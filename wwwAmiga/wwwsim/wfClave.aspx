<%@ Page Language="VB" AutoEventWireup="false" CodeFile="wfClave.aspx.vb" Inherits="wfClave" %>

<%@ Register src="controles/cuwClave.ascx" tagname="cuwClave" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
    <style type="text/css">
        .style1
        {
            width: 68%;
        }
    .style3
    {
        width: 83%;
        height: 3px;
    }
    .style15
    {
        width: 485px;
        height: 4px;
    }
    .style9
    {
        width: 100%;
        height: 4px;
    }
    .style10
    {
        width: 65%;
        height: 25px;
    }
    .style16
    {
        height: 25px;
    }
    .style12
    {
        width: 65%;
        height: 27px;
    }
    .style13
    {
        height: 27px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td>
                    <uc1:cuwClave ID="cuwClave1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
