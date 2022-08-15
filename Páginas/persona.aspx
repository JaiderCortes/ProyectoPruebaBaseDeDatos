<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/maestra.Master" CodeBehind="persona.aspx.vb" Inherits="Proyecto_con_Base_de_Datos.persona" %>
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
    &nbsp;<table class="auto-style10">
    <tr>
        <td class="auto-style12" colspan="4">Persona</td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">Id</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="276px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">Nombres</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox2" runat="server" Width="277px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo requerido</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">Apellidos</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox3" runat="server" Width="275px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo requerido</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">Documento</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox4" runat="server" Width="272px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo requerido</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">Dirección</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox5" runat="server" Width="270px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo requerido</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">Teléfono</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox6" runat="server" Width="273px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Campo requerido</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">Email</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox7" runat="server" Width="272px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox7" ErrorMessage="Email no válido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Email no válido</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">Ciudad</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="277px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">Tipo de documento</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList2" runat="server" Height="19px" Width="275px">
            </asp:DropDownList>
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
