using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class ECalificacion
    {
        private EEstudiante Estudiante { get; set; }
        private EMateria Materia { get; set; }

        private DateTime FechaIngreso { get; set; }
        private string Estado { get; set; }
        private decimal Calificacion { get; set; }
        private ETrimestre Trimestre { get; set; }

        public ECalificacion()
        {
            Estudiante = new EEstudiante();
            Materia = new EMateria();
            FechaIngreso = new DateTime();
            Estado = "";
            Calificacion = 0;
            Trimestre = new ETrimestre();
        }

        public ECalificacion(EEstudiante estu,
            EMateria mat, DateTime fechaIng, string estad,
            decimal calif, ETrimestre trim)
        {
            Estudiante = estu;
            Materia = mat;
            FechaIngreso = fechaIng;
            Estado = estad;
            Calificacion = calif;
            Trimestre = trim;
        }
    }
}
