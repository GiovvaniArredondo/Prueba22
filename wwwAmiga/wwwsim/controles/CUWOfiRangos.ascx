<%@ Control Language="vb" AutoEventWireup="false" Codefile="CUWOfiRangos.ascx.vb" Inherits="CUWOfiRangos"  %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<style type="text/css">
    .style1
    {
        width: 98%;
        height: 43px;
    }
    .style2
    {
        height: 59px;
    }
    .style4
    {
        width: 238px;
    }
    .style5
    {
        width: 253px;
    }
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 523px; HEIGHT: 334px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD align="center"><asp:label id="Label3" ForeColor="#16387C" Font-Names="Verdana" 
                Height="15px" Font-Size="Medium"
				Font-Bold="True" Width="406px" runat="server">Asignación de Lotes por Agencia</asp:label></TD>
	</TR>
	<TR>
		<TD align="center">
            <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:Label ID="Label4" runat="server" Font-Names="Calibri" Text="Oficinas:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="cmboficinas" runat="server" Font-Names="Calibri" 
                            Height="20px" Width="248px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Text="Aplicar" />
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
            <table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                <tr>
                    <td align="right" class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td align="right" class="style5">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        <asp:Label ID="Label5" runat="server" Font-Names="Calibri" 
                            Text="Libreta Desde:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td align="right" class="style5">
                        <asp:Label ID="Label6" runat="server" Font-Names="Calibri" 
                            Text="Libreta Hasta:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style4">
                        <asp:Label ID="Label7" runat="server" Font-Names="Calibri" 
                            Text="Certificado Desde:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td align="right" class="style5">
                        <asp:Label ID="Label8" runat="server" Font-Names="Calibri" 
                            Text="Certificado Desde:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style2">
		</TD>
	</TR>
	<TR>
		<TD align="center">
			&nbsp;</TD>
	</TR>
</TABLE>
