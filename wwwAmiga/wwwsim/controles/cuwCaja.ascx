<%@ Control Language="vb" AutoEventWireup="false" Inherits="cuwCaja" CodeFile="cuwCaja.ascx.vb" %>
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
        var moneda1, moneda1t;
        var moneda5, moneda5t;
        var moneda10, moneda10t;
        var moneda25, moneda25t;
        var moneda50, moneda50t;
        var moneda100, moneda100t;
        moneda1 = parseFloat(document.getElementById("<%=moneda_1_TextBox.ClientID %>").value);
        moneda5 = parseFloat(document.getElementById("<%=moneda_5_TextBox.ClientID %>").value);
        moneda10 = parseFloat(document.getElementById("<%=moneda_10_TextBox.ClientID %>").value);
        moneda25 = parseFloat(document.getElementById("<%=moneda_25_TextBox.ClientID %>").value);
        moneda50 = parseFloat(document.getElementById("<%=moneda_50_TextBox.ClientID %>").value);
        moneda100 = parseFloat(document.getElementById("<%=moneda_100_TextBox.ClientID %>").value);
        
        if(isNaN(moneda1))
        moneda1=0;
       if (isNaN(moneda5))
        moneda5 = 0;
       if (isNaN(moneda10))
        moneda10 = 0;
      if (isNaN(moneda25))
        moneda25 = 0;
      if (isNaN(moneda50))
        moneda50 = 0;
      if (isNaN(moneda100))
        moneda100 = 0;

    moneda1t = moneda1 * 0.01;
    moneda5t = moneda5 * 0.05;
    moneda10t = moneda10 * 0.10;
    moneda25t = moneda25 * 0.25;
    moneda50t = moneda50 * 0.50;
    moneda100t = moneda100 * 1;
    
        document.getElementById("<%=moneda_1_TextBox0.ClientID %>").value = moneda1t.toFixed(2);
        document.getElementById("<%=moneda_5_TextBox0.ClientID %>").value = moneda5t.toFixed(2);
        document.getElementById("<%=moneda_10_TextBox0.ClientID %>").value = moneda10t.toFixed(2);
        document.getElementById("<%=moneda_25_TextBox0.ClientID %>").value = moneda25t.toFixed(2);
        document.getElementById("<%=moneda_50_TextBox0.ClientID %>").value = moneda50t.toFixed(2);
        document.getElementById("<%=moneda_100_TextBox0.ClientID %>").value = moneda100t.toFixed(2);
        var totalmonedas;
        totalmonedas = moneda1t +  moneda5t +  moneda10t + moneda25t +  moneda50t +  moneda100t ;
        document.getElementById("<%=totalmonedas.ClientID %>").value = totalmonedas.toFixed(2);

        var billete1, billete1t;
        var billete5, billete5t;
        var billete10, billete10t;
        var billete20, billete20t;
        var billete50, billete50t;
        var billete100, billete100t;
        var billete200, billete200t;

        billete1 = parseFloat(document.getElementById("<%=billete_1_TextBox.ClientID %>").value);
        billete5 = parseFloat(document.getElementById("<%=billete_5_TextBox.ClientID %>").value);
        billete10 = parseFloat(document.getElementById("<%=billete_10_TextBox.ClientID %>").value);
        billete20 = parseFloat(document.getElementById("<%=billete_20_TextBox.ClientID %>").value);
        billete50 = parseFloat(document.getElementById("<%=billete_50_TextBox.ClientID %>").value);
        billete100 = parseFloat(document.getElementById("<%=billete_100_TextBox.ClientID %>").value);
        billete200 = parseFloat(document.getElementById("<%=billete_200_TextBox.ClientID %>").value);

        if (isNaN(billete1))
            billete1 = 0;
        if (isNaN(billete5))
            billete5 = 0;
        if (isNaN(billete10))
            billete10 = 0;
        if (isNaN(billete20))
            billete20 = 0;
        if (isNaN(billete50))
            billete50 = 0;
        if (isNaN(billete100))
            billete100 = 0;
        if (isNaN(billete200))
            billete200 = 0;

        billete1t = billete1 * 1;
        billete5t = billete5 * 5;
        billete10t = billete10 * 10;
        billete20t = billete20 * 20;
        billete50t = billete50 * 50;
        billete100t = billete100 * 100;
        billete200t = billete200 * 200;

        document.getElementById("<%=billete_1_TextBox0.ClientID %>").value = billete1t.toFixed(2);
        document.getElementById("<%=billete_5_TextBox0.ClientID %>").value = billete5t.toFixed(2);
        document.getElementById("<%=billete_10_TextBox0.ClientID %>").value = billete10t.toFixed(2);
        document.getElementById("<%=billete_20_TextBox0.ClientID %>").value = billete20t.toFixed(2);
        document.getElementById("<%=billete_50_TextBox0.ClientID %>").value = billete50t.toFixed(2);
        document.getElementById("<%=billete_100_TextBox0.ClientID %>").value = billete100t.toFixed(2);
        document.getElementById("<%=billete_200_TextBox0.ClientID %>").value = billete200t.toFixed(2);

        var totalbilletes, total;
        totalbilletes = billete1t + billete5t + billete10t + billete20t + billete50t + billete100t + billete200t;
        total = totalmonedas + totalbilletes;

        document.getElementById("<%=totalbilletes.ClientID %>").value = totalbilletes.toFixed(2);
        document.getElementById("<%=total.ClientID %>").value = total.toFixed(2);
        
    }//fin
