using System.Data;
using System.Data.SqlClient;
using SistemaReparacionesWeb.modelo;

namespace SistemaReparacionesWeb.logica
{
    public class logica_reparacion
    {
        public static int AgregarReparacion(
            int equipoID,
            string fechaSolicitud,
            string estado)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                        "SP_InsertarReparacion",
                        Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@EquipoID",
                        equipoID);

                    cmd.Parameters.AddWithValue(
                        "@FechaSolicitud",
                        fechaSolicitud);

                    cmd.Parameters.AddWithValue(
                        "@Estado",
                        estado);

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

        public static int ModificarReparacion(
            int reparacionID,
            int equipoID,
            string fechaSolicitud,
            string estado)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                        "SP_ModificarReparacion",
                        Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@ReparacionID",
                        reparacionID);

                    cmd.Parameters.AddWithValue(
                        "@EquipoID",
                        equipoID);

                    cmd.Parameters.AddWithValue(
                        "@FechaSolicitud",
                        fechaSolicitud);

                    cmd.Parameters.AddWithValue(
                        "@Estado",
                        estado);

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

        public static int EliminarReparacion(
            int reparacionID)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                        "SP_EliminarReparacion",
                        Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@ReparacionID",
                        reparacionID);

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

        public static DataTable ObtenerReparaciones()
        {
            DataTable dt = new DataTable();

            using (SqlConnection Conn =
                DBconn.obtenerConexion())
            {
                SqlCommand cmd =
                    new SqlCommand(
                    "SP_ConsultarReparaciones",
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