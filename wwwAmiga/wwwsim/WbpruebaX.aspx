<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbpruebaX.aspx.vb" Inherits="WbpruebaX" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%@ Register src="controles/WUCFindCrex.ascx" tagname="WUCFindCrex" tagprefix="uc1" %>
<%@ Register src="controles/WUCFindCre.ascx" tagname="WUCFindCre" tagprefix="uc2" %>
<%@ Register src="controles/Creditos/WbUCFindCred.ascx" tagname="WbUCFindCred" tagprefix="uc3" %>
<%@ Register src="controles/Creditos/wubPruebax.ascx" tagname="wubPruebax" tagprefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
                Width="969px" CssClass="NewsTab" Font-Names="Calibri" Font-Size="10pt">
                <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Busqueda de Creditos">                                        
                    <ContentTemplate>
                        <uc3:WbUCFindCred ID="WbUCFindCred1" runat="server" />
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Prueba X">                                       
                    <ContentTemplate>
                        <uc4:wubPruebax ID="wubPruebax1" runat="server" />
                    </ContentTemplate>
                </cc1:TabPanel>                
            </cc1:TabContainer>
        </ContentTemplate>
    
    </asp:UpdatePanel>


</asp:Content>


