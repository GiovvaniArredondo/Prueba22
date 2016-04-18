<%@ Control Language="VB" AutoEventWireup="false" CodeFile="cuwClave.ascx.vb" Inherits="controles_cuwClave" %>
<style type="text/css">
    .style33
    {
        width: 96%;
        height: 358px;
    }
    .style35
    {
        width: 52%;
        height: 264px;
    }
    .style36
    {
        width: 67%;
        height: 112px;
    }
    .style37
    {
        height: 64px;
        width: 232px;
    }
    .style38
    {
        width: 232px;
    }
    .style39
    {
        width: 167px;
    }
    .style40
    {
        height: 47px;
    }
    .style41
    {
        height: 41px;
    }
    .style42
    {
        width: 246px;
    }
    .style43
    {
        width: 167px;
        height: 38px;
    }
</style>
<table cellpadding="0" cellspacing="0" class="style33">
    <tr>
        <td class="style42">
            <table bgcolor="#8726FF" border="1" cellpadding="0" cellspacing="0" 
                class="style33">
                <tr>
                    <td class="style37">
			            <asp:image id="Image1" Width="231px" ImageUrl="../imagenes/cabecera.jpg" 
                            runat="server" Height="46px"></asp:image>
			        </td>
                </tr>
                <tr>
                    <td align="center" class="style38">
    <asp:image id="Image2" Width="200px" ImageUrl="~/imagenes/sim-logo copy2.GIF" 
        runat="server" Height="56px"></asp:image>
			        </td>
                </tr>
                <tr>
                    <td align="center" class="style38">
                        <asp:label id="Label10" 
                            Width="223px" runat="server" Height="27px" Font-Names="Verdana"
							Font-Size="9pt" ForeColor="#CCFF33" Font-Bold="True" BackColor="#8726FF">MF AMIGA</asp:label>
						</td>
                </tr>
                <tr>
                    <td align="center" class="style38">
                                    <asp:label id="Label11" Width="227px" 
                                        runat="server" Height="44px" Font-Names="Verdana"
										Font-Size="8pt" ForeColor="#CCFF66" Font-Bold="True" BackColor="#8726FF"></asp:label>
                                    </td>
                </tr>
                <tr>
                    <td align="center" class="style38">
                                    <asp:label id="Label12" Width="195px" runat="server" 
                            Font-Names="Verdana" Font-Size="6pt"
										ForeColor="#CCFF66" Font-Bold="True" BackColor="#8726FF"></asp:label>
                                    </td>
                </tr>
                <tr>
                    <td align="center" class="style38">
						<asp:hyperlink id="HyperLink2" runat="server" Height="24px" 
                            ForeColor="#CCFF66" NavigateUrl="http://www.mfamiga.com"
							Font-Names="Verdana" Font-Size="8pt" BackColor="#8726FF" Width="224px" Visible="False">http://www.mfamiga.com</asp:hyperlink>
					</td>
                </tr>
            </table>
        </td>
        <td>
            <table bgcolor="#8726FF" cellpadding="0" cellspacing="0" class="style35">
                <tr>
                    <td align="center" class="style40">
                                    <asp:Label ID="Label1" runat="server" BackColor="#009933" Font-Names="Calibri" 
                                        ForeColor="White" Text="Cambiar la contraseña" BorderColor="#000001" 
                                        BorderWidth="1px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table align="center" bgcolor="#F47FF7" border="1" cellpadding="0" 
                            cellspacing="0" class="style36" style="border-color: #003300">
                            <tr>
                                <td align="center" class="style39">
                                                <asp:Label ID="Label7" runat="server" Font-Names="Calibri" 
                                                    Text="Contraseña Actual:" Font-Size="9pt"></asp:Label>
                                            </td>
                                <td class="style39">
                                                <asp:textbox id="txtClave2" 
                            Width="100px" Runat="server" Font-Names="Verdana" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password" Height="21px"></asp:textbox>
                                            </td>
                            </tr>
                            <tr>
                                <td align="center" class="style39">
                                                <asp:Label ID="Label8" runat="server" Font-Names="Calibri" 
                                                    Text="Nueva Contraseña:" Font-Size="9pt"></asp:Label>
                                            </td>
                                <td class="style39">
                                                <asp:textbox id="txtClave0" 
                            Width="100px" Runat="server" Font-Names="Verdana" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password" Height="21px"></asp:textbox>
                                            </td>
                            </tr>
                            <tr>
                                <td align="center" class="style43">
                                                <asp:Label ID="Label9" runat="server" Font-Names="Calibri" 
                                                    Text="Confirmar Nueva Contraseña:" Font-Size="9pt"></asp:Label>
                                            </td>
                                <td class="style43">
                                                <asp:textbox id="txtClave1" 
                            Width="100px" Runat="server" Font-Names="Verdana" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password" Height="21px"></asp:textbox>
                                            </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style41">
                                    <asp:Label ID="Label5" runat="server" Font-Names="Calibri" ForeColor="#003300" 
                                        
                                        Text="Confirmar la nueva contraseña debe coincidir con la entrada Nueva contraseña." 
                                        Font-Size="9pt"></asp:Label>
                                </td>
                </tr>
                <tr>
                    <td align="center">
                                                <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Text="Confirmar" />
                                            </td>
                </tr>
            </table>
        </td>
    </tr>
</table>


