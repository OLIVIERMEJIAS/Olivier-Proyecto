using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;
namespace LogicaNegocio
{
    public class LNProfesor
    {
        public string CadConexion { get; set; }

        public LNProfesor()
        {
            CadConexion = "";
        }

        public LNProfesor(string cad)
        {
            CadConexion = cad;
        }

        public int accesoUsuario(EProfesor prof)
        {
            int result = -1;
            ADProfesor adp = new ADProfesor(CadConexion);
            try
            {
                result = adp.accesoUsuario(prof);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
    }
}
