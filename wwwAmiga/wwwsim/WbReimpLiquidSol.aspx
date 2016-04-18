<%@ Page Title="Reimprime Liquidacion Grupal" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbReimpLiquidSol.aspx.vb" Inherits="WbReimpLiquidSol" %>
<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbDesembG.ascx" tagname="WbDesembG" tagprefix="uc3" %>
<%@ Register src="controles/WFindCreGB.ascx" tagname="WFindCreGB" tagprefix="uc4" %>
<%@ Register src="controles/WbFindbcReimpresion.ascx" tagname="WbFindbcReimpresion" tagprefix="uc5" %>


<%@ Register src="controles/CUWPreAprLote.ascx" tagname="CUWPreAprLote" tagprefix="uc1" %>


<%@ Register src="controles/ucReCompDesembolso.ascx" tagname="ucReCompDesembolso" tagprefix="uc2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
				<iewc:tabstrip id="TabStrip1" AutoPostBack="True" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
				TabHoverStyle="background-color:#777777;" TabSelectedStyle="background-color:#ffffff;color:#000000;"
				runat="server" Font-Names="Century Gothic" Font-Size="Larger">
				<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
				<iewc:Tab Text="Desembolso por Lotes"></iewc:Tab>
				<iewc:Tab Text="Re-impresion" />
				</iewc:tabstrip>
			</td>
                
        </tr>        
        <tr>
            <td>
				<uc4:WFindCreGB ID="WFindCreGB2" runat="server" />
				<uc2:ucReCompDesembolso ID="ucReCompDesembolso1" runat="server" />
            </td>
        </tr>        
    </table>
</asp:Content>






