<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucprovaporta" CodeFile="ucprovaporta.ascx.vb" %>
<TABLE id="Table3" style="WIDTH: 608px; HEIGHT: 227px" cellSpacing="0" cellPadding="0"
	width="608" align="left" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 320px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 208px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="320" border="0">
				<TR>
					<TD>
						<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
							align="justify">PROVISION DE AHORROS&nbsp; &nbsp;(No incluye aportaciones)</P>
					</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 79px" align="center">
						<TABLE id="Table2" style="WIDTH: 251px; HEIGHT: 60px" cellSpacing="0" cellPadding="0" width="251"
							border="0">
							<TR>
								<TD style="WIDTH: 154px" align="right">
									<asp:label id="Label2" runat="server" Width="136px" Font-Names="Verdana" Font-Size="8pt">Provisión de Intereses:</asp:label></TD>
								<TD align="center">
									<asp:textbox id="txtprovi" runat="server" Width="72px" Font-Names="Verdana" Font-Size="8pt"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 154px" align="right"></TD>
								<TD>
									<asp:RangeValidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" Width="88px" runat="server"
										MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtprovi">Fecha Inválida-</asp:RangeValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 154px" align="right">
									<asp:CheckBox id="capitalizar" runat="server" Width="144px" Text="Capitalizar Intereses" Font-Names="Verdana"
										Font-Size="8pt"></asp:CheckBox></TD>
								<TD></TD>
							</TR>
						</TABLE>
						<asp:label id="label_mensaje" runat="server" Width="168px" Font-Names="Verdana" Font-Size="8pt"></asp:label></TD>
				</TR>
				<TR>
					<TD align="center"><INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 58px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
