vti_encoding:SR|utf8-nl
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="WbUsFueInd.ascx.vb" Inherits="wwwSIM.WbUsFueInd" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="552" border="0" style="BORDER-RIGHT:highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 552px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 482px; BACKGROUND-COLOR: #ffffff"
<TD style="HEIGHT:17px"></TD>
<P style="FONT-WEIGHT:bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="480" border="0" style="WIDTH:480px; HEIGHT: 158px"
<TD style="WIDTH:200px"><asp:regularexpressionvalidator id="RegularExpressionValidator1" Font-Size="8pt" runat="server" ForeColor="#16387C"
<P align="center"><asp:datagrid id="Datagrid1" runat="server" Width="264px" Height="112px" BackColor="White" BorderColor="#006699"
<asp:RangeValidator id="RangeValidator6" Width="89px" runat="server" Font-Names="Verdana" Font-Size="8pt"
</asp:datagrid></P>
<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="552" border="0" style="WIDTH:552px; HEIGHT: 183px">
<TD style="FONT-SIZE:8pt; WIDTH: 104px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'">No 
MaxLength="40" Enabled="False" Font-Italic="True" BorderWidth="1px"></asp:textbox></TD>
<P style="FONT-SIZE:8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
Enabled="False"></asp:dropdownlist></TD>
MaxLength="12" Enabled="False" Font-Italic="True" BorderWidth="1px"></asp:textbox></TD>
MaxLength="10" Enabled="False" BorderWidth="1px"></asp:textbox>
ControlToValidate="txtdFecha" Type="Date" MinimumValue="01/01/1900" MaximumValue="01/01/3000">Fecha Inválida</asp:RangeValidator></TD>
Enabled="False" BorderWidth="1px"></asp:textbox></TD>
Font-Names="Verdana"></asp:regularexpressionvalidator></TD>
<TD><asp:textbox id="TxtNoEmp" Font-Size="8pt" Font-Names="Verdana" runat="server" MaxLength="3"
Height="56px" MaxLength="40" TextMode="MultiLine" Enabled="False" Font-Italic="True" BorderWidth="1px"></asp:textbox></TD>
<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="528" border="0" style="WIDTH:528px; HEIGHT: 19px">
Enabled="False" BorderWidth="1px" Width="76px"></asp:textbox>
ErrorMessage="RangeValidator" ControlToValidate="TxtNoEmp" Type="Integer" MinimumValue="0" MaximumValue="1000">Valor Inválido</asp:RangeValidator></TD>
<P align="center"><INPUT id="btnNew" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 60px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnsave" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 60px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btncancela" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 60px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnelminar" style="BACKGROUND-POSITION:center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 60px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
vti_timelastmodified:TR|02 Jul 2007 15:40:52 -0000
vti_extenderversion:SR|4.0.2.8912
