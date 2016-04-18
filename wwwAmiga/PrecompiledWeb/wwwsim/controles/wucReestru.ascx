<%@ control language="vb" autoeventwireup="false" inherits="wucReestru, App_Web_yl8dokps" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<style type="text/css">

    .style23
    {
        width: 182%;
    }
    .style24
    {
        width: 509px;
    }
    .style32
    {
        width: 156px;
    }
    .style37
    {
        width: 232px;
        height: 6px;
    }
    .style38
    {
        height: 6px;
    }
    .style42
    {
        width: 68%;
    }
    .style39
    {
        width: 232px;
        height: 14px;
    }
    .style40
    {
        height: 14px;
    }
    
    .style11
    {
        width: 232px;
        height: 7px;
    }
    .style12
    {
        height: 7px;
    }
    .style41
    {
        width: 232px;
    }
    .style43
    {
        width: 811px;
        height: 100px;
    }
    .style44
    {
        width: 100%;
    }
    </style>
&nbsp;
<TABLE id="Table15" style="border: thin solid highlight; WIDTH: 1085px; HEIGHT: 703px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" align="left" border="0">
	<TR>
		<TD style="HEIGHT: 29px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">PRORROGA DE CREDITOS</P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px">
			<table id="Table22" align="center" border="0" cellpadding="0" cellspacing="0" 
                style="WIDTH: 618px; HEIGHT: 95px">
                <tr>
                    <td align="right" class="style37">
                        <asp:Label ID="Label1" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="12px" Width="48px">Credito:</asp:Label>
                    </td>
                    <td class="style38">
                        <table cellpadding="0" cellspacing="0" class="style42">
                            <tr>
                                <td>
                                    <asp:DropDownList ID="cbxCodIns" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="136px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:DropDownList ID="cbxcodofi" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Width="104px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtcnrocta" runat="server" BorderWidth="1px" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Width="88px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style37">
                        <asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="15px" Width="48px">Nombre:</asp:Label>
                    </td>
                    <td class="style38">
                        <asp:TextBox ID="txtcNomcli" runat="server" BorderWidth="1px" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Width="222px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style39">
                        <asp:Label ID="Label2" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Width="48px">Cliente:</asp:Label>
                    </td>
                    <td class="style40">
                        <asp:TextBox ID="txtcCodCli" runat="server" BorderWidth="1px" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Width="178px"></asp:TextBox>
                        <asp:TextBox ID="txtCredito" runat="server" BorderWidth="1px" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False" Width="16px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style11">
                        <asp:Label ID="Label29" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="10px" Width="192px">LINEA DE CRÉDITO ACTUAL:</asp:Label>
                    </td>
                    <td class="style12">
                        <asp:TextBox ID="TextBox1" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="23px" Width="368px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style41">
                        <asp:Label ID="Label28" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="10px" Width="128px">Fuente de Fondos:</asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="cbxprograma" runat="server" AutoPostBack="True" 
                            Font-Names="Century Gothic" Font-Size="10pt" Height="19px" Width="368px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style41">
                        <p align="right">
                            <asp:Label ID="Label8" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="10px" Width="104px">Línea de Crédito:</asp:Label>
                        </p>
                    </td>
                    <td>
                        <p style="BACKGROUND-COLOR: #ffffff">
                            <asp:DropDownList ID="cbxLineas" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Width="368px">
                            </asp:DropDownList>
                        </p>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px" align="center">
			<table cellpadding="0" cellspacing="0" class="style43">
                <tr>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" class="CSSTableGenerator" 
                            style="width: 108px">
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="96px">Monto Otorgado</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtnMonApr" runat="server" BorderColor="Black" 
                                        BorderWidth="1px" Font-Names="Gill Sans MT" Font-Size="10pt" Width="80px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RangeValidator ID="RangeValidator3" runat="server" 
                                        ControlToValidate="txtnMonApr" ErrorMessage="RangeValidator" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" MaximumValue="1000000000" 
                                        MinimumValue="0" Type="Double" Width="82px">Valor 
                                        Inválido</asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="75px">F.Desembolso:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFecDes" runat="server" BorderWidth="1px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Width="80px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RangeValidator ID="RangeValidator5" runat="server" 
                                        ControlToValidate="txtFecDes" DESIGNTIMEDRAGDROP="1491" 
                                        ErrorMessage="RangeValidator" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" Width="88px">Fecha Inválida-</asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label27" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="65px">F. 1ªCuota</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtfecpri" runat="server" BorderWidth="1px" 
                                        Font-Names="Century Gothic" Font-Size="10pt" Height="22px" Width="80px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RangeValidator ID="RangeValidator6" runat="server" 
                                        ControlToValidate="txtfecpri" DESIGNTIMEDRAGDROP="1491" 
                                        ErrorMessage="RangeValidator" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" Width="88px">Fecha Inválida-</asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label20" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="80px">F.Vencimiento</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtvencimiento" runat="server" BorderWidth="1px" 
                                        Enabled="False" Font-Names="Century Gothic" Font-Size="10pt" Height="22px" 
                                        Width="80px"></asp:TextBox>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:Label ID="Label26" runat="server" Font-Bold="True" 
                                        Font-Names="Gill Sans MT" Font-Size="8pt" Width="128px">FORMA DE PAGO</asp:Label>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="96px">Capital:</asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="cbxCapital" runat="server" AutoPostBack="True" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="150px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Height="16px" Width="79px">Interes:</asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="cbxInteres" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Height="16px" Width="150px">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="48px">NºCuotas:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="pnCuoSug" runat="server" BorderColor="Black" BorderWidth="1px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Width="60px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                        ControlToValidate="pnCuoSug" ErrorMessage="RangeValidator" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Height="8px" MaximumValue="240" 
                                        MinimumValue="1" Type="Integer" Width="86px">Valor Inválido-</asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label16" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="88px">Gracia(Cuotas):</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="pnPerGra1" runat="server" BorderColor="Black" 
                                        BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Height="26px" Width="60px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RangeValidator ID="RangeValidator9" runat="server" 
                                        ControlToValidate="pnPerGra" ErrorMessage="RangeValidator" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px" MaximumValue="12" MinimumValue="0" Type="Integer" 
                                        Width="100px">Gracia Inválidas-</asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label38" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="88px">Tipo de Cuota:</asp:Label>
                                </td>
                                <td>
                                    <asp:RadioButton ID="RadioButton1" runat="server" BackColor="White" 
                                        BorderWidth="1px" Checked="True" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        GroupName="TipoPago" Text="Nivelada" Width="104px" />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                        <asp:radiobutton id="RadioButton5" runat="server" 
                Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BackColor="White" GroupName="TipoPago" 
                Text="Flat"></asp:radiobutton>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td align="center">
                        <table cellpadding="0" cellspacing="0" class="style44">
                            <tr>
                                <td align="center">
                                    <asp:Label ID="Label30" runat="server" Font-Bold="True" 
                                        Font-Names="Gill Sans MT" Font-Size="8pt" Width="261px">CONDICIONES DE LA PRORROGA</asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <table cellpadding="0" cellspacing="0" class="CSSTableGenerator" 
                                        style="width: 150px">
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label41" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="16px" Width="89px" Visible="False">Fec. Reestr.:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtFecDes0" runat="server" BorderWidth="1px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False" Width="80px"></asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label31" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="16px" Width="89px">F. 1ªCuota:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtfecpri0" runat="server" BackColor="#FFFF66" 
                                                    BorderWidth="1px" Font-Names="Century Gothic" Font-Size="10pt" Height="22px" 
                                                    Width="80px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RangeValidator ID="RangeValidator7" runat="server" 
                                                    ControlToValidate="txtfecpri0" DESIGNTIMEDRAGDROP="1491" 
                                                    ErrorMessage="RangeValidator" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" Width="88px">Fecha Inválida-</asp:RangeValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label32" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="16px" Width="89px">NºCuotas:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="pnCuoSug0" runat="server" BackColor="#FFFF66" 
                                                    BorderColor="Black" BorderWidth="1px" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Width="60px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RangeValidator ID="RangeValidator8" runat="server" 
                                                    ControlToValidate="pnCuoSug0" ErrorMessage="RangeValidator" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="8px" MaximumValue="240" 
                                                    MinimumValue="1" Type="Integer" Width="86px">Valor Inválido-</asp:RangeValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label39" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Width="88px">Gracia(Cuotas):</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="pnPerGra0" runat="server" BorderWidth="1px" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Width="72px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:RangeValidator ID="RangeValidator10" runat="server" 
                                                    ControlToValidate="pnPerGra0" ErrorMessage="RangeValidator" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" MaximumValue="12" 
                                                    MinimumValue="0" Type="Integer" Width="100px">Gracia Inválidas-</asp:RangeValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label36" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="16px" Width="89px">Saldo Actual:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtnMonApr0" runat="server" BackColor="Black" 
                                                    BorderColor="Black" BorderWidth="1px" Enabled="False" Font-Bold="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="White" Width="80px"></asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label42" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="16px" Width="133px">Saldo de Int.Moratorio:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtmora" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Width="104px"></asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="txtcondicion" runat="server" Height="16px" Visible="False" 
                                                    Width="64px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label33" runat="server" Font-Bold="True" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Width="136px">FORMA DE PAGO</asp:Label>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label34" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="16px" Width="89px">Capital:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="cbxCapital0" runat="server" AutoPostBack="True" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="150px">
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label35" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="16px" Width="89px">Interes:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="cbxInteres0" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="16px" Width="150px">
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 29px" align="center">
						    <table cellpadding="0" cellspacing="0" class="style23">
                                <tr>
                                    <td class="style24">
                                        <asp:label id="Label40" runat="server" Width="196px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Font-Bold="True">PLAN DE PAGOS ACTUAL</asp:label>
                                    </td>
                                    <td>
                                        <asp:label id="Label37" runat="server" Width="232px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" Font-Bold="True">PLAN DE PAGOS PRORROGADO</asp:label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style24">
						                &nbsp;</td>
                                    <td>
			<TABLE id="Table18" style="WIDTH: 206px; HEIGHT: 61px" cellSpacing="0" 
                    cellPadding="0" border="0">
				<TR>
					<TD style="WIDTH: 102px" align="center">
                        <INPUT id="btnPlan" style="FONT-SIZE: 12px; BACKGROUND-IMAGE: url('Web/jpgs/btn_plan_b.jpg'); WIDTH: 56px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 51px; BACKGROUND-COLOR: transparent"
							type="button" name="Button4" runat="server"></TD>
					<TD align="center" class="style32"><INPUT id="btnGrabar" style="FONT-SIZE: 12px; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 58px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button2" runat="server"></TD>
					<TD align="center">
                        <INPUT id="btnImprimir" style="BACKGROUND-POSITION: center center; FONT-SIZE: 12px; BACKGROUND-IMAGE: url('Web/gifs/imprimir.gif'); WIDTH: 56px; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 53px; BACKGROUND-COLOR: transparent"
							type="button" name="Button3" runat="server"></TD>
				</TR>
			</TABLE>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style24">
						<asp:datagrid id="dgPlan" Height="175px" runat="server" Width="276px" 
                            BorderWidth="1px" BorderColor="#006699"
							BorderStyle="None" AutoGenerateColumns="False" CellPadding="3" BackColor="White" AllowSorting="True" 
                                            Font-Names="Gill Sans MT">
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
							<ItemStyle Font-Size="Medium" Font-Names="Century Gothic" HorizontalAlign="Center" ForeColor="#000066"
								VerticalAlign="Middle"></ItemStyle>
							<HeaderStyle Font-Size="Larger" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
								ForeColor="White" VerticalAlign="Middle" BackColor="#006699"></HeaderStyle>
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="Fecha" SortExpression="Fecha" HeaderText="Fecha" 
                                    DataFormatString="{0:dd-MM-yyyy}">
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
								<asp:BoundColumn DataField="gastos" HeaderText="Comisiones" 
                                    SortExpression="gastos">
                                    <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Size="XX-Small" Font-Strikeout="False" Font-Underline="False" />
                                    <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Size="XX-Small" Font-Strikeout="False" Font-Underline="False" />
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="nsegdeu" HeaderText="Seguro Deuda" 
                                    SortExpression="nsegdeu">
                                    <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Size="XX-Small" Font-Strikeout="False" Font-Underline="False" />
                                    <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Size="XX-Small" Font-Strikeout="False" Font-Underline="False" />
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
						<asp:datagrid id="dgPlan0" Height="232px" runat="server" Width="178px" 
                            BorderWidth="1px" BorderColor="#DEDFDE"
							BorderStyle="None" AutoGenerateColumns="False" CellPadding="4" BackColor="White" AllowSorting="True" 
                                            ForeColor="Black" GridLines="Vertical" Font-Names="Gill Sans MT">
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#CE5D5A"></SelectedItemStyle>
							<AlternatingItemStyle BackColor="#FFFF99" />
							<ItemStyle Font-Size="Medium" Font-Names="Century Gothic" HorizontalAlign="Center"
								VerticalAlign="Middle" BackColor="#F7F7DE"></ItemStyle>
							<HeaderStyle Font-Size="Larger" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
								ForeColor="White" VerticalAlign="Middle" BackColor="#6B696B"></HeaderStyle>
							<FooterStyle BackColor="#CCCC99"></FooterStyle>
							<Columns>
								<asp:BoundColumn DataField="Fecha" SortExpression="Fecha" HeaderText="Fecha" 
                                    DataFormatString="{0:dd-MM-yyyy}">
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
								<asp:BoundColumn DataField="gastos" HeaderText="Comisiones" 
                                    SortExpression="gastos">
                                    <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Size="XX-Small" Font-Strikeout="False" Font-Underline="False" />
                                    <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Size="XX-Small" Font-Strikeout="False" Font-Underline="False" />
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="nsegdeu" HeaderText="Seguro Deuda" 
                                    SortExpression="nsegdeu">
                                    <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Size="XX-Small" Font-Strikeout="False" Font-Underline="False" />
                                    <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Size="XX-Small" Font-Strikeout="False" Font-Underline="False" />
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
	</TR>
	<TR>
		<TD>
		</TD>
	</TR>
	<TR>
		<TD>
                                        <asp:textbox id="txtctipcuo" Height="16px" 
                runat="server" Width="22px" Visible="False"></asp:textbox>
                                        <asp:textbox id="txtdfecven" Height="16px" 
                runat="server" Width="25px" Visible="False"></asp:textbox>
                                        <asp:textbox id="txtnperdia" Height="16px" 
                runat="server" Width="19px" Visible="False"></asp:textbox>
                                        <asp:textbox id="txtctipper" Height="16px" 
                runat="server" Width="18px" Visible="False"></asp:textbox>
                                        <asp:textbox id="txtndiagra" Height="16px" 
                runat="server" Width="16px" Visible="False"></asp:textbox>
                                                <asp:textbox id="pnPerGra" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" 
                                                    Width="26px" BorderWidth="1px"
													BorderColor="Black" Height="16px" Visible="False"></asp:textbox>
                                        <asp:textbox id="pnDiaSug" runat="server" 
                                Width="17px" Font-Names="Century Gothic" Font-Size="Smaller"
								BorderWidth="1px" Visible="False" Height="16px"></asp:textbox>
                                        <asp:radiobutton id="RadioButton4" runat="server" Width="104px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Decreciente" 
                                            Visible="False"></asp:radiobutton>
                                        <asp:radiobutton id="RadioButton6" runat="server" Width="104px" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Periodo Fijo" 
                                Visible="False"></asp:radiobutton>
                                        <asp:radiobutton id="RadioButton7" 
                                runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Fecha Fija" 
                                Checked="True" Visible="False"></asp:radiobutton>
                                        <asp:radiobutton id="RadioButton2" runat="server" Width="104px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Creciente" 
                                            Visible="False"></asp:radiobutton>
                                        <asp:radiobutton id="RadioButton3" runat="server" Width="104px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="2px" BorderColor="DarkSalmon" BackColor="White" GroupName="TipoPago" Text="Libre Amort." 
                                            Visible="False"></asp:radiobutton>
                                        <asp:HiddenField ID="HiddenField1" runat="server" />
                                        <asp:HiddenField ID="HiddenField2" runat="server" />
                                    </TD>
	</TR>
</TABLE>
