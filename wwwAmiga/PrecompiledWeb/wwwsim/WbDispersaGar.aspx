<%@ page title="" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbDispersaGar, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<%@ Register src="controles/Creditos/WbUCDispersaGar.ascx" tagname="WbUCDispersaGar" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <uc2:WbUCDispersaGar ID="WbUCDispersaGar2" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

