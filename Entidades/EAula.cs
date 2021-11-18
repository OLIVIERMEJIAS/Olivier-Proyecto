using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class EAula
    {
        private byte AulaId { get; set; }
        private string Nombre { get; set; }
        private bool Laboratorio { get; set; }

        public EAula()
        {
            AulaId = 0;
            Nombre = "";
            Laboratorio = false;
        }

        public EAula(byte aulId, string nom, bool lab)
        {
            AulaId = aulId;
            Nombre = nom;
            Laboratorio = lab;
        }
    }
}
