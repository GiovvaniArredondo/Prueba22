<%@ Control Language="vb" AutoEventWireup="false" Inherits="dgKardex" CodeFile="dgKardex.ascx.vb" %>
<asp:DataGrid id="dgDatos" runat="server" AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderStyle="None"
	BorderWidth="1px" BackColor="White" CellPadding="3">
	<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
	<ItemStyle ForeColor="#000066"></ItemStyle>
	<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
	<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
	<Columns>
		<asp:BoundColumn DataField="nmonto" SortExpression="nmonto" HeaderText="Monto Pagado"></asp:BoundColumn>
		<asp:BoundColumn DataField="cconcep" SortExpression="cconcep" HeaderText="concepto"></asp:BoundColumn>
		<asp:BoundColumn DataField="cdescob" SortExpression="cdescob" HeaderText="Tipo"></asp:BoundColumn>
		<asp:BoundColumn DataField="dfecsis" SortExpression="dfecsis" HeaderText="Fecha"></asp:BoundColumn>
		<asp:BoundColumn DataField="dfecpro" SortExpression="dfecpro" HeaderText="F. Valor"></asp:BoundColumn>
	</Columns>
	<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
</asp:DataGrid>
