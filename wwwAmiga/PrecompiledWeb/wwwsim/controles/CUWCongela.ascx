<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="CUWCongela, App_Web_v6ddqlgy" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<style type="text/css">
    .style1
    {
        width: 226px;
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
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">CONGELAR INTERESES</P>
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
					<TD align="center">
						&nbsp;</TD>
				</TR>
				<TR>
					<TD align="center" class="style3">
						<TABLE id="Table7" borderColor="#ff9900" cellSpacing="0" cellPadding="0"
							border="0" style="width: 67%" class="CSSTableGenerator">
							<TR>
								<TD class="style1">&nbsp;</TD>
								<TD class="style2" align="left">&nbsp;</TD>
							</TR>
							<TR>
								<TD class="style1">
                                    <asp:label id="Label17" runat="server" Width="165px" 
                                        Font-Names="Verdana" Font-Size="8pt" Font-Bold="True" Height="18px">Intereses a Congelar:</asp:label></TD>
								<TD class="style2" align="left"><asp:textbox id="txtaldia" runat="server" 
                                        Width="102px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" style="margin-left: 6px; margin-right: 0px"></asp:textbox>
						<asp:rangevalidator id="RangeValidator3" runat="server" Width="96px" Font-Names="Verdana" Font-Size="8pt"
							MaximumValue="1000000000" MinimumValue="1" Type="Double" ErrorMessage="RangeValidator" 
                                        ControlToValidate="txtaldia">Monto Invalido</asp:rangevalidator>
						        </TD>
							</TR>
						</TABLE>
                    </TD>
				</TR>
				<TR>
					<TD align="center" class="style3">
                        <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Congelar" />
                        <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
                            ConfirmText="Seguro de Congelar?" Enabled="True" TargetControlID="Button1">
                        </cc1:ConfirmButtonExtender>
                    </TD>
				</TR>
				<TR>
					<TD align="center">
						<asp:textbox id="txtccodcli" runat="server" Width="75px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtmon60" runat="server" Width="36px" 
                            Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Height="16px" Visible="False"></asp:textbox>&nbsp;&nbsp;&nbsp;&nbsp; 
                        <asp:textbox id="txtmon30" runat="server" Width="43px" Font-Names="Verdana" Font-Size="8pt"
										Enabled="False" Height="16px" Visible="False"></asp:textbox><asp:textbox id="txt30" runat="server" Width="73px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
							Visible="False"></asp:textbox><asp:textbox id="txt60" runat="server" Width="64px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
							Visible="False"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
