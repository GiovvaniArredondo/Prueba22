<%@ control language="vb" autoeventwireup="false" inherits="ucctaaho, App_Web_yl8dokps" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<style type="text/css">
    .style1
    {
        width: 96%;
    }
    .style2
    {
        width: 89px;
    }
    .style3
    {
        width: 333px;
    }
    .style4
    {
        width: 89px;
        height: 33px;
    }
    .style5
    {
        width: 333px;
        height: 33px;
    }
    .style6
    {
        height: 33px;
    }
    .style7
    {
        width: 118px;
        height: 20px;
    }
    .style8
    {
        height: 20px;
    }
    .style9
    {
        width: 118px;
        height: 27px;
    }
    .style10
    {
        height: 27px;
    }
    .style11
    {
        height: 14px;
    }
    .style12
    {
        width: 78%;
    }
    .style13
    {
        width: 100%;
    }
</style>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0" 
    style="border: thin solid highlight; WIDTH: 524px; HEIGHT: 333px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD align="center">
			<asp:label id="Label1" runat="server" Width="336px" Font-Bold="True" Font-Names="Verdana" Font-Size="Medium"
				ForeColor="#16387C" Height="15px">APERTURA CUENTA DE AHORRO</asp:label>
        </TD>
	</TR>
	<TR>
		<TD align="center">
                    <asp:Image ID="foto_Image" runat="server" Visible="False" BorderWidth="1px" />
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style11">
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                <tr>
                    <td align="right" class="style4">
                        &nbsp;</td>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        <asp:label id="Label3" Width="56px" runat="server" Font-Size="8pt" Font-Names="Verdana">Agencia:</asp:label>
                    </td>
                    <td class="style5">
                        <asp:dropdownlist id="ddloficina" Width="248px" runat="server" Font-Size="8pt" 
                            Font-Names="Verdana" Height="16px"></asp:dropdownlist>
                    </td>
                    <td class="style6">
                        <asp:Button ID="btnaplicar" runat="server" Font-Names="Calibri" 
                            Text="Aplicar" />
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;</td>
                    <td class="style3">
						<asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Names="Verdana" 
                            Font-Size="10pt" ForeColor="Maroon"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="443" border="0" 
                style="WIDTH: 443px; HEIGHT: 163px" class="CSSTableGenerator">
				<TR>
					<TD align="right" class="style7">
                        &nbsp;</TD>
					<TD class="style8">
						&nbsp;</TD>
				</TR>
				<TR>
					<TD align="right" class="style7">
                        <asp:label id="Label15" Width="114px" 
                            runat="server" Font-Size="8pt" Font-Names="Verdana">Nº de Cuenta:</asp:label></TD>
					<TD class="style8">
						<asp:textbox id="txtcodaho" runat="server" Font-Size="8pt" Font-Names="Verdana" Height="20px"
							Enabled="False" Width="226px"></asp:textbox>
                    </TD>
				</TR>
				<TR>
					<TD align="right" class="style7"><asp:label id="Label4" Width="114px" 
                            runat="server" Font-Size="8pt" Font-Names="Verdana">Codigo Cliente:</asp:label></TD>
					<TD class="style8"><asp:textbox id="txtcodcli" Width="112px" runat="server" Font-Size="8pt" Font-Names="Verdana"
							Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD align="right" class="style9"><asp:label id="Label13" Width="56px" 
                            runat="server" Font-Size="8pt" Font-Names="Verdana">Nombre:</asp:label></TD>
					<TD class="style10"><asp:textbox id="txtnomcli" Width="312px" runat="server" 
                            Font-Size="8pt" Font-Names="Verdana"
							Enabled="False" Height="21px"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px" align="right"><asp:label id="Label5" Width="40px" runat="server" Font-Size="8pt" Font-Names="Verdana">Fecha:</asp:label></TD>
					<TD><asp:textbox id="txtfecha" Width="80px" runat="server" Font-Size="8pt" Font-Names="Verdana"></asp:textbox><asp:label id="Label12" Width="64px" runat="server" ForeColor="Red" BorderColor="Red" Font-Names="Verdana"
							Font-Size="8pt">dd/mm/aa</asp:label>
						<asp:RangeValidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" Width="88px" runat="server"
							MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecha">Fecha Inválida-</asp:RangeValidator></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px" align="right"><asp:label id="Label14" Width="75px" 
                            runat="server" Font-Size="8pt" Font-Names="Verdana">Nº Libreta:</asp:label></TD>
					<TD>
                        <asp:TextBox ID="txtlibreta" runat="server" Font-Bold="True" 
                            Font-Names="Verdana" Font-Size="8pt" Height="18px" Width="86px"></asp:TextBox>
                                        <asp:rangevalidator id="RangeValidator6" runat="server" 
                            Width="117px" Font-Names="Verdana" Font-Size="8pt"
								ErrorMessage="RangeValidator" ControlToValidate="txtlibreta" MaximumValue="999999" MinimumValue="1"
								Type="Integer" Height="16px">Número Inválido</asp:rangevalidator>
                    </TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 30px" align="right"><asp:label id="Label6" Width="113px" runat="server" Font-Size="8pt" Font-Names="Verdana">Tipo cuenta ahorro:</asp:label></TD>
					<TD style="HEIGHT: 30px"><asp:dropdownlist id="ddltipaho" Width="307px" 
                            runat="server" Font-Size="8pt" Font-Names="Verdana" Height="20px"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 14px" align="right"><asp:label id="Label7" Width="96px" runat="server" Font-Size="8pt" Font-Names="Verdana">Línea de ahorro:</asp:label></TD>
					<TD style="HEIGHT: 14px"><asp:dropdownlist id="ddllineas" Width="308px" 
                            runat="server" Font-Size="8pt" Font-Names="Verdana" Height="16px"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px"></TD>
					<TD><asp:label id="Label8" Width="144px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:label></TD>
				</TR>
			</TABLE>
        </TD>
	</TR>
	<TR>
		<TD align="center">
            <table cellpadding="0" cellspacing="0" class="style12">
                <tr>
                    <td align="center">
                        &nbsp;</td>
                    <td align="center">
            <asp:Button ID="btnfirmas" runat="server" Font-Names="Calibri" Height="28px" 
                Text="Firmas" Width="86px" Visible="False" />
            <cc1:ConfirmButtonExtender ID="btnfirmas_ConfirmButtonExtender" runat="server" 
                ConfirmText="Esta Seguro?" Enabled="True" TargetControlID="btnfirmas">
            </cc1:ConfirmButtonExtender>
                    </td>
                    <td align="center">
            <asp:Button ID="btncontrato" runat="server" Font-Names="Calibri" Height="28px" 
                Text="Contrato" Width="86px" Visible="False" />
            <cc1:ConfirmButtonExtender ID="btncontrato_ConfirmButtonExtender" runat="server" 
                ConfirmText="Esta Seguro?" Enabled="True" TargetControlID="btncontrato">
            </cc1:ConfirmButtonExtender>
                    </td>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" class="style13">
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadioButton11" runat="server" Checked="True" 
                                        Font-Names="Verdana" Font-Size="8pt" GroupName="impresion3" 
                                        Text="Adverso" Visible="False" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButton ID="RadioButton12" runat="server" Font-Names="Verdana" 
                                        Font-Size="8pt" GroupName="impresion3" Text="Inverso" Visible="False" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
            <asp:Button ID="btngraba" runat="server" Font-Names="Calibri" Height="28px" 
                Text="Grabar" Width="86px" />
            <cc1:ConfirmButtonExtender ID="btngraba_ConfirmButtonExtender" runat="server" 
                ConfirmText="Esta Seguro?" Enabled="True" TargetControlID="btngraba">
            </cc1:ConfirmButtonExtender>
                    </TD>
	</TR>
	<TR>
		<TD align="center">&nbsp;</TD>
	</TR>
</TABLE>
