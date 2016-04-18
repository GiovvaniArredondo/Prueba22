<%@ control language="vb" autoeventwireup="false" inherits="wucAjuPlan, App_Web_pi2jwlis" %>
<style type="text/css">

    .style1
    {
        width: 157%;
        height: 198px;
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
        width: 85px;
    }
    .style5
    {
        width: 78px;
        height: 27px;
    }
    .style6
    {
        width: 157px;
        height: 27px;
    }
    .style10
    {
        width: 85px;
        height: 27px;
    }
    .style8
    {
        height: 27px;
    }
    .style11
    {
        width: 99px;
        height: 38px;
    }
    .style12
    {
        height: 38px;
    }
    .style13
    {
        width: 118px;
    }
    .style14
    {
        height: 27px;
        width: 118px;
    }
    .style15
    {
        width: 81px;
    }
    .style16
    {
        height: 27px;
        width: 81px;
    }
    .style17
    {
        width: 78px;
        height: 25px;
    }
    .style18
    {
        width: 157px;
        height: 25px;
    }
    .style19
    {
        width: 85px;
        height: 25px;
    }
    .style20
    {
        height: 25px;
    }
    .style21
    {
        width: 118px;
        height: 25px;
    }
    .style22
    {
        width: 81px;
        height: 25px;
    }
    .style23
    {
        width: 182%;
    }
    .style24
    {
        width: 509px;
    }
    .style25
    {
        width: 481px;
    }
    .style26
    {
        width: 78px;
        height: 18px;
    }
    .style27
    {
        width: 157px;
        height: 18px;
    }
    .style28
    {
        width: 85px;
        height: 18px;
    }
    .style29
    {
        height: 18px;
    }
    .style30
    {
        width: 118px;
        height: 18px;
    }
    .style31
    {
        width: 81px;
        height: 18px;
    }
    .style32
    {
        width: 156px;
    }
    </style>
