<%@ control language="vb" autoeventwireup="false" inherits="WbUsBalance, App_Web_yl8dokps" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<script type="text/javascript">
    function SoloNumeros(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode == 08 || charCode == 32 || charCode == 45 || charCode == 46)
            return true;
        else if (charCode >= 48 && charCode <= 57)
            return true;

        return false;
    }


    function CalculaTotales()
    {
        var Ventas,CxC,OtrosIngresos,CostoVenta,GastosGen,GastosFin,Impuestos,Imprevistos;
        var Ingresos,Egresos,Disponible;
        var Efectivo,CuentasCobrar,Inventario,Fijo,OtrosActivos,Circulante;
        var Activo,Pasivo;
        var CxPagar,OxPagar,Prestamos,Patrimonio,PasivoxPatrimonio;
        
        Ventas=parseFloat(document.getElementById("WbUsBalance1_TextBox1").value);
        CxC=parseFloat(document.getElementById("WbUsBalance1_TextBox4").value);
        OtrosIngresos=parseFloat(document.getElementById("WbUsBalance1_TextBox31").value);
        
        if(isNaN(Ventas))
        Ventas=0;
        if(isNaN(CxC))
        CxC=0;
        if(isNaN(OtrosIngresos))
        OtrosIngresos=0;
        
        
        Ingresos=Math.round( Ventas+CxC+OtrosIngresos,2);
        document.getElementById("WbUsBalance1_Txtingresos").value=Ingresos;
        
        CostoVenta=parseFloat(document.getElementById("WbUsBalance1_TextBox12").value);
        GastosGen=parseFloat(document.getElementById("WbUsBalance1_TextBox13").value);
        GastosFin=parseFloat(document.getElementById("WbUsBalance1_TextBox14").value);
        Impuestos=parseFloat(document.getElementById("WbUsBalance1_TextBox15").value);
        Imprevistos=parseFloat(document.getElementById("WbUsBalance1_TextBox17").value);
        
        if(isNaN(CostoVenta))
        CostoVenta=0;
        if(isNaN(GastosGen))
        GastosGen=0;
        if(isNaN(GastosFin))
        GastosFin=0;
        if(isNaN(Impuestos))
        Impuestos=0;
        if(isNaN(Imprevistos))
        Imprevistos=0;
        
        Egresos= Math.round( CostoVenta+GastosGen+GastosFin+Impuestos+Imprevistos,2); 
        document.getElementById("WbUsBalance1_Txtegresos").value=Egresos;
        
        Disponible= Math.round( Ingresos-Egresos,2);
        document.getElementById("WbUsBalance1_TextBox27").value= Disponible;
        
        Efectivo=parseFloat(document.getElementById("WbUsBalance1_TextBox8").value);
        CuentasCobrar=parseFloat(document.getElementById("WbUsBalance1_TextBox9").value);
        Inventario=parseFloat(document.getElementById("WbUsBalance1_TextBox26").value);
        Fijo=parseFloat(document.getElementById("WbUsBalance1_TextBox10").value);
        OtrosActivos=parseFloat(document.getElementById("WbUsBalance1_TextBox11").value);
        
        //Circulante=parseFloat(document.getElementById("WbUsBalance1_TextBox25").value);
        
        
        if(isNaN(Efectivo))
        Efectivo=0;
        if(isNaN(CuentasCobrar))
        CuentasCobrar=0;
        if(isNaN(Inventario))
        Inventario=0;
        if(isNaN(Fijo))
        Fijo=0;
        if(isNaN(OtrosActivos))
        OtrosActivos=0;
        if(isNaN(Circulante))
        Circulante=0;
        
        Circulante=Efectivo+CuentasCobrar+Inventario;
        
        
        Activo=Fijo+OtrosActivos+Circulante;
        
        document.getElementById("WbUsBalance1_TextBox5").value=Activo;
        
        
        CxPagar=parseFloat(document.getElementById("WbUsBalance1_TextBox21").value);
        OxPagar=parseFloat(document.getElementById("WbUsBalance1_TextBox20").value);
        Prestamos=parseFloat(document.getElementById("WbUsBalance1_TextBox19").value);
        
        if(isNaN(CxPagar))
        CxPagar=0;
        if(isNaN(OxPagar))
        OxPagar=0;
        if(isNaN(Prestamos))
        Prestamos=0;
        
        Pasivo=CxPagar+OxPagar+Prestamos;
               
        document.getElementById("WbUsBalance1_TextBox22").value=Pasivo;        
        
        Patrimonio=Activo-Pasivo;
        
        document.getElementById("WbUsBalance1_TextBox18").value=Patrimonio;
        
        PasivoxPatrimonio=Pasivo+Patrimonio;
        
        document.getElementById("WbUsBalance1_TextBox23").value=PasivoxPatrimonio;
        
    }//fin
