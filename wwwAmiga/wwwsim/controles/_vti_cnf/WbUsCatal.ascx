<%@ Control Language="vb" AutoEventWireup="false" Codebehind="WbUsCatal.ascx.vb" Inherits="wwwSIM.WbUsCatal" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="472" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 472px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 342px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="WIDTH: 732px" align="center">
			<asp:label id="Label1" Font-Size="Medium" Font-Names="Verdana" runat="server" Width="248px"
				ForeColor="#16387C" Font-Bold="True" Height="15px">CATALOGO DE CUENTAS</asp:label></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 733px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="171" border="0" style="WIDTH: 171px; HEIGHT: 53px"
				align="center">
				<TR>
					<TD style="WIDTH: 211px">
						<P align="left">
							<asp:RadioButton id="Rdbcuenta" runat="server" Text="Busca por Cuenta" Font-Names="Verdana" Font-Size="8pt"
								AutoPostBack="True"></asp:RadioButton></P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 211px">
						<P align="left">
							<asp:RadioButton id="RdbDescrip" runat="server" Text="Busca por Descripcion" Font-Names="Verdana"
								Font-Size="8pt" AutoPostBack="True"></asp:RadioButton></P>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="347" border="0" style="WIDTH: 347px; HEIGHT: 61px"
				align="center">
				<TR>
					<TD>
						<P style="FONT-SIZE: 8pt; FONT-FAMILY: Verdana" align="right">Cuenta&nbsp;o 
							Descripcion a Buscar :
						</P>
					</TD>
					<TD style="WIDTH: 151px">
						<asp:TextBox id="TxtDescri" runat="server" Width="152px" Font-Size="8pt" Font-Names="Verdana"></asp:TextBox></TD>
					<TD><INPUT id="Button1" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar_b.jpg); WIDTH: 62px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
							type="button" name="Button2" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 732px">
			<DIV align="center">&nbsp;</DIV>
			<DIV align="center">
				<asp:datagrid id="DgCatalogo" runat="server" Width="447px" BackColor="White" AutoGenerateColumns="False"
					BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AllowSorting="True">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<HeaderStyle Font-Names="Californian FB" ForeColor="Blue"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" ForeColor="Blue"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn SortExpression="cCodcta" HeaderText="Cuenta Contable">
							<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cCodcta") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.cCodcta", URLCodigo) %>' Target="_self">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="cDescri" SortExpression="cDescri" HeaderText="Descripcion de la Cuenta">
							<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
</TABLE>
