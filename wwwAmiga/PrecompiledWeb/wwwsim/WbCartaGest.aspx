﻿<%@ page title="" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbCartaGest, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc2" %>

<%@ Register src="controles/ucgestion.ascx" tagname="ucgestion" tagprefix="uc4" %>

<%@ Register src="controles/ReportesGestion.ascx" tagname="ReportesGestion" tagprefix="uc3" %>


<%@ Register src="controles/Creditos/uchmora.ascx" tagname="uchmora" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <table cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td>
				    <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
				    TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
				    AutoPostBack="True">
				    <iewc:Tab Text="Busqueda de Créditos"></iewc:Tab>
				    <iewc:Tab Text="Cartas Gestion"></iewc:Tab>				    
				    </iewc:tabstrip>
			    </td>
                    
            </tr>        
            <tr>
                <td>
				    <uc1:uchmora ID="uchmora1" runat="server" />
				    <uc2:wucfindcligru ID="wucfindcligru1" runat="server" />
                </td>
            </tr>        
        </table>
    </asp:Content>




