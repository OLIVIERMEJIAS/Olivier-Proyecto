using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class ETrimestre
    {
        private byte TrimestreId { get; set; }
        private string Numero { get; set; }
        private DateTime FechaInicio { get; set; }
        private DateTime FechaFin { get; set; }

        public ETrimestre()
        {
            TrimestreId = 0;
            Numero = "";
            FechaInicio = new DateTime();
            FechaFin = new DateTime();
        }

        public ETrimestre(byte trim, string num,
            DateTime fechaI, DateTime fechaFi)
        {
            TrimestreId = trim;
            Numero = num;
            FechaInicio = fechaI;
            FechaFin = fechaFi;
        }
    }
}
