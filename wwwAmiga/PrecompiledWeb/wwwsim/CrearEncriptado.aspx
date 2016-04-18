<%@ page language="vb" autoeventwireup="false" inherits="CrearEncriptado, App_Web_4ra5sobm" enableEventValidation="false" maintainScrollPositionOnPostBack="true" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CrearEncriptado</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			Escriba Cadena a Encriptar:
			<asp:Button id="Button1" style="Z-INDEX: 101; LEFT: 230px; POSITION: absolute; TOP: 149px" runat="server"
				Text="Button" Width="88px" Height="22px"></asp:Button>
			<asp:TextBox id="clave" style="Z-INDEX: 102; LEFT: 64px; POSITION: absolute; TOP: 150px" runat="server"
				Width="148px" Height="22px"></asp:TextBox>
			<div id="encriptado" runat="server">Respuesta:
			</div>
		</form>
	</body>
</HTML>
