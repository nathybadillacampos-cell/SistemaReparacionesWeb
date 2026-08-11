<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Menu.aspx.cs"
    Inherits="SistemaReparacionesWeb.vista.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema de Reparaciones</title>

    <style>

        body {
            font-family: 'Segoe UI', Arial, sans-serif;
            background: linear-gradient(to right,#e1bee7,#f8bbd0);
            margin: 0;
            padding: 0;
        }

        .contenedor {
            width: 1000px;
            margin: 40px auto;
            text-align: center;
        }

        h1 {
            color: #7b1fa2;
            font-size: 55px;
            margin-bottom: 80px;
        }

        .fila {
            display: flex;
            justify-content: center;
            gap: 40px;
            margin-bottom: 60px;
        }

        .boton {
            width: 220px;
            height: 90px;
            border: none;
            border-radius: 12px;
            color: white;
            font-size: 22px;
            font-weight: bold;
            cursor: pointer;
        }

        .morado {
            background-color: #ba68c8;
        }

        .rosa {
            background-color: #f48fb1;
        }

        .lila {
            background-color: #b39ddb;
        }

        .boton:hover {
            opacity: 0.8;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

<div class="contenedor">

    <h1>SISTEMA DE REPARACIONES</h1>

    <div class="fila">

        <asp:Button
            ID="btnUsuarios"
            runat="server"
            Text="Usuarios"
            CssClass="boton morado" 
            PostBackUrl="Usuarios.aspx" />

        <asp:Button
            ID="btnEquipos"
            runat="server"
            Text="Equipos"
            CssClass="boton rosa"
            PostBackUrl="Equipos.aspx"/>

        <asp:Button
            ID="btnTecnicos"
            runat="server"
            Text="Técnicos"
            CssClass="boton lila"
            PostBackUrl="Tecnicos.aspx"/>

    </div>

    <div class="fila">

        <asp:Button
            ID="btnReparaciones"
            runat="server"
            Text="Reparaciones"
            CssClass="boton morado"
            PostBackUrl="Reparaciones.aspx"/>

        <asp:Button
            ID="btnAsignaciones"
            runat="server"
            Text="Asignaciones"
            CssClass="boton rosa" />

        <asp:Button
            ID="btnDetalles"
            runat="server"
            Text="Detalles"
            CssClass="boton lila" />

    </div>

</div>

</form>

</body>
</html>