<%@ control language="vb" autoeventwireup="false" inherits="cuwInsPar, App_Web_yl8dokps" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="536" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 536px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 288px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD align="center">
			<asp:label id="Label5" runat="server" Font-Names="Verdana" Font-Size="Medium" Height="15px"
				Width="373px" Font-Bold="True" ForeColor="#16387C">VERIFICACION DE INCOSISTENCIAS</asp:label>
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="456" border="0" style="WIDTH: 456px; HEIGHT: 84px">
				<TR>
					<TD style="WIDTH: 105px" align="right">
						<asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="80px">Fecha Inicial:</asp:label></TD>
					<TD style="WIDTH: 117px">
						<asp:textbox id="txtdfecini" runat="server" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
							Width="89px" Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 63px">
						<asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="70px">Fecha Final:</asp:label></TD>
					<TD style="WIDTH: 112px">
						<asp:textbox id="txtdfecfin" runat="server" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
							Width="82px" Enabled="False"></asp:textbox></TD>
					<TD><INPUT id="ibtnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 80px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 53px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="499" border="0" style="WIDTH: 499px; HEIGHT: 165px">
				<TR>
					<TD align="center">
						<asp:DataGrid id="dgVerifica" runat="server" BorderWidth="1px" BackColor="White" Width="505px"
							AutoGenerateColumns="False" CellPadding="3" BorderStyle="None" BorderColor="#006699" Height="142px">
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
							<ItemStyle ForeColor="#000066"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="cnumcom" SortExpression="cnumcom" HeaderText="Partida N&#186;">
									<HeaderStyle Font-Size="X-Small" Font-Names="Garamond"></HeaderStyle>
									<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="cGlosa" SortExpression="cGlosa" HeaderText="Descripci&#243;n">
									<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
									<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="ndebe" SortExpression="nDebe" HeaderText="Cargo Total">
									<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
									<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="nhaber" SortExpression="nhaber" HeaderText="Abono total">
									<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
									<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="dfeccnt" SortExpression="dfeccnt" HeaderText="Fecha" DataFormatString="{0:dd-MM-yyyy}">
									<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
									<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="cnumdoc" SortExpression="cnumdoc" HeaderText="Documento">
									<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
									<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
						</asp:DataGrid>
						<asp:Label id="Label4" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="358px" Font-Bold="True"
							ForeColor="Crimson"></asp:Label></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
