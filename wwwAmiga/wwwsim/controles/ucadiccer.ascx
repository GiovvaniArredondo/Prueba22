<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucadiccer" CodeFile="ucadiccer.ascx.vb" %>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 584px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 352px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="584" border="0">
	<TR>
		<TD style="HEIGHT: 29px" align="center"><asp:label id="Label1" Height="15px" ForeColor="#16387C" Font-Size="Medium" Width="362px" runat="server"
				Font-Names="Verdana" Font-Bold="True">ADICION DE CERTIFICADOS</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 59px" align="center">
			<P align="center"><INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 56px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 49px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server"></P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 189px" align="center">
			<TABLE id="Table2" style="WIDTH: 559px; HEIGHT: 192px" cellSpacing="0" cellPadding="0"
				width="559" align="center" border="0">
				<TR>
					<TD style="WIDTH: 96px; HEIGHT: 21px" align="left"><asp:label id="Label11" Font-Size="8pt" Width="64px" runat="server" Font-Names="Verdana">Certificado:</asp:label></TD>
					<TD style="WIDTH: 212px; HEIGHT: 21px"><asp:textbox id="txtccodcrt" Font-Size="8pt" runat="server" Font-Names="Verdana"></asp:textbox></TD>
					<TD style="WIDTH: 151px; HEIGHT: 21px" align="right">
						<P align="center">&nbsp;</P>
					</TD>
					<TD style="WIDTH: 402px; HEIGHT: 21px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 96px; HEIGHT: 26px" align="left"><asp:label id="Label15" Font-Size="8pt" Width="56px" runat="server" Font-Names="Verdana">Cod.Cliente:</asp:label></TD>
					<TD style="WIDTH: 212px; HEIGHT: 26px"><asp:textbox id="txtcodcli" Font-Size="8pt" Width="104px" runat="server" Font-Names="Verdana"
							Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 151px; HEIGHT: 26px" align="right">
						<P align="left"><asp:label id="Label10" Font-Size="8pt" Width="112px" runat="server" Font-Names="Verdana">Fecha de Apertura:</asp:label></P>
					</TD>
					<TD style="WIDTH: 402px; HEIGHT: 26px"><asp:textbox id="txtfecape" Font-Size="8pt" Width="80px" runat="server" Font-Names="Verdana"></asp:textbox><asp:label id="Label12" ForeColor="Red" Font-Size="8pt" Width="64px" runat="server" Font-Names="Verdana"
							BorderColor="Red">dd/mm/aa</asp:label><asp:rangevalidator id="RangeValidator5" Font-Size="8pt" Width="88px" runat="server" Font-Names="Verdana"
							ControlToValidate="txtfecape" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000">Fecha Inválida-</asp:rangevalidator></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 96px; HEIGHT: 19px" align="left"><asp:label id="Label2" Font-Size="8pt" Width="56px" runat="server" Font-Names="Verdana">Nombre:</asp:label></TD>
					<TD style="WIDTH: 212px; HEIGHT: 19px"><asp:textbox id="txtnomcli" Font-Size="8pt" Width="168px" runat="server" Font-Names="Verdana"
							Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 151px; HEIGHT: 19px" align="right">
						<P align="left"><asp:label id="Label13" Font-Size="8pt" Width="134px" runat="server" Font-Names="Verdana">Fecha de Vencimiento:</asp:label></P>
					</TD>
					<TD style="WIDTH: 402px; HEIGHT: 19px"><asp:textbox id="txtfecven" Font-Size="8pt" Width="80px" runat="server" Font-Names="Verdana"></asp:textbox><asp:label id="Label14" ForeColor="Red" Font-Size="8pt" Width="64px" runat="server" Font-Names="Verdana"
							BorderColor="Red">dd/mm/aa</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 96px; HEIGHT: 4px" align="left"></TD>
					<TD style="WIDTH: 212px; HEIGHT: 4px"></TD>
					<TD style="WIDTH: 151px; HEIGHT: 4px" align="right">
						<P align="left">&nbsp;</P>
					</TD>
					<TD style="WIDTH: 402px; HEIGHT: 4px"><asp:rangevalidator id="RangeValidator1" Font-Size="8pt" Width="88px" runat="server" Font-Names="Verdana"
							ControlToValidate="txtfecven" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000">Fecha Inválida-</asp:rangevalidator></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 96px; HEIGHT: 12px" align="left"><asp:label id="Label3" Font-Size="8pt" Width="59px" runat="server" Font-Names="Verdana">Cuenta de Ahorro:</asp:label></TD>
					<TD style="WIDTH: 212px; HEIGHT: 12px"><asp:textbox id="txtcodaho" Font-Size="8pt" Width="128px" runat="server" Font-Names="Verdana"></asp:textbox></TD>
					<TD style="WIDTH: 151px; HEIGHT: 12px" align="left"><asp:checkbox id="chqpignorar" Font-Size="8pt" Width="143px" runat="server" Font-Names="Verdana"
							Text="Pignorar Certificado"></asp:checkbox></TD>
					<TD style="WIDTH: 402px; HEIGHT: 12px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 96px; HEIGHT: 6px" align="left"><asp:label id="Label4" Font-Size="8pt" Width="48px" runat="server" Font-Names="Verdana">Monto:</asp:label></TD>
					<TD style="WIDTH: 212px; HEIGHT: 6px"><asp:textbox id="txtmonto" Font-Size="8pt" Width="80px" runat="server" Font-Names="Verdana"></asp:textbox><asp:rangevalidator id="RangeValidator3" Font-Size="8pt" Width="82px" runat="server" Font-Names="Verdana"
							ControlToValidate="txtmonto" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:rangevalidator></TD>
					<TD style="WIDTH: 151px; HEIGHT: 6px" align="right"></TD>
					<TD style="WIDTH: 402px; HEIGHT: 6px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 96px; HEIGHT: 5px" align="left"><asp:label id="Label5" Font-Size="8pt" Width="32px" runat="server" Font-Names="Verdana">Tasa:</asp:label></TD>
					<TD style="WIDTH: 212px; HEIGHT: 5px"><asp:textbox id="txttasa" Font-Size="8pt" Width="56px" runat="server" Font-Names="Verdana"></asp:textbox><asp:label id="Label7" Font-Size="8pt" runat="server" Font-Names="Verdana">%</asp:label><asp:rangevalidator id="RangeValidator6" Height="12px" Font-Size="8pt" Width="86px" runat="server" Font-Names="Verdana"
							ControlToValidate="txttasa" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="100">Valor Inválido-</asp:rangevalidator></TD>
					<TD style="WIDTH: 151px; HEIGHT: 5px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 96px; HEIGHT: 22px" align="left"><asp:label id="Label6" Font-Names="Verdana" runat="server" Width="32px" Font-Size="8pt">Plazo:</asp:label></TD>
					<TD style="WIDTH: 212px; HEIGHT: 22px"><asp:textbox id="txtplazo" Font-Names="Verdana" runat="server" Width="56px" Font-Size="8pt"></asp:textbox>
						<asp:RangeValidator id="RangeValidator2" Height="8px" Font-Size="8pt" Width="86px" runat="server" Font-Names="Verdana"
							ControlToValidate="txtplazo" ErrorMessage="RangeValidator" Type="Double" MinimumValue="1" MaximumValue="10000">Valor Inválido-</asp:RangeValidator></TD>
					<TD style="WIDTH: 151px; HEIGHT: 22px"></TD>
				</TR>
			</TABLE>
			<INPUT id="btngrabar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 71px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server"></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
