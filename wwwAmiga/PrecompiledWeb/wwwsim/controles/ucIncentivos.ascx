<%@ control language="vb" autoeventwireup="false" inherits="ucIncentivos, App_Web_mb_xwoah" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


<style type="text/css">

    .style1
    {
        width: 44%;
        height: 168px;
    }
    .style3
    {
        width: 84%;
    }
    </style>
<p>
    &nbsp;</p>
<table border="1" cellpadding="0" cellspacing="0" class="style1" 
    style="border-color: #003366; height: 265px; width: 53%;">
    <tr>
        <td align="center">
            <table cellpadding="0" cellspacing="0" class="style3">
                <tr>
                    <td align="center" 
                        style="font-family: 'Gill Sans MT'; color: #003366; font-style: oblique; font-weight: bold;">
                        INCENTIVOS</td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <table cellpadding="0" cellspacing="0" class="style2">
                                    <tr>
                                        <td align="right" class="style4">
                                            <asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="12pt" Text="Mes:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="cmbmes" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="12pt" Height="27px" Width="276px">
                                                <asp:ListItem Value="1">Enero</asp:ListItem>
                                                <asp:ListItem Value="2">Febrero</asp:ListItem>
                                                <asp:ListItem Value="3">Marzo</asp:ListItem>
                                                <asp:ListItem Value="4">Abril</asp:ListItem>
                                                <asp:ListItem Value="5">Mayo</asp:ListItem>
                                                <asp:ListItem Value="6">Junio</asp:ListItem>
                                                <asp:ListItem Value="7">Julio</asp:ListItem>
                                                <asp:ListItem Value="8">Agosto</asp:ListItem>
                                                <asp:ListItem Value="9">Septiembre</asp:ListItem>
                                                <asp:ListItem Value="10">Octubre</asp:ListItem>
                                                <asp:ListItem Value="11">Noviembre</asp:ListItem>
                                                <asp:ListItem Value="12">Diciembre</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style4">
                                            <asp:Label ID="Label4" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="12pt" Text="Año:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtanual" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" Height="28px" style="vertical-align:top" tabIndex="17" 
                                                Width="89px"></asp:TextBox>
                                            <cc1:NumericUpDownExtender ID="txtanual_NumericUpDownExtender" runat="server" 
                                                Enabled="True" Maximum="2099" Minimum="2000" RefValues="" ServiceDownMethod="" 
                                                ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                TargetButtonUpID="" TargetControlID="txtanual" Width="60">
                                            </cc1:NumericUpDownExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style4">
                                            &nbsp;</td>
                                        <td>
                                            <asp:DropDownList ID="cmbtipo" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="12pt" Height="27px" Width="276px">
                                                <asp:ListItem Value="1">Para Asesores</asp:ListItem>
                                                <asp:ListItem Value="2">Para Secretarias</asp:ListItem>
                                                <asp:ListItem Value="3">Para Supervisores Regionales</asp:ListItem>
                                                <asp:ListItem Value="4">Para Jefes de Agencia</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style4">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <table cellpadding="0" cellspacing="0" class="style3">
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="Label1" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="12pt" Text="Desde:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtdesde" runat="server" Font-Names="Gill Sans MT"></asp:TextBox>
                                            <cc1:MaskedEditExtender ID="txtdesde_MaskedEditExtender" runat="server" 
                                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                Mask="99/99/9999" MaskType="Date" TargetControlID="txtdesde">
                                            </cc1:MaskedEditExtender>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="Label2" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="12pt" Text="Hasta:"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txthasta" runat="server" Font-Names="Gill Sans MT"></asp:TextBox>
                                            <cc1:MaskedEditExtender ID="txthasta_MaskedEditExtender" runat="server" 
                                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                Mask="99/99/9999" MaskType="Date" TargetControlID="txthasta">
                                            </cc1:MaskedEditExtender>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btnimprimir" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Height="33px" Text="Imprimir" Width="86px" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
