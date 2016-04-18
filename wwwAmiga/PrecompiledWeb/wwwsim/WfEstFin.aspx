<%@ page language="VB" autoeventwireup="false" inherits="WfEstFin, App_Web_4ra5sobm" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register src="controles/WbUsBalance.ascx" tagname="WbUsBalance" tagprefix="uc1" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbUsVentas.ascx" tagname="WbUsVentas" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página sin título</title>
    <style type="text/css">
        .style1
        {
            width: 29%;
        }
    

A:link	{	
	text-decoration:	none;
	color:	#3333cc;
	}	
		
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td>
										<iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True">
											<iewc:Tab Text="Estados Fin."></iewc:Tab>
											<iewc:Tab Text="Ventas" TabIndex="1"></iewc:Tab>
										</iewc:tabstrip>
                                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                                        </asp:ScriptManager>
                </td>
            </tr>
            <tr>
                <td>
                    <uc1:WbUsBalance ID="WbUsBalance1" runat="server" />
                    <uc2:WbUsVentas ID="WbUsVentas1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
