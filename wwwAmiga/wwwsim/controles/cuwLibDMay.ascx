<%@ Control Language="vb" AutoEventWireup="false" Codefile="cuwLibDMay.ascx.vb" Inherits="cuwLibDMay"  %>
<TABLE id="Table4" style="WIDTH: 520px; HEIGHT: 279px" cellSpacing="0" cellPadding="0"
	width="520" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 423px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 352px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="423" border="0">
				<TR>
					<TD style="HEIGHT: 289px" align="center">
						<P><asp:label id="Label1" ForeColor="Navy" Font-Bold="True" runat="server" Font-Names="Verdana"
								Font-Size="Medium" Height="15px" Width="275px">LIBRO DIARIO MAYOR</asp:label></P>
						<P>
							<TABLE id="Table5" style="WIDTH: 373px; HEIGHT: 152px" cellSpacing="0" cellPadding="0"
								width="373" border="0">
								<TR>
									<TD style="HEIGHT: 96px" align="center">
										<TABLE id="Table6" style="WIDTH: 371px; HEIGHT: 72px" borderColor="#ffcc00" cellSpacing="0"
											cellPadding="0" width="371" bgColor="#ffff99" border="1">
											<TR>
												<TD style="WIDTH: 62px; HEIGHT: 30px" align="right"><asp:label id="Label4" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="56px">Oficina:</asp:label></TD>
												<TD style="HEIGHT: 30px"><SELECT id="CbxCodOFi" style="FONT-SIZE: 12px; WIDTH: 200px; FONT-FAMILY: 'Verdana'" name="CbxCodOFi"
														runat="server">
														<OPTION selected></OPTION>
													</SELECT>
													<asp:checkbox id="CheckBox1" runat="server" Font-Names="Verdana" Font-Size="8pt" Text="Consolidado"
														Checked="True"></asp:checkbox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 62px" align="right"><asp:label id="Label5" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="48px">Fondos:</asp:label></TD>
												<TD>
													<P><SELECT id="cbxfondos" style="FONT-SIZE: 12px; WIDTH: 200px; FONT-FAMILY: 'Verdana'" name="cbxfondos"
															runat="server">
															<OPTION selected></OPTION>
														</SELECT>
														<asp:checkbox id="CheckBox2" runat="server" Font-Names="Verdana" Font-Size="8pt" Text="Consolidado"
															Checked="True"></asp:checkbox></P>
												</TD>
											</TR>
										</TABLE>
										<asp:label id="Label6" ForeColor="DarkBlue" Font-Bold="True" runat="server" Font-Names="Verdana"
											Font-Size="8pt" Width="326px">PERIODO</asp:label>
										<TABLE id="Table7" style="BORDER-LEFT-COLOR: green; BORDER-BOTTOM-COLOR: green; WIDTH: 369px; BORDER-TOP-COLOR: green; HEIGHT: 41px; BORDER-RIGHT-COLOR: green"
											borderColor="highlight" cellSpacing="0" cellPadding="0" width="369" bgColor="inactivecaptiontext"
											border="1">
											<TR>
												<TD style="WIDTH: 73px; HEIGHT: 39px" align="right"><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="80px">Fecha Inicial:</asp:label></TD>
												<TD style="WIDTH: 98px; HEIGHT: 39px" align="center"><asp:textbox id="txtdfecini" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="72px"
														BorderWidth="1px"></asp:textbox></TD>
												<TD style="WIDTH: 74px; HEIGHT: 39px" align="right"><asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="72px">Fecha Final:</asp:label></TD>
												<TD style="HEIGHT: 39px" align="center"><asp:textbox id="txtdfecfin" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="80px"
														BorderWidth="1px"></asp:textbox></TD>
											</TR>
										</TABLE>
										<asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" DESIGNTIMEDRAGDROP="1491"
											Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtdfecini" ErrorMessage="RangeValidator">Fecha inicial Inválida-</asp:rangevalidator>
										<asp:rangevalidator id="Rangevalidator1" runat="server" Font-Names="Verdana" Font-Size="8pt" DESIGNTIMEDRAGDROP="1491"
											Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtdfecfin" ErrorMessage="RangeValidator">Fecha final Inválida-</asp:rangevalidator>
										<TABLE id="Table2" style="WIDTH: 289px; HEIGHT: 20px" cellSpacing="0" cellPadding="0" width="289"
											border="0">
											<TR>
												<TD align="center">
													<asp:CheckBox id="CheckBox3" ForeColor="DarkBlue" Font-Bold="True" runat="server" Font-Names="Verdana"
														Font-Size="8pt" Text="FILTRAR POR CUENTAS CONTABLES"></asp:CheckBox></TD>
											</TR>
										</TABLE>
										<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="328" border="0" style="WIDTH: 328px; HEIGHT: 21px">
											<TR>
												<TD style="WIDTH: 91px" align="right">
													<asp:label id="Label7" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="39px">Desde:</asp:label></TD>
												<TD style="WIDTH: 65px">
													<asp:TextBox id="txtdesde" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="96px"></asp:TextBox></TD>
												<TD style="WIDTH: 67px" align="right">
													<asp:label id="Label8" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="39px">Hasta:</asp:label></TD>
												<TD>
													<asp:TextBox id="txthasta" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="104px"></asp:TextBox></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</P>
						<INPUT id="btnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 75px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
				<TR>
					<TD align="center">
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
