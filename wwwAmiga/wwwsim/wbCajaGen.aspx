<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wbCajaGen.aspx.vb" Inherits="wbCajaGen" %>
<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>
<%@ Register src="controles/WbUConyuge.ascx" tagname="WbUConyuge" tagprefix="uc3" %>

<%@ Register src="controles/cuwCajaGen.ascx" tagname="cuwCajaGen" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
										<uc2:cuwCajaGen ID="cuwCajaGen1" runat="server" />
										</td>
        </tr>
    </table>
</asp:Content>

