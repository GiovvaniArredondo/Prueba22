<%@ Control Language="vb" AutoEventWireup="false" Codefile="CUWPreAprInd.ascx.vb" Inherits="CUWPreAprInd"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc2" %>
<meta content="False" name="vs_showGrid">
<style type="text/css">
    .style9
    {
        width: 61%;
        height: 406px;
    }
    .style10
    {
        width: 115%;
        height: 284px;
    }
    .style11
    {
        width: 72%;
        height: 30px;
    }
    .style12
    {
        width: 68px;
    }
    .style13
    {
        width: 81px;
    }
    .style14
    {
        width: 157px;
    }
    .style15
    {
        width: 95%;
        height: 15px;
    }
    .style16
    {
        width: 64px;
    }
    .style17
    {
        width: 94%;
    }
    .style18
    {
        width: 63px;
        height: 23px;
    }
    .style19
    {
        height: 23px;
    }
    .style20
    {
        width: 99%;
        height: 82px;
    }
    .style21
    {
        width: 156px;
    }
    .style22
    {
        width: 98%;
        height: 208px;
    }
    .style25
    {
        width: 141px;
    }
    .style26
    {
    }
    .style27
    {
        width: 120px;
        height: 38px;
    }
    .style29
    {
        width: 141px;
        height: 38px;
    }
    .style30
    {
        height: 38px;
    }
    .style31
    {
        height: 27px;
    }
    .style32
    {
        width: 615px;
    }
    .style33
    {
        width: 71%;
        height: 63px;
    }
    .style34
    {
        width: 139px;
    }
    .style36
    {
        width: 118px;
    }
    .style37
    {
        width: 95px;
    }
    .style38
    {
        width: 156px;
        height: 38px;
    }
    .style40
    {
        width: 100%;
    }
    .style41
    {
        width: 168px;
    }
    .style42
    {
        height: 38px;
        width: 168px;
    }
    .style43
    {
        height: 63px;
    }
    .style44
    {
        width: 120px;
        height: 30px;
    }
    .style45
    {
        width: 141px;
        height: 30px;
    }
    .style46
    {
        width: 168px;
        height: 30px;
    }
    .style47
    {
        height: 30px;
    }
    .style48
    {
        width: 120px;
        height: 35px;
    }
    .style49
    {
        width: 141px;
        height: 35px;
    }
    .style50
    {
        width: 168px;
        height: 35px;
    }
    .style51
    {
        height: 35px;
    }
    .style52
    {
        width: 120px;
        height: 26px;
    }
    .style53
    {
        width: 141px;
        height: 26px;
    }
    .style54
    {
        width: 168px;
        height: 26px;
    }
    .style55
    {
        height: 26px;
    }
</style>
<script src="js/jquery.js" type="text/javascript"></script>    
 <script type="text/javascript" src="js/lib.js"></script>
 <script type="text/javascript">
function ValidaTasa() {
            var ntasa, ntasmin, ntasmax, ntasaestandar;
            ntasa = document.getElementById("<%=txttasa.ClientID %>").value;
            ntasmin = document.getElementById("<%=HiddenField2.ClientID %>").value;
            ntasmax = document.getElementById("<%=HiddenField3.ClientID %>").value;
            ntasaestandar = document.getElementById("<%=HiddenField4.ClientID %>").value;
            if (ntasa < ntasmin || ntasa > ntasmax) {
                document.getElementById("<%=txttasa.ClientID %>").value = ntasaestandar;
                alert('Tasa Fuera de Rango, Verifique!!!');
             }
        }
        

 </script>
