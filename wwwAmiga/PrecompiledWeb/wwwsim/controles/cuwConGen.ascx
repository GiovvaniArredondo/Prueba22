<%@ control language="vb" autoeventwireup="false" inherits="cuwConGen, App_Web_pi2jwlis" %>
<TABLE id="Table2" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 560px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 416px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="560" border="0">
	<TR>
		<TD style="HEIGHT: 213px" align="center">
			<asp:label id="Label4" Width="224px" Height="15px" Font-Size="Medium" Font-Names="Verdana"
				runat="server" ForeColor="#16387C" Font-Bold="True">CONSULTA GENERAL</asp:label>
			<TABLE id="Table4" style="WIDTH: 354px; HEIGHT: 139px" cellSpacing="0" cellPadding="0"
				width="354" align="center" border="0">
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 29px">
						<asp:Button id="btnCtaCtb" Width="114px" BorderWidth="2px" Font-Size="8pt" Font-Names="Verdana"
							runat="server" Text="Cuenta Contable"></asp:Button></TD>
					<TD style="HEIGHT: 29px">
						<asp:TextBox id="txtCodCta" Width="144px" Font-Size="8pt" Font-Names="Verdana" runat="server"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 28px">
						<asp:Button id="btnDescri" Width="114px" BorderWidth="2px" Font-Size="8pt" Font-Names="Verdana"
							runat="server" Text="Descripción"></asp:Button></TD>
					<TD style="HEIGHT: 28px">
						<asp:TextBox id="txtDescri" Width="144px" Font-Size="8pt" Font-Names="Verdana" runat="server"
							Enabled="False"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 29px">
						<asp:Button id="btnDocume" Width="114px" BorderWidth="2px" Font-Size="8pt" Font-Names="Verdana"
							runat="server" Text="Documento"></asp:Button></TD>
					<TD style="HEIGHT: 29px">
						<asp:TextBox id="txtdocume" Width="144px" Font-Size="8pt" Font-Names="Verdana" runat="server"
							Enabled="False"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 28px">
						<asp:Button id="btnvalore" Width="114px" BorderWidth="2px" Font-Size="8pt" Font-Names="Verdana"
							runat="server" Text="Valores"></asp:Button></TD>
					<TD style="HEIGHT: 28px">
						<asp:TextBox id="txtvalore" Width="144px" Font-Size="8pt" Font-Names="Verdana" runat="server"
							Enabled="False"></asp:TextBox>
						<asp:RangeValidator id="RangeValidator2" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="82px"
							MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="txtvalore">Valor Inválido</asp:RangeValidator></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 118px; HEIGHT: 21px">
						<asp:Button id="btnFecha" Width="114px" BorderWidth="2px" Font-Size="8pt" Font-Names="Verdana"
							runat="server" Text="Fecha"></asp:Button></TD>
					<TD style="HEIGHT: 21px">
						<asp:TextBox id="txtfecha" Width="144px" Font-Size="8pt" Font-Names="Verdana" runat="server"
							Enabled="False"></asp:TextBox>
						<asp:RangeValidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="88px"
							MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecha">Fecha Inválida</asp:RangeValidator></TD>
				</TR>
			</TABLE>
			<asp:TextBox id="txtid" Width="72px" Height="13px" Font-Size="8pt" Font-Names="Verdana" runat="server"
				Visible="False"></asp:TextBox>
			<TABLE id="Table6" style="WIDTH: 274px; HEIGHT: 60px" cellSpacing="0" cellPadding="0" width="274"
				align="center" border="0">
				<TR>
					<TD style="WIDTH: 100px" align="center"><INPUT id="btnBuscar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 65px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
					<TD style="WIDTH: 89px">
						<asp:TextBox id="txtfecini" Width="80px" Font-Size="8pt" Font-Names="Verdana" runat="server"></asp:TextBox>
						<asp:RangeValidator id="RangeValidator1" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="88px"
							MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecini">Fecha Inválida</asp:RangeValidator></TD>
					<TD>
						<asp:TextBox id="txtfecfin" Width="72px" Font-Size="8pt" Font-Names="Verdana" runat="server"></asp:TextBox>
						<asp:RangeValidator id="RangeValidator3" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="88px"
							MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecfin">Fecha Inválida</asp:RangeValidator></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:DataGrid id="dgConsulta" Width="534px" BackColor="White" Height="166px" BorderWidth="1px"
				runat="server" AutoGenerateColumns="False" CellPadding="3" BorderStyle="None" BorderColor="#006699">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Size="Small" Font-Names="Garamond" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="cNumcom" SortExpression="cNumCom" HeaderText="Doc">
						<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="cCodCta" SortExpression="cCodCta" HeaderText="Cuenta Contable">
						<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="cGlosa" SortExpression="cGlosa" HeaderText="Descripci&#243;n">
						<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="nDebe" SortExpression="nDebe" HeaderText="Cargos">
						<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="nHaber" SortExpression="nHaber" HeaderText="Abonos">
						<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="dFecCnt" SortExpression="dFecCnt" HeaderText="Fechas" DataFormatString="{0:dd-MM-yyyy}">
						<HeaderStyle Font-Size="X-Small" Font-Names="Garamond" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Garamond"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid></TD>
	</TR>
</TABLE>
