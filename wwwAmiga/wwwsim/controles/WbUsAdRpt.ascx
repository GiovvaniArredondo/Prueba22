<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="WbUsAdRpt" CodeFile="WbUsAdRpt.ascx.vb" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD style="WIDTH: 996px"></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 996px; HEIGHT: 23px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 16pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
				align="center">MODULO&nbsp;DE REPORTES</P>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 996px"></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 997px; HEIGHT: 40px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="HEIGHT: 23px">
						<P style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
							align="right">Desde</P>
					</TD>
					<TD style="HEIGHT: 23px">
						<P align="left"><asp:textbox id="TxtDate1" Font-Italic="True" Font-Names="arial elvetica" BackColor="White" runat="server"></asp:textbox></P>
					</TD>
					<TD style="HEIGHT: 23px">
						<P style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
							align="right">Hasta</P>
					</TD>
					<TD style="HEIGHT: 23px"><asp:textbox id="TxtDate2" Font-Italic="True" Font-Names="arial elvetica" BackColor="White" runat="server"></asp:textbox></TD>
				</TR>
			</TABLE>
			<asp:label id="label_mensaje" Font-Names="Verdana" runat="server" Font-Size="8pt" Width="532px"
				Height="17px"></asp:label></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 996px"></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 998px; HEIGHT: 416px">
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 123px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 53px">
						<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
							align="right">Zona</P>
					</TD>
					<TD style="WIDTH: 244px; HEIGHT: 53px">
						<P align="center"><asp:listbox id="ListZonas" Font-Names="Verdana" BackColor="White" runat="server" Font-Size="XX-Small"
								Width="216px" Height="50px" SelectionMode="Multiple"></asp:listbox></P>
					</TD>
					<TD style="WIDTH: 134px; HEIGHT: 53px">
						<P align="center"><asp:checkbox id="chqzonas" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="90px"
								BorderWidth="1px" BorderColor="Transparent" ForeColor="#16387C" Text="Todos" AutoPostBack="True"></asp:checkbox></P>
					</TD>
					<TD style="WIDTH: 181px; HEIGHT: 53px"><asp:radiobutton id="rbtIngresos" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Ingresos Diarios" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="WIDTH: 176px; HEIGHT: 53px"><asp:radiobutton id="rbtsabana" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Sábana" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="HEIGHT: 53px"><asp:radiobutton id="Radiobutton7" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Consolidados Estadísticos" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 123px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 64px">
						<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
							align="right">Fuentes Fondos</P>
					</TD>
					<TD style="WIDTH: 244px; HEIGHT: 64px">
						<P align="center"><asp:listbox id="ListFondos" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="216px"
								Height="42px" SelectionMode="Multiple"></asp:listbox></P>
					</TD>
					<TD style="WIDTH: 134px; HEIGHT: 64px">
						<P align="center"><asp:checkbox id="chqfondos" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="90px"
								BorderWidth="1px" BorderColor="Transparent" ForeColor="#16387C" Text="Todos" AutoPostBack="True"></asp:checkbox></P>
					</TD>
					<TD style="WIDTH: 181px; HEIGHT: 64px"><asp:radiobutton id="rbtDesem" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Desembolsos" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="WIDTH: 176px; HEIGHT: 64px"><asp:radiobutton id="Radiobutton1" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Informes Estadísticos" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="HEIGHT: 64px"><asp:radiobutton id="Radiobutton8" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Consolidado Sector E." AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 123px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 59px">
						<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
							align="right">Actividad</P>
					</TD>
					<TD style="WIDTH: 244px; HEIGHT: 59px">
						<P align="center"><asp:listbox id="ListActividad" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="216px"
								Height="48px" SelectionMode="Multiple"></asp:listbox></P>
					</TD>
					<TD style="WIDTH: 134px; HEIGHT: 59px">
						<P align="center"><asp:checkbox id="chqactividad" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="90px"
								BorderWidth="1px" BorderColor="Transparent" ForeColor="#16387C" Text="Todos" AutoPostBack="True"></asp:checkbox></P>
					</TD>
					<TD style="WIDTH: 181px; HEIGHT: 59px"><asp:radiobutton id="rbtCartera" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Cartera Vigente" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="WIDTH: 176px; HEIGHT: 59px"><asp:radiobutton id="Radiobutton2" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Provisiones" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="HEIGHT: 59px"><asp:radiobutton id="Radiobutton9" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Consolidado Actividad" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 123px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 52px">
						<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
							align="right">Sexo</P>
					</TD>
					<TD style="WIDTH: 244px; HEIGHT: 52px">
						<P align="center"><asp:listbox id="ListSexo" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="216px"
								Height="39px" SelectionMode="Multiple"></asp:listbox></P>
					</TD>
					<TD style="WIDTH: 134px; HEIGHT: 52px">
						<P align="center"><asp:checkbox id="chqsexo" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="90px"
								BorderWidth="1px" BorderColor="Transparent" ForeColor="#16387C" Text="Todos" AutoPostBack="True"></asp:checkbox></P>
					</TD>
					<TD style="WIDTH: 181px; HEIGHT: 52px"><asp:radiobutton id="rbtDetalle" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Detalle de Cartera y depósitos" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="WIDTH: 176px; HEIGHT: 52px"><asp:radiobutton id="Radiobutton3" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Aseguradora (CUNA)" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="HEIGHT: 52px"><asp:radiobutton id="rdbsumario" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Sumarios" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 123px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 63px">
						<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
							align="right">Cartera</P>
					</TD>
					<TD style="WIDTH: 244px; HEIGHT: 63px">
						<P align="center"><asp:listbox id="ListTipo" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="216px"
								Height="37px" SelectionMode="Multiple"></asp:listbox></P>
					</TD>
					<TD style="WIDTH: 134px; HEIGHT: 63px">
						<P align="center"><asp:checkbox id="chqcartera" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="90px"
								BorderWidth="1px" BorderColor="Transparent" ForeColor="#16387C" Text="Todos" AutoPostBack="True"></asp:checkbox></P>
					</TD>
					<TD style="WIDTH: 181px; HEIGHT: 63px"><asp:radiobutton id="rbtMora" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Cartera General en Mora" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="WIDTH: 176px; HEIGHT: 63px"><asp:radiobutton id="Radiobutton4" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Vencimientos Diarios" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="HEIGHT: 63px"><asp:radiobutton id="Radiobutton6" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Vencimiento de cuotas" AutoPostBack="True" GroupName="rcartera" DESIGNTIMEDRAGDROP="1210"></asp:radiobutton></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 123px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 64px">
						<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
							align="right">Analista</P>
					</TD>
					<TD style="WIDTH: 244px; HEIGHT: 64px">
						<P align="center"><asp:listbox id="ListAna" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="216px"
								Height="40px" SelectionMode="Multiple"></asp:listbox></P>
					</TD>
					<TD style="WIDTH: 134px; HEIGHT: 64px">
						<P align="center"><asp:checkbox id="chqanalista" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="90px"
								BorderWidth="1px" BorderColor="Transparent" ForeColor="#16387C" Text="Todos" AutoPostBack="True"></asp:checkbox></P>
					</TD>
					<TD style="WIDTH: 181px; HEIGHT: 64px"><asp:radiobutton id="rbtProyec" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Proyeccion de Mora" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="WIDTH: 176px; HEIGHT: 64px"><asp:radiobutton id="Radiobutton5" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Créditos Depurados" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
					<TD style="HEIGHT: 64px"><asp:radiobutton id="Radiobutton12" Font-Names="Verdana" runat="server" Font-Size="XX-Small" Width="144px"
							BorderWidth="1px" ForeColor="#16387C" Text="Consolidado Profesión" AutoPostBack="True" GroupName="rcartera"></asp:radiobutton></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 123px; FONT-FAMILY: 'Century Gothic'; HEIGHT: 64px"></TD>
					<TD style="WIDTH: 244px; HEIGHT: 64px">
						<P align="center"><asp:button id="BtnProcesa" Font-Names="Verdana" runat="server" Width="152px" ForeColor="#16387C"
								Text="Procesar" Font-Bold="True"></asp:button></P>
					</TD>
					<TD style="WIDTH: 134px; HEIGHT: 64px"></TD>
					<TD style="WIDTH: 181px; HEIGHT: 64px"></TD>
					<TD style="WIDTH: 176px; HEIGHT: 64px"></TD>
					<TD style="HEIGHT: 64px"></TD>
				</TR>
			</TABLE>
			<P align="center">&nbsp;</P>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 997px"></TD>
	</TR>
</TABLE>
