<%@ Control Language="VB" AutoEventWireup="false" CodeFile="wucUploadExp.ascx.vb" Inherits="controles_wucUploadExp" %>

<style type="text/css">
    .style1
    {
        height: 52px;
    }
    .style2
    {
        height: 196px;
    }
</style>


    <ContentTemplate>
        <table id="Table1" cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr><td align="center" style="height:18px"></td></tr>
            <tr><td align="center" style="height:18px">
                <table ID="Table8" border="0" cellpadding="0" cellspacing="0" 
                    style="border:highlight thin solid;" width="400">
                    <tr>
                        <td align="center" style="height:34px">
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Verdana" 
                                Font-Size="Medium" ForeColor="#16387C">Carga de Expediente</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" style="height:38px">
                            <asp:TextBox ID="txtccodcli" runat="server" Visible="False" Width="21px"></asp:TextBox>
                            <asp:TextBox ID="txtcnomcli" runat="server" BorderWidth="2px" 
                                Font-Names="Garamond" ForeColor="Maroon" ReadOnly="True" Width="338px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" 
                            style="height:38px; vertical-align:bottom; margin-left: 40px;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center" style="height:30px;">
                            <asp:Label ID="LblStatus" runat="server" Font-Bold="True" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style1" 
                            style="padding-top:10px; padding-bottom:20px;">
                            <asp:FileUpload ID="FlUpExped" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style1" 
                            style="padding-top:10px; padding-bottom:20px;">
                                                                <asp:Label ID="lblUsuario110" Runat="server" Font-Bold="True" 
                                                                    Font-Names="Calibri" 
                Font-Size="10pt" ForeColor="#FF3300" 
                                                                    
                style="text-align: right" Width="400px">Aviso: No se pueden subir Archivos que exceden 5MB</asp:Label>
                        </td>
                    </tr>
                </table>
                </td></tr>
            <tr>
                <td align="center" style="height:18px">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:Button ID="btnGen" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                Font-Size="11pt" Text="Cargar" Width="100px" />
                        </ContentTemplate>
                            <Triggers><asp:PostBackTrigger ControlID="btnGen" /></Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    

