<%@ page language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="wbReversionRemesa, App_Web_epmxal5_" title="Página sin título" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register src="controles/cuwDepositoAnula.ascx" tagname="cuwDepositoAnula" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:cuwDepositoAnula ID="cuwDepositoAnula1" runat="server" />
</asp:Content>

