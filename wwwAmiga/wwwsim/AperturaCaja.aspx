<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AperturaCaja.aspx.vb" Inherits="AperturaCaja" %>

<%@ Register src="controles/cuwApertura.ascx" tagname="cuwApertura" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:cuwApertura ID="cuwApertura1" runat="server" />
</asp:Content>

