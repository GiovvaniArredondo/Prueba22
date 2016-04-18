<%@ control language="vb" autoeventwireup="false" inherits="dgHistorialCreditos, App_Web_pi2jwlis" %>
<P>&nbsp;</P>
<P>
	<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 520px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 288px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="520" border="0">
		<TR>
			<TD></TD>
		</TR>
		<TR>
			<TD align="center">
				<TABLE id="Table2" style="WIDTH: 307px; HEIGHT: 22px" cellSpacing="0" cellPadding="0" width="307"
					border="0">
					<TR>
						<TD style="WIDTH: 374px" align="right"><asp:label id="Label1" runat="server" Font-Names="Verdana" Font-Size="8pt">Cuenta:</asp:label></TD>
						<TD><asp:textbox id="txtcuenta" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="216px"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				<TABLE id="Table3" style="WIDTH: 467px; HEIGHT: 22px" cellSpacing="0" cellPadding="0" width="467"
					border="0">
					<TR>
						<TD style="WIDTH: 303px" align="right"><asp:label id="Label2" runat="server" Font-Names="Verdana" Font-Size="8pt">Nombre:</asp:label></TD>
						<TD><asp:textbox id="txtnomcli" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="296px"
								BorderWidth="1px" Enabled="False"></asp:textbox></TD>
					</TR>
				</TABLE>
				<asp:label id="label_mensaje" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="141px"
					ForeColor="Yellow"></asp:label></TD>
		</TR>
		<TR>
			<TD align="center"><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt" Width="141px"></asp:label>
                <asp:GridView ID="datagrid2" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                    <Columns>                        
                        <asp:BoundField DataField="dfecven" HeaderText="Fecha" 
                            DataFormatString="{0:dd-MM-yyyy}">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ctipope" HeaderText="Tipo Op.">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cNroCuo" HeaderText="Nº Cuota">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nmoncuo" HeaderText="Cuota" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ncapita" HeaderText="Capital" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nintere" HeaderText="Interes">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nGastos" HeaderText="Iva" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nsegdeu" HeaderText="Seguro Deuda" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nsaldo" HeaderText="Saldo" 
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
                    </TD>
		</TR>
		<TR>
			<TD align="center">&nbsp;&nbsp;&nbsp;&nbsp;<INPUT id="btnimprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 75px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 57px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server"></TD>
		</TR>
	</TABLE>
</P>
<p>
    &nbsp;</p>

