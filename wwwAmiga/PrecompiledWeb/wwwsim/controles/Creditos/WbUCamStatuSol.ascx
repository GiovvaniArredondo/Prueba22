<%@ control language="VB" autoeventwireup="false" inherits="controles_Creditos_WbUCamStatuSol, App_Web_6e0px9a3" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        height: 50px;
    }
</style>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="592" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 592px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 248px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 19px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">
                                                                <asp:Label ID="lblUsuario109" 
                    Runat="server" Font-Bold="True" 
                                                                    Font-Names="Calibri" 
                    Font-Size="14pt" ForeColor="#000099" 
                                                                    style="text-align: center" 
                    Width="400px">CAMBIAR ESTATUS SOLIDARIO</asp:Label>
                                                            </P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 120px">
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td style="text-align: right">
                                                                                        <asp:Label ID="lblUsuario112" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="11pt" 
                                        style="text-align: left" Width="120px" ForeColor="#2E6A99">Codigo Grupo:</asp:Label>
                                                                                    </td>
                                <td>
                                                                                        <asp:TextBox ID="TxtcCodgru" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" 
                                        Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" 
                                        TabIndex="2" Width="100px"></asp:TextBox>
                                                                                    </td>
                            </tr>
                            <tr>
                                <td style="text-align: right">
                                                                                        <asp:Label ID="lblUsuario113" Runat="server" Font-Names="Calibri" 
                                                                                            Font-Size="11pt" 
                                        style="text-align: left" Width="120px" ForeColor="#2E6A99">Nombre del Grupo:</asp:Label>
                                                                                    </td>
                                <td>
                                                                                        <asp:TextBox ID="Txtcnomgru" runat="server" BorderColor="#2E6A99" 
                                                                                            BorderWidth="1px" 
                                        Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                                                            Height="20px" 
                                        TabIndex="2" Width="300px"></asp:TextBox>
                                                                                    </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                <asp:GridView ID="Grid_Grupo" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                    <Columns>            
                        <asp:BoundField DataField="ccodcli" HeaderText="Codigo Cliente">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>                                    
                        <asp:BoundField DataField="ccodcta" HeaderText="Codigo de Prestamo">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnomcli" HeaderText="Nombre del Cliente">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnudoci" HeaderText="Identificacion" >
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>                        
                        <asp:BoundField DataField="nmonapr" HeaderText="Monto Aprobado">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>                       
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
                        </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD style="text-align: right">
                                                                <asp:Label ID="lblUsuario110" Runat="server" Font-Bold="True" 
                                                                    Font-Names="Calibri" 
                Font-Size="10pt" ForeColor="#FF3300" 
                                                                    
                style="text-align: right" Width="400px">Nota: Esta forma mueve el credito grupal a Estado Solicitado</asp:Label>
		</TD>
	</TR>
	<TR>
		<TD>
			<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnGrabar" runat="server" 
                    Font-Names="Gill Sans MT" Font-Size="12pt" Text="Cambiar Status" 
                    Enabled="False" />
                <cc1:ConfirmButtonExtender ID="btnGrabar_ConfirmButtonExtender" runat="server" 
                    ConfirmText="Realmente Desea Continuar" Enabled="True" 
                    TargetControlID="btnGrabar">
                </cc1:ConfirmButtonExtender>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
		</TD>
	</TR>
</TABLE>
