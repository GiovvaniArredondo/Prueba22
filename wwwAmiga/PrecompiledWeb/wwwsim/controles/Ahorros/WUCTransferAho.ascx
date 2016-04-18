<%@ control language="VB" autoeventwireup="false" inherits="controles_Ahorros_WUCTransferAho, App_Web_kxy_ccyk" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc11" %>
<style type="text/css">
    .style2
    {
        width: 100%;
    }
    
    .transpare 
     {
     font-family: Tahoma;
     font-size: 11px;  
     }
     

     .style1
    {
        width: 100%;
        height: 48px;
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
                
     
     .style59
    {
        width: 100%;
        height: 121px;
    }
                    
     
    .style61
    {
        width: 126px;
        height: 25px;
    }
    .style62
    {
        height: 25px;
    }
                
     
        
     .style65
    {
        width: 126px;
        height: 28px;
    }
    .style66
    {
        height: 28px;
    }
    .style67
    {
        width: 126px;
        height: 30px;
    }
    .style68
    {
        height: 30px;
    }
                
     
        
     .style60
    {
        width: 126px;
    }
                
     
            
     .style63
    {
        width: 126px;
        height: 31px;
    }
    .style64
    {
        height: 31px;
    }
                    
     
        
     </style>

            <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                            <ContentTemplate>
                                <table cellpadding="0" cellspacing="0" class="style1">
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
                                                            <asp:ListItem Value="01">Transferencia Ahorros</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:MultiView ID="MtvPrinci" runat="server">
                                                <asp:View ID="ViewCreditos" runat="server">
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
                                                                                                    <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                                                                                        <ContentTemplate>
                                                                                                            &nbsp;
                                                                                                        </ContentTemplate>
                                                                                                    </asp:UpdatePanel>
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
                                                    <table cellpadding="0" cellspacing="0" class="style1" 
                                    style="width: 750px; height: 600px; margin-right: 0px;">
                                                        <tr>
                                                            <td>
                                                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                                    <ContentTemplate>
                                                                        <table cellpadding="0" cellspacing="0" class="style1">
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Label ID="Label101" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                    Font-Size="14pt" ForeColor="#000066" Text="TRANSFERENCIA ENTRE DE CUENTAS"></asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Label ID="Label104" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                    Font-Size="11pt" ForeColor="Red" Text="CUENTA ORIGEN"></asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <table cellpadding="0" cellspacing="0" class="style2">
                                                                                        <tr>
                                                                                            <td style="text-align: center">
                                                                                                <asp:TextBox ID="asociado_TextBox" runat="server" BorderColor="#2E6A99" 
                                                                                BorderWidth="1px" CssClass="transpare" Font-Names="Verdana" Font-Size="8pt" 
                                                                                Height="25px" style="margin-bottom: 0px" TabIndex="4" Width="350px"></asp:TextBox>
                                                                                                <cc1:TextBoxWatermarkExtender ID="asociado_TextBox_TextBoxWatermarkExtender" 
                                                                                runat="server" Enabled="True" TargetControlID="asociado_TextBox" 
                                                                                WatermarkCssClass="Watermark" WatermarkText="DIGITE EL NOMBRE DEL ASOCIADO ORIGEN">
                                                                                                </cc1:TextBoxWatermarkExtender>
                                                                                            </td>
                                                                                            <td>
                                                                                                <asp:Button ID="btnfind" runat="server" Font-Names="Calibri" Font-Size="11pt" 
                                                                                Text="Buscar Origen" Width="120px" Height="28px" />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:GridView ID="Gridfind" runat="server" AllowPaging="True" 
                                                                    AutoGenerateColumns="False" Caption="Lineas de Socios" CssClass="grid" 
                                                                    Width="692px" Visible="False">
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
                                                                                            <asp:BoundField DataField="nmonres" HeaderText="Monto Bloqueado">
                                                                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                                                                <ItemStyle Font-Names="Gill Sans MT" />
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
                                                                                    &nbsp;</td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                                                                                        <ContentTemplate>
                                                                                            <table cellpadding="0" cellspacing="0" class="style59">
                                                                                                <tr>
                                                                                                    <td class="style61">
                                                                                                        <asp:Label ID="lblUsuario106" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" style="text-align: left" Width="125px">Cod. Asociado Orig. :</asp:Label>
                                                                                                    </td>
                                                                                                    <td class="style62">
                                                                                                        <asp:TextBox ID="TxtcCodcli_Origen" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        Height="20px" TabIndex="1" Width="105px"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style65">
                                                                                                        <asp:Label ID="lblUsuario108" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" Height="16px" style="text-align: left" Width="120px">No Cta Ahorro Origen:</asp:Label>
                                                                                                    </td>
                                                                                                    <td class="style66">
                                                                                                        <asp:TextBox ID="TxtcCodaho_Origen" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        Height="20px" TabIndex="1" Width="105px"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style67">
                                                                                                        <asp:Label ID="lblUsuario110" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" style="text-align: left" Width="140px">Nombre Asociado Orig. :</asp:Label>
                                                                                                    </td>
                                                                                                    <td class="style68">
                                                                                                        <asp:TextBox ID="Txtcnomcli_Origen" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        Height="20px" TabIndex="4" Width="500px"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style60">
                                                                                                        <asp:Label ID="lblUsuario118" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" style="text-align: left" Width="125px">Monto Restringido:</asp:Label>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                        <asp:TextBox ID="TxtnMonRes" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        ForeColor="Red" Height="20px" MaxLength="4" TabIndex="6" Width="105px">0</asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style63">
                                                                                                        <asp:Label ID="lblUsuario112" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" style="text-align: left" Width="125px">Saldo Cuenta Ahorro:</asp:Label>
                                                                                                    </td>
                                                                                                    <td class="style64">
                                                                                                        <asp:TextBox ID="TxtnSaldo" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        ForeColor="Red" Height="20px" MaxLength="4" TabIndex="6" Width="105px">0</asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style60">
                                                                                                        <asp:Label ID="lblUsuario116" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" style="text-align: left" Width="125px">Monto a Transferir:</asp:Label>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                        <asp:TextBox ID="TxtnMonto" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        ForeColor="Red" Height="20px" MaxLength="10" 
                                                                                        TabIndex="6" Width="105px">0</asp:TextBox>
                                                                                                        <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                                                                        ControlToValidate="TxtnMonto" ErrorMessage="Monto Invalido !!!" 
                                                                                        Font-Names="Calibri" Font-Size="11pt" MaximumValue="99999" 
                                                                                        MinimumValue="0"></asp:RangeValidator>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </ContentTemplate>
                                                                                    </asp:UpdatePanel>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Label ID="Label103" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                    Font-Size="11pt" ForeColor="Red" Text="CUENTA DESTINO"></asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <table cellpadding="0" cellspacing="0" class="style2">
                                                                                        <tr>
                                                                                            <td style="text-align: center">
                                                                                                <asp:TextBox ID="asociado_TextBox1" runat="server" BorderColor="#2E6A99" 
                                                                                BorderWidth="1px" CssClass="transpare" Font-Names="Verdana" Font-Size="8pt" 
                                                                                Height="25px" style="margin-bottom: 0px" TabIndex="4" Width="350px"></asp:TextBox>
                                                                                                <cc1:TextBoxWatermarkExtender ID="asociado_TextBox1_TextBoxWatermarkExtender" 
                                                                                runat="server" Enabled="True" TargetControlID="asociado_TextBox1" 
                                                                                WatermarkCssClass="Watermark" WatermarkText="DIGITE EL NOMBRE DEL ASOCIADO DESTINO">
                                                                                                </cc1:TextBoxWatermarkExtender>
                                                                                            </td>
                                                                                            <td>
                                                                                                <asp:Button ID="btnfind0" runat="server" Font-Names="Calibri" Font-Size="11pt" 
                                                                                Text="Buscar Destino" Width="120px" />
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:GridView ID="Gridfind_destino" runat="server" AllowPaging="True" 
                                                                    AutoGenerateColumns="False" Caption="Lineas de Socios" CssClass="grid" 
                                                                    Width="692px" Visible="False">
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
                                                                                            <asp:BoundField DataField="nmonres" HeaderText="Monto Bloqueado">
                                                                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                                                                <ItemStyle Font-Names="Gill Sans MT" />
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
                                                                                            <asp:DropDownList ID="paginasDropDownList0" runat="server" AutoPostBack="true" 
                                                                            Font-Size="12px" 
                                                                            onselectedindexchanged="paginasDropDownList_SelectedIndexChanged">
                                                                                            </asp:DropDownList>
                                                                                            de
                                                                                            <asp:Label ID="lblTotalNumberOfPages0" runat="server" />
                                                                                            <asp:Button ID="Button7" runat="server" CommandArgument="First" 
                                                                            CommandName="Page" CssClass="pagfirst" ToolTip="Prim. Pag" />
                                                                                            <asp:Button ID="Button8" runat="server" CommandArgument="Prev" 
                                                                            CommandName="Page" CssClass="pagprev" ToolTip="Pág. anterior" />
                                                                                            <asp:Button ID="Button9" runat="server" CommandArgument="Next" 
                                                                            CommandName="Page" CssClass="pagnext" ToolTip="Sig. página" />
                                                                                            <asp:Button ID="Button10" runat="server" CommandArgument="Last" 
                                                                            CommandName="Page" CssClass="paglast" onclick="Button10_Click" 
                                                                            ToolTip="Últ. Pag" />
                                                                                        </PagerTemplate>
                                                                                        <PagerStyle CssClass="pagerstyle" />
                                                                                        <AlternatingRowStyle BackColor="#99CCFF" />
                                                                                    </asp:GridView>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    &nbsp;</td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                                                                                        <ContentTemplate>
                                                                                            <table cellpadding="0" cellspacing="0" class="style59">
                                                                                                <tr>
                                                                                                    <td class="style61">
                                                                                                        <asp:Label ID="lblUsuario113" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" style="text-align: left" Width="125px">Cod. Asociado Dest. :</asp:Label>
                                                                                                    </td>
                                                                                                    <td class="style62">
                                                                                                        <asp:TextBox ID="TxtcCodcli_Destino" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        Height="20px" TabIndex="1" Width="105px"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style60">
                                                                                                        <asp:Label ID="lblUsuario114" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" Height="16px" style="text-align: left" Width="120px">No Cta Ahorro Dest.:</asp:Label>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                        <asp:TextBox ID="TxtcCodaho_Destino" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        Height="20px" TabIndex="1" Width="105px"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style60">
                                                                                                        <asp:Label ID="lblUsuario115" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" style="text-align: left" Width="140px">Nombre Asociado Dest. :</asp:Label>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                        <asp:TextBox ID="Txtcnomcli_Destino" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        Height="20px" TabIndex="4" Width="500px"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td class="style60">
                                                                                                        <asp:Label ID="lblUsuario117" Runat="server" Font-Names="Calibri" 
                                                                                        Font-Size="9pt" style="text-align: left" Width="140px">Concepto :</asp:Label>
                                                                                                    </td>
                                                                                                    <td>
                                                                                                        <asp:TextBox ID="Txtcglosa" runat="server" BorderColor="#2E6A99" 
                                                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                        Height="32px" TabIndex="4" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </ContentTemplate>
                                                                                    </asp:UpdatePanel>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <table cellpadding="0" cellspacing="0" class="style1">
                                                                                        <tr>
                                                                                            <td style="text-align: center">
                                                                                                <asp:Button ID="btnproc" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                                                Text="Procesar" Width="120px" Font-Bold="True" />
                                                                                                <cc1:ConfirmButtonExtender ID="btnproc_ConfirmButtonExtender" runat="server" 
                                                                                ConfirmText="Realmente Desea Continuar" Enabled="True" 
                                                                                TargetControlID="btnproc">
                                                                                                </cc1:ConfirmButtonExtender>
                                                                                            </td>
                                                                                            <td style="text-align: center">
                                                                                                <asp:Button ID="btnprint" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                                                Text="Imprimir" Width="120px" Font-Bold="True" Enabled="False" />
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </ContentTemplate>
                                                                    <Triggers>
                                                                        <asp:AsyncPostBackTrigger ControlID="btnproc" EventName="Click" />
                                                                        <asp:PostBackTrigger ControlID="btnfind" />
                                                                        <asp:PostBackTrigger ControlID="btnfind0" />                                                                       
                                                                        <asp:PostBackTrigger ControlID="btnprint" />
                                                                    </Triggers>
                                                                </asp:UpdatePanel>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:View>
                                            </asp:MultiView>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
</table>


