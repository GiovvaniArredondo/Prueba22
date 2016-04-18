<%@ control language="vb" autoeventwireup="false" inherits="usmodrep, App_Web_yjxjq67i" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

    <style type="text/css">
        .style1
        {
            width: 217px;
        }
        .style2
        {
            height: 24px;
            width: 217px;
        }
        .style7
        {
            width: 14px;
        }
        .style8
        {
            height: 24px;
            width: 14px;
        }
        .style9
        {
            width: 100%;
        }
        .style13
        {
            width: 32px;
            height: 36px;
        }
        .style14
        {
            width: 231px;
            height: 36px;
        }
        .style15
        {
            width: 36px;
            height: 36px;
        }
        .style16
        {
            height: 24px;
            width: 276px;
        }
        .style19
        {
            height: 24px;
            width: 480px;
        }
        .style20
        {
            height: 6px;
            width: 480px;
        }
        .style21
        {
            width: 14px;
            height: 208px;
        }
        .style22
        {
            width: 83px;
            height: 208px;
        }
        .style23
        {
            width: 217px;
            height: 208px;
        }
        .style24
        {
            height: 208px;
        }
        .style25
        {
            height: 128px;
            width: 14px;
        }
        .style26
        {
            width: 83px;
            height: 128px;
        }
        .style27
        {
            height: 128px;
            width: 217px;
        }
        .style28
        {
            height: 128px;
        }
        </style>
    
    <script type="text/javascript">
        function SoloNumeros(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;

            return false;
        }
    </script type="text/javascript">
	  
	    
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 992px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 497px; BACKGROUND-COLOR: transparent"
	cellSpacing="0" cellPadding="0" width="992" border="0">
	<TR>
		<TD style="HEIGHT: 81px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
				align="center">
				<TABLE id="Table2" style="WIDTH: 847px; HEIGHT: 408px" cellSpacing="0" cellPadding="0"
					width="847" border="0">
					<TR>
						<TD style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 6px"
							align="center">
                            MODULO DE REPORTES</TD>
					</TR>
					<TR>
						<TD>
							<TABLE id="Table3" style="WIDTH: 1251px; HEIGHT: 953px" cellSpacing="0" 
                                cellPadding="0" border="0">
								<TR>
									<TD style="WIDTH: 437px">
										<TABLE id="Table5" style="WIDTH: 365px; HEIGHT: 363px" cellSpacing="0" cellPadding="0"
											width="365" border="0">
											<TR>
												<TD style="WIDTH: 384px">
													<TABLE id="Table11" style="WIDTH: 317px; HEIGHT: 106px" cellSpacing="0" cellPadding="0"
														width="317" border="0">
														<TR>
															<TD style="WIDTH: 32px" align="left">&nbsp;</TD>
															<TD style="WIDTH: 231px">&nbsp;</TD>
															<TD style="WIDTH: 36px">&nbsp;</TD>
														</TR>
														<TR>
															<TD align="left" class="style13">
                                                                <asp:label id="Label21" runat="server" Font-Names="Century Gothic" Width="17px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True" Height="16px">Desde:</asp:label>
                                                                </TD>
															<TD class="style14">
                                                                <asp:textbox id="TxtDate1" runat="server" Font-Names="Verdana" 
                                                                    Width="116px" BackColor="White" BorderColor="#2E6A99" BorderWidth="1px" 
                                                                    Height="28px" Font-Size="10pt"></asp:textbox>
                                                                <cc1:MaskedEditExtender ID="TxtDate1_MaskedEditExtender" runat="server" 
                                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="TxtDate1">
                                                                </cc1:MaskedEditExtender>
                                                                <cc1:CalendarExtender ID="TxtDate1_CalendarExtender" runat="server" 
                                                                    Format="dd/MM/yyyy" TargetControlID="TxtDate1">
                                                                </cc1:CalendarExtender>
                                                                </TD>
															<TD class="style15">
                                                                <asp:rangevalidator id="RangeValidator1" runat="server" Font-Names="Century Gothic" Width="112px" Font-Size="8pt"
																		Font-Bold="True" BackColor="AliceBlue" MinimumValue="01/01/1900" MaximumValue="01/01/2999" Type="Date" ControlToValidate="TxtDate1" ErrorMessage="RangeValidator">Fecha Invalida</asp:rangevalidator>
                                                            </TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">
                                                                <asp:label id="Label20" runat="server" Font-Names="Century Gothic" Width="17px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Hasta:</asp:label>
                                                                </TD>
															<TD style="WIDTH: 231px">
                                                                <asp:textbox id="TxtDate2" runat="server" 
                                                                    Font-Names="Verdana" Width="116px" BackColor="White" BorderColor="#2E6A99" 
                                                                    BorderWidth="1px" Height="28px" Font-Size="10pt"></asp:textbox>
                                                                <cc1:MaskedEditExtender ID="TxtDate2_MaskedEditExtender" runat="server" 
                                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="TxtDate2">
                                                                </cc1:MaskedEditExtender>
                                                                </TD>
															<TD style="WIDTH: 36px">
                                                                <asp:rangevalidator id="RangeValidator2" runat="server" Font-Names="Century Gothic" Width="111px" Font-Size="8pt"
																	Font-Bold="True" BackColor="AliceBlue" MinimumValue="01/01/1900" MaximumValue="01/01/2999" Type="Date" ControlToValidate="TxtDate2"
																	ErrorMessage="RangeValidator">Fecha Invalida</asp:rangevalidator>
                                                            </TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">&nbsp;</TD>
															<TD style="WIDTH: 231px">
                                                                <asp:label id="Label19" runat="server" Font-Names="Century Gothic" 
                                                                    Width="160px" Font-Size="8pt"
																	ForeColor="#CC0000" Font-Bold="True" Height="16px">Rango días Mora:</asp:label>
                                                                </TD>
															<TD style="WIDTH: 36px">
                                                                <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" Font-Names="Calibri" 
                                                                    Font-Size="10pt" Text="Todos los Rangos" Height="16px" Width="127px" />
                                                            </TD>
														</TR>
														<TR>
															<TD align="left" class="style13">
                                                                <asp:label id="Label17" runat="server" Font-Names="Century Gothic" Width="17px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True" Height="16px">Desde:</asp:label>
                                                                </TD>
															<TD class="style14">
                                                                <asp:TextBox ID="txtrango1" runat="server" Height="28px" Width="87px" 
                                                                    onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                                <cc1:NumericUpDownExtender ID="txtrango1_NumericUpDownExtender" runat="server" 
                                                                    Enabled="True" Maximum="99999" Minimum="1" RefValues="" ServiceDownMethod="" 
                                                                    ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                                    TargetButtonUpID="" TargetControlID="txtrango1" Width="60">
                                                                </cc1:NumericUpDownExtender>
                                                            </TD>
															<TD class="style15"></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">
                                                                <asp:label id="Label18" runat="server" Font-Names="Century Gothic" Width="17px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Hasta:</asp:label>
                                                                </TD>
															<TD style="WIDTH: 231px">
                                                                <asp:TextBox ID="txtrango2" runat="server" Height="28px" Width="87px" 
                                                                    onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                                <cc1:NumericUpDownExtender ID="txtrango2_NumericUpDownExtender" runat="server" 
                                                                    Enabled="True" Maximum="99999" Minimum="1" RefValues="" ServiceDownMethod="" 
                                                                    ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                                    TargetButtonUpID="" TargetControlID="txtrango2" Width="60">
                                                                </cc1:NumericUpDownExtender>
                                                            </TD>
															<TD style="WIDTH: 36px">&nbsp;</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">&nbsp;</TD>
															<TD style="WIDTH: 231px">&nbsp;</TD>
															<TD style="WIDTH: 36px">&nbsp;</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left"><asp:label id="Label9" runat="server" Font-Names="Century Gothic" Width="65px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Exportar a:</asp:label></TD>
															<TD style="WIDTH: 231px"><asp:dropdownlist id="ddlexportar" runat="server" 
                                                                    Font-Names="CALIBRI" Width="169px" Font-Size="10pt">
                                                                </asp:dropdownlist></TD>
															<TD style="WIDTH: 36px" align="center">
                                                                <asp:Button ID="btAplicar" runat="server" Font-Names="Calibri" Height="24px" 
                                                                    Text="Aplicar" Width="94px" />
                                                            </TD>
														</TR>
														</TABLE>
													<TABLE id="Table12" style="WIDTH: 373px; HEIGHT: 26px" borderColor="highlight" cellSpacing="0"
														cellPadding="0" width="373" bgColor="#ffcc66" border="1">
														<TR>
															<TD style="WIDTH: 86px">
                                                                <asp:label id="Label12" runat="server" 
                                                                    Font-Names="Century Gothic" Width="64px" Font-Size="8pt"
																	ForeColor="Maroon" Font-Bold="True">Cajeros:</asp:label></TD>
															<TD style="WIDTH: 209px">
                                                                <asp:dropdownlist id="ddlcajeros" runat="server" 
                                                                    Font-Names="Century Gothic" Width="218px" Font-Size="8pt" 
                                                                    EnableTheming="True"></asp:dropdownlist></TD>
															<TD><asp:checkbox id="chqcajeros" runat="server" Font-Names="Century Gothic" 
                                                                    Width="44px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox></TD>
														</TR>
													</TABLE>
													<TABLE id="Table13" style="WIDTH: 370px; HEIGHT: 196px" borderColor="#ffcc66" cellSpacing="0"
														cellPadding="0" width="370" bgColor="#ffff99" border="2">
														<TR>
															<TD style="WIDTH: 71px"><asp:label id="Label15" runat="server" 
                                                                    Font-Names="Century Gothic" Width="51px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True" Height="16px">Producto</asp:label></TD>
															<TD style="WIDTH: 221px">
                                                                <asp:dropdownlist id="ddlproducto" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt"></asp:dropdownlist></TD>
															<TD><asp:checkbox id="chqproducto" runat="server" Font-Names="Century Gothic" 
                                                                    Width="42px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent" Height="38px"></asp:checkbox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 71px">&nbsp;</TD>
															<TD style="WIDTH: 221px">
                                                                <asp:Label ID="Label16" runat="server" Font-Size="7pt" ForeColor="Red" 
                                                                    Text="Por el momento este filtro esta habilitado para los Reportes 3 y 17"></asp:Label>
                                                            </TD>
															<TD>&nbsp;</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 71px"><asp:label id="Label1" runat="server" Font-Names="Century Gothic" Width="27px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Oficina</asp:label></TD>
															<TD style="WIDTH: 221px">
                                                                <asp:dropdownlist id="ddloficinas" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt"></asp:dropdownlist></TD>
															<TD><asp:checkbox id="chqoficinas" runat="server" Font-Names="Century Gothic" 
                                                                    Width="44px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 71px"><asp:label id="Label6" runat="server" Font-Names="Century Gothic" Width="54px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Fuente de Fondos</asp:label></TD>
															<TD style="WIDTH: 221px">
                                                                <asp:dropdownlist id="ddllineas" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt"></asp:dropdownlist></TD>
															<TD><asp:checkbox id="chqlineas" runat="server" Font-Names="Century Gothic" 
                                                                    Width="44px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 71px"><asp:label id="Label4" runat="server" 
                                                                    Font-Names="Century Gothic" Width="68px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Asesor de Negocio:</asp:label></TD>
															<TD style="WIDTH: 221px">
                                                                <asp:dropdownlist id="ddlanalistas" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt"></asp:dropdownlist></TD>
															<TD><asp:checkbox id="chqanalistas" runat="server" Font-Names="Century Gothic" 
                                                                    Width="44px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 71px"><asp:label id="Label7" runat="server" Font-Names="Century Gothic" Width="82px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Condición de la Cartera</asp:label></TD>
															<TD style="WIDTH: 221px">
                                                                <asp:dropdownlist id="ddlcartera" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt"></asp:dropdownlist></TD>
															<TD><asp:checkbox id="chqcartera" runat="server" Font-Names="Century Gothic" 
                                                                    Width="44px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 71px"><asp:label id="Label8" runat="server" Font-Names="Century Gothic" Width="46px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Tipo de Cartera</asp:label></TD>
															<TD style="WIDTH: 221px">
                                                                <asp:dropdownlist id="ddltipo" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt"></asp:dropdownlist></TD>
															<TD><asp:checkbox id="chqtipo" runat="server" Font-Names="Century Gothic" 
                                                                    Width="44px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 71px"><asp:label id="Label11" runat="server" Font-Names="Century Gothic" Width="51px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Municipio</asp:label></TD>
															<TD style="WIDTH: 221px">
                                                                <asp:dropdownlist id="ddlmuni" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt"></asp:dropdownlist></TD>
															<TD><asp:checkbox id="chqmuni" runat="server" Font-Names="Century Gothic" 
                                                                    Width="44px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 71px"><asp:label id="Label5" runat="server" Font-Names="Century Gothic" Width="64px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Estratificación</asp:label></TD>
															<TD style="WIDTH: 221px">
                                                                <asp:dropdownlist id="ddlestrato" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt"></asp:dropdownlist></TD>
															<TD><asp:checkbox id="chqestrato" runat="server" Font-Names="Century Gothic" 
                                                                    Width="44px" Font-Size="8pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
											<TR>
												<TD style="WIDTH: 384px" align="center"><asp:label id="label_mensaje" runat="server" Font-Names="Century Gothic" Width="375px" Font-Size="8pt"
														BackColor="Transparent" Height="25px"></asp:label></TD>
											</TR>
										</TABLE>
									</TD>
									<TD>
										<TABLE id="Table7" style="border-style: solid; border-color: inherit; border-width: thin; WIDTH: 799px; HEIGHT: 413px"
											borderColor="#003399" cellSpacing="0" cellPadding="0" background="Web/jpgs/fondoespecial2.jpg"
											border="2">
											<TR>
												<TD class="style7">
                                                    <table cellpadding="0" cellspacing="0" class="style9">
                                                        <tr>
                                                            <td>
                                                    <asp:radiobutton id="rbtIngresos" runat="server" 
                                                        Font-Names="Century Gothic" Width="146px" Font-Size="8pt"
														ForeColor="#16387C" Font-Bold="True" BorderWidth="1px" Text="1.1-Ingresos Diarios" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                    <asp:radiobutton id="rbtIngresos5" runat="server" 
                                                        Font-Names="Century Gothic" Width="188px" Font-Size="8pt"
														ForeColor="#16387C" Font-Bold="True" BorderWidth="1px" Text="1.2-Ingresos Diarios en Banco" BorderColor="White"
														GroupName="rcartera" Enabled="False" Height="16px"></asp:radiobutton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                    <asp:radiobutton id="rbtIngresos6" runat="server" 
                                                        Font-Names="Century Gothic" Width="203px" Font-Size="8pt"
														ForeColor="#16387C" Font-Bold="True" BorderWidth="1px" Text="1.3-Ingresos Diarios de Agencia" BorderColor="White"
														GroupName="rcartera" Enabled="False" Height="16px"></asp:radiobutton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </TD>
												<TD style="WIDTH: 83px">
                                                    <asp:radiobutton id="rbtIngresos1" runat="server" 
                                                        Font-Names="Century Gothic" Width="196px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="14-Ingresos de Excedentes"
														BorderColor="White" GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style1">
                                                    <asp:radiobutton id="rbtIngresos3" runat="server" 
                                                        Font-Names="Century Gothic" Width="146px" Font-Size="8pt"
														ForeColor="#16387C" Font-Bold="True" BorderWidth="1px" Text="27-Resumen Ingresos" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left">
                                                    <asp:radiobutton id="rbtIngresos4" runat="server" 
                                                        Font-Names="Century Gothic" Width="211px" Font-Size="8pt"
														ForeColor="#16387C" Font-Bold="True" BorderWidth="1px" Text="41-Ingresos (Otras formas de pago)" BorderColor="White"
														GroupName="rcartera" Enabled="False" style="margin-left: 0px"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style7">
                                                    <asp:radiobutton id="rbtDesem" runat="server" 
                                                        Font-Names="Century Gothic" Width="134px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="2-Desembolsos" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px" align="left">
                                                    <asp:radiobutton id="rbcondesem" runat="server" 
                                                        Font-Names="Century Gothic" Width="237px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="15-Consolidado de Desembolso" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style1">
                                                    <asp:radiobutton id="rbtnsector" 
                                                        runat="server" Font-Names="Century Gothic" Width="190px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="28-Resumen Sector Econ." BorderColor="White" Height="24px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left">
                                                    <asp:radiobutton id="rbtnextorno" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="42-Extorno de Pagos" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style7">
                                                    <asp:radiobutton id="rbtCarteraVIg" runat="server" 
                                                        Font-Names="Century Gothic" Width="170px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="3.1-Cartera Vigente" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px" align="left">
                                                    <asp:radiobutton id="rbdreserva" 
                                                        runat="server" Font-Names="Century Gothic" Width="119px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="16-Reserva" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton>
                                                    <asp:CheckBox ID="CheckBox4" runat="server" Font-Names="Calibri" 
                                                        Font-Size="8pt" Text="Por Oficina" />
                                                </TD>
												<TD align="left" class="style1">
                                                    <asp:radiobutton id="rbtndestino" 
                                                        runat="server" Font-Names="Century Gothic" Width="208px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="29-Resumen por Destino" BorderColor="White" Height="30px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left">
                                                    <asp:radiobutton id="rbtnmuni" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="43-Rangos por Municipio" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style7">
                                                   <!-- <asp:radiobutton id="rbtmora" runat="server" 
                                                        Font-Names="Century Gothic" Width="121px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="4-Cartera en Mora" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton>-->
                                                    <asp:radiobutton id="rbtCart_mora" runat="server" 
                                                        Font-Names="Century Gothic" Width="170px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="4.1-Cartera en Mora" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton>
														
														<asp:radiobutton id="RbtCart_moraGpo" runat="server" 
                                                        Font-Names="Century Gothic" Width="170px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="4.2-Cartera en Mora Gpo" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton>
                                                </TD>
												<TD style="WIDTH: 83px">
                                                    <asp:radiobutton id="rbdestrato" runat="server" 
                                                        Font-Names="Century Gothic" Width="195px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="17-Estrat. de la Cartera." BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton>
                                                    <asp:CheckBox ID="CheckBox2" runat="server" Font-Names="Calibri" 
                                                        Font-Size="8pt" Text="Por Analista" />
                                                    <asp:CheckBox ID="CheckBox3" runat="server" Font-Names="Calibri" 
                                                        Font-Size="8pt" Text="Por Oficina" />
                                                </TD>
												<TD align="left" class="style1">
                                                    <asp:radiobutton id="rbtnactivi" 
                                                        runat="server" Font-Names="Century Gothic" Width="215px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="30-Actividades Económicas" BorderColor="White" Height="30px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left">
                                                    <asp:radiobutton id="rbtnplazos" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="44-Rangos por Plazos" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style7">
                                                    <asp:radiobutton id="rbtproyeccion" runat="server" 
                                                        Font-Names="Century Gothic" Width="156px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="5-Proyeccion de Mora" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px">
                                                    <asp:radiobutton id="rbdgenero" runat="server" 
                                                        Font-Names="Century Gothic" Width="214px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="18-Reporte por género" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style1">
                                                    <asp:radiobutton id="rbtntasa" runat="server" 
                                                        Font-Names="Century Gothic" Width="166px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="31-Cartera x Tasa de Int." BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left">
                                                    <asp:radiobutton id="rbtncali" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="45-Resumen por Calificación"
														BorderColor="White" GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style7">
                                                    <asp:radiobutton id="rbdvenci" runat="server" 
                                                        Font-Names="Century Gothic" Width="197px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="6-Vencimiento de créditos" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px" align="left">
                                                    <asp:radiobutton id="rbdnopagos" 
                                                        runat="server" Font-Names="Century Gothic" Width="226px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="19-Pagos automaticos no aplicados" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style1">
                                                    <asp:radiobutton id="rbtnparalelo" 
                                                        runat="server" Font-Names="Century Gothic" Width="214px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="32-Créditos Paralelos" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left">
                                                    <asp:radiobutton id="rbtestadistico" runat="server" 
                                                        Font-Names="Century Gothic" Width="187px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="50-Cons. por oficina" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style7">
                                                    <asp:radiobutton id="rbtIngresos2" runat="server" 
                                                        Font-Names="Century Gothic" Width="198px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="7-Ingresos por Cancelaciones" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px" align="left">
                                                    <asp:radiobutton id="rbdsaldosfue" 
                                                        runat="server" Font-Names="Century Gothic" Width="202px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="20-Saldos por fuente de fondo" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style1">
                                                    <asp:radiobutton id="rbdcancelados" 
                                                        runat="server" Font-Names="Century Gothic" Width="227px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="33-Créditos cancelados" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left">
                                                    <asp:radiobutton id="rbtnprorec" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="51-Proyección Recuperación"
														BorderColor="White" Height="23px" GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style7">
                                                    <asp:radiobutton id="rbtnmora2" runat="server" 
                                                        Font-Names="Century Gothic" Width="150px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="8-Mora Estratificada" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px" align="left">
                                                    <asp:radiobutton id="rbtnrecumen" 
                                                        runat="server" Font-Names="Century Gothic" Width="199px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="21-Resumen de Recup. Mensual" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style1">
                                                    <asp:radiobutton id="rbtnrecuanu" 
                                                        runat="server" Font-Names="Century Gothic" Width="229px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="34-Resumen de Recuperación Anual" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left">
                                                    <asp:radiobutton id="rbtndesercion" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="52-Clientes Desertados" BorderColor="White"
														Height="23px" GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style7">
                                                    <asp:radiobutton id="rbdingfon" runat="server" 
                                                        Font-Names="Century Gothic" Width="185px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="9-Ingreso cons. por Fondo" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px" align="left">
                                                    <asp:radiobutton id="rbtncolomen" 
                                                        runat="server" Font-Names="Century Gothic" Width="228px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="22-Resumen de Desemb. Mensual" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style1">
                                                    <asp:radiobutton id="rbtncoloanu" 
                                                        runat="server" Font-Names="Century Gothic" Width="217px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="35-Resumen de Desemb. Anual" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left">
                                                    <asp:radiobutton id="rbtnedad" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="53-Resumen por Edad" BorderColor="White"
														Height="24px" GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style21"><asp:label id="Label13" runat="server" 
                                                        Font-Names="Verdana" Width="111px" Font-Size="8pt"
														ForeColor="DarkRed" Font-Bold="True">Informe Mensual</asp:label>
                                                    <asp:radiobutton id="rbtninforme1" runat="server" Font-Names="Century Gothic" 
                                                        Width="108px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="10-Colocación" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style22"><asp:label id="Label14" runat="server" Font-Names="Century Gothic" Width="94px" Font-Size="8pt"
														ForeColor="DarkRed" Font-Bold="True">Informe Mensual</asp:label>
                                                    <asp:radiobutton id="rbtnafecta" runat="server" Font-Names="Century Gothic" 
                                                        Width="150px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="23-Afectación Cartera" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style23">
                                                    <table cellpadding="0" cellspacing="0" class="style9">
                                                        <tr>
                                                            <td>
                                                                <asp:label id="Label10" runat="server" Font-Names="Century Gothic" Width="127px" Font-Size="8pt"
														ForeColor="DarkRed" Font-Bold="True">Agenda de Comite</asp:label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                    <asp:radiobutton id="rbtnagenda" runat="server" Font-Names="Century Gothic" 
                                                        Width="93px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="36-Nivel 1" BorderColor="White" GroupName="rcartera" 
                                                        Enabled="False"></asp:radiobutton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                    <asp:radiobutton id="rbtnagenda2" 
                                                        runat="server" Font-Names="Century Gothic" Width="113px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="37-Nivel 2" BorderColor="White" GroupName="rcartera" 
                                                        Enabled="False"></asp:radiobutton>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                    <asp:radiobutton id="rbtnagenda3" 
                                                        runat="server" Font-Names="Century Gothic" Width="113px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="77-Nivel 3" BorderColor="White" GroupName="rcartera" 
                                                        Enabled="False"></asp:radiobutton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </TD>
												<TD align="left" class="style24">
                                                    <asp:radiobutton id="rbtnsecuencia" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="54-Resumen por Secuencia" BorderColor="White"
														Height="24px" GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style25">
                                                    <asp:radiobutton id="rbtn50" runat="server" 
                                                        Font-Names="Century Gothic" Width="261px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="11-Cartera Vigente(Cancelados 50%)" BorderColor="White"
														Height="40px" GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style26">
                                                    <asp:radiobutton id="rbtntipo" 
                                                        runat="server" Font-Names="Century Gothic" Width="214px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="24-Resumen por Tipo de Crédito" BorderColor="White" Height="24px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style27">
                                                    <asp:radiobutton id="rbtproyeccion1" runat="server" Font-Names="Century Gothic" 
                                                        Width="224px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="38-Proyeccion de Mora(Observ.)" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style28">
												
                                                    <asp:radiobutton id="rbtnprorec1" 
                                                        runat="server" Font-Names="Century Gothic" Width="137px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="55-Proyección Recuperación Detallado" BorderColor="White"
														Height="23px" GroupName="rcartera" Enabled="False"></asp:radiobutton>
														
													<br />
                                                    <br />
														
													<asp:radiobutton id="rbtnprorec551" 
                                                        runat="server" Font-Names="Century Gothic" Width="137px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="55.1" BorderColor="White"
														Height="23px" GroupName="rcartera" Enabled="true"></asp:radiobutton>
													<br /> <br />
													
													
											</TR>
											<TR>
												<TD class="style8">
                                                    <asp:radiobutton id="rbtCartera1" 
                                                        runat="server" Font-Names="Century Gothic" Width="300px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="12-Cartera por Sector Economico" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px; HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtCartera2" runat="server" Font-Names="Century Gothic" 
                                                        Width="206px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="25-Cartera por Destino" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style2">
                                                    <asp:radiobutton id="rbtCartera3" runat="server" Font-Names="Century Gothic" 
                                                        Width="209px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="39-Cartera por Rango de Montos" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtCartera4" 
                                                        runat="server" Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="56-Cartera por Garantía" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style8">
                                                    <asp:radiobutton id="rbtninfored" 
                                                        runat="server" Font-Names="Century Gothic" Width="155px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="___" BorderColor="White" 
                                                        GroupName="rcartera" Enabled="False" Visible="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px; HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtnmora3" runat="server" 
                                                        Font-Names="Century Gothic" Width="174px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="26-Antiguedad Detallada" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style2">
                                                    <asp:radiobutton id="rbtngarantia" runat="server" Font-Names="Century Gothic" 
                                                        Width="195px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="40-Resumen por Garantía" BorderColor="White" Height="24px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtnmonto" 
                                                        runat="server" Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="57-Rangos por Montos" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style8">
                                                    <asp:radiobutton id="rbtnEjecutivo" 
                                                        runat="server" Font-Names="Century Gothic" Width="238px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="58-Resumen Ejecutivo" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px; HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtAjuste" runat="server" 
                                                        Font-Names="Century Gothic" Width="146px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="59-Ajustes Aplicados" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style2">
                                                    <asp:radiobutton id="rbttransunion" runat="server" 
                                                        Font-Names="Century Gothic" Width="146px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="60 - Archivo G&amp;T" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtAjuplan" runat="server" 
                                                        Font-Names="Century Gothic" Width="146px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="61-Cartera con Ajuste en Plan de Pagos" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style8">
                                                    <asp:radiobutton id="rbtnIntereses" runat="server" 
                                                        Font-Names="Century Gothic" Width="250px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="62-Saldos Cartera e Intereses por Cobrar" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px; HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtncuoven" runat="server" 
                                                        Font-Names="Century Gothic" Width="208px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="63-Cuotas a Vencer por Rango" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style2">
                                                    <asp:radiobutton id="rdbcarana" runat="server" 
                                                        Font-Names="Century Gothic" Width="196px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="64-Cons. x Analista" BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtnfdlg" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="65-Resumen por Tipo Cartera" BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style8">
                                                    <asp:radiobutton id="rbtcreditosplazo" runat="server" 
                                                        Font-Names="Century Gothic" Width="150px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="66-Creditos por Plazo" BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px; HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtResumenxProducto" runat="server" 
                                                        Font-Names="Century Gothic" Width="195px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="67-Cartera Resumen x Producto" BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style2">
                                                    <asp:radiobutton id="rbtPeriodicidad" runat="server" 
                                                        Font-Names="Century Gothic" Width="236px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="68-Periodicidad de Cobro" BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtResumenDesembolso" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="69-Resumen de Desembolso" BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style8">
                                                    <asp:radiobutton id="rbtClasificacionCarteraXAgencia" runat="server" 
                                                        Font-Names="Century Gothic" Width="263px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="70-Clasificacion de Cartera x Agencia" 
                                                        BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px; HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtResumenDeIngresos" runat="server" 
                                                        Font-Names="Century Gothic" Width="198px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="71-Ingresos Consolidados" BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style2">
                                                    <asp:radiobutton id="rbtCarteraSuspendida" runat="server" 
                                                        Font-Names="Century Gothic" Width="239px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="72-Cartera con Intereses Suspendidos" 
                                                        BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtIngresosCondonados" runat="server" 
                                                        Font-Names="Century Gothic" Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="73-Ingresos Condonados" 
                                                        BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style8">
                                                    <asp:radiobutton id="rbtResumenCartera3" runat="server" 
                                                        Font-Names="Century Gothic" Width="256px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="74-Resumen de Cartera Vigente" 
                                                        BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="WIDTH: 83px; HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtOtrosIngresos" runat="server" 
                                                        Font-Names="Century Gothic" Width="150px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="75-Otros Ingresos" 
                                                        BorderColor="White" Height="14px"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD align="left" class="style2">
                                                    <asp:radiobutton id="rbtnextorno0" runat="server" 
                                                        Font-Names="Century Gothic" Width="212px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="76-Extorno de Desembolsos" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD>
												<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtnsolicitud" runat="server" Font-Names="Century Gothic" 
                                                        Width="200px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="78-Solicitudes Pendiente" BorderColor="White" GroupName="rcartera" 
                                                        Enabled="False"></asp:radiobutton>
                                                    </TD>
											</TR>
											<TR>
												<TD class="style8">
                                                    <asp:radiobutton id="rbtnaldea" runat="server" Font-Names="Century Gothic" 
                                                        Width="291px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="79-Resumen por Aldeas" BorderColor="White" GroupName="rcartera" 
                                                        Enabled="False"></asp:radiobutton>
                                                    </TD>
												<TD style="WIDTH: 83px; HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbtnInter" runat="server" Font-Names="Century Gothic" 
                                                        Width="212px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="80-Solicitud de Amortización Inter." 
                                                        BorderColor="White" GroupName="rcartera" 
                                                        Enabled="False"></asp:radiobutton>
                                                    </TD>
												<TD align="left" class="style2">
                                                    <asp:radiobutton id="rbtCartera5" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="81-Creditos Trasladados a Castigo" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
												<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="rbComisionesMensuales" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="82- Comisiones Mensuales" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
											</TR>
											<tr><TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="RdbComportamiento" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="83- Comportamiento Productos" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
														
														<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="RdbDesembolso" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="84- Desembolsos" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
														
														
														<TD align="left" class="style2">
                                                    <asp:radiobutton id="RdbDetGruPro" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="88- Seguimiento a Productos" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
												
														<TD align="left" class="style2">
                                                    <asp:radiobutton id="RdbCuentaMaestra" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="89- Reporte de cuenta Maestra" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
														</tr>
														
												<tr><TD style="HEIGHT: 24px" align="left">
												<asp:radiobutton id="RdbGestores" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="90- Reporte de Gestores" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton>
												
                                                    <asp:radiobutton id="RdbAnexoC" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="Anexo C" BorderColor="White"
														GroupName="rcartera" Enabled="False" Visible="False"></asp:radiobutton></TD>
														
														<TD style="HEIGHT: 24px" align="left">
												<asp:radiobutton id="RdbAsigAnalistas" runat="server" 
                                                        Font-Names="Century Gothic" Width="243px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="91- Reporte de Asignacion de Analistas" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton>
														
														
														<TD style="HEIGHT: 24px" align="left">
												<asp:radiobutton id="RdbConsultaAnalistasGestores" runat="server" 
                                                        Font-Names="Century Gothic" Width="243px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="92- Consulta de Analistas" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton>
														
														<TD style="HEIGHT: 24px" align="left">
												<asp:radiobutton id="RdbPrendarias" runat="server" 
                                                        Font-Names="Century Gothic" Width="243px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="93- Garantias Prendarias" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton>
														
														
														</tr>
														<tr><TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="RdbDetalleGarantias" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="94- Detalle de Garantias" BorderColor="White"
														GroupName="rcartera" Enabled="False"></asp:radiobutton></TD> </tr>
														
														
												
													<TABLE id="Table34" style="border-style: solid; border-color: inherit; border-width: thin; WIDTH: 920px; HEIGHT: 65px"
											borderColor="#003399" cellSpacing="0" cellPadding="0" background="Web/jpgs/fondoespecial2.jpg"
											border="2">
											
											<br /><br /><TD style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; "
							align="center" class="style20">
                            PLD</TD>
														
														<tr>
														<TD align="left" class="style19">
                                                    <asp:radiobutton id="RdbDesembolso_inusuales" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="85- Desembolsos Relevantes" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
														
														<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="RdbPagos_Cuotas_Inusuales" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="86- Pagos de Cuotas Relevantes" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
														
														<TD align="left" class="style16">
                                                    <asp:radiobutton id="RdbOperaciones_Insuales" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="87- Operaciones Inusuales" BorderColor="White"
														GroupName="rcartera" style="margin-left: 0px"></asp:radiobutton></TD>
														
														</tr>
														</TABLE>
														<TABLE id="Table35" style="border-style: solid; border-color: inherit; border-width: thin; WIDTH: 920px; HEIGHT: 65px"
											borderColor="#003399" cellSpacing="0" cellPadding="0" background="Web/jpgs/fondoespecial2.jpg"
											border="2">
											<caption>Comisiones Area Comercial</caption>
											
														<tr>
														<TD align="left" class="style19">
                                                    <asp:radiobutton id="Rb_ComisionesIndividual" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text=" Comisiones Por Asesor" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
														
														<TD style="HEIGHT: 24px" align="left">
                                                    <asp:radiobutton id="Rb_ColocacionGlobal" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="14- Colocacion Global" BorderColor="White"
														GroupName="rcartera"></asp:radiobutton></TD>
														
														<TD align="left" class="style16">
                                                    <asp:radiobutton id="Rb_RecuperacionGlobal" runat="server" 
                                                        Font-Names="Century Gothic" Width="221px" Font-Size="8pt"
														ForeColor="#000040" Font-Bold="True" BorderWidth="1px" Text="15- Recuperacion Global" BorderColor="White"
														GroupName="rcartera" style="margin-left: 0px"></asp:radiobutton></TD>
														
														</tr>
														</TABLE>
														
										</TABLE>
									</TD>
								</TR>
								
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
</TABLE>
