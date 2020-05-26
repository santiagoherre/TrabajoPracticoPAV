using Juventus.DOMINIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.ElementosCocina
{
    class AD_ElemCocina
    {
        private static string connectionString = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];


        public static DataTable ObtenerTipoElemCocina()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select id, nombre FROM TiposElemCocina";

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
            finally { cn.Close(); }

        }

        public static DataTable ObtenerElementosCocina()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT e.id as id, e.nombre as nombre, e.descripcion as descripcion, t.nombre as tipoElemento FROM ElementosCocina e JOIN TiposElemCocina t ON t.id = e.idTipoElemCocina";

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
            finally { cn.Close(); }

        }

        public static bool insertarElementosCocina(ElemCocina elem)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO ElementosCocina VALUES (@nombre, @descripcion, @idTipoElemento)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", elem.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", elem.Descripcion);
                cmd.Parameters.AddWithValue("@idTipoElemento", elem.IdTipoElemento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;


            }
            catch (Exception)
            {

                throw;
            }
            finally { cn.Close(); }
            return resultado;

        }

        public static bool modificarElemento(ElemCocina elem)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE ElementosCocina SET nombre = @nombre, descripcion = @descripcion, idTipoElemCocina = @idTipoElemento WHERE id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", elem.Id);
                cmd.Parameters.AddWithValue("@nombre", elem.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", elem.Descripcion);
                cmd.Parameters.AddWithValue("@idTipoElemento", elem.IdTipoElemento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;


            }
            catch (Exception)
            {

                throw;
            }
            finally { cn.Close(); }
            return resultado;
        }

        public static bool validarExistente(int id)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select id FROM ElementosCocina WHERE id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count != 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cn.Close(); }

        }

        public static bool eliminarElemento(ElemCocina elem)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM ElementosCocina WHERE id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", elem.Id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;


            }
            catch (Exception)
            {

                throw;
            }
            finally { cn.Close(); }
            return resultado;
        }

        public static ElemCocina buscarElemCocina(int id)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select id, nombre, descripcion, idTipoElemCocina  FROM ElementosCocina WHERE id=@id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                ElemCocina elem = new ElemCocina();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    int var = 0;
                    Int32.TryParse(dr["id"].ToString(), out var);
                    elem.Id = var;
                    elem.Nombre = dr["nombre"].ToString();
                    elem.Descripcion = dr["descripcion"].ToString();
                    elem.IdTipoElemento = int.Parse(dr["idTipoElemCocina"].ToString());
                }

                return elem;
            }
            catch (Exception) 
            {
                throw;
            }
            finally { cn.Close(); }

        }


    }
}
