<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs"
    Inherits="SistemaReparacionesWeb.vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Login</title>

    <style>

        body {
            font-family: Arial;
            background: linear-gradient(to right,#e1bee7,#f8bbd0);
        }

        .contenedor {
            width: 450px;
            margin: 120px auto;
            background: white;
            padding: 40px;
            border-radius: 15px;
            text-align: center;
            box-shadow: 0px 5px 15px gray;
        }

        h1 {
            color: #7b1fa2;
        }

        .caja {
            width: 90%;
            padding: 12px;
            margin-top: 10px;
            margin-bottom: 20px;
            font-size: 18px;
        }

        .boton {
            width: 95%;
            padding: 12px;
            background: #7b1fa2;
            color: white;
            border: none;
            font-size: 20px;
            cursor: pointer;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

<div class="contenedor">

<h1>Sistema de Reparaciones</h1>

<asp:TextBox
    ID="txtUsuario"
    runat="server"
    CssClass="caja"
    placeholder="Usuario">
</asp:TextBox>

<asp:TextBox
    ID="txtPassword"
    runat="server"
    CssClass="caja"
    TextMode="Password"
    placeholder="Contraseña">
</asp:TextBox>

<asp:Button
    ID="btnIngresar"
    runat="server"
    Text="Ingresar"
    CssClass="boton"
    OnClick="btnIngresar_Click" />

<br /><br />

<asp:Label
    ID="lblMensaje"
    runat="server">
</asp:Label>

</div>

</form>

</body>
</html>