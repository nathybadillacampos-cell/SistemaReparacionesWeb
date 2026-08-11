using System;
using SistemaReparacionesWeb.logica;

namespace SistemaReparacionesWeb.vista
{
    public partial class Tecnicos :
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
            gvTecnicos.DataSource =
                logica_tecnico.ObtenerTecnicos();

            gvTecnicos.DataBind();
        }

        protected void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_tecnico.AgregarTecnico(
                    txtNombre.Text,
                    txtEspecialidad.Text);

            if (respuesta > -1)
            {
                lblMensaje.Text =
                    "✅ Técnico guardado correctamente";

                txtNombre.Text = "";
                txtEspecialidad.Text = "";

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