
<%@ page title="Modulo de Informes Ahorros" language="VB" masterpagefile="~/MasterPage.master" autoeventwireup="false" inherits="WbRepAho, App_Web_epmxal5_" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register src="controles/Ahorros/rpt_captacion_aportaciones_creditos.ascx" tagname="rpt_captacion_aportaciones_creditos" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>  
                                <uc2:rpt_captacion_aportaciones_creditos ID="rpt_captacion_aportaciones_creditos1" runat="server" />                                
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>



</asp:Content>
