using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
   public class ADEstudiante
    {
        public string CadConexion { get; set; }

        public ADEstudiante()
        {
            CadConexion = "";
        }

        public ADEstudiante(string cad)
        {
            CadConexion = cad;
        }

        public EEstudiante existeCedUsuario(string ced)
        {
           
            long cedula = long.Parse(ced);
            SqlDataReader reader;
            EEstudiante est = new EEstudiante();
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Select nombre,apellido1,apellido2,estudianteId from Estudiantes where " +
                "numIdentificacion = @num";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@num", cedula);
            
            try
            {
                conexion.Open();
                reader = comando.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    est.Nombre = reader.GetString(0);
                    est.Apellido1 = reader.GetString(1);
                    est.Apellido2 = reader.GetString(2);
                    est.Id = reader.GetInt16(3);
                }
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se pudo realizar búsqueda de estudiante");
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }



            return est;
        }
    }
}
