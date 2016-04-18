<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucgestion" CodeFile="ucgestion.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 95%;
        height: 303px;
    }
    .style3
    {
        width: 429px;
    }
    .style4
    {
        width: 97%;
        height: 153px;
    }
    .style5
    {
        width: 94px;
    }
    .style7
    {
        width: 78px;
    }
    .style8
    {
        width: 72px;
    }
    .style9
    {
        width: 64px;
    }
    .style10
    {
        width: 92px;
    }
    .style11
    {
        width: 100%;
        height: 60px;
    }
    .style14
    {
        width: 91%;
    }
    .style15
    {
        width: 130px;
    }
    .style16
    {
        width: 121px;
    }
    .style2
    {
        width: 99%;
        height: 311px;
    }
    .style6
    {
        width: 101px;
    }
    .style17
    {
        width: 94px;
        height: 32px;
    }
    .style18
    {
        width: 78px;
        height: 32px;
    }
    .style19
    {
        width: 72px;
        height: 32px;
    }
    .style20
    {
        width: 64px;
        height: 32px;
    }
    .style21
    {
        width: 92px;
        height: 32px;
    }
    .style22
    {
        height: 32px;
    }
    .style23
    {
        width: 94px;
        height: 24px;
    }
    .style24
    {
        width: 78px;
        height: 24px;
    }
    .style25
    {
        width: 72px;
        height: 24px;
    }
    .style26
    {
        width: 64px;
        height: 24px;
    }
    .style27
    {
        width: 92px;
        height: 24px;
    }
    .style28
    {
        height: 24px;
    }
    .style29
    {
        width: 90%;
    }
    .style31
    {
        width: 69px;
    }
    .style32
    {
        width: 77px;
    }
    .style33
    {
        width: 223px;
    }
    .style34
    {
        width: 93%;
    }
    .style35
    {
        width: 116px;
    }
    .style36
    {
        width: 125px;
    }
    .style37
    {
        width: 69px;
        height: 37px;
    }
    .style38
    {
        width: 77px;
        height: 37px;
    }
    .style39
    {
        width: 223px;
        height: 37px;
    }
    .style40
    {
        height: 37px;
    }
    .style41
    {
        width: 32%;
    }
    .style42
    {
        width: 98px;
    }
    .style43
    {
        width: 69px;
        height: 40px;
    }
    .style44
    {
        width: 77px;
        height: 40px;
    }
    .style45
    {
        width: 223px;
        height: 40px;
    }
    .style46
    {
        height: 40px;
    }
    .style47
    {
        height: 37px;
        width: 145px;
    }
    .style48
    {
        height: 40px;
        width: 145px;
    }
    .style49
    {
        width: 145px;
    }
    .style50
    {
        width: 100%;
        height: 104px;
    }
    .style51
    {
        height: 36px;
    }
    .style52
    {
        height: 31px;
    }
    .style53
    {
        height: 37px;
        width: 156px;
    }
    .style54
    {
        height: 40px;
        width: 156px;
    }
    .style55
    {
        width: 156px;
    }
    .style56
    {
        width: 101px;
        height: 28px;
    }
    .style57
    {
        height: 28px;
    }
    .style60
    {
        width: 101px;
        height: 32px;
    }
    .style61
    {
        width: 101px;
        height: 30px;
    }
    .style62
    {
        height: 30px;
    }
    .style65
    {
        width: 101px;
        height: 25px;
    }
    .style66
    {
        height: 25px;
    }
    .style67
    {
        width: 101px;
        height: 26px;
    }
    .style68
    {
        height: 26px;
    }
</style>
 <script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
    <script type="text/javascript">
      function SoloNumeros(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32 || charCode == 45 || charCode == 46)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;

            return false;
        }

     
      
</script>

