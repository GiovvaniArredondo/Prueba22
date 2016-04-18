<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="CuwPlan, App_Web_v6ddqlgy" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<script language="javascript" type="text/javascript">
// <!CDATA[



// ]]>
</script>

<style type="text/css">
    .style1
    {
        width: 34%;
    }
    .style2
    {
        width: 228px;
    }
    .style3
    {
        width: 70%;
        height: 51px;
    }
    .style4
    {
        width: 71px;
    }
    .style5
    {
        height: 38px;
    }
    .style6
    {
        width: 65%;
    }
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 649px; HEIGHT: 259px"
	cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0">
	<TR>
		<TD style="HEIGHT: 18px" align="center"><asp:label id="Label9" Height="16px" 
                Font-Bold="True" ForeColor="#16387C" runat="server" Font-Names="Verdana"
				Width="341px" Font-Size="Medium">CALENDARIO DE PAGOS</asp:label></TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" 
                style="width: 96%">
				<TR>
					<TD align="center">
                <asp:GridView ID="datagrid1" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                            <ControlStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:CommandField>
                        <asp:BoundField DataField="dfecpro" HeaderText="Fecha" 
                            DataFormatString="{0:dd-MM-yyyy}">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ctipope" HeaderText="Tipo Op.">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cNroCuo" HeaderText="Nº Cuota">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nMcuota" HeaderText="Cuota" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ncapita" HeaderText="Capital" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nintere" HeaderText="Interes">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Gastos" HeaderText="Iva" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nsegdeu" HeaderText="Seguro Deuda" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nsalcap" HeaderText="Saldo" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
                    </TD>
				</TR>
				<TR>
					<TD align="center">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <table align="left" cellpadding="0" cellspacing="0" 
    class="style3">
                                    <tr>
                                        <td align="right" class="style4">
                                            <asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="NºCuota:" Visible="False"></asp:Label>
                                        </td>
                                        <td align="right" class="style4">
                                            <asp:TextBox ID="txtnrocuo" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" Height="24px" Width="45px" Enabled="False" Visible="False"></asp:TextBox>
                                        </td>
                                        <td align="right" class="style4">
                                            <asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Fecha:" Visible="False"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtfecha" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" Height="26px" Width="95px" Visible="False"></asp:TextBox>
                                            <cc1:MaskedEditExtender ID="txtfecha_MaskedEditExtender" runat="server" 
                                                AutoComplete="False" ClearMaskOnLostFocus="False" ClearTextOnInvalid="True" 
                                                ClipboardEnabled="False" CultureAMPMPlaceholder="" 
                                                CultureCurrencySymbolPlaceholder="" CultureDateFormat="" 
                                                CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecha">
                                            </cc1:MaskedEditExtender>
                                            <cc1:CalendarExtender ID="txtfecha_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtfecha">
                                            </cc1:CalendarExtender>
                                        </td>
                                        <td align="right">
                                            <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Monto:" Visible="False"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtmonto" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="12pt" Height="27px" Width="89px" Visible="False"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnaplicar" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Aplicar" Width="75px" Visible="False" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnadelante" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Adelante" Width="75px" Visible="False" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btneliminar" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Eliminar" Width="75px" Visible="False" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnnuevo" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Nuevo" Width="75px" Visible="False" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style4">
                                            &nbsp;</td>
                                        <td align="right" class="style4">
                                            &nbsp;</td>
                                        <td align="right" class="style4">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td align="right">
                                            &nbsp;</td>
                                        <td>
                                            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                                ControlToValidate="txtmonto" ErrorMessage="RangeValidator" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="17px" MaximumValue="1000000" 
                                                MinimumValue="50" Type="Double" Width="97px">Monto Inválido</asp:RangeValidator>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </TD>
				</TR>
				<TR>
					<TD align="center" class="style5">
                        &nbsp;</TD>
				</TR>
				<TR>
					<TD align="center"><asp:textbox id="txtcCodCta" runat="server" Font-Names="Verdana" Width="357px" Visible="False"></asp:textbox></TD>
				</TR>
			</TABLE>
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td align="center" class="style2">
			<INPUT id="btnImprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 51px; BACKGROUND-COLOR: transparent"
				type="button" runat="server" visible="False"></td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
            <table cellpadding="0" cellspacing="0" class="style6">
                <tr>
                    <td>
                        <asp:HiddenField ID="HiddenField1" runat="server" />
                    </td>
                    <td>
                        <asp:HiddenField ID="HiddenField2" runat="server" />
                    </td>
                    <td>
                        <asp:HiddenField ID="HiddenField3" runat="server" />
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
</TABLE>
