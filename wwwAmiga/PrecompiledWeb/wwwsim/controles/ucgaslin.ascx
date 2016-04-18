<%@ control language="vb" autoeventwireup="false" inherits="ucgaslin, App_Web_yl8dokps" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="608" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 608px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 296px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD align="center" style="HEIGHT: 19px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">ASIGNACION DE GASTOS POR LINEA DE CREDITOS</P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 24px">
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="440" border="0" style="WIDTH: 440px; HEIGHT: 34px">
				<TR>
					<TD style="WIDTH: 293px; HEIGHT: 23px" align="right"><asp:label id="Label2" Width="96px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Número Línea:</asp:label></TD>
					<TD style="HEIGHT: 23px"><asp:textbox id="txtnrolin" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px"
							Enabled="False"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center" style="HEIGHT: 139px"><asp:datagrid id="dgClientes" BackColor="White" Width="568px" runat="server" BorderStyle="None"
				DataKeyField="cnrolin" AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="3" Height="120px">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Size="XX-Small" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Left"
					ForeColor="White" VerticalAlign="Top" BackColor="#006699"></HeaderStyle>
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
				<Columns>
					<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:ButtonColumn>
					<asp:BoundColumn DataField="gastos" SortExpression="gastos" HeaderText="Gastos Asignados">
						<HeaderStyle Font-Size="10pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="cuota" SortExpression="cuota" HeaderText="Cuota/Desembolso">
						<HeaderStyle Font-Size="10pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="monto" SortExpression="monto" HeaderText="Monto">
						<HeaderStyle Font-Size="10pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="porcen" SortExpression="porcen" HeaderText="Porcentaje">
						<HeaderStyle Font-Size="10pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="afecta" SortExpression="afecta" HeaderText="Afectar a:">
						<HeaderStyle Font-Size="10pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="codigo" SortExpression="codigo" HeaderText="Tipo Gasto">
						<HeaderStyle Font-Size="10pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:datagrid></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 37px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="600" border="0" style="WIDTH: 600px; HEIGHT: 64px"
				align="center">
				<TR>
					<TD style="WIDTH: 207px; HEIGHT: 19px" align="center"><asp:label id="Label3" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Gasto</asp:label></TD>
					<TD style="WIDTH: 182px; HEIGHT: 19px" align="center"><asp:label id="Label4" Width="144px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Cuota/Desembolso</asp:label></TD>
					<TD style="WIDTH: 183px; HEIGHT: 19px" align="center"><asp:label id="Label5" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Monto:</asp:label></TD>
					<TD style="WIDTH: 129px; HEIGHT: 19px" align="center"><asp:label id="Label6" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">%</asp:label></TD>
					<TD style="HEIGHT: 19px" align="center"><asp:label id="Label7" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Afectar a:</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 207px; HEIGHT: 20px" align="right"><asp:dropdownlist id="ddlgasto" Width="136px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 182px; HEIGHT: 20px" align="center"><asp:dropdownlist id="ddlcuota" Width="136px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 183px; HEIGHT: 20px"><asp:textbox id="txtmonto" Width="80px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px"></asp:textbox></TD>
					<TD style="WIDTH: 129px; HEIGHT: 20px"><asp:textbox id="txtporcen" Width="72px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"
							BorderWidth="1px"></asp:textbox></TD>
					<TD style="HEIGHT: 20px"><asp:dropdownlist id="ddlafecta" Width="128px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 207px; HEIGHT: 18px" align="right"></TD>
					<TD style="WIDTH: 182px; HEIGHT: 18px" align="center"></TD>
					<TD style="WIDTH: 183px; HEIGHT: 18px">
						<asp:RangeValidator id="RangeValidator3" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="86px"
							Height="23px" ControlToValidate="txtmonto" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0"
							MaximumValue="1000000000">Valor Inválido-</asp:RangeValidator></TD>
					<TD style="WIDTH: 129px; HEIGHT: 18px">
						<asp:RangeValidator id="RangeValidator1" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Width="86px"
							Height="23px" ControlToValidate="txtporcen" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0"
							MaximumValue="100">Valor Inválido-</asp:RangeValidator></TD>
					<TD style="HEIGHT: 18px"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="479" border="0" style="WIDTH: 479px; HEIGHT: 72px"
				align="center">
				<TR>
					<TD style="WIDTH: 339px" align="right"><INPUT style="BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg);WIDTH: 62px;BACKGROUND-REPEAT: no-repeat;HEIGHT: 60px;BACKGROUND-COLOR: transparent"
							type="button" id="btnAplicar" name="Button2" runat="server">&nbsp;&nbsp;&nbsp; 
						&nbsp;&nbsp;<INPUT id="btnElimina" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg);WIDTH: 64px;BACKGROUND-REPEAT: no-repeat;HEIGHT: 56px;BACKGROUND-COLOR: transparent"
							type="button" name="Button2" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
