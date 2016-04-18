

<%@ Page Title="Apertura de Cuentas" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbAdCtas_Aho.aspx.vb" Inherits="WbAdCtas_Aho" %>

<%@ Register src="controles/Ahorros/WbUCtasAhorro.ascx" tagname="WbUCtasAhorro" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">     
     <ContentTemplate>
          <uc3:WbUCtasAhorro ID="WbUCtasAhorro1" runat="server" />
     </ContentTemplate>
</asp:Content>
