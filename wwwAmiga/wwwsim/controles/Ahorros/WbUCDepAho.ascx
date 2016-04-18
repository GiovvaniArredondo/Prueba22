<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbUCDepAho.ascx.vb" Inherits="controles_Ahorros_WbUCDepAho" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc2" %>
<style type="text/css">
    .captura
    {
    	 font: Calibri, 12pt;
    }
    .style55
    {
        width: 100%;
    }
    .style14
    {
        width: 98%;
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
        width: 98%;
        height: 216px;
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
        height: 26px;
    }
    .style26
    {
        width: 261px;
        height: 25px;
    }
    .style27
    {
        height: 25px;
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
    .style36
    {
        width: 153px;
        height: 25px;
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
        width: 92%;
        height: 17px;
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
    .style52
    {
        width: 109px;
    }
    .style48
    {
        width: 331px;
    }
    .style50
    {
        width: 127px;
    }
    .style1
    {
        width: 96%;
        height: 36px;
    }
    </style>
    <script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
    <script type="text/javascript">
    function Calculatotal(){
        var efectivo, cheque, otros, total;
        efectivo = parseFloat(document.getElementById("<%=txtmonto.ClientID %>").value);
        cheque = parseFloat(document.getElementById("<%=txtcheque.ClientID %>").value);
        otros = parseFloat(document.getElementById("<%=txtotros.ClientID %>").value);
        total = parseFloat(efectivo + cheque + otros);
        document.getElementById("<%=txttotal.ClientID %>").value = total.toFixed(2);
    }

    </script>
<table cellpadding="0" cellspacing="0" class="style55">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table cellpadding="0" cellspacing="0" class="style14" 
    
    style="border: thin solid #003366; WIDTH: 712px; HEIGHT: 179px; BACKGROUND-COLOR: #ffffff">
                        <tr>
                            <td>
                                <table cellpadding="0" cellspacing="0" class="style14">
                                    <tr>
                                        <td align="center">
                                            <asp:label id="Label1" Font-Bold="True" Font-Names="Verdana" 
                                                ForeColor="#16387C" Width="400px"
				runat="server" Font-Size="Medium" Height="15px">DEPOSITO A AHORROS POR CUENTA CONTABLE</asp:label>
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
							Font-Size="8pt" Enabled="False" Height="21px" BorderWidth="1px"></asp:textbox>
                                                    </td>
                                                    <td class="style30">
                                                        &nbsp;</td>
                                                    <td class="style18">
                                                        <asp:label id="Label19" runat="server" Width="113px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px">Nº Serie Colector:</asp:label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtcolector" runat="server" Font-Names="Calibri" 
                                        Font-Size="12pt" Height="22px" Width="90px"></asp:TextBox>
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
							Width="123px" Enabled="False" BorderWidth="1px"></asp:textbox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right" class="style29">
                                                        <asp:label id="Label20" runat="server" Width="73px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px">Nombre:</asp:label>
                                                    </td>
                                                    <td class="style25">
                                                        <asp:textbox id="txtnomcli" runat="server" Width="336px" Font-Names="Verdana"
							Font-Size="8pt" Enabled="False" Height="21px" BorderWidth="1px"></asp:textbox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right" class="style53">
                                                        <asp:label id="Label21" runat="server" Width="60px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px">Saldo:</asp:label>
                                                    </td>
                                                    <td class="style54">
                                                        <asp:textbox id="txtsaldo" runat="server" Width="120px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False"></asp:textbox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right" class="style53">
                                                        <asp:Label ID="Label32" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                                            Height="16px" Width="110px">Cuenta Contable:</asp:Label>
                                                    </td>
                                                    <td class="style54">
                                                        <cc2:CbxCtaCTB ID="CbxCtaCTB1" runat="server" Font-Names="Calibri" 
                                                            Font-Size="10pt" Width="300px">
                                                        </cc2:CbxCtaCTB>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style16" align="right">
                                                        &nbsp;</td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlpromociones" runat="server" Enabled="False" 
                                        Font-Names="Calibri" Font-Size="10pt" Height="16px" Width="219px" Visible="False">
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
							Font-Size="8pt" BorderWidth="1px" MaxLength="9"></asp:textbox>
                                                                </td>
                                                                <td>
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td align="right" class="style24">
                                                                    <asp:label id="Label6" runat="server" Width="88px" Font-Names="Verdana" 
                                                    Font-Size="8pt">Efectivo:</asp:label>
                                                                </td>
                                                                <td class="style25">
                                                                    <asp:TextBox ID="txtmonto" runat="server" onchange = "Calculatotal()" 
                                                    Font-Names="Calibri" Font-Size="12pt" 
                                                    Height="20px" Width="90px" BorderWidth="1px"  ></asp:TextBox>
                                                                </td>
                                                                <td class="style25">
                                                                    <asp:RangeValidator id="RangeValidator3" Font-Size="8pt" runat="server" 
                                                                        Width="82px" Font-Names="Verdana"
							ControlToValidate="txtmonto" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="right" class="style22">
                                                                    <asp:label id="Label17" runat="server" Width="88px" Font-Names="Verdana" 
                                                    Font-Size="8pt">Cheque:</asp:label>
                                                                </td>
                                                                <td>
                                                                    <asp:TextBox ID="txtcheque" runat="server" Font-Names="Calibri" 
                                                    Font-Size="12pt" Height="20px" Width="90px" onchange="Calculatotal();" 
                                                    BorderWidth="1px"></asp:TextBox>
                                                                </td>
                                                                <td>
                                                                    <asp:RangeValidator id="RangeValidator4" Font-Size="8pt" runat="server" 
                                                                        Width="82px" Font-Names="Verdana"
							ControlToValidate="txtcheque" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="right" class="style26">
                                                                    <asp:label id="Label18" runat="server" Width="88px" Font-Names="Verdana" 
                                                    Font-Size="8pt">Otros:</asp:label>
                                                                </td>
                                                                <td class="style27">
                                                                    <asp:TextBox ID="txtotros" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                                    Height="20px" Width="90px" onchange="Calculatotal();" BorderWidth="1px"></asp:TextBox>
                                                                </td>
                                                                <td class="style27">
                                                                    <asp:RangeValidator id="RangeValidator5" Font-Size="8pt" runat="server" 
                                                                        Width="82px" Font-Names="Verdana"
							ControlToValidate="txtotros" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="right" class="style26">
                                                                    <asp:label id="Label22" runat="server" Width="49px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Total:</asp:label>
                                                                </td>
                                                                <td class="style27">
                                                                    <asp:textbox id="txttotal" runat="server" Width="120px" BackColor="AliceBlue"
							Font-Names="Verdana" Font-Size="8pt" Enabled="False" BorderWidth="1px"></asp:textbox>
                                                                </td>
                                                                <td class="style27">
                                                                    &nbsp;</td>
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
                                                                    <asp:dropdownlist id="ddltipaho" runat="server" Width="156px" 
                                                    Font-Names="Verdana" Font-Size="8pt" Enabled="False" Height="23px">
                                                                    </asp:dropdownlist>
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
                                                                    <asp:label id="Label9" runat="server" Width="64px" Font-Names="Verdana" 
                                                    Font-Size="8pt">Fecha:</asp:label>
                                                                </td>
                                                                <td>
                                                                    <asp:textbox id="txtfecha" runat="server" Width="72px" Font-Names="Verdana"
							Font-Size="8pt" BorderWidth="1px"></asp:textbox>
                                                                </td>
                                                                <td>
                                                                    &nbsp;</td>
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
                                                    CssClass="captura" Enabled="False"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="right" class="style36">
                                                                    <asp:label id="Label24" runat="server" Width="49px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Compensado:</asp:label>
                                                                </td>
                                                                <td class="style27">
                                                                    <asp:TextBox ID="txtcompensado" runat="server" Height="21px" Width="88px" 
                                                    CssClass="captura" Enabled="False"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="right" class="style37">
                                                                    <asp:label id="Label25" runat="server" Width="129px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Total Aportaciones:</asp:label>
                                                                </td>
                                                                <td class="style38">
                                                                    <asp:TextBox ID="txttotaporta" runat="server" Height="21px" Width="88px" 
                                                    CssClass="captura" Enabled="False"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="right" class="style31">
                                                                    <asp:label id="Label26" runat="server" Width="129px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Mora en Aportaciones:</asp:label>
                                                                </td>
                                                                <td>
                                                                    <asp:TextBox ID="txtmoraaporta" runat="server" Height="21px" Width="88px" 
                                                    CssClass="captura" Enabled="False"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="right" class="style32">
                                                                    <asp:label id="Label27" runat="server" Width="142px" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="16px">Observaciones del Documento:</asp:label>
                                                                </td>
                                                                <td class="style33">
                                                                    <asp:TextBox ID="txtobserva" runat="server" Height="51px" Width="132px" 
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
                                                                    <asp:TextBox ID="txtnotas" runat="server" Height="49px" Width="132px" 
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
                                                    <td align="right" class="style42">
                                                        <asp:label id="Label29" runat="server" Width="83px" 
                                        Font-Names="Verdana" Font-Size="8pt" Height="16px" 
                                        style="margin-left: 0px; margin-right: 0px">Salida:</asp:label>
                                                    </td>
                                                    <td class="style44">
                                                        <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" 
                                        Font-Names="Calibri" Font-Size="10pt" GroupName="libreta" 
                                        Text="CON LIBRETA" />
                                                    </td>
                                                    <td class="style43">
                                                        <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" GroupName="libreta" Text="SIN LIBRETA" />
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
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
                                                <tr>
                                                    <td class="style52" align="right">
                                                        <asp:label id="Label31" runat="server" Width="88px" Font-Names="Verdana" 
                                                    Font-Size="8pt">Cheque:</asp:label>
                                                    </td>
                                                    <td class="style48">
                                                        <asp:TextBox ID="txtnroche" runat="server" Font-Names="Calibri" 
                                                    Font-Size="12pt" Height="20px" Width="90px" 
                                        onchange="Calculatotal();"></asp:TextBox>
                                                    </td>
                                                    <td class="style50">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style52">
                                                        &nbsp;</td>
                                                    <td class="style48">
                                                        &nbsp;</td>
                                                    <td class="style50">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
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
                                        <td>
                                            <table align="center" cellpadding="0" cellspacing="0" class="style1">
                                                <tr>
                                                    <td>
                                                        <asp:Button ID="btnaplicar" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Height="27px" Text="Aplicar" Width="84px" Enabled="False" />
                                                        <cc1:ConfirmButtonExtender ID="btnaplicar_ConfirmButtonExtender" runat="server" 
                                        ConfirmText="Esta seguro?" Enabled="True" TargetControlID="btnaplicar">
                                                        </cc1:ConfirmButtonExtender>
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
                                        Height="27px" Text="Recibo" Width="84px" Visible="False" />
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="btn_rec_direct" runat="server" Font-Names="Calibri" 
                                                            Font-Size="12pt" Height="27px" Text="Recibo Direc" Width="91px" />
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="btnlibreta" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Height="27px" Text="Im.Libreta" Width="84px" Enabled="False" Visible="False" />
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="btnlibreta0" runat="server" Font-Names="Calibri" 
                                                            Font-Size="12pt" Height="27px" Text="Lib. Direc." Width="84px" />
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="btnprogra" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                        Text="Lavado de Dinero" Width="130px" Visible="False" />
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="btnreimp" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Height="27px" Text="ReImp. Rec" Width="84px" />
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
                                            <asp:radiobutton id="efectivo" runat="server" Text="Efectivo" Checked="True" Font-Names="Verdana"
								Font-Size="8pt" AutoPostBack="True" GroupName="tipo" Visible="False">
                                            </asp:radiobutton>
                                            <asp:dropdownlist id="ddlbancos" runat="server" Width="107px" 
                            Font-Names="Verdana" Font-Size="8pt" Height="16px" Visible="False">
                                            </asp:dropdownlist>
                                            <asp:checkbox id="Imprimir" runat="server" Width="74px" Font-Names="Verdana" 
                                                    Font-Size="X-Small" Checked="True" Text="Imprimir" 
                            Height="16px" Visible="False">
                                            </asp:checkbox>
                                            <asp:radiobutton id="bancos" runat="server" Text="Bancos" Font-Size="8pt" 
                            Font-Names="Verdana" AutoPostBack="True" GroupName="tipo" Visible="False">
                                            </asp:radiobutton>
                                            <asp:textbox id="txtdepositos" runat="server" Width="16px" Height="8px" 
                            Visible="False"></asp:textbox>
                                            <asp:TextBox ID="escondido_TextBox" runat="server" Visible="False" Width="30px"></asp:TextBox>
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
                    <asp:PostBackTrigger ControlID="btnreimp" />
                </Triggers>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>


