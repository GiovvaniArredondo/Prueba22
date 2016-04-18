<%@ Control Language="vb" AutoEventWireup="false" Inherits="WUsFindFia" CodeFile="WUsFindFia.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

 <script type="text/javascript">

	    function SoloLetras_Numeros(evt) {
	        var charCode = (evt.which) ? evt.which : event.keyCode
	        if (charCode == 08 || charCode == 32 || charCode == 45)
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
    
<P>
	<TABLE id="Table3" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 584px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 197px"
		cellSpacing="0" cellPadding="0" width="584" border="0">
		<TR>
			<TD align="center">
				<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD style="WIDTH: 146px; HEIGHT: 69px">
							<P style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; width: 184px;"
								align="right">
                                <asp:label id="Label1" 
                                    runat="server" Width="152px" Font-Names="Gill Sans MT" Font-Size="10pt"
									Height="11px" ForeColor="#16387C" Font-Bold="True">Nombre, Documento ó Codigo:</asp:label></P>
						</TD>
						<TD style="WIDTH: 234px; HEIGHT: 69px">
							<asp:TextBox id="TxtNombre" BorderWidth="1px" Width="326px" runat="server" Font-Names="Gill Sans MT"
								Font-Size="12pt" Height="26px" BorderColor="#2E6A99" onkeypress="return SoloLetras_Numeros(event)"></asp:TextBox>
                            <cc1:TextBoxWatermarkExtender ID="TxtNombre_TextBoxWatermarkExtender" 
                                runat="server" Enabled="True" TargetControlID="TxtNombre" 
                                WatermarkText="Nombre, NºDoc. Personal ó Codigo de Cliente ">
                            </cc1:TextBoxWatermarkExtender>
                        </TD>
						<TD style="HEIGHT: 69px"><INPUT id="btnfind" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 59px; BACKGROUND-COLOR: transparent"
								type="button" name="Button1" runat="server"></TD>
					</TR>
				</TABLE>
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
                        <asp:BoundField DataField="cnudoci" HeaderText="Cedula/DPI">
                        <HeaderStyle Font-Names="Gill Sans MT" />
                        <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
            </TD>
		</TR>
	</TABLE>
</P>
