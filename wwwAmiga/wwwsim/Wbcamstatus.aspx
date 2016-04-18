<%@ Page Title="Cambio de Status" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Wbcamstatus.aspx.vb" Inherits="Wbcamstatus" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>

<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc3" %>

<%@ Register src="controles/Creditos/WbUCamstatus.ascx" tagname="WbUCamstatus" tagprefix="uc4" %>
<%@ Register src="controles/Creditos/WbUCFindCred.ascx" tagname="WbUCFindCred" tagprefix="uc5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" 
                                            Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True" Height="33px" Width="303px">
											<iewc:Tab Text="Busqueda de Crédito"></iewc:Tab>
											<iewc:Tab Text="Cambiar Status"></iewc:Tab>										    
										</iewc:tabstrip>
            </td>
        </tr>
        <tr>
            <td>
                <uc5:WbUCFindCred ID="WbUCFindCred1" runat="server" />
                <uc4:WbUCamstatus ID="WbUCamstatus1" runat="server" />
				</TD>
            </td>
        </tr>
    </table>
</asp:Content>




