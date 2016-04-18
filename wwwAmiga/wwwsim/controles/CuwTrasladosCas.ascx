<%@ Control Language="vb" AutoEventWireup="false" Inherits="CuwTrasladosCas" CodeFile="CuwTrasladosCas.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<style type="text/css">
    .style1
    {
        height: 28px;
    }
    .style4
    {
        width: 91%;
        height: 110px;
    }
    .style5
    {
        height: 44px;
    }
    .style6
    {
        width: 239px;
    }
</style>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<TABLE id="Table8" style="border: thin solid highlight; WIDTH: 797px; HEIGHT: 349px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD align="center" class="style1">
			<asp:label id="Label1" Font-Bold="True" ForeColor="#0000C0" Font-Names="Gill Sans MT" runat="server"
					Width="312px" Font-Size="Medium">Traslados Masivos de Cartera</asp:label>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
			<asp:label id="lblmensaje" ForeColor="#C00000" Font-Names="Gill Sans MT" runat="server" Width="466px"
					Font-Size="10pt"></asp:label>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
			<table cellpadding="0" cellspacing="0" class="style4">
                <tr>
                    <td align="right">
                        <asp:label id="Label2" Font-Names="Gill Sans MT" runat="server" Width="110px" Font-Size="10pt">Trasladar A :</asp:label>
                    </td>
                    <td class="style6">
                            <asp:DropDownList ID="cbxtraslado" runat="server" AutoPostBack="True" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="34px" Width="230px">
                            </asp:DropDownList>
                        </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:label id="Label4" Font-Names="Gill Sans MT" runat="server" Width="110px" Font-Size="10pt">Fecha de Traslado:</asp:label>
                    </td>
                    <td class="style6">
                        <asp:textbox id="TXTFECPRO" Font-Bold="True" Font-Names="Gill Sans MT" runat="server" Width="116px"
								Font-Size="10pt" BorderWidth="1px" Enabled="False"></asp:textbox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right">
                                    <asp:label id="Label38" runat="server" Width="166px" Font-Size="10pt" 
                                        Height="15px" Font-Names="Gill Sans MT">Nombre de Archivo:</asp:label>
                                </td>
                    <td class="style6">
                                    <asp:textbox id="txtnombar" tabIndex="5" runat="server" Width="209px" 
                                        Font-Size="12pt" Font-Names="Gill Sans MT"
							BorderWidth="1px" Height="25px"></asp:textbox>
                                </td>
                    <td>
                                    <asp:ImageButton ID="ImageButton1" runat="server" 
                                        ImageUrl="~/web/jpgs/Descargar.jpg" style="" Height="51px" 
                            Width="69px" />
                                    </td>
                </tr>
                <tr>
                    <td align="right">
                                    &nbsp;</td>
                    <td class="style6">
                                    <asp:label id="Label39" runat="server" Width="267px" 
                            Font-Size="10pt" Height="15px" Font-Names="Gill Sans MT">La ruta del servidor es c:/txt/nombrearch.txt</asp:label>
                                </td>
                    <td>
                                    &nbsp;</td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style5">
			<asp:button id="btnaplicar" Font-Names="Gill Sans MT" runat="server" Width="117px" Text="Trasladar"></asp:button>
            <cc1:ConfirmButtonExtender ID="btnaplicar_ConfirmButtonExtender" runat="server" 
                ConfirmText="Esta Seguro del traslado" Enabled="True" 
                TargetControlID="btnaplicar">
            </cc1:ConfirmButtonExtender>
            <asp:HiddenField ID="HiddenField1" runat="server" />
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
			<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" Font-Names="Gill Sans MT">
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <Columns>
                    <asp:BoundField DataField="ccodcta" HeaderText="NºCrédito">
                        <HeaderStyle ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ccodcli" HeaderText="NºCliente">
                        <HeaderStyle ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="cnomcli" HeaderText="Nombre">
                        <HeaderStyle ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="coficina" HeaderText="Oficina">
                        <HeaderStyle ForeColor="White" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ccondic" HeaderText="Condición Actual">
                        <HeaderStyle ForeColor="White" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="nsalcap" DataFormatString="{0:Q###,##0.00}" 
                        HeaderText="Saldo Capital">
                        <ControlStyle ForeColor="White" />
                        <HeaderStyle ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="nsalint" DataFormatString="{0:Q###,##0.00}" 
                        HeaderText="Saldo Int.">
                        <HeaderStyle ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="nsalmor" DataFormatString="{0:Q###,##0.00}" 
                        HeaderText="Saldo Int.Mor.">
                        <HeaderStyle ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ndiaatr" HeaderText="Dias Atraso">
                        <HeaderStyle ForeColor="White" />
                    </asp:BoundField>
                    <asp:BoundField DataField="nmorcap" DataFormatString="{0:Q###,##0.00}" 
                        HeaderText="Mora Capital">
                        <HeaderStyle ForeColor="White" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Excluir">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                        <HeaderStyle ForeColor="White" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <AlternatingRowStyle BackColor="#F7F7F7" />
            </asp:GridView>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
			<asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                        <tr>
                            <td align="right">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="Label17" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="10pt" Width="110px">Juzgado:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtjuzgado" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="10pt" Width="279px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:label id="Label18" Font-Names="Gill Sans MT" runat="server" Width="110px" 
                            Font-Size="10pt">Nº de Juicio:</asp:label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtjuicio" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Width="279px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:label id="Label19" Font-Names="Gill Sans MT" runat="server" Width="110px" 
                            Font-Size="10pt">Abogado/Bufete:</asp:label>
                            </td>
                            <td>
                                <asp:DropDownList ID="cmbAbogado" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="37px" Width="276px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:label id="Label20" Font-Names="Gill Sans MT" runat="server" Width="145px" 
                            Font-Size="10pt">Fecha de la Demanda:</asp:label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtfechademanda" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="27px" Width="127px"></asp:TextBox>
                                <cc1:MaskedEditExtender ID="txtfechademanda_MaskedEditExtender" runat="server" CultureAMPMPlaceholder="" 
                            CultureCurrencySymbolPlaceholder="" CultureDateFormat="" 
                            CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtfechademanda">
                                </cc1:MaskedEditExtender>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:label id="Label21" Font-Names="Gill Sans MT" runat="server" Width="110px" 
                            Font-Size="10pt">Situación Actual:</asp:label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtsituacion" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Width="279px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:label id="Label22" Font-Names="Gill Sans MT" runat="server" Width="110px" 
                            Font-Size="10pt">Valor demandado:</asp:label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtvalord" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="25px" Width="130px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:label id="Label23" Font-Names="Gill Sans MT" runat="server" Width="130px" 
                            Font-Size="10pt">Fecha de Descuento:</asp:label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtfechaDes" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="26px" Width="130px"></asp:TextBox>
                                <cc1:MaskedEditExtender ID="txtfechaDes_MaskedEditExtender" runat="server" CultureAMPMPlaceholder="" 
                            CultureCurrencySymbolPlaceholder="" CultureDateFormat="" 
                            CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtfechaDes">
                                </cc1:MaskedEditExtender>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:label id="Label24" Font-Names="Gill Sans MT" runat="server" Width="176px" 
                            Font-Size="10pt">Valor descontado mensual:</asp:label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtvalormen" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="24px" Width="129px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
				<asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <TABLE id="Table1" style="WIDTH: 488px; HEIGHT: 218px" 
    cellSpacing="0" cellPadding="0"
					width="488" border="0">
                            <TR>
                                <TD style="WIDTH: 281px" align="right">
                                    &nbsp;</TD>
                                <TD>
                                    &nbsp;</TD>
                            </TR>
                            <TR>
                                <TD style="WIDTH: 281px; HEIGHT: 27px" align="right">
                                    &nbsp;</TD>
                                <TD style="HEIGHT: 27px">
                                    &nbsp;</TD>
                            </TR>
                            <TR>
                                <TD style="WIDTH: 281px" align="right">
                                    <TABLE id="Table2" style="WIDTH: 271px; HEIGHT: 114px" borderColor="blue" cellSpacing="0"
								cellPadding="0" width="271" bgColor="#99deff" border="1">
                                        <TR>
                                            <TD style="WIDTH: 51px" align="right">
                                                <asp:label id="Label3" 
                                            Font-Names="Gill Sans MT" runat="server" Width="41px" Font-Size="10pt">Crédito:</asp:label>
                                            </TD>
                                            <TD>
                                                <asp:textbox id="txtccodcta" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="192px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </TD>
                                        </TR>
                                        <TR>
                                            <TD style="WIDTH: 51px" align="right">
                                                <asp:label id="Label6" 
                                            Font-Names="Gill Sans MT" runat="server" Width="40px" Font-Size="10pt">Cod. Cliente:</asp:label>
                                            </TD>
                                            <TD>
                                                <asp:textbox id="txtccodcli" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="192px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </TD>
                                        </TR>
                                        <TR>
                                            <TD style="WIDTH: 51px; HEIGHT: 46px" align="right">
                                                <asp:label id="Label7" Font-Names="Gill Sans MT" runat="server" Width="48px" 
                                            Font-Size="10pt">Nombre:</asp:label>
                                            </TD>
                                            <TD style="HEIGHT: 46px">
                                                <asp:textbox id="txtcnomcli" 
                                            Font-Bold="True" Font-Names="Gill Sans MT" runat="server" Width="192px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False" Height="38px" Rows="2" TextMode="MultiLine"></asp:textbox>
                                            </TD>
                                        </TR>
                                        <TR>
                                            <TD style="WIDTH: 51px" align="right">
                                                <asp:label id="Label8" 
                                            Font-Names="Gill Sans MT" runat="server" Width="46px" Font-Size="10pt">Analista:</asp:label>
                                            </TD>
                                            <TD>
                                                <asp:textbox id="txtcnomana" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="192px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False" Height="33px" Rows="2" TextMode="MultiLine"></asp:textbox>
                                            </TD>
                                        </TR>
                                        <TR>
                                            <TD style="WIDTH: 51px" align="right">
                                                <asp:label id="Label9" 
                                            Font-Names="Gill Sans MT" runat="server" Width="51px" Font-Size="10pt">Condición:</asp:label>
                                            </TD>
                                            <TD>
                                                <asp:textbox id="txtccondic" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="192px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </TD>
                                        </TR>
                                    </TABLE>
                                </TD>
                                <TD>
                                    <TABLE id="Table3" style="WIDTH: 202px; HEIGHT: 162px" borderColor="#ffcc00" cellSpacing="0"
								cellPadding="0" width="202" bgColor="lemonchiffon" border="1">
                                        <TR>
                                            <TD style="WIDTH: 131px; HEIGHT: 14px" align="center">
                                                <asp:label id="Label10" 
                                            Font-Bold="True" Font-Names="Gill Sans MT" runat="server" Width="56px" 
                                            Font-Size="10pt">SALDOS</asp:label>
                                            </TD>
                                            <TD style="HEIGHT: 14px" align="center">
                                                <asp:label id="Label11" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="83px" Font-Size="10pt">Quetzales</asp:label>
                                            </TD>
                                        </TR>
                                        <TR>
                                            <TD style="WIDTH: 131px" align="right">
                                                <asp:label id="Label5" Font-Names="Gill Sans MT" runat="server" Width="48px" 
                                            Font-Size="10pt">Capital:</asp:label>
                                            </TD>
                                            <TD>
                                                <asp:textbox id="txtnsalcap" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="96px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </TD>
                                        </TR>
                                        <TR>
                                            <TD style="WIDTH: 131px" align="right">
                                                <asp:label id="Label12" Font-Names="Gill Sans MT" runat="server" Width="48px" 
                                            Font-Size="10pt">Interés:</asp:label>
                                            </TD>
                                            <TD>
                                                <asp:textbox id="txtnsalint" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="96px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </TD>
                                        </TR>
                                        <TR>
                                            <TD style="WIDTH: 131px" align="right">
                                                <asp:label id="Label13" Font-Names="Gill Sans MT" runat="server" Width="40px" 
                                            Font-Size="10pt">Mora:</asp:label>
                                            </TD>
                                            <TD>
                                                <asp:textbox id="txtnsalmor" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="96px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </TD>
                                        </TR>
                                        <TR>
                                            <TD style="WIDTH: 131px" align="right">
                                                <asp:label id="Label15" Font-Names="Gill Sans MT" runat="server" Width="96px" 
                                            Font-Size="10pt">Dias de Atraso:</asp:label>
                                            </TD>
                                            <TD>
                                                <asp:textbox id="txtndiaatr" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="96px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </TD>
                                        </TR>
                                        <TR>
                                            <TD style="WIDTH: 131px" align="right">
                                                <asp:label id="Label16" Font-Names="Gill Sans MT" runat="server" Width="88px" 
                                            Font-Size="10pt">Saldo Deudor:</asp:label>
                                            </TD>
                                            <TD>
                                                <asp:textbox id="txtntotal" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" runat="server" Width="96px"
											Font-Size="10pt" BorderWidth="1px" Enabled="False"></asp:textbox>
                                            </TD>
                                        </TR>
                                    </TABLE>
                                </TD>
                            </TR>
                        </TABLE>
                    </ContentTemplate>
                </asp:UpdatePanel>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
			&nbsp;</TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
							<asp:textbox id="txtcondicion" Font-Bold="True" Font-Names="Gill Sans MT" runat="server" Width="40px"
								Font-Size="10pt" BorderWidth="1px" Enabled="False" Visible="False" Height="7px"></asp:textbox><asp:textbox id="txtcestado" Font-Bold="True" Font-Names="Gill Sans MT" runat="server" Width="40px"
								Font-Size="10pt" BorderWidth="1px" Enabled="False" Visible="False" Height="7px"></asp:textbox>
							<asp:textbox id="txtccodlin" Font-Size="10pt" Width="40px" runat="server" Font-Names="Gill Sans MT"
								Font-Bold="True" Enabled="False" BorderWidth="1px" Height="7px" Visible="False"></asp:textbox>
                            <asp:HiddenField ID="HiddenField2" runat="server" />
        </TD>
	</TR>
</TABLE>
