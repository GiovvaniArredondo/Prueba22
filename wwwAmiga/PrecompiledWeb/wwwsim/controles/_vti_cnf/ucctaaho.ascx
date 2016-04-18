<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ucctaaho.ascx.vb" Inherits="wwwSIM.ucctaaho" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="472" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 472px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 333px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD align="center">
			<asp:label id="Label1" runat="server" Width="336px" Font-Bold="True" Font-Names="Verdana" Font-Size="Medium"
				ForeColor="#16387C" Height="15px">APERTURA CUENTA DE AHORRO</asp:label></TD>
	</TR>
	<TR>
		<TD align="center" style="HEIGHT: 212px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="443" border="0" style="WIDTH: 443px; HEIGHT: 213px">
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 55px" align="right"><asp:label id="Label3" Width="56px" runat="server" Font-Size="8pt" Font-Names="Verdana">Agencia:</asp:label></TD>
					<TD style="HEIGHT: 55px" align="left"><asp:dropdownlist id="ddloficina" Width="176px" runat="server" Font-Size="8pt" Font-Names="Verdana"></asp:dropdownlist>&nbsp;&nbsp;<INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server">
						<asp:textbox id="txtcodaho" runat="server" Font-Size="8pt" Font-Names="Verdana" Height="24px"
							Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 42px" align="right"><asp:label id="Label4" Width="56px" runat="server" Font-Size="8pt" Font-Names="Verdana">Nombre:</asp:label></TD>
					<TD style="HEIGHT: 42px"><asp:textbox id="txtcodcli" Width="112px" runat="server" Font-Size="8pt" Font-Names="Verdana"
							Enabled="False"></asp:textbox><asp:textbox id="txtnomcli" Width="192px" runat="server" Font-Size="8pt" Font-Names="Verdana"
							Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px" align="right"><asp:label id="Label5" Width="40px" runat="server" Font-Size="8pt" Font-Names="Verdana">Fecha:</asp:label></TD>
					<TD><asp:textbox id="txtfecha" Width="80px" runat="server" Font-Size="8pt" Font-Names="Verdana"></asp:textbox><asp:label id="Label12" Width="64px" runat="server" ForeColor="Red" BorderColor="Red" Font-Names="Verdana"
							Font-Size="8pt">dd/mm/aa</asp:label>
						<asp:RangeValidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" Width="88px" runat="server"
							MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecha">Fecha Inválida-</asp:RangeValidator></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 30px" align="right"><asp:label id="Label6" Width="113px" runat="server" Font-Size="8pt" Font-Names="Verdana">Tipo cuenta ahorro:</asp:label></TD>
					<TD style="HEIGHT: 30px"><asp:dropdownlist id="ddltipaho" Width="184px" runat="server" Font-Size="8pt" Font-Names="Verdana"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 14px" align="right"><asp:label id="Label7" Width="96px" runat="server" Font-Size="8pt" Font-Names="Verdana">Línea de ahorro:</asp:label></TD>
					<TD style="HEIGHT: 14px"><asp:dropdownlist id="ddllineas" Width="184px" runat="server" Font-Size="8pt" Font-Names="Verdana"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px"></TD>
					<TD><asp:label id="Label8" Width="144px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:label></TD>
				</TR>
			</TABLE>
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		</TD>
	</TR>
	<TR>
		<TD align="center"><INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server"></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
