<%@ control language="vb" autoeventwireup="false" inherits="CuwNotas, App_Web_yjxjq67i" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
    <title>Notas</title>
    <style type="text/css">
        .style4
        {
            width: 51%;
        }
        .style7
        {
            width: 94%;
            height: 53px;
        }
        .style9
        {
            width: 275px;
        }
        .style10
        {
            width: 100%;
        }
    </style>
</head>
    <div>
    </div>
    
<script language='JavaScript'>
document.onkeydown=function (evt) {return (evt ? evt.which : event.keyCode) != 13;}
</script>
        <table border="1" cellpadding="0" cellspacing="0" class="style4" 
            style="border-color: #003366; height: 369px;">
            <tr>
                <td align="center">
                    <table cellpadding="0" cellspacing="0" class="style10">
                        <tr>
                            <td align="center">
			<asp:label id="Label4" Width="257px" Height="15px" Font-Size="Medium" Font-Names="Verdana"
				runat="server" ForeColor="#16387C" Font-Bold="True">NOTAS DE GESTIONES</asp:label>
                                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table cellpadding="0" cellspacing="0" class="style7">
                                    <tr>
                                        <td align="right" class="style9">
                                                <asp:label id="Label57" Font-Size="12pt" runat="server" Font-Names="Calibri" 
                                                    Width="167px">Nº de Prestamo:</asp:label>
                                            </td>
                                        <td>
                                                        <asp:textbox id="txtccodcta" Font-Names="Verdana" runat="server" 
                                                Width="270px" Font-Size="8pt"
							Enabled="False" BorderWidth="1px"></asp:textbox>
                                                    </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style9">
                                                <asp:label id="Label55" Font-Size="12pt" runat="server" Font-Names="Calibri" 
                                                    Width="167px">Nota:</asp:label>
                                            </td>
                                        <td>
                                                <asp:TextBox ID="Txtnota" runat="server" Font-Names="Calibri" 
                                                    Font-Size="10pt" Height="61px" TextMode="MultiLine" Width="236px"></asp:TextBox>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style9">
                                                <asp:label id="Label56" Font-Size="12pt" runat="server" Font-Names="Calibri" 
                                                    Width="211px">Dias de validez de la nota:</asp:label>
                                            </td>
                                        <td>
                                            <asp:TextBox ID="txtndias" runat="server" Width="61px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style9">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                                ControlToValidate="txtndias" ErrorMessage="RangeValidator" MaximumValue="99999" 
                                                MinimumValue="1" Type="Double">Dias invalidos</asp:RangeValidator>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <table align="center" cellpadding="0" cellspacing="0" class="style7">
                                    <tr>
                                        <td align="center">
                                                <asp:Button ID="btnnuevo" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                                    Text="Nuevo" Width="70px" Height="29px" Visible="False" />
                                            </td>
                                        <td align="center">
                                                <asp:Button ID="btngrabar" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                                    Text="Grabar" Width="70px" />
                                            </td>
                                        <td align="center">
                                                <asp:Button ID="btnmodificar" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                                    Text="Modificar" Width="70px" />
                                            </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                                        <asp:textbox id="txtccodcli" Font-Names="Verdana" 
                                    runat="server" Width="115px" Font-Size="8pt"
							Enabled="False" BorderWidth="1px" Visible="False"></asp:textbox>
                                                    </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
