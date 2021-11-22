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

        public DataTable listarPorSeccion(string sec)
        {

            DataTable datos = new DataTable();
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Select a.estudianteId, a.materiaId, a.fecha, a.estado from Asistencias a" +
            " inner join Estudiantes e On  a.estudianteId = e.estudianteId Where";
            sentencia = $"{sentencia} e.seccion = '{sec}'";
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

        public DataTable listarPorEstudiante(int estId,int matId)
        {

            DataTable datos = new DataTable();
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Select estudianteId, materiaId, fecha, estado from Asistencias" +
                " where estudianteId = ";
            sentencia = $"{sentencia}{estId} and materiaId = {matId}";
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

        public bool agregarAsistencia(EAsistencia asist)
        {

            bool result = false;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Insert Into Asistencias Values(@estId,@matId,getdate(),@estado)";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@estId", asist.EstudianteId);
            comando.Parameters.AddWithValue("@matId", asist.MateriaId);
            comando.Parameters.AddWithValue("@estado", asist.Estado);

            try
            {
                conexion.Open();
                if (comando.ExecuteNonQuery() != 0)
                {
                    result = true;
                }
                
            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se pudo realizar conexión de datos, o la asistencia del día de hoy ya existe");
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return result;
        }

        public bool actualizarAsistencia(EAsistencia asist)
        {

            bool result = false;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Update Asistencias Set estado = @estado " +
                "Where estudianteId = @estId and materiaId = @matId and fecha = @fecha";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@estId", asist.EstudianteId);
            comando.Parameters.AddWithValue("@matId", asist.MateriaId);
            comando.Parameters.AddWithValue("@estado", asist.Estado);
            comando.Parameters.AddWithValue("@fecha", asist.FechaHora);

            try
            {
                conexion.Open();
                if (comando.ExecuteNonQuery() != 0)
                {
                    result = true;
                }

            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se pudo realizar conexión de datos");
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return result;
        }

        public bool eliminarAsistencia(EAsistencia asist)
        {

            bool result = false;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Delete From Asistencias " +
                "Where estudianteId = @estId and materiaId = @matId and fecha = @fecha";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@estId", asist.EstudianteId);
            comando.Parameters.AddWithValue("@matId", asist.MateriaId);
            comando.Parameters.AddWithValue("@estado", asist.Estado);
            comando.Parameters.AddWithValue("@fecha", asist.FechaHora);
conexion.Open();
                if (comando.ExecuteNonQuery() != 0)
                {
                    result = true;
                }
            try
            {
                

            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se pudo realizar conexión de datos");
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return result;
        }
    }
}
