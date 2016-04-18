<%@ Reference Control="~/controles/WUCGarantias.ascx" %>
<%@ Reference Control="~/controles/cuwplanGB.ascx" %>
<%@ Reference Control="~/controles/cuwaprlote.ascx" %>
<%@ Reference Control="~/controles/wfindcregb.ascx" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<%@ Register TagPrefix="uc1" TagName="HeadLargo" Src="controles/HeadLargo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="WUCGarantias" Src="controles/WUCGarantias.ascx" %>
<%@ Register TagPrefix="uc1" TagName="cuwplanGB" Src="controles/cuwplanGB.ascx" %>
<%@ Register TagPrefix="uc1" TagName="wfindcregb" Src="controles/wfindcregb.ascx" %>
<%@ Register TagPrefix="uc1" TagName="cuwaprlote" Src="controles/cuwaprlote.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Inherits="WbAprLote" CodeFile="WbAprLote.aspx.vb" %>
<%@ Register TagPrefix="uc1" TagName="MenuIzquierdo" Src="controles/MenuIzquierdo.ascx" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<%@ Register src="controles/WUCFindGru.ascx" tagname="WUCFindGru" tagprefix="uc2" %>
<%@ Register src="controles/WFindCreGB.ascx" tagname="WFindCreGB" tagprefix="uc3" %>
<%@ Register src="controles/cuwaprlote.ascx" tagname="cuwaprlote" tagprefix="uc4" %>
<%@ Register src="controles/CuwPlanGB.ascx" tagname="CuwPlanGB" tagprefix="uc5" %>
<%@ Register src="controles/CUWAprLote.ascx" tagname="CUWAprLote" tagprefix="uc6" %>
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
		    #Table3
            {
                width: 98%;
            }
            .style3
            {
                width: 160px;
            }
		.style9
    {
        width: 51%;
        height: 406px;
    }
    .style32
    {
        width: 615px;
    }
    .style10
    {
        width: 91%;
        height: 284px;
    }
    .style11
    {
        width: 72%;
        height: 30px;
    }
    .style12
    {
        width: 68px;
    }
    .style13
    {
        width: 81px;
    }
    .style14
    {
        width: 157px;
    }
    .style17
    {
        width: 94%;
    }
    .style18
    {
        width: 63px;
        height: 23px;
    }
    .style19
    {
        height: 23px;
    }
    .style20
    {
        width: 100%;
        height: 82px;
    }
    .style21
    {
        width: 156px;
    }
    .style38
    {
        width: 156px;
        height: 42px;
    }
    .style39
    {
        height: 42px;
    }
    .style22
    {
        width: 97%;
        height: 114px;
    }
    .style26
    {
        width: 120px;
    }
    .style24
    {
        width: 111px;
    }
    .style25
    {
        width: 141px;
    }
    .style27
    {
        width: 120px;
        height: 38px;
    }
    .style28
    {
        width: 111px;
        height: 38px;
    }
    .style29
    {
        width: 141px;
        height: 38px;
    }
    .style30
    {
        height: 38px;
    }
    .style31
    {
        height: 27px;
    }
    .style33
    {
        width: 94%;
        height: 63px;
    }
    .style35
    {
        width: 127px;
    }
    .style36
    {
        width: 118px;
    }
    .style37
    {
        width: 95px;
    }
    .style34
    {
        width: 139px;
    }
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
	<BODY background="imagenes/fondo.jpg">
		<P>
			<FORM id="Form1" method="post" runat="server">
				<TABLE id="Table2" style="border: thin solid background; Z-INDEX: 101; LEFT: 104px; WIDTH: 842px; POSITION: absolute; TOP: 16px; HEIGHT: 88px"
					cellSpacing="0" cellPadding="0" border="0">
					<TR>
						<TD align="center">
							<uc1:HeadLargo id="HeadLargo1" runat="server"></uc1:HeadLargo></TD>
					</TR>
					<TR>
						<TD align="center">
							<TABLE id="Table3" cellSpacing="0" cellPadding="0" border="0">
								<TR>
									<TD class="style3"></TD>
									<TD>
										<iewc:tabstrip id="TabStrip1" AutoPostBack="True" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											TabHoverStyle="background-color:#777777;" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											runat="server" Font-Names="Century Gothic" Font-Size="Larger">
											<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
											<iewc:Tab Text="Aprobación de Credito"></iewc:Tab>
											<iewc:Tab Text="Plan de Pagos"></iewc:Tab>
										</iewc:tabstrip></TD>
								</TR>
								<TR>
									<TD class="style3">
										<uc1:MenuIzquierdo id="MenuIzquierdo1" runat="server"></uc1:MenuIzquierdo></TD>
									<TD>
										<uc3:WFindCreGB ID="WFindCreGB1" runat="server" />
										<uc6:CUWAprLote ID="CUWAprLote1" runat="server" />
										<uc5:CuwPlanGB ID="CuwPlanGB1" runat="server" />
										</TD>
								</TR>
							</TABLE>
							<asp:Label id="Label1" runat="server" Font-Size="6pt" Font-Names="Verdana" ForeColor="MidnightBlue"
								Font-Bold="True" BackColor="Transparent">copyright@ 2006 FUNDAMICRO - El 
                            Salvador</asp:Label></TD>
					</TR>
				</TABLE>
				&nbsp;
			</FORM>
		</P>
	</BODY>
</HTML>
