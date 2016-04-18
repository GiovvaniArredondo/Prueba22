<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbUsFindPart.ascx.vb" Inherits="WbUsFindPart"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 69%;
    }
    .style2
    {
        width: 53px;
    }
    .style3
    {
        width: 96px;
    }
    .style4
    {
        width: 172px;
    }
    .style5
    {
        width: 56%;
    }
</style>
<head id="Head1" runat="server" />

<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0" 
    
    style="border: thin solid highlight; WIDTH: 542px; HEIGHT: 491px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD align="center">
			<asp:label id="Label1" Font-Size="Medium" Font-Names="Gill Sans MT" 
                runat="server" Width="384px"
				ForeColor="#16387C" Font-Bold="True" Height="15px">BUSQUEDA DE PARTIDAS O CHEQUES</asp:label>
        </TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" style="WIDTH: 424px; HEIGHT: 91px"
				align="center">
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
						<table cellpadding="0" cellspacing="0" class="style5">
                            <tr>
                                <td>
                        <asp:label id="lblClave1" Runat="server" Font-Names="Verdana" Font-Size="10pt">Buscar en:</asp:label>
                                </td>
                                <td>
                        <asp:DropDownList ID="cbxanos" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="17px" Width="99px">
                        </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
						<P align="left">
							<asp:RadioButton id="RdBFind1" Width="160px" runat="server" 
                                Text="Busca por No de Partida" Font-Names="Verdana"
								Font-Size="8pt" GroupName="busqueda"></asp:RadioButton></P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
						<P align="left">
							<asp:RadioButton id="RdBFind2" runat="server" Text="Busca por Descripcion" 
                                Width="153px" Font-Names="Verdana"
								Font-Size="8pt" Height="23px" GroupName="busqueda"></asp:RadioButton></P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
							<asp:RadioButton id="RdBFind3" runat="server" 
                            Text="Busca por Rangos de Fecha" Width="184px" Font-Names="Verdana"
								Font-Size="8pt" Height="23px" GroupName="busqueda"></asp:RadioButton>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
						<table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td class="style2">
                                    <asp:Label ID="Label2" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                        Text="Desde:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdfecini" runat="server" Font-Names="Calibri" 
                                        Font-Size="12pt" Height="23px" Width="95px"></asp:TextBox>
                                    <cc1:CalendarExtender ID="txtdfecini_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdfecini">
                                    </cc1:CalendarExtender>
                                </td>
                                <td class="style3">
                                    <asp:Label ID="Label3" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                        Text="Hasta:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdfecfin" runat="server" Font-Names="Calibri" 
                                        Font-Size="12pt" Height="23px" Width="93px"></asp:TextBox>
                                    <cc1:CalendarExtender ID="txtdfecfin_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdfecfin">
                                    </cc1:CalendarExtender>
                                </td>
                            </tr>
                        </table>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
			<TABLE id="Table4" cellSpacing="0" cellPadding="0" border="0" style="WIDTH: 437px; HEIGHT: 56px"
				align="center">
				<TR>
					<TD class="style4">
						<P align="right" style="FONT-SIZE: 8pt; FONT-FAMILY: Verdana">Nº Partida o 
							Descripcion: &nbsp;</P>
					</TD>
					<TD style="WIDTH: 228px">
						<asp:TextBox id="Txtdescri" Width="224px" runat="server" Font-Size="8pt" 
                            Font-Names="Verdana" AutoPostBack="True"></asp:TextBox></TD>
					<TD>
						<P align="center">
                            <asp:Button ID="Button1" runat="server" Font-Size="10pt" Text="Buscar" />
                        </P>
					</TD>
				</TR>
			</TABLE>
					</TD>
				</TR>
			</TABLE>
        </TD>
	</TR>
	<TR>
		<TD align="center">
			<DIV align="center">
				<asp:datagrid id="DgPartidas" BackColor="White" AutoGenerateColumns="False" BorderColor="#CCCCCC"
					BorderStyle="None" BorderWidth="1px" CellPadding="3" AllowSorting="True" Width="494px" 
                    runat="server" AllowPaging="True">
					<SelectedItemStyle Font-Bold="True" ForeColor="Maroon" BackColor="#669999" 
                        BorderColor="#336699" BorderWidth="1px"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="#FFFF99" />
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White" Font-Bold="False"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<HeaderStyle Font-Names="Californian FB" ForeColor="Blue"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" ForeColor="Blue"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn SortExpression="cNumcom" HeaderText="Numero de Partida">
							<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cNumcom") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.cNumcom", URLCodigo) %>' Target="_self">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="cGlosa" SortExpression="cGlosa" HeaderText="Descripcion de la Partida">
							<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="dfeccnt" SortExpression="dfeccnt" HeaderText="Fecha de Realizacion" DataFormatString="{0:dd-MM-yyyy}">
							<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					    <asp:BoundColumn DataField="ncargo" HeaderText="Cargos" SortExpression="ncargo">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Arial" 
                                Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Century Gothic" 
                                Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="nabono" HeaderText="Abonos" SortExpression="nabono">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Arial" 
                                Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Century Gothic" 
                                Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="ndifer" HeaderText="Dif." SortExpression="ndifer">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Arial" 
                                Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Century Gothic" 
                                Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                        </asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#003366" BackColor="White" 
                        Mode="NumericPages" Font-Bold="True"></PagerStyle>
				</asp:datagrid></DIV>
        </TD>
	</TR>
	<TR>
		<TD>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
		</TD>
	</TR>
</TABLE>
