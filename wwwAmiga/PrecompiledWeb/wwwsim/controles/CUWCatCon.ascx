<%@ control language="vb" autoeventwireup="false" inherits="CUWCatCon, App_Web_mb_xwoah" %>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 504px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 400px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="504" border="0">
	<TR>
		<TD style="HEIGHT: 104px" align="center">
			<TABLE id="Table10" style="WIDTH: 284px; HEIGHT: 106px" cellSpacing="0" 
                cellPadding="0" border="0">
				<TR>
					<TD><asp:label id="Label1" runat="server" Font-Names="Verdana" Font-Size="8pt">Tipo de Cuenta:</asp:label></TD>
				</TR>
				<TR>
					<TD align="left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:radiobutton id="rbtipo2" runat="server" Font-Names="Verdana" 
                            Font-Size="8pt" Width="80px" Text="Resumen"
							GroupName="tipo" Checked="True"></asp:radiobutton></TD>
				</TR>
				<TR>
					<TD align="left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:radiobutton id="rbtipo3" runat="server" Font-Names="Verdana" 
                            Font-Size="8pt" Width="80px" Text="Detalle"
							GroupName="tipo"></asp:radiobutton></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 103px" align="center"><INPUT id="btnnuevo" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 69px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 63px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">
			<asp:textbox id="txtcflag" runat="server" Width="84px" Visible="False"></asp:textbox><INPUT id="cmbedita" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_editar_b.jpg); WIDTH: 65px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 66px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">
			<TABLE id="Table5" style="WIDTH: 487px; HEIGHT: 32px" cellSpacing="0" cellPadding="0" width="487"
				align="center" border="0">
				<TR>
					<TD style="WIDTH: 71px" align="right"><asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="56px">Cuenta Contable:</asp:label></TD>
					<TD style="WIDTH: 74px"><asp:textbox id="txtctactb" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="102px"
							BorderWidth="2px" BackColor="White" Enabled="False"></asp:textbox></TD>
					<TD style="WIDTH: 70px" align="right"><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="83px">Descripción de Cuenta:</asp:label></TD>
					<TD style="WIDTH: 227px"><asp:textbox id="txtdescta" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="208px"
							BorderWidth="2px" BackColor="White" Enabled="False"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD>
			<TABLE id="Table6" style="WIDTH: 481px; HEIGHT: 75px" cellSpacing="0" cellPadding="0" width="481"
				align="center" border="0">
				<TR>
					<TD>
						<TABLE id="Table7" style="WIDTH: 480px; HEIGHT: 35px" cellSpacing="0" cellPadding="0" width="480"
							border="0">
							<TR>
								<TD style="WIDTH: 172px" align="right"><asp:label id="Label4" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="141px" Visible="False"
										Height="30px">Cuenta Padre (Cuenta Superior):</asp:label></TD>
								<TD><asp:dropdownlist id="cbxPadre" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="288px"
										Visible="False" Height="16px"></asp:dropdownlist></TD>
							</TR>
						</TABLE>
						<TABLE id="Table13" style="WIDTH: 480px; HEIGHT: 24px" cellSpacing="0" cellPadding="0"
							width="480" border="0">
							<TR>
								<TD style="WIDTH: 153px" align="right"><asp:label id="Label6" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="86px" Visible="False">Naturaleza de Cuenta:</asp:label></TD>
								<TD style="WIDTH: 277px"><asp:dropdownlist id="cmbnatcta" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="160px"
										Visible="False"></asp:dropdownlist></TD>
							</TR>
						</TABLE>
						<asp:label id="Label5" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="392px" BackColor="White"
							ForeColor="Red"></asp:label></TD>
				</TR>
			</TABLE>
			<TABLE id="Table12" style="WIDTH: 448px; HEIGHT: 49px" cellSpacing="0" cellPadding="0"
				width="448" align="center" border="0">
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
