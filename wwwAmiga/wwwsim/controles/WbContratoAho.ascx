<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbContratoAho.ascx.vb" Inherits="controles_WbContratoAho" %>
<style type="text/css">
    .style1
    {
        width: 30%;
        height: 109px;
    }
    .style4
    {
        width: 159px;
    }
    .style5
    {
        width: 52%;
        height: 256px;
    }
    .style6
    {
        width: 100%;
    }
</style>
<table cellpadding="0" cellspacing="0" class="style5">
    <tr>
        <td>
            <asp:label id="Label9" Width="330px" runat="server" ForeColor="MidnightBlue" Height="24px"
					Font-Size="Medium" Font-Names="Verdana" Font-Bold="True" BorderWidth="0px">IMPRESION DE DOCUMENTOS</asp:label>
        </td>
    </tr>
    <tr>
        <td>
            <table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td align="center" class="style4">
                        <asp:Label runat="server" Text="Cuenta de Ahorros:" Font-Names="Calibri" 
                            Font-Size="10pt" ForeColor="#000066" ID="Label90" Width="129px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox43" runat="server" Enabled="False" Font-Names="Calibri" 
                            Font-Size="12pt" Height="23px" Width="198px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style4">
                        <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Contrato" Width="109px" />
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style6">
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadioButton11" runat="server" Checked="True" 
                                        Font-Names="Verdana" Font-Size="8pt" GroupName="impresion3" 
                                        Text="Adverso" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadioButton12" runat="server" Font-Names="Verdana" 
                                        Font-Size="8pt" GroupName="impresion3" Text="Inverso" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style4" align="center">
                                    <asp:Button ID="Button5" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Height="30px" Text="Libro de Reg." Width="109px" />
                                </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style6">
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadioButton9" runat="server" Checked="True" 
                                        Font-Names="Verdana" Font-Size="8pt" GroupName="impresion2" 
                                        Text="Adverso" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadioButton10" runat="server" Font-Names="Verdana" 
                                        Font-Size="8pt" GroupName="impresion2" Text="Inverso" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
</table>
