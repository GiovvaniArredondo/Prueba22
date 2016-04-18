<%@ Control Language="vb" AutoEventWireup="false" Inherits="WUCGetLin" CodeFile="WUCGetLin.ascx.vb" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD>
			<P align="center"><asp:label id="Label9" Font-Size="Medium" Font-Names="Verdana" runat="server" Height="15px"
					Width="278px" ForeColor="DarkBlue" Font-Bold="True">BUSQUEDA DE LINEAS</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 5px"></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 89px"></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 75px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD>
						<P align="left"><asp:label id="Label1" Font-Size="Smaller" Font-Names="Century Gothic" runat="server" Height="11px"
								Width="144px">Nombre de la Línea</asp:label></P>
					</TD>
					<TD style="WIDTH: 324px">
						<P align="left"><asp:textbox id="TxtNombre" tabIndex="1" runat="server" Width="264px" ToolTip="Digite el Nombre del Cliente"></asp:textbox></P>
					</TD>
					<TD>
						<P align="left"><INPUT id="Button1" style="BACKGROUND-IMAGE: url(file:///C:\SimVB\ProyectoVB\imagenes\Buscar.bmp);WIDTH: 88px;BACKGROUND-REPEAT: no-repeat;HEIGHT: 40px;BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 6px"></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 153px">
			<DIV align="center"><asp:datagrid id="dglinea" runat="server" AutoGenerateColumns="False" AllowSorting="True" Width="472px"
					CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select"></asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Codigo de L&#237;nea">
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cNrolin") %>' Target="_self" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.cNrolin", URLCodigo) %>'>
								</asp:HyperLink>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cNrolin") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="cDeslin" SortExpression="cDeslin" HeaderText="Nombre de la L&#237;nea">
							<HeaderStyle Font-Size="X-Small" Font-Names="Century Gothic" Font-Bold="True"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 18px"></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 45px"></TD>
	</TR>
	<TR>
		<TD>
			<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;</P>
		</TD>
	</TR>
</TABLE>
