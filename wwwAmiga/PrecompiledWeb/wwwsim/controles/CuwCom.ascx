<%@ control language="vb" autoeventwireup="false" inherits="CuwCom, App_Web_5wr0lfuo" %>
<style type="text/css">
    .style1
    {
        width: 618px;
    }
    .style2
    {
        width: 281px;
    }
    .style3
    {
        width: 67%;
    }
    </style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 607px; HEIGHT: 219px"
	cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0" align="center">
	<TR>
		<TD class="style1">
			<TABLE id="Table2" style="WIDTH: 449px; HEIGHT: 266px" cellSpacing="0" cellPadding="0"
				border="0" align="center">
				<TR>
					<TD style="WIDTH: 308px" align="center">
                        <asp:label id="Label1" runat="server" 
                            Width="234px" Font-Names="Gill Sans MT" Font-Size="12pt" BorderColor="MidnightBlue"
							BorderStyle="None" BackColor="AliceBlue">Detalle de Comisiones</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 308px; margin-left: 40px;" align="center">
				<asp:datagrid id="dgdetalle0" Width="351px" runat="server" BackColor="White" 
                    Height="123px" AllowSorting="True"
					CellPadding="3" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC" 
                    AutoGenerateColumns="False" Enabled="False">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="#3399FF" />
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="ccodigo" SortExpression="ccodigo" HeaderText="Nº">
						    <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" />
						</asp:BoundColumn>
						<asp:BoundColumn DataField="cdescri" HeaderText="Descripcion" 
                            SortExpression="cdescri">
                            <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundColumn>
                        <asp:TemplateColumn HeaderText="Aplicar">
                            <EditItemTemplate>
                                <asp:TextBox runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" 
                                    Checked='<%# DataBinder.Eval(Container, "DataItem.llogtab") %>' 
                                    oncheckedchanged="CheckBox2_CheckedChanged" />
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Monto">
                            <EditItemTemplate>
                                <asp:TextBox runat="server" 
                                    Text='<%# DataBinder.Eval(Container, "DataItem.nmonto") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <table cellpadding="0" cellspacing="0" class="style3">
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox6" runat="server" BackColor="Yellow" 
                                                Font-Names="Gill Sans MT" Font-Size="12pt" Height="29px" 
                                                Text='<%# DataBinder.Eval(Container, "DataItem.nmonto") %>' Width="80px" 
                                                AutoPostBack="True" ontextchanged="TextBox6_TextChanged"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RangeValidator ID="RangeValidator3" runat="server" 
                                                ControlToValidate="TextBox6" ErrorMessage="RangeValidator" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" MaximumValue="1000000" 
                                                MinimumValue="0" style="margin-left: 27px; margin-top: 0px" Type="Double" 
                                                Width="96px">Monto Inválido-</asp:RangeValidator>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:TemplateColumn>
						<asp:BoundColumn DataField="ngasori" HeaderText="Descuento Original" 
                            SortExpression="ngasori">
                            <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid>
                    </TD>
				</TR>
				<TR>
					<TD style="WIDTH: 308px" align="center">
				        <table cellpadding="0" cellspacing="0" class="style3">
                            <tr>
                                <td align="right">
                                    <asp:label id="Label2" runat="server" 
                            Width="145px" Font-Names="Gill Sans MT" Font-Size="12pt" BorderColor="MidnightBlue"
							BorderStyle="None" BackColor="AliceBlue" Height="19px">Deuda a Descontar:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtDeuda" runat="server" 
                            Width="135px" Font-Names="Gill Sans MT" BorderWidth="1px"
										Enabled="False" Font-Size="14pt" Height="29px"></asp:textbox>
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD style="WIDTH: 308px" align="center">
				        &nbsp;</TD>
				</TR>
			</TABLE>
			<asp:textbox id="txtccodcta" runat="server" Width="35px" Visible="False"></asp:textbox></TD>
	</TR>
	<TR>
		<TD class="style1">
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td align="right" class="style2">
                        <asp:label id="Label10" runat="server" Width="160px" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="21px" Visible="False">Cuantos cheques a Emitir:</asp:label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="70px" 
                            Font-Names="Gill Sans MT" Visible="False"></asp:TextBox>
                    &nbsp;<asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" Height="26px" 
                            Text="Aplicar" Width="82px" Font-Size="12pt" Visible="False" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style2">
                        &nbsp;</td>
                    <td>
                        <asp:rangevalidator id="RangeValidator1" runat="server" Width="149px" 
                            Font-Names="Gill Sans MT" Font-Size="10pt"
								ErrorMessage="RangeValidator" ControlToValidate="TextBox1" MaximumValue="5" MinimumValue="1"
								Type="Double">Número Erroneo</asp:rangevalidator>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD class="style1">
			<DIV align="center">
				<asp:datagrid id="Dgdetalle" Width="351px" runat="server" BackColor="White" 
                    Height="123px" AllowSorting="True"
					CellPadding="3" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC" 
                    AutoGenerateColumns="False" Enabled="False">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="cnrodoc" SortExpression="cnrodoc" HeaderText="Nº">
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Nombre">
                            <EditItemTemplate>
                                <asp:TextBox runat="server" 
                                    Text='<%# DataBinder.Eval(Container, "DataItem.cnomchq") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" BackColor="#FFCC00" 
                                    Font-Names="Gill Sans MT" Height="26px" Width="209px" 
                                    Text='<%# DataBinder.Eval(Container, "DataItem.cnomchq") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:TemplateColumn HeaderText="Monto">
                            <EditItemTemplate>
                                <asp:TextBox runat="server" 
                                    Text='<%# DataBinder.Eval(Container, "DataItem.nmonto") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <table cellpadding="0" cellspacing="0" class="style3">
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox2" runat="server" BackColor="Yellow" 
                                                Font-Names="Gill Sans MT" Font-Size="12pt" Height="29px" 
                                                Text='<%# DataBinder.Eval(Container, "DataItem.nmonto") %>' Width="80px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:RangeValidator ID="RangeValidator2" runat="server" 
                                                ControlToValidate="TextBox2" ErrorMessage="RangeValidator" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" MaximumValue="1000000" 
                                                MinimumValue="1" style="margin-left: 27px; margin-top: 0px" Type="Double" 
                                                Width="96px">Monto Inválido-</asp:RangeValidator>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateColumn>
						<asp:BoundColumn DataField="ccodcta" SortExpression="ccodcta" 
                            HeaderText="Cuenta">
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</TD>
	</TR>
	<TR>
		<TD class="style1" align="center">
			<asp:Button ID="Button2" runat="server" Font-Names="Gill Sans MT" Height="30px" 
                            Text="Grabar" Width="112px" Font-Size="12pt" Visible="False" />
                    </TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
			<TABLE id="Table6" style="WIDTH: 562px; HEIGHT: 22px" cellSpacing="0" cellPadding="0" width="562"
				border="0">
				<TR>
					<TD style="WIDTH: 227px"><asp:checkbox id="CheckBox1" runat="server" Width="232px" 
                            Font-Names="Gill Sans MT" Font-Size="9pt"
							ForeColor="MidnightBlue" Text="Cheque a Tercero a Nombre de:" AutoPostBack="True" 
                            Visible="False"></asp:checkbox></TD>
					<TD><asp:textbox id="txtcNomchq" runat="server" Width="312px" 
                            Font-Names="Century Gothic" Font-Size="10pt"
							BorderWidth="1px" Enabled="False" MaxLength="120" Visible="False"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
