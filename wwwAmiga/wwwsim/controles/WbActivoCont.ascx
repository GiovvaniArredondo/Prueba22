<%@ Control Language="vb" AutoEventWireup="false" CodeFile="WbActivoCont.ascx.vb" Inherits="WbActivoCont"   %>
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
    .style8
    {
        height: 18px;
    }
    .style9
    {
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
    .style5
    {
        width: 99%;
        float: left;
    }
    .style12
    {
        width: 136px;
        text-align: right;
    }
    .style13
    {
    }
    .style14
    {
        width: 111px;
        text-align: right;
    }
    .style15
    {
        width: 137px;
        height: 22px;
    }
    .style16
    {
        width: 233px;
        height: 22px;
    }
    .style17
    {
        width: 110px;
        height: 22px;
    }
    .style18
    {
        width: 69px;
        height: 22px;
    }
    .style20
    {
        width: 137px;
        height: 29px;
    }
    .style21
    {
        height: 29px;
        width: 233px;
    }
    .style22
    {
        width: 110px;
        height: 29px;
    }
    .style23
    {
        width: 69px;
        height: 29px;
    }
    .style24
    {
        height: 15px;
        width: 233px;
    }
    .style25
    {
        height: 13px;
        width: 233px;
    }
    .style26
    {
        height: 20px;
        width: 233px;
    }
    .style27
    {
        width: 233px;
    }
    .style28
    {
        height: 18px;
        width: 233px;
    }
    .style29
    {
        height: 11px;
    }
    .style30
    {
        height: 20px;
        width: 694px;
    }
    .style31
    {
        width: 726px;
        height: 184px;
    }
    </style>
<P>
	&nbsp;<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 664px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 272px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="664" align="left" border="0">
		<TR>
			<TD class="style30">
				<P class="PageTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
					align="center">INGRESO DE ACTIVO
					FIJOS<br />
					<TABLE id="Table2" style="border: thin solid royalblue;"
						cellSpacing="0" cellPadding="0" border="0" class="style31">
						<TR>
							<TD style="HEIGHT: 15px" align="right" colspan="4">
                                <table class="style5">
                                    <tr>
                                        <td bgcolor="#0066FF">
                                            <asp:Label ID="Label58" runat="server" BackColor="#3366FF" Font-Bold="True" 
                                                Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="White" 
                                                Text="Datos del Activo:" Width="648px"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px; HEIGHT: 15px" align="right"><asp:label id="Label1" Font-Size="10pt" Width="105px" Font-Names="Gill Sans MT" runat="server">Codigo de Activo Generado:</asp:label></TD>
							<TD class="style24"><asp:textbox id="TextBox1" Font-Size="10pt" Width="194px" 
                                    Font-Names="Gill Sans MT" runat="server"
									Enabled="False"></asp:textbox></TD>
							<TD style="WIDTH: 110px; HEIGHT: 15px" align="right">&nbsp;</TD>
							<TD style="HEIGHT: 15px">
                                <asp:label id="Label22" 
                                    Height="8px" Font-Size="10pt" Width="119px" Font-Names="Gill Sans MT"
									runat="server">Activo Drepreciable:</asp:label>
                                <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" 
                                    Font-Names="Gill Sans MT" Font-Size="10pt" Text="Si" />
                            </TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px; HEIGHT: 13px" align="right"><asp:label id="Label14" Height="8px" Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server">Oficina:</asp:label></TD>
							<TD class="style25"><asp:dropdownlist id="Dropdownlist6" Font-Size="10pt" 
                                    Width="173px" Font-Names="Gill Sans MT" runat="server" Height="16px" 
                                    Enabled="False"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 13px" align="right"><asp:label id="Label15" 
                                    Height="8px" Font-Size="10pt" Width="88px" Font-Names="Gill Sans MT"
									runat="server">Fondo:</asp:label></TD>
							<TD style="HEIGHT: 13px">
                                <asp:dropdownlist id="cmbFondos" 
                                    Font-Size="10pt" Width="192px" Font-Names="Gill Sans MT" runat="server" 
                                    Height="16px" Enabled="False"></asp:dropdownlist></TD>
						</TR>
						<TR>
							<TD align="right" class="style1">
                                <asp:label id="Label59" Height="16px" 
                                    Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server">No. Nit.:</asp:label></TD>
							<TD class="style2" colspan="2">
                                <asp:textbox id="txtNIt" Font-Size="10pt" 
                                    Width="171px" Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:textbox>
                                            <asp:Button ID="btnBuscaProv" runat="server" Text="Buscar" 
                                    Width="53px" Enabled="False" Font-Names="Gill Sans MT" />
                            </TD>
							<TD class="style4">
                                            <asp:Button ID="btnProvee" runat="server" Text="Proveedores" Width="90px" 
                                                Enabled="False" style="margin-left: 0px" Font-Names="Gill Sans MT" />
                            </TD>
						</TR>
						<TR>
							<TD align="right" class="style1"><asp:label id="Label18" Height="8px" 
                                    Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server">Proveedor:</asp:label></TD>
							<TD class="style2">
                                <asp:textbox id="txtProvee" Font-Size="10pt" Width="235px" 
                                    Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:textbox></TD>
							<TD class="style2">
                                <asp:label id="Label19" Height="8px" 
                                    Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server" style="float: right">No. Factura:</asp:label></TD>
							<TD class="style4">
                                <asp:textbox id="txtFactura" Font-Size="10pt" Width="171px" 
                                    Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:textbox>
                            </TD>
						</TR>
						<TR>
							<TD align="right" class="style1"><asp:label id="Label5" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server">Fecha de Adquisión:</asp:label></TD>
							<TD class="style26">
                                <asp:textbox id="TextBox4" Font-Size="10pt" Width="171px" 
                                    Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:textbox>
                                <br />
                                <asp:rangevalidator id="RangeValidator5" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Type="Date"
									MaximumValue="01/01/3000" MinimumValue="01/01/2000" ControlToValidate="TextBox4" ErrorMessage="RangeValidator" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator></TD>
							<TD align="right" class="style3"><asp:label id="Label23" Font-Size="10pt" 
                                    Font-Names="Gill Sans MT" runat="server">Fecha de Baja:</asp:label></TD>
							<TD class="style4">
                                <asp:textbox id="txtFechaBja" Font-Size="10pt" Width="171px" 
                                    Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:textbox>
                                <asp:rangevalidator id="RangeValidator6" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                    runat="server" Type="Date"
									MaximumValue="01/01/3000" MinimumValue="01/01/2000" ControlToValidate="txtFechaBja" 
                                    ErrorMessage="RangeValidator" DESIGNTIMEDRAGDROP="1491" Width="100px" 
                                    Height="16px">Fecha Inválida-</asp:rangevalidator></TD>
						</TR>
						<TR>
							<TD align="right" class="style20"><asp:label id="Label16" 
                                    Height="8px" Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server">Cheque:</asp:label></TD>
							<TD class="style21">
                                <asp:textbox id="txtNroChq" Font-Size="10pt" 
                                    Width="171px" Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:textbox>
                                <br />
                                </TD>
							<TD align="right" class="style22"><asp:label id="Label17" 
                                    Height="8px" Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server">Partida:</asp:label></TD>
							<TD class="style23">
                                <asp:textbox id="txtPartida" Font-Size="10pt" 
                                    Width="171px" Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:textbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px; HEIGHT: 13px" align="right"><asp:label id="Label11" Height="8px" Font-Size="10pt" Width="105px" Font-Names="Gill Sans MT"
									runat="server">Activo Fijo:</asp:label></TD>
							<TD class="style25">
                                <asp:dropdownlist id="Dropdownlist4" Font-Size="10pt" Width="171px" 
                                    Font-Names="Gill Sans MT" runat="server"
									AutoPostBack="True" Height="16px" Enabled="False"></asp:dropdownlist>
                            </TD>
							<TD style="WIDTH: 110px; HEIGHT: 13px" align="right"><asp:label id="Label12" Height="8px" Font-Size="10pt" Width="88px" Font-Names="Gill Sans MT"
									runat="server">Tipo de Clasif:</asp:label></TD>
							<TD style="HEIGHT: 13px"><asp:dropdownlist id="Dropdownlist5" Font-Size="10pt" 
                                    Width="169px" Font-Names="Gill Sans MT" runat="server" Height="16px" 
                                    Enabled="False"></asp:dropdownlist></TD>
						</TR>
						<TR>
							<TD style="text-align: left;" align="right" class="style29"><asp:label id="Label2" 
                                    Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" 
                                    style="text-align: left">Descripción del Bien:</asp:label></TD>
							<TD style="text-align: left;" align="right" class="style29" colspan="3">
                                <asp:textbox id="TextBox2" Font-Size="10pt" Width="510px" 
                                    Font-Names="Gill Sans MT" runat="server" 
                                    style="text-align: left; float: left; margin-left: 0px" Enabled="False"></asp:textbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px" align="right"><asp:label id="Label6" Font-Size="10pt" Width="89px" Font-Names="Gill Sans MT" runat="server">Vida Útil (Años):</asp:label></TD>
							<TD class="style27">
                                <asp:textbox id="TextBox5" Font-Size="10pt" Width="59px" 
                                    Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:textbox></TD>
							<TD style="WIDTH: 110px" align="right"><asp:label id="Label3" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server">Valor del Bien:</asp:label></TD>
							<TD><asp:textbox id="TextBox3" Font-Size="10pt" Width="165px" 
                                    Font-Names="Gill Sans MT" runat="server" Enabled="False">0</asp:textbox></TD>
						</TR>
						<TR>
							<TD style="WIDTH: 137px" align="right"><asp:label id="Label7" Font-Size="10pt" Width="89px" Font-Names="Gill Sans MT" runat="server">Valor Residual:</asp:label></TD>
							<TD class="style27">
                                <asp:textbox id="TextBox6" Font-Size="10pt" Width="164px" 
                                    Font-Names="Gill Sans MT" runat="server" Enabled="False" Height="22px">0</asp:textbox></TD>
							<TD style="WIDTH: 110px" align="right"><asp:label id="Label13" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server">Valor No deducible:</asp:label></TD>
							<TD><asp:textbox id="Textbox8" Font-Size="10pt" Width="165px" 
                                    Font-Names="Gill Sans MT" runat="server" Enabled="False">0</asp:textbox></TD>
						</TR>
						<TR>
							<TD align="right" class="style15"><asp:label id="Label8" Font-Size="10pt" Width="89px" Font-Names="Gill Sans MT" runat="server"> Tipo de Activo:</asp:label></TD>
							<TD class="style16">
                                <asp:dropdownlist id="DropDownList2" Font-Size="10pt" 
                                    Width="166px" Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:dropdownlist></TD>
							<TD align="right" class="style17"><asp:label id="Label4" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server">Estado del Bien:</asp:label></TD>
							<TD class="style18"><asp:dropdownlist id="DropDownList1" Font-Size="10pt" 
                                    Width="166px" Font-Names="Gill Sans MT" runat="server" Enabled="False"></asp:dropdownlist></TD>
						</TR>
						<TR>
							<TD align="right" class="style8" colspan="4">
                                            <asp:Label ID="Label63" runat="server" BackColor="#3366FF" Font-Bold="True" 
                                                Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="White" 
                                                Text="Sección Administración:" Width="715px" 
                                    style="text-align: left; float: left"></asp:Label>
                                        </TD>
						</TR>
						<TR>
							<TD align="right" class="style8"><asp:label id="Label20" 
                                    Height="8px" Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server">Empleado:</asp:label></TD>
							<TD class="style28">
                                <asp:dropdownlist id="cmbUsuarios" 
                                    Font-Size="10pt" Width="229px" Font-Names="Gill Sans MT" runat="server" 
                                    Enabled="False" Height="16px"></asp:dropdownlist></TD>
							<TD align="right" class="style10">
                                <asp:label id="Label21" 
                                    Height="8px" Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server" Visible="False">Operador:</asp:label></TD>
							<TD class="style11">
                                            <asp:Button ID="btnAsignar" runat="server" Text="Asignar" Width="90px" 
                                                Enabled="False" Visible="False" Font-Names="Gill Sans MT" />
                            </TD>
						</TR>
						<TR>
							<TD align="right" class="style8">
                                <asp:label id="Label62" 
                                    Height="8px" Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server" Visible="False">Asignado A:</asp:label></TD>
							<TD class="style9" colspan="2">
                                <asp:textbox id="txtEmpleado" Font-Size="10pt" 
                                    Width="281px" Font-Names="Gill Sans MT" runat="server" Enabled="False" 
                                    Visible="False"></asp:textbox></TD>
							<TD class="style11">
                                <asp:textbox id="txtOperador" Font-Size="10pt" 
                                    Width="67px" Font-Names="Gill Sans MT" runat="server" Enabled="False" 
                                    Visible="False"></asp:textbox>
                                <asp:textbox id="txtcodEmp" Font-Size="10pt" 
                                    Width="67px" Font-Names="Gill Sans MT" runat="server" Enabled="False" 
                                    Visible="False"></asp:textbox></TD>
						</TR>
						<TR>
							<TD align="right" class="style8">
                                <asp:label id="Label9" Font-Size="10pt" Width="99px" Font-Names="Gill Sans MT" 
                                    runat="server">Area 
                                Responsable:</asp:label></TD>
							<TD class="style28">
                                <asp:dropdownlist id="Dropdownlist7" Font-Size="10pt" Width="227px" 
                                    Font-Names="Gill Sans MT" runat="server" Height="20px" Enabled="False"></asp:dropdownlist></TD>
							<TD class="style9">
                                <asp:label id="Label10" Font-Size="10pt" Width="95px" Font-Names="Gill Sans MT" runat="server">Ubicación Fisica:</asp:label></TD>
							<TD class="style11">
                                <asp:dropdownlist id="DropDownList3" 
                                    Font-Size="10pt" Width="166px" Font-Names="Gill Sans MT" runat="server" 
                                    Enabled="False"></asp:dropdownlist></TD>
						</TR>
						<TR>
							<TD align="right" class="style8" colspan="4">
                                <table class="style5">
                                    <tr>
                                        <td bgcolor="#0066FF">
                                            <asp:Label ID="Label60" runat="server" BackColor="#3366FF" Font-Bold="True" 
                                                Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="White" 
                                                Text="Sección Sistemas:" Width="600px"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
						</TR>
						<TR>
							<TD align="right" class="style8" colspan="4">
                                <asp:Panel ID="Panel1" runat="server" Enabled="False">
                                    <table class="style5">
                                        <tr>
                                            <td class="style12">
                                                <asp:label id="Label24" Font-Size="10pt" 
                                    Width="105px" Font-Names="Gill Sans MT" 
                runat="server">No. Serie:</asp:label>
                                            </td>
                                            <td class="style13">
                                                <asp:textbox id="txtSeri" Font-Size="10pt" Width="206px" 
                                    Font-Names="Gill Sans MT" runat="server" Height="24px"></asp:textbox>
                                            </td>
                                            <td class="style14">
                                                <asp:label id="Label25" Height="8px" 
                                    Font-Size="10pt" Width="84px" Font-Names="Gill Sans MT"
									runat="server">Modelo:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtModelo" Font-Size="10pt" Width="171px" 
                                    Font-Names="Gill Sans MT" runat="server"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style12">
                                                <asp:label id="Label49" Font-Size="10pt" 
                                    Width="105px" Font-Names="Gill Sans MT" 
                runat="server">Marca:</asp:label>
                                            </td>
                                            <td class="style13">
                                                <asp:dropdownlist id="cmbMarca" Font-Size="10pt" 
                                    Width="206px" Font-Names="Gill Sans MT" 
                runat="server" Height="18px">
                                                </asp:dropdownlist>
                                            </td>
                                            <td class="style14">
                                                <asp:label id="Label50" Font-Size="10pt" 
                                    Width="105px" Font-Names="Gill Sans MT" 
                runat="server">Tipo:</asp:label>
                                            </td>
                                            <td>
                                                <asp:dropdownlist id="cmbLinea" Font-Size="10pt" 
                                    Width="171px" Font-Names="Gill Sans MT" 
                runat="server" Height="27px">
                                                </asp:dropdownlist>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style12">
                                                <asp:label id="Label54" Font-Size="10pt" 
                                    Width="105px" Font-Names="Gill Sans MT" 
                runat="server">Licencia:</asp:label>
                                            </td>
                                            <td class="style13">
                                                <asp:textbox id="txtLicencia" Font-Size="10pt" Width="208px" 
                                    Font-Names="Gill Sans MT" runat="server"></asp:textbox>
                                            </td>
                                            <td class="style14">
                                                <asp:Label ID="Label57" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Width="105px">No. Inventario</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtPassInter" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Width="170px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style12">
                                                <asp:label id="Label52" Font-Size="10pt" 
                                    Width="105px" Font-Names="Gill Sans MT" 
                runat="server">Usuario LogMeIn:</asp:label>
                                            </td>
                                            <td class="style13">
                                                <asp:textbox id="txtUsLog" Font-Size="10pt" Width="208px" 
                                    Font-Names="Gill Sans MT" runat="server"></asp:textbox>
                                            </td>
                                            <td class="style14">
                                                <asp:label id="Label53" Font-Size="10pt" 
                                    Width="105px" Font-Names="Gill Sans MT" 
                runat="server">Clave LogMeIn:</asp:label>
                                            </td>
                                            <td>
                                                <asp:textbox id="txtPassLog" Font-Size="10pt" Width="171px" 
                                    Font-Names="Gill Sans MT" runat="server"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style12">
                                                <asp:label id="Label61" Font-Size="10pt" 
                                    Width="105px" Font-Names="Gill Sans MT" 
                runat="server">Detalle:</asp:label>
                                            </td>
                                            <td class="style13" colspan="3">
                                                <asp:textbox id="txtDetalle" Font-Size="10pt" Width="475px" 
                                    Font-Names="Gill Sans MT" runat="server" Height="74px" TextMode="MultiLine"></asp:textbox>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </TD>
						</TR>
						<TR>
							<TD align="right" class="style8">&nbsp;</TD>
							<TD class="style28">
                                <asp:HiddenField ID="hfinventario" runat="server" />
                            </TD>
							<TD align="right" class="style10">
                                <asp:HiddenField ID="VarX" runat="server" Value="1" />
                            </TD>
							<TD class="style11">
                                &nbsp;</TD>
						</TR>
					</TABLE>
					<TABLE id="Table3" style="WIDTH: 453px; HEIGHT: 74px" cellSpacing="0" cellPadding="0" width="453"
						border="0">
						<TR>
							<TD style="WIDTH: 256px" align="center">
                                <asp:Button ID="btnNuevo" runat="server" Height="58px" Text="Nuevo" 
                                    Width="78px" Font-Names="Gill Sans MT" />
                            </TD>
							<TD style="WIDTH: 256px" align="center">
                                <asp:Button ID="btnModificar" runat="server" Enabled="False" Height="58px" 
                                    Text="Modificar" Width="78px" Font-Names="Gill Sans MT" />
                            </TD>
							<TD style="WIDTH: 165px" align="center">
                                <asp:Button ID="btnGraba" runat="server" Enabled="False" Height="58px" 
                                    Text="Grabar" Width="78px" Font-Names="Gill Sans MT" />
                            </TD>
							<TD style="margin-left: 40px"><asp:textbox id="TextBox7" Font-Size="10pt" Width="38px" Font-Names="Gill Sans MT" runat="server"
									Visible="False"></asp:textbox></TD>
						</TR>
					</TABLE>
				</P>
			</TD>
		</TR>
	</TABLE>
</P>
<P>&nbsp;</P>