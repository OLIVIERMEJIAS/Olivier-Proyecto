using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class ADAsistencia
    {
        public string CadConexion { get; set; }

        public ADAsistencia()
        {
            CadConexion = "";
        }

        public ADAsistencia(string cad)
        {
            CadConexion = cad;
        }

        public DataTable listarPorEstudiante(int estId)
        {

            DataTable datos = new DataTable();
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Select estudianteId, materiaId, fechaHora, estado from Asistencias" +
                " where estudianteId = ";
            sentencia = $"{sentencia}{estId}";
            SqlDataAdapter adaptador = new SqlDataAdapter(sentencia, conexion);
         
            try
            {
                adaptador.Fill(datos);
                adaptador.Dispose();
            }
            catch (Exception)
            {
                adaptador.Dispose();
                throw new Exception("No se pudo realizar conexión de datos");
            }
 
            return datos;
        }
    }
}
