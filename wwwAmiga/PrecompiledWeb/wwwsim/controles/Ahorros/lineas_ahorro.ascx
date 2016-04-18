<%@ control language="vb" autoeventwireup="false" inherits="lineas_ahorro, App_Web_kxy_ccyk" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style25
    {
        height: 60px;
        width: 701px;
    }
    .style26
    {
        height: 27px;
    }
    .style29
    {
        height: 20px;
    }
    .style30
    {
        height: 43px;
    }
    .style32
    {
        height: 20px;
        width: 163px;
    }
    .style33
    {
        height: 43px;
        width: 163px;
    }
    .style35
    {
        height: 154px;
    }
    .style36
    {
        width: 163px;
        height: 30px;
    }
    .style37
    {
        height: 30px;
    }
    .style38
    {
        height: 27px;
        width: 165px;
    }
    .style39
    {
        height: 27px;
        width: 163px;
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

<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <fieldset id="Catalogo">
                    <legend>
                           <asp:Label ID="Label1" runat="server" Text="Parametros Ahorros" 
                            Font-Bold="True" Font-Names="Calibri" Font-Size="10pt"></asp:Label></legend>



                        <table cellpadding="0" cellspacing="0" class="style25">
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style25">
                                        <tr>
                                            <td class="style38" style="text-align: left">
                                                <asp:Label ID="lblUsuario84" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="175px">No Linea:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <asp:TextBox ID="Txtcnrolin" runat="server" BorderColor="#2E6A99" 
                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="20px" style="text-align: left" TabIndex="1" Width="100px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style38" style="text-align: left">
                                                <asp:Label ID="lblUsuario91" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="175px">Codigo Linea:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <asp:TextBox ID="TxtcCodlin" runat="server" BorderColor="#2E6A99" 
                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="20px" style="text-align: left" TabIndex="2" Width="150px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style38" style="text-align: left">
                                                <asp:Label ID="lblUsuario61" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="175px">Institución:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <cc1:CbxInst ID="CbxInst1" runat="server" AppendDataBoundItems="True" 
                                                    AutoPostBack="True" Enabled="False" Font-Names="Calibri" Font-Size="10pt" 
                                                    TabIndex="3" Width="250px">
                                                    <asp:ListItem Value="00">Seleccione una Opcion</asp:ListItem>
                                                </cc1:CbxInst>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style38" style="text-align: left">
                                                <asp:Label ID="lblUsuario58" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="175px">Moneda:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <cc1:CbxMoneda ID="CbxMoneda1" runat="server" AppendDataBoundItems="True" 
                                                    AutoPostBack="True" Enabled="False" Font-Names="Calibri" Font-Size="10pt" 
                                                    TabIndex="4" Width="250px">
                                                    <asp:ListItem Value="00">Seleccione una Opcion</asp:ListItem>
                                                </cc1:CbxMoneda>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style38" style="text-align: left">
                                                <asp:Label ID="lblUsuario59" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="175px">Capitalización:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <asp:DropDownList ID="cbxcapitaliza1" runat="server" Enabled="False" 
                                                    Font-Names="Calibri" Font-Size="10pt" Height="21px" Width="249px">
                                                    <asp:ListItem Value="00">Seleccione una Opción</asp:ListItem>
                                                    <asp:ListItem Value="01">Sin capitalización</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style38" style="text-align: left">
                                                <asp:Label ID="lblUsuario60" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="175px">Tipo de Ahorro:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <cc1:CbxTipAho ID="CbxTipAho1" runat="server" AppendDataBoundItems="True" 
                                                    AutoPostBack="True" Enabled="False" Font-Names="Calibri" Font-Size="10pt" 
                                                    TabIndex="6" Width="250px">
                                                    <asp:ListItem Value="00">Seleccione una Opción</asp:ListItem>
                                                </cc1:CbxTipAho>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style38" style="text-align: left">
                                                <asp:Label ID="lblUsuario90" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="175px">Sector:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <asp:DropDownList ID="CbxSectorAho1" runat="server" Enabled="False" 
                                                    Font-Names="Calibri" Font-Size="10pt" Height="21px" Width="249px">
                                                    <asp:ListItem Value="00">Seleccione una Opción</asp:ListItem>
                                                    <asp:ListItem Value="01">Sin Sector</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center" class="style35">
                                    <table cellpadding="0" cellspacing="0" class="style25">
                                        <tr>
                                            <td class="style32" style="text-align: left">
                                                &nbsp;</td>
                                            <td class="style29">
                                                &nbsp;</td>
                                            <td class="style29">
                                                &nbsp;</td>
                                            <td class="style29">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style39" style="text-align: left">
                                                <asp:Label ID="lblUsuario67" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="150px">Fecha Vigencia:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <asp:TextBox ID="TxtFecVig" runat="server" AutoPostBack="True" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="20px" style="text-align: left" TabIndex="8" 
                                                    Width="125px"></asp:TextBox>
                                                <asp:MaskedEditExtender ID="Masked_EditExt1" runat="server" 
                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="TxtFecVig">
                                                </asp:MaskedEditExtender>
                                                <asp:CalendarExtender ID="TxtFecVig_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="dd/MM/yyyy" PopupButtonID="Image_btn1" 
                                                    TargetControlID="TxtFecVig">
                                                </asp:CalendarExtender>
                                                <asp:ImageButton ID="Image_btn1" runat="server" 
                                                    ImageUrl="~/web/gifs/Calendar_scheduleHS.png" />
                                            </td>
                                            <td class="style26">
                                                &nbsp;</td>
                                            <td class="style26">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style39" style="text-align: left">
                                                <asp:Label ID="lblUsuario86" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="150px">Plazo:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <asp:TextBox ID="txtnplazomin" runat="server" BorderColor="#2E6A99" 
                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="20px" style="text-align: left" TabIndex="9" Width="150px"
                                                    onkeypress="return SoloNumeros(event)" MaxLength="3">0</asp:TextBox>
                                            </td>
                                            <td class="style26">
                                                <asp:Label ID="lblUsuario73" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="150px" Visible="False">Plazo Máximo:</asp:Label>
                                            </td>
                                            <td class="style26">
                                                <asp:TextBox ID="txtnplazomax" runat="server" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="20px" style="text-align: left" TabIndex="10" 
                                                    Width="150px" onkeypress="return SoloNumeros(event)" MaxLength="3" 
                                                    Visible="False">0</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style33" style="text-align: left">
                                                <asp:Label ID="lblUsuario87" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="150px">Monto Minimo:</asp:Label>
                                            </td>
                                            <td class="style30">
                                                <asp:TextBox ID="txtnmonmin" runat="server" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="20px" style="text-align: left" TabIndex="11" 
                                                    Width="150px" onkeypress="return NumCheck(event, this)" MaxLength="17">0.00</asp:TextBox>
                                            </td>
                                            <td class="style30">
                                                <asp:Label ID="lblUsuario88" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="150px">Monto Máximo:</asp:Label>
                                            </td>
                                            <td class="style30">
                                                <asp:TextBox ID="txtnmonmax" runat="server" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="20px" style="text-align: left" TabIndex="12" 
                                                    Width="150px" onkeypress="return NumCheck(event, this)" MaxLength="17">0.00</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style33" style="text-align: left">
                                                <asp:Label ID="lblUsuario69" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="150px">Tasa Minima:</asp:Label>
                                            </td>
                                            <td class="style30">
                                                <asp:TextBox ID="txtntasamin" runat="server" BorderColor="#2E6A99" 
                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="20px" style="text-align: left" TabIndex="13" Width="150px"
                                                    onkeypress="return NumCheck(event, this)" MaxLength="5">0.00</asp:TextBox>
                                            </td>
                                            <td class="style30">
                                                <asp:Label ID="lblUsuario71" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="150px">Tasa Máxima:</asp:Label>
                                            </td>
                                            <td class="style30">
                                                <asp:TextBox ID="txtntasamax" runat="server" BorderColor="#2E6A99" 
                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="20px" style="text-align: left" TabIndex="14" Width="150px"
                                                    onkeypress="return NumCheck(event, this)" MaxLength="5">0.00</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style36" style="text-align: left">
                                                <asp:Label ID="lblUsuario92" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="150px">Tasa :</asp:Label>
                                            </td>
                                            <td class="style37">
                                                <asp:TextBox ID="txtntasa" runat="server" BorderColor="#2E6A99" 
                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="20px" MaxLength="5" onkeypress="return NumCheck(event, this)" 
                                                    style="text-align: left" TabIndex="14" Width="150px">0.00</asp:TextBox>
                                            </td>
                                            <td class="style37">
                                                <asp:Label ID="lblUsuario89" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="150px">Estado:</asp:Label>
                                            </td>
                                            <td class="style37">
                                                <asp:DropDownList ID="cmbEstado" runat="server" AutoPostBack="True" 
                                                    Enabled="False" Font-Names="Calibri" Font-Size="10pt" TabIndex="15" 
                                                    Width="150px">
                                                    <asp:ListItem Value="00">Seleccione un Estado</asp:ListItem>
                                                    <asp:ListItem Value="1">Activa</asp:ListItem>
                                                    <asp:ListItem Value="2">Inactiva</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style1">
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblUsuario64" Runat="server" Font-Names="Calibri" 
                                                    Font-Size="9pt" style="text-align: center" Width="150px">Descripción de Producto:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtcDesprod" runat="server" BorderWidth="1px" Enabled="False" 
                                                    Font-Names="CALIBRI" Font-Size="10pt" Height="55px" TabIndex="16" 
                                                    TextMode="MultiLine" Width="458px"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">
                                    <asp:Label ID="lblUsuario83" Runat="server" Font-Names="Calibri" 
                                        Font-Size="9pt" ForeColor="#CC0000">El formato de la fecha es dd/MM/YYYY {*}</asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="lblMensaje" runat="server" ForeColor="#3333CC"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style25">
                                        <tr>
                                            <td style="text-align: center">
                                                <asp:Button ID="btnnew" runat="server" CssClass="TestStyle" Font-Bold="True" 
                                                    Font-Names="Calibri" Font-Size="9pt" Height="27px" Text="Nuevo" 
                                                    Width="120px" />
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button ID="btnEdit" runat="server" CssClass="TestStyle" Enabled="False" 
                                                    Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                                                    Text="Editar" Width="120px" />
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button ID="Btnsave" runat="server" CssClass="TestStyle" Enabled="False" 
                                                    Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                                                    TabIndex="17" Text="Actualizar" Width="120px" />
                                                <cc2:ConfirmButtonExtender ID="Confirm_BtnExt1" runat="server" 
                                                    ConfirmText="Realmente Desea Guardar los cambios" Enabled="True" 
                                                    TargetControlID="Btnsave">
                                                </cc2:ConfirmButtonExtender>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>



                </fieldset>    
                </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnsave" EventName="Click" />
                        <asp:AsyncPostBackTrigger ControlID="btnnew" EventName="Click" />                                                
                        <asp:AsyncPostBackTrigger ControlID="btnEdit" EventName="Click" />                                                                      
                        
                    </Triggers>
                </asp:UpdatePanel>
        </td>
    </tr>
</table>
