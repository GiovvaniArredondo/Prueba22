<%@ control language="vb" autoeventwireup="false" inherits="wbanulapagosct, App_Web_yjxjq67i" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 537px;
    }
    .style2
    {
        width: 57px;
    }
</style>
<P align="center">
	<TABLE id="Table4" style="border: thin solid highlight; WIDTH: 476px; HEIGHT: 302px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" align="left" border="0">
		<TR>
			<TD style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); BACKGROUND-REPEAT: no-repeat; BACKGROUND-COLOR: transparent"
				align="center" class="style1">
				<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD>
							<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
								align="center">ANULACION DE PAGOS x GRUPO</P>
						</TD>
					</TR>
				</TABLE>
				<TABLE id="Table7" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD style="HEIGHT: 29px"><asp:label id="label_mensaje" Font-Names="Gill Sans MT" runat="server" Width="312px" Font-Size="10pt"></asp:label></TD>
					</TR>
				</TABLE>
				<TABLE id="Table8" style="WIDTH: 405px; HEIGHT: 117px; BACKGROUND-COLOR: #ffffff" cellSpacing="0"
					cellPadding="0" width="405" border="0">
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label1" Font-Names="Gill Sans MT" runat="server" Width="56px" Font-Size="10pt" Height="15px">Grupo/Banco:</asp:label></TD>
						<TD><asp:textbox id="txtnomcli" tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                Width="264px" Font-Size="10pt" Enabled="False"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label32" Font-Size="10pt" 
                            runat="server" Font-Names="Gill Sans MT">Fecha de Vigencia:</asp:label></TD>
						<TD>
                        <asp:DropDownList ID="cbxFechas" runat="server" 
                            Font-Names="Century Gothic" Font-Size="10pt" Height="18px" Width="106px" 
                                Enabled="False">
                        </asp:DropDownList>
                        </TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label2" Font-Names="Gill Sans MT" 
                                runat="server" Width="120px" Font-Size="10pt" Height="15px">Nº de Recibo:</asp:label></TD>
						<TD><asp:textbox id="txtcomprobante" tabIndex="5" Font-Names="Gill Sans MT" runat="server" Width="108px"
								Font-Size="10pt"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label5" Font-Names="Gill Sans MT" 
                                runat="server" Width="104px" Font-Size="10pt" Height="15px" Visible="False">Nº 
Doc:</asp:label></TD>
						<TD><asp:textbox id="txtcnrodoc" tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                Width="106px" Font-Size="10pt" Visible="False"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label3" Font-Names="Gill Sans MT" runat="server" Width="56px" Font-Size="10pt" Height="15px">Fecha:</asp:label></TD>
						<TD><asp:textbox id="txtfecha" tabIndex="5" Font-Names="Gill Sans MT" runat="server" Width="110px" Font-Size="10pt"></asp:textbox></TD>
					</TR>
				</TABLE>
				&nbsp;&nbsp;&nbsp; &nbsp; 
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<TABLE id="Table6" cellSpacing="0" cellPadding="0" border="0" 
                    style="width: 77%">
					<TR>
						<TD style="WIDTH: 63px" align="right"><INPUT id="btnAplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 58px; BACKGROUND-COLOR: transparent"
								type="button" name="Button2" runat="server"></TD>
						<TD class="style2">
				            &nbsp;</TD>
						<TD style="WIDTH: 113px">
				            <asp:Button ID="btngrabar" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                                Height="28px" Text="Revertir" Width="80px" />
                            <cc1:ConfirmButtonExtender ID="btngrabar_ConfirmButtonExtender" runat="server" 
                                ConfirmText="Esta Seguro?" Enabled="True" TargetControlID="btngrabar">
                            </cc1:ConfirmButtonExtender>
                        </TD>
						<TD><INPUT id="btncancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 69px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 64px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server"></TD>
					</TR>
				</TABLE>
			    <asp:textbox id="txtcnrocta" tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                Width="157px" Font-Size="10pt" Visible="False" Height="19px"></asp:textbox>
			</TD>
		</TR>
	</TABLE>
</P>
