<%@ control language="vb" autoeventwireup="false" inherits="WbUsFueFam, App_Web_yl8dokps" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<style type="text/css">
    .style21
    {
        width: 100%;
    }
    .style18
    {
        width: 64%;
    }

    .style17
    {
        width: 85%;
    }
    .style11
    {
        width: 54%;
        height: 58px;
    }
    .style15
    {
        width: 108px;
    }
    .style16
    {
        width: 103px;
    }
    .style14
    {
        width: 114px;
    }

    .style19
    {
        height: 12px;
    }
    .style20
    {
        width: 41%;
        height: 57px;
    }

    </style>
    <script type="text/javascript">
        function SoloNumeros(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32 || charCode == 45 || charCode == 46)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;

            return false;
        }

    function CalculaTotalesFuenteFamiliar()
    {
        var Conyugue,Cuotas,Remesa,Otros;
        var Vivienda,Alimentacion,Telefono,Transporte,Educacion,Salud,Vestuario,Personales;
        var Ingresos,Egresos,Disponible;
        
        
        Conyugue=parseFloat(document.getElementById("WbUsFueFam1_txtIngrCony").value);
        Cuotas=parseFloat(document.getElementById("WbUsFueFam1_Txtcuotas").value);
        Remesa=parseFloat(document.getElementById("WbUsFueFam1_TxtRemesa").value);
        Otros=parseFloat(document.getElementById("WbUsFueFam1_TxtOtros").value);
        
        if(isNaN(Conyugue))
        Conyugue=0;
        if(isNaN(Cuotas))
        Cuotas=0;
        if(isNaN(Remesa))
        Remesa=0;
        if(isNaN(Otros))
        Otros=0;
        
        Ingresos=Conyugue+Cuotas+Remesa+Otros;
        
        document.getElementById("WbUsFueFam1_TxtTIngr").value=Ingresos;
                
        
        Vivienda=parseFloat(document.getElementById("WbUsFueFam1_Txtviv").value);
        Alimentacion=parseFloat(document.getElementById("WbUsFueFam1_TxtAlim").value);
        Telefono=parseFloat(document.getElementById("WbUsFueFam1_TxtTel").value);
        Transporte=parseFloat(document.getElementById("WbUsFueFam1_TxtTrans").value);
        Educacion=parseFloat(document.getElementById("WbUsFueFam1_TxtEdu").value);
        Salud=parseFloat(document.getElementById("WbUsFueFam1_TxtSalud").value);
        Vestuario=parseFloat(document.getElementById("WbUsFueFam1_TxtVest").value);
        Personales=parseFloat(document.getElementById("WbUsFueFam1_TxtPers").value);
        
        if(isNaN(Vivienda))
        Vivienda=0;
        if(isNaN(Alimentacion))
        Alimentacion=0;
        if(isNaN(Telefono))
        Telefono=0;
        if(isNaN(Transporte))
        Transporte=0;
        if(isNaN(Educacion))
        Educacion=0;
        if(isNaN(Salud))
        Salud=0;
        if(isNaN(Vestuario))
        Vestuario=0;
        if(isNaN(Personales))
        Personales=0;
        
        Egresos=Vivienda+Alimentacion+Telefono+Transporte+Educacion+Salud+Vestuario+Personales;
        
        document.getElementById("WbUsFueFam1_TxtTEgr").value=Egresos;
                
        
    }//fin
</script>

