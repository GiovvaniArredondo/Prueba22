<%@ control language="vb" autoeventwireup="false" inherits="CUWSugInd, App_Web_yl8dokps" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 89%;
        height: 166px;
    }
    .style2
    {
        width: 78px;
    }
    .style4
    {
        width: 157px;
    }
    .style9
    {
        width: 156px;
    }
    .style10
    {
        width: 96%;
        height: 27px;
    }
    .style11
    {
        width: 78px;
        height: 28px;
    }
    .style12
    {
        width: 157px;
        height: 28px;
    }
    .style13
    {
        width: 156px;
        height: 28px;
    }
    .style14
    {
        height: 28px;
    }
</style>
<P>
	<TABLE id="Table8" style="OVERFLOW: visible; WIDTH: 684px; HEIGHT: 494px" borderColor="highlight"
		cellSpacing="0" cellPadding="0" bgColor="white" border="2">
		<TR>
			<TD style="HEIGHT: 8px">
				<TABLE id="Table10" style="WIDTH: 672px; HEIGHT: 22px" cellSpacing="0" cellPadding="0"
					width="672" border="0">
					<TR>
						<TD style="WIDTH: 112px"><asp:label id="Label1" runat="server" Width="67px" Font-Names="Verdana" Font-Size="8pt">Credito:</asp:label></TD>
						<TD style="WIDTH: 88px"><asp:dropdownlist id="cbxCodIns" runat="server" 
                                Font-Names="Verdana" Font-Size="8pt" Height="37px" Width="138px"></asp:dropdownlist></TD>
						<TD style="WIDTH: 168px"><asp:dropdownlist id="cbxcodofi" runat="server" Width="216px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
						<TD style="WIDTH: 145px"><asp:textbox id="txtcnrocta" runat="server" Width="112px" Font-Names="Century Gothic" Font-Size="8pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
						<TD><asp:textbox id="txtCredito" runat="server" Width="133px" Font-Size="8pt" 
                                BorderWidth="1px" Enabled="False"
								Visible="False" Height="18px"></asp:textbox></TD>
					</TR>
				</TABLE>
				<TABLE id="Table11" style="WIDTH: 688px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="688"
					border="0">
					<TR>
						<TD style="WIDTH: 69px"><asp:label id="Label2" runat="server" Width="64px" Font-Names="Verdana" Font-Size="8pt">Cliente:</asp:label></TD>
						<TD style="WIDTH: 233px"><asp:textbox id="txtcCodCli" runat="server" Width="224px" Font-Names="Century Gothic" Font-Size="8pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
						<TD><asp:textbox id="txtcNomcli" runat="server" Width="264px" Font-Names="Century Gothic" Font-Size="8pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				<TABLE id="Table13" style="WIDTH: 688px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="688"
					border="0">
					<TR>
						<TD style="WIDTH: 69px"><asp:label id="Label3" runat="server" Width="60px" Font-Names="Verdana" Font-Size="8pt">Analista:</asp:label></TD>
						<TD style="WIDTH: 230px"><asp:textbox id="txtNomAna" runat="server" Width="224px" Font-Names="Century Gothic" Font-Size="8pt"
								BorderWidth="1px" Enabled="False" Height="19px"></asp:textbox></TD>
						<TD style="WIDTH: 86px"><asp:label id="Label4" runat="server" Width="116px" Font-Names="Verdana" Font-Size="8pt" Height="3px">Monto Solicitado:</asp:label></TD>
						<TD style="WIDTH: 55px"><asp:textbox id="txtMonSol" runat="server" Width="74px" Font-Names="Century Gothic" Font-Size="8pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
						<TD>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                        </TD>
					</TR>
				</TABLE>
				<TABLE id="Table14" style="WIDTH: 688px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="688"
					border="0">
					<TR>
						<TD><asp:label id="Label7" runat="server" Width="688px" Font-Names="Verdana" Font-Size="9pt" BorderWidth="2px"
								Height="24px" BorderColor="#0000C0" BackColor="SteelBlue" ForeColor="AliceBlue">Fuente de Ingresos</asp:label></TD>
					</TR>
				</TABLE>
				<TABLE id="Table16" style="WIDTH: 688px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="688"
					border="0">
					<TR>
						<TD style="WIDTH: 234px"><asp:dropdownlist id="cbxfueing" runat="server" Width="232px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
						<TD><asp:textbox id="txtActCre" runat="server" Width="368px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				<TABLE id="Table17" style="WIDTH: 688px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="688"
					border="0">
					<TR>
						<TD><asp:label id="Label23" runat="server" Width="688px" Font-Names="Verdana" Font-Size="9pt" BorderWidth="2px"
								Height="24px" BorderColor="#0000C0" BackColor="SteelBlue" ForeColor="AliceBlue">Datos Sugeridos</asp:label></TD>
					</TR>
				</TABLE>
				<TABLE id="Table19" style="WIDTH: 688px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="688"
					border="0">
					<TR>
						<TD style="WIDTH: 122px" align="right">
							<asp:label id="Label6" Font-Size="8pt" Font-Names="Verdana" Width="120px" runat="server" BorderWidth="2px"
								BorderColor="#C04000" BorderStyle="Groove">Grupo:</asp:label></TD>
						<TD><SELECT id="cbxgrupos" style="FONT-SIZE: 12px; WIDTH: 424px; FONT-FAMILY: 'Century Gothic'"
								name="cbxanacre" runat="server">
								<OPTION selected></OPTION>
							</SELECT></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 122px"><asp:label id="Label8" runat="server" Width="120px" Font-Names="Verdana" Font-Size="8pt" BorderWidth="2px"
								BorderColor="#C04000" BorderStyle="Groove">Línea de Crédito:</asp:label></TD>
						<TD><asp:dropdownlist id="cbxLineas" runat="server" Width="424px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					</TR>
				</TABLE>
				<TABLE id="Table24" style="WIDTH: 688px; HEIGHT: 32px" cellSpacing="0" cellPadding="0"
					width="688" border="0">
					<TR>
						<TD style="WIDTH: 122px"><asp:label id="Label18" runat="server" Width="120px" Font-Names="Verdana" Font-Size="8pt" BorderWidth="2px"
								BorderColor="#C04000" BorderStyle="Groove">Tipo de Contrato:</asp:label></TD>
						<TD><asp:dropdownlist id="cbxContrato" runat="server" Width="424px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					</TR>
				</TABLE>
				<TABLE id="Table29" style="WIDTH: 625px; HEIGHT: 181px" cellSpacing="0" cellPadding="0"
					border="0" align="center">
					<TR>
						<TD><asp:label id="Label19" runat="server" Width="16px" Font-Names="Verdana" Font-Size="8pt" Visible="False">Gastos:</asp:label><asp:textbox id="TxtCapita" runat="server" Width="40px" Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:label id="Label17" runat="server" Width="40px" Font-Names="Verdana" Font-Size="8pt" Visible="False">Meses</asp:label><asp:textbox id="txtgastos" runat="server" Width="16px" Font-Names="Century Gothic" Font-Size="8pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtnmeses" runat="server" Width="23px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TxtRefina" runat="server" Width="21px" Font-Names="Verdana" Font-Size="8pt"
								Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TxtDesembolso" runat="server" Width="30px" Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TxtDescuento" runat="server" Width="29px" Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtdFecVen" runat="server" Width="29px" Visible="False" Height="16px"></asp:textbox><asp:textbox id="txtnliminf" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtnlimsup" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcplazo" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcodref1" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcodref2" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcodref3" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcodref4" runat="server" Width="32px" Visible="False"></asp:textbox>
                                        <asp:label id="Label16" runat="server" Width="88px" Font-Names="Verdana" 
                                            Font-Size="8pt" Visible="False">Gracia en días:</asp:label>
                                        <asp:textbox id="pnPerGra" runat="server" Width="72px" 
                                            Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Visible="False"></asp:textbox>
                                    </TD>
					</TR>
					<TR>
						<TD>
                            <table align="center" cellpadding="0" cellspacing="0" class="style1">
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label10" runat="server" Width="96px" Font-Names="Calibri" 
                                            Font-Size="10pt">Monto Sugerido:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtmonSug" runat="server" Width="80px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:rangevalidator id="RangeValidator1" runat="server" Width="149px" Font-Names="Verdana" Font-Size="8pt"
								ErrorMessage="RangeValidator" ControlToValidate="txtmonSug" MaximumValue="1000000" MinimumValue="50"
								Type="Double">Monto Sugerido Inválido-</asp:rangevalidator>
                                    </td>
                                    <td>
                                        &nbsp;&nbsp;&nbsp;
                                        <asp:label id="Label12" runat="server" Width="79px" Font-Names="Calibri" 
                                            Font-Size="10pt" BorderWidth="1px"
								BackColor="#003366" ForeColor="White" Font-Bold="True" Height="16px">Tipo de Cuota</asp:label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label11" runat="server" Width="75px" Font-Names="Calibri" 
                                            Font-Size="10pt">F.Desembolso:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtFecDes" runat="server" Width="80px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Height="22px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
								ControlToValidate="txtFecDes" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date">Fecha 
                                        de Des.Inválida-</asp:rangevalidator>
                                    </td>
                                    <td>
                                        <asp:radiobutton id="RadioButton1" runat="server" Width="104px" 
                                            Font-Names="Calibri" Font-Size="10pt"
								BorderWidth="2px" BorderColor="#000066" BackColor="White" GroupName="TipoPago" Text="FIJA NIVELADA" 
                                            Checked="True"></asp:radiobutton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label21" runat="server" Width="65px" Font-Names="Calibri" 
                                            Font-Size="10pt">F. 1ªCuota</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtfecpri" runat="server" Width="80px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Height="22px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:rangevalidator id="Rangevalidator6" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
								ControlToValidate="txtfecpri" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date">Fecha 
                                        de 1º Cuota Inválida-</asp:rangevalidator>
                                    </td>
                                    <td>
                                        <asp:radiobutton id="RadioButton5" runat="server" Width="104px" 
                                            Font-Names="Calibri" Font-Size="10pt"
								BorderWidth="2px" BorderColor="#000066" BackColor="White" GroupName="TipoPago" Text="FLAT"></asp:radiobutton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label20" runat="server" Width="80px" Font-Names="Calibri" 
                                            Font-Size="10pt">F.Vencimiento</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtvencimiento" runat="server" Width="80px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Enabled="False" Height="22px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:TextBox ID="txtgrupo" runat="server" Height="16px" Visible="False" 
                                            Width="31px"></asp:TextBox>
                                        <asp:TextBox ID="txtlinea" runat="server" Height="16px" Visible="False" 
                                            Width="31px"></asp:TextBox>
                                        <asp:TextBox ID="txtcuotas" runat="server" Height="16px" Visible="False" 
                                            Width="31px"></asp:TextBox>
                                        <asp:TextBox ID="txtfondo" runat="server" Height="16px" Visible="False" 
                                            Width="31px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:label id="Label26" runat="server" Width="96px" Font-Names="Calibri" 
                                            Font-Size="10pt" Font-Bold="True">FORMA DE PAGO</asp:label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style11">
                                        <asp:label id="Label14" runat="server" Width="48px" Font-Names="Calibri" 
                                            Font-Size="10pt">NºCuotas:</asp:label>
                                    </td>
                                    <td class="style12">
                                        <asp:textbox id="pnCuoSug" runat="server" Width="80px" 
                                            Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Height="20px"></asp:textbox>
                                    </td>
                                    <td class="style13" align="right">
                                        <asp:label id="Label24" runat="server" Width="96px" Font-Names="Calibri" 
                                            Font-Size="10pt">Capital:</asp:label>
                                    </td>
                                    <td class="style14">
                                        <asp:dropdownlist id="cbxCapital" runat="server" Width="150px" 
                                            Font-Names="Calibri" Font-Size="10pt" AutoPostBack="True" Height="16px"></asp:dropdownlist>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        &nbsp;</td>
                                    <td class="style4">
                                        <asp:rangevalidator id="RangeValidator2" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
								ControlToValidate="pnCuoSug" MaximumValue="240" MinimumValue="1" Type="Integer">Cuotas 
                                        Inválidas-</asp:rangevalidator>
                                    </td>
                                    <td class="style9" align="right">
                                        <asp:label id="Label25" runat="server" Width="79px" Font-Names="Calibri" 
                                            Font-Size="10pt" Height="16px">Interes:</asp:label>
                                    </td>
                                    <td>
                                        <asp:dropdownlist id="cbxInteres" runat="server" Width="150px" 
                                            Font-Names="Calibri" Font-Size="10pt" Height="16px"></asp:dropdownlist>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label9" runat="server" Width="48px" Font-Names="Verdana" Font-Size="8pt">Garantías:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtgarantias" runat="server" Width="80px" 
                                            Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Enabled="False" Height="21px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                </table>
                                    </TD>
					</TR>
					<TR>
						<TD><asp:radiobutton id="RadioButton6" runat="server" Width="104px" 
                                Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Periodo Fijo" 
                                Visible="False"></asp:radiobutton><asp:radiobutton id="RadioButton7" 
                                runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Fecha Fija" 
                                Checked="True" Visible="False"></asp:radiobutton><asp:label id="Label15" 
                                runat="server" Width="48px" Font-Names="Verdana" Font-Size="8pt" Height="16px" 
                                Visible="False">Plazo:</asp:label><asp:textbox id="pnDiaSug" runat="server" 
                                Width="72px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Visible="False"></asp:textbox><asp:rangevalidator id="RangeValidator3" runat="server" Width="93px" Font-Names="Verdana" Font-Size="8pt"
								ErrorMessage="RangeValidator" ControlToValidate="pnDiaSug" MaximumValue="730" MinimumValue="1" Type="Integer">Plazo 
                            Inválido-</asp:rangevalidator>
                                        <asp:radiobutton id="RadioButton2" runat="server" Width="87px" 
                                Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Cre" 
                                Height="20px" Visible="False"></asp:radiobutton>
                                        <asp:radiobutton id="RadioButton3" runat="server" Width="65px" 
                                Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Libre" 
                                Height="18px" Visible="False"></asp:radiobutton>
                                        <asp:radiobutton id="RadioButton4" runat="server" Width="73px" 
                                Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Decre" 
                                Height="16px" Visible="False"></asp:radiobutton>
                                    </TD>
					</TR>
					<TR>
						<TD>
                            <table cellpadding="0" cellspacing="0" class="style10">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label27" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                            Text="Causa de Rechazo:" Visible="False"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlcausa" runat="server" BackColor="#A8C5FF" 
                                            Font-Names="Verdana" Font-Size="8pt" ForeColor="#000066" Height="16px" 
                                            Visible="False" Width="373px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </TD>
					</TR>
					</TABLE>
				<P><asp:label id="Label22" runat="server" Width="690px" Font-Names="Verdana" 
                        Font-Size="9pt" BorderWidth="2px"
						Height="27px" BorderColor="#0000C0" BackColor="SteelBlue" ForeColor="AliceBlue">Refinanciamiento</asp:label>
					<TABLE id="Table31" style="WIDTH: 688px; HEIGHT: 2px" cellSpacing="0" cellPadding="0" width="688"
						border="0">
						<TR>
							<TD style="WIDTH: 687px" align="center"><asp:datagrid id="Datagrid1" runat="server" Width="617px" BorderWidth="1px" Height="48px" BorderColor="#006699"
									BackColor="White" BorderStyle="None" CellPadding="3" AutoGenerateColumns="False" AllowSorting="True">
									<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
									<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
									<ItemStyle ForeColor="#000066"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
									<Columns>
										<asp:BoundColumn DataField="idcuenta" SortExpression="idcuenta" HeaderText="cuenta">
											<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
												VerticalAlign="Top"></HeaderStyle>
											<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="nCapita" SortExpression="nCapita" HeaderText="Capital">
											<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
												VerticalAlign="Top"></HeaderStyle>
											<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="nIntere" SortExpression="nIntere" HeaderText="Interes">
											<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
											<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="nIntMor" SortExpression="nIntMor" HeaderText="Mora">
											<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
											<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="nsegdeu" SortExpression="nsegdeu" HeaderText="Seguro">
											<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
											<ItemStyle Font-Size="XX-Small" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="ncomision" SortExpression="ncomision" HeaderText="Comision">
											<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
											<ItemStyle Font-Size="XX-Small" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="Ntota" SortExpression="Ntota" HeaderText="Total">
											<HeaderStyle Font-Size="XX-Small" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
											<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
										</asp:BoundColumn>
									</Columns>
									<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
								</asp:datagrid></TD>
							<TD style="WIDTH: 687px" align="center"><INPUT id="btnQuitar" style="BACKGROUND-IMAGE: url(Web/gifs/btn_quitar.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button1" runat="server"></TD>
						</TR>
					</TABLE>
					<TABLE id="Table33" style="WIDTH: 661px; HEIGHT: 62px" cellSpacing="0" 
                        cellPadding="0" border="0" align="center">
						<TR>
							<TD style="WIDTH: 77px">
								<P><INPUT id="btnAplicar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
										type="button" runat="server"></P>
							</TD>
							<TD style="WIDTH: 73px">
								<P><INPUT id="btnGrabar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
										type="button" name="Button1" runat="server"></P>
							</TD>
							<TD style="WIDTH: 91px"><INPUT id="btnIA" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_IA.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button1" runat="server"></TD>
							<TD style="WIDTH: 26px"></TD>
							<TD style="WIDTH: 105px"><INPUT id="btnPlan" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_plan_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button1" runat="server"></TD>
							<TD style="WIDTH: 95px"><INPUT id="btnInicializar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button1" runat="server"></TD>
							<TD style="WIDTH: 102px"><INPUT id="btnResCom" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_sugerencia_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button1" runat="server"></TD>
							<TD style="WIDTH: 114px"><INPUT id="btnhistoria" style="BACKGROUND-IMAGE: url(Web/jpgs/signo2.bmp); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
									type="button" name="Button1" runat="server"></TD>
							<TD>
                                <asp:ImageButton ID="ImageButton1" runat="server" BorderColor="Black" 
                                    ImageUrl="~/web/jpgs/btn_rechazar_b.jpg" />
                                <cc1:ConfirmButtonExtender ID="ImageButton1_ConfirmButtonExtender" 
                                    runat="server" ConfirmText="Seguro de Rechazar?" Enabled="True" 
                                    TargetControlID="ImageButton1">
                                </cc1:ConfirmButtonExtender>
                            </TD>
						</TR>
					</TABLE>
				</P>
				<P>&nbsp;</P>
			</TD>
		</TR>
	</TABLE>
</P>
