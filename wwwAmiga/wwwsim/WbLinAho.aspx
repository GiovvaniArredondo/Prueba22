<%@ Page Title="Lineas de Creditos" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="WbLinAho.aspx.vb" Inherits="WbLinAho" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register src="controles/Ahorros/WbUCfindlinAho.ascx" tagname="WbUCfindlinAho" tagprefix="uc1" %>
<%@ Register src="controles/Ahorros/lineas_ahorro.ascx" tagname="lineas_ahorro" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">    

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
                CssClass="NewsTab" Font-Names="Calibri" Font-Size="10pt" Width="800px">
                <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Busqueda de Linea"><ContentTemplate><uc1:WbUCfindlinAho ID="WbUCfindlinAho1" runat="server" ></uc1:WbUCfindlinAho></ContentTemplate></cc1:TabPanel>                
                <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Linea de Ahorro"><ContentTemplate><uc2:lineas_ahorro ID="lineas_ahorro1" runat="server" /></ContentTemplate></cc1:TabPanel>                
            </cc1:TabContainer>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>


