<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ucprovisiones.ascx.vb" Inherits="wwwSIM.ucprovisiones" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD></TD>
	</TR>
	<TR>
		<TD align="center"><asp:label id="Label1" runat="server" Font-Bold="True" Font-Size="Medium">P R O V I S I O N E S</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 21px"></TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 373px" align="right"><asp:label id="Label2" runat="server" Width="216px">Provisión de Certificados a plazo:</asp:label></TD>
					<TD><INPUT id="btncertificados" style="BACKGROUND-POSITION-X: left; FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND-ATTACHMENT: fixed; BACKGROUND-IMAGE: url(imagenes/check2.gif); WIDTH: 45px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Century Gothic'; HEIGHT: 36px; BACKGROUND-COLOR: transparent"
							tabIndex="12" type="button" name="btnaplicar" runat="server"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 373px" align="right"><asp:label id="Label3" runat="server" Width="216px">Provisión de Aportaciones:</asp:label></TD>
					<TD><INPUT id="btnaportaciones" style="BACKGROUND-POSITION-X: left; FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND-ATTACHMENT: fixed; BACKGROUND-IMAGE: url(imagenes/check2.gif); WIDTH: 45px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Century Gothic'; HEIGHT: 36px; BACKGROUND-COLOR: transparent"
							tabIndex="12" type="button" name="Button5" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 2px" align="center"><INPUT id="btnsalir" style="BACKGROUND-POSITION-X: left; FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND-ATTACHMENT: fixed; BACKGROUND-IMAGE: url(imagenes/retorno.gif); WIDTH: 45px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Century Gothic'; HEIGHT: 36px; BACKGROUND-COLOR: transparent"
				tabIndex="12" type="button" name="Button5" runat="server"></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
