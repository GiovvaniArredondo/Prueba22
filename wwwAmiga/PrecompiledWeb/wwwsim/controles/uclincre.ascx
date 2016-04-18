<%@ control language="vb" autoeventwireup="false" inherits="uclincre, App_Web_5wr0lfuo" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>

<script language="javascript" type="text/javascript">
// <!CDATA[

    function btnGraba_onclick() {

    }

// ]]>
</script>

<link rel="stylesheet" href="css/style.css" type="text/css" />
<style type="text/css">
    .style17
    {
        width: 100%;
    }
    .style5
    {
        height: 73px;
    }
    .style3
    {
        height: 19px;
        width: 239px;
        text-align: left;
    }
    .style13
    {
        height: 41px;
        width: 239px;
        text-align: left;
    }
    .style14
    {
        width: 75px;
        height: 41px;
    }
    .style15
    {
        width: 143px;
        height: 41px;
    }
    .style16
    {
        width: 97px;
        height: 41px;
    }
    .style10
    {
        width: 320px;
    }
    .style11
    {
        height: 24px;
        width: 320px;
    }
    .style12
    {
        width: 81%;
        height: 41px;
    }
    .style9
    {
        width: 38%;
        height: 63px;
    }
    </style>
<table cellpadding="0" cellspacing="0" class="style17">
    <tr>
        <td>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 920px; HEIGHT: 376px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">DEFINIR LINEAS DE CREDITO</P>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table4" style="WIDTH: 748px; HEIGHT: 124px" cellSpacing="0" 
                cellPadding="0" border="0">
				<TR>
					<TD align="center" class="style5">
						<TABLE id="Table5" style="WIDTH: 879px; HEIGHT: 70px" borderColor="#ffcc00" cellSpacing="0"
							cellPadding="0" bgColor="#ffff99" border="1">
							<TR>
								<TD align="right" class="style3">
                                    <asp:label id="Label27" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" runat="server" Width="120px" Height="16px" 
                                        style="text-align: left">Tipo de Linea:</asp:label></TD>
								<TD align="right" class="style3">
                                    <cc1:CbxTipCred ID="CbxTipCred1" runat="server" AutoPostBack="True" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Height="18px" Width="171px">
                                    </cc1:CbxTipCred>
                                </TD>
								<TD style="WIDTH: 75px; HEIGHT: 19px" align="right">
                                    <asp:label id="Label29" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" runat="server" Width="120px" Height="16px" 
                                        style="text-align: left">Cobro de Interes:</asp:label></TD>
								<TD style="WIDTH: 143px; HEIGHT: 19px">
                                    <cc1:CbxTipCobInt ID="CbxTipCobInt1" runat="server" AutoPostBack="True" 
                                        Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="18px" 
                                        Width="187px">
                                    </cc1:CbxTipCobInt>
                                </TD>
								<TD style="WIDTH: 97px; HEIGHT: 19px" align="right">
                                    <asp:label id="Label28" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" runat="server" Width="120px" Height="16px" 
                                        style="text-align: left">Forma de Pago:</asp:label></TD>
								<TD style="WIDTH: 97px; HEIGHT: 19px" align="right">
                                    <cc1:CbxFormaPago ID="CbxFormaPago1" runat="server" AutoPostBack="True" 
                                        Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="18px" 
                                        Width="189px">
                                    </cc1:CbxFormaPago>
                                </TD>
							</TR>
							<TR>
								<TD align="right" class="style3">
                                    <asp:label id="Label21" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" runat="server" Width="120px" style="text-align: left"> Moneda:  </asp:label></TD>
								<TD align="right" class="style3">
                                    <asp:dropdownlist id="ddlmoneda" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" runat="server" Width="171px"
										AutoPostBack="True" Height="18px"></asp:dropdownlist></TD>
								<TD style="WIDTH: 75px; HEIGHT: 19px" align="right">
									<asp:label id="Label13" Font-Names="Gill Sans MT" Font-Size="12pt" runat="server" 
                                        Width="120px" Height="23px" style="text-align: left"> Plazo:</asp:label></TD>
								<TD style="WIDTH: 143px; HEIGHT: 19px">
                                    <asp:dropdownlist id="ddlplazo" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" runat="server" Width="189px" 
                                        AutoPostBack="True" Height="18px"></asp:dropdownlist></TD>
								<TD style="WIDTH: 97px; HEIGHT: 19px" align="right"><asp:label id="Label14" 
                                        Font-Names="Gill Sans MT" Font-Size="12pt" runat="server" Width="120px" 
                                        Font-Strikeout="False" Height="24px" 
                                        style="margin-left: 0px; text-align: left;">Fuente de Fondos:</asp:label></TD>
								<TD style="WIDTH: 97px; HEIGHT: 19px" align="right">
                                    <asp:dropdownlist id="ddlfondos" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        runat="server" Width="187px"
										AutoPostBack="True" Height="18px"></asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD align="right" class="style13">
                                    <asp:label id="Label1" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" runat="server" Width="120px" Height="16px" 
                                        style="text-align: left">Metodologia:</asp:label></TD>
								<TD align="right" class="style13">
                                    <asp:dropdownlist id="ddlgarantia" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" runat="server" Width="173px"
										AutoPostBack="True" Height="18px"></asp:dropdownlist></TD>
								<TD align="right" class="style14">
                                    <asp:label id="Label15" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" runat="server" Width="120px" style="text-align: left">Programa:</asp:label></TD>
								<TD class="style15">
                                    <asp:dropdownlist id="ddlcartera" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" runat="server" Width="189px"
										AutoPostBack="True" Height="18px"></asp:dropdownlist></TD>
								<TD align="right" class="style16">
                                    <asp:label id="Label16" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" runat="server" Width="120px" style="text-align: left">Producto:</asp:label></TD>
								<TD align="right" class="style16">
                                    <asp:dropdownlist id="ddlprogramas" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" runat="server" Width="189px"
										AutoPostBack="True" Height="18px"></asp:dropdownlist></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="center">
						<P style="BORDER-RIGHT: blue thin solid; BORDER-TOP: blue thin solid; FONT-WEIGHT: bold; FONT-SIZE: 12pt; BORDER-LEFT: blue thin solid; COLOR: background; BORDER-BOTTOM: blue thin solid; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffff99"
							align="center">LINEAS DE CREDITO</P>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table3" style="WIDTH: 293px; HEIGHT: 39px" cellSpacing="0" cellPadding="0" width="293"
				align="center" border="0">
				<TR>
					<TD style="WIDTH: 126px" align="right"><asp:label id="Label11" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" runat="server" Width="80px">Cod. Línea:</asp:label></TD>
					<TD><asp:textbox id="txtcodlin" Font-Names="Gill Sans MT" Font-Size="12pt" 
                            runat="server" Width="160px"
							BorderWidth="1px" ForeColor="Black" BorderStyle="Groove" Enabled="False" BackColor="AliceBlue"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<table id="Table2" align="center" bgcolor="#ffffcc" border="1" 
                bordercolor="#ff9900" cellpadding="0" cellspacing="0" class="CSSTableGenerator" 
                style="WIDTH: 873px; HEIGHT: 151px">
                <tr>
                    <td align="right" class="style10">
                        &nbsp;</td>
                    <td style="WIDTH: 238px">
                        &nbsp;</td>
                    <td align="right" style="WIDTH: 116px">
                        &nbsp;</td>
                    <td style="WIDTH: 264px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style10">
                        <asp:Label ID="Label2" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="80px">Num. Línea:</asp:Label>
                    </td>
                    <td style="WIDTH: 238px">
                        <asp:TextBox ID="txtnrolin" runat="server" BackColor="AliceBlue" 
                            BorderStyle="Groove" BorderWidth="1px" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Black" Width="120px"></asp:TextBox>
                    </td>
                    <td align="right" style="WIDTH: 116px">
                        <asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="80px">Descripción:</asp:Label>
                    </td>
                    <td style="WIDTH: 264px">
                        <asp:TextBox ID="txtdeslin" runat="server" BorderStyle="Groove" 
                            BorderWidth="1px" Font-Names="Gill Sans MT" Font-Size="12pt" Width="224px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style11">
                        <asp:Label ID="Label23" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="130px">Tasa Mínima:</asp:Label>
                    </td>
                    <td style="WIDTH: 238px; HEIGHT: 24px">
                        <asp:TextBox ID="txttasamin" runat="server" 
                            BorderStyle="Groove" BorderWidth="1px" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="80px" Enabled="False"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator5" runat="server" 
                            ControlToValidate="txttasamin" ErrorMessage="RangeValidator" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" Height="15px" MaximumValue="200" 
                            MinimumValue="0" Type="Double" Width="110px">Valor Inválido</asp:RangeValidator>
                    </td>
                    <td align="right" style="WIDTH: 116px; HEIGHT: 24px">
                        <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="128px">Tasa Máxima:</asp:Label>
                    </td>
                    <td style="WIDTH: 264px; HEIGHT: 24px">
                        <asp:TextBox ID="txttasamax" runat="server" 
                            BorderStyle="Groove" BorderWidth="1px" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="80px" Enabled="False"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator6" runat="server" 
                            ControlToValidate="txttasamax" ErrorMessage="RangeValidator" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" Height="15px" MaximumValue="200" 
                            MinimumValue="0" Type="Double" Width="123px">Valor Inválido</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style11">
                        <asp:Label ID="Label4" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="142px">Tasa Default:</asp:Label>
                    </td>
                    <td style="WIDTH: 238px; HEIGHT: 24px">
                        <asp:TextBox ID="txttasa" runat="server" BorderStyle="Groove" BorderWidth="1px" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" Width="80px" Enabled="False"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" 
                            ControlToValidate="txttasa" ErrorMessage="RangeValidator" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Height="15px" MaximumValue="200" MinimumValue="0" Type="Double" 
                            Width="114px">Valor Inválido</asp:RangeValidator>
                    </td>
                    <td align="right" style="WIDTH: 116px; HEIGHT: 24px">
                        <asp:Label ID="Label5" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="107px">Mora:</asp:Label>
                    </td>
                    <td style="WIDTH: 264px; HEIGHT: 24px">
                        <asp:TextBox ID="txtmora" runat="server" BorderStyle="Groove" BorderWidth="1px" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" Width="80px" Enabled="False"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" 
                            ControlToValidate="txtmora" ErrorMessage="RangeValidator" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Height="15px" MaximumValue="999" MinimumValue="0" Type="Double" 
                            Width="136px">Valor Inválido</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style10">
                        <asp:Label ID="Label6" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="125px">Monto min.</asp:Label>
                    </td>
                    <td style="WIDTH: 238px">
                        <asp:TextBox ID="txtliminf" runat="server" 
                            BorderStyle="Groove" BorderWidth="1px" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="88px" Enabled="False" EnableTheming="True"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator3" runat="server" 
                            ControlToValidate="txtliminf" ErrorMessage="RangeValidator" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" MaximumValue="1000000000" MinimumValue="0" 
                            Type="Double" Width="112px">Valor Inválido</asp:RangeValidator>
                    </td>
                    <td align="right" style="WIDTH: 116px">
                        <asp:Label ID="Label7" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="127px">Monto 
                        max</asp:Label>
                    </td>
                    <td align="left" style="WIDTH: 264px">
                        <asp:TextBox ID="txtlimsup" runat="server" 
                            BorderStyle="Groove" BorderWidth="1px" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="112px" Enabled="False"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:RangeValidator ID="RangeValidator4" runat="server" 
                            ControlToValidate="txtlimsup" ErrorMessage="RangeValidator" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" MaximumValue="1000000000" MinimumValue="0" 
                            Type="Double" Width="111px">Valor Inválido</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style10">
                        <asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="182px">Plazo Minimo (en meses)</asp:Label>
                    </td>
                    <td style="WIDTH: 238px">
                        <asp:TextBox ID="txtplazomin" runat="server" 
                            BorderStyle="Groove" BorderWidth="1px" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="88px" Enabled="False"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator7" runat="server" 
                            ControlToValidate="txtplazomin" ErrorMessage="RangeValidator" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" MaximumValue="1000000000" MinimumValue="0" 
                            Type="Double" Width="123px" Height="23px">Valor Inválido</asp:RangeValidator>
                    </td>
                    <td align="right" style="WIDTH: 116px">
                        <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="192px">Plazo Maximo (en meses)</asp:Label>
                    </td>
                    <td align="left" style="WIDTH: 264px">
                        <asp:TextBox ID="txtplazomax" runat="server" 
                            BorderStyle="Groove" BorderWidth="1px" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="88px" Enabled="False"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator8" runat="server" 
                            ControlToValidate="txtplazomax" ErrorMessage="RangeValidator" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" MaximumValue="1000000000" MinimumValue="0" 
                            Type="Double" Width="122px">Valor Inválido</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style10">
                        <asp:Label ID="Label30" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="182px">No Cuotas:</asp:Label>
                    </td>
                    <td style="WIDTH: 238px">
                        <asp:TextBox ID="txtncuotas" runat="server" AutoPostBack="True" 
                            BorderStyle="Groove" BorderWidth="1px" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="88px" Enabled="False">0</asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator9" runat="server" 
                            ControlToValidate="txtncuotas" ErrorMessage="RangeValidator" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" MaximumValue="1000000000" MinimumValue="0" 
                            Type="Double" Width="123px" Height="23px">Valor Inválido</asp:RangeValidator>
                    </td>
                    <td align="right" style="WIDTH: 116px">
                        <asp:Label ID="Label31" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="182px">Monto Cuota:</asp:Label>
                    </td>
                    <td align="left" style="WIDTH: 264px">
                        <asp:TextBox ID="txtnmoncuo" runat="server" AutoPostBack="True" 
                            BorderStyle="Groove" BorderWidth="1px" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="88px" Enabled="False">0</asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator10" runat="server" 
                            ControlToValidate="txtnmoncuo" ErrorMessage="RangeValidator" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" MaximumValue="1000000000" MinimumValue="0" 
                            Type="Double" Width="122px">Valor Inválido</asp:RangeValidator>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="style12">
                <tr>
                    <td align="center">
			<asp:checkbox id="chqactivar" Font-Names="Gill Sans MT" Font-Size="12pt" runat="server" Width="113px"
				Text="Activar Línea" EnableViewState="False" Checked="True"></asp:checkbox>
		            </td>
                    <td align="center">
			<asp:checkbox id="chqRevolvente" Font-Names="Gill Sans MT" Font-Size="12pt" runat="server" Width="190px"
				Text="Linea Revolvente" EnableViewState="False" AutoPostBack="True"></asp:checkbox>
			<asp:checkbox id="lliva" Font-Names="Gill Sans MT" Font-Size="12pt" runat="server" Width="190px"
				Text="Aplica IVA a Interes" EnableViewState="False" AutoPostBack="True" Checked="True"></asp:checkbox>
		            </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="style9">
                <tr>
                    <td>
                        <INPUT id="btnAplicar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
				type="button" runat="server" visible="False">&nbsp;&nbsp;&nbsp;&nbsp; <INPUT id="btnAdiciona" 
                            type="button" runat="server" 
                            style="BACKGROUND-IMAGE: url('Web/jpgs/btn_insertar_b.jpg'); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 61px; BACKGROUND-COLOR: transparent">&nbsp;&nbsp; </td>
                    <td>
                        <INPUT id="btnGraba" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server" onclick="return btnGraba_onclick()">&nbsp;&nbsp;&nbsp;&nbsp;
                        <INPUT id="btnCancela" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
				type="button" name="Button2" runat="server"></td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 18px">
			&nbsp;</TD>
	</TR>
	</TABLE>
        </td>
    </tr>
</table>

