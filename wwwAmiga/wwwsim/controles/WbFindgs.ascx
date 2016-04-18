<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbFindgs.ascx.vb" Inherits="WbFindgs"  %>
<TABLE id="Table3" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 616px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 306px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="616" align="left" border="0">
	<TR>
		<TD style="WIDTH: 903px">
			<P align="center"><asp:label id="Label2" runat="server" Width="549px" 
                    Font-Names="Verdana" Font-Size="Medium"
					Height="15px" ForeColor="#16387C" Font-Bold="True">BUSQUEDA DE CLIENTES POR 
                GRUPO SOLIDARIO</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 904px">
			<TABLE id="Table4" style="WIDTH: 624px; HEIGHT: 64px" cellSpacing="0" cellPadding="0" width="624"
				border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 391px; HEIGHT: 41px">
							<P style="BACKGROUND-COLOR: #ffffff" align="right"><asp:label id="Label1" 
                                    runat="server" Width="177px" Font-Names="Verdana" Font-Size="Smaller"
									Height="16px" ForeColor="#16387C" Font-Bold="True">Nombre del Grupo 
                                Solidario</asp:label></P>
						</TD>
						<TD style="WIDTH: 275px; HEIGHT: 41px">
							<P align="left">
                                <asp:DropDownList ID="cbxcentros" runat="server" AutoPostBack="True" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="240px" 
                                BackColor="#FFFF99">
                        </asp:DropDownList>
						    </P>
						</TD>
						<TD style="WIDTH: 141px; HEIGHT: 41px">
							<P align="left"><INPUT id="Button1" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 57px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 51px; BACKGROUND-COLOR: transparent"
									type="button" name="Button1" runat="server"></P>
						</TD>
					</TR>
				</TBODY>
			</TABLE>
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center"><asp:datagrid id="dgClientes" runat="server" Width="594px" Height="178px" BorderWidth="1px" BorderStyle="None"
					AllowSorting="True" AutoGenerateColumns="False" BorderColor="#000099" BackColor="White" CellPadding="3" AllowPaging="True">
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="LightCyan" BackColor="#006699"></HeaderStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Codigo de Cliente">
							<HeaderStyle Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Target="_self" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.ccodcli", URLCodigo) %>' Text='<%# DataBinder.Eval(Container, "DataItem.ccodcli") %>'>
								</asp:HyperLink>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ccodcli") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="cNomcli" SortExpression="cNomcli" HeaderText="Nombre del Cliente">
							<HeaderStyle Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					    <asp:BoundColumn DataField="cnudoci" HeaderText="Identificacion" 
                            SortExpression="cnudoci">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Verdana" 
                                Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Verdana" 
                                Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Left" VerticalAlign="Top" />
                        </asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 903px">
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center">&nbsp;<asp:textbox 
                    id="TxtNombre" tabIndex="1" runat="server" Width="264px" Font-Names="Verdana" BorderWidth="1px"
									ToolTip="Digite el Nombre del Cliente" Visible="False"></asp:textbox></DIV>
		</TD>
	</TR>
</TABLE>