<TABLE id="Table3" style="border: thin solid #003366; WIDTH: 1009px; HEIGHT: 45px; BACKGROUND-COLOR: #ffffff; "
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD align="center">
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Gill Sans MT" 
                            Font-Size="14pt" ForeColor="#16387C" 
                            Text="GESTION MORA" Width="641px"></asp:Label>
			</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="center">
            <table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td class="style3">
                        <table cellpadding="0" cellspacing="0" class="style14">
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style2">
                                        <tr>
                                            <td class="style6">
                                                <asp:label id="Label54" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Fecha:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="TXTFECPRO" Font-Size="10pt" Width="116px" runat="server" Font-Names="Gill Sans MT"
							Font-Bold="True" BorderWidth="1px" Enabled="False" BorderColor="#2E6A99" Height="23px"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style56">
                                                <asp:label id="Label53" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Agencia:</asp:label>
                                            </td>
                                            <td class="style57">
                                                <asp:textbox id="txtagencia" Font-Size="10pt" Width="286px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" BorderColor="#2E6A99" Height="23px"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style6">
                                                <asp:label id="Label33" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Codigo:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtcodcli" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" BorderColor="#2E6A99" Height="23px"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style65">
                                                <asp:label id="Label36" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Prestamo Nº:</asp:label>
                                            </td>
                                            <td class="style66">
                                                <asp:textbox id="txtcodcta" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="180px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style61">
                                                <asp:label id="Label20" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Nombre:</asp:label>
                                            </td>
                                            <td class="style62">
                                                <asp:textbox id="txtnomcli" Font-Size="10pt" Width="287px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" Height="23px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style6">
                                                <asp:label id="Label63" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT">Calle:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtcalle" Font-Size="10pt" Width="351px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" Height="23px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style65">
                                                <asp:label id="Label64" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" Width="90px">No Interior:</asp:label>
                                            </td>
                                            <td class="style66">
                                                <asp:textbox id="txtnoInterior" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="180px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style60">
                                                <asp:label id="Label65" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" Width="90px">No Exterior:</asp:label>
                                            </td>
                                            <td class="style22">
                                                <asp:textbox id="txtnoExterior" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="180px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style6">
                                                <asp:label id="Label66" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" Width="90px">Colonia:</asp:label>
                                            </td>
                                            <td>
                                                        <asp:DropDownList ID="DropDownComu" runat="server" AutoPostBack="True" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" TabIndex="24" 
                                                            Width="351px" Enabled="False">
                                                        </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style67">
                                                <asp:label id="Label67" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" Width="90px">Cod. Postal:</asp:label>
                                            </td>
                                            <td class="style68">
                                                <asp:textbox id="txtcodpostal" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="180px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style65">
                                                <asp:label id="Label68" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" Width="100px">Telefono Celular:</asp:label>
                                            </td>
                                            <td class="style66">
                                                <asp:textbox id="txtcelular" Font-Size="10pt" Width="351px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" Height="23px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style65">
                                                <asp:label id="Label59" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Telefono Fijo:</asp:label>
                                            </td>
                                            <td class="style66">
                                                <asp:textbox id="txttelefonos" Font-Size="10pt" Width="351px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" Height="23px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style6">
                                                <asp:label id="Label32" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" Visible="False">Domicilio:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtdireccion" Font-Size="10pt" Width="351px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" Height="23px" BorderColor="#2E6A99" Visible="False"></asp:textbox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:label id="Label57" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Bold="True">DETALLE DE LA GESTIÓN</asp:label>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:TextBox ID="Txtdetalle" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Height="61px" TextMode="MultiLine" Width="398px" Enabled="False"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style50">
                                        <tr>
                                            <td align="right" class="style51">
                                                <asp:label id="Label62" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" 
                                                    Width="221px">Frecuencia de pago Establecida:</asp:label>
                                            </td>
                                            <td class="style51">
                                                <asp:TextBox ID="txtfrecpag" runat="server" Font-Names="Gill Sans MT" 
                                                    Height="23px" Width="190px" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style52">
                                                <asp:label id="Label60" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" 
                                                    Width="221px">Fecha Primer Pago:</asp:label>
                                            </td>
                                            <td class="style52">
                                                <asp:TextBox ID="txtfecpag" runat="server" Font-Names="Gill Sans MT" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Height="23px"></asp:TextBox>
                                                <cc1:MaskedEditExtender ID="txtfecpag_MaskedEditExtender" runat="server" 
                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecpag">
                                                </cc1:MaskedEditExtender>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                                <asp:label id="Label61" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" 
                                                    Width="221px" onkeypress="return SoloNumeros(event)">Monto Convenido:</asp:label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtmonconv" runat="server" Font-Names="Gill Sans MT" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Height="23px"></asp:TextBox>
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
                            <tr>
                                <td>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                        ControlToValidate="Txtdetalle" 
                                        ErrorMessage="La gestión no puede exceder de 254 caracteres" 
                                        ValidationExpression="^([\S\s]{0,254})$" Font-Names="Gill Sans MT"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Pendiente, Dar  Seguimiento" Enabled="False" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox2" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Gestión Efectiva, Socio Pagó" Enabled="False" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style14">
                                        <tr>
                                            <td align="center" class="style6">
                                                <asp:Button ID="btnnuevo" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                                                    Text="Nuevo" Width="70px" Height="29px" />
                                            </td>
                                            <td align="center">
                                                <asp:Button ID="btnborrar" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                                                    Text="Borrar" Width="70px" />
                                            </td>
                                            <td align="center">
                                                <asp:Button ID="btngrabar" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                                                    Text="Grabar" Width="70px" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style4">
                            <tr>
                                <td align="center" class="style22">
                                    <asp:label id="Label34" Font-Size="12pt" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Bold="True">CARACTERISTICAS DEL CRÉDITO</asp:label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style4">
                                        <tr>
                                            <td class="style5">
                                                <asp:label id="Label35" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Desembolso:</asp:label>
                                            </td>
                                            <td class="style7">
                                                <asp:textbox id="txtncapdes" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style8">
                                                <asp:label id="Label39" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Cap.Pagado:</asp:label>
                                            </td>
                                            <td class="style9">
                                                <asp:textbox id="txtncappag" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style10">
                                                <asp:label id="Label42" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Saldo Capital:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtnsalcap" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style17">
                                                <asp:label id="Label37" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Otorgado:</asp:label>
                                            </td>
                                            <td class="style18">
                                                <asp:textbox id="txtdfecvig" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style19">
                                                <asp:label id="Label40" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Vence:</asp:label>
                                            </td>
                                            <td class="style20">
                                                <asp:textbox id="txtdfecven" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style21">
                                                <asp:label id="Label43" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Cuota:</asp:label>
                                            </td>
                                            <td class="style22">
                                                <asp:textbox id="txtnmoncuo" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                <asp:label id="Label38" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Meses Plazo:</asp:label>
                                            </td>
                                            <td class="style7">
                                                <asp:textbox id="txtnmeses" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style8">
                                                <asp:label id="Label41" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Tasa:</asp:label>
                                            </td>
                                            <td class="style9">
                                                <asp:textbox id="txtntasa" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style10">
                                                <asp:label id="Label44" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Dias Atraso:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtndiaatr" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                <asp:label id="Label45" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Ultimo Pago:</asp:label>
                                            </td>
                                            <td class="style7">
                                                <asp:textbox id="txtdultpag" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style8">
                                                <asp:label id="Label46" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Fecha Valor:</asp:label>
                                            </td>
                                            <td class="style9">
                                                <asp:textbox id="txtdfecval" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style10">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style23">
                                                <asp:label id="Label48" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Último Pago:</asp:label>
                                            </td>
                                            <td class="style24">
                                                <asp:textbox id="txtnultpag" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style25">
                                                &nbsp;</td>
                                            <td class="style26">
                                                &nbsp;</td>
                                            <td class="style27">
                                                &nbsp;</td>
                                            <td class="style28">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style5">
                                                &nbsp;</td>
                                            <td class="style7">
                                                &nbsp;</td>
                                            <td class="style8">
                                                &nbsp;</td>
                                            <td class="style9">
                                                &nbsp;</td>
                                            <td class="style10">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style11">
                                        <tr>
                                            <td>
                                                <asp:label id="Label49" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Promotor:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtnomana" Font-Size="10pt" Width="41px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" BorderColor="#2E6A99" Height="23px"></asp:textbox>
                                                <asp:textbox id="txtnomana0" Font-Size="10pt" Width="338px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" BorderColor="#2E6A99" Height="23px"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style14">
                                        <tr>
                                            <td class="style15">
                                                <asp:label id="Label51" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" 
                                                    Height="16px" Width="88px">Créditos Vigentes:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtncrevig" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                            <td class="style16">
                                                <asp:label id="Label52" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" 
                                                    Width="20px">Créditos Cancelados:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtncrecan" Font-Size="10pt" runat="server" 
                                                    Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="23px" Width="78px" BorderColor="#2E6A99"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style15">
                                                <asp:label id="Label55" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" 
                                                    Width="20px">Garantía:</asp:label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="Txtgarantia" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="61px" TextMode="MultiLine" Width="155px" 
                                                    ReadOnly="True"></asp:TextBox>
                                            </td>
                                            <td align="right" class="style16">
                                                <asp:label id="Label56" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" 
                                                    Width="77px">Datos del Fiador(a):</asp:label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="Txtfiador" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="55px" TextMode="MultiLine" Width="155px" 
                                                    ReadOnly="True"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
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
		<TD style="HEIGHT: 19px" align="center">
            <asp:datagrid id="Datagrid1" runat="server" Width="617px" BorderWidth="1px" 
                Height="48px" BorderColor="#DEBA84"
									BackColor="#DEBA84" BorderStyle="None" CellPadding="3" 
                AutoGenerateColumns="False" AllowSorting="True" CellSpacing="2" 
                Font-Names="Gill Sans MT" Font-Size="8pt" >
									<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
									<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
									<AlternatingItemStyle BackColor="#99FF66" />
									<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
									<Columns>
										<asp:ButtonColumn CommandName="Select" Text="Seleccionar"></asp:ButtonColumn>
										<asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Font-Names="Gill Sans MT" 
                                                    Font-Size="12pt" Height="27px" 
                                                    Text='<%# DataBinder.Eval(Container, "DataItem.idgestion") %>' Width="80px"></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
										<asp:BoundColumn DataField="dfecges" SortExpression="dfecges" 
                                            HeaderText="Fecha" DataFormatString="{0:dd-MM-yyyy}">
											<HeaderStyle Font-Size="Small" Font-Names="Gill Sans MT" Font-Bold="True" HorizontalAlign="Center"
												VerticalAlign="Top" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
											<ItemStyle Font-Size="Small" Font-Names="Century Gothic" 
                                                HorizontalAlign="Center" VerticalAlign="Top" Font-Bold="False" 
                                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                                Font-Underline="False"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="gestion" SortExpression="gestion" 
                                            HeaderText="Gestión">
											<HeaderStyle Font-Size="Small" Font-Names="Gill Sans MT" Font-Bold="True" HorizontalAlign="Center"
												VerticalAlign="Top" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
											<ItemStyle Font-Size="Small" Font-Names="Century Gothic" 
                                                HorizontalAlign="Center" VerticalAlign="Top" Font-Bold="False" 
                                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                                Font-Underline="False"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="time_in" SortExpression="time_in" 
                                            HeaderText="Hora IN">
											<HeaderStyle Font-Size="Small" Font-Names="Gill Sans MT" HorizontalAlign="Center" 
                                                VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
											<ItemStyle Font-Size="Small" Font-Names="Century Gothic" 
                                                HorizontalAlign="Center" VerticalAlign="Top" Font-Bold="False" 
                                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                                Font-Underline="False"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="time_out" SortExpression="time_out" 
                                            HeaderText="Hora OUT">
											<HeaderStyle Font-Size="Small" Font-Names="Gill Sans MT" HorizontalAlign="Center" 
                                                VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
											<ItemStyle Font-Size="Small" Font-Names="Century Gothic" 
                                                HorizontalAlign="Center" VerticalAlign="Top" Font-Bold="False" 
                                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                                Font-Underline="False"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="ccodusu" SortExpression="ccodusu" 
                                            HeaderText="Gestor">
											<HeaderStyle Font-Size="Small" Font-Names="Gill Sans MT" HorizontalAlign="Center" 
                                                VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
											<ItemStyle Font-Size="Small" Font-Names="Arial" HorizontalAlign="Center" 
                                                VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                                Font-Strikeout="False" Font-Underline="False"></ItemStyle>
										</asp:BoundColumn>
									    <asp:BoundColumn DataField="cflag" SortExpression="cflag"></asp:BoundColumn>
									    <asp:BoundColumn DataField="cfrecpag" HeaderText="Frecuencia Pago Conv." 
                                            SortExpression="cfrecpag"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="dfecpag" DataFormatString="{0:dd-MM-yyyy}" 
                                            HeaderText="Fecha Pago" SortExpression="dfecpag"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="nmonconv" HeaderText="Pago Convenido" 
                                            SortExpression="nmonconv"></asp:BoundColumn>
									</Columns>
									<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
								</asp:datagrid>
        </TD>
	</TR>
	<TR>
		<TD align="center">
            <table cellpadding="0" cellspacing="0" class="style29">
                <tr>
                    <td class="style37">
                        <asp:TextBox ID="Txtndesde" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Height="20px" Width="59px" Visible="False"></asp:TextBox>
                    </td>
                    <td class="style38">
                        <asp:TextBox ID="Txtnhasta" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Height="20px" style="margin-left: 0px" Width="59px" 
                            Visible="False"></asp:TextBox>
                    </td>
                    <td class="style39">
                                                &nbsp;</td>
                    <td class="style40">
                        </td>
                    <td class="style40">
                        </td>
                    <td class="style40">
                        </td>
                    <td class="style53">
                                                <asp:Button ID="btnnota" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    Text="Colocar Notas" Width="140px" Height="26px" Visible="False" />
                        </td>
                    <td class="style47">
                                                &nbsp;</td>
                    <td class="style40">
                        </td>
                    <td class="style40">
                        </td>
                </tr>
                <tr>
                    <td class="style43">
                    </td>
                    <td class="style44">
                    </td>
                    <td class="style45">
                                                &nbsp;</td>
                    <td class="style46">
                        </td>
                    <td class="style46">
                        </td>
                    <td class="style46">
                        </td>
                    <td class="style54">
                        </td>
                    <td class="style48">
                        </td>
                    <td class="style46">
                        </td>
                    <td class="style46">
                        </td>
                </tr>
                <tr>
                    <td class="style31">
                        &nbsp;</td>
                    <td class="style32">
                        &nbsp;</td>
                    <td class="style33" align="center">
                                                &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td class="style55">
                        &nbsp;</td>
                    <td class="style49">
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
		<TD style="HEIGHT: 19px" align="center">
			<table align="left" cellpadding="0" cellspacing="0" class="style41">
                <tr>
                    <td class="style42">
                        <asp:CheckBox ID="CheckBox3" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Otro" Width="59px" Visible="False" />
                    </td>
                    <td>
                        <asp:dropdownlist id="ddlanalistas" runat="server" 
                                                                    Font-Names="Gill Sans MT" Width="259px" 
                            Font-Size="10pt" Height="16px" Visible="False"></asp:dropdownlist>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="center">
			&nbsp;</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="center">
			<table cellpadding="0" cellspacing="0" class="style34">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td class="style35">
                        <asp:TextBox ID="txtdfec1" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Height="20px" Width="102px" Visible="False"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtdfec1_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdfec1">
                        </cc1:CalendarExtender>
                    </td>
                    <td class="style36">
                        <asp:TextBox ID="txtdfec2" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Height="20px" Width="102px" Visible="False"></asp:TextBox>
                        <cc1:CalendarExtender ID="txtdfec2_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdfec2">
                        </cc1:CalendarExtender>
                    </td>
                    <td>
                        &nbsp;</td>
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
                        &nbsp;</td>
                    <td class="style35">
                                                &nbsp;</td>
                    <td class="style36">
                                                &nbsp;</td>
                    <td>
                        &nbsp;</td>
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
		<TD style="HEIGHT: 19px" align="center">
			<asp:label id="label_mensaje" Font-Size="10pt" Width="384px" runat="server" Font-Names="Gill Sans MT"
				BackColor="White" Visible="False">Label</asp:label>
        </TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="center">
            <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                Text="Aplicar" Visible="False" />
        </TD>
	</TR>
	<TR>
		<TD align="center">
                                                <asp:Button ID="btnnuevo3" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    Text="Imprimir No Efectivas" 
                            Width="125px" Visible="False" />
                                                <asp:Button ID="btnnuevo4" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    Text="Imprimir Efectivas" 
                            Width="125px" Visible="False" />
                    <asp:textbox id="txtlinea" Font-Size="10pt" Width="86px" 
                runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox>
            <asp:TextBox ID="txtbandera" runat="server" Height="16px" Visible="False" 
                Width="51px"></asp:TextBox>
            <asp:TextBox ID="txtinicio" runat="server" Height="16px" Visible="False" 
                Width="51px"></asp:TextBox>
            <asp:textbox id="TxtComodin" runat="server" Width="64px" Font-Names="Gill Sans MT" BorderWidth="1px"
								Visible="False"></asp:textbox>
                                                <asp:Button ID="btnnuevo0" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    Text="Rango Días Mora No  Gestionada" 
                            Width="82px" Visible="False" Height="24px" />
                                                <asp:Button ID="btnnuevo1" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    Text="Imprimir Reporte Productividad" 
                            Width="89px" Height="27px" Visible="False" />
                                                <asp:Button ID="btnnuevo2" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    Text="Imprimir Productividad--&gt;Excel" 
                            Width="85px" Height="25px" Visible="False" />
        </TD>
	</TR>
</TABLE>

<script language='JavaScript'>
document.onkeydown=function (evt) {return (evt ? evt.which : event.keyCode) != 13;}
</script>
