<%@ Control Language="vb" AutoEventWireup="false" Codefile="CUWCatalogo.ascx.vb" Inherits="CUWCatalogo"  %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="600" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 600px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 296px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 49px" align="center">
			<asp:datagrid id="dscatalogo" runat="server" Width="594px" AutoGenerateColumns="False" CellPadding="3"
				BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#000099" AllowSorting="True"
				AllowPaging="True" Height="178px">
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="LightCyan" BackColor="#006699"></HeaderStyle>
				<Columns>
					<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
						<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:ButtonColumn>
					<asp:TemplateColumn SortExpression="ccodcta" HeaderText="Cuenta Contable">
						<HeaderStyle Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center"
							VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
						<ItemTemplate>
							<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Ccodcta") %>' Target="_self" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Ccodcta", URLCodigo) %>'>
							</asp:HyperLink>
						</ItemTemplate>
						<EditItemTemplate>
							<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ccodcta") %>'>
							</asp:TextBox>
						</EditItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="cdescrip" SortExpression="cdescrip" HeaderText="Descripcion">
						<HeaderStyle Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center"
							VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Left" VerticalAlign="Middle"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:datagrid><INPUT id="btnImprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 53px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 39px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server"></TD>
	</TR>
	<TR>
		<TD align="center"></TD>
	</TR>
</TABLE>
