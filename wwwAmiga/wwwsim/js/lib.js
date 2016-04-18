//calcular la edad de una persona
//recibe la fecha como un string en formato español
//devuelve un entero con la edad. Devuelve false en caso de que la fecha sea incorrecta o mayor que el dia actual
function calcular_edad(fecha){

    //calculo la fecha de hoy
    hoy=new Date()    

    //calculo la fecha que recibo
    //La descompongo en un array
    var array_fecha = fecha.split("/")
    //si el array no tiene tres partes, la fecha es incorrecta
    if (array_fecha.length!=3)
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
    if (ano<=99)
       ano =1900+ano

    //resto los años de las dos fechas    
    edad=hoy.getFullYear()- ano; //-1 porque no se si ha cumplido años ya este año

   
       
    //si resto los meses y me da menor que 0 entonces no ha cumplido años. Si da mayor si ha cumplido
    /* if (hoy.getMonth() + 1 - mes < 0) //+ 1 porque los meses empiezan en 0
    return edad
    if (hoy.getMonth() + 1 - mes > 0)
    return edad+1
   
    //entonces es que eran iguales. miro los dias
    //si resto los dias y me da menor que 0 entonces no ha cumplido años. Si da mayor o igual si ha cumplido
    if (hoy.getUTCDate() - dia >= 0)
    return edad + 1*/

    
    return edad
}


function calcular_edad_Otr(fecha) {

    //calculo la fecha de hoy
    hoy = new Date()

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
        ano = 1900 + ano

    //resto los años de las dos fechas    
    edad = hoy.getFullYear() - ano; //-1 porque no se si ha cumplido años ya este año

    //si resto los meses y me da menor que 0 entonces no ha cumplido años. Si da mayor si ha cumplido
    /* if (hoy.getMonth() + 1 - mes < 0) //+ 1 porque los meses empiezan en 0
    return edad
    if (hoy.getMonth() + 1 - mes > 0)
    return edad+1

    //entonces es que eran iguales. miro los dias
    //si resto los dias y me da menor que 0 entonces no ha cumplido años. Si da mayor o igual si ha cumplido
    if (hoy.getUTCDate() - dia >= 0)
    return edad + 1*/

    return edad
}


function HabilitaDescripcion() {
    if (document.getElementById("wbUOtrosPagos1:check1").Checked = true)
        document.getElementById("wbUOtrosPagos1_TextBox3").text = "Pago de Referencias Crediticias";
if (document.getElementById("wbUOtrosPagos1:check2").Checked = true)
    document.getElementById("wbUOtrosPagos1_TextBox3").text = "Pago de Comisiones Crediticias";
if (document.getElementById("wbUOtrosPagos1:check4").Checked = true)
    document.getElementById("wbUOtrosPagos1_TextBox3").text = "Pago de Legalizacion y Otros por concepto de Crediticias";
 }

