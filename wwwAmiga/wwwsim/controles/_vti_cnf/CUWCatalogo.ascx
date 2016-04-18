<%@ Control Language="vb" AutoEventWireup="false" Codebehind="CUWCatalogo.ascx.vb" Inherits="wwwSIM.CUWCatalogo" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="472" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 472px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 216px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 49px" align="center"><INPUT id="btnImprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 53px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 39px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server"></TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:DataGrid id="dsCatalogo" runat="server" BorderColor="#006699" BorderStyle="None" BorderWidth="1px"
				BackColor="White" CellPadding="3" AutoGenerateColumns="False" Width="445px">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="ccodcta" SortExpression="ccodcta" HeaderText="Cuenta Contable">
						<HeaderStyle Font-Size="X-Small" Font-Names="Verdana" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Verdana"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="cdescrip" SortExpression="cdescrip" HeaderText="Descripci&#243;n">
						<HeaderStyle Font-Size="X-Small" Font-Names="Verdana" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Verdana"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid></TD>
	</TR>
</TABLE>
