<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="wbsaldo" CodeFile="wbsaldo.ascx.vb" %>
<style type="text/css">
    .style1
    {
        width: 109px;
        height: 21px;
    }
    .style2
    {
        width: 117px;
        height: 21px;
    }
    .style3
    {
        width: 197px;
        height: 21px;
    }
    .style4
    {
        height: 21px;
    }
    .style5
    {
        width: 109px;
        height: 19px;
    }
    .style6
    {
        width: 117px;
        height: 19px;
    }
    .style7
    {
        width: 197px;
        height: 19px;
    }
    .style8
    {
        height: 19px;
    }
    .style9
    {
        width: 109px;
        height: 15px;
    }
    .style10
    {
        width: 117px;
        height: 15px;
    }
    .style11
    {
        width: 197px;
        height: 15px;
    }
    .style12
    {
        height: 15px;
    }
    .style13
    {
        width: 109px;
        height: 26px;
    }
    .style14
    {
        width: 117px;
        height: 26px;
    }
    .style15
    {
        width: 197px;
        height: 26px;
    }
    .style16
    {
        height: 26px;
    }
    .style17
    {
        width: 109px;
        height: 7px;
    }
    .style18
    {
        width: 117px;
        height: 7px;
    }
    .style19
    {
        width: 197px;
        height: 7px;
    }
    .style20
    {
        height: 7px;
    }
