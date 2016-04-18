<%@ control language="vb" autoeventwireup="false" inherits="cuwConMov, App_Web_mb_xwoah" %>
<TABLE id="Table2" style="WIDTH: 512px; HEIGHT: 219px" cellSpacing="0" cellPadding="0"
	width="512" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="384" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 384px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 200px; BACKGROUND-COLOR: #ffffff">
				<TR>
					<TD style="HEIGHT: 71px" align="center">
						<asp:label id="Label4" runat="server" Font-Names="Verdana" Font-Size="Medium" Height="15px"
							Width="255px" Font-Bold="True" ForeColor="#16387C">CONCENTRACION DE MOVIMIENTOS DIARIOS</asp:label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 47px" align="center">
						<TABLE id="Table3" style="WIDTH: 376px; HEIGHT: 19px" cellSpacing="0" cellPadding="0" width="376"
							border="0">
							<TR>
								<TD style="WIDTH: 102px" align="right">
									<asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="80px">Fecha Inicial:</asp:label></TD>
								<TD style="WIDTH: 102px">
									<asp:textbox id="txtdfecini" runat="server" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
										Width="80px"></asp:textbox></TD>
								<TD style="WIDTH: 71px">
									<asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="72px">Fecha Final:</asp:label></TD>
								<TD>
									<asp:textbox id="txtdfecfin" runat="server" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
										Width="80px"></asp:textbox></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="center"><INPUT id="ibtnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 75px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server">
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
