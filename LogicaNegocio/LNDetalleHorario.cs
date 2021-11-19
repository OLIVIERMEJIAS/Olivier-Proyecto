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

        public ArrayList generarHorarios(DateTime horaInic)
        {
            byte[] libresXGrupo = new byte[13];
            byte horId = 1;
            char dia = 'L';
            byte profe = 0;
            byte aul = 0;
            DateTime horaFin = new DateTime();
            ArrayList detalles = new ArrayList();

            EDetalleHorario det = new EDetalleHorario(horId, profe, aul, dia, horaInic, horaFin);
            



            return detalles;
        }

    }
}
