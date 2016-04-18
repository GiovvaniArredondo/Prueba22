

<%@ Page Title="Estado de Cuenta" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wbmovimientos.aspx.vb" Inherits="wbmovimientos" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>


<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc3" %>
<%@ Register src="controles/wbpagos.ascx" tagname="wbpagos" tagprefix="uc4" %>


<%@ Register src="controles/dgHistorialCreditos.ascx" tagname="dgHistorialCreditos" tagprefix="uc1" %>
<%@ Register src="controles/wbsaldo.ascx" tagname="wbsaldo" tagprefix="uc2" %>
<%@ Register src="controles/ucestadocta.ascx" tagname="ucestadocta" tagprefix="uc5" %>


<%@ Register src="controles/ucestadocta1.ascx" tagname="ucestadocta1" tagprefix="uc6" %>


<%@ Register src="controles/Creditos/WbUCFindCred.ascx" tagname="WbUCFindCred" tagprefix="uc7" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
				TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
				AutoPostBack="True">
				<iewc:Tab Text="Busqueda de Créditos"></iewc:Tab>
				<iewc:Tab Text="Consulta de Movimientos"></iewc:Tab>
				<iewc:Tab Text="Plan de Pagos"></iewc:Tab>
				<iewc:Tab Text="Saldo a una Fecha" />
				</iewc:tabstrip></TD>
            </td>
        </tr>
        <tr>
            <td>
                <uc6:ucestadocta1 ID="ucestadocta11" runat="server" />
                <uc7:WbUCFindCred ID="WbUCFindCred1" runat="server" />
                <uc1:dgHistorialCreditos ID="dgHistorialCreditos1" runat="server" />
                <uc2:wbsaldo ID="wbsaldo1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
