<%@ Control Language="vb" AutoEventWireup="false" Inherits="WUsRefCli" CodeFile="WUsRefCli.ascx.vb" %>
<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 576px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 225px"
	cellSpacing="0" cellPadding="0" width="576" border="0">
	<TR>
		<TD style="HEIGHT: 202px; BACKGROUND-COLOR: #ffffff">
			<TABLE id="Table2" style="WIDTH: 552px; HEIGHT: 60px" cellSpacing="0" cellPadding="0" width="552"
				border="0">
				<TR>
					<TD style="WIDTH: 175px">
						<P style="FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
							align="justify">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Nombre del Cliente</P>
					</TD>
					<TD style="WIDTH: 263px; BACKGROUND-COLOR: #ffffff">
                        <asp:textbox id="TxtNombre" 
                            Font-Names="Verdana" Width="342px" runat="server" BorderColor="#2E6A99" 
                            BorderWidth="1px" Height="23px"></asp:textbox></TD>
					<TD style="BACKGROUND-COLOR: #ffffff"><INPUT id="btnFind" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_buscar2_b.gif); WIDTH: 56px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 53px; BACKGROUND-COLOR: transparent"
							type="button" runat="server"></TD>
				</TR>
			</TABLE>
			<DIV style="BACKGROUND-COLOR: #ffffff" align="center">
                <asp:GridView ID="Grid_Ref" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                            <ControlStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:CommandField>                        
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>                        
                        <asp:BoundField DataField="cNomcli" HeaderText="Nombre Cliente">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="dfecvig" HeaderText="Fecha Desembolso" DataFormatString="{0:dd-MM-yyyy}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>                      
                        <asp:BoundField DataField="ncapdes" HeaderText="Monto" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>                        
                        
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
						</DIV>
		</TD>
	</TR>
</TABLE>
