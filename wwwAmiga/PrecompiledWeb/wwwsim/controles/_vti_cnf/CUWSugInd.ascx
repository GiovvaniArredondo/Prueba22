vti_encoding:SR|utf8-nl
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="CUWSugInd.ascx.vb" Inherits="wwwSIM.CUWSugInd" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" style="BORDER-RIGHT:highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 661px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 518px; BACKGROUND-COLOR: #ffffff"
<TD style="WIDTH:240px" align="center"><INPUT id="btnrechazar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
<TABLE id="Table2" style="WIDTH:624px; HEIGHT: 45px" cellSpacing="0" cellPadding="0" width="624"
<TD height="4"><asp:textbox id="txtcnrocta" runat="server" Font-Names="Century Gothic" Font-Size="8pt" BorderWidth="1px"
Enabled="False"></asp:textbox><asp:textbox id="txtCredito" runat="server" Width="192px" Font-Size="8pt" BorderWidth="1px" Enabled="False"
Visible="False"></asp:textbox></TD>
<TABLE id="Table3" style="WIDTH:624px; HEIGHT: 23px" cellSpacing="0" cellPadding="0" width="624"
BorderWidth="1px" Enabled="False"></asp:textbox></TD>
<TD><asp:label id="Label5" runat="server" Width="42px" Font-Names="Verdana" Font-Size="8pt">Dolares</asp:label></TD>
<TABLE id="Table4" style="WIDTH:648px; HEIGHT: 26px" cellSpacing="0" cellPadding="0" width="648"
BorderWidth="1px" Enabled="False" Height="19px"></asp:textbox></TD>
<TABLE id="Table5" style="WIDTH:656px; HEIGHT: 18px" cellSpacing="0" cellPadding="0" width="656"
<TD align="left" bgColor="background" colSpan="1" rowSpan="1"><asp:label id="Label6" runat="server" Width="128px" Font-Names="Verdana" Font-Size="Smaller"
BorderWidth="1px" BorderColor="LightSlateGray" BorderStyle="Solid" BackColor="Transparent" ForeColor="PowderBlue">Fuente de Ingreso</asp:label></TD>
<TABLE id="Table6" style="WIDTH:600px; HEIGHT: 23px" cellSpacing="0" cellPadding="0" width="600"
<TABLE id="Table7" style="WIDTH:656px; HEIGHT: 18px" cellSpacing="0" cellPadding="0" width="656"
<TD bgColor="background"><asp:label id="Label7" runat="server" Width="128px" Font-Names="Verdana" Font-Size="Smaller"
BorderWidth="1px" BorderColor="LightSlateGray" BorderStyle="Solid" BackColor="Transparent" ForeColor="PowderBlue">Datos Sugeridos</asp:label></TD>
<TABLE id="Table8" style="WIDTH:646px; HEIGHT: 22px" cellSpacing="0" cellPadding="0" width="646"
<TD align="left"><asp:dropdownlist id="cbxLineas" runat="server" Width="344px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
<TABLE id="Table10" style="WIDTH:648px; HEIGHT: 32px" cellSpacing="0" cellPadding="0"
BackColor="AliceBlue" Font-Bold="True">Tipo de Cuota</asp:label></TD>
<TD style="HEIGHT:12px" align="center"><asp:textbox id="txtnmeses" runat="server" Width="56px" Font-Names="Century Gothic" Font-Size="Smaller"
BorderWidth="1px"></asp:textbox></TD>
BorderWidth="1px" Height="22px"></asp:textbox></TD>
BorderWidth="1px" BackColor="White" GroupName="TipoPago" Text="Fija" Checked="True"></asp:radiobutton></TD>
BorderWidth="1px" BackColor="White" GroupName="TipoPago" Text="Creciente"></asp:radiobutton></TD>
BorderWidth="1px" BackColor="White" GroupName="TipoPago" Text="Libre Amort."></asp:radiobutton></TD>
<TABLE id="Table12" style="WIDTH:650px; HEIGHT: 293px" cellSpacing="0" cellPadding="0"
BackColor="AliceBlue" Font-Bold="True">Tipo de Periodo</asp:label></TD>
BorderWidth="1px" BackColor="White" GroupName="TipoPago" Text="Decreciente"></asp:radiobutton></TD>
BorderWidth="1px" BackColor="White" GroupName="TipoPago" Text="Flat"></asp:radiobutton></TD>
<TABLE id="Table14" style="WIDTH:648px; HEIGHT: 37px" cellSpacing="0" cellPadding="0"
BorderWidth="1px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Periodo Fijo"></asp:radiobutton></TD>
BorderWidth="1px" BorderColor="Navy" BackColor="White" GroupName="TipoPeriodo" Text="Fecha Fija" Checked="True"></asp:radiobutton></TD>
BorderWidth="1px" Enabled="False" Visible="False"></asp:textbox></TD>
<P><asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
ControlToValidate="txtFecDes" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" DESIGNTIMEDRAGDROP="1491">Fecha de Des.Inválida-</asp:rangevalidator><asp:rangevalidator id="RangeValidator1" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
ControlToValidate="txtmonSug" MaximumValue="1000000" MinimumValue="50" Type="Double">Monto Sugerido Inválido-</asp:rangevalidator><asp:rangevalidator id="RangeValidator2" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
ControlToValidate="pnCuoSug" MaximumValue="240" MinimumValue="1" Type="Integer">Cuotas Inválidas-</asp:rangevalidator><asp:rangevalidator id="RangeValidator3" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
ControlToValidate="pnDiaSug" MaximumValue="730" MinimumValue="1" Type="Integer">Plazo Inválido-</asp:rangevalidator><asp:rangevalidator id="RangeValidator4" runat="server" Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
ControlToValidate="pnPerGra" MaximumValue="12" MinimumValue="0" Type="Integer">Periodo de Gracia Inválido-</asp:rangevalidator>
<asp:textbox id="TxtDescuento" runat="server" Width="73px" Font-Names="Verdana" Font-Size="8pt"
<TABLE id="Table9" style="WIDTH:649px; HEIGHT: 141px" cellSpacing="0" cellPadding="0"
<TD style="FONT-WEIGHT:bold; FONT-SIZE: 10pt; COLOR: powderblue; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 17px; BACKGROUND-COLOR: background">Refinanciamiento:</TD>
<TD align="center" style="HEIGHT:114px"><asp:datagrid id="Datagrid1" runat="server" Width="452px" BorderWidth="1px" Height="112px" BorderColor="#006699"
</asp:datagrid></TD>
Enabled="False" Visible="False"></asp:textbox><asp:textbox id="TxtCapita" runat="server" Width="96px" Font-Names="Verdana" Font-Size="8pt"
<TABLE id="Table15" style="WIDTH:648px; HEIGHT: 64px" cellSpacing="0" cellPadding="0"
<P><INPUT id="btnAplicar" style="BACKGROUND-IMAGE:url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
<P><INPUT id="btnGrabar" style="BACKGROUND-IMAGE:url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 61px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
vti_timelastmodified:TR|16 Jul 2007 22:40:40 -0000
vti_extenderversion:SR|4.0.2.8912
