<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ control language="vb" autoeventwireup="false" inherits="ucestadocta1, App_Web_v6ddqlgy" %>
<link type="text/css" href="web/css/style.css"/> 
<TABLE id="Table3" style="border: thin solid highlight; WIDTH: 564px; HEIGHT: 341px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" border="0">
	<asp:TextBox ID="txtlinea" runat="server" Enabled="False" Visible="False"></asp:TextBox>
	<TR>
        
		<TD align="center"><asp:label id="Label1" Font-Size="Medium" Width="248px" runat="server" Font-Names="Gill Sans MT"
				Font-Bold="True" ForeColor="Navy" Height="31px">ESTADO DE CUENTA</asp:label>
			<TABLE id="Table5" style="border-style: groove; WIDTH: 541px; HEIGHT: 220px; "
				borderColor="#000099" cellSpacing="0" borderColorDark="#006699" cellPadding="0"
				bgColor="#CCFF66" class="CSSTableGenerator">
				<TR>
					<TD style="WIDTH: 129px" align="right">&nbsp;</TD>
					<TD>&nbsp;</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 129px" align="right"><asp:label id="Label4" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Fecha Al:</asp:label></TD>
					<TD><asp:textbox id="TXTFECPRO" Font-Size="10pt" Width="116px" runat="server" Font-Names="Gill Sans MT"
							Font-Bold="True" BorderWidth="1px"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 129px; HEIGHT: 19px" align="right"><asp:label id="Label20" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Nombre:</asp:label></TD>
					<TD style="HEIGHT: 19px"><asp:textbox id="txtnomcli" Font-Size="10pt" Width="285px" 
                            runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" ForeColor="Black" Height="16px"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 129px" align="right"><asp:label id="Label30" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Agencia:</asp:label></TD>
					<TD><asp:textbox id="txtagencia" Font-Size="10pt" Width="286px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" ForeColor="Black"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 129px" align="right"><asp:label id="Label31" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Analista:</asp:label></TD>
					<TD><asp:textbox id="txtnomana" Font-Size="10pt" Width="285px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" ForeColor="Black"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 129px" align="right"><asp:label id="Label2" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Cuenta:</asp:label></TD>
					<TD><asp:textbox id="txtcodcta" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" ForeColor="Black"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 129px" align="right"><asp:label id="Label3" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Cliente:</asp:label></TD>
					<TD><asp:textbox id="txtcodcli" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT" BorderWidth="1px"
							Enabled="False" ForeColor="Black"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 129px" align="right"><asp:label id="Label6" Font-Size="10pt" runat="server" Font-Names="Gill Sans MT">Direcciòn:</asp:label></TD>
					<TD><asp:textbox id="txtdireccion" Font-Size="10pt" Width="372px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" ForeColor="Black" Height="21px"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 129px" align="right">
                        <asp:label id="Label32" Font-Size="10pt" 
                            runat="server" Font-Names="Gill Sans MT" Visible="False">Banco que Deposita:</asp:label></TD>
					<TD><asp:textbox id="txtbanco" Font-Size="10pt" Width="373px" runat="server" Font-Names="Gill Sans MT"
							BorderWidth="1px" Enabled="False" ForeColor="Black" Height="20px" Visible="False"></asp:textbox></TD>
				</TR>
			</TABLE>
			<asp:label id="label_mensaje" Font-Size="10pt" Width="384px" runat="server" Font-Names="Gill Sans MT"
				BackColor="White" Visible="False">Label</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="center">
            <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                Text="Aplicar" />
        </TD>
	</TR>
	<TR>
		<TD align="center"></TD>
	</TR>
</TABLE>
