<%@ control language="VB" autoeventwireup="false" inherits="ucCambiaagenciaI, App_Web_pi2jwlis" %>
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
        height: 13px;
    }
    .style12
    {
        height: 13px;
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
        width: 180px;
    }
    .style16
    {
        height: 32px;
        width: 180px;
    }
    .style17
    {
        height: 24px;
        width: 180px;
    }
    .style18
    {
        height: 13px;
        width: 180px;
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
    .style21
    {
        width: 108px;
        height: 83px;
    }
    .style22
    {
        height: 83px;
        width: 180px;
    }
    .style23
    {
        height: 83px;
        width: 190px;
    }
</style>
<table class="style1" border="1" 
    style="border-color: #003300; margin-right: 0px; width: 88%;">
    <tr>
        <td class="style2" colspan="2" 
            style="text-align: center; font-family: calibri; font-size: 16px;">
            CAMBIAR AGENCIA DE FORMA INDIVIDUAL<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </td>
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
    </tr>
    <tr>
        <td align="right" class="style9" style="font-family: calibri; font-size: 14px">
            Crédito:</td>
        <td class="style16">
            <asp:TextBox ID="txtcCodsol" runat="server" Font-Names="Calibri" 
                Font-Size="12pt" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" class="style21" 
            style="border-color: #FFFFFF; font-family: calibri; font-size: 14px">
            Agencia Actual:</td>
        <td class="style22">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Font-Names="Georgia" 
                Font-Size="10pt" Height="22px" Width="312px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" Enabled="False" Font-Names="Georgia" 
                Font-Size="10pt" Height="22px" Width="92px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" class="style13" 
            style="border-color: #FFFFFF; font-family: calibri; font-size: 14px">
            Nueva Agencia:</td>
        <td class="style17">
            <asp:DropDownList ID="cmbAgencia" runat="server" Font-Names="Calibri" 
                Font-Size="10pt" Height="25px" Width="166px" BackColor="#CCFF33" 
                AutoPostBack="True">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right" class="style11" 
            style="border-color: #FFFFFF; font-family: calibri; font-size: 14px">
            </td>
        <td class="style18">
            <asp:DropDownList ID="DropDownLinea2" runat="server" Font-Names="Calibri" 
                Font-Size="10pt" Height="28px" Width="453px" BackColor="#CCFF33" 
                AutoPostBack="True" Enabled="False" Visible="False">
            </asp:DropDownList>
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
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:DropDownList ID="DropDownLinea1" runat="server" Font-Names="Calibri" 
                Font-Size="10pt" Height="16px" Width="93px" BackColor="#FFFFCC" 
                Enabled="False" Visible="False">
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Font-Names="Georgia" Text="Fondo" 
                Visible="False"></asp:Label>
        </td>
    </tr>
    </table>
