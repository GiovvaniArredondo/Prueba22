<%@ Control Language="vb" AutoEventWireup="false" Codefile="uccierreMen.ascx.vb" Inherits="uccierreMen"  %>
<TABLE id="Table1" style="WIDTH: 354px; HEIGHT: 216px" borderColor="#006699" cellSpacing="0"
	cellPadding="0" width="354" align="center" border="2" bgColor="#ffffff">
	<TR>
		<TD style="HEIGHT: 20px" align="center">&nbsp;</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:label id="Label5" Font-Size="Medium" Width="309px" runat="server" 
                Font-Bold="True" Font-Names="Gill Sans MT"
				Height="15px" ForeColor="Navy">CIERRE CONTABLE MENSUAL</asp:label></TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="185" border="1" style="WIDTH: 185px; HEIGHT: 86px; background-color: #99FF66;"
				borderColor="#ff9900" bgColor="lemonchiffon">
				<TR>
					<TD style="WIDTH: 64px" align="right"><asp:label id="Label2" runat="server" 
                            Width="48px" Font-Size="12pt" Font-Names="Gill Sans MT">Desde:</asp:label></TD>
					<TD>&nbsp;
						<asp:textbox id="txtfecha1" runat="server" Width="88px" Font-Names="Verdana" 
                            Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 64px" align="right"><asp:label id="Label3" runat="server" 
                            Width="48px" Font-Size="12pt" Font-Names="Gill Sans MT">Hasta:</asp:label></TD>
					<TD>&nbsp;
						<asp:textbox id="txtfecha2" runat="server" Width="88px" Font-Names="Verdana" 
                            Enabled="False"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center"><asp:button id="Button1" runat="server" Width="128px" 
                Text="cierre" Font-Names="Gill Sans MT" Font-Size="12pt"></asp:button></TD>
	</TR>
</TABLE>
