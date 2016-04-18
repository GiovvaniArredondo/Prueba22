<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCambiaLineaI.ascx.vb" Inherits="ucCambiaLineaI" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 59%;
        height: 58px;
    }
    .style2
    {
        color: #003399;
        font-weight: bold;
    }
    .style4
    {
        width: 108px;
    }
    .style5
    {
        width: 90%;
    }
    .style9
    {
        width: 108px;
        height: 32px;
    }
    .style10
    {
        height: 32px;
        width: 190px;
    }
    .style11
    {
        width: 108px;
        height: 69px;
    }
    .style12
    {
        height: 69px;
        width: 190px;
    }
    .style13
    {
        width: 108px;
        height: 24px;
    }
    .style14
    {
        height: 24px;
        width: 190px;
    }
    .style15
    {
        width: 178px;
    }
    .style16
    {
        height: 32px;
        width: 178px;
    }
    .style17
    {
        height: 24px;
        width: 178px;
    }
    .style18
    {
        height: 69px;
        width: 178px;
    }
    .style19
    {
        color: #003399;
        font-weight: bold;
        width: 190px;
    }
    .style20
    {
        width: 190px;
    }
</style>
<table class="style1" border="1" 
    style="border-color: #003300">
    <tr>
        <td class="style2" colspan="2" 
            style="text-align: center; font-family: calibri; font-size: 16px;">
            CAMBIAR LINEA DE CRÉDITO DE FORMA INDIVIDUAL<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </td>
        <td class="style19" 
            style="text-align: center; font-family: calibri; font-size: 16px;" 
            align="center">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="right" class="style4" style="font-family: calibri; font-size: 14px">
            Cliente:</td>
        <td class="style15">
            <table cellpadding="0" cellspacing="0" class="style5">
                <tr>
                    <td>
            <asp:TextBox ID="txtcnomgru" runat="server" Font-Names="Calibri" 
                Font-Size="12pt" Enabled="False" Height="21px" Width="352px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
        <td class="style20">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="right" class="style9" style="font-family: calibri; font-size: 14px">
            Crédito:</td>
        <td class="style16">
            <asp:TextBox ID="txtcCodsol" runat="server" Font-Names="Calibri" 
                Font-Size="12pt" Enabled="False"></asp:TextBox>
        </td>
        <td class="style10" align="center">
            <asp:Label ID="Label1" runat="server" Font-Names="Georgia" Text="Fondo"></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="right" class="style4" 
            style="border-color: #FFFFFF; font-family: calibri; font-size: 14px">
            Línea de Crédito Actual:</td>
        <td class="style15">
            <asp:DropDownList ID="DropDownLinea1" runat="server" Font-Names="Calibri" 
                Font-Size="10pt" Height="28px" Width="453px" BackColor="#FFFFCC" 
                Enabled="False">
            </asp:DropDownList>
        </td>
        <td class="style20">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Font-Names="Georgia" 
                Font-Size="10pt" Height="22px" Width="162px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" class="style13" 
            style="border-color: #FFFFFF; font-family: calibri; font-size: 14px">
            Fondo Asignar:</td>
        <td class="style17">
            <asp:DropDownList ID="cmbFondo" runat="server" Font-Names="Calibri" 
                Font-Size="10pt" Height="28px" Width="267px" BackColor="#CCFF33" 
                AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td class="style14">
        </td>
    </tr>
    <tr>
        <td align="right" class="style11" 
            style="border-color: #FFFFFF; font-family: calibri; font-size: 14px">
            Línea de Crédito a Asignar:</td>
        <td class="style18">
            <asp:DropDownList ID="DropDownLinea2" runat="server" Font-Names="Calibri" 
                Font-Size="10pt" Height="28px" Width="453px" BackColor="#CCFF33" 
                AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td class="style12">
            <asp:TextBox ID="TextBox2" runat="server" Enabled="False" Font-Names="Georgia" 
                Font-Size="10pt" Height="22px" Width="162px" Visible="False"></asp:TextBox>
            <br />
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                Text="Cambiar" />
            <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
                ConfirmText="Seguro de Aplicar Cambio?" Enabled="True" 
                TargetControlID="Button1">
            </cc1:ConfirmButtonExtender>
        </td>
        <td style="text-align: center" class="style20">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            &nbsp;</td>
        <td style="text-align: center" class="style20">
            &nbsp;</td>
    </tr>
    </table>
