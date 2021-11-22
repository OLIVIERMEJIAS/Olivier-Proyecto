using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Collections;

namespace LogicaNegocio
{
    public class LNDetalleHorario
    {
        private string CadCadena { get; set; }

        public LNDetalleHorario()
        {
            CadCadena = "";
        }

        public LNDetalleHorario(string cad)
        {
            CadCadena = cad;
        }

        public void elegirProfesor(ArrayList detL, byte horId, byte profId, string horaI)
        {
            foreach(EDetalleHorario det in detL)
            {
                if(det.HorarioId == horId)
                {

                }
            }
        }

        public ArrayList generarHorarios()
        {
            byte[] libresXGrupo = new byte[13];
            byte[] horariosId = new byte[13] { 1, 2 , 3 ,4 , 5 , 6 , 7 , 8, 9 , 10, 11, 12, 13};
            byte horId = 0;
            char dia = 'L';
            byte profe = 0;
            byte aul = 0;
            string[] horasInicio = new string[5] { "07:20", "09:00", "10:40", "13:00", "14:40" };
            string[] horasFin = new string[5] { "08:40", "10:20", "12:00", "14:20", "16:00" };
            ArrayList detalles = new ArrayList();
            ArrayList detallesL = new ArrayList();
            ArrayList detallesK = new ArrayList();
            ArrayList detallesM = new ArrayList();
            ArrayList detallesJ = new ArrayList();
            ArrayList detallesV = new ArrayList();
            


            EDetalleHorario det = new EDetalleHorario(horId, profe, aul, dia, horasInicio[0], horasFin[0]);
            



            return detalles;
        }

    }
}
