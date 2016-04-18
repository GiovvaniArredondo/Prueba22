<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucestadoGru" CodeFile="ucestadoGru.ascx.vb" %>

<script language="javascript" type="text/javascript">
// <!CDATA[

   

// ]]>
</script>

<style type="text/css">
    .style1
    {
        width: 76px;
        height: 33px;
    }
    .style2
    {
        height: 33px;
    }
    .style3
    {
        width: 76px;
    }
    .style4
    {
        height: 19px;
        width: 76px;
    }
    .style5
    {
        width: 76px;
        height: 16px;
    }
    .style6
    {
        height: 16px;
    }
    .style7
    {
        width: 76px;
        height: 4px;
    }
    .style8
    {
        height: 4px;
    }
    .style9
    {
        width: 76px;
        height: 26px;
    }
    .style10
    {
        height: 26px;
    }
    .style11
    {
        width: 85%;
    }
    .style12
    {
        width: 180px;
    }
</style>
<TABLE id="Table3" style="border: thin solid highlight; WIDTH: 448px; HEIGHT: 197px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD align="center"><asp:label id="Label1" Font-Size="Medium" Width="270px" 
                runat="server" Font-Names="Verdana"
				Font-Bold="True" ForeColor="Navy" Height="31px"> Estado de Cuenta Grupal</asp:label>
			<TABLE id="Table5" style="border-style: groove; WIDTH: 415px; HEIGHT: 177px; "
				borderColor="#000099" cellSpacing="0" borderColorDark="#006699" cellPadding="0"
				bgColor="#ffff99">
				<TR>
					<TD align="right" class="style3"><asp:label id="Label4" Font-Size="8pt" runat="server" Font-Names="Verdana">Fecha Al:</asp:label></TD>
					<TD><asp:textbox id="TXTFECPRO" Font-Size="8pt" Width="116px" runat="server" Font-Names="Verdana"
							Font-Bold="True" BorderWidth="1px"></asp:textbox></TD>
				</TR>
				<TR>
					<TD align="right" class="style4"><asp:label id="Label20" Font-Size="8pt" runat="server" Font-Names="Verdana">Grupo</asp:label></TD>
					<TD style="HEIGHT: 19px"><asp:textbox id="txtnomcli" Font-Size="8pt" Width="208px" runat="server" Font-Names="Verdana"
							BorderWidth="1px" Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD align="right" class="style1"><asp:label id="Label3" Font-Size="8pt" runat="server" Font-Names="Verdana">Codigo:</asp:label></TD>
					<TD class="style2"><asp:textbox id="txtcodcli" Font-Size="8pt" runat="server" Font-Names="Verdana" BorderWidth="1px"
							Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD align="right" class="style9"><asp:label id="Label32" Font-Size="8pt" 
                            runat="server" Font-Names="Verdana">Fechas:</asp:label></TD>
					<TD class="style10">
                        <asp:DropDownList ID="cbxFechas" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="85px">
                        </asp:DropDownList>
                    </TD>
				</TR>
				<TR>
					<TD align="right" class="style5"></TD>
					<TD class="style6"></TD>
				</TR>
				<TR>
					<TD align="right" class="style7"><asp:label id="Label30" Font-Size="8pt" runat="server" Font-Names="Verdana">Agencia:</asp:label></TD>
					<TD class="style8"><asp:textbox id="txtagencia" Font-Size="8pt" Width="286px" runat="server" Font-Names="Verdana"
							BorderWidth="1px" Enabled="False"></asp:textbox></TD>
				</TR>
				<TR>
					<TD align="right" class="style3"><asp:label id="Label31" Font-Size="8pt" 
                            runat="server" Font-Names="Verdana" Visible="False">Analista:</asp:label></TD>
					<TD><asp:textbox id="txtnomana" Font-Size="8pt" Width="44px" runat="server" Font-Names="Verdana"
							BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox>
                        <asp:label id="Label5" Font-Size="8pt" runat="server" Font-Names="Verdana" 
                            Visible="False">Linea:</asp:label><asp:textbox id="txtlinea" 
                            Font-Size="8pt" Width="96px" runat="server" Font-Names="Verdana"
							BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox></TD>
				</TR>
				</TABLE>
			<asp:label id="label_mensaje" Font-Size="8pt" Width="384px" runat="server" Font-Names="Verdana"
				BackColor="White" Visible="False">Label</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="center">
            <table cellpadding="0" cellspacing="0" class="style11">
                <tr>
                    <td align="center" class="style12">
                        <asp:Button ID="btnaplica" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Aplicar" Width="109px" />
                    </td>
                    <td align="center">
                        <asp:Button ID="Button2" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Plan de Pagos" />
                        <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Plan de Pagos" Visible="False" />
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center"><asp:textbox id="txtcodcta" Font-Size="8pt" runat="server" 
                Font-Names="Verdana" BorderWidth="1px"
							Enabled="False" Height="20px" Visible="False" Width="16px"></asp:textbox>
            <asp:textbox id="txtdireccion" Font-Size="8pt" Width="21px" runat="server" Font-Names="Verdana"
							BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox>
            <asp:textbox id="txtninteres" Font-Size="8pt" Width="21px" runat="server" Font-Names="Verdana"
							BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox>
            <asp:textbox id="txtnintmora" Font-Size="8pt" Width="21px" runat="server" Font-Names="Verdana"
							BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox>
            <asp:textbox id="txtncapmora" Font-Size="8pt" Width="21px" runat="server" Font-Names="Verdana"
							BorderWidth="1px" Enabled="False" Height="16px" Visible="False"></asp:textbox></TD>
	</TR>
</TABLE>
