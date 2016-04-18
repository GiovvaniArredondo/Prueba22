<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Login.ascx.vb" Inherits="wwwSIM.Login1" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE style="WIDTH: 249px; HEIGHT: 360px" cellPadding="4" width="249" border="0" bgColor="inactivecaption"
	align="left">
	<TR>
		<TD align="center" background="../imagenes/fondo.gif" bgColor="#eeffff">
			<TABLE style="WIDTH: 228px; HEIGHT: 174px" borderColor="#000099" bgColor="#ffffff" borderColorLight="#0000ff"
				border="0">
				<TR>
					<TD style="FONT-WEIGHT: bold; FONT-SIZE: 0.9em; COLOR: white; FONT-STYLE: normal; HEIGHT: 39px; BACKGROUND-COLOR: #5d7b9d"
						align="center" bgColor="#ffff66" colSpan="2">
						<asp:Image id="Image1" Width="220px" ImageUrl="../imagenes/teclado.jpg" runat="server" Height="46px"></asp:Image></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 0.8em; WIDTH: 96px; HEIGHT: 25px" align="right" bgColor="#eeffff"><asp:label id="lblUsuario" Runat="server" Font-Names="Century Gothic">Usuario:</asp:label></TD>
					<TD style="HEIGHT: 25px" align="left" bgColor="#eeffff"><asp:textbox id="txtUsuario" Width="112px" Runat="server" Font-Names="Century Gothic" BorderColor="Black"
							Font-Size="0.8em"></asp:textbox><asp:requiredfieldvalidator id="requiredUsuario" Runat="server" ToolTip="Usuario es requerido." ControlToValidate="txtUsuario"
							ErrorMessage="Usuario es requerido.">
									*</asp:requiredfieldvalidator></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 0.8em; WIDTH: 96px; HEIGHT: 26px" align="right" bgColor="#eeffff"><asp:label id="lblClave" Runat="server" Font-Names="Century Gothic">Clave:</asp:label></TD>
					<TD style="HEIGHT: 26px" align="left" bgColor="#eeffff"><asp:textbox id="txtClave" Width="110px" Runat="server" Font-Names="Arial" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password"></asp:textbox><asp:requiredfieldvalidator id="requiredClave" Runat="server" ToolTip="Clave es requerida." ControlToValidate="txtClave"
							ErrorMessage="Clave es requerida.">
									*</asp:requiredfieldvalidator></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 27px" borderColor="#3300cc" align="center" bgColor="#eeffff" colSpan="2">
						<asp:Button id="btnIn" Font-Names="Verdana" runat="server" Text="Ingresar"></asp:Button></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 0.8em; COLOR: red" bgColor="#ffffff" colSpan="2"><asp:literal id="FailureText" Runat="server" EnableViewState="False"></asp:literal></TD>
				</TR>
			</TABLE>
			<TABLE id="Table1" style="WIDTH: 236px; HEIGHT: 152px" cellSpacing="0" cellPadding="0"
				width="236" border="0">
				<TR>
					<TD align="center" bgColor="#006699" style="WIDTH: 282px; HEIGHT: 169px">
						<asp:Label id="Label2" Font-Names="Garamond" Width="233px" ForeColor="White" Font-Size="Small"
							runat="server" Font-Bold="True">Fundación de Capacitación y Asesoría  en Microfinanzas</asp:Label>
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="HEIGHT: 63px" align="center">
									<asp:Label id="Label3" Font-Names="Garamond" Width="233px" ForeColor="White" Font-Size="X-Small"
										runat="server" Font-Bold="True">Edificio Century Plaza, Alameda Manuel Enrique Araujo, Km 4 Carretera a Santa Tecla, San Salvador, El Salvador, C.A.</asp:Label></TD>
							</TR>
						</TABLE>
						<asp:Label id="Label4" Font-Names="Garamond" Width="233px" ForeColor="White" Font-Size="X-Small"
							runat="server" Font-Bold="True">PBX(503) 2265-2177</asp:Label>
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="HEIGHT: 18px" align="center">
									<asp:Label id="Label5" Font-Names="Garamond" Width="233px" ForeColor="White" Font-Size="X-Small"
										runat="server" Font-Bold="True">FAX(503) 2265-2173</asp:Label></TD>
							</TR>
						</TABLE>
						<asp:HyperLink id="HyperLink1" ForeColor="White" runat="server" NavigateUrl="http://www.fundamicro.com/">www.fundamicro.com</asp:HyperLink></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
