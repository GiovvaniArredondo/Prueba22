

<%@ Page Title="Reversión de Pagos Grupal" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Wbanulact.aspx.vb" Inherits="Wbanulact" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>


<%@ Register src="controles/wbanulapagosct.ascx" tagname="wbanulapagosct" tagprefix="uc2" %>
<%@ Register src="controles/WbFindtodos.ascx" tagname="WbFindtodos" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" 
                                            Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True" Height="33px" Width="303px">
											<iewc:Tab Text="Busqueda de Grupo"></iewc:Tab>
											<iewc:Tab Text="Reversion Pago Grupal"></iewc:Tab>										    
										</iewc:tabstrip>
            </td>
        </tr>
        <tr>
            <td>
                <uc3:WbFindtodos ID="WbFindtodos1" runat="server" />
                <uc2:wbanulapagosct ID="wbanulapagosct1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>



