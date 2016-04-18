<%@ Control Language="vb" AutoEventWireup="false" Codefile="modificacion_plazo.ascx.vb" Inherits="modificacion_plazo"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<head runat="server">
    <title>Modificación a Depósitos a Plazo</title>
    <style type="text/css">
        .style1
        {
            width: 396px;
        }
        .style2
        {
            width: 174px;
        }
        .style3
        {
            width: 451px;
        }
        .style4
        {
            width: 100%;
        }
        .style5
        {
            height: 232px;
        }
    </style>
</head>
<div>

			<asp:label id="Label4" Width="372px" Height="15px" Font-Size="Medium" Font-Names="Verdana"
				runat="server" ForeColor="#16387C" Font-Bold="True">MODIFICAR DEPOSITO A PLAZO</asp:label>

</div>
    <div>
        <table border="1" cellpadding="0" cellspacing="0" class="style4">
            <tr>
                <td style="border-color: #003366">
                    <table cellpadding="0" cellspacing="0" class="style4">
                        <tr>
                            <td>
        <table style="width: 60%;">
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
                		<asp:textbox id="txtdepositos" runat="server" Width="16px" Height="8px" 
                            Visible="False"></asp:textbox>
                                            <asp:TextBox ID="txtccodcli" runat="server" 
                        Height="16px" Visible="False" Width="87px"></asp:TextBox>
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
                            <td class="style5">
                <asp:GridView ID="plazos_GridView" runat="server" BackColor="White" 
        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                        Visible="False" Font-Names="Verdana" Font-Size="10pt" 
                        AutoGenerateColumns="False" Width="977px">
        <RowStyle BackColor="White" ForeColor="#333333" />
                    <Columns>
                        <asp:CommandField ButtonType="Button" InsertVisible="False" 
                            SelectText="Seleccionar" ShowCancelButton="False" ShowSelectButton="True" />
                        <asp:BoundField DataField="ccodcrt" HeaderText="CERTIFICADO" />
                        <asp:BoundField DataField="nombre" HeaderText="NOMBRE" />
                        <asp:BoundField DataField="nsaldoaho" HeaderText="MONTO" />
                        <asp:BoundField DataField="nplazo" HeaderText="PLAZO" InsertVisible="False" />
                        <asp:BoundField DataField="ntasint" HeaderText="TASA" />
                        <asp:BoundField DataField="dfecapr" HeaderText="APERTURA" 
                            DataFormatString="{0:dd-MM-yyyy}" />
                        <asp:BoundField DataField="dfecven" HeaderText="VENCE" 
                            DataFormatString="{0:dd-MM-yyyy}" />
                        <asp:BoundField DataField="ccodaho" HeaderText="CTA. AHORRO" />
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
    <table style="width: 65%;">
        <tr>
            <td class="style2">
                &nbsp;
            </td>
            <td class="style3">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style2">
              
                <asp:Label ID="nombre_Label" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Text="Nombre" Visible="False"></asp:Label>
            </td>
            <td class="style3">
               
                <asp:TextBox ID="nombre_TextBox" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Visible="False" Height="21px" Width="440px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="monto_Label" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Text="Monto" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="monto_TextBox" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Visible="False" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="plazo_Label" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Text="Plazo" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="plazo_TextBox" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Visible="False" Height="22px" Width="58px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="tasa_Label" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Text="Tasa" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="tasa_TextBox" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Visible="False" Height="22px" Width="58px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="fec_apertura_Label" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Text="Fecha Apertura" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="fec_apertura_TextBox" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="cta_ahorro_Label" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Text="Cuenta ahorro" Visible="False"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="cta_ahorro_TextBox" runat="server" Font-Names="Verdana" 
                    Font-Size="10pt" Visible="False" Enabled="False" Height="22px" 
                    Width="219px"></asp:TextBox>
                <asp:DropDownList ID="cta_ahorro_DropDownList" runat="server" 
                    AutoPostBack="True" Font-Names="Verdana" Font-Size="10pt" Height="26px" 
                    Visible="False" Width="215px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;
            </td>
            <td class="style3">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="actualizar_Button" runat="server" BackColor="#99CC00" 
                    Font-Bold="False" Font-Names="Calibri" Font-Size="12pt" Text="Actualizar" 
                    Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
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
