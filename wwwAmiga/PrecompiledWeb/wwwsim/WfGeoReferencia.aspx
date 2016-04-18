<%@ page language="VB" autoeventwireup="false" inherits="WfGeoReferencia, App_Web_4ra5sobm" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<%@ Register src="controles/wucGeoReferencia.ascx" tagname="wucGeoReferencia" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
    <style type="text/css">
        .style1
        {
            width: 29%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td>
                    <uc2:wucGeoReferencia ID="wucGeoReferencia1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
