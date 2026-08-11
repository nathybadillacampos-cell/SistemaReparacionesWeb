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

            if (respuesta > -1)
            {
                lblMensaje.Text =
                    "✅ Usuario guardado correctamente";

                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";

                CargarGrid();
            }
            else
            {
                lblMensaje.Text =
                    "❌ Error al guardar";
            }
        }
    }
}