<%@ Control Language="vb" AutoEventWireup="false" Inherits="Login2" CodeFile="Login2.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<script language="javascript" type="text/javascript">
// <!CDATA[


// ]]>
</script>

<style type="text/css">
    .style2
    {
        width: 37%;
        height: 82px;
    }
    .style3
    {
        width: 94%;
        height: 3px;
    }
    .style15
    {
        width: 485px;
        height: 4px;
    }
    .style9
    {
        width: 100%;
        height: 4px;
    }
    .style10
    {
        width: 65%;
        height: 25px;
    }
    .style16
    {
        height: 25px;
    }
    .style12
    {
        width: 65%;
        height: 27px;
    }
    .style13
    {
        height: 27px;
    }
    .style5
    {
        width: 136px;
    }
    .style14
    {
        width: 131px;
    }
</style>
                        <table cellpadding="0" cellspacing="0" class="style2" 
    align="center">
                            <tr>
                                <td align="center" bgcolor="#3366CC">
                                    <asp:Label ID="Label1" runat="server" BackColor="#3366CC" Font-Names="Calibri" 
                                        ForeColor="White" Text="Cambiar la contraseña"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table align="center" cellpadding="0" cellspacing="0" class="style3">
                                        <tr>
                                            <td align="right" class="style15">
                                                <asp:Label ID="Label7" runat="server" Font-Names="Calibri" 
                                                    Text="Contraseña Actual:" Font-Size="9pt"></asp:Label>
                                            </td>
                                            <td class="style9">
                                                <asp:textbox id="txtClave2" 
                            Width="100px" Runat="server" Font-Names="Verdana" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password" Height="21px"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style10">
                                                <asp:Label ID="Label8" runat="server" Font-Names="Calibri" 
                                                    Text="Nueva Contraseña:" Font-Size="9pt"></asp:Label>
                                            </td>
                                            <td class="style16">
                                                <asp:textbox id="txtClave0" 
                            Width="100px" Runat="server" Font-Names="Verdana" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password" Height="21px"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style12">
                                                <asp:Label ID="Label9" runat="server" Font-Names="Calibri" 
                                                    Text="Confirmar Nueva Contraseña:" Font-Size="9pt"></asp:Label>
                                            </td>
                                            <td class="style13">
                                                <asp:textbox id="txtClave1" 
                            Width="100px" Runat="server" Font-Names="Verdana" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password" Height="21px"></asp:textbox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Label ID="Label5" runat="server" Font-Names="Calibri" ForeColor="Red" 
                                        
                                        Text="Confirmar la nueva contraseña debe coincidir con la entrada Nueva contraseña." 
                                        Font-Size="9pt"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table align="center" cellpadding="0" cellspacing="0" class="style5">
                                        <tr>
                                            <td align="center" class="style14">
                                                <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Text="Confirmar" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
        

