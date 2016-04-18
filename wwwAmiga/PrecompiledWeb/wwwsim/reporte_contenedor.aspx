<%@ page language="VB" autoeventwireup="false" inherits="reporte_contenedor, App_Web_4ra5sobm" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <CR:CrystalReportViewer ID="fondo_CrystalReportViewer1" runat="server" 
            AutoDataBind="true" DisplayGroupTree="False" 
            EnableDatabaseLogonPrompt="False" />
    
    </div>
    </form>
</body>
</html>
