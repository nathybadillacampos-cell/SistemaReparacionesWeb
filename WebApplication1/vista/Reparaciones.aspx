<%@ Page Language="C#" AutoEventWireup="true"
CodeBehind="Reparaciones.aspx.cs"
Inherits="SistemaReparacionesWeb.vista.Reparaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<title>Reparaciones</title>

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
    font-size:16px;
}

.boton{
    background:#7b1fa2;
    color:white;
    border:none;
    padding:12px 25px;
    font-size:18px;
    cursor:pointer;
}

.boton:hover{
    background:#6a1b9a;
}

.mensaje{
    font-weight:bold;
    font-size:18px;
}

</style>

</head>

<body>

<form id="form1" runat="server">

<div class="contenedor">

<h1>Gestión de Reparaciones</h1>

<asp:TextBox
ID="txtEquipoID"
runat="server"
CssClass="caja"
placeholder="Equipo ID">
</asp:TextBox>

<asp:TextBox
ID="txtFechaSolicitud"
runat="server"
CssClass="caja"
placeholder="Fecha Solicitud">
</asp:TextBox>

<asp:TextBox
ID="txtEstado"
runat="server"
CssClass="caja"
placeholder="Estado">
</asp:TextBox>

<asp:Button
ID="btnGuardar"
runat="server"
Text="Guardar Reparación"
CssClass="boton"
OnClick="btnGuardar_Click" />

<br />
<br />

<asp:Label
ID="lblMensaje"
runat="server"
CssClass="mensaje">
</asp:Label>

<br />
<br />

<asp:GridView
ID="gvReparaciones"
runat="server"
Width="100%"
GridLines="Both"
AutoGenerateColumns="true">
</asp:GridView>

</div>

</form>

</body>

</html>
``