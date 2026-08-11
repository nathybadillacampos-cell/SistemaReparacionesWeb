using System;
using SistemaReparacionesWeb.logica;

namespace SistemaReparacionesWeb.vista
{
    public partial class Equipos :
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
            gvEquipos.DataSource =
                logica_equipo.ObtenerEquipos();

            gvEquipos.DataBind();
        }

        protected void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_equipo.AgregarEquipo(
                    txtTipoEquipo.Text,
                    txtModelo.Text,
                    Convert.ToInt32(txtUsuarioID.Text));

            lblMensaje.Text =
                respuesta > -1
                ? "✅ Equipo guardado correctamente"
                : "❌ No se pudo guardar el equipo. Verifique que el Usuario ID exista.";

            CargarGrid();
        }

        protected void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_equipo.ModificarEquipo(
                    Convert.ToInt32(txtID.Text),
                    txtTipoEquipo.Text,
                    txtModelo.Text,
                    Convert.ToInt32(txtUsuarioID.Text));

            lblMensaje.Text =
                respuesta > -1
                ? "✅ Equipo modificado correctamente"
                : "❌ No se pudo modificar el equipo. Verifique que el Equipo ID exista.";

            CargarGrid();
        }

        protected void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_equipo.EliminarEquipo(
                    Convert.ToInt32(txtID.Text));

            lblMensaje.Text =
                respuesta > -1
                ? "✅ Equipo eliminado correctamente"
                : "❌ No se puede eliminar el equipo porque tiene reparaciones asociadas o el ID no existe.";

            CargarGrid();
        }
    }
}