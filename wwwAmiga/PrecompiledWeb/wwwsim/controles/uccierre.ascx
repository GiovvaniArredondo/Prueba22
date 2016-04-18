<%@ control language="vb" autoeventwireup="false" inherits="uccierre, App_Web_yjxjq67i" %>
<TABLE id="Table1" style="WIDTH: 354px; HEIGHT: 216px" borderColor="#006699" cellSpacing="0"
	cellPadding="0" width="354" align="center" border="2" bgColor="#ffffff">
	<TR>
		<TD style="HEIGHT: 20px" align="center"><asp:label id="Label4" runat="server" Width="288px" Font-Size="XX-Small" Font-Names="Verdana"> Deberá usarse para cierres de ejercicios fiscales</asp:label></TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:label id="Label5" Font-Size="Medium" Width="223px" runat="server" Font-Bold="True" Font-Names="Verdana"
				Height="15px" ForeColor="Navy">CIERRE CONTABLE</asp:label></TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="185" border="1" style="WIDTH: 185px; HEIGHT: 86px"
				borderColor="#ff9900" bgColor="lemonchiffon">
				<TR>
					<TD style="WIDTH: 64px" align="right"><asp:label id="Label2" runat="server" Width="48px" Font-Size="X-Small" Font-Names="Verdana">Desde:</asp:label></TD>
					<TD>&nbsp;
						<asp:textbox id="txtfecha1" runat="server" Width="88px" Font-Names="Verdana"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 64px" align="right"><asp:label id="Label3" runat="server" Width="48px" Font-Size="X-Small" Font-Names="Verdana">Hasta:</asp:label></TD>
					<TD>&nbsp;
						<asp:textbox id="txtfecha2" runat="server" Width="88px" Font-Names="Verdana"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center"><asp:button id="Button1" runat="server" Width="128px" Text="cierre" Font-Names="Verdana"></asp:button></TD>
	</TR>
</TABLE>
