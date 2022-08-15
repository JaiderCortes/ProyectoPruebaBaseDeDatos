<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/maestra.Master" CodeBehind="tipodoc.aspx.vb" Inherits="Proyecto_con_Base_de_Datos.tipodoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style10 {
            width: 54%;
            margin-top: 10px;
            margin-left: 40px;
        }
        .auto-style11 {
            width: 300px;
            text-align: right;
        }
        .auto-style6 {
            width: 300px;
        }
        .auto-style9 {
            width: 2095px;
            text-align: center;
        }
    .auto-style12 {
        text-align: center;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style10">
        <tr>
            <td class="auto-style12" colspan="4">Tipo de documento</td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="2">Id</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="276px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="2">Nombre</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox2" runat="server" Width="277px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo requerido</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Button ID="Button1" runat="server" BackColor="#339933" Text="Primer" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="Button2" runat="server" BackColor="#0066FF" Text="Anterior" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="Button3" runat="server" BackColor="#FF3300" Text="Siguiente" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="Button4" runat="server" BackColor="#CCCC00" Text="Ultimo" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Button ID="Button5" runat="server" BackColor="#009933" Text="Nuevo" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="Button6" runat="server" BackColor="#0033CC" Enabled="False" Text="Insertar" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="Button7" runat="server" BackColor="#99CC00" Text="Actualizar" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="Button8" runat="server" BackColor="Red" Text="Eliminar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
