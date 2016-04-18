<%@ Control Language="vb" AutoEventWireup="false" Inherits="uccalmora" CodeFile="uccalmora.ascx.vb" %>
<P>
	<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="272" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 272px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 152px; BACKGROUND-COLOR: inactivecaptiontext"
		bgColor="inactivecaptiontext">
		<TR>
			<TD align="center" bgColor="lightcyan">
				<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: inactivecaptiontext"
					align="center">CALCULO DE MORA</P>
			</TD>
		</TR>
		<TR>
			<TD>
				<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="210" border="1" style="WIDTH: 210px; HEIGHT: 80px"
					align="center" borderColor="#333366" bgColor="#ffff99">
					<TR>
						<TD style="HEIGHT: 64px">
							<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD style="WIDTH: 212px" align="right">
										<asp:Label id="Label1" BackColor="Transparent" ForeColor="DarkBlue" BorderWidth="0px" Width="73px"
											runat="server" Font-Size="8pt" Font-Names="Verdana" Visible="False"></asp:Label></TD>
									<TD>
										<P align="left">&nbsp;</P>
									</TD>
								</TR>
							</TABLE>
							<asp:Label id="Label2" Font-Names="Verdana" Font-Size="8pt" runat="server">Fecha Proceso:</asp:Label>
							<asp:TextBox id="txtfecval" Font-Names="Verdana" Font-Size="8pt" runat="server" Width="104px"
								Enabled="False" BorderWidth="1px"></asp:TextBox>
							<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="174" border="0" style="WIDTH: 174px; HEIGHT: 22px"
								align="center">
								<TR>
									<TD style="WIDTH: 133px" align="right">
										<asp:label id="Label3" Width="56px" runat="server" Font-Size="8pt" Font-Names="Verdana" Height="15px"
											Visible="False">Nombre:</asp:label></TD>
									<TD>
										<asp:textbox id="txtnomcli" tabIndex="5" BorderWidth="1px" Width="65px" runat="server" Font-Size="X-Small"
											Font-Names="Verdana" Enabled="False" Visible="False"></asp:textbox></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
					<TR>
						<TD align="center">&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 68px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></TD>
					</TR>
				</TABLE>
				<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="259" border="0" style="WIDTH: 259px; HEIGHT: 19px"
					align="center">
					<TR>
						<TD style="WIDTH: 76px" align="right">
							<asp:label id="Label4" Width="56px" runat="server" Font-Size="8pt" Font-Names="Verdana" Height="15px"
								Visible="False">Crédito:</asp:label></TD>
						<TD style="WIDTH: 76px" align="right">
							<asp:dropdownlist id="ddlcodins" Width="52px" runat="server" Font-Size="8pt" Font-Names="Verdana"
								Height="16px" Visible="False"></asp:dropdownlist></TD>
						<TD style="WIDTH: 95px" align="right">
							<asp:dropdownlist id="ddlcodofi" Width="33px" runat="server" Font-Size="8pt" Font-Names="Verdana"
								Visible="False"></asp:dropdownlist></TD>
						<TD style="WIDTH: 145px" align="left">
							<asp:textbox id="txtcnrocta" tabIndex="5" BorderWidth="1px" Width="42px" runat="server" Font-Size="8pt"
								Font-Names="Verdana" Enabled="False" Visible="False"></asp:textbox></TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
</P>
