<%@ Control Language="vb" AutoEventWireup="false" CodeFile="WbActivoRp.ascx.vb" Inherits="WbActivoRp"   %>
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnprint_onclick() {

}

// ]]>
</script>

<P></P>
<P></P>
<P></P>
<P>
	<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 536px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 272px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="536" align="left" border="0">
		<TR>
			<TD style="HEIGHT: 20px">
				<P class="PageTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
					align="center">IMPRESION&nbsp;DE ACTIVOS
					<TABLE id="Table2" style="BORDER-RIGHT: royalblue thin solid; BORDER-TOP: royalblue thin solid; BORDER-LEFT: royalblue thin solid; WIDTH: 453px; BORDER-BOTTOM: royalblue thin solid; HEIGHT: 121px"
						borderColor="#003399" cellSpacing="0" cellPadding="0" width="453" bgColor="#ffff99"
						border="2">
						<TR>
							<TD style="WIDTH: 168px; HEIGHT: 18px" align="right"><asp:label id="Label9" runat="server" Font-Names="Century Gothic" Width="65px" Font-Size="8pt"
									ForeColor="#0000C0" Font-Bold="True">Exportar a:</asp:label></TD>
							<TD style="WIDTH: 198px; HEIGHT: 18px"><asp:dropdownlist id="ddlexportar" runat="server" Font-Names="Century Gothic" Width="201px" Font-Size="8pt"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 18px" align="right"></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 168px; HEIGHT: 18px" align="right"><asp:label id="Label1" runat="server" Font-Names="Century Gothic" Width="32px" Font-Size="8pt"
									Height="8px" ForeColor="#0000C0" Font-Bold="True">Fecha:</asp:label></TD>
							<TD style="WIDTH: 198px; HEIGHT: 18px"><asp:textbox id="TxtDate2" runat="server" Font-Names="Century Gothic" Width="117px" Font-Size="8pt"></asp:textbox></TD>
							<TD style="WIDTH: 110px; HEIGHT: 18px" align="right"><asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
									ControlToValidate="TxtDate2" MinimumValue="01/01/2000" MaximumValue="01/01/3000" Type="Date">Fecha Inválida-</asp:rangevalidator></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 168px; HEIGHT: 15px" align="right"><asp:label id="Label14" runat="server" Font-Names="Century Gothic" Width="32px" Font-Size="8pt"
									Height="8px" ForeColor="#0000C0" Font-Bold="True">Oficina:</asp:label></TD>
							<TD style="WIDTH: 198px; HEIGHT: 15px"><asp:dropdownlist id="ddloficinas" runat="server" Font-Names="Century Gothic" Width="205px" Font-Size="8pt"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 15px" align="center">
                                <asp:checkbox id="chqoficinas" runat="server" Font-Names="Century Gothic" 
                                    Width="51px" Font-Size="8pt"
									Text="Todos" Checked="True"></asp:checkbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 168px; HEIGHT: 15px" align="right"><asp:label id="Label15" 
                                    runat="server" Font-Names="Century Gothic" Width="32px" Font-Size="8pt"
									Height="8px" ForeColor="#0000C0" Font-Bold="True">Fondo:</asp:label></TD>
							<TD style="WIDTH: 198px; HEIGHT: 15px"><asp:dropdownlist id="ddlfondos" 
                                    runat="server" Font-Names="Century Gothic" Width="205px" Font-Size="8pt"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 15px" align="center">
                                <asp:checkbox id="chqfondos" 
                                    runat="server" Font-Names="Century Gothic" Width="51px" Font-Size="8pt"
									Text="Todos" Checked="True"></asp:checkbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 168px; HEIGHT: 15px" align="right">
                                <asp:label id="Label16" 
                                    runat="server" Font-Names="Century Gothic" Width="150px" Font-Size="8pt"
									Height="8px" ForeColor="#0000C0" Font-Bold="True">Activo Depreciable:</asp:label></TD>
							<TD style="WIDTH: 198px; HEIGHT: 15px">
                                <asp:dropdownlist id="ddldepreciable" 
                                    runat="server" Font-Names="Century Gothic" Width="205px" Font-Size="8pt">
                                    <asp:ListItem>Si</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                </asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 15px" align="center">
                                <asp:checkbox id="chqdepcon" 
                                    runat="server" Font-Names="Century Gothic" Width="55px" Font-Size="8pt"
									Text="Todos" Checked="True"></asp:checkbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 168px; HEIGHT: 18px" align="right"><asp:label id="Label8" runat="server" Font-Names="Century Gothic" Width="93px" Font-Size="8pt"
									ForeColor="#0000C0" Font-Bold="True"> Tipo de Activo:</asp:label></TD>
							<TD style="WIDTH: 198px; HEIGHT: 18px"><asp:dropdownlist id="ddltipo" runat="server" Font-Names="Century Gothic" Width="205px" Font-Size="8pt"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 18px" align="center"><asp:checkbox id="chqtipo" runat="server" Font-Names="Century Gothic" Font-Size="8pt" Text="Todos"
									Checked="True"></asp:checkbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 168px; HEIGHT: 18px" align="right"><asp:label id="Label2" runat="server" Font-Names="Century Gothic" Width="93px" Font-Size="8pt"
									ForeColor="#0000C0" Font-Bold="True"> Clasificación de Activo:</asp:label></TD>
							<TD style="WIDTH: 198px; HEIGHT: 18px"><asp:dropdownlist id="ddlClasActivo" runat="server" Font-Names="Century Gothic" Width="205px" Font-Size="8pt"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 18px" align="center"><asp:checkbox id="chqclasactivo" runat="server" Font-Names="Century Gothic" Font-Size="8pt" Text="Todos"
									Checked="True"></asp:checkbox></TD>
						</TR>
					</TABLE>
					<TABLE id="Table3" style="WIDTH: 453px; HEIGHT: 89px" cellSpacing="0" cellPadding="0" width="453"
						align="center" border="0">
						<TR>
							<TD style="WIDTH: 165px" align="center">
								<TABLE id="Table4" style="WIDTH: 455px; HEIGHT: 68px" cellSpacing="0" cellPadding="0" width="455"
									border="0">
									<TR>
										<TD align="center">
                                            <asp:Button ID="btnImprimir" runat="server" Height="57px" Text="Imprimir" 
                                                Width="81px" />
                                        </TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
					</TABLE>
				</P>
			</TD>
		</TR>
	</TABLE>
</P>
<P>&nbsp;</P>
