<%@ control language="vb" autoeventwireup="false" inherits="consulta_plazo, App_Web_yl8dokps" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<head runat="server">
    <title>Consulta Depósitos a Plazo</title>
    <style type="text/css">
        .style1
        {
            width: 396px;
        }
        .style2
        {
            width: 93%;
        }
        .style3
        {
            height: 255px;
        }
        </style>
</head>
    <div>
        <table border="1" cellpadding="0" cellspacing="0" class="style2" 
            style="border-color: #003366">
            <tr>
                <td>
                    <table cellpadding="0" cellspacing="0" class="style2">
                        <tr>
                            <td>
        <table style="width: 66%;">
            <tr>
                <td class="style1">
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Verdana" 
                            Font-Size="14pt" ForeColor="#16387C" 
                            Text="CONSULTA DEPOSITOS A PLAZO" Width="370px" Height="17px"></asp:Label>
                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;
                    <asp:Image ID="foto_Image" runat="server" Visible="False" />
                    </td>
                <td>
                    &nbsp;
                    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;
                    <asp:TextBox ID="asociado_TextBox" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Width="370px" BorderColor="#80FF80" BorderStyle="Outset" BorderWidth="3px"></asp:TextBox>
                    <asp:TextBoxWatermarkExtender ID="asociado_TextBox_TextBoxWatermarkExtender" 
                        runat="server" Enabled="True" TargetControlID="asociado_TextBox" 
                        WatermarkText="Digite el nombre o código de asociado">
                    </asp:TextBoxWatermarkExtender>
                </td>
                <td>
                    &nbsp;
                    <asp:Button ID="buscar_Button" runat="server" BackColor="#99CC00" Font-Bold="False" 
                        Font-Names="Calibri" Font-Size="12pt" Text="Buscar" />
                    <asp:Label ID="mensaje" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Text="No existe!!!" Font-Bold="True" ForeColor="Red" 
                        Visible="False"></asp:Label>
                    <asp:ImageButton ID="repetir_ImageButton" runat="server" Height="25px" 
                        ImageUrl="~/web/jpgs/repetir.png" Width="35px" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
    
        <asp:GridView ID="asociados_GridView" runat="server" BackColor="#DEBA84" 
            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            CellSpacing="2" Visible="False" AutoGenerateColumns="False" 
            Font-Names="Verdana" Font-Size="10pt" Width="764px">
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <Columns>
                <asp:CommandField ButtonType="Button" CancelText="" DeleteText="" EditText="" 
                    InsertText="" InsertVisible="False" NewText="" SelectText="Seleccionar" 
                    ShowCancelButton="False" ShowSelectButton="True" UpdateText="" />
                <asp:BoundField DataField="asociado" HeaderText="ASOCIADO" />
                <asp:BoundField DataField="nombre" HeaderText="NOMBRE" />
                <asp:BoundField DataField="dui" HeaderText="DUI" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    
                            </td>
                        </tr>
                        <tr>
                            <td class="style3">
                <asp:GridView ID="plazos_GridView" runat="server" BackColor="White" 
        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                        Visible="False" Font-Names="Verdana" Font-Size="10pt" 
                        AutoGenerateColumns="False" Width="977px">
        <RowStyle BackColor="White" ForeColor="#333333" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" InsertVisible="False" 
                            ShowCancelButton="False" ShowSelectButton="True" />
                        <asp:BoundField DataField="ccodcrt" HeaderText="CERTIFICADO" />
                        <asp:BoundField DataField="nsaldoaho" HeaderText="MONTO" />
                        <asp:BoundField DataField="nplazo" HeaderText="PLAZO" InsertVisible="False" />
                        <asp:BoundField DataField="ntasint" HeaderText="TASA" />
                        <asp:BoundField DataField="dfecori" HeaderText="ORIGINAL" 
                            DataFormatString="{0:dd-MM-yyyy}" />
                        <asp:BoundField DataField="dfecapr" HeaderText="APERTURA" 
                            DataFormatString="{0:dd-MM-yyyy}" />
                        <asp:BoundField DataField="dfecven" HeaderText="VENCE" 
                            DataFormatString="{0:dd-MM-yyyy}" />
                        <asp:BoundField DataField="ccodaho" HeaderText="CTA. AHORRO" />
                        <asp:BoundField DataField="cpignor" HeaderText="PIGNORADO" />
                        <asp:BoundField DataField="cestado" HeaderText="RENOVADO" />
                        <asp:BoundField DataField="ccodusu" HeaderText="USUARIO" />
                    </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#336666" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    
                            </td>
                        </tr>
                        <tr>
                            <td>
    
        <asp:Button ID="imprimir_Button" runat="server" BackColor="#99CC00" 
            Text="Impresion Resguardo" Visible="False" Font-Names="Verdana" Font-Size="10pt" 
                                    style="height: 29px" Height="27px" Width="234px" />
    
                                <asp:Button ID="imprimir1_Button" runat="server" BackColor="#80FF80" 
                                    Font-Names="Verdana" Font-Size="10pt" Height="27px" style="margin-top: 0px" 
                                    Text="Imprimir Todos los Certificados" Visible="False" Width="234px" />
    
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    
    <div>
    
    <br />
    
    </div>
    
    <br />
    


<script language='JavaScript'>
document.onkeydown=function (evt) {return (evt ? evt.which : event.keyCode) != 13;}
</script>
