using System.Data;
using System.Data.SqlClient;
using SistemaReparacionesWeb.modelo;

namespace SistemaReparacionesWeb.logica
{
    public class logica_equipo
    {
        public static int AgregarEquipo(
            string tipoEquipo,
            string modelo,
            int usuarioID)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_InsertarEquipo",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@TipoEquipo",
                        tipoEquipo);

                    cmd.Parameters.AddWithValue(
                        "@Modelo",
                        modelo);

                    cmd.Parameters.AddWithValue(
                        "@UsuarioID",
                        usuarioID);

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

        public static int ModificarEquipo(
            int equipoID,
            string tipoEquipo,
            string modelo,
            int usuarioID)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_ModificarEquipo",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@EquipoID",
                        equipoID);

                    cmd.Parameters.AddWithValue(
                        "@TipoEquipo",
                        tipoEquipo);

                    cmd.Parameters.AddWithValue(
                        "@Modelo",
                        modelo);

                    cmd.Parameters.AddWithValue(
                        "@UsuarioID",
                        usuarioID);

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

        public static int EliminarEquipo(
            int equipoID)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_EliminarEquipo",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@EquipoID",
                        equipoID);

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

        public static DataTable ObtenerEquipos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection Conn =
                DBconn.obtenerConexion())
            {
                SqlCommand cmd =
                    new SqlCommand(
                        "SP_ConsultarEquipos",
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