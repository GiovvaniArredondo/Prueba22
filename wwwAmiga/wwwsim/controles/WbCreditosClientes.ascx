<%@ Control Language="vb" AutoEventWireup="false" Inherits="WbCreditosClientes" CodeFile="WbCreditosClientes.ascx.vb" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD>
			<DIV align="center">
				<asp:datagrid id="dgCreditosCLiente" AllowSorting="True" AutoGenerateColumns="False" BorderColor="#CCCCCC"
					BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" runat="server" Width="573px">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<HeaderStyle Font-Names="'Verdana'"></HeaderStyle>
							<ItemStyle Font-Names="'Verdana'"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Cuenta">
							<HeaderStyle Font-Names="'Verdana'"></HeaderStyle>
							<ItemStyle Font-Names="'Verdana'"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Cuenta") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Cuenta", URLCuenta) %>' Target="_self">
								</asp:HyperLink>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="dfecvig" SortExpression="dfecvig" HeaderText="Fecha">
							<HeaderStyle Font-Size="Smaller" Font-Names="'Verdana'" HorizontalAlign="Center"></HeaderStyle>
							<ItemStyle Font-Size="Smaller" Font-Names="'Verdana'"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="ncapdes" SortExpression="ncapes" HeaderText="Desembolso">
							<HeaderStyle Font-Size="Smaller" Font-Names="'Verdana'" HorizontalAlign="Center"></HeaderStyle>
							<ItemStyle Font-Size="Smaller" Font-Names="'Verdana'" HorizontalAlign="Center"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="cEstado" SortExpression="cEstado" HeaderText="Estado">
							<HeaderStyle Font-Size="Smaller" Font-Names="'Verdana'" HorizontalAlign="Center"></HeaderStyle>
							<ItemStyle Font-Size="Smaller" Font-Names="'Verdana'" HorizontalAlign="Center"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
</TABLE>
