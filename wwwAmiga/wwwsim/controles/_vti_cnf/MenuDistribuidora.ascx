<%@ Control Language="vb" AutoEventWireup="false" Codebehind="MenuDistribuidora.ascx.vb" Inherits="wwwSIM.MenuDistribuidora" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<script language="JavaScript">
<!--
function mmLoadMenus() {
  if (window.mm_menu_0723225714_0) return;
  window.mm_menu_0723225714_0 = new Menu("root",119,18,"Verdana, Arial, Helvetica, sans-serif",12,"#ffffff","#000000","#12428b","#bfd8f2","left","middle",3,0,200,-5,7,true,true,true,0,true,true);
  mm_menu_0723225714_0.addMenuItem("Ayuda&nbsp;de&nbsp;e-PyME","window.open('Ds_Ayudaepyme.aspx', '_self');");
  mm_menu_0723225714_0.addMenuItem("FAQ&acute;s","window.open('Ds_Faqs.aspx', '_self');");
  mm_menu_0723225714_0.addMenuItem("Soporte&nbsp;en&nbsp;L&iacute;nea","window.open('Ds_Soportelinea.aspx', '_self');");
  mm_menu_0723225714_0.addMenuItem("Busqueda","window.open('Ds_Busqueda.aspx', '_self');");
   mm_menu_0723225714_0.hideOnMouseOut=true;
   mm_menu_0723225714_0.menuBorder=1;
   mm_menu_0723225714_0.menuLiteBgColor='#bfd8f2';
   mm_menu_0723225714_0.menuBorderBgColor='#555555';
   mm_menu_0723225714_0.bgColor='#bfd8f2';
  window.mm_menu_0723225052_1 = new Menu("root",212,18,"Verdana, Arial, Helvetica, sans-serif",12,"#ffffff","#000000","#12428b","#bfd8f2","left","middle",3,0,200,-5,7,true,true,true,0,true,true);
  mm_menu_0723225052_1.addMenuItem("Consulta&nbsp;de&nbsp;Producto","window.open('Ds_Consultaproducto.aspx', '_self');");
  mm_menu_0723225052_1.addMenuItem("Consulta&nbsp;por&nbsp;l&iacute;nea","window.open('Ds_Consultalinea.aspx', '_self');");
  mm_menu_0723225052_1.addMenuItem("Consulta&nbsp;por&nbsp;subl&iacute;nea","window.open('Ds_Consultasublinea.aspx', '_self');");
  mm_menu_0723225052_1.addMenuItem("Consulta&nbsp;por&nbsp;Almacen","window.open('Ds_Consultaalmacen.aspx', '_self');");
  mm_menu_0723225052_1.addMenuItem("Consulta&nbsp;por&nbsp;Marcas","window.open('Ds_Consultamarcas.aspx', '_self');");
  mm_menu_0723225052_1.addMenuItem("Consulta&nbsp;por&nbsp;Clientes","window.open('Ds_Consultaclientes.aspx', '_self');");
  mm_menu_0723225052_1.addMenuItem("Consulta&nbsp;por&nbsp;proceso&nbsp;de&nbsp;pedido","window.open('Ds_Consultaproceso.aspx', '_self');");
  mm_menu_0723225052_1.addMenuItem("Consulta&nbsp;por&nbsp;par&aacute;metros","window.open('Ds_Consultaparametros.aspx', '_self');");
  mm_menu_0723225052_1.addMenuItem("Estadisticas","window.open('Ds_Estadisticas.aspx', '_self');");
   mm_menu_0723225052_1.hideOnMouseOut=true;
   mm_menu_0723225052_1.menuBorder=1;
   mm_menu_0723225052_1.menuLiteBgColor='#bfd8f2';
   mm_menu_0723225052_1.menuBorderBgColor='#555555';
   mm_menu_0723225052_1.bgColor='#bfd8f2';
  window.mm_menu_0723224704_0 = new Menu("root",96,18,"Verdana, Arial, Helvetica, sans-serif",12,"#ffffff","#000000","#12428b","#bfd8f2","left","middle",3,0,200,-5,7,true,true,true,0,true,true);
  mm_menu_0723224704_0.addMenuItem("Sugerencias","window.open('Ds_Sugerencias.aspx', '_self');");
  mm_menu_0723224704_0.addMenuItem("Reclamos","window.open('Ds_Reclamos.aspx', '_self');");
  mm_menu_0723224704_0.addMenuItem("Notificaciones","window.open('Ds_Notificaciones.aspx', '_self');");
  mm_menu_0723224704_0.addMenuItem("Noticias","window.open('Ds_Noticias.aspx', '_self');");
  mm_menu_0723224704_0.addMenuItem("Descargas","window.open('Ds_Descargas.aspx', '_self');");
  mm_menu_0723224704_0.addMenuItem("Banners","window.open('Ds_Banners.aspx', '_self');");
   mm_menu_0723224704_0.hideOnMouseOut=true;
   mm_menu_0723224704_0.menuBorder=1;
   mm_menu_0723224704_0.menuLiteBgColor='#bfd8f2';
   mm_menu_0723224704_0.menuBorderBgColor='#555555';
   mm_menu_0723224704_0.bgColor='#bfd8f2';
  window.mm_menu_0723224518_0 = new Menu("root",135,18,"Verdana, Arial, Helvetica, sans-serif",12,"#ffffff","#000000","#12428b","#bfd8f2","left","middle",3,0,200,-5,7,true,true,true,0,true,true);
  mm_menu_0723224518_0.addMenuItem("Encuestas","window.open('Ds_Encuesta.aspx', '_self');");
  mm_menu_0723224518_0.addMenuItem("Resultado&nbsp;Encuesta","window.open('Ds_Resultadoencuesta.aspx', '_self');");
   mm_menu_0723224518_0.hideOnMouseOut=true;
   mm_menu_0723224518_0.menuBorder=1;
   mm_menu_0723224518_0.menuLiteBgColor='#bfd8f2';
   mm_menu_0723224518_0.menuBorderBgColor='#555555';
   mm_menu_0723224518_0.bgColor='#bfd8f2';
  window.mm_menu_0723224247_0 = new Menu("root",75,18,"Verdana, Arial, Helvetica, sans-serif",12,"#ffffff","#000000","#12428b","#bfd8f2","left","middle",3,0,200,-5,7,true,true,true,0,true,true);
  mm_menu_0723224247_0.addMenuItem("Cotizaci&oacute;n","window.open('Ds_Cotizacion.aspx', '_self');");
  mm_menu_0723224247_0.addMenuItem("Historial","window.open('Ds_Historialcotizacion.aspx', '_self');");
  mm_menu_0723224247_0.addMenuItem("Estatus","window.open('Ds_Estatuscotizacion.aspx', '_self');");
   mm_menu_0723224247_0.hideOnMouseOut=true;
   mm_menu_0723224247_0.menuBorder=1;
   mm_menu_0723224247_0.menuLiteBgColor='#bfd8f2';
   mm_menu_0723224247_0.menuBorderBgColor='#555555';
   mm_menu_0723224247_0.bgColor='#bfd8f2';
  window.mm_menu_0723210002_0 = new Menu("root",61,18,"Verdana, Arial, Helvetica, sans-serif",12,"#ffffff","#000000","#12428b","#bfd8f2","left","middle",3,0,200,-5,7,true,true,true,0,true,true);
  mm_menu_0723210002_0.addMenuItem("Pedidos","window.open('Ds_Pedidos.aspx', '_self');");
  mm_menu_0723210002_0.addMenuItem("Estatus","window.open('Ds_Estatuspedido.aspx', '_self');");
  mm_menu_0723210002_0.addMenuItem("Historial","window.open('Ds_Historialpedido.aspx', '_self');");
   mm_menu_0723210002_0.hideOnMouseOut=true;
   mm_menu_0723210002_0.menuBorder=1;
   mm_menu_0723210002_0.menuLiteBgColor='#bfd8f2';
   mm_menu_0723210002_0.menuBorderBgColor='#555555';
   mm_menu_0723210002_0.bgColor='#bfd8f2';
  window.mm_menu_0723194959_0 = new Menu("root",172,18,"Verdana, Arial, Helvetica, sans-serif",12,"#ffffff","#000000","#12428b","#bfd8f2","left","middle",3,0,200,-5,7,true,true,true,0,true,true);
  mm_menu_0723194959_0.addMenuItem("Tipo&nbsp;&nbsp;de&nbsp;Movimientos","window.open('Ds_TipoMovimientos.aspx', '_self');");
  mm_menu_0723194959_0.addMenuItem("Movimientos&nbsp;al&nbsp;Inventario","window.open('Ds_Movimientosinventario.aspx', '_self');");
  mm_menu_0723194959_0.addMenuItem("Almacenes","window.open('Ds_Alamacenes.aspx', '_self');");
  mm_menu_0723194959_0.addMenuItem("L&iacute;neas","window.open('Ds_Lineas.aspx', '_self');");
  mm_menu_0723194959_0.addMenuItem("Subl&iacute;neas","window.open('Ds_Sublineas.aspx', '_self');");
  mm_menu_0723194959_0.addMenuItem("Marcas","window.open('Ds_Marcas.aspx', '_self');");
  mm_menu_0723194959_0.addMenuItem("Productos","window.open('Ds_Productos.aspx', '_self');");
  mm_menu_0723194959_0.addMenuItem("Productos&nbsp;Destacados","window.open('Ds_Productosdestacados.aspx', '_self');");
  mm_menu_0723194959_0.addMenuItem("Ofertas","window.open('Ds_Ofertras.aspx', '_self');");
   mm_menu_0723194959_0.hideOnMouseOut=true;
   mm_menu_0723194959_0.menuBorder=1;
   mm_menu_0723194959_0.menuLiteBgColor='#bfd8f2';
   mm_menu_0723194959_0.menuBorderBgColor='#555555';
   mm_menu_0723194959_0.bgColor='#bfd8f2';
  window.mm_menu_0723205641_1 = new Menu("root",199,18,"Verdana, Arial, Helvetica, sans-serif",12,"#ffffff","#000000","#12428b","#bfd8f2","left","middle",3,0,200,-5,7,true,true,true,0,true,true);
  mm_menu_0723205641_1.addMenuItem("Empresa&nbsp;Distribuidora","window.open('MantDistribuidora.aspx', '_self');");
  mm_menu_0723205641_1.addMenuItem("Cuenta&nbsp;Empresa&nbsp;Distribuidora","window.open('Ds_Cuentaempresa.aspx', '_self');");
  mm_menu_0723205641_1.addMenuItem("Empresa&nbsp;Cliente","window.open('MantCliente.aspx', '_self');");
  mm_menu_0723205641_1.addMenuItem("Cuentas&nbsp;Empresa&nbsp;Cliente","window.open('Ds_Cuentacliente.aspx', '_self');");
   mm_menu_0723205641_1.hideOnMouseOut=true;
   mm_menu_0723205641_1.menuBorder=1;
   mm_menu_0723205641_1.menuLiteBgColor='#bfd8f2';
   mm_menu_0723205641_1.menuBorderBgColor='#555555';
   mm_menu_0723205641_1.bgColor='#bfd8f2';

  mm_menu_0723205641_1.writeMenus();
} // mmLoadMenus()


