<%@ Control Language="VB" AutoEventWireup="false" CodeFile="wbAutoFirmas.ascx.vb" Inherits="controles_wbAutoFirmas" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 64%;
        height: 161px;
    }
    .style5
    {
        width: 492px;
        height: 187px;
    }
    .style6
    {
        width: 529px;
    }
    .style7
    {
        width: 547px;
    }
    .style8
    {
        width: 529px;
        height: 35px;
    }
    .style9
    {
        width: 547px;
        height: 35px;
    }
    .style10
    {
        width: 529px;
        height: 33px;
    }
    .style11
    {
        width: 547px;
        height: 33px;
    }
    .style12
    {
        height: 43px;
    }
    .style13
    {
        width: 529px;
        height: 36px;
    }
    .style14
    {
        width: 547px;
        height: 36px;
    }
</style>
<table border="0" cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td align =center >
            <asp:label id="Label9" Width="542px" runat="server" ForeColor="MidnightBlue" Height="15px"
					Font-Size="Medium" Font-Names="Verdana" Font-Bold="True" BorderWidth="0px">AUTORIZADOS A RETIRAR DE CUENTA DE AHORRO</asp:label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center">
            <table cellpadding="0" cellspacing="0" class="style5">
                <tr>
                    <td 
                    class="style13">
                        <asp:Label runat="server" Text="Cuenta de Ahorros:" Font-Names="Calibri" 
                            Font-Size="10pt" ForeColor="#000066" ID="Label90"></asp:Label>
                    </td>
                    <td 
                    class="style14">
                        <asp:TextBox ID="TextBox43" runat="server" Enabled="False" Font-Names="Calibri" 
                            Font-Size="12pt" Height="23px" Width="198px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td 
                    class="style6">
                        <asp:Label runat="server" Text="Primer Autorizado:" Font-Names="Calibri" 
                            Font-Size="10pt" ForeColor="#000066" ID="Label87"></asp:Label>
                    </td>
                    <td 
                    class="style7">
                        <asp:TextBox runat="server" Height="23px" Width="285px" ID="TextBox7"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td 
                        class="style8">
                        <asp:Label runat="server" Text="Fecha de Nac." Font-Names="Calibri" Font-Size="10pt" ForeColor="#000066" ID="Label88"></asp:Label>
                    </td>
                    <td 
                        class="style9">
                        <asp:TextBox runat="server" Height="23px" Width="98px" ID="TextBox38"></asp:TextBox>
                        <cc1:CalendarExtender runat="server" Format="dd/MM/yyyy" Enabled="True" TargetControlID="TextBox38" ID="TextBox38_CalendarExtender">
                        </cc1:CalendarExtender>
                    </td>
                </tr>
                <tr>
                    <td 
                        class="style6">
                        <asp:Label runat="server" Text="DUI:" Font-Names="Calibri" Font-Size="10pt" ForeColor="#000066" ID="Label89"></asp:Label>
                    </td>
                    <td 
                        class="style7">
                        <asp:TextBox runat="server" Height="20px" Width="160px" ID="TextBox41" 
                            MaxLength="10"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td 
                        class="style6">
                        &nbsp;</td>
                    <td 
                        class="style7">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td 
                        class="style6">
                        <asp:Label runat="server" Text="Segundo Autorizado:" Font-Names="Calibri" 
                            Font-Size="10pt" ForeColor="#000066" ID="Label19"></asp:Label>
                    </td>
                    <td 
                        class="style7">
                        <asp:TextBox runat="server" Height="20px" Width="283px" ID="TextBox8"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td 
                        class="style10">
                        <asp:Label runat="server" Text="Fecha de Nac." Font-Names="Calibri" Font-Size="10pt" ForeColor="#000066" ID="Label20"></asp:Label>
                    </td>
                    <td 
                        class="style11">
                        <asp:TextBox runat="server" Height="23px" Width="98px" ID="TextBox39"></asp:TextBox>
                        <cc1:CalendarExtender runat="server" Format="dd/MM/yyyy" Enabled="True" TargetControlID="TextBox39" ID="TextBox39_CalendarExtender">
                        </cc1:CalendarExtender>
                    </td>
                </tr>
                <tr>
                    <td 
                        class="style6">
                        <asp:Label runat="server" Text="DUI:" Font-Names="Calibri" Font-Size="10pt" ForeColor="#000066" ID="Label21"></asp:Label>
                    </td>
                    <td 
                        class="style7">
                        <asp:TextBox runat="server" Height="20px" Width="161px" ID="TextBox42" 
                            MaxLength="10" style="margin-bottom: 0px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="center" class="style12">
            <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                Text="Grabar" />
            <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
                ConfirmText="Seguro de Grabar?" Enabled="True" TargetControlID="Button1">
            </cc1:ConfirmButtonExtender>
        </td>
    </tr>
</table>
