<%@ control language="vb" autoeventwireup="false" inherits="ucestctactb, App_Web_pi2jwlis" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="408" border="0" style="WIDTH: 408px; HEIGHT: 273px">
	<TR>
		<TD align="center"></TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table4" style="WIDTH: 354px; HEIGHT: 216px" borderColor="#006699" cellSpacing="0"
				cellPadding="0" width="354" align="center" border="2">
				<TR>
					<TD align="center">
						<asp:label id="Label1" Font-Size="Medium" Font-Names="Verdana" Width="332px" runat="server"
							ForeColor="#16387C" Height="15px" Font-Bold="True">ESTADO DE CUENTA CONTABLE</asp:label></TD>
				</TR>
				<TR>
					<TD align="center">
						<TABLE id="Table2" style="WIDTH: 200px; HEIGHT: 86px" borderColor="#ff9900" cellSpacing="0"
							cellPadding="0" width="200" bgColor="lemonchiffon" border="1">
							<TR>
								<TD style="WIDTH: 141px" align="right">
									<asp:label id="Label2" Font-Size="X-Small" Font-Names="Verdana" Width="48px" runat="server">Desde:</asp:label></TD>
								<TD>
									&nbsp;
									<asp:textbox id="txtfecha1" runat="server" Width="120px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 141px" align="right">
									<asp:label id="Label3" Font-Size="X-Small" Font-Names="Verdana" Width="48px" runat="server">Hasta:</asp:label></TD>
								<TD>&nbsp;
									<asp:textbox id="txtfecha2" runat="server" Width="120px"></asp:textbox></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="center"><INPUT id="btnprint" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 71px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD>
			<asp:TextBox id="txtcodcta" runat="server" Visible="False"></asp:TextBox></TD>
	</TR>
</TABLE>
