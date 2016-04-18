<%@ Control Language="vb" AutoEventWireup="false" Inherits="WUCGarantiasG" CodeFile="WUCGarantiasG.ascx.vb" %>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 656px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 345px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="656" bgColor="#ff9966" border="0">
	<TR>
		<TD style="HEIGHT: 6px" align="center" bgColor="#ffffff"><asp:label id="Label9" ForeColor="#16387C" Height="15px" Font-Bold="True" Width="278px" Font-Size="Medium"
				Font-Names="Gill Sans MT" runat="server">GARANTÍAS DEL GRUPO</asp:label></TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 137px"><asp:label id="Label2" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Visible="False">Codigo de Grupo:</asp:label></TD>
					<TD><asp:textbox id="txtcCodcli" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Visible="False"
							BorderWidth="1px" Enabled="False"></asp:textbox>
                        <asp:TextBox ID="TextBox3" runat="server" Enabled="False" Visible="False"></asp:TextBox>
                    </TD>
				</TR>
			</TABLE>
			<TABLE id="Table9" style="WIDTH: 657px; HEIGHT: 220px" cellSpacing="0" cellPadding="0"
				width="657" border="0">
				<TR>
					<TD style="WIDTH: 649px; HEIGHT: 278px" align="center"><asp:datagrid id="dgGarantias" Height="121px" Width="654px" runat="server" BorderWidth="1px" AllowSorting="True"
							AutoGenerateColumns="False" BorderColor="#000099" BorderStyle="None" CellPadding="3" BackColor="White">
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="SkyBlue"></SelectedItemStyle>
							<ItemStyle ForeColor="#000066"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<Columns>
								<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
									<ItemStyle Font-Size="10pt" Font-Names="Gill Sans MT"></ItemStyle>
								</asp:ButtonColumn>
								
								<asp:BoundColumn DataField="cnudotr" SortExpression="cnudotr" HeaderText="Cuenta">
									<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Wrap="False"></HeaderStyle>
									<ItemStyle Font-Size="10pt" Font-Names="Gill Sans MT" Wrap="False"></ItemStyle>
									<FooterStyle Wrap="False"></FooterStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="cnomcli" SortExpression="cnomcli" HeaderText="Cliente">
									<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Wrap="False"></HeaderStyle>
									<ItemStyle Font-Size="10pt" Font-Names="Gill Sans MT" Wrap="False"></ItemStyle>
									<FooterStyle Wrap="False"></FooterStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="nsaldnind" SortExpression="nsaldnind" HeaderText="Garantia Liquida">
									<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Wrap="False"></HeaderStyle>
									<ItemStyle Font-Size="10pt" Font-Names="Gill Sans MT" Wrap="False"></ItemStyle>
									<FooterStyle Wrap="False"></FooterStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="MontoSugerido" SortExpression="MontoSugerido" HeaderText="Monto Solicitado">
									<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Wrap="False"></HeaderStyle>
									<ItemStyle Font-Size="10pt" Font-Names="Gill Sans MT"></ItemStyle>
									<FooterStyle Wrap="False"></FooterStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Diferencia" SortExpression="Diferencia" HeaderText="Diferencia">
									<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Wrap="False"></HeaderStyle>
									<ItemStyle Font-Size="10pt" Font-Names="Gill Sans MT" Wrap="False"></ItemStyle>
									<FooterStyle Wrap="False"></FooterStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Wrap="False" Mode="NumericPages"></PagerStyle>
						</asp:datagrid>
						<TABLE id="Table10" style="WIDTH: 656px; HEIGHT: 21px" cellSpacing="0" cellPadding="0"
							width="656" border="0">
							<TR>
								<TD style="WIDTH: 771px" align="right">
									<asp:textbox id="txtccodcta" Width="35px" runat="server" Visible="False"></asp:textbox>
									<asp:textbox id="txtcmoneda" Width="35px" runat="server" Visible="False"></asp:textbox>
									<asp:textbox id="txttasacion" Width="37px" Font-Names="Gill Sans MT" runat="server" Visible="False"></asp:textbox>
									<asp:textbox id="TextBox2" Width="56px" Font-Names="Gill Sans MT" runat="server" Visible="False"></asp:textbox>
                                    <asp:label id="Label6" Width="99px" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                        runat="server" Visible="False">Disponibilidad:</asp:label></TD>
								<TD style="WIDTH: 104px"><asp:textbox id="txtDisponible" ForeColor="MidnightBlue" 
                                        Font-Bold="True" Width="80px" Font-Size="10pt"
										Font-Names="Gill Sans MT" runat="server" BorderWidth="1px" Enabled="False" BackColor="White" 
                                        Visible="False"></asp:textbox></TD>
							</TR>
						</TABLE>
						<TABLE id="Table11" style="WIDTH: 640px; HEIGHT: 21px" cellSpacing="0" cellPadding="0"
							width="640" border="0">
							<TR>
								<TD style="WIDTH: 646px" align="center">
									&nbsp;</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 646px" align="center">
									<asp:label id="Label4" ForeColor="Red" Height="8px" Font-Bold="True" Width="472px" Font-Size="10pt"
										Font-Names="Gill Sans MT" runat="server"></asp:label></TD>
							</TR>
						</TABLE>
						<TABLE id="Table12" style="WIDTH: 640px; HEIGHT: 22px" cellSpacing="0" cellPadding="0"
							width="640" border="0">
							<TR>
								<TD style="WIDTH: 189px" align="right">
									<asp:TextBox id="txtctipgar" runat="server" Width="16px" Visible="False"></asp:TextBox>
									<asp:label id="Label5" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                        runat="server" Visible="False">Descripción</asp:label></TD>
								<TD style="WIDTH: 328px"><asp:textbox id="txtDescri" Width="304px" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server"
										BorderWidth="1px" Enabled="False" BackColor="White"></asp:textbox></TD>
								<TD style="WIDTH: 87px"><asp:label id="Label3" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" runat="server" Visible="False">Gravamen</asp:label></TD>
								<TD><asp:textbox id="txtGravamen" Width="79px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" runat="server"
										BorderWidth="1px" Visible="False"></asp:textbox></TD>
							</TR>
						</TABLE>
						<P align="center">
                            <INPUT id="Button1" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 54px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 50px; BACKGROUND-COLOR: transparent"
								type="button" runat="server" visible="False"></P>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
<P>&nbsp;</P>
