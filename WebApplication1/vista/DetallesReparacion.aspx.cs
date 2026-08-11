using System;
using SistemaReparacionesWeb.logica;

namespace SistemaReparacionesWeb.vista
{
    public partial class DetallesReparacion :
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
            gvDetalles.DataSource =
                logica_detalle.ObtenerDetalles();

            gvDetalles.DataBind();
        }

        protected void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_detalle.AgregarDetalle(
                    Convert.ToInt32(txtReparacionID.Text),
                    txtDescripcion.Text,
                    txtFechaInicio.Text,
                    txtFechaFin.Text);

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Detalle guardado"
                : "❌ No se pudo guardar el detalle. Verifique que la Reparación ID exista.";

            CargarGrid();
        }

        protected void btnConsultar_Click(
            object sender,
            EventArgs e)
        {
            CargarGrid();

            lblMensaje.Text =
                "✅ Consulta realizada";
        }

        protected void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_detalle.ModificarDetalle(
                    Convert.ToInt32(txtID.Text),
                    Convert.ToInt32(txtReparacionID.Text),
                    txtDescripcion.Text,
                    txtFechaInicio.Text,
                    txtFechaFin.Text);

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Detalle modificado"
                : "❌ No se pudo modificar el detalle. Verifique que el Detalle ID exista.";

            CargarGrid();
        }

        protected void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_detalle.EliminarDetalle(
                    Convert.ToInt32(txtID.Text));

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Detalle eliminado"
                : "❌ No se pudo eliminar el detalle. Verifique que el Detalle ID exista.";

            CargarGrid();
        }
    }
}