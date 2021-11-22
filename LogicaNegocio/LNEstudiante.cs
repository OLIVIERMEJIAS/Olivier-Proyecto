using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
   public class LNEstudiante
    {
        public string CadConexion { get; set; }

        public LNEstudiante()
        {
            CadConexion = "";
        }

        public LNEstudiante(string cad)
        {
            CadConexion = cad;
        }
        public EEstudiante existeCedUsuario(string ced)
        {
            ADEstudiante ade = new ADEstudiante(CadConexion);
            try
            {
                return ade.existeCedUsuario(ced);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
