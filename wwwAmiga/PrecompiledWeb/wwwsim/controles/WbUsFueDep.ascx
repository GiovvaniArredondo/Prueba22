<%@ control language="vb" autoeventwireup="false" inherits="WbUsFueDep, App_Web_yjxjq67i" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<meta content="True" name="vs_showGrid">

<style type="text/css">
    .CSSTableGenerator
    {
        width: 347px;
        height: 250px;
    }
    .style21
    {
        width: 100%;
    }
    .style20
    {
        width: 78px;
    }
    .style17
    {
        width: 567px;
        height: 255px;
    }
    .style18
    {
        width: 183px;
    }
    .style19
    {
        width: 157px;
    }
    .style11
    {
        width: 81%;
        height: 51px;
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
    .style22
    {
        height: 26px;
    }
    .style23
    {
        width: 78px;
        height: 26px;
    }
    .style24
    {
        width: 157px;
        height: 21px;
    }
    .style25
    {
        height: 21px;
    }
    </style>
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
            if (charCode == 08 || charCode == 32 || charCode == 45)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;

            return false;
        }

        function SoloLetras_Numeros(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32 || charCode == 45)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;
            else if (charCode >= 65 && charCode <= 90)
                return true;
            else if (charCode >= 97 && charCode <= 122)
                return true;
            return false;
        }

        function SoloLetras_Numeros(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32 || charCode == 45)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;
            else if (charCode >= 65 && charCode <= 90)
                return true;
            else if (charCode >= 97 && charCode <= 122)
                return true;

            return false;
      
        }
        function CargaMuni2() {            
    	$.ajax({
  			type: "POST",
  			url: "ajax/Municipios.ashx",
  			data: "Departamento=" + document.getElementById("<%=cmbDep.ClientID %>").options[document.getElementById("<%=cmbDep.ClientID %>").selectedIndex].value,
  			success: function(html) {
  			$("#<%=cmbMun.ClientID %>").html(html);
  			 CargaComu2();
  			}
  		});  		
		}
		function CargaComu2() {    
    	$.ajax({
  			type: "POST",
  			url: "ajax/Comunidades.ashx",
  			data: "Municipio=" + document.getElementById("<%=cmbMun.ClientID %>").options[document.getElementById("<%=cmbMun.ClientID %>").selectedIndex].value,
  			success: function(html){
  			  $("#<%=cmbCant.ClientID %>").html(html);  			  
  			}
  		});
}

        function BuscarZona() {
            // Enviaremos la informacion actual a la pagina contactos.aspx
            var str1 = document.getElementById('<%= TxtLat.ClientID  %>').value;
            var str2 = document.getElementById('<%= TxtLng.ClientID  %>').value;
            var str3 = "" //document.getElementById('ctl00_ContentPlaceHolder1_WbUCAdCat1_TxtcDepcta').value;
            var str4 = "" //document.getElementById('ctl00_ContentPlaceHolder1_WbUCAdCat1_TxtnSaldo').value;
            var str5 = "" //document.getElementById('ctl00_ContentPlaceHolder1_WbUCAdCat1_CbxTipcta1').value;
            var str6 = "" //document.getElementById('ctl00_ContentPlaceHolder1_WbUCAdCat1_CbxTipApli1').value;

            // creamos un arreglo con la informacion a enviar... esto puede crecer aun mas si 
            //queremos enviar mas cosas
            var Argumentos = new Array(str1, str2, str3, str4, str5, str6);
            //damos la configuracion a la pagina que se ha de abrir
            var ran = Math.random() * 4; //usamos esto para asegurarnos que la pagina destino se refresque
            var ConfiguracionPagina = 'dialogTop=200px; dialogLeft=450px; dialogWidth=900px;dialogHeight=650px; center=yes; help=no; status=no; menubar=no; resizable=no; border=thin';

            //        var ConfiguracionPagina = 'center:yes;resizable:no;help:no;status:no;dialogWidth:670px;dialogHeight:405px';
            var Pagina = 'Map/WbGeoRerencia.aspx?rn=' + ran;
            //var Pagina = 'Map/WbPrueba.aspx?rn=' + ran;
            //var Pagina = 'Map/Geocoding.aspx?rn=' + ran;
            // aqui hacemos que la pagina que se abra no sea totalmente independiente
            // sino que funcione al tipico estilo de los  "child forms"
            // se espera a que esta pagina retorne un determinado valor(como un arreglo) 
            // Nota: Las dos paginas padre.aspx y contactos.aspx estan en el mismo directorio
            Argumentos = window.showModalDialog(Pagina, Argumentos, ConfiguracionPagina);

            // Una vez que el formulario fue cerrado puede que haya o no devuelto informacion asi que la verificamos
            if (Argumentos == null) {	// mandamos un mensaje
                window.alert('No se devolvio ninguna valor!');
            }
            else {	//quiere decir que se ha devuelto una lista de contactos
                // asi que recuperamos la informacion enviada
                document.getElementById('<%= TxtLat.ClientID  %>').value = Argumentos[0];
                document.getElementById('<%= TxtLng.ClientID  %>').value = Argumentos[1];

            }

        }
