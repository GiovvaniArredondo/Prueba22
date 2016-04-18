<%@ control language="vb" autoeventwireup="false" inherits="ucbusaho, App_Web_mb_xwoah" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="592" bgColor="#ffffff" border="0"
	style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 592px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 312px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD>
			<P style="BACKGROUND-COLOR: white" align="center"><asp:label id="Label9" Width="365px" runat="server" ForeColor="MidnightBlue" Height="15px"
					Font-Size="Medium" Font-Names="Verdana" Font-Bold="True" BorderWidth="0px">BUSCA CUENTAS DE AHORROS</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 5px; BACKGROUND-COLOR: #ffffff"></TD>
	</TR>
	<TR>
		<TD align="center" bgColor="#ffffff">
			<asp:label id="Label2" BorderWidth="0px" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt"
				Height="15px" ForeColor="MidnightBlue" runat="server" Width="365px">Cuentas de Ahorro</asp:label></TD>
	</TR>
	<TR>
		<TD bgColor="#ffffff" style="HEIGHT: 88px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="568" border="0" style="WIDTH: 568px; HEIGHT: 32px"
				align="center">
				<TR>
					<TD style="WIDTH: 175px">
						<P style="BACKGROUND-COLOR: white" align="right"><asp:label id="Label1" Width="64px" runat="server" ForeColor="MidnightBlue" Height="11px" Font-Size="Smaller"
								Font-Names="Century Gothic"> Asociado:</asp:label></P>
					</TD>
					<TD style="WIDTH: 213px">
						<P style="BACKGROUND-COLOR: white" align="left"><asp:textbox id="TxtNombre" tabIndex="1" Width="208px" runat="server" ToolTip="Digite el Nombre del Cliente"></asp:textbox></P>
					</TD>
					<TD>
						<P align="left"><INPUT id="Button1" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 72px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
								type="button" name="Button2" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="288" border="0" style="WIDTH: 288px; HEIGHT: 43px"
				align="center">
				<TR>
					<TD style="WIDTH: 183px" align="right">
						<asp:CheckBox id="txtcodigo1" runat="server" Text="Por Código" Font-Names="Verdana" Height="16px"
							Width="104px" BorderWidth="0px" Font-Size="8pt"></asp:CheckBox>&nbsp;</TD>
					<TD style="HEIGHT: 19px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 183px; BACKGROUND-COLOR: white" align="right">
						<asp:CheckBox id="txtnombre1" runat="server" Text="Por Nombre" Font-Names="Verdana" Height="16px"
							Width="104px" BorderWidth="0px" Font-Size="8pt"></asp:CheckBox></TD>
					<TD></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD bgColor="#ffffff"></TD>
	</TR>
	<TR>
		<TD style="BACKGROUND-COLOR: #ffffff">
			<DIV align="center"><asp:datagrid id="dgClientes" BackColor="White" Width="510px" runat="server" CellPadding="3" BorderWidth="1px"
					BorderColor="#CCCCCC" AutoGenerateColumns="False" DataKeyField="codigo" BorderStyle="None" Height="104px">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Cuenta Ah.">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Target="_self" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.codigo", URLCodigo) %>' Text='<%# DataBinder.Eval(Container, "DataItem.codigo") %>'>
								</asp:HyperLink>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cnrolin") %>' Rows='<%# DataBinder.Eval(Container, "ItemType") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="tipo" SortExpression="tipo" HeaderText="Tipo Ahorro">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="cnomcli" SortExpression="cnomcli" HeaderText="Asociado">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="nsaldoaho" SortExpression="nsaldoaho" HeaderText="Saldo Ahorro">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
	<TR>
		<TD>
			<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;</P>
		</TD>
	</TR>
</TABLE>
