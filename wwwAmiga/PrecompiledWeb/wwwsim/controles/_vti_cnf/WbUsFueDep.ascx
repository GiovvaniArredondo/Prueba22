vti_encoding:SR|utf8-nl
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="WbUsFueDep.ascx.vb" Inherits="wwwSIM.WbUsFueDep" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="600" border="0" style="BORDER-RIGHT:highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 600px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 538px; BACKGROUND-COLOR: #ffffff"
<TD style="HEIGHT:48px">
<P style="FONT-WEIGHT:bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="483" border="0" style="WIDTH:483px; HEIGHT: 162px"
<TD style="WIDTH:97px"></TD>
<P align="center"><asp:datagrid id="Datagrid1" BorderColor="#006699" BorderStyle="None" BorderWidth="1px" CellPadding="3"
<asp:RangeValidator id="RangeValidator3" Width="88px" runat="server" Font-Size="8pt" Font-Names="Verdana"
</asp:datagrid></P>
<TD align="left" style="WIDTH:219px">
<P align="right"><asp:textbox id="txtComodin" runat="server" Visible="False" Width="99px"></asp:textbox></P>
<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="592" border="0" style="WIDTH:592px; HEIGHT: 259px">
<TD style="FONT-WEIGHT:normal; FONT-SIZE: 8pt; WIDTH: 112px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 23px">Razon 
BorderWidth="1px" Width="144px"></asp:textbox></TD>
<TD style="FONT-SIZE:8pt; WIDTH: 112px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'">Sueldo</TD>
Font-Size="8pt"></asp:dropdownlist></TD>
Font-Size="X-Small" BorderWidth="1px"></asp:textbox></TD>
<TD><asp:textbox id="TxtTel" Enabled="False" runat="server" Width="96px" Font-Names="Verdana" Font-Size="8pt"
Font-Size="8pt" TextMode="MultiLine" MaxLength="40" BorderWidth="1px"></asp:textbox></TD>
MaxLength="3" BorderWidth="1px"></asp:textbox>
Type="Integer">Valor Inválido</asp:RangeValidator></TD>
MaxLength="8" BorderWidth="1px"></asp:textbox></TD>
Font-Size="8pt" BorderWidth="1px"></asp:textbox>
MaxLength="4" BorderWidth="1px"></asp:textbox>
ErrorMessage="RangeValidator" MaximumValue="01/01/3000" MinimumValue="01/01/1900" Type="Date">Fecha Inválida</asp:RangeValidator></TD>
ErrorMessage="La Fecha tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="TxtdFecha" Display="Dynamic" Font-Names="Verdana"></asp:regularexpressionvalidator></TD>
Font-Names="Verdana" Font-Size="8pt" BorderWidth="1px"></asp:textbox>
Type="Double">Valor Inválido</asp:RangeValidator></TD>
<P align="center"><INPUT style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 58px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 52px; BACKGROUND-COLOR: transparent"
type="button" id="btnNew" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnSave" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 58px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 52px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnCancela" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 58px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 52px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnelminar" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 58px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 52px; BACKGROUND-COLOR: transparent"
vti_timelastmodified:TR|21 Jun 2007 16:39:18 -0000
vti_extenderversion:SR|4.0.2.8912
