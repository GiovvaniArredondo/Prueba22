<%@ control language="VB" autoeventwireup="false" inherits="controles_Contratos_WbUContratosG, App_Web_tibq4zqz" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 143px;
        height: 23px;
    }
    .style3
    {
        height: 23px;
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
						<asp:label id="Label3" runat="server" Width="400px" Font-Bold="True" 
                            Font-Size="Medium" Height="15px"
							Font-Names="Verdana" ForeColor="#16387C">PAGARE GRUPAL</asp:label></TD>
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
								<TD align="right" class="style2">
                                    <asp:label id="Label20" runat="server" 
                                        Width="120px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000" Visible="False">Prestamo Nº:</asp:label></TD>
								<TD class="style3"><asp:textbox id="txtccodcta" runat="server" Width="277px" Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Height="19px" Visible="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 143px" align="right">
                                    <asp:label id="Label26" runat="server" 
                                        Width="120px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000" Visible="False">Exportación:</asp:label></TD>
								<TD>
                                    <asp:DropDownList ID="cmbtipo" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt">
                                        <asp:ListItem>PDF</asp:ListItem>
                                        <asp:ListItem>DOC</asp:ListItem>
                                    </asp:DropDownList>
                                </TD>
							</TR>
						</TABLE>
						<asp:textbox id="txtccodcli" runat="server" Width="21px" Visible="False"></asp:textbox>
                        <asp:textbox id="txtcnomcli" runat="server" Width="338px" Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Enabled="False"></asp:textbox></TD>
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
					<TD style="HEIGHT: 20px" align="center">
                <asp:GridView ID="Grid_Grupo" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                    <Columns>            
                        <asp:BoundField DataField="ccodcli" HeaderText="Codigo Cliente">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>                                    
                        <asp:BoundField DataField="ccodcta" HeaderText="Codigo de Prestamo">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnomcli" HeaderText="Nombre del Cliente">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnudoci" HeaderText="Identificacion" >
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>                        
                        <asp:BoundField DataField="nmonapr" HeaderText="Monto Aprobado">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ninteres" HeaderText="Interes Total">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td>
                                    <asp:label id="Label22" runat="server" 
                                        Width="125px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Codigo Presidente:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtccodpresidente" runat="server" Width="200px" 
                                        Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Height="21px" Enabled="False" style="margin-bottom: 6px"></asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:label id="Label21" runat="server" 
                                        Width="125px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Presidente(a) Grupo:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtcpresidente" runat="server" Width="350px" 
                                        Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Height="21px" Enabled="False" style="margin-bottom: 6px"></asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:label id="Label23" runat="server" 
                                        Width="125px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Estado:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtcEstado" runat="server" Width="350px" 
                                        Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Height="21px" Enabled="False" style="margin-bottom: 6px"></asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:label id="Label24" runat="server" 
                                        Width="125px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Municipio:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtcMunicipio" runat="server" Width="350px" 
                                        Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Height="21px" Enabled="False" style="margin-bottom: 6px"></asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:label id="Label25" runat="server" 
                                        Width="125px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Dirección:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtcDirec" runat="server" Width="350px" 
                                        Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True" Height="21px" Enabled="False" style="margin-bottom: 6px"></asp:textbox>
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 20px" align="center">
                        &nbsp;</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 41px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                            ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Generar" Enabled="False" style="height: 29px" />
					</TD>
				</TR>
				<TR>
					<TD align="center"><asp:button id="btnExportar" runat="server" Text="Exportar Reporte" Visible="False"></asp:button></TD>
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
