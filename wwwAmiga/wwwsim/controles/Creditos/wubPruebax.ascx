<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="wubPruebax" CodeFile="wubPruebax.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc2" %>
<link href="Estilo.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .style1
    {
        width: 87%;
        height: 125px;
    }
    .style2
    {
        width: 318px;
        height: 82px;
    }
    .style3
    {
        height: 6px;
        text-align: center;
    }
    .style4
    {
        width: 79%;
        height: 110px;
    }
    .style5
    {
        width: 82px;
    }
    .style6
    {
        width: 70%;
        height: 71px;
    }
    .style7
    {
        width: 62%;
        height: 82px;
    }
    .style8
    {
        width: 133px;
    }
    .style9
    {
        height: 42px;
    }
    .style10
    {
        height: 31px;
    }
    .style12
    {
        width: 133px;
        height: 30px;
    }
    .style13
    {
        height: 30px;
    }
</style>
<script type="text/javascript">


</script>
<P>
	<TABLE id="Table15" style="border: thin solid highlight; WIDTH: 839px; HEIGHT: 327px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" align="left" border="0">
		<TR>
			<TD style="HEIGHT: 14px">
				<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
					align="center">SIMULACION DE ESCENARIOS (PRUEBA X)</P>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 14px" align="center">
				<table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label1" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Codigo Cliente:" style="text-align: left" 
                                Width="130px"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtccodcli" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Height="23px" Width="143px" 
                                BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label2" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Nombre Cliente:" style="text-align: left" 
                                Width="130px"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtcnomcli" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Height="24px" Width="258px" 
                                BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Text="Codigo Credito:" 
                                style="text-align: left" Width="130px"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtccodcta" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Height="24px" Width="258px" 
                                BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label27" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Text="Fecha Desembolso:" 
                                style="text-align: left" Width="130px"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtdfecvig" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Height="24px" Width="120px" 
                                BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="text-align: right">
				<asp:Label ID="tipo_credito" runat="server" Font-Bold="True" 
                    Font-Names="Gill Sans MT" Font-Size="10pt" Font-Strikeout="False" ForeColor="Red" 
                                style="text-align: left" Width="130px"></asp:Label>
                        </td>
                        <td style="text-align: left">
                            <asp:TextBox ID="txtbandera" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False" Width="30px">0</asp:TextBox>
                        </td>
                    </tr>
                </table>
			</TD>
		</TR>
		<TR>
			<TD align="center" class="style3">
				<asp:GridView ID="dgAjustes" runat="server" AutoGenerateColumns="False" 
                    Font-Names="Gill Sans MT" Font-Size="8pt" Width="403px" ShowFooter="True">
                    <Columns>  
                        
                        <asp:BoundField DataField="dfecpro" DataFormatString="{0:dd-MM-yyyy}"  HeaderText="Fec.Pago">                                            
                              <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>                                                  
                         <asp:BoundField DataField="cnuming" HeaderText="No Doc" > 
                              <ItemStyle HorizontalAlign="Center" /> 
                        </asp:BoundField>                                                                    
                        <asp:BoundField DataField="nmonto" HeaderText="Pago" > 
                              <ItemStyle HorizontalAlign="Right" /> 
                        </asp:BoundField>                    
                        <asp:BoundField DataField="ccodusu" HeaderText="Usuario" > 
                              <ItemStyle HorizontalAlign="center" /> 
                        </asp:BoundField>                         
                    </Columns>
                </asp:GridView>
			</TD>
		</TR>
		<TR>
			<TD align="center" class="style3">
				<table align="center" cellpadding="0" cellspacing="0" class="style2">
                    <tr>
                        <td align="right" class="style10">
                            <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Text="Cta. Contable:"></asp:Label>
                        </td>
                        <td class="style10">
                            <cc2:CbxCatalogo ID="CbxCatalogo1" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="18px" Width="207px">
                            </cc2:CbxCatalogo>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="btnAjuste" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Realizar Ajuste" Width="110px" Enabled="False" />
                            <cc1:ConfirmButtonExtender ID="btnAjuste_ConfirmButtonExtender" runat="server" 
                                ConfirmText="Realmente Desea Continuar ?" Enabled="True" 
                                TargetControlID="btnAjuste">
                            </cc1:ConfirmButtonExtender>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style9">
                            &nbsp;</td>
                        <td class="style9">
                            <asp:Button ID="btnImprime_Ajuste" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Imprimir Ajuste" Width="110px" Enabled="False" 
                                Visible="False" />
                        </td>
                    </tr>
                    </table>
			</TD>
		</TR>
		<TR>
			<TD align="center" class="style3">
				&nbsp;</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 14px" align="center">
				<table cellpadding="0" cellspacing="0" class="style6">
                    <tr>
                        <td>
                            <asp:Label ID="Label17" runat="server" Font-Bold="True" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Font-Strikeout="False" 
                                Text="Saldo Capital"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label18" runat="server" Font-Bold="True" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Font-Strikeout="False" 
                                Text="Saldo Int.Normal"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label19" runat="server" Font-Bold="True" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Font-Strikeout="False" 
                                Text="Saldo Int.Moratorio"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label20" runat="server" Font-Bold="True" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Font-Strikeout="False" 
                                Text="Deuda Capital"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtnsalcap" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtnsalint" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtnsalmor" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtndeucap" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                            <asp:TextBox ID="txtajuste5" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False"></asp:TextBox>
                        </td>
                    </tr>
                </table>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 14px" align="center">
				<table cellpadding="0" cellspacing="0" class="style4">
                    <tr>
                        <td class="style5">
                            &nbsp;</td>
                        <td>
                            <asp:Label ID="Label8" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False">Capital:</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False">Int.Normal+Iva</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False">Int.Morat.+Iva</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label13" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False">Otros</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Visible="False">PROGAPE</asp:Label>
                        </td>
                        <td style="text-align: center">
                            <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Visible="False">Com.xAdmonOtr</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <asp:Label ID="Label7" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Width="120px">Pagado Importado:</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpagado1" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpagado2" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpagado3" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpagado6" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpagado5" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpagado4" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Width="120px">Saldo Pagos Real</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtanterior1" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt"   AutoPostBack="True" BorderColor="#2E6A99" 
                                BorderWidth="1px" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtanterior2" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt"   AutoPostBack="True" BorderColor="#2E6A99" 
                                BorderWidth="1px" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtanterior3" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt"   AutoPostBack="True" BorderColor="#2E6A99" 
                                BorderWidth="1px" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtanterior6" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt"   AutoPostBack="True" BorderColor="#2E6A99" 
                                BorderWidth="1px" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtanterior5" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt"   AutoPostBack="True" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtanterior4" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt"   AutoPostBack="True" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            <asp:Label ID="Label15" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Width="120px">Ajuste a Realizar:</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtajuste1" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtajuste2" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtajuste3" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtajuste6" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtajuste4" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnverifica" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Verificar Ajuste" Width="110px" Enabled="False" 
                                Visible="False" />
                        </td>
                    </tr>
                </table>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 14px" align="center">
				<asp:Label ID="Label16" runat="server" Font-Bold="True" 
                    Font-Names="Gill Sans MT" Font-Size="10pt" Font-Strikeout="False" 
                    Text="APLICACION DE PAGOS"></asp:Label>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 14px" align="center">
				<table cellpadding="0" cellspacing="0" class="style7">
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label21" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False">Fecha Valor:</asp:Label>
                        </td>
                        <td class="style8">
                            <asp:TextBox ID="txtdfecval" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Width="75px" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                            <cc1:MaskedEditExtender ID="txtdfecval_MaskedEditExtender" runat="server" 
                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                Mask="99/99/9999" MaskType="Date" TargetControlID="txtdfecval">
                            </cc1:MaskedEditExtender>
                            <cc1:CalendarExtender ID="txtdfecval_CalendarExtender" runat="server" 
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdfecval">
                            </cc1:CalendarExtender>
                        </td>
                        <td>
                            <asp:Button ID="btnaplicar" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Aplicar" Width="75px" Enabled="False" 
                                Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style13">
                            <asp:Label ID="Label28" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False">No Boleta:</asp:Label>
                        </td>
                        <td class="style12">
                            <asp:TextBox ID="txtcnuming" runat="server" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" style="height: 22px"></asp:TextBox>
                        </td>
                        <td class="style13">
                            </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label22" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False">Monto a Pagar:</asp:Label>
                        </td>
                        <td class="style8">
                            <asp:TextBox ID="txtnmonpag" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" style="height: 22px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;</td>
                        <td class="style8">
                            <asp:Button ID="btngrabar" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Grabar" Width="75px" Enabled="False" 
                                Visible="False" />
                            <cc1:ConfirmButtonExtender ID="btngrabar_ConfirmButtonExtender" runat="server" 
                                ConfirmText="Realmente Desea Grabar el Pago ?" Enabled="True" 
                                TargetControlID="btngrabar">
                            </cc1:ConfirmButtonExtender>
                            <asp:Button ID="btnsave" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Pago Pendientes" Width="100px" Enabled="False" 
                                style="height: 28px" />
                            <asp:Button ID="btnproc" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Generar Pagos" Width="100px" Enabled="False" 
                                style="height: 28px" />
                            <cc1:ConfirmButtonExtender ID="btnproc_ConfirmButtonExtender" runat="server" 
                                ConfirmText="Realmente Desea Grabar el Pago ?" Enabled="True" 
                                TargetControlID="btnproc">
                            </cc1:ConfirmButtonExtender>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 14px" align="center">
				&nbsp;</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 14px" align="center">
				<asp:GridView ID="dgDetalle" runat="server" AutoGenerateColumns="False" 
                    Font-Names="Gill Sans MT" Font-Size="8pt" Width="659px" ShowFooter="True">
                    <Columns>  
                         <asp:BoundField DataField="dfecsis" DataFormatString="{0:dd-MM-yyyy}"  HeaderText="Fec.Aplica">                                            
                              <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>   
                        <asp:BoundField DataField="dfecpro" DataFormatString="{0:dd-MM-yyyy}"  HeaderText="Fec.Pago">                                            
                              <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>                          
                        <asp:BoundField DataField="cdescob" HeaderText="Tipo" > 
                              <ItemStyle HorizontalAlign="Center" /> 
                        </asp:BoundField>   
                         <asp:BoundField DataField="cnrodoc" HeaderText="Doc" > 
                              <ItemStyle HorizontalAlign="Center" /> 
                        </asp:BoundField>                                                                    
                        <asp:BoundField DataField="npago" HeaderText="Pago" > 
                              <ItemStyle HorizontalAlign="Right" /> 
                        </asp:BoundField> 
                        <asp:BoundField DataField="ncapita" HeaderText="Capital" > 
                              <ItemStyle HorizontalAlign="Right" /> 
                        </asp:BoundField> 
                        <asp:BoundField DataField="nintere" HeaderText="Interes" > 
                              <ItemStyle HorizontalAlign="Right" /> 
                        </asp:BoundField> 
                        <asp:BoundField DataField="nmora" HeaderText="Mora" > 
                              <ItemStyle HorizontalAlign="Right" /> 
                        </asp:BoundField> 
                        <asp:BoundField DataField="notros" HeaderText="Otros" > 
                              <ItemStyle HorizontalAlign="Right" /> 
                        </asp:BoundField> 
                        <asp:BoundField DataField="nsaldo" HeaderText="Saldo" > 
                              <ItemStyle HorizontalAlign="Right" /> 
                        </asp:BoundField>                         
                    </Columns>
                </asp:GridView>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 14px" align="center">
				<asp:HiddenField ID="HiddenField1" runat="server" />
				<table align="center" cellpadding="0" cellspacing="0" class="style2">
                    <tr>
                        <td align="right" class="style10">
                            &nbsp;</td>
                        <td class="style10">
				            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style10">
                            &nbsp;</td>
                        <td class="style10">
				<asp:Label ID="Label4" runat="server" Font-Bold="True" 
                    Font-Names="Gill Sans MT" Font-Size="10pt" Font-Strikeout="False" 
                    Text="IMPORTAR PAGOS" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style10">
                            <asp:Label ID="Label5" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Text="Desde:" Visible="False"></asp:Label>
                        </td>
                        <td class="style10">
                            <asp:TextBox ID="txtdesde" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Width="75px" BorderColor="#2E6A99" BorderWidth="1px" 
                                Visible="False"></asp:TextBox>
                            <cc1:MaskedEditExtender ID="txtdesde_MaskedEditExtender" runat="server" 
                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                Mask="99/99/9999" MaskType="Date" TargetControlID="txtdesde">
                            </cc1:MaskedEditExtender>
                            <cc1:CalendarExtender ID="txtdesde_CalendarExtender" runat="server" 
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdesde">
                            </cc1:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label6" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Text="Hasta:" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txthasta" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Width="75px" BorderColor="#2E6A99" BorderWidth="1px" 
                                Visible="False"></asp:TextBox>
                            <cc1:MaskedEditExtender ID="txthasta_MaskedEditExtender" runat="server" 
                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                Mask="99/99/9999" MaskType="Date" TargetControlID="txthasta">
                            </cc1:MaskedEditExtender>
                            <cc1:CalendarExtender ID="txthasta_CalendarExtender" runat="server" 
                                Enabled="True" Format="dd/MM/yyyy" TargetControlID="txthasta">
                            </cc1:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style9">
                            </td>
                        <td class="style9">
                            <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" Height="31px" 
                                Text="Importar" Width="110px" Enabled="False" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
                            <asp:TextBox ID="txtnotraspag" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False"></asp:TextBox>
                            <asp:TextBox ID="txtnprogapepag" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Visible="False">PROGAPE</asp:Label>
                            <asp:TextBox ID="txtncompag" runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" 
                                BorderWidth="1px" Visible="False"></asp:TextBox>
                            <asp:Label ID="Label23" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Visible="False">ComxAdmon</asp:Label>
                            <asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Font-Strikeout="False" Visible="False">Otras Deudas</asp:Label>
            </TD>
		</TR>
		</TABLE>
</P>
