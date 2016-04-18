<%@ Control Language="vb" AutoEventWireup="false" Codebehind="MenuLateral.ascx.vb" Inherits="wwwSIM.MenuLateral" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE cellPadding="0" width="137" border="0" style="HEIGHT: 364px" align="right">
	<TR>
		<TD style="HEIGHT: 25px" align="right">
			<asp:imagebutton id="ibtnCarrito" runat="server" Width="27px" Height="28px" ImageUrl="../imagenes/carretilla.gif"
				Visible="False" AlternateText="Carrito de Compras"></asp:imagebutton></TD>
	</TR>
	<TR>
		<td style="HEIGHT: 9px">
		</td>
	</TR>
	<TR>
		<TD style="WIDTH: 446px; HEIGHT: 59px" align="right">
			<DIV align="center">
				<TABLE id="Table2" style="WIDTH: 132px; HEIGHT: 58px" cellSpacing="1" cellPadding="1" width="128"
					align="right" border="0">
					<TR>
						<TD style="HEIGHT: 16px" bgColor="background">
							<P align="center"><FONT face="Arial" color="white" size="1">Buscar Producto</FONT></P>
						</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 37px">
							<P align="center">
								<asp:TextBox id="TextBox1" Height="24px" Width="87px" runat="server"></asp:TextBox><BR>
								<asp:DropDownList id="DDowl1" runat="server" Width="82px">
									<asp:ListItem Value="Criterio">Criterio</asp:ListItem>
								</asp:DropDownList></P>
							<P align="center">
								<asp:Image id="Image1" runat="server" ImageUrl="file:///C:\Inetpub\wwwroot\PYME\imagenes\top_bto_buscar.gif"></asp:Image></P>
						</TD>
					</TR>
					<TR>
						<TD bgColor="background">
							<P align="center">&nbsp;</P>
						</TD>
					</TR>
				</TABLE>
			</DIV>
		</TD>
	</TR>
	<TR>
		<TD align="right" style="WIDTH: 446px">
			<table id="loginTable" cellpadding="0" cellspacing="0" border="0" runat="server">
				<tr>
					<td>
						<DIV align="center">
							<TABLE style="WIDTH: 130px; HEIGHT: 102px" align="right" bgColor="#ffffff" border="0">
								<TR>
									<TD style="FONT-WEIGHT: bold; FONT-SIZE: 0.9em; COLOR: white; FONT-STYLE: normal; HEIGHT: 19px; BACKGROUND-COLOR: #5d7b9d"
										align="center" bgColor="#ffffff" colSpan="2">Ingreso</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 48px; HEIGHT: 20px" align="right" bgColor="#ffffff"><asp:label id="lblUsuario" Runat="server">Usuario:</asp:label></TD>
									<TD style="HEIGHT: 25px" align="left" bgColor="#ffffff"><asp:textbox id="txtUsuario" Runat="server" Width="49px" Font-Size="0.8em" Height="19px"></asp:textbox><asp:requiredfieldvalidator id="requiredUsuario" Runat="server" ToolTip="Usuario es requerido." ControlToValidate="txtUsuario"
											ErrorMessage="Usuario es requerido.">
									*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="FONT-SIZE: 0.8em; WIDTH: 48px; HEIGHT: 17px" align="right" bgColor="#ffffff"><asp:label id="lblClave" Runat="server">Clave:</asp:label></TD>
									<TD style="HEIGHT: 17px" align="left" bgColor="#ffffff"><asp:textbox id="txtClave" Runat="server" Width="49px" Font-Size="0.8em" TextMode="Password"></asp:textbox><asp:requiredfieldvalidator id="requiredClave" Runat="server" ToolTip="Clave es requerida." ControlToValidate="txtClave"
											ErrorMessage="Clave es requerida.">
									*</asp:requiredfieldvalidator></TD>
								</TR>
								<TR>
									<TD style="FONT-SIZE: 0.8em" align="right" bgColor="#ffffff" colSpan="2">
										<SELECT id="perfilUsuario" runat="server" style="WIDTH: 116px">
											<OPTION value="CL" selected>Cliente</OPTION>
											<OPTION value="DS">Distribuidora</OPTION>
										</SELECT>
									</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 13px" align="right" bgColor="#ffffff" colSpan="2">
										<P align="center"><asp:button id="btnIngresar" Runat="server" Font-Size="0.7em" BorderWidth="1px" BorderColor="#CCCCCC"
												BorderStyle="Solid" BackColor="#FFFBFF" Font-Names="Verdana" ForeColor="#284775" Text="Ingresar" Height="17px"></asp:button></P>
									</TD>
								</TR>
								<TR>
									<TD style="FONT-SIZE: 0.8em; COLOR: red" bgColor="#ffffff" colSpan="2"><asp:literal id="FailureText" Runat="server" EnableViewState="False"></asp:literal></TD>
								</TR>
							</TABLE>
						</DIV>
					</td>
				</tr>
			</table>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 446px" align="center">
			<DIV align="center">
				<TABLE id="Table1" style="WIDTH: 132px; HEIGHT: 129px" width="132" align="right" bgColor="background"
					border="1" borderColor="#ffffff">
					<TR>
						<TD style="HEIGHT: 13px">
							<asp:HyperLink id="HyperLink1" ForeColor="White" runat="server">Productos</asp:HyperLink></TD>
					</TR>
					<TR>
						<TD>
							<asp:HyperLink id="HyperLink2" ForeColor="White" runat="server">Ofertas</asp:HyperLink></TD>
					</TR>
					<TR>
						<TD>
							<asp:HyperLink id="HyperLink3" ForeColor="White" runat="server">Destacados</asp:HyperLink></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 23px">
							<asp:HyperLink id="HyperLink4" ForeColor="White" runat="server">Notificaciones</asp:HyperLink></TD>
					</TR>
					<TR>
						<TD>
							<asp:HyperLink id="HyperLink5" ForeColor="White" runat="server">Noticias</asp:HyperLink></TD>
					</TR>
				</TABLE>
			</DIV>
		</TD>
	</TR>
	<tr>
		<td> <!-- Keep all menus within masterdiv-->
			<div id="masterdiv">
				<div class="menutitle" onclick="SwitchMenu('sub1')">Site Menu</div>
				<span class="submenu" id="sub1">- <a href="new.htm">What's New</a><br>
					- <a href="hot.htm">What's hot</a><br>
					- <a href="revised.htm">Revised Scripts</a><br>
					- <a href="morezone/">More Zone</a> </span>
				<div class="menutitle" onclick="SwitchMenu('sub2')">FAQ/Help</div>
				<span class="submenu" id="sub2">- <a href="notice.htm">Usage Terms</a><br>
					- <a href="faqs.htm">DHTML FAQs</a><br>
					- <a href="help.htm">Scripts FAQs</a> </span>
				<div class="menutitle" onclick="SwitchMenu('sub3')">Help Forum</div>
				<span class="submenu" id="sub3">- <a href="http://www.codingforums.com">Coding Forums</a><br>
				</span>
				<div class="menutitle" onclick="SwitchMenu('sub4')">Cool Links</div>
				<span class="submenu" id="sub4">- <a href="http://www.javascriptkit.com">JavaScript Kit</a><br>
					- <a href="http://www.freewarejava.com">Freewarejava</a><br>
					- <a href="http://www.cooltext.com">Cool Text</a><br>
					- <a href="http://www.google.com">Google.com</a> </span><img src="about.gif" onclick="SwitchMenu('sub5')"><br>
				<span class="submenu" id="sub5">- <a href="http://www.dynamicdrive.com/link.htm">Link 
						to DD</a><br>
					- <a href="http://www.dynamicdrive.com/recommendit/">Recommend Us</a><br>
					- <a href="http://www.dynamicdrive.com/contact.htm">Email Us</a><br>
				</span>
			</div>
		</td>
	</tr>
</TABLE>
