<%@ Control Language="vb" AutoEventWireup="false" Codefile="Wbcomunal.ascx.vb" Inherits="Wbcomunal"  %>
<style type="text/css">
    .style5
    {
        width: 97%;
    }
    .style6
    {
        width: 101px;
    }
    .style7
    {
        width: 410px;
    }
    .style8
    {
        width: 141px;
    }
    .style15
    {
        width: 60%;
    }
    .style16
    {
        width: 74%;
        height: 24px;
    }
    .style18
    {
        width: 93%;
    }
    .style19
    {
        width: 91px;
    }
    .style20
    {
        width: 146px;
    }
    .style21
    {
        width: 68px;
    }
    .style22
    {
        width: 110px;
    }
    .style23
    {
        width: 77%;
    }
    .style24
    {
        width: 130px;
    }
    .style25
    {
        height: 176px;
    }
    .style26
    {
        height: 156px;
    }
    .style27
    {
        width: 90px;
    }
</style>
<table cellpadding="0" cellspacing="0" class="style15" 
    style="border: thin solid highlight; WIDTH: 657px; HEIGHT: 481px; BACKGROUND-COLOR: #ffffff">
    <tr>
        <td align="center" 
            style="font-family: Calibri; font-size: large; color: #003366; font-weight: bold;">
            ABC BANCO COMUNAL</tr>
    <tr>
        <td>
            <table cellpadding="0" cellspacing="0" class="style16">
                <tr>
                    <td class="style27">
                        <asp:label id="Label6" Font-Size="10pt" Width="96px" 
                        Font-Names="Calibri" runat="server" Height="16px" Font-Bold="True" 
                            ForeColor="#003366">Banco Comunal:</asp:label>
                    </td>
                    <td align="left">
                        <asp:textbox id="txtcnomcli" Font-Size="8pt" Width="321px" Font-Names="Verdana" runat="server"
						Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table align="left" cellpadding="0" cellspacing="0" class="style18">
                <tr>
                    <td class="style19">
                        <asp:label id="Label11" Font-Size="10pt" Width="71px" 
                        Font-Names="Calibri" runat="server" Height="16px" Font-Bold="True" 
                            ForeColor="#003366">Sucursal:</asp:label>
                    </td>
                    <td class="style20">
                        <SELECT id="cbxCodins" 
                            style="FONT-SIZE: 12px; WIDTH: 140px; FONT-FAMILY: 'Verdana'" name="cbxCodins"
								runat="server">
								<OPTION selected></OPTION>
							</SELECT></td>
                    <td class="style21">
                        <SELECT id="CbxCodOFi" style="FONT-SIZE: 12px; WIDTH: 176px; FONT-FAMILY: 'Verdana'" name="CbxCodOFi"
								runat="server">
								<OPTION selected></OPTION>
							</SELECT></td>
                    <td class="style22">
                        <INPUT id="txtNroCta" style="FONT-SIZE: 12px; WIDTH: 128px; FONT-FAMILY: 'Verdana'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtNroCta" runat="server"></td>
                    <td>
				<asp:textbox id="txtccodtmp" Font-Size="8pt" Width="54px" Font-Names="Verdana" runat="server"
					Enabled="False" Visible="False" MaxLength="18" Height="16px" style="margin-left: 0px"></asp:textbox>
                            </td>
                </tr>
                <tr>
                    <td class="style19">
                        <asp:label id="Label12" Font-Size="10pt" Width="71px" 
                        Font-Names="Calibri" runat="server" Height="16px" Font-Bold="True" 
                            ForeColor="#003366">Codigo Bco:</asp:label>
                    </td>
                    <td class="style20">
                        <INPUT id="txtcodcli" style="FONT-SIZE: 12px; WIDTH: 128px; FONT-FAMILY: 'Verdana'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtcodcli" runat="server"></td>
                    <td class="style21">
                        <asp:textbox id="TxtTipcre" Width="128px" Font-Names="Verdana" runat="server" BorderWidth="1px"
								Visible="False"></asp:textbox>
                    </td>
                    <td class="style22">
                        <asp:textbox id="TxtTipgar" Width="136px" Font-Names="Verdana" runat="server" BorderWidth="1px"
								Visible="False"></asp:textbox>
                    </td>
                    <td align="center">
                        <asp:TextBox 
                        ID="txtflag" runat="server" Height="16px" Width="40px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
				<asp:label id="lblMostrar" Font-Size="X-Small" Width="112px" Font-Names="Verdana" runat="server"
					ForeColor="#16387C" Height="16px"></asp:label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:label id="Label13" Font-Size="12pt" Width="652px" 
                        Font-Names="Calibri" runat="server" Height="16px" 
                BackColor="#FFFF66" BorderWidth="1px" Font-Bold="True" ForeColor="#003366">Datos 
            del Banco Comunal</asp:label>
        </td>
    </tr>
    <tr>
        <td class="style26">
                <table border="1" cellpadding="0" cellspacing="0" class="style5" 
                    
                style="border-color: #000099; background-color: #CCFF33; height: 142px;" 
                align="center">
                    <tr>
                        <td class="style6">
                            <asp:label id="Label1" Font-Size="8pt" Width="111px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Nombre del Banco Comunal:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox1" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black" Height="24px"></asp:textbox>
                        </td>
                        <td class="style8">
                            <asp:label id="Label8" Font-Size="8pt" Width="99px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Departamento:</asp:label>
                        </td>
                        <td>
                            <asp:dropdownlist id="cmbDep" Font-Names="Verdana" Font-Size="8pt" 
                                Enabled="False" runat="server"
								Width="165px" AutoPostBack="True" tabIndex="10"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label2" Font-Size="8pt" Width="88px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Dia de Reunión:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox2" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black"></asp:textbox>
                        </td>
                        <td class="style8">
                            <asp:label id="Label9" Font-Size="8pt" Width="86px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Municipio:</asp:label>
                        </td>
                        <td>
                            <asp:dropdownlist id="cmbMun" Font-Names="Verdana" Font-Size="8pt" 
                                Enabled="False" runat="server"
								Width="165px" AutoPostBack="True" tabIndex="11"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label3" Font-Size="8pt" Width="96px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Hora de Reunión:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox3" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black"></asp:textbox>
                        </td>
                        <td class="style8">
                            <asp:label id="Label10" Font-Size="8pt" Width="80px" 
                                Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Comunidad:</asp:label>
                        </td>
                        <td>
                            <asp:dropdownlist id="cmbCant" Font-Names="Verdana" Font-Size="8pt" 
                                Enabled="False" runat="server"
								Width="165px" tabIndex="12"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label4" Font-Size="8pt" Width="104px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Lugar de Reunión:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox4" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black"></asp:textbox>
                        </td>
                        <td class="style8">
                            &nbsp;</td>
                        <td>
                            <asp:dropdownlist id="cmbCentro" Font-Names="Verdana" Font-Size="8pt" 
                                Enabled="False" runat="server"
								Width="163px" AutoPostBack="True" tabIndex="12" Height="24px" Visible="False"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label5" Font-Size="8pt" Width="64px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Frecuencia:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox5" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black"></asp:textbox>
                        </td>
                        <td class="style8">
							<asp:label id="Label7" runat="server" Font-Names="Century Gothic" Width="87px" Font-Size="8pt"
								Height="16px" ForeColor="#000040">Activo?</asp:label>
                        </td>
                        <td>
							<asp:CheckBox id="CheckBox1" runat="server" Font-Names="8"></asp:CheckBox>
                        </td>
                    </tr>
                </table>
            </td>
    </tr>
    <tr>
        <td class="style25">
			<asp:datagrid id="Datagrid1" AllowSorting="True" 
                AutoGenerateColumns="False" CellPadding="3"
								BorderWidth="1px" BorderStyle="None" BorderColor="#006699" BackColor="White" 
                Height="16px" Width="645px"
								runat="server">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
								<AlternatingItemStyle BackColor="#FFFF66" />
								<ItemStyle ForeColor="#000066"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
								<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
								<Columns>
									<asp:ButtonColumn CommandName="Select" Text="Quitar">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Names="Verdana" Font-Size="X-Small" ForeColor="Blue" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:ButtonColumn>
									<asp:TemplateColumn SortExpression="CCODCLI" HeaderText="Codigo">
										<HeaderStyle Font-Size="X-Small" Font-Names="Calibri" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
										<ItemStyle Font-Size="X-Small" Font-Names="Calibri" HorizontalAlign="Center" ForeColor="Black"
											VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                            Font-Underline="False"></ItemStyle>
										<ItemTemplate>
											<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ccodcli") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.ccodcli", URLCodigo) %>' Target="_self">
											</asp:HyperLink>
										</ItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn DataField="cnomcli" SortExpression="cnomcli" 
                                        HeaderText="Nombre ">
										<HeaderStyle Font-Size="X-Small" Font-Names="Calibri" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Middle" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                            Font-Underline="False"></HeaderStyle>
										<ItemStyle Font-Size="X-Small" Font-Names="Calibri" HorizontalAlign="Center" 
                                            VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                            Font-Strikeout="False" Font-Underline="False"></ItemStyle>
									</asp:BoundColumn>
                                    <asp:BoundColumn DataField="cnudoci" HeaderText="Identificacion" 
                                        SortExpression="cnudoci">
                                        <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
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
								    <asp:BoundColumn DataField="ccodcli" HeaderText="ccodcli" 
                                        SortExpression="ccodcli"></asp:BoundColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
							</asp:datagrid>
		    </td>
    </tr>
    <tr>
        <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style23">
                <tr>
                    <td align="center" class="style24">
                        <INPUT id="btnAplica" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 63px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						tabIndex="9" type="button" name="Button4" runat="server"></td>
                    <td align="center" class="style8">
                        <INPUT id="btnGraba" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 66px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						disabled tabIndex="9" type="button" name="Button2" runat="server"></td>
                    <td align="center">
                        <INPUT id="btncancela" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 65px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						tabIndex="10" type="button" name="Button3" runat="server"></td>
                    <td align="center">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="52px" 
                            ImageUrl="~/web/jpgs/printer.jpg" Width="60px" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
</table>

