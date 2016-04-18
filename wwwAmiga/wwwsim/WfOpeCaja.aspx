<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WfOpeCaja.aspx.vb" Inherits="WfOpeCaja" %>

<%@ Register src="controles/cuwFaltante.ascx" tagname="cuwFaltante" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:cuwFaltante ID="cuwFaltante1" runat="server" />
</asp:Content>

