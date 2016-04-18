<%@ Control Language="vb" AutoEventWireup="false" Codefile="cuwRepCtb.ascx.vb" Inherits="cuwRepCtb"  %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<style type="text/css">
    .style1
    {
        height: 19px;
        width: 210px;
    }
    .style2
    {
        height: 35px;
        width: 210px;
    }
    .style3
    {
        width: 210px;
    }
    .style6
    {
        width: 76%;
        height: 39px;
    }
    .style7
    {
        width: 43px;
    }
    .style8
    {
        height: 41px;
    }
    .style9
    {
        width: 100%;
        height: 29px;
    }
    .style10
    {
        height: 19px;
        width: 83px;
    }
    .style11
    {
        height: 35px;
        width: 83px;
    }
    .style12
    {
        width: 83px;
    }
</style>

<TABLE id="Table4" style="WIDTH: 520px; HEIGHT: 279px" cellSpacing="0" cellPadding="0"
	width="520" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 496px; HEIGHT: 352px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" border="0">
				<TR>
					<TD style="HEIGHT: 289px" align="center">
						<P><asp:label id="Label1" ForeColor="Navy" Font-Bold="True" runat="server" Font-Names="Verdana"
								Font-Size="Medium" Height="15px" Width="275px">LIBROS CONTABLES</asp:label>
							<TABLE id="Table9" style="WIDTH: 332px; HEIGHT: 26px" cellSpacing="0" cellPadding="0" width="332"
								border="0">
								<TR>
									<TD style="WIDTH: 118px"><asp:label id="Label13" ForeColor="#0000C0" 
                                            Font-Bold="True" runat="server" Font-Names="Verdana"
											Font-Size="8pt" Width="95px">Año:</asp:label></TD>
									<TD>
                                        <asp:DropDownList ID="cbxanos" runat="server" AutoPostBack="True" 
                                            Font-Names="Century Gothic" Font-Size="8pt" Height="41px" Width="91px">
                                        </asp:DropDownList>
                                    </TD>
								</TR>
								<TR>
									<TD style="WIDTH: 118px"><asp:label id="Label9" ForeColor="#0000C0" Font-Bold="True" runat="server" Font-Names="Verdana"
											Font-Size="8pt" Width="95px">Exportar a:</asp:label></TD>
									<TD><asp:dropdownlist id="ddlexportar" runat="server" Font-Names="Verdana" Width="168px"></asp:dropdownlist></TD>
								</TR>
							</TABLE>
						</P>
						<P>
							<TABLE id="Table5" style="WIDTH: 473px; HEIGHT: 152px" cellSpacing="0" 
                                cellPadding="0" border="0">
								<TR>
									<TD style="HEIGHT: 96px" align="center">
										<TABLE id="Table6" style="WIDTH: 371px; HEIGHT: 72px" borderColor="#ffcc00" cellSpacing="0"
											cellPadding="0" width="371" bgColor="#ffff99" border="1">
											<TR>
												<TD style="WIDTH: 62px; HEIGHT: 30px" align="right"><asp:label id="Label4" 
                                                        runat="server" Font-Names="Calibri" Font-Size="10pt" Width="56px">Oficina:</asp:label></TD>
												<TD style="HEIGHT: 30px"><SELECT id="CbxCodOFi" 
                                                        style="FONT-SIZE: 12px; WIDTH: 200px; FONT-FAMILY: calibri" name="CbxCodOFi"
														runat="server">
														<OPTION selected></OPTION>
													</SELECT>
													<asp:checkbox id="CheckBox1" runat="server" Font-Names="Calibri" Font-Size="10pt"
														Text="Consolidado" Checked="True"></asp:checkbox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 62px" align="right"><asp:label id="Label5" runat="server" 
                                                        Font-Names="Calibri" Font-Size="10pt" Width="48px">Fondos:</asp:label></TD>
												<TD>
													<P><SELECT id="cbxfondos" 
                                                            style="FONT-SIZE: 12px; WIDTH: 200px; FONT-FAMILY: calibri" name="cbxfondos"
															runat="server">
															<OPTION selected></OPTION>
														</SELECT>
														<asp:checkbox id="CheckBox2" runat="server" Font-Names="Calibri" Font-Size="10pt"
															Text="Consolidado" Checked="True"></asp:checkbox></P>
												</TD>
											</TR>
										</TABLE>
										<asp:label id="Label6" ForeColor="DarkBlue" Font-Bold="True" runat="server" Font-Names="Verdana"
											Font-Size="8pt" Width="326px">PERIODO</asp:label>
										<TABLE id="Table7" style="BORDER-LEFT-COLOR: green; BORDER-BOTTOM-COLOR: green; WIDTH: 369px; BORDER-TOP-COLOR: green; HEIGHT: 41px; BORDER-RIGHT-COLOR: green"
											borderColor="highlight" cellSpacing="0" cellPadding="0" width="369" bgColor="inactivecaptiontext"
											border="1">
											<TR bgcolor="#CCFF66">
												<TD style="WIDTH: 73px; HEIGHT: 39px" align="right"><asp:label id="Label3" 
                                                        runat="server" Font-Names="Calibri" Font-Size="10pt" Width="80px">Fecha Inicial:</asp:label></TD>
												<TD style="WIDTH: 98px; HEIGHT: 39px" align="center"><asp:textbox id="txtdfecini" 
                                                        runat="server" Font-Names="Calibri" Font-Size="10pt" Width="80px"
														BorderWidth="1px"></asp:textbox>
                                                    <cc1:MaskedEditExtender ID="txtdfecini_MaskedEditExtender" runat="server" 
                                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                        Mask="99/99/9999" MaskType="Date" TargetControlID="txtdfecini">
                                                    </cc1:MaskedEditExtender>
                                                </TD>
												<TD style="WIDTH: 74px; HEIGHT: 39px" align="right"><asp:label id="Label2" 
                                                        runat="server" Font-Names="Calibri" Font-Size="10pt" Width="72px">Fecha Final:</asp:label></TD>
												<TD style="HEIGHT: 39px" align="center"><asp:textbox id="txtdfecfin" runat="server" 
                                                        Font-Names="Calibri" Font-Size="10pt" Width="80px"
														BorderWidth="1px"></asp:textbox>
                                                    <cc1:MaskedEditExtender ID="txtdfecfin_MaskedEditExtender" runat="server" 
                                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                        Mask="99/99/9999" MaskType="Date" TargetControlID="txtdfecfin">
                                                    </cc1:MaskedEditExtender>
                                                </TD>
											</TR>
										</TABLE>
										<asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" DESIGNTIMEDRAGDROP="1491"
											Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtdfecini" ErrorMessage="RangeValidator">Fecha inicial Inválida-</asp:rangevalidator><asp:rangevalidator id="Rangevalidator1" runat="server" Font-Names="Verdana" Font-Size="8pt" DESIGNTIMEDRAGDROP="1491"
											Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtdfecfin" ErrorMessage="RangeValidator">Fecha final Inválida-</asp:rangevalidator>
										<TABLE id="Table2" style="WIDTH: 510px; HEIGHT: 20px" cellSpacing="0" cellPadding="0"
											border="0">
											<TR>
												<TD align="center"><asp:checkbox id="CheckBox3" ForeColor="DarkBlue" Font-Bold="True" runat="server" Font-Names="Verdana"
														Font-Size="8pt" Text="FILTRAR POR CUENTAS CONTABLES"></asp:checkbox></TD>
											</TR>
											<TR>
												<TD align="center">
                                                    <table cellpadding="0" cellspacing="0" class="style9">
                                                        <tr>
                                                            <td align="right">
                                                                <asp:label id="Label12" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                                                    Width="39px">Banco:</asp:label>
                                                            </td>
                                                            <td>
                        <asp:DropDownList ID="cmbBancos" runat="server" BackColor="#FFFF66" 
                            Font-Names="Verdana" Font-Size="8pt" Height="24px" Width="300px">
                        </asp:DropDownList>
                                                            </td>
                                                            <td>
                                                                <asp:CheckBox ID="chkbanco" runat="server" Checked="True" 
                                                                    Font-Names="Calibri" Font-Size="8pt" Text="Por Banco" Height="17px" 
                                                                    Width="75px" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </TD>
											</TR>
											<TR>
												<TD align="center">
													<asp:RadioButton id="Antes" Font-Size="8pt" Font-Names="Century Gothic" runat="server" Text="Antes del Cierre"
														GroupName="Cierre" Checked="True" AutoPostBack="True"></asp:RadioButton>
													<asp:RadioButton id="Despues" Font-Size="8pt" Font-Names="Century Gothic" runat="server" Text="Despues del Cierre"
														GroupName="Cierre" AutoPostBack="True"></asp:RadioButton></TD>
											</TR>
											<TR>
												<TD align="center">
										<TABLE id="Table3" style="WIDTH: 328px; HEIGHT: 32px" cellSpacing="0" cellPadding="0" width="328"
											border="0">
											<TR>
												<TD style="WIDTH: 91px" align="right"><asp:label id="Label7" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="39px">Desde:</asp:label></TD>
												<TD style="WIDTH: 65px"><asp:textbox id="txtdesde" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="96px"></asp:textbox></TD>
												<TD style="WIDTH: 67px" align="right"><asp:label id="Label8" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="39px">Hasta:</asp:label></TD>
												<TD><asp:textbox id="txthasta" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="104px"></asp:textbox></TD>
											</TR>
										</TABLE>
										        </TD>
											</TR>
											<TR>
												<TD align="center" class="style8">
													<table cellpadding="0" cellspacing="0" class="style6">
                                                        <tr>
                                                            <td class="style7">
                                                                <asp:label id="Label11" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                                                    Width="39px">Nivel:</asp:label>
                                                            </td>
                                                            <td>
                                                                <SELECT id="CbxNivel" 
                                                        
                                                                    
                                                                    style="FONT-SIZE: 12px; WIDTH: 51px; FONT-FAMILY: calibri; height: 26px; margin-left: 0px;" name="CbxNivel"
														runat="server">
														<OPTION selected></OPTION>
													</SELECT></td>
                                                            <td>
                                                                <asp:CheckBox ID="Checknivel" runat="server" Checked="True" 
                                                                    Font-Names="Calibri" Font-Size="8pt" Text="Todos los Niveles" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style7">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:CheckBox ID="Checknivel0" runat="server" 
                                                                    Font-Names="Calibri" Font-Size="8pt" Text="Nivel de Oficinas" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </TD>
											</TR>
											<TR>
												<TD align="center">
													&nbsp;</TD>
											</TR>
										</TABLE>
										<TABLE id="Table8" style="WIDTH: 520px; HEIGHT: 103px" borderColor="#ff3300" cellSpacing="0"
											cellPadding="0" bgColor="#FFD737" border="1">
											<TR>
												<TD class="style1">
                                                    <asp:radiobutton id="rbtn1" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" Text="Balance General "
														GroupName="financiero" Checked="True"></asp:radiobutton>
                                                            </TD>
												<TD class="style10">
                                                                <asp:CheckBox ID="Checkdeta0" runat="server" 
                                                                    Font-Names="Calibri" Font-Size="8pt" Text="Detallado" />
                                                            </TD>
												<TD style="HEIGHT: 19px"><asp:radiobutton id="rbtn2" runat="server" 
                                                        Font-Names="Calibri" Font-Size="10pt" Text="Libro Diario Mayor"
														GroupName="financiero"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style1">
                                                                <asp:RadioButton ID="RadioButton1" runat="server" Font-Names="Calibri" 
                                                                    Font-Size="10pt" GroupName="financiero" 
                                                        Text="Estado de Ingresos y Egresos" Width="199px" />
                                                    </TD>
												<TD class="style10">
                                                                <asp:CheckBox ID="Checkdeta1" runat="server" 
                                                                    Font-Names="Calibri" Font-Size="8pt" Text="Detallado" />
                                                    </TD>
												<TD style="HEIGHT: 19px">
                                                    <asp:RadioButton ID="rbtn12" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" GroupName="financiero" Text="Listado de Partidas" />
                                                </TD>
											</TR>
											<TR>
												<TD class="style2">
                                                                <asp:radiobutton id="rbtn5" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" Width="176px" Text="Balance de Comprobación"
														GroupName="financiero"></asp:radiobutton>
                                                </TD>
												<TD class="style11">
                                                                <asp:CheckBox ID="Checkdeta" runat="server" 
                                                                    Font-Names="Calibri" Font-Size="8pt" Text="Detallado" />
                                                </TD>
												<TD style="HEIGHT: 35px"><asp:radiobutton id="rbtn4" runat="server" 
                                                        Font-Names="Calibri" Font-Size="10pt" Text="Libro Diario Detallado"
														GroupName="financiero"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style3">
                                                    <asp:radiobutton id="rbtn7" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" Text="Libro Mayor Auxiliar"
														GroupName="financiero"></asp:radiobutton>
                                                </TD>
												<TD class="style12">
                                                    &nbsp;</TD>
												<TD><asp:radiobutton id="rbtn6" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" Text="Concentración Diaria"
														GroupName="financiero"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style3"><asp:radiobutton id="rbtn9" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" Width="204px" Text="Movimientos por Cuenta"
														GroupName="financiero" Height="19px"></asp:radiobutton></TD>
												<TD class="style12">&nbsp;</TD>
												<TD><asp:radiobutton id="rbtn8" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" Width="200px" Text="Archivo TXT Dispersador"
														GroupName="financiero" Visible="False"></asp:radiobutton></TD>
											</TR>
											<TR>
												<TD class="style3"><asp:radiobutton id="rbtn10" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" Width="160px" Text="Movimientos Bancarios"
														GroupName="financiero" Height="16px"></asp:radiobutton>
                                                    </TD>
												<TD class="style12">
                                                    <asp:CheckBox ID="CheckBox4" runat="server" Font-Names="Calibri" 
                                                        Font-Size="8pt" Text="Consolidado" />
                                                </TD>
												<TD>&nbsp;</TD>
											</TR>
											<TR>
												<TD class="style3">
                                                    <asp:RadioButton ID="rbtn13" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" GroupName="financiero" Height="16px" Text="Impresiòn Partida:" 
                                                        Width="160px" />
                                                    </TD>
												<TD class="style12">
                                                    <asp:TextBox ID="txtcnumpar" runat="server" Font-Names="Verdana" 
                                                        Font-Size="8pt" Height="24px" Width="104px"></asp:TextBox>
                                                </TD>
												<TD>
                                                    <asp:RadioButton ID="rbtn14" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" GroupName="financiero" Height="16px" Text="Exportar Movimientos a Excel:" 
                                                        Width="190px" />
                                                    </TD>
											</TR>
										</TABLE>
										<asp:textbox id="TextBox1" runat="server" Width="30px" Visible="False"></asp:textbox><asp:textbox id="TextBox2" runat="server" Width="36px" Visible="False"></asp:textbox><asp:textbox id="TextBox3" runat="server" Width="20px" Visible="False"></asp:textbox><asp:textbox id="TextBox4" runat="server" Width="46px" Visible="False"></asp:textbox><asp:textbox id="Textbox5" runat="server" Width="46px" Visible="False"></asp:textbox><asp:textbox id="Textbox6" runat="server" Width="46px" Visible="False"></asp:textbox><asp:textbox id="Textbox7" runat="server" Width="46px" Visible="False"></asp:textbox><asp:textbox id="Textbox8" runat="server" Width="31px" Visible="False"></asp:textbox>
										<asp:textbox id="txtcierre" Width="31px" runat="server" Visible="False"></asp:textbox>
                                                                <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Calibri" 
                                                                    Font-Size="8pt" GroupName="financiero" 
                                            Text="Mensual" Visible="False" />
                                                    <asp:radiobutton id="rbtn11" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" Width="152px" Text="Balance Consolidado"
														GroupName="financiero" Height="16px" Visible="False"></asp:radiobutton>
                                                            </TD>
								</TR>
							</TABLE>
						</P>
						<INPUT id="btnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 75px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
				<TR>
					<TD align="center">
                        <asp:Button ID="Button1" runat="server" Text="Button" Visible="False" />
                    </TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
