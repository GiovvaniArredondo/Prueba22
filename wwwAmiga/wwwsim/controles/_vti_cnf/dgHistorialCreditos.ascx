<%@ Control Language="vb" AutoEventWireup="false" Codebehind="dgHistorialCreditos.ascx.vb" Inherits="wwwSIM.dgHistorialCreditos" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<P>&nbsp;</P>
<P>
	<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 520px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 288px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="520" border="0">
		<TR>
			<TD></TD>
		</TR>
		<TR>
			<TD align="center">
				<TABLE id="Table2" style="WIDTH: 307px; HEIGHT: 22px" cellSpacing="0" cellPadding="0" width="307"
					border="0">
					<TR>
						<TD style="WIDTH: 374px" align="right"><asp:label id="Label1" runat="server" Font-Names="Verdana" Font-Size="8pt">Cuenta:</asp:label></TD>
						<TD><asp:textbox id="txtcuenta" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="216px"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				<TABLE id="Table3" style="WIDTH: 467px; HEIGHT: 22px" cellSpacing="0" cellPadding="0" width="467"
					border="0">
					<TR>
						<TD style="WIDTH: 303px" align="right"><asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="8pt">Nombre:</asp:label></TD>
						<TD><asp:textbox id="txtnomcli" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="296px"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				<asp:label id="label_mensaje" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="141px"
					ForeColor="Yellow"></asp:label></TD>
		</TR>
		<TR>
			<TD align="center"><asp:datagrid id="DataGrid1" runat="server" Width="490px" BorderWidth="1px" AutoGenerateColumns="False"
					BorderColor="#CCCCCC" BorderStyle="None" BackColor="White" CellPadding="3">
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<Columns>
						<asp:BoundColumn DataField="cnrocuo" SortExpression="cnrocuo" HeaderText="# Cuota">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="dfecven" SortExpression="dfecven" HeaderText="Fecha" DataFormatString="{0:dd-MM-yyyy}">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="ncapita" SortExpression="ncapita" HeaderText="Capital" DataFormatString="{0:C}">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="nintere" SortExpression="nintere" HeaderText="Inter&#233;s" DataFormatString="{0:C}">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="nsegdeu" SortExpression="nsegdeu" HeaderText="Seguro de Deuda" DataFormatString="{0:C}">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" Width="2px"
								VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="nmoncuo" SortExpression="nmoncuo" HeaderText="Cuota" DataFormatString="{0:C}">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="nsaldo" SortExpression="nsaldo" HeaderText="Saldo" DataFormatString="{0:C}">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="141px"></asp:label></TD>
		</TR>
		<TR>
			<TD align="center">&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnimprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 75px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server"></TD>
		</TR>
	</TABLE>
</P>
