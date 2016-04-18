<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbActivoTraslados.ascx.vb" Inherits="controles_WbActivoTraslados" %>
<style type="text/css">

    .style1
    {
        height: 11px;
        width: 641px;
    }
    .style2
    {
        width: 641px;
    }
    .style5
    {
        width: 100%;
    }
    .style3
    {
        width: 110px;
        }
    .style8
    {
        height: 18px;
    }
    .style15
    {
        width: 137px;
        height: 9px;
    }
    .style16
    {
        width: 159px;
        height: 9px;
    }
    .style17
    {
        width: 110px;
        height: 9px;
    }
    .style18
    {
        width: 69px;
        height: 9px;
    }
    .style21
    {
        width: 137px;
        height: 28px;
    }
    .style22
    {
        height: 28px;
        text-align: left;
    }
    .style23
    {
        width: 69px;
        height: 28px;
    }
    .style24
    {
        width: 137px;
        height: 27px;
    }
    .style25
    {
        height: 27px;
    }
    .style26
    {
        width: 69px;
        height: 27px;
    }
    .style28
    {
        width: 159px;
        height: 27px;
    }
    .style29
    {
        width: 110px;
        height: 27px;
    }
    .style30
    {
        height: 29px;
    }
    .style32
    {
        width: 69px;
    }
</style>

