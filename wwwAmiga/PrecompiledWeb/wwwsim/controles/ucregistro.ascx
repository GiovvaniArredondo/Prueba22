<%@ control language="vb" autoeventwireup="false" inherits="ucregistro, App_Web_yjxjq67i" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="568" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 568px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 288px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD align="center">
			<asp:label id="Label6" Font-Bold="True" Font-Names="Verdana" runat="server" Width="245px" Font-Size="Medium"
				Height="15px" ForeColor="#16387C">PERFILES DE  USUARIOS</asp:label></TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="479" border="0" style="WIDTH: 479px; HEIGHT: 31px"
				align="center">
				<TR>
					<TD style="WIDTH: 184px" align="right"><asp:label id="Label2" Width="72px" runat="server" Font-Names="Verdana" Font-Size="8pt">USUARIO:</asp:label></TD>
					<TD style="WIDTH: 378px" align="left"><asp:dropdownlist id="ddlusuarios" Width="192px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist><asp:textbox id="txtcodigo" Width="49px" runat="server" Height="19px" Enabled="False" Font-Names="Verdana"
							Font-Size="8pt"></asp:textbox></TD>
				</TR>
			</TABLE>
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="552" border="0" style="WIDTH: 552px; HEIGHT: 137px">
				<TR>
					<TD style="WIDTH: 245px; HEIGHT: 19px" align="right">
						<asp:label id="Label3" Font-Names="Verdana" runat="server" Width="122px" Font-Size="8pt" ForeColor="MidnightBlue">GRUPO DE TRABAJO</asp:label></TD>
					<TD style="WIDTH: 89px; HEIGHT: 19px" align="center"></TD>
					<TD style="HEIGHT: 19px" align="left">
						<asp:label id="Label4" Font-Names="Verdana" runat="server" Width="144px" Font-Size="8pt" ForeColor="MidnightBlue">OPCIONES POR GRUPO</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 245px" align="right">
						<asp:dropdownlist id="ddlgrupos" Font-Names="Verdana" runat="server" Width="224px" Font-Size="8pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 89px" align="center"><INPUT id="btnaplicar2" style="FONT-WEIGHT: bold; FONT-SIZE: 8pt; BACKGROUND: url(Web/jpgs/btn_aplicar_b.jpg) fixed no-repeat center center; WIDTH: 61px; COLOR: buttontext; FONT-FAMILY: 'Century Gothic'; HEIGHT: 50px"
							tabIndex="12" type="button" name="Button5" runat="server"></TD>
					<TD align="right">
						<asp:listbox id="ltbopciones" Font-Names="Verdana" runat="server" Width="234px" Font-Size="8pt"
							Height="80px"></asp:listbox></TD>
				</TR>
			</TABLE>
			<INPUT id="btngrabar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 63px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">
		</TD>
	</TR>
</TABLE>
