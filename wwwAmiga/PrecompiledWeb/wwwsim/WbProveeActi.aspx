<%@ page language="VB" autoeventwireup="false" inherits="WbProveeActi, App_Web_4ra5sobm" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register src="controles/WCProveedor.ascx" tagname="WCProveedor" tagprefix="uc1" %>

<%@ Register src="controles/WCProveedorAct.ascx" tagname="WCProveedorAct" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc2:WCProveedorAct ID="WCProveedorAct1" runat="server" />
    
    </div>
    </form>
</body>
</html>
