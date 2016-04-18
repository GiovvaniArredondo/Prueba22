<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="ucDescarga, App_Web_v6ddqlgy" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 80px;
        }
        #Table1
        {
            width: 57%;
        }
        .style2
        {
            height: 33px;
        }
        .style3
        {
            height: 18px;
        }
        .style4
        {
            height: 19px;
        }
    </style>

<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table8" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 433px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 184px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="433" border="0">
				<TR>
					<TD style="HEIGHT: 33px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:label id="Label3" runat="server" Width="251px" Font-Bold="True" Font-Size="Medium" Height="15px"
							Font-Names="Gill Sans MT" ForeColor="#16387C">PAGOS AUTOMATICOS</asp:label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 19px" align="center">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td align="right">
                                    <asp:label id="Label41" runat="server" Width="166px" Font-Size="10pt" 
                                        Height="15px" Font-Names="Gill Sans MT">Tipo de Archivo:</asp:label>
                                </td>
                                <td>
						<asp:dropdownlist id="cmbtipArch" runat="server" Width="201px" Height="24px" 
                            Font-Names="Gill Sans MT" Font-Size="10pt">
                            <asp:ListItem Value="1">Banamex</asp:ListItem>
                            <asp:ListItem Value="2">Paynet</asp:ListItem>                            
                        </asp:dropdownlist>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label40" runat="server" Width="166px" Font-Size="10pt" 
                                        Height="15px" Font-Names="Gill Sans MT">Banco:</asp:label>
                                </td>
                                <td>
						<asp:dropdownlist id="cmbbanco" runat="server" Width="201px" Height="24px" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"></asp:dropdownlist>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style2">
                                    <asp:label id="Label38" runat="server" Width="166px" Font-Size="10pt" 
                                        Height="15px" Font-Names="Gill Sans MT">Nombre de Archivo:</asp:label>
                                </td>
                                <td class="style2">
                                    <asp:FileUpload ID="FileUpload1" runat="server" BorderColor="#2E6A99" 
                                        BorderWidth="1px" Font-Names="Gill Sans MT" Font-Size="12pt" Height="33px" 
                                        style="text-align: center" Width="408px" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
						<asp:label id="Label39" runat="server" Width="195px" Font-Size="10pt" Height="15px" 
                                        Font-Names="Gill Sans MT">Fecha de Proceso contable:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtfecbar" tabIndex="5" runat="server" Width="102px" 
                                        Font-Size="12pt" Font-Names="Gill Sans MT"
							BorderWidth="1px" AutoPostBack="True" Height="29px" BorderColor="#2E6A99" Enabled="False"></asp:textbox>
                                    <cc1:MaskedEditExtender ID="txtfecbar_MaskedEditExtender" runat="server" 
                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                        Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecbar">
                                    </cc1:MaskedEditExtender>
                                    <cc1:CalendarExtender ID="txtfecbar_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtfecbar">
                                    </cc1:CalendarExtender>
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD align="center" class="style4"></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 19px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:rangevalidator id="RangeValidator5" runat="server" Width="88px" Font-Size="8pt" Font-Names="Gill Sans MT"
							DESIGNTIMEDRAGDROP="1491" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecbar">Fecha Inválida-</asp:rangevalidator>
                                    <asp:textbox id="txtnombar" tabIndex="5" runat="server" Width="209px" 
                                        Font-Size="12pt" Font-Names="Gill Sans MT"
							BorderWidth="1px" Height="28px" BorderColor="#2E6A99" Visible="False"></asp:textbox>
                                </TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 22px" align="center"><asp:label id="label_mensaje" runat="server" Width="184px" Font-Size="8pt" Height="15px" Font-Names="Gill Sans MT"
							ForeColor="Red"></asp:label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 22px" align="center">
                        <asp:Label ID="LabelError" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                            ForeColor="Red" Height="15px" Width="250px"></asp:Label>
                    </TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 41px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
						&nbsp;<asp:Button ID="btnprocesar" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="11pt" Height="32px" Text="Procesar" Width="106px" />
                        <cc1:ConfirmButtonExtender ID="btnprocesar_ConfirmButtonExtender" 
                            runat="server" ConfirmText="Seguro de Procesar?" Enabled="True" 
                            TargetControlID="btnprocesar">
                        </cc1:ConfirmButtonExtender>
                        &nbsp; 
                        <INPUT id="btnimprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(imagenes/Wzprint.bmp); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server" visible="False"></TD>
				</TR>
				<TR>
					<TD align="center" class="style3">
                        <asp:label id="Label2" runat="server" Width="369px" 
                            Font-Size="10pt" Height="15px" Font-Names="Gill Sans MT" Visible="False">La ruta del servidor es c:/txt/nombrearch.txt</asp:label></TD>
				</TR>
			</TABLE>
			&nbsp;&nbsp;&nbsp;
		</TD>
	</TR>
	</TABLE>
<SCRIPT language="JavaScript">
 function aplicar()
 {
 if(confirm("¿Esta seguro de continuar?"))
   alert("ok");
  else
   alert("proceso no completado");
 }
</SCRIPT>
