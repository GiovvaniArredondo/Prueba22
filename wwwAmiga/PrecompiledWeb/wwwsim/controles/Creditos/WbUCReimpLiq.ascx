<%@ control language="VB" autoeventwireup="false" inherits="controles_Creditos_WbUCReimpLiq, App_Web_6e0px9a3" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<style type="text/css">
    .style61
    {
        width: 100%;
    }
    .style1
    {
        width: 100%;
        height: 70px;
        margin-right: 0px;
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
                
     
    .style27
    {
        width: 774px;
        height: 386px;
    }
                    
     
    .style59
    {
        width: 100%;
        height: 323px;
    }
    .style60
    {
        width: 125px;
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

            <table cellpadding="0" cellspacing="0" class="style61">
                <tr>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td>
                                            &nbsp;</td>
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
                                                            <asp:ListItem Value="01">Busqueda de Cliente</asp:ListItem>
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
                                                                                                    
                                                                                                        <ContentTemplate>
                                                                                                            <fieldset ID="Catalogo0">
                                                                                                                <legend>
                                                                                                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                                                        Font-Size="10pt" Text="Busqueda de Socios"></asp:Label>
                                                                                                                </legend>
                                                                                                                <table cellpadding="0" cellspacing="0" class="style25" 
                                                                                                                    style="width: 600px; height: 350px">
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            <table cellpadding="0" cellspacing="0" class="style17">
                                                                                                                                <tr>
                                                                                                                                    <td class="style23" style="border: 1pt groove #FFFFFF; text-align: center">
                                                                                                                                        &nbsp;</td>
                                                                                                                                </tr>
                                                                                                                                <tr>
                                                                                                                                    <td style="border: 1pt groove #FFFFFF; text-align: center">
                                                                                                                                        <table cellpadding="0" cellspacing="0" class="style24">
                                                                                                                                            <tr>
                                                                                                                                                <td class="style53" style="text-align: center">
                                                                                                                                                    <asp:Label ID="lblUsuario82" Runat="server" Font-Names="calibri" 
                                                                                                                                                        Font-Size="9pt" Width="100px">Criterio a Evaluar:</asp:Label>
                                                                                                                                                </td>
                                                                                                                                                <td style="text-align: center">
                                                                                                                                                    <asp:TextBox ID="TxtcEvalua" runat="server" BorderColor="#2E6A99" 
                                                                                                                                                        BorderWidth="1px" Font-Names="Verdana" Font-Size="8pt" 
                                                                                                                                                        Height="29px" TabIndex="4" Width="350px" CssClass="transpare" 
                                                                                                                                                        onkeypress="return SoloLetras_Numeros(event)"></asp:TextBox>
                                                                                                                                                    <cc2:TextBoxWatermarkExtender ID="TxtcEvalua_TextBoxWatermarkExtender" 
                                                                                                                                                        runat="server" Enabled="True" TargetControlID="TxtcEvalua" 
                                                                                                                                                        WatermarkCssClass="Watermark" WatermarkText="DIGITE EL NOMBRE DEL CLIENTE">
                                                                                                                                                    </cc2:TextBoxWatermarkExtender>
                                                                                                                                                </td>
                                                                                                                                                <td>
                                                                                                                                                    <asp:Button ID="btnbuscar" runat="server" Font-Bold="True" Font-Names="calibri" 
                                                                                                                                                        Font-Size="9pt" Height="24px" Text="Buscar" Width="171px" />
                                                                                                                                                </td>
                                                                                                                                            </tr>
                                                                                                                                            <tr>
                                                                                                                                                <td class="style53" style="text-align: center">
                                                                                                                                                    &nbsp;</td>
                                                                                                                                                <td style="text-align: center">
                                                                                                                                                    &nbsp;</td>
                                                                                                                                                <td style="text-align: right">
                                                                                                                                                    &nbsp;</td>
                                                                                                                                            </tr>
                                                                                                                                        </table>
                                                                                                                                    </td>
                                                                                                                                </tr>
                                                                                                                            </table>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td style="text-align: center">
                                                                                                                            &nbsp;</td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td style="text-align: center">
                                                                                                                            <asp:GridView ID="GridViewDatos" runat="server" AllowPaging="True" 
                                                                                                                                AutoGenerateColumns="False" Caption="Listado de Clientes" CssClass="grid" 
                                                                                                                                Width="723px">
                                                                                                                                <Columns>
                                                                                                                                    <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                                                                                                                        <controlstyle font-names="Gill Sans MT" font-size="9pt" />
                                                                                                                                        <HeaderStyle BackColor="#99CCFF" />
                                                                                                                                    </asp:CommandField>
                                                                                                                                    <asp:BoundField DataField="asociado" HeaderText="Codigo Cliente">
                                                                                                                                        <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                                                                                                        <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                                    </asp:BoundField>
                                                                                                                                    <asp:BoundField DataField="nombre" HeaderText="Nombre del Asociado" 
                                                                                                                                        ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                                                                                                        <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                                                                                                                        <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="350px" />
                                                                                                                                    </asp:BoundField>
                                                                                                                                    <asp:BoundField DataField="dui" HeaderText="No CURP">
                                                                                                                                        <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                                                                                                        <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                                    </asp:BoundField>
                                                                                                                                    <asp:BoundField DataField="id_ife" HeaderText="No IFE">
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
                                                                                                                                    <asp:Button ID="Button7" runat="server" CommandArgument="First" 
                                                                                                                                        CommandName="Page" CssClass="pagfirst" ToolTip="Prim. Pag" />
                                                                                                                                    <asp:Button ID="Button8" runat="server" CommandArgument="Prev" 
                                                                                                                                        CommandName="Page" CssClass="pagprev" ToolTip="Pág. anterior" />
                                                                                                                                    <asp:Button ID="Button2" runat="server" CommandArgument="Next" 
                                                                                                                                        CommandName="Page" CssClass="pagnext" ToolTip="Sig. página" />
                                                                                                                                    <asp:Button ID="Button9" runat="server" CommandArgument="Last" 
                                                                                                                                        CommandName="Page" CssClass="paglast" ToolTip="Últ. Pag" />
                                                                                                                                </PagerTemplate>
                                                                                                                                <PagerStyle CssClass="pagerstyle" />
                                                                                                                                <AlternatingRowStyle BackColor="#99CCFF" />
                                                                                                                            </asp:GridView>
                                                                                                                            <asp:GridView ID="GridViewCreditos" runat="server" AutoGenerateColumns="False" 
                                                                                                                                Caption="Listado de Creditos" CssClass="grid" Width="723px">
                                                                                                                                <Columns>
                                                                                                                                    <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                                                                                                                        <controlstyle font-names="Gill Sans MT" font-size="9pt" />
                                                                                                                                        <HeaderStyle BackColor="#009900" />
                                                                                                                                    </asp:CommandField>
                                                                                                                                    <asp:BoundField DataField="codigo" HeaderText="NºPrestamo">
                                                                                                                                        <HeaderStyle BackColor="#009900" Font-Names="Gill Sans MT" 
                                                                                                                                        ForeColor="White" Width="150px" />
                                                                                                                                        <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                                    </asp:BoundField>                                                                                                                                    
                                                                                                                                    <asp:BoundField DataField="ncapdes" HeaderText="Monto" 
                                                                                                                                        ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                                                                                                        <HeaderStyle BackColor="#009900" Font-Names="Gill Sans MT" 
                                                                                                                                        ForeColor="White" />
                                                                                                                                        <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="100px" />
                                                                                                                                    </asp:BoundField>
                                                                                                                                    <asp:BoundField DataField="nsalcap" HeaderText="Saldo Capital" 
                                                                                                                                        ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                                                                                                        <HeaderStyle BackColor="#009900" Font-Names="Gill Sans MT" 
                                                                                                                                        ForeColor="White" />
                                                                                                                                        <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="100px" />
                                                                                                                                    </asp:BoundField>
                                                                                                                                    <asp:BoundField DataField="dfecvig" DataFormatString="{0:dd-MM-yyyy}" 
                                                                                                                                        HeaderText="Fecha">
                                                                                                                                        <HeaderStyle BackColor="#009900" Font-Names="Gill Sans MT" 
                                                                                                                                        ForeColor="White" />
                                                                                                                                        <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                                    </asp:BoundField>
                                                                                                                                    <asp:BoundField DataField="cestado" HeaderText="Estado">
                                                                                                                                        <HeaderStyle BackColor="#009900" Font-Names="Gill Sans MT" 
                                                                                                                                        ForeColor="White" Width="100px" />
                                                                                                                                        <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                                    </asp:BoundField>
                                                                                                                                    <asp:BoundField DataField="cnudoci" HeaderText="No CURP">
                                                                                                                                        <HeaderStyle BackColor="#009900" Font-Names="Gill Sans MT" 
                                                                                                                                        ForeColor="White" Width="100px" />
                                                                                                                                        <ItemStyle Font-Names="Gill Sans MT" />
                                                                                                                                    </asp:BoundField>                                                                                                                                    
                                                                                                                                </Columns>
                                                                                                                                <PagerStyle CssClass="pagerstyle" />
                                                                                                                                <AlternatingRowStyle BackColor="#99FF66" />
                                                                                                                            </asp:GridView>
                                                                                                                        </td>
                                                                                                                    </tr>
                                                                                                                    <tr>
                                                                                                                        <td>
                                                                                                                            &nbsp;</td>
                                                                                                                    </tr>
                                                                                                                </table>
                                                                                                            </fieldset>
                                                                                                        </ContentTemplate>                                                                                                   
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
                                                <asp:View ID="ViewLiquidacion" runat="server">
                                                    <table cellpadding="0" cellspacing="0" class="style61">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="lblUsuario109" Runat="server" Font-Bold="True" 
                                                                    Font-Names="Calibri" Font-Size="11pt" ForeColor="#000099" 
                                                                    style="text-align: left" Width="400px">ORDEN DE PAGO REFERENCIADA</asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <table cellpadding="0" cellspacing="0" class="style27">
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
                                                                                        <asp:Label ID="lblUsuario87" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="100px">Nombre de Socio :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtctitular" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="450px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario89" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="100px">No CURP:</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtcnudoci" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="150px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario119" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="100px">No IFE:</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="TxtcIFE" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="150px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario110" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="100px">No Prestamo :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtccodcta" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="150px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario111" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="120px">Fecha de Emisión :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtdfecvig" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="105px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario112" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="120px">Plazo (Meses):</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtnplazo" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="105px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario88" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="100px">Cuota :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtncuota" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="105px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario113" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="130px">Monto Desembolsado :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtncapdes" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="105px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario114" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="130px">Vencimiento :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtdfecven" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="105px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario115" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="130px">Linea de Crédito :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtclinea" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="550px"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario117" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="130px" Visible="False">No Cta. a la Vista :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="TxtcctaVista" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="150px" Visible="False"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario116" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="130px" Visible="False">No Transacción :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtcnrodoc" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" TabIndex="2" Width="105px" Visible="False"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style60">
                                                                                        <asp:Label ID="lblUsuario118" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="9pt" style="text-align: left" Width="130px" Visible="False">No Factura :</asp:Label>
                                                                                    </td>
                                                                                    <td>
                                                                                        <asp:TextBox ID="Txtcnofact" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" MaxLength="10" TabIndex="2" Width="105px"
                                                                                            onkeypress="return SoloNumeros(event)" Visible="False" ></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <table cellpadding="0" cellspacing="0" class="style1">
                                                                                <tr>
                                                                                    <td style="text-align: center">
                                                                                        <table cellpadding="0" cellspacing="0" class="style61">
                                                                                            <tr>
                                                                                                <td style="text-align: center">
                                                                                                    <asp:Button ID="btnImprime" runat="server" Enabled="False" Font-Bold="True" 
                                                                                                        Font-Names="Calibri" Font-Size="9pt" Height="27px" TabIndex="22" 
                                                                                                        Text="Imprimir Detalle" Width="145px" Visible="False" />
                                                                                                </td>
                                                                                                <td style="text-align: center">
                                                                                                    <asp:Button ID="btnImprime1" runat="server" Enabled="False" Font-Bold="True" 
                                                                                                        Font-Names="Calibri" Font-Size="9pt" Height="27px" TabIndex="22" 
                                                                                                        Text="Re-Impre Orden-Referencia" Width="145px" />
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
                                            </asp:MultiView>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                            <Triggers>
                                 <asp:PostBackTrigger ControlID="btnImprime" />
                                 <asp:PostBackTrigger ControlID="btnImprime1" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </td>
                </tr>
</table>




