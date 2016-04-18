<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbUsCAdPartida.ascx.vb" Inherits="WbUsCAdPartida"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<meta content="True" name="vs_showGrid">
<style type="text/css">
    .style3
    {
        height: 18px;
        width: 603px;
        margin-left: 40px;
    }
    .style8
    {
        height: 37px;
        width: 603px;
    }
    .style9
    {
        width: 87%;
        height: 32px;
    }
    .style10
    {
        width: 349px;
    }
    #Table4
    {
        width: 94%;
    }
    .style15
    {
        width: 603px;
        height: 29px;
    }
    .style16
    {
        width: 77%;
    }
    .style18
    {
        width: 99%;
        height: 186px;
    }
    .style19
    {
        width: 85px;
    }
    .style20
    {
        width: 289px;
    }
    .style21
    {
        width: 85px;
        height: 27px;
    }
    .style22
    {
        width: 289px;
        height: 27px;
    }
    .style24
    {
        width: 85px;
        height: 68px;
    }
    .style25
    {
        width: 289px;
        height: 68px;
    }
    .style27
    {
        width: 83%;
        height: 286px;
    }
    .style28
    {
        width: 361px;
    }
    .style29
    {
        width: 403px;
    }
    .style30
    {
        width: 171px;
        }
    .style32
    {
        height: 17px;
        width: 603px;
        margin-left: 40px;
    }
    .style35
    {
        width: 171px;
        height: 13px;
    }
    .style36
    {
        height: 13px;
    }
    .style37
    {
        width: 111%;
        height: 311px;
    }
    .style38
    {
        height: 271px;
        width: 603px;
        margin-left: 40px;
    }
    .style39
    {
        width: 171px;
        height: 22px;
    }
    .style40
    {
        height: 22px;
    }
