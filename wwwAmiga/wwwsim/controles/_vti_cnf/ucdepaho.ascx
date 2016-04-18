<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ucdepaho.ascx.vb" Inherits="wwwSIM.ucdepaho" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="536" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 536px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 368px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 20px" align="center">
			<asp:label id="Label1" Font-Bold="True" Font-Names="Verdana" ForeColor="#16387C" Width="278px"
				runat="server" Font-Size="Medium" Height="15px">DEPOSITO DE AHORROS</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 282px" align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="511" border="0" style="WIDTH: 511px; HEIGHT: 270px">
				<TR>
					<TD style="WIDTH: 101px"></TD>
					<TD style="WIDTH: 136px"></TD>
					<TD style="WIDTH: 71px"></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 23px"><asp:label id="Label2" runat="server" Width="80px" Font-Names="Verdana" Font-Size="8pt">Nº Asociado:</asp:label></TD>
					<TD style="WIDTH: 136px; HEIGHT: 23px"><asp:textbox id="txtcodcli" runat="server" BorderStyle="Groove" Font-Names="Verdana" Font-Size="X-Small"
							Width="123px" Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 71px; HEIGHT: 23px"><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt">Nombre:</asp:label></TD>
					<TD style="HEIGHT: 23px"><asp:textbox id="txtnomcli" runat="server" Width="161px" BorderStyle="Groove" Font-Names="Verdana"
							Font-Size="8pt" Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 23px"><asp:label id="Label4" runat="server" Width="96px" Font-Names="Verdana" Font-Size="8pt">Tipo de Ahorro:</asp:label></TD>
					<TD style="WIDTH: 136px; HEIGHT: 23px"><asp:dropdownlist id="ddltipaho" runat="server" Width="120px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 71px; HEIGHT: 23px"><asp:label id="Label8" runat="server" Width="112px" Font-Names="Verdana" Font-Size="8pt">Nº Cuenta Ahorro:</asp:label></TD>
					<TD style="HEIGHT: 23px"><asp:textbox id="txtcodcta" runat="server" Width="106px" BorderStyle="Groove" Font-Names="Verdana"
							Font-Size="8pt" Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 25px"><asp:label id="Label16" runat="server" Width="64px" Font-Names="Verdana" Font-Size="8pt">Tipo pago:</asp:label></TD>
					<TD style="WIDTH: 136px; HEIGHT: 25px">
						<P><asp:radiobutton id="efectivo" runat="server" Text="Efectivo" Checked="True" Font-Names="Verdana"
								Font-Size="8pt"></asp:radiobutton></P>
					</TD>
					<TD style="WIDTH: 71px; HEIGHT: 25px"><asp:label id="Label14" runat="server" Width="40px" DESIGNTIMEDRAGDROP="901" Font-Names="Verdana"
							Font-Size="8pt">Banco:</asp:label></TD>
					<TD style="HEIGHT: 25px"><asp:dropdownlist id="ddlbancos" runat="server" Width="120px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 22px"></TD>
					<TD style="WIDTH: 136px; HEIGHT: 22px"><asp:radiobutton id="bancos" runat="server" Text="Bancos" Font-Size="8pt" Font-Names="Verdana"></asp:radiobutton></TD>
					<TD style="WIDTH: 71px; HEIGHT: 22px"><asp:label id="Label11" runat="server" Width="32px" Font-Names="Verdana" Font-Size="8pt">Cajero:</asp:label></TD>
					<TD style="HEIGHT: 22px"><asp:dropdownlist id="ddlcajero" runat="server" Width="120px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 26px"><asp:label id="Label15" runat="server" Width="40px" DESIGNTIMEDRAGDROP="901" Font-Names="Verdana"
							Font-Size="8pt">Oficina:</asp:label></TD>
					<TD style="WIDTH: 136px; HEIGHT: 26px"><asp:dropdownlist id="ddloficina" runat="server" Width="120px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 71px; HEIGHT: 26px"></TD>
					<TD style="HEIGHT: 26px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 23px"></TD>
					<TD style="WIDTH: 136px; HEIGHT: 23px"><asp:label id="Label10" runat="server" Width="56px" DESIGNTIMEDRAGDROP="904" Font-Names="Verdana"
							Font-Size="8pt">Imprimir?</asp:label></TD>
					<TD style="WIDTH: 71px; HEIGHT: 23px"><asp:checkbox id="Imprimir" runat="server" Width="96px" Font-Names="Verdana" Font-Size="X-Small"></asp:checkbox></TD>
					<TD style="HEIGHT: 23px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 23px"></TD>
					<TD style="WIDTH: 136px; HEIGHT: 23px"><asp:label id="Label9" runat="server" Width="64px" Font-Names="Verdana" Font-Size="8pt">Fecha:</asp:label></TD>
					<TD style="WIDTH: 71px; HEIGHT: 23px"><asp:textbox id="txtfecha" runat="server" Width="72px" BorderStyle="Groove" Font-Names="Verdana"
							Font-Size="8pt"></asp:textbox></TD>
					<TD style="HEIGHT: 23px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 24px"></TD>
					<TD style="WIDTH: 136px; HEIGHT: 24px"><asp:label id="Label5" runat="server" Width="72px" Font-Names="Verdana" Font-Size="8pt">Disponible:</asp:label></TD>
					<TD style="WIDTH: 71px; HEIGHT: 24px"><asp:textbox id="txtsaldo" runat="server" Width="120px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="2px" Enabled="False"></asp:textbox></TD>
					<TD style="HEIGHT: 24px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 23px"></TD>
					<TD style="WIDTH: 136px; HEIGHT: 23px"><asp:label id="Label7" runat="server" Width="56px" Font-Names="Verdana" Font-Size="8pt">Nº.Docto:</asp:label></TD>
					<TD style="WIDTH: 71px; HEIGHT: 23px"><asp:textbox id="txtnrodoc" runat="server" Width="120px" BorderStyle="Groove" Font-Names="Verdana"
							Font-Size="8pt"></asp:textbox></TD>
					<TD style="HEIGHT: 23px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px; HEIGHT: 13px"></TD>
					<TD style="WIDTH: 136px; HEIGHT: 13px"><asp:label id="Label6" runat="server" Width="88px" Font-Names="Verdana" Font-Size="8pt">Depósito:</asp:label></TD>
					<TD style="WIDTH: 71px; HEIGHT: 13px"><asp:textbox id="txtmonto" runat="server" Width="120px" BackColor="AliceBlue" BorderStyle="Groove"
							Font-Names="Verdana" Font-Size="8pt"></asp:textbox></TD>
					<TD style="HEIGHT: 13px">
						<asp:RangeValidator id="RangeValidator3" Font-Size="8pt" runat="server" Width="82px" Font-Names="Verdana"
							ControlToValidate="txtmonto" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0.01" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 101px"></TD>
					<TD style="WIDTH: 136px"></TD>
					<TD style="WIDTH: 71px"><asp:label id="Label13" runat="server" Width="88px" Font-Names="Verdana" Font-Size="8pt"></asp:label></TD>
					<TD></TD>
				</TR>
			</TABLE>
			<INPUT id="btnAplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<INPUT id="btncancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">
		</TD>
	</TR>
</TABLE>
