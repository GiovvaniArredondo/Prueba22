<%@ control language="vb" autoeventwireup="false" inherits="WUCLibMdet, App_Web_yjxjq67i" %>
<TABLE id="Table2" style="WIDTH: 400px; HEIGHT: 203px" cellSpacing="0" cellPadding="0"
	width="400" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 406px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 298px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="406" border="0">
				<TR>
					<TD style="HEIGHT: 32px" align="center">
						<asp:label id="Label1" ForeColor="Navy" Width="275px" Height="15px" Font-Size="Medium" Font-Names="Verdana"
							runat="server" Font-Bold="True">LIBRO MAYOR DETALLADO</asp:label>
						<TABLE id="Table5" style="WIDTH: 373px; HEIGHT: 168px" cellSpacing="0" cellPadding="0"
							width="373" border="0">
							<TR>
								<TD style="HEIGHT: 96px" align="center">
									<TABLE id="Table6" style="WIDTH: 371px; HEIGHT: 72px" borderColor="#ffcc00" cellSpacing="0"
										cellPadding="0" width="371" bgColor="#ffff99" border="1">
										<TR>
											<TD style="WIDTH: 62px; HEIGHT: 30px" align="right">
												<asp:label id="Label4" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="56px">Oficina:</asp:label></TD>
											<TD style="HEIGHT: 30px"><SELECT id="CbxCodOFi" style="FONT-SIZE: 12px; WIDTH: 200px; FONT-FAMILY: 'Verdana'" name="CbxCodOFi"
													runat="server">
													<OPTION selected></OPTION>
												</SELECT>
												<asp:checkbox id="CheckBox1" runat="server" Font-Names="Verdana" Font-Size="8pt" Checked="True"
													Text="Consolidado"></asp:checkbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 62px" align="right">
												<asp:label id="Label5" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="48px">Fondos:</asp:label></TD>
											<TD>
												<P><SELECT id="cbxfondos" style="FONT-SIZE: 12px; WIDTH: 200px; FONT-FAMILY: 'Verdana'" name="cbxfondos"
														runat="server">
														<OPTION selected></OPTION>
													</SELECT>
													<asp:checkbox id="CheckBox2" runat="server" Font-Names="Verdana" Font-Size="8pt" Checked="True"
														Text="Consolidado"></asp:checkbox></P>
											</TD>
										</TR>
									</TABLE>
									<asp:label id="Label6" Font-Bold="True" runat="server" Font-Names="Verdana" Font-Size="8pt"
										Width="326px" ForeColor="DarkBlue">PERIODO</asp:label>
									<TABLE id="Table7" style="BORDER-LEFT-COLOR: green; BORDER-BOTTOM-COLOR: green; WIDTH: 369px; BORDER-TOP-COLOR: green; HEIGHT: 41px; BORDER-RIGHT-COLOR: green"
										borderColor="highlight" cellSpacing="0" cellPadding="0" width="369" bgColor="inactivecaptiontext"
										border="1">
										<TR>
											<TD style="WIDTH: 86px; HEIGHT: 39px" align="right">
												<asp:label id="Label10" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="80px">Fecha Inicial:</asp:label></TD>
											<TD style="WIDTH: 94px; HEIGHT: 39px" align="center">
												<asp:textbox id="txtdfecini" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="82px"
													BorderWidth="1px"></asp:textbox></TD>
											<TD style="WIDTH: 74px; HEIGHT: 39px" align="right">
												<asp:label id="Label9" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="72px">Fecha Final:</asp:label></TD>
											<TD style="HEIGHT: 39px" align="center">
												<asp:textbox id="txtdfecfin" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="80px"
													BorderWidth="1px"></asp:textbox></TD>
										</TR>
									</TABLE>
									<asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
										ControlToValidate="txtdfecini" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" DESIGNTIMEDRAGDROP="1491">Fecha inicial Inválida-</asp:rangevalidator>
									<asp:rangevalidator id="Rangevalidator1" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
										ControlToValidate="txtdfecini" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" DESIGNTIMEDRAGDROP="1491">Fecha final Inválida-</asp:rangevalidator></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="center">
						<TABLE id="Table4" style="WIDTH: 123px; HEIGHT: 36px" cellSpacing="0" cellPadding="0" width="123"
							border="0">
							<TR>
								<TD style="HEIGHT: 82px" align="center"><INPUT id="btnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 75px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
										type="button" name="Button1" runat="server"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
