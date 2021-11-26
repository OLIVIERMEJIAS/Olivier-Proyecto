using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace AccesoDatos
{
    public class ADCalificacion
    {
        public string CadConexion { get; set; }

        public ADCalificacion()
        {
            CadConexion = "";
        }

        public ADCalificacion(string cad)
        {
            CadConexion = cad;
        }

        public DataTable listarPorSeccion(string sec)
        {

            DataTable datos = new DataTable();
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Select c.estudianteId, c.materiaId," +
                " c.calificacion, c.fechaIngreso, c.estado, c.trimestreId " +
                "from Calificaciones c inner join Estudiantes e On c.estudianteId = e.estudianteId Where";
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

        public DataTable listarPorEstudiante(int estId, int matId)
        {

            DataTable datos = new DataTable();
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Select estudianteId, materiaId," +
                " calificacion, fechaIngreso, estado, trimestreId " +
                "from Calificaciones where estudianteId = ";
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

        public bool agregarCalificacion(ECalificacion calif)
        {

            bool result = false;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Insert Into Calificaciones Values(@estId,@matId,getdate(),@calif,@estado,@trimId)";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@estId", calif.EstudianteID);
            comando.Parameters.AddWithValue("@matId", calif.MateriaID);
            comando.Parameters.AddWithValue("@calif", calif.Calificacion);
            comando.Parameters.AddWithValue("@estado", calif.Estado);
            comando.Parameters.AddWithValue("@trimId", calif.TrimestreID);

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
                throw new Exception("No se pudo realizar conexión de datos, o la calificación del día de hoy ya existe");
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return result;
        }

        public bool actualizarCalificacion(ECalificacion calif)
        {

            bool result = false;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Update Calificaciones Set estado = @estado, calificacion = @calif " +
                "Where estudianteId = @estId and materiaId = @matId and fechaIngreso = @fecha";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@estId", calif.EstudianteID);
            comando.Parameters.AddWithValue("@matId", calif.MateriaID);
            comando.Parameters.AddWithValue("@estado", calif.Estado);
            comando.Parameters.AddWithValue("@fecha", calif.FechaIngreso);
            comando.Parameters.AddWithValue("@calif", calif.Calificacion);
           
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

        public bool eliminarCalificacion(ECalificacion calif)
        {

            bool result = false;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Delete From Calificaciones " +
                "Where estudianteId = @estId and materiaId = @matId and fechaIngreso = @fecha";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@estId", calif.EstudianteID);
            comando.Parameters.AddWithValue("@matId", calif.MateriaID);
            comando.Parameters.AddWithValue("@estado", calif.Estado);
            comando.Parameters.AddWithValue("@fecha", calif.FechaIngreso);
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
