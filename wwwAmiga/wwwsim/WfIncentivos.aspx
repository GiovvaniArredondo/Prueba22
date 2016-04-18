<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WfIncentivos.aspx.vb" Inherits="WfIncentivos" %>

<%@ Register src="controles/WbUCLientesCon.ascx" tagname="WbUCLientesCon" tagprefix="uc1" %>
<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>

<%@ Register src="controles/ucIncentivos.ascx" tagname="ucIncentivos" tagprefix="uc2" %>

<%@ Register src="controles/ucIncentivos_Par.ascx" tagname="ucIncentivos_Par" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True" Width="160px">
											<iewc:Tab Text="Incentivos"></iewc:Tab>
											<iewc:Tab Text="Parametros"></iewc:Tab>
										</iewc:tabstrip>
                <uc3:ucIncentivos_Par ID="ucIncentivos_Par1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <uc2:ucIncentivos ID="ucIncentivos1" runat="server" />
										</td>
        </tr>
    </table>
</asp:Content>

