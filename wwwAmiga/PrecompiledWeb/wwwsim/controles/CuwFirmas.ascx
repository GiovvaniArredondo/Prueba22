<%@ control language="vb" autoeventwireup="false" inherits="CuwFirmas, App_Web_yjxjq67i" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
    <%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
    <title>Bloqueo / Desbloqueo a Cuentas de Ahorro</title>
    <style type="text/css">
        .style4
        {
            width: 61%;
        }
        .style5
        {
            width: 86%;
            height: 286px;
        }
        .style21
        {
            width: 435px;
            height: 164px;
        }
    </style>
</head>
    <div>
        <table border="1" cellpadding="0" cellspacing="0" class="style4" 
            style="border-color: #003366; height: 322px;">
            <tr>
                <td>
                    <table cellpadding="0" cellspacing="0" class="style5" align="center">
                        <tr>
                            <td align="center">
                                <asp:Label runat="server" Text="AUTORIZACION DE FIRMAS" Font-Names="Calibri" 
                                    Font-Size="18pt" ForeColor="#000066" ID="Label101" Font-Bold="True"></asp:Label>
                                                        <asp:textbox id="txtcodcli" Font-Names="Verdana" runat="server" Width="168px" Font-Size="8pt"
							Enabled="False" BorderWidth="1px" Visible="False"></asp:textbox>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <table cellpadding="0" cellspacing="0" class="style21" align="center">
                                    <tr>
                                        <td class="style23" align="right">
                                            <asp:Label runat="server" Text="Primer Autorizado:" Font-Names="Calibri" 
                                                Font-Size="10pt" ForeColor="#000066" ID="Label102"></asp:Label>
                                        </td>
                                        <td class="style24" align="left">
                                            <asp:TextBox runat="server" Height="20px" Width="160px" ID="TextBox7" 
                                                BorderWidth="1px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style23" align="right">
                                            <asp:Label runat="server" Text="Fecha de Nac." Font-Names="Calibri" Font-Size="10pt" ForeColor="#000066" ID="Label103"></asp:Label>
                                        </td>
                                        <td class="style24">
                                            <asp:TextBox runat="server" Height="20px" Width="160px" ID="TextBox38" 
                                                BorderWidth="1px"></asp:TextBox>
                                            <cc1:CalendarExtender runat="server" Format="dd/MM/yyyy" Enabled="True" TargetControlID="TextBox38" ID="TextBox38_CalendarExtender">
                                            </cc1:CalendarExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style23" align="right">
                                            <asp:Label runat="server" Text="Cedula/DPI:" Font-Names="Calibri" 
                                                Font-Size="10pt" ForeColor="#000066" ID="Label104"></asp:Label>
                                        </td>
                                        <td class="style24">
                                            <asp:TextBox runat="server" Height="20px" Width="160px" ID="TextBox41" 
                                                BorderWidth="1px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style23" align="right">
                                            <asp:Label runat="server" Text="Segundo Autorizado:" Font-Names="Calibri" 
                                                Font-Size="10pt" ForeColor="#000066" ID="Label105"></asp:Label>
                                        </td>
                                        <td class="style24">
                                            <asp:TextBox runat="server" Height="20px" Width="160px" ID="TextBox42" 
                                                BorderWidth="1px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style23" align="right">
                                            <asp:Label runat="server" Text="Fecha de Nac." Font-Names="Calibri" 
                                                Font-Size="10pt" ForeColor="#000066" ID="Label106"></asp:Label>
                                        </td>
                                        <td class="style24">
                                            <asp:TextBox runat="server" Height="20px" Width="160px" ID="TextBox43" 
                                                BorderWidth="1px"></asp:TextBox>
                                            <cc1:CalendarExtender runat="server" Format="dd/MM/yyyy" Enabled="True" 
                                                TargetControlID="TextBox43" ID="TextBox43_CalendarExtender">
                                            </cc1:CalendarExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style23" align="right">
                                            <asp:Label runat="server" Text="Cedula/DPI:" Font-Names="Calibri" Font-Size="10pt" 
                                                ForeColor="#000066" ID="Label107"></asp:Label>
                                        </td>
                                        <td class="style24">
                                            <asp:TextBox runat="server" Height="20px" Width="160px" ID="TextBox44" 
                                                BorderWidth="1px"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                    Text="Grabar" Width="93px" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                            <asp:TextBox runat="server" Height="20px" Width="70px" ID="TextBox45" 
                                                BorderWidth="1px" Visible="False"></asp:TextBox>
                                            <asp:TextBox runat="server" Height="20px" Width="70px" ID="TextBox46" 
                                                BorderWidth="1px" Visible="False"></asp:TextBox>
                                            <asp:TextBox runat="server" Height="20px" Width="70px" ID="TextBox47" 
                                                BorderWidth="1px" Visible="False"></asp:TextBox>
                                        </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    
<script language='JavaScript'>
document.onkeydown=function (evt) {return (evt ? evt.which : event.keyCode) != 13;}
</script>
