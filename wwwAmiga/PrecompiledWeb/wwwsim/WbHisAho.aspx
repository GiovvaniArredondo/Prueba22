
<%@ page title="Historial de Ahorros" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbHisAho, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>




<%@ Register src="controles/Ahorros/rpt_historial_ahorros.ascx" tagname="rpt_historial_ahorros" tagprefix="uc1" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td>
                        <uc1:rpt_historial_ahorros ID="rpt_historial_ahorros1" runat="server" />
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>

