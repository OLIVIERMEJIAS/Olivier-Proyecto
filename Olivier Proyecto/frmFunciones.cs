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
using System.Collections;

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
        #region Métodos Calificaciones
        private void btnBuscarCedCalif_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Métodos Asistencias


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
        #endregion

        #region Horario
        public ArrayList generarHorarios()
        {
            byte[] libresXGrupo = new byte[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            byte[] profesLecciones = new byte[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            byte[] horarioId = new byte[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            List<byte> lista = new List<byte>();
            char[] dias = new char[5] { 'L', 'K', 'M', 'J', 'V' };
            byte horId = 0;
            byte dia = 1;
            char diaSem = ' ';
            byte profe = 0;
            byte aul = 0;
            byte limLibres = 8;
            byte limLibres2 = 6;
            byte gruposLibres = 0;
            byte gruposLibresMax = 5;
            Random ran = new Random(0);
            int ranNum = 0;
            int indiceHoras = 0;
            string[] horasInicio = new string[5] { "07:20", "09:00", "10:40", "13:00", "14:40" };
            string[] horasFin = new string[5] { "08:40", "10:20", "12:00", "14:20", "16:00" };
            string horI = "";
            string horF = "";
            ArrayList detalles = new ArrayList();
            ArrayList detallesL = new ArrayList();
            ArrayList detallesK = new ArrayList();
            ArrayList detallesM = new ArrayList();
            ArrayList detallesJ = new ArrayList();
            ArrayList detallesV = new ArrayList();
            //ciclo que controla los días de la semana
            while (dia <= 5)
            {
                //asignación del día de la semana
                switch (dia)
                {
                    case 1:
                        diaSem = dias[0];
                        break;
                    case 2:
                        diaSem = dias[1];
                        break;
                    case 3:
                        diaSem = dias[2];
                        break;
                    case 4:
                        diaSem = dias[3];
                        break;
                    case 5:
                        diaSem = dias[4];
                        break;
                }
                while (indiceHoras <= 4)
                {
                    //llenar la lista de Id de horarios que representa a cada seccion en orden
                    //, en total hay 13 Ids de horario
                    foreach (byte item in horarioId)
                    {
                        lista.Add(item);
                    }

                    //esta evaluación se trata de que cuando los grupos más
                    //avanzados lleven la especialidad lo cual se llevará a
                    //cabo por dos secciones por día,
                    //en toda la mañana los días L,K,J,V, entonces
                    //como son en total 8 aulas generales y 13 grupos en total
                    //usualmente cuando todos reciben clases generales
                    //deben quedarse libres 5 grupos por cada dos lecciones,
                    //pero cuando haya dos grupos en especialidad solo deben quedarse
                    //libre 3 grupos, ya que dos aulas generales no serán ocupadas
                    //probablemente por los dos grupos de especialidad
                    if (dia == 1 || dia == 2 || dia == 4 || dia == 5)
                    {
                        if (horI == horasInicio[0] || horI == horasInicio[1] || horI == horasInicio[2])
                        { gruposLibresMax = 3; }
                    }
                    //se inpartirán en las tardes de L a J
                    //en cada par de lecciones a un grupo de
                    //niveles inferiores computación y a otro
                    //educación financiera, entonces en las
                    //lecciones después de almuerzo se darán
                    //estas materias a dos grupos, y en las
                    //últimas lecciones estas dos materias a otros dos grupos
                    if (dia >= 4 && (horI == horasInicio[3] || horI == horasInicio[4]))
                    {
                        gruposLibresMax = 3;
                    }
                    //esta condiciación tine el mismo propósito que
                    //la anterior para el día V,auque solo para
                    //las dos lecciones después de almuerzo, por que
                    //ya solo quedarían dos grupos faltantes en la
                    //semana de recibir educucación financiera y computación
                    if (dia == 5 && horI == horasInicio[3])
                    {
                        gruposLibresMax = 3;
                    }
                    //esta evaluación se trata de elegir al azar cada
                    //dos lecciones que grupos se quedan libres, basado
                    //en aletoriedad, pero también revisando el límite
                    //de pares de lecciones libres que pueden estar sin
                    //clase cada grupo, en base a si están en la mitad inferior de
                    //niveles o la superior y así deja en la lista solo quedan
                    //las secciones representadas por sus Ids de horario que
                    //que si van a recibir lecciones
                    while (gruposLibres != gruposLibresMax)
                    {
                        ranNum = ran.Next(0, lista.Count - 1);
                        if (horarioId[ranNum] <= 9)
                        {
                            if (libresXGrupo[ranNum] < limLibres)
                            {
                                lista.RemoveAt(ranNum);
                                libresXGrupo[ranNum]++;
                                gruposLibres++;
                            }
                        }
                        else
                        {
                            if (libresXGrupo[ranNum] < limLibres2)
                            {
                                lista.RemoveAt(ranNum);
                                libresXGrupo[ranNum]++;
                                gruposLibres++;
                            }
                        }
                    }

                    foreach (EDetalleHorario item in detallesL)
                    {
                        if (item.HoraInicio != horasInicio[0])
                            break;

                    }
                    switch (dia)
                    {
                        case 1:
                            EDetalleHorario detaH = new EDetalleHorario(horId, profe, aul, diaSem, horI, horF);
                            detallesL.Add(detaH);
                            break;
                        case 2:
                            EDetalleHorario detalH = new EDetalleHorario(horId, profe, aul, diaSem, horI, horF);
                            detallesK.Add(detalH);
                            break;
                        case 3:
                            EDetalleHorario detallH = new EDetalleHorario(horId, profe, aul, diaSem, horI, horF);
                            detallesM.Add(detallH);
                            break;
                        case 4:
                            EDetalleHorario detalleHor = new EDetalleHorario(horId, profe, aul, diaSem, horI, horF);
                            detallesJ.Add(detalleHor);
                            break;
                        case 5:
                            EDetalleHorario detalleH = new EDetalleHorario(horId, profe, aul, diaSem, horI, horF);
                            detallesV.Add(detalleH);
                            break;
                    }
                }
            }



            //verificar profe
            //ver materia
            //lecciones profe
            //lecciones grupo
            //time libre grupo




            foreach (EDetalleHorario item in detallesL)
                detalles.Add(item);
            foreach (EDetalleHorario item in detallesK)
                detalles.Add(item);
            foreach (EDetalleHorario item in detallesM)
                detalles.Add(item);
            foreach (EDetalleHorario item in detallesJ)
                detalles.Add(item);
            foreach (EDetalleHorario item in detallesV)
                detalles.Add(item);


            return detalles;
        }
        #endregion
    }
}
