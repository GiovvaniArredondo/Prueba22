<%@ control language="vb" autoeventwireup="false" inherits="wucSocioEco, App_Web_yl8dokps" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<style type="text/css">
    .style1
    {
        width: 76%;
        height: 41px;
    }
    .style2
    {
        width: 180px;
    }
    .style3
    {
        width: 174px;
    }
    .style4
    {
        width: 171px;
    }
    .style5
    {
        width: 137px;
    }
    .style6
    {
        width: 72%;
        margin-bottom: 0px;
        height: 64px;
    }
    .style7
    {
        width: 249px;
    }
    .style8
    {
        width: 83%;
    }
    .style9
    {
        width: 206px;
    }
    .style10
    {
        width: 72%;
    }
    .style11
    {
        width: 168px;
    }
    .style12
    {
        width: 88%;
    }
    .style13
    {
        width: 320px;
    }
    .style14
    {
        width: 89%;
    }
    .style15
    {
        width: 78%;
    }
    .style16
    {
        width: 83%;
    }
    .style17
    {
        width: 89%;
    }
    .style18
    {
        width: 93%;
    }
    .style19
    {
        width: 91%;
    }
    .style20
    {
        width: 137px;
        height: 32px;
    }
    .style21
    {
        height: 32px;
    }
</style>
<script language="javascript" type="text/javascript">
// <!CDATA[



// ]]>
</script>
<head id="Head1" runat="server" />
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 688px; HEIGHT: 507px"
	cellSpacing="0" cellPadding="0" width="688" bgColor="#ffffff" border="0">
	<TR>
		<TD align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #006699; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
				align="center">DATOS SOCIOECONOMICOS<asp:ScriptManager ID="ScriptManager1" 
                    runat="server">
                </asp:ScriptManager>
            </P>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td class="style3">
                        <asp:label id="Label16" Font-Bold="True" ForeColor="Navy" Font-Size="8pt" Font-Names="Verdana"
							Width="48px" runat="server">Cod.Cliente</asp:label>
                    </td>
                    <td class="style4">
                        <asp:textbox id="TxtCodigo" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"></asp:textbox>
                    </td>
                    <td class="style2">
						<asp:label id="Label17" runat="server" Width="48px" Font-Names="Verdana" Font-Size="8pt" ForeColor="Navy"
							Font-Bold="True">Nombre:</asp:label>
                    </td>
                    <td>
						<asp:textbox id="TxtNomcli" tabIndex="3" runat="server" Width="225px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False"></asp:textbox>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:datagrid id="Datagrid1" Enabled="False" AllowSorting="True" 
                AutoGenerateColumns="False" CellPadding="3"
								BorderWidth="1px" BorderStyle="None" BorderColor="#006699" BackColor="White" 
                Height="112px" Width="645px"
								runat="server">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
								<ItemStyle ForeColor="#000066"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
								<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
								<Columns>
									<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
										<HeaderStyle Font-Size="X-Small" Font-Names="Calibri" Font-Bold="True" 
                                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
										<ItemStyle Font-Size="X-Small" Font-Names="Verdana" HorizontalAlign="Center" ForeColor="Blue"
											VerticalAlign="Top"></ItemStyle>
									</asp:ButtonColumn>
									<asp:TemplateColumn SortExpression="cnrohij" HeaderText="Nro">
										<HeaderStyle Font-Size="X-Small" Font-Names="Calibri" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
										<ItemStyle Font-Size="X-Small" Font-Names="Calibri" HorizontalAlign="Center" ForeColor="Black"
											VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                            Font-Underline="False"></ItemStyle>
										<ItemTemplate>
											<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cnrohij") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.cnrohij", URLCodigo) %>' Target="_self">
											</asp:HyperLink>
										</ItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn DataField="cnomhij" SortExpression="cnomhij" 
                                        HeaderText="Nombre de los Hijos">
										<HeaderStyle Font-Size="X-Small" Font-Names="Calibri" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                            Font-Underline="False"></HeaderStyle>
										<ItemStyle Font-Size="X-Small" Font-Names="Calibri" HorizontalAlign="Center" 
                                            VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False"></ItemStyle>
									</asp:BoundColumn>
								    <asp:BoundColumn DataField="dfecnac" HeaderText="Fecha Nac." 
                                        SortExpression="dfecnac" DataFormatString="{0:dd-MM-yyyy}">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="nedad" HeaderText="Edad" SortExpression="nedad">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="cCodGrad" HeaderText="Grado que Cursa" 
                                        SortExpression="cCodGrad">
                                        <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="lcarnet" HeaderText="Tiene Carné Salud" 
                                        SortExpression="lcarnet">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
							</asp:datagrid>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td class="style20">
                        <asp:Label ID="Label32" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Nº."></asp:Label>
                    </td>
                    <td class="style21">
                        <asp:textbox id="TxtComodin" runat="server" Width="64px" Font-Names="Verdana" 
                            BorderWidth="1px" Enabled="False"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        <asp:Label ID="Label18" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Nombre Hijo(a):"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Height="22px" Width="367px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        <asp:Label ID="Label19" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Fecha de Nac:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Height="22px" Width="165px"></asp:TextBox>
                        <cc1:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="TextBox2">
                        </cc1:CalendarExtender>
							<asp:RangeValidator id="RangeValidator1" runat="server" Font-Size="8pt" 
                            Font-Names="Verdana" ErrorMessage="RangeValidator"
								ControlToValidate="TextBox2" MinimumValue="01/01/1910" MaximumValue="01/01/2015" Type="Date">Fec.Nacimiento Inválida-</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        <asp:Label ID="Label20" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Grado que Cursa:"></asp:Label>
                    </td>
                    <td>
						<asp:dropdownlist id="cmbgrado" runat="server" Width="290px" Height="16px" 
                                        Font-Names="Calibri" Font-Size="10pt"></asp:dropdownlist>
                                 
                                  
                                </td>
                </tr>
                <tr>
                    <td class="style5">
                        <asp:Label ID="Label21" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Tiene Carné Salud:"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Calibri" Text=" Si" />
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Agregar" Width="85px" style="height: 29px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
                            ConfirmText="Seguro de Agregar" Enabled="True" TargetControlID="Button1">
                        </cc1:ConfirmButtonExtender>
                    &nbsp;
                        <asp:Button ID="Button2" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Suprimir" Width="85px" />
                        <cc1:ConfirmButtonExtender ID="Button2_ConfirmButtonExtender" runat="server" 
                            ConfirmText="Seguro de Suprimir" Enabled="True" TargetControlID="Button2">
                        </cc1:ConfirmButtonExtender>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="style6">
                <tr>
                    <td class="style7">
                        <asp:Label ID="Label22" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Si dejan la escuela, señale porque?"></asp:Label>
                    </td>
                    <td>
                        <asp:textbox id="txtobserv" Font-Names="Verdana" Font-Size="8pt" runat="server"
								Width="269px" Height="56px" TextMode="MultiLine" tabIndex="15"></asp:textbox>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD align="center" 
            style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #003366; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'">
			Uso del préstamo</TR>
	<TR>
		<TD align="center">
			<asp:CheckBox ID="CheckBox2" runat="server" Font-Names="Calibri" 
                Text="Ha tenido prestamos anteriormente?" />
