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

                string consulta = "SELECT a.id as id, a.descripcion as descripcion, a.fechaInicio as fechaInicio, a.fechaFin as fechaFin, t.nombre as tipoActividad, ar.nombre as area, v.patente as patente, g.nombre as grupo JOIN TiposActividades t ON t.id=a.idTipoActividad JOIN Areas ar ON ar.id=a.idArea JOIN Vehiculos v ON v.patente=a.patente JOIN Grupos g ON g.id=a.idGrupo";

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
    }
}
