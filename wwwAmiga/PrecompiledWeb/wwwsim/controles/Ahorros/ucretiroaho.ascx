    <%@ control language="vb" autoeventwireup="false" inherits="ucretiroaho, App_Web_kxy_ccyk" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc2" %>
<style type="text/css">
    .captura
    {
    	 font: Calibri, 12pt;
    }
    .style56
    {
        width: 100%;
    }
    .style14
    {
        width: 96%;
    }
    .style15
    {
        width: 97%;
        height: 33px;
    }
    .style16
    {
        width: 141px;
    }
    .style17
    {
        width: 171px;
    }
    .style30
    {
        width: 154px;
        
    }
    .style18
    {
        width: 118px;
    }
    .style19
    {
        width: 84%;
        height: 104px;
    }
    .style29
    {
        width: 141px;
        height: 26px;
    }
    .style25
    {
        height: 26px;
    }
    .style53
    {
        width: 141px;
        height: 24px;
    }
    .style54
    {
        height: 24px;
    }
    .style21
    {
        width: 96%;
        height: 66px;
    }
    .style23
    {
        width: 370px;
    }
    .style22
    {
        width: 261px;
    }
    .style24
    {
        width: 261px;
        height: 37px;
    }
    .style55
    {
        height: 37px;
    }
    .style28
    {
        width: 261px;
        height: 23px;
    }
    .style9
    {
        height: 23px;
    }
    .style34
    {
        width: 153px;
        height: 30px;
    }
    .style35
    {
        height: 30px;
    }
    .style37
    {
        width: 153px;
        height: 27px;
    }
    .style38
    {
        height: 27px;
    }
    .style31
    {
        width: 153px;
    }
    .style32
    {
        width: 153px;
        height: 84px;
    }
    .style33
    {
        height: 84px;
    }
    .style39
    {
        width: 85%;
        height: 102px;
    }
    .style42
    {
        width: 135px;
    }
    .style44
    {
        width: 114px;
    }
    .style43
    {
        width: 211px;
    }
    .style45
    {
        width: 97%;
    }
    .style51
    {
        height: 4px;
        width: 109px;
    }
    .style47
    {
        height: 4px;
        width: 331px;
    }
    .style49
    {
        height: 4px;
        width: 127px;
    }
    .style46
    {
        height: 4px;
    }
    .style1
    {
        width: 99%;
    }
    .style57
    {
        width: 135px;
        height: 30px;
    }
    .style58
    {
        width: 114px;
        height: 30px;
    }
    .style59
    {
        width: 211px;
        height: 30px;
    }
    </style>
    <script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
   
    <table cellpadding="0" cellspacing="0" class="style56">
        <tr>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table cellpadding="0" cellspacing="0" class="style14" 
    
        
    style="border: thin solid #003366; WIDTH: 718px; HEIGHT: 179px; BACKGROUND-COLOR: #ffffff">
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style14" align="center">
                                        <tr>
                                            <td align="center">
                                                <asp:label id="Label1" Font-Bold="True" Font-Names="Verdana" 
                                                    ForeColor="#339933" Width="278px"
				runat="server" Font-Size="Medium" Height="15px">RETIRO DE AHORROS</asp:label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table cellpadding="0" cellspacing="0" class="style15">
                                                    <tr>
                                                        <td align="right" class="style16">
                                                            <asp:label id="Label8" runat="server" Width="126px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px">Cuenta de Ahorros:</asp:label>
                                                        </td>
                                                        <td class="style17">
                                                            <asp:textbox id="txtcodcta" runat="server" Width="149px" Font-Names="Verdana"
							Font-Size="8pt" Enabled="False" Height="21px" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox>
                                                        </td>
                                                        <td class="style30">
                                                            &nbsp;</td>
                                                        <td class="style18">
                                                            <asp:label id="Label19" runat="server" Width="113px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px">Nº Serie Colector:</asp:label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtcolector" runat="server" Font-Names="Calibri" 
                                        Font-Size="12pt" Height="22px" Width="90px" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table cellpadding="0" cellspacing="0" class="style19">
                                                    <tr>
                                                        <td align="right" class="style16">
                                                            <asp:label id="Label15" runat="server" Width="40px" DESIGNTIMEDRAGDROP="901" Font-Names="Verdana"
							Font-Size="8pt">Oficina:</asp:label>
                                                        </td>
                                                        <td>
                                                            <asp:dropdownlist id="ddloficina" runat="server" Width="216px" 
                                        Font-Names="Verdana" Font-Size="8pt" Enabled="False" Height="16px">
                                                            </asp:dropdownlist>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" class="style16">
                                                            <asp:label id="Label2" runat="server" Width="80px" Font-Names="Verdana" 
                                        Font-Size="8pt">Nº Asociado:</asp:label>
                                                        </td>
                                                        <td>
                                                            <asp:textbox id="txtcodcli" runat="server" Font-Names="Verdana" Font-Size="X-Small"
							Width="123px" Enabled="False" BorderWidth="1px" BorderColor="#2E6A99" Height="21px"></asp:textbox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" class="style29">
                                                            <asp:label id="Label20" runat="server" Width="73px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px">Nombre:</asp:label>
                                                        </td>
                                                        <td class="style25">
                                                            <asp:textbox id="txtnomcli" runat="server" Width="336px" Font-Names="Verdana"
							Font-Size="8pt" Enabled="False" Height="21px" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" class="style53">
                                                            <asp:label id="Label21" runat="server" Width="60px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px">Saldo:</asp:label>
                                                        </td>
                                                        <td class="style54">
                                                            <asp:textbox id="txtsaldo" runat="server" Width="120px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False" BorderColor="#2E6A99" Height="21px"></asp:textbox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" class="style53">
                                                            <asp:label id="Label32" runat="server" Width="60px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px">Compensado:</asp:label>
                                                        </td>
                                                        <td class="style54">
                                                            <asp:textbox id="txtcompensado" runat="server" Width="120px" 
                                        Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False" BorderColor="#2E6A99" Height="21px"></asp:textbox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" class="style53">
                                                            <asp:label id="Label33" runat="server" Width="128px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px">Monto Restringido:</asp:label>
                                                        </td>
                                                        <td class="style54">
                                                            <asp:textbox id="txtrestringido" runat="server" Width="120px" 
                                        Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False" BorderColor="#2E6A99" Height="21px"></asp:textbox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="style16" align="right">
                                                            &nbsp;</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddlpromociones" runat="server" Enabled="False" 
                                        Font-Names="Calibri" Font-Size="10pt" Height="16px" Width="219px" 
                                        Visible="False">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table cellpadding="0" cellspacing="0" class="style21">
                                                    <tr>
                                                        <td class="style23">
                                                            <table cellpadding="0" cellspacing="0" class="style21">
                                                                <tr>
                                                                    <td align="right" class="style22">
                                                                        <asp:label id="Label7" runat="server" Width="56px" Font-Names="Verdana" 
                                                    Font-Size="8pt">Nº.Docto:</asp:label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:textbox id="txtnrodoc" runat="server" Width="120px" Font-Names="Verdana"
							Font-Size="8pt" BorderWidth="1px" BorderColor="#2E6A99" Height="21px"></asp:textbox>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style24">
                                                                        <asp:label id="Label6" runat="server" Width="88px" Font-Names="Verdana" 
                                                    Font-Size="8pt">Retiro:</asp:label>
                                                                    </td>
                                                                    <td class="style55">
                                                                        <asp:TextBox ID="txtmonto" runat="server"  Font-Names="Calibri" Font-Size="12pt" 
                                                    Height="21px" Width="90px" AutoPostBack="True" BorderColor="#2E6A99" BorderWidth="1px"  ></asp:TextBox>
                                                                    </td>
                                                                    <td class="style55">
                                                                        <asp:RangeValidator id="RangeValidator3" Font-Size="8pt" runat="server" 
                                                                            Width="82px" Font-Names="Verdana"
							ControlToValidate="txtmonto" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style28">
                                                                        &nbsp;</td>
                                                                    <td class="style9">
                                                                    </td>
                                                                    <td class="style9">
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style22">
                                                                        <asp:label id="Label4" runat="server" Width="96px" Font-Names="Verdana" 
                                                    Font-Size="8pt">Tipo de Ahorro:</asp:label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:dropdownlist id="ddltipaho" runat="server" Width="131px" 
                                                    Font-Names="Calibri" Font-Size="10pt" Enabled="False" Height="16px">
                                                                            <asp:ListItem Value="01">CTA. CONCENTRADORA                </asp:ListItem>
                                                                            <asp:ListItem Value="02">CTA. GARANTIA LIQUIDA            </asp:ListItem>
                                                                            <asp:ListItem Value="03">SUBSIDIO FEDERAL                </asp:ListItem>
                                                                        </asp:dropdownlist>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style22">
                                                                        <asp:label id="Label9" runat="server" Width="64px" Font-Names="Verdana" 
                                                    Font-Size="8pt">Fecha:</asp:label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:textbox id="txtfecha" runat="server" Width="72px" Font-Names="Verdana"
							Font-Size="8pt" BorderWidth="1px" BorderColor="#2E6A99" Height="21px"></asp:textbox>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style22">
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style22">
                                                                        <asp:label id="Label29" runat="server" Width="83px" 
                                        Font-Names="Verdana" Font-Size="8pt" Height="16px" 
                                        style="margin-left: 0px; margin-right: 0px">Salida:</asp:label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" 
                                        Font-Names="Calibri" Font-Size="10pt" GroupName="libreta" Text="CON LIBRETA" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" GroupName="libreta" Text="SIN LIBRETA" Width="126px" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td>
                                                            <table cellpadding="0" cellspacing="0" class="style21">
                                                                <tr>
                                                                    <td align="right" class="style34">
                                                                        <asp:label id="Label23" runat="server" Width="49px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Libreta:</asp:label>
                                                                    </td>
                                                                    <td class="style35">
                                                                        <asp:TextBox ID="txtlibreta" runat="server" Height="21px" Width="88px" 
                                                    CssClass="captura" Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style37">
                                                                        <asp:label id="Label25" runat="server" Width="129px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Total Aportaciones:</asp:label>
                                                                    </td>
                                                                    <td class="style38">
                                                                        <asp:TextBox ID="txttotaporta" runat="server" Height="21px" Width="88px" 
                                                    CssClass="captura" Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style31">
                                                                        <asp:label id="Label26" runat="server" Width="129px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Mora en Aportaciones:</asp:label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtmoraaporta" runat="server" Height="21px" Width="88px" 
                                                    CssClass="captura" Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style32">
                                                                        <asp:label id="Label27" runat="server" Width="169px" Font-Names="Calibri" 
                                                    Font-Size="10pt" Height="16px">Observaciones del Documento:</asp:label>
                                                                    </td>
                                                                    <td class="style33">
                                                                        <asp:TextBox ID="txtobserva" runat="server" Height="36px" Width="132px" 
                                                    CssClass="captura" Enabled="False" TextMode="MultiLine" 
                                                    BackColor="#99FF66"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style31">
                                                                        <asp:label id="Label28" runat="server" Width="129px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Notas:</asp:label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtnotas" runat="server" Height="28px" Width="132px" 
                                                    CssClass="captura" TextMode="MultiLine"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table cellpadding="0" cellspacing="0" class="style39">
                                                    <tr>
                                                        <td align="right" class="style57">
                                                            <asp:CheckBox ID="chkcheque" runat="server" onchange ="activarcampos();" Font-Names="Calibri" 
                                                    Font-Size="10pt" Text="Pago con Cheque" Width="146px" 
                                                    AutoPostBack="True" />
                                                        </td>
                                                        <td class="style58" align="right">
                                                            <asp:label id="Label36" runat="server" Width="143px" Font-Names="Calibri" 
                                                    Font-Size="10pt" Height="16px">Banco:</asp:label>
                                                        </td>
                                                        <td class="style59">
                                                            <cc2:CbxBancos ID="CbxBancos1" runat="server" AutoPostBack="True" 
                                                                Enabled="False" Font-Names="Calibri" Font-Size="10pt" Height="25px" 
                                                                Width="300px">
                                                            </cc2:CbxBancos>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" class="style42">
                                                            &nbsp;</td>
                                                        <td align="right" class="style44">
                                                            <asp:Label ID="Label38" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                                Height="16px" Width="143px">Cta. Banco:</asp:Label>
                                                        </td>
                                                        <td class="style43">
                                                            <cc2:Cbx_ctaBco ID="Cbx_ctaBco1" runat="server" Enabled="False" 
                                                                Font-Names="Calibri" Font-Size="10pt" Height="25px" Width="300px">
                                                            </cc2:Cbx_ctaBco>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" class="style42">
                                                            &nbsp;</td>
                                                        <td class="style44" align="right">
                                                            <asp:label id="Label37" runat="server" Width="143px" Font-Names="Calibri" 
                                                    Font-Size="10pt" Height="16px">Cheque:</asp:label>
                                                        </td>
                                                        <td class="style43">
                                                            <asp:TextBox ID="txtnroche" runat="server" Font-Names="Calibri" 
                                                    Font-Size="12pt" Height="20px" Width="90px" Enabled="False" BorderColor="#2E6A99" BorderWidth="1px" 
                                        ></asp:TextBox>
                                                            <asp:Button ID="comprobante_Button" runat="server" BackColor="#80FF80" 
                                                    Text="Partida" Visible="False" Width="80px" Font-Names="Verdana" 
                                                    Font-Size="8pt" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" class="style42">
                                                            &nbsp;</td>
                                                        <td class="style44" align="right">
                                                            <asp:label id="Label35" runat="server" Width="143px" Font-Names="Calibri" 
                                                    Font-Size="10pt" Height="16px">A nombre de Cheque:</asp:label>
                                                        </td>
                                                        <td class="style43">
                                                            <asp:TextBox ID="txtcnomchq" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Width="400px" Enabled="False"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table cellpadding="0" cellspacing="0" class="style45">
                                                    <tr>
                                                        <td id="dllca" align="right" class="style51">
                                                            &nbsp;</td>
                                                        <td class="style47">
                                                            &nbsp;</td>
                                                        <td align="right" class="style49">
                                                            <asp:label id="Label30" runat="server" Width="70px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Cajero:</asp:label>
                                                        </td>
                                                        <td class="style46">
                                                            <asp:DropDownList ID="ddlcajero" runat="server" Enabled="False" 
                                        Font-Names="Calibri" Font-Size="10pt" Height="16px" Width="219px">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:label id="Label13" runat="server" Width="88px" Font-Names="Verdana" 
                            Font-Size="8pt"></asp:label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center">
                                                <asp:Button ID="btnverificar" runat="server" Font-Names="Calibri" 
                            Text="Confrontar Firma y Foto" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table align="center" cellpadding="0" cellspacing="0" class="style1">
                                                    <tr>
                                                        <td>
                                                            <asp:Button ID="btnaplicar" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Height="27px" Text="Aplicar" Width="84px" Enabled="False" />
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Height="27px" Text="Grabar" Width="84px" />
                                                            <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
                                        ConfirmText="Esta seguro?" Enabled="True" TargetControlID="Button1">
                                                            </cc1:ConfirmButtonExtender>
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="btncancela" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Height="27px" Text="Cancelar" Width="84px" />
                                                            <cc1:ConfirmButtonExtender ID="btncancela_ConfirmButtonExtender" runat="server" 
                                        ConfirmText="Esta seguro?" Enabled="True" TargetControlID="btncancela">
                                                            </cc1:ConfirmButtonExtender>
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="btnimprimir" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Height="27px" Text="Recibo" Width="84px" />
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="btn_rec_direct" runat="server" Font-Names="Calibri" 
                                                                Font-Size="12pt" Height="27px" Text="Recibo Direc" Width="93px" 
                                                                Visible="False" />
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="btnlibreta" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Height="28px" Text="Im.Libreta" Width="84px" Enabled="False" Visible="False" />
                                                            &nbsp;</td>
                                                        <td>
                                                            <asp:Button ID="btnlib_direct" runat="server" Font-Names="Calibri" 
                                                                Font-Size="12pt" Height="28px" Text="Libreta Direc" Width="97px" 
                                                                Visible="False" />
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="btnprogra" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                        Text="Lavado de Dinero" Width="130px" Visible="False" />
                                                        </td>
                                                        <td>
                                                            <asp:Button ID="btnhabilitar" runat="server" Font-Names="Calibri" 
                                                                Text="Habilitar" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:radiobutton id="efectivo" runat="server" Text="Efectivo" Checked="True" Font-Names="Verdana"
								Font-Size="8pt" AutoPostBack="True" GroupName="tipo" Visible="False">
                                                </asp:radiobutton>
                                                <asp:checkbox id="Imprimir" runat="server" Width="74px" Font-Names="Verdana" 
                                                    Font-Size="X-Small" Checked="True" Text="Imprimir" 
                            Height="16px" Visible="False">
                                                </asp:checkbox>
                                                <asp:radiobutton id="bancos" runat="server" Text="Bancos" Font-Size="8pt" 
                            Font-Names="Verdana" AutoPostBack="True" GroupName="tipo" Visible="False">
                                                </asp:radiobutton>
                                                <asp:textbox id="txtdepositos" runat="server" Width="16px" Height="8px" 
                            Visible="False"></asp:textbox>
                                                <asp:textbox id="verificalavado" runat="server" Width="16px" Height="8px" 
                            Visible="False"></asp:textbox>
                                                <asp:TextBox ID="escondido_TextBox" runat="server" Height="18px" 
                            Visible="False" Width="55px"></asp:TextBox>
                                                <asp:HiddenField ID="HiddenField1" runat="server" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                    <Triggers>                        
                        <asp:PostBackTrigger ControlID="btnimprimir" />
                        <asp:PostBackTrigger ControlID="btnlibreta" />
                        <asp:PostBackTrigger ControlID="btnprogra" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
    </table>


