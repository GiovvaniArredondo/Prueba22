<%@ control language="vb" autoeventwireup="false" inherits="WbUsFueAgro, App_Web_yjxjq67i" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<style type="text/css">
    .CSSTableGenerator
    {
        width: 318px;
        height: 114px;
    }
    .style13
    {
        width: 100%;
    }
    .style12
    {
        width: 46%;
    }
    .style10
    {
        width: 97%;
    }
    .style11
    {
        height: 41px;
    }
    .style1
    {
        width: 98%;
    }
    .style2
    {
        width: 135px;
    }
    .style3
    {
        width: 108px;
    }
    </style>
    <script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
    <script type="text/javascript">
        function totalfamiliar() {
            document.getElementById('<%=txtfamtot.ClientID %>').value = parseFloat(document.getElementById('<%=txtfammes.ClientID %>').value) + parseFloat(document.getElementById('<%=txtfammes0.ClientID %>').value) + parseFloat(document.getElementById('<%=txtfamtra.ClientID %>').value) + parseFloat(document.getElementById('<%=txtfamtra0.ClientID %>').value);
            document.getElementById('<%=txtnofamtot.ClientID %>').value = parseFloat(document.getElementById('<%=txtnofammes.ClientID %>').value) + parseFloat(document.getElementById('<%=txtnofammes0.ClientID %>').value) + parseFloat(document.getElementById('<%=txtnofamtra.ClientID %>').value) + parseFloat(document.getElementById('<%=txtnofamtra0.ClientID %>').value);
        }

        function CargaMuni() {            
    	$.ajax({
  			type: "POST",
  			url: "ajax/Municipios.ashx",
  			data: "Departamento=" + document.getElementById("<%=cmbDep.ClientID %>").options[document.getElementById("<%=cmbDep.ClientID %>").selectedIndex].value,
  			success: function(html) {
  			$("#<%=cmbMun.ClientID %>").html(html);
  			 CargaComu();
  			}
  		});  		
		}
		function CargaComu() {    
    	$.ajax({
  			type: "POST",
  			url: "ajax/Comunidades.ashx",
  			data: "Municipio=" + document.getElementById("<%=cmbMun.ClientID %>").options[document.getElementById("<%=cmbMun.ClientID %>").selectedIndex].value,
  			success: function(html){
  			  $("#<%=cmbcant.ClientID %>").html(html);  			  
  			}
  		});  		
		}	
