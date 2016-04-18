<%@ control language="vb" autoeventwireup="false" inherits="uchisaho, App_Web_5wr0lfuo" %>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 512px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 360px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="512" border="0">
	<TR>
		<TD style="HEIGHT: 41px" align="center"><asp:label id="Label1" Font-Bold="True" Font-Names="Verdana" Width="278px" runat="server" Font-Size="Medium"
				Height="15px" ForeColor="#16387C">HISTORIAL DE AHORROS</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="center">
			<TABLE id="Table2" style="WIDTH: 499px; HEIGHT: 91px" cellSpacing="0" cellPadding="0" width="499"
				border="0">
				<TR>
					<TD style="WIDTH: 138px; HEIGHT: 18px"><asp:label id="Label2" Font-Names="Verdana" Width="80px" runat="server" Font-Size="8pt">Nº Asociado:</asp:label></TD>
					<TD style="WIDTH: 164px; HEIGHT: 18px"><asp:textbox id="txtcodcli" Font-Names="Verdana" runat="server" Font-Size="8pt" BorderStyle="Groove"
							Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 56px; HEIGHT: 18px"><asp:label id="Label3" Font-Names="Verdana" runat="server" Font-Size="8pt">Nombre:</asp:label></TD>
					<TD style="HEIGHT: 18px"><asp:textbox id="txtnomcli" Font-Names="Verdana" Width="168px" runat="server" Font-Size="8pt"
							BorderStyle="Groove" Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 138px"><asp:label id="Label8" Font-Names="Verdana" Width="112px" runat="server" Font-Size="8pt">Nº Cuenta Ahorro:</asp:label></TD>
					<TD style="WIDTH: 164px"><asp:textbox id="txtcodcta" Font-Names="Verdana" Width="136px" runat="server" Font-Size="8pt"
							BorderStyle="Groove" Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 56px"><asp:label id="Label9" Font-Names="Verdana" Width="64px" runat="server" Font-Size="8pt">Fecha:</asp:label></TD>
					<TD><asp:textbox id="txtfecha" Font-Names="Verdana" Width="72px" runat="server" Font-Size="8pt" BorderStyle="Groove"
							Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 138px"></TD>
					<TD style="WIDTH: 164px"><asp:label id="Label4" Font-Names="Verdana" runat="server" Font-Size="8pt"></asp:label></TD>
					<TD style="WIDTH: 56px"><asp:label id="Label5" Font-Names="Verdana" Width="64px" runat="server" Font-Size="8pt">Saldo:</asp:label></TD>
					<TD><asp:textbox id="txtsaldo" Font-Names="Verdana" Width="88px" runat="server" Font-Size="8pt" BorderStyle="Groove"
							Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 138px"></TD>
					<TD style="WIDTH: 164px"></TD>
					<TD style="WIDTH: 56px"></TD>
					<TD></TD>
				</TR>
			</TABLE>
			<asp:datagrid id="datos" BorderWidth="1px" BackColor="#DEBA84" Width="482px" 
                runat="server" BorderStyle="None"
				AutoGenerateColumns="False" CellPadding="3" BorderColor="#DEBA84" CellSpacing="2" 
                Font-Names="Verdana" Font-Size="10pt">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
				<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
				<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="dfecope" SortExpression="dfecope" HeaderText="Fecha" DataFormatString="{0:dd-MM-yyyy}">
						<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
							VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="ctipope" SortExpression="ctipope" HeaderText="Tipo">
						<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
							VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="nmonto" SortExpression="nmonto" HeaderText="Monto" DataFormatString="{0:c}">
						<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
							VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="nsaldoaho" SortExpression="nsaldoaho" HeaderText="Saldo" DataFormatString="{0:c}">
						<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
							VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
			</asp:datagrid></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 8px"><asp:label id="label_mensaje" Font-Names="Verdana" Width="392px" runat="server" Font-Size="8pt"></asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 45px" align="center"><INPUT id="btnprint" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnsalir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server"></TD>
	</TR>
</TABLE>
