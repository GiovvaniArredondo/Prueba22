<%@ page title="" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbcontratosInd, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>
<%@ Register src="controles/WUsGarant.ascx" tagname="WUsGarant" tagprefix="uc1" %>
<%@ Register src="controles/WUsFindFia.ascx" tagname="WUsFindFia" tagprefix="uc1" %>

<%@ Register src="controles/Contratos/WbUContratos.ascx" tagname="WbUContratos" tagprefix="uc2" %>
<%@ Register src="controles/wucfindcligru.ascx" tagname="wucfindcligru" tagprefix="uc3" %>

<%@ Register src="controles/WbFindtodos.ascx" tagname="WbFindtodos" tagprefix="uc4" %>
<%@ Register src="controles/Contratos/WbUContratosG.ascx" tagname="WbUContratosG" tagprefix="uc5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD style="HEIGHT: 19px">
										<iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True" Height="29px">
											<iewc:Tab Text="Busqueda"></iewc:Tab>
											<iewc:Tab Text="Doc.   Legal"></iewc:Tab>
										</iewc:tabstrip>
                                        <uc3:wucfindcligru ID="wucfindcligru1" runat="server" />
                                        <uc2:WbUContratos ID="WbUContratos1" runat="server" />
                                    </TD>
								</TR>
								<TR>
									<TD>
                                        &nbsp;</TD>
								</TR>
							</TABLE>
</asp:Content>


