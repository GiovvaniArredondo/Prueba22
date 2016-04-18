<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="wbpagos, App_Web_v6ddqlgy" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<script  runat="server">
Sub btClick1(obj As Object, e As EventArgs)        
        Ejecutar(obj, e)
        Grabar2.Enabled = False
End Sub
</script>
<script language="javascript" type="text/javascript">
    function clickOnce() {
        document.getElementById('<%=Grabar2.ClientId%>').disabled = true;
        return true;
    }
</script>
<style type="text/css">
    .style5
    {
        width: 90%;
        height: 53px;
    }
    .style6
    {
        width: 79px;
    }
    .style7
    {
        width: 91px;
    }
    .style8
    {
        width: 109px;
    }
    .style9
    {
        height: 26px;
    }
    .style11
    {
        width: 99%;
    }
    .style17
    {
        width: 99%;
    }
    .style18
    {
        height: 208px;
    }
    .style19
    {
        width: 145px;
    }
    .style20
    {
        width: 241px;
    }
    .style21
    {
        width: 83px;
    }
</style>
<TABLE id="Table1" style="border: medium solid highlight; WIDTH: 795px; HEIGHT: 553px; BACKGROUND-COLOR: #FFFFFF"
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD style="HEIGHT: 26px">
			&nbsp;</TD>
	</TR>
	<TR>
	
		<TD style="HEIGHT: 37px">
			<table cellpadding="0" cellspacing="0" class="style11">
                <tr>
                    <td class="style21">
                        <asp:label id="Label28" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="88px" runat="server">Fecha Valor:</asp:label>
                    </td>
                    <td>
            <asp:textbox id="txtfecval2" tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="104px"
				runat="server" BorderWidth="2px" AutoPostBack="True" BackColor="Yellow" BorderColor="#003366" 
                            Height="21px"></asp:textbox>
                        <cc1:MaskedEditExtender ID="txtfecval2_MaskedEditExtender" runat="server" 
                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecval2">
                        </cc1:MaskedEditExtender>
                    </td>
                    <td>
                        <asp:rangevalidator id="RangeValidator5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="88px" runat="server"
				ControlToValidate="txtfecval2" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator>
                    </td>
                    <td align="right" class="style20">
			<asp:CheckBox id="reimpresion" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="DarkBlue"
				Text="Re-Imprimir Recibo:"></asp:CheckBox>
			        </td>
                    <td align="right" class="style19">
                        <asp:label id="label_mensaje0" Font-Size="10pt" Font-Names="Gill Sans MT" 
                            Height="16px" Width="16px"
				runat="server"></asp:label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtRecImp" runat="server" Height="26px" Width="83px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style21">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td class="style20">
                        <asp:label id="label_mensaje" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="160px"
				runat="server"></asp:label>
			        </td>
                    <td class="style19">
			            &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table3" style="WIDTH: 536px; HEIGHT: 19px" cellSpacing="0" cellPadding="0" width="536"
				border="0">
				<TR>
					<TD style="WIDTH: 113px"><asp:label id="Label10" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="56px" runat="server">Crédito:</asp:label></TD>
					<TD style="WIDTH: 167px" align="center">
                        <asp:textbox id="txtnrocta" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Height="19px" Width="171px"
							runat="server" BorderWidth="1px" Enabled="False" ForeColor="Black"></asp:textbox></TD>
					<TD align="center"><asp:textbox id="txtcCodOfi" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="74px" runat="server"
							BorderWidth="1px" Visible="False" ForeColor="Black"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 113px"><asp:label id="Label11" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="112px" runat="server">Codigo de Cliente:</asp:label></TD>
					<TD style="WIDTH: 167px" align="center"><asp:textbox id="txtcodcli" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="176px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black"></asp:textbox></TD>
					<TD align="center"><asp:textbox id="txtnomcli" tabIndex="5" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" Width="247px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black"></asp:textbox></TD>
				</TR>
			</TABLE>
			</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:label id="Label31" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="56px" runat="server"></asp:label>
			<asp:textbox id="Txtccodins" Font-Size="10pt" Font-Names="Gill Sans MT" Width="74px" runat="server"
				BorderWidth="1px" Visible="False"></asp:textbox><asp:label id="Label32" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="56px" runat="server"></asp:label>
			</TD>
	</TR>
	<TR>
		<TD align="center" class="style9" bgcolor="#003366">
			<asp:label id="Label39" 
                Font-Size="12pt" Font-Names="Gill Sans MT" Height="16px" Width="335px"
				runat="server" Font-Bold="True" ForeColor="PowderBlue" BackColor="#003366">Saldos de Crédito</asp:label>
			</TD>
	</TR>
	<TR>
		<TD align="center" class="style9">
			<TABLE id="Table4" style="WIDTH: 536px; HEIGHT: 27px" cellSpacing="0" cellPadding="0" width="536"
				border="0">
				<TR>
					<TD style="WIDTH: 92px; HEIGHT: 6px"><asp:label id="Label13" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="48px" runat="server">Capital</asp:label></TD>
					<TD style="WIDTH: 82px; HEIGHT: 6px"><asp:label id="Label14" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="72px" runat="server">Interés</asp:label></TD>
					<TD style="WIDTH: 84px; HEIGHT: 6px"><asp:label id="Label15" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="64px" runat="server">Int.Mora</asp:label></TD>
					<TD style="WIDTH: 86px; HEIGHT: 6px"><asp:label id="Label16" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="64px" runat="server">Total</asp:label></TD>
					<TD style="WIDTH: 86px; HEIGHT: 6px"><asp:label id="Label17" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="72px" runat="server">Cuota</asp:label></TD>
					<TD style="HEIGHT: 6px" align="center"><asp:label id="Label18" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="64px" runat="server">Atraso</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 92px; HEIGHT: 6px"><asp:textbox id="txtsaldo" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="88px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black">0</asp:textbox></TD>
					<TD style="WIDTH: 82px; HEIGHT: 6px"><asp:textbox id="txtintere" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="83px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black">0</asp:textbox></TD>
					<TD style="WIDTH: 84px; HEIGHT: 6px"><asp:textbox id="txtgastos" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="77px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black">0</asp:textbox></TD>
					<TD style="WIDTH: 86px; HEIGHT: 6px"><asp:textbox id="txttotal" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="79px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black">0</asp:textbox></TD>
					<TD style="WIDTH: 86px; HEIGHT: 6px"><asp:textbox id="txtcuota" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="69px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black"></asp:textbox></TD>
					<TD style="HEIGHT: 6px" align="center"><asp:textbox id="txtdiaatr" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="64px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black"></asp:textbox></TD>
				</TR>
			</TABLE>
			</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:Label ID="Label60" runat="server" BackColor="#009933" BorderWidth="1px" 
                Font-Bold="False" Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="White" 
                Height="16px" Width="576px"></asp:Label>
			</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:label id="Label29" runat="server" Width="540px" Height="16px" 
                Font-Names="Gill Sans MT" Font-Size="10pt"
				ForeColor="Crimson" Font-Bold="True" BorderWidth="1px" BackColor="Gold"></asp:label>
			</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:label id="Label30" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                Width="60px" runat="server" BackColor="#CCFF33" BorderColor="#006600" 
                BorderWidth="1px" Font-Bold="True" ForeColor="#006600"></asp:label>
			</TD>
	</TR>
	<TR>
		<TD align="center" class="style18">
            <table cellpadding="0" cellspacing="0" class="style11">
                <tr>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" class="style17">
                            <tr>
                                <td align="right">
            <asp:label id="Label19" 
                Font-Size="12pt" Font-Names="Gill Sans MT" Height="16px" Width="131px"
				runat="server" Font-Bold="True" ForeColor="#003366">Detalle de Pago </asp:label>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label3" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" 
                                        Width="120px" runat="server" Visible="False">Nº Doc. </asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtcompro" tabIndex="5" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" Width="111px" runat="server"
							BorderWidth="1px" Visible="False">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label37" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="120px" 
                            runat="server">NºRecibo:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtcompro0" 
                            tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="111px" runat="server"
							BorderWidth="1px" Enabled="False">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label4" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="88px" runat="server">Deuda Capital:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtcapita" 
                            tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="111px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label5" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="97px" runat="server">Interés Normal:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtintere2" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="111px"
							runat="server" BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label9" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="32px" runat="server">Int.Mora:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtmora" 
                            tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="111px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label38" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="48px" 
                            runat="server" Visible="False">IVA:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtiva" 
                            tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="111px" runat="server"
							BorderWidth="1px" Enabled="False" Visible="False">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="Label66" runat="server" BorderColor="#003300" Font-Bold="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="Black" Height="16px" 
                                        style="margin-bottom: 0px" Width="126px">Detalle de Cargos:</asp:Label>
                                </td>
                                <td>
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                        CssClass="CSSTableGenerator" Width="251px">
                                        <Columns>
                                            <asp:BoundField DataField="ctipgas">
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="8pt" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="cdescri" HeaderText="Descripción">
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="8pt" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="nmongas" HeaderText="Cargo">
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="8pt" />
                                            </asp:BoundField>
                                        </Columns>
                                        <AlternatingRowStyle BackColor="#E8E8E8" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" class="style17">
                            <tr>
                                <td align="right">
                                    <asp:label id="Label6" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="104px" runat="server">Monto Desemb:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtcapdes" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="113px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label7" Font-Size="10pt" Font-Names="Gill Sans MT" Height="14px" Width="128px" runat="server">Ultima Fecha de Pago:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtdultpag" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="111px"
							runat="server" BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White"></asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label8" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="96px" runat="server">Monto de Cuota:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtmoncuo" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="111px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label23" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="96px" runat="server">Pago a Cuenta:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtpagcta" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="111px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label24" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="96px" runat="server">Deuda Efectiva:</asp:label>
                                </td>
                                <td>
                        <asp:textbox id="txtdeuefe" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="111px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White">0</asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="right">
						<asp:label id="Label25" runat="server" Width="80px" Height="15px" Font-Names="Gill Sans MT" Font-Size="10pt">Tipo de Pago:</asp:label>
                                </td>
                                <td>
						<asp:dropdownlist id="cmbtippag" runat="server" Width="138px" 
                            Font-Names="Gill Sans MT" Font-Size="10pt"
							AutoPostBack="True" Enabled="False"></asp:dropdownlist>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
						<asp:label id="lblbanco" runat="server" Width="50px" Height="15px" Font-Names="Gill Sans MT" Font-Size="10pt">Banco:</asp:label>
                                </td>
                                <td>
						<asp:dropdownlist id="cmbbanco" runat="server" Width="201px" Height="24px" 
                            Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    &nbsp;</td>
                                <td>
                                                <asp:CheckBox ID="CheckBox2" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Cancelación Total" 
                            AutoPostBack="True" Font-Bold="True" Visible="False" />
                                            </td>
                            </tr>
                            <tr>
                                <td align="right">
						<asp:label id="Label26" runat="server" Width="104px" Height="15px" Font-Names="Gill Sans MT" Font-Size="10pt"
							Font-Bold="True" BorderWidth="2px" ForeColor="Navy" BackColor="Yellow">Monto a Pagar:</asp:label>
                                </td>
                                <td>
						<asp:textbox id="txtmonpag" tabIndex="5" runat="server" Width="109px" 
                            Font-Names="Gill Sans MT" Font-Size="Small"
							BorderWidth="2px" ForeColor="#0000C0" BackColor="LightYellow" Height="25px">0</asp:textbox>
                                            </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    &nbsp;</td>
                                <td>
						<asp:rangevalidator id="RangeValidator3" runat="server" Width="96px" Font-Names="Gill Sans MT" Font-Size="10pt"
							MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="txtmonpag">Valor Inválido</asp:rangevalidator>
						        </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
			<table 
                cellpadding="0" cellspacing="0" class="style5">
            <tr>
                <td align="center" class="style6">
                    <INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: #ffffff"
				type="button" runat="server" visible="False"></td>
                <td align="center" class="style7">
                    <asp:Button ID="Grabar2" runat="server" Font-Names="Gill Sans MT" Height="30px" 
                        OnClick="btClick1" OnClientClick="clickOnce()" Text="Guardar" 
                        UseSubmitBehavior="false" Width="82px" />
                </td>
                <td align="center" class="style7">
                    <asp:Button ID="btnActivar" runat="server" Font-Names="Gill Sans MT" 
                        Text="Habilitar" Visible="False" />
                </td>
                <td align="center" class="style8">
                    <asp:Button ID="btnimprimir" runat="server" Font-Names="Gill Sans MT" 
                        Font-Size="12pt" Text="Recibo" />
                </td>
                <td align="center">
                    <asp:Button ID="Button2" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                        Text="Factura" Visible="False" />
                </td>
                <td align="center">
                    <asp:Button ID="Button3" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                        Text="PlanPagos" />
                </td>
                <td align="center">
                    <asp:Button ID="Button4" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                        Text="Estado Cta." />
                </td>
            </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table6" style="WIDTH: 597px; HEIGHT: 20px" cellSpacing="0" 
                cellPadding="0" border="0">
				<TR>
					<TD style="WIDTH: 130px; HEIGHT: 1px">
						<asp:label id="Label27" runat="server" Width="64px" Height="15px" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:label></TD>
					<TD style="WIDTH: 132px; HEIGHT: 1px" align="center">
						<asp:textbox id="txtflat" runat="server" Width="16px" Height="8px" 
                            Visible="False"></asp:textbox>
						<asp:textbox id="txtbandera" runat="server" Width="16px" Height="8px" Visible="False"></asp:textbox>
						<asp:textbox id="txtfecoto" runat="server" Width="16px" Height="16px" Visible="False"></asp:textbox>
						<asp:textbox id="txtfecven" runat="server" Width="16px" Height="16px" 
                            Visible="False"></asp:textbox>
						<asp:textbox id="txtcnomana" runat="server" Width="18px" Height="16px" 
                            Visible="False"></asp:textbox>
						<asp:textbox id="txtintaldia" runat="server" Width="16px" Height="16px" 
                            Visible="False"></asp:textbox>
						<asp:textbox id="txtcapaldia" runat="server" Width="16px" Height="16px" 
                            Visible="False"></asp:textbox>
						<asp:label id="Label1" runat="server" Width="16px" Height="15px" Font-Names="Gill Sans MT" Font-Size="10pt"
							Visible="False">As</asp:label>
                        <asp:Button ID="Button5" runat="server" Text="Button" Visible="False" />
                    </TD>
					<TD style="WIDTH: 144px; HEIGHT: 1px">
						<asp:textbox id="txtprograma" runat="server" Width="32px" Height="16px" Visible="False"></asp:textbox>
						<asp:textbox id="txtncappag" runat="server" Width="32px" Height="16px" Visible="False"></asp:textbox><asp:label id="Label33" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="32px" runat="server"
							Visible="False">Apo</asp:label>
						<asp:textbox id="txtahosim" tabIndex="5" runat="server" Width="22px" Font-Names="Gill Sans MT" Font-Size="10pt"
							BorderWidth="1px" Enabled="False" Visible="False">0</asp:textbox></TD>
					<TD style="HEIGHT: 1px" align="left">
						<asp:textbox id="txtaporta" tabIndex="5" runat="server" Width="17px" Font-Names="Gill Sans MT" Font-Size="10pt"
							BorderWidth="1px" Enabled="False" Visible="False">0</asp:textbox>
						<asp:textbox id="txtbandera0" runat="server" Width="16px" Height="8px" 
                            Visible="False"></asp:textbox>
                                                <asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Century Gothic" 
                                                    Font-Size="10pt" Text="Solidario" 
                            Visible="False" />
                                    <asp:textbox id="txtdeucap" tabIndex="5" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" Width="51px" runat="server"
							BorderWidth="1px" Enabled="False" Height="23px" Visible="False">0</asp:textbox>
                                            </TD>
					<TD style="HEIGHT: 1px" align="left">
                    <asp:Button ID="btngrabar" runat="server" Font-Names="Georgia" Height="29px" 
                        Text="Grabar" Width="79px" Visible="False" />
                    <cc1:ConfirmButtonExtender ID="btngrabar_ConfirmButtonExtender" runat="server" 
                        ConfirmText="Esta Seguro?" Enabled="True" TargetControlID="btngrabar">
                    </cc1:ConfirmButtonExtender>
                                            </TD>
				</TR>
				<TR>
					<TD style="WIDTH: 130px; HEIGHT: 1px">
                        <asp:textbox id="txtncongelado" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="39px"
							runat="server" BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="#C1E0FF" 
                            Height="16px" Visible="False">0</asp:textbox>
                        <asp:textbox id="txtcomision" 
                            tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="38px"
							runat="server" BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White" 
                            Height="16px" Visible="False">0</asp:textbox>
                        <asp:textbox id="txthonorarios" tabIndex="5" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" Width="22px"
							runat="server" BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White" 
                            Height="16px" Visible="False">0</asp:textbox></TD>
					<TD style="WIDTH: 132px; HEIGHT: 1px" align="center">
                        <asp:textbox id="txtgestion" 
                            tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="28px"
							runat="server" BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White" 
                            Height="18px" Visible="False">0</asp:textbox>
                        <asp:textbox id="txtsegdeu" 
                            tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="27px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White" Height="16px" 
                            Visible="False">0</asp:textbox></TD>
					<TD style="WIDTH: 144px; HEIGHT: 1px">
                        <asp:textbox id="txtmanejo" 
                            tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="34px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black" BackColor="White" Height="16px" 
                            Visible="False">0</asp:textbox>
                        <asp:textbox id="txtahovis" tabIndex="5" 
                            Font-Size="10pt" Font-Names="Gill Sans MT" Width="25px" runat="server"
							BorderWidth="1px" Enabled="False" ForeColor="Black" Height="16px" Visible="False">0</asp:textbox></TD>
					<TD style="HEIGHT: 1px" align="left">
                                    <asp:label id="Label2" Font-Size="10pt" Font-Names="Gill Sans MT" Height="16px" 
                                        Width="162px" runat="server" Visible="False">Deudad de Capitalización:</asp:label>
                                </TD>
					<TD style="HEIGHT: 1px" align="left">
						&nbsp;</TD>
				</TR>
			</TABLE>
                    </TD>
	</TR>
	</TABLE>
