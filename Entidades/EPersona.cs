using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    abstract class EPersona
    {
        protected ushort PersonaId { get; set; }
        protected int NumIdentificacion { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido1 { get; set; }
        protected string Apellido2 { get; set; }
        protected char Genero { get; set; }
        protected string Email { get; set; }
        protected DateTime FechaIngreso { get; set; }
        protected DateTime FechaNacimiento { get; set; }
        protected ushort Distrito { get; set; }
        protected string DirExact { get; set; }
        protected bool Activo { get; set; }
        protected bool Borrado { get; set; }

        public EPersona()
        {
            PersonaId = 0;
            NumIdentificacion = 0;
            Nombre = "";
            Apellido1 = "";
            Apellido2 = "";
            Genero = ' ';
            Email = "";
            FechaIngreso = new DateTime();
            FechaNacimiento = new DateTime();
            Distrito = 0;
            DirExact = "";
            Activo = true;
            Borrado = false;
        }

        public EPersona(ushort id, int ident, string nom,
            string ape1, string ape2, char gen, string email,
            DateTime fechIng, DateTime fechNac, ushort dist,
            string dirExact, bool act, bool bor)
        {
            PersonaId = id;
            NumIdentificacion = ident;
            Nombre = nom;
            Apellido1 = ape1;
            Apellido2 = ape2;
            Genero = gen;
            Email = email;
            FechaIngreso = fechIng;
            FechaNacimiento = fechNac;
            Distrito = dist;
            DirExact = dirExact;
            Activo = act;
            Borrado = bor;
        }

        public abstract void listar();





    }
}
