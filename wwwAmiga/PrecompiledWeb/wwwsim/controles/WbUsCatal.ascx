<%@ control language="vb" autoeventwireup="false" inherits="WbUsCatal, App_Web_yl8dokps" %>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 472px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 342px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="472" border="0">
	<TR>
		<TD style="WIDTH: 732px" align="center"><asp:label id="Label1" Height="15px" Font-Bold="True" ForeColor="#16387C" Width="248px" runat="server"
				Font-Names="Verdana" Font-Size="Medium">CATALOGO DE CUENTAS</asp:label></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 733px">
			<TABLE id="Table2" style="WIDTH: 171px; HEIGHT: 53px" cellSpacing="0" cellPadding="0" width="171"
				align="center" border="0">
				<TR>
					<TD style="WIDTH: 211px">
						<P align="left"><asp:radiobutton id="Rdbcuenta" runat="server" Font-Names="Verdana" 
                                Font-Size="8pt" AutoPostBack="True"
								Text="Busca por Cuenta" Checked="True" GroupName="opcion"></asp:radiobutton></P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 211px">
						<P align="left"><asp:radiobutton id="RdbDescrip" runat="server" 
                                Font-Names="Verdana" Font-Size="8pt" AutoPostBack="True"
								Text="Busca por Descripcion" GroupName="opcion"></asp:radiobutton></P>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" style="WIDTH: 347px; HEIGHT: 61px" cellSpacing="0" cellPadding="0" width="347"
				align="center" border="0">
				<TR>
					<TD>
						<P style="FONT-SIZE: 8pt; FONT-FAMILY: Verdana" align="right">Cuenta&nbsp;o 
							Descripcion a Buscar :
						</P>
					</TD>
					<TD style="WIDTH: 151px"><asp:textbox id="TxtDescri" Width="152px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:textbox></TD>
					<TD><INPUT id="Button1" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar_b.jpg); WIDTH: 62px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
							type="button" name="Button2" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 732px">
			<DIV align="center">&nbsp;</DIV>
			<DIV align="center"><asp:datagrid id="DgCatalogo" Width="447px" runat="server" 
                    AllowSorting="True" CellPadding="3"
					BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC" AutoGenerateColumns="False" 
                    BackColor="White" AllowPaging="True">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="#CCFF66" />
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
