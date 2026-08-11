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

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Técnico guardado"
                : "❌ No se pudo guardar el técnico. Verifique que los datos sean correctos.";

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
                logica_tecnico.ModificarTecnico(
                    Convert.ToInt32(txtID.Text),
                    txtNombre.Text,
                    txtEspecialidad.Text);

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Técnico modificado"
                : "❌ No se pudo modificar el técnico. Verifique que el Técnico ID exista.";

            CargarGrid();
        }

        protected void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            int respuesta =
                logica_tecnico.EliminarTecnico(
                    Convert.ToInt32(txtID.Text));

            lblMensaje.Text =
                respuesta > 0
                ? "✅ Técnico eliminado"
                : "❌ No se puede eliminar el técnico porque tiene asignaciones asociadas o el ID no existe.";

            CargarGrid();
        }
    }
}