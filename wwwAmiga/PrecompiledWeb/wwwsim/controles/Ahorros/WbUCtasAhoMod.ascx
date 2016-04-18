<%@ control language="VB" autoeventwireup="false" inherits="controles_Ahorros_WbUCtasAhoMod, App_Web_kxy_ccyk" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<style type="text/css">
    .style63
    {
        width: 100%;
    }
    .style1
    {
        width: 100%;
        height: 49px;
    }
    .style46
    {
        width: 271px;
        text-align: center;
    }
    
    .style5
    {
        width: 100%;
        height: 32px;
    }
                
     
    .style52
    {
        width: 209px;
    }
                    
     
    .style47
    {
        height: 45px;
    }
    .style53
    {
        width: 306px;
    }
                    
     
    .style48
    {
        width: 450px;
    }
                
     
    .style27
    {
        width: 770px;
        height: 178px;
    }
                
     
    .style59
    {
        width: 100%;
        height: 231px;
    }
    .style60
    {
        width: 126px;
    }
                
     
    .style34
    {
        width: 771px;
    }
                    
     
    .style61
    {
        width: 36px;
    }
    .style62
    {
        width: 289px;
    }
                
     
    .style44
    {
        height: 48px;
    }
    .style36
    {
        height: 74px;
    }
        
     
    .style45
    {
        height: 27px;
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

            <table cellpadding="0" cellspacing="0" class="style63">
                <tr>
                    <td>                        
                            <ContentTemplate>
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table cellpadding="0" cellspacing="0" class="style1">
                                                <tr>
                                                    <td class="style46">
                                                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="False" 
                                        Font-Names="calibri" Font-Size="11pt" style="text-align: center" 
                                        Text="SELECCIONE UN CRITERIO"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="CbxTipTran" runat="server" AutoPostBack="True" 
                                        Font-Names="calibri" Font-Size="10pt" Height="24px" Width="291px">
                                                            <asp:ListItem Value="00">Seleccionar una Opción</asp:ListItem>
                                                            <asp:ListItem Value="01">Busqueda de Socio</asp:ListItem>
                                                            <asp:ListItem Value="02">Mantenimiento Ctas. Ahorro</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:MultiView ID="MtvPrinci" runat="server">
                                                <asp:View ID="ViewFind" runat="server">
                                                    <table class="style5">
                                                        <tr>
                                                            <td>
                                                                <table class="style5">
                                                                    <tr>
                                                                        <td>
                                                                            <table class="style5">
                                                                                <tr>
                                                                                    <td>
                                                                                        <table class="style5">
                                                                                            <tr>
                                                                                                <td>
                                                                                                    <fieldset ID="Catalogo">
                                                                                                        <legend>
                                                                                                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                                    Font-Size="10pt" Text="Busqueda de Socio"></asp:Label>
                                                                                                        </legend>
                                                                                                        <table cellpadding="0" cellspacing="0" class="style25" 
                                                                                                        style="width: 600px; height: 350px">
                                                                                                            <tr>
                                                                                                                <td>
                                                                                                                    <table cellpadding="0" cellspacing="0" class="style17">
                                                                                                                        <tr>
                                                                                                                            <td class="style23" style="border: 1pt groove #FFFFFF; text-align: center">
                                                                                                                                <table cellpadding="0" cellspacing="0" class="style1" style="width: 743px; ">
                                                                                                                                    <tr>
                                                                                                                                        <td class="style52" style="border: 0.5pt groove #FFFFFF; text-align: center">
                                                                                                                                        </td>
                                                                                                                                        <td class="style26" style="border: 0.5pt groove #FFFFFF; text-align: center;">
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td class="style20" 
                                                                                                                                        
                                                                                                                                        style="border: 0.5pt groove #FFFFFF; text-align: center; margin-left: 40px;">
                                                                                                                                            <asp:Label ID="lblUsuario77" Runat="server" Font-Names="calibri" 
                                                                                                                                            Font-Size="9pt" style="font-weight: 700; font-size: 10pt">TIPO DE BUSQUEDA:</asp:Label>
                                                                                                                                        </td>
                                                                                                                                        <td class="style15" style="border: 0.5pt groove #FFFFFF; text-align: left;">
                                                                                                                                            <asp:DropDownList ID="cbxTipBusq" runat="server" AutoPostBack="True" 
                                                                                                                                            Font-Names="calibri" Font-Size="10pt" Height="21px" Width="250px">
                                                                                                                                                <asp:ListItem Value="00">Seleccione una Opción</asp:ListItem>
                                                                                                                                                <asp:ListItem Value="01">Nombre del Cliente</asp:ListItem>
                                                                                                                                                <asp:ListItem Value="02">Número de Doc</asp:ListItem>
                                                                                                                                                <asp:ListItem Value="03">Número de Cliente</asp:ListItem>
                                                                                                                                            </asp:DropDownList>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                </table>
                                                                                                                            </td>
                                                                                                                        </tr>
                                                                                                                        <tr>
                                                                                                                            <td class="style47" style="border: 1pt groove #FFFFFF; text-align: center">
                                                                                                                                <table cellpadding="0" cellspacing="0" class="style24">
                                                                                                                                    <tr>
                                                                                                                                        <td class="style53" style="text-align: center">
                                                                                                                                            <asp:Label ID="lblUsuario82" Runat="server" Font-Names="calibri" 
                                                                                                                                            Font-Size="9pt" Width="100px">Criterio a Evaluar:</asp:Label>
                                                                                                                                        </td>
                                                                                                                                        <td class="style48" style="text-align: left">
                                                                                                                                            <asp:TextBox ID="TxtcEvalua" runat="server" BorderColor="#2E6A99" 
                                                                                                                                            BorderWidth="1px" CssClass="transpare" Enabled="False" Font-Names="Verdana" 
                                                                                                                                            Font-Size="8pt" Height="25px" TabIndex="4" Width="350px"></asp:TextBox>
                                                                                                                                            <cc2:TextBoxWatermarkExtender ID="TxtcEvalua_TextBoxWatermarkExtender" 
                                                                                                                                            runat="server" Enabled="True" TargetControlID="TxtcEvalua" 
                                                                                                                                            WatermarkCssClass="Watermark" 
                                                                                                                                            WatermarkText="DIGITE EL NOMBRE DEL ASOCIADO">
                                                                                                                                            </cc2:TextBoxWatermarkExtender>
                                                                                                                                        </td>
                                                                                                                                        <td class="style48" style="text-align: center">
                                                                                                                                            <asp:Button ID="btnbuscar" runat="server" Font-Bold="True" Font-Names="calibri" 
                                                                                                                                            Font-Size="9pt" Height="24px" Text="Buscar" Width="171px" />
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                </table>
                                                                                                                            </td>
                                                                                                                        </tr>
                                                                                                                    </table>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                            <tr>
                                                                                                                <td style="text-align: center">
                                                                                                                    <asp:GridView ID="Gridfind" runat="server" AllowPaging="True" 
                                                                                                                    AutoGenerateColumns="False" Caption="Lineas de Socios" CssClass="grid" 
                                                                                                                    Width="692px">
                                                                                                                        <Columns>
                                                                                                                            <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                                                                                                                <controlstyle font-names="Gill Sans MT" font-size="9pt" />
                                                                                                                                <HeaderStyle BackColor="#99CCFF" />
                                                                                                                            </asp:CommandField>
                                                                                                                            <asp:BoundField DataField="ccodcli" HeaderText="Codigo de Socio">
                                                                                                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                                                                                                <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                            </asp:BoundField>
                                                                                                                            <asp:BoundField DataField="ccodaho" HeaderText="No Cta. Ahorro">
                                                                                                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                                                                                                <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                            </asp:BoundField>
                                                                                                                            <asp:BoundField DataField="cnombres" HeaderText="Nombres" 
                                                                                                                            ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                                                                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                                                                                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="350px" />
                                                                                                                            </asp:BoundField>
                                                                                                                            <asp:BoundField DataField="capellidos" HeaderText="Apellidos" 
                                                                                                                            ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                                                                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                                                                                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="350px" />
                                                                                                                            </asp:BoundField>
                                                                                                                            <asp:BoundField DataField="tipo_cta" HeaderText="Tipo de Cuenta" 
                                                                                                                            ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                                                                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                                                                                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="350px" />
                                                                                                                            </asp:BoundField>
                                                                                                                            <asp:BoundField DataField="saldo" HeaderText="saldo">
                                                                                                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                                                                                                <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                            </asp:BoundField>
                                                                                                                            <asp:BoundField DataField="cestado" HeaderText="Estado">
                                                                                                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                                                                                                <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                            </asp:BoundField>
                                                                                                                        </Columns>
                                                                                                                        <PagerTemplate>
                                                                                                                            Página
                                                                                                                            <asp:DropDownList ID="paginasDropDownList" runat="server" AutoPostBack="true" 
                                                                                                                            Font-Size="12px" 
                                                                                                                            onselectedindexchanged="paginasDropDownList_SelectedIndexChanged">
                                                                                                                            </asp:DropDownList>
                                                                                                                            de
                                                                                                                            <asp:Label ID="lblTotalNumberOfPages" runat="server" />
                                                                                                                            <asp:Button ID="Button4" runat="server" CommandArgument="First" 
                                                                                                                            CommandName="Page" CssClass="pagfirst" ToolTip="Prim. Pag" />
                                                                                                                            <asp:Button ID="Button5" runat="server" CommandArgument="Prev" 
                                                                                                                            CommandName="Page" CssClass="pagprev" ToolTip="Pág. anterior" />
                                                                                                                            <asp:Button ID="Button6" runat="server" CommandArgument="Next" 
                                                                                                                            CommandName="Page" CssClass="pagnext" ToolTip="Sig. página" />
                                                                                                                            <asp:Button ID="Button3" runat="server" CommandArgument="Last" 
                                                                                                                            CommandName="Page" CssClass="paglast" onclick="Button3_Click" 
                                                                                                                            ToolTip="Últ. Pag" />
                                                                                                                        </PagerTemplate>
                                                                                                                        <PagerStyle CssClass="pagerstyle" />
                                                                                                                        <AlternatingRowStyle BackColor="#99CCFF" />
                                                                                                                    </asp:GridView>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                            <tr>
                                                                                                                <td>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                        </table>
                                                                                                    </fieldset>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:View>
                                                <asp:View ID="ViewCtaAho" runat="server">
                                                    <table cellpadding="0" cellspacing="0" class="style27">
                                                        <tr>
                                                            <td class="style28">
                                                                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                Font-Size="12pt" Text="MODIFICACION DE CUENTAS"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style28">
                                                                <table cellpadding="0" cellspacing="0" class="style59">
                                                                    <tr>
                                                                        <td class="style60">
                                                                            <asp:Label ID="lblUsuario86" Runat="server" Font-Names="Calibri" 
                                                            Font-Size="9pt" style="text-align: left" Width="100px">Cod. Asociado :</asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="TxtcCodcli" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                            Height="20px" TabIndex="1" Width="105px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style60">
                                                                            <asp:Label ID="lblUsuario103" Runat="server" Font-Names="Calibri" 
                                                            Font-Size="9pt" Height="16px" style="text-align: left" Width="100px">No Cta Ahorro:</asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="TxtcCodaho" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                            Height="20px" TabIndex="1" Width="105px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style60">
                                                                            <asp:Label ID="lblUsuario104" Runat="server" Font-Names="Calibri" 
                                                            Font-Size="9pt" style="text-align: left" Width="100px">Nombres :</asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="TxtcNombres" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                            Height="20px" TabIndex="2" Width="500px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style60">
                                                                            <asp:Label ID="lblUsuario105" Runat="server" Font-Names="Calibri" 
                                                            Font-Size="9pt" style="text-align: left" Width="100px">Apellidos :</asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="TxtcApellidos" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                            Height="20px" TabIndex="3" Width="500px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style60">
                                                                            <asp:Label ID="lblUsuario87" Runat="server" Font-Names="Calibri" 
                                                            Font-Size="9pt" style="text-align: left" Width="100px">Nombre de Socio :</asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="Txtctitular" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                            Height="20px" TabIndex="4" Width="500px"></asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style60">
                                                                            <asp:Label ID="lblUsuario32" Runat="server" Font-Names="Calibri" 
                                                            Font-Size="9pt" style="text-align: left" Width="100px">Fecha :</asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="Txtdfeccnt" runat="server" AutoPostBack="True" 
                                                            BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                            Font-Size="8pt" Height="20px" TabIndex="5" Width="105px"></asp:TextBox>
                                                                            <cc2:MaskedEditExtender ID="Masked_EditExt1" runat="server" 
                                                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                            Mask="99/99/9999" MaskType="Date" TargetControlID="Txtdfeccnt">
                                                                            </cc2:MaskedEditExtender>
                                                                            <cc2:CalendarExtender ID="Calendar_Ext1" runat="server" Enabled="True" 
                                                            Format="dd/MM/yyyy" PopupButtonID="Image_btn1" 
                                                            TargetControlID="Txtdfeccnt">
                                                                            </cc2:CalendarExtender>
                                                                            <asp:ImageButton ID="Image_btn1" runat="server" Enabled="False" 
                                                            ImageUrl="~/web/gifs/Calendar_scheduleHS.png" />
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style60">
                                                                            <asp:Label ID="lblUsuario91" Runat="server" Font-Names="Calibri" 
                                                            Font-Size="9pt" style="text-align: left" Width="100px">Número Libreta:</asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="Txtnlibreta" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                            Height="20px" MaxLength="4" onkeypress="return SoloNumeros(event)" TabIndex="6" 
                                                            Width="105px">0</asp:TextBox>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style60">
                                                                            <asp:Label ID="lblUsuario101" Runat="server" Font-Names="Calibri" 
                                                            Font-Size="9pt" style="text-align: left" Width="100px">Tipo de Cta.:</asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <cc1:CbxTipAho ID="CbxTipAho1" runat="server" AutoPostBack="True" 
                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" TabIndex="7" 
                                                            Width="250px">
                                                                            </cc1:CbxTipAho>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td class="style60">
                                                                            <asp:Label ID="lblUsuario102" Runat="server" Font-Names="Calibri" 
                                                            Font-Size="9pt" style="text-align: left" Width="100px">Linea de Ahorro:</asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <cc1:CbxLinAhoProd ID="CbxLinAhoProd1" runat="server" Enabled="False" 
                                                            Font-Names="Calibri" Font-Size="10pt" Width="500px">
                                                                            </cc1:CbxLinAhoProd>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style32">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style32">
                                                                <asp:UpdatePanel ID="UpdatePanel1" runat="server" Visible="False">
                                                                    <ContentTemplate>
                                                                        <table cellpadding="0" cellspacing="0" class="style63">
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                        Font-Size="10pt" Text="Firmas Autorizadas"></asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <table cellpadding="0" cellspacing="0" class="style34">
                                                                                        <tr>
                                                                                            <td class="style61" style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario106" Runat="server" Font-Names="Calibri" 
                                                                                                    Font-Size="9pt">Id:</asp:Label>
                                                                                            </td>
                                                                                            <td class="style62" style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario107" Runat="server" Font-Names="Calibri" 
                                                                                                    Font-Size="9pt">Nombre:</asp:Label>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario108" Runat="server" Font-Names="Calibri" 
                                                                                                    Font-Size="9pt" Height="26px" style="text-align: center" Width="142px">Fecha Nacimiento:</asp:Label>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario109" Runat="server" Font-Names="calibri" 
                                                                                                    Font-Size="9pt">No DUI:</asp:Label>
                                                                                            </td>
                                                                                            <td>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="style61" style="text-align: center">
                                                                                                <asp:TextBox ID="Txtnlinea0" runat="server" BorderColor="#2E6A99" 
                                                                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                                    Height="20px" style="text-align: left" TabIndex="14" Width="30px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td class="style62" style="text-align: center">
                                                                                                <asp:TextBox ID="TxtcNomFir" runat="server" BorderColor="#2E6A99" 
                                                                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                                    Height="20px" style="text-align: left" TabIndex="10" Width="250px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:TextBox ID="Txtdnacimi0" runat="server" AutoPostBack="True" 
                                                                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                                                                    Font-Size="8pt" Height="20px" TabIndex="11" Width="105px"></asp:TextBox>
                                                                                                <cc2:MaskedEditExtender ID="Txtdnacimi0_MaskedEditExtender" runat="server" 
                                                                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="Txtdnacimi0">
                                                                                                </cc2:MaskedEditExtender>
                                                                                                <cc2:CalendarExtender ID="Txtdnacimi0_CalendarExtender" runat="server" 
                                                                                                    Enabled="True" Format="dd/MM/yyyy" PopupButtonID="Image_btn5" 
                                                                                                    TargetControlID="Txtdnacimi0">
                                                                                                </cc2:CalendarExtender>
                                                                                                <asp:ImageButton ID="Image_btn5" runat="server" 
                                                                                                    ImageUrl="~/web/gifs/Calendar_scheduleHS.png" TabIndex="11" />
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:TextBox ID="TxtcnudociFir" runat="server" BorderColor="#2E6A99" 
                                                                                                    BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                                                                    Height="20px" TabIndex="12" Width="120px"></asp:TextBox>
                                                                                                <cc2:MaskedEditExtender ID="TxtcnudociFir_MaskedEditExtender" runat="server" 
                                                                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                                                                    Mask="99999999-9" MaskType="Number" TargetControlID="TxtcnudociFir">
                                                                                                </cc2:MaskedEditExtender>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:ImageButton ID="btnproc0" runat="server" Enabled="False" 
                                                                                                    ImageUrl="~/Imagenes/add.png" style="width: 24px" TabIndex="13" />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:GridView ID="GridFirm" runat="server" AutoGenerateColumns="False" 
                                                                                        AutoGenerateSelectButton="True" BackColor="White" BorderColor="#336666" 
                                                                                        BorderStyle="Double" BorderWidth="3px" CellPadding="4" CssClass="" 
                                                                                        Font-Names="Calibri" Font-Size="10pt" GridLines="Horizontal" ShowFooter="True" 
                                                                                        Width="773px">
                                                                                        <RowStyle BackColor="White" ForeColor="#333333" />
                                                                                        <Columns>
                                                                                            <asp:BoundField DataField="IdCuenta" HeaderText="Id">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="left" />
                                                                                            </asp:BoundField>
                                                                                            <asp:BoundField DataField="cNomFir" HeaderText="Nombre de Firma">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="left" />
                                                                                            </asp:BoundField>
                                                                                            <asp:BoundField DataField="dnacimi" DataFormatString="{0:d}" 
                                                                                                HeaderText="Nacimiento">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                            </asp:BoundField>
                                                                                            <asp:BoundField DataField="cnudoci" HeaderText="No DUI">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="center" />
                                                                                            </asp:BoundField>
                                                                                            <asp:TemplateField>
                                                                                                <ItemTemplate>
                                                                                                    <asp:ImageButton ID="ibt0" runat="server" 
                                                                                                        CommandArgument='<%# Bind("idcuenta") %>' ImageUrl="~/imagenes/delete.png" 
                                                                                                        onclick="ibt_Click" 
                                                                                                        onclientclick="return confirm('¿Confirma que desea eliminar el registro indicado?');" />
                                                                                                </ItemTemplate>
                                                                                            </asp:TemplateField>
                                                                                        </Columns>
                                                                                        <FooterStyle BackColor="White" ForeColor="#333333" />
                                                                                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                                                                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                                                                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                                                                    </asp:GridView>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                        Font-Size="10pt" Text="Detalle de Beneficiarios"></asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <table cellpadding="0" cellspacing="0" class="style34">
                                                                                        <tr>
                                                                                            <td style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario93" Runat="server" Font-Names="Calibri" 
                                                                                                    Font-Size="9pt">Id:</asp:Label>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario26" Runat="server" Font-Names="Calibri" 
                                                                                                    Font-Size="9pt">Nombre:</asp:Label>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario85" Runat="server" Font-Names="Calibri" 
                                                                                                    Font-Size="9pt" Height="26px" style="text-align: center" Width="125px">Fecha Nacimiento:</asp:Label>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario33" Runat="server" Font-Names="Calibri" 
                                                                                                    Font-Size="9pt" style="text-align: center" Width="100px">Parentesco:</asp:Label>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario28" Runat="server" Font-Names="calibri" 
                                                                                                    Font-Size="9pt">%:</asp:Label>
                                                                                            </td>
                                                                                            <td>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="text-align: center">
                                                                                                <asp:TextBox ID="Txtnlinea" runat="server" BorderColor="#2E6A99" 
                                                                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                                    Height="20px" style="text-align: left" TabIndex="14" Width="30px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:TextBox ID="TxtcNomben" runat="server" BorderColor="#2E6A99" 
                                                                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                                    Height="20px" style="text-align: left" TabIndex="14" Width="250px"></asp:TextBox>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:TextBox ID="Txtdnacimi" runat="server" AutoPostBack="True" 
                                                                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                                                                    Font-Size="8pt" Height="20px" TabIndex="15" Width="105px"></asp:TextBox>
                                                                                                <cc2:MaskedEditExtender ID="Txtdnacimi_MaskedEditExtender" runat="server" 
                                                                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="Txtdnacimi">
                                                                                                </cc2:MaskedEditExtender>
                                                                                                <cc2:CalendarExtender ID="Txtdnacimi_CalendarExtender" runat="server" 
                                                                                                    Enabled="True" Format="dd/MM/yyyy" PopupButtonID="Image_btn4" 
                                                                                                    TargetControlID="Txtdnacimi">
                                                                                                </cc2:CalendarExtender>
                                                                                                <asp:ImageButton ID="Image_btn4" runat="server" 
                                                                                                    ImageUrl="~/web/gifs/Calendar_scheduleHS.png" TabIndex="15" />
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <cc1:CbxParentesco ID="CbxParentesco1" runat="server" 
                                                                                                    AppendDataBoundItems="True" Enabled="False" Font-Names="Calibri" 
                                                                                                    Font-Size="10pt" TabIndex="16" Width="150px">
                                                                                                    <asp:ListItem Value="00">Seleccione una Opción</asp:ListItem>
                                                                                                </cc1:CbxParentesco>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:TextBox ID="TxtnPorcen" runat="server" BorderColor="#2E6A99" 
                                                                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                                    Height="20px" MaxLength="6" onkeypress="return NumCheck(event, this)" 
                                                                                                    style="text-align: left" TabIndex="17" Width="100px">0.00</asp:TextBox>
                                                                                                <cc2:MaskedEditExtender ID="MaskedEdit_Ext2" runat="server" 
                                                                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                                                                    InputDirection="RightToLeft" Mask="999.99" MaskType="Number" 
                                                                                                    TargetControlID="TxtnPorcen">
                                                                                                </cc2:MaskedEditExtender>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:ImageButton ID="btnproc" runat="server" Enabled="False" 
                                                                                                    ImageUrl="~/Imagenes/add.png" TabIndex="19" />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <table cellpadding="0" cellspacing="0" class="style36">
                                                                                        <tr>
                                                                                            <td class="style45" style="text-align: center">
                                                                                                <asp:Label ID="lblUsuario110" Runat="server" Font-Names="Calibri" 
                                                                                                    Font-Size="9pt" style="text-align: left" Width="90px">Dirección:</asp:Label>
                                                                                            </td>
                                                                                            <td class="style45">
                                                                                                <asp:TextBox ID="TxtcDirBen" runat="server" BorderColor="#2E6A99" 
                                                                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                                    Height="21px" TabIndex="18" Width="649px"></asp:TextBox>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:GridView ID="GridBen" runat="server" AutoGenerateColumns="False" 
                                                                                        AutoGenerateSelectButton="True" BackColor="White" BorderColor="#336666" 
                                                                                        BorderStyle="Double" BorderWidth="3px" CellPadding="4" CssClass="" 
                                                                                        Font-Names="Calibri" Font-Size="10pt" GridLines="Horizontal" ShowFooter="True" 
                                                                                        Width="773px">
                                                                                        <RowStyle BackColor="White" ForeColor="#333333" />
                                                                                        <Columns>
                                                                                            <asp:BoundField DataField="IdCuenta" HeaderText="Id">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="left" />
                                                                                            </asp:BoundField>
                                                                                            <asp:BoundField DataField="cNomBen" HeaderText="Nombre del Beneficiario">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="left" />
                                                                                            </asp:BoundField>
                                                                                            <asp:BoundField DataField="dnacimi" DataFormatString="{0:d}" 
                                                                                                HeaderText="Nacimiento">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="Center" />
                                                                                            </asp:BoundField>
                                                                                            <asp:BoundField DataField="cParent" HeaderText="Parentesco">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="center" />
                                                                                            </asp:BoundField>
                                                                                            <asp:BoundField DataField="cDirecc" HeaderText="Direccion">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="left" />
                                                                                            </asp:BoundField>
                                                                                            <asp:BoundField DataField="nporcen" HeaderText="Porcentaje">
                                                                                                <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                                                                                <ItemStyle HorizontalAlign="left" />
                                                                                            </asp:BoundField>
                                                                                            <asp:TemplateField>
                                                                                                <ItemTemplate>
                                                                                                    <asp:ImageButton ID="ibt" runat="server" 
                                                                                                        CommandArgument='<%# Bind("idcuenta") %>' ImageUrl="~/imagenes/delete.png" 
                                                                                                        onclick="ibt_Click" 
                                                                                                        onclientclick="return confirm('¿Confirma que desea eliminar el registro indicado?');" />
                                                                                                </ItemTemplate>
                                                                                            </asp:TemplateField>
                                                                                        </Columns>
                                                                                        <FooterStyle BackColor="White" ForeColor="#333333" />
                                                                                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                                                                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                                                                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                                                                    </asp:GridView>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    &nbsp;</td>
                                                                            </tr>
                                                                        </table>
                                                                    </ContentTemplate>
                                                                </asp:UpdatePanel>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style33">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <table cellpadding="0" cellspacing="0" class="style1">
                                                                    <tr>
                                                                        <td style="text-align: center">
                                                                            <asp:Button ID="btnnew" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                Font-Size="9pt" Height="27px" Text="Nuevo" Visible="False" Width="120px" />
                                                                        </td>
                                                                        <td style="text-align: center">
                                                                            <asp:Button ID="btnEdit" runat="server" Enabled="False" Font-Bold="True" 
                                                                                Font-Names="Calibri" Font-Size="9pt" Height="27px" Text="Editar" 
                                                                                Width="120px" />
                                                                        </td>
                                                                        <td style="text-align: center">
                                                                            <asp:Button ID="btncancel" runat="server" Enabled="False" Font-Bold="True" 
                                                                                Font-Names="Calibri" Font-Size="9pt" Height="27px" Text="Cancelar" 
                                                                                Width="120px" />
                                                                        </td>
                                                                        <td style="text-align: center">
                                                                            <asp:Button ID="btnsave" runat="server" Enabled="False" Font-Bold="True" 
                                                                                Font-Names="Calibri" Font-Size="9pt" Height="27px" TabIndex="20" 
                                                                                Text="Actualizar" Width="120px" />
                                                                            <cc2:ConfirmButtonExtender ID="Confirm_BtnExt1" runat="server" 
                                                                                ConfirmText="Realmente Desea Continuar ?" Enabled="True" 
                                                                                TargetControlID="btnsave">
                                                                            </cc2:ConfirmButtonExtender>
                                                                        </td>
                                                                        <td style="text-align: center">
                                                                            <asp:Button ID="btn_imprimir" runat="server" Font-Bold="True" 
                                                                                Font-Names="Calibri" Font-Size="9pt" Height="27px" Text="Imprimir" 
                                                                                Visible="False" Width="120px" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:View>
                                            </asp:MultiView>
                                        </td>
                                    </tr>
                                </table>
                            
                    </td>
                </tr>
</table>

