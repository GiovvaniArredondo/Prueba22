<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WbProvee.aspx.vb" Inherits="WbProvee" %>

<%@ Register src="controles/WCProveedor.ascx" tagname="WCProveedor" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:WCProveedor ID="WCProveedor1" runat="server" />
    
    </div>
    </form>
</body>
</html>
