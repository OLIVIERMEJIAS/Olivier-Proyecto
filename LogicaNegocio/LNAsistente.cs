using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class LNAsistente
    {
        public string CadConexion { get; set; }

        public LNAsistente()
        {
            CadConexion = "";
        }

        public LNAsistente(string cad)
        {
            CadConexion = cad;
        }

        public bool accesoUsuario(EAsistente asis)
        {
            bool result = false;
            ADAsistente ada = new ADAsistente(CadConexion);
            try
            {
                result = ada.accesoUsuario(asis);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }
    }
}
