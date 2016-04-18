<%@ Control Language="vb" AutoEventWireup="false" Inherits="wbanulagrudes" CodeFile="wbanulagrudes.ascx.vb" %>
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
<head id="Head1" /> 
	<TABLE id="Table4" style="border: thin solid highlight; WIDTH: 476px; HEIGHT: 302px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" align="left" border="0">
		<TR>
			<TD style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); BACKGROUND-REPEAT: no-repeat; BACKGROUND-COLOR: transparent"
				align="center" class="style1">
				<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD>
							<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
								align="center">ANULACION DE DESEMBOLSOS x GRUPO</P>
						</TD>
					</TR>
				</TABLE>
				<TABLE id="Table7" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD style="HEIGHT: 29px">
                            <asp:label id="label_mensaje" Font-Names="Gill Sans MT" runat="server" Width="312px" Font-Size="10pt"></asp:label></TD>
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
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label3" Font-Names="Gill Sans MT" 
                                runat="server" Width="70px" Font-Size="10pt" Height="16px">Fecha Des.:</asp:label></TD>
						<TD><asp:textbox id="txtfecha" tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                Width="108px" Font-Size="10pt" Height="19px"></asp:textbox>
                            <cc1:CalendarExtender ID="txtfecha_CalendarExtender" runat="server" 
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtfecha">
                            </cc1:CalendarExtender>
                        </TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label2" Font-Names="Gill Sans MT" 
                                runat="server" Width="56px" Font-Size="10pt" Height="15px" Visible="False">Comprobante:</asp:label></TD>
						<TD><asp:textbox id="txtcomprobante" tabIndex="5" Font-Names="Gill Sans MT" 
                                runat="server" Width="108px"
								Font-Size="10pt" Visible="False"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label5" Font-Names="Gill Sans MT" 
                                runat="server" Width="104px" Font-Size="10pt" Height="15px" Visible="False">Nº Documento:</asp:label></TD>
						<TD><asp:textbox id="txtcnrodoc" tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                Width="108px" Font-Size="10pt" Visible="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				&nbsp;&nbsp;&nbsp; &nbsp; 
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:textbox id="txtcnrocta" 
                    tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                Width="85px" Font-Size="10pt" Visible="False" Height="16px"></asp:textbox>&nbsp;<TABLE id="Table6" cellSpacing="0" cellPadding="0" border="0" 
                    style="width: 77%">
					<TR>
						<TD style="WIDTH: 63px" align="right">
                            <INPUT id="btnAplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 58px; BACKGROUND-COLOR: transparent"
								type="button" name="Button2" runat="server" visible="False"></TD>
						<TD class="style2">
				            &nbsp;</TD>
						<TD style="WIDTH: 113px">
				            <asp:ImageButton ID="ImageButton1" runat="server" 
                                        ImageUrl="~/web/jpgs/btn_guardar2_b.gif" />
                                    <cc1:ConfirmButtonExtender ID="ImageButton1_ConfirmButtonExtender" 
                                        runat="server" ConfirmText="Revertir Desembolsos?" Enabled="True" 
                                        TargetControlID="ImageButton1">
                                    </cc1:ConfirmButtonExtender>
                                </TD>
						<TD><INPUT id="btncancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 69px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 64px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server" visible="False"></TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
</P>
