<%@ control language="VB" autoeventwireup="false" inherits="controles_Creditos_WbUCArchivoDispersa, App_Web_6e0px9a3" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        height: 27px;
    }
    .style2
    {
        height: 25px;
        width: 146px;
    }
    .style3
    {
        width: 100%;
    }
</style>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0" 
    style="border: thin solid highlight; WIDTH: 490px; HEIGHT: 232px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 19px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">
                                                                <asp:Label ID="lblUsuario109" 
                    Runat="server" Font-Bold="True" 
                                                                    Font-Names="Calibri" 
                    Font-Size="14pt" ForeColor="#000099" 
                                                                    style="text-align: center" 
                    Width="400px">GENERA ARCHIVO DISPERSADOR</asp:Label>
                                                            </P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 120px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" 
                style="WIDTH: 485px; HEIGHT: 38px">
				<TR>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Gill Sans MT'; " class="style2">
						<P align="right" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">Fecha 
							a Dispersar:</P>
					</TD>
					<TD style="WIDTH: 136px; HEIGHT: 25px">
						<P align="left">
                            <asp:textbox id="TxtDfecvig" Enabled="False" Width="100px" 
                                runat="server" Font-Names="Gill Sans MT"
								Font-Size="10pt" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                            <cc1:MaskedEditExtender ID="TxtDfecvig_MaskedEditExtender" runat="server" 
                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                Mask="99/99/9999" MaskType="Date" TargetControlID="TxtDfecvig">
                            </cc1:MaskedEditExtender>
                            <cc1:CalendarExtender ID="TxtDfecvig_CalendarExtender" runat="server" 
                                Enabled="True" TargetControlID="TxtDfecvig">
                            </cc1:CalendarExtender>
                        </P>
					</TD>
				</TR>
				</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="text-align: right" class="style1">
                                                                <asp:Label ID="lblUsuario110" Runat="server" Font-Bold="True" 
                                                                    Font-Names="Calibri" 
                Font-Size="10pt" ForeColor="#FF3300" 
                                                                    
                style="text-align: right" Width="400px">Nota: Esta Archivo, se genera una vez por fecha y hora establecido</asp:Label>
		</TD>
	</TR>
	<TR>
		<TD style="text-align: center">
			<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
		    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table cellpadding="0" cellspacing="0" class="style3">
                        <tr>
                            <td>
                                <asp:Button ID="btnGrabar" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="11pt" Text="Generar Dispersión" Width="155px" />
                                <cc1:ConfirmButtonExtender ID="btnGrabar_ConfirmButtonExtender" runat="server" 
                                    ConfirmText="Realmente Desea Continuar" Enabled="True" 
                                    TargetControlID="btnGrabar">
                                </cc1:ConfirmButtonExtender>
                            </td>
                            <td>
                                <asp:Button ID="btnReport_1" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="11pt" Text="Dispersiónes Generadas" Width="155px" />
                            </td>
                            <td>
                                <asp:Button ID="btnReport_2" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="11pt" Text="Dispersiónes Pendientes" Width="155px" />
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
                  <Triggers>
                          <asp:PostBackTrigger ControlID="btnGrabar" />                          
                          <asp:PostBackTrigger ControlID="btnReport_1" />                          
                          <asp:PostBackTrigger ControlID="btnReport_2" />                          
                  </Triggers>
            </asp:UpdatePanel>
            <p>
            </P>
		</TD>
	</TR>
</TABLE>
