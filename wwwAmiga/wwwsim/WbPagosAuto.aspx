<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbPagosAuto.aspx.vb" Inherits="WbPagosAuto" title="Página sin título" %>

<%@ Register src="controles/Creditos/WbUCPagosAuto.ascx" tagname="WbUCPagosAuto" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <uc1:WbUCPagosAuto ID="WbUCPagosAuto1" runat="server" />
  
</asp:Content>

