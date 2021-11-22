using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace Olivier_Proyecto
{
    public partial class frmLogIn : Form
    {
        static string CadConexion = "Server = DESKTOP-0MSC0IG;Database=ColegioTecnico;User Id = sa; Password=Progra;";
        LNDirector lnd = new LNDirector(CadConexion);
        LNProfesor lnp = new LNProfesor(CadConexion);
        LNAsistente lna = new LNAsistente(CadConexion);
        frmFunciones funciones = new frmFunciones();
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            EGlobal.TipoUsuario = cmbEleccion.Text;
            bool result = false;
            int result2;
            if(cmbEleccion.Text == "Director")
            {
                EDirector dir = new EDirector(txtNombreUsuario.Text, txtContrasena.Text, 'D');
                result = lnd.accesoUsuario(dir);
            }
            else if (cmbEleccion.Text == "Asistente")
            {
                EAsistente asis = new EAsistente(txtNombreUsuario.Text, txtContrasena.Text, 'A');
                result = lna.accesoUsuario(asis);
            }
            else
            {
                EProfesor prof = new EProfesor('P',txtNombreUsuario.Text, txtContrasena.Text);
                result2 = lnp.accesoUsuario(prof);
                if(result2 != -1)
                {
                    result = true;
                    EGlobal.profesorId = result2;
                }
           
            }
            if (result)
            {
                MessageBox.Show("Acceso Concedido, Bienvenido(a) al sistema del Colegio");
                frmFunciones funciones = new frmFunciones();
                funciones.Show();
                
            }
            else
                MessageBox.Show("Acceso denegado, inténtelo de nuevo");
        }
    }
}
