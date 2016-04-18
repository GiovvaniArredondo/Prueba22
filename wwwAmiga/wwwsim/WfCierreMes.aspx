<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WfCierreMes.aspx.vb" Inherits="WfCierreMes" %>

<%@ Register src="controles/WbUCLientesCon.ascx" tagname="WbUCLientesCon" tagprefix="uc1" %>
<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>

<%@ Register src="controles/ucIncentivos.ascx" tagname="ucIncentivos" tagprefix="uc2" %>

<%@ Register src="controles/ucIncentivos_Par.ascx" tagname="ucIncentivos_Par" tagprefix="uc3" %>

<%@ Register src="controles/uccierreMen.ascx" tagname="uccierreMen" tagprefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <uc4:uccierreMen ID="uccierreMen1" runat="server" />
										</td>
        </tr>
    </table>
</asp:Content>

