<%@ control language="vb" autoeventwireup="false" inherits="cuwDisBal1, App_Web_pi2jwlis" %>
<TABLE id="Table2" style="WIDTH: 568px; HEIGHT: 203px" cellSpacing="0" cellPadding="0"
	width="568" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 432px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 184px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="432" border="0">
				<TR>
					<TD align="center">
						<asp:label id="Label1" runat="server" Font-Names="Verdana" Font-Size="Medium" Height="15px"
							Width="208px" ForeColor="#16387C" Font-Bold="True">BALANCE GENERAL</asp:label></TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="Table3" style="WIDTH: 402px; HEIGHT: 137px" cellSpacing="0" cellPadding="0"
							width="402" align="center" border="0">
							<TR>
								<TD align="center">
									<TABLE id="Table4" style="WIDTH: 401px; HEIGHT: 24px" cellSpacing="0" cellPadding="0" width="401"
										border="0">
										<TR>
											<TD style="WIDTH: 110px; HEIGHT: 53px" align="right">
												<asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="88px">Fecha Inicial:</asp:label></TD>
											<TD style="WIDTH: 110px; HEIGHT: 53px">
												<asp:textbox id="txtdfecini" runat="server" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
													Width="80px" Enabled="False"></asp:textbox></TD>
											<TD style="WIDTH: 75px; HEIGHT: 53px">
												<asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="71px">Fecha Final:</asp:label></TD>
											<TD style="HEIGHT: 53px">
												<asp:textbox id="txtdfecfin" runat="server" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
													Width="80px" Enabled="False"></asp:textbox></TD>
										</TR>
									</TABLE>
									<INPUT id="btnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 75px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
										type="button" name="Button1" runat="server">
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
