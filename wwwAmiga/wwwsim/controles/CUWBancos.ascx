<%@ Control Language="vb" AutoEventWireup="false" Codefile="CUWBancos.ascx.vb" Inherits="CUWBancos"  %>
<style type="text/css">
    .style1
    {
        width: 180px;
    }
</style>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 656px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 334px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="656" border="0">
	<TR>
		<TD align="center"><asp:label id="Label3" ForeColor="#16387C" Font-Names="Verdana" Height="15px" Font-Size="Medium"
				Font-Bold="True" Width="319px" runat="server">Administración de Bancos</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 197px" align="center">
			<TABLE id="Table2" style="WIDTH: 627px; HEIGHT: 216px" cellSpacing="0" cellPadding="0"
				width="627" border="0">
				<TR>
					<TD style="WIDTH: 378px" align="center">
						<TABLE id="Table3" style="WIDTH: 689px; HEIGHT: 155px" cellSpacing="0" 
                            cellPadding="0" border="0">
							<TR>
								<TD align="right" class="style1"><asp:label id="Label38" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="102px" runat="server">Nombre Banco:</asp:label></TD>
								<TD><asp:dropdownlist id="cmbbancos" Font-Names="Verdana" Font-Size="8pt" Width="240px" runat="server"></asp:dropdownlist><asp:textbox id="txtcnombco" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="240px"
										runat="server" Enabled="False" BorderWidth="1px"></asp:textbox><asp:imagebutton id="ImageButton1" Height="22px" Width="24px" runat="server" ImageUrl="../Web/jpgs/btn_aplicar_b.jpg"
										ImageAlign="Middle"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD align="right" class="style1">
                                    <asp:Label ID="Label40" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Agencia:"></asp:Label>
                                </TD>
								<TD>
                                    <asp:DropDownList ID="cmbAgencia" runat="server" Height="16px" Width="238px" 
                                        Font-Names="Verdana" Font-Size="8pt">
                                    </asp:DropDownList>
                                </TD>
							</TR>
							<TR>
								<TD align="right" class="style1">
                                    <asp:Label ID="Label41" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Fondo:"></asp:Label>
                                </TD>
								<TD>
                                    <asp:DropDownList ID="cmbFondo" runat="server" Height="17px" Width="239px" 
                                        Font-Names="Verdana" Font-Size="8pt">
                                    </asp:DropDownList>
                                </TD>
							</TR>
							<TR>
								<TD align="right" class="style1"><asp:label id="Label1" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="118px" runat="server">Codigo de Banco:</asp:label></TD>
								<TD><asp:textbox id="txtccodbco" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="144px"
										runat="server" Enabled="False" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD align="right" class="style1"><asp:label id="Label2" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="96px" runat="server">Tipo de Cuenta:</asp:label></TD>
								<TD><asp:radiobutton id="rbtn1" Font-Names="Verdana" Font-Size="8pt" Width="72px" 
                                        runat="server" Text="Ahorro"
										GroupName="tipo2"></asp:radiobutton>
                                    <asp:radiobutton id="rbtn2" 
                                        Font-Names="Verdana" Font-Size="8pt" Width="76px" runat="server" Text="Corriente"
										GroupName="tipo2" Checked="True"></asp:radiobutton></TD>
							</TR>
							<TR>
								<TD align="right" class="style1">
                                    <asp:Label ID="Label42" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                        Text="Aplicación Cuenta:"></asp:Label>
                                </TD>
								<TD>
                                    <asp:DropDownList ID="cmAplCuenta" runat="server" Font-Names="Verdana" 
                                        Font-Size="8pt" Height="16px" Width="160px">
                                    </asp:DropDownList>
                                </TD>
							</TR>
							<TR>
								<TD align="right" class="style1"><asp:label id="Label4" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="96px" runat="server">Nº de  Cuenta:</asp:label></TD>
								<TD><asp:textbox id="txtcctacte" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="144px"
										runat="server" Enabled="False" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD align="right" class="style1"><asp:label id="Label5" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="127px" runat="server">Codigo Contable:</asp:label></TD>
								<TD><asp:textbox id="txtccodcta" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="144px"
										runat="server" Enabled="False" BorderWidth="1px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD align="right" class="style1"><asp:label id="Label6" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="120px" runat="server">Correlativo Cheque:</asp:label></TD>
								<TD><asp:textbox id="txtcnrochq" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="144px"
										runat="server" Enabled="False" BorderWidth="1px"></asp:textbox></TD>
							</TR>
						</TABLE>
					    <asp:CheckBox ID="CheckBox1" runat="server" Text="Activada?" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					</TD>
					<TD style="WIDTH: 378px" align="center">
						&nbsp;</TD>
					<TD style="WIDTH: 378px" align="center">
						&nbsp;</TD>
					<TD align="center">
						<TABLE id="Table4" style="WIDTH: 216px; HEIGHT: 163px" cellSpacing="0" cellPadding="0"
							width="216" border="0">
							<TR>
								<TD align="center"><asp:label id="Label7" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="102px" runat="server">Periodo:</asp:label>
									<TABLE id="Table5" style="WIDTH: 208px; HEIGHT: 19px" cellSpacing="0" cellPadding="0" width="208"
										border="0">
										<TR>
											<TD style="WIDTH: 106px" align="center"><asp:textbox id="txtdfecha1" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="83px"
													runat="server" BorderWidth="1px"></asp:textbox></TD>
											<TD align="center"><asp:textbox id="txtdfecha2" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="83px"
													runat="server" BorderWidth="1px"></asp:textbox></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD align="center">
									<TABLE id="Table6" style="WIDTH: 192px; HEIGHT: 88px" cellSpacing="0" cellPadding="0" width="192"
										border="0">
										<TR>
											<TD style="WIDTH: 114px" align="right"><asp:label id="Label8" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="96px" runat="server">Saldo Anterior:</asp:label></TD>
											<TD><asp:textbox id="txtnsalant" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="88px"
													runat="server" Enabled="False" BorderWidth="1px">0</asp:textbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 114px" align="right"><asp:label id="Label9" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="96px" runat="server">Cargos:</asp:label></TD>
											<TD><asp:textbox id="txtncargos" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="88px"
													runat="server" Enabled="False" BorderWidth="1px">0</asp:textbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 114px" align="right"><asp:label id="Label10" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="96px" runat="server">Abonos:</asp:label></TD>
											<TD><asp:textbox id="txtnabonos" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="88px"
													runat="server" Enabled="False" BorderWidth="1px">0</asp:textbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 114px" align="right"><asp:label id="Label11" Font-Names="Verdana" Height="15px" Font-Size="8pt" Width="96px" runat="server">Saldo Actual:</asp:label></TD>
											<TD><asp:textbox id="txtnsalact" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" Width="88px"
													runat="server" Enabled="False" BorderWidth="1px">0</asp:textbox></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
						<asp:TextBox id="txtvalida" Width="42px" runat="server" Visible="False"></asp:TextBox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table7" style="WIDTH: 529px; HEIGHT: 32px" cellSpacing="0" cellPadding="0" width="529"
				border="0">
				<TR>
					<TD style="WIDTH: 93px"><INPUT id="btnnuevo" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
					<TD style="WIDTH: 91px"><INPUT id="btneditar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_editar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
					<TD style="WIDTH: 90px">
                        <INPUT id="btngrabar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button3" runat="server"></TD>
					<TD style="WIDTH: 91px">
                        <INPUT id="btnundo" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button4" runat="server"></TD>
					<TD style="WIDTH: 85px">
                        <INPUT id="btnquitar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/btn_quitar.gif); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button2" runat="server" visible="False"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
