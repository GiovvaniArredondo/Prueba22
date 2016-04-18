<%@ Control Language="vb" AutoEventWireup="false" Codefile="rpt_historial_ahorros.ascx.vb" Inherits="rpt_historial_ahorros"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>
<%@ Register namespace="AjaxControlToolkit" tagprefix="AjaxControlToolkit" %>


    <title>Historial de Cuentas</title>
    <style type="text/css">
        .style1
        {
            width: 62%;
        }
        .style2
        {
            width: 372px;
        }
        .style3
        {
            width: 133px;
        }
        .style4
        {
            width: 81%;
        }
        .style5
        {
            width: 57px;
        }
        .style6
        {
            width: 100px;
        }
        .style7
        {
            width: 78%;
        }
        .style8
        {
            height: 39px;
            width: 832px;
        }
        .style9
        {
            width: 832px;
        }
    </style>
</head>
</body>
    <table border="1" cellpadding="0" cellspacing="0" class="style4" 
        style="border-color: #003366">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style4">
                    <tr>
                        <td align="center" class="style9">
    
			<asp:label id="Label1" runat="server" Width="336px" Font-Bold="True" Font-Names="Verdana" Font-Size="Medium"
				ForeColor="#16387C" Height="15px">HISTORIAL DE CUENTAS</asp:label>
    
                        </td>
                    </tr>
                    <tr>
                        <td class="style9">
        
        <table class="style1">
            <tr>
                <td class="style2">
                    <asp:TextBox ID="asociado_TextBox" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Width="370px" BorderWidth="1px" Height="25px" BorderColor="#2E6A99" 
                        CssClass="transpare"></asp:TextBox>
                    <asp:TextBoxWatermarkExtender ID="asociado_TextBox_TextBoxWatermarkExtender" 
                        runat="server" Enabled="True" TargetControlID="asociado_TextBox" 
                        WatermarkText="Digite el nombre o código de asociado" 
                        WatermarkCssClass="Watermark">
                    </asp:TextBoxWatermarkExtender>
                </td>
                <td>
                    <asp:ImageButton ID="buscar_Button" runat="server" Height="31px" 
                        ImageUrl="~/web/jpgs/btn_buscar_b.jpg" Width="41px" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="28px" 
                        ImageUrl="~/web/jpgs/repetir.png" Width="43px" style="margin-left: 0px" />
                </td>
                <td>
                    <asp:Label ID="mensaje" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Text="No existe!!!" Font-Bold="True" ForeColor="Red" 
                        Visible="False"></asp:Label>
                </td>
                <td>
                    <asp:Image ID="foto_image" runat="server" Visible="False" BorderWidth="1px" />
                </td>
            </tr>
            </table>
    
                        </td>
                    </tr>
                    <tr>
                        <td class="style9">
        
                                <asp:GridView ID="GridViewDatos" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" Caption="Listado de Clientes" CssClass="grid" 
                                    Width="618px">
                                    <Columns>
                                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                            <ControlStyle Font-Names="Gill Sans MT" Font-Size="9pt" />
                                            <HeaderStyle BackColor="#99CCFF" />
                                        </asp:CommandField>
                                        <asp:BoundField DataField="ccodcli" HeaderText="Codigo Asociado">
                                            <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:BoundField>                                        
                                        <asp:BoundField DataField="cnomcli" HeaderText="Nombre del Asociado" 
                                            ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                            <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="350px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="cnudoci" HeaderText="No Doc">
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
                                        <asp:Button ID="Button2" runat="server" CommandArgument="Next" 
                                            CommandName="Page" CssClass="pagnext" ToolTip="Sig. página" />
                                        <asp:Button ID="Button3" runat="server" CommandArgument="Last" 
                                            CommandName="Page" CssClass="paglast" ToolTip="Últ. Pag" />
                                    </PagerTemplate>
                                    <PagerStyle CssClass="pagerstyle" />
                                    <AlternatingRowStyle BackColor="#99CCFF" />
                                </asp:GridView>
    
                <asp:GridView ID="cuentas_GridView" runat="server" BackColor="White" 
        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                        Visible="False" Font-Names="Verdana" Font-Size="10pt" 
                        AutoGenerateColumns="False" Width="760px">
        <RowStyle BackColor="White" ForeColor="#333333" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" InsertVisible="False" 
                            SelectText="Seleccionar" ShowCancelButton="False" ShowSelectButton="True" >
                        <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                        <HeaderStyle Font-Names="Calibri" Font-Size="10pt" />
                        <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:CommandField>
                        <asp:BoundField DataField="cuenta" HeaderText="CUENTA" >
                        <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                        <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tipo_cta" HeaderText="TIPO CUENTA" >
                        <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                        <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="saldo" HeaderText="SALDO" >
                        <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                        <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="NOTAS" HeaderText="NOTAS" InsertVisible="False" >
                        <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                        <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="PRODUCTO" HeaderText="PRODUCTO">
                        <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                        <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="NMONRES" HeaderText="MONTO BLOQUEADO" InsertVisible="False" >
                        <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                        <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cestado" HeaderText="ESTADO">
                        <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                        <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        
                    </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#336666" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="#99FF33" />
    </asp:GridView>
    
                        </td>
                    </tr>
                    <tr>
                        <td class="style9">
    
                            <asp:CheckBox ID="llBandera" runat="server" AutoPostBack="True" 
                                Font-Bold="True" Font-Names="Calibri" Font-Size="11pt" 
                                Text="Filtrar Movimientos" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style9">
    
                            <table cellpadding="0" cellspacing="0" class="style7">
                                <tr>
                                    <td style="text-align: center">
                                        <asp:Label ID="lblUsuario78" Runat="server" Font-Names="calibri" 
                                            Font-Size="9pt" style="font-weight: 700; font-size: 11pt" Visible="False">Fecha Inicio:</asp:Label>
                                        <asp:Label ID="lblUsuario79" Runat="server" Font-Names="calibri" 
                                            Font-Size="9pt" ForeColor="#CC0000" Visible="False">{*}</asp:Label>
                                    </td>
                                    <td style="text-align: center">
                                        <asp:TextBox ID="Txtdfecini" runat="server" BorderColor="#2E6A99" 
                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                            Height="20px" TabIndex="6" Visible="False" Width="105px"></asp:TextBox>                                        
                                        <asp:MaskedEditExtender ID="Masked_EditExt5" runat="server" 
                                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                            Mask="99/99/9999" MaskType="Date" TargetControlID="Txtdfecini">
                                        </asp:MaskedEditExtender>
                                        <asp:CalendarExtender ID="Calendar_Extender2" runat="server" 
                                            Enabled="True" Format="dd/MM/yyyyy" PopupButtonID="Image_btn2" 
                                            TargetControlID="Txtdfecini">
                                        </asp:CalendarExtender>
                                        <asp:ImageButton ID="Image_btn2" runat="server" 
                                            ImageUrl="~/web/gifs/Calendar_scheduleHS.png" Visible="False" />
                                    </td>
                                    <td>
                                        <asp:Label ID="lblUsuario96" Runat="server" Font-Names="calibri" 
                                            Font-Size="9pt" style="font-weight: 700; font-size: 11pt" Visible="False">Fecha Fin:</asp:Label>
                                        <asp:Label ID="lblUsuario81" Runat="server" Font-Names="calibri" 
                                            Font-Size="9pt" ForeColor="#CC0000" Visible="False">{*}</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Txtdfecfin" runat="server" BorderColor="#2E6A99" 
                                            BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                            Height="20px" TabIndex="6" Visible="False" Width="105px"></asp:TextBox>
                                        <asp:MaskedEditExtender ID="Masked_EditExt6" runat="server" 
                                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                            Mask="99/99/9999" MaskType="Date" TargetControlID="Txtdfecfin">
                                        </asp:MaskedEditExtender>
                                        <asp:CalendarExtender ID="Calendar_Ext3" runat="server" 
                                            Enabled="True" Format="dd/MM/yyyy" PopupButtonID="Image_btn3" 
                                            TargetControlID="Txtdfecfin">
                                        </asp:CalendarExtender>
                                        <asp:ImageButton ID="Image_btn3" runat="server" 
                                            ImageUrl="~/web/gifs/Calendar_scheduleHS.png" Visible="False" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="style8" style="text-align: center">
    
                            <asp:Button ID="btnHistori" runat="server" Enabled="False" Font-Bold="True" 
                                Font-Names="Calibri" Font-Size="9pt" Height="27px" TabIndex="22" 
                                Text="General Historial" Visible="False" Width="150px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style9">
    <table class="style1">
        <tr>
            <td class="style3">
                            <asp:TextBox ID="TextBox1" runat="server" BorderWidth="1px" Visible="False" 
                                Width="52px"></asp:TextBox></td><td>
                <asp:Button ID="generar_Button" runat="server" BackColor="#99CC00" 
                    Text="Generar Historial" Visible="False" Font-Names="Calibri" 
                    Font-Size="12pt" />
            </td>
            <td class="style5">
                <asp:Label ID="total_ahorros_Label" runat="server" Text="Total Ahorros..." 
                    Visible="False"></asp:Label></td><td class="style6">
                <asp:TextBox ID="total_ahorros_TextBox" runat="server" Visible="False" 
                    Width="100px"></asp:TextBox></td></tr></td></tr></table></td></tr></table>