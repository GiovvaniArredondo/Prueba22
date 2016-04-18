<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbUCSolLquidSocio.ascx.vb" Inherits="controles_Ahorros_WbUCSolLquidSocio" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc2" %>


    
<script language='JavaScript'>
    document.onkeydown = function(evt) { return (evt ? evt.which : event.keyCode) != 13; }


    //Esta función solo permite numeros, se invoca desde el evento onkeypress Ejemplo onkeypress="return SoloNumeros(event)"
    function SoloNumeros(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode == 08 || charCode == 32 || charCode == 45)
            return true;
        else if (charCode >= 48 && charCode <= 57)
            return true; return false;
    }

</script>



<script language="javascript" type="text/javascript">
    function DoPostBack() {
        __doPostBack('postback_Button', '');
    }
</script>

<style type="text/css">
    .style1
    {
        width: 100%;
    }
        .style27
        {
            width: 170px;
            text-align: left;
        }
        .style3
        {
            width: 192px;
        }
        .style4
        {
            width: 172px;
        }
        .style5
        {
            width: 175px;
        }
        .style30
        {
            width: 170px;
            height: 24px;
        }
        .style32
        {
            width: 192px;
            height: 24px;
        }
        .style38
        {
            width: 172px;
            height: 24px;
        }
        .style19
        {
            width: 175px;
            height: 24px;
        }
        </style>
