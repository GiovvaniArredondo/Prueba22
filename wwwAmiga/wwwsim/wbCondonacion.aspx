


<%@ Page Title="Condonación de Intereses" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="wbCondonacion.aspx.vb" Inherits="wbCondonacion" %>
<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc2" %>
<%@ Register src="controles/wbCondonar.ascx" tagname="wbCondonar" tagprefix="uc3" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" 
                                            Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True" Height="33px" Width="303px">
											<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
											<iewc:Tab Text="Condonación"></iewc:Tab>										    
										</iewc:tabstrip>
                <uc3:wbCondonar ID="wbCondonar1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <uc2:wucfindcligru ID="wucfindcligru1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>


		