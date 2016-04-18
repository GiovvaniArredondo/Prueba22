<%@ control language="vb" autoeventwireup="false" inherits="rpt_captacion_aportaciones_creditos, App_Web_kxy_ccyk" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

    <%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>

    <style type="text/css">
        .style15
        {
            width: 100%;
        }
        .style3
        {
            width: 90%;
        }
        .style4
        {
            width: 99%;
            height: 260px;
        }
        .style1
        {
            width: 65%;
            height: 77px;
        }
        .style2
        {
            width: 71px;
        }
        .style12
        {
            width: 170px;
        }
        .style11
        {
            width: 53px;
        }
        .style13
        {
            width: 162px;
        }
        .style7
        {
            width: 100%;
        }
        .style17
        {
            width: 191px;
        }
        .style14
        {
            width: 248px;
        }
        .style8
        {
            width: 100%;
            height: 174px;
        }
        .style9
        {
            width: 89%;
        }
        .style16
        {
            height: 64px;
        }
        </style>

    <table cellpadding="0" cellspacing="0" class="style15">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table border="1" cellpadding="0" cellspacing="0" class="style3" 
    style="border-color: #003366; height: 337px;">
                        <tr>
                            <td>
                                <table cellpadding="0" cellspacing="0" class="style4" align="center" border="0">
                                    <tr>
                                        <td align="center">
                                            <asp:Label ID="Label3" runat="server" Text="REPORTES DE AHORROS" Font-Bold="True" 
                            Font-Names="Calibri" Font-Size="22pt" ForeColor="#003366"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" align="center">
                                                <tr>
                                                    <td class="style2">
                                                        <asp:Label ID="Label2" runat="server" Text="Desde:" Font-Names="Calibri"></asp:Label>
                                                    </td>
                                                    <td class="style12">
                                                        <asp:TextBox ID="desde_TextBox" runat="server" Height="22px" Width="93px" 
                        Font-Names="Calibri">01/01/2011</asp:TextBox>
                                                        <asp:MaskedEditExtender ID="desde_TextBox_MaskedEditExtender" runat="server" 
                                                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                            Mask="99/99/9999" MaskType="Date" TargetControlID="desde_TextBox">
                                                        </asp:MaskedEditExtender>
                                                        <asp:CalendarExtender ID="desde_TextBox_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="desde_TextBox" Format="dd/MM/yyyy">
                                                        </asp:CalendarExtender>
                                                    </td>
                                                    <td class="style11">
                                                        <asp:Label ID="Label9" runat="server" Text="Hasta:" Font-Names="Calibri"></asp:Label>
                                                    </td>
                                                    <td class="style11">
                                                        <asp:TextBox ID="hasta_TextBox" runat="server" Height="22px" Width="93px" 
                        Font-Names="Calibri">30/09/2011</asp:TextBox>
                                                        <asp:MaskedEditExtender ID="hasta_TextBox_MaskedEditExtender" runat="server" 
                                                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                            Mask="99/99/9999" MaskType="Date" TargetControlID="hasta_TextBox">
                                                        </asp:MaskedEditExtender>
                                                        <asp:CalendarExtender ID="hasta_TextBox_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="hasta_TextBox" Format="dd/MM/yyyy">
                                                        </asp:CalendarExtender>
                                                    </td>
                                                    <td class="style13">
                                                        <asp:Label ID="Label14" runat="server" Text="Gráfico:" Font-Names="Calibri" 
                                                            Visible="False"></asp:Label>
                                                        <asp:DropDownList ID="grafico_DropDownList" runat="server" 
                        Height="18px" Width="96px" Visible="False">
                                                            <asp:ListItem>Pastel</asp:ListItem>
                                                            <asp:ListItem>Barras</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        <asp:Button ID="ejecutar_Button" runat="server" 
                        Text="Ejecutar" Font-Names="Calibri" Font-Size="11pt" Width="120px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style2">
                                                        <asp:label id="Label12" runat="server" Font-Names="Calibri" Width="65px" Font-Size="X-Small"
																	ForeColor="Black" Font-Bold="False">Exportar a:</asp:label>
                                                    </td>
                                                    <td colspan="2">
                                                        <asp:dropdownlist id="ddlexportar" runat="server" Font-Names="Calibri" 
                        Width="169px" Font-Size="10pt">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td class="style11">
                                                        <asp:label id="Label13" runat="server" Font-Names="Calibri" Width="65px" Font-Size="X-Small"
																	ForeColor="Black" Font-Bold="False">Oficina:</asp:label>
                                                    </td>
                                                    <td class="style13">
                                                        <asp:DropDownList ID="ddlOficinas" runat="server" Font-Names="Calibri" 
                        Width="165px" Enabled="False" Font-Size="10pt">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                        <asp:CheckBox ID="ckbTodas" runat="server" Checked="True" Font-Names="Calibri" 
                        Text="Todas" AutoPostBack="True" />
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-color: #800000">
                                            
                                            <table cellpadding="0" cellspacing="0" class="style15">
                                                <tr>
                                                    <td>
                                                        <asp:RadioButton ID="RadioButton34" runat="server" BorderColor="#000001" 
                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                            Text="Movimientos Diarios" Width="164px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:RadioButton ID="RadioButton48" runat="server" Font-Names="Calibri" 
                                                            Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                            Text="Cartera Ahorros Cuadratura" Width="184px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server" Visible="False">
                                                            <ContentTemplate>
                                                                <table align="center" border="1" cellpadding="0" cellspacing="0" class="style7" 
                                                                    style="border-color: #990000; height: 598px;">
                                                                    <tr>
                                                                        <td align="center" class="style17">
                                                                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                Font-Size="12pt" ForeColor="Blue" Text="Aportaciones"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                Font-Size="12pt" ForeColor="Blue" Text="Certificados"></asp:Label>
                                                                        </td>
                                                                        <td class="style14">
                                                                            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                Font-Size="12pt" ForeColor="Blue" Text="Cuentas de Ahorro"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                Font-Size="12pt" ForeColor="Blue" Text="Asociados"></asp:Label>
                                                                        </td>
                                                                        <td>
                                                                            <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                                Font-Size="12pt" ForeColor="Blue" Text="Capitalizaciones"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="center" class="style17">
                                                                            <table cellpadding="0" cellspacing="0" class="style8">
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton1" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Captación de Aportaciones" Width="203px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                        <td>
                                                                            <table cellpadding="0" cellspacing="0" class="style8">
                                                                                <tr>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton11" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Certificados Renovados" Width="203px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton12" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Certificados Anulados" Visible="False" Width="203px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton13" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Certificados Cancelados" Width="203px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton14" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Certificados Aperturados" Width="203px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton15" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Certificados Pignorados" Width="203px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton16" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Participación en Cartera:" Width="203px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:DropDownList ID="nombres_DropDownList" runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="10pt" Height="21px" Width="262px">
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton17" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Certificados por Tasa:" Width="203px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:DropDownList ID="tasa_DropDownList" runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="10pt" Height="21px" Width="262px">
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton18" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Certificados por Plazo:" Width="203px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:DropDownList ID="plazo_DropDownList" runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="10pt" Height="21px" Width="262px">
                                                                                        </asp:DropDownList>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton25" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Concentración  x Monto Aperturado" Width="227px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <table cellspacing="0" class="style9">
                                                                                            <tr>
                                                                                                <td>
                                                                                                    <asp:Label ID="Label10" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                                                                        Text="Desde:"></asp:Label>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <asp:TextBox ID="monto1_TextBox" runat="server" Font-Names="Calibri" 
                                                                                                        Font-Size="10pt" Height="17px" Width="62px"></asp:TextBox>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <asp:Label ID="Label11" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                                                                        Text="Hasta:"></asp:Label>
                                                                                                </td>
                                                                                                <td>
                                                                                                    <asp:TextBox ID="monto2_TextBox" runat="server" Font-Names="Calibri" 
                                                                                                        Font-Size="10pt" Height="17px" Width="62px"></asp:TextBox>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton26" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Certificados Vencidos y Pago de Intereses" Width="255px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton28" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Provisión Diaria de Intereses" Width="255px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton29" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Provisión Diaria de Intereses Acumulados" Width="255px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton30" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Intereses Pendiente de Pago" Width="255px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton31" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Interes Pendiente Diaria de Pago Acum." Width="257px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton32" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="20px" Text="Cartera de Cert. Auditores" Width="164px" />
                                                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                                        <asp:CheckBox ID="CheckBox2" runat="server" Font-Names="Verdana" 
                                                                                            Font-Size="8pt" ForeColor="Blue" Text="Cvs" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton33" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Liquidez Diaria" Width="164px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton40" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="16px" Text="Provision Diaria de Interes por Tasa" Width="254px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td class="style16">
                                                                                        <asp:RadioButton ID="RadioButton41" runat="server" BorderColor="#000001" 
                                                                                            Enabled="False" Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" 
                                                                                            Height="52px" Text="Historial de Intereses Pagados por Asociado" 
                                                                                            Width="254px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                        <td class="style14">
                                                                            <table cellpadding="0" cellspacing="0" class="style8">
                                                                                <tr>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton2" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Cuentas de Ahorro Bloqueadas" Width="199px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton3" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="62px" 
                                                                                            Text="Cuentas de Ahorro con Cheques en Compensación" Width="213px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton4" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="71px" 
                                                                                            Text="Cuentas de Ahorro Bloqueadas x Desembolsos" Width="220px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton5" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="59px" 
                                                                                            Text="Cuentas de Ahorro Montos Restringidos" Width="219px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton19" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="39px" 
                                                                                            Text="Inactividad de Cuentas de Ahorro" Width="221px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton24" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Provisión Diaria Cartera Ahorros" Width="221px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton27" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="24px" 
                                                                                            Text="Resumen Provisión Diaria por Cartera" Width="327px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton35" runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Sumario Cartera de Ahorros" Width="184px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton36" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Sumario Cartera de Créditos" Width="184px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <cc1:CbxTipAho ID="CbxTipAho1" runat="server" Enabled="False" 
                                                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Width="200px">
                                                                                        </cc1:CbxTipAho>
                                                                                        <asp:CheckBox ID="llahorros" runat="server" AutoPostBack="True" Checked="True" 
                                                                                            Font-Names="Verdana" Font-Size="8pt" ForeColor="Blue" 
                                                                                            Text="Todos los Ahorros" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton38" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Cartera Ahorros Auditores" Width="184px" />
                                                                                        <asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Verdana" 
                                                                                            Font-Size="8pt" ForeColor="Blue" Text="Cvs" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton39" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Cartera Créditos Auditores" Width="184px" />
                                                                                        <asp:CheckBox ID="CheckBox3" runat="server" Font-Names="Verdana" 
                                                                                            Font-Size="8pt" ForeColor="Blue" Text="Cvs" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="Blue" 
                                                                                            Text="Gráficos"></asp:Label>
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton42" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Cartera de Créditos Gráfica" Width="184px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton43" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Cartera de Ahorros Gráfica" Width="184px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton45" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Cartera Analista Gráfica" Width="184px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton44" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Mora Edad Gráfica" Width="184px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton46" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Mora Cartera Gráfica" Width="184px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton47" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Mora Analista Gráfica" Width="184px" />
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                        <td>
                                                                            <table cellpadding="0" cellspacing="0" class="style8">
                                                                                <tr>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton6" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Asociados Ingresados" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton8" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Asociados Retirados" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton7" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Asociados Inactivos con +365 dias" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton23" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Asociados Cubiertos x Fondo de Defunsión" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton37" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Asociados Ingresados por Rango" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                        <td>
                                                                            <table cellpadding="0" cellspacing="0" class="style8">
                                                                                <tr>
                                                                                    <td>
                                                                                        &nbsp;</td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton9" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Capitalización Trimestral de Cartera Ah.(Detalle)" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton10" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Capitalización Trimestral de Cartera Ah.(Resumen)" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton20" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Dividendos Pagados en el  Año" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton21" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Dividendos Calculados en el  Año" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                                <tr>
                                                                                    <td>
                                                                                        <asp:RadioButton ID="RadioButton22" runat="server" Enabled="False" 
                                                                                            Font-Names="Calibri" Font-Size="10pt" GroupName="opciones" Height="16px" 
                                                                                            Text="Dividendos Pendientes en el Año" Width="169px" />
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
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
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
                <Triggers>                    
                    <asp:PostBackTrigger ControlID="ejecutar_Button" />
                </Triggers>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>


