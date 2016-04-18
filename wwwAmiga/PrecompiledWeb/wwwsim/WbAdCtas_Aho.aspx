

<%@ page title="Apertura de Cuentas" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbAdCtas_Aho, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register src="controles/Ahorros/WbUCtasAhorro.ascx" tagname="WbUCtasAhorro" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">     
     <ContentTemplate>
          <uc3:WbUCtasAhorro ID="WbUCtasAhorro1" runat="server" />
     </ContentTemplate>
</asp:Content>
