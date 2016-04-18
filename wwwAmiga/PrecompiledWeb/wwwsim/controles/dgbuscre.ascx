<%@ control language="vb" autoeventwireup="false" inherits="dgbuscre, App_Web_yl8dokps" %>
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
					<asp:ButtonColumn Text="Seleccionar" CommandName="Select"></asp:ButtonColumn>
					<asp:BoundColumn DataField="ccodcli" SortExpression="ccodcli" HeaderText="C&#243;digo"></asp:BoundColumn>
					<asp:BoundColumn DataField="ncapdes" SortExpression="ncapdes" HeaderText="Monto"></asp:BoundColumn>
					<asp:BoundColumn DataField="dfecvig" SortExpression="dfecvig" HeaderText="Fecha D."></asp:BoundColumn>
					<asp:BoundColumn DataField="dfecven" SortExpression="dfecven" HeaderText="Vencimiento"></asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid></TD>
	</TR>
</TABLE>
