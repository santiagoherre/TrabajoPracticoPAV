using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.DAO
{
    public class AD_Tipos
    {
        private static string cadConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];

        public static DataTable ObtenerElementos(string tabla)
        {
            SqlConnection cn = new SqlConnection(cadConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT* FROM " + tabla;

                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@tabla", tabla);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        internal static void AgregarTipo(string nombre, string descripcion, string tabla)
        {
            SqlConnection cn = new SqlConnection(cadConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO " + tabla + " (nombre, descripcion) VALUES (@nombre, @descripcion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@tipo", descripcion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cn.Close();
            }
        }

        internal static void AgregarTipo(string nombre, string tabla)
        {
            SqlConnection cn = new SqlConnection(cadConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO " + tabla + " (nombre) VALUES (@nombre)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
