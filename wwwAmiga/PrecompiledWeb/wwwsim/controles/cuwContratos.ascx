<%@ control language="vb" autoeventwireup="false" inherits="cuwContratos, App_Web_mb_xwoah" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        height: 144px;
    }
    .style2
    {
        width: 60%;
    }
</style>
<TABLE id="Table1" style="WIDTH: 504px; HEIGHT: 303px" cellSpacing="0" cellPadding="0"
	width="504" border="0">
	<TR>
		<TD align="center"></TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table8" style="border: thin solid highlight; WIDTH: 490px; HEIGHT: 246px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" border="0">
				<TR>
					<TD style="HEIGHT: 33px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:label id="Label3" runat="server" Width="251px" Font-Bold="True" Font-Size="Medium" Height="15px"
							Font-Names="Gill Sans MT" ForeColor="#16387C">CONTRATOS Y PAGARES</asp:label></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 22px" align="center">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 143px" align="right"><asp:label id="Label18" runat="server" Width="120px" Font-Size="10pt" Font-Names="Gill Sans MT" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Tipo de Contrato:</asp:label></TD>
								<TD><asp:dropdownlist id="cbxContrato" runat="server" Width="278px" Font-Size="10pt" Font-Names="Gill Sans MT"></asp:dropdownlist></TD>
							</TR>
						</TABLE>
						<asp:textbox id="txtccodcli" runat="server" Width="21px" Visible="False"></asp:textbox><asp:textbox id="txtcnomcli" runat="server" Width="338px" Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 15px" align="center"><asp:label id="Label19" runat="server" 
                            Width="120px" Font-Size="10pt" Font-Names="Gill Sans MT" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000" Visible="False">Formato:</asp:label><asp:dropdownlist id="ddlTipos" runat="server" Visible="False">
							<asp:ListItem Value="4">Excel</asp:ListItem>
							<asp:ListItem Value="5" Selected="True">PDF</asp:ListItem>
							<asp:ListItem Value="2">Texto Enriquecido</asp:ListItem>
							<asp:ListItem Value="3">Word</asp:ListItem>
						</asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 15px" align="center">&nbsp;</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 20px" align="center">
                        <asp:CheckBox ID="chkaRuego" runat="server" BorderColor="Maroon" 
                            BorderWidth="2px" Font-Names="Gill Sans MT" Text="Datos Firma a Ruego" />
                    </TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 20px" align="center">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td align="right">
                                    <asp:label id="Label21" runat="server" Width="91px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" BorderWidth="0px"
										BorderStyle="None" Height="16px">Nombre:</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtnombre" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Height="23px" Width="291px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label22" runat="server" Width="128px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" BorderWidth="0px"
										BorderStyle="None" Height="16px">Tipo de Documento:</asp:label>
                                </td>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style2">
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" GroupName="opcion" Text="DPI" 
                                                    Width="100px" />
                                            </td>
                                            <td>
                                                <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" GroupName="opcion" Text="Cedula" Width="100px" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label26" runat="server" Width="128px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" BorderWidth="0px"
										BorderStyle="None" Height="16px">Nº de Documento:</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdocumento" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Height="23px" Width="291px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    &nbsp;</td>
                                <td>
                                    <asp:label id="Label23" runat="server" Width="91px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" BorderWidth="0px"
										BorderStyle="None" Height="16px">Extendido en:</asp:label>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label24" runat="server" Width="91px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" BorderWidth="0px"
										BorderStyle="None" Height="16px">Departamento:</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtdepartamento" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Height="23px" Width="291px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:label id="Label25" runat="server" Width="91px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" BorderWidth="0px"
										BorderStyle="None" Height="16px">Municipio:</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtmunicipio" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Height="23px" Width="291px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 41px" align="center"><INPUT id="btnaplicar2" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					</TD>
				</TR>
				<TR>
					<TD align="center"><asp:button id="btnExportar" runat="server" Text="Exportar Reporte" Visible="False"></asp:button></TD>
				</TR>
			</TABLE>
			&nbsp;&nbsp;&nbsp;
		</TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
