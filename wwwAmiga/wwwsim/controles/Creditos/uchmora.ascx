<%@ Control Language="VB" AutoEventWireup="false" CodeFile="uchmora.ascx.vb" Inherits="controles_uchmora" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc2" %>
<style type="text/css">
    .style13
    {
        width: 100%;
    }
    .style1
    {
        width: 48%;
    }
    .style2
    {
        width: 97%;
        height: 348px;
    }
    .style3
    {
        width: 100%;
        height: 39px;
    }
    .style4
    {
        width: 143px;
    }
    .style5
    {
        width: 100%;
        height: 30px;
    }
    .style6
    {
        width: 84px;
    }
    .style7
    {
        width: 157px;
    }
    .style8
    {
        width: 81px;
    }
    .style9
    {
        width: 51%;
    }
    .style10
    {
        width: 84%;
        height: 37px;
    }
    .style12
    {
        width: 144px;
    }
    .style14
    {
        width: 143px;
        height: 25px;
    }
    .style15
    {
        height: 25px;
    }
    .style16
    {
        height: 21px;
    }
</style>

<script type="text/javascript">

    function SoloNumeros(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode == 08 || charCode == 32 || charCode == 45)
            return true;
        else if (charCode >= 48 && charCode <= 57)
            return true; return false;
    }


    //Esta función solo permite numeros y el punto, se invoca desde el evento onkeypress Ejemplo onkeypress="return NumCheck(event, this)"
    function NumCheck(e, field) {
        key = e.keyCode ? e.keyCode : e.which
        if (key == 8 || key == 9 ||  key == 127) return true        
        if (key > 47 && key < 58) {
            var cad = field.value;
            if (cad.indexOf(".") != -1) {
                regexp = /.[0-9]{2}$/
                return !(regexp.test(field.value))
            }
            return true
        }
        if (key == 46) {
            if (field.value == "") return false
            regexp = /^[0-9]+$/
            return regexp.test(field.value)
        }
        return false
    }
    

</script>

