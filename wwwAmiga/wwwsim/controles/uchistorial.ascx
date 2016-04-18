<%@ Control Language="vb" AutoEventWireup="false" Inherits="uchistorial" CodeFile="uchistorial.ascx.vb" %>
<P>
	<TABLE id="Table7" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 640px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 530px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="640" border="0">
		<TR>
			<TD style="HEIGHT: 89px" align="center">
				<P style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; BORDER-BOTTOM-WIDTH: thin; BORDER-BOTTOM-COLOR: #0099ff; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
					align="center">ESTADO DE CUENTAS
					<TABLE id="Table4" style="WIDTH: 476px; HEIGHT: 40px" cellSpacing="0" cellPadding="0" width="476"
						border="0">
						<TR>
							<TD style="WIDTH: 449px">
								<TABLE id="Table8" style="WIDTH: 406px; HEIGHT: 57px" cellSpacing="0" cellPadding="0" width="406"
									border="0">
									<TR>
										<TD style="WIDTH: 166px" align="right">
											<asp:label id="Label1" Font-Size="8pt" Font-Names="Verdana" runat="server" DESIGNTIMEDRAGDROP="315">Nombre:</asp:label></TD>
										<TD>
											<asp:textbox id="txtnomcli" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
												BorderWidth="1px" Width="208px"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 166px" align="right">
											<asp:label id="Label2" Font-Size="8pt" Font-Names="Verdana" runat="server" DESIGNTIMEDRAGDROP="320">Cuenta:</asp:label></TD>
										<TD>
											<asp:textbox id="txtcodcta" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
												BorderWidth="1px"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 166px" align="right">
											<asp:label id="Label3" Font-Size="8pt" Font-Names="Verdana" runat="server" DESIGNTIMEDRAGDROP="325">Cliente::</asp:label></TD>
										<TD>
											<asp:textbox id="txtcodcli" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
												BorderWidth="1px" DESIGNTIMEDRAGDROP="327"></asp:textbox></TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
					</TABLE>
				</P>
			</TD>
		</TR>
		<TR>
			<TD align="center">
				<TABLE id="Table9" style="WIDTH: 471px; HEIGHT: 95px" cellSpacing="0" cellPadding="0" width="471"
					border="0">
					<TR>
						<TD style="WIDTH: 151px" align="right">
							<asp:label id="Label4" Font-Size="8pt" Font-Names="Verdana" runat="server" DESIGNTIMEDRAGDROP="333">Monto Desembolsado:</asp:label></TD>
						<TD style="WIDTH: 81px">
							<asp:textbox id="txtcapdes" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="90px" DESIGNTIMEDRAGDROP="335"></asp:textbox></TD>
						<TD style="WIDTH: 102px" align="right">
							<asp:label id="Label9" Font-Size="8pt" Font-Names="Verdana" runat="server" DESIGNTIMEDRAGDROP="337">Monto Garantias:</asp:label></TD>
						<TD>
							<asp:textbox id="txtmongar" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="94px" DESIGNTIMEDRAGDROP="339"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 151px" align="right">
							<asp:label id="Label5" Font-Size="8pt" Font-Names="Verdana" runat="server">Saldo Capital:</asp:label></TD>
						<TD style="WIDTH: 81px">
							<asp:textbox id="txtsalcap" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="90px"></asp:textbox></TD>
						<TD style="WIDTH: 102px"></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 151px" align="right">
							<asp:label id="Label6" Font-Size="8pt" Font-Names="Verdana" runat="server">Capital en Mora:</asp:label></TD>
						<TD style="WIDTH: 81px">
							<asp:textbox id="txtmorcap" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="90px"></asp:textbox></TD>
						<TD style="WIDTH: 102px" align="right">
							<asp:label id="Label10" Font-Size="8pt" Font-Names="Verdana" runat="server">Cuota:</asp:label></TD>
						<TD>
							<asp:textbox id="txtcuota" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="94px"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 151px" align="right">
							<asp:label id="Label7" Font-Size="8pt" Font-Names="Verdana" runat="server">Intereses Normales:</asp:label></TD>
						<TD style="WIDTH: 81px">
							<asp:textbox id="txtintere" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="90px"></asp:textbox></TD>
						<TD style="WIDTH: 102px" align="right">
							<asp:label id="Label11" Font-Size="8pt" Font-Names="Verdana" runat="server">F. Desembolso:</asp:label></TD>
						<TD>
							<asp:textbox id="txtdfecvig" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="94px"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 151px" align="right">
							<asp:label id="Label8" Font-Size="8pt" Font-Names="Verdana" runat="server">Intereses Moratorios:</asp:label></TD>
						<TD style="WIDTH: 81px">
							<asp:textbox id="txtintmor" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="90px"></asp:textbox></TD>
						<TD style="WIDTH: 102px" align="right">
							<asp:label id="Label12" Font-Size="8pt" Font-Names="Verdana" runat="server">F. Vencimiento:</asp:label></TD>
						<TD>
							<asp:textbox id="txtdfecven" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="94px"></asp:textbox></TD>
					</TR>
				</TABLE>
				<TABLE id="Table3" style="WIDTH: 635px; HEIGHT: 298px" cellSpacing="0" cellPadding="0"
					width="635" border="0">
					<TR>
						<TD align="center">
							<asp:label id="Label13" Font-Size="8pt" Font-Names="Verdana" runat="server">Total a Pagar al Día:</asp:label>
							<asp:textbox id="txtmonpag" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								BorderWidth="1px" Width="92px"></asp:textbox>
							<TABLE id="Table2" style="WIDTH: 634px; HEIGHT: 23px" cellSpacing="0" cellPadding="0" width="634"
								border="0">
								<TR>
									<TD>
										<asp:Label id="Label14" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="80px" BackColor="White"
											Visible="False">Label</asp:Label></TD>
								</TR>
							</TABLE>
							<TABLE id="Table1" style="WIDTH: 633px; HEIGHT: 202px" cellSpacing="0" cellPadding="0"
								width="633" border="0">
								<TR>
									<TD style="HEIGHT: 12px">
										<P style="FONT-WEIGHT: bold; FONT-SIZE: 8pt; BORDER-BOTTOM-WIDTH: thin; BORDER-BOTTOM-COLOR: #0099ff; COLOR: inactivecaptiontext; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: background"
											align="center">Detalle de pagos de Créditos</P>
									</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 76px" align="center">
										<asp:datagrid id="DataGrid1" runat="server" BorderWidth="1px" Width="631px" AutoGenerateColumns="False"
											BorderColor="#006699" BorderStyle="None" BackColor="White" CellPadding="3" Height="190px">
											<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
											<ItemStyle ForeColor="#000066"></ItemStyle>
											<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
											<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
											<Columns>
												<asp:BoundColumn DataField="dfecsis" SortExpression="dfecsis" ReadOnly="True" HeaderText="Fecha Contable"
													DataFormatString="{0:dd-MM-yyyy}">
													<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
													<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="dfecpro" SortExpression="dfecpro" ReadOnly="True" HeaderText="Fecha Valor"
													DataFormatString="{0:dd-MM-yyyy}">
													<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
													<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="cnrodoc" SortExpression="cnrodoc" HeaderText="Numero Doc.">
													<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
													<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="cnuming" SortExpression="cnuming" HeaderText="Numero Rec.">
													<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
													<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="ncapita" SortExpression="ncapita" HeaderText="Capital" DataFormatString="{0:C}">
													<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
													<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="nintere" SortExpression="nintere" HeaderText="Interes" DataFormatString="{0:C}">
													<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
													<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="nmora" SortExpression="nmora" HeaderText="Mora" DataFormatString="{0:C}">
													<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
													<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="notros" SortExpression="notros" HeaderText="Otros" DataFormatString="{0:C}">
													<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
													<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="npago" SortExpression="npago" HeaderText="Total Pagado" DataFormatString="{0:C}">
													<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
													<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
													<FooterStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></FooterStyle>
												</asp:BoundColumn>
											</Columns>
											<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
										</asp:datagrid></TD>
								</TR>
							</TABLE>
							<INPUT id="btnimprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 69px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></TD>
					</TR>
				</TABLE>
			</TD>
		</TR>
	</TABLE>
</P>
