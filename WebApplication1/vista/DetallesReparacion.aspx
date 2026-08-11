<%@ Page Language="C#" AutoEventWireup="true"
CodeBehind="DetallesReparacion.aspx.cs"
Inherits="SistemaReparacionesWeb.vista.DetallesReparacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<title>Detalles de Reparación</title>

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
    font-size:55px;
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
    margin-right:10px;
}

</style>

</head>

<body>

<form id="form1" runat="server">

<div class="contenedor">

<h1>Detalles de Reparación</h1>

<asp:TextBox
ID="txtID"
runat="server"
CssClass="caja"
placeholder="Detalle ID">
</asp:TextBox>

<asp:TextBox
ID="txtReparacionID"
runat="server"
CssClass="caja"
placeholder="Reparación ID">
</asp:TextBox>

<asp:TextBox
ID="txtDescripcion"
runat="server"
CssClass="caja"
placeholder="Descripción">
</asp:TextBox>

<asp:TextBox
ID="txtFechaInicio"
runat="server"
CssClass="caja"
placeholder="Fecha Inicio">
</asp:TextBox>

<asp:TextBox
ID="txtFechaFin"
runat="server"
CssClass="caja"
placeholder="Fecha Fin">
</asp:TextBox>

<asp:Button
ID="btnGuardar"
runat="server"
Text="Guardar"
CssClass="boton"
OnClick="btnGuardar_Click" />

<asp:Button
ID="btnConsultar"
runat="server"
Text="Consultar"
CssClass="boton"
OnClick="btnConsultar_Click" />

<asp:Button
ID="btnModificar"
runat="server"
Text="Modificar"
CssClass="boton"
OnClick="btnModificar_Click" />

<asp:Button
ID="btnEliminar"
runat="server"
Text="Eliminar"
CssClass="boton"
OnClick="btnEliminar_Click" />

<br /><br />

<asp:Label
ID="lblMensaje"
runat="server">
</asp:Label>

<br /><br />

<asp:GridView
ID="gvDetalles"
runat="server"
Width="100%">
</asp:GridView>

</div>

</form>

</body>
</html>