<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbDispersador.aspx.vb" Inherits="WbDispersador" %>

<%@ Register src="controles/Creditos/WbUCArchivoDispersa.ascx" tagname="WbUCArchivoDispersa" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <uc1:WbUCArchivoDispersa ID="WbUCArchivoDispersa1" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

