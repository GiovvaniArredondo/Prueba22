<%@ Control Language="vb" AutoEventWireup="false" Inherits="WbUCReversion" CodeFile="WbUCReversion.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="592" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 592px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 248px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 19px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">REVERSION DE DESEMBOLSOS</P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 120px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="584" border="0" style="WIDTH: 584px; HEIGHT: 101px">
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 180px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
						<P align="right" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">Nro. 
							Credito:</P>
					</TD>
					<TD style="WIDTH: 136px; HEIGHT: 24px">
						<P align="left"><asp:textbox id="TxtInst" Enabled="False" Width="56px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:textbox><asp:textbox id="TxtOficina" Enabled="False" Width="64px" runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 59px; HEIGHT: 24px">
						<P align="left"><asp:textbox id="TxtCuenta" Enabled="False" Width="120px" runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt"></asp:textbox></P>
					</TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 180px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 25px">
						<P align="right" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">Nombre 
							del Cliente:</P>
					</TD>
					<TD style="WIDTH: 136px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtCodcli" Enabled="False" Width="112px" runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 59px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtNomcli" Enabled="False" Width="232px" runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt"></asp:textbox></P>
					</TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 180px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 25px">
						<P align="right" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">Fecha 
							de Desembolso:</P>
					</TD>
					<TD style="WIDTH: 136px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtDfecvig" Enabled="False" Width="86px" runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 59px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtCodigo" Enabled="False" Width="165px" runat="server" Visible="False" Font-Names="Gill Sans MT"
								Font-Size="10pt"></asp:textbox></P>
					</TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 180px; FONT-FAMILY: 'Gill Sans MT'">
						<P align="right" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">No 
							Doc.&nbsp;de Desembolso:</P>
					</TD>
					<TD style="WIDTH: 136px">
						<P align="left"><asp:textbox id="Txtcnrodoc" Enabled="False" Width="86px" runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 59px">
						<P align="right">
							<asp:TextBox id="txtcnrochq" runat="server" Visible="False" Width="85px" Font-Names="Gill Sans MT"
								Font-Size="10pt"></asp:TextBox></P>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD>
			<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnGrabar" runat="server" 
                    Font-Names="Gill Sans MT" Font-Size="12pt" Text="Revertir" />
                <cc1:ConfirmButtonExtender ID="btnGrabar_ConfirmButtonExtender" runat="server" 
                    ConfirmText="Seguro" Enabled="True" TargetControlID="btnGrabar">
                </cc1:ConfirmButtonExtender>
&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnImprime" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
					type="button" name="Button2" runat="server" visible="False">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
				&nbsp;<INPUT id="btnCancela" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 61px;BACKGROUND-REPEAT: no-repeat;HEIGHT: 56px;BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server" visible="False">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
		</TD>
	</TR>
</TABLE>