<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>
                    <table cellpadding="0" cellspacing="0" class="style1">
                        <tr>
                            <td>
                                <table style="width: 58%;">
                                    <tr>
                                        <td class="style1">
                                            &nbsp;
                                            <asp:TextBox ID="asociado_TextBox" runat="server" BorderColor="#2E6A99" 
                                                BorderWidth="1px" CssClass="transpare" Font-Names="Verdana" Font-Size="8pt" 
                                                Height="25px" style="margin-bottom: 0px" TabIndex="4" Width="350px"></asp:TextBox>
                                            <cc1:TextBoxWatermarkExtender ID="asociado_TextBox_TextBoxWatermarkExtender" 
                                                runat="server" Enabled="True" TargetControlID="asociado_TextBox" 
                                                WatermarkCssClass="Watermark" WatermarkText="DIGITE EL NOMBRE DEL ASOCIADO">
                                            </cc1:TextBoxWatermarkExtender>
                                        </td>
                                        <td>
                                            &nbsp;
                                            <asp:Button ID="buscar_Button" runat="server" Font-Bold="False" 
                                                Font-Names="Calibri" Font-Size="11pt" Text="Buscar" Width="120px" />
                                            <asp:Label ID="mensaje" runat="server" Font-Bold="True" Font-Names="Verdana" 
                                                Font-Size="10pt" ForeColor="Red" Text="No existe!!!" Visible="False"></asp:Label>
                                        </td>
                                        <td>
                                            &nbsp;
                                            <asp:Image ID="foto_Image" runat="server" BorderWidth="1px" Visible="False" />
                                            <asp:ImageButton ID="repetir_ImageButton" runat="server" Height="25px" 
                                                ImageUrl="~/web/jpgs/repetir.png" Width="35px" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="GridViewDatos" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" Caption="Listado de Asociados" CssClass="grid" 
                                    Visible="False" Width="755px">
                                    <Columns>
                                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                            <ControlStyle Font-Names="Gill Sans MT" Font-Size="9pt" />
                                            <HeaderStyle BackColor="#99CCFF" />
                                        </asp:CommandField>
                                        <asp:BoundField DataField="asociado" HeaderText="Codigo Asociado">
                                            <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="ccodant" HeaderText="Ref.Anterior">
                                            <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="nombre" HeaderText="Nombre del Asociado" 
                                            ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                            <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="350px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="dui" HeaderText="DUI">
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
                                        <asp:Button ID="Button6" runat="server" CommandArgument="First" 
                                            CommandName="Page" CssClass="pagfirst" ToolTip="Prim. Pag" />
                                        <asp:Button ID="Button7" runat="server" CommandArgument="Prev" 
                                            CommandName="Page" CssClass="pagprev" ToolTip="Pág. anterior" />
                                        <asp:Button ID="Button8" runat="server" CommandArgument="Next" 
                                            CommandName="Page" CssClass="pagnext" ToolTip="Sig. página" />
                                        <asp:Button ID="Button9" runat="server" CommandArgument="Last" 
                                            CommandName="Page" CssClass="paglast" ToolTip="Últ. Pag" />
                                    </PagerTemplate>
                                    <PagerStyle CssClass="pagerstyle" />
                                    <AlternatingRowStyle BackColor="#99CCFF" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="cuentas_GridView" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                                    CellPadding="4" Font-Names="Verdana" Font-Size="10pt" Visible="False" 
                                    Width="760px">
                                    <RowStyle BackColor="White" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="ccodaho" HeaderText="CUENTA">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="tipo" HeaderText="TIPO CUENTA">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="nsaldoaho" HeaderText="SALDO">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
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
                                <asp:GridView ID="plazos_GridView" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="4" Font-Names="Verdana" Font-Size="10pt" ForeColor="Black" 
                                    GridLines="Vertical" Visible="False" Width="756px">
                                    <RowStyle BackColor="#F7F7DE" />
                                    <Columns>
                                        <asp:BoundField DataField="ccodcrt" HeaderText="No. CERTIFICADO">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="nmonapr" HeaderText="MONTO">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                    </Columns>
                                    <FooterStyle BackColor="#CCCC99" />
                                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                    <AlternatingRowStyle BackColor="White" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="creditos_GridView" runat="server" AutoGenerateColumns="False" 
                                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" CellSpacing="2" Font-Names="Verdana" Font-Size="10pt" 
                                    Visible="False" Width="752px">
                                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                    <Columns>
                                        <asp:BoundField DataField="ccodcta" HeaderText="CREDITO">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="nmoncuo" HeaderText="CUOTA">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="dfecvig" DataFormatString="{0:dd-MM-yyyy}" 
                                            HeaderText="VIGENTE">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="dfecven" DataFormatString="{0:dd-MM-yyyy}" 
                                            HeaderText="VENCE">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="NCAPDES" HeaderText="DESEMBOLSO">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="saldo" HeaderText="SALDO CAPITAL">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="deuda_total" HeaderText="DEUDA_TOTAL">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                    </Columns>
                                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="deudores_GridView" runat="server" AutoGenerateColumns="False" 
                                    BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
                                    CellPadding="3" CellSpacing="1" Font-Names="Verdana" Font-Size="10pt" 
                                    GridLines="None" Visible="False" Width="754px">
                                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                                    <Columns>
                                        <asp:BoundField DataField="ccodcta" HeaderText="CUENTA">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="cargos" HeaderText="DEBE">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="abonos" HeaderText="HABER">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="saldo" HeaderText="SALDO">
                                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" ForeColor="White" />
                                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                                        </asp:BoundField>
                                    </Columns>
                                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                    <ContentTemplate>
                                        <table style="width: 60%;">
                                            <tr>
                                                <td class="style27">
                                                    <asp:Label ID="Label4" runat="server" Font-Names="calibri" Font-Size="10pt" 
                                                        Text="Total haberes"></asp:Label>
                                                </td>
                                                <td class="style3">
                                                    <asp:Label ID="Label7" runat="server" Font-Names="calibri" Font-Size="10pt" 
                                                        Text="Total deuda"></asp:Label>
                                                </td>
                                                <td class="style4">
                                                    <asp:Label ID="Label5" runat="server" Font-Names="calibri" Font-Size="10pt" 
                                                        Text="Comision"></asp:Label>
                                                </td>
                                                <td class="style5">
                                                    <asp:Label ID="Label6" runat="server" Font-Names="calibri" Font-Size="10pt" 
                                                        Text="Disponible"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style27">
                                                    <asp:TextBox ID="haberes_TextBox" runat="server" BorderColor="#2E6A99" 
                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="10pt"></asp:TextBox>
                                                </td>
                                                <td class="style3">
                                                    <asp:TextBox ID="deuda_TextBox" runat="server" BorderColor="#2E6A99" 
                                                        BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="10pt"></asp:TextBox>
                                                </td>
                                                <td class="style4">
                                                    <asp:TextBox ID="comision_TextBox" runat="server" BorderColor="#2E6A99" 
                                                        BorderWidth="1px" CausesValidation="True" Enabled="False" Font-Names="Verdana" 
                                                        Font-Size="10pt"></asp:TextBox>
                                                </td>
                                                <td class="style5">
                                                    <asp:TextBox ID="disponible_TextBox" runat="server" BorderColor="#2E6A99" 
                                                        BorderWidth="1px" Enabled="False" Font-Bold="True" Font-Names="Verdana" 
                                                        Font-Size="10pt" ForeColor="Red"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style30">
                                                    &nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Font-Names="calibri" Font-Size="10pt" 
                                                        Text="Motivo del retiro"></asp:Label>
                                                </td>
                                                <td class="style32">
                                                    &nbsp;
                                                    <asp:TextBox ID="motivo_TextBox" runat="server" Font-Names="Calibri" 
                                                        Font-Size="10pt" Height="73px" style="margin-top: 0px" TextMode="MultiLine" 
                                                        Width="205px">viaje a los Estados Unidos </asp:TextBox>
                                                </td>
                                                <td class="style38">
                                                    &nbsp;</td>
                                                <td class="style19">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="retiro_Button" runat="server" Font-Names="Calibri" 
                                    Font-Size="11pt" ForeColor="Black" Text="Solicitud de Retiro" Visible="False" 
                                    Width="150px" />
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="retiro_Button" />
                </Triggers>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>



