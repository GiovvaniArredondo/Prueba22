<%@ Page Title="Aprobación de Crédito" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbPreApruno.aspx.vb" Inherits="WbPreApruno" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc1" %>
<%@ Register src="controles/CUWPreAprInd.ascx" tagname="CUWPreAprInd" tagprefix="uc2" %>
<%@ Register src="controles/WUCGarantias.ascx" tagname="WUCGarantias" tagprefix="uc3" %>

<%@ Register src="controles/CuwCom.ascx" tagname="CuwCom" tagprefix="uc2" %>

<%@ Register src="controles/CuwPlan.ascx" tagname="CuwPlan" tagprefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" AutoPostBack="True" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
				TabHoverStyle="background-color:#777777;" TabSelectedStyle="background-color:#ffffff;color:#000000;"
				runat="server" Font-Names="Century Gothic" Font-Size="Larger">
				<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
				<iewc:Tab Text="Aprobación de Credito"></iewc:Tab>
				<iewc:Tab Text="Plan de Pagos"></iewc:Tab>
				<iewc:Tab Text="Garantías"></iewc:Tab>
				<iewc:Tab Text="Comisiones" />
				</iewc:tabstrip>

            </td>
        </tr>
        <tr>
            <td>
                <uc4:CuwPlan ID="CuwPlan1" runat="server" />
                <uc2:CuwCom ID="CuwCom1" runat="server" />
				<uc1:wucfindcligru ID="wucfindcligru2" runat="server" />
                <uc2:CUWPreAprInd ID="CUWPreAprInd1" runat="server" />
                <uc3:WUCGarantias ID="WUCGarantias2" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
