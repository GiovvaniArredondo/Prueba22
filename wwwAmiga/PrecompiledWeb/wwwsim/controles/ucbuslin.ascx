<%@ control language="vb" autoeventwireup="false" inherits="ucbuslin, App_Web_yl8dokps" %>
<style type="text/css">
.grid 
{
	border-width:0px;
	font-size:12px;
}

.grid caption 
 {
     background:#f9f9f9 url(images/captionbckg.gif) repeat-x;
	        color:#15428B;
	        text-align:left;
	        line-height:22px;
	        font-size:11px;
	        font-weight:bold;
	        padding-top:2px;
	        padding-left:2px;
	        font-family:tahoma,arial,verdana,sans-serif;
        }

        .grid table 
        {
        	border:solid 1px #99BBE8;
        	height:30px;
	    }
	        
        .grid th
        {
	        background:transparent url(images/thbackground.gif) repeat;
            height:19px;
            border:solid 1px #99BBE8;
            font-weight:normal;
        }

        .grid td
        {
	        border:1px solid #99BBE8;
            color:Black;
            height:25px;
        }
        
        .pagerstyle 
        {
	        font-size:x-small;
	        text-align:right;
            background-position: bottom left;
            background: #D0DEF0 url(images/toolbarbck.gif) repeat-x scroll left top;
        }

        .gopag 
        {
            font-size:x-small;
            width:20px;
        }

        .pagprev
        {
            background:transparent url(images/previous.png) no-repeat scroll center;
            height:1.3em;
            width:16px;
            cursor:pointer;
            border:0px;
        }
        
        .pagnext
        {
            background:transparent url(images/next.png) no-repeat scroll center;
            height:1.3em;
            width:16px;
            cursor:pointer;
            border:0px;
        }

        .pagfirst
        {
            background:transparent url(images/first.png) no-repeat scroll center;
            height:1.3em;
            width:16px;
            cursor:pointer;
            border:0px;
        }
        
        .paglast
        {
            background:transparent url(images/last.png) no-repeat scroll center;
            height:1.3em;
            width:16px;
            cursor:pointer;
            border:0px;
        }

</style>


<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="520" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 520px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 360px">
	<TR>
		<TD>
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
				align="center">LINEA DE CREDITOS</P>
		</TD>
	</TR>
	<TR>
		<TD bgColor="#ffffff"></TD>
	</TR>
	<TR>
		<TD bgColor="#ffffff" style="HEIGHT: 136px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="472" border="0" style="WIDTH: 472px; HEIGHT: 56px">
				<TR>
					<TD style="WIDTH: 187px">
						<P align="right" style="BACKGROUND-COLOR: #ffffff"><asp:label id="Label1" Width="122px" runat="server" ForeColor="SlateBlue" Height="11px" Font-Size="8pt"
								Font-Names="Verdana">Nombre de Línea:</asp:label><asp:label id="Label2" Width="32px" runat="server" ForeColor="Yellow" Height="18px" Font-Size="6pt"
								Font-Names="Century Gothic" Visible="False"></asp:label></P>
					</TD>
					<TD style="WIDTH: 219px">
						<P align="left"><asp:textbox id="TxtNombre" tabIndex="1" Width="208px" runat="server" ToolTip="Digite el Nombre del Cliente"
								Font-Names="Verdana" Font-Size="8pt"></asp:textbox></P>
					</TD>
					<TD>
						<P align="left"><INPUT style="BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif);WIDTH: 56px;BACKGROUND-REPEAT: no-repeat;HEIGHT: 48px;BACKGROUND-COLOR: transparent"
								type="button" id="Button2" name="Button2" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
			<INPUT id="btnAdiciona" type="button" runat="server" 
                style="BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent" 
                visible="False"><asp:GridView ID="Grid_Lineas" runat="server" AllowPaging="True" 
                AutoGenerateColumns="False" Caption="Lineas de Crédito" CssClass="grid" 
                Width="578px">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                    <controlstyle font-names="Gill Sans MT" font-size="9pt" />
                    <HeaderStyle BackColor="#99CCFF" />
                    </asp:CommandField>
                    <asp:BoundField DataField="cnrolin" HeaderText="Numero de Linea">
                    <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                    <ItemStyle Font-Names="Gill Sans MT" />
                    </asp:BoundField>
                    <asp:BoundField DataField="cdeslin" HeaderText="Descripción de Linea" 
                        ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                    <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                    <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="350px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ccodlin" HeaderText="Código de Linea">
                    <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                    <ItemStyle Font-Names="Gill Sans MT" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ntasint" HeaderText="Tasa de Interes">
                    <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                    <ItemStyle Font-Names="Gill Sans MT" />
                    </asp:BoundField>
                </Columns>
                <PagerTemplate>
                    Página
                    <asp:DropDownList ID="paginasDropDownList" runat="server" AutoPostBack="true" 
                        Font-Size="12px" 
                        onselectedindexchanged="paginasDropDownList_SelectedIndexChanged">
                    </asp:DropDownList>
                    de
                    <asp:Label ID="lblTotalNumberOfPages" runat="server" />
                    <asp:Button ID="Button4" runat="server" CommandArgument="First" 
                        CommandName="Page" CssClass="pagfirst" ToolTip="Prim. Pag" />
                    <asp:Button ID="Button5" runat="server" CommandArgument="Prev" 
                        CommandName="Page" CssClass="pagprev" ToolTip="Pág. anterior" />
                    <asp:Button ID="Button6" runat="server" CommandArgument="Next" 
                        CommandName="Page" CssClass="pagnext" ToolTip="Sig. página" />
                    <asp:Button ID="Button3" runat="server" CommandArgument="Last" 
                        CommandName="Page" CssClass="paglast" onclick="Button3_Click" 
                        ToolTip="Últ. Pag" />
                </PagerTemplate>
                <PagerStyle CssClass="pagerstyle" />
                <AlternatingRowStyle BackColor="#99CCFF" />
            </asp:GridView>
		</TD>
	</TR>
	<TR>
		<TD bgColor="#ffffff">
			&nbsp;</TD>
	</TR>
	<TR>
		<TD bgColor="#ffffff">
			&nbsp;</TD>
	</TR>
</TABLE>
