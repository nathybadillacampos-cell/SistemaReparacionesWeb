using System;
using System.Data;
using System.Data.SqlClient;
using SistemaReparacionesWeb.modelo;

namespace SistemaReparacionesWeb.logica
{
    public class logica_asignacion
    {
        public static int AgregarAsignacion(
            int reparacionID,
            int tecnicoID,
            string fechaAsignacion)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_InsertarAsignacion",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@ReparacionID",
                        reparacionID);

                    cmd.Parameters.AddWithValue(
                        "@TecnicoID",
                        tecnicoID);

                    cmd.Parameters.AddWithValue(
                        "@FechaAsignacion",
                        fechaAsignacion);

                    retorno =
                        cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int ModificarAsignacion(
            int asignacionID,
            int reparacionID,
            int tecnicoID,
            string fechaAsignacion)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_ModificarAsignacion",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@AsignacionID",
                        asignacionID);

                    cmd.Parameters.AddWithValue(
                        "@ReparacionID",
                        reparacionID);

                    cmd.Parameters.AddWithValue(
                        "@TecnicoID",
                        tecnicoID);

                    cmd.Parameters.AddWithValue(
                        "@FechaAsignacion",
                        fechaAsignacion);

                    retorno =
                        cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int EliminarAsignacion(
            int asignacionID)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_EliminarAsignacion",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@AsignacionID",
                        asignacionID);

                    retorno =
                        cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                retorno = -1;
            }

            return retorno;
        }

        public static DataTable ObtenerAsignaciones()
        {
            DataTable dt = new DataTable();

            using (SqlConnection Conn =
                DBconn.obtenerConexion())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "SP_ConsultarAsignaciones",
                        Conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}