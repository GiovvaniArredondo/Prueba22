
<%@ page title="Depositos a Cuenta" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="wbmovaho, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register src="controles/Cuwbusaho.ascx" tagname="Cuwbusaho" tagprefix="uc1" %>
<%@ Register src="controles/Ahorros/ucdepaho.ascx" tagname="ucdepaho" tagprefix="uc2" %>





<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td>                        
                                <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
                                    CssClass="NewsTab" Font-Names="Calibri" Font-Size="10pt" Width="800px">
                                    <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Busqueda de Socios">
                                        <ContentTemplate>                                            
                                            <uc1:Cuwbusaho ID="Cuwbusaho1" runat="server" />
                                        </ContentTemplate>
                                    </cc1:TabPanel>
                                    <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Depositos Cta.">
                                        <ContentTemplate>                                            
                                            <uc2:ucdepaho ID="ucdepaho1" runat="server" />
                                        </ContentTemplate>
                                    </cc1:TabPanel>                                    
                                </cc1:TabContainer>                           
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>



</asp:Content>

