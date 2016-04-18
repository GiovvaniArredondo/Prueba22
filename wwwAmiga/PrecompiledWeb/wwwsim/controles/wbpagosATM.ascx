<%@ control language="vb" autoeventwireup="false" inherits="wbpagosATM, App_Web_yl8dokps" %>
<TABLE id="Table7" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 558px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 24px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="1" cellPadding="1" width="558" border="1">
	<TR>
		<TD style="WIDTH: 123px"><asp:label id="Label29" runat="server" Width="112px" Font-Names="Verdana" Font-Size="8pt">Nombre de Archivo a Descargar:</asp:label></TD>
		<TD style="WIDTH: 116px"><asp:textbox id="txtarcdes" runat="server" Width="97px" Font-Names="Verdana" Font-Size="8pt"></asp:textbox></TD>
		<TD style="WIDTH: 10px"><asp:label id="Label37" runat="server" Width="72px" Font-Names="Verdana" Font-Size="8pt">Fecha de Proceso:</asp:label></TD>
		<TD style="WIDTH: 103px"><asp:textbox id="txtfecpro" runat="server" Width="88px" Font-Names="Verdana" Font-Size="8pt"></asp:textbox></TD>
		<TD><asp:button id="btnATM" runat="server" Width="112px" Font-Names="Verdana" Font-Size="8pt" Text="Aplicación ATM"></asp:button></TD>
	</TR>
