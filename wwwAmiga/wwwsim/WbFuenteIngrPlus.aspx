<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WbFuenteIngrPlus.aspx.vb" Inherits="WbFuenteIngrPlus" validaterequest="false" enableEventValidation="false" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>

<%@ Register src="controles/WbUsFueDep.ascx" tagname="WbUsFueDep" tagprefix="uc2" %>

<%@ Register src="controles/WbUsFueFam.ascx" tagname="WbUsFueFam" tagprefix="uc3" %>
<%@ Register src="controles/WbUsFueInd.ascx" tagname="WbUsFueInd" tagprefix="uc4" %>

<%@ Register src="controles/HeadLargo.ascx" tagname="HeadLargo" tagprefix="uc5" %>

<%@ Register src="controles/MenuIzquierdo.ascx" tagname="MenuIzquierdo" tagprefix="uc6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
	<HEAD runat="server">
		<title>Fuentes de Ingreso</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<style type="text/css">.menutitle {
	BORDER-RIGHT: #000000 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #000000 1px solid; PADDING-LEFT: 2px; FONT-WEIGHT: bold; MARGIN-BOTTOM: 5px; PADDING-BOTTOM: 2px; BORDER-LEFT: #000000 1px solid; WIDTH: 140px; CURSOR: pointer; COLOR: #000000; PADDING-TOP: 2px; BORDER-BOTTOM: #000000 1px solid; BACKGROUND-COLOR: #003264; TEXT-ALIGN: center
}
.submenu {
	MARGIN-BOTTOM: 0.5em
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
<body>
    <form id="form1" runat="server">
    <div>
    <table width="100%" cellpadding="0" cellspacing="0"> 
    <tr>
    <td>
        &nbsp;</td>
    <td>
        <uc5:HeadLargo ID="HeadLargo1" runat="server" />
    </td>
    </tr>
    <tr>
    <td valign=top  >
        <uc6:MenuIzquierdo ID="MenuIzquierdo1"  runat="server" />
    </td>
    <td>
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
            Height="781px" Width="914px">
                    <cc1:TabPanel runat="server" HeaderText="Buscar Clientes" ID="BuscarCli">
                        <ContentTemplate>
                            
                            <uc1:WbFind ID="WbFind1" runat="server"></uc1:WbFind>
                            
                        </ContentTemplate>
                        
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="Independiente" runat="server" HeaderText="Independiente">
                        <ContentTemplate>
                            
                            <uc4:WbUsFueInd ID="WbUsFueInd1" runat="server" >
                                
                            </uc4:WbUsFueInd>
                            
                        </ContentTemplate>
                        
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="Dependiente" runat="server" HeaderText="Dependiente">
                    <ContentTemplate>
                        
                        <uc2:WbUsFueDep ID="WbUsFueDep1" runat="server" >
                            
                        </uc2:WbUsFueDep>
                        
                    </ContentTemplate>
                        
                    </cc1:TabPanel>
                     <cc1:TabPanel ID="Familiar" runat="server" HeaderText="Familiar">
                     <ContentTemplate>
                         
                         <uc3:WbUsFueFam ID="WbUsFueFam1" runat="server" >
                             
                         </uc3:WbUsFueFam>
                         
                     </ContentTemplate>
                         
                    </cc1:TabPanel>
                </cc1:TabContainer>
       
        <br />
        .<br />
    </td>
    </tr>
    <tr><td>
        &nbsp;</td><td>
            &nbsp;</td></tr>
    </table>
    </div>
    </form>
</body>
</html>
