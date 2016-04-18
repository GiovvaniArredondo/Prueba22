<%@ Control Language="vb" AutoEventWireup="false" Codefile="Cuwbusaho.ascx.vb" Inherits="Cuwbusaho"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

    <title>Bloqueo / Desbloqueo a Cuentas de Ahorro</title>
    <style type="text/css">
        .style1
        {
            width: 389px;
        }
        .style4
        {
            width: 90%;
        }
        .style5
        {
            width: 131%;
            height: 43px;
        }
        .style6
        {
            width: 289px;
        }
        .style7
        {
            width: 115px;
        }
        .style9
        {
            width: 87px;
        }
        .style10
        {
            width: 79px;
        }
    </style>

    <div>
        <table border="1" cellpadding="0" cellspacing="0" class="style4" 
            style="border-color: #003366">
            <tr>
                <td>
                    <table cellpadding="0" cellspacing="0" class="style4" align="center">
                        <tr>
                            <td>
        <table style="width: 95%;" align="center">
            <tr>
                <td class="style1">
                    &nbsp;
                    <table align="center" cellpadding="0" cellspacing="0" class="style5">
                        <tr>
                            <td class="style6">
                    <asp:TextBox ID="asociado_TextBox" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                        Width="400px" BorderWidth="1px" Height="25px" BorderColor="#2E6A99" 
                                    CssClass="transpare"></asp:TextBox>
                    <asp:TextBoxWatermarkExtender ID="asociado_TextBox_TextBoxWatermarkExtender" 
                        runat="server" Enabled="True" TargetControlID="asociado_TextBox" 
                        WatermarkText="Digite el nombre o código de asociado" WatermarkCssClass="Watermark">
                    </asp:TextBoxWatermarkExtender>
    
                            </td>
                            <td class="style10">
                                                                                                                                <asp:Button ID="btnbuscar" runat="server" 
                                    Font-Bold="True" 
                                                                                                                                    
                                    Font-Names="calibri" Font-Size="9pt" Height="24px" 
                                    Text="Buscar" 
                                                                                                                                    
                                    Width="171px" />
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="31px" 
                        ImageUrl="~/web/jpgs/btn_buscar_b.jpg" Width="41px" Visible="False" />
                            </td>
                            <td class="style9">
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="28px" 
                        ImageUrl="~/web/jpgs/repetir.png" Width="43px" style="margin-left: 0px" />
                            </td>
                            <td class="style7">
                    <asp:Label ID="Label3" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                        Text="No existe!!!" Font-Bold="True" ForeColor="Red" 
                        Visible="False" Width="100px"></asp:Label>
                            </td>
                            <td>
                    <asp:Image ID="foto_Image" runat="server" Visible="False" BorderWidth="1px" />
                            </td>
                        </tr>
                    </table>
                    </td>
            </tr>
            <tr>
                <td class="style1" align="center">
                    &nbsp;
                        
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
                <td class="style1" align="center">
                            <asp:TextBox ID="TextBox1" runat="server" BorderWidth="1px" Visible="False" 
                                Width="52px"></asp:TextBox>
                        </td>
            </tr>
            </table>
                            </td>
                        </tr>
                        </table>
                </td>
            </tr>
        </table>
    </div>
    
<script language='JavaScript'>
document.onkeydown=function (evt) {return (evt ? evt.which : event.keyCode) != 13;}
</script>
