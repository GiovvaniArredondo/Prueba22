<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wbReversionRemesa.aspx.vb" Inherits="wbReversionRemesa" title="Página sin título" %>

<%@ Register src="controles/cuwDepositoAnula.ascx" tagname="cuwDepositoAnula" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:cuwDepositoAnula ID="cuwDepositoAnula1" runat="server" />
</asp:Content>

