<%@ control language="vb" autoeventwireup="false" inherits="ucbuscer, App_Web_yl8dokps" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="536" bgColor="#ffffff" border="0"
	style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 536px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 352px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD>
			<P style="BACKGROUND-COLOR: #ffffff" align="center">
				<asp:label id="Label2" Font-Names="Verdana" Font-Size="Medium" Height="15px" ForeColor="#16387C"
					runat="server" Width="362px" Font-Bold="True">BUSQUEDA DE CERTIFICADOS</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 35px; BACKGROUND-COLOR: #ffffff" align="center">
			<asp:Label id="Label4" runat="server" Width="196px" BackColor="Transparent" Font-Names="Verdana"
				Font-Size="8pt" BorderWidth="0px" ForeColor="DarkBlue">CERTIFICADOS A PLAZO</asp:Label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 100px; BACKGROUND-COLOR: #ffffff">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="360" border="0" style="WIDTH: 360px; HEIGHT: 38px"
				align="center">
				<TR>
					<TD style="WIDTH: 161px">
						<P align="right"><asp:label id="Label1" Width="50px" runat="server" ForeColor="MidnightBlue" Height="11px" Font-Size="8pt"
								Font-Names="Verdana"> Asociado:</asp:label></P>
					</TD>
					<TD style="WIDTH: 264px">
						<P align="left"><asp:textbox id="TxtNombre" tabIndex="1" Width="208px" runat="server" ToolTip="Digite el Nombre del Cliente"></asp:textbox></P>
					</TD>
					<TD>
						<P align="left"><INPUT id="Button1" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 72px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
								type="button" name="Button2" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="221" border="0" style="WIDTH: 221px; HEIGHT: 44px"
				align="center">
				<TR>
					<TD style="WIDTH: 37px; HEIGHT: 20px" bgColor="#ffffff"></TD>
					<TD style="HEIGHT: 19px">
						<asp:Label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="216px"></asp:Label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 37px" align="right"></TD>
					<TD align="center"><INPUT id="btnadiciona" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 72px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
							type="button" name="Button2" runat="server"></TD>
				</TR>
			</TABLE>
			<asp:Label id="Label5" Height="8px" runat="server" Width="80px" Font-Names="Verdana" Font-Size="8pt"></asp:Label>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px; BACKGROUND-COLOR: #ffffff"></TD>
	</TR>
	<TR>
		<TD style="BACKGROUND-COLOR: #ffffff">
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center"><asp:datagrid id="dgClientes" BackColor="White" Width="480px" runat="server" CellPadding="3" BorderWidth="1px"
					BorderColor="#CCCCCC" AutoGenerateColumns="False" DataKeyField="ccodcrt" BorderStyle="None">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Certificado">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ccodcrt") %>' Target="_self" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.ccodcrt", URLCodigo) %>'>
								</asp:HyperLink>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cnrolin") %>' Rows='<%# DataBinder.Eval(Container, "ItemType") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="cnomcli" SortExpression="cnomcli" HeaderText="Nombre">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="nmonapr" SortExpression="nmonapr" HeaderText="Monto">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="ntasint" SortExpression="ntasint" HeaderText="Tasa">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
</TABLE>
