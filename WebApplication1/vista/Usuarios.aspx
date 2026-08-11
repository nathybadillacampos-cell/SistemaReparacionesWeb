<%@ Page Language="C#" AutoEventWireup="true"
CodeBehind="Usuarios.aspx.cs"
Inherits="SistemaReparacionesWeb.vista.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<title>Usuarios</title>

<style>

body{
    font-family:Arial;
    background:#f3e5f5;
}

.contenedor{
    width:900px;
    margin:auto;
    padding:30px;
}

h1{
    color:#7b1fa2;
    text-align:center;
}

.caja{
    width:100%;
    padding:12px;
    margin-bottom:15px;
}

.boton{
    background:#7b1fa2;
    color:white;
    border:none;
    padding:12px 25px;
    font-size:18px;
}

</style>

</head>

<body>

<form id="form1" runat="server">

<div class="contenedor">

<h1>Gestión de Usuarios</h1>

<asp:TextBox
ID="txtNombre"
runat="server"
CssClass="caja"
placeholder="Nombre">
</asp:TextBox>

<asp:TextBox
ID="txtCorreo"
runat="server"
CssClass="caja"
placeholder="Correo">
</asp:TextBox>

<asp:TextBox
ID="txtTelefono"
runat="server"
CssClass="caja"
placeholder="Teléfono">
</asp:TextBox>

<asp:Button
ID="btnGuardar"
runat="server"
Text="Guardar Usuario"
CssClass="boton"
OnClick="btnGuardar_Click" />

<br /><br />

<asp:Label
ID="lblMensaje"
runat="server">
</asp:Label>

<br /><br />

<asp:GridView
ID="gvUsuarios"
runat="server"
Width="100%">
</asp:GridView>

</div>

</form>

</body>

</html>