<table cellpadding="0" cellspacing="0" class="style9">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <table bgcolor="White" cellpadding="0" cellspacing="0" class="style9" 
                style="border: thin solid #003366; WIDTH: 725px; HEIGHT: 315px">
                <tr>
                    <td class="style32">
                        <table align="left" bgcolor="White" cellpadding="0" cellspacing="0" 
                            class="style10">
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style11">
                                        <tr>
                                            <td class="style12">
                                                <asp:label id="Label1" runat="server" Width="57px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C" Height="16px">Credito:</asp:label>
                                            </td>
                                            <td class="style13">
                                                <asp:dropdownlist id="cbxCodIns" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist>
                                            </td>
                                            <td class="style14">
                                                <asp:dropdownlist id="cbxcodofi" runat="server" Width="161px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"></asp:dropdownlist>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtcnrocta" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px"
								Enabled="False"></asp:textbox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style15">
                                        <tr>
                                            <td class="style16">
                                                <asp:label id="Label2" runat="server" Width="58px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C" Height="16px">Cliente:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtcCodCli" runat="server" Width="224px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="23px"></asp:textbox>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtcNomcli" runat="server" Width="224px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="24px"></asp:textbox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style17">
                                        <tr>
                                            <td class="style18">
                                                <asp:label id="Label3" runat="server" Width="66px" Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#16387C">Analista:</asp:label>
                                            </td>
                                            <td class="style19">
                                                <asp:textbox id="txtNomAna" runat="server" Width="252px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </td>
                                            <td class="style19">
                                                <asp:textbox id="txtCredito" runat="server" Width="182px" Font-Size="10pt" BorderWidth="1px" Visible="False"></asp:textbox>
                                            </td>
                                            <td class="style19">
                                                <asp:textbox id="txtcontrato" runat="server" Width="24px" Visible="False"></asp:textbox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:label id="Label7" runat="server" Width="126px" Font-Names="Calibri" Font-Size="12pt"
									ForeColor="#003300" BorderColor="#003300" Font-Bold="True" Height="16px">Datos del Crédito</asp:label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style20">
                                        <tr>
                                            <td align="right" class="style21">
                                                <asp:label id="Label13" runat="server" Width="62px" Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#16387C">Grupo:</asp:label>
                                            </td>
                                            <td>
                                                <SELECT id="cbxgrupos" style="FONT-SIZE: 12px; WIDTH: 399px; FONT-FAMILY: 'Gill Sans MT'"
								name="cbxanacre" runat="server">
								<OPTION selected></OPTION>
							</SELECT></td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style21">
                                                <asp:label id="Label8" runat="server" Width="115px" Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#16387C">Línea de Crédito:</asp:label>
                                            </td>
                                            <td>
                                                <asp:dropdownlist id="cbxLineas" runat="server" Width="400px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt"
									Height="33px" AutoPostBack="True"></asp:dropdownlist>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style38">
                                                <asp:label id="Label17" runat="server" Width="115px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C">Fuente de Fondos:</asp:label>
                                            </td>
                                            <td class="style30">
                        <asp:DropDownList ID="cbxprograma" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="19px" Width="400px" AutoPostBack="True">
                        </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style21">
							<asp:label id="Label15" runat="server" Width="132px" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#16387C" Height="19px">Causas de Rechazo:</asp:label>
						                    </td>
                                            <td>
                                                <asp:dropdownlist id="cbxrechazo" runat="server" Width="456px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt"
									Height="32px" Visible="False"></asp:dropdownlist>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style21">
							<asp:label id="Label35" runat="server" Width="165px" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#16387C" Height="16px" Visible="False">Documento de Formalización:</asp:label>
						                    </td>
                                            <td>
                                                <asp:dropdownlist id="cbxContrato" runat="server" Width="401px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="43px" Visible="False"></asp:dropdownlist>
                                            </td>
                                        </tr>
                                        </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style22">
                                        <tr>
                                            <td align="right" class="style26">
                                                <asp:label id="Label4" runat="server" Width="115px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C"
								Height="19px">Monto Solicitado:</asp:label>
                                            </td>
                                            <td class="style26">
                                                <asp:textbox id="txtMonSol" runat="server" Width="94px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </td>
                                            <td align="right" class="style25">
                                                <asp:label id="Label5" runat="server" Width="123px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C" style="margin-left: 6px">Monto Aprobado</asp:label>
                                            </td>
                                            <td class="style41">
                                                <asp:textbox id="txtnMonApr" runat="server" Width="92px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px"></asp:textbox>
                                            </td>
                                            <td>
                                                <asp:rangevalidator id="RangeValidator1" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" ErrorMessage="RangeValidator"
									Type="Double" MinimumValue="25" MaximumValue="1000000000" ControlToValidate="txtnMonApr">Monto 
                                                Inválido-</asp:rangevalidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style27">
                                                <asp:label id="Label10" runat="server" Width="103px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C">Monto Sugerido</asp:label>
                                            </td>
                                            <td class="style27">
                                                <asp:textbox id="txtmonSug" runat="server" Width="93px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="19px"></asp:textbox>
                                            </td>
                                            <td align="right" class="style29">
                                                    <asp:Label ID="Label34" runat="server" Font-Names="Gill Sans MT" 
                                                        Font-Size="10pt" Width="94px">Tasa de Interes:</asp:Label>
                                            </td>
                                            <td class="style42">
                                                    <asp:TextBox ID="txttasa" runat="server" BorderWidth="1px" 
                                                        Font-Names="Gill Sans MT" Font-Size="10pt" onchange="ValidaTasa();" 
                                                        Width="80px" Enabled="False"></asp:TextBox>
                                            </td>
                                            <td class="style30">
                                                    <asp:RangeValidator ID="RangeValidator9" runat="server" 
                                                        ControlToValidate="txttasa" ErrorMessage="RangeValidator" Font-Names="Verdana" 
                                                        Font-Size="8pt" MaximumValue="200" MinimumValue="0" Type="Double" 
                                                    Width="149px">Tasa Inválido-</asp:RangeValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style26">
                                                <asp:label id="Label38" runat="server" Width="103px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C">F.Desemb.Sug:</asp:label>
                                            </td>
                                            <td class="style26">
                                                <asp:textbox id="txtFecDes0" runat="server" Width="94px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </td>
                                            <td align="right" class="style25">
                                                <asp:label id="Label6" runat="server" Width="128px" Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#16387C">Fecha Desembolso</asp:label>
                                            </td>
                                            <td class="style41">
                                                <asp:textbox id="txtFecDes" runat="server" Width="94px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px"></asp:textbox>
                                            </td>
                                            <td>
                                                <asp:rangevalidator id="RangeValidator2" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" ErrorMessage="RangeValidator"
									Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtFecDes">Fecha 
                                                Inválida-</asp:rangevalidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style44">
                                                <asp:label id="Label39" runat="server" Width="103px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C">F.1ªCuota Sug:</asp:label>
                                            </td>
                                            <td class="style44">
                                                <asp:textbox id="txtfecpri0" runat="server" Width="94px" 
                                                    Font-Names="Gill Sans MT" Font-Size="Smaller"
									BorderWidth="1px" Height="20px" Enabled="False"></asp:textbox>
                                            </td>
                                            <td class="style45" align="right">
                                                <asp:label id="Label12" runat="server" Width="99px" Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#16387C"
								Height="18px">Fecha 1er.Cuota</asp:label>
                                            </td>
                                            <td class="style46">
                                                <asp:textbox id="txtfecpri" runat="server" Width="94px" 
                                                    Font-Names="Gill Sans MT" Font-Size="Smaller"
									BorderWidth="1px" Height="20px"></asp:textbox>
                                            </td>
                                            <td class="style47">
                                                <asp:rangevalidator id="Rangevalidator6" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" ErrorMessage="RangeValidator"
									Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" ControlToValidate="txtfecpri" DESIGNTIMEDRAGDROP="1491">Fecha 
                                                Inválida-</asp:rangevalidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style26">
                                                <asp:label id="Label14" runat="server" Width="48px" Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#16387C">Cuotas</asp:label>
                                            </td>
                                            <td class="style26">
                                                <asp:textbox id="pnCuoSug" runat="server" Width="92px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="20px"></asp:textbox>
                                            </td>
                                            <td class="style25" align="right">
                                                <asp:label id="Label18" runat="server" Width="103px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C">Tipo de Cuota:</asp:label>
                                            </td>
                                            <td class="style41">
                                                <asp:textbox id="txttipocuota" runat="server" Width="93px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="21px"></asp:textbox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style52">
                                                <asp:label id="Label40" runat="server" Width="80px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C">Monto Cuota:</asp:label>
                                            </td>
                                            <td class="style52">
                                                <asp:textbox id="txtnmoncuo" runat="server" Width="92px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="20px">0.00</asp:textbox>
                                            </td>
                                            <td class="style53" align="right">
                                            </td>
                                            <td class="style54">
                                            </td>
                                            <td class="style55">
                                                </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style26">
                                                <asp:label id="Label16" runat="server" Width="48px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#16387C">Garantías</asp:label>
                                            </td>
                                            <td class="style26">
                                                <asp:textbox id="txtgarantias" runat="server" Width="93px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="22px"></asp:textbox>
                                            </td>
                                            <td class="style25" align="right">
                                                &nbsp;</td>
                                            <td class="style41">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style48">
                                                <asp:label id="Label19" runat="server" Width="48px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="Black" Visible="False">Gastos:</asp:label>
                                            </td>
                                            <td class="style48">
                                                <asp:TextBox ID="Txtncomis" runat="server" BorderWidth="1px" 
                                                    Font-Names="Gill Sans MT" Font-Size="12pt" Width="80px" Visible="False">0.0</asp:TextBox>
                                            </td>
                                            <td class="style49" align="right">
                                        <asp:Label ID="Label33" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                            Text="Nº Cuotas a Cobrar:" Visible="False"></asp:Label>
                                            </td>
                                            <td class="style50">
                                        <asp:textbox id="pnCuoSug0" runat="server" Width="80px" 
                                            Font-Names="Gill Sans MT" Font-Size="Smaller"
								BorderWidth="1px" Height="21px" Visible="False"></asp:textbox>
                                            </td>
                                            <td class="style51">
                                        <asp:rangevalidator id="RangeValidator7" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ErrorMessage="RangeValidator"
								ControlToValidate="pnCuoSug0" MaximumValue="240" MinimumValue="0" Type="Integer">Cuotas Inválidas-</asp:rangevalidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style48">
                                                <asp:label id="Label41" runat="server" Width="100px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="Black">Nivel Comite:</asp:label>
                                            </td>
                                            <td class="style48">
                                                <cc2:CbxUsuario_Comite ID="CbxUsuario_Comite1" runat="server" 
                                                    Font-Names="Calibri" Font-Size="10pt" Width="200px" Enabled="False">
                                                </cc2:CbxUsuario_Comite>
                                            </td>
                                            <td class="style49" align="right">
                                                &nbsp;</td>
                                            <td class="style50">
                                                &nbsp;</td>
                                            <td class="style51">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style26">
                                                &nbsp;</td>
                                            <td class="style26">
                                                <asp:RangeValidator ID="RangeValidator8" runat="server" 
                                                    ControlToValidate="Txtncomis" ErrorMessage="RangeValidator" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" MaximumValue="1000000" MinimumValue="0" 
                                                    Type="Double" Width="149px">Comisión Inválido</asp:RangeValidator>
                                            </td>
                                            <td class="style25" align="right">
                                                &nbsp;</td>
                                            <td class="style41">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style26">
                                                <asp:label id="Label36" runat="server" Width="89px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#003366" Font-Bold="True">ACTA Nº:</asp:label>
                                            </td>
                                            <td class="style26">
                                                <asp:TextBox ID="txtacta" runat="server" Font-Names="Gill Sans MT"></asp:TextBox>
                                            </td>
                                            <td class="style25" align="right">
                                                <asp:label id="Label37" runat="server" Width="89px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#003366" Font-Bold="True">Resolución:</asp:label>
                                            </td>
                                            <td class="style41">
                                                <asp:TextBox ID="txtresolucion" runat="server" Font-Names="Gill Sans MT"></asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style26">
                                                <asp:Label ID="Label42" runat="server" CssClass="style16" Font-Bold="True" 
                                                    Font-Names="Gisha" Font-Size="Smaller" Text="Datos Adicionales Vivienda" 
                                                    Visible="False"></asp:Label>
                                            </td>
                                            <td class="style26" colspan="4">
                                                <asp:TextBox ID="txtInfoAdicionalVivienda" runat="server" Columns="20" 
                                                    Enabled="False" Height="76px" Rows="10" TextMode="MultiLine" Width="503px"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                           
                            <tr>
                                <td class="style31">
                                    <asp:label id="Label11" runat="server" Width="295px" Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="Red"
									Height="21px" Font-Bold="True"></asp:label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style43">
                                    <table align="center" cellpadding="0" cellspacing="0" class="style33">
                                        <tr>
                                            <td class="style36">
                                                <INPUT id="btnGrabar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
								type="button" name="Button4" runat="server"></td>
                                            <td class="style37">
                                                <INPUT id="btnPlan" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_plan_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
								type="button" name="Button8" runat="server"></td>
                                            <td class="style34">
                                                <INPUT id="Button2" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
								type="button" name="Button7" runat="server"></td>
                                            <td>
                                <asp:ImageButton ID="ImageButton1" runat="server" BorderColor="Black" 
                                    ImageUrl="~/web/jpgs/btn_rechazar_b.jpg" />
                                <cc1:ConfirmButtonExtender ID="ImageButton1_ConfirmButtonExtender" 
                                    runat="server" ConfirmText="Seguro de Rechazar?" Enabled="True" 
                                    TargetControlID="ImageButton1">
                                </cc1:ConfirmButtonExtender>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
				<asp:textbox id="txtdFecVen" runat="server" Width="48px" Visible="False"></asp:textbox><asp:textbox id="txtcTipCuo" runat="server" Width="64px" Visible="False"></asp:textbox><asp:textbox id="txtcTipPer" runat="server" Width="64px" Visible="False"></asp:textbox><asp:textbox id="txtnperdia" runat="server" Width="56px" Visible="False"></asp:textbox><asp:textbox id="txtndiaGra" runat="server" Width="44px" Visible="False"></asp:textbox>
				<asp:textbox id="txtcflat" runat="server" Width="44px" Visible="False"></asp:textbox>
				<asp:textbox id="txtcfreccap" runat="server" Width="44px" Visible="False"></asp:textbox>
				<asp:textbox id="txtcfrecint" runat="server" Width="44px" Visible="False"></asp:textbox>
                            <asp:TextBox ID="txtccodsol" runat="server" Visible="False" Width="61px"></asp:TextBox>
                            <asp:TextBox ID="txtbandera" runat="server" Visible="False" Width="61px"></asp:TextBox>
							                    <asp:CheckBox ID="Chkseguro" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Microseguro?" Visible="False" />
                                    <table cellpadding="0" cellspacing="0" class="style40">
                                        <tr>
                                            <td>
                                        <asp:HiddenField ID="HiddenField5" runat="server" />
                                            </td>
                                            <td>
                                        <asp:HiddenField ID="HiddenField6" runat="server" />
                                            </td>
                                            <td>
                                        <asp:HiddenField ID="HiddenField7" runat="server" />
                                            </td>
                                            <td>
                                        <asp:HiddenField ID="HiddenField8" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                        <asp:HiddenField ID="HiddenField2" runat="server" />
                                            </td>
                                            <td>
                                        <asp:HiddenField ID="HiddenField3" runat="server" />
                                            </td>
                                            <td>
                                        <asp:HiddenField ID="HiddenField4" runat="server" />
                                            </td>
                                            <td>
                                                <asp:HiddenField ID="HiddenField9" runat="server" />
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

