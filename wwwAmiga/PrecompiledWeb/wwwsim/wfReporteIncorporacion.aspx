<%@ page language="vb" autoeventwireup="false" inherits="wfReporteIncorporacion, App_Web_4ra5sobm" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Register TagPrefix="uc1" TagName="Encabezado" Src="controles/Encabezado.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wfReporteIncorporacion</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="FISDLStyles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table_Principal" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px"
				cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD width="5"></TD>
					<TD><uc1:encabezado id="Encabezado1" runat="server"></uc1:encabezado></TD>
					<TD width="5"></TD>
				</TR>
				<TR>
					<TD width="5"></TD>
					<TD vAlign="top" align="left"><IMG style="WIDTH: 8px; HEIGHT: 8px" height="8" src="imagenes/spacer.gif" width="8"></TD>
					<TD width="5"></TD>
				</TR>
				<TR>
					<TD width="5"></TD>
					<TD vAlign="top" align="left"><asp:label id="Label_Mensaje" runat="server" Width="640px" CssClass="NormalBold" ForeColor="Red"></asp:label></TD>
					<TD width="5"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
