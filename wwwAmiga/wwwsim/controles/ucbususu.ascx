<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucbususu" CodeFile="ucbususu.ascx.vb" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="512" bgColor="#ffff99" border="0"
	style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 512px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 312px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD>
			<P style="BACKGROUND-COLOR: #ffffff" align="center">
				<asp:label id="Label6" Height="15px" runat="server" Width="219px" Font-Names="Verdana" Font-Size="Medium"
					Font-Bold="True" ForeColor="#16387C">BUSCAR USUARIOS</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 280px" bgColor="#ffffff">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="434" border="0" style="WIDTH: 434px; HEIGHT: 61px"
				align="center">
				<TR>
					<TD style="WIDTH: 148px">
						<P align="right"><asp:label id="Label1" Font-Size="8pt" Font-Names="Verdana" Width="133px" runat="server" Height="11px"
								ForeColor="MidnightBlue">Nombre de Usuario:</asp:label></P>
					</TD>
					<TD style="WIDTH: 204px">
						<P align="left"><asp:textbox id="TxtNombre" tabIndex="1" Width="184px" runat="server" ToolTip="Digite el Nombre del Cliente"
								BorderWidth="1px" Font-Names="Verdana" Font-Size="8pt"></asp:textbox></P>
					</TD>
					<TD>
						<P align="left"><INPUT id="Button1" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
								type="button" name="Button2" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="199" border="0" style="WIDTH: 199px; HEIGHT: 64px"
				align="center">
				<TR>
					<TD align="center"><INPUT id="btnadiciona" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 61px; BACKGROUND-COLOR: transparent"
							type="button" name="Button2" runat="server"></TD>
				</TR>
			</TABLE>
			<DIV align="center"><asp:datagrid id="dgClientes" BackColor="White" Width="481px" runat="server" BorderStyle="None"
					DataKeyField="idusuario" AutoGenerateColumns="False" BorderColor="#006699" BorderWidth="1px" CellPadding="3">
					<SelectedItemStyle Font-Bold="True" HorizontalAlign="Center" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="C&#243;digo">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.idusuario") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.idusuario", URLCodigo) %>' Target="_self">
								</asp:HyperLink>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cnrolin") %>' Rows='<%# DataBinder.Eval(Container, "ItemType") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="usuario" SortExpression="cnomusu" HeaderText="Usuario">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="nombre" SortExpression="nombre" HeaderText="Nombre">
							<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
	<TR>
		<TD bgColor="#ffffff">
			<DIV align="center">&nbsp;</DIV>
		</TD>
	</TR>
</TABLE>
