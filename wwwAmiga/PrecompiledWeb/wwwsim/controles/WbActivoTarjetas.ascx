<%@ control language="VB" autoeventwireup="false" inherits="controles_WbActivoTarjetas, App_Web_5wr0lfuo" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 76px;
        text-align: right;
    }
    .style3
    {
        width: 229px;
    }
    .style4
    {
        width: 37px;
        text-align: right;
    }
    .style5
    {
        width: 76px;
        text-align: right;
        height: 23px;
    }
    .style6
    {
        width: 229px;
        height: 23px;
    }
    .style7
    {
        width: 37px;
        text-align: right;
        height: 23px;
    }
    .style8
    {
        height: 23px;
    }
</style>
<TABLE id="Table3" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 616px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 306px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="616" align="left" border="0">
	<TR>
		<TD style="WIDTH: 903px">
			<P align="center"><asp:label id="Label2" runat="server" Width="278px" Font-Names="Gill Sans MT" Font-Size="Medium"
					Height="15px" ForeColor="#16387C" Font-Bold="True">BUSQUEDA DE EMPLEADOS</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 904px">
			<TABLE id="Table4" style="WIDTH: 624px; HEIGHT: 64px" cellSpacing="0" cellPadding="0" width="624"
				border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 391px; HEIGHT: 41px">
							<P style="BACKGROUND-COLOR: #ffffff" align="right"><asp:label id="Label1" runat="server" Width="152px" Font-Names="Gill Sans MT" Font-Size="10pt"
									Height="11px" ForeColor="#16387C" Font-Bold="True">Nombre del Empleado:</asp:label></P>
						</TD>
						<TD style="WIDTH: 275px; HEIGHT: 41px">
							<P align="left"><asp:textbox id="TxtNombre" tabIndex="1" runat="server" Width="264px" Font-Names="Gill Sans MT" BorderWidth="1px"
									ToolTip="Digite el Nombre del Cliente"></asp:textbox></P>
						</TD>
						<TD style="WIDTH: 141px; HEIGHT: 41px">
							<P align="left">
                                <asp:Button ID="btnBuscar" 
                                    runat="server" Font-Names="Calibri" Font-Size="12pt" Text="Buscar" />
                            </P>
						</TD>
					</TR>
				</TBODY>
			</TABLE>
			<DIV style="BACKGROUND-COLOR: #ffffff; font-family: 'Gill Sans MT';" 
                align="center">
                <asp:GridView ID="gvEmpleados" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" Font-Size="X-Small" ForeColor="#333333" GridLines="None" 
                    Width="554px" Font-Names="Gill Sans MT">
                    <RowStyle BackColor="#EFF3FB" />
                    <Columns>
                        <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                        <asp:TemplateField HeaderText="Usuario" Visible="False">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("usuario") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("usuario") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Oficina" Visible="False">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ccodofi") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("ccodofi") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nombre">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("nombre") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </DIV>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 903px">
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center">&nbsp;<br />
                <asp:label id="Label6" runat="server" Width="278px" Font-Names="Gill Sans MT" Font-Size="Medium"
					Height="15px" ForeColor="#16387C" Font-Bold="True">DATOS DEL EMPLEADO</asp:label>
                <table class="style1">
                    <tr>
                        <td>
                            <table class="style1">
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label3" runat="server" Width="53px" Font-Names="Gill Sans MT" Font-Size="10pt"
									Height="16px" ForeColor="#16387C" Font-Bold="True">Nombre:</asp:label>
                                    </td>
                                    <td class="style3">
                                        <asp:textbox id="txtEmpleado" tabIndex="1" runat="server" Width="220px" 
                                            Font-Names="Gill Sans MT" BorderWidth="1px"
									ToolTip="Digite el Nombre del Cliente" Enabled="False"></asp:textbox>
                                    </td>
                                    <td class="style4">
                                        <asp:label id="Label7" runat="server" Width="50px" Font-Names="Gill Sans MT" Font-Size="10pt"
									Height="17px" ForeColor="#16387C" Font-Bold="True">Cargo</asp:label>
                                    </td>
                                    <td>
                                        <asp:textbox id="txtCargo" tabIndex="1" runat="server" Width="220px" 
                                            Font-Names="Gill Sans MT" BorderWidth="1px"
									ToolTip="Digite el Nombre del Cliente" Enabled="False"></asp:textbox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style5">
                                        <asp:label id="Label4" runat="server" Width="50px" Font-Names="Gill Sans MT" Font-Size="10pt"
									Height="17px" ForeColor="#16387C" Font-Bold="True">Oficina:</asp:label>
                                    </td>
                                    <td class="style6">
                                        <asp:textbox id="txtOficina" tabIndex="1" runat="server" Width="220px" 
                                            Font-Names="Gill Sans MT" BorderWidth="1px"
									ToolTip="Digite el Nombre del Cliente" Enabled="False"></asp:textbox>
                                    </td>
                                    <td class="style7">
                                    </td>
                                    <td class="style8">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:label id="Label5" runat="server" Width="44px" Font-Names="Gill Sans MT" Font-Size="10pt"
									Height="16px" ForeColor="#16387C" Font-Bold="True" style="margin-right: 0px" Visible="False">Usuario:</asp:label>
                                    </td>
                                    <td class="style3">
                                        <asp:textbox id="txtCodUsu" tabIndex="1" runat="server" Width="50px" 
                                            Font-Names="Gill Sans MT" BorderWidth="1px"
									ToolTip="Digite el Nombre del Cliente" Enabled="False" Visible="False"></asp:textbox>
                                    </td>
                                    <td class="style4">
                                        <asp:textbox id="txtIdUsuario" tabIndex="1" runat="server" Width="50px" 
                                            Font-Names="Gill Sans MT" BorderWidth="1px"
									ToolTip="Digite el Nombre del Cliente" Visible="False"></asp:textbox>
                                    </td>
                                    <td>
                                        <asp:textbox id="txtCodOfi" tabIndex="1" runat="server" Width="50px" 
                                            Font-Names="Gill Sans MT" BorderWidth="1px"
									ToolTip="Digite el Nombre del Cliente" Visible="False"></asp:textbox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <asp:Button ID="btnImprimir" runat="server" Height="49px" 
                    Text="Imprimir Tarjeta" Font-Names="Gill Sans MT" />
                <br />
                <br />
            </DIV>
		</TD>
	</TR>
</TABLE>
