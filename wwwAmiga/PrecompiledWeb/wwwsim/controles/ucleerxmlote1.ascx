<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="ucleerxmlote1, App_Web_v6ddqlgy" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<HEAD runat =server >


    <style type="text/css">
        .style1
        {
            width: 91%;
            height: 176px;
        }
        #Table1
        {
            height: 409px;
            width: 86%;
        }
        .style14
        {
            width: 110%;
            height: 580px;
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
        .style24
        {
            width: 178px;
        }
        .style26
        {
            width: 51%;
            height: 69px;
        }
        .style27
        {
            width: 146px;
        }
        .style28
        {
            width: 172px;
        }
        .style29
        {
            width: 69%;
        }
        .style30
        {
            width: 180px;
        }
        .style31
        {
            width: 178px;
            height: 36px;
        }
        .style32
        {
            height: 36px;
        }
        </style>
</HEAD>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<TABLE  id="Table1" cellSpacing="0" cellPadding="0" border="1" 
    style="OVERFLOW: visible; WIDTH: 589px; HEIGHT: 442px">
	<TR>
		<TD align="center" 
            style="border: thin solid highlight; BACKGROUND-COLOR: #ffffff" 
            class="style16">
            <table cellpadding="0" cellspacing="0" class="style14" align="center">
                <tr>
                    <td align="center" class="style17">
						<asp:label id="Label3" runat="server" Width="368px" Font-Bold="True" 
                            Font-Size="Medium" Height="15px"
							Font-Names="Century Gothic" ForeColor="#16387C" BackColor="Yellow" BorderWidth="2px">PAGOS 
                        EN LOTE POR CENTRO</asp:label>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td align="right" class="style24">
                        <asp:label id="Label7" Font-Size="12pt" Width="63px" Font-Names="Calibri" 
                            runat="server">Centro:</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtcentro" runat="server" Enabled="False" 
                                        Font-Names="Calibri" Font-Size="12pt" Height="25px" Width="280px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style24">
						<asp:label id="Label39" runat="server" Width="195px" Font-Size="12pt" Height="15px" 
                                        Font-Names="Calibri">Fecha de Proceso contable:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtfecbar" tabIndex="5" runat="server" Width="83px" 
                                        Font-Size="12pt" Font-Names="Calibri"
							BorderWidth="1px"></asp:textbox>
                                    <cc1:CalendarExtender ID="txtfecbar_CalendarExtender" runat="server" 
                                        TargetControlID="txtfecbar" Format="dd/MM/yyyy">
                                    </cc1:CalendarExtender>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style24">
                                    <asp:label id="Label38" runat="server" Width="147px" Font-Size="12pt" 
                                        Height="15px" Font-Names="Calibri">Total a Aplicar:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtaaplicar" tabIndex="5" runat="server" Width="94px" 
                                        Font-Size="12pt" Font-Names="Calibri"
							BorderWidth="1px" Enabled="False" Height="20px"></asp:textbox>
                                 
                                  
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style31">
                                    <asp:label id="Label43" runat="server" Width="147px" Font-Size="12pt" 
                                        Height="15px" Font-Names="Calibri">Tipo de Pago:</asp:label>
                                </td>
                                <td class="style32">
						<asp:dropdownlist id="cmbtippag" runat="server" Width="306px" Height="16px" 
                                        Font-Names="Calibri" Font-Size="12pt"></asp:dropdownlist>
                                 
                                  
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style24">
                                    <asp:label id="Label41" runat="server" Width="147px" Font-Size="12pt" 
                                        Height="15px" Font-Names="Calibri">Banco:</asp:label>
                                </td>
                                <td>
						<asp:dropdownlist id="cmbbanco" runat="server" Width="306px" Height="16px" 
                                        Font-Names="Calibri" Font-Size="12pt"></asp:dropdownlist>
                                 
                                  
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style24">
                                    <asp:label id="Label42" runat="server" Width="147px" Font-Size="12pt" 
                                        Height="15px" Font-Names="Calibri">Nº Recibo:</asp:label>
                                </td>
                                <td>
						            <asp:textbox id="txtcompro" tabIndex="5" Font-Size="12pt" Font-Names="Calibri" 
                                        Width="111px" runat="server"
							BorderWidth="1px" Enabled="False">0</asp:textbox>
                                 
                                  
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style24">
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
                                <td align="right" class="style24">
                                    <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" 
                                        Font-Names="Calibri" Font-Size="10pt" GroupName="Anexos" Text="Excedente" />
                                    <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Calibri" 
                                        Font-Size="10pt" GroupName="Anexos" Text="Faltante" />
                                </td>
                                <td>
                                    <asp:textbox id="txtaaplicar0" tabIndex="5" runat="server" Width="94px" 
                                        Font-Size="12pt" Font-Names="Calibri"
							BorderWidth="1px" Height="20px"></asp:textbox>
                                 
                                  
                                &nbsp;
                                    <asp:Button ID="Button1" runat="server" Font-Names="Calibri" 
                                        Text="Distribuir" />
                                </td>
                            </tr>
                        </table>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
                        <asp:datagrid id="datagrid1" runat="server" 
                            Width="536px" AllowSorting="True" AutoGenerateColumns="False"
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
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Codigo de Prestamo">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
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
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="nCuota" SortExpression="nCuota" HeaderText="Cuota" 
                            DataFormatString="{0:C}">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="npago" SortExpression="npago" HeaderText="Pago" 
                            DataFormatString="{0:C}">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" 
                                HorizontalAlign="Center" VerticalAlign="Top" BackColor="#3535FF" 
                                Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" ForeColor="White"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="ndeuda" DataFormatString="{0:C}" 
                            HeaderText="Deuda al día" SortExpression="ndeuda">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Verdana" 
                                Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                Font-Underline="False" />
                            <ItemStyle BackColor="#990000" Font-Bold="False" Font-Italic="False" 
                                Font-Names="Century Gothic" Font-Overline="False" Font-Size="XX-Small" 
                                Font-Strikeout="False" Font-Underline="False" ForeColor="White" 
                                HorizontalAlign="Center" VerticalAlign="Top" ></ItemStyle>
                        </asp:BoundColumn>
						<asp:BoundColumn DataField="lsolidario" SortExpression="lsolidario" 
                            HeaderText="Solidario?">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					    <asp:BoundColumn DataField="codigo" SortExpression="codigo"></asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#2461BF" 
                            Wrap="False"></PagerStyle>
				</asp:datagrid>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
						<table class="style26">
                            <tr>
                                <td class="style27">
                        <asp:label id="Label40" Font-Size="8pt" Width="63px" Font-Names="Century Gothic" 
                            runat="server">A pagar:</asp:label>
                                            </td>
                                <td class="style28">
                                                <asp:TextBox ID="txtnpago" runat="server" Font-Names="Century Gothic" 
                                                    Font-Size="8pt" Height="24px" Width="50px"></asp:TextBox>
                                            </td>
                                <td>
                                                <asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Century Gothic" 
                                                    Font-Size="8pt" Text="Solidario" />
                                            </td>
                                <td>
                                    <INPUT id="btnimprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></td>
                            </tr>
                        </table>
                        </td>
                </tr>
                <tr>
                    <td>
                        <table align="center" border="2" cellpadding="0" cellspacing="0" 
                            class="style29" style="border-color: #000066">
                            <tr>
                                <td align="center">
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="49px" 
                                        ImageUrl="~/web/jpgs/btn_guardar2_b.gif" Width="62px" />
                                    <cc1:ConfirmButtonExtender ID="ImageButton1_ConfirmButtonExtender" 
                                        runat="server" ConfirmText="Desea Aplicar Pagos?" Enabled="True" 
                                        TargetControlID="ImageButton1">
                                    </cc1:ConfirmButtonExtender>
                                </td>
                                <td align="center" class="style30">
                                     <INPUT id="btnRecibo" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: #ffffff"
				           type="button" name="Button3" runat="server"></td>
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
