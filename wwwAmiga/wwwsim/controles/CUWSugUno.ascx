<%@ Control Language="vb" AutoEventWireup="false" Codefile="CUWSugUno.ascx.vb" Inherits="CUWSugUno"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<style type="text/css">
    .style10
    {
        width: 95%;
        height: 29px;
    }
    .style11
    {
        width: 146px;
    }
    .style26
    {
        width: 122px;
        }
    .style28
    {
        width: 100px;
        height: 32px;
    }
    .style29
    {
        width: 91px;
        height: 32px;
    }
    .style31
    {
        width: 95px;
        height: 32px;
    }
    .style32
    {
        width: 102px;
        height: 32px;
    }
    .style33
    {
        width: 114px;
        height: 32px;
    }
    .style34
    {
        height: 32px;
    }
    
    .style37
    {
        height: 30px;
    }
    .CSSTableGenerator
    {
        height: 98px;
        width: 312px;
    }
    .style38
    {
        width: 92px;
        height: 32px;
    }
    .style39
    {
        width: 70px;
    }
    .style40
    {
        width: 56%;
    }
    .style41
    {
        width: 100%;
    }
    .style42
    {
        width: 166px;
        height: 31px;
    }
    .style43
    {
        height: 31px;
    }
    .style44
    {
        width: 166px;
        height: 29px;
    }
    .style45
    {
        height: 29px;
    }
    .style46
    {
        width: 166px;
        height: 33px;
    }
    .style47
    {
        height: 33px;
    }
    .style48
    {
        width: 166px;
        height: 30px;
    }
    .style49
    {
        width: 166px;
    }
    .style50
    {
        height: 24px;
    }
</style>
<script src="js/jquery.js" type="text/javascript"></script>    
 <script type="text/javascript" src="js/lib.js"></script>
 <script type="text/javascript">
function ValidaTasa() {
            var ntasa, ntasmin, ntasmax, ntasaestandar;
            ntasa = document.getElementById("<%=txttasa.ClientID %>").value;
            ntasmin = document.getElementById("<%=HiddenField2.ClientID %>").value;
            ntasmax = document.getElementById("<%=HiddenField3.ClientID %>").value;
            ntasaestandar = document.getElementById("<%=HiddenField4.ClientID %>").value;
            if (ntasa < ntasmin || ntasa > ntasmax) {
                document.getElementById("<%=txttasa.ClientID %>").value = ntasaestandar;
                alert('Tasa Fuera de Rango, Verifique!!!');
             }
        }
