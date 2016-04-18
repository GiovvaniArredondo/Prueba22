<%@ control language="vb" autoeventwireup="false" inherits="WbFindActivoF, App_Web_mb_xwoah" %>
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
</style>

<TABLE id="Table2" style="border: thin solid highlight; WIDTH: 659px; HEIGHT: 377px"
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
						&nbsp;</TD>
					<TD style="WIDTH: 238px">
						<P align="left">
							&nbsp;</P>
					</TD>
					<TD style="WIDTH: 80px">
						<P align="right" style="width: 462px">
						<asp:label id="Label1" Font-Bold="True" ForeColor="#16387C" Height="16px" Font-Size="Smaller"
							Font-Names="Verdana" Width="144px" runat="server">Ingrese el dato a Buscar:</asp:label>
							<asp:textbox id="TxtNombre" tabIndex="1" Width="247px" runat="server" ToolTip="Digite el Nombre del Cliente"
								BorderWidth="1px" Font-Names="Verdana"></asp:textbox>
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                        </P>
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
				</asp:datagrid></DIV>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>


