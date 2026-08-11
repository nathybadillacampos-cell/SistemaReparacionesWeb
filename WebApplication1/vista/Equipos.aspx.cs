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
                    Convert.ToInt32(
                        txtUsuarioID.Text));

            if (respuesta > -1)
            {
                lblMensaje.Text =
                    "✅ Equipo guardado correctamente";

                txtTipoEquipo.Text = "";
                txtModelo.Text = "";
                txtUsuarioID.Text = "";

                CargarGrid();
            }
            else
            {
                lblMensaje.Text =
                    "❌ Error al guardar equipo";
            }
        }
    }
}