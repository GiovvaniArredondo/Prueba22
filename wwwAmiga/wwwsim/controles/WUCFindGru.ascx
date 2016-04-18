<%@ Control Language="vb" AutoEventWireup="false" Codefile="WUCFindGru.ascx.vb" Inherits="WUCFindGru"  %>
<TABLE id="Table2" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 576px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 377px"
	cellSpacing="0" cellPadding="0" width="576" border="0" bgcolor="White">
	<TR>
		<TD style="HEIGHT: 11px">
			<P style="BACKGROUND-COLOR: white" align="center">
				<asp:label id="Label9" Font-Bold="True" ForeColor="#16387C" Height="15px" Font-Size="Medium"
					Font-Names="Verdana" Width="448px" runat="server">BUSQUEDA DE CREDITOS</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="472" border="0" style="WIDTH: 472px; HEIGHT: 147px">
				<TR>
					<TD style="WIDTH: 301px" align="right">
						<asp:radiobuttonlist id="rdbbusqueda" ForeColor="#16387C" Height="173px" 
                            Font-Size="8pt" Font-Names="Century Gothic"
							Width="170px" runat="server" RepeatColumns="1" RepeatDirection="Horizontal" BackColor="AliceBlue"
							BorderWidth="2px" BorderColor="Navy">
							<asp:ListItem Value="Por Nombre" Selected="True">Por Nombre                         </asp:ListItem>
							<asp:ListItem Value="Por C&#243;digo">Por C&#243;digo                       </asp:ListItem>
							<asp:ListItem Value="Documento &#250;nico">Cedula / D.I.P.</asp:ListItem>
						</asp:radiobuttonlist></TD>
					<TD style="WIDTH: 178px">
						<asp:radiobuttonlist id="rdbbusqueda2" ForeColor="#16387C" Height="149px" 
                            Font-Size="8pt" Font-Names="Century Gothic"
							Width="206px" runat="server" RepeatColumns="1" RepeatDirection="Horizontal" BackColor="LightSteelBlue"
							BorderWidth="2px" BorderColor="Navy">
							<asp:ListItem Value="Proceso de Solicitud">Proceso de Solicitud</asp:ListItem>
							<asp:ListItem Value="Proceso de Sugerencia">Proceso de Sugerencia</asp:ListItem>
							<asp:ListItem>Proceso de Pre-Autorizados</asp:ListItem>
							<asp:ListItem Value="Proceso de Autorización">Proceso de Autorización</asp:ListItem>
							<asp:ListItem Value="Vigentes" Selected="True">Vigentes</asp:ListItem>
							<asp:ListItem Value="Todos">Todos</asp:ListItem>
						    <asp:ListItem>Cancelados</asp:ListItem>
						</asp:radiobuttonlist></TD>
					<TD style="WIDTH: 301px">
						<asp:radiobuttonlist id="rdbbusqueda3" runat="server" Width="131px" 
                            Font-Names="Century Gothic" Font-Size="9pt"
							Height="174px" ForeColor="#16387C" BorderColor="Navy" BorderWidth="2px" BackColor="LightSkyBlue"
							RepeatDirection="Horizontal" RepeatColumns="1">
							<asp:ListItem Value="Grupo">Grupo</asp:ListItem>
						</asp:radiobuttonlist></TD>
				</TR>
			</TABLE>
			<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="536" border="0" style="WIDTH: 536px; HEIGHT: 48px">
				<TR>
					<TD style="WIDTH: 222px" align="right">
						<asp:label id="Label1" Font-Bold="True" ForeColor="#16387C" Height="11px" Font-Size="Smaller"
							Font-Names="Verdana" Width="144px" runat="server">Nombre del Grupo:</asp:label></TD>
					<TD style="WIDTH: 238px">
						<P align="left">
							<asp:textbox id="TxtNombre" tabIndex="1" Width="247px" runat="server" ToolTip="Digite el Nombre del Cliente"
								BorderWidth="1px" Font-Names="Verdana"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 80px">
						<P align="right"><INPUT id="Button1" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif);WIDTH: 56px;BACKGROUND-REPEAT: no-repeat;HEIGHT: 48px;BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center"><asp:datagrid id="dgClientes" 
                    runat="server" Width="536px" AllowSorting="True" AutoGenerateColumns="False"
					BorderColor="#000099" BorderWidth="1px" BackColor="White" CellPadding="3" 
                    BorderStyle="None" Height="121px" AllowPaging="True">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="SkyBlue"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="LightCyan" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Codigo de Grupo">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Codigo") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Codigo", URLCodigo) %>' Target="_self">
								</asp:HyperLink>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.codigo") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="cNomcli" SortExpression="cNomcli" 
                            HeaderText="Nombre del Grupo">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="ncapdes" SortExpression="ncapdes" 
                            HeaderText="Monto" DataFormatString="{0:Q###,##0.00}">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="dfecvig" SortExpression="dfecvig" HeaderText="Fecha" DataFormatString="{0:dd-MM-yyyy}">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="cestado" SortExpression="cestado" HeaderText="Estado">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Wrap="False" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
</TABLE>
