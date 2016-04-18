<%@ control language="vb" autoeventwireup="false" inherits="cuwDisRes1, App_Web_5wr0lfuo" %>
<TABLE id="Table2" style="WIDTH: 496px; HEIGHT: 302px" cellSpacing="0" cellPadding="0"
	width="496" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 405px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 186px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="405" border="0">
				<TR>
					<TD style="HEIGHT: 84px" align="center">
						<asp:label id="Label1" runat="server" Font-Names="Verdana" Font-Size="Medium" Height="15px"
							Width="275px" Font-Bold="True" ForeColor="#16387C">ESTADO DE RESULTADOS</asp:label>
						<TABLE id="Table5" style="WIDTH: 373px; HEIGHT: 160px" cellSpacing="0" cellPadding="0"
							width="373" border="0">
							<TR>
								<TD style="HEIGHT: 96px" align="center">
									<TABLE id="Table6" style="WIDTH: 371px; HEIGHT: 72px" borderColor="#ffcc00" cellSpacing="0"
										cellPadding="0" width="371" bgColor="#ffff99" border="1">
										<TR>
											<TD style="WIDTH: 62px; HEIGHT: 30px" align="right">
												<asp:label id="Label4" Width="56px" Font-Size="8pt" Font-Names="Verdana" runat="server">Oficina:</asp:label></TD>
											<TD style="HEIGHT: 30px"><SELECT id="CbxCodOFi" style="FONT-SIZE: 12px; WIDTH: 200px; FONT-FAMILY: 'Verdana'" name="CbxCodOFi"
													runat="server">
													<OPTION selected></OPTION>
												</SELECT>
												<asp:checkbox id="CheckBox1" Font-Size="8pt" Font-Names="Verdana" runat="server" Text="Consolidado"
													Checked="True"></asp:checkbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 62px" align="right">
												<asp:label id="Label5" Width="48px" Font-Size="8pt" Font-Names="Verdana" runat="server">Fondos:</asp:label></TD>
											<TD>
												<P><SELECT id="cbxfondos" style="FONT-SIZE: 12px; WIDTH: 200px; FONT-FAMILY: 'Verdana'" name="cbxfondos"
														runat="server">
														<OPTION selected></OPTION>
													</SELECT>
													<asp:checkbox id="CheckBox2" Font-Size="8pt" Font-Names="Verdana" runat="server" Text="Consolidado"
														Checked="True"></asp:checkbox></P>
											</TD>
										</TR>
									</TABLE>
									<asp:label id="Label6" ForeColor="DarkBlue" Font-Bold="True" Width="326px" Font-Size="8pt"
										Font-Names="Verdana" runat="server">PERIODO</asp:label>
									<TABLE id="Table7" style="BORDER-LEFT-COLOR: green; BORDER-BOTTOM-COLOR: green; WIDTH: 369px; BORDER-TOP-COLOR: green; HEIGHT: 41px; BORDER-RIGHT-COLOR: green"
										borderColor="highlight" cellSpacing="0" cellPadding="0" width="369" bgColor="inactivecaptiontext"
										border="1">
										<TR>
											<TD style="WIDTH: 86px; HEIGHT: 39px" align="right">
												<asp:label id="Label10" Width="80px" Font-Size="8pt" Font-Names="Verdana" runat="server">Fecha Inicial:</asp:label></TD>
											<TD style="WIDTH: 94px; HEIGHT: 39px" align="center">
												<asp:textbox id="txtdfecini" runat="server" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
													Width="84px"></asp:textbox></TD>
											<TD style="WIDTH: 74px; HEIGHT: 39px" align="right">
												<asp:label id="Label9" Width="72px" Font-Size="8pt" Font-Names="Verdana" runat="server">Fecha Final:</asp:label></TD>
											<TD style="HEIGHT: 39px" align="center">
												<asp:textbox id="txtdfecfin" runat="server" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
													Width="80px"></asp:textbox></TD>
										</TR>
									</TABLE>
									<asp:rangevalidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" runat="server" DESIGNTIMEDRAGDROP="1491"
										Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtdfecini" ErrorMessage="RangeValidator">Fecha inicial Inválida-</asp:rangevalidator>
									<asp:rangevalidator id="Rangevalidator1" Font-Size="8pt" Font-Names="Verdana" runat="server" DESIGNTIMEDRAGDROP="1491"
										Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtdfecini" ErrorMessage="RangeValidator">Fecha final Inválida-</asp:rangevalidator></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="center"><INPUT id="btnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 75px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
