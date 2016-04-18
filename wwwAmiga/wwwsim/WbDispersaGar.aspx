<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbDispersaGar.aspx.vb" Inherits="WbDispersaGar" %>
<%@ Register src="controles/Creditos/WbUCDispersaGar.ascx" tagname="WbUCDispersaGar" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <uc2:WbUCDispersaGar ID="WbUCDispersaGar2" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

