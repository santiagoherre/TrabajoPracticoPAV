using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus
{
    class AD_Motor
    {
        private static string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];

        public static DataTable ObtenerTabla(string nombreTabla)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM " + nombreTabla;

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
        public static bool AgregarMotor(Motor mot)
        {

            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Motores(fabricante,modelo,idTipoMotor) VALUES(@fabricante,@modelo,@idTipoMotor)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fabricante", mot.FabricanteMotor);
                cmd.Parameters.AddWithValue("@modelo", mot.ModeloMotor);
                cmd.Parameters.AddWithValue("@idTipoMotor", mot.IdtipoDeMotor);
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
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool BajaMotor(Motor mot)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Motores WHERE fabricante = @fabricante AND modelo = @modelo AND idTipoMotor = @idTipoMotor";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fabricante", mot.FabricanteMotor);
                cmd.Parameters.AddWithValue("@modelo", mot.ModeloMotor);
                cmd.Parameters.AddWithValue("@idTipoMotor", mot.IdtipoDeMotor);
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
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool ActualizarMotor(Motor mot)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Motores SET fabricante = @fabricante, modelo = @modelo WHERE idTipoMotor = @idTipoMotor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fabricante", mot.FabricanteMotor);
                cmd.Parameters.AddWithValue("modelo", mot.ModeloMotor);
                cmd.Parameters.AddWithValue("@idTipoMotor", mot.IdtipoDeMotor);
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
            finally
            {
                cn.Close();
            }
            return resultado;

        }
        public static Motor ObtenerMotor(string id)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Motor mot = new Motor();
            try
            {


                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Motores WHERE id LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    mot.FabricanteMotor = dr["fabricante"].ToString();
                    mot.ModeloMotor = dr["modelo"].ToString();
                    mot.IdtipoDeMotor = int.Parse(dr["idTipoMotor"].ToString());
                }


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return mot;

        }
    }
}
