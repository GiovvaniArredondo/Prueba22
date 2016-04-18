<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="wbUOtrosPagos, App_Web_v6ddqlgy" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<style type="text/css">

    .style1
    {
        width: 67px;
        height: 31px;
    }
    .style2
    {
        width: 57px;
        height: 31px;
    }
    .style3
    {
        height: 41px;
    }
    .style11
    {
        height: 8px;
        width: 177px;
    }
    .style12
    {
        height: 6px;
        width: 177px;
    }
    .style16
    {
        width: 151px;
        height: 34px;
    }
    .style17
    {
        height: 34px;
        width: 177px;
    }
    .style19
    {
        height: 8px;
        width: 151px;
    }
    .style20
    {
        height: 6px;
        width: 151px;
    }
    .style21
    {
        height: 30px;
        width: 151px;
    }
    .style22
    {
        height: 30px;
        width: 177px;
    }
    .style23
    {
        height: 20px;
        text-align: left;
    }
    .style24
    {
        height: 39px;
        width: 151px;
    }
    .style25
    {
        height: 39px;
        width: 177px;
    }
    .style26
    {
        height: 37px;
        width: 151px;
    }
    .style27
    {
        height: 37px;
        width: 177px;
    }
    .style28
    {
        width: 139px;
        height: 34px;
    }
    .style29
    {
        width: 243px;
        height: 34px;
    }
    .style30
    {
        height: 34px;
    }
</style>
  <script src="js/jquery.js" type="text/javascript"></script>    
  <script type="text/javascript" src="js/lib.js"></script>
  <script type="text/javascript">

      function ActivaNumeroClientes() {

        var control = document.getElementById("<%= txtNumeroClientes.ClientID%>");
        var control2 = document.getElementById("<%= txtBanco.ClientID%>");
        var valor= document.getElementById("<%= ddlingreso.ClientID%>").options[document.getElementById("<%= ddlingreso.ClientID%>").selectedIndex].value

        if (valor == "RF") {

            control.disabled = false
            control2.disabled = false
        }
        else {

            control.value = ""
            control.disabled = true
            control2.value = ""
            control2.disabled = true
        }        

      }

    function ObtieneTotal() {
        var TipoIngreso = document.getElementById("<%= ddlingreso.ClientID%>").options[document.getElementById("<%= ddlingreso.ClientID%>").selectedIndex].value;
        var NumeroClientes = document.getElementById("<%= txtNumeroClientes.ClientID%>").value;
        var CodigoCliente = document.getElementById("<%= txtcnrocta.ClientID%>").value;
        var Producto = document.getElementById("<%= ddlproducto.ClientID%>").options[document.getElementById("<%= ddlproducto.ClientID%>").selectedIndex].value;
        
        $.ajax({
            type: "POST",
            url: "ajax/CalculaOtrosIngresos.ashx",
            data: "TipoIngreso=" + TipoIngreso + "&NumeroClientes=" + NumeroClientes + "&Producto=" + Producto+"&CodigoCliente="+CodigoCliente,
            success: function(html) {                
                document.getElementById("<%= txtaldia.ClientID%>").value = parseFloat(html);
            }
        });
    }



    function SoloNumeros(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode == 08 || charCode == 32 || charCode == 45)
            return true;
        else if (charCode >= 48 && charCode <= 57)
            return true;

        return false;
    }

    function SoloLetras(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode == 08 || charCode == 32 || charCode == 45)
            return true;
        else if (charCode >= 65 && charCode <= 90)
            return true;
        else if (charCode >= 97 && charCode <= 122)
            return true;

        return false;
    }


    function SoloLetras_Numeros(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode == 08 || charCode == 32 || charCode == 45)
            return true;
        else if (charCode >= 48 && charCode <= 57)
            return true;
        else if (charCode >= 65 && charCode <= 90)
            return true;
        else if (charCode >= 97 && charCode <= 122)
            return true;

        return false;
    }


</script>