//-->
</script>
<script language="JavaScript1.2" src="mm_menu.js"></script>
<!--======================== BEGIN COPYING THE HTML HERE ==========================-->
<script language="JavaScript1.2">mmLoadMenus();</script>

<img name="tesis" src="imagenes/tesis.jpg" width="640" height="18" border="0" usemap="#m_tesis">
<map name="m_tesis">
	<area shape="poly" coords="560,0,640,0,640,18,560,18,560,0" href="#" target="Ninguno" alt="" onMouseOut="MM_startTimeout();"  onMouseOver="MM_showMenu(window.mm_menu_0723225714_0,560,18,null,'tesis');"  >
	<area shape="poly" coords="480,0,560,0,560,18,480,18,480,0" href="#" target="Ninguno" alt="" onMouseOut="MM_startTimeout();"  onMouseOver="MM_showMenu(window.mm_menu_0723225052_1,480,18,null,'tesis');"  >
	<area shape="poly" coords="400,0,480,0,480,18,400,18,400,0" href="#" target="Ninguno" alt="" onMouseOut="MM_startTimeout();"  onMouseOver="MM_showMenu(window.mm_menu_0723224704_0,400,18,null,'tesis');"  >
	<area shape="poly" coords="320,0,400,0,400,18,320,18,320,0" href="#" target="Ninguno" alt="" onMouseOut="MM_startTimeout();"  onMouseOver="MM_showMenu(window.mm_menu_0723224518_0,320,18,null,'tesis');"  >
	<area shape="poly" coords="240,0,320,0,320,18,240,18,240,0" href="#" target="Ninguno" alt="" onMouseOut="MM_startTimeout();"  onMouseOver="MM_showMenu(window.mm_menu_0723224247_0,240,18,null,'tesis');"  >
	<area shape="poly" coords="160,0,240,0,240,18,160,18,160,0" href="#" target="Ninguno" alt="" onMouseOut="MM_startTimeout();"  onMouseOver="MM_showMenu(window.mm_menu_0723210002_0,160,18,null,'tesis');"  >
	<area shape="poly" coords="79,1,159,1,159,19,79,19,79,1" href="#" target="Ninguno" alt="" onMouseOut="MM_startTimeout();"  onMouseOver="MM_showMenu(window.mm_menu_0723194959_0,79,19,null,'tesis');"  >
	<area shape="poly" coords="0,0,80,0,80,18,0,18,0,0" href="#" target="Ninguno" alt="" onMouseOut="MM_startTimeout();"  onMouseOver="MM_showMenu(window.mm_menu_0723205641_1,0,18,null,'tesis');"  >
</map>
<!--========================= STOP COPYING THE HTML HERE =========================-->
