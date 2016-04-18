<%@ page title="" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbDispersador, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register src="controles/Creditos/WbUCArchivoDispersa.ascx" tagname="WbUCArchivoDispersa" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <uc1:WbUCArchivoDispersa ID="WbUCArchivoDispersa1" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

