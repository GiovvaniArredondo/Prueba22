<%@ page title="Inicio" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="_Default, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register src="controles/Cuwflash1.ascx" tagname="Cuwflash1" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <uc1:Cuwflash1 ID="Cuwflash11" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>

