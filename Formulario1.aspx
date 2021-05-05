<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario1.aspx.cs" Inherits="rosalba.Formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>CODCITA:</td>
                <td>
                    <asp:TextBox ID="txtcodcita" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>FECHA:</td>
                <td>
                    <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>HORA:</td>
                <td>
                    <asp:TextBox ID="txthora" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>ID_PACIENTE:</td>
                <td>
                    <asp:TextBox ID="txtidpaciente" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>ID_MEDICO:</td>
                <td>
                    <asp:TextBox ID="txtidmedico" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>VALOR:</td>
                <td>
                    <asp:TextBox ID="txtvalor" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>DIAGNOSTICO:</td>
                <td>
                    <asp:TextBox ID="txtdiagnostico" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>NOMBRE ACOMPAÑANTE:</td>
                <td>
                    <asp:TextBox ID="txtnomacompanante" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>RESPUESTA</td>
                <td>
                    <asp:Label ID="lblrespuesta" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnguardar" runat="server" OnClick="btnguardar_Click" Text="Guardar" />
                </td>
                <td>
                    <asp:Button ID="btnconsultar" runat="server" OnClick="btnconsultar_Click" Text="Consultar" />
                </td>
                <td>
                    <asp:Button ID="btneliminar" runat="server" Text="eliminar" OnClick="btneliminar_Click1" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
