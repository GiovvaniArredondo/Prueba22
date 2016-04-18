

<%@ page title="Reversión de Desembolsos" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbReversion, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>


<%@ Register src="controles/WUCFindCre.ascx" tagname="WUCFindCre1" tagprefix="uc1" %>
<%@ Register src="controles/WbUCReversion.ascx" tagname="WbUCReversion" tagprefix="uc2" %>

<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" 
                                            Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True" Height="33px" Width="303px">
											<iewc:Tab Text="Busqueda de Crédito"></iewc:Tab>
											<iewc:Tab Text="Reversion Desembolso"></iewc:Tab>										    
										</iewc:tabstrip>
            </td>
        </tr>
        <tr>
            <td>
                <uc3:wucfindcligru ID="wucfindcligru1" runat="server" />
				<uc2:WbUCReversion id="WbUCReversion1" runat="server">
				</uc2:WbUCReversion></TD>
            </td>
        </tr>
    </table>
</asp:Content>








