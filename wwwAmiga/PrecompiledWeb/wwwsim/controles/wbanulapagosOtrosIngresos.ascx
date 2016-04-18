<%@ control language="vb" autoeventwireup="false" inherits="wbanulapagosOtrosIngresos, App_Web_pi2jwlis" %>


<P align="center">
	<TABLE id="Table4" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 542px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 312px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="542" align="left" border="0">
		<TR>
			<TD style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); BACKGROUND-REPEAT: no-repeat; BACKGROUND-COLOR: transparent"
				align="center">
				<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD>
							<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
								align="center">ANULACION DE OTROS INGRESOS</P>
						</TD>
					</TR>
				</TABLE>
				<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD style="WIDTH: 63px" align="right"><asp:label id="Label4" Font-Names="Verdana" runat="server" Width="56px" Font-Size="8pt" Height="15px">Crédito:</asp:label></TD>
						<TD style="WIDTH: 105px"><asp:dropdownlist id="ddlcodins" Font-Names="Century Gothic" runat="server" Width="104px" Font-Size="8pt"></asp:dropdownlist></TD>
						<TD style="WIDTH: 113px"><asp:dropdownlist id="ddlcodofi" 
                                Font-Names="Century Gothic" runat="server" Width="125px" Font-Size="8pt" 
                                Enabled="False"></asp:dropdownlist></TD>
						<TD style="WIDTH: 166px"><asp:textbox id="txtcnrocta" tabIndex="5" Font-Names="Verdana" runat="server" Width="152px" Font-Size="8pt"></asp:textbox></TD>
						<TD><INPUT id="btnAplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 58px; BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></TD>
					</TR>
				</TABLE>
				<TABLE id="Table7" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD style="HEIGHT: 29px"><asp:label id="label_mensaje" Font-Names="Verdana" runat="server" Width="312px" Font-Size="8pt"></asp:label></TD>
					</TR>
				</TABLE>
				<TABLE id="Table8" style="WIDTH: 405px; HEIGHT: 117px; BACKGROUND-COLOR: #ffffff" cellSpacing="0"
					cellPadding="0" width="405" border="0">
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label1" Font-Names="Verdana" runat="server" Width="56px" Font-Size="8pt" Height="15px">Nombre:</asp:label></TD>
						<TD><asp:textbox id="txtnomcli" tabIndex="5" Font-Names="Verdana" runat="server" 
                                Width="264px" Font-Size="8pt" Enabled="False"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label2" Font-Names="Verdana" 
                                runat="server" Width="125px" Font-Size="8pt" Height="16px">Boleta Deposito:</asp:label></TD>
						<TD><asp:textbox id="txtcomprobante" tabIndex="5" Font-Names="Verdana" runat="server" Width="108px"
								Font-Size="8pt"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right">
                            <asp:label id="Label7" Font-Names="Verdana" 
                                runat="server" Width="125px" Font-Size="8pt" Height="16px">Numero Recibo:</asp:label></TD>
						<TD>
                            <asp:TextBox ID="txtRecibo" runat="server"></asp:TextBox>
                        </TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label5" Font-Names="Verdana" runat="server" Width="104px" Font-Size="8pt" Height="15px">Producto</asp:label></TD>
						<TD>
                                                                <asp:dropdownlist id="ddlproducto" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt"></asp:dropdownlist>
                                </TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label6" Font-Names="Verdana" 
                                runat="server" Width="104px" Font-Size="8pt" Height="15px">Tipo de Ingreso</asp:label></TD>
						<TD>
                                                                <asp:dropdownlist id="ddlingreso" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" 
                                        Font-Size="10pt"></asp:dropdownlist></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right">&nbsp;</TD>
						<TD>
						<asp:dropdownlist id="cmbbanco" runat="server" Width="201px" Height="24px" 
                            Font-Names="Verdana" Font-Size="7pt" Visible="False"></asp:dropdownlist></TD>
					</TR>
				</TABLE>
				<INPUT id="btngrabar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 69px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 64px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp; &nbsp; 
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			    <asp:Button ID="Imprimir" runat="server" Height="62px" Text="Imprimir" 
                    Width="80px" />
			</TD>
		</TR>
	</TABLE>
</P>