<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 494px; HEIGHT: 330px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="494" border="0">
	<TR>
		<TD align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">OTROS INGRESOS FINANCIEROS</P>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table3" style="WIDTH: 438px; HEIGHT: 56px" cellSpacing="0" cellPadding="0" width="438"
				border="0">
				<TR>
					<TD align="right" class="style28"><asp:label id="Label4" runat="server" 
                            Width="101px" Height="16px" Font-Names="Verdana" Font-Size="8pt">Codigo Cliente:</asp:label></TD>
					<TD class="style29">
                        <asp:textbox id="txtcCodcli_" tabIndex="5" runat="server" 
                            Width="152px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" BorderColor="#2E6A99" BorderWidth="1px" Height="25px"></asp:textbox></TD>
					<TD class="style30">
						</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 139px" align="right">
                        <asp:label id="Label32" runat="server" 
                            Width="120px" Height="16px" Font-Names="Verdana" Font-Size="8pt">Codigo Prestamo:</asp:label></TD>
					<TD style="WIDTH: 243px"><asp:textbox id="txtcnrocta" tabIndex="5" runat="server" 
                            Width="152px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" BorderColor="#2E6A99" BorderWidth="1px" Height="25px"></asp:textbox></TD>
					<TD>
						<asp:TextBox ID="TxtFecha" runat="server" Enabled="False" Visible="False" 
                            Width="57px"></asp:TextBox>
                    </TD>
				</TR>
				<TR>
					<TD style="WIDTH: 139px" align="right"><asp:label id="Label9" runat="server" Width="67px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Nombre:  </asp:label></TD>
					<TD style="WIDTH: 243px"><asp:textbox id="txtnomcli" runat="server" Width="232px" 
                            Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" BorderColor="#2E6A99" BorderWidth="1px" Height="25px"></asp:textbox></TD>
					<TD>
						<P align="center"><INPUT id="btnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
								type="button" runat="server"></P>
					</TD>
				</TR>
				</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center" style="text-align: left">
                                <asp:label id="Label33" runat="server" 
                            Width="300px" Height="16px" Font-Names="Gill Sans MT" Font-Size="11pt" 
                                    Font-Bold="False" ForeColor="#000099">Detalle de seguros</asp:label>
		</TD>
	</TR>
	<TR>
		<TD align="center">
                                <asp:GridView ID="Grid_Garantia" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                                    <Columns>
                                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                            <ControlStyle Font-Names="Gill Sans MT" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:CommandField>
                                        <asp:BoundField DataField="Nro" HeaderText="Nro">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Tipo" HeaderText="Tipo">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" 
                            DataFormatString="{0:dd-MM-yyyy}">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Garantia" HeaderText="Garantia" 
                            DataFormatString="{0:###,##0.00}">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Tasacion" HeaderText="Tasacion" 
                            DataFormatString="{0:###,##0.00}">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
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
		<TD align="center" class="style23">
		    <asp:label id="Label34" runat="server" 
                            Width="300px" Height="16px" Font-Names="Gill Sans MT" 
                Font-Size="11pt" Font-Bold="False" ForeColor="#000099">Detalle de Otros Ingresos Aplicados</asp:label>
		</TD>
	</TR>
	<TR>
		<TD align="center" class="style23">
                                <asp:GridView ID="Grid_Seguro" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                                    <Columns>                                        
                                        <asp:BoundField DataField="No" HeaderText="Nro">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>                                        
                                        <asp:BoundField DataField="dfecpag" HeaderText="Fecha" 
                            DataFormatString="{0:dd-MM-yyyy}">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>                                        
                                        <asp:BoundField DataField="Tipo" HeaderText="Tipo">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="left" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="nmonto" HeaderText="Monto Seguro" 
                            DataFormatString="{0:###,##0.00}">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
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
		<TD>
			<TABLE id="Table4" style="WIDTH: 430px; HEIGHT: 107px" cellSpacing="0" 
                cellPadding="0" align="center" border="0">
				<TR>
					<TD style="HEIGHT: 127px" align="center">
						<TABLE id="Table6" style="WIDTH: 371px; HEIGHT: 357px" cellSpacing="0" 
                            cellPadding="0" align="center" border="0">
							<TR>
								<TD align="right" class="style16">
                                    <asp:label id="Label22" runat="server" 
                            Width="67px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Producto:  </asp:label>
                                </TD>
								<TD class="style17">
                                                                <asp:dropdownlist id="ddlproducto" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" Font-Size="10pt" Enabled="False"></asp:dropdownlist>
                                </TD>
							</TR>
							<TR>
								<TD align="right" class="style16">
                                    <asp:Label ID="Label19" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Fecha :"></asp:Label>
                                </TD>
								<TD class="style17">
                                    <asp:TextBox ID="TextBox2" runat="server" Width="91px" Height="25px" 
                                        BorderColor="#2E6A99" BorderWidth="1px" Font-Names="Calibri" 
                                        Font-Size="10pt"></asp:TextBox>
                                    <cc1:MaskedEditExtender ID="TextBox2_MaskedEditExtender" runat="server" 
                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                        Mask="99/99/9999" MaskType="Date" TargetControlID="TextBox2">
                                    </cc1:MaskedEditExtender>
                                    <cc1:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="TextBox2">
                                    </cc1:CalendarExtender>
                                </TD>
							</TR>
							<TR>
								<TD class="style19" align="right">
                                    <asp:Label ID="Label18" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="No. de Recibo:"></asp:Label>
                                </TD>
								<TD class="style11">
                                    <asp:TextBox ID="TextBox1" runat="server" BorderColor="#2E6A99" 
                                        BorderWidth="1px" Height="25px" onkeypress="return SoloNumeros(event)"></asp:TextBox>
                                </TD>
							</TR>
							<TR>
								<TD class="style19" align="right">
                                    <asp:Label ID="Label23" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Tipo de Ingreso:"></asp:Label>
                                </TD>
								<TD class="style11">
                                                                <asp:dropdownlist id="ddlingreso" runat="server" 
                                                                    Font-Names="Calibri" Width="218px" 
                                        Font-Size="10pt" onchange="ActivaNumeroClientes()" Height="22px" Enabled="False"></asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD class="style21" align="right">
                                    <asp:Label ID="Label28" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Sucursal:"></asp:Label>
                                </TD>
								<TD class="style22">
                                                                <asp:dropdownlist id="ddlcodofi" runat="server" 
                            Width="213px" Font-Names="calibri" Font-Size="10pt" Height="22px" Enabled="False"></asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD class="style21" align="right">
                                    <asp:Label ID="Label26" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Fondo:" Visible="False"></asp:Label>
                                </TD>
								<TD class="style22">
						<asp:dropdownlist id="cmbFondos" Font-Size="10pt" Font-Names="calibri" runat="server"
							Width="217px" Height="16px" Visible="False"></asp:dropdownlist>
                                 
                                  
                                            </TD>
							</TR>
							<TR>
								<TD class="style21" align="right">
                                    <asp:Label ID="Label27" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Banco:"></asp:Label>
                                </TD>
								<TD class="style22">
						<asp:dropdownlist id="cmbbanco" runat="server" Width="217px" Height="26px" 
                            Font-Names="calibri" Font-Size="10pt"></asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD class="style16" align="right">
                                    <asp:Label ID="Label24" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Numero de Clientes:" Visible="False"></asp:Label>
                                </TD>
								<TD class="style17">
                                    <asp:TextBox ID="txtNumeroClientes" runat="server" Enabled="False" 
                                        Visible="False" BorderColor="#2E6A99" BorderWidth="1px" Height="25px"></asp:TextBox>
                                </TD>
							</TR>
							<TR>
								<TD class="style20" align="right">
                                    <asp:Label ID="Label25" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Nombre Banco/Grupo" Visible="False"></asp:Label>
                                </TD>
								<TD class="style12">
                                    <asp:TextBox ID="txtBanco" runat="server" Enabled="False" Visible="False" 
                                        BorderColor="#2E6A99" BorderWidth="1px" Height="25px"></asp:TextBox>
                                </TD>
							</TR>
							<TR>
								<TD class="style26" align="right">
                                    <asp:Label ID="Label31" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Nro Garantía:"></asp:Label>
                                </TD>
								<TD class="style27">
                                    <asp:TextBox ID="txtcNrogar" runat="server" Enabled="False" 
                                        BorderColor="#2E6A99" BorderWidth="1px" Height="25px"></asp:TextBox>
                                </TD>
							</TR>
							<TR>
								<TD class="style20" align="right">
                                    <asp:Label ID="Label29" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Codigo Garantía:"></asp:Label>
                                </TD>
								<TD class="style12">
                                    <asp:TextBox ID="txtcCodgar" runat="server" Enabled="False" 
                                        BorderColor="#2E6A99" BorderWidth="1px" Height="25px"></asp:TextBox>
                                </TD>
							</TR>
							<TR>
								<TD class="style24" align="right">
                                    <asp:Label ID="Label30" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Monto Garantía:"></asp:Label>
                                </TD>
								<TD class="style25">
                                    <asp:TextBox ID="txtnmontoGar" runat="server" Enabled="False" 
                                        BorderColor="#2E6A99" BorderWidth="1px" Height="25px">0.00</asp:TextBox>
                                </TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 1px" align="center" colspan="2">
                                    &nbsp;</TD>
							</TR>
							</TABLE>
						</TD>
				</TR>
				<TR>
					<TD align="center">
						<TABLE id="Table7" borderColor="#ff9900" cellSpacing="0" cellPadding="0" bgColor="#CCFF33"
							border="2" style="width: 62%; margin-right: 0px;">
							<TR>
								<TD class="style1"><asp:label id="Label17" runat="server" Width="131px" 
                                        Font-Names="Verdana" Font-Size="8pt" Font-Bold="True" Height="18px">Monto a Pagar:</asp:label></TD>
								<TD class="style2" align="left">
                                    <asp:textbox id="txtaldia" runat="server" 
                                        Width="102px" Font-Names="Verdana" Font-Size="8pt" 
                                        style="margin-left: 6px; margin-right: 0px" BorderColor="#2E6A99" 
                                        BorderWidth="1px" Height="25px"></asp:textbox>                                        
                                        <asp:rangevalidator id="RangeValidator1" runat="server" Width="90px" 
                                        Font-Names="Verdana" Font-Size="8pt"
								ErrorMessage="RangeValidator" ControlToValidate="txtaldia" MaximumValue="1000000.00000" MinimumValue="0"
								Type="Double" Height="16px">Monto  Inválido-</asp:rangevalidator>
                                </TD>
							</TR>
						</TABLE>
						</TD>
				</TR>
				<TR>
					<TD align="center" class="style3">
                        <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Grabar" Width="120px" Height="30px" />
                        <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
                            ConfirmText="Seguro de Aplicar Pago?" Enabled="True" 
                            TargetControlID="Button1">
                        </cc1:ConfirmButtonExtender>
                    &nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Imprimir" Width="120px" Height="30px" style="margin-left: 0px" />
                        &nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Height="31px" 
                            Text="Eliminar" Width="109px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </TD>
				</TR>
				<TR>
					<TD align="center">
                        <asp:textbox id="txttotal" runat="server" Width="16px" 
                            Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtmora" 
                            runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt" 
                            Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtmoncuo" 
                            runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Visible="False"></asp:textbox>
                        <asp:textbox id="txtmon60" runat="server" Width="16px" 
                            Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Height="16px" Visible="False"></asp:textbox>&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:textbox id="txtmon30" runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Height="16px" Visible="False"></asp:textbox>
                        <asp:textbox id="txtdeucap" runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Visible="False"></asp:textbox>
                        <asp:textbox id="txtcapita" runat="server" Width="19px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Visible="False"></asp:textbox>
                        <asp:textbox id="txtinteres" runat="server" Width="28px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Visible="False"></asp:textbox>
                        <asp:textbox id="txtcomisiones" runat="server" Width="16px" 
                            Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Visible="False"></asp:textbox>
                        <asp:textbox id="txtnseguro" 
                            runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Visible="False"></asp:textbox>
                        <asp:textbox id="txtdultpag" 
                            runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Visible="False"></asp:textbox>
                        <asp:textbox id="txtdias" 
                            runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt" 
                            Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txt60" 
                            runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
							Visible="False"></asp:textbox><asp:textbox id="txt30" runat="server" 
                            Width="16px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
							Visible="False"></asp:textbox>
						<asp:textbox id="txtccodcli" runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" Visible="False"></asp:textbox>
						</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
