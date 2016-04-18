<%@ Control Language="vb" AutoEventWireup="false" Inherits="cwRecSol" CodeFile="cwRecSol.ascx.vb" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD style="HEIGHT: 164px" align="center" vAlign="middle">
			<P>&nbsp;</P>
			<asp:DataGrid id="dgCausas" runat="server" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
				BackColor="White" CellPadding="3" AutoGenerateColumns="False" Width="532px" AllowSorting="True">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
				<Columns>
					<asp:ButtonColumn Text="Seleccionar" CommandName="Select"></asp:ButtonColumn>
					<asp:TemplateColumn HeaderText="Codigo">
						<HeaderStyle Font-Size="X-Small" Font-Names="Garamond"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
						<ItemTemplate>
							<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cCodigo") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.cCodigo", URLCodigo) %>' Target="_self">
							</asp:HyperLink>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="cdescri" SortExpression="cdescri" HeaderText="Causas de Rechazo">
						<HeaderStyle Font-Size="X-Small" Font-Names="Garamond"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid></TD>
	</TR>
	<TR>
		<TD align="center"></TD>
	</TR>
</TABLE>