<TABLE id="Table2" style="border: thin solid highlight; WIDTH: 694px; HEIGHT: 377px"
	cellSpacing="0" cellPadding="0" border="0" bgcolor="White">
	<TR>
		<TD class="style1">
			<P style="BACKGROUND-COLOR: white" align="center">
				<asp:label id="Label9" Font-Bold="True" ForeColor="#16387C" Height="15px" Font-Size="Medium"
					Font-Names="Verdana" Width="448px" runat="server">BUSQUEDA DE ACTIVO</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD align="center" class="style2">
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="472" border="0" 
                style="WIDTH: 472px; HEIGHT: 74px">
				<TR>
					<TD style="WIDTH: 301px" align="right">
						&nbsp;</TD>
					<TD style="WIDTH: 178px; text-align: center;">
						<asp:radiobuttonlist id="rdbbusqueda" ForeColor="#16387C" Height="65px" 
                            Font-Size="8pt" Font-Names="Century Gothic"
							Width="346px" runat="server" RepeatColumns="1" RepeatDirection="Horizontal" BackColor="AliceBlue"
							BorderWidth="2px" BorderColor="Navy">
							<asp:ListItem Value="Por Descripcion    " Selected="True">Por Descripcion                         </asp:ListItem>
							<asp:ListItem Value="Por No. Inventario">Por No. Inventario</asp:ListItem>
						    <asp:ListItem>No. Factura</asp:ListItem>
                            <asp:ListItem>Por Fecha</asp:ListItem>
						</asp:radiobuttonlist></TD>
					<TD style="WIDTH: 301px">
						&nbsp;</TD>
				</TR>
			</TABLE>
			<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="536" border="0" style="WIDTH: 536px; HEIGHT: 48px">
				<TR>
					<TD style="WIDTH: 222px" align="right">
						<asp:label id="Label1" Font-Bold="True" ForeColor="#16387C" Height="11px" Font-Size="Smaller"
							Font-Names="Verdana" Width="144px" runat="server">Ingrese el dato a Buscar:</asp:label></TD>
					<TD style="WIDTH: 238px">
						<P align="left">
							<asp:textbox id="TxtNombre" tabIndex="1" Width="247px" runat="server" ToolTip="Digite el Nombre del Cliente"
								BorderWidth="1px" Font-Names="Verdana"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 80px">
						<P align="right">
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                        </P>
					</TD>
				</TR>
			</TABLE>
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center">
                <asp:datagrid id="dgActivos" 
                    runat="server" Width="536px" AllowSorting="True" AutoGenerateColumns="False"
					BorderColor="#000099" BorderWidth="1px" BackColor="White" CellPadding="3" 
                    BorderStyle="None" Height="121px" AllowPaging="True">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="SkyBlue"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="#FFFF66" />
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="LightCyan" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Inventario" SortExpression="ccodinv">
							<ItemTemplate>
                                <ItemTemplate>
                                    <asp:HyperLink ID="HyperLink1" runat="server" 
                                        NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.ccodinv", URLCodigo) %>' 
                                        Target="_self" Text='<%# DataBinder.Eval(Container, "DataItem.Ccodinv") %>'>
                                    </asp:HyperLink>
                                </ItemTemplate>
                            </ItemTemplate>
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.codigo") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="cnumcom" SortExpression="cnumcom" 
                            HeaderText="Partida">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="cnumdoc" SortExpression="cnumdoc" 
                            HeaderText="Factura">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="dfecadq" SortExpression="dfecadq" 
                            HeaderText="Fecha Compra" DataFormatString="{0:dd-MM-yyyy}">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="cdesbien" SortExpression="cdesbien" 
                            HeaderText="Descripcion">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Wrap="False" Mode="NumericPages"></PagerStyle>
				</asp:datagrid>
                <br />
                <asp:Panel ID="Panel1" runat="server" Height="197px" Width="651px">
                    <TABLE id="Table8" style="BORDER-RIGHT: royalblue thin solid; BORDER-TOP: royalblue thin solid; BORDER-LEFT: royalblue thin solid; WIDTH: 650px; BORDER-BOTTOM: royalblue thin solid; HEIGHT: 184px"
						cellSpacing="0" cellPadding="0" width="650" border="0">
                        <TR>
							<TD style="HEIGHT: 15px" align="right" colspan="5">
                                <table class="style5">
                                    <tr>
                                        <td bgcolor="#0066FF">
                                            <asp:Label ID="Label58" runat="server" BackColor="#3366FF" Font-Bold="True" 
                                                Font-Names="Calibri" Font-Size="12pt" ForeColor="White" 
                                                Text="Datos del Activo:" Width="600px"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
						</TR>
                        <TR>
							<TD style="WIDTH: 137px; HEIGHT: 15px" align="right">
                                <asp:label id="Label63" Font-Size="8pt" Width="105px" 
                                    Font-Names="Century Gothic" runat="server">Codigo de 
                                Activo Generado:</asp:label></TD>
							<TD style="WIDTH: 159px; HEIGHT: 15px">
                                <asp:textbox id="txtInventario" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server"
									Enabled="False"></asp:textbox></TD>
							<TD style="WIDTH: 110px; HEIGHT: 15px" align="right" colspan="2">&#160;</TD>
							<TD style="WIDTH: 69px; HEIGHT: 15px">
                                &#160;</TD>
						</TR>
                        <TR>
							<TD align="right" class="style21">
                                <asp:label id="Label14" Height="8px" Font-Size="8pt" Width="84px" Font-Names="Century Gothic"
									runat="server">Oficina:</asp:label></TD>
							<TD colspan="3" class="style22">
                                <asp:TextBox ID="txtOficina" runat="server" Enabled="False" 
                            Font-Names="Century Gothic" Font-Size="8pt" Width="280px"></asp:TextBox></TD>
							<TD class="style23">&#160;</TD>
						</TR>
                        <tr><td align="right" class="style24"><asp:Label 
                            ID="Label66" runat="server" Font-Names="Century Gothic" Font-Size="8pt" 
                            Height="8px" Width="84px">Responsable:</asp:Label></td><td colspan="3" 
                                class="style25"><asp:TextBox ID="txtEmpleado1" runat="server" 
                            Enabled="False" Font-Names="Century Gothic" Font-Size="8pt" Width="280px"></asp:TextBox></td>
                            <td class="style26"></td></tr>
                        <TR>
							<TD align="right" class="style15">
                                <asp:Label ID="Label19" runat="server" Font-Names="Century Gothic" 
                            Font-Size="8pt" Height="8px" Width="84px">No. Factura:</asp:Label></TD>
							<TD class="style16">
                                <asp:TextBox ID="txtFactura" runat="server" Enabled="False" 
                            Font-Names="Century Gothic" Font-Size="8pt" Width="171px"></asp:TextBox></TD>
							<TD align="right" class="style17" colspan="2">
                                <asp:Label ID="Label3" runat="server" Font-Names="Century Gothic" 
                            Font-Size="8pt">Valor del Bien:</asp:Label></TD>
							<TD class="style18">
                                <asp:TextBox ID="txtValorBien" runat="server" Enabled="False" 
                            Font-Names="Century Gothic" Font-Size="8pt" Width="171px"></asp:TextBox></TD>
						</TR>
                        <TR>
							<TD align="right" class="style2">
                                <asp:Label ID="Label22" runat="server" Font-Names="Century Gothic" 
                            Font-Size="8pt" Height="8px" Width="80px">Activo Drepreciable:</asp:Label></TD>
							<TD class="style2">
                                <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" 
                            Enabled="False" Font-Names="Century Gothic" Font-Size="8pt" Text="Si" />
                            </TD>
							<TD align="right" class="style3" colspan="2">
                                </TD>
							<TD class="style32">
                                </TD>
						</TR>
                        <TR>
							<TD align="right" class="style24">
                                                <asp:Label ID="Label24" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Width="105px">No. Serie:</asp:Label>
                                            </TD>
							<TD class="style28">
                                                <asp:TextBox ID="txtSeri" runat="server" 
                            Enabled="False" Font-Names="Century Gothic" Font-Size="8pt" Width="171px"></asp:TextBox>
                            </TD>
							<TD align="right" colspan="2" class="style29">
                                                <asp:Label ID="Label25" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="8px" Width="84px">Modelo:</asp:Label>
                                            </TD>
							<TD class="style26">
                                                <asp:TextBox ID="txtModelo" runat="server" 
                            Enabled="False" Font-Names="Century Gothic" Font-Size="8pt" Width="171px"></asp:TextBox>
                                            </TD>
						</TR>
                        <TR>
							<TD align="right" class="style24">
                                                <asp:Label ID="Label49" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Width="105px">Marca:</asp:Label>
                                            </TD>
							<TD class="style28">
                                                <asp:TextBox ID="txtMarca" runat="server" 
                            Enabled="False" Font-Names="Century Gothic" Font-Size="8pt" Width="171px"></asp:TextBox>
                                            </TD>
							<TD align="right" colspan="2" class="style29">
                                                <asp:Label ID="Label50" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" style="margin-bottom: 0px" 
                            Width="105px">Tipo:</asp:Label>
                                            </TD>
							<TD class="style26">
                                                <asp:TextBox ID="txtTipo" runat="server" 
                            Enabled="False" Font-Names="Century Gothic" Font-Size="8pt" Width="171px"></asp:TextBox>
                                            </TD>
						</TR>
                        <TR>
							<TD style="WIDTH: 137px" align="right">
                                                <asp:Label ID="Label61" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Width="105px">Otras 
                                                Especificaciones:</asp:Label>
                                            </TD>
							<TD colspan="4">
                                                <asp:TextBox ID="txtDetalle" runat="server" 
                            Enabled="False" Font-Names="Century Gothic" Font-Size="8pt" Height="48px" 
                            TextMode="MultiLine" Width="475px"></asp:TextBox>
                                            </TD>
						</TR>
                        <TR>
							<TD align="right" colspan="5">
                                                &#160;</TD>
						</TR>
                        <TR>
							<TD align="right" class="style8" colspan="5">
                                <table class="style5">
                                    <tr>
                                        <td bgcolor="#0066FF">
                                            <asp:Label ID="Label48" runat="server" BackColor="#3366FF" Font-Bold="True" 
                                                Font-Names="Calibri" Font-Size="12pt" ForeColor="White" 
                                                Text="Sección de Traslado:" Width="600px"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
						</TR>
                        <tr>
							
							<td align="right" class="style30">
                            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label68" runat="server" Font-Names="Century Gothic" 
                                Font-Size="8pt" Height="8px" Width="84px">Agencia:</asp:Label>
                            </td>
                            
							<td class="style30" colspan="2">
                            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="cmbOficinas" runat="server" AutoPostBack="True" 
                                Enabled="False" Font-Names="Century Gothic" Font-Size="8pt" Width="280px">
                            </asp:DropDownList>
                            </td>
                            
							<td class="style30" colspan="2">
                                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtCcodOfi" runat="server" Font-Names="Century Gothic" 
                                    Font-Size="8pt" Visible="False" Width="38px"></asp:TextBox>
                            </td>
                            
						</tr>
                        <TR><TD align="right" class="style30">
                            <asp:Label ID="Label20" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="8px" Width="84px">Empleado:</asp:Label></TD>
                            <td class="style30" colspan="2">
                                <asp:DropDownList ID="cmbUsuarios" runat="server" AutoPostBack="True" 
                            Enabled="False" Font-Names="Century Gothic" Font-Size="8pt" Width="280px">
                                </asp:DropDownList>
                        </td><td class="style30" colspan="2">
                        <asp:TextBox ID="txtcodEmp" runat="server" Enabled="False" 
                            Font-Names="Century Gothic" Font-Size="8pt" Visible="False" Width="67px">
                        </asp:TextBox>
                        <asp:TextBox ID="txtOperador" runat="server" Enabled="False" 
                            Font-Names="Century Gothic" Font-Size="8pt" Visible="False" Width="67px">
                        </asp:TextBox>
                        </td></TR>
                        <tr>
							<td align="right" class="style22">
                            
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
							<td class="style22" colspan="3">
                            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                            &nbsp;<asp:Label ID="label_mensaje" runat="server" BackColor="Transparent" 
                                    Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="318px"></asp:Label>
                            </td>
							<td class="style23">
                            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </td>
                            
						</tr>
                        <tr>
                            <td align="right" class="style8" colspan="5">
                                <table ID="Table3" align="center" border="0" cellpadding="0" cellspacing="0" 
                                    style="WIDTH: 453px; HEIGHT: 25px" width="453">
                                    <tr>
                                        <td align="center" style="WIDTH: 256px">
                                            <asp:Button ID="btnDescargar" runat="server" Enabled="False" Height="30px" 
                                                Text="Descargar" Width="78px" />
                                        </td>
                                        <td align="center" style="WIDTH: 256px">
                                            <asp:Button ID="btnTrasladar" runat="server" Enabled="False" Height="30px" 
                                                Text="Trasladar" Width="78px" />
                                            <br />
                                        </td>
                                        <td align="center" style="WIDTH: 256px">
                                            <asp:Button ID="btnBoleta" runat="server" Enabled="False" Height="30px" 
                                                Text="Boleta" Width="78px" />
                                        </td>
                                        <td align="center" style="WIDTH: 165px">
                                            <asp:Button ID="btnGraba" runat="server" Enabled="False" Height="30px" 
                                                Text="Grabar" Visible="False" Width="78px" />
                                        </td>
                                        <td style="margin-left: 40px">
                                            <asp:TextBox ID="TextBox7" runat="server" Font-Names="Century Gothic" 
                                                Font-Size="8pt" Visible="False" Width="38px"></asp:TextBox>
                                            <asp:TextBox ID="txtIdUsuario" runat="server" Font-Names="Century Gothic" 
                                                Font-Size="8pt" Visible="False" Width="38px"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </TABLE>
                </asp:Panel>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </DIV>
		</TD>
	</TR>
</TABLE>


