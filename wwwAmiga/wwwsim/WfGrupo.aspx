<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Wfgrupo.aspx.vb" Inherits="Wfgrupo" %>
<%@ Register assembly="Microsoft.Web.UI.WebControls" namespace="Microsoft.Web.UI.WebControls" tagprefix="iewc" %>
<%@ Register src="controles/WbFind.ascx" tagname="WbFind" tagprefix="uc1" %>



<%@ Register src="controles/WbSolidario.ascx" tagname="WbSolidario" tagprefix="uc2" %>
<%@ Register src="controles/WbFindgr.ascx" tagname="WbFindgr" tagprefix="uc3" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TR>
									<TD class="style29">
                                        <iewc:tabstrip id="TabStrip1" runat="server" Font-Size="Larger" 
                                            Font-Names="Century Gothic" TabSelectedStyle="background-color:#ffffff;color:#000000;"
											TabHoverStyle="background-color:#777777;" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
											AutoPostBack="True" Width="326px" Height="39px">
											<iewc:Tab Text="Busqueda"></iewc:Tab>
											<iewc:Tab Text="ABC"></iewc:Tab>
										    <iewc:Tab DefaultStyle="" HoverStyle="" SelectedStyle="" Text="Clientes" />
										</iewc:tabstrip>                                       
                                    </TD>
								</TR>
								<TR>
									<TD>
									     <uc3:WbFindgr ID="WbFindgr1" runat="server" />
									     <uc2:WbSolidario ID="WbSolidario1" runat="server" />
                                         <uc1:WbFind ID="WbFind1" runat="server" />
																				
                                    </TD>
								</TR>
							</TABLE>
</asp:Content>