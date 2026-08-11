using System;
using SistemaReparacionesWeb.logica;

namespace SistemaReparacionesWeb.vista
{
    public partial class Reparaciones :
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
            gvReparaciones.DataSource =
                logica_reparacion.ObtenerReparaciones();

            gvReparaciones.DataBind();
        }

        protected void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_reparacion.AgregarReparacion(
                    Convert.ToInt32(txtEquipoID.Text),
                    txtFechaSolicitud.Text,
                    txtEstado.Text);

            if (respuesta > -1)
            {
                lblMensaje.Text =
                    "✅ Reparación guardada correctamente";

                txtEquipoID.Text = "";
                txtFechaSolicitud.Text = "";
                txtEstado.Text = "";

                CargarGrid();
            }
            else
            {
                lblMensaje.Text =
                    "❌ Error al guardar reparación";
            }
        }
    }
}