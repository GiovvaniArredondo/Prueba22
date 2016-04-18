<%@ control language="vb" autoeventwireup="false" inherits="WbDesemb1, App_Web_yjxjq67i" %>
      <style type="text/css">

    .CSSTableGenerator
    {
        height: 98px;
        width: 312px;
    }
    </style>
      <script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
    <script type="text/javascript">
        function Fechas(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32)
                return true;
            else if (charCode >= 47 && charCode <= 57)
                return true;

            return false;
        }

        function SoloNumeros(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32 || charCode == 45 || charCode == 46)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;

            return false;
        }
</script>

<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 536px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 829px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="536" border="0">
	<TR>
		<TD style="HEIGHT: 79px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; TEXT-TRANSFORM: uppercase; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">DESEMBOLSO DE CREDITOS
			</P>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; TEXT-TRANSFORM: uppercase; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">
				<TABLE id="Table8" style="WIDTH: 338px; HEIGHT: 45px" cellSpacing="0" cellPadding="0" width="338"
					border="0">
					<TR>
						<TD style="WIDTH: 207px; HEIGHT: 22px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:label id="Label1" Font-Size="10pt" runat="server" Width="32px" Font-Names="Gill Sans MT">Grupo:</asp:label></TD>
						<TD style="HEIGHT: 22px"><SELECT id="cbxgrupos" style="FONT-SIZE: 12px; WIDTH: 333px; FONT-FAMILY: 'Gill Sans MT'"
								name="cbxanacre" runat="server">
								<OPTION selected></OPTION>
							</SELECT></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 207px" align="right"><asp:label id="Label6" Font-Size="10pt" runat="server" Width="63px" Font-Names="Gill Sans MT">Cliente:</asp:label></TD>
						<TD><asp:textbox id="TxtNomcli" runat="server" Width="328px" Font-Names="Gill Sans MT" BorderWidth="1px"
								Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Gill Sans MT', 'Gill Sans MT'; HEIGHT: 53px">
			<TABLE id="Table2" style="WIDTH: 560px; HEIGHT: 76px" cellSpacing="0" cellPadding="0" width="560"
				border="0">
				<TR>
					<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 108px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 32px">Solicitud</TD>
					<TD style="WIDTH: 135px; HEIGHT: 32px"><asp:textbox id="TxtInst" runat="server" Width="87px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 87px; HEIGHT: 32px"><asp:textbox id="TxtOficina" runat="server" Width="87px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False"></asp:textbox></TD>
					<TD style="HEIGHT: 32px"><asp:textbox id="txtCuenta" runat="server" Width="216px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 108px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 23px">Codigo 
						de Cliente</TD>
					<TD style="WIDTH: 135px; HEIGHT: 23px"><asp:textbox id="TxtCodcli" runat="server" Width="136px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 87px; HEIGHT: 23px"></TD>
					<TD style="HEIGHT: 23px"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 108px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">Moneda</TD>
					<TD style="WIDTH: 135px; HEIGHT: 22px"><asp:textbox id="TxtMoneda" runat="server" Width="136px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Font-Italic="True"></asp:textbox></TD>
					<TD style="WIDTH: 87px; HEIGHT: 22px"></TD>
					<TD style="HEIGHT: 22px"><asp:textbox id="txtCodigo" Font-Size="10pt" runat="server" Width="72px" Font-Names="Gill Sans MT"
							Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TxtRefina" Font-Size="10pt" runat="server" Width="64px" Font-Names="Gill Sans MT"
							Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtig" Font-Size="10pt" runat="server" Width="64px" Font-Names="Gill Sans MT" Enabled="False"
							Visible="False"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 2px; BACKGROUND-COLOR: #3399FF">Datos 
			del Desembolso</TD>
	</TR>
	<TR>
		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 2px; COLOR: White">
            <asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Gill Sans MT" 
                ForeColor="Black" Text="Desembolso Parcial" AutoPostBack="True" 
                Font-Bold="False" Font-Size="12pt" Visible="False" />
        </TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 96px">
			<TABLE id="Table3" style="WIDTH: 552px; HEIGHT: 41px" cellSpacing="0" cellPadding="0" width="552"
				border="0">
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 128px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 12px">
						<P style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
							align="left">No Dcto.</P>
					</TD>
					<TD style="FONT-SIZE: 10pt; WIDTH: 125px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 12px">
						<P style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
							align="left">Capital</P>
					</TD>
					<TD style="FONT-SIZE: 10pt; WIDTH: 122px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 12px">
						<P style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
							align="left">Descuentos</P>
					</TD>
					<TD style="FONT-SIZE: 10pt; WIDTH: 131px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 12px">
						<P style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
							align="left">Desembolso</P>
					</TD>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 12px">
						<P style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
							align="left">Forma&nbsp; de Desembolso</P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 128px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtDocumento" Font-Size="10pt" runat="server" Width="96px" Font-Names="Gill Sans MT"
								BorderWidth="1px" Enabled="False"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 125px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtCapita" Font-Size="10pt" runat="server" 
                                Width="96px" Font-Names="Gill Sans MT"
								BorderWidth="1px" Enabled="False" AutoPostBack="True"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 122px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtDescuento" Font-Size="10pt" runat="server" Width="96px" Font-Names="Gill Sans MT"
								BorderWidth="1px" Enabled="False"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 131px; HEIGHT: 25px">
						<P align="left"><asp:textbox id="TxtDesembolso" Font-Size="10pt" runat="server" 
                                Width="96px" Font-Names="Gill Sans MT"
								BorderWidth="1px" Enabled="False" AutoPostBack="True"></asp:textbox></P>
					</TD>
					<TD style="HEIGHT: 25px">
						<P align="left"><asp:dropdownlist id="cmbtippag" Font-Size="10pt" runat="server" 
                                Width="120px" Font-Names="Gill Sans MT" AutoPostBack="True"></asp:dropdownlist></P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 128px; HEIGHT: 25px">
						&nbsp;</TD>
					<TD style="WIDTH: 125px; HEIGHT: 25px">
						<asp:RangeValidator ID="RangeValidator1" runat="server" 
                            ControlToValidate="TxtCapita" ErrorMessage="RangeValidator" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" MaximumValue="1000000" 
                            MinimumValue="1" Type="Double" Width="104px">Monto Invalido</asp:RangeValidator>
					</TD>
					<TD style="WIDTH: 122px; HEIGHT: 25px">
						&nbsp;</TD>
					<TD style="WIDTH: 131px; HEIGHT: 25px">
						&nbsp;</TD>
					<TD style="HEIGHT: 25px">
						&nbsp;</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 128px; HEIGHT: 25px" align="right">
						<asp:Label ID="Label30" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Text="Disponible:"></asp:Label>
					</TD>
					<TD style="WIDTH: 125px; HEIGHT: 25px">
						<asp:TextBox ID="TextBox13" runat="server" Enabled="False" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="23px" Width="81px"></asp:TextBox>
					</TD>
					<TD style="WIDTH: 122px; HEIGHT: 25px">
                                        <asp:label id="Label45" runat="server" Width="80px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">Monto Cuota:</asp:label>
                        </TD>
					<TD style="WIDTH: 131px; HEIGHT: 25px">
                                        <asp:textbox id="txtnmoncuo" runat="server" Width="81px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="18px">0.00</asp:textbox>
                        </TD>
					<TD style="HEIGHT: 25px">
						&nbsp;</TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" style="WIDTH: 480px; HEIGHT: 56px" cellSpacing="0" cellPadding="0" width="480"
				border="0">
				<TR>
					<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 82px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 56px">Concepto 
						:</TD>
					<TD style="HEIGHT: 56px"><asp:textbox id="cGlosa" Font-Size="10pt" runat="server" 
                            Width="398px" Font-Names="Gill Sans MT"
							Height="48px" TextMode="MultiLine"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: powerblue; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 7px; BACKGROUND-COLOR: #0099FF">Detalle 
			de Comisiones</TD>
	</TR>
	<TR>
		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: powerblue; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 7px; " 
            align="center">
            <asp:datagrid id="Datagrid2" runat="server" 
                            Width="337px" BorderWidth="1px" Height="48px" BorderColor="#006699"
									BackColor="White" BorderStyle="None" CellPadding="3" AutoGenerateColumns="False" 
                            AllowSorting="True">
									<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
									<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
									<AlternatingItemStyle BackColor="#FFFF66" />
									<ItemStyle ForeColor="#000066"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
									<Columns>
										<asp:BoundColumn DataField="cdescri" SortExpression="cdescri" 
                                            HeaderText="Comision">
											<HeaderStyle Font-Size="X-Small" Font-Names="Gill Sans MT" Font-Bold="True" HorizontalAlign="Center"
												VerticalAlign="Top" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
											<ItemStyle Font-Size="X-Small" Font-Names="Gill Sans MT" 
                                                HorizontalAlign="Center" VerticalAlign="Top" Font-Bold="False" 
                                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                                Font-Underline="False"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="nmongas" SortExpression="nmongas" 
                                            HeaderText="Monto">
											<HeaderStyle Font-Size="X-Small" Font-Names="Gill Sans MT" Font-Bold="True" HorizontalAlign="Center"
												VerticalAlign="Top" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
											<ItemStyle Font-Size="X-Small" Font-Names="Gill Sans MT" 
                                                HorizontalAlign="Center" VerticalAlign="Top" Font-Bold="False" 
                                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                                Font-Underline="False"></ItemStyle>
										</asp:BoundColumn>
									</Columns>
									<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
								</asp:datagrid></TD>
	</TR>
	<TR>
		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 10pt;  FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 7px; >
            &nbsp;</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: #ffffff; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 75px">
			<TABLE id="Table5" style="WIDTH: 336px; HEIGHT: 33px" cellSpacing="0" cellPadding="0"
				border="0">
				<TR>
					<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 183px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">Deuda 
						a Descontar:</TD>
					<TD style="HEIGHT: 24px"><asp:textbox id="txtDeuda" runat="server" Width="84px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False"></asp:textbox></TD>
				</TR>
				</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: powerblue; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 17px; BACKGROUND-COLOR: #3399FF">Refinanciamiento:</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: #ffffff; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 77px">
			<DIV align="center">
                <asp:GridView ID="Grid_Ref" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="612px">
                    <Columns>                                                
                        <asp:BoundField DataField="idcuenta" HeaderText="cuenta">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>                        
                        <asp:BoundField DataField="nCapita" HeaderText="Capital" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nIntere" HeaderText="Interes" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nIntMor" HeaderText="Mora">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nsegdeu" HeaderText="Seguro" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ncomision" HeaderText="Comisión" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="niva" HeaderText="Iva" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ntota" HeaderText="Total" 
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
                            </DIV>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: powerblue; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 14px; BACKGROUND-COLOR: #3399FF">Detalle 
			del Cheque&nbsp;u O.P.</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: black; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 53px">
            <table id="Table6" align="center" border="1" cellpadding="0" cellspacing="0" 
                style="border-color: #000066; WIDTH: 455px; HEIGHT: 42px">
                <tr>
                    <td style="FONT-SIZE: 9pt; WIDTH: 183px; HEIGHT: 21px">
                        <p align="left" 
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">
                            <asp:Label ID="Label28" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Height="16px" Width="96px">Banco:</asp:Label>
                        </p>
                    </td>
                    <td style="FONT-SIZE: 9pt; HEIGHT: 21px">
                        <p align="left" 
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">
                            <asp:Label ID="Label29" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Height="16px" Width="96px" Visible="False">Cheque Nº</asp:Label>
                        </p>
                    </td>
                    <td style="FONT-SIZE: 9pt; HEIGHT: 21px">
                            <asp:Label ID="Label31" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Height="16px" Width="96px" Visible="False">Nº de Doc.</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="WIDTH: 183px; HEIGHT: 27px">
                        <asp:DropDownList ID="cmbBancos" runat="server" BackColor="#FFFF66" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="26px" Width="300px" 
                            AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                    <td style="HEIGHT: 27px">
                        <asp:TextBox ID="Txtnrochq" runat="server" BackColor="#FFFF66" 
                            BorderWidth="1px" Font-Names="Gill Sans MT" Font-Size="10pt" MaxLength="10" 
                            Width="80px" onkeypress="return SoloNumeros(event)" Visible="False" ></asp:TextBox>
                    </td>
                    <td style="HEIGHT: 27px">
                        <asp:TextBox ID="Txtfactura" runat="server" BackColor="#FFFF66" 
                            BorderWidth="1px" Font-Names="Gill Sans MT" Font-Size="10pt" MaxLength="10" 
                            Width="80px" Visible="False"></asp:TextBox>
                    </td>
                </tr>
            </table>
			<asp:textbox id="txtbandera" runat="server" Width="16px" Visible="False" Height="8px"></asp:textbox></TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: black; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 16px">
			<P align="center">
                <INPUT id="btnAplica" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" runat="server" visible="False">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnGrabar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnimprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(imagenes/Wzprint.bmp); WIDTH: 60px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 62px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp; 
                <INPUT id="btnfactura" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 60px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 62px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server" visible="False"> &nbsp;&nbsp;<INPUT 
                    id="btnCancela" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server" visible="False">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: black; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 16px">
			<asp:textbox id="TextBox5" runat="server" Width="21px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="16px" Visible="False"></asp:textbox>
            <asp:textbox id="TextBox6" runat="server" Width="23px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="16px" Visible="False"></asp:textbox>
            <asp:textbox id="TextBox7" runat="server" Width="34px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="16px" Visible="False"></asp:textbox>
            <asp:textbox id="txtIVA" runat="server" Width="24px" 
                            Font-Names="Gill Sans MT" BorderWidth="1px" Enabled="False" 
                Height="16px" Visible="False"></asp:textbox><asp:textbox id="TextBox9" 
                runat="server" Width="23px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="16px" Visible="False"></asp:textbox>
            <asp:textbox id="TextBox10" runat="server" Width="28px" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" Height="16px" Visible="False"></asp:textbox>
            <asp:textbox id="txtcodref1" runat="server" Width="16px" Visible="False"></asp:textbox><asp:textbox id="txtcodref2" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcodref3" runat="server" Width="32px" Visible="False"></asp:textbox><asp:textbox id="txtcodref4" runat="server" Width="32px" Visible="False"></asp:textbox>
            <asp:textbox id="txtfecvig" runat="server" Width="23px" Visible="False" 
                            Height="16px"></asp:textbox>
		    <asp:TextBox ID="TextBox12" runat="server" Height="17px" Visible="False" 
                Width="18px"></asp:TextBox>
            <asp:TextBox ID="TextBox11" runat="server" Height="16px" Visible="False" 
                Width="17px"></asp:TextBox>
            <asp:TextBox ID="txtflag" runat="server" Height="16px" Visible="False" 
                Width="28px"></asp:TextBox>
            <asp:TextBox ID="txtcnumcom" runat="server" Height="16px" Visible="False" 
                Width="28px"></asp:TextBox>
            <asp:TextBox ID="txtnumeros" runat="server" Height="16px" Visible="False" 
                Width="28px"></asp:TextBox>
		</TD>
	</TR>
</TABLE>
