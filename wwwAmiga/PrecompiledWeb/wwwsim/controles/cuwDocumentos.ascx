<%@ control language="vb" autoeventwireup="false" inherits="cuwDocumentos, App_Web_pi2jwlis" %>
<style type="text/css">
    .style1
    {
        width: 95px;
    }
    .style3
    {
        width: 96px;
    }
    .style4
    {
        width: 198px;
    }
    .style5
    {
        width: 200px;
    }
</style>
<TABLE id="Table4" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 608px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 272px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="608" border="0">
	<TR>
		<TD style="HEIGHT: 114px" align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">IMPRESION&nbsp;DOCUMENTOS GRUPALES</P>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">
				<TABLE id="Table1" style="WIDTH: 481px; HEIGHT: 131px" cellSpacing="0" 
                    cellPadding="0" border="0">
					<TR>
						<TD style="WIDTH: 383px" align="center">
							<TABLE id="Table5" style="WIDTH: 368px; HEIGHT: 26px" height="26" cellSpacing="0" cellPadding="0"
								width="368" border="0">
								<TR>
									<TD style="WIDTH: 124px"><asp:label id="Label10" Width="97px" runat="server" 
                                            Font-Names="Verdana" Font-Size="8pt">Grupo:</asp:label></TD>
									<TD class="style1">
                                        <asp:TextBox ID="txtcCodsol" runat="server" Enabled="False" 
                                            Font-Names="Century Gothic" Font-Size="8pt" Height="20px" 
                                            style="margin-left: 0px" Width="92px"></asp:TextBox>
                                    </TD>
									<TD>
                                        <asp:TextBox ID="txtcnomgru" runat="server" Enabled="False" 
                                            Font-Names="Century Gothic" Font-Size="8pt" Height="21px" Width="244px"></asp:TextBox>
                                    </TD>
								</TR>
								<TR>
									<TD style="WIDTH: 124px"><asp:label id="Label7" Width="97px" runat="server" 
                                            Font-Names="Verdana" Font-Size="8pt">Fecha de Doc.:</asp:label></TD>
									<TD class="style1"><asp:textbox id="txtdfecha" Width="92px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											BorderWidth="1px" Font-Bold="True"></asp:textbox></TD>
									<TD><asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
											ControlToValidate="txtdfecha" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date">Fecha de Des.Inválida-</asp:rangevalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 124px"><asp:label id="Label11" Width="65px" runat="server" 
                                            Font-Names="Century Gothic" Font-Size="8pt"
											Font-Bold="True" ForeColor="#0000C0">Documento Legal:</asp:label></TD>
									<TD class="style1">
                                        <asp:Button ID="Button3" runat="server" Font-Bold="True" 
                                            Font-Names="Century Gothic" Font-Size="8pt" Text="Generar" />
                                    </TD>
									<TD><asp:dropdownlist id="cbxContrato" runat="server" Width="256px" 
                                            Font-Names="Verdana" Font-Size="8pt" Height="17px"></asp:dropdownlist></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 124px">&nbsp;</TD>
									<TD class="style1"><asp:label id="Label9" Width="65px" runat="server" Font-Names="Century Gothic" Font-Size="8pt"
											Font-Bold="True" ForeColor="#0000C0">Exportar a:</asp:label></TD>
									<TD><asp:dropdownlist id="ddlexportar" Width="169px" runat="server" Font-Names="Verdana"></asp:dropdownlist>
                                        <asp:TextBox ID="txtmontolet" runat="server" Height="18px" Visible="False" 
                                            Width="85px"></asp:TextBox>
                                    </TD>
								</TR>
							</TABLE>
							<TABLE id="Table2" style="WIDTH: 452px; HEIGHT: 90px" cellSpacing="0" 
                                cellPadding="0" border="0" align="center">
								<TR>
									<TD align="center" class="style5"><INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
									<TD align="center" class="style3"><INPUT id="btnCancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
									<TD align="center" class="style4">
										<INPUT id="Button1" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/printer1.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button2" runat="server"></TD>
									<TD align="center" class="style4">
										<INPUT id="Button2" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/printer.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button3" runat="server"></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
</TABLE>
