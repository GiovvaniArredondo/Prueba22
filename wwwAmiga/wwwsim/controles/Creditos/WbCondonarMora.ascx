<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbCondonarMora.ascx.vb" Inherits="controles_Creditos_WbCondonarMora" %>
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
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 494px; HEIGHT: 330px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="494" border="0">
	<TR>
		<TD align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">CONDONAR INTERESES MORATORIOS</P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 77px" align="center">
			<TABLE id="Table2" style="WIDTH: 469px; HEIGHT: 25px" cellSpacing="0" cellPadding="0" width="469"
				border="0">
				<TR>
					<TD style="WIDTH: 52px" align="right"><asp:label id="Label4" runat="server" Width="56px" Height="15px" Font-Names="Gill Sans MT" Font-Size="10pt">Crédito:</asp:label></TD>
					<TD style="WIDTH: 102px"><asp:dropdownlist id="ddlcodins" runat="server" Width="103px" Height="16px" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 136px"><asp:dropdownlist id="ddlcodofi" runat="server" 
                            Width="169px" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"></asp:dropdownlist></TD>
					<TD style="WIDTH: 109px"><asp:textbox id="txtcnrocta" tabIndex="5" runat="server" 
                            Width="152px" Font-Names="Gill Sans MT" Font-Size="10pt"
							Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
					<TD align="center"></TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" style="WIDTH: 438px; HEIGHT: 56px" cellSpacing="0" cellPadding="0" width="438"
				border="0">
				<TR>
					<TD style="WIDTH: 139px" align="right"><asp:label id="Label9" runat="server" Width="67px" Height="15px" Font-Names="Gill Sans MT" Font-Size="10pt">Nombre:  </asp:label></TD>
					<TD style="WIDTH: 243px"><asp:textbox id="txtnomcli" runat="server" Width="232px" 
                            Font-Names="Gill Sans MT" Font-Size="10pt"
							Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
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
								<TD style="WIDTH: 109px; HEIGHT: 8px"><asp:label id="Label12" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Cuota:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 8px"><asp:textbox id="txtmoncuo" runat="server" 
                                        Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 8px"><asp:label id="Label13" runat="server" Width="96px" Font-Names="Gill Sans MT" Font-Size="10pt">Mora Capital:</asp:label></TD>
								<TD style="HEIGHT: 8px"><asp:textbox id="txtdeucap" runat="server" Width="102px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 8px"><asp:label id="Label3" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Saldo Capital:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 8px"><asp:textbox id="txtcapita" runat="server" 
                                        Width="102px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 8px"><asp:label id="Label5" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Interés:</asp:label></TD>
								<TD style="HEIGHT: 8px"><asp:textbox id="txtinteres" runat="server" Width="104px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 6px"><asp:label id="Label6" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Mora:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 6px"><asp:textbox id="txtmora" runat="server" 
                                        Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False" 
                                        BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 6px"><asp:label id="Label7" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Comisiones:</asp:label></TD>
								<TD style="HEIGHT: 6px"><asp:textbox id="txtcomisiones" runat="server" 
                                        Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 4px"><asp:label id="Label10" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Ultimo Pago:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 4px"><asp:textbox id="txtdultpag" runat="server" 
                                        Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 4px"><asp:label id="Label11" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Seguro de Deuda:</asp:label></TD>
								<TD style="HEIGHT: 4px"><asp:textbox id="txtnseguro" runat="server" Width="104px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 1px"><asp:label id="Label8" runat="server" Width="96px" Font-Names="Gill Sans MT" Font-Size="10pt" Font-Bold="True">Total a pagar:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 1px"><asp:textbox id="txttotal" runat="server" 
                                        Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 1px"><asp:label id="Label1" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Dias Atraso:</asp:label></TD>
								<TD style="HEIGHT: 1px"><asp:textbox id="txtdias" runat="server" Width="72px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False" 
                                        BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							</TABLE>
						<asp:textbox id="txtccodcli" runat="server" Width="75px" Font-Names="Gill Sans MT" Font-Size="10pt"
							Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txt30" runat="server" Width="73px" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"
							Visible="False"></asp:textbox><asp:textbox id="txt60" runat="server" Width="64px" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"
							Visible="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD align="center">
						<TABLE id="Table7" borderColor="#ff9900" cellSpacing="0" cellPadding="0" bgColor="#CCFF33"
							border="2" style="width: 50%">
							<TR>
								<TD class="style1"><asp:label id="Label17" runat="server" Width="131px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Font-Bold="True" Height="18px">Monto a Condonar:</asp:label></TD>
								<TD class="style2" align="left">
                                    <asp:textbox id="txtaldia" runat="server" 
                                        Width="102px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" style="margin-left: 6px; margin-right: 0px" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox></TD>
							</TR>
						</TABLE>
						</TD>
				</TR>
				<TR>
					<TD align="center" class="style3">
                        <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                            Text="Condonar" />
                        <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
                            ConfirmText="Seguro de Condonar?" Enabled="True" TargetControlID="Button1">
                        </cc1:ConfirmButtonExtender>
                    </TD>
				</TR>
				<TR>
					<TD align="center"><asp:textbox id="txtmon60" runat="server" Width="36px" 
                            Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" Height="16px" Visible="False"></asp:textbox>&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:textbox id="txtmon30" runat="server" Width="43px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" Height="16px" Visible="False"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
