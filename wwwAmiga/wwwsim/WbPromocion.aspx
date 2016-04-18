<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbPromocion.aspx.vb" Inherits="WbPromocion" %>

<%@ Register src="controles/Creditos/WUCPromocion.ascx" tagname="WUCPromocion" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <uc1:WUCPromocion ID="WUCPromocion1" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

