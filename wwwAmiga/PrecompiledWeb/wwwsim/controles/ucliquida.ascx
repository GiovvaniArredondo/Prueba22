<%@ Reference Control="~/controles/dgCreditos.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="ucliquida, App_Web_v6ddqlgy" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<P>
	<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="504" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 504px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 636px; BACKGROUND-COLOR: #ffffff">
		<TR>
			<TD align="center">
				<asp:label id="Label1" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="Medium"
					Width="330px" ForeColor="#16387C" Height="15px">LIQUIDACION DE ASOCIADOS</asp:label></TD>
		</TR>
		<TR>
			<TD><asp:label id="Label6" runat="server" Font-Names="Verdana" Font-Size="8pt">Cliente:</asp:label><asp:textbox id="txtcodcta" runat="server" Enabled="False" BorderStyle="Groove" Font-Names="Verdana"
					Font-Size="8pt"></asp:textbox>&nbsp;
				<asp:label id="Label7" runat="server" Font-Names="Verdana" Font-Size="8pt">Nombre:</asp:label>&nbsp;
				<asp:textbox id="txtnomcli" runat="server" Enabled="False" BorderStyle="Groove" Width="176px"
					Font-Names="Verdana" Font-Size="8pt"></asp:textbox></TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 34px">
				<asp:label id="Label11" runat="server" Width="40px" Font-Names="Verdana" Font-Size="8pt">Cajero:</asp:label>
				<asp:dropdownlist id="ddlcajero" runat="server" Width="225px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 242px" align="center">
				<P><asp:label id="Label3" runat="server" Width="168px" Font-Size="8pt" Font-Names="Verdana" ForeColor="MidnightBlue">CUENTAS DE AHORRO</asp:label></P>
				<P><asp:datagrid id="dgClientes" runat="server" BorderStyle="None" Width="475px" AllowSorting="True"
						BackColor="White" AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="3"
						Height="100px">
						<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<ItemStyle ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<Columns>
							<asp:BoundColumn DataField="ccodaho" SortExpression="ccodaho" HeaderText="Cuenta de ahorro">
								<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
								<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="ctipo" SortExpression="ctipo" HeaderText="tipo de ahorro" DataFormatString="{0:C}">
								<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
								<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="nsaldoaho" SortExpression="nsaldoaho" HeaderText="Saldo" DataFormatString="{0:C}">
								<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
								<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Wrap="False" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></P>
				<P><INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 73px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 62px; BACKGROUND-COLOR: transparent"
						type="button" name="Button1" runat="server"></P>
				<P>
					<asp:label id="Label8" runat="server" Font-Names="Verdana" Font-Size="8pt">Total Ahorros: </asp:label><asp:textbox id="txtahorros" runat="server" Enabled="False" BorderStyle="Groove" Font-Names="Verdana"
						Font-Size="8pt" Width="112px"></asp:textbox></P>
			</TD>
		</TR>
		<TR>
			<TD align="center" style="HEIGHT: 27px"><asp:label id="Label4" runat="server" Width="160px" Font-Size="8pt" Font-Names="Verdana" ForeColor="MidnightBlue">DEUDAS PENDIENTES</asp:label></TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 159px">
				<P align="center"><asp:datagrid id="dgcreditos" runat="server" BorderStyle="None" Width="484px" AllowSorting="True"
						BackColor="White" AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="3">
						<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<ItemStyle ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<Columns>
							<asp:BoundColumn DataField="ccodcta" SortExpression="ccodcta" HeaderText="Cr&#233;dito">
								<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
								<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="ncapdes" SortExpression="ncapdes" HeaderText="Monto desembolsado" DataFormatString="{0:C}">
								<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
								<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="nsalcap" SortExpression="nsalcap" HeaderText="Saldo Capital" DataFormatString="{0:C}">
								<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
								<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="nsalint" SortExpression="nsalint" HeaderText="Interes" DataFormatString="{0:C}">
								<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
								<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="nsalmor" SortExpression="nsalmor" HeaderText="Mora" DataFormatString="{0:C}">
								<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
								<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Wrap="False" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></P>
				<P align="center"><asp:label id="Label5" runat="server" Font-Names="Verdana" Font-Size="8pt">Deuda Total:</asp:label>&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:textbox id="txtdeuda" runat="server" Enabled="False" BorderStyle="Groove" Font-Names="Verdana"
						Font-Size="8pt" Width="80px"></asp:textbox></P>
			</TD>
		</TR>
		<TR>
			<TD align="center">&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 73px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 62px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server"></TD>
		</TR>
	</TABLE>
</P>