</script>

<table cellpadding="0" cellspacing="0" class="style21">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0" style="border: thin solid highlight; WIDTH: 635px; HEIGHT: 538px; BACKGROUND-COLOR: #ffffff"
	bgColor="#ffffff">
                        <TR>
                            <TD style="HEIGHT: 19px">
                                <P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">
                                    FUENTE DE INGRESOS DEPENDIENTE</P>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 19px" align="center">
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
                            BorderWidth="1px" Font-Size="10pt"
					Font-Names="Gill Sans MT" Font-Bold="True" Height="27px" BorderColor="#2E6A99"></asp:textbox>
                                        </TD>
                                    </TR>
                                </TABLE>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 19px" align="center">
                                <asp:datagrid id="Datagrid1" BorderColor="Tan" BorderWidth="1px" CellPadding="2"
								AutoGenerateColumns="False" AllowSorting="True" Enabled="False" BackColor="LightGoldenrodYellow" 
                                runat="server" Width="318px"
								Height="143px" ForeColor="Black" GridLines="None" CssClass="CSSTableGenerator">
                                    <SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue">
                                    </SelectedItemStyle>
                                    <HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
                                    <FooterStyle BackColor="Tan"></FooterStyle>
                                    <AlternatingItemStyle BackColor="PaleGoldenrod" />
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
                                        HeaderText="Fuente">
                                            <HeaderStyle Font-Size="X-Small" Font-Names="Gill Sans MT" Font-Bold="True" HorizontalAlign="Center"
											VerticalAlign="Top"></HeaderStyle>
                                            <ItemStyle Font-Size="X-Small" Font-Names="Gill Sans MT" 
                                            HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        </asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" 
                                    BackColor="PaleGoldenrod"></PagerStyle>
                                </asp:datagrid>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 19px" align="left">
                                <table cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td class="style22">
                                            <asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Fecha de datos:" Width="139px"></asp:Label>
                                        </td>
                                        <td class="style22">
                                            <asp:textbox id="TxtdFecha" Enabled="False" BorderWidth="1px" Width="96px" 
                                        runat="server" MaxLength="10"
							Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99"></asp:textbox>
                                            <cc1:CalendarExtender ID="TxtdFecha_CalendarExtender" 
                            runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="TxtdFecha">
                                            </cc1:CalendarExtender>
                                            <cc1:MaskedEditExtender ID="TxtdFecha_MaskedEditExtender" runat="server" 
                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                        Mask="99/99/9999" MaskType="Date" TargetControlID="TxtdFecha">
                                            </cc1:MaskedEditExtender>
                                        </td>
                                        <td class="style23">
                                            <asp:RangeValidator id="RangeValidator1" runat="server" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" ControlToValidate="txtdFecha"
							ErrorMessage="RangeValidator" MaximumValue="01/01/3000" MinimumValue="01/01/1900" Type="Date">Fecha Inválida</asp:RangeValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Fecha de Ingreso:" Width="139px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="TxtAno" Enabled="False" runat="server" Width="96px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"
							MaxLength="10" BorderWidth="1px" onkeypress="return Fechas(event)" BorderColor="#2E6A99"></asp:textbox>
                                            <cc1:CalendarExtender ID="TxtAno_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="TxtAno">
                                            </cc1:CalendarExtender>
                                            <cc1:MaskedEditExtender ID="TxtAno_MaskedEditExtender" runat="server" 
                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                        Mask="99/99/9999" MaskType="Date" TargetControlID="TxtAno">
                                            </cc1:MaskedEditExtender>
                                        </td>
                                        <td class="style20">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 19px" align="center">
                                <table cellpadding="0" cellspacing="0" class="style17">
                                    <tr>
                                        <td align="center">
                                            <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                                                <tr>
                                                    <td class="style18">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style18">
                                                        <asp:Label ID="Label18" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Nombre de la Empresa:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtRazon" Enabled="False" runat="server" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"
							BorderWidth="1px" Width="144px" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style18">
                                                        <asp:Label ID="Label19" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Tipo:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbNdoc" Enabled="False" runat="server" Width="116px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtNroDoc" Enabled="False" runat="server" Width="77px" Font-Names="Gill Sans MT"
							Font-Size="X-Small" BorderWidth="1px" Visible="False"></asp:textbox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style18">
                                                        <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Ingreso Mensual:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtSueldo" Enabled="False" BackColor="AliceBlue" 
                                        runat="server" Width="88px"
							Font-Names="Gill Sans MT" Font-Size="10pt" BorderWidth="1px" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        <asp:RangeValidator id="RangeValidator3" Width="88px" runat="server" 
                                                            Font-Size="10pt" Font-Names="Gill Sans MT"
							ControlToValidate="TxtSueldo" ErrorMessage="RangeValidator" MaximumValue="1000000000" MinimumValue="0"
							Type="Double">Valor Inválido</asp:RangeValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style18">
                                                        <asp:Label ID="Label34" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Maneja Fondos:" Width="139px" Visible="False"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbManejaFon" Enabled="False" runat="server" 
                                        Width="116px" Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style18">
                                                        <asp:Label ID="Label35" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Puesto:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="txtpuesto" Enabled="False" runat="server" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"
							BorderWidth="1px" Width="144px" onkeypress="return SoloLetras(event)" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style18">
                                                        <asp:Label ID="Label36" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Jefe Inmediato:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="txtjefe" Enabled="False" runat="server" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"
							BorderWidth="1px" Width="144px" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style18">
                                                        <asp:Label ID="Label37" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Puesto Jefe Inmediato:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="txtpuestojefe" Enabled="False" runat="server" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"
							BorderWidth="1px" Width="144px" onkeypress="return SoloLetras(event)" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td align="center">
                                            <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                                                <tr>
                                                    <td class="style19">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="style19">
                                                        <asp:Label ID="Label28" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Estado:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbDep" Enabled="False" runat="server" 
                            Width="152px" Font-Names="Gill Sans MT"
							Font-Size="10pt" onchange="CargaMuni2();" AutoPostBack="True">
                                                        </asp:dropdownlist>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style19">
                                                        <asp:Label ID="Label29" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Municipio:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbMun" Enabled="False" runat="server" 
                            Width="152px" Font-Names="Gill Sans MT"
							Font-Size="10pt" onchange="CargaComu2();" AutoPostBack="True">
                                                        </asp:dropdownlist>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style19">
                                                        <asp:Label ID="Label30" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Colonia:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbCant" Enabled="False" runat="server" 
                            Width="152px" Font-Names="Gill Sans MT"
							Font-Size="10pt">
                                                        </asp:dropdownlist>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style19">
                                                        <asp:Label ID="Label33" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" Text="Calle/No Ext./No Int.:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="Txtdirec" Enabled="False" runat="server" Width="184px" 
                                        Height="48px" Font-Names="Gill Sans MT"
							Font-Size="10pt" TextMode="MultiLine" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style24">
                                                        <asp:Label ID="Label55" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" ForeColor="Black" Height="16px" Text="Latitud {*}:" 
                                                            Width="130px"></asp:Label>
                                                    </td>
                                                    <td class="style25">
                                                        <asp:TextBox ID="TxtLat" runat="server" BorderColor="#2E6A99" BorderWidth="1px" 
                                                            Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" 
                                                            MaxLength="18" tabIndex="57" Width="140px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style19">
                                                        <asp:Label ID="Label56" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" ForeColor="Black" Height="16px" Text="Longitud {*}:" 
                                                            Width="130px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TxtLng" runat="server" BorderColor="#2E6A99" BorderWidth="1px" 
                                                            Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" 
                                                            MaxLength="18" tabIndex="57" Width="140px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style19">
                                                        <asp:Label ID="Label32" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" Text="Telefono:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TxtTel" runat="server" BorderColor="#2E6A99" BorderWidth="1px" 
                                                            Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" MaxLength="10" 
                                                            onkeypress="return SoloNumeros(event)" Width="96px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 19px" align="center">
                                <table 
                    cellpadding="0" cellspacing="0" class="style11">
                                    <tr>
                                        <td class="style15">
                                            <asp:Button ID="btnuevo" runat="server" 
                    Font-Names="Gill Sans MT" Text="Nuevo" Width="85px" Font-Size="12pt" Height="35px" />
                                        </td>
                                        <td class="style16">
                                            <asp:Button ID="btgrabar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Grabar" Width="85px" Font-Size="12pt" Height="35px" />
                                        </td>
                                        <td class="style14">
                                            <asp:Button ID="btini" runat="server" 
                    Font-Names="Gill Sans MT" Text="Inicializar" Width="85px" style="margin-left: 0px" Font-Size="12pt" 
                                                Height="35px" />
                                        </td>
                                        <td>
                                            <asp:Button ID="bteliminar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Eliminar" Width="85px" Height="35px" Font-Size="12pt" />
                                            <cc1:ConfirmButtonExtender ID="bteliminar_ConfirmButtonExtender" runat="server" 
                                                ConfirmText="Realmente Desea Eliminar" Enabled="True" 
                                                TargetControlID="bteliminar">
                                            </cc1:ConfirmButtonExtender>
                                        </td>
                                        <td>
                                            <input id="BtnGeolocaliza" onclick="return BuscarZona();" 
                                                style="font-family: 'Gill Sans MT'; font-size: 11pt; font-weight: normal; height: 35px; width: 95px;" 
                                                type="button" value="Geolocalizar" visible="True" /></td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR>
                            <TD>
                                <asp:textbox id="txtComodin" runat="server" 
                Visible="False" Width="99px"></asp:textbox>
                                <asp:textbox id="TxtBandera" runat="server" Width="48px" Visible="False" Font-Names="Gill Sans MT"
							Font-Size="10pt" BorderWidth="1px"></asp:textbox>
                                <asp:Label ID="Label20" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Sector:" Width="63px" Height="16px" 
                Visible="False"></asp:Label>
                                <asp:dropdownlist id="cmbsector" Enabled="False" 
                runat="server" Width="48px" Font-Names="Gill Sans MT"
							Font-Size="10pt" Height="16px" Visible="False">
                                </asp:dropdownlist>
                                <asp:Label ID="Label21" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Actividad:" Width="69px" Height="16px" 
                Visible="False"></asp:Label>
                                <asp:dropdownlist id="cmbactividad" Enabled="False" 
                            runat="server" Width="85px" Font-Names="Gill Sans MT"
							Font-Size="10pt" Height="16px" Visible="False">
                                </asp:dropdownlist>
                                <asp:Label ID="Label23" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Condicion:" Width="79px" Height="18px" 
                Visible="False"></asp:Label>
                                <asp:dropdownlist id="cmbcondicion" Enabled="False" 
                runat="server" Width="51px" Font-Names="Gill Sans MT"
							Font-Size="10pt" Height="16px" Visible="False">
                                </asp:dropdownlist>
                            </TD>
                        </TR>
                    </TABLE>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>

