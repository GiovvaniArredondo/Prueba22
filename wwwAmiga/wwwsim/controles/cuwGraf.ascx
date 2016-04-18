<%@ Control Language="vb" AutoEventWireup="false" Inherits="cuwGraf" CodeFile="cuwGraf.ascx.vb" %>
<TABLE id="Table4" style="WIDTH: 528px; HEIGHT: 259px" cellSpacing="0" cellPadding="0"
	width="528" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 448px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 240px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="448" border="0">
				<TR>
					<TD style="HEIGHT: 39px">
						<P style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; BORDER-BOTTOM-WIDTH: thin; BORDER-BOTTOM-COLOR: #0099ff; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
							align="center">GRAFICOS</P>
					</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 41px">
						<TABLE id="Table2" style="WIDTH: 418px; HEIGHT: 181px" cellSpacing="0" cellPadding="0"
							width="418" align="center" border="0">
							<TR>
								<TD align="center">
									<TABLE id="Table3" style="WIDTH: 419px; HEIGHT: 117px" cellSpacing="0" cellPadding="0"
										width="419" border="0">
										<TR>
											<TD style="WIDTH: 211px; HEIGHT: 27px" align="right">
												<asp:radiobutton id="rbtnAntiguedad" AutoPostBack="True" Text="Antiguedad de Mora" ForeColor="#16387C"
													BorderWidth="2px" Width="206px" Font-Size="X-Small" runat="server" Font-Names="Verdana" Checked="True"
													GroupName="OpcionesGraf"></asp:radiobutton></TD>
											<TD style="WIDTH: 2px; HEIGHT: 27px"></TD>
											<TD style="HEIGHT: 27px">
												<asp:radiobutton id="rbtnGenero" AutoPostBack="True" Text="Por Genero de Clientes" ForeColor="#16387C"
													BorderWidth="2px" Width="206px" Font-Size="X-Small" runat="server" Font-Names="Verdana" GroupName="OpcionesGraf"
													BackColor="InactiveCaptionText"></asp:radiobutton></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 211px" align="right">
												<asp:radiobutton id="RbtnGeneroC" AutoPostBack="True" Text="Por Genero de Cartera" ForeColor="Navy"
													BorderWidth="1px" Width="206px" Font-Size="X-Small" runat="server" Font-Names="Verdana" GroupName="OpcionesGraf"
													BackColor="InactiveCaptionText"></asp:radiobutton></TD>
											<TD style="WIDTH: 2px"></TD>
											<TD>
												<asp:radiobutton id="rbtnCliOfi" AutoPostBack="True" Text="Clientes por Oficina" ForeColor="#16387C"
													BorderWidth="2px" Width="206px" Font-Size="X-Small" runat="server" Font-Names="Verdana" GroupName="OpcionesGraf"></asp:radiobutton></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 211px; HEIGHT: 19px" align="right">
												<asp:radiobutton id="rbtnCarOfi" AutoPostBack="True" Text="Cartera por Oficina" ForeColor="#16387C"
													BorderWidth="2px" Width="206px" Font-Size="X-Small" runat="server" Font-Names="Verdana" GroupName="OpcionesGraf"></asp:radiobutton></TD>
											<TD style="WIDTH: 2px; HEIGHT: 19px"></TD>
											<TD style="HEIGHT: 19px">
												<asp:radiobutton id="rbtnDesCre" AutoPostBack="True" Text="Clientes por Destino" ForeColor="#16387C"
													BorderWidth="2px" Width="206px" Font-Size="X-Small" runat="server" Font-Names="Verdana" GroupName="OpcionesGraf"
													BackColor="InactiveCaptionText"></asp:radiobutton></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 211px"></TD>
											<TD style="WIDTH: 2px"></TD>
											<TD></TD>
										</TR>
									</TABLE>
									<INPUT id="btnProcesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
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
