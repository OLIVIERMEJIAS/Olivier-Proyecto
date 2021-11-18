using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class EAsistencia
    {
        private EEstudiante estudiante { get; set; }
        private EMateria materia { get; set; }
        private DateTime FechaHora { get; set; }
        private string Estado { get; set; }

        public EAsistencia()
        {
            estudiante = new EEstudiante();
            materia = new EMateria();
            FechaHora = new DateTime();
            Estado = "";
        }

        public EAsistencia(EEstudiante estu,
            EMateria mat, DateTime fechHor, string estad)
        {
            estudiante = estu;
            materia = mat;
            FechaHora = fechHor;
            Estado = estad;
        }
    }
}
