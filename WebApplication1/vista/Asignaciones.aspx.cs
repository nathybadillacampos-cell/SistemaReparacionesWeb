using System;
using SistemaReparacionesWeb.logica;

namespace SistemaReparacionesWeb.vista
{
    public partial class Asignaciones :
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
            gvAsignaciones.DataSource =
                logica_asignacion.ObtenerAsignaciones();

            gvAsignaciones.DataBind();
        }

        protected void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_asignacion.AgregarAsignacion(
                    Convert.ToInt32(txtReparacionID.Text),
                    Convert.ToInt32(txtTecnicoID.Text),
                    txtFechaAsignacion.Text);

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Asignación guardada"
                : "❌ No se pudo guardar la asignación. Verifique que la Reparación ID y el Técnico ID existan";

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
                logica_asignacion.ModificarAsignacion(
                    Convert.ToInt32(txtID.Text),
                    Convert.ToInt32(txtReparacionID.Text),
                    Convert.ToInt32(txtTecnicoID.Text),
                    txtFechaAsignacion.Text);

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Asignación modificada"
                : "❌ No se pudo modificar la asignación. Verifique que el ID de Asignación exista.";

            CargarGrid();
        }

        protected void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_asignacion.EliminarAsignacion(
                    Convert.ToInt32(txtID.Text));

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Asignación eliminada"
                : "❌ No se pudo eliminar la asignación. Verifique que el ID exista o que no tenga registros relacionados.";

            CargarGrid();
        }
    }
}