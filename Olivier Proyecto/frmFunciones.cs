using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Entidades;

namespace Olivier_Proyecto
{
    public partial class frmFunciones : Form
    {
        static string CadConexion = "Server = DESKTOP-0MSC0IG;Database=ColegioTecnico;User Id = sa; Password=Progra;";
        LNEstudiante lne = new LNEstudiante(CadConexion);
        LNAsistencia lna = new LNAsistencia(CadConexion);
        LNMateria lnm = new LNMateria(CadConexion);
        EEstudiante est;
        int materiaId;
        int estudianteId;
        int fila = 0;
        bool guardar = true;
        public frmFunciones()
        {
            InitializeComponent();
        }

        private void btnBuscarCedCalif_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAsis_Click(object sender, EventArgs e)
        {
            est = lne.existeCedUsuario(txtCedAsis.Text);
            estudianteId = est.Id;
            if(est.Nombre == "")
            {
                MessageBox.Show("No se encontró este número de cédula");
            }
            else
            {
                txtNomAsis.Text = $"{est.Nombre} {est.Apellido1} {est.Apellido2}";
                DataTable datos;
                datos = lna.listarPorEstudiante(est.Id);
                dgvAsistencias.DataSource = datos;
                dgvAsistencias.Columns[0].HeaderText = "EstudianteID";
                dgvAsistencias.Columns[1].HeaderText = "MateriaID";
                dgvAsistencias.Columns[2].HeaderText = "Fecha de Registro";
                dgvAsistencias.Columns[3].HeaderText = "Estado";
                txtMateria.Text = lnm.accederANombre(EGlobal.profesorId).Nombre;
                materiaId = lnm.accederANombre(EGlobal.profesorId).MateriaId;
                fila = 0;
            }
        }

        private void btnGuardarAsis_Click(object sender, EventArgs e)
        {
            if (guardar)
            {
                bool result;
                EAsistencia asist = new EAsistencia(estudianteId, materiaId, cmbEstadoAsis.Text);
                try
                {
                    result = lna.agregarAsistencia(asist);
                    if (result)
                    {
                        MessageBox.Show("Asistencia agregada con éxito");
                        btnBuscarAsis_Click(sender, e);
                    }
                    else
                        MessageBox.Show("No fue posible asignar la asistencia");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                bool result;
                

                EAsistencia asist = new EAsistencia(int.Parse(dgvAsistencias[0,fila].Value.ToString()),
                    int.Parse(dgvAsistencias[1, fila].Value.ToString()), dgvAsistencias[2, fila].Value.ToString(),
                        dgvAsistencias[3, fila].Value.ToString());
                try
                {
                    result = lna.actualizarAsistencia(asist);
                    if (result)
                    {
                        MessageBox.Show("Asistencia actualizada con éxito");
                        btnBuscarAsis_Click(sender, e);
                        guardar = true;
                    }
                    else
                        MessageBox.Show("No fue posible actualizar la asistencia");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    guardar = true;
                }
            }
            
        }

        private void dgvAsistencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAsistencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgvAsistencias.CurrentRow.Index;
            guardar = false;
            MessageBox.Show("Se ha abierto el espacio para modificar el estado de la aistencia y dar guardar," +
                "o solo dar en eliminar para deshacer la asistencia");

        }

        private void btnElimAsis_Click(object sender, EventArgs e)
        {
            bool result;


            EAsistencia asist = new EAsistencia(int.Parse(dgvAsistencias[0, fila].Value.ToString()),
                int.Parse(dgvAsistencias[1, fila].Value.ToString()), dgvAsistencias[2, fila].Value.ToString(),
                    dgvAsistencias[3, fila].Value.ToString());
            try
            {
                result = lna.eliminarAsistencia(asist);
                if (result)
                {
                    MessageBox.Show("Asistencia eliminada con éxito");
                    btnBuscarAsis_Click(sender, e);
                    guardar = true;
                }
                else
                    MessageBox.Show("No fue posible actualizar la asistencia");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                guardar = true;
            }
        }
    }
}
