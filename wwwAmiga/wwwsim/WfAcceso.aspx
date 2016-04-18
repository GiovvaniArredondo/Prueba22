<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WfAcceso.aspx.vb" Inherits="WfAcceso" %>

<%@ Register src="controles/WbUsBalance.ascx" tagname="WbUsBalance" tagprefix="uc1" %>

<%@ Register src="controles/Acceso.ascx" tagname="Acceso" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
    <style type="text/css">
        .style1
        {
            width: 33%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="0" cellspacing="0" class="style1" align="center">
            <tr>
                <td>
                    <uc2:Acceso ID="Acceso1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
