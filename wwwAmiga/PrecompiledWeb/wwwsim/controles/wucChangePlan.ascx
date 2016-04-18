<%@ control language="vb" autoeventwireup="false" inherits="wucChangePlan, App_Web_yl8dokps" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">

    .style1
    {
        width: 98%;
        height: 198px;
    }
    .style2
    {
        width: 78px;
    }
    .style4
    {
        width: 157px;
    }
    .style9
    {
        width: 156px;
    }
    .style5
    {
        width: 78px;
        height: 27px;
    }
    .style6
    {
        width: 157px;
        height: 27px;
    }
    .style10
    {
        width: 156px;
        height: 27px;
    }
    .style8
    {
        height: 27px;
    }
    .style12
    {
        height: 38px;
    }
    .style26
    {
        width: 154px;
    }
    .style30
    {
        width: 98%;
        height: 104px;
    }
    .style31
    {
        width: 68%;
    }
    .style32
    {
        height: 32px;
    }
    .style33
    {
        height: 26px;
    }
    .style34
    {
        width: 83%;
    }
    .style3
    {
        width: 70%;
        height: 51px;
    }
    .style35
    {
        height: 31px;
    }
    .style36
    {
        height: 14px;
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
&nbsp;
<head id="Head1" runat="server" />
<TABLE id="Table15" style="border: thin solid highlight; WIDTH: 643px; HEIGHT: 891px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" align="left" border="0">
	<TR>
		<TD class="style36">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">CAMBIO DE PLAN DE PAGOS<asp:HiddenField ID="HiddenField1" 
                    runat="server" />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px" align="center">
			<table align="center" cellpadding="0" cellspacing="0" class="style30">
                <tr>
                    <td align="right" class="style12">
                        <asp:label id="Label1" Height="12px" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="48px">Credito:</asp:label>
                    </td>
                    <td class="style12">
                        <table cellpadding="0" cellspacing="0" class="style31">
                            <tr>
                                <td>
                                    <asp:dropdownlist id="cbxCodIns" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="136px"></asp:dropdownlist>
                                </td>
                                <td>
                                    <asp:dropdownlist id="cbxcodofi" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="104px"></asp:dropdownlist>
                                </td>
                                <td>
                                    <asp:textbox id="txtcnrocta" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="88px"
													BorderWidth="1px" Enabled="False"></asp:textbox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style32">
                        <asp:label id="Label3" Height="15px" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="48px">Nombre:</asp:label>
                    </td>
                    <td class="style32">
                        <asp:textbox id="txtcNomcli" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="222px"
													BorderWidth="1px" Enabled="False"></asp:textbox></td>
                </tr>
                <tr>
                    <td align="right" class="style33">
                        <asp:label id="Label2" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="48px">Cliente:</asp:label>
                    </td>
                    <td class="style33">
                        <asp:textbox id="txtcCodCli" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="178px"
													BorderWidth="1px" Enabled="False"></asp:textbox><asp:textbox id="txtCredito" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="16px"
													BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox></td>
                </tr>
                <tr>
                    <td align="right">
												<asp:label id="Label29" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" 
                                                    Width="196px" Height="10px">LINEA DE CRÉDITO ACTUAL:</asp:label>
											</td>
                    <td>
												<asp:TextBox ID="TextBox1" runat="server" Enabled="False" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="23px" Width="368px"></asp:TextBox>
											</td>
                </tr>
                <tr>
                    <td align="right">
                                        <asp:label id="Label30" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" runat="server" Width="90px" Height="16px">Producto:</asp:label>
											</td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style34">
                            <tr>
                                <td>
                                        <asp:dropdownlist id="ddlcartera" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" runat="server" Width="203px" Height="16px" 
                                            style="margin-left: 0px; margin-right: 5px"></asp:dropdownlist>
                                    </td>
                                <td>
                                        <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" 
                                            Text="Buscar Líneas" />
                                    </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style35">
												<asp:label id="Label28" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" 
                                                    Width="128px" Height="10px" Visible="False">Fuente de Fondos:</asp:label>
											</td>
                    <td class="style35">
                        <asp:DropDownList ID="cbxprograma" runat="server" 
                            Font-Names="Century Gothic" Font-Size="10pt" Height="19px" Width="368px" AutoPostBack="True" 
                                                    Visible="False">
                        </asp:DropDownList>
											</td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:label id="Label8" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="104px" Height="10px">Línea de Crédito:</asp:label></td>
                    <td>
                        <asp:dropdownlist id="cbxLineas" Font-Size="10pt" Font-Names="Gill Sans MT" 
                            runat="server" Width="368px" AutoPostBack="True"></asp:dropdownlist></td>
                </tr>
                <tr>
                    <td align="right" class="style32">
                        <asp:label id="Label33" Width="56px" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt">Tasa Int.</asp:label></td>
                    <td class="style32">
                        <asp:textbox id="txtTasa" Width="61px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px"
														BorderColor="Black" onchange="ValidaTasa();"></asp:textbox></td>
                </tr>
                <tr>
                    <td align="right">
                        &nbsp;</td>
                    <td>
                        <asp:rangevalidator id="RangeValidator8" Width="86px" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt"
														ControlToValidate="txtTasa" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                            MaximumValue="100" Height="12px">Valor Inválido-</asp:rangevalidator></td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px" align="center">
                            <table align="center" cellpadding="0" cellspacing="0" class="style1">
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label5" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="96px">Monto Otorgado</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtnMonApr" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                            runat="server" Width="80px"
													BorderWidth="1px" BorderColor="Black" Enabled="False"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:rangevalidator id="RangeValidator3" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="82px"
													MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="txtnMonApr">Valor 
                                        Inválido</asp:rangevalidator>
                                    </td>
                                    <td>
                                        <asp:label id="Label12" runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px"
								BackColor="LemonChiffon" ForeColor="#C04000" Font-Bold="True">Tipo de Cuota</asp:label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label11" runat="server" Width="75px" Font-Names="Gill Sans MT" Font-Size="10pt">F.Desembolso:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtFecDes" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="80px"
													BorderWidth="1px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:rangevalidator id="RangeValidator5" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="88px"
													MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtFecDes" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator>
                                    </td>
                                    <td>
                                        <asp:radiobutton id="RadioButton1" runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Fija" Checked="True"></asp:radiobutton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label27" runat="server" Width="65px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">F. 1ªCuota</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtfecpri" Height="22px" Font-Size="Smaller" Font-Names="Century Gothic" runat="server"
										Width="80px" BorderWidth="1px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:rangevalidator id="RangeValidator6" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="88px"
										MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecpri" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator>
                                    </td>
                                    <td>
                                        <asp:radiobutton id="RadioButton5" runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Flat"></asp:radiobutton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label20" runat="server" Width="80px" Font-Names="Gill Sans MT" Font-Size="10pt">F.Vencimiento</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtvencimiento" runat="server" Width="80px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Enabled="False" Height="22px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        &nbsp;</td>
                                    <td>
                                        <asp:radiobutton id="RadioButton4" runat="server" Width="104px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Decreciente"></asp:radiobutton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        &nbsp;</td>
                                    <td class="style4">
                                        <asp:label id="Label26" runat="server" Width="148px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Font-Bold="True">FORMA DE PAGO</asp:label>
                                    </td>
                                    <td class="style9">
                                        &nbsp;</td>
                                    <td>
                                        <asp:radiobutton id="RadioButton2" runat="server" Width="104px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Creciente" 
                                            Visible="False"></asp:radiobutton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label24" runat="server" Width="96px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">Capital:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:dropdownlist id="cbxCapital" runat="server" Width="150px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" AutoPostBack="True" Height="16px"></asp:dropdownlist>
                                    </td>
                                    <td class="style9">
                                        &nbsp;</td>
                                    <td>
                                        <asp:radiobutton id="RadioButton3" runat="server" Width="104px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Libre Amort." 
                                            Visible="False"></asp:radiobutton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label25" runat="server" Width="79px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Height="16px">Interes:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:dropdownlist id="cbxInteres" runat="server" Width="150px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px"></asp:dropdownlist>
                                    </td>
                                    <td class="style9">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style5">
                                        <asp:label id="Label14" runat="server" Width="48px" Font-Names="Gill Sans MT" Font-Size="10pt">NºCuotas:</asp:label>
                                    </td>
                                    <td class="style6">
                                        <asp:textbox id="pnCuoSug" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="60px" BorderWidth="1px"
													BorderColor="Black"></asp:textbox>
                                    </td>
                                    <td class="style10">
                                        <asp:rangevalidator id="RangeValidator1" Height="8px" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server"
													Width="86px" MaximumValue="240" MinimumValue="1" Type="Integer" ErrorMessage="RangeValidator" ControlToValidate="pnCuoSug">Valor Inválido-</asp:rangevalidator>
                                    </td>
                                    <td class="style8">
                                        <asp:textbox id="pnDiaSug" runat="server" 
                                Width="72px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Visible="False"></asp:textbox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label16" runat="server" Width="88px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Visible="False">Gracia en días:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="pnPerGra0" runat="server" Width="72px" 
                                            Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Visible="False"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:radiobutton id="RadioButton6" runat="server" Width="104px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Periodo Fijo" 
                                Visible="False"></asp:radiobutton>
                                    </td>
                                    <td>
                                        <asp:radiobutton id="RadioButton7" 
                                runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Fecha Fija" 
                                Checked="True" Visible="False"></asp:radiobutton>
                                    </td>
                                </tr>
                            </table>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px" align="center">
						<asp:textbox id="txtcCodCta" runat="server" Font-Names="Verdana" Width="357px" Visible="False"></asp:textbox>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px" align="center">
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
                        <asp:BoundField DataField="cNroCuo" HeaderText="Nº Cuota">
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
                        <asp:BoundField DataField="Gastos" HeaderText="Cargos" 
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
		<TD style="HEIGHT: 29px" align="center">
                                <table align="left" cellpadding="0" cellspacing="0" 
    class="style3">
                                    <tr>
                                        <td align="right" class="style4">
                                            <asp:Label ID="Label31" runat="server" Font-Names="Gill Sans MT" 
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
                                            <asp:TextBox ID="txtfecha" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" Height="26px" Width="95px"></asp:TextBox>
                                            <cc1:MaskedEditExtender ID="txtfecha_MaskedEditExtender" runat="server" 
                                                AutoComplete="False" ClearMaskOnLostFocus="False" ClearTextOnInvalid="True" 
                                                ClipboardEnabled="False" CultureAMPMPlaceholder="" 
                                                CultureCurrencySymbolPlaceholder="" CultureDateFormat="" 
                                                CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecha">
                                            </cc1:MaskedEditExtender>
                                            <cc1:CalendarExtender ID="txtfecha_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtfecha">
                                            </cc1:CalendarExtender>
                                        </td>
                                        <td align="right">
                                            <asp:Label ID="Label32" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Monto:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtmonto" runat="server" Font-Names="Gill Sans MT" 
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
                            </TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px" align="center">
						&nbsp;</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px" align="center">
			<TABLE id="Table18" style="WIDTH: 504px; HEIGHT: 61px" cellSpacing="0" cellPadding="0"
				width="504" border="0" align="center">
				<TR>
					<TD align="center" class="style26">
                        <INPUT id="btnPlan" style="FONT-SIZE: 12px; BACKGROUND-IMAGE: url(Web/jpgs/btn_plan_b.jpg); WIDTH: 56px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
							type="button" name="Button4" runat="server"></TD>
					<TD style="WIDTH: 102px" align="center"><INPUT id="btnGrabar" style="FONT-SIZE: 12px; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 58px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button2" runat="server"></TD>
					<TD align="center">
                        <INPUT id="btnImprimir" style="BACKGROUND-POSITION: center center; FONT-SIZE: 12px; BACKGROUND-IMAGE: url('Web/gifs/imprimir.gif'); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
							type="button" name="Button3" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px" align="center">
									<TABLE id="Table1" style="WIDTH: 670px; HEIGHT: 19px" cellSpacing="0" cellPadding="0"
										border="0">
										<TR>
											<TD style="HEIGHT: 19px; BACKGROUND-COLOR: inactivecaptiontext" align="center" bgColor="inactivecaptiontext"><asp:textbox id="txtctipcuo" Height="9px" runat="server" Width="64px" Visible="False"></asp:textbox><asp:textbox id="txtctipper" Height="7px" runat="server" Width="64px" Visible="False"></asp:textbox><asp:textbox id="txtdfecven" Height="7px" runat="server" Width="64px" Visible="False"></asp:textbox><asp:textbox id="txtndiagra" Height="7px" runat="server" Width="64px" Visible="False"></asp:textbox><asp:textbox id="txtnperdia" Height="7px" runat="server" Width="64px" Visible="False"></asp:textbox>
                                                <asp:textbox id="pnPerGra" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" 
                                                    Width="26px" BorderWidth="1px"
													BorderColor="Black" Height="16px" Visible="False"></asp:textbox></TD>
										</TR>
										<TR>
											<TD align="center">
                                                <table class="style34">
                                                    <tr>
                                                        <td>
                                        <asp:HiddenField ID="HiddenField2" runat="server" />
                                                        </td>
                                                        <td>
                                        <asp:HiddenField ID="HiddenField3" runat="server" />
                                                        </td>
                                                        <td>
                                        <asp:HiddenField ID="HiddenField4" runat="server" />
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </TD>
										</TR>
									</TABLE>
									</TD>
	</TR>
	</TABLE>
