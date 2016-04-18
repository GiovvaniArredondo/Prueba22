<%@ Page Title="Desembolso de Crédito" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbDesembolso.aspx.vb" Inherits="WbDesembolso" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>

<%@ Register TagPrefix="uc1" TagName="WUsRefCli" Src="controles/WUsRefCli.ascx" %>
<%@ Register TagPrefix="uc1" TagName="WbDesemb" Src="controles/WbDesemb.ascx" %>
<%@ Register TagPrefix="uc1" TagName="WUCFindCre" Src="controles/WUCFindCre.ascx" %>



<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc2" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" AutoPostBack="True" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											TabHoverStyle="background-color:#777777;" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											runat="server" Font-Names="Century Gothic" Font-Size="Larger">
											<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
											<iewc:Tab Text="Desembolso de Credito"></iewc:Tab>
											<iewc:Tab Text="Refinanciamiento"></iewc:Tab>
										</iewc:tabstrip>

            </td>
        </tr>
        <tr>
            <td>
                <uc1:WUsRefCli ID="WUsRefCli1" runat="server" />
                <uc2:wucfindcligru ID="wucfindcligru1" runat="server" />
                <uc1:WbDesemb ID="WbDesemb1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>



										
