<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="wubPlanp" CodeFile="wubPlanp.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 164px;
        height: 39px;
    }
    .style2
    {
        width: 152px;
        height: 39px;
    }
    .style3
    {
        width: 77px;
        height: 39px;
    }
    .style4
    {
        height: 39px;
    }
    .style5
    {
        width: 164px;
        height: 31px;
    }
    .style6
    {
        width: 152px;
        height: 31px;
    }
    .style7
    {
        width: 77px;
        height: 31px;
    }
    .style8
    {
        height: 31px;
    }
    .style9
    {
        width: 62%;
    }
</style>
<head id="Head1" runat="server" />
<P align="center">
	<TABLE id="Table15" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 576px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 593px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="576" align="left" border="0">
		<TR>
			<TD style="HEIGHT: 14px">
				<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
					align="center">&nbsp;PLAN DE PAGOS TEÓRICO</P>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 547px">
				<TABLE id="Table16" style="WIDTH: 560px; HEIGHT: 458px" cellSpacing="0" cellPadding="0"
					width="560" align="center" border="0">
					<TR>
						<TD style="WIDTH: 467px" align="center">
<TABLE id="Table26" style="border: thin solid highlight; WIDTH: 649px; HEIGHT: 259px"
	cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0">
	<TR>
		<TD style="HEIGHT: 18px" align="center">
							<TABLE id="Table17" style="WIDTH: 574px; HEIGHT: 207px" cellSpacing="0" cellPadding="0"
								width="574" align="center" border="0">
								<TR>
									<TD style="WIDTH: 438px; HEIGHT: 64px">
										<TABLE id="Table23" style="WIDTH: 567px; HEIGHT: 50px" cellSpacing="0" cellPadding="0"
											width="567" align="center" border="0">
											<TR>
												<TD style="WIDTH: 132px; HEIGHT: 18px" align="center"><asp:label id="Label1" Width="56px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Tasa Int.</asp:label></TD>
												<TD style="WIDTH: 86px; HEIGHT: 18px" align="center"><asp:label id="Label5" Width="48px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Monto</asp:label></TD>
												<TD style="WIDTH: 112px; HEIGHT: 18px"><asp:label id="Label6" Width="112px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Fecha Desembolso</asp:label></TD>
												<TD style="WIDTH: 70px; HEIGHT: 18px" align="center"><asp:label id="Label4" Width="48px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Cuotas</asp:label></TD>
												<TD style="WIDTH: 110px; HEIGHT: 18px" align="center"><asp:label id="Label14" 
                                                        Width="48px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                        Visible="False">Gracia</asp:label></TD>
												<TD style="WIDTH: 52px; HEIGHT: 18px" align="center"><asp:label id="Label15" 
                                                        Width="30px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                        Visible="False">Plazo</asp:label></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 132px" align="center"><asp:textbox id="txtTasa" Width="61px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px"
														BorderColor="Black"></asp:textbox></TD>
												<TD style="WIDTH: 86px" align="center"><asp:textbox id="txtMonto" Width="72px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px"
														BorderColor="Black"></asp:textbox></TD>
												<TD style="WIDTH: 112px" align="center"><asp:textbox id="txtFecha" Width="80px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px"></asp:textbox>
                                            <cc1:MaskedEditExtender ID="txtfecha_MaskedEditExtender0" runat="server" 
                                                AutoComplete="False" ClearMaskOnLostFocus="False" ClearTextOnInvalid="True" 
                                                ClipboardEnabled="False" CultureAMPMPlaceholder="" 
                                                CultureCurrencySymbolPlaceholder="" CultureDateFormat="" 
                                                CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecha">
                                            </cc1:MaskedEditExtender>
                                            <cc1:CalendarExtender ID="txtfecha_CalendarExtender0" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtfecha">
                                            </cc1:CalendarExtender>
                                                </TD>
												<TD style="WIDTH: 70px" align="center"><asp:textbox id="txtCuotas" Width="60px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														BorderWidth="1px" BorderColor="Black"></asp:textbox></TD>
												<TD style="WIDTH: 110px" align="center"><asp:textbox id="txtgracia" Width="72px" 
                                                        runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														BorderWidth="1px" BorderColor="Black" Visible="False"></asp:textbox></TD>
												<TD style="WIDTH: 52px"><asp:textbox id="txtPlazo" Width="64px" runat="server" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px"
														BorderColor="Black" Visible="False"></asp:textbox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 132px"><asp:rangevalidator id="RangeValidator6" Width="86px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														ControlToValidate="txtTasa" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="100" Height="12px">Valor Inválido-</asp:rangevalidator></TD>
												<TD style="WIDTH: 86px"><asp:rangevalidator id="RangeValidator3" Width="82px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														ControlToValidate="txtMonto" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:rangevalidator></TD>
												<TD style="WIDTH: 112px"><asp:rangevalidator id="RangeValidator5" Width="88px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														ControlToValidate="txtFecha" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000"
														DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator></TD>
												<TD style="WIDTH: 70px"><asp:rangevalidator id="RangeValidator1" Width="86px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														ControlToValidate="txtCuotas" ErrorMessage="RangeValidator" Type="Integer" MinimumValue="1" MaximumValue="240" Height="8px">Valor Inválido-</asp:rangevalidator></TD>
												<TD style="WIDTH: 110px"><asp:rangevalidator id="RangeValidator4" Width="88px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														ControlToValidate="txtgracia" ErrorMessage="RangeValidator" Type="Integer" MinimumValue="0" MaximumValue="12">Valor Inválido-</asp:rangevalidator></TD>
												<TD style="WIDTH: 52px"><asp:rangevalidator id="RangeValidator2" Width="96px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														ControlToValidate="txtPlazo" ErrorMessage="RangeValidator" Type="Integer" MinimumValue="1" MaximumValue="730">Valor Inválido-</asp:rangevalidator></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 438px" align="center">
										<TABLE id="Table24" style="WIDTH: 568px; HEIGHT: 20px" cellSpacing="0" cellPadding="0"
											width="568" border="0">
											<TR>
												<TD style="WIDTH: 163px" align="right"><asp:label id="Label13" Width="96px" 
                                                        runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="0px"
														ForeColor="MidnightBlue" Visible="False">Tipo de Periodo</asp:label></TD>
												<TD style="WIDTH: 150px"><asp:radiobutton id="RadioButton6" Width="88px" 
                                                        runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														BorderWidth="0px" Text="Periodo Fijo" GroupName="TipoPeriodo" Visible="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 67px"><asp:label id="Label12" Width="80px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="0px"
														ForeColor="MidnightBlue">Tipo de Cuota</asp:label></TD>
												<TD><asp:radiobutton id="RadioButton1" Width="125px" runat="server" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt"
														BorderWidth="0px" Text="Fija Nivelada" GroupName="TipoPago" Checked="True"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 163px" align="right">&nbsp;</TD>
												<TD style="WIDTH: 150px"><asp:radiobutton id="RadioButton7" Width="88px" 
                                                        runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
														BorderWidth="0px" BorderColor="Navy" Text="Fecha Fija" GroupName="TipoPeriodo" Checked="True" Visible="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 67px">&nbsp;</TD>
												<TD>&nbsp;</TD>
											</TR>
											<TR>
												<TD style="WIDTH: 163px" align="right">
                                                    <asp:CheckBox ID="lliva" runat="server" Checked="True" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="MidnightBlue" 
                                                        Text="Aplicar IVA al Interes" />
                                                </TD>
												<TD style="WIDTH: 150px">&nbsp;</TD>
												<TD style="WIDTH: 67px">&nbsp;</TD>
												<TD><asp:radiobutton id="RadioButton5" Width="56px" runat="server" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt"
														BorderWidth="0px" Text="FLAT" GroupName="TipoPago"></asp:radiobutton></TD>
											</TR>
										</TABLE>
										<TABLE id="Table25" style="WIDTH: 568px; HEIGHT: 80px" cellSpacing="0" cellPadding="0"
											width="568" border="0">
											<TR>
												<TD align="right" class="style5">
                                        <asp:label id="Label24" runat="server" Width="96px" Font-Names="Calibri" 
                                            Font-Size="10pt">Capital:</asp:label>
                                                </TD>
												<TD class="style6">
                                        <asp:dropdownlist id="cbxCapital" runat="server" Width="150px" 
                                            Font-Names="Calibri" Font-Size="10pt" AutoPostBack="True" Height="16px"></asp:dropdownlist>
                                                </TD>
												<TD class="style7">
                            <asp:textbox id="txtnperdia" Font-Names="Gill Sans MT" Font-Size="10pt" runat="server"
								Width="89px" MaxLength="8" tabIndex="17" Height="28px" style="vertical-align:top"></asp:textbox>
                            <cc1:NumericUpDownExtender ID="txtnperdia_NumericUpDownExtender" runat="server" 
                                Enabled="True" Maximum="1000" Minimum="1" RefValues="" ServiceDownMethod="" 
                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                TargetButtonUpID="" TargetControlID="txtnperdia" Width="60">
                            </cc1:NumericUpDownExtender>
                                                </TD>
												<TD class="style8"><asp:radiobutton id="RadioButton2" Width="99px" runat="server" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt"
														BorderWidth="0px" Text="Creciente" GroupName="TipoPago" Visible="False"></asp:radiobutton><asp:radiobutton id="RadioButton3" Width="112px" runat="server" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt"
														BorderWidth="0px" Text="Libre Amort." GroupName="TipoPago" Visible="False"></asp:radiobutton><asp:radiobutton id="Radiobutton4" Width="113px" runat="server" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt"
														BorderWidth="0px" Text="Decreciente" GroupName="TipoPago"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD align="right" class="style1">
                                        <asp:label id="Label25" runat="server" Width="79px" Font-Names="Calibri" 
                                            Font-Size="10pt" Height="16px">Interes:</asp:label>
                                                </TD>
												<TD class="style2">
                                        <asp:dropdownlist id="cbxInteres" runat="server" Width="150px" 
                                            Font-Names="Calibri" Font-Size="10pt" Height="16px"></asp:dropdownlist>
                                                </TD>
												<TD class="style3"></TD>
												<TD class="style4">&nbsp;</TD>
											</TR>
											<TR>
												<TD style="WIDTH: 164px" align="right">
													<asp:label id="Label21" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="65px">F. 1ªCuota</asp:label></TD>
												<TD style="WIDTH: 152px">
													<asp:textbox id="txtfecpri" Font-Size="Smaller" Font-Names="Century Gothic" runat="server" Width="80px"
														BorderWidth="1px" Height="22px"></asp:textbox></TD>
												<TD style="WIDTH: 77px"></TD>
												<TD>&nbsp;</TD>
											</TR>
											<TR>
												<TD style="WIDTH: 164px"></TD>
												<TD style="WIDTH: 152px"></TD>
												<TD style="WIDTH: 77px"></TD>
												<TD>&nbsp;</TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
							</TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" 
                style="width: 96%">
				<TR>
					<TD align="center">
                <asp:GridView ID="datagrid1" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                            <ControlStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:CommandField>
                        <asp:BoundField DataField="dfecpro" HeaderText="Fecha" 
                            DataFormatString="{0:dd-MM-yyyy}">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ctipope" HeaderText="Tipo Op.">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnrocuo" HeaderText="Nº Cuota">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nMcuota" HeaderText="Cuota" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ncapita" HeaderText="Capital" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nintere" HeaderText="Interes">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Gastos" HeaderText="Iva" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nsegdeu" HeaderText="Seguro Deuda" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nsalcap" HeaderText="Saldo" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
                    </TD>
				</TR>
				<TR>
					<TD align="center">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <table align="left" cellpadding="0" cellspacing="0" 
    class="style3">
                                    <tr>
                                        <td align="right" class="style4">
                                            <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="NºCuota:"></asp:Label>
                                        </td>
                                        <td align="right" class="style4">
                                            <asp:TextBox ID="txtnrocuo" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" Height="24px" Width="45px" Enabled="False"></asp:TextBox>
                                        </td>
                                        <td align="right" class="style4">
                                            <asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Fecha:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtfecha0" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" Height="26px" Width="95px"></asp:TextBox>
                                        </td>
                                        <td align="right">
                                            <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Monto:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtmonto0" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" Height="27px" Width="89px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnaplicar" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Aplicar" Width="75px" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnadelante" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Adelante" Width="75px" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btneliminar" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Eliminar" Width="75px" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnnuevo" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Nuevo" Width="75px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style4">
                                            &nbsp;</td>
                                        <td align="right" class="style4">
                                            &nbsp;</td>
                                        <td align="right" class="style4">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td align="right">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RangeValidator ID="RangeValidator7" runat="server" 
                                                ControlToValidate="txtmonto" ErrorMessage="RangeValidator" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="17px" MaximumValue="1000000" 
                                                MinimumValue="50" Type="Double" Width="97px">Monto Inválido</asp:RangeValidator>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </TD>
				</TR>
				<TR>
					<TD align="center">
                        <table cellpadding="0" cellspacing="0" class="style9">
                            <tr>
                                <td>
                                    <INPUT id="btnPlan" style="FONT-SIZE: 12px; BACKGROUND-IMAGE: url('Web/jpgs/btn_plan_b.jpg'); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
								type="button" name="Button3" runat="server"></td>
                                <td align="center">
			<INPUT id="btnImprimir0" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url('Web/jpgs/fileprint.gif'); WIDTH: 65px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 62px; BACKGROUND-COLOR: transparent"
				type="button" runat="server"></td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD align="center"><asp:textbox id="txtcCodCta" runat="server" Font-Names="Verdana" Width="357px" Visible="False"></asp:textbox></TD>
				</TR>
			</TABLE>
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td align="center" class="style2">
			            &nbsp;</td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
            <table cellpadding="0" cellspacing="0" class="style6">
                <tr>
                    <td>
                        <asp:HiddenField ID="HiddenField1" runat="server" />
                    </td>
                    <td>
                        <asp:HiddenField ID="HiddenField2" runat="server" />
                    </td>
                    <td>
                        <asp:HiddenField ID="HiddenField3" runat="server" />
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
</TABLE>
                        </TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
		<TR>
			<TD></TD>
		</TR>
	</TABLE>
</P>