</script>
<table cellpadding="0" cellspacing="0" class="style13">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <TABLE id="Table1" style="border: thin solid highlight; WIDTH: 725px; HEIGHT: 482px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0">
                        <TR>
                            <TD style="HEIGHT: 21px">
                                <P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">
                                    FICHA TÈCNICA AGROPECUARIA</P>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                <TABLE id="Table5" style="WIDTH: 403px; HEIGHT: 45px" cellSpacing="0" 
                    cellPadding="0" align="center" border="0">
                                    <TR>
                                        <TD style="WIDTH: 328px">
                                            <P align="center">
                                                <asp:label id="Label6" Width="63px" runat="server" Font-Size="12pt" Font-Names="Gill Sans MT" 
                                Font-Bold="True" Height="19px">Cliente:</asp:label>
                                            </P>
                                        </TD>
                                        <TD style="WIDTH: 220px">
                                            <asp:textbox id="txtcnomcli" Width="323px" runat="server" Enabled="False" 
                            BorderWidth="1px" Font-Size="10pt"
					Font-Names="Gill Sans MT" Font-Bold="True" Height="27px" BorderColor="#2E6A99"></asp:textbox>
                                        </TD>
                                    </TR>
                                </TABLE>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                <asp:Label ID="Label37" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Text="Empleados" Width="139px" 
                Font-Bold="True"></asp:Label>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                                    <tr>
                                        <td align="center">
                                            <asp:Label ID="Label38" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Familiares" Width="139px" Font-Italic="True"></asp:Label>
                                        </td>
                                        <td align="center">
                                            &nbsp;</td>
                                        <td align="center">
                                            <asp:Label ID="Label39" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="NO Familiares" Width="139px" Font-Italic="True"></asp:Label>
                                        </td>
                                        <td align="center">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label40" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Hombres Permanentes:" Width="129px" Height="16px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtfammes" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server" onChange = "totalfamiliar()"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                            <cc1:NumericUpDownExtender ID="txtfammes_NumericUpDownExtender" runat="server"  
                                Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                TargetButtonUpID="" TargetControlID="txtfammes" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label48" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Hombres Permanentes:" Width="129px" Height="16px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtnofammes" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server" onChange = "totalfamiliar()"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                            <cc1:NumericUpDownExtender ID="txtnofammes_NumericUpDownExtender" runat="server" 
                                Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                TargetButtonUpID="" TargetControlID="txtnofammes" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label50" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Mujeres Permanentes:" Width="129px" Height="16px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtfammes0" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server" onChange = "totalfamiliar()"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                            <cc1:NumericUpDownExtender ID="txtfammes0_NumericUpDownExtender" runat="server"  
                                Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                TargetButtonUpID="" TargetControlID="txtfammes0" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label51" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Mujeres Permanentes:" Width="129px" Height="16px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtnofammes0" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server" onChange = "totalfamiliar()"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                            <cc1:NumericUpDownExtender ID="txtnofammes0_NumericUpDownExtender" runat="server" 
                                Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                TargetButtonUpID="" TargetControlID="txtnofammes0" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label42" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Hombres Temporales:" Width="136px" Height="20px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtfamtra" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server" onChange = "totalfamiliar()"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                            <cc1:NumericUpDownExtender ID="txtfamtra_NumericUpDownExtender" runat="server" 
                                Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                TargetButtonUpID="" TargetControlID="txtfamtra" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label49" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Hombres Temporales:" Width="136px" Height="20px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtnofamtra" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server" onChange = "totalfamiliar()"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                            <cc1:NumericUpDownExtender ID="txtnofamtra_NumericUpDownExtender" runat="server" 
                                Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                TargetButtonUpID="" TargetControlID="txtnofamtra" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label52" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Mujeres Temporales:" Width="136px" Height="20px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtfamtra0" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server" onChange = "totalfamiliar()"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                            <cc1:NumericUpDownExtender ID="txtfamtra0_NumericUpDownExtender" runat="server" 
                                Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                TargetButtonUpID="" TargetControlID="txtfamtra0" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label53" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Mujeres Temporales:" Width="136px" Height="20px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtnofamtra0" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server" onChange = "totalfamiliar()"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                            <cc1:NumericUpDownExtender ID="txtnofamtra0_NumericUpDownExtender" runat="server" 
                                Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                TargetButtonUpID="" TargetControlID="txtnofamtra0" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label44" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Total:" Width="139px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtfamtot" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label45" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Total" Width="139px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtnofamtot" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Enabled="False" runat="server"
								Width="89px" tabIndex="19" Height="28px" style="vertical-align:top" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                <asp:datagrid id="Datagrid1" Enabled="False" 
                            AllowSorting="True" AutoGenerateColumns="False" CellPadding="3"
								BorderWidth="1px" BorderStyle="None" BorderColor="#006699" BackColor="White" 
                Height="112px" Width="266px"
								runat="server" CssClass="CSSTableGenerator">
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999">
                                    </SelectedItemStyle>
                                    <ItemStyle ForeColor="#000066"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699">
                                    </HeaderStyle>
                                    <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                                    <Columns>
                                        <asp:ButtonColumn Text="Seleccionar" CommandName="Select">
                                            <HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True">
                                            </HeaderStyle>
                                            <ItemStyle Font-Size="X-Small" Font-Names="Gill Sans MT" 
                                            HorizontalAlign="Center" ForeColor="Blue"
											VerticalAlign="Top"></ItemStyle>
                                        </asp:ButtonColumn>
                                        <asp:TemplateColumn SortExpression="Nro" HeaderText="Nro">
                                            <HeaderStyle Font-Size="X-Small" Font-Names="Gill Sans MT" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
                                            <ItemStyle Font-Size="X-Small" Font-Names="Gill Sans MT" 
                                            HorizontalAlign="Center" ForeColor="Black"
											VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:HyperLink id=HyperLink1 runat="server" 
                                                Text='<%# DataBinder.Eval(Container, "DataItem.Nro") %>' 
                                                NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Nro", URLCodigo) %>' 
                                                Target="_self">
                                                </asp:HyperLink>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="cnomfue" SortExpression="cnomfue" 
                                        HeaderText="Propietario(a)">
                                            <HeaderStyle Font-Size="X-Small" Font-Names="Gill Sans MT" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
                                            <ItemStyle Font-Size="X-Small" Font-Names="Gill Sans MT" 
                                            HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        </asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" 
                                    Mode="NumericPages"></PagerStyle>
                                </asp:datagrid>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                <asp:Label ID="Label54" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Text="Datos del Terreno a Producir" Width="286px" 
                Font-Bold="True"></asp:Label>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                <table align="left" cellpadding="0" cellspacing="0" class="style12">
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Fecha de datos:" Width="139px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="TxtdFecha" Enabled="False" BorderWidth="1px" Width="96px" 
                                        runat="server" MaxLength="10"
							Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99"></asp:textbox>
                                            <cc1:MaskedEditExtender ID="TxtdFecha_MaskedEditExtender" runat="server" 
                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                        Mask="99/99/9999" MaskType="Date" TargetControlID="TxtdFecha">
                                            </cc1:MaskedEditExtender>
                                            <cc1:CalendarExtender ID="TxtdFecha_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="TxtdFecha">
                                            </cc1:CalendarExtender>
                                        </td>
                                        <td>
                                            <asp:rangevalidator id="RangeValidator1" runat="server" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" MaximumValue="01/01/3000"
							MinimumValue="01/01/1900" Type="Date" ControlToValidate="txtdFecha" ErrorMessage="RangeValidator" 
                                        Width="100px">Fecha Inválida</asp:rangevalidator>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                <table cellpadding="0" cellspacing="0" class="style10">
                                    <tr>
                                        <td align="center">
                                            <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Tipo:" Width="93px" Height="16px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbTipneg" Enabled="False" Width="131px" runat="server" Font-Names="Gill Sans MT"
							Font-Size="10pt">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label27" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Para:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbpara" Enabled="False" Width="131px" runat="server" Font-Names="Gill Sans MT"
							Font-Size="10pt">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label28" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Propietario:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="txtpropietario" Enabled="False" BorderWidth="1px" 
                                        Height="22px" Width="152px" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label29" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Direccion Propietario:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="Txtdireccion" Enabled="False" BorderWidth="1px" Height="39px" 
                                        Width="152px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        TextMode="MultiLine" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label35" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Tipo de Medida:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbmedida0" Enabled="False" Width="131px" runat="server" Font-Names="Gill Sans MT"
							Font-Size="10pt">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style11">
                                                        <asp:Label ID="Label46" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Medida de la Cuerda:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td class="style11">
                                                        <asp:dropdownlist id="cmbmedida" Enabled="False" Width="131px" runat="server" Font-Names="Gill Sans MT"
							Font-Size="10pt">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td class="style11">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label47" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Cantidad:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="txtcantidad" Enabled="False" BorderWidth="1px" Height="24px" 
                                        Width="81px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td align="center">
                                            <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label30" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Estado:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbDep" Enabled="False" 
                            Width="170px" runat="server" onchange="CargaMuni();" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="16px" AutoPostBack="True">
                                                        </asp:dropdownlist>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label31" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Municipio:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbMun" Enabled="False" 
                            Width="170px" runat="server" onchange="CargaComu();" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="16px" AutoPostBack="True">
                                                        </asp:dropdownlist>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label32" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Colonia:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbcant" Enabled="False" 
                            Width="169px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Height="16px">
                                                        </asp:dropdownlist>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label33" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Direccion del Terreno:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtDirec" Enabled="False" BorderWidth="1px" Height="56px" 
                                        Width="152px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        TextMode="MultiLine" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                &nbsp;</TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                <table cellpadding="0" cellspacing="0" class="style1">
                                    <tr>
                                        <td align="center" class="style2">
                                            <asp:Button ID="btnuevo" runat="server" 
                    Font-Names="Gill Sans MT" Text="Nuevo" Width="85px" Font-Size="12pt" />
                                        </td>
                                        <td align="center" class="style3">
                                            <asp:Button ID="btgrabar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Grabar" Width="85px" Font-Size="12pt" />
                                        </td>
                                        <td align="center">
                                            <asp:Button ID="btini" runat="server" 
                    Font-Names="Gill Sans MT" Text="Inicializar" Width="85px" style="margin-left: 0px" 
                                Font-Size="12pt" />
                                        </td>
                                        <td align="center">
                                            <asp:Button ID="bteliminar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Eliminar" Width="85px" Font-Size="12pt" />
                                        </td>
                                        <td align="center">
                                            <asp:Button ID="btbalance" runat="server" 
                    Font-Names="Gill Sans MT" Text="Resumen Ing y Cos." Width="113px" />
                                        </td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="center">
                                &nbsp;</TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 17px">
                                <asp:dropdownlist id="cmbNdoc" Enabled="False" 
                Width="116px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                Visible="False">
                                </asp:dropdownlist>
                                <asp:textbox id="TxtNroDoc" 
                Enabled="False" BorderWidth="1px" Width="72px" runat="server" MaxLength="12"
							Font-Names="Gill Sans MT" Font-Size="10pt" Font-Italic="True" Visible="False"></asp:textbox>
                                <asp:textbox id="txtComodin" 
                runat="server" Visible="False" 
                            Height="19px" Width="41px"></asp:textbox>
                                <asp:textbox id="txtfuente" runat="server" Width="88px" Enabled="False" 
                            Visible="False"></asp:textbox>
                                <asp:textbox id="TxtBandera" 
                BorderWidth="1px" Width="43px" runat="server" Visible="False" 
                Font-Names="Gill Sans MT" Height="16px"></asp:textbox>
                                <asp:textbox id="TxtNoEmp" Enabled="False" BorderWidth="1px" Width="76px" 
                runat="server" MaxLength="3"
							Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False"></asp:textbox>
                                <asp:Label ID="Label36" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Total de Cuerdas Varas:" Width="139px" 
                Visible="False"></asp:Label>
                                <asp:textbox id="txtcuerdasvaras" Enabled="False" BorderWidth="1px" 
                                        Height="20px" Width="44px" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Visible="False"></asp:textbox>
                                <asp:textbox id="txtcuerdasmts" Enabled="False" 
                BorderWidth="1px" Height="21px" 
                                        Width="53px" runat="server" 
                Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False"></asp:textbox>
                            </TD>
                        </TR>
                    </TABLE>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>

