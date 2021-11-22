using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EEstudiante : EPersona
    {
        public string Carnet { get; set; }
        public string Seccion { get; set; }
        public int Id { get; set; }
        public EEstudiante() : base()
        {
            Carnet = "";
            Seccion = "";
            Id = 0;
        }
    }

    
}
