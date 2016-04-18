vti_encoding:SR|utf8-nl
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="WbUsBalance.ascx.vb" Inherits="wwwSIM.WbUsBalance" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="512" border="0" style="BORDER-RIGHT:highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 512px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 516px; BACKGROUND-COLOR: #ffffff">
<TD style="COLOR:blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 16px; BACKGROUND-COLOR: background"
<P style="FONT-WEIGHT:bold; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
<asp:RangeValidator id="RangeValidator24" Font-Size="8pt" Width="85px" runat="server" Font-Names="Verdana"
Font-Size="Smaller" BackColor="Transparent" BorderColor="Black">Estado de Resultados</asp:label></TD>
<TD style="HEIGHT:42px; BACKGROUND-COLOR: #ffffff"></TD>
<TD style="FONT-SIZE:8pt; WIDTH: 158px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 42px; BACKGROUND-COLOR: #ffffff">Otros 
de Balance:</TD>
<TD style="WIDTH:150px; HEIGHT: 42px; BACKGROUND-COLOR: #ffffff"></TD>
BorderWidth="1px" Font-Size="8pt"></asp:textbox>
ErrorMessage="La Fecha tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="TxtdFecha" Display="Dynamic" Font-Names="Verdana" Width="192px"></asp:regularexpressionvalidator></TD>
Width="78px" Font-Size="8pt"></asp:textbox></TD>
ErrorMessage="RangeValidator" MaximumValue="01/01/3000" MinimumValue="01/01/1900" Type="Date">Fecha Inválida</asp:RangeValidator></TD>
<TD style="BACKGROUND-COLOR:#ffffff"></TD>
Font-Size="8pt"></asp:textbox>
Type="Double" Height="8px">Valor Inválido</asp:RangeValidator></TD>
Type="Integer" Height="8px">Valor Inválido</asp:RangeValidator></TD>
Font-Names="Verdana" ForeColor="Black" BorderWidth="1px" Font-Size="8pt"></asp:textbox>
Font-Size="Smaller" BackColor="Transparent" BorderColor="Black">Balance Económico</asp:label></TD>
<INPUT style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 70px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 52px; BACKGROUND-COLOR: transparent"
type="button" id="btnnuevo" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btngrabar" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 70px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 52px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btncancela" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 66px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 52px; BACKGROUND-COLOR: transparent"
vti_timelastmodified:TR|02 Jul 2007 18:34:09 -0000
vti_extenderversion:SR|4.0.2.8912