&nbsp;</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="style8" border="1" 
                style="border-color: #003366">
                <tr>
                    <td class="style9">
                        <asp:Label ID="Label23" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Como invirtio su último prestamo? :"></asp:Label>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style14">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox6" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Comercio" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox7" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Servicios" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox8" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Agricultura" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox9" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Pecuario" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox10" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="No lo invirtió en actividad productiva" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox11" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Otros (Especifique)" />
                                    <asp:TextBox ID="TextBox3" runat="server" Font-Names="Calibri" Font-Size="8pt"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:Label ID="Label24" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Usó parte de su préstamo para?"></asp:Label>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style15">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox12" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Comprar alimentos para el hogar" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox13" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Comprar ropa u otros articulos" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox14" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Presto el dinero a otra persona" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox15" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Ahorró el dinero" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox16" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="No indicado" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:Label ID="Label25" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Durante los últimos 12 meses, los ingresos totales del hogar:"></asp:Label>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style16">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox17" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Disminuyeron mucho" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox18" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Disminuyeron" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox19" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Se mantuvieron iguales" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox20" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Aumentaron" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox21" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Aumentaron mucho" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox22" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="No sabe" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:Label ID="Label26" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Si disminuyeron, porque?"></asp:Label>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style17">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox23" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Enfermedad" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox24" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Bajos precios" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox25" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Mala producción" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox26" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Problemas conyugales" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox27" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Otros(Especifique)" />
                                    <asp:TextBox ID="TextBox4" runat="server" Font-Names="Calibri" Font-Size="8pt"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:Label ID="Label27" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Si aumentaron, porque?"></asp:Label>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style19">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox43" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Amplió su microempresa" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox44" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Vendió mejor" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox45" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Recibió Remesa" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox46" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Emigró a otra parte a trabajar" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox47" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="No sabe" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD align="center" 
            style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #003366; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'">
			Activos del Hogar</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:CheckBox ID="CheckBox3" runat="server" Font-Names="Calibri" 
                Text="Si ha comprado enseres del hogar en el último año?" />
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="style10">
                <tr>
                    <td class="style11">
                        <asp:Label ID="Label28" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Si ha comprado, cuales?"></asp:Label>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style18">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox28" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Televisor" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox29" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Radiograbadora" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox30" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Sala" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox31" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Comedor" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox32" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Camas" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox33" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Bicicletas" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox34" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Otros(Especifique)" />
                                    <asp:TextBox ID="TextBox5" runat="server" Font-Names="Calibri" Font-Size="8pt"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD align="center" 
            style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #003366; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'">
			Vivienda</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="style12" border="1" 
                style="border-color: #000066">
                <tr>
                    <td class="style13">
                        <asp:Label ID="Label29" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="La vivienda en la que habita es propia?"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBox4" runat="server" Font-Names="Calibri" Text="Si" />
                    </td>
                </tr>
                <tr>
                    <td class="style13">
                        <asp:Label ID="Label30" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Ha hecho mejoras en los últimos 12 meses?"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBox5" runat="server" Font-Names="Calibri" Text="Si" />
                    </td>
                </tr>
                <tr>
                    <td class="style13">
                        <asp:Label ID="Label31" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Si ha hecho mejoras, cuales?"></asp:Label>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style18">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox35" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Techo" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox36" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Piso" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox37" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Paredes" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox38" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Otros Ambientes" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox39" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Agua Potable" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox40" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Energía Electrica" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox41" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Pintura" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox42" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" Text="Otros(Especifique)" />
                                    <asp:TextBox ID="TextBox6" runat="server" Font-Names="Calibri" Font-Size="8pt"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			&nbsp;</TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table3" style="WIDTH: 79px; HEIGHT: 88px; margin-right: 51px;" 
                cellSpacing="0" cellPadding="0" width="79"
				border="0">
				<TR>
					<TD>
                        <asp:Button ID="btgrabar" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Grabar" Width="85px" />
                    </TD>
					<TD>&nbsp;</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