</script>
<table border="1" cellpadding="0" cellspacing="0" class="style40" 
    style="border-color: #003366">
    <tr>
        <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style40">
                <tr>
                    <td align="center">
				<TABLE id="Table10" style="WIDTH: 672px; HEIGHT: 22px" cellSpacing="0" cellPadding="0"
					width="672" border="0" align="left">
					<TR>
						<TD style="WIDTH: 112px"><asp:label id="Label1" runat="server" Width="67px" Font-Names="Gill Sans MT" Font-Size="10pt">Credito:</asp:label></TD>
						<TD style="WIDTH: 88px"><asp:dropdownlist id="cbxCodIns" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist></TD>
						<TD style="WIDTH: 168px"><asp:dropdownlist id="cbxcodofi" runat="server" Width="216px" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist></TD>
						<TD style="WIDTH: 145px"><asp:textbox id="txtcnrocta" runat="server" Width="112px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
						<TD><asp:textbox id="txtCredito" runat="server" Width="182px" Font-Size="10pt" 
                                BorderWidth="1px" Enabled="False"
								Visible="False" Height="20px"></asp:textbox></TD>
					</TR>
				</TABLE>
				    </td>
                </tr>
                <tr>
                    <td align="center">
				<TABLE id="Table11" style="WIDTH: 582px; HEIGHT: 2px" cellSpacing="0" cellPadding="0"
					border="0" align="left">
					<TR>
						<TD style="WIDTH: 69px"><asp:label id="Label2" runat="server" Width="57px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="17px">Cliente:</asp:label></TD>
						<TD style="WIDTH: 233px"><asp:textbox id="txtcCodCli" runat="server" Width="224px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
						<TD><asp:textbox id="txtcNomcli" runat="server" Width="264px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				    </td>
                </tr>
                <tr>
                    <td align="center">
				<TABLE id="Table13" style="WIDTH: 688px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="688"
					border="0" align="left">
					<TR>
						<TD class="style39"><asp:label id="Label3" runat="server" Width="60px" Font-Names="Gill Sans MT" Font-Size="10pt">Analista:</asp:label></TD>
						<TD style="WIDTH: 230px"><asp:textbox id="txtNomAna" runat="server" Width="224px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="19px"></asp:textbox></TD>
						<TD style="WIDTH: 86px"><asp:textbox id="txtccodana" runat="server" Width="56px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="20px"></asp:textbox></TD>
						<TD style="WIDTH: 86px">&nbsp;</TD>
						<TD style="WIDTH: 86px">&nbsp;</TD>
					</TR>
				</TABLE>
				    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:label id="Label7" runat="server" Width="688px" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" BorderWidth="2px"
								Height="21px" BorderColor="#0000C0" BackColor="SteelBlue" ForeColor="AliceBlue">Fuente de Ingresos</asp:label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
				<TABLE id="Table16" style="WIDTH: 688px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="688"
					border="0">
					<TR>
						<TD style="WIDTH: 234px"><asp:dropdownlist id="cbxfueing" runat="server" 
                                Width="306px" Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px"></asp:dropdownlist></TD>
						<TD><asp:textbox id="txtActCre" runat="server" Width="368px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:label id="Label23" runat="server" Width="115px" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" BorderWidth="2px"
								Height="16px" BorderColor="#0000C0" BackColor="SteelBlue" ForeColor="AliceBlue">Datos Sugeridos</asp:label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
				        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <TABLE id="Table24" cellSpacing="0" cellPadding="0" 
                            border="0" align="left" class="CSSTableGenerator">
                                    <TR>
                                        <TD align="right" class="style49">
                                            &nbsp;</TD>
                                        <TD>
                                            &nbsp;</TD>
                                    </TR>
                                    <TR>
                                        <TD align="right" class="style42">
                                            <asp:label id="Label12" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Destino de Crédito:</asp:label>
                                        </TD>
                                        <TD class="style43">
                                            <asp:DropDownList ID="cbxdescre" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="276px">
                                            </asp:DropDownList>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD align="right" class="style44">
                                            <asp:label id="Label13" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Sector Económico:</asp:label>
                                        </TD>
                                        <TD class="style45">
                                            <select id="cbxsececo" 
                            
                                
                                style="FONT-SIZE: 12px; WIDTH: 276px; FONT-FAMILY: 'Gill Sans MT'; height: 18px;" disabled
								name="cbxsececo" runat="server">
                                                <OPTION selected></OPTION>
                                            </select></TD>
                                    </TR>
                                    <TR>
                                        <TD align="right" class="style44">
                                            <asp:label id="Label43" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Fuente de Fondos:</asp:label>
                                        </TD>
                                        <TD class="style45">
                                            <asp:DropDownList ID="cbxprograma" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="276px" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD align="right" class="style46">
                                            <asp:label id="Label44" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Programa:</asp:label>
                                        </TD>
                                        <TD class="style47">
                                            <asp:dropdownlist id="cmbprograma" Font-Size="10pt" Width="276px" 
                            Font-Names="Gill Sans MT" runat="server"
								Enabled="False" Height="16px">
                                            </asp:dropdownlist>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD align="right" class="style48">
                                            <asp:label id="Label6" Font-Size="10pt" Font-Names="Gill Sans MT" Width="120px" 
                                runat="server" BorderWidth="0px"
								BorderColor="#C04000" BorderStyle="Groove">Grupo:</asp:label>
                                        </TD>
                                        <TD class="style37">
                                            <SELECT id="cbxgrupos" style="FONT-SIZE: 12px; WIDTH: 276px; FONT-FAMILY: 'Gill Sans MT'"
								name="cbxanacre" runat="server">
                                                <OPTION selected></OPTION>
                                            </SELECT>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD align="right" class="style49">
                                            <asp:label id="Label28" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" runat="server" Width="39px">Producto:</asp:label>
                                        </TD>
                                        <TD>
                                            <asp:dropdownlist id="ddlcartera" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" runat="server" Width="203px" Height="16px" 
                                            style="margin-left: 0px; margin-right: 5px">
                                            </asp:dropdownlist>
                                            <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" 
                                            Text="Buscar Líneas" />
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD align="right" class="style49">
                                            <asp:label id="Label8" runat="server" 
                                Width="120px" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="0px"
								BorderColor="#C04000" BorderStyle="Groove">Línea de Crédito:</asp:label>
                                        </TD>
                                        <TD>
                                            <asp:dropdownlist id="cbxLineas" runat="server" Width="424px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" AutoPostBack="True">
                                            </asp:dropdownlist>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD align="right" class="style49">
                                            <asp:label id="Label18" runat="server" Width="120px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="0px"
								BorderColor="#C04000" BorderStyle="Groove" Visible="False">Tipo de Contrato:</asp:label>
                                        </TD>
                                        <TD>
                                            <asp:dropdownlist id="cbxContrato" runat="server" Width="424px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False">
                                            </asp:dropdownlist>
                                        </TD>
                                    </TR>
                                </TABLE>
                            </ContentTemplate>
                        </asp:UpdatePanel>
				        </td>
                </tr>
                <tr>
                    <td align="center">
                            <table cellpadding="0" cellspacing="0" class="style26">
                                <tr>
                                    <td align="center">
                                        <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                                            <tr>
                                                <td>
                                        <asp:label id="Label46" runat="server" Width="96px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Height="18px">Monto Solicitado:</asp:label>
                                                </td>
                                                <td>
                                                    <asp:textbox id="txtMonSol" runat="server" Width="80px" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                        <asp:label id="Label10" runat="server" Width="96px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">Monto Sugerido:</asp:label>
                                                </td>
                                                <td>
                                        <asp:textbox id="txtmonSug" runat="server" Width="80px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px"></asp:textbox>
                                                </td>
                                                <td>
                                        <asp:rangevalidator id="RangeValidator1" runat="server" Width="149px" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt"
								ErrorMessage="RangeValidator" ControlToValidate="txtmonSug" MaximumValue="2000000" MinimumValue="50"
								Type="Double">Monto Sugerido Inválido-</asp:rangevalidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label33" runat="server" Font-Names="Gill Sans MT" 
                                                        Font-Size="10pt" Width="94px">Tasa de Interes:</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txttasa" runat="server" BorderWidth="1px" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt" onchange="ValidaTasa();" 
                                                        Width="80px" Enabled="False"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:RangeValidator ID="RangeValidator8" runat="server" 
                                                        ControlToValidate="txttasa" ErrorMessage="RangeValidator" Font-Names="Verdana" 
                                                        Font-Size="8pt" MaximumValue="200" MinimumValue="0" Type="Double" Width="149px">Tasa Inválido-</asp:RangeValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style37">
                                        <asp:label id="Label11" runat="server" Width="75px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">F.Desembolso:</asp:label>
                                                </td>
                                                <td class="style37">
                                        <asp:textbox id="txtFecDes" runat="server" Width="80px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Height="22px"></asp:textbox>
                                                    <cc1:MaskedEditExtender ID="txtFecDes_MaskedEditExtender" runat="server" 
                                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                        Mask="99/99/9999" MaskType="Date" TargetControlID="txtFecDes">
                                                    </cc1:MaskedEditExtender>
                                                </td>
                                                <td class="style37">
                                        <asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" ErrorMessage="RangeValidator"
								ControlToValidate="txtFecDes" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date">Fecha de Des.Inválida-</asp:rangevalidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                        <asp:label id="Label21" runat="server" Width="65px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">F. 1ªCuota</asp:label>
                                                </td>
                                                <td>
                                        <asp:textbox id="txtfecpri" runat="server" Width="80px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Height="22px"></asp:textbox>
                                                    <cc1:MaskedEditExtender ID="txtfecpri_MaskedEditExtender" runat="server" 
                                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                        Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecpri">
                                                    </cc1:MaskedEditExtender>
                                                </td>
                                                <td>
                                        <asp:rangevalidator id="Rangevalidator6" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" ErrorMessage="RangeValidator"
								ControlToValidate="txtfecpri" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date">Fecha de 1º Cuota Inválida-</asp:rangevalidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                        <asp:label id="Label20" runat="server" Width="80px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">F.Vencimiento</asp:label>
                                                </td>
                                                <td>
                                        <asp:textbox id="txtvencimiento" runat="server" Width="80px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="22px"></asp:textbox>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="style50">
                                        <asp:label id="Label14" runat="server" Width="48px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">NºCuotas:</asp:label>
                                                </td>
                                                <td class="style50">
                                        <asp:textbox id="pnCuoSug" runat="server" Width="80px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Height="21px" Enabled="False"></asp:textbox>
                                                </td>
                                                <td class="style50">
                                        <asp:rangevalidator id="RangeValidator2" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" ErrorMessage="RangeValidator"
								ControlToValidate="pnCuoSug" MaximumValue="240" MinimumValue="1" Type="Integer">Cuotas Inválidas-</asp:rangevalidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                        <asp:label id="Label9" runat="server" Width="48px" Font-Names="Gill Sans MT" Font-Size="10pt">Garantías:</asp:label>
                                                </td>
                                                <td>
                                        <asp:textbox id="txtgarantias" runat="server" Width="81px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="18px"></asp:textbox>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                        <asp:label id="Label45" runat="server" Width="80px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">Monto Cuota:</asp:label>
                                                </td>
                                                <td>
                                        <asp:textbox id="txtnmoncuo" runat="server" Width="81px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="18px">0.00</asp:textbox>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            </table>
                                    </td>
                                    <td align="center">
                                        <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    <asp:Label ID="Label42" runat="server" BorderWidth="0px" Font-Bold="False" 
                                                        Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="White" Height="16px" 
                                                        Width="128px">Tipo de Cuota</asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                        <asp:radiobutton id="RadioButton1" runat="server" Width="139px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="0px" BorderColor="#000066" BackColor="White" GroupName="TipoPago" Text="FIJA NIVELADA" 
                                            Checked="True" Enabled="False"></asp:radiobutton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                        <asp:radiobutton id="RadioButton5" runat="server" Width="104px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="0px" BorderColor="#000066" BackColor="White" GroupName="TipoPago" Text="FLAT" Enabled="False"></asp:radiobutton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                        <asp:radiobutton id="RadioButton4" runat="server" Width="104px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="0px" BorderColor="#000066" BackColor="White" GroupName="TipoPago" Text="Decreciente" 
                                Height="16px" Enabled="False"></asp:radiobutton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                        <asp:label id="Label26" runat="server" Width="176px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Font-Bold="False">FORMA DE PAGO</asp:label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                        <asp:label id="Label24" runat="server" Width="71px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Height="16px">Capital:</asp:label>
                                                </td>
                                                <td>
                                        <asp:dropdownlist id="cbxCapital" runat="server" Width="150px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" AutoPostBack="True" Height="16px" 
                                                        Enabled="False"></asp:dropdownlist>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                        <asp:label id="Label25" runat="server" Width="59px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Height="17px">Interes:</asp:label>
                                                </td>
                                                <td>
                                        <asp:dropdownlist id="cbxInteres" runat="server" Width="150px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Enabled="False"></asp:dropdownlist>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:label id="Label22" runat="server" Width="139px" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" BorderWidth="2px"
						Height="16px" BorderColor="#0000C0" BackColor="SteelBlue" ForeColor="AliceBlue" Visible="False">Refinanciamiento</asp:label>
					</td>
                </tr>
                <tr>
                    <td align="center">
					<TABLE id="Table31" style="WIDTH: 660px; HEIGHT: 2px" cellSpacing="0" cellPadding="0"
						border="0">
						<TR>
							<TD style="WIDTH: 687px" align="center">
                <asp:GridView ID="Grid_Ref" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="612px">
                    <Columns>                                                
                        <asp:BoundField DataField="idcuenta" HeaderText="cuenta">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>                        
                        <asp:BoundField DataField="nCapita" HeaderText="Capital" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nIntere" HeaderText="Interes" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nIntMor" HeaderText="Mora">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nsegdeu" HeaderText="Seguro" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ncomision" HeaderText="Comisión" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="niva" HeaderText="Iva" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ntota" HeaderText="Total" 
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
							<TD style="WIDTH: 687px" align="center">
                                <INPUT id="btnQuitar" style="BACKGROUND-IMAGE: url(Web/gifs/btn_quitar.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button3" runat="server"></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 687px" align="center">
                                &nbsp;</TD>
							<TD style="WIDTH: 687px" align="center">
                                &nbsp;</TD>
						</TR>
					</TABLE>
					</td>
                </tr>
                <tr>
                    <td align="center">
                            <table align="center" cellpadding="0" cellspacing="0" class="style10">
                                <tr>
                                    <td align="right" class="style11">
                                        <asp:Label ID="Label27" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                            Text="Causa de Rechazo:" Visible="False"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlcausa" runat="server" BackColor="#A8C5FF" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#000066" Height="25px" 
                                            Visible="False" Width="373px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                </table>
                        </td>
                </tr>
                <tr>
                    <td align="center">
					<TABLE id="Table33" style="WIDTH: 574px; HEIGHT: 75px" cellSpacing="0" 
                        cellPadding="0" border="0" align="center">
						<TR>
							<TD class="style28">
								<P><INPUT id="btnGrabar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
										type="button" name="Button4" runat="server"></P>
							</TD>
							<TD class="style29">
                                <INPUT id="btnIA" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_IA.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button5" runat="server"></TD>
							<TD class="style38">
                                <INPUT id="btnPlan" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_plan_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button2" runat="server"></TD>
							<TD class="style31">
                                <INPUT id="btnInicializar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button6" runat="server"></TD>
							<TD class="style32">
                                <INPUT id="btnResCom" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_sugerencia_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button7" runat="server"></TD>
							<TD class="style33"><INPUT id="btnhistoria" style="BACKGROUND-IMAGE: url(Web/jpgs/signo2.bmp); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button1" runat="server"></TD>
							<TD class="style34">
                                <asp:ImageButton ID="ImageButton1" runat="server" BorderColor="Black" 
                                    ImageUrl="~/web/jpgs/btn_rechazar_b.jpg" />
                                <cc1:ConfirmButtonExtender ID="ImageButton1_ConfirmButtonExtender" 
                                    runat="server" ConfirmText="Seguro de Rechazar?" Enabled="True" 
                                    TargetControlID="ImageButton1">
                                </cc1:ConfirmButtonExtender>
                            </TD>
						</TR>
						</TABLE>
				    </td>
                </tr>
                <tr>
                    <td align="center">
				<TABLE id="Table29" style="WIDTH: 625px; HEIGHT: 40px" cellSpacing="0" cellPadding="0"
					border="0" align="center">
					<TR>
						<TD><asp:label id="Label19" runat="server" Width="16px" Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False">Gastos:</asp:label>
                            <asp:textbox id="TxtCapita" runat="server" Width="21px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Visible="False" Height="18px"></asp:textbox><asp:label id="Label17" runat="server" Width="40px" Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False">Meses</asp:label><asp:textbox id="txtgastos" runat="server" Width="16px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtnmeses" runat="server" Width="23px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TxtRefina" runat="server" Width="21px" Font-Names="Gill Sans MT" Font-Size="10pt"
								Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TxtDesembolso" runat="server" Width="30px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TxtDescuento" runat="server" Width="29px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtdFecVen" runat="server" Width="29px" Visible="False" Height="16px"></asp:textbox><asp:textbox id="txtnliminf" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtnlimsup" runat="server" Width="32px" Visible="False"></asp:textbox>
                            <asp:textbox id="txtcplazo" runat="server" Width="16px" Visible="False" 
                                Height="21px"></asp:textbox><asp:textbox id="txtcodref1" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcodref2" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcodref3" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcodref4" runat="server" Width="32px" Visible="False"></asp:textbox>
							                    <asp:CheckBox ID="Chkseguro" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Microseguro?" Visible="False" />
                                        <asp:label id="Label16" runat="server" Width="88px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Visible="False">Gracia en días:</asp:label>
                                        <asp:textbox id="pnPerGra" runat="server" Width="27px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Visible="False" Height="16px"></asp:textbox>
                                    </TD>
					</TR>
					<TR>
						<TD>
                            <table cellpadding="0" cellspacing="0" class="style41">
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
                                    <td>
                                        <asp:HiddenField ID="HiddenField4" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:HiddenField ID="HiddenField5" runat="server" />
                                    </td>
                                    <td>
                                        <asp:HiddenField ID="HiddenField6" runat="server" />
                                    </td>
                                    <td>
                                        <asp:HiddenField ID="HiddenField7" runat="server" />
                                    </td>
                                    <td>
                                        <asp:HiddenField ID="HiddenField8" runat="server" />
                                    </td>
                                </tr>
                            </table>
                        </TD>
					</TR>
					<TR>
						<TD><asp:radiobutton id="RadioButton6" runat="server" Width="93px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Periodo Fijo" 
                                Visible="False" Height="16px"></asp:radiobutton><asp:radiobutton id="RadioButton7" 
                                runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Fecha Fija" 
                                Checked="True" Visible="False"></asp:radiobutton><asp:label id="Label15" 
                                runat="server" Width="48px" Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" 
                                Visible="False">Plazo:</asp:label>
                            <asp:textbox id="pnDiaSug" runat="server" 
                                Width="30px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Visible="False" Height="20px"></asp:textbox>
                            <asp:rangevalidator id="RangeValidator3" runat="server" Width="81px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								ErrorMessage="RangeValidator" ControlToValidate="pnDiaSug" MaximumValue="730" MinimumValue="1" 
                                Type="Integer" Height="16px">Plazo Inválido-</asp:rangevalidator>
                                        <asp:radiobutton id="RadioButton2" runat="server" Width="87px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Cre" 
                                Height="20px" Visible="False"></asp:radiobutton>
                                        <asp:radiobutton id="RadioButton3" runat="server" Width="65px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Libre" 
                                Height="18px" Visible="False"></asp:radiobutton>
                                    </TD>
					</TR>
					</TABLE>
				    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

