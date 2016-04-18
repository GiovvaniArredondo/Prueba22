<%@ Control Language="vb" AutoEventWireup="false" Codebehind="WbUsFindPart.ascx.vb" Inherits="wwwSIM.WbUsFindPart" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="480" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 480px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 304px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD align="center">
			<asp:label id="Label1" Font-Size="Medium" Font-Names="Verdana" runat="server" Width="384px"
				ForeColor="#16387C" Font-Bold="True" Height="15px">BUSQUEDA DE PARTIDAS O CHEQUES</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 111px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="180" border="0" style="WIDTH: 180px; HEIGHT: 54px"
				align="center">
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
						<P align="left">
							<asp:RadioButton id="RdBFind1" Width="160px" runat="server" Text="Busca por No de Partida" Font-Names="Verdana"
								Font-Size="8pt" AutoPostBack="True"></asp:RadioButton></P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 390px; HEIGHT: 19px">
						<P align="left">
							<asp:RadioButton id="RdBFind2" runat="server" Text="Busca por Descripcion" Width="153px" Font-Names="Verdana"
								Font-Size="8pt" AutoPostBack="True" Height="23px"></asp:RadioButton></P>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="373" border="0" style="WIDTH: 373px; HEIGHT: 56px"
				align="center">
				<TR>
					<TD style="WIDTH: 71px">
						<P align="right" style="FONT-SIZE: 8pt; FONT-FAMILY: Verdana">Nº Partida o 
							Descripcion: &nbsp;</P>
					</TD>
					<TD style="WIDTH: 228px">
						<asp:TextBox id="Txtdescri" Width="224px" runat="server" Font-Size="8pt" Font-Names="Verdana"></asp:TextBox></TD>
					<TD>
						<P align="center"><INPUT id="btnfind" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD>
			<DIV align="center">
				<asp:datagrid id="DgPartidas" BackColor="White" AutoGenerateColumns="False" BorderColor="#CCCCCC"
					BorderStyle="None" BorderWidth="1px" CellPadding="3" AllowSorting="True" Width="475px" runat="server">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
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
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
</TABLE>
