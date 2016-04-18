<%@ control language="vb" autoeventwireup="false" inherits="cuwCamcentro, App_Web_yjxjq67i" %>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 432px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 278px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="432" align="left" border="0">
	<TR>
		<TD style="HEIGHT: 20px">
			<P class="PageTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
				align="center">CAMBIO DE CENTRO</P>
			<P class="PageTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
				align="center">
				<TABLE id="Table4" style="WIDTH: 393px; HEIGHT: 176px" borderColor="inactivecaption" cellSpacing="0"
					cellPadding="0" width="393" border="2">
					<TR>
						<TD>
							<TABLE id="Table2" style="WIDTH: 386px; HEIGHT: 117px" borderColor="inactivecaption" cellSpacing="0"
								cellPadding="0" width="386" border="0">
								<TR>
									<TD style="WIDTH: 141px" align="right">
										<asp:Label id="Label1" Font-Size="8pt" Width="102px" Font-Names="Verdana" runat="server" ForeColor="Navy">Nombre 
                                        Cliente:</asp:Label></TD>
									<TD>
										<asp:textbox id="txtcnomcli" Font-Size="8pt" Width="264px" Font-Names="Verdana" runat="server"
											Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 141px; HEIGHT: 23px" align="right">
										<asp:Label id="Label2" Font-Size="8pt" Width="104px" Font-Names="Verdana" runat="server" ForeColor="Navy">Codigo Cliente:</asp:Label></TD>
									<TD style="HEIGHT: 23px">
										<asp:textbox id="txtccodcli" Font-Size="8pt" Width="185px" Font-Names="Verdana" runat="server"
											Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 141px" align="right">
										<asp:Label id="Label8" Font-Size="8pt" Width="104px" Font-Names="Verdana" 
                                            runat="server" ForeColor="Navy">Codigo Credito:</asp:Label></TD>
									<TD>
										<asp:textbox id="txtccodcta" Font-Size="8pt" Width="185px" Font-Names="Verdana" runat="server"
											Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 141px" align="right">
										<asp:Label id="Label4" Font-Size="8pt" Width="99px" Font-Names="Verdana" runat="server" ForeColor="Navy">Centro 
                                        Actual:</asp:Label></TD>
									<TD>
										<asp:textbox id="txtcnomcentro" Font-Size="8pt" Width="258px" 
                                            Font-Names="Verdana" runat="server"
											Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 141px" align="right">
										<asp:Label id="Label6" Font-Size="8pt" Width="99px" Font-Names="Verdana" 
                                            runat="server" ForeColor="Navy">Grupo Actual:</asp:Label></TD>
									<TD>
										<asp:textbox id="txtcnomgrupo" Font-Size="8pt" Width="258px" 
                                            Font-Names="Verdana" runat="server"
											Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 141px" align="right">
										<asp:Label id="Label5" Font-Size="8pt" Width="109px" Font-Names="Verdana" runat="server" ForeColor="Navy">Centro 
                                        a Asignar:</asp:Label></TD>
									<TD>
                        <asp:DropDownList ID="cbxcentros" runat="server" AutoPostBack="True" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="240px" 
                                BackColor="#FFFF99">
                        </asp:DropDownList>
						            </TD>
								</TR>
								<TR>
									<TD style="WIDTH: 141px" align="right">
										<asp:Label id="Label7" Font-Size="8pt" Width="109px" Font-Names="Verdana" 
                                            runat="server" ForeColor="Navy">Grupo a Asignar:</asp:Label></TD>
									<TD>
                        <asp:DropDownList ID="cbxgrupo" runat="server" AutoPostBack="True" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="240px" 
                                BackColor="#FFFF99">
                        </asp:DropDownList>
						            </TD>
								</TR>
							</TABLE>
							<TABLE id="Table3" style="WIDTH: 195px; HEIGHT: 72px" cellSpacing="0" cellPadding="0" width="195"
								border="0" align="center">
								<TR>
									<TD style="WIDTH: 68px" align="center"><INPUT id="btnGraba" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 66px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
											disabled tabIndex="9" type="button" name="Button2" runat="server"></TD>
									<TD style="WIDTH: 9px" align="center"><INPUT id="btncancela" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 65px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
											tabIndex="10" type="button" name="Button3" runat="server"></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
</TABLE>
