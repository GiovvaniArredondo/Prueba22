<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucprovpla" CodeFile="ucprovpla.ascx.vb" %>
<TABLE id="Table3" style="WIDTH: 600px; HEIGHT: 230px" cellSpacing="0" cellPadding="0"
	width="600" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="336" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 336px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 208px; BACKGROUND-COLOR: #ffffff">
				<TR>
					<TD style="HEIGHT: 59px">
						<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
							align="center">PROVISION DE CERTIFICADOS A PLAZO</P>
					</TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 149px; HEIGHT: 40px" align="right">
									<asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="8pt">Ultima Provisión:</asp:label></TD>
								<TD style="HEIGHT: 40px">
									<asp:textbox id="txtultpro" runat="server" Width="72px" Font-Names="Verdana" Font-Size="8pt"></asp:textbox>
									<asp:RangeValidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="88px"
										ControlToValidate="txtultpro" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000"
										MaximumValue="01/01/3000">Fecha Inválida-</asp:RangeValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 149px" align="right">
									<asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt">Provisión actual:</asp:label></TD>
								<TD>
									<asp:textbox id="txtproact" runat="server" Width="72px" Font-Names="Verdana" Font-Size="8pt"></asp:textbox>
									<asp:RangeValidator id="RangeValidator1" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="88px"
										ControlToValidate="txtproact" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000"
										MaximumValue="01/01/3000">Fecha Inválida-</asp:RangeValidator></TD>
							</TR>
						</TABLE>
						<asp:Label id="label_mensaje" runat="server" Width="168px" Font-Names="Verdana" Font-Size="8pt"></asp:Label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 64px" align="center"><INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
