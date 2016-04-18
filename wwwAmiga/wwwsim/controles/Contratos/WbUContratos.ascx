<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbUContratos.ascx.vb" Inherits="controles_Contratos_WbUContratos" %>
<style type="text/css">
    .style1
    {
        height: 26px;
    }
    .style2
    {
        width: 143px;
        height: 28px;
    }
    .style3
    {
        height: 28px;
    }
</style>
<TABLE id="Table1" style="WIDTH: 504px; HEIGHT: 303px" cellSpacing="0" cellPadding="0"
	width="504" border="0">
	<TR>
		<TD align="center"></TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table8" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 466px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 246px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="466" border="0">
				<TR>
					<TD style="HEIGHT: 33px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:label id="Label3" runat="server" Width="251px" Font-Bold="True" Font-Size="Medium" Height="15px"
							Font-Names="Verdana" ForeColor="#16387C">CONTRATOS Y PAGARES</asp:label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 22px" align="center">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" 
                            style="height: 54px; width: 100%">
							<TR>
								<TD style="WIDTH: 143px" align="right"><asp:label id="Label18" runat="server" Width="120px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Tipo de Contrato:</asp:label></TD>
								<TD><asp:dropdownlist id="cbxContrato" runat="server" Width="278px" Font-Size="8pt" 
                                        Font-Names="Verdana" Enabled="False"></asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD align="right" class="style2"><asp:label id="Label20" runat="server" 
                                        Width="120px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Prestamo Nº:</asp:label></TD>
								<TD class="style3"><asp:textbox id="txtccodcta" runat="server" Width="277px" Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Height="19px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 143px" align="right">
                                    <asp:label id="Label23" runat="server" 
                                        Width="125px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Estado:</asp:label>
                                </TD>
								<TD>
                                    <asp:textbox id="txtcEstado" runat="server" Width="350px" 
                                        Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Height="21px" Enabled="False" style="margin-bottom: 6px"></asp:textbox>
                                </TD>
							</TR>
							<TR>
								<TD style="WIDTH: 143px" align="right">
                                    <asp:label id="Label24" runat="server" 
                                        Width="125px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Municipio:</asp:label>
                                </TD>
								<TD>
                                    <asp:textbox id="txtcMunicipio" runat="server" Width="350px" 
                                        Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Height="21px" Enabled="False" style="margin-bottom: 6px"></asp:textbox>
                                </TD>
							</TR>
						</TABLE>
						<asp:textbox id="txtccodcli" runat="server" Width="21px" Visible="False"></asp:textbox><asp:textbox id="txtcnomcli" runat="server" Width="338px" Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 15px" align="center"><asp:label id="Label19" runat="server" 
                            Width="120px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000" Visible="False">Formato:</asp:label><asp:dropdownlist id="ddlTipos" runat="server" Visible="False">
							<asp:ListItem Value="4">Excel</asp:ListItem>
							<asp:ListItem Value="5" Selected="True">PDF</asp:ListItem>
							<asp:ListItem Value="2">Texto Enriquecido</asp:ListItem>
							<asp:ListItem Value="3">Word</asp:ListItem>
						</asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 20px" align="center">&nbsp;</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 41px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                            ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Generar" Enabled="False" />
					</TD>
				</TR>
				<TR>
					<TD align="center" class="style1"><asp:button id="btnExportar" runat="server" Text="Exportar Reporte" Visible="False"></asp:button></TD>
				</TR>
			</TABLE>
			<asp:TextBox ID="txtCodUsu" runat="server" Visible="False"></asp:TextBox>
			&nbsp;&nbsp;&nbsp;
		</TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
