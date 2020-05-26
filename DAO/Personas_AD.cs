using Juventus.Personas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Juventus.Varios
{
    class Personas_AD
    {
        public static DataTable ObtenerListadoPersonasReducido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT nombre, apellido, idTipoDocumento, dni, añoEscolar FROM Personas";

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
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static bool AgregarPersonaABD(Persona per)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Personas (nombre, apellido, fechaNacimiento, idTipoDocumento, dni, sexo, institucionAcademica, añoEscolar, direccion, telefono, idGrupo, correoElectronico) VALUES(@nombre, @apellido, @fechaNacimiento, @idTipoDocumento, @nroDocumento, @idSexo, @institucionAcademica, @añoEscolar, @direccion, @telefono, @idGrupo, @correoElectronico)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@apellido", per.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", per.FechaNacimiento);
                cmd.Parameters.AddWithValue("@idTipoDocumento", per.IdDocumento);
                cmd.Parameters.AddWithValue("@nroDocumento", per.Documento);
                cmd.Parameters.AddWithValue("@idSexo", per.IdSexo);
                cmd.Parameters.AddWithValue("@institucionAcademica", per.InstitucionAcademica);
                cmd.Parameters.AddWithValue("@añoEscolar", per.AñoEscolar);
                cmd.Parameters.AddWithValue("@direccion", per.Direccion);
                cmd.Parameters.AddWithValue("@telefono", per.Telefono);
                cmd.Parameters.AddWithValue("@idGrupo", per.IdGrupo);
                cmd.Parameters.AddWithValue("@correoElectronico", per.CorreoElectronico);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static Persona ObtenerPersona(string documento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Persona p = new Persona();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Personas where dni like @documento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", documento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.Nombre = dr["nombre"].ToString();
                    p.Apellido = dr["apellido"].ToString();
                    p.FechaNacimiento = DateTime.Parse(dr["fechaNacimiento"].ToString());
                    p.IdSexo = int.Parse(dr["sexo"].ToString());
                    p.IdDocumento = int.Parse(dr["idTipoDocumento"].ToString());
                    p.Documento = int.Parse(dr["dni"].ToString());
                    p.Direccion = dr["direccion"].ToString();
                    p.Telefono = dr["telefono"].ToString();
                    p.CorreoElectronico = dr["correoElectronico"].ToString();
                    p.InstitucionAcademica = dr["institucionAcademica"].ToString();
                    p.AñoEscolar = int.Parse(dr["añoEscolar"].ToString());
                    p.IdGrupo = int.Parse(dr["idGrupo"].ToString());
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

            return p;
        }

        public static bool ActualizarPersona(Persona per)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                //UPDATE table_name
                //SET column1 = value1, column2 = value2, ...
                //WHERE condition;

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Personas SET nombre = @nombre, apellido = @apellido, fechaNacimiento = @fechaNacimiento, idTipoDocumento = @idTipoDocumento, dni = @nroDocumento, sexo = @idSexo,  institucionAcademica = @institucion, añoEscolar = @añoEscolar, direccion = @direccion, telefono = @telefono, IdGrupo = @idGrupo, correoElectronico = @correoElectronico WHERE dni like @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@apellido", per.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", per.FechaNacimiento);
                cmd.Parameters.AddWithValue("@idTipoDocumento", per.IdDocumento);
                cmd.Parameters.AddWithValue("@nroDocumento", per.Documento);
                cmd.Parameters.AddWithValue("@idSexo", per.IdSexo);
                cmd.Parameters.AddWithValue("@institucion", per.InstitucionAcademica);
                cmd.Parameters.AddWithValue("@añoEscolar", per.AñoEscolar);
                cmd.Parameters.AddWithValue("@direccion", per.Direccion);
                cmd.Parameters.AddWithValue("@telefono", per.Telefono);
                cmd.Parameters.AddWithValue("@idGrupo", per.IdGrupo);
                cmd.Parameters.AddWithValue("@correoElectronico", per.CorreoElectronico);
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

        public static bool EliminarPersona(Persona per)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Personas WHERE nombre = @nombre AND apellido = @apellido AND fechaNacimiento = @fechaNacimiento AND idTipoDocumento = @idTipoDocumento AND dni = @nroDocumento AND sexo = @idSexo AND institucionAcademica = @institucion AND añoEscolar = @añoEscolar AND direccion = @direccion AND telefono = @telefono AND IdGrupo = @idGrupo AND correoElectronico = @correoElectronico";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@apellido", per.Apellido);
                cmd.Parameters.AddWithValue("@fechaNacimiento", per.FechaNacimiento);
                cmd.Parameters.AddWithValue("@idTipoDocumento", per.IdDocumento);
                cmd.Parameters.AddWithValue("@nroDocumento", per.Documento);
                cmd.Parameters.AddWithValue("@idSexo", per.IdSexo);
                cmd.Parameters.AddWithValue("@institucion", per.InstitucionAcademica);
                cmd.Parameters.AddWithValue("@añoEscolar", per.AñoEscolar);
                cmd.Parameters.AddWithValue("@direccion", per.Direccion);
                cmd.Parameters.AddWithValue("@telefono", per.Telefono);
                cmd.Parameters.AddWithValue("@idGrupo", per.IdGrupo);
                cmd.Parameters.AddWithValue("@correoElectronico", per.CorreoElectronico);
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

        public static DataTable ObtenerTiposDeDocumentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TiposDocumentos";

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
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerAñosEscolares()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM AñosEscolares";

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
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerGrupos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Grupos";

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
