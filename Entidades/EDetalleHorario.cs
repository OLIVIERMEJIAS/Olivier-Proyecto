using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EDetalleHorario
    {
        private byte HorarioId { get; set; }
        private ushort ProfesorID { get; set; }
        private byte AulaID { get; set; }
        private char Dia { get; set; }
        private DateTime HoraInicio { get; set; }
        private DateTime HoraFin { get; set; }

        public EDetalleHorario()
        {
            HorarioId = 0;
            ProfesorID = 0;
            AulaID = 0;
            Dia = ' ';
            HoraInicio = new DateTime();
            HoraFin = new DateTime();
        }

        public EDetalleHorario(byte horarId,
            byte prof, byte aul, char diaSem,
            DateTime horI, DateTime horF)
        {
            HorarioId = horarId;
            ProfesorID = prof;
            AulaID = aul;
            Dia = diaSem;
            HoraInicio = horI;
            HoraFin = horF;
        }
    }
}
