<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wbcaja.aspx.vb" Inherits="wbcaja" %>

<%@ Register src="controles/cuwCaja.ascx" tagname="cuwCaja" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:cuwCaja ID="cuwCaja1" runat="server" />
</asp:Content>

