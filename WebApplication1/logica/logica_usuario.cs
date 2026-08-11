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

            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
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

        public static DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();

            SqlConnection Conn = new SqlConnection();

            using (Conn = DBconn.obtenerConexion())
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

            return dt;
        }
    }
}