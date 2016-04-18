<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="ucleerxmlote, App_Web_v6ddqlgy" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<head >
    <style type="text/css">
        .style1
        {
            width: 97%;
            height: 268px;
        }
        .style2
        {
            width: 263px;
        }
        #Table1
        {
            height: 409px;
            width: 86%;
        }
        .style14
        {
            width: 119%;
            height: 578px;
        }
        .style16
        {
            height: 440px;
            width: 519px;
        }
        .style17
        {
            height: 38px;
        }
        .style30
        {
            width: 263px;
            height: 30px;
        }
        .style31
        {
            height: 30px;
        }
        .style32
        {
            width: 263px;
            height: 36px;
        }
        .style33
        {
            height: 36px;
        }
        .style34
        {
            width: 62%;
            height: 56px;
        }
        .style36
        {
            width: 263px;
            height: 39px;
        }
        .style37
        {
            height: 39px;
        }
        .style38
        {
            width: 263px;
            height: 34px;
        }
        .style39
        {
            height: 34px;
        }
        .style42
        {
            width: 71%;
        }
        .style44
        {
            height: 69px;
        }
        .style45
        {
            width: 53px;
        }
        .style46
        {
            width: 123px;
        }
        </style>
</HEAD>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="1" 
    style="OVERFLOW: visible; WIDTH: 663px; HEIGHT: 442px">
	<TR>
		<TD align="center" 
            style="border: thin solid highlight; BACKGROUND-COLOR: #ffffff" 
            class="style16">
            &nbsp;&nbsp;
            <table cellpadding="0" cellspacing="0" class="style14" align="left">
                <tr>
                    <td align="center" class="style17">
						<asp:label id="Label3" runat="server" Width="368px" Font-Bold="True" 
                            Font-Size="Medium" Height="15px"
							Font-Names="Gill Sans MT" ForeColor="#16387C" BackColor="Yellow" BorderWidth="2px">PAGOS 
                        GRUPALES </asp:label>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
						<table cellpadding="0" cellspacing="0" class="style34">
                            <tr>
                                <td align="right">
						<asp:label id="Label39" runat="server" Width="195px" Font-Size="12pt" Height="15px" 
                                        Font-Names="Gill Sans MT" Font-Bold="True">Fecha Valor:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtfecbar" tabIndex="5" runat="server" Width="83px" 
                                        Font-Size="12pt" Font-Names="Gill Sans MT"
							BorderWidth="1px" AutoPostBack="True"></asp:textbox>
                                    <cc1:MaskedEditExtender ID="txtfecbar_MaskedEditExtender" runat="server" 
                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                        Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecbar">
                                    </cc1:MaskedEditExtender>
                                    <cc1:CalendarExtender ID="txtfecbar_CalendarExtender" runat="server" 
                                        TargetControlID="txtfecbar" Format="dd/MM/yyyy">
                                    </cc1:CalendarExtender>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
						<asp:label id="Label44" runat="server" Width="195px" Font-Size="12pt" Height="15px" 
                                        Font-Names="Gill Sans MT" Font-Bold="True">Fecha Última de Pago:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtfecult" tabIndex="5" runat="server" Width="83px" 
                                        Font-Size="12pt" Font-Names="Gill Sans MT"
							BorderWidth="1px" AutoPostBack="True" Enabled="False"></asp:textbox>
                                    <cc1:CalendarExtender ID="txtfecult_CalendarExtender" runat="server" 
                                        TargetControlID="txtfecult" Format="dd/MM/yyyy">
                                    </cc1:CalendarExtender>
                                </td>
                            </tr>
                        </table>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td align="right" class="style38">
                        <asp:label id="Label7" Font-Size="12pt" Width="63px" Font-Names="Gill Sans MT" 
                            runat="server">Grupo:</asp:label>
                                </td>
                                <td class="style39">
                        <select id="cbxgrupos" style="FONT-SIZE: 12px; WIDTH: 260px; FONT-FAMILY: Gill Sans MT; margin-left: 0px; height: 35px; "
									name="cbxgrupos" runat="server" disabled="true">
									<OPTION selected></OPTION>
								</select></td>
                            </tr>
                            <tr>
                                <td align="right" class="style30">
						            </td>
                                <td class="style31">
                                                <asp:CheckBox ID="CheckBox2" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="12pt" Text="Cancelación Total " 
                            AutoPostBack="True" Font-Bold="True" />
                                            </td>
                            </tr>
                            <tr>
                                <td align="right" class="style2">
                                    <asp:label id="Label38" runat="server" Width="147px" Font-Size="12pt" 
                                        Height="15px" Font-Names="Gill Sans MT">Total a Aplicar:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtaaplicar" tabIndex="5" runat="server" Width="111px" 
                                        Font-Size="12pt" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" Height="21px"></asp:textbox>
                                 
                                  
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style36">
                                    <asp:label id="Label43" runat="server" Width="147px" Font-Size="12pt" 
                                        Height="15px" Font-Names="Gill Sans MT">Tipo de Pago:</asp:label>
                                </td>
                                <td class="style37">
						<asp:dropdownlist id="cmbtippag" runat="server" Width="306px" Height="28px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" AutoPostBack="True"></asp:dropdownlist>
                                 
                                  
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style2">
                                    <asp:label id="Label41" runat="server" Width="130px" Font-Size="12pt" 
                                        Height="16px" Font-Names="Gill Sans MT">Banco:</asp:label>
                                </td>
                                <td>
						<asp:dropdownlist id="cmbbanco" runat="server" Width="305px" Height="24px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"></asp:dropdownlist>
                                 
                                  
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style2">
                                    <asp:label id="Label42" runat="server" Width="147px" Font-Size="12pt" 
                                        Height="15px" Font-Names="Gill Sans MT">Nª Recibo:</asp:label>
                                </td>
                                <td>
						            <asp:textbox id="txtcompro" tabIndex="5" Font-Size="12pt" Font-Names="Gill Sans MT" 
                                        Width="111px" runat="server"
							BorderWidth="1px" Enabled="False"></asp:textbox>
                                 
                                  
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style32">
                                    <asp:label id="Label37" 
                            Font-Size="12pt" Font-Names="Gill Sans MT" Height="15px" Width="120px" runat="server" 
                                        Visible="False">Nº :</asp:label>
                                </td>
                                <td class="style33">
						            <asp:textbox id="txtcompro0" tabIndex="5" Font-Size="12pt" Font-Names="Gill Sans MT" 
                                        Width="111px" runat="server"
							BorderWidth="1px" Visible="False">0</asp:textbox>
                                 
                                  
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style2">
                                    <asp:label id="label_mensaje" runat="server" Width="184px" Font-Size="8pt" Height="15px" Font-Names="Verdana"
							ForeColor="Red"></asp:label>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator5" runat="server" Width="88px" Font-Size="8pt" Font-Names="Verdana"
							DESIGNTIMEDRAGDROP="1491" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecbar">Fecha 
                                    Inválida-</asp:rangevalidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style2">
                                    <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" GroupName="Anexos" Text="Excedente" />
                                    <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" GroupName="Anexos" Text="Faltante" />
                                </td>
                                <td>
                                    <asp:textbox id="txtaaplicar0" tabIndex="5" runat="server" Width="94px" 
                                        Font-Size="12pt" Font-Names="Gill Sans MT"
							BorderWidth="1px" Height="20px" style="margin-left: 9px"></asp:textbox>
                                 
                                  
                                &nbsp;<asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Distribuir" />
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style2">
                                    <asp:Button ID="Button2" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Reiniciar a Cero Valores a Pagar" />
                                </td>
                                <td align="center">
                                    <asp:Button ID="Button3" runat="server" Font-Names="Gill Sans MT" 
                                        Text="Actualizar Total a Aplicar" />
                                </td>
                            </tr>
                        </table>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
                        <asp:datagrid id="datagrid1" runat="server" 
                            Width="437px" AllowSorting="True" AutoGenerateColumns="False"
					BorderColor="#000099" BorderWidth="2px" CellPadding="4" 
                            Height="121px" ForeColor="#333333">
					        <EditItemStyle BackColor="#2461BF" />
					<SelectedItemStyle Font-Bold="True" ForeColor="#333333" BackColor="#D1DDF1"></SelectedItemStyle>
					    <AlternatingItemStyle BackColor="White" />
					<ItemStyle BackColor="#EFF3FB"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#507CD1"></HeaderStyle>
					<FooterStyle ForeColor="White" BackColor="#507CD1" Font-Bold="True"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<ItemStyle Font-Size="XX-Small" Font-Names="Gill Sans MT" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Codigo de Prestamo">
							<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Font-Bold="True" 
                                HorizontalAlign="Center" VerticalAlign="Top" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Gill Sans MT" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Codigo") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Codigo", URLCodigo) %>' Target="_self">
								</asp:HyperLink>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.codigo") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="cNomcli" SortExpression="cNomcli" HeaderText="Nombre del Cliente">
							<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Font-Bold="True" 
                                HorizontalAlign="Center" VerticalAlign="Top" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Gill Sans MT" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="nCuota" SortExpression="nCuota" HeaderText="Cuota" 
                            DataFormatString="{0:Q###,##0.00}">
							<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Font-Bold="True" 
                                HorizontalAlign="Center" VerticalAlign="Top" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
							<ItemStyle Font-Size="10pt" Font-Names="Gill Sans MT" HorizontalAlign="Left" 
                                VerticalAlign="Top" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Pago a Aplicar">
                            <EditItemTemplate>
                                <asp:TextBox runat="server" 
                                    Text='<%# DataBinder.Eval(Container, "DataItem.npago", "{0:Q###,##0.00}") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" BackColor="Yellow" 
                                    Font-Names="Gill Sans MT" Font-Size="12pt" Height="27px" 
                                    Text='<%# DataBinder.Eval(Container, "DataItem.npago") %>' Width="80px"></asp:TextBox>
                                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                    ControlToValidate="TextBox2" ErrorMessage="RangeValidator" Font-Names="Verdana" 
                                    Font-Size="8pt" MaximumValue="1000000" MinimumValue="0" Type="Double" 
                                    Width="149px">Pago a Aplicar Inválido-</asp:RangeValidator>
                            </ItemTemplate>
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                            <ItemStyle BackColor="#FFFF66" Font-Bold="False" Font-Italic="False" 
                                Font-Names="Gill Sans MT" Font-Overline="False" Font-Size="XX-Small" 
                                Font-Strikeout="False" Font-Underline="False" ForeColor="White" 
                                HorizontalAlign="Center" VerticalAlign="Top" />
                        </asp:TemplateColumn>
						<asp:BoundColumn DataField="ndeuda" DataFormatString="{0:Q###,##0.00}" 
                            HeaderText="Deuda al día" SortExpression="ndeuda">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                Font-Overline="False" Font-Size="10pt" Font-Strikeout="False" 
                                Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                            <ItemStyle BackColor="#990000" Font-Bold="False" Font-Italic="False" 
                                Font-Names="Gill Sans MT" Font-Overline="False" Font-Size="10pt" 
                                Font-Strikeout="False" Font-Underline="False" ForeColor="White" 
                                HorizontalAlign="Center" VerticalAlign="Top" ></ItemStyle>
                        </asp:BoundColumn>
						<asp:BoundColumn DataField="lsolidario" SortExpression="lsolidario" 
                            HeaderText="Solidario?">
							<HeaderStyle Font-Size="10pt" Font-Names="Gill Sans MT" Font-Bold="True" 
                                HorizontalAlign="Center" VerticalAlign="Top" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Gill Sans MT" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					    <asp:BoundColumn DataField="codigo" SortExpression="codigo">
                            <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" 
                                VerticalAlign="Top" />
                        </asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#2461BF" 
                            Wrap="False"></PagerStyle>
				</asp:datagrid>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style44">
						<table border="1" cellpadding="0" cellspacing="0" class="style42" 
                            style="border-color: #003366; height: 69px; width: 60%;">
                            <tr>
                                <td align="center">
                                    <asp:ImageButton ID="ImageButton1" runat="server" 
                                        ImageUrl="~/web/jpgs/btn_guardar2_b.gif" style="width: 53px" />
                                    <cc1:ConfirmButtonExtender ID="ImageButton1_ConfirmButtonExtender" 
                                        runat="server" ConfirmText="Desea Aplicar Pagos?" Enabled="True" 
                                        TargetControlID="ImageButton1">
                                    </cc1:ConfirmButtonExtender>
                                </td>
                                <td align="center">
                                     <INPUT id="btnRecibo" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: #ffffff"
				           type="button" name="Button3" runat="server"></td>
                                <td align="center" class="style46">
			<asp:CheckBox id="reimpresion" runat="server" Font-Names="Verdana" Font-Size="8pt" ForeColor="DarkBlue"
				Text="Re-Imprimir Recibo:" Width="148px" Height="20px"></asp:CheckBox>
                                </td>
                                <td align="center">
                                    <asp:Label ID="Label45" runat="server" Font-Names="Gill Sans MT"></asp:Label>
                                </td>
                                <td align="center" class="style45">
                                     <asp:TextBox ID="txtcnumrec" runat="server" Font-Names="Gill Sans MT" 
                                         Font-Size="10pt" Height="19px" Width="39px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtcCodsol" runat="server" Visible="False" Height="16px" 
                            Width="61px"></asp:TextBox>
                        <asp:TextBox ID="txtccomodin" runat="server" Height="19px" Visible="False" 
                            Width="53px"></asp:TextBox>
                        <asp:TextBox ID="txtflag" runat="server" Height="19px" Visible="False" 
                            Width="53px"></asp:TextBox>
                        <asp:TextBox ID="txtsocias" runat="server" Height="19px" Visible="False" 
                            Width="53px"></asp:TextBox>
						<asp:textbox id="txtflat" runat="server" Width="16px" Height="8px" 
                            Visible="False"></asp:textbox>
                        <asp:TextBox ID="txtInteres" runat="server" Height="23px" Visible="False" 
                            Width="82px"></asp:TextBox>
                        <asp:TextBox ID="txtmora" runat="server" Height="23px" Visible="False" 
                            Width="82px"></asp:TextBox>
                                    <INPUT id="btnimprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url('Web/jpgs/btn_aplicar_b.jpg'); WIDTH: 27px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 20px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server" visible="False"><asp:TextBox 
                            ID="txtnpago" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="8pt" Height="24px" Width="54px" 
                            Visible="False"></asp:TextBox><asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="8pt" Text="Solidario" Visible="False" />
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	</TABLE>
<SCRIPT language="JavaScript">
 function aplicar()
 {
 if(confirm("¿Esta seguro de continuar?"))
   alert("ok");
  else
   alert("proceso no completado");
 }
</SCRIPT>
