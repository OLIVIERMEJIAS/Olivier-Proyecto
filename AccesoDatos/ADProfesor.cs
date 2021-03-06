using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class ADProfesor
    {
        public string CadConexion { get; set; }

        public ADProfesor()
        {
            CadConexion = "";
        }

        public ADProfesor(string cad)
        {
            CadConexion = cad;
        }
        public int accesoUsuario(EProfesor prof)
        {
            int result = -1;
            SqlDataReader reader;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Select empleadoId from Empleados where puesto =" +
                " @puesto and contrasena = @contrasena and nombreUsuario = @nombreU";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@puesto", prof.Puesto);
            comando.Parameters.AddWithValue("@contrasena", prof.Contrasena);
            comando.Parameters.AddWithValue("@nombreU", prof.NombreUsuario);
            
            try
            {
                conexion.Open();
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetInt16(0);
                }
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se pudo realizar conexión de acceso");
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
