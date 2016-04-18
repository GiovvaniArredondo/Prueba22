<%@ Control Language="vb" AutoEventWireup="false" Codefile="cuwGenBal.ascx.vb" Inherits="cuwGenBal"  %>
<TABLE id="Table4" style="WIDTH: 552px; HEIGHT: 230px" cellSpacing="0" cellPadding="0"
	width="552" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 448px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 200px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="448" border="0">
				<TR>
					<TD style="HEIGHT: 2px" align="center">
						<asp:label id="Label2" BackColor="White" Height="10px" runat="server" Font-Names="Verdana"
							Width="429px" Font-Size="8pt" BorderWidth="0px" ForeColor="MidnightBlue">Este Proceso Genera Datos Para Balances, Verifique las Inconsistencias.</asp:label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 98px">
						<TABLE id="Table2" style="WIDTH: 190px; HEIGHT: 40px" cellSpacing="0" cellPadding="0" width="190"
							align="center" border="0">
							<TR>
								<TD style="WIDTH: 238px" align="right">
									<asp:label id="Label1" runat="server" Font-Names="Verdana" Width="100px" Font-Size="8pt">Mes de Proceso:  </asp:label></TD>
								<TD>
									<asp:textbox id="txtMesPro" runat="server" Font-Names="Verdana" Width="80px" Font-Size="8pt"
										BorderWidth="1px" Enabled="False"></asp:textbox></TD>
							</TR>
						</TABLE>
						<TABLE id="Table3" style="WIDTH: 361px; HEIGHT: 122px" cellSpacing="0" cellPadding="0"
							width="361" align="center" border="0">
							<TR>
								<TD style="HEIGHT: 30px">
									<TABLE id="Table5" style="WIDTH: 360px; HEIGHT: 116px" cellSpacing="0" cellPadding="0"
										width="360" align="center" border="0">
										<TR>
											<TD align="center">
												<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
													<TR>
														<TD style="WIDTH: 102px; HEIGHT: 43px" align="right">
															<asp:label id="Label3" runat="server" Font-Names="Verdana" Width="88px" Font-Size="8pt">Fecha Inicial:</asp:label></TD>
														<TD style="WIDTH: 96px; HEIGHT: 43px">
															<asp:textbox id="txtdfecini" runat="server" Font-Names="Verdana" Width="80px" Font-Size="8pt"
																BorderWidth="1px" Enabled="False"></asp:textbox></TD>
														<TD style="WIDTH: 64px; HEIGHT: 43px">
															<asp:label id="Label4" runat="server" Font-Names="Verdana" Width="72px" Font-Size="8pt">Fecha Final:</asp:label></TD>
														<TD style="HEIGHT: 43px">
															<asp:textbox id="txtdfecfin" runat="server" Font-Names="Verdana" Width="80px" Font-Size="8pt"
																BorderWidth="1px" Enabled="False"></asp:textbox></TD>
													</TR>
												</TABLE>
												<INPUT id="ibtnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 75px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
													type="button" name="Button1" runat="server"></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
