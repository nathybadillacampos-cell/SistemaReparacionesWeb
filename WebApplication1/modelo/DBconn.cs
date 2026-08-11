using System.Data.SqlClient;

namespace SistemaReparacionesWeb.modelo
{
    public class DBconn
    {
        public static SqlConnection obtenerConexion()
        {
            SqlConnection conexion =
                new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;
                  Database=SistemaReparaciones;
                  Trusted_Connection=True;");

            conexion.Open();

            return conexion;
        }
    }
}