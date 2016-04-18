<%@ page language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="FuenteIngresos, App_Web_epmxal5_" title="Fuente de Ingresos" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>
<%@ Register src="controles/WbUsFueDep.ascx" tagname="WbUsFueDep" tagprefix="uc2" %>
<%@ Register src="controles/WbUsFueFam.ascx" tagname="WbUsFueFam" tagprefix="uc3" %>


<%@ Register src="controles/WbUsFueInd.ascx" tagname="WbUsFueInd" tagprefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-family: verdana; font-size: 10px">
        <table cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td>
                    <iewc:tabstrip id="TabStrip1" runat="server" AutoPostBack="True" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											TabHoverStyle="background-color:#777777;" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											Font-Names="Century Gothic" Font-Size="Larger">
											<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
											<iewc:Tab Text="Independiente"></iewc:Tab>
											<iewc:Tab Text="Dependiente"></iewc:Tab>
											<iewc:Tab Text="Familiar"></iewc:Tab>
										</iewc:tabstrip>
                </td>
            </tr>
            <tr>
                <td>
                    <uc1:WbFind ID="WbFind1" runat="server" />
                    <uc4:WbUsFueInd ID="WbUsFueInd1" runat="server" />
                    <uc3:WbUsFueFam ID="WbUsFueFam1" runat="server" />
                    <uc2:WbUsFueDep ID="WbUsFueDep1" runat="server" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

