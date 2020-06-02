using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.Actividades
{
    class AD_Actividad
    {
        private static string connectionString = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];

        public static object ObtenerActividades()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT a.id as id, a.descripcion as descripcion, a.fechaInicio as fechaInicio, a.fechaFin as fechaFin, t.nombre as tipoActividad, ar.descripcion as area, v.patente as patente, g.nombre as grupo FROM Actividades a JOIN TiposActividades t ON t.id=a.idTipoActividad JOIN Areas ar ON ar.id=a.idArea JOIN Vehiculos v ON v.patente=a.patente JOIN Grupos g ON g.id=a.idGrupo";

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

        internal static bool validarExistente(int id)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select id FROM Actividades WHERE id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
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

        internal static bool modificarElemento(Actividad act)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlTransaction objTransaccion = null;
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Actividades SET descripcion = @descripcion, fechaInicio = @fechaInicio, fechaFin = @fechaFin, idTipoActividad = @idTipoActividad, idArea = @idArea, patente = @patente, idGrupo = @idGrupo WHERE id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", act.Id);
                cmd.Parameters.AddWithValue("@descripcion", act.Descripcion);
                cmd.Parameters.AddWithValue("@fechaInicio", act.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", act.FechaFin);
                cmd.Parameters.AddWithValue("@idTipoActividad", act.IdTipoActividad);
                cmd.Parameters.AddWithValue("@idArea", act.IdArea);
                cmd.Parameters.AddWithValue("@patente", act.Patente);
                cmd.Parameters.AddWithValue("@idGrupo", act.IdGrupo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                objTransaccion = cn.BeginTransaction("ModificarActividad");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                objTransaccion.Commit();
                resultado = true;


            }
            catch (Exception)
            {
                objTransaccion.Rollback();
                throw;
            }
            finally { cn.Close(); }
            return resultado;
        }

        public static object ObtenerCombo(string nombre)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM " + nombre;

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

        public static bool insertarActividad(Actividad act)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlTransaction objTransaccion = null;
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Actividades(descripcion, fechaInicio, fechaFin, idTipoActividad, idArea, patente, idGrupo) VALUES (@descripcion, @fechaInicio, @fechaFin, @idTipoActividad, @idArea, @patente, @idGrupo)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", act.Descripcion);
                cmd.Parameters.AddWithValue("@fechaInicio", act.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", act.FechaFin);
                cmd.Parameters.AddWithValue("@idTipoActividad", act.IdTipoActividad);
                cmd.Parameters.AddWithValue("@idArea", act.IdArea);
                cmd.Parameters.AddWithValue("@patente", act.Patente);
                cmd.Parameters.AddWithValue("@idGrupo", act.IdGrupo);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                objTransaccion = cn.BeginTransaction("InsertarActividad");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                objTransaccion.Commit();
                resultado = true;


            }
            catch (Exception)
            {
                objTransaccion.Rollback();
            }
            finally { cn.Close(); }
            return resultado;
        }

        internal static Actividad buscarActividad(int id)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Actividades WHERE id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                Actividad act = new Actividad();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    act.Id = int.Parse(dr["id"].ToString());
                    act.Descripcion = dr["descripcion"].ToString();
                    act.FechaInicio = DateTime.Parse(dr["fechaInicio"].ToString());
                    act.FechaFin = DateTime.Parse(dr["fechaFin"].ToString());
                    act.IdTipoActividad = int.Parse(dr["idTipoActividad"].ToString());
                    act.IdArea = int.Parse(dr["idArea"].ToString());
                    act.Patente = dr["patente"].ToString();
                    act.IdGrupo = int.Parse(dr["idGrupo"].ToString());
                }

                return act;
            }
            catch (Exception)
            {

                throw;
            }
            finally { cn.Close(); }
        }

        public static bool eliminarActividad(Actividad act)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlTransaction objTransaccion = null;
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Actividades WHERE id = @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", act.Id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                objTransaccion = cn.BeginTransaction("EliminarActividad");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                objTransaccion.Commit();
                resultado = true;


            }
            catch (Exception)
            {
                objTransaccion.Rollback();
            }
            finally { cn.Close(); }
            return resultado;
        }

        public static DataTable obtenerActividadesPorTipo(int idTipoActividad)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT id, descripcion, fechaInicio, fechaFin FROM Actividades WHERE idTipoActividad = @idAct";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idAct", idTipoActividad);
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
    }
}
