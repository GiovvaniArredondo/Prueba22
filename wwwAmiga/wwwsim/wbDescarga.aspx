

<%@ Page Title="Pagos ATM" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wbDescarga.aspx.vb" Inherits="wbDescarga" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>


<%@ Register src="controles/ucDescarga.ascx" tagname="ucDescarga" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                                 
                <uc1:ucDescarga ID="ucDescarga1" runat="server" />
                                 
            </td>
        </tr>        
    </table>
</asp:Content>

