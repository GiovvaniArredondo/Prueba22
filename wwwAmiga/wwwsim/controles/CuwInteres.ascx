<%@ Control Language="vb" AutoEventWireup="false" Inherits="CuwInteres" CodeFile="CuwInteres.ascx.vb" %>
<TABLE id="Table8" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 496px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 328px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="496" border="0">
	<TR>
		<TD style="HEIGHT: 114px" align="center">
			<P align="center"><asp:label id="Label1" Font-Bold="True" ForeColor="#0000C0" Font-Names="Verdana" runat="server"
					Width="312px" Font-Size="Medium">Suspensión de Intereses</asp:label></P>
			<P><asp:label id="lblmensaje" ForeColor="#C00000" Font-Names="Verdana" runat="server" Width="466px"
					Font-Size="8pt"></asp:label>
				<TABLE id="Table1" style="WIDTH: 488px; HEIGHT: 218px" cellSpacing="0" cellPadding="0"
					width="488" border="0">
					<TR>
						<TD style="WIDTH: 281px" align="right"><asp:label id="Label2" Font-Names="Verdana" runat="server" Width="110px" Font-Size="8pt">Trasladar A :</asp:label></TD>
						<TD><SELECT id="cbxtraslado" style="FONT-SIZE: 12px; WIDTH: 152px; FONT-FAMILY: 'Verdana'" name="cbxanacre"
								runat="server">
								<OPTION selected></OPTION>
							</SELECT></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 281px; HEIGHT: 27px" align="right"><asp:label id="Label4" Font-Names="Verdana" runat="server" Width="110px" Font-Size="8pt">Fecha de Traslado:</asp:label></TD>
						<TD style="HEIGHT: 27px"><asp:textbox id="TXTFECPRO" Font-Bold="True" Font-Names="Verdana" runat="server" Width="116px"
								Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 281px" align="right">
							<TABLE id="Table2" style="WIDTH: 271px; HEIGHT: 114px" borderColor="blue" cellSpacing="0"
								cellPadding="0" width="271" bgColor="#99deff" border="1">
								<TR>
									<TD style="WIDTH: 51px" align="right"><asp:label id="Label3" Font-Names="Verdana" runat="server" Width="41px" Font-Size="8pt">Crédito:</asp:label></TD>
									<TD><asp:textbox id="txtccodcta" Font-Bold="True" Font-Names="Verdana" runat="server" Width="192px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 51px" align="right"><asp:label id="Label6" Font-Names="Verdana" runat="server" Width="40px" Font-Size="8pt">Cod. Cliente:</asp:label></TD>
									<TD><asp:textbox id="txtccodcli" Font-Bold="True" Font-Names="Verdana" runat="server" Width="192px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 51px; HEIGHT: 46px" align="right"><asp:label id="Label7" Font-Names="Verdana" runat="server" Width="48px" Font-Size="8pt">Nombre:</asp:label></TD>
									<TD style="HEIGHT: 46px"><asp:textbox id="txtcnomcli" Font-Bold="True" Font-Names="Verdana" runat="server" Width="192px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False" Height="38px" Rows="2" TextMode="MultiLine"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 51px" align="right"><asp:label id="Label8" Font-Names="Verdana" runat="server" Width="46px" Font-Size="8pt">Analista:</asp:label></TD>
									<TD><asp:textbox id="txtcnomana" Font-Bold="True" Font-Names="Verdana" runat="server" Width="192px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False" Height="33px" Rows="2" TextMode="MultiLine"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 51px" align="right"><asp:label id="Label9" Font-Names="Verdana" runat="server" Width="51px" Font-Size="8pt">Condición:</asp:label></TD>
									<TD><asp:textbox id="txtccondic" Font-Bold="True" Font-Names="Verdana" runat="server" Width="192px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
								</TR>
							</TABLE>
						</TD>
						<TD>
							<TABLE id="Table3" style="WIDTH: 202px; HEIGHT: 162px" borderColor="#ffcc00" cellSpacing="0"
								cellPadding="0" width="202" bgColor="lemonchiffon" border="1">
								<TR>
									<TD style="WIDTH: 131px; HEIGHT: 14px" align="center"><asp:label id="Label10" Font-Bold="True" Font-Names="Verdana" runat="server" Width="56px" Font-Size="7pt">SALDOS</asp:label></TD>
									<TD style="HEIGHT: 14px" align="center"><asp:label id="Label11" Font-Bold="True" Font-Names="Verdana" runat="server" Width="83px" Font-Size="7pt">Dolares ($)</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 131px" align="right"><asp:label id="Label5" Font-Names="Verdana" runat="server" Width="48px" Font-Size="8pt">Capital:</asp:label></TD>
									<TD><asp:textbox id="txtnsalcap" Font-Bold="True" Font-Names="Verdana" runat="server" Width="96px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 131px" align="right"><asp:label id="Label12" Font-Names="Verdana" runat="server" Width="48px" Font-Size="8pt">Interés:</asp:label></TD>
									<TD><asp:textbox id="txtnsalint" Font-Bold="True" Font-Names="Verdana" runat="server" Width="96px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 131px" align="right"><asp:label id="Label13" Font-Names="Verdana" runat="server" Width="40px" Font-Size="8pt">Mora:</asp:label></TD>
									<TD><asp:textbox id="txtnsalmor" Font-Bold="True" Font-Names="Verdana" runat="server" Width="96px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 131px" align="right"><asp:label id="Label15" Font-Names="Verdana" runat="server" Width="96px" Font-Size="8pt">Dias de Atraso:</asp:label></TD>
									<TD><asp:textbox id="txtndiaatr" Font-Bold="True" Font-Names="Verdana" runat="server" Width="96px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 131px" align="right"><asp:label id="Label16" Font-Names="Verdana" runat="server" Width="88px" Font-Size="8pt">Saldo Deudor:</asp:label></TD>
									<TD><asp:textbox id="txtntotal" Font-Bold="True" Font-Names="Verdana" runat="server" Width="96px"
											Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
								</TR>
							</TABLE>
							<asp:textbox id="txtcondicion" Font-Bold="True" Font-Names="Verdana" runat="server" Width="40px"
								Font-Size="8pt" BorderWidth="1px" Enabled="False" Visible="False" Height="7px"></asp:textbox><asp:textbox id="txtcestado" Font-Bold="True" Font-Names="Verdana" runat="server" Width="40px"
								Font-Size="8pt" BorderWidth="1px" Enabled="False" Visible="False" Height="7px"></asp:textbox>
							<asp:textbox id="txtccodlin" Font-Size="8pt" Width="40px" runat="server" Font-Names="Verdana"
								Font-Bold="True" Enabled="False" BorderWidth="1px" Height="7px" Visible="False"></asp:textbox></TD>
					</TR>
				</TABLE>
			</P>
			<asp:button id="btnaplicar" Font-Names="Verdana" runat="server" Width="117px" Text="Trasladar"></asp:button></TD>
	</TR>
</TABLE>
