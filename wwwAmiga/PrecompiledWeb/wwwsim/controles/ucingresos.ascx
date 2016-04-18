<%@ control language="vb" autoeventwireup="false" inherits="ucingresos, App_Web_pi2jwlis" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD>
			<asp:Label id="label_mensaje" Width="232px" runat="server"></asp:Label></TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:Label id="Label2" BackColor="AliceBlue" Width="208px" runat="server" BorderWidth="1px"
				Font-Bold="True" Font-Names="Verdana">Ingresos Diarios</asp:Label></TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 310px"></TD>
					<TD style="WIDTH: 180px"></TD>
					<TD style="WIDTH: 78px"></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 310px" align="right">
						<asp:Label id="Label4" runat="server" Font-Names="Verdana">Desde:</asp:Label></TD>
					<TD style="WIDTH: 180px">
						<asp:TextBox id="txtfecini" runat="server" Font-Names="Verdana"></asp:TextBox></TD>
					<TD style="WIDTH: 78px">
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
				tabIndex="12" type="button" value="Imprimir" name="Button5" runat="server">&nbsp;&nbsp;<INPUT id="btncancela" style="FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND: url(imagenes/Cancelar.gif) fixed no-repeat left center; WIDTH: 126px; COLOR: buttontext; FONT-FAMILY: 'Verdana'; HEIGHT: 36px"
				tabIndex="12" type="button" value="Cancelar" name="Button5" runat="server">&nbsp;&nbsp;<INPUT id="Button5" style="FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND: url(imagenes/Wzclose.bmp) fixed no-repeat left center; WIDTH: 120px; COLOR: buttontext; FONT-FAMILY: 'Verdana'; HEIGHT: 36px"
				tabIndex="12" type="button" value="Salir" name="Button5" runat="server"></TD>
	</TR>
</TABLE>
