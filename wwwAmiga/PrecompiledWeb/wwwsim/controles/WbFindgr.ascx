<%@ control language="vb" autoeventwireup="false" inherits="WbFindgr, App_Web_yl8dokps" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />

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
    
<TABLE id="Table3" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 616px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 306px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="616" align="left" border="0">
	<TR>
		<TD style="WIDTH: 903px">
			<P align="center"><asp:label id="Label2" runat="server" Width="278px" Font-Names="Verdana" Font-Size="Medium"
					Height="15px" ForeColor="#16387C" Font-Bold="True">BUSQUEDA DE GRUPOS</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 904px">
			<TABLE id="Table4" style="WIDTH: 624px; HEIGHT: 64px" cellSpacing="0" cellPadding="0" width="624"
				border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 391px; HEIGHT: 41px">
							<P style="BACKGROUND-COLOR: #ffffff" align="right"><asp:label id="Label1" 
                                    runat="server" Width="152px" Font-Names="Gill Sans MT" Font-Size="12pt"
									Height="11px" ForeColor="#16387C" Font-Bold="True">Nombre del Grupo :</asp:label></P>
						</TD>
						<TD style="WIDTH: 275px; HEIGHT: 41px">
							<P align="left">
                                <asp:textbox id="TxtNombre" tabIndex="1" runat="server" 
                                    Width="400px" Font-Names="Gill Sans MT" BorderWidth="1px"
									ToolTip="Digite el Nombre del Cliente" Font-Size="12pt" BorderColor="#2E6A99" 
									onkeypress="return SoloLetras_Numeros(event)" CssClass="ToUpper"></asp:textbox></P>
						</TD>
						<TD style="WIDTH: 141px; HEIGHT: 41px">
							<P align="left"><INPUT id="Button1" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 57px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 51px; BACKGROUND-COLOR: transparent"
									type="button" name="Button1" runat="server"></P>
						</TD>
					</TR>
				</TBODY>
			</TABLE>
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center">
                <asp:GridView ID="dgclientes" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                    <Columns>
                        <asp:CommandField ButtonType="Button" CancelText="" DeleteText="" EditText="" 
                            InsertText="" InsertVisible="False" NewText="" SelectText="Seleccionar" 
                            ShowCancelButton="False" ShowSelectButton="True" UpdateText="">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:CommandField>
                        <asp:BoundField DataField="codigo" HeaderText="Codigo de Grupo">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" />
                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnomgru" HeaderText="Nombre del Cliente">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" />
                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <SelectedRowStyle BackColor="#99CC00" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
            </DIV>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 903px">
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center">
							<asp:label id="Label3" runat="server" Width="152px" 
                    Font-Names="Verdana" Font-Size="Smaller"
									Height="11px" ForeColor="#16387C" Font-Bold="True" Visible="False">Nombre del Centro: </asp:label>
						&nbsp;<asp:DropDownList ID="cbxcentros" runat="server" AutoPostBack="True" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="240px" 
                                BackColor="#FFFF99" Visible="False">
                        </asp:DropDownList>
						</DIV>
		</TD>
	</TR>
</TABLE>
