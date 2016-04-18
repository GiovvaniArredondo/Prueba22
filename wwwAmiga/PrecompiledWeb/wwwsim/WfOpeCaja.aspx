<%@ page title="" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WfOpeCaja, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register src="controles/cuwFaltante.ascx" tagname="cuwFaltante" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:cuwFaltante ID="cuwFaltante1" runat="server" />
</asp:Content>

