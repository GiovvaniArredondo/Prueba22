<%@ page title="Impresion de Orden de Pago Referenciada" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbOrdePagoG, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc1" %>


<%@ Register src="controles/Creditos/WbUCPagoRefG.ascx" tagname="WbUCPagoRefG" tagprefix="uc2" %>


<%@ Register src="controles/WFindCreGB.ascx" tagname="WFindCreGB" tagprefix="uc3" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" AutoPostBack="True" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
				TabHoverStyle="background-color:#777777;" TabSelectedStyle="background-color:#ffffff;color:#000000;"
				runat="server" Font-Names="Century Gothic" Font-Size="Larger">
				<iewc:Tab Text="Busqueda de Grupo"></iewc:Tab>
				<iewc:Tab Text="Impresion Orden de Pago"></iewc:Tab>				
				</iewc:tabstrip>

            </td>
        </tr>
        <tr>
            <td>                
				<uc3:WFindCreGB ID="WFindCreGB1" runat="server" />
				<uc2:WbUCPagoRefG ID="WbUCPagoRefG1" runat="server" />
                
            </td>
        </tr>
    </table>
</asp:Content>

