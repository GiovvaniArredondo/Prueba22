<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCambiaFondoPartida.ascx.vb" Inherits="controles_ucCambiaFondoPartida" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 56%;
        height: 58px;
    }
    .style2
    {
        color: #003399;
        font-weight: bold;
    }
    .style3
    {
        color: #FF3300;
        font-weight: bold;
    }
    .style4
    {
        width: 101px;
    }
</style>
<table class="style1" bgcolor="#99FF66" border="1" 
    style="border-color: #003300">
    <tr>
        <td class="style2" colspan="2" 
            style="text-align: center; font-family: calibri; font-size: 16px;">
            CAMBIA PARTIDA DE FONDO</td>
    </tr>
    <tr>
        <td align="right" class="style4" style="font-family: calibri; font-size: 14px">
            Partida Nº:</td>
        <td>
            <asp:TextBox ID="TextBoxNumeroPartida" runat="server" Font-Names="Calibri" 
                Font-Size="12pt"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBoxNumeroPartida" 
                ErrorMessage="Debe ingresar un valor" Font-Names="Calibri" Font-Size="12pt"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td align="right" class="style4" 
            style="border-color: #FFFFFF; font-family: calibri; font-size: 14px">
            Fuente de Fondo:</td>
        <td>
            <asp:DropDownList ID="DropDownListFondos" runat="server" Font-Names="Calibri" 
                Font-Size="12pt">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:Button ID="ButtonCambiarFondo" runat="server" style="text-align: center" 
                Text="Cambiar Fondo" Font-Names="Calibri" Font-Size="10pt" />
            <cc1:ConfirmButtonExtender ID="ButtonCambiarFondo_ConfirmButtonExtender" 
                runat="server" ConfirmText="Esta Seguro del Cambio?" Enabled="True" 
                TargetControlID="ButtonCambiarFondo">
            </cc1:ConfirmButtonExtender>
        </td>
    </tr>
    <tr>
        <td class="style3" colspan="2" 
            style="text-align: left; font-family: Calibri; font-size: 12px; font-weight: bold;" 
            align="justify">
            Nota: Debe estar seguro que la partida no pertenece a 
            pagos,desembolso,reversiones, reclasificaion de cartera. ya que estas estan 
            divididas en varios fondos y esto puede causar problemas a la hora de cuadrar.</td>
    </tr>
</table>
