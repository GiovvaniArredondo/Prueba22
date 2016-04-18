<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucIncentivos_Par" CodeFile="ucIncentivos_Par.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 44%;
        height: 168px;
    }
    .style3
    {
        width: 96%;
        height: 378px;
    }
    </style>
<P>
	&nbsp;</P>
<table border="1" cellpadding="0" cellspacing="0" class="style1" 
    style="border-color: #003366; height: 265px; width: 73%;">
    <tr>
        <td align="center">
            <table cellpadding="0" cellspacing="0" class="style3">
                <tr>
                    <td align="center" 
                        style="font-family: 'Gill Sans MT'; color: #003366; font-style: oblique; font-weight: bold;">
                        PARAMETROS
                        INCENTIVOS</td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="cmbtipo" runat="server" 
                Font-Names="Gill Sans MT" Font-Size="12pt" Height="27px" Width="276px" AutoPostBack="True">
                                    <asp:ListItem Value="1">Para Asesores</asp:ListItem>
                                    <asp:ListItem Value="2">Para Secretarias</asp:ListItem>
                                    <asp:ListItem Value="3">Para Supervisores Regionales</asp:ListItem>
                                    <asp:ListItem Value="4">Para Jefes de Agencia</asp:ListItem>
                                </asp:DropDownList>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="136px" Width="810px">
                                    <Columns>
                                        <asp:BoundField DataField="ccodigo">
                                            <ItemStyle Width="10px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="cdescri" HeaderText="Descripción">
                                            <ItemStyle Width="330px" />
                                        </asp:BoundField>
                                        <asp:TemplateField HeaderText="Factor">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("nnumtab") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" BackColor="Yellow" 
                                                    Font-Names="Gill Sans MT" Font-Size="12pt" Height="27px" 
                                                    Text='<%# DataBinder.Eval(Container, "DataItem.nnumtab") %>' Width="80px"></asp:TextBox>
                                                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                                    ControlToValidate="TextBox2" ErrorMessage="RangeValidator" Font-Names="Verdana" 
                                                    Font-Size="8pt" MaximumValue="1000000" MinimumValue="0" Type="Double" 
                                                    Width="149px">Factor Inválido</asp:RangeValidator>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="35px" />
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btnGrabar" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Height="33px" Text="Grabar" Width="86px" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

