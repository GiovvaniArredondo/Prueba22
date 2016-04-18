<%@ Control Language="vb" AutoEventWireup="false" CodeFile="WbActivoDetalle.ascx.vb" Inherits="WbActivo1"   %>
<style type="text/css">
    .style1
    {
        width: 137px;
        height: 20px;
    }
    .style2
    {
        height: 20px;
    }
    .style3
    {
        width: 110px;
        height: 20px;
    }
    .style4
    {
        width: 69px;
        height: 20px;
    }
    .style5
    {
        width: 100%;
    }
    .style8
    {
        width: 137px;
        height: 18px;
    }
    .style9
    {
        width: 159px;
        height: 18px;
    }
    .style10
    {
        width: 110px;
        height: 18px;
    }
    .style11
    {
        width: 69px;
        height: 18px;
    }
</style>
<P>
	&nbsp;<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 664px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 272px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="664" align="left" border="0">
		<TR>
			<TD style="HEIGHT: 20px">
				<P class="PageTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
					align="center">INVENTARIO SISTEMAS<TABLE id="Table2" style="BORDER-RIGHT: royalblue thin solid; BORDER-TOP: royalblue thin solid; BORDER-LEFT: royalblue thin solid; WIDTH: 650px; BORDER-BOTTOM: royalblue thin solid; HEIGHT: 184px"
						cellSpacing="0" cellPadding="0" width="650" border="0">
						<TR>
							<TD style="WIDTH: 137px; HEIGHT: 15px" align="right"><asp:label id="Label1" Font-Size="8pt" Width="105px" Font-Names="Century Gothic" runat="server">Codigo de Activo Generado:</asp:label></TD>
							<TD style="WIDTH: 159px; HEIGHT: 15px"><asp:textbox id="TextBox1" Font-Size="8pt" Width="171px" Font-Names="Century Gothic" runat="server"
									Enabled="False"></asp:textbox></TD>
							<TD style="WIDTH: 110px; HEIGHT: 15px" align="right">&nbsp;</TD>
							<TD style="WIDTH: 69px; HEIGHT: 15px">
                                <asp:textbox id="txtNIt" Font-Size="8pt" 
                                    Width="171px" Font-Names="Century Gothic" runat="server" Visible="False"></asp:textbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px; HEIGHT: 13px" align="right"><asp:label id="Label14" Height="8px" Font-Size="8pt" Width="84px" Font-Names="Century Gothic"
									runat="server">Oficina:</asp:label></TD>
							<TD style="WIDTH: 159px; HEIGHT: 13px"><asp:dropdownlist id="Dropdownlist6" Font-Size="8pt" Width="166px" Font-Names="Century Gothic" runat="server"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 13px" align="right">&nbsp;</TD>
							<TD style="WIDTH: 69px; HEIGHT: 13px">&nbsp;</TD>
						</TR>
						<TR>
							<TD align="right" class="style1"><asp:label id="Label5" Font-Size="8pt" Font-Names="Century Gothic" runat="server">Fecha de Adquisión:</asp:label></TD>
							<TD class="style2"><asp:textbox id="TextBox4" Font-Size="8pt" Width="171px" Font-Names="Century Gothic" runat="server"></asp:textbox>
                                <br />
                                <asp:rangevalidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" runat="server" Type="Date"
									MaximumValue="01/01/3000" MinimumValue="01/01/2000" ControlToValidate="TextBox4" ErrorMessage="RangeValidator" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator></TD>
							<TD align="right" class="style3"><asp:label id="Label23" Font-Size="8pt" 
                                    Font-Names="Century Gothic" runat="server">Fecha de Baja:</asp:label></TD>
							<TD class="style4"><asp:textbox id="TextBox13" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server"></asp:textbox>
                                <br />
                                <asp:rangevalidator id="RangeValidator6" Font-Size="8pt" Font-Names="Verdana" 
                                    runat="server" Type="Date"
									MaximumValue="01/01/3000" MinimumValue="01/01/2000" ControlToValidate="TextBox13" 
                                    ErrorMessage="RangeValidator" DESIGNTIMEDRAGDROP="1491" Width="100px" 
                                    Height="16px">Fecha Inválida-</asp:rangevalidator></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px; HEIGHT: 13px" align="right"><asp:label id="Label20" 
                                    Height="8px" Font-Size="8pt" Width="84px" Font-Names="Century Gothic"
									runat="server">Empleado:</asp:label></TD>
							<TD style="WIDTH: 159px; HEIGHT: 13px">
                                <asp:dropdownlist id="cmbUsuarios" 
                                    Font-Size="8pt" Width="166px" Font-Names="Century Gothic" runat="server"
									AutoPostBack="True"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 13px" align="right">
                                <asp:label id="Label21" 
                                    Height="8px" Font-Size="8pt" Width="84px" Font-Names="Century Gothic"
									runat="server" Visible="False">Operador:</asp:label></TD>
							<TD style="WIDTH: 69px; HEIGHT: 13px">
                                <asp:textbox id="txtOperador" Font-Size="8pt" 
                                    Width="171px" Font-Names="Century Gothic" runat="server" Enabled="False" 
                                    Visible="False"></asp:textbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px; HEIGHT: 13px" align="right"><asp:label id="Label11" Height="8px" Font-Size="8pt" Width="105px" Font-Names="Century Gothic"
									runat="server">Activo Fijo:</asp:label></TD>
							<TD style="WIDTH: 159px; HEIGHT: 13px">
                                <asp:dropdownlist id="Dropdownlist4" Font-Size="8pt" Width="166px" Font-Names="Century Gothic" runat="server"
									AutoPostBack="True"></asp:dropdownlist>
                            </TD>
							<TD style="WIDTH: 110px; HEIGHT: 13px" align="right"><asp:label id="Label12" Height="8px" Font-Size="8pt" Width="88px" Font-Names="Century Gothic"
									runat="server">Tipo de Clasif:</asp:label></TD>
							<TD style="WIDTH: 69px; HEIGHT: 13px"><asp:dropdownlist id="Dropdownlist5" Font-Size="8pt" Width="166px" Font-Names="Century Gothic" runat="server"></asp:dropdownlist></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px; HEIGHT: 13px" align="right"><asp:label id="Label2" Font-Size="8pt" Font-Names="Century Gothic" runat="server">Descripción del Bien:</asp:label></TD>
							<TD style="WIDTH: 159px; HEIGHT: 13px"><asp:textbox id="TextBox2" Font-Size="8pt" Width="171px" Font-Names="Century Gothic" runat="server"></asp:textbox></TD>
							<TD style="WIDTH: 110px; HEIGHT: 13px" align="right"><asp:label id="Label8" Font-Size="8pt" Width="89px" Font-Names="Century Gothic" runat="server"> Tipo de Activo:</asp:label></TD>
							<TD style="WIDTH: 69px; HEIGHT: 13px"><asp:dropdownlist id="DropDownList2" Font-Size="8pt" Width="176px" Font-Names="Century Gothic" runat="server"></asp:dropdownlist></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px" align="right"><asp:label id="Label4" Font-Size="8pt" Font-Names="Century Gothic" runat="server">Estado del Bien:</asp:label></TD>
							<TD style="WIDTH: 159px"><asp:dropdownlist id="DropDownList1" Font-Size="8pt" Width="166px" Font-Names="Century Gothic" runat="server"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px" align="right">&nbsp;</TD>
							<TD style="WIDTH: 69px">&nbsp;</TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px" align="right"><asp:label id="Label10" Font-Size="8pt" Width="95px" Font-Names="Century Gothic" runat="server">Ubicación Fisica:</asp:label></TD>
							<TD style="WIDTH: 159px"><asp:dropdownlist id="DropDownList3" 
                                    Font-Size="8pt" Width="166px" Font-Names="Century Gothic" runat="server"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px" align="right">&nbsp;</TD>
							<TD style="WIDTH: 69px">&nbsp;</TD>
						</TR>
						<TR>
							<TD align="right" colspan="4">
                                <table class="style5">
                                    <tr>
                                        <td bgcolor="#0066FF">
                                            <asp:Label ID="Label48" runat="server" BackColor="#3366FF" Font-Bold="True" 
                                                Font-Names="Calibri" Font-Size="12pt" ForeColor="White" 
                                                Text="Datos de Equipo de Computación" Width="600px"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px" align="right"><asp:label id="Label24" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">No. Serie:</asp:label></TD>
							<TD style="WIDTH: 159px">
                                <asp:textbox id="txtSeri" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server" Enabled="False"></asp:textbox></TD>
							<TD style="WIDTH: 110px" align="right"><asp:label id="Label25" Height="8px" 
                                    Font-Size="8pt" Width="84px" Font-Names="Century Gothic"
									runat="server">Modelo:</asp:label></TD>
							<TD style="WIDTH: 69px">
                                <asp:textbox id="txtModelo" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server" Enabled="False"></asp:textbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px" align="right"><asp:label id="Label49" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">Marca:</asp:label></TD>
							<TD style="WIDTH: 159px"><asp:dropdownlist id="cmbMarca" Font-Size="8pt" 
                                    Width="166px" Font-Names="Century Gothic" runat="server" Enabled="False"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px" align="right"><asp:label id="Label50" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">Tipo:</asp:label></TD>
							<TD style="WIDTH: 69px"><asp:dropdownlist id="cmbLinea" Font-Size="8pt" 
                                    Width="166px" Font-Names="Century Gothic" runat="server" Enabled="False"></asp:dropdownlist></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px" align="right"><asp:label id="Label54" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">Cap. Disco Duro :</asp:label></TD>
							<TD style="WIDTH: 159px">
                                <asp:textbox id="txtDisco" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server" Enabled="False"></asp:textbox></TD>
							<TD style="WIDTH: 110px" align="right"><asp:label id="Label55" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">Memoria Ram:</asp:label></TD>
							<TD style="WIDTH: 69px">
                                <asp:textbox id="txtMemoria" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server" Enabled="False"></asp:textbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px" align="right"><asp:label id="Label56" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">Procesador:</asp:label></TD>
							<TD style="WIDTH: 159px">
                                <asp:textbox id="txtProcesador" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server" Enabled="False"></asp:textbox></TD>
							<TD style="WIDTH: 110px" align="right"><asp:label id="Label51" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">Licencia:</asp:label></TD>
							<TD style="WIDTH: 69px">
                                <asp:textbox id="txtLicencia" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server" Enabled="False"></asp:textbox></TD>
						</TR>
						<TR>
							<TD align="right" class="style8"><asp:label id="Label52" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">Usuario LogMeIn:</asp:label></TD>
							<TD class="style9">
                                <asp:textbox id="txtUsLog" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server" Enabled="False"></asp:textbox></TD>
							<TD align="right" class="style10"><asp:label id="Label53" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">Clave LogMeIn:</asp:label></TD>
							<TD class="style11">
                                <asp:textbox id="txtPassLog" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server" Enabled="False"></asp:textbox></TD>
						</TR>
						<TR>
							<TD align="right" class="style8"><asp:label id="Label57" Font-Size="8pt" 
                                    Width="105px" Font-Names="Century Gothic" runat="server">Clave I.Explorer:</asp:label></TD>
							<TD class="style9">
                                <asp:textbox id="txtPassInter" Font-Size="8pt" Width="171px" 
                                    Font-Names="Century Gothic" runat="server" Enabled="False"></asp:textbox></TD>
							<TD align="right" class="style10">&nbsp;</TD>
							<TD class="style11">&nbsp;</TD>
						</TR>
					</TABLE>
					<TABLE id="Table3" style="WIDTH: 453px; HEIGHT: 74px" cellSpacing="0" cellPadding="0" width="453"
						border="0">
						<TR>
							<TD style="WIDTH: 256px" align="center"><INPUT id="btnNew" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 66px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 68px; BACKGROUND-COLOR: transparent"
									type="button" name="btnNew" runat="server"></TD>
							<TD style="WIDTH: 165px" align="center"><INPUT id="btnGraba" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 66px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
									tabIndex="9" type="button" name="Button2" runat="server"></TD>
							<TD><asp:textbox id="TextBox7" Font-Size="8pt" Width="38px" Font-Names="Century Gothic" runat="server"
									Visible="False"></asp:textbox></TD>
						    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:fondesysadmonConnectionString1 %>" 
                                ProviderName="<%$ ConnectionStrings:fondesysadmonConnectionString1.ProviderName %>" 
                                SelectCommand="SELECT [Cantidad], [Descripcion] FROM [articulo]">
                            </asp:SqlDataSource>
						</TR>
					</TABLE>
				</P>
			</TD>
		</TR>
	</TABLE>
</P>
<P>&nbsp;</P>