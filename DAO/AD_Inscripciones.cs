﻿using Juventus.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.DAO
{
    class AD_Inscripciones
    {
        private static string connectionString = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
        public static bool insertarInscripcion(Inscripcion insc)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlTransaction objTransaccion = null;
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO inscripciones(dni, idTipoDocumento, fecha, idTipoActividad) VALUES (@dni, @idTipoDoc, @fecha, @idTipoActividad)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", insc.Dni);
                cmd.Parameters.AddWithValue("@idTipoDoc", insc.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@fecha", insc.Fecha);
                cmd.Parameters.AddWithValue("@idTipoActividad", insc.IdTipoActividad);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                objTransaccion = cn.BeginTransaction("InsertarInscripcion");
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

        public static bool validarExistencia(Inscripcion insc)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM inscripciones WHERE idTipoActividad= @idTipoActividad AND dni = @dni";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idTipoActividad", insc.IdTipoActividad);
                cmd.Parameters.AddWithValue("@dni", insc.Dni);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 0)
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

    }
}
