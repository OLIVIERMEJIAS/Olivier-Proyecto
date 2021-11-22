using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class EAsistencia
    {
        public int EstudianteId { get; set; }
        public int MateriaId { get; set; }
        public string FechaHora { get; set; }
        public string Estado { get; set; }

        public EAsistencia()
        {
            EstudianteId = 0;
            MateriaId = 0;
            FechaHora = "";
            Estado = "";
        }

        public EAsistencia(int estu,
            int mat, string estad)
        {
            EstudianteId = estu;
            MateriaId = mat;
            FechaHora = "";
            Estado = estad;
        }

        public EAsistencia(int estu,
            int mat, string fech, string estad)
        {
            EstudianteId = estu;
            MateriaId = mat;
            FechaHora = fech;
            Estado = estad;
        }
    }
}
