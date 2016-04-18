<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbUCEliminaSol.ascx.vb" Inherits="controles_Creditos_WbUCEliminaSol" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        height: 19px;
        width: 588px;
    }
    .style2
    {
        height: 120px;
        width: 588px;
    }
    .style3
    {
        width: 588px;
    }
</style>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="592" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 592px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 248px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD class="style1">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">
                                                                <asp:Label ID="lblUsuario109" 
                    Runat="server" Font-Bold="True" 
                                                                    Font-Names="Calibri" 
                    Font-Size="14pt" ForeColor="#000099" 
                                                                    style="text-align: center" 
                    Width="400px">ELIMINAR SOLICITUD DE CREDITO</asp:Label>
                                                            </P>
		</TD>
	</TR>
	<TR>
		<TD class="style2">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="584" border="0" style="WIDTH: 584px; HEIGHT: 101px">
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 180px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
						<P align="right" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">Nro. 
							Credito:</P>
					</TD>
					<TD style="WIDTH: 136px; HEIGHT: 24px">
						<P align="left"><asp:textbox id="TxtInst" Enabled="False" Width="56px" 
                                runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:textbox><asp:textbox id="TxtOficina" 
                                Enabled="False" Width="64px" runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 59px; HEIGHT: 24px">
						<P align="left"><asp:textbox id="TxtCuenta" Enabled="False" Width="120px" 
                                runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></P>
					</TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 180px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 25px">
						<P align="right" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">Nombre 
							del Cliente:</P>
					</TD>
					<TD style="WIDTH: 136px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtCodcli" Enabled="False" Width="112px" 
                                runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 59px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtNomcli" Enabled="False" Width="232px" 
                                runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></P>
					</TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 180px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 25px">
						<P align="right" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">Fecha 
							de Solicitud:</P>
					</TD>
					<TD style="WIDTH: 136px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtDfecvig" Enabled="False" Width="86px" 
                                runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 59px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtCodigo" Enabled="False" Width="165px" 
                                runat="server" Visible="False" Font-Names="Gill Sans MT"
								Font-Size="10pt" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></P>
					</TD>
				</TR>
				</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="text-align: right" class="style3">
                                                                <asp:Label ID="lblUsuario110" Runat="server" Font-Bold="True" 
                                                                    Font-Names="Calibri" 
                Font-Size="10pt" ForeColor="#FF3300" 
                                                                    
                style="text-align: right" Width="400px">Nota: Esta forma Elimina la solicitud</asp:Label>
		</TD>
	</TR>
	<TR>
		<TD class="style3">
			<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnGrabar" runat="server" 
                    Font-Names="Gill Sans MT" Font-Size="12pt" Text="Eliminar Solicitud" 
                    Enabled="False" />
                <cc1:ConfirmButtonExtender ID="btnGrabar_ConfirmButtonExtender" runat="server" 
                    ConfirmText="Realmente Desea Continuar" Enabled="True" TargetControlID="btnGrabar">
                </cc1:ConfirmButtonExtender>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
		</TD>
	</TR>
</TABLE>
