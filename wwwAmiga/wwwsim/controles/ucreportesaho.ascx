<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucreportesaho" CodeFile="ucreportesaho.ascx.vb" %>
<meta content="False" name="vs_snapToGrid">
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="624" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 624px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 416px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 119px" align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
				align="center">MODULO&nbsp;DE REPORTES DE AHORROS
				<TABLE id="Table2" style="WIDTH: 393px; HEIGHT: 68px" cellSpacing="0" cellPadding="0" width="393"
					align="center" border="0">
					<TR>
						<TD style="WIDTH: 57px; HEIGHT: 68px">
							<P style="FONT-WEIGHT: normal; FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
								align="right">Desde:</P>
						</TD>
						<TD style="WIDTH: 25px; HEIGHT: 68px">
							<P align="right">
								<asp:textbox id="txtfecha1" Width="102px" runat="server" BackColor="White" Font-Names="Verdana"
									Font-Size="8pt" BorderWidth="1px"></asp:textbox></P>
						</TD>
						<TD style="WIDTH: 41px; HEIGHT: 68px">
							<P style="FONT-WEIGHT: normal; FONT-SIZE: 8pt; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
								align="right">Hasta:</P>
						</TD>
						<TD style="WIDTH: 121px; HEIGHT: 68px">
							<asp:textbox id="txtfecha2" Width="94px" runat="server" BackColor="White" Font-Names="Verdana"
								Font-Size="8pt" BorderWidth="1px"></asp:textbox></TD>
						<TD style="HEIGHT: 68px"><INPUT id="btnProcesa" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 60px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></TD>
					</TR>
				</TABLE>
				<TABLE id="Table4" style="BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BACKGROUND-COLOR: #ffffff; BORDER-BOTTOM-STYLE: none"
					cellSpacing="0" cellPadding="0" width="100%" border="1">
					<TR>
						<TD style="HEIGHT: 14px" align="center" bgColor="#ffffff">
							<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="601" border="0" style="WIDTH: 601px; HEIGHT: 288px"
								align="center">
								<TR>
									<TD style="FONT-SIZE: 10pt; WIDTH: 121px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 42px">
										<P style="FONT-WEIGHT: normal; FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
											align="right">Tipo de Ahorro:</P>
									</TD>
									<TD style="WIDTH: 216px; HEIGHT: 42px">
										<P align="left">
											<asp:listbox id="listtipaho" Width="185px" runat="server" BackColor="White" Font-Names="Verdana"
												Height="50px" SelectionMode="Multiple" Font-Size="8pt"></asp:listbox></P>
									</TD>
									<TD style="WIDTH: 88px; HEIGHT: 42px">
										<P align="center">
											<asp:checkbox id="chqtipaho" Width="61px" runat="server" Font-Names="Verdana" Font-Size="8pt"
												Text="Todos" ForeColor="#16387C" BorderColor="Navy" BorderWidth="1px" AutoPostBack="True"></asp:checkbox></P>
									</TD>
									<TD style="HEIGHT: 42px">
										<asp:radiobutton id="rbtmovaho" Width="160px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											Text="Movimientos de ahorros" ForeColor="#16387C" BorderWidth="1px" AutoPostBack="True" GroupName="RAhorro"></asp:radiobutton></TD>
								</TR>
								<TR>
									<TD style="FONT-SIZE: 10pt; WIDTH: 121px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 72px">
										<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
											align="right">&nbsp;</P>
										<P style="FONT-WEIGHT: normal; FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
											align="right">Profesión:</P>
										<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
											align="right">&nbsp;</P>
									</TD>
									<TD style="WIDTH: 216px; HEIGHT: 72px">
										<P align="left">
											<asp:listbox id="Listprofesion" Width="185px" runat="server" Font-Names="Verdana" Height="50px"
												SelectionMode="Multiple" Font-Size="8pt"></asp:listbox></P>
									</TD>
									<TD style="WIDTH: 88px; HEIGHT: 72px">
										<P align="center">
											<asp:checkbox id="chqprofesion" Width="61px" runat="server" Font-Names="Verdana" Font-Size="8pt"
												Text="Todos" ForeColor="#16387C" BorderColor="Navy" BorderWidth="1px" AutoPostBack="True"></asp:checkbox></P>
									</TD>
									<TD style="HEIGHT: 72px">
										<asp:radiobutton id="rbtsumario" Width="160px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											Text="Provisiones de Ahorros" ForeColor="#16387C" BorderWidth="1px" AutoPostBack="True" GroupName="RAhorro"></asp:radiobutton></TD>
								</TR>
								<TR>
									<TD style="FONT-SIZE: 10pt; WIDTH: 121px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 44px">
										<P style="FONT-WEIGHT: normal; FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
											align="right">Sexo:</P>
									</TD>
									<TD style="WIDTH: 216px; HEIGHT: 44px">
										<P align="left">
											<asp:listbox id="ListSexo" Width="185px" runat="server" Font-Names="Verdana" Height="50px" SelectionMode="Multiple"
												Font-Size="8pt"></asp:listbox></P>
									</TD>
									<TD style="WIDTH: 88px; HEIGHT: 44px">
										<P align="center">
											<asp:checkbox id="chqsexo" Width="61px" runat="server" Font-Names="Verdana" Font-Size="8pt" Text="Todos"
												ForeColor="#16387C" BorderColor="Navy" BorderWidth="1px" AutoPostBack="True"></asp:checkbox></P>
									</TD>
									<TD style="HEIGHT: 44px">
										<asp:radiobutton id="rbtcaraho" Width="160px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											Text="Cartera por ahorro" ForeColor="#16387C" BorderWidth="1px" AutoPostBack="True" GroupName="RAhorro"></asp:radiobutton></TD>
								</TR>
								<TR>
									<TD style="FONT-SIZE: 10pt; WIDTH: 121px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 40px">
										<P style="FONT-WEIGHT: normal; FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
											align="right">Catera:</P>
									</TD>
									<TD style="WIDTH: 216px; HEIGHT: 40px">
										<P align="left">
											<asp:listbox id="Listcartera" Width="185px" runat="server" Font-Names="Verdana" Height="50px"
												SelectionMode="Multiple" Font-Size="8pt"></asp:listbox></P>
									</TD>
									<TD style="WIDTH: 88px; HEIGHT: 40px">
										<P align="center">
											<asp:checkbox id="chqcartera" Width="61px" runat="server" Font-Names="Verdana" Font-Size="8pt"
												Text="Todos" ForeColor="#16387C" BorderColor="Navy" BorderWidth="1px" AutoPostBack="True"></asp:checkbox></P>
									</TD>
									<TD style="HEIGHT: 40px">
										<asp:radiobutton id="rbtprovpla" Width="160px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											Text="Cartera a plazo" ForeColor="#16387C" BorderWidth="1px" AutoPostBack="True" GroupName="RAhorro"></asp:radiobutton></TD>
								</TR>
								<TR>
									<TD style="FONT-SIZE: 10pt; WIDTH: 121px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 43px">
										<P style="FONT-WEIGHT: normal; FONT-SIZE: 8pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
											align="right">Tasa ahorros&nbsp;:</P>
									</TD>
									<TD style="WIDTH: 216px; HEIGHT: 43px">
										<P align="left">
											<asp:listbox id="Listtasa1" Width="185px" runat="server" Font-Names="Verdana" Height="50px" SelectionMode="Multiple"
												Font-Size="8pt"></asp:listbox></P>
									</TD>
									<TD style="WIDTH: 88px; HEIGHT: 43px">
										<P align="center">
											<asp:checkbox id="chqtasa1" Width="61px" runat="server" Font-Names="Verdana" Font-Size="8pt" Text="Todos"
												ForeColor="#16387C" BorderColor="Navy" BorderWidth="1px" AutoPostBack="True"></asp:checkbox></P>
									</TD>
									<TD style="HEIGHT: 43px">
										<asp:radiobutton id="rbtintcert" Width="160px" runat="server" Font-Names="Verdana" Font-Size="8pt"
											Text="P. de interés de certif." ForeColor="#16387C" BorderWidth="1px" AutoPostBack="True" GroupName="RAhorro"></asp:radiobutton></TD>
								</TR>
							</TABLE>
							<asp:label id="label_mensaje" Width="532px" runat="server" Font-Names="Verdana" Height="17px"
								Font-Size="8pt"></asp:label></TD>
					</TR>
				</TABLE>
			</P>
		</TD>
	</TR>
</TABLE>