function HabilitaCampos()
	    {
	        //2 y 6 se habilitan los campos si son diferentes de deshabilitan

	        var EstadoCivil = document.getElementById("WbUCLientes1:cmbEstCli").options[document.getElementById("WbUCLientes1:cmbEstCli").selectedIndex].value
	        if (EstadoCivil==2 || EstadoCivil==6)
	        {
	            document.getElementById("WbUCLientes1_TxtNomC").disabled=false;
	            document.getElementById("WbUCLientes1_TxtIdCony").disabled=false;
	            document.getElementById("WbUCLientes1_cmbProfCony").disabled=false;
	            document.getElementById("WbUCLientes1_TxtNacCony").disabled=false;
	            document.getElementById("WbUCLientes1_cmbGenCony").disabled=false;
	            //alert("lo habilite")
	        }
	        else
	        {
	            document.getElementById("WbUCLientes1_TxtNomC").disabled=false;
	            document.getElementById("WbUCLientes1_TxtIdCony").disabled=false;
	            document.getElementById("WbUCLientes1_cmbProfCony").disabled=false;
	            document.getElementById("WbUCLientes1_TxtNacCony").disabled=false;
	            document.getElementById("WbUCLientes1_cmbGenCony").disabled=false;
	        }
	        
	    }

	    function HabilitaParciales() {

	        if (document.getElementById("WbDesemb1:CheckBox1").Checked = true)
	        {
	            document.getElementById("WbDesemb1_TxtCapita").disabled = true;
	            document.getElementById("WbDesemb1_TxtCapita").text = document.getElementById("WbDesemb1_TextBox13").text;
	            //alert("lo habilite")
	        }
	        else {
	            document.getElementById("WbDesemb1_TxtCapita").disabled = false;
	            document.getElementById("WbDesemb1_TxtCapita").text = document.getElementById("WbDesemb1_TextBox13").text;
	        }

	    }


    function CalculaTotales()
    {
        var Ventas,CxC,OtrosIngresos,CostoVenta,GastosGen,GastosFin,Impuestos,Imprevistos;
        var Ingresos,Egresos,Disponible;
        var Efectivo,CuentasCobrar,Inventario,Fijo,OtrosActivos,Circulante;
        var Activo,Pasivo;
        var CxPagar,OxPagar,Prestamos,Patrimonio,PasivoxPatrimonio;
        
        Ventas=parseFloat(document.getElementById("WbUsBalance1_TextBox1").value);
        CxC=parseFloat(document.getElementById("WbUsBalance1_TextBox4").value);
        OtrosIngresos=parseFloat(document.getElementById("WbUsBalance1_TextBox31").value);
        
        if(isNaN(Ventas))
        Ventas=0;
        if(isNaN(CxC))
        CxC=0;
        if(isNaN(OtrosIngresos))
        OtrosIngresos=0;
        
        
        Ingresos=Ventas+CxC+OtrosIngresos;
        document.getElementById("WbUsBalance1_Txtingresos").value=Ingresos;
        
        CostoVenta=parseFloat(document.getElementById("WbUsBalance1_TextBox12").value);
        GastosGen=parseFloat(document.getElementById("WbUsBalance1_TextBox13").value);
        GastosFin=parseFloat(document.getElementById("WbUsBalance1_TextBox14").value);
        Impuestos=parseFloat(document.getElementById("WbUsBalance1_TextBox15").value);
        Imprevistos=parseFloat(document.getElementById("WbUsBalance1_TextBox17").value);
        
        if(isNaN(CostoVenta))
        CostoVenta=0;
        if(isNaN(GastosGen))
        GastosGen=0;
        if(isNaN(GastosFin))
        GastosFin=0;
        if(isNaN(Impuestos))
        Impuestos=0;
        if(isNaN(Imprevistos))
        Imprevistos=0;
        
        Egresos=CostoVenta+GastosGen+GastosFin+Impuestos+Imprevistos; 
        document.getElementById("WbUsBalance1_Txtegresos").value=Egresos;
        
        Disponible=Ingresos-Egresos;
        document.getElementById("WbUsBalance1_TextBox27").value=Disponible;
        
        Efectivo=parseFloat(document.getElementById("WbUsBalance1_TextBox8").value);
        CuentasCobrar=parseFloat(document.getElementById("WbUsBalance1_TextBox9").value);
        Inventario=parseFloat(document.getElementById("WbUsBalance1_TextBox26").value);
        Fijo=parseFloat(document.getElementById("WbUsBalance1_TextBox10").value);
        OtrosActivos=parseFloat(document.getElementById("WbUsBalance1_TextBox11").value);
        
        //Circulante=parseFloat(document.getElementById("WbUsBalance1_TextBox25").value);
        
        
        if(isNaN(Efectivo))
        Efectivo=0;
        if(isNaN(CuentasCobrar))
        CuentasCobrar=0;
        if(isNaN(Inventario))
        Inventario=0;
        if(isNaN(Fijo))
        Fijo=0;
        if(isNaN(OtrosActivos))
        OtrosActivos=0;
        if(isNaN(Circulante))
        Circulante=0;
        
        Circulante=Efectivo+CuentasCobrar+Inventario;
        
        
        Activo=Fijo+OtrosActivos+Circulante;
        
        document.getElementById("WbUsBalance1_TextBox5").value=Activo;
        
        
        CxPagar=parseFloat(document.getElementById("WbUsBalance1_TextBox21").value);
        OxPagar=parseFloat(document.getElementById("WbUsBalance1_TextBox20").value);
        Prestamos=parseFloat(document.getElementById("WbUsBalance1_TextBox19").value);
        
        if(isNaN(CxPagar))
        CxPagar=0;
        if(isNaN(OxPagar))
        OxPagar=0;
        if(isNaN(Prestamos))
        Prestamos=0;
        
        Pasivo=CxPagar+OxPagar+Prestamos;
               
        document.getElementById("WbUsBalance1_TextBox22").value=Pasivo;        
        
        Patrimonio=Activo-Pasivo;
        
        document.getElementById("WbUsBalance1_TextBox18").value=Patrimonio;
        
        PasivoxPatrimonio=Pasivo+Patrimonio;
        
        document.getElementById("WbUsBalance1_TextBox23").value=PasivoxPatrimonio;
        
    }//fin
	    
