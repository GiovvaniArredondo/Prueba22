<%@ control language="vb" autoeventwireup="false" inherits="Reportes, App_Web_pi2jwlis" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<TABLE id="Table1" style="WIDTH: 472px; HEIGHT: 184px" cellSpacing="0" cellPadding="0"
	width="472" align="center" border="0">
	<TR>
		<TD style="HEIGHT: 80px" align="center"><CR:CRYSTALREPORTVIEWER id="crvContenedor" runat="server" Width="350px" Height="50px"></CR:CRYSTALREPORTVIEWER></TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:ImageButton id="ibtnExcel" runat="server" Width="40px" ImageUrl="../imagenes/excel.bmp" Height="39px"></asp:ImageButton></TD>
	</TR>
</TABLE>
