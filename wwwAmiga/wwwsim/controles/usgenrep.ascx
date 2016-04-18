<%@ Control Language="vb" AutoEventWireup="false" Codefile="usgenrep.ascx.vb" Inherits="usgenrep"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />

    <style type="text/css">
        .style1
        {
            width: 95%;
            height: 263px;
        }
        .style2
        {
            width: 108%;
            border: 2px solid #003366;
            background-color: #C0D9F1;
        }
        .style3
        {
            width: 384px;
            height: 38px;
        }
        .style4
        {
            width: 216px;
        }
        .style5
        {
            width: 384px;
            height: 242px;
        }
        .style7
        {
            width: 384px;
            height: 19px;
        }
        .style8
        {
            width: 107%;
        }
        .style9
        {
            width: 250px;
        }
        .style10
        {
            width: 165px;
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
	  
	  
    <TABLE id="Table1" style="border: thin solid highlight; WIDTH: 902px; HEIGHT: 497px; BACKGROUND-COLOR: transparent"
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD style="HEIGHT: 81px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
				align="center">
				<TABLE id="Table2" style="WIDTH: 899px; HEIGHT: 408px" cellSpacing="0" 
                    cellPadding="0" border="0">
					<TR>
						<TD style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; COLOR: #EBEBEB; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 6px"
							align="center" bgcolor="Maroon">
                            GENERADOR DE REPORTE</TD>
					</TR>
					<TR>
						<TD>
							<TABLE id="Table3" style="WIDTH: 895px; HEIGHT: 362px" cellSpacing="0" 
                                cellPadding="0" border="0">
								<TR>
									<TD style="WIDTH: 437px">
										<TABLE id="Table5" style="WIDTH: 419px; HEIGHT: 400px" cellSpacing="0" 
                                            cellPadding="0" border="0">
											<TR>
												<TD style="WIDTH: 384px">
													<TABLE id="Table11" style="WIDTH: 409px; HEIGHT: 106px" cellSpacing="0" 
                                                        cellPadding="0" border="0">
														<TR>
															<TD style="WIDTH: 32px" align="right"><asp:label id="Label2" runat="server" Font-Names="Century Gothic" Width="17px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True">Desde:</asp:label></TD>
															<TD class="style10"><asp:textbox id="TxtDate1" runat="server" Font-Names="Gill Sans MT" Width="116px" BackColor="White"></asp:textbox>
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
															<TD style="WIDTH: 36px">
																<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"><asp:rangevalidator id="RangeValidator1" runat="server" Font-Names="Century Gothic" Width="112px" Font-Size="10pt"
																		Font-Bold="True" BackColor="AliceBlue" MinimumValue="01/01/1900" MaximumValue="01/01/2999" Type="Date" ControlToValidate="TxtDate1" ErrorMessage="RangeValidator">Fecha Invalida</asp:rangevalidator></P>
															</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left"><asp:label id="Label3" runat="server" Font-Names="Century Gothic" Width="36px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True">Hasta:</asp:label></TD>
															<TD class="style10"><asp:textbox id="TxtDate2" runat="server" Font-Names="Gill Sans MT" Width="115px" BackColor="White"></asp:textbox>
                                                                <cc1:MaskedEditExtender ID="TxtDate2_MaskedEditExtender" runat="server" 
                                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="TxtDate2">
                                                                </cc1:MaskedEditExtender>
                                                            </TD>
															<TD style="WIDTH: 36px"><asp:rangevalidator id="RangeValidator2" runat="server" Font-Names="Century Gothic" Width="111px" Font-Size="10pt"
																	Font-Bold="True" BackColor="AliceBlue" MinimumValue="01/01/1900" MaximumValue="01/01/2999" Type="Date" ControlToValidate="TxtDate2"
																	ErrorMessage="RangeValidator">Fecha Invalida</asp:rangevalidator></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">&nbsp;</TD>
															<TD class="style10">
                                                                <asp:label id="Label19" runat="server" Font-Names="Century Gothic" 
                                                                    Width="160px" Font-Size="10pt"
																	ForeColor="#CC0000" Font-Bold="True" Height="16px">Periodo para el Cálculo de Mora: de 1 a</asp:label>
                                                                <br />
                                                                </TD>
															<TD style="WIDTH: 36px">
                                                                <asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Gill Sans MT" 
                                                                    Font-Size="10pt" Text="Cambiar Rangos" Height="16px" Width="126px" />
                                                            </TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">
                                                                &nbsp;</TD>
															<TD class="style10">
                                                                <asp:TextBox ID="txtrango1" runat="server" Height="27px" Width="87px" onkeypress="return SoloNumeros(event)"></asp:TextBox>
                                                                <cc1:NumericUpDownExtender ID="txtrango1_NumericUpDownExtender" runat="server" 
                                                                    Enabled="True" Maximum="99999" Minimum="1" RefValues="" ServiceDownMethod="" 
                                                                    ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                                    TargetButtonUpID="" TargetControlID="txtrango1" Width="60">
                                                                </cc1:NumericUpDownExtender>
                                                            </TD>
															<TD style="WIDTH: 36px">&nbsp;</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">
                                                                &nbsp;</TD>
															<TD class="style10">
                                                                <asp:TextBox ID="txtrango2" runat="server" Height="27px" Width="87px" onkeypress="return SoloNumeros(event)"></asp:TextBox>
                                                                <cc1:NumericUpDownExtender ID="txtrango2_NumericUpDownExtender" runat="server" 
                                                                    Enabled="True" Maximum="99999" Minimum="1" RefValues="" ServiceDownMethod="" 
                                                                    ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                                    TargetButtonUpID="" TargetControlID="txtrango2" Width="60">
                                                                </cc1:NumericUpDownExtender>
                                                            </TD>
															<TD style="WIDTH: 36px">&nbsp;</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">
                                                                &nbsp;</TD>
															<TD class="style10">
                                                                <asp:TextBox ID="txtrango3" runat="server" Height="27px" Width="87px" onkeypress="return SoloNumeros(event)"></asp:TextBox>
                                                                <cc1:NumericUpDownExtender ID="txtrango3_NumericUpDownExtender" runat="server" 
                                                                    Enabled="True" Maximum="99999" Minimum="1" RefValues="" ServiceDownMethod="" 
                                                                    ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                                    TargetButtonUpID="" TargetControlID="txtrango3" Width="60">
                                                                </cc1:NumericUpDownExtender>
                                                            </TD>
															<TD style="WIDTH: 36px">&nbsp;</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">
                                                                &nbsp;</TD>
															<TD class="style10">
                                                                <asp:TextBox ID="txtrango4" runat="server" Height="27px" Width="87px" onkeypress="return SoloNumeros(event)"></asp:TextBox>
                                                                <cc1:NumericUpDownExtender ID="txtrango4_NumericUpDownExtender" runat="server" 
                                                                    Enabled="True" Maximum="99999" Minimum="1" RefValues="" ServiceDownMethod="" 
                                                                    ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                                    TargetButtonUpID="" TargetControlID="txtrango4" Width="60">
                                                                </cc1:NumericUpDownExtender>
                                                            </TD>
															<TD style="WIDTH: 36px">&nbsp;</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left">&nbsp;</TD>
															<TD class="style10">&nbsp;</TD>
															<TD style="WIDTH: 36px">&nbsp;</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left"><asp:label id="Label9" runat="server" 
                                                                    Font-Names="Century Gothic" Width="65px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True" Visible="False">Exportar a:</asp:label></TD>
															<TD class="style10"><asp:dropdownlist id="ddlexportar" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="169px" Visible="False"></asp:dropdownlist></TD>
															<TD style="WIDTH: 36px" align="center">
                                                                &nbsp;</TD>
														</TR>
														</TABLE>
												</TD>
											</TR>
											<TR>
												<TD align="left" class="style7">
                                                                <asp:CheckBox ID="CheckBox4" runat="server" Font-Names="Gill Sans MT" 
                                                                    Font-Size="12pt" Text="Solo Saldos con Mora" Height="16px" Width="196px" />
                                                            </TD>
											</TR>
											<TR>
												<TD align="left" class="style7">
                                                                <table cellpadding="0" cellspacing="0" class="style8">
                                                                    <tr>
                                                                        <td class="style9">
                                                                <asp:CheckBox ID="CheckBox5" runat="server" Font-Names="Gill Sans MT" 
                                                                    Font-Size="12pt" Text="Solo Créditos a Vencer Hasta el:" Height="16px" Width="231px" />
                                                                        </td>
                                                                        <td>
                                                                            <asp:textbox id="TxtDate3" runat="server" Font-Names="Gill Sans MT" Width="115px" 
                                                                                BackColor="White"></asp:textbox>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </TD>
											</TR>
											<TR>
												<TD align="center" class="style3">
                                                                <asp:Button ID="btAplicar" runat="server" Font-Names="Gill Sans MT" Height="24px" 
                                                                    Text="Aplicar" Width="94px" />
                                                            </TD>
											</TR>
											<TR>
												<TD align="center" class="style5">
                                                    <table border="2" cellpadding="0" cellspacing="0" class="style2" 
                                                        style="border: thin groove #003366; height: 310px;">
                                                        <tr>
                                                            <td align="right">
                                                                <asp:label id="Label15" runat="server" 
                                                                    Font-Names="Century Gothic" Width="51px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True" Height="16px">Producto</asp:label>
                                                            </td>
                                                            <td class="style4">
                                                                <asp:dropdownlist id="ddlproducto" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="218px" Font-Size="10pt"></asp:dropdownlist>
                                                            </td>
                                                            <td>
                                                                <asp:checkbox id="chqproducto" runat="server" Font-Names="Century Gothic" 
                                                                    Width="73px" Font-Size="10pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="#ffcc66" Height="27px"></asp:checkbox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:label id="Label1" runat="server" Font-Names="Century Gothic" Width="27px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True">Oficina</asp:label>
                                                            </td>
                                                            <td class="style4">
                                                                <asp:dropdownlist id="ddloficinas" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="218px" Font-Size="10pt"></asp:dropdownlist>
                                                            </td>
                                                            <td>
                                                                <asp:checkbox id="chqoficinas" runat="server" Font-Names="Century Gothic" 
                                                                    Width="73px" Font-Size="10pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:label id="Label6" runat="server" Font-Names="Century Gothic" Width="67px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True" Height="16px">Fuente de Fondos</asp:label>
                                                            </td>
                                                            <td class="style4">
                                                                <asp:dropdownlist id="ddllineas" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="218px" Font-Size="10pt"></asp:dropdownlist>
                                                            </td>
                                                            <td>
                                                                <asp:checkbox id="chqlineas" runat="server" Font-Names="Century Gothic" 
                                                                    Width="73px" Font-Size="10pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:label id="Label4" runat="server" 
                                                                    Font-Names="Century Gothic" Width="68px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True">Asesor de Negocio:</asp:label>
                                                            </td>
                                                            <td class="style4">
                                                                <asp:dropdownlist id="ddlanalistas" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="218px" Font-Size="10pt"></asp:dropdownlist>
                                                            </td>
                                                            <td>
                                                                <asp:checkbox id="chqanalistas" runat="server" Font-Names="Century Gothic" 
                                                                    Width="73px" Font-Size="10pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:label id="Label7" runat="server" Font-Names="Century Gothic" Width="82px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True">Condición de la Cartera</asp:label>
                                                            </td>
                                                            <td class="style4">
                                                                <asp:dropdownlist id="ddlcartera" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="218px" Font-Size="10pt"></asp:dropdownlist>
                                                            </td>
                                                            <td>
                                                                <asp:checkbox id="chqcartera" runat="server" Font-Names="Century Gothic" 
                                                                    Width="73px" Font-Size="10pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:label id="Label8" runat="server" Font-Names="Century Gothic" Width="46px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True">Tipo de Cartera</asp:label>
                                                            </td>
                                                            <td class="style4">
                                                                <asp:dropdownlist id="ddltipo" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="218px" Font-Size="10pt"></asp:dropdownlist>
                                                            </td>
                                                            <td>
                                                                <asp:checkbox id="chqtipo" runat="server" Font-Names="Century Gothic" 
                                                                    Width="73px" Font-Size="10pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:label id="Label11" runat="server" Font-Names="Century Gothic" Width="51px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True">Municipio</asp:label>
                                                            </td>
                                                            <td class="style4">
                                                                <asp:dropdownlist id="ddlmuni" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="218px" Font-Size="10pt"></asp:dropdownlist>
                                                            </td>
                                                            <td>
                                                                <asp:checkbox id="chqmuni" runat="server" Font-Names="Century Gothic" 
                                                                    Width="73px" Font-Size="10pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent"></asp:checkbox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="right">
                                                                <asp:label id="Label5" runat="server" Font-Names="Century Gothic" Width="64px" Font-Size="10pt"
																	ForeColor="#0000C0" Font-Bold="True">Estratificación</asp:label>
                                                            </td>
                                                            <td class="style4">
                                                                <asp:dropdownlist id="ddlestrato" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="218px" Font-Size="10pt"></asp:dropdownlist>
                                                            </td>
                                                            <td>
                                                                <asp:checkbox id="chqestrato" runat="server" Font-Names="Century Gothic" 
                                                                    Width="73px" Font-Size="10pt"
																	ForeColor="#16387C" BorderWidth="1px" Text="Todos" BorderColor="Transparent" Height="22px"></asp:checkbox>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </TD>
											</TR>
											<TR>
												<TD style="WIDTH: 384px" align="center"><asp:label id="label_mensaje" runat="server" Font-Names="Century Gothic" Width="375px" Font-Size="10pt"
														BackColor="Transparent" Height="25px"></asp:label></TD>
											</TR>
										</TABLE>
									</TD>
									<TD align="center">
										<table cellpadding="0" cellspacing="0" class="style1">
                                            <tr>
                                                <td align="center">
                                                                <asp:Button ID="btnmine" runat="server" Font-Names="Gill Sans MT" Height="24px" 
                                                                    Text="Generar MINE" Width="94px" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:label id="Label20" runat="server" Font-Names="Century Gothic" 
                                                        Width="178px" Font-Size="12pt"
																	ForeColor="#0000C0" Font-Bold="True">Campos para Informe:</asp:label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:CheckBox ID="CheckBox6" runat="server" AutoPostBack="True" 
                                                        Font-Names="Gill Sans MT" Font-Size="12pt" Text="Marcar Todos" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                        <asp:datagrid id="datagrid1" runat="server" 
                            Width="351px" AllowSorting="True" AutoGenerateColumns="False"
					BorderColor="#003366" BorderWidth="2px" CellPadding="4" 
                            Height="121px" ForeColor="#333333" PageSize="30" CssClass="CSSTableGenerator">
					        <EditItemStyle BackColor="#2461BF" />
					<SelectedItemStyle Font-Bold="True" ForeColor="#333333" BackColor="#D1DDF1"></SelectedItemStyle>
					    <AlternatingItemStyle BackColor="#99FF33" />
					<ItemStyle BackColor="#EFF3FB"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#507CD1"></HeaderStyle>
					<FooterStyle ForeColor="White" BackColor="#507CD1" Font-Bold="True"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="ccodigo" DataTextField="ccodigo" HeaderText="Codigo" 
                            SortExpression="ccodigo">
						    <FooterStyle BackColor="#66FF99" Font-Bold="False" Font-Italic="False" 
                                Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                VerticalAlign="Middle" Font-Names="Gill Sans MT" Font-Size="10pt" />
						    <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Size="10pt" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" 
                                Font-Names="Gill Sans MT" />
						</asp:ButtonColumn>
						<asp:BoundColumn DataField="cdescri" 
                            HeaderText="Campos" ReadOnly="True" SortExpression="cdescri">
							<FooterStyle BackColor="#996600" Font-Bold="False" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
							<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Font-Bold="True" 
                                HorizontalAlign="Center" VerticalAlign="Top" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
							<ItemStyle Font-Size="10pt" Font-Names="Gill Sans MT" HorizontalAlign="Left" 
                                VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False"></ItemStyle>
						</asp:BoundColumn>
       					<asp:TemplateColumn HeaderText="Seleccionar" SortExpression="lmodifi">
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox3" runat="server" 
                                    Checked='<%# DataBinder.Eval(Container, "DataItem.lmodifi") %>' />
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                                Font-Underline="False" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Size="10pt" Font-Strikeout="False" Font-Underline="False" 
                                Font-Names="Gill Sans MT" />
                        </asp:TemplateColumn>
       					<asp:BoundColumn DataField="cstrtab" SortExpression="cstrtab">
                            <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                                Font-Underline="False" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                                Font-Underline="False" />
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="cflag" SortExpression="cflag">
                            <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                                Font-Underline="False" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                                Font-Underline="False" />
                        </asp:BoundColumn>
       					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#2461BF" 
                            Wrap="False"></PagerStyle>
				</asp:datagrid>
                                                </td>
                                            </tr>
                                        </table>
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
