using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class EMateria
    {
        public byte MateriaId { get; set; }
        public string Nombre { get; set; }
        public byte NumLeccionesSeccion { get; set; }
        public ArrayList Profesores { get; set; }
        public bool Borrado { get; set; }

        public EMateria()
        {
            MateriaId = 0;
            Nombre = "";
            NumLeccionesSeccion = 0;
            Profesores = new ArrayList();
            Borrado = false;
        }
        public EMateria(byte matId, string nom, byte num,
            bool borrad)
        {
            MateriaId = matId;
            Nombre = nom;
            NumLeccionesSeccion = num;
            Profesores = new ArrayList();
            Borrado = borrad;
        }
    }
}
