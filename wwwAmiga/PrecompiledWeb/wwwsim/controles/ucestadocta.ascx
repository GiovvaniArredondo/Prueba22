<%@ control language="vb" autoeventwireup="false" inherits="ucestadocta, App_Web_yl8dokps" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="512" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 512px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 328px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD>&nbsp;
			<asp:label id="label_mensaje" Font-Size="8pt" Width="80px" runat="server" DESIGNTIMEDRAGDROP="134"
				Font-Names="Verdana" Visible="False" BackColor="White">Label</asp:label></TD>
	</TR>
	<TR>
		<TD align="center" style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; BORDER-BOTTOM-WIDTH: thin; BORDER-BOTTOM-COLOR: #0099ff; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"><asp:label id="Label1" runat="server" Width="248px" Font-Size="Medium">ESTADO DE CUENTA</asp:label></TD>
	</TR>
	<TR>
		<TD align="center"><asp:button id="btnaplicar" runat="server" Width="117px" Text="Aplicar" Font-Names="Verdana"></asp:button>
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="459" border="0" style="WIDTH: 459px; HEIGHT: 203px">
				<TR>
					<TD>
						<TABLE id="Table4" style="WIDTH: 122px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="122"
							align="center" border="0">
							<TR>
								<TD style="WIDTH: 449px">
									<P>&nbsp;</P>
								</TD>
							</TR>
						</TABLE>
						<TABLE id="Table8" style="BORDER-RIGHT: blue thin solid; BORDER-TOP: blue thin solid; BORDER-LEFT: blue thin solid; WIDTH: 448px; BORDER-BOTTOM: blue thin solid; HEIGHT: 181px"
							cellSpacing="0" cellPadding="0" width="448" border="0">
							<TR>
								<TD style="WIDTH: 105px" align="right">
									<asp:label id="Label4" Font-Names="Verdana" DESIGNTIMEDRAGDROP="315" runat="server" Font-Size="8pt"
										Font-Bold="True">FECHA AL:</asp:label></TD>
								<TD>
									<asp:textbox id="TXTFECPRO" Font-Names="Verdana" runat="server" Width="116px" Font-Size="8pt"
										Font-Bold="True" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 105px" align="right">
									<asp:label id="Label20" Font-Names="Verdana" DESIGNTIMEDRAGDROP="315" runat="server" Width="61px"
										Font-Size="8pt">Nombre:</asp:label></TD>
								<TD>
									<asp:textbox id="txtnomcli" Font-Names="Verdana" runat="server" Width="208px" Font-Size="8pt"
										BorderWidth="1px" Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 105px" align="right">
									<asp:label id="Label30" Font-Names="Verdana" DESIGNTIMEDRAGDROP="315" runat="server" Width="68px"
										Font-Size="8pt">Agencia:</asp:label></TD>
								<TD>
									<asp:textbox id="txtagencia" Font-Names="Verdana" runat="server" Width="286px" Font-Size="8pt"
										BorderWidth="1px" Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 105px" align="right">
									<asp:label id="Label31" Font-Names="Verdana" DESIGNTIMEDRAGDROP="315" runat="server" Font-Size="8pt">Analista:</asp:label></TD>
								<TD>
									<asp:textbox id="txtnomana" Font-Names="Verdana" runat="server" Width="285px" Font-Size="8pt"
										BorderWidth="1px" Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 105px" align="right">
									<asp:label id="Label2" Font-Names="Verdana" DESIGNTIMEDRAGDROP="320" runat="server" Font-Size="8pt">Cuenta:</asp:label></TD>
								<TD>
									<asp:textbox id="txtcodcta" Font-Names="Verdana" runat="server" Font-Size="8pt" BorderWidth="1px"
										Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 105px" align="right">
									<asp:label id="Label3" Font-Names="Verdana" DESIGNTIMEDRAGDROP="325" runat="server" Font-Size="8pt">Cliente::</asp:label></TD>
								<TD>
									<asp:textbox id="txtcodcli" Font-Names="Verdana" DESIGNTIMEDRAGDROP="327" runat="server" Font-Size="8pt"
										BorderWidth="1px" Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 105px" align="right">
									<asp:label id="Label5" Font-Names="Verdana" DESIGNTIMEDRAGDROP="325" runat="server" Font-Size="8pt">Linea:</asp:label></TD>
								<TD>
									<asp:textbox id="txtlinea" Font-Names="Verdana" DESIGNTIMEDRAGDROP="327" runat="server" Width="312px"
										Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 105px" align="right">
									<asp:label id="Label6" Font-Names="Verdana" DESIGNTIMEDRAGDROP="325" runat="server" Font-Size="8pt">Direcciòn:</asp:label></TD>
								<TD>
									<asp:textbox id="txtdireccion" Font-Names="Verdana" DESIGNTIMEDRAGDROP="327" runat="server" Width="312px"
										Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 105px" align="right"></TD>
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
