using System;

namespace SistemaReparacionesWeb.vista
{
    public partial class Login :
        System.Web.UI.Page
    {
        protected void btnIngresar_Click(
            object sender,
            EventArgs e)
        {
            if (txtUsuario.Text == "admin"
                &&
                txtPassword.Text == "123")
            {
                Response.Redirect(
                    "Menu.aspx");
            }
            else
            {
                lblMensaje.Text =
                    "Usuario o contraseña incorrectos";
            }
        }
    }
}