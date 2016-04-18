<%@ Control Language="vb" AutoEventWireup="false" Inherits="wbanulapagos" CodeFile="wbanulapagos.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<P align="center">
	<TABLE id="Table4" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 542px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 312px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="542" align="left" border="0">
		<TR>
			<TD style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); BACKGROUND-REPEAT: no-repeat; BACKGROUND-COLOR: transparent"
				align="center">
				<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD>
							<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
								align="center">ANULACION DE PAGOS</P>
						</TD>
					</TR>
				</TABLE>
				<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD style="WIDTH: 63px" align="right"><asp:label id="Label4" Font-Names="Gill Sans MT" runat="server" Width="56px" Font-Size="10pt" Height="15px">Crédito:</asp:label></TD>
						<TD style="WIDTH: 105px"><asp:dropdownlist id="ddlcodins" Font-Names="Century Gothic" runat="server" Width="104px" Font-Size="10pt"></asp:dropdownlist></TD>
						<TD style="WIDTH: 113px"><asp:dropdownlist id="ddlcodofi" 
                                Font-Names="Century Gothic" runat="server" Width="125px" Font-Size="10pt" 
                                Enabled="False"></asp:dropdownlist></TD>
						<TD style="WIDTH: 166px"><asp:textbox id="txtcnrocta" tabIndex="5" Font-Names="Gill Sans MT" runat="server" Width="152px" Font-Size="10pt"></asp:textbox></TD>
						<TD><INPUT id="btnAplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 58px; BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></TD>
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
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label1" Font-Names="Gill Sans MT" runat="server" Width="56px" Font-Size="10pt" Height="15px">Nombre:</asp:label></TD>
						<TD><asp:textbox id="txtnomcli" tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                Width="264px" Font-Size="10pt" Enabled="False"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label2" Font-Names="Gill Sans MT" 
                                runat="server" Width="125px" Font-Size="10pt" Height="16px">Nº Recibo:</asp:label></TD>
						<TD><asp:textbox id="txtcomprobante" tabIndex="5" Font-Names="Gill Sans MT" runat="server" Width="108px"
								Font-Size="10pt"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label3" Font-Names="Gill Sans MT" runat="server" Width="56px" Font-Size="10pt" Height="15px">Fecha:</asp:label></TD>
						<TD><asp:textbox id="txtfecha" tabIndex="5" Font-Names="Gill Sans MT" runat="server" Width="110px" Font-Size="10pt"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 242px" align="right"><asp:label id="Label5" Font-Names="Gill Sans MT" runat="server" Width="104px" Font-Size="10pt" Height="15px">Nº Documento:</asp:label></TD>
						<TD><asp:textbox id="txtcnrodoc" tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                Width="106px" Font-Size="10pt" Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				&nbsp;&nbsp;<asp:Button ID="btngrabar" runat="server" Font-Names="Gill Sans MT" 
                    Font-Size="12pt" Text="Revertir" />
                <cc1:ConfirmButtonExtender ID="btngrabar_ConfirmButtonExtender" runat="server" 
                    ConfirmText="Seguro?" Enabled="True" TargetControlID="btngrabar">
                </cc1:ConfirmButtonExtender>
                &nbsp; &nbsp; 
				&nbsp;<INPUT id="btncancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 69px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 64px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server" visible="False">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			</TD>
		</TR>
	</TABLE>
</P>
