<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wbCamAna.aspx.vb" Inherits="wbCamAna" title="Página sin título" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc1" %>
<%@ Register src="controles/cuwCamAna.ascx" tagname="cuwCamAna" tagprefix="uc2" %>
<%@ Register src="controles/cuwLoteAna.ascx" tagname="cuwLoteAna" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 37%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True">
											<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
											<iewc:Tab Text="Cambiar Analista"></iewc:Tab>
										    <iewc:Tab Text="Cambio por Lote" />
										</iewc:tabstrip>
            </td>
        </tr>
        <tr>
            <td>
                <uc2:cuwCamAna ID="cuwCamAna1" runat="server" />
                <uc3:cuwLoteAna ID="cuwLoteAna1" runat="server" />
                <uc1:wucfindcligru ID="wucfindcligru1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>

