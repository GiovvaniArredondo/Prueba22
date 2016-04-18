<%@ Page Language="vb" AutoEventWireup="false" Inherits="mensajesPrueba" CodeFile="mensajesPrueba.aspx.vb" %>
<%@ Register TagPrefix="uc1" TagName="Encabezado" Src="controles/Encabezado.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucMensajePrueba" Src="controles/ucMensajePrueba.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>mensajesPrueba</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="Styles.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" cellSpacing="0"
				cellPadding="0" width="100%" border="0">
				<TR>
					<TD>
						<uc1:Encabezado id="Encabezado1" runat="server"></uc1:Encabezado></TD>
				</TR>
				<TR>
					<TD><IMG style="WIDTH: 16px; HEIGHT: 16px" height="16" src="imagenes/spacer.gif" width="16"></TD>
				</TR>
				<TR>
					<TD>
						<uc1:ucMensajePrueba id="UcMensajePrueba1" runat="server"></uc1:ucMensajePrueba></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
