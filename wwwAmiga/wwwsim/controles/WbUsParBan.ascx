<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbUsParBan.ascx.vb" Inherits="WbUsParBan"  %>
<meta content="False" name="vs_snapToGrid">
<style type="text/css">
    .style2
    {
        width: 131px;
    }
    .style3
    {
        width: 100%;
    }
    .style4
    {
        width: 102px;
    }
    .style5
    {
        width: 131px;
        height: 20px;
    }
    .style6
    {
        width: 102px;
        height: 20px;
    }
    .style7
    {
        height: 20px;
    }
    .style8
    {
        width: 84px;
    }
    .style9
    {
        height: 20px;
        width: 84px;
    }
    .style10
    {
        height: 80px;
    }
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 579px; HEIGHT: 570px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD align="center"><asp:label id="Label1" Font-Bold="True" Height="15px" ForeColor="#16387C" runat="server" Width="275px"
				Font-Names="Verdana" Font-Size="Medium">PARTIDAS BANCARIAS</asp:label></TD>
	</TR>
	<TR>
		<TD style="FONT-STYLE: italic; FONT-FAMILY: 'arial elvetica'; " class="style10">
			<TABLE id="Table2" style="WIDTH: 578px; HEIGHT: 37px" cellSpacing="0" cellPadding="0" width="578"
				align="center" border="0">
				<TR>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Century Gothic'; HEIGHT: 16px">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana"
							align="center">Voucher</P>
					</TD>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Century Gothic'; HEIGHT: 16px">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana"
							align="center">Oficina</P>
					</TD>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Century Gothic'; HEIGHT: 16px">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana"
							align="center">Fecha Contable</P>
					</TD>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Century Gothic'; HEIGHT: 16px">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana"
							align="center">Nº Doc.:</P>
					</TD>
				</TR>
				<TR>
					<TD>
						<P align="center"><asp:textbox id="TxtNumpar" runat="server" Width="116px" Font-Names="Verdana" Font-Size="8pt"
								Enabled="False" BackColor="AliceBlue"></asp:textbox></P>
					</TD>
					<TD>
						<P align="center"><asp:dropdownlist id="cmbOficina" runat="server" Width="161px" Font-Names="Verdana" Font-Size="8pt"
								Enabled="False"></asp:dropdownlist></P>
					</TD>
					<TD>
						<P align="center"><asp:textbox id="TxtDate" runat="server" Width="124px" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
								AutoPostBack="True"></asp:textbox></P>
					</TD>
					<TD>
						<asp:textbox id="TxtNumdoc" Font-Size="8pt" Font-Names="Verdana" 
                            BackColor="White" runat="server"
							Enabled="False" Width="128px" Font-Bold="True" Font-Italic="True"></asp:textbox>
					</TD>
				</TR>
				<TR>
					<TD>
						&nbsp;</TD>
					<TD>
						&nbsp;</TD>
					<TD>
						<asp:rangevalidator id="RangeValidator5" runat="server" Width="88px" Font-Names="Verdana" Font-Size="8pt"
								MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="TxtDate">Fecha Inválida-</asp:rangevalidator>
					</TD>
					<TD>
						&nbsp;</TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" style="WIDTH: 576px; HEIGHT: 16px" cellSpacing="0" cellPadding="0" width="576"
				align="center" border="0">
				<TR>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: Verdana; color: #16387c; font-style: normal;" 
                        align="right">
						F.de Fondos:</TD>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Century Gothic'; HEIGHT: 19px">
						<asp:dropdownlist id="cmbFondos" runat="server" Width="184px" Font-Names="Verdana" Font-Size="8pt"
							Enabled="False" AutoPostBack="True"></asp:dropdownlist>
					</TD>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Century Gothic'; HEIGHT: 19px">
						&nbsp;</TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Century Gothic'; HEIGHT: 19px">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana"
							align="center">Banco</P>
					</TD>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Century Gothic'; HEIGHT: 19px">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana"
							align="center">Tipo de Partida</P>
					</TD>
					<TD style="FONT-SIZE: 10pt; FONT-FAMILY: 'Century Gothic'; HEIGHT: 19px">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana"
							align="center">Monto</P>
					</TD>
				</TR>
				<TR>
					<TD>
						<P align="center">
                        <asp:DropDownList ID="cmbBancos" runat="server" BackColor="#FFFF66" 
                            Font-Names="Verdana" Font-Size="8pt" Height="16px" Width="300px" 
                            AutoPostBack="True" Enabled="False">
                        </asp:DropDownList>
                        </P>
					</TD>
					<TD>
						<asp:DropDownList ID="cmbtippar" runat="server" Font-Names="Verdana" 
                            Font-Size="8pt" Height="16px" Width="175px">
                            <asp:ListItem Value="BD">BOLETA DE DEPÓSITO</asp:ListItem>
                            <asp:ListItem Value="NC">NOTA DE CRÉDITO</asp:ListItem>
                            <asp:ListItem Value="ND">NOTA DE DEBITO</asp:ListItem>
                        </asp:DropDownList>
					</TD>
					<TD>
						<asp:textbox id="TxtMonChq" runat="server" Width="107px" Font-Names="Verdana" Font-Size="8pt"
								Enabled="False" BackColor="White" AutoPostBack="True"></asp:textbox>
					</TD>
				</TR>
				<TR>
					<TD>
						&nbsp;</TD>
					<TD>
						<asp:rangevalidator id="RangeValidator2" runat="server" Width="82px" Font-Names="Verdana" Font-Size="8pt"
								MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TxtMonChq">Valor Inválido</asp:rangevalidator>
					</TD>
					<TD>
						&nbsp;</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 323px" align="center">
			<TABLE id="Table5" style="WIDTH: 552px; HEIGHT: 66px" cellSpacing="0" cellPadding="0" width="552"
				align="center" border="0">
				<TR>
					<TD style="WIDTH: 114px"><asp:checkbox id="CheckBox1" ForeColor="#16387C" 
                            runat="server" Font-Names="Verdana" Font-Size="8pt" Text="Descripción :" 
                            Checked="True"></asp:checkbox></TD>
					<TD>
						<P align="left"><asp:textbox id="TxtGlosa" Height="64px" runat="server" Width="441px" Font-Names="Verdana" Font-Size="8pt"
								Enabled="False" TextMode="MultiLine"></asp:textbox></P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 114px">&nbsp;</TD>
					<TD>
                        <asp:textbox id="Txtcconcepto" Font-Size="8pt" Font-Names="Verdana" 
                            runat="server" Enabled="False"
								Width="46px" Height="26px" TextMode="MultiLine" style="margin-left: 0px" Visible="False"></asp:textbox>
							                    <asp:dropdownlist id="cmbCatalago" runat="server" Width="251px" 
                                                    Font-Names="Verdana" Font-Size="8pt"
								Enabled="False" AutoPostBack="True" Height="67px" style="margin-bottom: 9px" Visible="False"></asp:dropdownlist>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table7" style="WIDTH: 537px; HEIGHT: 80px" cellSpacing="0" cellPadding="0"
				align="center" border="0">
				<TR>
					<TD class="style2">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana; height: 5px; width: 129px;"
							align="center">Cuenta</P>
					</TD>
					<TD class="style4">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana; width: 93px;"
							align="center">Cargo</P>
					</TD>
					<TD class="style8">
						<P style="FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: Verdana"
							align="center">Abono</P>
					</TD>
					<TD><asp:textbox id="TxtComodin" Height="10px" runat="server" Width="40px" Font-Names="Century Gothic"
							Font-Size="X-Small" Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TxtBandera" Height="12px" runat="server" Width="40px" Font-Names="Century Gothic"
							Font-Size="X-Small" Enabled="False" Visible="False"></asp:textbox>
							<asp:textbox id="Txtcdescri" Enabled="False" runat="server" 
                            Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="19px" Width="19px" Visible="False"></asp:textbox>
                                            </TD>
				</TR>
				<TR>
					<TD class="style5">
						<P align="center"><asp:textbox id="Txtccodcta" runat="server" Width="116px" Font-Names="Verdana" Font-Size="8pt"
								Enabled="False"></asp:textbox></P>
					</TD>
					<TD class="style6">
						<P align="center"><asp:textbox id="TxtnDebe" runat="server" Width="66px" 
                                Font-Names="Verdana" Font-Size="8pt"
								Enabled="False" Height="16px"></asp:textbox></P>
					</TD>
					<TD class="style9">
						<P align="center"><asp:textbox id="TxtnHaber" runat="server" Font-Names="Verdana" 
                                Font-Size="8pt" Enabled="False" Height="16px" Width="71px"></asp:textbox></P>
					</TD>
					<TD class="style7">
						<P align="center"><INPUT id="btnProcesa" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 56px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></P>
					</TD>
				</TR>
				<TR>
					<TD class="style2">
						<asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="8pt" ForeColor="Red"
								Width="150px"></asp:label>
					</TD>
					<TD class="style4">
						<asp:rangevalidator id="RangeValidator3" runat="server" Width="82px" Font-Names="Verdana" Font-Size="8pt"
								MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TxtnDebe">Valor Inválido</asp:rangevalidator>
					</TD>
					<TD class="style8">
						<asp:rangevalidator id="RangeValidator1" runat="server" Width="82px" Font-Names="Verdana" Font-Size="8pt"
								MaximumValue="1000000000" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="TxtnHaber">Valor Inválido</asp:rangevalidator>
					</TD>
					<TD>
						&nbsp;</TD>
				</TR>
			</TABLE>
			<asp:datagrid id="Dgdetalle" Width="550px" runat="server" BackColor="White" 
                Height="74px" AllowSorting="True"
					CellPadding="3" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC" 
                AutoGenerateColumns="False">
                <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999">
                </SelectedItemStyle>
                <ItemStyle ForeColor="#000066"></ItemStyle>
                <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699">
                </HeaderStyle>
                <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                <Columns>
                    <asp:ButtonColumn Text="Seleccionar" CommandName="Select">
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
                            <asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.IdCuenta") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.IdCuenta", URLCodigo) %>' Target="_self">
                            </asp:HyperLink>
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
                        DataFormatString="{0:Q###,##0.00}">
                        <HeaderStyle Font-Size="XX-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
								VerticalAlign="Top"></HeaderStyle>
                        <ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top">
                        </ItemStyle>
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="nHaber" SortExpression="nHaber" HeaderText="Abonos" 
                        DataFormatString="{0:Q###,##0.00}">
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
                    <asp:ButtonColumn CommandName="Delete" Text="Eliminar">
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                            Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                            Font-Underline="False" />
                    </asp:ButtonColumn>
                </Columns>
                <PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages">
                </PagerStyle>
            </asp:datagrid>
			<TABLE id="Table6" style="WIDTH: 399px; HEIGHT: 34px" cellSpacing="0" cellPadding="0"
				align="center" border="0">
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 501px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 47px">
						<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Arial Helvetica'"
							align="right">TOTALES&nbsp;:</P>
					</TD>
					<TD style="WIDTH: 335px; HEIGHT: 47px"><asp:textbox id="TxtTotDebe" Font-Bold="True" runat="server" Width="113px" Font-Names="Verdana"
							Font-Size="X-Small" Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 335px; HEIGHT: 47px"><asp:textbox id="TxtTotHaber" Font-Bold="True" runat="server" Width="116px" Font-Names="Verdana"
							Font-Size="X-Small" Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 335px; HEIGHT: 47px">
                        <asp:Label ID="Label3" runat="server" Font-Names="Calibri" Text="Dif."></asp:Label>
                    </TD>
					<TD style="WIDTH: 335px; HEIGHT: 47px"><asp:textbox 
                            id="Txtdiferencia" Font-Size="X-Small" Font-Names="Verdana" BackColor="White" runat="server"
							Enabled="False" Width="104px" BorderColor="White" Font-Bold="True" ForeColor="Maroon"></asp:textbox></TD>
				</TR>
			</TABLE>
			            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table cellpadding="0" cellspacing="0" class="style3">
                <tr>
                    <td>
			<INPUT id="btnnew" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 71px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
				type="button" name="Button2" runat="server"></td>
                    <td>
                        <INPUT id="btnsave" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 71px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
				type="button" name="Button3" runat="server"></td>
                    <td>
                        <INPUT id="btncancel" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 71px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
				type="button" name="Button4" runat="server"></td>
                    <td>
                        <INPUT id="btnedit" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_editar_b.jpg); WIDTH: 71px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
				type="button" name="Button5" runat="server"></td>
                    <td>
                        <INPUT id="btnprint" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 71px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
				type="button" name="Button6" runat="server"></td>
                    <td>
                        <asp:Button ID="btnrevertir" runat="server" Enabled="False" 
                            Font-Names="Calibri" Font-Size="12pt" Height="36px" Text="Revertir" 
                            Width="79px" Visible="False" />
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
</TABLE>
