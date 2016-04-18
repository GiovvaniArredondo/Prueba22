<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbUCfindlinAho.ascx.vb" Inherits="controles_WbUCfindlinAho" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style3
    {
        height: 50px;
    }
    .style4
    {
        height: 40px;
    }
</style>
<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <TABLE id="Table1" cellSpacing="0" cellPadding="0" width="520" border="0" 
    
                        style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 520px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 360px">
                        <TR>
                            <TD class="style3">
                                <P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">
                                    LINEA DE AHORROS<asp:Label ID="Label3" runat="server"></asp:Label>
                                    <asp:Label ID="Label5" runat="server" Height="8px" Width="24px"></asp:Label>
                                </P>
                            </TD>
                        </TR>
                        <TR>
                            <TD bgColor="#ffffff" class="style4">
                                <TABLE id="Table2" cellSpacing="0" cellPadding="0" width="472" border="0" 
                style="HEIGHT: 56px">
                                    <TR>
                                        <TD style="WIDTH: 187px">
                                            <P align="right" style="BACKGROUND-COLOR: #ffffff">
                                                <asp:label id="Label1" Width="122px" runat="server" ForeColor="SlateBlue" 
                                Height="11px" Font-Size="8pt"
								Font-Names="Verdana">Nombre de Línea:</asp:label>
                                                <asp:label id="Label2" Width="32px" runat="server" ForeColor="Yellow" 
                                Height="18px" Font-Size="6pt"
								Font-Names="Century Gothic" Visible="False"></asp:label>
                                            </P>
                                        </TD>
                                        <TD style="WIDTH: 219px">
                                            <P align="left">
                                                <asp:textbox id="TxtNombre" tabIndex="1" 
                                Width="208px" runat="server" ToolTip="Digite el Nombre del Cliente"
								Font-Names="Verdana" Font-Size="8pt"></asp:textbox>
                                            </P>
                                        </TD>
                                        <TD>
                                            <P align="left">
                                                <INPUT style="BACKGROUND-IMAGE: url('file:///C:/Fuentes/wwwCopadeo/wwwsim/controles/Web/jpgs/btn_buscar2_b.gif'); WIDTH: 56px;BACKGROUND-REPEAT: no-repeat;HEIGHT: 48px;BACKGROUND-COLOR: transparent"
								type="button" id="Button2" name="Button2" runat="server">
                                            </P>
                                        </TD>
                                    </TR>
                                </TABLE>
                            </TD>
                        </TR>
                        <TR>
                            <TD bgColor="#ffffff">
                                <asp:GridView ID="Grid_Lineas" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" Caption="Lineas de Crédito" CssClass="grid" 
                                    Width="578px">
                                    <Columns>
                                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                            <controlstyle font-names="Gill Sans MT" font-size="9pt" />
                                            <HeaderStyle BackColor="#99CCFF" />
                                        </asp:CommandField>
                                        <asp:BoundField DataField="cnrolin" HeaderText="Numero de Linea">
                                            <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="cdeslin" HeaderText="Descripción de Linea" 
                                            ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                            <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="350px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="ccodlin" HeaderText="Código de Linea">
                                            <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="ntasint" HeaderText="Tasa de Interes">
                                            <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:BoundField>
                                    </Columns>
                                    <PagerTemplate>
                                        Página
                                        <asp:DropDownList ID="paginasDropDownList" runat="server" AutoPostBack="true" 
                                            Font-Size="12px" 
                                            onselectedindexchanged="paginasDropDownList_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        de
                                        <asp:Label ID="lblTotalNumberOfPages" runat="server" />
                                        <asp:Button ID="Button4" runat="server" CommandArgument="First" 
                                            CommandName="Page" CssClass="pagfirst" ToolTip="Prim. Pag" />
                                        <asp:Button ID="Button5" runat="server" CommandArgument="Prev" 
                                            CommandName="Page" CssClass="pagprev" ToolTip="Pág. anterior" />
                                        <asp:Button ID="Button6" runat="server" CommandArgument="Next" 
                                            CommandName="Page" CssClass="pagnext" ToolTip="Sig. página" />
                                        <asp:Button ID="Button3" runat="server" CommandArgument="Last" 
                                            CommandName="Page" CssClass="paglast" ToolTip="Últ. Pag" 
                                            onclick="Button3_Click" />
                                    </PagerTemplate>
                                    <PagerStyle CssClass="pagerstyle" />
                                    <AlternatingRowStyle BackColor="#99CCFF" />
                                </asp:GridView>
                            </TD>
                        </TR>
                    </TABLE>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>

