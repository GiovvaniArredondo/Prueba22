<%@ Control Language="vb" AutoEventWireup="false" Inherits="dgbuscta" CodeFile="dgbuscta.ascx.vb" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD align="center">
			<asp:DataGrid id="dgdatos" runat="server" AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderStyle="None"
				BorderWidth="1px" BackColor="White" CellPadding="3">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
				<Columns>
					<asp:ButtonColumn Text="Sel" CommandName="Select"></asp:ButtonColumn>
					<asp:TemplateColumn HeaderImageUrl="../imagenes/Editar.gif" HeaderText="C&#243;digo">
						<ItemTemplate>
							<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ccodcli") %>' Target="_self" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.ccodcli", URLcodigo) %>'>
							</asp:HyperLink>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ccodcli") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="cnomcli" SortExpression="cnomcli" HeaderText="Nombre">
						<HeaderStyle Width="150px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="cnudoci" SortExpression="cnudoci" HeaderText="Documento">
						<HeaderStyle Width="3cm"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="dnacimi" SortExpression="dnacimi" HeaderText="F.Nacimiento"></asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid></TD>
	</TR>
</TABLE>
