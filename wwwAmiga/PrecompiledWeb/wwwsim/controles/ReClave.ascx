<%@ control language="vb" autoeventwireup="false" inherits="ReClave, App_Web_pi2jwlis" %>
<style type="text/css">
    .style1
    {
        width: 59%;
    }
    .style2
    {
        width: 94%;
        height: 179px;
    }
    .style3
    {
        width: 83%;
        height: 78px;
    }
    .style4
    {
        width: 260px;
    }
    .style5
    {
        width: 72%;
    }
</style>
<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td>
            <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style2">
                            <tr>
                                <td align="center" bgcolor="#3366CC">
                                    <asp:Label ID="Label1" runat="server" BackColor="#3366CC" Font-Names="Calibri" 
                                        ForeColor="White" Text="Cambiar la contraseña"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table align="center" cellpadding="0" cellspacing="0" class="style3">
                                        <tr>
                                            <td align="right" class="style4">
                                                <asp:Label ID="Label2" runat="server" Font-Names="Calibri" 
                                                    Text="Contraseña Actual:"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" 
                                                    Font-Names="Calibri" TextMode="Password" style="height: 21px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style4">
                                                <asp:Label ID="Label3" runat="server" Font-Names="Calibri" 
                                                    Text="Nueva Contraseña:"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox2" runat="server" Font-Names="Calibri" 
                                                    TextMode="Password"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style4">
                                                <asp:Label ID="Label4" runat="server" Font-Names="Calibri" 
                                                    Text="Confirmar Nueva Contraseña:"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox3" runat="server" Font-Names="Calibri" 
                                                    TextMode="Password"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Font-Names="Calibri" ForeColor="Red" 
                                        Text="Confirmar la nueva contraseña debe coincidir con la entrada Nueva contraseña."></asp:Label>
                                    <asp:literal id="FailureText" Runat="server" EnableViewState="False"></asp:literal>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table align="center" cellpadding="0" cellspacing="0" class="style5">
                                        <tr>
                                            <td>
                                                <asp:Button ID="Button1" runat="server" Font-Names="Calibri" 
                                                    Text="Cambiar Contraseña" />
                                            </td>
                                            <td>
                                                <asp:Button ID="Button2" runat="server" Font-Names="Calibri" Text="Cancelar" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
