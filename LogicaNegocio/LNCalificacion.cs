using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class LNCalificacion
    {
        public string CadConexion { get; set; }

        public LNCalificacion()
        {
            CadConexion = "";
        }

        public LNCalificacion(string cad)
        {
            CadConexion = cad;
        }

        public DataTable listarPorSeccion(string sec)
        {
            try
            {
                ADCalificacion adc = new ADCalificacion(CadConexion);
                return adc.listarPorSeccion(sec);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable listarPorEstudiante(int estId, int matId)
        {
            ADCalificacion adc = new ADCalificacion(CadConexion);
            try
            {
                return adc.listarPorEstudiante(estId, matId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool agregarCalificacion(ECalificacion calif)
        {
            ADCalificacion adc = new ADCalificacion(CadConexion);
            try
            {
                return adc.agregarCalificacion(calif);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool actualizarCalificacion(ECalificacion calif)
        {
            ADCalificacion adc = new ADCalificacion(CadConexion);
            try
            {
                return adc.actualizarCalificacion(calif);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool eliminarCalificacion(ECalificacion calif)
        {
            ADCalificacion adc = new ADCalificacion(CadConexion);
            try
            {
                return adc.eliminarCalificacion(calif);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
