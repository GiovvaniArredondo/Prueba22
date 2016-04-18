<%@ Control Language="vb" AutoEventWireup="false" Inherits="WbUsFueInd" CodeFile="WbUsFueInd.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


<style type="text/css">
    .CSSTableGenerator
    {
        width: 366px;
        height: 111px;
    }
    .style12
    {
        width: 100%;
    }
    .style11
    {
        width: 49%;
        height: 62px;
    }
    .style10
    {
        width: 97%;
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
    .style13
    {
        height: 27px;
    }
    .style14
    {
        height: 28px;
    }
    .style15
    {
        height: 29px;
    }
    .style16
    {
        height: 36px;
    }
    </style>
    <script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
    <script type="text/javascript">
        function totalfamiliar() {
            document.getElementById('<%=txtfamtot.ClientID %>').value = parseFloat(document.getElementById('<%=txtfammes.ClientID %>').value) + parseFloat(document.getElementById('<%=txtfamtra.ClientID %>').value);
            document.getElementById('<%=txtnofamtot.ClientID %>').value = parseFloat(document.getElementById('<%=txtnofammes.ClientID %>').value) + parseFloat(document.getElementById('<%=txtnofamtra.ClientID %>').value);
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
        function SoloNumeros(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32 || charCode == 45)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;

            return false;
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


<table cellpadding="0" cellspacing="0" class="style12">
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
                                    FUENTE DE INGRESOS INDEPENDIENTE</P>
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
                                <asp:GridView ID="GridViewFuente" runat="server" AutoGenerateColumns="False" 
                                    Caption="Listado de Fuentes" CssClass="grid" Width="247px" Visible="False">
                                    <Columns>
                                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                            <controlstyle font-names="Gill Sans MT" font-size="9pt" />
                                            <HeaderStyle BackColor="#009900" />
                                        </asp:CommandField>
                                        <asp:BoundField DataField="Nro" HeaderText="Nro">
                                            <HeaderStyle BackColor="#009900" Font-Names="Gill Sans MT" ForeColor="White" 
                                                Width="150px" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:BoundField>                                                                                                             
                                        <asp:BoundField DataField="cnomfue" HeaderText="Fuente">
                                            <HeaderStyle BackColor="#009900" Font-Names="Gill Sans MT" ForeColor="White" 
                                                Width="100px" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:BoundField>
                                    </Columns>
                                    <PagerStyle CssClass="pagerstyle" />
                                    <AlternatingRowStyle BackColor="#99FF66" />
                                </asp:GridView>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 21px" align="left">
                                <table cellpadding="0" cellspacing="0" class="style11">
                                    <tr>
                                        <td>
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
							MinimumValue="01/01/1900" Type="Date" ControlToValidate="txtdFecha" ErrorMessage="RangeValidator">Fecha Inválida</asp:rangevalidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label29" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Fecha de Apertura Neg.:" Width="139px"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:textbox id="TxtdFechaA" Enabled="False" BorderWidth="1px" Width="96px" 
                                        runat="server" MaxLength="10"
							Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99"></asp:textbox>
                                            <cc1:MaskedEditExtender ID="TxtdFechaA_MaskedEditExtender" runat="server" 
                                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                        Mask="99/99/9999" MaskType="Date" TargetControlID="TxtdFechaA">
                                            </cc1:MaskedEditExtender>
                                            <cc1:CalendarExtender ID="TxtdFechaA_CalendarExtender" runat="server" 
                                        Enabled="True" Format="dd/MM/yyyy" TargetControlID="TxtdFechaA">
                                            </cc1:CalendarExtender>
                                        </td>
                                        <td>
                                            <asp:rangevalidator id="RangeValidator2" runat="server" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" MaximumValue="01/01/3000"
							MinimumValue="01/01/1900" Type="Date" ControlToValidate="TxtdFechaA" ErrorMessage="RangeValidator">Fecha Inválida</asp:rangevalidator>
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
                                                    <td class="style13">
                                                        <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="NIT:" Width="93px" Height="16px" Visible="False"></asp:Label>
                                                    </td>
                                                    <td class="style13">
                                                        <asp:textbox id="Txtnit" Enabled="False" BorderWidth="1px" Width="149px" 
                                        runat="server" MaxLength="40"
							Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Visible="False" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td class="style13">
                                                        </td>
                                                </tr>
                                                <tr>
                                                    <td class="style14">
                                                        <asp:Label ID="Label27" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Nombre de Negocio:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td class="style14">
                                                        <asp:textbox id="TxtRazon" Enabled="False" BorderWidth="1px" Width="149px" 
                                        runat="server" MaxLength="40"
							Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                    <td class="style14">
                                                        </td>
                                                </tr>
                                                <tr>
                                                    <td class="style15">
                                                        <asp:Label ID="Label48" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Giro:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td class="style15">
                                                        <asp:TextBox ID="TxtcGiro" runat="server" BorderWidth="1px" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" MaxLength="40" 
                                                            Width="149px" BorderColor="#2E6A99"></asp:TextBox>
                                                    </td>
                                                    <td class="style15">
                                                        </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label28" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Telefono:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtTel" runat="server" BorderWidth="1px" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" MaxLength="10" 
                                                            onkeypress="return SoloNumeros(event)" Width="104px" BorderColor="#2E6A99"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label35" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Sector Economico:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbsector" 
                            Enabled="False" Width="150px" runat="server" Font-Names="Gill Sans MT"
							Font-Size="10pt" Height="17px">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label36" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Actividad Economica:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbactividad" Enabled="False" Width="150px" 
                                                            runat="server" Font-Names="Gill Sans MT"
							Font-Size="10pt" Height="25px">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label46" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Condicion de Compra:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:dropdownlist id="cmbconcpa" Enabled="False" Width="131px" runat="server" Font-Names="Gill Sans MT"
							Font-Size="10pt">
                                                        </asp:dropdownlist>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label47" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" Text="Condicion de Venta:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="cmbconvta" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Width="131px">
                                                        </asp:DropDownList>
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
                                                        <asp:TextBox ID="txtfuente" runat="server" BorderWidth="1px" Enabled="False" 
                                                            Width="88px" Visible="False"></asp:TextBox>
                                                    </td>
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
                            Font-Size="10pt" Text="Calle/No Ext./No Int.:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:textbox id="TxtDirec" Enabled="False" BorderWidth="1px" Height="56px" 
                                        Width="167px" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        TextMode="MultiLine" BorderColor="#2E6A99"></asp:textbox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style16">
                                                        <asp:Label ID="Label55" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Latitud {*}:" Width="130px" ForeColor="Black" Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style16">
                                                        <asp:TextBox ID="TxtLat" runat="server" BorderColor="#2E6A99" BorderWidth="1px" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" 
                                                            MaxLength="18" tabIndex="57" Width="140px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label56" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" ForeColor="Black" Height="16px" Text="Longitud {*}:" 
                                                            Width="130px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TxtLng" runat="server" BorderColor="#2E6A99" BorderWidth="1px" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" 
                                                            MaxLength="18" tabIndex="57" Width="140px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label34" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" Text="Tipo de Local:" Width="139px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="cmbTipneg" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Width="131px">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
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
                            Font-Size="10pt" Text="Fijos:" Width="75px" Height="16px"></asp:Label>
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
                                            <asp:Label ID="Label41" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Fijos:" Width="73px" Height="18px"></asp:Label>
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
                                            <asp:Label ID="Label42" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Temporales:" Width="66px" Height="20px"></asp:Label>
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
                                            <asp:Label ID="Label43" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Text="Temporales:" Width="82px" Height="16px"></asp:Label>
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
                                            <cc1:ConfirmButtonExtender ID="bteliminar_ConfirmButtonExtender" runat="server" 
                                                ConfirmText="Realmente Desea Eliminar " Enabled="True" 
                                                TargetControlID="bteliminar">
                                            </cc1:ConfirmButtonExtender>
                                        </td>
                                        <td align="center">
                                            <input id="BtnGeolocaliza" onclick="return BuscarZona();" 
                                                style="font-family: 'Gill Sans MT'; font-size: 11pt; font-weight: normal; height: 35px; width: 95px;" 
                                                type="button" value="Geolocalizar" visible="False" disabled="disabled" /></td>
                                        <td align="center">
                                            <asp:Button ID="btbalance" runat="server" Font-Names="Gill Sans MT" 
                                                Text="Estados Finac." Width="85px" />
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
                                <asp:textbox id="TxtBandera" 
                BorderWidth="1px" Width="43px" runat="server" Visible="False" 
                Font-Names="Gill Sans MT" Height="16px"></asp:textbox>
                                <asp:textbox id="TxtNoEmp" Enabled="False" BorderWidth="1px" Width="76px" 
                runat="server" MaxLength="3"
							Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False"></asp:textbox>
                            </TD>
                        </TR>
                    </TABLE>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>