</TABLE>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 558px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 511px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="558" border="0">
	<TR>
		<TD style="HEIGHT: 26px"><asp:label id="Label28" runat="server" Width="88px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Fecha Valor:</asp:label><asp:textbox id="txtfecval2" tabIndex="5" runat="server" Width="104px" Font-Names="Verdana" Font-Size="8pt"
				BorderWidth="1px"></asp:textbox><asp:rangevalidator id="RangeValidator5" runat="server" Width="88px" Font-Names="Verdana" Font-Size="8pt"
				DESIGNTIMEDRAGDROP="1491" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecval2">Fecha Inválida-</asp:rangevalidator><asp:label id="label_mensaje" runat="server" Width="184px" Height="15px" Font-Names="Verdana"
				Font-Size="8pt"></asp:label></TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table2" style="WIDTH: 512px; HEIGHT: 19px" cellSpacing="0" cellPadding="0" width="512"
				border="0">
				<TR>
					<TD style="WIDTH: 90px; HEIGHT: 19px"><asp:label id="Label10" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Crédito:</asp:label></TD>
					<TD style="WIDTH: 110px; HEIGHT: 19px"><asp:dropdownlist id="ddlcodins" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 150px; HEIGHT: 19px"><asp:dropdownlist id="ddlcodofi" runat="server" Width="136px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 153px; HEIGHT: 19px"><asp:textbox id="txtnrocta" tabIndex="5" runat="server" Width="140px" Height="16px" Font-Names="Verdana"
							Font-Size="8pt" BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					<TD style="HEIGHT: 19px" align="center"><asp:textbox id="txtcCodOfi" runat="server" Width="74px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Visible="False"></asp:textbox></TD>
				</TR>
			</TABLE>
			<asp:label id="Label32" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt"></asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 37px">
			<TABLE id="Table3" style="WIDTH: 536px; HEIGHT: 19px" cellSpacing="0" cellPadding="0" width="536"
				border="0">
				<TR>
					<TD style="WIDTH: 113px"><asp:label id="Label11" runat="server" Width="112px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Codigo de Cliente:</asp:label></TD>
					<TD style="WIDTH: 167px" align="center"><asp:textbox id="txtcodcli" tabIndex="5" runat="server" Width="176px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					<TD align="center"><asp:textbox id="txtnomcli" tabIndex="5" runat="server" Width="247px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False"></asp:textbox></TD>
				</TR>
			</TABLE>
			<asp:label id="Label31" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt"></asp:label></TD>
	</TR>
	<TR>
		<TD style="BACKGROUND-COLOR: background"><asp:label id="Label12" runat="server" Width="160px" Height="15px" Font-Names="Verdana" Font-Size="X-Small"
				ForeColor="PowderBlue" Font-Bold="True">Saldos de Credito:</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 47px">
			<TABLE id="Table5" style="WIDTH: 536px; HEIGHT: 19px" cellSpacing="0" cellPadding="0" width="536"
				border="0">
				<TR>
					<TD style="WIDTH: 123px" align="center"><asp:label id="Label13" runat="server" Width="48px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Capital</asp:label></TD>
					<TD style="WIDTH: 81px" align="center"><asp:label id="Label14" runat="server" Width="72px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Interés</asp:label></TD>
					<TD style="WIDTH: 123px" align="center"><asp:label id="Label15" runat="server" Width="64px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Gastos</asp:label></TD>
					<TD style="WIDTH: 131px" align="center"><asp:label id="Label16" runat="server" Width="64px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Total</asp:label></TD>
					<TD style="WIDTH: 96px" align="center"><asp:label id="Label17" runat="server" Width="72px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Cuota</asp:label></TD>
					<TD style="WIDTH: 142px" align="center"><asp:label id="Label18" runat="server" Width="64px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Atraso</asp:label></TD>
					<TD></TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" style="WIDTH: 536px; HEIGHT: 27px" cellSpacing="0" cellPadding="0" width="536"
				border="0">
				<TR>
					<TD style="WIDTH: 92px; HEIGHT: 6px"><asp:textbox id="txtsaldo" tabIndex="5" runat="server" Width="88px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 1px; HEIGHT: 6px"></TD>
					<TD style="WIDTH: 82px; HEIGHT: 6px"><asp:textbox id="txtintere" tabIndex="5" runat="server" Width="83px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 84px; HEIGHT: 6px"><asp:textbox id="txtgastos" tabIndex="5" runat="server" Width="77px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 86px; HEIGHT: 6px"><asp:textbox id="txttotal" tabIndex="5" runat="server" Width="79px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 86px; HEIGHT: 6px"><asp:textbox id="txtcuota" tabIndex="5" runat="server" Width="69px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					<TD style="HEIGHT: 6px" align="center"><asp:textbox id="txtdiaatr" tabIndex="5" runat="server" Width="64px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False"></asp:textbox></TD>
				</TR>
			</TABLE>
			<asp:label id="Label30" runat="server" Width="120px" Height="15px" Font-Names="Verdana" Font-Size="8pt"></asp:label></TD>
	</TR>
	<TR>
		<TD style="BACKGROUND-COLOR: background"><asp:label id="Label19" runat="server" Width="128px" Height="15px" Font-Names="Verdana" Font-Size="X-Small"
				ForeColor="PowderBlue" Font-Bold="True">Detalle de Pago </asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 235px">
			<TABLE id="Table6" style="WIDTH: 544px; HEIGHT: 272px" cellSpacing="0" cellPadding="0"
				width="544" border="0">
				<TR>
					<TD style="WIDTH: 108px; HEIGHT: 19px"><asp:label id="Label2" runat="server" Width="112px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Deudad de Capitalización:</asp:label></TD>
					<TD style="WIDTH: 128px; HEIGHT: 19px" align="center"><asp:textbox id="txtdeucap" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px; HEIGHT: 19px" align="center"><asp:label id="Label6" runat="server" Width="104px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Monto Desemb:</asp:label></TD>
					<TD style="HEIGHT: 19px" align="left"><asp:textbox id="txtcapdes" tabIndex="5" runat="server" Width="113px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px"><asp:label id="Label3" runat="server" Width="120px" Height="15px" Font-Names="Verdana" Font-Size="8pt"># de Comprobante:</asp:label></TD>
					<TD style="WIDTH: 128px" align="center"><asp:textbox id="txtcompro" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px"><asp:label id="Label7" runat="server" Width="128px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Ultima Fecha de Pago:</asp:label></TD>
					<TD align="left"><asp:textbox id="txtdultpag" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px"><asp:label id="Label4" runat="server" Width="120px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Deuda Capital:</asp:label></TD>
					<TD style="WIDTH: 128px" align="center"><asp:textbox id="txtcapita" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px"><asp:label id="Label8" runat="server" Width="138px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Monto de Cuota:</asp:label></TD>
					<TD align="left"><asp:textbox id="txtmoncuo" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px; HEIGHT: 25px"><asp:label id="Label5" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Interés:</asp:label></TD>
					<TD style="WIDTH: 128px; HEIGHT: 25px" align="center"><asp:textbox id="txtintere2" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px; HEIGHT: 25px"><asp:label id="Label23" runat="server" Width="138px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Pago a Cuenta:</asp:label></TD>
					<TD style="HEIGHT: 25px" align="left"><asp:textbox id="txtpagcta" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px; HEIGHT: 25px"><asp:label id="Label9" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Mora:</asp:label></TD>
					<TD style="WIDTH: 128px; HEIGHT: 25px" align="center"><asp:textbox id="txtmora" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px; HEIGHT: 25px"><asp:label id="Label24" runat="server" Width="96px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Deuda Efectiva:</asp:label></TD>
					<TD style="HEIGHT: 25px" align="left"><asp:textbox id="txtdeuefe" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px; HEIGHT: 34px"><asp:label id="Label20" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Comisión:</asp:label></TD>
					<TD style="WIDTH: 128px; HEIGHT: 34px" align="center"><asp:textbox id="txtcomision" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana"
							Font-Size="8pt" BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px; HEIGHT: 34px"><asp:label id="Label34" runat="server" Width="80px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Ahorro Vista:</asp:label></TD>
					<TD style="HEIGHT: 34px" align="left"><asp:textbox id="txtahovis" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px; HEIGHT: 18px"><asp:label id="Label21" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Honorarios:</asp:label></TD>
					<TD style="WIDTH: 128px; HEIGHT: 18px" align="center"><asp:textbox id="txthonorarios" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana"
							Font-Size="8pt" BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px; HEIGHT: 18px"></TD>
					<TD style="HEIGHT: 18px" align="center"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px; HEIGHT: 26px"><asp:label id="Label22" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Gestión:</asp:label></TD>
					<TD style="WIDTH: 128px; HEIGHT: 26px" align="center"><asp:textbox id="txtgestion" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px; HEIGHT: 26px"></TD>
					<TD style="HEIGHT: 26px" align="center"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px"><asp:label id="Label35" runat="server" Width="104px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Seguro Deuda:</asp:label></TD>
					<TD style="WIDTH: 128px" align="center"><asp:textbox id="txtsegdeu" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px"><asp:label id="Label36" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Manejo:</asp:label></TD>
					<TD style="WIDTH: 128px" align="center"><asp:textbox id="txtmanejo" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px"><asp:label id="Label25" runat="server" Width="80px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Tipo de Pago:</asp:label></TD>
					<TD align="left"><asp:dropdownlist id="cmbtippag" runat="server" Width="138px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px; HEIGHT: 17px"><asp:label id="Label1" runat="server" Width="136px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Ahorro Simultáneo:</asp:label></TD>
					<TD style="WIDTH: 128px; HEIGHT: 17px" align="center"><asp:textbox id="txtahosim" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px; HEIGHT: 17px"><asp:label id="lblbanco" runat="server" Width="138px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Banco:</asp:label></TD>
					<TD style="HEIGHT: 17px" align="left"><asp:dropdownlist id="cmbbanco" runat="server" Width="138px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px"><asp:label id="Label33" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Aportaciones:</asp:label></TD>
					<TD style="WIDTH: 128px" align="center"><asp:textbox id="txtaporta" tabIndex="5" runat="server" Width="111px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px" Enabled="False">0</asp:textbox></TD>
					<TD style="WIDTH: 106px"><asp:label id="Label26" runat="server" Width="96px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Monto a Pagar:</asp:label></TD>
					<TD align="left"><asp:textbox id="txtmonpag" tabIndex="5" runat="server" Width="129px" Font-Names="Verdana" Font-Size="X-Small"
							BorderWidth="1px" BackColor="AliceBlue">0</asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 108px"></TD>
					<TD style="WIDTH: 128px" align="center"></TD>
					<TD style="WIDTH: 106px"></TD>
					<TD align="left"><asp:rangevalidator id="RangeValidator3" runat="server" Width="96px" Font-Names="Verdana" Font-Size="8pt"
							MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="txtmonpag">Valor Inválido</asp:rangevalidator></TD>
				</TR>
			</TABLE>
			<asp:label id="Label27" runat="server" Width="104px" Height="15px" Font-Names="Verdana" Font-Size="8pt"></asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 56px" align="center"><INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
				type="button" runat="server">&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<INPUT id="btngrabar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</TD>
	</TR>
</TABLE>
