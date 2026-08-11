using System.Data;
using System.Data.SqlClient;
using SistemaReparacionesWeb.modelo;

namespace SistemaReparacionesWeb.logica
{
    public class logica_tecnico
    {
        public static int AgregarTecnico(
            string nombre,
            string especialidad)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                        "SP_InsertarTecnico",
                        Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@Nombre",
                        nombre);

                    cmd.Parameters.AddWithValue(
                        "@Especialidad",
                        especialidad);

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

        public static int ModificarTecnico(
            int tecnicoID,
            string nombre,
            string especialidad)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                        "SP_ModificarTecnico",
                        Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@TecnicoID",
                        tecnicoID);

                    cmd.Parameters.AddWithValue(
                        "@Nombre",
                        nombre);

                    cmd.Parameters.AddWithValue(
                        "@Especialidad",
                        especialidad);

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

        public static int EliminarTecnico(
            int tecnicoID)
        {
            int retorno = 0;

            try
            {
                using (SqlConnection Conn =
                    DBconn.obtenerConexion())
                {
                    SqlCommand cmd =
                        new SqlCommand(
                        "SP_EliminarTecnico",
                        Conn);

                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue(
                        "@TecnicoID",
                        tecnicoID);

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

        public static DataTable ObtenerTecnicos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection Conn =
                DBconn.obtenerConexion())
            {
                SqlCommand cmd =
                    new SqlCommand(
                    "SP_ConsultarTecnicos",
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