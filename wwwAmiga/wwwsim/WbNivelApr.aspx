<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbNivelApr.aspx.vb" Inherits="WbNivelApr" %>

<%@ Register src="controles/Creditos/WbUCNivelApr.ascx" tagname="WbUCNivelApr" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <uc1:WbUCNivelApr ID="WbUCNivelApr1" runat="server" />
    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

