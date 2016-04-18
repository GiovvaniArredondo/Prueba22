
<%@ page title="Retiro Cuenta" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="wbretaho, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register src="controles/Cuwbusaho.ascx" tagname="Cuwbusaho" tagprefix="uc1" %>







<%@ Register src="controles/Ahorros/ucretiroaho.ascx" tagname="ucretiroaho" tagprefix="uc2" %>







<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                                    CssClass="NewsTab" Font-Names="Calibri" Font-Size="10pt" Width="800px">
                                    <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Busqueda de Socios">
                                        <ContentTemplate>                                            
                                            <uc1:Cuwbusaho ID="Cuwbusaho1" runat="server" />
                                        </ContentTemplate>
                                    </cc1:TabPanel>
                                    <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Retiro Cta.">
                                        <ContentTemplate>
                                            <uc2:ucretiroaho ID="ucretiroaho1" runat="server" />
                                        </ContentTemplate>
                                    </cc1:TabPanel>                                    
                                </cc1:TabContainer>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>



</asp:Content>

