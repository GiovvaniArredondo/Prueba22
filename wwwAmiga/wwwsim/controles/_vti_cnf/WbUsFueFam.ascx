vti_encoding:SR|utf8-nl
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="WbUsFueFam.ascx.vb" Inherits="wwwSIM.WbUsFueFam" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="584" border="0" style="BORDER-RIGHT:highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 584px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 603px; BACKGROUND-COLOR: #ffffff"
<TD style="COLOR:blue; FONT-FAMILY: 'Century Gothic'"><P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
<TD style="HEIGHT:24px">
<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="576" border="0" style="WIDTH:576px; HEIGHT: 120px">
<TD style="WIDTH:152px; BACKGROUND-COLOR: #ffffff"><asp:textbox id="TxtTIngr" BackColor="AliceBlue" runat="server" Width="104px" Enabled="False"
<asp:RangeValidator id="RangeValidator13" Width="120px" runat="server" Font-Names="Verdana" Font-Size="8pt"
</asp:datagrid></TD>
<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="576" border="0" style="WIDTH:576px; HEIGHT: 324px">
<TD style="FONT-SIZE:10pt; WIDTH: 150px; FONT-FAMILY: 'Century Gothic'; BACKGROUND-COLOR: #ffffff">
<P style="FONT-SIZE:8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
BorderWidth="1px"></asp:textbox></TD>
ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/1900" MaximumValue="01/01/3000">Fecha Inválida</asp:RangeValidator></TD>
ErrorMessage="La Fecha tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdFecha" Display="Dynamic" Font-Names="Verdana"></asp:regularexpressionvalidator></TD>
<P style="FONT-WEIGHT:bold; FONT-SIZE: 10pt; COLOR: navy; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
<TD style="BACKGROUND-COLOR:#ffffff"><asp:textbox id="TxtTEgr" BackColor="AliceBlue" runat="server" Width="104px" Enabled="False"
ControlToValidate="Txtviv" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
<TD style="FONT-WEIGHT:normal; FONT-SIZE: 8pt; WIDTH: 150px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 26px; BACKGROUND-COLOR: #ffffff">Educación</TD>
ControlToValidate="TxtAlim" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="txtIngrCony" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="TxtTel" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="Txtcuotas" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="TxtTrans" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="TxtRemesa" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="TxtEdu" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="TxtOtros" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="TxtSalud" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="TxtVest" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
ControlToValidate="txtPers" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0" MaximumValue="1000000000">Valor Inválido</asp:RangeValidator></TD>
AutoPostBack="True" Font-Names="Verdana" BorderWidth="1px"></asp:textbox></TD>
<P align="center" style="BACKGROUND-COLOR:#ffffff"><INPUT style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 68px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
type="button" id="btnNew" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnSave" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 68px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnCancela" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 68px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnelminar" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 68px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
vti_timelastmodified:TR|07 Jun 2007 19:33:35 -0000
vti_extenderversion:SR|4.0.2.8912
