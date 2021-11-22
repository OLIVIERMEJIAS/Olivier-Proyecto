using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EAsistente :  EPersona
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public char Puesto { get; set; }

        public EAsistente():base()
        {
            NombreUsuario = "";
            Contrasena = "";
            Puesto = ' ';
        }

        public EAsistente(string nom, string con, char puest):base()
        {
            NombreUsuario = nom;
            Contrasena = con;
            Puesto = puest;
        }
        public  void listar()
        {

        }
    }
}
