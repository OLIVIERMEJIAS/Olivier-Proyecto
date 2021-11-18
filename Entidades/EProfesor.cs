using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class EProfesor : EPersona
    {
        private char Puesto { get; set; }
        
        private string NombreUsuario { get; set; }
        private string Contrasena { get; set; }
        private EMateria Materia { set; get; }

        public EProfesor()
        {
            Puesto = ' ';
            NombreUsuario = "";
            Contrasena = "";
            Materia = new EMateria();
        }

        public EProfesor(char puest, string nomU,
            string contra, EMateria mat)
        {
            Puesto = puest;
            NombreUsuario = nomU;
            Contrasena = contra;
            Materia = mat;
        }


        public override void listar()
        {
            
        }
    }
}
