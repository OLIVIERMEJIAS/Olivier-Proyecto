using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class EDetalleHorario
    {
        private byte HorarioId { get; set; }
        private string Seccion { get; set; }
        private EProfesor Profesor { get; set; }
        private EAula Aula { get; set; }
        private char Dia { get; set; }
        private DateTime HoraInicio { get; set; }
        private DateTime HoraFin { get; set; }

        public EDetalleHorario()
        {
            HorarioId = 0;
            Seccion = "";
            Profesor = new EProfesor();
            Aula = new EAula();
            Dia = ' ';
            HoraInicio = new DateTime();
            HoraFin = new DateTime();
        }

        public EDetalleHorario(byte horarId, string sec,
            EProfesor prof, EAula aul, char diaSem,
            DateTime horI, DateTime horF)
        {
            HorarioId = horarId;
            Seccion = sec;
            Profesor = prof;
            Aula = aul;
            Dia = diaSem;
            HoraInicio = horI;
            HoraFin = horF;
        }
    }
}
