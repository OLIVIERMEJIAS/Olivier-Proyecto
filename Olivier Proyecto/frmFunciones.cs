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
            }
        }
    }
}
