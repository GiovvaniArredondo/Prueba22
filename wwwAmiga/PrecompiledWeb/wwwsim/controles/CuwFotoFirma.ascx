<%@ control language="vb" autoeventwireup="false" inherits="CuwFotoFirma, App_Web_pi2jwlis" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
    <title>Bloqueo / Desbloqueo a Cuentas de Ahorro</title>
    <style type="text/css">
        .style4
        {
            width: 87%;
        }
        .style5
        {
            width: 93%;
            height: 40px;
        }
        .style6
        {
            width: 531px;
        }
        .style7
        {
            height: 187px;
        }
    </style>
</head>
    <div>
			<asp:label id="Label5" Width="224px" Height="15px" Font-Size="Medium" Font-Names="Verdana"
				runat="server" ForeColor="#16387C" Font-Bold="True">FOTO Y FIRMA</asp:label>
        <table border="1" cellpadding="0" cellspacing="0" class="style4" 
            style="border-color: #003366">
            <tr>
                <td>
                    <table cellpadding="0" cellspacing="0" class="style5">
                        <tr>
                            <td>
                                <table cellpadding="0" cellspacing="0" class="style5">
                                    <tr>
                                        <td align="center" class="style6">
                    <asp:Image ID="foto_Image" runat="server" Visible="False" Height="423px" Width="360px" 
                                                BorderWidth="1px" />
                                        </td>
                                        <td align="center">
                                            <table cellpadding="0" cellspacing="0" class="style5">
                                                <tr>
                                                    <td align="center" class="style7">
                    <asp:Image ID="firma_Image" runat="server" Visible="False" Height="138px" Width="432px" BorderWidth="1px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <table cellpadding="0" cellspacing="0" class="style5">
                                                            <tr>
                                                                <td align="center">
                                                                    <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Text="Titular" 
                                                                        Width="100px" />
                                                                </td>
                                                                <td align="center">
                                                                    <asp:Button ID="Button2" runat="server" Font-Names="Calibri" Text="Segundo" 
                                                                        Width="100px" />
                                                                </td>
                                                                <td align="center">
                                                                    <asp:Button ID="Button3" runat="server" Font-Names="Calibri" Text="Tercero" 
                                                                        Width="100px" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <asp:Label ID="Label1" runat="server" Font-Names="Calibri"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <asp:Label ID="Label2" runat="server" Font-Names="Calibri"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <asp:Label ID="Label3" runat="server" Font-Names="Calibri"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <asp:textbox id="txtcodcli" Font-Names="Verdana" runat="server" Width="168px" Font-Size="8pt"
							Enabled="False" BorderWidth="1px" Visible="False"></asp:textbox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <asp:Label ID="Label4" runat="server" Font-Names="Calibri"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    
<script language='JavaScript'>
document.onkeydown=function (evt) {return (evt ? evt.which : event.keyCode) != 13;}
</script>
