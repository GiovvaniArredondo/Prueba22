<%@ control language="vb" autoeventwireup="false" inherits="WbSollote, App_Web_5wr0lfuo" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<script language="javascript" type="text/javascript">
// <!CDATA[



// ]]>
</script>

<style type="text/css">

    .style8
    {
        width: 70%;
    }
    .style9
    {
        width: 619px;
    }
    .style12
    {
        width: 207px;
    }
    .style16
    {
        width: 154px;
    }
    .style15
    {
        width: 123px;
    }
    .style14
    {
        width: 165px;
    }
    .style17
    {
        width: 140px;
    }
    .style18
    {
        width: 92%;
        height: 68px;
    }
    .style19
    {
        width: 193px;
    }
    .style20
    {
        width: 257px;
    }
</style>



<table cellpadding="0" cellspacing="0" class="style8" 
    style="border: thin solid highlight; WIDTH: 525px; HEIGHT: 440px; BACKGROUND-COLOR: #ffffff">
    <tr>
        <td align="center" class="style9" 
            style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">
                        SOLICITUD DE CREDITOS GRUPAL</td>
    </tr>
    <tr>
        <td class="style9">
            <table align="center" cellpadding="0" cellspacing="0">
                <tr>
                    <td align="center" class="style20">
								<asp:RadioButton id="RadioButton1" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="10pt" Font-Bold="True"
									GroupName="tipo" Text="Individual" AutoPostBack="True" Visible="False"></asp:RadioButton>
                    </td>
                    <td class="style12">
                        <asp:textbox id="txtcnomcli" Font-Size="10pt" Width="299px" Font-Names="Gill Sans MT" runat="server"
									Font-Bold="True" Enabled="False" BorderWidth="1px" Visible="False"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style20">
								<asp:RadioButton id="RadioButton2" runat="server" Font-Names="Gill Sans MT" 
                                    Width="127px" Font-Size="10pt"
									Font-Bold="True" GroupName="tipo" Text="Grupo:" AutoPostBack="True" Checked="True" 
                            style="margin-left: 11px; margin-bottom: 3px" Height="18px"></asp:RadioButton>
                    </td>
                    <td class="style12">
                        <asp:DropDownList ID="cbxgrupos" runat="server" 
                            Font-Names="Century Gothic" Font-Size="10pt" Height="16px" Width="240px" 
                            Enabled="False">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style20">
                        &nbsp;</td>
                    <td class="style12">
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <table cellpadding="0" cellspacing="0">
                <tr>
                    <td align="right" class="style16">
                        &nbsp;</td>
                    <td class="style15">
                        &nbsp;</td>
                    <td class="style14">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style16">
                        <asp:label id="Label8" Font-Size="10pt" Width="89px" Font-Names="Gill Sans MT" 
                            runat="server" Height="16px">Solicitud:</asp:label>
                    </td>
                    <td class="style15">
                        <asp:DropDownList ID="cbxcodins" runat="server" AutoPostBack="True" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="24px" Width="128px">
                        </asp:DropDownList>
                    </td>
                    <td class="style14">
                        <select id="CbxCodOFi" 
                            style="FONT-SIZE: 12px; WIDTH: 140px; FONT-FAMILY: 'Gill Sans MT'" name="CbxCodOFi"
								runat="server">
								<OPTION selected></OPTION>
							</select></td>
                    <td>
                        <INPUT id="txtNroCta" style="FONT-SIZE: 12px; WIDTH: 138px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
								disabled type="text" size="17" name="txtNroCta" runat="server"></td>
                </tr>
                <tr>
                    <td align="right" class="style16">
                        <asp:label id="Label9" Font-Size="10pt" Width="120px" Font-Names="Gill Sans MT" 
                            runat="server">Codigo del Cliente:</asp:label>
                    </td>
                    <td class="style15">
                        <INPUT id="txtcodcli" style="FONT-SIZE: 12px; WIDTH: 130px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtcodcli" runat="server"></td>
                    <td class="style14">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style9">
				<asp:label id="lblMostrar" Font-Size="X-Small" Width="214px" 
                Font-Names="Gill Sans MT" runat="server"
					ForeColor="#16387C" Height="16px"></asp:label>
            <asp:textbox id="TxtTipcre" Font-Names="Gill Sans MT" runat="server" 
                BorderWidth="1px" Visible="False" Height="17px" Width="98px"></asp:textbox>
            <asp:textbox id="TxtTipgar" Width="90px" Font-Names="Gill Sans MT" runat="server" BorderWidth="1px"
								Visible="False" Height="17px"></asp:textbox>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:label id="Label10" Font-Size="10pt" Width="1106px" Font-Names="Gill Sans MT" 
                runat="server" BackColor="#FFFF66" BorderWidth="2px" Font-Bold="True" 
                ForeColor="#000099" Height="16px">DATOS SOLICITADOS:</asp:label>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <table align="center" cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                <tr>
                    <td class="style17">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label14" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px" Visible="False">Fuente de Fondos:</asp:label>
                    </td>
                    <td>
                        <asp:DropDownList ID="cbxprograma" runat="server" 
                            Font-Names="Century Gothic" Font-Size="10pt" Height="16px" Width="192px" 
                            Visible="False">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label16" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Asesor de Negocio:</asp:label>
                    </td>
                    <td>
                        <select id="cbxanacre" 
                            style="FONT-SIZE: 12px; WIDTH: 279px; FONT-FAMILY: 'Gill Sans MT'" disabled
								name="cbxanacre" runat="server">
								<OPTION selected></OPTION>
							</select></td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label17" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Fecha de Asignación:</asp:label>
                    </td>
                    <td>
                        <INPUT id="txtfecasi" style="FONT-SIZE: 12px; WIDTH: 130px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtfecasi" runat="server"><asp:TextBox 
                            id="txtccodtmp" runat="server" Font-Names="Gill Sans MT" Width="77px" Font-Size="10pt"
								MaxLength="18" Enabled="False" Visible="False"></asp:TextBox>
                    </td>
                </tr>
                </table>
        </td>
    </tr>
    <tr>
        <td class="style9" align="center">
				<asp:GridView ID="dgGastos" runat="server" AutoGenerateColumns="False" 
                    Font-Names="Gill Sans MT" Font-Size="10pt" 
                    Height="148px" Width="512px" CssClass="CSSTableGenerator">
                    <Columns>
                        <asp:BoundField DataField="ccodigo" HeaderText="Codigo">
                        <ControlStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#003300" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cdescri" HeaderText="Descripción">
                        <ControlStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#003300" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Aplicar">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("llogtab") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox2" runat="server" 
                                    Checked='<%# DataBinder.Eval(Container, "DataItem.llogtab") %>' />
                            </ItemTemplate>
                            <ControlStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#003300" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                    <HeaderStyle BackColor="#CCFF33" />
                </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
			<asp:datagrid id="Datagrid1" AllowSorting="True" 
                AutoGenerateColumns="False" CellPadding="3"
								BorderWidth="1px" BorderStyle="None" BorderColor="#006699" BackColor="White" 
                Height="16px" Width="254px"
								runat="server" CssClass="CSSTableGenerator">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
								<AlternatingItemStyle BackColor="#FFFF66" />
								<ItemStyle ForeColor="#000066"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
								<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
								<Columns>
									<asp:BoundColumn DataField="ccodcli" HeaderText="Codigo Cliente" 
                                        SortExpression="ccodcli">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
									<asp:BoundColumn DataField="cnomcli" SortExpression="cnomcli" 
                                        HeaderText="Nombre ">
										<HeaderStyle Font-Size="X-Small" Font-Names="Gill Sans MT" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Middle" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                            Font-Underline="False"></HeaderStyle>
										<ItemStyle Font-Size="X-Small" Font-Names="Gill Sans MT" HorizontalAlign="Center" 
                                            VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False"></ItemStyle>
									</asp:BoundColumn>
                                    <asp:BoundColumn DataField="cnudoci" HeaderText="Identificacion" 
                                        SortExpression="cnudoci">
                                        <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
								    <asp:TemplateColumn HeaderText="Monto Solicitado">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TextBox5" runat="server" 
                                                Text='<%# DataBinder.Eval(Container, "DataItem.nmonsol") %>' 
                                                BackColor="Yellow" Font-Names="Gill Sans MT" Font-Size="12pt" Height="27px" 
                                                Width="80px"></asp:TextBox>
                                            <asp:RangeValidator ID="RangeValidator2" runat="server" 
                                                ControlToValidate="TextBox5" ErrorMessage="RangeValidator" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" MaximumValue="1000000" MinimumValue="500" Type="Double" 
                                                Width="149px">Monto  Inválido-</asp:RangeValidator>
                                        </ItemTemplate>
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:TemplateColumn>
								    <asp:TemplateColumn HeaderText="Sector">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="DropDownList1" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Height="39px" Width="130px">
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Destino">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="cbxdescre" runat="server" Font-Names="Century Gothic" 
                                                Font-Size="10pt" Height="16px" Width="137px">
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:TemplateColumn>
                                    <asp:TemplateColumn HeaderText="Actividad">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="cmbactividad" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Height="16px" Width="233px">
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:TemplateColumn>
								    <asp:TemplateColumn HeaderText="Fuente de Ingreso">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="cbxfueing0" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Height="38px" Width="190px">
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:TemplateColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
							</asp:datagrid>
                                </td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                        <asp:dropdownlist id="cmbactividad" Font-Size="10pt" Width="36px" 
                            Font-Names="Gill Sans MT" runat="server"
								Enabled="False" Height="16px" Visible="False"></asp:dropdownlist>
                        <INPUT id="txtmonsol" style="FONT-SIZE: 12px; WIDTH: 130px; DIRECTION: rtl; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
									disabled type="text" size="16" name="txtmonsol" runat="server" visible="False"><select 
                id="cbxfueing" style="FONT-SIZE: 12px; WIDTH: 27px; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; height: 8px;"
								disabled name="cbxfueing" runat="server" visible="False">
								<OPTION selected></OPTION>
							</select><select id="cbxsececo" 
                            
                style="FONT-SIZE: 12px; WIDTH: 30px; FONT-FAMILY: 'Gill Sans MT'; height: 1px;" disabled
								name="cbxsececo" runat="server" visible="False">
								<OPTION selected></OPTION>
							</select><asp:DropDownList ID="cbxdescre" runat="server" 
                            Font-Names="Century Gothic" Font-Size="10pt" Height="16px" 
                Width="50px" Visible="False">
                        </asp:DropDownList>
                        <asp:label id="Label7" Font-Size="10pt" Width="63px" Font-Names="Gill Sans MT" 
                            runat="server" Height="16px" Visible="False">Cargo:</asp:label>
            <asp:HiddenField ID="HiddenField1" runat="server" />
                        <select id="cbxCargo" style="FONT-SIZE: 12px; WIDTH: 96px; FONT-FAMILY: 'Century Gothic'; height: 12px;"
									name="cbxanacre0" runat="server" visible="False">
									<OPTION selected></OPTION>
								</select><asp:DropDownList ID="cbxcentros" runat="server" AutoPostBack="True" 
                            Font-Names="Century Gothic" Font-Size="10pt" Height="16px" Width="32px" 
                            Visible="False">
                        </asp:DropDownList>
                    </td>
    </tr>
    <tr>
        <td class="style9">
            <table cellpadding="0" cellspacing="0" class="style18">
                <tr>
                    <td align="center" class="style19">
                        <INPUT id="btnAplica" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 63px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						disabled tabIndex="9" type="button" name="Button4" runat="server" visible="False"></td>
                    <td align="center">
                        <INPUT id="btnGuardar" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 63px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						disabled tabIndex="9" type="button" name="Button5" runat="server"></td>
                    <td align="center">
                        <INPUT id="btncancela" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 65px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						tabIndex="10" type="button" name="Button3" runat="server" visible="False"></td>
                </tr>
            </table>
        </td>
    </tr>
</table>

<P>&nbsp;</P>
