using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class EMateria
    {
        private byte MateriaId { get; set; }
        private string Nombre { get; set; }
        private byte NumLeccionesSeccion { get; set; }
        private ArrayList Profesores { get; set; }
        private bool Borrado { get; set; }

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