</script>
<style type="text/css">
    .style11
    {
        height: 35px;
        width: 450px;
    }
    #Table4
    {
        width: 103%;
    }
    .style14
    {
        height: 25px;
        width: 144px;
    }
    .style15
    {
        height: 24px;
        width: 144px;
    }
    .style16
    {
        height: 23px;
        width: 144px;
    }
    .style23
    {
        width: 92%;
    }
    .style24
    {
        width: 135px;
    }
    .style25
    {
        width: 85px;
    }
    #Table3
    {
        width: 42%;
        height: 52px;
    }
    .style28
    {
        width: 170px;
        height: 20px;
    }
    .style29
    {
        width: 126px;
        height: 20px;
    }
    .style30
    {
        width: 99px;
        height: 20px;
    }
    .style31
    {
        height: 20px;
    }
    .style32
    {
        width: 153%;
    }
    .style44
    {
        width: 68%;
    }
    .CSSTableGenerator
    {
        width: 331px;
    }
    .style45
    {
        width: 80%;
    }
    .style46
    {
        height: 86px;
    }
    .style47
    {
        height: 50px;
    }
    .style48
    {
        height: 15px;
    }
    
    .style49
    {
        height: 42px;
    }
    
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 602px; HEIGHT: 336px; "
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">ESTADOS FINANCIEROS</P>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; " class="style47">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" align="center">
				<TR>
					<TD style="FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff" 
                        class="style28">&nbsp;</TD>
					<TD style="BACKGROUND-COLOR: #ffffff" align="center" class="style29">&nbsp;</TD>
					<TD style="BACKGROUND-COLOR: #ffffff" class="style30">&nbsp;</TD>
					<TD style="BACKGROUND-COLOR: #ffffff" class="style31">&nbsp;</TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff" 
                        class="style28">
                                    <asp:Label ID="Label36" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                        Text="Fecha de Balance:" Width="121px"></asp:Label>
                                </TD>
					<TD style="BACKGROUND-COLOR: #ffffff" align="left" class="style29">
                        <asp:textbox id="TxtdFecha" Font-Names="Gill Sans MT" runat="server" 
                            Width="88px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" AutoPostBack="True" BorderColor="#2E6A99"></asp:textbox>
                        <cc1:CalendarExtender ID="TxtdFecha_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="TxtdFecha">
                        </cc1:CalendarExtender>
                        <cc1:MaskedEditExtender ID="TxtdFecha_MaskedEditExtender" runat="server" 
                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="TxtdFecha">
                        </cc1:MaskedEditExtender>
                    </TD>
					<TD style="BACKGROUND-COLOR: #ffffff" class="style30">
                        <asp:textbox id="txtfuente" 
                            Font-Names="Gill Sans MT" runat="server" Width="93px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox></TD>
					<TD style="BACKGROUND-COLOR: #ffffff" class="style31">
                        <asp:textbox id="txtcodcli" 
                            Font-Names="Gill Sans MT" runat="server" Width="168px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox></TD>
				</TR>
				</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; " class="style48">
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" border="0" align="center">
				<TR>
					<TD style="WIDTH: 300px; HEIGHT: 18px" align="center">
                        <table cellpadding="0" cellspacing="0" class="style32">
                            <tr>
                                <td align="right">
                                    <asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Cliente:"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:textbox id="txtnomcli" Font-Names="Gill Sans MT" runat="server" 
                                        Width="424px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD style="WIDTH: 300px; HEIGHT: 22px" align="right">
                        <table cellpadding="0" cellspacing="0" class="style23" align="left">
                            <tr>
                                <td class="style25">
                                    &nbsp; &nbsp;
                                    <asp:Label ID="Label8" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                        Text="Balance:"></asp:Label>
                                </td>
                                <td class="style24">
						<asp:dropdownlist id="ddlbalance" Font-Names="Calibri" runat="server" Width="93px" 
                                        Font-Size="10pt" Height="42px"></asp:dropdownlist>
                                </td>
                                <td>
                                    <asp:Button ID="btbuscar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Buscar" Width="85px" Font-Size="10pt" />
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				</TABLE>
			</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px">
			<table align="center" cellpadding="0" cellspacing="0" class="style44">
                <tr>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                            <tr>
                                <td style="FONT-SIZE: 9pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff; font-weight: bold;">
                                    <asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Ingresos Mensuales" Font-Bold="True" ForeColor="#E8E8E8"></asp:Label>
                                </td>
                                <td>
                        <asp:TextBox ID="Txtingresos" runat="server" Enabled="False" 
                            Font-Names="Calibri" Font-Size="10pt" Height="17px" Width="79px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Ventas al Contado:" Visible="False"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" BorderWidth="1px" Enabled="False" 
                                        Font-Names="Gill Sans MT" Height="21px" Width="79px" Visible="False" 
                                        BorderColor="#2E6A99"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator2" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox1">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label13" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Ventas: "></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox4" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt" Enabled="False"
							BorderWidth="1px" TabIndex="2"  onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99" ></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator3" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox4">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Otros Ingresos:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox31" Font-Names="Gill Sans MT" runat="server" 
                            Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="3" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator4" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox31">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label21" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Disponible:"></asp:Label>
                                </td>
                                <td>
                                    <asp:textbox id="TextBox27" Font-Names="Gill Sans MT" ForeColor="Black" 
                                        runat="server" Width="80px"
							Font-Size="10pt" BackColor="White" Enabled="False" BorderWidth="1px" AutoPostBack="True" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                            <tr>
                                <td style="FONT-SIZE: 9pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff; font-weight: bold;">
                                    <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Gastos Mensuales" Font-Bold="True" ForeColor="#E8E8E8"></asp:Label>
                                </td>
                                <td>
                        <asp:TextBox ID="Txtegresos" runat="server" Enabled="False" 
                            Font-Names="Calibri" Font-Size="10pt" Height="18px" Width="80px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label15" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Costo de Venta:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox12" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="4" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator5" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox12">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label16" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Gastos Generales:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox13" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="5" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator6" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox13">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label17" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Gastos Financieros:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox14" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="6" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator7" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox14">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label18" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Impuestos:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox15" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="7" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator8" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox15">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label19" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="% de Confiabilidad:"></asp:Label>
                                </td>
                                <td>
                                    <asp:textbox id="TextBox16" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="8" onkeypress="return SoloNumeros(event)" MaxLength="3" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator9" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="100" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox16">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label20" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Imprevistos:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox17" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="9" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator10" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox17">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; " class="style46">
			<table align="center" cellpadding="0" cellspacing="0" class="style45">
                <tr>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                            <tr>
                                <td style="FONT-SIZE: 9pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff; font-weight: bold;">
                                    <asp:Label ID="Label22" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="ACTIVO" Font-Bold="True" ForeColor="#E8E8E8"></asp:Label>
                                </td>
                                <td>
                                    <asp:textbox id="TextBox5" Font-Names="Gill Sans MT" ForeColor="Black" 
                                        runat="server" Width="80px"
							Font-Size="10pt" BackColor="White" Enabled="False" BorderWidth="1px" AutoPostBack="True" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Activo Circulante:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox25" 
                            Font-Names="Gill Sans MT" ForeColor="Black" runat="server" Width="80px"
							Font-Size="10pt" BackColor="White" BorderWidth="1px" TabIndex="10" onkeypress="return SoloNumeros(event)" 
                                        Enabled="False" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator14" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox25">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label27" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Efectivo y Bancos:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox8" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt" Enabled="False"
							BorderWidth="1px" TabIndex="11" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator16" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox8">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label29" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Cuentas por cobrar:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox9" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt" Enabled="False"
							BorderWidth="1px" TabIndex="12" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator18" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox9">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label30" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Inventario:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox26" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="13" onkeypress="return SoloNumeros(event)" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator20" Font-Names="Gill Sans MT" runat="server" 
                                        Width="85px" Font-Size="10pt"
							Height="16px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" 
                                        ControlToValidate="TextBox26">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label31" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Activo Fijo:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox10" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="14" onkeypress="return SoloNumeros(event)" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator22" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox10">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label32" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Otros Activos:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox11" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="15" onkeypress="return SoloNumeros(event)" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator24" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox11">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                            <tr>
                                <td style="FONT-SIZE: 9pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff; font-weight: bold;">
                                    <asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="PASIVO Y PATRIMONIO" Font-Bold="True" ForeColor="#E8E8E8"></asp:Label>
                                </td>
                                <td>
                                    <asp:textbox id="TextBox23" Font-Names="Gill Sans MT" runat="server" 
                                        Width="80px" Font-Size="10pt"
							BackColor="White" Enabled="False" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Pasivo:"></asp:Label>
                                </td>
                                <td>
                                    <asp:textbox id="TextBox22" Font-Names="Gill Sans MT" runat="server" 
                                        Width="80px" Font-Size="10pt"
							BackColor="White" Enabled="False" BorderWidth="1px" onkeypress="return SoloNumeros(event)" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator15" Font-Names="Gill Sans MT" runat="server" 
                                        Width="85px" Font-Size="10pt"
							Height="16px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" 
                                        ControlToValidate="TextBox22">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label28" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="C * Pagar Proveedores:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox21" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="16" onkeypress="return SoloNumeros(event)" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator17" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox21">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label33" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Otras Cuentas * pagar:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox20" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="17" onkeypress="return SoloNumeros(event)" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator19" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox20">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label34" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Otros Prestamos:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox19" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" TabIndex="18" onkeypress="return SoloNumeros(event)" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator21" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox19">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label35" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Patrimonio:"></asp:Label>
                                </td>
                                <td>
                        <asp:textbox id="TextBox18" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt"
							BackColor="White" Enabled="False" BorderWidth="1px" TabIndex="19" onkeypress="return SoloNumeros(event)" 
                                        BorderColor="#2E6A99"></asp:textbox>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator23" Font-Names="Gill Sans MT" runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TextBox18">Valor Inválido</asp:rangevalidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; " 
            align="center" class="style49">
                        <asp:Button ID="btncalcula" runat="server" 
                    Font-Names="Gill Sans MT" Text="Calcular Previa" Width="100px" Height="30px" />
                        <asp:textbox id="Txtcomodin" 
                            Font-Names="Gill Sans MT" runat="server" Width="78px" Font-Size="10pt"
							BorderWidth="1px" Visible="False" Height="17px"></asp:textbox></TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px" 
            align="center">
            <table 
                    cellpadding="0" cellspacing="0" class="style11">
                <tr>
                    <td class="style15">
                        <asp:Button ID="btnuevo" runat="server" 
                    Font-Names="Gill Sans MT" Text="Nuevo" Width="85px" Height="25px" />
                    </td>
                    <td class="style16">
                        <asp:Button ID="btgrabar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Grabar" Width="85px" style="height: 28px" />
                    </td>
                    <td class="style14">
                        <asp:Button ID="btini" runat="server" 
                    Font-Names="Gill Sans MT" Text="Inicializar" Width="85px" 
                            style="margin-left: 0px" />
                    </td>
                    <td>
                        <asp:Button ID="btimprimir" runat="server" 
                    Font-Names="Gill Sans MT" Text="Imprimir" Width="85px" Height="25px" />
                    </td>
                </tr>
                </table>
		</TD>
	</TR>
	</TABLE>