</style>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 494px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 547px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="494" border="0">
	<TR>
		<TD align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">SALDO A UNA FECHA</P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 77px" align="center">
			<TABLE id="Table2" style="WIDTH: 469px; HEIGHT: 25px" cellSpacing="0" cellPadding="0" width="469"
				border="0">
				<TR>
					<TD style="WIDTH: 52px" align="right"><asp:label id="Label4" runat="server" Width="56px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Crédito:</asp:label></TD>
					<TD style="WIDTH: 102px"><asp:dropdownlist id="ddlcodins" runat="server" Width="103px" Height="16px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 136px"><asp:dropdownlist id="ddlcodofi" runat="server" Width="169px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 109px"><asp:textbox id="txtcnrocta" tabIndex="5" runat="server" 
                            Width="152px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" BorderColor="#2E6A99" BorderWidth="1px" Height="22px"></asp:textbox></TD>
					<TD align="center"></TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" style="WIDTH: 438px; HEIGHT: 56px" cellSpacing="0" cellPadding="0" width="438"
				border="0">
				<TR>
					<TD style="WIDTH: 139px" align="right"><asp:label id="Label9" runat="server" Width="67px" Height="15px" Font-Names="Verdana" Font-Size="8pt">Nombre:  </asp:label></TD>
					<TD style="WIDTH: 243px"><asp:textbox id="txtnomcli" runat="server" Width="232px" 
                            Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" BorderColor="#2E6A99" BorderWidth="1px" Height="25px"></asp:textbox></TD>
					<TD>
						<P align="center"><INPUT id="btnprocesar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
								type="button" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 162px" align="center"><asp:label id="Label2" runat="server" Width="146px" Font-Names="Verdana" Font-Size="8pt" Font-Bold="True">Fecha a Procesar:</asp:label><asp:calendar id="calfecval" runat="server" Width="294px" Height="112px" Font-Names="Verdana"
				Font-Size="8pt" BackColor="#FFFFCC" ForeColor="#663399" BorderWidth="1px" DayNameFormat="FirstLetter" BorderColor="#FFCC66" ShowGridLines="True">
				<TodayDayStyle ForeColor="White" BackColor="#FFCC66"></TodayDayStyle>
				<SelectorStyle BackColor="#FFCC66"></SelectorStyle>
				<NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC"></NextPrevStyle>
				<DayHeaderStyle Height="1px" BackColor="#FFCC66"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" BackColor="#CCCCFF"></SelectedDayStyle>
				<TitleStyle Font-Size="9pt" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#CC9966"></OtherMonthDayStyle>
			</asp:calendar></TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table4" style="WIDTH: 440px; HEIGHT: 252px" cellSpacing="0" cellPadding="0"
				width="440" align="center" border="0">
				<TR>
					<TD style="HEIGHT: 127px" align="center">
						<TABLE id="Table6" style="WIDTH: 439px; HEIGHT: 120px" cellSpacing="0" cellPadding="0"
							width="439" align="center" border="0">
							<TR>
								<TD class="style1"><asp:label id="Label12" runat="server" Font-Names="Verdana" Font-Size="8pt">Cuota:</asp:label></TD>
								<TD class="style2"><asp:textbox id="txtmoncuo" runat="server" Width="100px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD class="style3"><asp:label id="Label13" runat="server" Width="96px" Font-Names="Verdana" Font-Size="8pt">Deuda Capital:</asp:label></TD>
								<TD class="style4"><asp:textbox id="txtdeucap" runat="server" Width="100px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD class="style5"><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt">Saldo Capital:</asp:label></TD>
								<TD class="style6"><asp:textbox id="txtcapita" runat="server" Width="100px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD class="style7"><asp:label id="Label5" runat="server" Font-Names="Verdana" Font-Size="8pt">Interés:</asp:label></TD>
								<TD class="style8"><asp:textbox id="txtinteres" runat="server" Width="100px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD class="style13"><asp:label id="Label6" runat="server" Font-Names="Verdana" Font-Size="8pt">Mora:</asp:label></TD>
								<TD class="style14"><asp:textbox id="txtmora" runat="server" Width="100px" 
                                        Font-Names="Verdana" Font-Size="8pt" Enabled="False" BorderColor="#2E6A99" 
                                        BorderWidth="1px"></asp:textbox></TD>
								<TD class="style15"><asp:label id="Label7" runat="server" Font-Names="Verdana" Font-Size="8pt">Comisiones:</asp:label></TD>
								<TD class="style16"><asp:textbox id="txtcomisiones" runat="server" Width="100px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD class="style9"><asp:label id="Label10" runat="server" Font-Names="Verdana" Font-Size="8pt">Ultimo Pago:</asp:label></TD>
								<TD class="style10"><asp:textbox id="txtdultpag" runat="server" Width="100px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD class="style11"><asp:label id="Label11" runat="server" Font-Names="Verdana" Font-Size="8pt">Seguro de Deuda:</asp:label></TD>
								<TD class="style12"><asp:textbox id="txtnseguro" runat="server" Width="100px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD class="style17"></TD>
								<TD class="style18"></TD>
								<TD class="style19"><asp:label id="Label18" runat="server" 
                                        Font-Names="Verdana" Font-Size="8pt">IVA:</asp:label></TD>
								<TD class="style20">
                                    <asp:textbox id="txtiva" 
                            tabIndex="5" Font-Size="8pt" Font-Names="Verdana" Width="100px" runat="server"
							BorderWidth="1px" Enabled="False" BorderColor="#2E6A99">0</asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 1px"><asp:label id="Label8" runat="server" Width="96px" Font-Names="Verdana" Font-Size="8pt" Font-Bold="True">Total a pagar:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 1px"><asp:textbox id="txttotal" runat="server" 
                                        Width="100px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 1px"><asp:label id="Label1" runat="server" Font-Names="Verdana" Font-Size="8pt">Dias Atraso:</asp:label></TD>
								<TD style="HEIGHT: 1px"><asp:textbox id="txtdias" runat="server" Width="100px" 
                                        Font-Names="Verdana" Font-Size="8pt" Enabled="False" BorderColor="#2E6A99" 
                                        BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 3px"></TD>
								<TD style="WIDTH: 117px; HEIGHT: 3px"></TD>
								<TD style="WIDTH: 198px; HEIGHT: 3px"></TD>
								<TD style="HEIGHT: 3px"></TD>
							</TR>
						</TABLE>
						<TABLE id="Table7" borderColor="#ff9900" cellSpacing="0" cellPadding="0" width="100%" bgColor="#ffff99"
							border="2">
							<TR>
								<TD style="WIDTH: 148px"><asp:label id="Label17" runat="server" Width="72px" Font-Names="Verdana" Font-Size="8pt" Font-Bold="True">A PAGAR:</asp:label></TD>
								<TD style="WIDTH: 57px"><asp:label id="Label16" runat="server" Width="48px" Height="16px" Font-Names="Verdana" Font-Size="8pt">Al Día:</asp:label></TD>
								<TD style="WIDTH: 44px"><asp:label id="Label14" runat="server" Width="64px" Height="16px" Font-Names="Verdana" Font-Size="8pt">1-30 días:</asp:label></TD>
								<TD style="WIDTH: 56px"><asp:label id="Label15" runat="server" Width="72px" Height="16px" Font-Names="Verdana" Font-Size="8pt">31-60 días:</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 148px"></TD>
								<TD style="WIDTH: 57px"><asp:textbox id="txtaldia" runat="server" Width="102px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD style="WIDTH: 44px"><asp:textbox id="txtmon30" runat="server" Width="102px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD style="WIDTH: 56px"><asp:textbox id="txtmon60" runat="server" Width="102px" 
                                        Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
						</TABLE>
						<asp:textbox id="txtccodcli" runat="server" Width="75px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txt30" runat="server" Width="73px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
							Visible="False"></asp:textbox><asp:textbox id="txt60" runat="server" Width="64px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
							Visible="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD align="center"><INPUT id="btncancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp; <INPUT id="btnimprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(imagenes/Wzprint.bmp); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