<table cellpadding="0" cellspacing="0" class="style13">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table border="1" cellpadding="0" cellspacing="0" class="style1" 
    style="border-color: #003366; height: 380px;">
                        <tr>
                            <td>
                                <table align="center" cellpadding="0" cellspacing="0" class="style2">
                                    <tr>
                                        <td align="center">
                                            <asp:label id="Label1" Font-Size="X-Small" Width="189px" 
                runat="server" Font-Names="Verdana"
				Font-Bold="True" ForeColor="Maroon" Height="21px">Gestión de  Mora</asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" style="text-align: left">
                                            <asp:CheckBox ID="llBandera_Indiv" runat="server" AutoPostBack="True" 
                                                Font-Names="Calibri" Font-Size="11pt" Text="Individual" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <table cellpadding="0" cellspacing="0" class="style3">
                                                <tr>
                                                    <td class="style4">
                                                        <asp:Label ID="Label60" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                            Width="120px">Codigo de Socio:</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtcCodcli" runat="server" Font-Names="Calibri" 
                            Font-Size="10pt" Height="20px" Width="102px" BorderColor="#2E6A99" BorderWidth="1px" Enabled="False"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style14">
                                                        <asp:Label ID="Label59" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                            Width="120px">Codigo de Prestamo:</asp:Label>
                                                    </td>
                                                    <td class="style15">
                                                        <asp:TextBox ID="txtcCodcta" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Calibri" Font-Size="10pt" 
                                                            Height="20px" Width="200px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style4">
                                                        <asp:Label ID="Label61" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                            Width="120px">Nombre Socio:</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtcNomcli" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Calibri" Font-Size="10pt" 
                                                            Height="20px" Width="300px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table cellpadding="0" cellspacing="0" class="style3">
                                                <tr>
                                                    <td class="style4">
                                                        <asp:label id="Label54" Font-Size="10pt" runat="server" Font-Names="Calibri">Fecha Proyectada:</asp:label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtdfec1" runat="server" Font-Names="Calibri" 
                            Font-Size="12pt" Height="20px" Width="102px" BorderColor="#2E6A99" BorderWidth="1px" Enabled="False"></asp:TextBox>
                                                        <cc1:MaskedEditExtender ID="txtdfec1_MaskedEditExtender" runat="server" 
                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                        Mask="99/99/9999" MaskType="Date" TargetControlID="txtdfec1">
                                                        </cc1:MaskedEditExtender>
                                                        <cc1:CalendarExtender ID="txtdfec1_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdfec1">
                                                        </cc1:CalendarExtender>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table cellpadding="0" cellspacing="0" class="style5">
                                                <tr>
                                                    <td class="style6">
                                                        <asp:label id="Label55" Font-Size="10pt" runat="server" 
                                        Font-Names="Calibri">Promotor:</asp:label>
                                                    </td>
                                                    <td>
                                                        <cc2:CbxAnalistas ID="CbxAnalistas1" runat="server" Font-Names="Calibri" 
                                                            Font-Size="10pt" Height="21px" Width="300px">
                                                        </cc2:CbxAnalistas>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table cellpadding="0" cellspacing="0" class="style5">
                                                <tr>
                                                    <td class="style7">
                                                        <asp:label id="Label56" Font-Size="10pt" runat="server" 
                                        Font-Names="Calibri" Visible="False">Rangos de días a la fecha:</asp:label>
                                                    </td>
                                                    <td class="style8">
                                                        <asp:TextBox ID="Txtndesde" runat="server" Font-Names="Calibri" 
                            Font-Size="12pt" Height="20px" Width="59px" BorderColor="#2E6A99" BorderWidth="1px"
                            onkeypress="return SoloNumeros(event)" Visible="False" ></asp:TextBox>
                                                    </td>
                                                    <td class="style8">
                                                        <asp:TextBox ID="Txtnhasta" runat="server" Font-Names="Calibri" 
                            Font-Size="12pt" Height="20px" style="margin-left: 0px" Width="59px" 
                                        BorderColor="#2E6A99" BorderWidth="1px"
                                        onkeypress="return SoloNumeros(event)" Visible="False" ></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label57" runat="server" Font-Names="Calibri"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <table cellpadding="0" cellspacing="0" class="style9">
                                                <tr>
                                                    <td align="center">
                                                        <asp:Label ID="Label58" runat="server" Font-Bold="True" Font-Names="Calibri">EMISION DE CARTAS</asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:CheckBox ID="CheckBox3" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Carta Recordatorio de Pago" Width="192px" Visible="False" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:CheckBox ID="CheckBox4" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Carta Atraso 1 a 21 días" Width="192px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:CheckBox ID="CheckBox5" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Carta Atraso 22 a 35 días" Width="192px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:CheckBox ID="CheckBox6" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Carta Atraso 36 a 63 días" Width="192px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style16">
                                                        <asp:CheckBox ID="CheckBox7" runat="server" Font-Names="Calibri" 
                                                            Font-Size="10pt" Text="Carta Atraso 64 a 90 días" Width="192px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style16">
                                                        <asp:CheckBox ID="CheckBox8" runat="server" Font-Names="Calibri" 
                                                            Font-Size="10pt" Text="Carta Atraso 91 a 104 días" Width="192px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style16">
                                                        <asp:CheckBox ID="CheckBox9" runat="server" Font-Names="Calibri" 
                                                            Font-Size="10pt" Text="Carta Atraso 105 a 118 días" Width="192px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style16">
                                                        <asp:CheckBox ID="CheckBox10" runat="server" Font-Names="Calibri" 
                                                            Font-Size="10pt" Text="Mas de 119 días" Width="192px" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table align="center" cellpadding="0" cellspacing="0" class="style10">
                                                <tr>
                                                    <td align="center" class="style12">
                                                        <asp:Button ID="btncartas" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Text="Cartas" Width="90px" />
                                                    </td>
                                                    <td align="center">
                                                        <asp:Button ID="Button3" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        style="margin-left: 30px" Text="Lista Cartera" Width="90px" Visible="False" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:CheckBox ID="CheckBox2" runat="server" Font-Names="Calibri" 
                                                Font-Size="10pt" Text="Solo Haberes--&gt;Deuda" Visible="False" Width="142px" />
                                            <asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Calibri" 
                                                Font-Size="10pt" Text="Calcular Haberes" Visible="False" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
                  <Triggers>
                     <asp:PostBackTrigger ControlID="Button3" />
                     <asp:PostBackTrigger ControlID="btncartas" />                     
                  </Triggers>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>

