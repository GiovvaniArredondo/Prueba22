
<%@ page title="" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbFuenteIngr, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>

<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>
<%@ Register src="controles/WbUsFueInd.ascx" tagname="WbUsFueInd" tagprefix="uc3" %>
<%@ Register src="controles/WbUsFueFam.ascx" tagname="WbUsFueFam" tagprefix="uc4" %>
<%@ Register src="controles/WbUsFueDep.ascx" tagname="WbUsFueDep" tagprefix="uc5" %>
<%@ Register src="controles/WbUsFueAgro.ascx" tagname="WbUsFueAgro" tagprefix="uc6" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD style="WIDTH: 166px">&nbsp;</TD>
									<TD>&nbsp;</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 166px"><iewc:tabstrip id="TabStrip1" runat="server" AutoPostBack="True" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											TabHoverStyle="background-color:#777777;" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											Font-Names="Century Gothic" Font-Size="Larger">
											<iewc:Tab Text="Busqueda de Clientes"></iewc:Tab>
											<iewc:Tab Text="Micro-Empresario"></iewc:Tab>
											<iewc:Tab Text="Asalariado"></iewc:Tab>
											<iewc:Tab Text="Familiar"></iewc:Tab>
										    <iewc:Tab Text="Agropecuaria" />
										</iewc:tabstrip></TD>
									<TD>&nbsp;</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 166px">									
                                        <uc1:wbfind id="WbFind1" runat="server"></uc1:wbfind>
                                        <uc3:WbUsFueInd ID="WbUsFueInd1" runat="server" />
                                        <uc5:WbUsFueDep ID="WbUsFueDep1" runat="server" />
                                        <uc6:WbUsFueAgro ID="WbUsFueAgro1" runat="server" />                                        
                                        <uc4:WbUsFueFam ID="WbUsFueFam1" runat="server" />
									</TD>
								</TR>
							</TABLE>
</asp:Content>
