<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Contenedor_Ahorros.aspx.vb" Inherits="Contenedor_Ahorros" %>

<%@ Register src="controles/Contenedor_Ahorros.ascx" tagname="Contenedor_Ahorros" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:Contenedor_Ahorros ID="Contenedor_Ahorros1" runat="server" />
    
    </div>
    </form>
</body>
</html>
