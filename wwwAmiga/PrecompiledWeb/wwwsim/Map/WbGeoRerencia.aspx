<%@ page language="VB" autoeventwireup="false" inherits="Map_WbGeoRerencia, App_Web_dmdcl1db" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register src="../controles/wucGeoReferencia.ascx" tagname="wucGeoReferencia" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <uc1:wucGeoReferencia ID="wucGeoReferencia1" runat="server" />
    
    </div>
    </form>
</body>
</html>
