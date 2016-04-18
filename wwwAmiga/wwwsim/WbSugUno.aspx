

<%@ Page Title="Sugerencia del Analista" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbSuguno.aspx.vb" Inherits="WbSuguno" %>



<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc1" %>
<%@ Register src="controles/WUsRefCli.ascx" tagname="WUsRefCli" tagprefix="uc2" %>
<%@ Register src="controles/CuwPlan.ascx" tagname="CuwPlan" tagprefix="uc3" %>
<%@ Register src="controles/CUWSuguno.ascx" tagname="CUWSuguno" tagprefix="uc4" %>
<%@ Register src="controles/WUCGarantias.ascx" tagname="WUCGarantias" tagprefix="uc5" %>
<%@ Register src="controles/cuwcom.ascx" tagname="cuwcom" tagprefix="uc6" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td>
                   <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
					TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
					AutoPostBack="True">
					<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
					<iewc:Tab Text="Sugerencia de Credito"></iewc:Tab>
					<iewc:Tab Text="Plan de Pagos"></iewc:Tab>
					<iewc:Tab Text="Garantías"></iewc:Tab>
					<iewc:Tab Text="Comisiones"></iewc:Tab>
					<iewc:Tab Text="Refinanciamiento"></iewc:Tab>
					</iewc:tabstrip>                                        
                 <TD>
                     &nbsp;</TD>

            </td>
        </tr>
        <tr>
            <td>
                   <uc1:wucfindcligru ID="wucfindcligru1" runat="server" />
                   <uc2:wusrefcli id="WUsRefCli1" runat="server"/>
                   <uc3:cuwplan id="CuwPlan1" runat="server" /> 
                   <uc4:cuwsuguno ID="CUWSuguno1" runat="server" />
                   <uc5:wucgarantias id="WUCGarantias1" runat="server"/>
                   <uc6:cuwcom id="CuwCom1" runat="server"/>                   
            </td>
        </tr>
    </table>
</asp:Content>

