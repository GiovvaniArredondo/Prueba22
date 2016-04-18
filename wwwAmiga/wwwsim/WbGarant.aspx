<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbGarant.aspx.vb" Inherits="WbGarant" %>
<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>
<%@ Register src="controles/WUsGarant.ascx" tagname="WUsGarant" tagprefix="uc1" %>
<%@ Register src="controles/WUsFindFia.ascx" tagname="WUsFindFia" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    
        <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" 
                                            Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True" Height="39px">
											<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
											<iewc:Tab Text="Garant&#237;as"></iewc:Tab>
											<iewc:Tab Text="Avales"></iewc:Tab>
										</iewc:tabstrip>
            </td>
        </tr>
        <tr>
            <td>
										<uc1:WUsGarant id="WUsGarant1" runat="server"></uc1:WUsGarant>
										<uc1:WbFind id="WbFind1" runat="server"></uc1:WbFind>
										<uc1:WUsFindFia id="WUsFindFia1" runat="server"></uc1:WUsFindFia>
            </td>
        </tr>
    </table>    
    
</asp:Content>

