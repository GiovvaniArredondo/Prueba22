<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbUsFindPartBan.ascx.vb" Inherits="WbUsFindPartBan"  %>
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
        width: 100px;
    }
    .style5
    {
        width: 100%;
    }
    .style6
    {
        width: 196px;
    }
</style>
<head id="Head1" runat="server" />

<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0" 
    
    
    style="border: thin solid highlight; WIDTH: 603px; HEIGHT: 491px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD align="center">
			<asp:label id="Label1" Font-Size="Medium" Font-Names="Verdana" runat="server" Width="384px"
				ForeColor="#16387C" Font-Bold="True" Height="15px">BUSQUEDA DE PARTIDAS BANCARIAS</asp:label>
        </TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" style="WIDTH: 511px; HEIGHT: 91px"
				align="center">
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
						<asp:CheckBox ID="CheckBox3" runat="server" BackColor="#FFFF66" 
                            Font-Names="Calibri" Font-Size="10pt" Text="Buscar por Rangos de Fecha" />
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
						&nbsp;</TD>
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
						<table cellpadding="0" cellspacing="0" class="style5">
                            <tr>
                                <td align="right">
                                    <asp:Label ID="Label5" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                        Text="Nº de Partida ó Descrip." Width="147px"></asp:Label>
                                </td>
                                <td>
						<asp:TextBox id="Txtdescri" Width="224px" runat="server" Font-Size="8pt" 
                            Font-Names="Verdana" AutoPostBack="True"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
							<asp:RadioButton id="RdBFind4" runat="server" 
                            Text="Otros Criterios:" Width="184px" Font-Names="Verdana"
								Font-Size="8pt" Height="23px" GroupName="busqueda"></asp:RadioButton>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
			<TABLE id="Table4" cellSpacing="0" cellPadding="0" border="0" style="WIDTH: 498px; HEIGHT: 56px"
				align="center">
				<TR>
					<TD class="style4" align="right">
                                    <asp:Label ID="Label4" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                        Text="Banco:"></asp:Label>
					</TD>
					<TD class="style6">
                        <asp:DropDownList ID="cmbBancos" runat="server" BackColor="#FFFF66" 
                            Font-Names="Verdana" Font-Size="8pt" Height="16px" Width="300px">
                        </asp:DropDownList>
                        </TD>
					<TD>
						<asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Calibri" 
                            Font-Size="10pt" Text="Todos" Checked="True" />
					</TD>
				</TR>
				<TR>
					<TD class="style4" align="right">
                                    <asp:Label ID="Label6" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                        Text="Nº de Cheque:" Visible="False"></asp:Label>
					</TD>
					<TD class="style6">
                        <asp:TextBox ID="TextBox1" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Visible="False"></asp:TextBox>
                        </TD>
					<TD>
						<asp:CheckBox ID="CheckBox2" runat="server" Font-Names="Calibri" 
                            Font-Size="10pt" Text="Todos" Checked="True" Visible="False" />
					</TD>
				</TR>
				</TABLE>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
			            &nbsp;</TD>
				</TR>
			</TABLE>
        </TD>
	</TR>
	<TR>
		<TD align="center">
			&nbsp;</TD>
	</TR>
	<TR>
		<TD align="center">
                            <asp:Button ID="Button1" runat="server" Font-Size="10pt" Text="Buscar" />
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
