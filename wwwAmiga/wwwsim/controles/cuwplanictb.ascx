<%@ Control Language="vb" AutoEventWireup="false" Codefile="cuwplanictb.ascx.vb" Inherits="cuwplanictb"  %>
<TABLE id="Table4" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 472px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 216px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="472" border="0">
	<TR>
		<TD style="HEIGHT: 114px" align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 12pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Century Gothic'; BACKGROUND-COLOR: #ffffff"
				align="center">GENERACIÓN PARTIDA CONTABLE</P>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">&nbsp;PLANILLAS DE PAGOS</P>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">
				<TABLE id="Table1" style="WIDTH: 401px; HEIGHT: 128px" cellSpacing="0" cellPadding="0"
					width="401" border="0">
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
							<TABLE id="Table2" style="WIDTH: 362px; HEIGHT: 108px" cellSpacing="0" cellPadding="0"
								width="362" border="0">
								<TR>
									<TD style="WIDTH: 22px" align="center"></TD>
									<TD style="WIDTH: 338px" align="center"><INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/books_032.png); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
									<TD style="WIDTH: 63px" align="center"><asp:dropdownlist id="ddlexportar" Width="35px" runat="server" Font-Names="Verdana" Visible="False"></asp:dropdownlist></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 22px" align="center"></TD>
									<TD style="WIDTH: 338px" align="center"><asp:textbox id="TextBox1" Width="302px" runat="server" Font-Names="Century Gothic" Font-Size="8pt"
											BorderWidth="2px" Height="23px" BackColor="White" BorderColor="DarkRed" AutoPostBack="True" Enabled="False" ForeColor="Black"></asp:textbox></TD>
									<TD style="WIDTH: 63px" align="center"></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
</TABLE>
