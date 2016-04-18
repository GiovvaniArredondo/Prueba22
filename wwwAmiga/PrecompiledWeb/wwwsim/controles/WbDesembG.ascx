<%@ control language="vb" autoeventwireup="false" inherits="WbDesembG1, App_Web_mb_xwoah" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
  <script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
    <script type="text/javascript">
        function Fechas(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32)
                return true;
            else if (charCode >= 47 && charCode <= 57)
                return true;

            return false;
        }

        function SoloNumeros(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32 || charCode == 46)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;

            return false;
        }
        

    </script>

<style type="text/css">
    .style1
    {
        height: 188px;
    }
    .style2
    {
        height: 31px;
    }
    .style3
    {
        width: 207px;
        height: 34px;
    }
    .style4
    {
        height: 34px;
    }
    .style5
    {
        width: 89%;
        height: 68px;
    }
    .style6
    {
        height: 9px;
    }
    .style7
    {
        height: 66px;
    }
    .style8
    {
        height: 22px;
    }
    .style9
    {
        width: 207px;
        height: 33px;
    }
    .style10
    {
        height: 33px;
    }
</style>

<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 536px; HEIGHT: 318px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="536" border="0">
	<TR>
		<TD align="center" class="style1">
			<asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Names="Gill Sans MT" 
                Font-Size="14pt" ForeColor="#003366" Text="DESEMBOLSO DE CREDITOS GRUPALES"></asp:Label>		    
		    <br />
		    <br />
            <asp:DataGrid ID="dgGarantias" runat="server" AllowSorting="True" 
                AutoGenerateColumns="False" BackColor="White" BorderColor="#000099" 
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="121px" 
                Width="654px">
                <SelectedItemStyle BackColor="SkyBlue" Font-Bold="True" ForeColor="White" />
                <ItemStyle ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <Columns>
                
                <asp:ButtonColumn Text="Seleccionar" CommandName="Select">
									<ItemStyle Font-Size="10pt" Font-Names="Gill Sans MT"></ItemStyle>
								</asp:ButtonColumn>
           
                    <asp:BoundColumn DataField="cnudotr" HeaderText="Cuenta" 
                        SortExpression="cnudotr">
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" Wrap="False" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" Wrap="False" />
                        <FooterStyle Wrap="False" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="cnomcli" HeaderText="Cliente" 
                        SortExpression="cnomcli">
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" Wrap="False" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" Wrap="False" />
                        <FooterStyle Wrap="False" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="nsaldnind" HeaderText="Garantia Liquida" 
                        SortExpression="nsaldnind">
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" Wrap="False" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" Wrap="False" />
                        <FooterStyle Wrap="False" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="MontoSugerido" HeaderText="Monto Solicitado" 
                        SortExpression="MontoSugerido">
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" Wrap="False" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <FooterStyle Wrap="False" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="Diferencia" HeaderText="Diferencia" 
                        SortExpression="Diferencia">
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" Wrap="False" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" Wrap="False" />
                        <FooterStyle Wrap="False" />
                    </asp:BoundColumn>
                </Columns>
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" 
                    Mode="NumericPages" Wrap="False" />
            </asp:DataGrid>
            <br />
            <br />
		</TD>
	</TR>
	<TR>
		<TD class="style2">
				<TABLE id="Table8" style="WIDTH: 635px; HEIGHT: 119px; margin-top: 0px;" 
                    cellSpacing="0" cellPadding="0"
					border="0">
					<TR>
						<TD style="WIDTH: 207px; HEIGHT: 22px" align="right"><asp:label id="Label13" Font-Size="10pt" runat="server" Width="32px" 
                                Font-Names="Gill Sans MT">Grupo:</asp:label>&nbsp;&nbsp;&nbsp;&nbsp; </TD>
						<TD style="HEIGHT: 22px">
                            <SELECT id="cbxgrupos" style="FONT-SIZE: 12px; WIDTH: 333px; FONT-FAMILY: Gill Sans MT"
								name="cbxanacre" runat="server" onclick="return cbxgrupos_onclick()">
								<OPTION selected></OPTION>
							</SELECT></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 207px; HEIGHT: 22px" align="right">
							<asp:label id="Label31" Font-Size="10pt" runat="server" Width="69px" 
                                Font-Names="Gill Sans MT">Concepto: </asp:label></TD>
						<TD style="HEIGHT: 22px"><asp:textbox id="cGlosa" Font-Size="X-Small" runat="server" Width="398px" Font-Names="Verdana"
							Height="48px" TextMode="MultiLine"></asp:textbox></TD>
					</TR>
					<TR>
						<TD align="right" class="style3">
							<asp:label id="Label32" Font-Size="10pt" runat="server" Width="163px" 
                                Font-Names="Gill Sans MT">Monto Aprobado:</asp:label></TD>
						<TD class="style4">
                                                <asp:textbox id="txtnMonApr" runat="server" Width="92px" 
                                                    Font-Names="Century Gothic" Font-Size="10pt"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 207px; HEIGHT: 22px" align="right">
                            <asp:RadioButton ID="RadioButton1" runat="server" Font-Names="Gill Sans MT" 
                                GroupName="Forma" Text="Un cheque por Miembro" Checked="True" 
                                AutoPostBack="True" Visible="False" />
                        </TD>
						<TD style="HEIGHT: 22px">
                            <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Gill Sans MT" 
                                GroupName="Forma" Text="Un cheque por Grupo" AutoPostBack="True" 
                                Visible="False" />
                        </TD>
					</TR>
					<TR>
						<TD style="WIDTH: 207px; HEIGHT: 22px" align="right">
							<asp:label id="Label33" Font-Size="10pt" runat="server" Width="163px" 
                                Font-Names="Gill Sans MT">Cheque a Nombre de:</asp:label>
                        </TD>
						<TD style="HEIGHT: 22px">
                            <SELECT id="cbxclientes" style="FONT-SIZE: 12px; WIDTH: 333px; FONT-FAMILY: Gill Sans MT"
								name="cbxanacre0" runat="server">
								<OPTION selected></OPTION>
							</SELECT></TD>
					</TR>
					<TR>
						<TD align="right" class="style9">
							<asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Gill Sans MT" 
                                Text="Cheque a Terceros:" />
                        </TD>
						<TD class="style10">
                            <asp:TextBox ID="txtcnomchq" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="23px" Width="330px"></asp:TextBox>
                        </TD>
					</TR>
					<TR>
						<TD align="right" class="style9">
                                        <asp:label id="Label45" runat="server" Width="80px" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt">Monto Cuota:</asp:label>
                        </TD>
						<TD class="style10">
                                        <asp:textbox id="txtnmoncuo" runat="server" Width="81px" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"
								BorderWidth="1px" Enabled="False" Height="18px">0.00</asp:textbox>
                        </TD>
					</TR>
					<TR>
						<TD style="WIDTH: 207px; HEIGHT: 22px" align="right">
						<P style="FONT-WEIGHT: normal; FONT-SIZE: 12pt; COLOR: Red ; FONT-STYLE: normal; FONT-FAMILY: 'Arial Helvetica'"
							>Forma&nbsp; de Desembolso</P>
					    </TD>
						<TD style="HEIGHT: 22px">
                            <asp:dropdownlist id="cmbtippag" Font-Size="10pt" runat="server" 
                                Width="120px" Font-Names="calibri" AutoPostBack="True"></asp:dropdownlist>
                            <asp:textbox id="TxtCapita" Font-Size="10pt" runat="server" Width="95px" Font-Names="Verdana"
								BorderWidth="1px" Enabled="False" Height="23px" Visible="False"></asp:textbox>
                            </TD>
					</TR>
					<TR>
						<TD style="WIDTH: 207px; HEIGHT: 22px" align="right">
                            <asp:textbox id="TxtDocumento" Font-Size="10pt" runat="server" Width="36px" Font-Names="Verdana"
								BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox>
                            <asp:textbox id="TextBox10" runat="server" Width="85px" Font-Names="Verdana" BorderWidth="1px"
							Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TextBox9" 
                                runat="server" Width="84px" Font-Names="Verdana" BorderWidth="1px"
							Enabled="False" Visible="False"></asp:textbox>
                        </TD>
						<TD style="HEIGHT: 22px">
                            <asp:textbox id="TxtCodcli" runat="server" Width="30px" Font-Names="Verdana" BorderWidth="1px"
							Enabled="False" Height="16px" Visible="False"></asp:textbox>
                            <asp:textbox id="txtCodigo" Font-Size="10pt" runat="server" Width="34px" Font-Names="Verdana"
							Enabled="False" Visible="False" Height="16px"></asp:textbox>
                            <asp:textbox id="TxtDesembolso" Font-Size="10pt" runat="server" 
                                Width="29px" Font-Names="Verdana"
								BorderWidth="1px" Enabled="False" AutoPostBack="True" Height="16px" Visible="False"></asp:textbox>
                            <asp:textbox id="TxtDescuento" Font-Size="10pt" runat="server" Width="53px" Font-Names="Verdana"
								BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox>
                            <asp:textbox id="TextBox5" runat="server" Width="38px" Font-Names="Verdana" BorderWidth="1px"
							Enabled="False" Height="17px" Visible="False"></asp:textbox>
                            <asp:textbox id="TextBox6" runat="server" Width="94px" Font-Names="Verdana" BorderWidth="1px"
							Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TextBox7" 
                                runat="server" Width="30px" Font-Names="Verdana" BorderWidth="1px"
							Enabled="False" Height="19px" Visible="False"></asp:textbox>
                            <asp:textbox id="txtIVA" runat="server" Width="21px" Font-Names="Verdana" 
                                BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox>
                            <asp:textbox id="TxtNomcli" runat="server" Width="26px" Font-Names="Verdana" BorderWidth="1px"
								Enabled="False" Height="20px" Visible="False"></asp:textbox>
                            <asp:TextBox ID="txtdfecvig" runat="server" Height="16px" Visible="False" 
                                Width="64px"></asp:TextBox>
                        </TD>
					</TR>
					</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: #ffffff; FONT-FAMILY: 'Century Gothic'; " 
            align="center" class="style6">
							<asp:HiddenField ID="HiddenField1" runat="server" />
		</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: #ffffff; FONT-FAMILY: 'Century Gothic'; " 
            align="center" class="style6">
							<asp:label id="Label35" Font-Size="12pt" runat="server" Width="284px" 
                                Font-Names="Gill Sans MT" Font-Bold="True" ForeColor="#003366">Comisión Grupal:</asp:label>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: #ffffff; FONT-FAMILY: 'Century Gothic'; " 
            align="center" class="style7">
            <asp:datagrid id="Datagrid2" runat="server" 
                            Width="337px" BorderWidth="1px" Height="48px" BorderColor="#006699"
									BackColor="White" BorderStyle="None" CellPadding="3" AutoGenerateColumns="False" 
                            AllowSorting="True">
									<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
									<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
									<AlternatingItemStyle BackColor="#FFFF66" />
									<ItemStyle ForeColor="#000066"></ItemStyle>
									<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
									<Columns>
										<asp:BoundColumn DataField="cdescri" SortExpression="cdescri" 
                                            HeaderText="Comision">
											<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
												VerticalAlign="Top" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
											<ItemStyle Font-Size="X-Small" Font-Names="Century Gothic" 
                                                HorizontalAlign="Center" VerticalAlign="Top" Font-Bold="False" 
                                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                                Font-Underline="False"></ItemStyle>
										</asp:BoundColumn>
										<asp:BoundColumn DataField="nmongas" SortExpression="nmongas" 
                                            HeaderText="Monto">
											<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center"
												VerticalAlign="Top" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></HeaderStyle>
											<ItemStyle Font-Size="X-Small" Font-Names="Century Gothic" 
                                                HorizontalAlign="Center" VerticalAlign="Top" Font-Bold="False" 
                                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                                Font-Underline="False"></ItemStyle>
										</asp:BoundColumn>
									</Columns>
									<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
								</asp:datagrid>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: #ffffff; FONT-FAMILY: 'Century Gothic'; " 
            align="left" class="style8">
            Clientes del Grupo/Banco:Clientes<asp:label id="Label34" Font-Size="12pt" 
                runat="server" Width="284px" 
                                Font-Names="Gill Sans MT" Font-Bold="True" ForeColor="#003366">Clientes del Grupo/Banco:</asp:label></TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: #ffffff; FONT-FAMILY: 'Century Gothic'; HEIGHT: 77px">
			<asp:datagrid id="Datagrid1" AllowSorting="True" 
                AutoGenerateColumns="False" CellPadding="3"
								BorderWidth="1px" BorderStyle="None" BorderColor="#006699" BackColor="White" 
                Height="16px" Width="639px"
								runat="server">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
								<AlternatingItemStyle BackColor="#FFFF66" />
								<ItemStyle ForeColor="#000066"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
								<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
								<Columns>
									<asp:BoundColumn DataField="ccodcta" HeaderText="Codigo Préstamo" 
                                        SortExpression="ccodcta">
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
								    <asp:BoundColumn DataField="nmonapr" HeaderText="Monto Aprobado" 
                                        SortExpression="nmonapr" DataFormatString="{0:$###,##0.00}">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
								    <asp:BoundColumn DataField="ncuoapr" HeaderText="Cuotas" 
                                        SortExpression="ncuoapr">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="cnrolin" HeaderText="Nro Linea" 
                                        SortExpression="cnrolin">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Gill Sans MT" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
							</asp:datagrid>
		</TD>
	</TR>
	<TR>
		<TD style="FONT-WEIGHT: bold; FONT-SIZE: 12pt; COLOR: powerblue; FONT-STYLE: normal; FONT-FAMILY: Gill Sans MT; HEIGHT: 14px; BACKGROUND-COLOR: #3399FF">Detalle 
			del Cheque&nbsp;u O.P.</TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: black; FONT-FAMILY: 'Century Gothic'; HEIGHT: 53px">
			<asp:textbox id="txtbandera" runat="server" Width="16px" Visible="False" Height="8px"></asp:textbox>
            <table id="Table6" align="center" border="1" cellpadding="0" cellspacing="0" 
                style="border-color: #000066; WIDTH: 455px; HEIGHT: 42px">
                <tr>
                    <td style="FONT-SIZE: 9pt; WIDTH: 183px; HEIGHT: 21px">
                        <p align="left" 
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Arial Helvetica'">
                            <asp:Label ID="Label28" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                                ForeColor="#000066" Height="16px" Width="96px">Banco:</asp:Label>
                        </p>
                    </td>
                    <td style="FONT-SIZE: 9pt; HEIGHT: 21px">
                        <p align="left" 
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Arial Helvetica'">
                            <asp:Label ID="Label29" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                                ForeColor="#000066" Height="16px" Width="96px" Visible="False">Cheque Nº</asp:Label>
                        </p>
                    </td>
                    <td style="FONT-SIZE: 9pt; HEIGHT: 21px">
                            <asp:Label ID="Label36" runat="server" Font-Names="Verdana" Font-Size="10pt" 
                                ForeColor="#000066" Height="16px" Width="96px" Visible="False">Nº de Doc.</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="WIDTH: 183px; HEIGHT: 27px">
                        <asp:DropDownList ID="cmbBancos" runat="server" BackColor="#FFFF66" 
                            Font-Names="calibri" Font-Size="10pt" Height="21px" Width="300px" 
                            AutoPostBack="True" Enabled="False">
                        </asp:DropDownList>
                    </td>
                    <td style="HEIGHT: 27px">
                        <asp:TextBox ID="Txtnrochq" runat="server" BackColor="#FFFF66" 
                            BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" MaxLength="10" 
                            Width="80px" Enabled="False" onkeypress="return SoloNumeros(event)" 
                            Visible="False"></asp:TextBox>
                    </td>
                    <td style="HEIGHT: 27px">
                        <asp:TextBox ID="Txtfactura" runat="server" BackColor="#FFFF66" 
                            BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" MaxLength="10" 
                            Width="80px" Enabled="False" Visible="False"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD style="FONT-SIZE: 10pt; COLOR: black; FONT-FAMILY: 'Century Gothic'; HEIGHT: 16px">
			<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table 
                    cellpadding="0" cellspacing="0" class="style5">
                <tr>
                    <td align="center">
                        <INPUT id="btnAplica" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" runat="server" visible="False"></td>
                    <td align="center">
                        <asp:ImageButton 
                    ID="ImageButton1" runat="server" 
                                        ImageUrl="~/web/jpgs/btn_guardar2_b.gif" 
                    Width="58px" Enabled="False" />
                                    <cc1:ConfirmButtonExtender ID="ImageButton1_ConfirmButtonExtender" 
                                        runat="server" ConfirmText="Desea Grabar Desembolso?" Enabled="True" 
                                        TargetControlID="ImageButton1">
                                    </cc1:ConfirmButtonExtender>
                                </td>
                    <td align="center">
                        <INPUT id="btnimprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(imagenes/Wzprint.bmp); WIDTH: 60px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 62px; BACKGROUND-COLOR: transparent"
					type="button" name="Button2" runat="server"></td>
                    <td align="center">
                <INPUT id="btnfactura" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 60px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 62px; BACKGROUND-COLOR: transparent"
					type="button" name="Button3" runat="server" visible="False"></td>
                    <td align="center">
                        <INPUT id="btnCancela" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server" visible="False"></td>
                </tr>
                </table>
            </P>
		</TD>
	</TR>
</TABLE>
<p align="center">
    &nbsp;</p>

