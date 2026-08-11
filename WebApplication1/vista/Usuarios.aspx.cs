using System;
using SistemaReparacionesWeb.logica;

namespace SistemaReparacionesWeb.vista
{
    public partial class Usuarios :
        System.Web.UI.Page
    {
        protected void Page_Load(
            object sender,
            EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }
        }

        private void CargarGrid()
        {
            gvUsuarios.DataSource =
                logica_usuario.ObtenerUsuarios();

            gvUsuarios.DataBind();
        }

        protected void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_usuario.AgregarUsuario(
                    txtNombre.Text,
                    txtCorreo.Text,
                    txtTelefono.Text);

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Usuario guardado correctamente"
                : "❌ No se pudo guardar el usuario. Verifique que todos los datos sean correctos.";

            CargarGrid();
        }

        protected void btnConsultar_Click(
            object sender,
            EventArgs e)
        {
            CargarGrid();

            lblMensaje.Text =
                "✅ Consulta realizada correctamente";
        }

        protected void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_usuario.ModificarUsuario(
                    Convert.ToInt32(txtID.Text),
                    txtNombre.Text,
                    txtCorreo.Text,
                    txtTelefono.Text);

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Usuario modificado correctamente"
                : "❌ No se pudo modificar el usuario. Verifique que el Usuario ID exista.";

            CargarGrid();
        }

        protected void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_usuario.EliminarUsuario(
                    Convert.ToInt32(txtID.Text));

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Usuario eliminado correctamente"
                : "❌ No se puede eliminar el usuario porque tiene equipos asociados o el ID no existe.";

            CargarGrid();
        }
    }
}