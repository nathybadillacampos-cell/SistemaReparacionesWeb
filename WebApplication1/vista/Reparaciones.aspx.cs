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

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Reparación guardada"
                : "❌ No se pudo guardar la reparación. Verifique que el Equipo ID exista.";

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
                logica_reparacion.ModificarReparacion(
                    Convert.ToInt32(txtID.Text),
                    Convert.ToInt32(txtEquipoID.Text),
                    txtFechaSolicitud.Text,
                    txtEstado.Text);

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Reparación modificada"
                : "❌ No se pudo modificar la reparación. Verifique que el Reparación ID exista.";

            CargarGrid();
        }

        protected void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_reparacion.EliminarReparacion(
                    Convert.ToInt32(txtID.Text));

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Reparación eliminada"
                : "❌ No se puede eliminar la reparación porque tiene asignaciones o detalles asociados.";

            CargarGrid();
        }
    }
}