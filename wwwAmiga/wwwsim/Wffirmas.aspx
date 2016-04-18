<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Wffirmas.aspx.vb" Inherits="Wffirmas" %>

<%@ Register src="controles/WbUsBalance.ascx" tagname="WbUsBalance" tagprefix="uc1" %>

<%@ Register src="controles/CuwFotoFirma.ascx" tagname="CuwFotoFirma" tagprefix="uc2" %>

<%@ Register src="controles/CuwFirmas.ascx" tagname="CuwFirmas" tagprefix="uc3" %>

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
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <uc3:CuwFirmas ID="CuwFirmas1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
