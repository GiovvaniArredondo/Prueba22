<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ucmovimientos.ascx.vb" Inherits="wwwSIM.ucmovimientos" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 202px" align="right">
						<asp:label id="Label4" Height="15px" Font-Names="Verdana" Font-Size="X-Small" runat="server"
							Width="56px">Crédito:</asp:label></TD>
					<TD style="WIDTH: 111px" align="right">
						<asp:dropdownlist id="ddlcodins" runat="server" Font-Size="X-Small" Font-Names="Verdana"></asp:dropdownlist></TD>
					<TD style="WIDTH: 123px" align="right">
						<asp:dropdownlist id="ddlcodofi" runat="server" Font-Size="X-Small" Font-Names="Verdana"></asp:dropdownlist></TD>
					<TD style="WIDTH: 197px" align="right">
						<asp:textbox id="txtcnrocta" tabIndex="5" Font-Names="Verdana" Font-Size="X-Small" runat="server"
							Width="178px"></asp:textbox></TD>
					<TD><INPUT id="btnaplicar" style="BACKGROUND-POSITION-X: left; FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND-ATTACHMENT: fixed; BACKGROUND-IMAGE: url(imagenes/check.gif); WIDTH: 112px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 38px; BACKGROUND-COLOR: transparent"
							tabIndex="12" type="button" value="Aplicar" name="Button5" runat="server"></TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 309px" align="right">
						<asp:Label id="Label1" Width="103px" runat="server" Font-Size="X-Small" Font-Names="Verdana">Nombre:</asp:Label></TD>
					<TD>
						<asp:textbox id="txtnomcli" tabIndex="5" Width="336px" runat="server" Font-Size="XX-Small" Font-Names="Century Gothic"></asp:textbox></TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 309px" align="right">
						<asp:Label id="Label2" Width="144px" runat="server" Font-Size="X-Small" Font-Names="Verdana">Codigo Cliente:</asp:Label></TD>
					<TD>
						<asp:textbox id="txtcodcli" tabIndex="5" Width="152px" runat="server" Font-Size="XX-Small" Font-Names="Century Gothic"></asp:textbox></TD>
				</TR>
			</TABLE>
			<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 310px" align="right">
						<asp:Label id="Label3" Width="96px" runat="server" Font-Size="X-Small" Font-Names="Verdana">Fecha:</asp:Label></TD>
					<TD>
						<asp:textbox id="txtfecval" tabIndex="5" Width="104px" runat="server" Font-Size="XX-Small" Font-Names="Century Gothic"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:DataGrid id="datos" runat="server" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
				BackColor="White" CellPadding="3" Width="299px">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<EditItemStyle BorderStyle="Solid" BorderColor="Gold" BackColor="Gold"></EditItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid></TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 501px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnimprimir" style="FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND: url(imagenes/Wzprint.bmp) fixed no-repeat left center; WIDTH: 148px; COLOR: buttontext; FONT-FAMILY: 'Verdana'; HEIGHT: 36px"
							tabIndex="12" type="button" value="Imprimir" name="Button5" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</TD>
					<TD align="left"><INPUT id="Button5" style="FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND: url(imagenes/Wzclose.bmp) fixed no-repeat left center; WIDTH: 136px; COLOR: buttontext; FONT-FAMILY: 'Verdana'; HEIGHT: 36px"
							tabIndex="12" type="button" value="Salir" name="Button5" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