</script>

<style type="text/css">
    .style1
    {
        width: 84%;
        height: 40px;
    }
    .style2
    {
        width: 67%;
    }
    .style3
    {
        height: 58px;
    }
</style>
<head id="Head1" runat="server" />
<TABLE id="Table8" style="border: thin solid highlight; WIDTH: 534px; HEIGHT: 200px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" border="0" DESIGNTIMEDRAGDROP="9">
	<TR>
		<TD style="HEIGHT: 33px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:label id="Label1" runat="server" Width="278px" Font-Bold="True" Font-Size="Medium" Height="15px"
				Font-Names="Verdana" ForeColor="#16387C">CUADRE DEL CAJERO</asp:label></TD>
	</TR>
	<TR>
		<TD align="center" class="style3">&nbsp;
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td align="right">
                        <asp:label id="Label28" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="88px" runat="server">Fecha:</asp:label>
                    </td>
                    <td>
            <asp:textbox id="txtfecha" tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="104px"
				runat="server" BorderWidth="2px" BackColor="Yellow" BorderColor="#003366" 
                            Height="27px" Enabled="False"></asp:textbox>
                        <cc1:MaskedEditExtender ID="txtfecha_MaskedEditExtender" runat="server" 
                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecha">
                        </cc1:MaskedEditExtender>
                        <cc1:CalendarExtender ID="txtfecha_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtfecha">
                        </cc1:CalendarExtender>
                    </td>
                    <td>
                        <asp:rangevalidator id="RangeValidator5" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" Width="88px" runat="server"
				ControlToValidate="txtfecha" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000" 
                            MaximumValue="01/01/3000" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 28px" align="center">
            <table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td>
                        <asp:label id="Label48" Font-Size="10pt" Font-Names="Gill Sans MT" 
                            Height="16px" Width="61px" runat="server">Monedas</asp:label>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style2">
                            <tr>
                                <td>
                        <asp:label id="Label29" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Cantidad</asp:label>
                                </td>
                                <td>
                        <asp:label id="Label30" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Valor Unitario</asp:label>
                                </td>
                                <td>
                        <asp:label id="Label31" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Total</asp:label>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="moneda_1_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label32" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q0.01</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="moneda_1_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="moneda_5_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label33" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q0.05</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="moneda_5_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="moneda_10_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label34" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q0.10</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="moneda_10_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="moneda_25_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label35" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q0.25</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="moneda_25_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="moneda_50_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label36" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q0.50</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="moneda_50_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="moneda_100_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label37" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q1.00</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="moneda_100_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="totalmonedas" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 28px" align="center">
            <table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td>
                        <asp:label id="Label49" Font-Size="10pt" Font-Names="Gill Sans MT" 
                            Height="16px" Width="59px" runat="server">Billetes</asp:label>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style2">
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="billete_1_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label41" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q1.00</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="billete_1_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="billete_5_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label42" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q5.00</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="billete_5_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="billete_10_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label43" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q10.00</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="billete_10_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="billete_20_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label44" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q20.00</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="billete_20_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="billete_50_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label45" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q50.00</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="billete_50_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="billete_100_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label46" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q100.00</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="billete_100_TextBox0" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" Enabled="False"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="billete_200_TextBox" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" TabIndex="1" Width="85px" onchange ="CalculaTotales()"></asp:TextBox>
                                </td>
                                <td>
                        <asp:label id="Label47" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="88px" runat="server">Q200.00</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="billete_200_TextBox0" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="totalbilletes" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                        <asp:label id="Label50" Font-Size="10pt" Font-Names="Gill Sans MT" Height="16px" 
                                        Width="59px" runat="server">TOTAL</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="total" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="1" Width="85px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 28px" align="center">
            &nbsp;</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			</TD>
	</TR>
	<TR>
		<TD align="center">
            <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td align="center">
                        <asp:Button ID="btnarqueo" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Text="Arqueo" Width="94px" />
                    </td>
                    <td align="center">
                        <asp:Button ID="btncuadre" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Text="Cuadre" Width="94px" />
                    </td>
                    <td align="center">
                        <asp:Button ID="btnValida" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Text="Validación" Width="94px" />
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
