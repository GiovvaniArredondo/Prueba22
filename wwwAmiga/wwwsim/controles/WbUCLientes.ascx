<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbUCLientes.ascx.vb" Inherits="WbUCLientes"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<style type="text/css">
    .style27
    {
        width: 100%;
    }
    #Table3
    {
        width: 100%;
        height: 346px;
    }
    .style7
    {
        height: 24px;
        width: 235px;
    }
    .style12
    {
        height: 24px;
        width: 116px;
    }
    .style19
    {
        width: 114px;
        height: 4px;
    }
    .style23
    {
        height: 4px;
        width: 235px;
    }
    .style24
    {
        height: 4px;
        width: 116px;
    }
    .style22
    {
        height: 4px;
    }
    .style33
    {
        width: 114px;
        height: 32px;
    }
    .style34
    {
        height: 32px;
        width: 235px;
    }
    .style35
    {
        height: 32px;
        width: 116px;
    }
    .style36
    {
        height: 32px;
    }
    .style8
    {
        height: 23px;
        width: 235px;
    }
    .style13
    {
        width: 116px;
    }
    .style9
    {
        height: 2px;
        width: 235px;
    }
    .style14
    {
        height: 2px;
        width: 116px;
    }
    .style10
    {
        height: 16px;
        width: 235px;
    }
    .style15
    {
        height: 16px;
        width: 116px;
    }
    .style4
    {
        width: 100%;
        height: 86px;
        margin-right: 0px;
    }
    .style39
    {
        height: 140px;
    }
    .style43
    {
        width: 27px;
        height: 16px;
    }
    .style44
    {
        height: 16px;
    }
    .style45
    {
        height: 16px;
        width: 81px;
    }
    .style46
    {
        width: 27px;
        height: 4px;
    }
    .style47
    {
        height: 4px;
        width: 81px;
    }
    .style48
    {
        width: 27px;
        height: 7px;
    }
    .style49
    {
        height: 7px;
    }
    .style50
    {
        height: 7px;
        width: 81px;
    }
    .style51
    {
        width: 27px;
        height: 8px;
    }
    .style52
    {
        height: 8px;
    }
    .style53
    {
        height: 8px;
        width: 81px;
    }
    .style54
    {
        width: 27px;
        height: 66px;
    }
    .style55
    {
        height: 66px;
    }
    .style56
    {
        height: 66px;
        width: 81px;
    }
    .style57
    {
        width: 27px;
        height: 18px;
    }
    .style58
    {
        height: 18px;
    }
    .style59
    {
        height: 18px;
        width: 81px;
    }
    .style60
    {
        width: 27px;
        height: 6px;
    }
    .style61
    {
        height: 6px;
    }
    .style62
    {
        height: 6px;
        width: 81px;
    }
    .style63
    {
        width: 27px;
        height: 17px;
    }
    .style64
    {
        height: 17px;
    }
    .style65
    {
        height: 17px;
        width: 81px;
    }
    .style5
    {
        width: 122px;
    }
    .style37
    {
        width: 133px;
    }
    .style66
    {
        width: 122px;
        height: 64px;
    }
    .style67
    {
        width: 239px;
        height: 64px;
    }
    .style68
    {
        width: 133px;
        height: 64px;
    }
    .style69
    {
        height: 64px;
    }
    .style28
    {
        width: 122px;
        height: 29px;
    }
    .style38
    {
        width: 133px;
        height: 29px;
    }
    .style31
    {
        height: 29px;
    }
    .style70
    {
        width: 27px;
        height: 25px;
    }
    .style71
    {
        height: 25px;
    }
    .style72
    {
        height: 25px;
        width: 81px;
    }
    .style73
    {
        width: 114px;
        height: 35px;
    }
    .style74
    {
        height: 35px;
        width: 235px;
    }
    .style75
    {
        height: 35px;
        width: 116px;
    }
    .style77
    {
        width: 114px;
    }
    .style78
    {
        width: 235px;
        text-align: left;
    }
    .style79
    {
        width: 114px;
        height: 34px;
    }
    .style80
    {
        height: 34px;
        width: 235px;
    }
    .style81
    {
        height: 34px;
        width: 116px;
    }
    .style82
    {
        height: 34px;
    }
    .style83
    {
        width: 114px;
        height: 29px;
    }
    .style85
    {
        height: 29px;
        width: 235px;
        text-align: left;
    }
    .style86
    {
        height: 29px;
        width: 116px;
    }
    .style87
    {
        height: 37px;
    }
    .style88
    {
        height: 33px;
    }
    .style89
    {
        width: 239px;
        text-align: left;
    }
    .style90
    {
        height: 29px;
        width: 239px;
        text-align: left;
    }
    .style91
    {
        width: 259px;
    }
    .style92
    {
        height: 37px;
        width: 259px;
    }
    .style93
    {
        height: 24px;
        width: 246px;
    }
    .style94
    {
        height: 22px;
        width: 246px;
    }
    .style95
    {
        height: 37px;
        width: 128px;
    }
    .style96
    {
        width: 128px;
    }
    .style97
    {
        height: 33px;
        width: 128px;
    }
    .style98
    {
        height: 35px;
    }   
   

    </style>
