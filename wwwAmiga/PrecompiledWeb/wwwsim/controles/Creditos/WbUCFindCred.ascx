<%@ control language="VB" autoeventwireup="false" inherits="controles_Creditos_WbUCFindCred, App_Web_6e0px9a3" %>
<link href="Estilo.css" rel="stylesheet" type="text/css" />

   <script type="text/javascript">

	    function SoloLetras_Numeros(evt) {
	        var charCode = (evt.which) ? evt.which : event.keyCode
	        if (charCode == 08 || charCode == 32 || charCode == 45 || charCode == 241 || charCode == 209)
	            return true;
	        else if (charCode >= 48 && charCode <= 57)
	            return true;	            
	        else if (charCode >= 65 && charCode <= 90)
	            return true;
	        else if (charCode >= 97 && charCode <= 122)
	            return true;
	        return false;
	    }

	    
    </script>
    
<TABLE id="Table2" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 576px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 377px"
	cellSpacing="0" cellPadding="0" width="576" border="0" bgcolor="White">
	<TR>
		<TD style="HEIGHT: 11px">
			<P style="BACKGROUND-COLOR: white" align="center">
				<asp:label id="Label9" Font-Bold="True" ForeColor="#16387C" Height="15px" Font-Size="Medium"
					Font-Names="Verdana" Width="448px" runat="server">BUSQUEDA DE CREDITOS</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="472" border="0" style="WIDTH: 472px; HEIGHT: 147px">
				<TR>
					<TD style="WIDTH: 301px" align="right">
						<asp:radiobuttonlist id="rdbbusqueda" ForeColor="#16387C" Height="173px" 
                            Font-Size="8pt" Font-Names="Century Gothic"
							Width="170px" runat="server" RepeatColumns="1" RepeatDirection="Horizontal" BackColor="AliceBlue"
							BorderWidth="2px" BorderColor="Navy">
							<asp:ListItem Value="Por Nombre" Selected="True">Por Nombre                         </asp:ListItem>
							<asp:ListItem Value="Por C&#243;digo">Por C&#243;digo                       </asp:ListItem>
							<asp:ListItem Value="Documento &#250;nico">D.P.I./Cedula</asp:ListItem>
						</asp:radiobuttonlist></TD>
					<TD style="WIDTH: 178px">
						<asp:radiobuttonlist id="rdbbusqueda2" ForeColor="#16387C" Height="149px" 
                            Font-Size="8pt" Font-Names="Century Gothic"
							Width="206px" runat="server" RepeatColumns="1" RepeatDirection="Horizontal" BackColor="LightSteelBlue"
							BorderWidth="2px" BorderColor="Navy">
							<asp:ListItem Value="Proceso de Solicitud">Proceso de Solicitud</asp:ListItem>
							<asp:ListItem Value="Proceso de Sugerencia">Proceso de Sugerencia</asp:ListItem>
							<asp:ListItem Enabled="False">Proceso de Pre-Autorizado</asp:ListItem>
							<asp:ListItem Value="Proceso de Autorización">Proceso de Autorización</asp:ListItem>
							<asp:ListItem Value="Vigentes" Selected="True">Vigentes</asp:ListItem>
							<asp:ListItem Value="Todos">Todos</asp:ListItem>
						    <asp:ListItem>Cancelados</asp:ListItem>
						</asp:radiobuttonlist></TD>
					<TD style="WIDTH: 301px">
						<asp:radiobuttonlist id="rdbbusqueda3" runat="server" Width="131px" 
                            Font-Names="Century Gothic" Font-Size="9pt"
							Height="174px" ForeColor="#16387C" BorderColor="Navy" BorderWidth="2px" BackColor="LightSkyBlue"
							RepeatDirection="Horizontal" RepeatColumns="1">
							<asp:ListItem Value="Cliente" Selected="True">Cliente</asp:ListItem>
							<asp:ListItem Value="Grupo">Grupo</asp:ListItem>
						</asp:radiobuttonlist></TD>
				</TR>
			</TABLE>
			<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="536" border="0" style="WIDTH: 536px; HEIGHT: 48px">
				<TR>
					<TD style="WIDTH: 222px" align="right">
						<asp:label id="Label1" Font-Bold="True" ForeColor="#16387C" Height="11px" Font-Size="12pt"
							Font-Names="calibri" Width="144px" runat="server">Nombre del Cliente:</asp:label></TD>
					<TD style="WIDTH: 238px">
						<P align="left">
							<asp:textbox id="TxtNombre" tabIndex="1" Width="330px" runat="server" ToolTip="Digite el Nombre del Cliente"
								BorderWidth="1px" Font-Names="Verdana" BorderColor="#2E6A99" Height="25px"
								onkeypress="return SoloLetras_Numeros(event)" CssClass="ToUpper"></asp:textbox></P>
					</TD>
					<TD style="WIDTH: 80px">
						<P align="right"><INPUT id="Button1" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif);WIDTH: 56px;BACKGROUND-REPEAT: no-repeat;HEIGHT: 48px;BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center">
                <asp:GridView ID="GridViewDatos" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" Caption="Listado de Créditos" CssClass="grid">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                        <ControlStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <HeaderStyle BackColor="#99CCFF" />
                        </asp:CommandField>
                        <asp:BoundField DataField="codigo" HeaderText="Codigo del Prestamo">
                        <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                        <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnomcli" HeaderText="Nombre de Cliente" 
                            ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                        <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
<ItemStyle HorizontalAlign="Left" Width="350px" Font-Names="Gill Sans MT"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="ncapdes" HeaderText="Monto" ItemStyle-Width="60px">
                        <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                        <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="dfecvig" DataFormatString="{0:dd-MM-yyyy}" 
                            HeaderText="Fecha">
                        <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                        <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cestado" HeaderText="Estado">
                        <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                        <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                    </Columns>
                    <PagerTemplate>
                        Página
                        <asp:DropDownList ID="paginasDropDownList" runat="server" AutoPostBack="true" 
                            Font-Size="12px" OnSelectedIndexChanged="GoPage">
                        </asp:DropDownList>
                        de
                        <asp:Label ID="lblTotalNumberOfPages" runat="server" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button4" runat="server" CommandArgument="First" 
                            CommandName="Page" CssClass="pagfirst" ToolTip="Prim. Pag" />
                        <asp:Button ID="Button5" runat="server" CommandArgument="Prev" 
                            CommandName="Page" CssClass="pagprev" ToolTip="Pág. anterior" />
                        <asp:Button ID="Button2" runat="server" CommandArgument="Next" 
                            CommandName="Page" CssClass="pagnext" ToolTip="Sig. página" />
                        <asp:Button ID="Button3" runat="server" CommandArgument="Last" 
                            CommandName="Page" CssClass="paglast" ToolTip="Últ. Pag" />
                    </PagerTemplate>
                    <PagerStyle CssClass="pagerstyle" />
                    <AlternatingRowStyle BackColor="#99CCFF" />
                </asp:GridView>
            </DIV>
		</TD>
	</TR>
</TABLE>
