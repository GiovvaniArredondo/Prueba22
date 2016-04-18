<%@ Control Language="vb" AutoEventWireup="false" Inherits="dgCreditos" CodeFile="dgCreditos.ascx.vb" %>
<asp:DataGrid id="dgCred" runat="server" AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderStyle="None"
	BorderWidth="1px" BackColor="White" CellPadding="3">
	<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
	<ItemStyle ForeColor="#000066"></ItemStyle>
	<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
	<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
	<Columns>
		<asp:ButtonColumn Text="Sel" CommandName="Select"></asp:ButtonColumn>
		<asp:BoundColumn DataField="ccodcta" SortExpression="ccodcta" HeaderText="Codigo"></asp:BoundColumn>
		<asp:BoundColumn DataField="ncapdes" SortExpression="ncapdes" HeaderText="Monto"></asp:BoundColumn>
		<asp:BoundColumn DataField="dfecvig" SortExpression="dfecvig" HeaderText="Fecha Desembolso"></asp:BoundColumn>
	</Columns>
	<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
</asp:DataGrid>
