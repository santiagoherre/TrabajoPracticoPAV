using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus
{
    class AD_Carpa
    {

        public static DataTable obtenerTiposCarpas()

        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM TiposCarpas";

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
            catch (Exception) { throw; }

            finally { cn.Close(); }
        }

        public static bool persistenciaCarpas(Carpa car)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Carpas (idTipoCarpa, cantidadCaños, cantidadDormitorios) VALUES (@idTipoCarpa, @cantidadCaños, @cantidadDormitorios)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idTipoCarpa", car.IdTipoCarpa);
                cmd.Parameters.AddWithValue("@cantidadCaños", car.CantCaños);
                cmd.Parameters.AddWithValue("@cantidadDormitorios", car.CantDormitorios);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception) { throw; }

            finally { cn.Close(); }

            return resultado;
        }

        public static DataTable obtenerListadoCarpas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.id, t.nombre as tipoCarpa, c.cantidadCaños, c.cantidadDormitorios FROM Carpas c JOIN TiposCarpas t ON t.id = c.idTipoCarpa";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception) { throw; }

            finally { cn.Close(); }
        }

        public static bool modificarCarpa(Carpa c)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Carpas SET idTipoCarpa = @idTipoCarpa, cantidadCaños = @cantidadCaños, cantidadDormitorios = @cantidadDormitorios WHERE id LIKE @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@idTipoCarpa", c.IdTipoCarpa);
                cmd.Parameters.AddWithValue("@cantidadCaños", c.CantCaños);
                cmd.Parameters.AddWithValue("@cantidadDormitorios", c.CantDormitorios);
                                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;

            }
            catch (Exception) { throw; }

            finally { cn.Close(); }

            return resultado;
        }

        public static Carpa buscarCarpa(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select id, idTipoCarpa, cantidadCaños, cantidadDormitorios  FROM Carpas WHERE id=@id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                Carpa carpa = new Carpa();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    int var = 0;
                    Int32.TryParse(dr["id"].ToString(), out var);
                    carpa.Id = var;
                    carpa.IdTipoCarpa = (int)dr["idTipoCarpa"];
                    carpa.CantCaños = (int) dr["cantidadCaños"];
                    carpa.CantDormitorios = (int)dr["cantidadDormitorios"];
                }

                return carpa;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }

        }

        public static bool eliminarCarpa(Carpa carpa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Carpas WHERE id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", carpa.Id);
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

        public static DataTable listadoCarpas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Carpas ORDER BY cantidadDormitorios";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception) { throw; }

            finally { cn.Close(); }
        }

        public static DataTable obtenerEstadisticaTiposCarpas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT t.nombre as Nombre, COUNT (c.idTipoCarpa) as Cantidad FROM TiposCarpas T INNER JOIN Carpas c ON t.id = c.idTipoCarpa GROUP BY t.nombre";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception) { throw; }

            finally { cn.Close(); }
        }

        public static DataTable obtenerDormitoriosPorTipo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select t.nombre as tipoCarpa, count(c.cantidadDormitorios) as Cantidad, c.cantidadDormitorios from Carpas c INNER JOIN TiposCarpas t ON c.idTipoCarpa = t.id GROUP BY c.cantidadDormitorios, t.nombre";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception) { throw; }

            finally { cn.Close(); }
        }

        public static DataTable obtenerListadiDormitorios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT t.nombre, c.cantidadDormitorios FROM Carpas c INNER JOIN TiposCarpas t ON c.idTipoCarpa = t.id ORDER BY c.cantidadDormitorios";

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception) { throw; }

            finally { cn.Close(); }
        }


    }
}
