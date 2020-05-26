using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.ElementosElectricos
{
    public class AD_Electricidad
    {
        private static string cadConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
        
        public static DataTable ObtenerElementos()
        {
            SqlConnection cn = new SqlConnection(cadConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT e.id as ID, e.nombre, te.nombre AS Tipo FROM ElementosElectricidad e, TiposElemElectricidad te WHERE e.idTipoElemElectricidad=te.id";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
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

        public static void AgregarElementoElectrico(ElementoElectrico ee)
        {
            SqlConnection cn = new SqlConnection(cadConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO ElementosElectricidad (nombre, idTipoElemElectricidad) VALUES (@nombre, @tipo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", ee.Nombre);
                cmd.Parameters.AddWithValue("@tipo", ee.Tipo);
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

        public static DataTable ObtenerTipos()
        {
            SqlConnection cn = new SqlConnection(cadConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TiposELemElectricidad";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception )
            {
                throw;
            } 
            finally
            {
                cn.Close();
            }
        }

        internal static ElementoElectrico buscarElemElectrico(string id)
        {
            SqlConnection cn = new SqlConnection(cadConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT id, nombre, idTipoElemElectricidad FROM ElementosElectricidad where id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    int idBD = Int32.Parse(dr["id"].ToString());
                    string nombre = dr["nombre"].ToString();
                    int tipo = int.Parse(dr["idTipoElemElectricidad"].ToString());
                    return new ElementoElectrico(idBD, nombre, tipo);
                }
                else
                {
                    ElementoElectrico ee = null;
                    return ee;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ActualizarElementoElectrico(ElementoElectrico ee)
        {
            SqlConnection cn = new SqlConnection(cadConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE ElementosElectricidad SET nombre=@nom, idTipoElemElectricidad=@tipo WHERE id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", ee.Id);
                cmd.Parameters.AddWithValue("@nom", ee.Nombre);
                cmd.Parameters.AddWithValue("@tipo", ee.Tipo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void EliminarElementoElectrico(ElementoElectrico ee)
        {
            SqlConnection cn = new SqlConnection(cadConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM ElementosElectricidad WHERE nombre=@nom and idTipoElemElectricidad=@tipo and id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", ee.Id);
                cmd.Parameters.AddWithValue("@nom", ee.Nombre);
                cmd.Parameters.AddWithValue("@tipo", ee.Tipo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
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
    }
}