</style>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0" 
    
    
    
    style="border: thin solid highlight; WIDTH: 590px; HEIGHT: 571px; BACKGROUND-COLOR: #ffffff; margin-right: 0px;">
	<TR>
		<TD align="center" class="style8">
			<asp:label id="Label1" Font-Bold="True" Width="394px" runat="server" 
                Font-Names="Verdana" Font-Size="Medium"
				ForeColor="#16387C" Height="15px" meta:resourcekey="Label1Resource1">CAPTURA DE PARTIDAS DE DIARIO</asp:label></TD>
	</TR>
	<TR>
		<TD align="center" class="style3">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" style="WIDTH: 554px; HEIGHT: 130px"
				align="center">
				<TR>
					<TD style="FONT-SIZE: 8pt; WIDTH: 171px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana">
                        No. &nbsp;Partida</TD>
					<TD style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana; HEIGHT: 17px">
                        Fecha Contable</TD>
					<TD style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana; HEIGHT: 17px">
                        Fecha de Documento</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 171px"><asp:textbox id="TxtNumpar" Font-Size="8pt" 
                            Font-Names="Verdana" BackColor="White" runat="server"
							Enabled="False" Width="128px" Font-Bold="True" Font-Italic="True" 
                            meta:resourcekey="TxtNumparResource1"></asp:textbox></TD>
					<TD><asp:textbox id="TxtDate" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
							Width="112px" AutoPostBack="True" meta:resourcekey="TxtDateResource1"></asp:textbox>
						<cc1:MaskedEditExtender ID="TxtDate_MaskedEditExtender" runat="server" 
                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="TxtDate">
                        </cc1:MaskedEditExtender>
						<asp:RangeValidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" 
                            runat="server" Width="88px"
							ControlToValidate="TxtDate" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000"
							MaximumValue="01/01/3000" meta:resourcekey="RangeValidator5Resource1">Fecha Inválida-</asp:RangeValidator></TD>
					<TD><asp:textbox id="TxtDco" Font-Size="8pt" Font-Names="Verdana" runat="server" 
                            Enabled="False" meta:resourcekey="TxtDcoResource1"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana; " 
                        class="style30">
                        <asp:Label ID="Label21" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Nº Documento:" meta:resourcekey="Label21Resource1"></asp:Label>
                    </TD>
					<TD><asp:textbox id="TxtNumdoc" Font-Size="8pt" Font-Names="Verdana" 
                            BackColor="White" runat="server"
							Enabled="False" Width="128px" Font-Bold="True" Font-Italic="True" 
                            meta:resourcekey="TxtNumdocResource1"></asp:textbox></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana; " 
                        class="style35">
                        <asp:Label ID="Label20" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                            Text="Tipo de Poliza:" meta:resourcekey="Label20Resource1"></asp:Label>
                    </TD>
					<TD class="style36">
						<asp:dropdownlist id="cmbrubro" runat="server" Width="208px" Height="16px" 
                                        Font-Names="Calibri" Font-Size="10pt" Enabled="False" 
                            meta:resourcekey="cmbrubroResource1"></asp:dropdownlist>
                                 
                                  
                    </TD>
					<TD class="style36">&nbsp;</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="left" class="style32">
			<table align="left" cellpadding="0" cellspacing="0" class="style9">
                <tr>
                    <td align="right" class="style10">
                        <asp:checkbox id="CheckBox1" Font-Size="8pt" Font-Names="Verdana" 
                            runat="server" Width="96px"
								Text="Descripción :" ForeColor="#16387C" Checked="True" meta:resourcekey="CheckBox1Resource1"></asp:checkbox>
                    </td>
                    <td>
                        <asp:textbox id="TxtGlosa" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
								Width="400px" Height="46px" TextMode="MultiLine" style="margin-left: 0px" 
                            meta:resourcekey="TxtGlosaResource1"></asp:textbox>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style38">
			<table cellpadding="0" cellspacing="0" class="style27">
                <tr>
                    <td class="style28">
                        <table bgcolor="#99CCFF" border="1" cellpadding="0" cellspacing="0" 
                            class="style16" 
                            style="border-color: #000066; background-color: #CCFF66; height: 242px;">
                            <tr>
                                <td class="style29">
                                    <table border="1" cellpadding="0" cellspacing="0" class="style18">
                                        <tr>
                                            <td class="style19">
                        <asp:Label ID="Label3" runat="server" Font-Names="Calibri" ForeColor="#000066" 
                            Text="Cuenta:" Font-Size="10pt" meta:resourcekey="Label3Resource1"></asp:Label>
                                            </td>
                                            <td class="style20">
							<asp:textbox id="Txtccodcta" Enabled="False" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="24px" Width="184px" meta:resourcekey="TxtccodctaResource1"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style19">
                                                &nbsp;</td>
                                            <td class="style20">
							<asp:label id="Label2" ForeColor="Red" Font-Size="8pt" Font-Names="Verdana" runat="server"
								Width="138px" Height="16px" meta:resourcekey="Label2Resource1"></asp:label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style19">
                        <asp:Label ID="Label5" runat="server" Font-Names="Calibri" ForeColor="#000066" 
                            Text="Cargo:" Font-Size="10pt" meta:resourcekey="Label5Resource1"></asp:Label>
                                            </td>
                                            <td class="style20">
							<asp:textbox id="TxtnDebe" Width="96px" Enabled="False" runat="server" Font-Names="Verdana" 
                                                    Font-Size="8pt" meta:resourcekey="TxtnDebeResource1"></asp:textbox>
							<asp:RangeValidator id="RangeValidator3" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="82px"
								ControlToValidate="TxtnDebe" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000" 
                                                    Height="16px" meta:resourcekey="RangeValidator3Resource1">Valor 
                        Inválido</asp:RangeValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style21">
                        <asp:Label ID="Label6" runat="server" Font-Names="Calibri" ForeColor="#000066" 
                            Text="Abono:" Font-Size="10pt" meta:resourcekey="Label6Resource1"></asp:Label>
                                            </td>
                                            <td class="style22">
							<asp:textbox id="TxtnHaber" Width="98px" Enabled="False" runat="server" Font-Names="Verdana"
								Font-Size="8pt" meta:resourcekey="TxtnHaberResource1"></asp:textbox>
							<asp:RangeValidator id="RangeValidator1" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="82px"
								ControlToValidate="TxtnHaber" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000" 
                                                    meta:resourcekey="RangeValidator1Resource1">Valor 
                        Inválido</asp:RangeValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style21">
                        <asp:Label ID="Label22" runat="server" Font-Names="Calibri" ForeColor="#000066" 
                            Text="Fuente de Fondos:" Font-Size="10pt" Width="100px" meta:resourcekey="Label22Resource1"></asp:Label>
                                            </td>
                                            <td class="style22">
						<asp:dropdownlist id="cmbFondos" Font-Size="8pt" Font-Names="Verdana" runat="server" Enabled="False"
							Width="208px" meta:resourcekey="cmbFondosResource1"></asp:dropdownlist>
                                 
                                  
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style21">
                        <asp:Label ID="Label23" runat="server" Font-Names="Calibri" ForeColor="#000066" 
                            Text="Oficina:" Font-Size="10pt" Width="100px" meta:resourcekey="Label23Resource1"></asp:Label>
                                            </td>
                                            <td class="style22">
						                        <asp:dropdownlist id="cmbOficina" Font-Size="8pt" Font-Names="Verdana" 
                                                    runat="server" Enabled="False"
							Width="206px" meta:resourcekey="cmbOficinaResource1"></asp:dropdownlist>
                                 
                                  
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style24">
							<asp:textbox id="Txtcdescri" Enabled="False" runat="server" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="16px" Width="69px" Visible="False" 
                                                    meta:resourcekey="TxtcdescriResource1"></asp:textbox>
                                            </td>
                                            <td class="style25">
                        <INPUT id="btnProcesa" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 52px; BACKGROUND-COLOR: transparent"
								type="button" name="Button2" runat="server"></td>
                                        </tr>
                                    </table>
                        <asp:Label ID="Label4" runat="server" Font-Names="Calibri" ForeColor="#000066" 
                            Text="Concepto:" Font-Size="10pt" Visible="False" meta:resourcekey="Label4Resource1"></asp:Label>
                        <asp:textbox id="Txtcconcepto" Font-Size="8pt" Font-Names="Verdana" 
                            runat="server" Enabled="False"
								Width="46px" Height="26px" TextMode="MultiLine" style="margin-left: 0px" Visible="False" 
                                        meta:resourcekey="TxtcconceptoResource1"></asp:textbox>
							                    <asp:dropdownlist id="cmbCatalago" runat="server" Width="251px" 
                                                    Font-Names="Verdana" Font-Size="8pt"
								Enabled="False" AutoPostBack="True" Height="67px" style="margin-bottom: 9px" Visible="False" 
                                        meta:resourcekey="cmbCatalagoResource1"></asp:dropdownlist>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style37">
                            <tr>
                                <td align="center">
                                    <INPUT id="btnnew" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
					type="button" name="Button3" runat="server"></td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <INPUT id="btnsave" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
					type="button" name="Button4" runat="server"></td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <INPUT id="btncancel" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
					type="button" name="Button5" runat="server" visible="False"></td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <INPUT id="btnedit" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_editar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
					type="button" name="Button6" runat="server" visible="False"></td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <INPUT id="btnprint" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server"></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style3">
			<asp:datagrid id="Dgdetalle" Width="550px" runat="server" BackColor="White" 
                Height="74px" AllowSorting="True"
					CellPadding="3" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC" 
                AutoGenerateColumns="False" meta:resourcekey="DgdetalleResource1">
                <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999">
                </SelectedItemStyle>
                <ItemStyle ForeColor="#000066"></ItemStyle>
                <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699">
                </HeaderStyle>
                <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                <Columns>
                    <asp:ButtonColumn Text="Seleccionar" CommandName="Select" 
                        meta:resourcekey="ButtonColumnResource1">
                        <HeaderStyle Font-Names="Californian FB" ForeColor="Blue"></HeaderStyle>
                        <ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" ForeColor="Blue">
                        </ItemStyle>
                    </asp:ButtonColumn>
                    <asp:TemplateColumn SortExpression="IdCuenta" HeaderText="No">
                        <HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
                        <ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top">
                        </ItemStyle>
                        <ItemTemplate>
                            <asp:HyperLink id=HyperLink1 runat="server" 
                                Text='<%# DataBinder.Eval(Container, "DataItem.IdCuenta") %>' 
                                NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.IdCuenta", URLCodigo) %>' 
                                Target="_self" meta:resourcekey="HyperLink1Resource1"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="cCodcta" SortExpression="cCodcta" HeaderText="Cuenta">
                        <HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
                        <ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top">
                        </ItemStyle>
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="cdescri" HeaderText="Descripción" 
                        SortExpression="cdescri">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Arial" 
                            Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" 
                            Wrap="False" />
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Century Gothic" 
                            Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Left" VerticalAlign="Top" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="nDebe" SortExpression="nDebe" HeaderText="Cargos" 
                        DataFormatString="{0:###,##0.00}">
                        <HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
                        <ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top">
                        </ItemStyle>
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="nHaber" SortExpression="nHaber" HeaderText="Abonos" 
                        DataFormatString="{0:###,##0.00}">
                        <HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
                        <ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top">
                        </ItemStyle>
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="cConcepto" HeaderText="Concepto" 
                        SortExpression="cConcepto">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="arial" 
                            Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Century Gothic" 
                            Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Left" VerticalAlign="Top" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="idcuenta" HeaderText="Linea" 
                        SortExpression="idcuenta"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ffondos" HeaderText="Id Fondo" 
                        SortExpression="ffondos">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Arial" 
                            Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Century Gothic" 
                            Font-Overline="False" Font-Size="XX-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Left" VerticalAlign="Top" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ccodofi" HeaderText="Oficina" 
                        SortExpression="ccodofi">
                        <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                            Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                            Font-Underline="False" />
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                            Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                            Font-Underline="False" />
                    </asp:BoundColumn>
                    <asp:ButtonColumn CommandName="Delete" Text="Eliminar" 
                        meta:resourcekey="ButtonColumnResource2">
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="calibri" 
                            Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                            Font-Underline="False" />
                    </asp:ButtonColumn>
                </Columns>
                <PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages">
                </PagerStyle>
            </asp:datagrid>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style15">
			<TABLE id="Table4" cellSpacing="0" cellPadding="0" border="0" align="center">
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 311px; FONT-FAMILY: 'Century Gothic'">
						<P align="right" style="COLOR: #16387c; FONT-STYLE: normal">
			                <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" Text="XLS" 
                                Visible="False" />
			<asp:textbox id="TxtComodin" Width="56px" runat="server" Font-Names="Verdana" Font-Size="8pt"
				Height="16px" Visible="False" meta:resourcekey="TxtComodinResource1"></asp:textbox>
			<asp:textbox id="TxtBandera" Width="56px" runat="server" Font-Names="Verdana" Font-Size="8pt"
				Height="16px" Visible="False" style="margin-bottom: 0px" meta:resourcekey="TxtBanderaResource1"></asp:textbox>
			                TOTALES&nbsp;:</P>
					</TD>
					<TD><asp:textbox id="TxtTotDebe" Font-Size="X-Small" Font-Names="Verdana" 
                            BackColor="White" runat="server"
							Enabled="False" Width="104px" meta:resourcekey="TxtTotDebeResource1"></asp:textbox>
                        <asp:textbox id="TxtTotHaber" Font-Size="X-Small" Font-Names="Verdana" 
                            BackColor="White" runat="server"
							Enabled="False" Width="104px" BorderColor="White" Font-Bold="True" 
                            meta:resourcekey="TxtTotHaberResource1"></asp:textbox></TD>
					<TD style="font-family: Calibri; font-size: 12px">Dif.<asp:textbox 
                            id="Txtdiferencia" Font-Size="X-Small" Font-Names="Verdana" 
                            BackColor="White" runat="server"
							Enabled="False" Width="104px" BorderColor="White" Font-Bold="True" ForeColor="Maroon" 
                            meta:resourcekey="TxtdiferenciaResource1"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	</TABLE>
