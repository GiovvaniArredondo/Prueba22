<%@ Page Title="Emsión de Carnet" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wbcolector.aspx.vb" Inherits="wbcolector" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru1" tagprefix="uc1" %>
<%@ Register src="controles/Uccolector.ascx" tagname="Uccolector1" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>

                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True">
											<iewc:Tab Text="Busqueda de Cr&#233;ditos"></iewc:Tab>
											<iewc:Tab Text="Emitir Carnet"></iewc:Tab>											
										</iewc:tabstrip>
            </td>
        </tr>
        <tr>
            <td>
                <uc1:wucfindcligru1 ID="wucfindcligru11" runat="server" />
                <uc2:Uccolector1 ID="Uccolector11" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>