<table cellpadding="0" cellspacing="0" class="style21">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <TABLE id="Table1" cellSpacing="0" cellPadding="0" width="584" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 584px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 603px; BACKGROUND-COLOR: #ffffff"
	bgColor="#ffffff">
                        <TR>
                            <TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 21px">
                                <P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">
                                    FUENTE DE INGRESOS FAMILIARES</P>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 21px">
                                &nbsp;</TD>
                        </TR>
                        <TR>
                            <TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 21px">
                                <TABLE id="Table4" style="WIDTH: 403px; HEIGHT: 45px" cellSpacing="0" 
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
                            BorderWidth="1px" Font-Size="8pt"
					Font-Names="Gill Sans MT" Font-Bold="True" Height="27px" BorderColor="#2E6A99"></asp:textbox>
                                        </TD>
                                    </TR>
                                </TABLE>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 21px" 
            align="center">
                                <asp:datagrid id="Datagrid1" BorderColor="#DEBA84" BorderStyle="None" 
                            BorderWidth="1px" CellPadding="3"
							AutoGenerateColumns="False" AllowSorting="True" BackColor="#DEBA84" runat="server" 
                            Width="304px" Height="72px" Enabled="False" CellSpacing="2" 
                            Font-Names="Verdana" Font-Size="10pt" CssClass="CSSTableGenerator">
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C">
                                    </SelectedItemStyle>
                                    <ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129">
                                    </HeaderStyle>
                                    <FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
                                    <Columns>
                                        <asp:ButtonColumn Text="Seleccionar" CommandName="Select">
                                            <HeaderStyle Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True">
                                            </HeaderStyle>
                                            <ItemStyle Font-Size="X-Small" Font-Names="Verdana" HorizontalAlign="Center" ForeColor="Blue"
										VerticalAlign="Top"></ItemStyle>
                                        </asp:ButtonColumn>
                                        <asp:TemplateColumn SortExpression="Nro" HeaderText="Nro">
                                            <HeaderStyle Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center"
										VerticalAlign="Top"></HeaderStyle>
                                            <ItemStyle Font-Size="X-Small" Font-Names="Verdana" HorizontalAlign="Center" ForeColor="Black"
										VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:HyperLink id=HyperLink1 runat="server" 
                                            Text='<%# DataBinder.Eval(Container, "DataItem.Nro") %>' 
                                            NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.Nro", URLCodigo) %>' 
                                            Target="_self">
                                                </asp:HyperLink>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="Fecha" SortExpression="Fecha" HeaderText="Fecha" 
                                    DataFormatString="{0:dd-MM-yyyy}">
                                            <HeaderStyle Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" HorizontalAlign="Center"
										VerticalAlign="Top"></HeaderStyle>
                                            <ItemStyle Font-Size="X-Small" Font-Names="Verdana" HorizontalAlign="Center" 
                                        VerticalAlign="Top"></ItemStyle>
                                        </asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:datagrid>
                                <asp:textbox id="TxtComodin" runat="server" 
                Visible="False" Width="83px" Height="16px"></asp:textbox>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 21px" 
            align="center">
                                <table cellpadding="0" cellspacing="0" class="style18">
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="Label33" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Fecha Datos:" Width="139px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="txtdFecha" runat="server" Width="120px" Enabled="False" Font-Names="Gill Sans MT"
								BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox>
                                            <cc1:MaskedEditExtender ID="txtdFecha_MaskedEditExtender" runat="server" 
                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtdFecha">
                                            </cc1:MaskedEditExtender>
                                            <cc1:CalendarExtender ID="txtdFecha_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdFecha">
                                            </cc1:CalendarExtender>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label34" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="dd/mm/yyyy" Width="94px" Height="16px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:RangeValidator id="RangeValidator1" runat="server" Font-Names="Verdana" 
                                Font-Size="8pt" ControlToValidate="txtdFecha"
								ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/1900" MaximumValue="01/01/3000">Fecha Inválida</asp:RangeValidator>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 21px" 
            align="center">
                                <table cellpadding="0" cellspacing="0" class="style17">
                                    <tr>
                                        <td align="center">
                                            <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label17" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="INGRESOS MENSUALES" Width="167px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label18" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Ingresos Familiares:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="txtIngrCony" runat="server" Width="104px" Enabled="False" Font-Names="Verdana"
				BorderWidth="1px" Height="20px" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator2" Width="87px" runat="server" 
                                                            Font-Names="Verdana" Font-Size="8pt"
				ControlToValidate="txtIngrCony" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                                        MaximumValue="1000000000" Height="16px">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
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
                                                        <asp:Label ID="Label22" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Total  de Ingreso:" Width="100px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtTIngr" BackColor="AliceBlue" runat="server" Width="104px" Enabled="False"
				AutoPostBack="True" Font-Names="Verdana" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox>
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
                                                        <asp:Label ID="Label23" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="EGRESOS MENSUALES" Width="167px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Cuota de Vivienda:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="Txtviv" runat="server" Width="104px" Enabled="False" 
                                        Font-Names="Verdana" BorderWidth="1px" onkeypress="return SoloNumeros(event)" 
                                                            BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator6" Width="100px" runat="server" 
                                                            Font-Names="Verdana" Font-Size="8pt"
				ControlToValidate="Txtviv" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                                        MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Alimentacion:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtAlim" runat="server" Width="104px" Enabled="False" 
                                        Font-Names="Verdana" BorderWidth="1px" onkeypress="return SoloNumeros(event)" 
                                                            BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator7" Width="100px" runat="server" 
                                                            Font-Names="Verdana" Font-Size="8pt"
				ControlToValidate="TxtAlim" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                                        MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Agua, luz y telefono:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtTel" runat="server" Width="104px" Enabled="False" 
                                        Font-Names="Verdana" BorderWidth="1px" onkeypress="return SoloNumeros(event)" 
                                                            BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator8" Width="100px" runat="server" 
                                                            Font-Names="Verdana" Font-Size="8pt"
				ControlToValidate="TxtTel" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                                        MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label27" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Transporte:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtTrans" runat="server" Width="104px" Enabled="False" Font-Names="Verdana"
				BorderWidth="1px" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator9" Width="100px" runat="server" 
                                                            Font-Names="Verdana" Font-Size="8pt"
				ControlToValidate="TxtTrans" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                                        MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label29" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Educacion:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtEdu" runat="server" Width="104px" Enabled="False" 
                                        Font-Names="Verdana" BorderWidth="1px" onkeypress="return SoloNumeros(event)" 
                                                            BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator10" Width="100px" runat="server" 
                                                            Font-Names="Verdana" Font-Size="8pt"
				ControlToValidate="TxtEdu" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                                        MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label31" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Salud:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtSalud" runat="server" Width="104px" Enabled="False" Font-Names="Verdana"
				BorderWidth="1px" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator11" Width="100px" runat="server" 
                                                            Font-Names="Verdana" Font-Size="8pt"
				ControlToValidate="TxtSalud" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                                        MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label28" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Vestuario" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtVest" runat="server" Width="104px" Enabled="False" 
                                        Font-Names="Verdana" BorderWidth="1px" onkeypress="return SoloNumeros(event)" 
                                                            BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator12" Width="100px" runat="server" 
                                                            Font-Names="Verdana" Font-Size="8pt"
				ControlToValidate="TxtVest" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                                        MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label30" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Prestamos Personales:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="txtPers" runat="server" Width="104px" Enabled="False" 
                                        Font-Names="Verdana" BorderWidth="1px" onkeypress="return SoloNumeros(event)" 
                                                            BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator13" Width="100px" runat="server" 
                                                            Font-Names="Verdana" Font-Size="8pt"
				ControlToValidate="txtPers" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" 
                                        MaximumValue="1000000000">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label32" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Total Egreso:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtTEgr" BackColor="AliceBlue" runat="server" Width="104px" Enabled="False"
				AutoPostBack="True" Font-Names="Verdana" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
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
                            <TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 21px" 
            align="center">
                                <asp:Button ID="btncalcular" runat="server" 
                    Font-Names="Gill Sans MT" Text="Calcula Previa" Width="85px" />
                            </TD>
                        </TR>
                        <TR>
                            <TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 21px" 
            align="center">
                                <table 
                    cellpadding="0" cellspacing="0" class="style11">
                                    <tr>
                                        <td class="style15">
                                            <asp:Button ID="btnuevo" runat="server" 
                    Font-Names="Gill Sans MT" Text="Nuevo" Width="85px" />
                                        </td>
                                        <td class="style16">
                                            <asp:Button ID="btgrabar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Grabar" Width="85px" />
                                        </td>
                                        <td class="style14">
                                            <asp:Button ID="btini" runat="server" 
                    Font-Names="Gill Sans MT" Text="Inicializar" Width="85px" style="margin-left: 0px" />
                                        </td>
                                        <td>
                                            <asp:Button ID="bteliminar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Eliminar" Width="85px" Height="25px" />
                                        </td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 21px" 
            align="center">
                                <asp:textbox id="TxtBandera" 
                runat="server" Width="104px" Enabled="False" Visible="False" Font-Names="Verdana"
				BorderWidth="1px"></asp:textbox>
                            </TD>
                        </TR>
                        <TR>
                            <TD class="style19">
                                <p>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <table cellpadding="0" cellspacing="0" class="style20">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label19" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="IGSS, pension o cuota familiar:" Width="165px"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="Txtcuotas" runat="server" BorderWidth="1px" Enabled="False" 
                                Font-Names="Verdana" Width="104px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label20" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Otros:" Width="132px"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TxtOtros" runat="server" BorderWidth="1px" Enabled="False" 
                                Font-Names="Verdana" Width="104px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label21" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Remesas:" Width="100px"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TxtRemesa" runat="server" BorderWidth="1px" Enabled="False" 
                                Font-Names="Verdana" Width="104px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </TD>
                        </TR>
                        </TBODY>
                    </TABLE>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>

