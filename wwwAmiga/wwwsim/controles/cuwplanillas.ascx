<%@ Control Language="vb" AutoEventWireup="false" Codefile="cuwplanillas.ascx.vb" Inherits="cuwplanillas"  %>
<TABLE id="Table4" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 608px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 272px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="608" border="0">
	<TR>
		<TD style="HEIGHT: 114px" align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">IMPRESIONES&nbsp;PLANILLAS DE PAGOS</P>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">
				<TABLE id="Table1" style="WIDTH: 423px; HEIGHT: 131px" cellSpacing="0" cellPadding="0"
					width="423" border="0">
					<TR>
						<TD style="WIDTH: 383px" align="center">
							<TABLE id="Table5" style="WIDTH: 368px; HEIGHT: 26px" height="26" cellSpacing="0" cellPadding="0"
								width="368" border="0">
								<TR>
									<TD style="WIDTH: 124px"><asp:label id="Label7" Width="111px" runat="server" Font-Names="Verdana" Font-Size="8pt">Fecha de Planilla:</asp:label></TD>
									<TD><asp:textbox id="txtdfecha" Width="92px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											BorderWidth="1px" Font-Bold="True"></asp:textbox></TD>
									<TD><asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
											ControlToValidate="txtdfecha" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date">Fecha de Des.Inválida-</asp:rangevalidator></TD>
								</TR>
							</TABLE>
							<TABLE id="Table2" style="WIDTH: 271px; HEIGHT: 108px" cellSpacing="0" cellPadding="0"
								width="271" border="0">
								<TR>
									<TD style="WIDTH: 236px" align="center"><asp:label id="Label9" Width="65px" runat="server" Font-Names="Century Gothic" Font-Size="8pt"
											Font-Bold="True" ForeColor="#0000C0">Exportar a:</asp:label></TD>
									<TD align="center"><asp:dropdownlist id="ddlexportar" Width="169px" runat="server" Font-Names="Verdana"></asp:dropdownlist></TD>
									<TD style="WIDTH: 63px" align="center"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 236px" align="center"><INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
									<TD align="center"><INPUT id="btnCancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
									<TD style="WIDTH: 63px" align="center">
										<INPUT id="Button1" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/printer1.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
</TABLE>
