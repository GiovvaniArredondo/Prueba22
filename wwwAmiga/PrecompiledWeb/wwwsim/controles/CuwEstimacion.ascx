<%@ control language="VB" autoeventwireup="false" inherits="controles_CuwEstimacion, App_Web_yjxjq67i" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<style type="text/css">
    .style6
    {
        width: 52%;
        height: 91px;
    }
    .style7
    {
        width: 123px;
    }
</style>
<head id="Head1" runat="server" />
<table align="center" cellpadding="0" cellspacing="0" class="style6">
    <tr>
        <td>
                        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                        </asp:ToolkitScriptManager>
                    </td>
    </tr>
    <tr>
        <td>
            <table cellpadding="0" cellspacing="0" class="style6">
                <tr>
                    <td align="right" class="style7">
                        <asp:Label ID="Label1" runat="server" Font-Names="Calibri" Text="Fecha:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Font-Names="Calibri" Height="21px" 
                            Width="117px"></asp:TextBox>
                        <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="TextBox1">
                        </asp:CalendarExtender>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style7">
                        <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Text="Detallado" />
                    </td>
                    <td align="center">
                        <asp:Button ID="Button2" runat="server" Font-Names="Calibri" Text="Resumen" 
                            Height="24px" />
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Font-Names="Calibri" Text="Partidas" 
                            Height="24px" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

