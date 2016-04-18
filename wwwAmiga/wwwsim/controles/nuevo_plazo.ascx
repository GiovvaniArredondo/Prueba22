<%@ Control Language="vb" AutoEventWireup="false" Codefile="nuevo_plazo.ascx.vb" Inherits="nuevo_plazo"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>



    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 132px;
        }
        .style3
        {
            width: 769px;
        }
        .style4
        {
            width: 468px;
        }
        .style5
        {
            width: 150px;
        }
        .style6
        {
            width: 191px;
        }
        .style7
        {
            width: 80%;
        }
        .style8
        {
            width: 62%;
            height: 40px;
        }
        .style9
        {
            width: 82%;
        }
        .style10
        {
            width: 467px;
        }
        .style11
        {
            width: 202px;
        }
        .style12
        {
            width: 176px;
        }
    </style>

    <table border="1" cellpadding="0" cellspacing="0" class="style9" 
    style="border-color: #003366">
        <tr>
            <td>
<table cellpadding="0" cellspacing="0" class="style7" style="border-color: #003366">
    <tr>
        <td>
			<asp:label id="Label11" runat="server" Width="419px" Font-Bold="True" 
                        Font-Names="Verdana" Font-Size="Medium"
				ForeColor="#16387C" Height="15px">NUEVOS CERTIFICADOS</asp:label>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
        </td>
    </tr>
    <tr>
        <td>
    
        <table style="width:66%;">
            <tr>
                <td class="style1">
                    <asp:Image ID="foto_image" runat="server" Visible="False" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:TextBox ID="asociado_TextBox" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Width="370px" BorderColor="#80FF80" BorderStyle="Outset" BorderWidth="3px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="buscar_Button" runat="server" BackColor="#99CC00" Font-Bold="False" 
                        Font-Names="Calibri" Font-Size="12pt" Text="Buscar" />
                </td>
                <td>
                    <asp:ImageButton ID="repetir_ImageButton" runat="server" Height="25px" 
                        ImageUrl="~/web/jpgs/repetir.png" Width="35px" />
                </td>
                <td>
                    <asp:Label ID="mensaje" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Text="No existe!!!" Font-Bold="True" ForeColor="Red" 
                        Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1" colspan="4">
                                        <asp:GridView ID="asociados_GridView" runat="server" 
                                            AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" 
                                            BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" 
                                            Font-Names="Verdana" Font-Size="10pt" Visible="False" 
                        Width="764px">
                                            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                            <Columns>
                                                <asp:CommandField ButtonType="Button" CancelText="" DeleteText="" EditText="" 
                                                    InsertText="" InsertVisible="False" NewText="" SelectText="Seleccionar" 
                                                    ShowCancelButton="False" ShowSelectButton="True" UpdateText="" />
                                                <asp:BoundField DataField="asociado" HeaderText="ASOCIADO" />
                                                <asp:BoundField DataField="nombre" HeaderText="NOMBRE" HtmlEncode="False" />
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
                <td class="style1">
                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Names="Verdana" 
                        Font-Size="10pt" ForeColor="Maroon"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtccodcli" runat="server" Height="16px" Visible="False" 
                        Width="51px"></asp:TextBox>
						<asp:textbox id="txtdepositos" runat="server" Width="16px" Height="8px" 
                            Visible="False"></asp:textbox>
                                            </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="escondido_TextBox" runat="server" Visible="False" Width="40px"></asp:TextBox>
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
                                        &nbsp;</td>
    </tr>
    <tr>
        <td>
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" Visible="False">
                        <ContentTemplate>
                            <table cellpadding="0" cellspacing="0" class="style8">
                                <tr>
                                    <td class="style11">
                                        <asp:Label ID="Label1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                        Text="No. Certificado [TAB]"></asp:Label>
                                    </td>
                                    <td class="style12">
                                        <asp:TextBox ID="certificado_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" AutoPostBack="True"></asp:TextBox>
                                    </td>
                                    <td class="style10">
                                        <asp:CheckBox ID="reimprimir_CheckBox" runat="server" AutoPostBack="True" 
                                            BackColor="#0080FF" Font-Names="Calibri" Font-Size="12pt" 
                                            Text="Reimpresion de Certificado" />
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
    </tr>
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" Visible="False">
                <ContentTemplate>
                    <table style="width: 100%;">
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label2" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Text="Monto"></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:TextBox ID="monto_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt">0.00</asp:TextBox>
                                <asp:TextBox ID="fecha_apertura_TextBox" runat="server" Enabled="False" 
                        Font-Names="Verdana" Font-Size="10pt" Width="112px"></asp:TextBox>
                                <asp:TextBox ID="fecha_vence_TextBox" runat="server" Enabled="False" 
                                    Font-Names="Verdana" Font-Size="10pt" Width="112px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label3" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Text="Linea"></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:DropDownList ID="linea_DropDownList" runat="server" AutoPostBack="True" 
                        Width="600px" Font-Names="Calibri">
                                </asp:DropDownList>
                                <asp:TextBox ID="tasa_TextBox" runat="server" Enabled="False" 
                        Font-Names="Calibri" Font-Size="10pt" Width="55px">0.00</asp:TextBox>
                                <asp:TextBox ID="plazo_TextBox" runat="server" Enabled="False" 
                        Font-Names="Calibri" Font-Size="10pt" Width="55px">0</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label4" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Text="Cta. de ahorro" Visible="False"></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:DropDownList ID="cta_ahorro_DropDownList" runat="server" 
                        AutoPostBack="True" Width="200px" Visible="False">
                                </asp:DropDownList>
                                <asp:TextBox ID="cta_nombre_TextBox" runat="server" Enabled="False" 
                        Font-Names="Verdana" Font-Size="10pt" Width="266px" Visible="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label5" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                        Text="Asignado a" Visible="False"></asp:Label>
                            </td>
                            <td class="style3">
                                <asp:DropDownList ID="asignado_DropDownList" runat="server" AutoPostBack="True" 
                        Width="400px" Visible="False">
                                </asp:DropDownList>
                                <asp:TextBox ID="asignado_codigo_TextBox" runat="server" Enabled="False" 
                        Font-Names="Verdana" Font-Size="10pt" Width="55px" Visible="False"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" Visible="False">
                <ContentTemplate>
                    <table style="width: 100%;">
                        <tr>
                            <td class="style4" align="center" bgcolor="#99CC00">
                                &nbsp;
                                <asp:Label ID="Label6" runat="server" Font-Names="Verdana" 
                        Font-Size="10pt" Text="Nombre"></asp:Label>
                            </td>
                            <td class="style4" align="center" bgcolor="#99CC00">
                                <asp:Label ID="Label10" runat="server" Font-Names="Verdana" 
                        Font-Size="10pt" Text="Dirección"></asp:Label>
                            </td>
                            <td class="style5" align="center" bgcolor="#99CC00">
                                &nbsp;
                                <asp:Label ID="Label7" runat="server" Font-Names="Verdana" 
                        Font-Size="10pt" Text="Fec. Nacimiento"></asp:Label>
                            </td>
                            <td class="style6" align="center" bgcolor="#99CC00">
                                <asp:Label ID="Label8" runat="server" Font-Names="Verdana" 
                        Font-Size="10pt" Text="Parentesco"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#99CC00">
                                &nbsp;
                                <asp:Label ID="Label9" runat="server" Font-Names="Verdana" 
                        Font-Size="10pt" Text="%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <asp:TextBox ID="nombre1_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="20px" Width="275px" style="margin-bottom: 0px"></asp:TextBox>
                                <asp:TextBoxWatermarkExtender ID="nombre1_TextBox_TextBoxWatermarkExtender" 
                        runat="server" Enabled="True" TargetControlID="nombre1_TextBox" 
                        WatermarkText="Nombre del beneficiario">
                                </asp:TextBoxWatermarkExtender>
                            </td>
                            <td class="style4">
                                <asp:TextBox ID="dir1_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="22px" Width="300px"></asp:TextBox>
                                <asp:TextBoxWatermarkExtender ID="dir1_TextBox_TextBoxWatermarkExtender" 
                        runat="server" Enabled="True" TargetControlID="dir1_TextBox" 
                        WatermarkText="Domicilio del beneficiario">
                                </asp:TextBoxWatermarkExtender>
                            </td>
                            <td class="style5">
                                <asp:TextBox ID="fecha1_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Width="100px"></asp:TextBox>
                                <asp:CalendarExtender ID="fecha1_TextBox_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="fecha1_TextBox">
                                </asp:CalendarExtender>
                            </td>
                            <td class="style6">
                                <asp:DropDownList ID="parentesco1_DropDownList" runat="server" 
                        Font-Names="Calibri" Font-Size="10pt" Width="173px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:TextBox ID="porcentaje1_TextBox" runat="server" Height="22px" Width="82px" 
                                    Font-Names="Calibri">0.00</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <asp:TextBox ID="nombre2_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="20px" Width="275px"></asp:TextBox>
                            </td>
                            <td class="style4">
                                <asp:TextBox ID="dir2_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="22px" Width="300px"></asp:TextBox>
                            </td>
                            <td class="style5">
                                <asp:TextBox ID="fecha2_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Width="100px"></asp:TextBox>
                                <asp:CalendarExtender ID="fecha2_TextBox_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="fecha2_TextBox">
                                </asp:CalendarExtender>
                            </td>
                            <td class="style6">
                                <asp:DropDownList ID="parentesco2_DropDownList" runat="server" 
                        Font-Names="Calibri" Font-Size="10pt" Width="173px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:TextBox ID="porcentaje2_TextBox" runat="server" Height="22px" Width="82px" 
                                    Font-Names="Calibri">0.00</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <asp:TextBox ID="nombre3_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="20px" Width="275px"></asp:TextBox>
                            </td>
                            <td class="style4">
                                <asp:TextBox ID="dir3_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="22px" Width="300px"></asp:TextBox>
                            </td>
                            <td class="style5">
                                <asp:TextBox ID="fecha3_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Width="100px"></asp:TextBox>
                                <asp:CalendarExtender ID="fecha3_TextBox_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="fecha3_TextBox">
                                </asp:CalendarExtender>
                            </td>
                            <td class="style6">
                                <asp:DropDownList ID="parentesco3_DropDownList" runat="server" 
                        Font-Names="Calibri" Font-Size="10pt" Width="173px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:TextBox ID="porcentaje3_TextBox" runat="server" Height="22px" Width="82px" 
                                    Font-Names="Calibri">0.00</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <asp:TextBox ID="nombre4_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="20px" Width="275px"></asp:TextBox>
                            </td>
                            <td class="style4">
                                <asp:TextBox ID="dir4_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="22px" Width="300px"></asp:TextBox>
                            </td>
                            <td class="style5">
                                <asp:TextBox ID="fecha4_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Width="100px"></asp:TextBox>
                                <asp:CalendarExtender ID="fecha4_TextBox_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="fecha4_TextBox">
                                </asp:CalendarExtender>
                            </td>
                            <td class="style6">
                                <asp:DropDownList ID="parentesco4_DropDownList" runat="server" 
                        Font-Names="Calibri" Font-Size="10pt" Width="173px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:TextBox ID="porcentaje4_TextBox" runat="server" Height="22px" Width="82px" 
                                    Font-Names="Calibri">0.00</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                <asp:TextBox ID="nombre5_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="20px" Width="275px"></asp:TextBox>
                            </td>
                            <td class="style4">
                                <asp:TextBox ID="dir5_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Height="22px" Width="300px"></asp:TextBox>
                            </td>
                            <td class="style5">
                                <asp:TextBox ID="fecha5_TextBox" runat="server" Font-Names="Calibri" 
                        Font-Size="10pt" Width="100px"></asp:TextBox>
                                <asp:CalendarExtender ID="fecha5_TextBox_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="fecha5_TextBox">
                                </asp:CalendarExtender>
                            </td>
                            <td class="style6">
                                <asp:DropDownList ID="parentesco5_DropDownList" runat="server" 
                        Font-Names="Calibri" Font-Size="10pt" Width="173px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:TextBox ID="porcentaje5_TextBox" runat="server" Height="22px" Width="82px" 
                                    Font-Names="Calibri">0.00</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;</td>
                            <td class="style4" align="center">
                                &nbsp;</td>
                            <td class="style5">
                                &nbsp;</td>
                            <td class="style6">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;
                                <asp:Button ID="btnprogra" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                    Text="Lavado de Dinero" Visible="False" Width="130px" 
                                    BackColor="#0080FF" />
                            </td>
                            <td class="style4">
                                <asp:Button ID="crear_Button" runat="server" BackColor="#99CC00" 
                                    Font-Names="Calibri" Font-Size="12pt" Text="Grabar" Visible="False" 
                                    Width="80px" />
                            </td>
                            <td class="style5">
                                &nbsp;
                                </td>
                            <td class="style6">
                                <asp:Button ID="imprimir_Button" runat="server" BackColor="#99CC00" 
                                    Font-Names="Calibri" Font-Size="12pt" Text="Imp. Certificado" Visible="False" 
                                    Width="110px" />
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>

            </td>
        </tr>
</table>
        

<script language='JavaScript'>
document.onkeydown=function (evt) {return (evt ? evt.which : event.keyCode) != 13;}
</script>


