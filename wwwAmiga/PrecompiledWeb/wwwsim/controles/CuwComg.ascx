<%@ control language="vb" autoeventwireup="false" inherits="CuwComg, App_Web_mb_xwoah" %>
<style type="text/css">
    .style1
    {
        width: 618px;
    }
    .style3
    {
        width: 67%;
    }
    .style4
    {
        width: 100%;
        height: 35px;
    }
    .style5
    {
        width: 308px;
        height: 39px;
    }
    </style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 607px; HEIGHT: 219px"
	cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0" align="center">
	<TR>
		<TD class="style1">
			<TABLE id="Table2" style="WIDTH: 576px; HEIGHT: 32px" cellSpacing="0" 
                cellPadding="0" width="576"
				border="0" align="center">
				<TR>
					<TD style="WIDTH: 308px" align="center">
                        <asp:label id="Label1" runat="server" 
                            Width="360px" Font-Names="Gill Sans MT" Font-Size="12pt" BorderColor="MidnightBlue"
							BorderStyle="None" BackColor="AliceBlue" Height="16px">Detalle de Comisiones</asp:label></TD>
				</TR>
				<TR>
					<TD align="center" class="style5">
                        <table cellpadding="0" cellspacing="0" class="style4">
                            <tr>
                                <td align="right">
                                    <asp:label id="Label2" runat="server" 
                            Width="200px" Font-Names="Gill Sans MT" Font-Size="10pt"
							BorderStyle="None">Clientes:</asp:label>
                                </td>
                                <td>
                                        <asp:dropdownlist id="ddlcartera" Font-Names="Calibri" 
                                        Font-Size="10pt" runat="server" Width="287px" Height="32px" 
                                            style="margin-left: 0px; margin-right: 5px" AutoPostBack="True"></asp:dropdownlist>
                                        </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD style="WIDTH: 308px" align="center">
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
			</TABLE>
			<asp:textbox id="txtccodcta" runat="server" Width="35px" Visible="False"></asp:textbox>
            <asp:HiddenField ID="HiddenField1" runat="server" />
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
			&nbsp;</TD>
	</TR>
</TABLE>
