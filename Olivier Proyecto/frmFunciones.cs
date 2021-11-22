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
        LNEstudiante lne = new LNEstudiante(Config.getCadConexion);
        LNAsistencia lna = new LNAsistencia(Config.getCadConexion);
        LNMateria lnm = new LNMateria(Config.getCadConexion);
        EEstudiante est;
        int materiaId;
        int estudianteId;
        int fila = 0;
        bool guardar = true;
        bool listar = false;
        public frmFunciones()
        {
            InitializeComponent();
        }

        private void btnBuscarCedCalif_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAsis_Click(object sender, EventArgs e)
        {
            listar = false;
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
                txtMateria.Text = lnm.accederANombre(EGlobal.profesorId).Nombre;
                materiaId = lnm.accederANombre(EGlobal.profesorId).MateriaId;
                datos = lna.listarPorEstudiante(est.Id,materiaId);
                dgvAsistencias.DataSource = datos;
                dgvAsistencias.Columns[0].HeaderText = "EstudianteID";
                dgvAsistencias.Columns[1].HeaderText = "MateriaID";
                dgvAsistencias.Columns[2].HeaderText = "Fecha de Registro";
                dgvAsistencias.Columns[3].HeaderText = "Estado";
                
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
                        guardar = true;
                        MessageBox.Show("Asistencia agregada con éxito");
                        btnBuscarAsis_Click(sender, e);
                    }
                    else
                        MessageBox.Show("No fue posible asignar la asistencia");
                }
                catch (Exception ex)
                {
                    guardar = true;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                bool result;

                string fech = DateTime.Parse(dgvAsistencias[2, fila].Value.ToString()).ToString("yyyy-MM-dd");
                EAsistencia asist = new EAsistencia(int.Parse(dgvAsistencias[0,fila].Value.ToString()),
                    int.Parse(dgvAsistencias[1, fila].Value.ToString()), fech,
                        cmbEstadoAsis.Text);
                try
                {
                    result = lna.actualizarAsistencia(asist);
                    if (result)
                    {
                        MessageBox.Show("Asistencia actualizada con éxito");
                        if (!listar)
                        {
                            btnBuscarAsis_Click(sender, e);
                        }else
                        {
                            btnListarAsis_Click(sender, e);
                        }
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
            if (!guardar)
            {
                bool result;

                string fech = DateTime.Parse(dgvAsistencias[2, fila].Value.ToString()).ToString("yyyy-MM-dd");
                EAsistencia asist = new EAsistencia(int.Parse(dgvAsistencias[0, fila].Value.ToString()),
                    int.Parse(dgvAsistencias[1, fila].Value.ToString()), fech,
                        dgvAsistencias[3, fila].Value.ToString());
                try
                {
                    result = lna.eliminarAsistencia(asist);
                    if (result)
                    {
                        MessageBox.Show("Asistencia eliminada con éxito");
                        if (!listar)
                        {
                            btnBuscarAsis_Click(sender, e);
                        }
                        else
                        {
                            btnListarAsis_Click(sender, e);
                        }
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

        private void btnListarAsis_Click(object sender, EventArgs e)
        {
            listar = true;
            try
            {
                DataTable datos;
                datos = lna.listarPorSeccion(cmbSeccionAsis.Text);
                dgvAsistencias.DataSource = datos;
                dgvAsistencias.Columns[0].HeaderText = "EstudianteID";
                dgvAsistencias.Columns[1].HeaderText = "MateriaID";
                dgvAsistencias.Columns[2].HeaderText = "Fecha de Registro";
                dgvAsistencias.Columns[3].HeaderText = "Estado";
                
               
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
