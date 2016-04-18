<%@ Register TagPrefix="uc1" TagName="wbpagos" Src="Controles/wbpagos.ascx" %>
<%@ Register TagPrefix="uc1" TagName="MenuIzquierdo" Src="Controles/MenuIzquierdo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="encabezado" Src="Controles/encabezado.ascx" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<%@ page language="vb" autoeventwireup="false" inherits="wbprincipal, App_Web_4ra5sobm" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Control de Pagos</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<style type="text/css">
.menutitle { BORDER-RIGHT: #000000 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #000000 1px solid; PADDING-LEFT: 2px; FONT-WEIGHT: bold; MARGIN-BOTTOM: 5px; PADDING-BOTTOM: 2px; BORDER-LEFT: #000000 1px solid; WIDTH: 140px; CURSOR: pointer; COLOR: #000000; PADDING-TOP: 2px; BORDER-BOTTOM: #000000 1px solid; BACKGROUND-COLOR: #003264; TEXT-ALIGN: center }
.submenu { MARGIN-BOTTOM: 0.5em }
		</style>
		<script type="text/javascript">

/***********************************************
* Switch Menu script- by Martial B of http://getElementById.com/
* Modified by Dynamic Drive for format & NS4/IE4 compatibility
* Visit http://www.dynamicdrive.com/ for full source code
***********************************************/

var persistmenu="yes" //"yes" or "no". Make sure each SPAN content contains an incrementing ID starting at 1 (id="sub1", id="sub2", etc)
var persisttype="sitewide" //enter "sitewide" for menu to persist across site, "local" for this page only

if (document.getElementById){ //DynamicDrive.com change
document.write('<style type="text/css">\n')
document.write('.submenu{display: none;}\n')
document.write('</style>\n')
}

function SwitchMenu(obj){
if(document.getElementById){
var el = document.getElementById(obj);
var ar = document.getElementById("masterdiv").getElementsByTagName("span"); //DynamicDrive.com change
if(el.style.display != "block"){ //DynamicDrive.com change
for (var i=0; i<ar.length; i++){
if (ar[i].className=="submenu") //DynamicDrive.com change
ar[i].style.display = "none";
}
el.style.display = "block";
}else{
el.style.display = "none";
}
}
}

function get_cookie(Name) { 
var search = Name + "="
var returnvalue = "";
if (document.cookie.length > 0) {
offset = document.cookie.indexOf(search)
if (offset != -1) { 
offset += search.length
end = document.cookie.indexOf(";", offset);
if (end == -1) end = document.cookie.length;
returnvalue=unescape(document.cookie.substring(offset, end))
}
}
return returnvalue;
}

function onloadfunction(){
if (persistmenu=="yes"){
var cookiename=(persisttype=="sitewide")? "switchmenu" : window.location.pathname
var cookievalue=get_cookie(cookiename)
if (cookievalue!="")
document.getElementById(cookievalue).style.display="block"
}
}

function savemenustate(){
var inc=1, blockid=""
while (document.getElementById("sub"+inc)){
if (document.getElementById("sub"+inc).style.display=="block"){
blockid="sub"+inc
break
}
inc++
}
var cookiename=(persisttype=="sitewide")? "switchmenu" : window.location.pathname
var cookievalue=(persisttype=="sitewide")? blockid+";path=/" : blockid
document.cookie=cookiename+"="+cookievalue
}

if (window.addEventListener)
window.addEventListener("load", onloadfunction, false)
else if (window.attachEvent)
window.attachEvent("onload", onloadfunction)
else if (document.getElementById)
window.onload=onloadfunction

if (persistmenu=="yes" && document.getElementById)
window.onunload=savemenustate

		</script>
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<BODY onresize="resizeVentana(divHeadImage);">
		<FORM id="Form1" method="post" runat="server" style="BACKGROUND-COLOR: #ffcc00">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="1" width="100%" border="0">
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 286px; HEIGHT: 2px"></TD>
							</TR>
						</TABLE>
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD></TD>
								<TD>
									<uc1:encabezado id="Encabezado1" runat="server"></uc1:encabezado></TD>
							</TR>
							<TR>
								<TD></TD>
								<TD style="BACKGROUND-COLOR: #ffcc33">
									<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<TR>
											<TD style="WIDTH: 328px; BACKGROUND-COLOR: #ffcc00" bgColor="#ffd700">
												<uc1:MenuIzquierdo id="MenuIzquierdo1" runat="server"></uc1:MenuIzquierdo></TD>
											<TD style="WIDTH: 64px">
												<asp:Label id="Label1" runat="server" Width="24px"></asp:Label></TD>
											<TD></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</FORM>
		<script language="javascript">
function resizeVentana(e){
	e.style.width=document.body.clientWidth - 135;
}
		</script>
	</BODY>
</HTML>