<head id="Head1"/>

    <script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
    <script type="text/javascript">
        function HabilitaCampos() {
            //2 y 6 se habilitan los campos si son diferentes de deshabilitan

            var EstadoCivil = document.getElementById("<%=cmbEstCli.ClientID %>").options[document.getElementById("<%=cmbEstCli.ClientID %>").selectedIndex].value
            if (EstadoCivil == 2 || EstadoCivil == 6) {
                document.getElementById("<%=TxtNomC.ClientID %>").disabled = true;
                document.getElementById("<%=TxtIdCony.ClientID %>").disabled = true;
                document.getElementById("<%=cmbProfCony.ClientID %>").disabled = true;
                document.getElementById("<%=TxtNacCony.ClientID %>").disabled = true;
                document.getElementById("<%=cmbGenCony.ClientID %>").disabled = true;
                document.getElementById("<%=Sleer.ClientID %>").disabled = true;
                document.getElementById("<%=cmbParent.ClientID %>").disabled = true;
                //alert("lo habilite")
            }
            else {
                document.getElementById("<%=TxtNomC.ClientID %>").disabled = true;
                document.getElementById("<%=TxtIdCony.ClientID %>").disabled = true;
                document.getElementById("<%=cmbProfCony.ClientID %>").disabled = true;
                document.getElementById("<%=TxtNacCony.ClientID %>").disabled = true;
                document.getElementById("<%=cmbGenCony.ClientID %>").disabled = true;
                document.getElementById("<%=Sleer.ClientID %>").disabled = true;
                document.getElementById("<%=cmbParent.ClientID %>").disabled = false;
            }

        }

        function CargaMuni0() {
            $.ajax({
                type: "POST",
                url: "ajax/Municipios0.ashx",
                data: "Departamento0=" + document.getElementById("<%=DropDownDeptos0.ClientID %>").options[document.getElementById("<%=DropDownDeptos0.ClientID %>").selectedIndex].value,
                success: function(html) {
                $("#<%=DropDownMuni0.ClientID %>").html(html);
                CargaComu0();
                 }
            });
        }

                    
        function CargaMuni() {    
    	$.ajax({
  			type: "POST",
  			url: "ajax/Municipios.ashx",
  			data: "Departamento=" + document.getElementById("<%=DropDownDeptos.ClientID %>").options[document.getElementById("<%=DropDownDeptos.ClientID %>").selectedIndex].value,
  			success: function(html){
  			$("#<%=DropDownMuni.ClientID %>").html(html);
  			 CargaComu();
  			}
  		});  		
		}
		function CargaComu() {    
    	$.ajax({
  			type: "POST",
  			url: "ajax/Comunidades.ashx",
  			data: "Municipio=" + document.getElementById("<%=DropDownMuni.ClientID %>").options[document.getElementById("<%=DropDownMuni.ClientID %>").selectedIndex].value,
  			success: function(html){
  			$("#<%=DropDownComu.ClientID %>").html(html);  			  
  			}
  		});  		
		}

		function CargaComu0() {
		    $.ajax({
		        type: "POST",
		        url: "ajax/Comunidades0.ashx",
		        data: "Municipio0=" + document.getElementById("<%=DropDownMuni0.ClientID %>").options[document.getElementById("<%=DropDownMuni0.ClientID %>").selectedIndex].value,
		        success: function(html) {
		            $("#<%=DropDownComu0.ClientID %>").html(html);
		        }
		    });
		}	

       function Getfecha(){
           document.getElementById('<%=TxtEdad.ClientID %>').value = calcular_edad(document.getElementById('<%=TxtDfecnaci.ClientID %>').value);
       }
       
       function Getfecha_final() {
           document.getElementById('<%=TxtEdad.ClientID %>').value = calcular_edad_Otr(document.getElementById('<%=TxtDfecnaci.ClientID %>').value);
       }

       
       function Getfecha1(){
           document.getElementById('<%=TxtEdadCony.ClientID %>').value = calcular_edad(document.getElementById('<%=TxtNacCony.ClientID %>').value);	         
	    }

	   function SoloNumeros(evt) {
	        var charCode = (evt.which) ? evt.which : event.keyCode
	        if (charCode == parseInt('08') || charCode == 32)
	            return true;
	        else if (charCode >= 48 && charCode <= 57)
	            return true;

	        return false;
	    }

	    function SoloLetras(evt) {
	        var charCode = (evt.which) ? evt.which : event.keyCode

	        if (charCode == parseInt('08') || charCode == 32 || charCode == 241 || charCode == 209)	        
	            return true;
	        else if (charCode >= 65 && charCode <= 90)
	            return true;
	        else if (charCode >= 97 && charCode <= 122)
	            return true;	            

	        return false;
	    }


	    function SoloLetras_Numeros(evt) {
	        var charCode = (evt.which) ? evt.which : event.keyCode
	        if (charCode == parseInt('08') || charCode == 32)
	            return true;
	        else if (charCode >= 48 && charCode <= 57)
	            return true;	            
	        else if (charCode >= 65 && charCode <= 90)
	            return true;
	        else if (charCode >= 97 && charCode <= 122)
	            return true;

	        return false;
	    }

	    //Esta función solo permite numeros y el punto, se invoca desde el evento onkeypress Ejemplo onkeypress="return NumCheck(event, this)"
	    function NumCheck(e, field) {
	        key = e.keyCode ? e.keyCode : e.which
	        if (key == 8 || key == 9 || key == 127)
	            return true;
	        else if (key > 47 && key < 58) {
	            var cad = field.value;
	            if (cad.indexOf(".") != -1) {
	                regexp = /.[0-9]{2}$/
	                return !(regexp.test(field.value))
	            }
	            return true
	        }
	        else if (key == 46) {
	            if (field.value == "") return false
	            regexp = /^[0-9]+$/
	            return regexp.test(field.value)
	        }
	        return false
	    }



	    function calcular_edad_fin(fecha) {

	        //calculo la fecha de hoy 
	        hoy = new Date()
	        //alert(hoy) 

	        //calculo la fecha que recibo 
	        //La descompongo en un array 
	        var array_fecha = fecha.split("/")
	        //si el array no tiene tres partes, la fecha es incorrecta 
	        if (array_fecha.length != 3)
	            return false

	        //compruebo que los ano, mes, dia son correctos 
	        var ano
	        ano = parseInt(array_fecha[2]);
	        if (isNaN(ano))
	            return false

	        var mes
	        mes = parseInt(array_fecha[1]);
	        if (isNaN(mes))
	            return false

	        var dia
	        dia = parseInt(array_fecha[0]);
	        if (isNaN(dia))
	            return false


	        //si el año de la fecha que recibo solo tiene 2 cifras hay que cambiarlo a 4 
	        if (ano <= 99)
	            ano += 1900

	        //resto los años de las dos fechas 
	        edad = hoy.getYear() - ano - 1; //-1 porque no se si ha cumplido años ya este año 

	        //si resto los meses y me da menor que 0 entonces no ha cumplido años. Si da mayor si ha cumplido 
	        if (hoy.getMonth() + 1 - mes < 0) //+ 1 porque los meses empiezan en 0 
	            return edad
	        if (hoy.getMonth() + 1 - mes > 0)
	            return edad + 1

	        //entonces es que eran iguales. miro los dias 
	        //si resto los dias y me da menor que 0 entonces no ha cumplido años. Si da mayor o igual si ha cumplido 
	        if (hoy.getUTCDate() - dia >= 0)
	            return edad + 1

	        return edad
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

<table cellpadding="0" cellspacing="0" class="style27">
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
                    <TABLE id="Table1" style="border: thin solid highlight; WIDTH: 720px; HEIGHT: 933px; BACKGROUND-COLOR: #FFFFFF"
		cellSpacing="0" cellPadding="0" border="0">
                        <TR>
                            <TD>
                                <P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #006699; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
					align="center">
                                    DATOS GENERALES DE CLIENTES
                                    <asp:Image ID="ImageFoto" runat="server" Height="58px" Visible="False" 
                        Width="83px" />
                                    <asp:DropDownList ID="DropDownMuni0" 
    runat="server" 
                                        Font-Names="Gill Sans MT" 
    Font-Size="10pt" Height="16px" tabIndex="14" 
    Width="106px" Visible="False">
                                    </asp:DropDownList>
                                </P>
                            </TD>
                        </TR>
                        <tr>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                    <ContentTemplate>
                                        <asp:ImageButton ID="btnadd" runat="server" ImageUrl="~/Imagenes/add.png" />
                                        <asp:DropDownList ID="cmbTipDoc" runat="server" AutoPostBack="True" 
                                            Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" 
                                            tabIndex="9" Visible="False" Width="125px">
                                        </asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right">
                                <asp:Label ID="Label54" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="10pt" ForeColor="Red" onkeypress="return SoloLetras(event)" 
                                    Text="Campos Requeridos {*}" Width="130px"></asp:Label>
                            </td>
                        </tr>
                        <TR>
                            <TD style="HEIGHT: 16px; BACKGROUND-COLOR: silver">
                                <P style="FONT-WEIGHT: normal; FONT-SIZE: 11pt; COLOR: White; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #006699"
					align="center">
                                    Identificación</P>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 132px" align="center">
                                <TABLE ID="Table2" border="0" cellPadding="0" cellSpacing="0" 
                            style="WIDTH: 699px; HEIGHT: 379px">
                                    <tr>
                                        <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                                            class="style83">
                                            Cliente</td>
                                        <td class="style85">
                                            <asp:TextBox ID="TxtCodigo" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99" BorderWidth="1px" 
                                                Height="28px"></asp:TextBox>
                                        </td>
                                        <td class="style86" 
                                    
                                    
                                            
                                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; ">
                                            Oficina</td>
                                        <td class="style31">
                                            <asp:DropDownList ID="cmbOficina" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="1" Width="203px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                            Tipo de Cliente</td>
                                        <td class="style7">
                                            <asp:DropDownList ID="cmbTipcli" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="2" Width="208px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style12" style="FONT-SIZE: 10pt; ">
                                            <asp:Label ID="Label22" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Height="17px" Text="Localidad Demografica:" Visible="False" 
                                                Width="149px"></asp:Label>
                                        </td>
                                        <td style="HEIGHT: 24px">
                                            <asp:DropDownList ID="cmblocalidad" runat="server" Enabled="False" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="18px" TabIndex="12" 
                                                Visible="False" Width="203px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style73" 
                                    
                                    
                                            
                                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; ">
                                            <asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#000066" onkeypress="return SoloLetras(event)" 
                                                Text="Apellido Paterno {*}:" Width="124px"></asp:Label>
                                        </td>
                                        <td class="style74">
                                            <asp:TextBox ID="Txtpriape" runat="server" BorderColor="#2E6A99" 
                                                BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                Height="28px" onkeypress="return SoloLetras(event)" tabIndex="3" 
                                                Width="200px" CssClass="ToUpper"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rqv1" runat="server" 
                                                ControlToValidate="Txtpriape" ErrorMessage="Falta Apellido Paterno">*</asp:RequiredFieldValidator>
                                            <cc1:ValidatorCalloutExtender ID="rqv1_ValidatorCalloutExtender" runat="server" 
                                                Enabled="True" TargetControlID="rqv1">
                                            </cc1:ValidatorCalloutExtender>
                                        </td>
                                        <td class="style75" style="FONT-SIZE: 10pt; ">
                                            <asp:Label ID="Label8" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#000066" Text="Primer Nombre {*}:" 
                                                Width="124px"></asp:Label>
                                        </td>
                                        <td class="style98" style="font-family: Gill Sans MT; font-size: 12px;">
                                            <asp:TextBox ID="TxtNomcli" runat="server" BorderColor="#2E6A99" 
                                                BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                Height="28px" onkeypress="return SoloLetras(event)" tabIndex="5" 
                                                Width="200px" CssClass="ToUpper"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rqv2" runat="server" 
                                                ControlToValidate="TxtNomcli" ErrorMessage="Falta Primer Nombre ">*</asp:RequiredFieldValidator>
                                            <cc1:ValidatorCalloutExtender ID="rqv2_ValidatorCalloutExtender" runat="server" 
                                                Enabled="True" TargetControlID="rqv2">
                                            </cc1:ValidatorCalloutExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style79" 
                                    
                                    
                                            
                                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; ">
                                            <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#000066" onkeypress="return SoloLetras(event)" 
                                                Text="Apellido Materno:" Width="124px"></asp:Label>
                                        </td>
                                        <td class="style80">
                                            <asp:TextBox ID="Txtsegape" runat="server" BorderColor="#2E6A99" 
                                                BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                Height="28px" onkeypress="return SoloLetras(event)" tabIndex="4" 
                                                Width="200px" CssClass="ToUpper"></asp:TextBox>
                                        </td>
                                        <td class="style81" style="FONT-SIZE: 10pt; ">
                                            <asp:Label ID="Label7" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#000066" onkeypress="return SoloLetras(event)" 
                                                Text="Segundo Nombre :" Width="124px"></asp:Label>
                                        </td>
                                        <td class="style82" style="font-family: Gill Sans MT; font-size: 12px;">
                                          
                                            <asp:TextBox ID="Txtsegnom" runat="server" BorderColor="#2E6A99" 
                                                BorderWidth="1px" CssClass="ToUpper" Enabled="False" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Height="28px" onkeypress="return SoloLetras(event)" 
                                                tabIndex="6" Width="200px"></asp:TextBox>
                                          
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style19" 
                                    
                                    
                                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; ">
                                            <asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Tercer Nombre:" Width="124px" 
                                                onkeypress="return SoloLetras(event)" Visible="False"></asp:Label>
                                        </td>
                                        <td class="style23">
                                            <asp:TextBox ID="Txtternom" runat="server" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="7" Width="200px"
                                            onkeypress="return SoloLetras(event)" BorderColor="#2E6A99" BorderWidth="1px" 
                                                Height="28px" Visible="False" CssClass="ToUpper"></asp:TextBox>
                                        </td>
                                        <td class="style24" style="FONT-SIZE: 10pt; ">
                                            <asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Apellido de Casada:" Width="124px" 
                                        ForeColor="#000066" Visible="False" onkeypress="return SoloLetras(event)"></asp:Label>
                                        </td>
                                        <td class="style22" style="font-family: Gill Sans MT; font-size: 12px;">
                                            <asp:TextBox ID="Txtapecasada" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="8" Width="200px" 
                                        Visible="False" BorderColor="#2E6A99" BorderWidth="1px" Height="28px" 
                                                CssClass="ToUpper"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style77" 
                                    
                                    
                                            
                                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; ">
                                            <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Lugar Nacimiento:" Width="124px"></asp:Label>
                                        </td>
                                        <td class="style78">
                                            <asp:DropDownList ID="DropDownDeptos0" runat="server" AutoPostBack="True" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="25px" 
                                                onchange="CargaMuni0();" TabIndex="9" Width="208px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style13" style="FONT-SIZE: 10pt; ">
                                            <asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Text="Fec.Nacimiento:" Width="124px" ForeColor="#000066"></asp:Label>
                                        </td>
                                        <td style="font-family: Gill Sans MT; font-size: 12px;">
                                            <table cellpadding="0" cellspacing="0" class="style27">
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TxtDfecnaci" runat="server" BackColor="White" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" onChange="Getfecha()" tabIndex="10" 
                                                    Width="116px" BorderColor="#2E6A99" BorderWidth="1px" Height="28px"></asp:TextBox>
                                                        <cc1:MaskedEditExtender ID="Mask_EditExt1" runat="server" 
                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="TxtDfecnaci">
                                                        </cc1:MaskedEditExtender>
                                                        <cc1:CalendarExtender ID="TxtDfecnaci_CalendarExtender" runat="server" 
                                                    Format="dd/MM/yyyy" PopupButtonID="Image_btn1" PopupPosition="Right" 
                                                    TargetControlID="TxtDfecnaci">
                                                        </cc1:CalendarExtender>
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton ID="Image_btn1" runat="server" 
                                                    ImageUrl="~/web/gifs/Calendar_scheduleHS.png" />
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TxtEdad" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Width="64px" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Height="28px" Visible="False"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style19" 
                                    
                                    
                                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; ">
                                            <asp:Label ID="Label45" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Text="Sexo:" Width="124px"></asp:Label>
                                        </td>
                                        <td class="style23">
                                            <asp:DropDownList ID="cmbGenCli" runat="server" Enabled="False" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="11" Width="208px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style24" style="FONT-SIZE: 10pt; ">
                                            &nbsp;</td>
                                        <td class="style22" 
                                    style="font-family: Gill Sans MT; font-size: 12px; color: #999999;">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style19" 
                                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; ">
                                            Nº CURP {*}:</td>
                                        <td class="style23">
                                            <table cellpadding="0" cellspacing="0" class="style27">
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="Txtorden" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                            Height="28px" MaxLength="14" tabIndex="5" Visible="False" Width="39px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TxtIdCivil" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                            Height="28px" MaxLength="18" onkeypress="return SoloLetras_Numeros(event)" 
                                                            tabIndex="12" Width="161px" CssClass="ToUpper"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rqv4" runat="server" 
                                                            ControlToValidate="TxtIdCivil" ErrorMessage="Falta N° CURP">*</asp:RequiredFieldValidator>
                                                        <cc1:ValidatorCalloutExtender ID="rqv4_ValidatorCalloutExtender" runat="server" 
                                                            Enabled="True" TargetControlID="rqv4">
                                                        </cc1:ValidatorCalloutExtender>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td class="style24" style="FONT-SIZE: 10pt; ">
                                            <asp:TextBox ID="txtiva" runat="server" Enabled="False" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" MaxLength="8" 
                                                tabIndex="14" Visible="False" Width="62px"></asp:TextBox>
                                            <asp:Label ID="Label6" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#666666" Visible="False"></asp:Label>
                                        </td>
                                        <td class="style22" 
                                            style="font-family: Gill Sans MT; font-size: 12px; color: #999999;">
                                            Formato (dd/mm/yyyy)<cc1:MaskedEditValidator ID="Mask_Edit1" runat="server" 
                                                ControlExtender="Mask_EditExt1" ControlToValidate="TxtDfecnaci" 
                                                Display="Dynamic" EmptyValueMessage="La fecha es requerida" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" InvalidValueMessage="Fecha Invalida" 
                                                IsValidEmpty="False" TooltipMessage="Por favor Digite una Fecha">
                                            </cc1:MaskedEditValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style33" 
                                    
                                    
                                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; ">
                                            <asp:Label ID="Label44" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Text="IFE {*}:" Width="124px"></asp:Label>
                                        </td>
                                        <td class="style34">
                                            <asp:TextBox ID="TxtIFE" runat="server" BorderColor="#2E6A99" BorderWidth="1px" 
                                                Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" 
                                                MaxLength="13" onkeypress="return SoloNumeros(event)" tabIndex="13" 
                                                Width="161px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rqv5" runat="server" ControlToValidate="TxtIFE" 
                                                ErrorMessage="Falta N° IFE">*</asp:RequiredFieldValidator>
                                            <cc1:ValidatorCalloutExtender ID="rqv5_ValidatorCalloutExtender" runat="server" 
                                                Enabled="True" TargetControlID="rqv5">
                                            </cc1:ValidatorCalloutExtender>
                                        </td>
                                        <td class="style35" style="FONT-SIZE: 10pt; ">
                                            <p align="left" 
                                        
                                        
                                        
                                                style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; width: 115px;">
                                                RFC {*}</p>
                                        </td>
                                        <td class="style36">
                                            <asp:TextBox ID="TxtIdTribu" runat="server" Enabled="False" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt" MaxLength="13" tabIndex="14" 
                                        Width="168px" Height="28px" onkeypress="return SoloLetras_Numeros(event)" 
                                                BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rqv6" runat="server" 
                                                ControlToValidate="TxtIdTribu" ErrorMessage="Falta No RFC">*</asp:RequiredFieldValidator>
                                            <cc1:ValidatorCalloutExtender ID="rqv6_ValidatorCalloutExtender" runat="server" 
                                                Enabled="True" TargetControlID="rqv6">
                                            </cc1:ValidatorCalloutExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 23px">
                                            <asp:Label ID="Label46" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Text="Profesión:" Width="124px"></asp:Label>
                                        </td>
                                        <td class="style8">                                            
                                            <asp:DropDownList ID="cmbProfCli" runat="server" Enabled="False" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="15" Width="208px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style13" 
                                    
                                    
                                            
                                            style="FONT-SIZE: 10pt; font-weight: normal; color: #16387c; font-style: normal; font-family: Gill Sans MT; ">
                                            <asp:Label ID="Label18" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#000066" Text="Nº Hijos:" Width="107px"></asp:Label>
                                        </td>
                                        <td style="HEIGHT: 23px">                                            
                                                   <asp:TextBox ID="txthijos" runat="server" BorderColor="#2E6A99" 
                                                        BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                        Height="28px" MaxLength="8" style="vertical-align:top" tabIndex="16" 
                                                        Width="89px"></asp:TextBox>
                                                    <cc1:NumericUpDownExtender ID="txthijos_NumericUpDownExtender" runat="server" 
                                                        Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                                        ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                        TargetButtonUpID="" TargetControlID="txthijos" Width="60">
                                                    </cc1:NumericUpDownExtender>
                                                
                                            
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 2px">
                                            <asp:Label ID="Label47" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Text="Estado Civil:" Width="124px"></asp:Label>
                                        </td>
                                        <td class="style9">
                                            <asp:DropDownList ID="cmbEstCli" runat="server" Enabled="False" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="17" Width="208px">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style14" style="FONT-SIZE: 10pt; ">
                                            <p align="left" 
                                        
                                        
                                                style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">
                                                <asp:Label ID="Label5" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Text="Nº Dependientes:" Width="107px"></asp:Label>
                                            </p>
                                        </td>
                                        <td style="HEIGHT: 2px">
                                            <asp:TextBox ID="txtdepen" runat="server" BorderColor="#2E6A99" 
                                                BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                Height="28px" MaxLength="8" style="vertical-align:top" tabIndex="18" 
                                                Width="89px"></asp:TextBox>
                                            <cc1:NumericUpDownExtender ID="txtdepen_NumericUpDownExtender" runat="server" 
                                                Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                TargetButtonUpID="" TargetControlID="txtdepen" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 16px">
                                            &nbsp;</td>
                                        <td class="style10">
                                            &nbsp;</td>
                                        <td class="style15" style="FONT-SIZE: 10pt; ">
                                            &nbsp;</td>
                                        <td style="HEIGHT: 16px">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 16px">
                                            &nbsp;</td>
                                        <td class="style10">
                                            &nbsp;</td>
                                        <td class="style15" style="FONT-SIZE: 10pt; ">
                                            &nbsp;</td>
                                        <td style="HEIGHT: 16px">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 16px">
                                            &nbsp;</td>
                                        <td class="style10">
                                            &nbsp;</td>
                                        <td class="style15" style="FONT-SIZE: 10pt; ">
                                            &nbsp;</td>
                                        <td style="HEIGHT: 16px">
                                            &nbsp;</td>
                                    </tr>
                                </TABLE>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="FONT-SIZE: 11pt">
                                <P style="FONT-WEIGHT: normal; FONT-SIZE: 11pt; COLOR: White; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #006699"
					align="center">
                                    Domicilio</P>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="FONT-SIZE: 11pt" class="style39">
                                <table cellpadding="0" cellspacing="0" class="style27">
                                    <tr>
                                        <td>
                                            <table cellpadding="0" cellspacing="0" class="style27">
                                                <tr>
                                                    <td class="style96">
                                                        <asp:Label ID="Label41" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" ForeColor="#000066" Text="Estado:" Width="107px"></asp:Label>
                                                    </td>
                                                    <td class="style91">
                                                        <asp:DropDownList runat="server" AutoPostBack="True" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="21px" TabIndex="19" Width="202px" ID="DropDownDeptos" >
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label42" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" ForeColor="#000066" Text="Municipio:" Width="107px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList runat="server" AutoPostBack="True" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" TabIndex="20" Width="202px" ID="DropDownMuni" 
                                onchange="CargaComu();">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style95">
                                                        <asp:Label ID="Label48" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" ForeColor="#000066" Text="Calle {*}:" Width="107px"></asp:Label>
                                                    </td>
                                                    <td class="style92">
                                                        <asp:TextBox ID="TxtcCalle" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                            Height="28px" onkeypress="return SoloLetras_Numeros(event)" tabIndex="21" 
                                                            Width="200px" CssClass="ToUpper"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rqv7" runat="server" 
                                                            ControlToValidate="TxtcCalle" ErrorMessage="Falta Nombre de la Calle">*</asp:RequiredFieldValidator>
                                                        <cc1:ValidatorCalloutExtender ID="rqv7_ValidatorCalloutExtender" runat="server" 
                                                            Enabled="True" TargetControlID="rqv7">
                                                        </cc1:ValidatorCalloutExtender>
                                                    </td>
                                                    <td class="style87">
                                                        <asp:Label ID="Label49" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" ForeColor="#000066" Text="No Ext:" Width="107px"></asp:Label>
                                                    </td>
                                                    <td class="style87">
                                                        <asp:TextBox ID="TxtcNoExt" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                            Height="28px" onkeypress="return SoloNumeros(event)" tabIndex="22" Width="200px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rqv12" runat="server" 
                                                            ControlToValidate="TxtcNoExt" ErrorMessage="Falta N° Exterior">*</asp:RequiredFieldValidator>
                                                        <cc1:ValidatorCalloutExtender ID="rqv12_ValidatorCalloutExtender" 
                                                            runat="server" Enabled="True" TargetControlID="rqv12">
                                                        </cc1:ValidatorCalloutExtender>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style96">
                                                        <asp:Label ID="Label50" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" ForeColor="#000066" Text="No Int:" Width="107px"></asp:Label>
                                                    </td>
                                                    <td class="style91">
                                                        <asp:TextBox ID="TxtcNoInt" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                            Height="28px" onkeypress="return SoloNumeros(event)" tabIndex="23" Width="200px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table cellpadding="0" cellspacing="0" class="style27">
                                                <tr>
                                                    <td class="style96">
                                                        <asp:Label ID="Label43" runat="server" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" ForeColor="#000066" Text="Colonia:" Width="107px"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="DropDownComu" runat="server" AutoPostBack="True" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" TabIndex="24" 
                                                            Width="507px">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style97">
                                                        <asp:Label ID="Label51" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" ForeColor="#000066" Text="Cod. Postal {*}:" Width="107px"></asp:Label>
                                                    </td>
                                                    <td class="style88">
                                                        <asp:TextBox ID="TxtcCodPostal" runat="server" BorderColor="#2E6A99" 
                                                            BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                            Height="28px" onkeypress="return SoloNumeros(event)" tabIndex="24" Width="200px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rqv8" runat="server" 
                                                            ControlToValidate="TxtcCodPostal" ErrorMessage="Falta N° Codigo Postal">*</asp:RequiredFieldValidator>
                                                        <cc1:ValidatorCalloutExtender ID="rqv8_ValidatorCalloutExtender" runat="server" 
                                                            Enabled="True" TargetControlID="rqv8">
                                                        </cc1:ValidatorCalloutExtender>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style96">
                                                        <asp:Label ID="Label19" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" Height="17px" Text="Dirección:" 
                                                            Width="96px" ForeColor="#000099" Visible="False"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TxtDirDom" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="42px" TabIndex="24" 
                                                            TextMode="MultiLine" Width="510px" BorderColor="#2E6A99" BorderWidth="1px" 
                                                            Visible="False"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table id="Table3" border="0" cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style70">
                                                        <asp:Label runat="server" Text="Telèfono Fijo {*}:" Font-Names="Gill Sans MT" 
                                                        Font-Size="10pt" Width="96px" ID="Label21" Height="17px"></asp:Label>
                                                    </td>
                                                    <td class="style71">
                                                        <asp:TextBox runat="server" MaxLength="10" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="26" Width="120px" 
                                ID="TxtTelDom" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99" BorderWidth="1px" 
                                                            Height="28px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rqv9" runat="server" 
                                                            ControlToValidate="TxtTelDom" ErrorMessage="Falta N° Telefono Fijo">*</asp:RequiredFieldValidator>
                                                        <cc1:ValidatorCalloutExtender ID="rqv9_ValidatorCalloutExtender" runat="server" 
                                                            Enabled="True" TargetControlID="rqv9">
                                                        </cc1:ValidatorCalloutExtender>
                                                    </td>
                                                    <td class="style72" 
                                
                            
                            
                                                        
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                        <asp:Label runat="server" Text="Teléfono Celular {*}:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="17px" Width="120px" ID="Label20"></asp:Label>
                                                    </td>
                                                    <td class="style71">
                                                        <asp:TextBox runat="server" Enabled="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="27" 
                                Width="120px" ID="txtcelular" MaxLength="10" onkeypress="return SoloNumeros(event)" 
                                                            BorderColor="#2E6A99" BorderWidth="1px" Height="28px"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rqv10" runat="server" 
                                                            ControlToValidate="txtcelular" ErrorMessage="Falta N° Telefono Celular">*</asp:RequiredFieldValidator>
                                                        <cc1:ValidatorCalloutExtender ID="rqv10_ValidatorCalloutExtender" 
                                                            runat="server" Enabled="True" TargetControlID="rqv10">
                                                        </cc1:ValidatorCalloutExtender>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style46">
                                                        <asp:Label runat="server" Text="Otro telefono:" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Width="124px" 
                                ID="Label16"></asp:Label>
                                                    </td>
                                                    <td class="style22">
                                                        <asp:TextBox ID="txtotrtel" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" MaxLength="10" 
                                                            onkeypress="return SoloNumeros(event)" TabIndex="28" Width="120px" 
                                                            BorderColor="#2E6A99" BorderWidth="1px" Height="28px"></asp:TextBox>
                                                    </td>
                                                    <td class="style47" 
                                
                            
                            
                                                        
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                        &nbsp;</td>
                                                    <td class="style22">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style48">
                                                        <asp:Label runat="server" Text="Condición de la Vivienda:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="152px" ID="Label2"></asp:Label>
                                                    </td>
                                                    <td class="style49">
                                                        <asp:DropDownList ID="cmbCondicion" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="30" Width="208px">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td class="style50" 
                                
                            
                            
                                                        
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                        <asp:Label runat="server" Text="Otro:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="90px" ID="Label27" 
                                Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style49">
                                                        <asp:TextBox ID="txtotracondicion" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" TabIndex="31" 
                                                            Width="208px" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style51">
                                                        <asp:Label runat="server" Text="Paredes:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="90px" ID="Label28" 
                                Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style52">
                                                        <asp:ListBox ID="cmbparedes" runat="server" Font-Names="Gill Sans MT" 
                                                            Height="60px" SelectionMode="Multiple" TabIndex="32" Width="148px">
                                                            <asp:ListItem Value="1">Adobe</asp:ListItem>
                                                            <asp:ListItem Value="2">Block</asp:ListItem>
                                                            <asp:ListItem Value="3">Ladrillo</asp:ListItem>
                                                            <asp:ListItem Value="4">Madera</asp:ListItem>
                                                            <asp:ListItem Value="5">Otro</asp:ListItem>
                                                        </asp:ListBox>
                                                    </td>
                                                    <td class="style53" 
                                
                            
                            
                                                        
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                        <asp:Label runat="server" Text="Piso:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="90px" ID="Label30" 
                                Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style52">
                                                        <asp:ListBox ID="cmbpiso" runat="server" Font-Names="Gill Sans MT" 
                                                            Height="60px" SelectionMode="Multiple" TabIndex="33" Width="148px">
                                                            <asp:ListItem Value="1">Tierra</asp:ListItem>
                                                            <asp:ListItem Value="2">Cemento</asp:ListItem>
                                                            <asp:ListItem Value="3">Granito</asp:ListItem>
                                                            <asp:ListItem Value="4">Ceramico</asp:ListItem>
                                                            <asp:ListItem Value="5">Otro</asp:ListItem>
                                                        </asp:ListBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style43">
                                                        <asp:Label runat="server" Text="Otro:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="90px" ID="Label29" 
                                Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style44">
                                                        <asp:TextBox ID="txtotracondicion0" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="23px" TabIndex="34" 
                                                            Width="208px"></asp:TextBox>
                                                    </td>
                                                    <td class="style45" 
                                
                            
                            
                                                        
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                        <asp:Label runat="server" Text="Otro:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="90px" ID="Label31" 
                                Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style44">
                                                        <asp:TextBox ID="txtotracondicion1" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" TabIndex="37" 
                                                            Width="208px" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style54">
                                                        <asp:Label runat="server" Text="Techo:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="90px" ID="Label32" 
                                Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style55">
                                                        <asp:ListBox ID="cmbtecho" runat="server" Font-Names="Gill Sans MT" 
                                                            Height="60px" SelectionMode="Multiple" TabIndex="38" Width="148px">
                                                            <asp:ListItem Value="1">Lamina</asp:ListItem>
                                                            <asp:ListItem Value="2">Terraza</asp:ListItem>
                                                            <asp:ListItem Value="3">Otro</asp:ListItem>
                                                        </asp:ListBox>
                                                    </td>
                                                    <td class="style56" 
                                
                            
                            
                                                        
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                        <asp:Label runat="server" Text="Servicios:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="90px" ID="Label34" 
                                Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style55">
                                                        <asp:ListBox ID="cmbservicios" runat="server" Font-Names="Gill Sans MT" 
                                                            SelectionMode="Multiple" TabIndex="39" Width="148px">
                                                            <asp:ListItem Value="1">Agua</asp:ListItem>
                                                            <asp:ListItem Value="2">Energia Electrica</asp:ListItem>
                                                            <asp:ListItem Value="3">Drenaje</asp:ListItem>
                                                            <asp:ListItem Value="4">Fosa Septica</asp:ListItem>
                                                            <asp:ListItem Value="5">Otros</asp:ListItem>
                                                        </asp:ListBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style57">
                                                        <asp:Label runat="server" Text="Otro:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="90px" ID="Label33" 
                                Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style58">
                                                        <asp:TextBox runat="server" Enabled="False" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="28px" TabIndex="39" Width="208px" ID="txtotracondicion2" 
                                                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                    </td>
                                                    <td class="style59" 
                                
                            
                            
                                                        
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                        <asp:Label runat="server" Text="Otro:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" ForeColor="#000066" Width="90px" ID="Label35" 
                                Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style58">
                                                        <asp:TextBox runat="server" Enabled="False" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" TabIndex="40" Width="208px" ID="txtotracondicion3" Height="28px" 
                                                            BorderColor="#2E6A99" BorderWidth="1px" style="margin-bottom: 0px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style60">
                                                        <asp:Label runat="server" Text="Dueño:" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#000066" Width="90px" 
                                ID="Label36" Height="16px"></asp:Label>
                                                    </td>
                                                    <td class="style61">
                                                        <asp:textbox id="txtdueño" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="40" Height="28px" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                                    </td>
                                                    <td class="style62" 
                                
                            
                            
                                                        
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                        <asp:Label ID="Label37" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Valor Aproximado:" 
                                                            Width="126px"></asp:Label>
                                                    </td>
                                                    <td class="style61">
                                                        <asp:TextBox ID="txtvalor" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                            onkeypress="return NumCheck(event, this)" TabIndex="41" Width="120px" 
                                                            BorderColor="#2E6A99" BorderWidth="1px" Height="28px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style63" 
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                        <asp:Label ID="Label38" runat="server" Font-Names="Gill Sans MT" 
                                                            Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Año desde que Reside:" 
                                                            Width="134px"></asp:Label>
                                                    </td>
                                                    <td class="style64">
                                                        <asp:TextBox ID="txtrecidir" runat="server" Enabled="False" 
                                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" 
                                                            onkeypress="return SoloNumeros(event)" style="vertical-align:top" tabIndex="42" 
                                                            Width="89px" BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                                        <cc1:NumericUpDownExtender ID="txtrecidir_NumericUpDownExtender" runat="server" 
                                                            Enabled="True" Maximum="2030" Minimum="0" RefValues="" ServiceDownMethod="" 
                                                            ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                            TargetButtonUpID="" TargetControlID="txtrecidir" Width="60">
                                                        </cc1:NumericUpDownExtender>
                                                    </td>
                                                    <td class="style65" 
                                                        style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                                                    </td>
                                                    <td class="style64">
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </TD>
                        </TR>
                        <TR align="center" 
            style="font-family: Gill Sans MT; font-size: 12px; color: #FFFFFF;">
                            <TD style="FONT-SIZE: 14pt; HEIGHT: 20px; BACKGROUND-COLOR: #3366FF" 
                bgcolor="#000099">
                                Otros
                                <TD style="FONT-SIZE: 11pt; HEIGHT: 20px; ">
                                    &nbsp;</TD>
                        </TR>
                        <TR align="center" 
            style="font-family: Gill Sans MT; font-size: 12px; color: #FFFFFF;">
                            <TD style="FONT-SIZE: 14pt; HEIGHT: 20px; BACKGROUND-COLOR: #3366FF" 
                bgcolor="#000099">
                                <table cellpadding="0" cellspacing="0" class="style4" align="center" 
                    bgcolor="White">
                                    <tr>
                                        <td align="right" class="style5">
                                            <asp:Label ID="Label1" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Text="Etnia:" Visible="False"></asp:Label>
                                        </td>
                                        <td align="center" class="style89">
                                            <asp:dropdownlist id="cmbEtnia" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="43" Visible="False">
                                            </asp:dropdownlist>
                                        </td>
                                        <td align="right" class="style37">
                                            <asp:Label ID="Label23" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Grupo Etnico:" Width="124px" Visible="False"></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:dropdownlist id="cmbgruetnico" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="44" Visible="False">
                                            </asp:dropdownlist>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style66">
                                            <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Idiomas que domina:" Width="124px" Visible="False"></asp:Label>
                                        </td>
                                        <td align="left" class="style67">
                                            <asp:ListBox runat="server" SelectionMode="Multiple" Font-Names="Gill Sans MT" 
                                Width="148px" ID="cmbidiomas" TabIndex="45" Visible="False"></asp:ListBox>
                                        </td>
                                        <td align="right" class="style68">
                                        </td>
                                        <td align="left" class="style69">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style28">
                                            <asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Text="Escolaridad:"></asp:Label>
                                        </td>
                                        <td align="center" class="style90">
                                            <asp:dropdownlist id="cmbNivel" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="46">
                                            </asp:dropdownlist>
                                        </td>
                                        <td align="right" class="style38">
                                            <asp:Label ID="Label17" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Grado:" Width="124px" ForeColor="#000066" 
                                Visible="False"></asp:Label>
                                        </td>
                                        <td align="left" class="style31">
                                            <asp:textbox id="txtgrado" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="200px" tabIndex="47" Visible="False" BorderColor="#2E6A99" BorderWidth="1px" Height="28px"></asp:textbox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style5">
                                            <asp:Label ID="Label13" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Sabe leer:" Width="124px" ForeColor="#000066"></asp:Label>
                                        </td>
                                        <td align="center" class="style89">
                                            <asp:DropDownList ID="cmbleer" runat="server" Enabled="False" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="48" Width="208px">
                                            </asp:DropDownList>
                                        </td>
                                        <td align="right" class="style37">
                                            <asp:Label ID="Label15" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="17px" Text="Sabe firmar:" Width="96px" 
                                ForeColor="#000066"></asp:Label>
                                        </td>
                                        <td align="left">
                                            <asp:dropdownlist id="cmbfirmar" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="49">
                                            </asp:dropdownlist>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style28">
                                            <asp:Label ID="Label4" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Text="Datos Adicionales:"></asp:Label>
                                        </td>
                                        <td align="center" class="style90">
                                            <asp:textbox id="Txtadicionales" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" Height="37px" TextMode="MultiLine" tabIndex="50"></asp:textbox>
                                        </td>
                                        <td align="right" class="style38">
                                            <asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Sabe escribir:" Width="124px" ForeColor="#000066"></asp:Label>
                                        </td>
                                        <td align="left" class="style31">
                                            <asp:dropdownlist id="cmbescribir" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="51">
                                            </asp:dropdownlist>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style28">
                                            <asp:Label ID="Label52" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Correo Electronico {*}:" 
                                                Width="130px"></asp:Label>
                                        </td>
                                        <td align="center" class="style90">
                                            <asp:TextBox ID="txtccorreo" runat="server" BorderColor="#2E6A99" 
                                                BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                Height="28px" TabIndex="52" Width="208px" CssClass="ToUpper"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rqv11" runat="server" 
                                                ControlToValidate="txtccorreo" ErrorMessage="Falta Correo Electronico" 
                                                Font-Bold="True">*</asp:RequiredFieldValidator>
                                            <cc1:ValidatorCalloutExtender ID="rqv11_ValidatorCalloutExtender" 
                                                runat="server" Enabled="True" TargetControlID="rqv11">
                                            </cc1:ValidatorCalloutExtender>
                                        </td>
                                        <td align="right" class="style38">
                                            <asp:Label ID="Label53" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Usuario Facebook:" 
                                                Width="120px"></asp:Label>
                                        </td>
                                        <td align="left" class="style31">
                                            <asp:TextBox ID="txtcusuface" runat="server" BorderColor="#2E6A99" 
                                                BorderWidth="1px" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                Height="28px" TabIndex="52" Width="208px" CssClass="ToUpper"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                                <TD style="FONT-SIZE: 11pt; HEIGHT: 20px; ">
                                    &nbsp;</TD>
                        </TR>
                        <TR>
                            <TD style="FONT-SIZE: 11pt; HEIGHT: 20px; BACKGROUND-COLOR: maroon">
                                <P style="FONT-WEIGHT: normal; FONT-SIZE: 11pt; COLOR: White; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #006699"
					align="center">
                                    Datos del Conyuge/Familiar</P>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 69px">
                                <TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
                                    <TR>
                                        <TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                            <asp:Label ID="Label39" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Codigo Conyuge/Familiar:" Width="124px"></asp:Label>
                                        </TD>
                                        <TD class="style93">
                                            <asp:TextBox runat="server" MaxLength="12" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" ID="TxtId" TabIndex="52" 
                                                BorderColor="#2E6A99" Height="28px"></asp:TextBox>
                                        </TD>
                                        <TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                            <asp:Label ID="Label40" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Relacion con Cliente:" Width="76px" Height="16px"></asp:Label>
                                        </TD>
                                        <TD style="HEIGHT: 24px">
                                            <asp:dropdownlist id="cmbParent" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="53">
                                            </asp:dropdownlist>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                            Nombre</TD>
                                        <TD class="style93">
                                            <asp:textbox id="TxtNomC" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" runat="server"
								Width="200px" tabIndex="54" BorderColor="#2E6A99" BorderWidth="1px" Height="28px"></asp:textbox>
                                        </TD>
                                        <TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                            Nacimiento</TD>
                                        <TD style="HEIGHT: 24px">
                                            <asp:textbox id="TxtNacCony" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" runat="server" onChange = "Getfecha1()"
								Width="120px" MaxLength="10" tabIndex="55" BorderColor="#2E6A99" BorderWidth="1px" Height="28px"></asp:textbox>
                                            <cc1:MaskedEditExtender ID="TxtNacCony_MaskedEdit" runat="server" 
                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                Mask="99/99/9999" MaskType="Date" TargetControlID="TxtNacCony">
                                            </cc1:MaskedEditExtender>
                                            <asp:textbox id="TxtEdadCony" tabIndex="56" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False"
								runat="server" Width="60px" BorderColor="#2E6A99" BorderWidth="1px" Height="28px" Visible="False"></asp:textbox>
                                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                ControlExtender="TxtNacCony_MaskedEdit" ControlToValidate="TxtNacCony" 
                                Display="Dynamic" EmptyValueMessage="La fecha es requerida" 
                                ErrorMessage="Mask_Edit2" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                InvalidValueMessage="Fecha Invalida" 
                                TooltipMessage="Por favor Digite una Fecha">
                                            </cc1:MaskedEditValidator>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                            No CURP:<br />
                                        </TD>
                                        <TD class="style93">
                                            <asp:textbox id="TxtIdCony" tabIndex="57" 
                                Font-Names="Gill Sans MT" Font-Size="10pt"
								runat="server" Width="140px" MaxLength="18" Height="28px" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                        </TD>
                                        <TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                            Sexo:</TD>
                                        <TD style="HEIGHT: 24px">
                                            <asp:dropdownlist id="cmbGenCony" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" runat="server"
								Width="192px" tabIndex="58">
                                            </asp:dropdownlist>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                            Profesión</TD>
                                        <TD class="style94">
                                            <asp:dropdownlist id="cmbProfCony" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" runat="server"
								Width="208px" tabIndex="59">
                                            </asp:dropdownlist>
                                        </TD>
                                        <TD style="WIDTH: 79px; HEIGHT: 22px">
                                        </TD>
                                        <TD style="HEIGHT: 22px">
                                            <asp:CheckBox ID="Sleer" runat="server" Font-Bold="False" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Text="Sabe Leer y Escribir" 
                                Checked="True"  tabIndex="60" Visible="False"/>
                                        </TD>
                                    </TR>
                                    <tr>
                                        <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                            <asp:Label ID="Label55" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Latitud {*}:" 
                                                Width="130px"></asp:Label>
                                        </td>
                                        <td class="style94">
                                            <asp:TextBox ID="TxtLat" runat="server" BorderColor="#2E6A99" BorderWidth="1px" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" MaxLength="18" 
                                                tabIndex="57" Width="140px" Enabled="False"></asp:TextBox>
                                        </td>
                                        <td style="WIDTH: 79px; HEIGHT: 22px">
                                            <asp:Label ID="Label56" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Longitud {*}:" 
                                                Width="130px"></asp:Label>
                                        </td>
                                        <td style="HEIGHT: 22px">
                                            <asp:TextBox ID="TxtLng" runat="server" BorderColor="#2E6A99" BorderWidth="1px" 
                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" MaxLength="18" 
                                                tabIndex="57" Width="140px" Enabled="False"></asp:TextBox>
                                        </td>
                                    </tr>
                                </TABLE>
                            </TD>
                        </TR>
                        <TR>
                            <TD>
                                <asp:CheckBox ID="SeguroV" runat="server" Font-Bold="True" 
                                Font-Names="Century Gothic" Font-Size="10pt" 
                    Text="Sujeto a Retención" Visible="False" />
                                <asp:CheckBox ID="Sfirmar" runat="server" Font-Bold="True" 
                                Font-Names="Century Gothic" Font-Size="10pt" Text="Sabe Leer y Escribir" 
                                Checked="True" Visible="False" />
                                <asp:DropDownList ID="DropDownComu0" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Width="110px" Visible="False" Enabled="False" 
                                Height="16px">
                                </asp:DropDownList>
                            </TD>
                        </TR>
                    </TABLE>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td>
                                    <asp:FileUpload ID="fileUpEx" runat="server" Font-Names="Gill Sans MT" 
                                        TabIndex="60" Width="248px" Visible="False" />
                                    <asp:Button ID="btnSubir" runat="server" Font-Names="Gill Sans MT" 
                                        Height="21px" Text="Subir Foto" Width="98px" 
                TabIndex="60" Visible="False" />
                                    <asp:Label ID="lblStatus" runat="server" CssClass="style4" Height="16px" 
                                        Font-Names="Calibri" Font-Size="12pt"></asp:Label>
                                </td>
    </tr>
    <tr>
        <td>
                                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                        <ContentTemplate>
                                            <P align="center" style="text-align: left">
                                                &nbsp;&nbsp;<asp:Button ID="btnuevo" 
                        runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" Text="Nuevo" 
                        Width="85px" />
                                                &nbsp;&nbsp;<asp:Button ID="btgrabar" runat="server" Font-Names="Gill Sans MT" 
                        Font-Size="12pt" Text="Grabar" Width="85px" tabIndex="60" />
                                                <cc1:ConfirmButtonExtender ID="btgrabar_ConfirmButtonExtender" runat="server" 
                                                    ConfirmText="Realmente Desea Continuar ?" Enabled="True" 
                                                    TargetControlID="btgrabar">
                                                </cc1:ConfirmButtonExtender>
                                                &nbsp;&nbsp;<asp:Button ID="bteditar" runat="server" 
                        Font-Names="Gill Sans MT" Font-Size="12pt" Text="Editar" Width="85px" />
                                                &nbsp;&nbsp;<asp:Button ID="btCancela" runat="server" 
                        Font-Names="Gill Sans MT" Font-Size="12pt" Text="Inicializar" Width="85px" />
                                                <cc1:ConfirmButtonExtender ID="btCancela_ConfirmButtonExtender" runat="server" 
                        ConfirmText="Desea Limpiar los Datos ?" Enabled="True" 
                        TargetControlID="btCancela">
                                                </cc1:ConfirmButtonExtender>
                                                &nbsp;&nbsp;<asp:Button ID="btreferencia" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="12pt" Text="Referencias" Width="85px" Enabled="False" />
                                                &nbsp;
                                                <input id="BtnGeolocaliza" onclick="return BuscarZona();" 
                                                    style="font-family: 'Gill Sans MT'; font-size: 12pt; font-weight: normal; height: 35px; width: 95px;" 
                                                    type="button" value="Geolocalizar" visible="True" disabled="disabled" /></P>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                </td>
    </tr>
    <tr>
        <td>
                                                <asp:Button ID="btnubicacion_2" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="12pt" Text="Geocoding" Width="120px" Visible="False" />
                                </td>
    </tr>
    <tr>
        <td>
                                                &nbsp;</td>
    </tr>
</table>
            <asp:HiddenField ID="hfExtension" runat="server" />
            <asp:HiddenField ID="hfPathArchivo" runat="server" />
            
<asp:HiddenField ID="HiddenField1" runat="server" />

            
            <asp:HiddenField ID="hfIdEmpleado" runat="server" />
        

            
