<%@ control language="vb" autoeventwireup="false" inherits="uccartera, App_Web_5wr0lfuo" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD>
			<asp:Label id="label_mensaje" Width="232px" runat="server"></asp:Label></TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:Label id="Label2" BackColor="AliceBlue" Width="208px" runat="server" BorderWidth="2px"
				Font-Names="Verdana" Font-Bold="True">Saldos de Cartera</asp:Label></TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 310px"></TD>
					<TD style="WIDTH: 1px"></TD>
					<TD style="WIDTH: 111px"></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 310px" align="right"></TD>
					<TD style="WIDTH: 1px"></TD>
					<TD style="WIDTH: 111px">
						<asp:Label id="Label5" runat="server" Font-Names="Verdana">Hasta:</asp:Label></TD>
					<TD>
						<asp:TextBox id="txtfecfin" runat="server" Font-Names="Verdana"></asp:TextBox></TD>
				</TR>
			</TABLE>
			<asp:Label id="Label6" Width="104px" runat="server"></asp:Label></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="Label1" Width="104px" runat="server"></asp:Label></TD>
	</TR>
	<TR>
		<TD align="center"><INPUT id="btnimprimir" style="FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND: url(imagenes/Wzprint.bmp) fixed no-repeat left center; WIDTH: 124px; COLOR: buttontext; FONT-FAMILY: 'Verdana'; HEIGHT: 38px"
				tabIndex="12" type="button" value="Imprimir" name="Button5" runat="server">&nbsp;&nbsp;<INPUT id="btncancela" style="FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND: url(imagenes/Cancelar.gif) fixed no-repeat left center; WIDTH: 131px; COLOR: buttontext; FONT-FAMILY: 'Verdana'; HEIGHT: 36px"
				tabIndex="12" type="button" value="Cancelar" name="Button5" runat="server">&nbsp;&nbsp;<INPUT id="Button5" style="FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND: url(imagenes/Wzclose.bmp) fixed no-repeat left center; WIDTH: 129px; COLOR: buttontext; FONT-FAMILY: 'Verdana'; HEIGHT: 36px"
				tabIndex="12" type="button" value="Salir" name="Button5" runat="server"></TD>
	</TR>
</TABLE>
