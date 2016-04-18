﻿<%@ Page Title="Entrega de Garantía" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbEntregaGar.aspx.vb" Inherits="WbEntregaGar" %>

<%@ Register src="controles/Creditos/WbUCEntreGar.ascx" tagname="WbUCEntreGar" tagprefix="uc1" %>



<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>


<%@ Register src="controles/wbUOtrosPagos.ascx" tagname="wbUOtrosPagos" tagprefix="uc2" %>


<%@ Register src="controles/Creditos/WbUCFindCred.ascx" tagname="WbUCFindCred" tagprefix="uc3" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>

                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
				TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
				AutoPostBack="True">
				<iewc:Tab Text="Busqueda de Créditos"></iewc:Tab>
				<iewc:Tab Text="Entrega Garantía"></iewc:Tab>
				<iewc:TabSeparator />
				</iewc:tabstrip>
                <uc3:WbUCFindCred ID="WbUCFindCred1" runat="server" />
                <uc1:WbUCEntreGar ID="WbUCEntreGar1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>



