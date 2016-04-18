<%@ page title="Pagos Grupales" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="wbatmlotes, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>


<%@ Register src="controles/WbFindgr.ascx" tagname="WbFindgr" tagprefix="uc3" %>
<%@ Register src="controles/ucleerxmlote.ascx" tagname="ucleerxmlote1" tagprefix="uc4" %>


<%@ Register src="controles/WbFindtodos.ascx" tagname="WbFindtodos" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
               <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
				TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
				AutoPostBack="True" Width="160px">
			   <iewc:Tab Text="Busqueda"></iewc:Tab>
			   <iewc:Tab Text="Pago Grupal"></iewc:Tab>
			   </iewc:tabstrip>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WbFindtodos ID="WbFindtodos1" runat="server" />
                <uc4:ucleerxmlote1 ID="ucleerxmlote11" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>




