<%@ Control Language="vb" AutoEventWireup="false" Codefile="cuwempleados.ascx.vb" Inherits="cuwempleados"  %>
<TABLE id="Table4" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 752px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 401px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="752" border="0">
	<TR>
		<TD style="HEIGHT: 114px" align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">PLANILLA DE PAGOS</P>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">
				<TABLE id="Table1" style="WIDTH: 662px; HEIGHT: 272px" cellSpacing="0" cellPadding="0"
					width="662" border="0">
					<TR>
						<TD align="center">
							<TABLE id="Table5" style="WIDTH: 368px; HEIGHT: 26px" height="26" cellSpacing="0" cellPadding="0"
								width="368" border="0">
								<TR>
									<TD style="WIDTH: 124px"><asp:label id="Label7" Width="111px" runat="server" Font-Names="Verdana" Font-Size="8pt">Fecha de Planilla:</asp:label></TD>
									<TD><asp:textbox id="txtdfecha" Width="92px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											BorderWidth="1px" Font-Bold="True"></asp:textbox></TD>
									<TD><asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
											ControlToValidate="txtdfecha" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date">Fecha de Des.Inválida-</asp:rangevalidator></TD>
								</TR>
							</TABLE>
							<asp:datagrid id="Datagrid1" Width="629px" runat="server" BorderWidth="1px" AllowSorting="True"
								AutoGenerateColumns="False" CellPadding="4" BackColor="White" BorderStyle="None" BorderColor="#CC9966"
								Height="96px">
								<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
								<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
								<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
								<Columns>
									<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Verdana" Font-Bold="True"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Center" ForeColor="Blue"
											VerticalAlign="Top"></ItemStyle>
									</asp:ButtonColumn>
									<asp:TemplateColumn HeaderText="Id">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Center" ForeColor="Black"
											VerticalAlign="Top"></ItemStyle>
										<ItemTemplate>
											<asp:HyperLink id=HyperLink1 runat="server" Target="_self" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.id", URLCodigo) %>' Text='<%# DataBinder.Eval(Container, "DataItem.Id") %>'>
											</asp:HyperLink>
										</ItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn DataField="cnomemp" SortExpression="cnomemp" HeaderText="Nombre">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="cdui" SortExpression="cdui" HeaderText="DUI">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="ccargo" SortExpression="ccargo" HeaderText="Cargo">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
											Width="8px" VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="nsalario" SortExpression="nsalario" HeaderText="Salario">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="ncomision" SortExpression="ncomision" HeaderText="Comisi&#243;n">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="nboni" SortExpression="nboni" HeaderText="Bonificacion">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="notros" HeaderText="Otros Descuentos" FooterText="notros">
										<HeaderStyle Font-Size="XX-Small" Font-Underline="True" Font-Names="Century Gothic" HorizontalAlign="Center"
											VerticalAlign="Middle"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="ncelular" SortExpression="ncelular" HeaderText="Pago Telefono">
										<HeaderStyle Font-Size="XX-Small" Font-Underline="True" Font-Names="Century Gothic" HorizontalAlign="Center"
											VerticalAlign="Middle"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="ntotal" SortExpression="ntotal" HeaderText="total">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Century Gothic" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
							</asp:datagrid></TD>
					</TR>
					<TR>
						<TD align="center">
							<TABLE id="Table2" style="WIDTH: 513px; HEIGHT: 18px" borderColor="#ffcc00" cellSpacing="0"
								cellPadding="0" width="513" bgColor="#ffff99" border="1">
								<TR>
									<TD style="WIDTH: 78px"><asp:label id="Label3" Width="63px" runat="server" Font-Names="Verdana" Font-Size="8pt">Empleado:</asp:label></TD>
									<TD style="WIDTH: 212px"><asp:textbox id="txtcnomemp" Width="214px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											BorderWidth="1px" Font-Bold="True" Enabled="False"></asp:textbox></TD>
									<TD style="WIDTH: 95px"><asp:label id="Label2" Width="41px" runat="server" Font-Names="Verdana" Font-Size="8pt">Comisión:</asp:label></TD>
									<TD style="WIDTH: 85px"><asp:textbox id="txtncomision" Width="81px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											BorderWidth="1px" Font-Bold="True"></asp:textbox></TD>
									<TD style="WIDTH: 1px"><asp:label id="Label8" Width="38px" runat="server" Font-Names="Verdana" Font-Size="8pt">Otros Descuentos:</asp:label></TD>
									<TD style="WIDTH: 86px"><asp:textbox id="txtnotros" Width="82px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											BorderWidth="1px" Font-Bold="True"></asp:textbox></TD>
									<TD><INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 40px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 24px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 78px"></TD>
									<TD style="WIDTH: 212px"></TD>
									<TD style="WIDTH: 95px">
										<asp:label id="Label10" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="41px">Bonificación:</asp:label></TD>
									<TD style="WIDTH: 85px">
										<asp:textbox id="txtnboni" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="81px" Font-Bold="True"
											BorderWidth="1px"></asp:textbox></TD>
									<TD style="WIDTH: 1px">
										<asp:label id="Label9" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="41px">Pago Telefono:</asp:label></TD>
									<TD style="WIDTH: 86px">
										<asp:textbox id="txtntelefono" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="79px"
											Font-Bold="True" BorderWidth="1px"></asp:textbox></TD>
									<TD></TD>
								</TR>
							</TABLE>
							<asp:textbox id="TxtComodin" Width="128px" runat="server" Font-Names="Verdana" BorderWidth="1px"
								Visible="False"></asp:textbox><asp:textbox id="TxtCodigo" Width="89px" runat="server" Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtccodcta" Width="89px" runat="server" Font-Names="Verdana" Font-Size="8pt"
								BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox></TD>
					</TR>
					<TR>
						<TD>
							<TABLE id="Table3" style="WIDTH: 646px; HEIGHT: 40px" cellSpacing="0" cellPadding="0" width="646"
								border="0">
								<TR>
									<TD style="WIDTH: 238px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									</TD>
									<TD style="WIDTH: 116px"><INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
									<TD><INPUT id="btnCancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
											type="button" name="Button1" runat="server"></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
</TABLE>
