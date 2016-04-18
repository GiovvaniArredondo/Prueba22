<%@ control language="VB" autoeventwireup="false" inherits="controles_Creditos_WbConFotos, App_Web_6e0px9a3" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        height: 28px;
    }
</style>

<TABLE id="Table1" style="WIDTH: 504px; HEIGHT: 303px" cellSpacing="0" cellPadding="0"
	width="504" border="0">
            <TR>
                <TD align="center">
                    &nbsp;</TD>
            </TR>
            <tr>
                <td align="center">
                </td>
            </tr>
            <TR>
                <TD align="center">
                    <TABLE id="Table8" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 466px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 246px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="466" border="0">
                        <TR>
                            <TD style="HEIGHT: 33px" align="center">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:label id="Label3" runat="server" Width="300px" Font-Bold="True" 
                            Font-Size="Small" Height="15px"
							Font-Names="Verdana" ForeColor="#16387C">Vista Previa Fotografias Digitales</asp:label>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 22px" align="center">
                                <TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
                                    <TR>
                                        <TD style="WIDTH: 143px" align="right">
                                            <asp:Image ID="ImageFoto" runat="server" Height="58px" Visible="False" 
                                                Width="83px" />
                                        </TD>
                                        <TD>
                                            &nbsp;</TD>
                                    </TR>
                                </TABLE>
                                <asp:textbox id="txtccodcli" runat="server" Width="21px" Visible="False"></asp:textbox>
                                <asp:textbox id="txtcnomcli" 
                            runat="server" Width="338px" Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True"></asp:textbox>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 15px" align="center">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblUsuario33" Runat="server" Font-Names="calibri" 
                                                Font-Size="9pt" style="text-align: left" Width="120px">Tipo de Fotografia</asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="cbxTipFoto" runat="server" Font-Names="Calibri" 
                                                Font-Size="10pt" Height="16px" Width="300px">
                                                <asp:ListItem Value="A">DOMICILIO</asp:ListItem>
                                                <asp:ListItem Value="B">NEGOCIO</asp:ListItem>
                                                <asp:ListItem Value="C">GARANTIAS</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                                <br />
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 20px" align="center">
                                <asp:Label ID="lblStatus" runat="server" Text="Label" Font-Names="Calibri" 
                                    Font-Size="9pt"></asp:Label>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 41px" align="center">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                            ID="btnGen" runat="server" Font-Bold="True" 
                            Font-Names="Calibri" Font-Size="11pt" Text="Visualizar" Width="100px" />
                                &nbsp;&nbsp;</TD>
                        </TR>
                        <TR>
                            <TD align="center">
                                &nbsp;</TD>
                        </TR>
                    </TABLE>
                    &nbsp;&nbsp;&nbsp;</TD>
            </TR>
            <TR>
                <TD>
                </TD>
            </TR>
        </TABLE>
    