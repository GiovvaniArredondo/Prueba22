<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wbDepositoRemesa.aspx.vb" Inherits="wbDepositoRemesa" %>

<%@ Register src="controles/cuwDeposito.ascx" tagname="cuwDeposito" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:cuwDeposito ID="cuwDeposito1" runat="server" />
</asp:Content>

