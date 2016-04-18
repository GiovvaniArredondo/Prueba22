<%@ Control Language="vb" AutoEventWireup="false" Codebehind="CUWCatCon.ascx.vb" Inherits="wwwSIM.CUWCatCon" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="504" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 504px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 400px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 104px" align="center">
			<TABLE id="Table10" style="WIDTH: 172px; HEIGHT: 106px" cellSpacing="0" cellPadding="0"
				width="172" border="0">
				<TR>
					<TD>
						<asp:label id="Label1" Font-Size="8pt" Font-Names="Verdana" runat="server">Tipo de Cuenta:</asp:label></TD>
				</TR>
				<TR>
					<TD align="left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:radiobutton id="rbtipo1" Font-Size="8pt" Font-Names="Verdana" runat="server" Checked="True"
							GroupName="tipo" Text="Padre" Width="77px"></asp:radiobutton></TD>
				</TR>
				<TR>
					<TD align="left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:radiobutton id="rbtipo2" Font-Size="8pt" Font-Names="Verdana" runat="server" GroupName="tipo"
							Text="Padre/Hijo" Width="80px"></asp:radiobutton></TD>
				</TR>
				<TR>
					<TD align="left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:radiobutton id="rbtipo3" Font-Size="8pt" Font-Names="Verdana" runat="server" GroupName="tipo"
							Text="Hijo" Width="80px"></asp:radiobutton></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 103px" align="center"><INPUT id="btnnuevo" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 69px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 63px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="487" border="0" style="WIDTH: 487px; HEIGHT: 32px"
				align="center">
				<TR>
					<TD style="WIDTH: 90px">
						<asp:label id="Label2" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="104px">Cuenta Contable:</asp:label></TD>
					<TD style="WIDTH: 74px">
						<asp:textbox id="txtctactb" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="56px"
							Enabled="False" BackColor="White" BorderWidth="1px"></asp:textbox></TD>
					<TD style="WIDTH: 100px">
						<asp:label id="Label3" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="137px">Descripción de Cuenta:</asp:label></TD>
					<TD style="WIDTH: 227px">
						<asp:textbox id="txtdescta" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="177px"
							Enabled="False" BackColor="White" BorderWidth="1px"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="458" border="0" style="WIDTH: 458px; HEIGHT: 75px"
				align="center">
				<TR>
					<TD>
						<TABLE id="Table7" cellSpacing="0" cellPadding="0" width="412" border="0" style="WIDTH: 412px; HEIGHT: 35px">
							<TR>
								<TD style="WIDTH: 206px"><asp:label id="Label4" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="192px" Visible="False">Cuenta Padre (Cuenta Superior):</asp:label></TD>
								<TD><asp:dropdownlist id="cbxPadre" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="192px"
										Visible="False"></asp:dropdownlist></TD>
							</TR>
						</TABLE>
						<TABLE id="Table13" cellSpacing="0" cellPadding="0" width="432" border="0" style="WIDTH: 432px; HEIGHT: 24px">
							<TR>
								<TD style="WIDTH: 300px"><asp:label id="Label6" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="136px" Visible="False">Naturaleza de Cuenta:</asp:label></TD>
								<TD style="WIDTH: 277px"><asp:dropdownlist id="cmbnatcta" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="192px"
										Visible="False"></asp:dropdownlist></TD>
							</TR>
						</TABLE>
						<asp:label id="Label5" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="392px" BackColor="White"
							ForeColor="Red"></asp:label>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table12" cellSpacing="0" cellPadding="0" width="448" border="0" style="WIDTH: 448px; HEIGHT: 49px"
				align="center">
				<TR>
					<TD style="WIDTH: 232px" align="center"><INPUT id="ibtngrabar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 69px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 63px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
					<TD align="center"><INPUT id="ibtnrevertir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 69px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 63px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
