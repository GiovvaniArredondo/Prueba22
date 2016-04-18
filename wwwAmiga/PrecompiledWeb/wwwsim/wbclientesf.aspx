<%@ page title="" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="wbclientesf, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>
<%@ Register src="controles/WbUCLientes.ascx" tagname="WbUCLientes" tagprefix="uc2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" 
                                            Font-Names="Century Gothic" TabSelectedStyle="background-color:0066cc;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True" Height="33px" Width="303px" SelectedIndex="1">
											<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
											<iewc:Tab Text="Adici&#243;n de Clientes"></iewc:Tab>										    
										</iewc:tabstrip>
                <uc2:WbUCLientes ID="WbUCLientes1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <uc1:WbFind ID="WbFind1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>

