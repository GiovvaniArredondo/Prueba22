<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="cuwlibretas" CodeFile="cuwlibretas.ascx.vb" %>
<TABLE id="Table8" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 544px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 280px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="544" border="0">
	<TR>
		<TD style="WIDTH: 496px; HEIGHT: 276px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:label id="Label3" runat="server" Width="251px" Font-Bold="True" Font-Size="Medium" Height="15px"
				Font-Names="Verdana" ForeColor="#16387C">LIBRETA DE PAGOS</asp:label>
			<TABLE id="Table5" style="WIDTH: 405px; HEIGHT: 57px" cellSpacing="0" cellPadding="0" width="405"
				border="0">
				<TR>
					<TD align="center">
						<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 110px; HEIGHT: 50px" align="right">
									<asp:label id="Label5" runat="server" Width="95px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="0px"
										BorderStyle="Groove" BorderColor="White">Codigo Crédito:</asp:label></TD>
								<TD style="WIDTH: 140px; HEIGHT: 50px">
									<asp:textbox id="txtccodcta" runat="server" Width="136px" Font-Names="Garamond" ForeColor="Maroon"
										BorderWidth="2px" ReadOnly="True"></asp:textbox></TD>
								<TD style="WIDTH: 53px; HEIGHT: 50px">
									<asp:label id="Label4" runat="server" Width="45px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="0px"
										BorderStyle="Groove" BorderColor="White">Cliente:</asp:label></TD>
								<TD style="HEIGHT: 50px">
									<asp:textbox id="txtcnomcli" runat="server" Width="248px" Font-Names="Garamond" ForeColor="Maroon"
										BorderWidth="2px" ReadOnly="True"></asp:textbox></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="center" style="HEIGHT: 32px">
						<TABLE id="Table4" style="WIDTH: 378px; HEIGHT: 19px" cellSpacing="0" cellPadding="0" width="378"
							border="0">
							<TR>
								<TD style="WIDTH: 322px" align="right">
									<asp:label id="Label18" runat="server" Width="61px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="2px"
										BorderStyle="Groove" BorderColor="#C04000">Banco:</asp:label></TD>
								<TD>
									<asp:dropdownlist id="cmbbanco" runat="server" Width="288px" Font-Size="8pt" Font-Names="Verdana"></asp:dropdownlist></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="center">
						<TABLE id="Table2" style="WIDTH: 294px; HEIGHT: 52px" cellSpacing="0" cellPadding="0" width="294"
							border="0">
							<TR>
								<TD style="WIDTH: 140px; HEIGHT: 26px" align="right">
									<asp:label id="Label1" runat="server" Width="64px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="0px"
										BorderStyle="Groove" BorderColor="White">Desde:</asp:label></TD>
								<TD style="WIDTH: 124px; HEIGHT: 26px">
									<asp:textbox id="txtdfecini" runat="server" Width="104px" Font-Names="Garamond" ForeColor="MidnightBlue"
										BorderWidth="2px"></asp:textbox></TD>
								<TD style="WIDTH: 43px; HEIGHT: 26px">
									<asp:label id="Label2" runat="server" Width="40px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="0px"
										BorderStyle="Groove" BorderColor="White">Hasta:</asp:label></TD>
								<TD style="HEIGHT: 26px">
									<asp:textbox id="txtdfecfin" runat="server" Width="104px" Font-Names="Garamond" ForeColor="MidnightBlue"
										BorderWidth="2px"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 140px; HEIGHT: 26px" align="right">
									<asp:TextBox id="txtcflag" Width="32px" runat="server" Visible="False"></asp:TextBox></TD>
								<TD style="WIDTH: 124px; HEIGHT: 26px">
									<asp:rangevalidator id="RangeValidator5" runat="server" Width="88px" Font-Size="8pt" Font-Names="Verdana"
										DESIGNTIMEDRAGDROP="1491" ControlToValidate="txtdfecini" ErrorMessage="RangeValidator" Type="Date"
										MinimumValue="01/01/2000" MaximumValue="01/01/3000">Fecha Inválida-</asp:rangevalidator></TD>
								<TD style="WIDTH: 43px; HEIGHT: 26px"></TD>
								<TD style="HEIGHT: 26px">
									<asp:rangevalidator id="Rangevalidator1" runat="server" Width="88px" Font-Size="8pt" Font-Names="Verdana"
										DESIGNTIMEDRAGDROP="1491" ControlToValidate="txtdfecfin" ErrorMessage="RangeValidator" Type="Date"
										MinimumValue="01/01/2000" MaximumValue="01/01/3000">Fecha Inválida-</asp:rangevalidator></TD>
							</TR>
						</TABLE>
						<INPUT id="btnaplicar2" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
			</TABLE>
			<asp:TextBox id="txtdfecvig" Width="41px" runat="server" Visible="False"></asp:TextBox>
		</TD>
	</TR>
</TABLE>
