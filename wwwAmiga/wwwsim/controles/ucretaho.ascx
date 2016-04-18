<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucretaho" CodeFile="ucretaho.ascx.vb" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="536" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 536px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 336px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 20px" align="center">
			<asp:label id="Label1" Font-Bold="True" Font-Names="Verdana" runat="server" Width="278px" ForeColor="#16387C"
				Font-Size="Medium" Height="15px">RETIRO DE AHORROS</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 238px" align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="520" border="0" style="WIDTH: 520px; HEIGHT: 211px">
				<TR>
					<TD style="WIDTH: 70px"></TD>
					<TD style="WIDTH: 141px"></TD>
					<TD style="WIDTH: 87px"></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 70px; HEIGHT: 23px"><asp:label id="Label2" Width="80px" runat="server" Font-Names="Verdana" Font-Size="8pt">Nº Asociado:</asp:label></TD>
					<TD style="WIDTH: 141px; HEIGHT: 23px"><asp:textbox id="txtcodcli" runat="server" Font-Names="Verdana" Font-Size="8pt" Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 87px; HEIGHT: 23px"><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt">Nombre:</asp:label></TD>
					<TD style="HEIGHT: 23px"><asp:textbox id="txtnomcli" Width="176px" runat="server" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 70px; HEIGHT: 22px"><asp:label id="Label4" Width="96px" runat="server" Font-Names="Verdana" Font-Size="8pt">Tipo de Ahorro:</asp:label></TD>
					<TD style="WIDTH: 141px; HEIGHT: 22px">
						<asp:dropdownlist id="ddltipaho" runat="server" Width="136px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 87px; HEIGHT: 22px">
						<asp:Label id="Label11" Width="72px" runat="server" Font-Names="Verdana" Font-Size="8pt">Nº Cuenta:</asp:Label></TD>
					<TD style="HEIGHT: 22px">
						<asp:TextBox id="txtcodcta" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="112px"
							Enabled="False"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 70px; HEIGHT: 24px"><asp:label id="Label7" Width="40px" runat="server" Font-Names="Verdana" Font-Size="8pt">Saldo</asp:label></TD>
					<TD style="WIDTH: 141px; HEIGHT: 24px">
						<asp:textbox id="txtsaldo" runat="server" Font-Names="Verdana" Font-Size="8pt" Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 87px; HEIGHT: 24px"><asp:label id="Label5" Width="64px" runat="server" Font-Names="Verdana" Font-Size="8pt">Disponible:</asp:label></TD>
					<TD style="HEIGHT: 24px"><asp:textbox id="txtdispo" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="112px"
							Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 70px; HEIGHT: 22px"></TD>
					<TD style="WIDTH: 141px; HEIGHT: 22px"><asp:checkbox id="CheckBox1" runat="server" Text="Con Libreta" Width="88px" Font-Names="Verdana"
							BorderWidth="0px" Font-Size="8pt"></asp:checkbox></TD>
					<TD style="WIDTH: 87px; HEIGHT: 22px"><asp:label id="Label8" Width="88px" runat="server" Font-Names="Verdana" Font-Size="8pt">Tipo de Retiro:</asp:label></TD>
					<TD style="HEIGHT: 22px"><asp:dropdownlist id="ddltipo" Width="144px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 70px; HEIGHT: 19px"></TD>
					<TD style="WIDTH: 141px; HEIGHT: 19px"></TD>
					<TD style="WIDTH: 87px; HEIGHT: 19px"><asp:label id="Label9" Width="40px" runat="server" Font-Names="Verdana" Font-Size="8pt">Banco</asp:label></TD>
					<TD style="HEIGHT: 19px"><asp:dropdownlist id="ddlbanco" Width="144px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 70px; HEIGHT: 21px"></TD>
					<TD style="WIDTH: 141px; HEIGHT: 21px"></TD>
					<TD style="WIDTH: 87px; HEIGHT: 21px"><asp:label id="Label12" Width="32px" runat="server" Font-Names="Verdana" Font-Size="8pt"> Fecha:</asp:label></TD>
					<TD style="HEIGHT: 21px">
						<asp:textbox id="txtfecha" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="72px" Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 70px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 141px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 87px; HEIGHT: 20px"><asp:label id="Label13" Width="56px" runat="server" Font-Names="Verdana" Font-Size="8pt">Nro. Doc:</asp:label></TD>
					<TD style="HEIGHT: 20px">
						<asp:textbox id="txtnrodoc" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="112px"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 70px"></TD>
					<TD style="WIDTH: 141px"></TD>
					<TD style="WIDTH: 87px"><asp:label id="Label6" Width="40px" runat="server" Font-Names="Verdana" Font-Size="8pt">Retiro:</asp:label></TD>
					<TD>
						<asp:textbox id="txtmonto" runat="server" BackColor="AliceBlue" Width="104px" Font-Names="Verdana"
							Font-Size="8pt"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 70px"></TD>
					<TD style="WIDTH: 141px"></TD>
					<TD style="WIDTH: 87px"></TD>
					<TD>
						<asp:RangeValidator id="RangeValidator3" Font-Size="8pt" Width="82px" runat="server" Font-Names="Verdana"
							MaximumValue="1000000000" MinimumValue="0.01" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="txtmonto">Valor Inválido</asp:RangeValidator></TD>
				</TR>
			</TABLE>
			<asp:label id="Label10" Width="136px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:label></TD>
	</TR>
	<TR>
		<TD align="center"><INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 64px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 64px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<INPUT id="btncancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 64px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;</TD>
	</TR>
</TABLE>
