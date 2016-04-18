<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="CUWCongelar, App_Web_v6ddqlgy" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 67px;
        height: 31px;
    }
    .style2
    {
        width: 57px;
        height: 31px;
    }
    .style3
    {
        height: 41px;
    }
    .style4
    {
        width: 80%;
        height: 49px;
    }
    .style5
    {
        width: 167px;
    }
    .style6
    {
        width: 167px;
        height: 27px;
    }
    .style7
    {
        height: 27px;
    }
    .style8
    {
        width: 167px;
        height: 29px;
    }
    .style9
    {
        height: 29px;
    }
    .style10
    {
        height: 40px;
    }
    .style11
    {
        width: 65%;
    }
    .style12
    {
        width: 198px;
    }
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 494px; HEIGHT: 330px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="494" border="0">
	<TR>
		<TD align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">SUSPENDER INTERESES</P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 77px" align="center">
			<TABLE id="Table2" style="WIDTH: 469px; HEIGHT: 25px" cellSpacing="0" cellPadding="0" width="469"
				border="0">
				<TR>
					<TD style="WIDTH: 52px" align="right"><asp:label id="Label4" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Crédito:</asp:label></TD>
					<TD style="WIDTH: 102px"><asp:dropdownlist id="ddlcodins" runat="server" Width="103px" Height="16px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 136px"><asp:dropdownlist id="ddlcodofi" runat="server" 
                            Width="169px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"></asp:dropdownlist></TD>
					<TD style="WIDTH: 109px"><asp:textbox id="txtcnrocta" tabIndex="5" runat="server" Width="152px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False"></asp:textbox></TD>
					<TD align="center"></TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" style="WIDTH: 438px; HEIGHT: 56px" cellSpacing="0" cellPadding="0" width="438"
				border="0">
				<TR>
					<TD style="WIDTH: 139px" align="right"><asp:label id="Label9" runat="server" Width="67px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Nombre:  </asp:label></TD>
					<TD style="WIDTH: 243px"><asp:textbox id="txtnomcli" runat="server" Width="232px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False"></asp:textbox></TD>
					<TD>
						<P align="center"><INPUT id="btnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
								type="button" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table4" style="WIDTH: 440px; HEIGHT: 107px" cellSpacing="0" cellPadding="0"
				width="440" align="center" border="0">
				<TR>
					<TD style="HEIGHT: 127px" align="center">
						<TABLE id="Table6" style="WIDTH: 439px; HEIGHT: 120px" cellSpacing="0" cellPadding="0"
							width="439" align="center" border="0">
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 8px"><asp:label id="Label12" runat="server" Font-Names="Verdana" Font-Size="8pt">Cuota:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 8px">&nbsp;</TD>
								<TD style="WIDTH: 197px; HEIGHT: 8px"><asp:label id="Label13" runat="server" Width="96px" Font-Names="Verdana" Font-Size="8pt">Deuda Capital:</asp:label></TD>
								<TD style="HEIGHT: 8px"><asp:textbox id="txtdeucap" runat="server" Width="102px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 8px"><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt">Saldo Capital:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 8px"><asp:textbox id="txtcapita" runat="server" Width="102px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 8px"><asp:label id="Label5" runat="server" Font-Names="Verdana" Font-Size="8pt">Interés:</asp:label></TD>
								<TD style="HEIGHT: 8px"><asp:textbox id="txtinteres" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 6px"><asp:label id="Label6" runat="server" Font-Names="Verdana" Font-Size="8pt">Mora:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 6px"><asp:textbox id="txtmora" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 6px"><asp:label id="Label7" runat="server" Font-Names="Verdana" Font-Size="8pt">Comisiones:</asp:label></TD>
								<TD style="HEIGHT: 6px"><asp:textbox id="txtcomisiones" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 4px"><asp:label id="Label10" runat="server" Font-Names="Verdana" Font-Size="8pt">Ultimo Pago:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 4px"><asp:textbox id="txtdultpag" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 4px"><asp:label id="Label11" runat="server" Font-Names="Verdana" Font-Size="8pt">Seguro de Deuda:</asp:label></TD>
								<TD style="HEIGHT: 4px"><asp:textbox id="txtnseguro" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 1px"><asp:label id="Label8" runat="server" Width="96px" Font-Names="Verdana" Font-Size="8pt" Font-Bold="True">Total a pagar:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 1px"><asp:textbox id="txttotal" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 1px"><asp:label id="Label1" runat="server" Font-Names="Verdana" Font-Size="8pt">Dias Atraso:</asp:label></TD>
								<TD style="HEIGHT: 1px"><asp:textbox id="txtdias" runat="server" Width="72px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 1px">&nbsp;</TD>
								<TD style="WIDTH: 117px; HEIGHT: 1px">&nbsp;</TD>
								<TD style="WIDTH: 197px; HEIGHT: 1px">&nbsp;</TD>
								<TD style="HEIGHT: 1px">&nbsp;</TD>
							</TR>
							</TABLE>
						<asp:textbox id="txtccodcli" runat="server" Width="75px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txt30" runat="server" Width="73px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
							Visible="False"></asp:textbox><asp:textbox id="txt60" runat="server" Width="64px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
							Visible="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD align="center" class="style10">
						<table cellpadding="0" cellspacing="0" class="style11">
                            <tr>
                                <td align="center" class="style12">
                                    <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" 
                                        Font-Names="Calibri" GroupName="opcion" Text="Parcial" />
                                </td>
                                <td align="center">
                                    <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Calibri" 
                                        GroupName="opcion" Text="Total" />
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD align="center">
						<table cellpadding="0" cellspacing="0" class="style4">
                            <tr>
                                <td align="right" class="style6">
                                    <asp:label id="Label18" runat="server" Font-Names="Verdana" Font-Size="8pt">Periodo de Tiempo (días):</asp:label>
                                </td>
                                <td class="style7">
                                    <asp:textbox id="txtperiodo" runat="server" Width="44px" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="20px" AutoPostBack="True"></asp:textbox>
                                </td>
                                <td class="style7">
                                        <asp:rangevalidator id="RangeValidator6" runat="server" 
                                        Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
								ControlToValidate="txtperiodo" MaximumValue="180" MinimumValue="30" Type="Integer">Días Inválidos</asp:rangevalidator>
                                    </td>
                            </tr>
                            <tr>
                                <td align="right" class="style8">
                                    <asp:label id="Label19" runat="server" Font-Names="Verdana" Font-Size="8pt">A partir de:</asp:label>
                                </td>
                                <td class="style9">
                                        <asp:textbox id="txtFecha" runat="server" Width="80px" 
                                        Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Height="22px" AutoPostBack="True"></asp:textbox>
                                    </td>
                                <td class="style9">
                                        <asp:rangevalidator id="RangeValidator5" runat="server" 
                                        Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
								ControlToValidate="txtFecha" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date">Fecha Inválida</asp:rangevalidator>
                                    </td>
                            </tr>
                            <tr>
                                <td align="right" class="style5">
                                    <asp:label id="Label20" runat="server" Font-Names="Verdana" Font-Size="8pt">Hasta el dia:</asp:label>
                                </td>
                                <td>
                                        <asp:textbox id="txtFecha0" runat="server" Width="80px" 
                                        Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Height="22px" Enabled="False"></asp:textbox>
                                    </td>
                                <td>
                                        &nbsp;</td>
                            </tr>
                        </table>
						</TD>
				</TR>
				<TR>
					<TD align="center" class="style3">
						<TABLE id="Table7" borderColor="#ff9900" cellSpacing="0" cellPadding="0" bgColor="#CCFF33"
							border="2" style="width: 50%">
							<TR>
								<TD class="style1"><asp:label id="Label17" runat="server" Width="131px" 
                                        Font-Names="Verdana" Font-Size="8pt" Font-Bold="True" Height="18px">Intereses al día:</asp:label></TD>
								<TD class="style2" align="left"><asp:textbox id="txtaldia" runat="server" 
                                        Width="102px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" style="margin-left: 6px; margin-right: 0px"></asp:textbox></TD>
							</TR>
						</TABLE>
                    </TD>
				</TR>
				<TR>
					<TD align="center" class="style3">
                        <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Suspender" />
                        <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
                            ConfirmText="Seguro de Suspender?" Enabled="True" TargetControlID="Button1">
                        </cc1:ConfirmButtonExtender>
                    </TD>
				</TR>
				<TR>
					<TD align="center"><asp:textbox id="txtmon60" runat="server" Width="36px" 
                            Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Height="16px" Visible="False"></asp:textbox>&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:textbox id="txtmon30" runat="server" Width="43px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Height="16px" Visible="False"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
