<%@ Control Language="vb" AutoEventWireup="false" Inherits="cuwGarHip" CodeFile="cuwGarHip.ascx.vb" %>
<TABLE id="Table4" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 656px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 464px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="656" border="0">
	<TR>
		<TD style="HEIGHT: 114px" align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">CONTROL DE GARANTÍAS HIPOTECARIAS</P>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">
				<asp:label id="Label6" runat="server" Width="63px" Font-Size="8pt" Font-Names="Verdana">Cliente:</asp:label>
				<asp:textbox id="txtcnomcli" runat="server" Width="434px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana"
					Font-Bold="True" Enabled="False"></asp:textbox>
				<TABLE id="Table1" style="WIDTH: 485px; HEIGHT: 183px" cellSpacing="0" cellPadding="0"
					width="485" border="0">
					<TR>
						<TD align="center"><asp:datagrid id="Datagrid1" DESIGNTIMEDRAGDROP="22" Height="193px" BorderColor="#CC9966" BorderStyle="None"
								BackColor="White" CellPadding="4" AutoGenerateColumns="False" AllowSorting="True" runat="server" Width="567px"
								BorderWidth="1px">
								<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
								<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
								<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
								<Columns>
									<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Verdana" Font-Bold="True"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Center" ForeColor="Blue"
											VerticalAlign="Top"></ItemStyle>
									</asp:ButtonColumn>
									<asp:TemplateColumn HeaderText="Nro">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Verdana" HorizontalAlign="Center" ForeColor="Black"
											VerticalAlign="Top"></ItemStyle>
										<ItemTemplate>
											<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Nro") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Nro", URLCodigo) %>' Target="_self">
											</asp:HyperLink>
										</ItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn DataField="cdescri" SortExpression="cdescri" HeaderText="Descripcion">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Arial Narrow" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Arial Narrow" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="dfecvig" SortExpression="dfecvig" HeaderText="Fecha de Otorg." DataFormatString="{0:dd-MM-yyyy}">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Arial Narrow" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Arial Narrow" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="nmongra" SortExpression="nmongra" HeaderText="Gravamen">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Arial Narrow" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Arial Narrow" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="dpresent" SortExpression="dpresent" HeaderText="Fecha Presentacion" DataFormatString="{0:dd-MM-yyyy}">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Arial Narrow" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Arial Narrow" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="cnumpres" SortExpression="cnumpres" HeaderText="N&#186; Presentacion"
										DataFormatString="{0:c}">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Arial Narrow" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Arial Narrow" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="dinscrip" SortExpression="dinscrip" HeaderText="Fecha Inscripcion" DataFormatString="{0:dd-MM-yyyy}">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Arial Narrow" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Arial Narrow" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="cnumins" SortExpression="cnumins" HeaderText="N&#186; Inscripcion">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Arial Narrow" Font-Bold="True" HorizontalAlign="Center"
											Width="8px" VerticalAlign="Top"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Arial Narrow" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="cobser" SortExpression="cobser" HeaderText="Observaciones">
										<HeaderStyle Font-Size="XX-Small" Font-Names="Arial Narrow" Font-Bold="True" HorizontalAlign="Center"></HeaderStyle>
										<ItemStyle Font-Size="XX-Small" Font-Names="Arial Narrow" VerticalAlign="Top"></ItemStyle>
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
									<TD style="WIDTH: 78px"><asp:label id="Label3" runat="server" Width="63px" Font-Size="8pt" Font-Names="Verdana">Fecha Presentación</asp:label><asp:textbox id="txtdfecpre" runat="server" Width="87px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana"
											Font-Bold="True"></asp:textbox></TD>
									<TD style="WIDTH: 53px"><asp:label id="Label1" Height="16px" runat="server" Width="1px" Font-Size="8pt" Font-Names="Verdana">Nº Presentación</asp:label><asp:textbox id="txtnnumpre" runat="server" Width="91px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana"
											Font-Bold="True"></asp:textbox></TD>
									<TD style="WIDTH: 95px"><asp:label id="Label2" runat="server" Width="41px" Font-Size="8pt" Font-Names="Verdana">Fecha Inscripción</asp:label><asp:textbox id="txtdfecins" runat="server" Width="92px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana"
											Font-Bold="True"></asp:textbox></TD>
									<TD style="WIDTH: 73px"><asp:label id="Label4" runat="server" Width="41px" Font-Size="8pt" Font-Names="Verdana">Nº Inscripción</asp:label><asp:textbox id="txtnnumins" runat="server" Width="72px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana"
											Font-Bold="True"></asp:textbox></TD>
									<TD><asp:label id="Label5" runat="server" Width="41px" Font-Size="8pt" Font-Names="Verdana">Observaciones</asp:label><asp:textbox id="txtcobservar" runat="server" Width="270px" BorderWidth="1px" Font-Size="8pt"
											Font-Names="Verdana" Font-Bold="True" Rows="3" TextMode="MultiLine"></asp:textbox></TD>
								</TR>
							</TABLE>
							<asp:textbox id="TxtComodin" runat="server" Width="128px" BorderWidth="1px" Font-Names="Verdana"
								Visible="False"></asp:textbox><asp:textbox id="TxtCodigo" runat="server" Width="89px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana"
								Enabled="False" Visible="False"></asp:textbox><asp:textbox id="txtccodcta" runat="server" Width="89px" BorderWidth="1px" Font-Size="8pt" Font-Names="Verdana"
								Enabled="False" Visible="False"></asp:textbox></TD>
					</TR>
					<TR>
						<TD>
							<TABLE id="Table3" style="WIDTH: 635px; HEIGHT: 78px" cellSpacing="0" cellPadding="0" width="635"
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
