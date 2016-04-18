<%@ control language="vb" autoeventwireup="false" inherits="WbFind, App_Web_5wr0lfuo" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


     
 <style type="text/css">
     .style1
     {
         width: 639px;
         height: 306px;
     }
 </style>


     
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
    
<TABLE id="Table3" style="border: thin solid highlight; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" align="left" border="0" class="style1">
	<TR>
		<TD style="WIDTH: 903px">
			<P align="center"><asp:label id="Label2" runat="server" Width="278px" Font-Names="Gill Sans MT" Font-Size="Medium"
					Height="15px" ForeColor="#16387C" Font-Bold="True">BUSQUEDA DE CLIENTES</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD style="WIDTH: 904px">
			<TABLE id="Table4" style="WIDTH: 624px; HEIGHT: 64px" cellSpacing="0" cellPadding="0" width="624"
				border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 391px; HEIGHT: 41px">
							<P style="BACKGROUND-COLOR: #ffffff" align="right">
                                <asp:label id="Label1" 
                                    runat="server" Width="152px" Font-Names="Gill Sans MT" Font-Size="10pt"
									Height="11px" ForeColor="#16387C" Font-Bold="True">Nombre, Documento ó Codigo:</asp:label></P>
						</TD>
						<TD style="WIDTH: 275px; HEIGHT: 41px">
							<P align="left">
                                                                                                                                                    <asp:TextBox ID="TxtcEvalua" runat="server" 
                                    BorderColor="#2E6A99" 
                                                                                                                                                        
                                    BorderWidth="1px" Font-Names="Verdana" 
                                    Font-Size="8pt" 
                                                                                                                                                        
                                    Height="29px" TabIndex="4" Width="400px" 
                                    CssClass="transpare" 
                                                                                                                                                        
                                    onkeypress="return SoloLetras_Numeros(event)"></asp:TextBox>
                                                                                                                                                    <cc1:TextBoxWatermarkExtender 
                                    ID="TxtcEvalua_TextBoxWatermarkExtender" 
                                                                                                                                                        
                                    runat="server" Enabled="True" 
                                    TargetControlID="TxtcEvalua" 
                                                                                                                                                        
                                    WatermarkCssClass="Watermark" WatermarkText="Digite Nombre del Cliente, No Documento, Codigo de Cliente">
                                                                                                                                                    </cc1:TextBoxWatermarkExtender>
                            </P>
						</TD>
						<TD style="WIDTH: 141px; HEIGHT: 41px">
							<P align="left"><asp:Button ID="Button2" 
                                    runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" Text="Buscar" />
                            </P>
						</TD>
					</TR>
				</TBODY>
			</TABLE>
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center">
                <asp:GridView ID="dgclientes" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Visible="False" Width="579px">
                    <Columns>
                        <asp:CommandField ButtonType="Button" CancelText="" DeleteText="" EditText="" 
                            InsertText="" InsertVisible="False" NewText="" SelectText="Seleccionar" 
                            ShowCancelButton="False" ShowSelectButton="True" UpdateText="">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:CommandField>
                        <asp:BoundField DataField="codigo" HeaderText="Codigo Cliente">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" />
                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnomcli" HeaderText="Nombre del Cliente">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Calibri" Font-Size="10pt" />
                            <ItemStyle Font-Names="Calibri" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnudoci" HeaderText="Identificacion">
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
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center">&nbsp;</DIV>
		</TD>
	</TR>
</TABLE>
