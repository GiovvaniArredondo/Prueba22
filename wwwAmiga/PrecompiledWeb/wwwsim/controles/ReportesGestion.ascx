<%@ control language="vb" autoeventwireup="false" inherits="ReportesGestion, App_Web_yjxjq67i" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc2" %>
<style type="text/css">
    .style1
    {
        height: 39px;
        width: 777px;
    }
    .style2
    {
        height: 44px;
        width: 777px;
    }
    .style5
    {
        width: 68%;
        height: 64px;
    }
    .style6
    {
        height: 5px;
        width: 777px;
    }
    .style7
    {
        width: 227px;
    }
    .style8
    {
        width: 114px;
    }
    .style9
    {
        width: 100%;
    }
    .style10
    {
        height: 30px;
    }
    .style11
    {
        width: 95px;
    }
    .style12
    {
        height: 32px;
    }
    .style13
    {
        height: 31px;
    }
</style>

<TABLE id="Table3" style="WIDTH: 689px; HEIGHT: 399px" cellSpacing="0" 
    cellPadding="0" align="left" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="border: thin solid #003366; WIDTH: 613px; HEIGHT: 247px; BACKGROUND-COLOR: #ffffff; "
				cellSpacing="0" cellPadding="0" align="center" border="0">
				<TR>
					<TD align="center" class="style2">
						<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
							align="center">REPORTES DE GESTION</P>
					</TD>
				</TR>
				<TR>
					<TD align="center" class="style6">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <table cellpadding="0" cellspacing="0" class="style5">
                                    <tr>
                                        <td align="right" class="style8">
                                            <asp:label id="Label4" runat="server" Font-Names="Gill Sans MT" Width="17px" Font-Size="12pt"
																	ForeColor="#0000C0" Font-Bold="False" Visible="False">Región:</asp:label>
                                        </td>
                                        <td class="style7">
                                            <asp:dropdownlist id="ddlregion" runat="server" 
                                                                    Font-Names="Calibri" 
                Width="218px" Font-Size="10pt" AutoPostBack="True" Visible="False">
                                            </asp:dropdownlist>
                                        </td>
                                        <td class="style11">
                                            <asp:checkbox id="chqregiones" runat="server" Font-Names="Century Gothic" 
                                                                    Width="94px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" 
                BorderColor="Transparent" AutoPostBack="True" Checked="True" Visible="False">
                                            </asp:checkbox>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </TD>
				</TR>
				<TR>
					<TD align="center" class="style1">
                        <table cellpadding="0" cellspacing="0" class="style9">
                            <tr>
                                <td class="style10" style="text-align: center">
                                            <asp:label id="Label5" runat="server" Font-Names="Gill Sans MT" 
                                        Width="100px" Font-Size="12pt"
																	ForeColor="#0000C0" Font-Bold="False" style="text-align: left">Sucursal:</asp:label>
                                        </td>
                                <td class="style10">
                                            <asp:dropdownlist id="ddloficinas" runat="server" 
                                                                    Font-Names="Gill Sans MT" 
                Width="218px" Font-Size="10pt">
                                            </asp:dropdownlist>
                                        </td>
                                <td class="style10">
                                            <asp:checkbox id="chqoficinas" runat="server" Font-Names="Century Gothic" 
                                                                    Width="94px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" 
                BorderColor="Transparent" Checked="True">
                                            </asp:checkbox>
                                        </td>
                            </tr>
                            <tr>
                                <td class="style12" style="text-align: center">
                                            <asp:label id="Label2" runat="server" Font-Names="Gill Sans MT" 
                                        Width="100px" Font-Size="12pt"
																	ForeColor="#0000C0" Font-Bold="False" style="text-align: left">Desde:</asp:label>
                                        </td>
                                <td class="style12">
                                            <asp:textbox id="TxtDate1" runat="server" Font-Names="Verdana" Width="116px" 
                BackColor="White" BorderColor="#2E6A99" BorderWidth="1px" Height="23px"></asp:textbox>
                                            <cc1:MaskedEditExtender ID="TxtDate1_MaskedEditExtender" runat="server" 
                                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                Mask="99/99/9999" MaskType="Date" TargetControlID="TxtDate1">
                                            </cc1:MaskedEditExtender>
                                            <cc1:CalendarExtender ID="TxtDate1_CalendarExtender" runat="server" 
                                                                    Format="dd/MM/yyyy" 
                TargetControlID="TxtDate1">
                                            </cc1:CalendarExtender>
                                        </td>
                                <td class="style12">
                                            <asp:rangevalidator id="RangeValidator1" runat="server" 
                Font-Names="Century Gothic" Width="112px" Font-Size="8pt"
																		Font-Bold="True" BackColor="AliceBlue" MinimumValue="01/01/1900" 
                MaximumValue="01/01/2999" Type="Date" ControlToValidate="TxtDate1" 
                ErrorMessage="RangeValidator">Fecha Invalida</asp:rangevalidator>
                                        </td>
                            </tr>
                            <tr>
                                <td class="style13" style="text-align: center">
                                            <asp:label id="Label3" runat="server" Font-Names="Gill Sans MT" 
                                        Width="100px" Font-Size="12pt"
																	ForeColor="#0000C0" Font-Bold="False" style="text-align: left">Hasta:</asp:label>
                                        </td>
                                <td class="style13">
                                            <asp:TextBox ID="TxtDate2" runat="server" BackColor="White" 
                                                Font-Names="Verdana" Width="116px" BorderColor="#2E6A99" BorderWidth="1px" 
                                                Height="23px"></asp:TextBox>
                                            <cc1:MaskedEditExtender ID="TxtDate2_MaskedEditExtender" runat="server" 
                                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                Mask="99/99/9999" MaskType="Date" TargetControlID="TxtDate2">
                                            </cc1:MaskedEditExtender>
                                            <cc1:CalendarExtender ID="TxtDate2_CalendarExtender" runat="server" 
                                                Format="dd/MM/yyyy" TargetControlID="TxtDate2">
                                            </cc1:CalendarExtender>
                                        </td>
                                <td class="style13">
                                            <asp:rangevalidator id="RangeValidator2" runat="server" 
                Font-Names="Century Gothic" Width="111px" Font-Size="8pt"
																	Font-Bold="True" BackColor="AliceBlue" MinimumValue="01/01/1900" 
                MaximumValue="01/01/2999" Type="Date" ControlToValidate="TxtDate2"
																	ErrorMessage="RangeValidator">Fecha Invalida</asp:rangevalidator>
                                        </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                            <asp:label id="Label6" runat="server" Font-Names="Gill Sans MT" 
                                        Width="100px" Font-Size="12pt"
																	ForeColor="#0000C0" Font-Bold="False" style="text-align: left">Gestor:</asp:label>
                                        </td>
                                <td>
                                    <cc2:CbxAnalistas ID="CbxAnalistas1" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="218px">
                                    </cc2:CbxAnalistas>
                                </td>
                                <td>
                                            <asp:checkbox id="chqgestores" runat="server" Font-Names="Century Gothic" 
                                                                    Width="94px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" 
                BorderColor="Transparent" Checked="True">
                                            </asp:checkbox>
                                        </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD align="center" class="style1">
                        <asp:DropDownList ID="cbxopciones" runat="server" Font-Names="Gill Sans MT" 
                            Height="38px" Width="332px">
                            <asp:ListItem Value="1">Reporte Convenios de Pagos No Cumplidos</asp:ListItem>
                            <asp:ListItem Value="2">Reporte Convenios de Pago Cumplidos</asp:ListItem>
                            <asp:ListItem Value="3">Reporte Convenios de Pago por Vencer</asp:ListItem>
                        </asp:DropDownList>
                    </TD>
				</TR>
				<TR>
					<TD align="center" class="style1">
                        <asp:Button ID="btnimprimir" runat="server" Height="31px" Text="Imprimir" 
                            Width="123px" />
                    </TD>
				</TR>
				<TR>
					<TD align="center" class="style1">
                        &nbsp;</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
