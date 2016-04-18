<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbUsuNivelApr.aspx.vb" Inherits="WbUsuNivelApr" %>



<%@ Register src="controles/Creditos/WbUCUsuNivelApr.ascx" tagname="WbUCUsuNivelApr" tagprefix="uc1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        
        <uc1:WbUCUsuNivelApr ID="WbUCUsuNivelApr1" runat="server" />
        
    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

