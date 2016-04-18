<%@ Control Language="vb" AutoEventWireup="false" Inherits="cuwRepHip" CodeFile="cuwRepHip.ascx.vb" %>
<TABLE id="Table4" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 520px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 266px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="520" border="0">
	<TR>
		<TD style="HEIGHT: 114px" align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">REPORTES GARANTIAS HIPOTECARIAS</P>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">
				<TABLE id="Table1" style="WIDTH: 485px; HEIGHT: 216px" cellSpacing="0" cellPadding="0"
					width="485" border="0">
					<TR>
						<TD style="HEIGHT: 53px" align="center">
							<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD style="WIDTH: 126px" align="right">
										<asp:label id="Label2" runat="server" Width="41px" Font-Size="8pt" Font-Names="Verdana">Desde:</asp:label></TD>
									<TD style="WIDTH: 65px">
										<asp:textbox id="txtdfecdesde" runat="server" Width="87px" Font-Size="8pt" Font-Names="Verdana"
											BorderWidth="1px" Font-Bold="True"></asp:textbox></TD>
									<TD style="WIDTH: 60px" align="right">
										<asp:label id="Label1" runat="server" Width="41px" Font-Size="8pt" Font-Names="Verdana">Hasta:</asp:label></TD>
									<TD style="WIDTH: 88px">
										<asp:textbox id="txtdfechasta" runat="server" Width="87px" Font-Size="8pt" Font-Names="Verdana"
											BorderWidth="1px" Font-Bold="True"></asp:textbox></TD>
									<TD>
										<asp:CheckBox id="CheckBox1" runat="server" Font-Size="8pt" Font-Names="Verdana" Text="Todo"></asp:CheckBox></TD>
								</TR>
							</TABLE>
							<asp:rangevalidator id="RangeValidator5" runat="server" Font-Size="8pt" Font-Names="Verdana" DESIGNTIMEDRAGDROP="1491"
								Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtdfecdesde"
								ErrorMessage="RangeValidator">Fecha de Desde Inválida</asp:rangevalidator>
							<asp:rangevalidator id="Rangevalidator1" runat="server" Font-Size="8pt" Font-Names="Verdana" DESIGNTIMEDRAGDROP="1491"
								Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtdfechasta"
								ErrorMessage="RangeValidator">Fecha de Hasta Inválida</asp:rangevalidator></TD>
					</TR>
					<TR>
						<TD align="center">
							<TABLE id="Table3" style="WIDTH: 314px; HEIGHT: 54px" borderColor="#ff9900" cellSpacing="0"
								cellPadding="0" width="314" bgColor="#ffffcc" border="2">
								<TR>
									<TD style="WIDTH: 166px">
										<asp:CheckBox id="CheckBox4" runat="server" Width="123px" Font-Size="8pt" Font-Names="Verdana"
											Text="Incluir Saneadas"></asp:CheckBox></TD>
									<TD>
										<asp:radiobutton id="rbt3" runat="server" Width="170px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="0px"
											ForeColor="Black" Text="Todas" GroupName="rhipo" AutoPostBack="True" Checked="True"></asp:radiobutton></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 166px">
										<asp:CheckBox id="CheckBox3" runat="server" Width="197px" Font-Size="8pt" Font-Names="Verdana"
											Text="Incluir Cancelados"></asp:CheckBox></TD>
									<TD>
										<asp:radiobutton id="rbt2" runat="server" Width="169px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="0px"
											ForeColor="Black" Text="Inscritas y Presentadas" GroupName="rhipo" AutoPostBack="True"></asp:radiobutton></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 166px">
										<asp:CheckBox id="CheckBox2" runat="server" Width="197px" Font-Size="8pt" Font-Names="Verdana"
											Text="Incluir vigentes" Checked="True"></asp:CheckBox></TD>
									<TD align="left">
										<asp:radiobutton id="rbt1" runat="server" Width="153px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="0px"
											ForeColor="Black" Text="Observadas" GroupName="rhipo" AutoPostBack="True"></asp:radiobutton></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD align="center"><INPUT id="btnprint" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
</TABLE>
