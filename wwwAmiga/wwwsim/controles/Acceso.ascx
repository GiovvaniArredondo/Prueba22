<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Acceso.ascx.vb" Inherits="Acceso" %>
<style type="text/css">
    .style35
    {
        width: 100%;
        height: 167px;
    }
    .style40
    {
        height: 47px;
    }
    .style36
    {
        width: 52%;
        height: 53px;
    }
    .style39
    {
        width: 96px;
    }
    .style41
    {
        width: 49%;
        height: 244px;
    }
</style>
<table border="1" cellpadding="0" cellspacing="0" class="style41">
    <tr>
        <td align="center">
            <table bgcolor="#FFFF99" cellpadding="0" cellspacing="0" class="style35" 
                align="center">
                <tr>
                    <td align="center" class="style40">
                                    <asp:Label ID="Label1" runat="server" BackColor="#009933" Font-Names="Calibri" 
                                        ForeColor="White" Text="Autorizar Operación" BorderColor="#000001" 
                                        BorderWidth="1px" Width="300px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table align="center" bgcolor="#99FF33" border="1" cellpadding="0" 
                            cellspacing="0" class="style36" 
                            style="border-color: #003300; height: 86px;">
                            <tr>
                                <td align="right" class="style39">
                        <asp:label id="lblClave0" Runat="server" Font-Names="Gill Sans MT">Usuario:</asp:label>
                                            </td>
                                <td>
                                                <asp:textbox id="txtusuario" 
                            Width="126px" Runat="server" Font-Names="Gill Sans MT" BorderColor="Black"
							Font-Size="14pt" BorderWidth="1px"></asp:textbox>
                                            </td>
                            </tr>
                            <tr>
                                <td align="right" class="style39">
                        <asp:label id="lblClave" Runat="server" Font-Names="Gill Sans MT">Clave:</asp:label>
                                            </td>
                                <td>
                                                <asp:textbox id="txtClave" 
                            Width="126px" Runat="server" Font-Names="Gill Sans MT" BorderColor="Black"
							Font-Size="14pt" TextMode="Password" BorderWidth="1px"></asp:textbox>
                                            </td>
                            </tr>
                            </table>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                                                <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Text="Aceptar" 
                                                    Font-Size="12pt" Width="110px" />
                                            </td>
                </tr>
            </table>
        </td>
    </tr>
</table>



