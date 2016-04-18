<%@ control language="vb" autoeventwireup="false" inherits="uccreausu, App_Web_5wr0lfuo" %>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 456px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 368px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="456" border="0">
	<TR>
		<TD align="center"><asp:label id="Label1" ForeColor="#16387C" Font-Size="Medium" Width="219px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Height="15px">CREAR USUARIOS</asp:label></TD>
	</TR>
	<TR>
		<TD align="center"><asp:label id="indica" Font-Size="8pt" Width="384px" runat="server" Font-Names="Verdana"></asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 183px">
			<TABLE id="Table2" style="WIDTH: 447px; HEIGHT: 181px" cellSpacing="0" cellPadding="0"
				width="447" align="center" border="0">
				<TR>
					<TD style="WIDTH: 123px; HEIGHT: 32px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="Label2" Font-Size="8pt" Width="43px" runat="server" Font-Names="Verdana">Código:</asp:label></TD>
					<TD style="HEIGHT: 32px"><asp:textbox id="txtcodusu" Font-Size="8pt" Width="104px" runat="server" Font-Names="Verdana"></asp:textbox><asp:textbox id="txtcodigo" Font-Size="8pt" Width="48px" runat="server" Font-Names="Verdana"
							Visible="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 123px; HEIGHT: 30px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="Label3" Font-Size="8pt" Width="49px" runat="server" Font-Names="Verdana">Nombre:</asp:label></TD>
					<TD style="HEIGHT: 30px"><asp:textbox id="txtnombre" Font-Size="8pt" Width="304px" runat="server" Font-Names="Verdana"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 123px; HEIGHT: 28px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="Label4" Font-Size="8pt" Width="55px" runat="server" Font-Names="Verdana">Dirección:</asp:label></TD>
					<TD style="HEIGHT: 28px"><asp:textbox id="txtdireccion" Font-Size="8pt" Width="304px" runat="server" Font-Names="Verdana"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 123px; HEIGHT: 28px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="Label5" Font-Size="8pt" Width="51px" runat="server" Font-Names="Verdana">Teléfono:</asp:label></TD>
					<TD style="HEIGHT: 28px"><asp:textbox id="txttelefono" Font-Size="8pt" Width="120px" runat="server" Font-Names="Verdana"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 123px; HEIGHT: 28px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="Label6" Font-Size="8pt" Width="41px" runat="server" Font-Names="Verdana">Cargo:</asp:label></TD>
					<TD style="HEIGHT: 28px"><asp:dropdownlist id="ddlcargo" Font-Size="8pt" Width="264px" runat="server" Font-Names="Verdana"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 123px; HEIGHT: 28px" align="right"><asp:label id="Label9" Font-Size="8pt" Width="84px" runat="server" Font-Names="Verdana">Pertenece a Oficina:</asp:label></TD>
					<TD style="HEIGHT: 28px"><asp:dropdownlist id="cbxCodOFi" Font-Size="8pt" Width="216px" runat="server" Font-Names="Verdana"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 123px; HEIGHT: 27px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="Label7" Font-Size="8pt" Width="35px" runat="server" Font-Names="Verdana">Clave:</asp:label></TD>
					<TD id="clave1" style="HEIGHT: 27px"><asp:textbox id="clave" Font-Size="8pt" runat="server" Font-Names="Verdana" TextMode="Password"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 123px; HEIGHT: 37px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="Label8" Font-Size="8pt" Width="94px" runat="server" Font-Names="Verdana">Confirmar Clave:</asp:label></TD>
					<TD id="clave2" style="HEIGHT: 37px"><asp:textbox id="txtconfirmar" Font-Size="8pt" runat="server" Font-Names="Verdana" TextMode="Password"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;<INPUT id="btngrabar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server"></TD>
	</TR>
</TABLE>
