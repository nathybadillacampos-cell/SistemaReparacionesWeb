using System.Data;
using System.Data.SqlClient;
using SistemaReparacionesWeb.modelo;

namespace SistemaReparacionesWeb.logica
{
    public class logica_usuario
    {
        public static int AgregarUsuario(
            string nombre,
            string correo,
            string telefono)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_InsertarUsuario",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@Nombre",
                        nombre);

                    cmd.Parameters.AddWithValue(
                        "@Correo",
                        correo);

                    cmd.Parameters.AddWithValue(
                        "@Telefono",
                        telefono);

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

        public static int ModificarUsuario(
            int usuarioID,
            string nombre,
            string correo,
            string telefono)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_ModificarUsuario",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@UsuarioID",
                        usuarioID);

                    cmd.Parameters.AddWithValue(
                        "@Nombre",
                        nombre);

                    cmd.Parameters.AddWithValue(
                        "@Correo",
                        correo);

                    cmd.Parameters.AddWithValue(
                        "@Telefono",
                        telefono);

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

        public static int EliminarUsuario(
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
                            "SP_EliminarUsuario",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

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

        public static DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                            "SP_ConsultarUsuarios",
                            Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    da.Fill(dt);
                }
            }
            catch
            {
            }

            return dt;
        }
    }
}