vti_encoding:SR|utf8-nl
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="WbUCLientes.ascx.vb" Inherits="wwwSIM.WbUCLientes" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<P style="FONT-SIZE:11pt; FONT-FAMILY: 'Verdana'">
<TABLE id="Table1" style="BORDER-RIGHT:highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 593px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 504px; BACKGROUND-COLOR: #ffffff"
<P style="FONT-WEIGHT:normal; FONT-SIZE: 11pt; COLOR: lightcyan; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #006699"
<TD style="HEIGHT:53px">
<TABLE id="Table2" style="WIDTH:588px; HEIGHT: 112px" cellSpacing="0" cellPadding="0"
<TD style="FONT-WEIGHT:normal; FONT-SIZE: 8pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 22px">Profesión</TD>
<TD style="WIDTH:79px; HEIGHT: 22px"></TD>
Width="184px"></asp:dropdownlist></TD>
Width="208px" AutoPostBack="True"></asp:dropdownlist></TD>
<TD style="FONT-SIZE:11pt; HEIGHT: 20px; BACKGROUND-COLOR: maroon">
Width="200px"></asp:textbox></TD>
Width="112px" AutoPostBack="True" MaxLength="10"></asp:textbox><asp:textbox id="TxtEdad" Font-Names="Verdana" Font-Size="8pt" Enabled="False" runat="server"
Width="64px"></asp:textbox>
<asp:RangeValidator id="RangeValidator1" runat="server" Font-Size="8pt" Font-Names="Verdana" ErrorMessage="RangeValidator"
ControlToValidate="TxtDfecnaci" MinimumValue="01/01/1910" MaximumValue="01/01/3000" Type="Date">Fec.Nacimiento Inválida-</asp:RangeValidator></TD>
Width="96px" MaxLength="9"></asp:textbox></TD>
Width="128px" MaxLength="13"></asp:textbox></TD>
Width="208px"></asp:dropdownlist></TD>
Width="184px" AutoPostBack="True"></asp:dropdownlist></TD>
Width="88px" MaxLength="8"></asp:textbox></TD>
Width="208px" Height="56px" TextMode="MultiLine"></asp:textbox></TD>
Width="120px" AutoPostBack="True" MaxLength="10"></asp:textbox><asp:textbox id="TxtEdadCony" tabIndex="1" Font-Names="Verdana" Font-Size="8pt" Enabled="False"
runat="server" Width="60px"></asp:textbox></TD>
runat="server" Width="120px" MaxLength="9"></asp:textbox></TD>
Width="192px"></asp:dropdownlist></TD>
<P align="center">&nbsp;&nbsp;&nbsp;<INPUT id="btnNew" style="BACKGROUND-IMAGE:url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 53px; BACKGROUND-COLOR: transparent"
type="button" runat="server">&nbsp;&nbsp; &nbsp;&nbsp;<INPUT id="btnGrabar" style="BACKGROUND-IMAGE:url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 71px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 53px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp; &nbsp;&nbsp;&nbsp;<INPUT id="cmbedita" style="BACKGROUND-IMAGE:url(Web/jpgs/btn_editar_b.jpg); WIDTH: 65px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnCancela" style="BACKGROUND-IMAGE:url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 68px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
vti_timelastmodified:TR|29 Jun 2007 20:52:09 -0000
vti_extenderversion:SR|4.0.2.8912
