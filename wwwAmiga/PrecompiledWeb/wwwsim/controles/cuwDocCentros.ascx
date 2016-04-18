<%@ control language="vb" autoeventwireup="false" inherits="cuwDoccentros, App_Web_pi2jwlis" %>
<script language="javascript" type="text/javascript">
// <!CDATA[



// ]]>
</script>

<style type="text/css">
    .style1
    {
        width: 73px;
    }
    .style2
    {
        width: 121px;
    }
</style>
<TABLE id="Table4" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 608px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 272px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="608" border="0">
	<TR>
		<TD style="HEIGHT: 114px" align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">IMPRESION&nbsp;DOCUMENTOS POR CENTROS</P>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">
				<TABLE id="Table1" style="WIDTH: 423px; HEIGHT: 131px" cellSpacing="0" cellPadding="0"
					width="423" border="1">
					<TR>
						<TD style="WIDTH: 383px" align="center" bgcolor="White">
							<TABLE id="Table5" style="WIDTH: 368px; HEIGHT: 26px" height="26" cellSpacing="0" cellPadding="0"
								width="368" border="0">
								<TR>
									<TD style="WIDTH: 124px"><asp:label id="Label10" Width="97px" runat="server" 
                                            Font-Names="Verdana" Font-Size="8pt">Centro:</asp:label></TD>
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
							</TABLE>
							<TABLE id="Table2" style="WIDTH: 271px; HEIGHT: 108px" cellSpacing="0" cellPadding="0"
								width="271" border="0">
								<TR>
									<TD style="WIDTH: 236px" align="center"><asp:label id="Label9" Width="65px" runat="server" Font-Names="Century Gothic" Font-Size="8pt"
											Font-Bold="True" ForeColor="#0000C0">Exportar a:</asp:label></TD>
									<TD align="center" class="style2"><asp:dropdownlist id="ddlexportar" Width="169px" runat="server" Font-Names="Verdana"></asp:dropdownlist></TD>
									<TD style="WIDTH: 63px" align="center">&nbsp;</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 236px" align="center">&nbsp;</TD>
									<TD align="center" class="style2"><INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
									<TD style="WIDTH: 63px" align="center">
                                     <INPUT id="btnRecibo" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/printer.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: #ffffff"
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
