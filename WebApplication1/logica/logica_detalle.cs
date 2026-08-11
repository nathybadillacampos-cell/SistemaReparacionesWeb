using System.Data;
using System.Data.SqlClient;
using SistemaReparacionesWeb.modelo;

namespace SistemaReparacionesWeb.logica
{
    public class logica_detalle
    {
        public static int AgregarDetalle(
            int reparacionID,
            string descripcion,
            string fechaInicio,
            string fechaFin)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                        "SP_InsertarDetalleReparacion",
                        Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@ReparacionID",
                        reparacionID);

                    cmd.Parameters.AddWithValue(
                        "@Descripcion",
                        descripcion);

                    cmd.Parameters.AddWithValue(
                        "@FechaInicio",
                        fechaInicio);

                    cmd.Parameters.AddWithValue(
                        "@FechaFin",
                        fechaFin);

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

        public static int ModificarDetalle(
            int detalleID,
            int reparacionID,
            string descripcion,
            string fechaInicio,
            string fechaFin)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                        "SP_ModificarDetalleReparacion",
                        Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@DetalleID",
                        detalleID);

                    cmd.Parameters.AddWithValue(
                        "@ReparacionID",
                        reparacionID);

                    cmd.Parameters.AddWithValue(
                        "@Descripcion",
                        descripcion);

                    cmd.Parameters.AddWithValue(
                        "@FechaInicio",
                        fechaInicio);

                    cmd.Parameters.AddWithValue(
                        "@FechaFin",
                        fechaFin);

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

        public static int EliminarDetalle(
            int detalleID)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                        "SP_EliminarDetalleReparacion",
                        Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@DetalleID",
                        detalleID);

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

        public static DataTable ObtenerDetalles()
        {
            DataTable dt = new DataTable();

            using (SqlConnection Conn =
                DBconn.obtenerConexion())
            {
                SqlCommand cmd =
                    new SqlCommand(
                    "SP_ConsultarDetallesReparacion",
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