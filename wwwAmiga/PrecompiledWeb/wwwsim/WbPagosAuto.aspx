<%@ page language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbPagosAuto, App_Web_epmxal5_" title="Página sin título" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register src="controles/Creditos/WbUCPagosAuto.ascx" tagname="WbUCPagosAuto" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <uc1:WbUCPagosAuto ID="WbUCPagosAuto1" runat="server" />
  
</asp:Content>

