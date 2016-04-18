<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WbGoogleMaps.aspx.vb" Inherits="WbGoogleMaps" %>

<%@ Register Assembly ="GMaps"  Namespace="Subgurim.Controles" TagPrefix = "cc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 84%;
            height: 87px;
        }
        .style2
        {
            width: 129px;
        }
        .style3
        {
            width: 129px;
            height: 31px;
        }
        .style4
        {
            height: 31px;
        }
        .style5
        {
            height: 19px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td>
                    <table cellpadding="0" cellspacing="0" class="style1">
                        <tr>
                            <td>
        <cc:GMap ID="GMap1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                    Font-Size="11pt" Text="Buscar Ubicación"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButtonList ID="rbtnOpciones" runat="server" Font-Names="Calibri" 
                                    Font-Size="11pt" AutoPostBack="True">
                                    <asp:ListItem Value="A">Coordenadas</asp:ListItem>
                                    <asp:ListItem Value="B">Ubicación</asp:ListItem>                                    
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td class="style3">
                                            <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Names="Calibri" 
                                                Font-Size="11pt" Text="Latitud:"></asp:Label>
                                        </td>
                                        <td class="style4">
                                            <asp:TextBox ID="TxtLatitud" runat="server" BorderWidth="1px" 
                                                Font-Names="Calibri" Font-Size="12pt"></asp:TextBox>
                                        </td>
                                        <td class="style4">
                                <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Names="Calibri" 
                                    Font-Size="11pt" Text="Localidad:"></asp:Label>
                                        </td>
                                        <td class="style4">
                                <asp:TextBox ID="TxtLocalidad" runat="server" BorderWidth="1px" 
                                    Font-Names="Calibri" Font-Size="12pt" Width="300px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Names="Calibri" 
                                                Font-Size="11pt" Text="Longitud:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TxtLongitud" runat="server" BorderWidth="1px" 
                                                Font-Names="Calibri" Font-Size="12pt"></asp:TextBox>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style2">
                                            &nbsp;</td>
                                        <td>
                    <asp:Button ID="BtnIr" runat="server" Font-Bold="True" Font-Names="Calibri" 
                        Font-Size="10pt" Height="30px" Text="Cambiar" Width="150px" 
                        Enabled="False" />
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                    <asp:Button ID="Btnciudad" runat="server" Font-Bold="True" Font-Names="Calibri" 
                        Font-Size="10pt" Height="30px" Text="Ir ......." Width="150px" 
                        Enabled="False" />
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
            <tr>
                <td>
                    <table cellpadding="0" cellspacing="0" class="style1">
                        <tr>
                            <td class="style3">
                                <asp:Label ID="Label5" runat="server" Font-Bold="False" Font-Names="Calibri" 
                                    Font-Size="11pt" Text="Latitud:"></asp:Label>
                            </td>
                            <td class="style4">
                                <asp:Label ID="LblLatitud" runat="server" Font-Names="Calibri" Font-Size="11pt" 
                                    ForeColor="Maroon" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label6" runat="server" Font-Bold="False" Font-Names="Calibri" 
                                    Font-Size="11pt" Text="Longitud:"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="LblLongitud" runat="server" Font-Names="Calibri" 
                                    Font-Size="11pt" ForeColor="Maroon" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label9" runat="server" Font-Bold="False" Font-Names="Calibri" 
                                    Font-Size="11pt" Text="Tipo de Mapa:"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ListaTipoMapa" runat="server" Font-Names="Calibri" 
                                    Font-Size="10pt">
                                    <asp:ListItem Value="A">Normal</asp:ListItem>
                                    <asp:ListItem Value="B">Satelital</asp:ListItem>
                                    <asp:ListItem Value="C">Hibrido</asp:ListItem>
                                    <asp:ListItem Value="D">Fisico</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Button ID="BtnVer" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                    Font-Size="10pt" Height="30px" Text="Ver" Width="40px" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
