using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ECalificacion
    {
        public int EstudianteID { get; set; }
        public int MateriaID { get; set; }
        public string FechaIngreso { get; set; }
        public string Estado { get; set; }
        public decimal Calificacion { get; set; }
        public int TrimestreID { get; set; }

        public ECalificacion()
        {
            EstudianteID = 0;
            MateriaID = 0;
            FechaIngreso = "";
            Estado = "";
            Calificacion = 0;
            TrimestreID = 0;
        }

        public ECalificacion(int estu,
             int mat, decimal calif, string estad
             , int trim)
        {
            EstudianteID = estu;
            MateriaID = mat;
            Estado = estad;
            Calificacion = calif;
            TrimestreID = trim;
        }

        public ECalificacion(int estu,
            int mat, decimal calif,string fech,string estad
            ,int trim)
        {
            EstudianteID = estu;
            MateriaID = mat;
            Estado = estad;
            FechaIngreso = fech;
            Calificacion = calif;
            TrimestreID = trim;
        }
    }
}