&nbsp;
<TABLE id="Table15" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 520px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 703px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="520" align="left" border="0">
	<TR>
		<TD style="HEIGHT: 29px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">AJUSTE ADMINISTRATIVO DE PLAN DE PAGOS</P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 547px">
			<TABLE id="Table16" style="WIDTH: 693px; HEIGHT: 521px" cellSpacing="0" 
                cellPadding="0" align="center" border="0">
				<TR>
					<TD style="WIDTH: 419px" align="center">
						<TABLE id="Table17" style="WIDTH: 683px; HEIGHT: 297px" cellSpacing="0" 
                            cellPadding="0" border="0">
							<TR>
								<TD style="WIDTH: 438px; HEIGHT: 72px">
									<TABLE id="Table19" style="WIDTH: 432px; HEIGHT: 19px" cellSpacing="0" cellPadding="0"
										width="432" border="0">
										<TR>
											<TD style="WIDTH: 64px"><asp:label id="Label1" Height="12px" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="48px">Credito:</asp:label></TD>
											<TD style="WIDTH: 110px" align="left"><asp:dropdownlist id="cbxCodIns" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="136px"></asp:dropdownlist></TD>
											<TD style="WIDTH: 68px"><asp:dropdownlist id="cbxcodofi" Font-Size="8pt" 
                                                    Font-Names="Verdana" runat="server" Width="104px" Enabled="False"></asp:dropdownlist></TD>
											<TD><asp:textbox id="txtcnrocta" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="88px"
													BorderWidth="1px" Enabled="False"></asp:textbox></TD>
										</TR>
									</TABLE>
									<TABLE id="Table20" style="WIDTH: 448px; HEIGHT: 19px" cellSpacing="0" cellPadding="0"
										width="448" border="0">
										<TR>
											<TD style="WIDTH: 30px"><asp:label id="Label3" Height="15px" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="48px">Nombre:</asp:label></TD>
											<TD style="WIDTH: 313px" align="left"><asp:textbox id="txtcNomcli" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="222px"
													BorderWidth="1px" Enabled="False"></asp:textbox></TD>
										</TR>
									</TABLE>
									<TABLE id="Table21" style="WIDTH: 448px; HEIGHT: 19px" cellSpacing="0" cellPadding="0"
										width="448" border="0">
										<TR>
											<TD style="WIDTH: 65px"><asp:label id="Label2" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="48px">Cliente:</asp:label></TD>
											<TD style="WIDTH: 406px" align="left"><asp:textbox id="txtcCodCli" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="178px"
													BorderWidth="1px" Enabled="False"></asp:textbox><asp:textbox id="txtCredito" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="16px"
													BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox></TD>
										</TR>
									</TABLE>
									<TABLE id="Table22" style="WIDTH: 638px; HEIGHT: 58px" cellSpacing="0" 
                                        cellPadding="0" border="0">
										<TR>
											<TD class="style11">
												<asp:label id="Label29" Font-Size="8pt" Font-Names="Calibri" runat="server" 
                                                    Width="128px" Height="10px">LINEA DE CRÉDITO ACTUAL:</asp:label>
											</TD>
											<TD class="style12">
												<asp:TextBox ID="TextBox1" runat="server" Enabled="False" Font-Names="Calibri" 
                                                    Font-Size="10pt" Height="23px" Width="368px"></asp:TextBox>
											</TD>
										</TR>
										<TR>
											<TD style="WIDTH: 99px">
												<asp:label id="Label28" Font-Size="8pt" Font-Names="Verdana" runat="server" 
                                                    Width="128px" Height="10px">Fuente de Fondos:</asp:label>
											</TD>
											<TD>
                        <asp:DropDownList ID="cbxprograma" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="19px" Width="368px" AutoPostBack="True">
                        </asp:DropDownList>
											</TD>
										</TR>
										<TR>
											<TD style="WIDTH: 99px">
												<P><asp:label id="Label8" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="104px" Height="10px">Línea de Crédito:</asp:label></P>
											</TD>
											<TD>
												<P style="BACKGROUND-COLOR: #ffffff"><asp:dropdownlist id="cbxLineas" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="368px"></asp:dropdownlist></P>
											</TD>
										</TR>
									</TABLE>
									</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 438px" align="center">
                            <table align="center" cellpadding="0" cellspacing="0" class="style1">
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label5" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="96px">Monto Otorgado</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtnMonApr" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="80px"
													BorderWidth="1px" BorderColor="Black"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:rangevalidator id="RangeValidator3" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="82px"
													MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="txtnMonApr">Valor 
                                        Inválido</asp:rangevalidator>
                                    </td>
                                    <td>
                                        <asp:label id="Label12" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"
								BackColor="LemonChiffon" ForeColor="#C04000" Font-Bold="True">Tipo de Cuota</asp:label>
                                    </td>
                                    <td class="style13">
                                        &nbsp;</td>
                                    <td class="style15">
                                        <asp:label id="Label30" runat="server" Width="110px" Font-Names="Calibri" 
                                            Font-Size="10pt" Font-Bold="True">CONDICIONES DE LA REESTRUCTURACIÓN:</asp:label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label11" runat="server" Width="75px" Font-Names="Verdana" Font-Size="8pt">F.Desembolso:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtFecDes" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="80px"
													BorderWidth="1px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:rangevalidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="88px"
													MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtFecDes" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator>
                                    </td>
                                    <td>
                                        <asp:radiobutton id="RadioButton1" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Fija" Checked="True"></asp:radiobutton>
                                    </td>
                                    <td class="style13">
                                        &nbsp;</td>
                                    <td class="style15">
                                        <asp:textbox id="txtFecDes0" Font-Size="8pt" Font-Names="Verdana" 
                                            runat="server" Width="80px"
													BorderWidth="1px" Visible="False"></asp:textbox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label27" runat="server" Width="65px" Font-Names="Verdana" 
                                            Font-Size="8pt">F. 1ªCuota</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtfecpri" Height="22px" Font-Size="Smaller" Font-Names="Century Gothic" runat="server"
										Width="80px" BorderWidth="1px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        <asp:rangevalidator id="RangeValidator6" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="88px"
										MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecpri" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator>
                                    </td>
                                    <td>
                                        <asp:radiobutton id="RadioButton5" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Flat"></asp:radiobutton>
                                    </td>
                                    <td align="right" class="style13">
                                        <asp:label id="Label31" runat="server" Width="89px" Font-Names="Verdana" 
                                            Font-Size="8pt" Height="16px">F. 1ªCuota:</asp:label>
                                    </td>
                                    <td class="style15">
                                        <asp:textbox id="txtfecpri0" Height="22px" Font-Size="Smaller" 
                                            Font-Names="Century Gothic" runat="server"
										Width="80px" BorderWidth="1px" BackColor="#FFFF66"></asp:textbox>
                                    </td>
                                    <td>
                                        <asp:rangevalidator id="RangeValidator7" Font-Size="8pt" Font-Names="Verdana" 
                                            runat="server" Width="88px"
													MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" 
                                            ControlToValidate="txtfecpri0" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label20" runat="server" Width="80px" Font-Names="Verdana" Font-Size="8pt">F.Vencimiento</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtvencimiento" runat="server" Width="80px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Enabled="False" Height="22px"></asp:textbox>
                                    </td>
                                    <td class="style9">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td align="right" class="style13">
                                        <asp:label id="Label32" runat="server" Width="89px" Font-Names="Verdana" 
                                            Font-Size="8pt" Height="16px">NºCuotas:</asp:label>
                                    </td>
                                    <td class="style15">
                                        <asp:textbox id="pnCuoSug0" Font-Size="8pt" Font-Names="Verdana" runat="server" 
                                            Width="60px" BorderWidth="1px"
													BorderColor="Black" BackColor="#FFFF66"></asp:textbox>
                                    </td>
                                    <td>
                                        <asp:rangevalidator id="RangeValidator8" Height="8px" Font-Size="8pt" 
                                            Font-Names="Verdana" runat="server"
													Width="86px" MaximumValue="240" MinimumValue="1" Type="Integer" ErrorMessage="RangeValidator" 
                                            ControlToValidate="pnCuoSug0">Valor Inválido-</asp:rangevalidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        </td>
                                    <td class="style18">
                                        <asp:label id="Label26" runat="server" Width="96px" Font-Names="Calibri" 
                                            Font-Size="10pt" Font-Bold="True">FORMA DE PAGO</asp:label>
                                    </td>
                                    <td class="style19">
                                        <asp:textbox id="txtctipcuo" Height="9px" runat="server" Width="64px" Visible="False"></asp:textbox></td>
                                    <td class="style20">
                                        <asp:textbox id="txtctipper" Height="7px" runat="server" Width="64px" Visible="False"></asp:textbox>
                                    </td>
                                    <td class="style21">
                                        <asp:label id="Label36" runat="server" Width="89px" Font-Names="Verdana" 
                                            Font-Size="8pt" Height="16px">Saldo Actual:</asp:label>
                                    </td>
                                    <td class="style22">
                                        <asp:textbox id="txtnMonApr0" Font-Size="8pt" Font-Names="Verdana" 
                                            runat="server" Width="80px"
													BorderWidth="1px" BorderColor="Black" BackColor="Black" Enabled="False" Font-Bold="False" 
                                            ForeColor="White"></asp:textbox>
                                    </td>
                                    <td class="style20">
                                        <asp:textbox id="txtcondicion" Height="7px" runat="server" Width="64px" 
                                            Visible="False"></asp:textbox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label24" runat="server" Width="96px" Font-Names="Calibri" 
                                            Font-Size="10pt">Capital:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:dropdownlist id="cbxCapital" runat="server" Width="150px" 
                                            Font-Names="Calibri" Font-Size="10pt" AutoPostBack="True" Height="16px"></asp:dropdownlist>
                                    </td>
                                    <td class="style9">
                                        <asp:textbox id="txtdfecven" Height="7px" runat="server" Width="64px" Visible="False"></asp:textbox></td>
                                    <td>
                                        <asp:textbox id="txtndiagra" Height="7px" runat="server" Width="64px" Visible="False"></asp:textbox>
                                    </td>
                                    <td class="style13">
                                        &nbsp;</td>
                                    <td class="style15">
                                        <asp:label id="Label33" runat="server" Width="96px" Font-Names="Calibri" 
                                            Font-Size="10pt" Font-Bold="True">FORMA DE PAGO</asp:label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label25" runat="server" Width="79px" Font-Names="Calibri" 
                                            Font-Size="10pt" Height="16px">Interes:</asp:label>
                                    </td>
                                    <td class="style4">
                                        <asp:dropdownlist id="cbxInteres" runat="server" Width="150px" 
                                            Font-Names="Calibri" Font-Size="10pt" Height="16px"></asp:dropdownlist>
                                    </td>
                                    <td class="style9">
                                        <asp:textbox id="txtnperdia" Height="7px" runat="server" Width="64px" Visible="False"></asp:textbox>
                                                </td>
                                    <td>
                                                <asp:textbox id="pnPerGra" Font-Size="8pt" Font-Names="Verdana" runat="server" 
                                                    Width="26px" BorderWidth="1px"
													BorderColor="Black" Height="16px" Visible="False"></asp:textbox>
                                    </td>
                                    <td align="right" class="style13">
                                        <asp:label id="Label34" runat="server" Width="89px" Font-Names="Verdana" 
                                            Font-Size="8pt" Height="16px">Capital:</asp:label>
                                    </td>
                                    <td class="style15">
                                        <asp:dropdownlist id="cbxCapital0" runat="server" Width="150px" 
                                            Font-Names="Calibri" Font-Size="10pt" AutoPostBack="True" Height="16px"></asp:dropdownlist>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style5">
                                        <asp:label id="Label14" runat="server" Width="48px" Font-Names="Verdana" Font-Size="8pt">NºCuotas:</asp:label>
                                    </td>
                                    <td class="style6">
                                        <asp:textbox id="pnCuoSug" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="60px" BorderWidth="1px"
													BorderColor="Black"></asp:textbox>
                                    </td>
                                    <td class="style10">
                                        <asp:rangevalidator id="RangeValidator1" Height="8px" Font-Size="8pt" Font-Names="Verdana" runat="server"
													Width="86px" MaximumValue="240" MinimumValue="1" Type="Integer" ErrorMessage="RangeValidator" ControlToValidate="pnCuoSug">Valor Inválido-</asp:rangevalidator>
                                    </td>
                                    <td class="style8">
                                        <asp:textbox id="pnDiaSug" runat="server" 
                                Width="72px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Visible="False"></asp:textbox>
                                    </td>
                                    <td class="style14" align="right">
                                        <asp:label id="Label35" runat="server" Width="89px" Font-Names="Verdana" 
                                            Font-Size="8pt" Height="16px">Interes:</asp:label>
                                    </td>
                                    <td class="style16">
                                        <asp:dropdownlist id="cbxInteres0" runat="server" Width="150px" 
                                            Font-Names="Calibri" Font-Size="10pt" Height="16px"></asp:dropdownlist>
                                    </td>
                                    <td class="style8">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style26">
                                        <asp:label id="Label16" runat="server" Width="88px" Font-Names="Verdana" 
                                            Font-Size="8pt" Visible="False">Gracia en días:</asp:label>
                                    </td>
                                    <td class="style27">
                                        <asp:textbox id="pnPerGra0" runat="server" Width="72px" 
                                            Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Visible="False"></asp:textbox>
                                    </td>
                                    <td class="style28">
                                        <asp:radiobutton id="RadioButton6" runat="server" Width="104px" 
                                Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Periodo Fijo" 
                                Visible="False"></asp:radiobutton>
                                    </td>
                                    <td class="style29">
                                        <asp:radiobutton id="RadioButton7" 
                                runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Fecha Fija" 
                                Checked="True" Visible="False"></asp:radiobutton>
                                    </td>
                                    <td align="center" class="style30">
                                    </td>
                                    <td align="center" class="style31">
                                    </td>
                                    <td class="style29">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:radiobutton id="RadioButton2" runat="server" Width="104px" 
                                            Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Creciente" 
                                            Visible="False"></asp:radiobutton>
                                    </td>
                                    <td class="style4">
                                        <asp:radiobutton id="RadioButton3" runat="server" Width="104px" 
                                            Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Libre Amort." 
                                            Visible="False"></asp:radiobutton>
                                    </td>
                                    <td class="style9">
                                        <asp:radiobutton id="RadioButton4" runat="server" Width="104px" 
                                            Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Decreciente" 
                                            Visible="False"></asp:radiobutton>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td class="style13">
                                        &nbsp;</td>
                                    <td class="style15">
                                        <asp:label id="Label37" runat="server" Width="153px" Font-Names="Calibri" 
                                            Font-Size="10pt" Font-Bold="True">PLAN DE PAGOS REESTR.</asp:label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
								</TD>
							</TR>
						</TABLE>
						    <table cellpadding="0" cellspacing="0" class="style23">
                                <tr>
                                    <td class="style24">
						<asp:datagrid id="dgPlan" Height="175px" runat="server" Width="385px" 
                            BorderWidth="1px" BorderColor="#006699"
							BorderStyle="None" AutoGenerateColumns="False" CellPadding="3" BackColor="White" AllowSorting="True">
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
							<ItemStyle Font-Size="Medium" Font-Names="Century Gothic" HorizontalAlign="Center" ForeColor="#000066"
								VerticalAlign="Middle"></ItemStyle>
							<HeaderStyle Font-Size="Larger" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
								ForeColor="White" VerticalAlign="Middle" BackColor="#006699"></HeaderStyle>
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="Fecha" SortExpression="Fecha" HeaderText="Fecha">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="operacion" SortExpression="operacion" HeaderText="Tipo Op.">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="N_Cuota" SortExpression="N_Cuota" HeaderText="N&#186;Cuota">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="capital" SortExpression="capital" HeaderText="Capital">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="interes" SortExpression="interes" HeaderText="Interes">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Saldo" SortExpression="Saldo" HeaderText="Saldo">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
						</asp:datagrid>
                                    </td>
                                    <td>
						<asp:datagrid id="dgPlan0" Height="232px" runat="server" Width="245px" 
                            BorderWidth="1px" BorderColor="#DEDFDE"
							BorderStyle="None" AutoGenerateColumns="False" CellPadding="4" BackColor="White" AllowSorting="True" 
                                            ForeColor="Black" GridLines="Vertical">
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#CE5D5A"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#FFFF99" />
							<ItemStyle Font-Size="Medium" Font-Names="Century Gothic" HorizontalAlign="Center"
								VerticalAlign="Middle" BackColor="#F7F7DE"></ItemStyle>
							<HeaderStyle Font-Size="Larger" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
								ForeColor="White" VerticalAlign="Middle" BackColor="#6B696B"></HeaderStyle>
							<FooterStyle BackColor="#CCCC99"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="Fecha" SortExpression="Fecha" HeaderText="Fecha">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="operacion" SortExpression="operacion" HeaderText="Tipo Op.">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="N_Cuota" SortExpression="N_Cuota" HeaderText="N&#186;Cuota">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="capital" SortExpression="capital" HeaderText="Capital">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="interes" SortExpression="interes" HeaderText="Interes">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Saldo" SortExpression="Saldo" HeaderText="Saldo">
									<HeaderStyle Font-Size="XX-Small"></HeaderStyle>
									<ItemStyle Font-Size="XX-Small"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#F7F7DE" 
                                Mode="NumericPages"></PagerStyle>
						</asp:datagrid>
                                    </td>
                                </tr>
                            </table>
                        </TD>
					<TD style="WIDTH: 419px" align="center">
						&nbsp;</TD>
				</TR>
			</TABLE>
			<TABLE id="Table18" style="WIDTH: 754px; HEIGHT: 61px" cellSpacing="0" 
                    cellPadding="0" border="0">
				<TR>
					<TD align="center" class="style25">&nbsp;</TD>
					<TD style="WIDTH: 102px" align="center">
                        <INPUT id="btnPlan" style="FONT-SIZE: 12px; BACKGROUND-IMAGE: url(Web/jpgs/btn_plan_b.jpg); WIDTH: 56px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
							type="button" name="Button4" runat="server"></TD>
					<TD align="center" class="style32"><INPUT id="btnGrabar" style="FONT-SIZE: 12px; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 58px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button2" runat="server"></TD>
					<TD align="center"><INPUT id="btnImprimir" style="BACKGROUND-POSITION: center center; FONT-SIZE: 12px; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 56px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
							type="button" name="Button3" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
