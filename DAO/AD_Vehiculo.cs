using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.Vehiculo
{
    public class AD_Vehiculo
    {
        private static string connectionString = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];

        public static DataTable ObtenerElementos()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT patente, kilometraje, fechaDeCompra FROM Vehiculos";

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
        public static bool AgregarVehiculoABD(Vehiculo vehiculo)
        {
            string cadenaConexion = connectionString;
            SqlConnection cn = new SqlConnection(cadenaConexion);

            bool res = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Vehiculos (patente, kilometraje, fechaDeCompra) VALUES (@patente, @kilometraje, @fechaDeCompra)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", vehiculo.Patente);
                cmd.Parameters.AddWithValue("@kilometraje", vehiculo.Kilometraje);
                cmd.Parameters.AddWithValue("@fechaDeCompra", vehiculo.FechaDeCompra);
                


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;
                return res;


            }
            catch (Exception)
            {
                ;
                throw;
            }
            finally
            {
                cn.Close();

            }

        }

        internal static bool validarExistente(string patente)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select patente FROM Vehiculos WHERE patente = @patente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patente);
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

        public static bool modificarVehiculo(Vehiculo vehiculo)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Vehiculos SET kilometraje = @kilometraje, fechaDeCompra = @fecha WHERE patente = @patente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", vehiculo.Patente);
                cmd.Parameters.AddWithValue("@kilometraje", vehiculo.Kilometraje);
                cmd.Parameters.AddWithValue("@fecha", vehiculo.FechaDeCompra);
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

        public static bool eliminarVehiculo(Vehiculo vehiculo)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Vehiculos WHERE patente = @patente";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", vehiculo.Patente);
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

        public static Vehiculo buscarVehiculo(string id)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select patente, kilometraje, fechaDeCompra  FROM Vehiculos WHERE patente=@id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                Vehiculo vehiculo = new Vehiculo();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    vehiculo.Patente = dr["patente"].ToString();
                    vehiculo.Kilometraje = int.Parse(dr["kilometraje"].ToString());
                    vehiculo.FechaDeCompra = dr["fechaDeCompra"].ToString();
                }

                return vehiculo;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }
        }

        public static DataTable ObtenerActividadesXvehiculos()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT v.patente as Vehiculo, a.id as CantActividades FROM Actividades a inner join Vehiculos v On a.patente = v.patente";

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

        public static DataTable ObtenerVehiculosXTipoActividad()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT v.patente as CantVehiculos, ta.id, ta.nombre FROM Vehiculos v inner join Actividades a ON a.patente = v.patente inner join TiposActividades ta ON ta.id = a.idTipoActividad ";

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

    }
}
