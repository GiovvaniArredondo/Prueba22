<%@ Control Language="vb" AutoEventWireup="false" Inherits="WUCGarantias" CodeFile="WUCGarantias.ascx.vb" %>
    <script type="text/javascript">
        function SoloNumeros(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode == 08 || charCode == 32 || charCode == 45 || charCode == 46)
                return true;
            else if (charCode >= 48 && charCode <= 57)
                return true;

            return false;
        }

</script>

<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 656px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 345px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="656" bgColor="#ff9966" border="0">
	<TR>
		<TD style="HEIGHT: 6px" align="center" bgColor="#ffffff"><asp:label id="Label9" ForeColor="#16387C" Height="15px" Font-Bold="True" Width="278px" Font-Size="Medium"
				Font-Names="Gill Sans MT" runat="server">GARANTÍAS</asp:label></TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 137px"><asp:label id="Label2" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Visible="False">Codigo de Cliente</asp:label></TD>
					<TD><asp:textbox id="txtcCodcli" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server" Visible="False"
							BorderWidth="1px" Enabled="False"></asp:textbox></TD>
				</TR>
			</TABLE>
			<TABLE id="Table9" style="WIDTH: 657px; HEIGHT: 220px" cellSpacing="0" cellPadding="0"
				width="657" border="0">
				<TR>
					<TD style="WIDTH: 649px; HEIGHT: 278px" align="center">
                <asp:GridView ID="Grid_Garantias" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                            <ControlStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:CommandField>                        
                        <asp:BoundField DataField="ccodgar" HeaderText="No">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ctipgar" HeaderText="TP">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ctipdes" HeaderText="DC">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cCoduni" HeaderText="Codigo">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cdescri" HeaderText="Descripción">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cmoneda" HeaderText="Mn">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nmontas" HeaderText="Tasación" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nmongra" HeaderText="Gravamen" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="disponible" HeaderText="Interes">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>                        
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
						<TABLE id="Table10" style="WIDTH: 656px; HEIGHT: 21px" cellSpacing="0" cellPadding="0"
							width="656" border="0">
							<TR>
								<TD style="WIDTH: 771px" align="right">
									<asp:textbox id="txtccodcta" Width="35px" runat="server" Visible="False"></asp:textbox>
									<asp:textbox id="txtcmoneda" Width="35px" runat="server" Visible="False"></asp:textbox>
									<asp:textbox id="txttasacion" Width="37px" Font-Names="Gill Sans MT" runat="server" Visible="False"></asp:textbox>
									<asp:textbox id="TextBox2" Width="56px" Font-Names="Gill Sans MT" runat="server" Visible="False"></asp:textbox><asp:label id="Label6" Width="99px" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server">Disponibilidad:</asp:label></TD>
								<TD style="WIDTH: 104px"><asp:textbox id="txtDisponible" ForeColor="MidnightBlue" Font-Bold="True" Width="80px" Font-Size="10pt"
										Font-Names="Gill Sans MT" runat="server" BorderWidth="1px" Enabled="False" BackColor="White"></asp:textbox></TD>
							</TR>
						</TABLE>
						<TABLE id="Table11" style="WIDTH: 640px; HEIGHT: 21px" cellSpacing="0" cellPadding="0"
							width="640" border="0">
							<TR>
								<TD style="WIDTH: 646px" align="center">
									&nbsp;</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 646px" align="center">
									<asp:label id="Label4" ForeColor="Red" Height="8px" Font-Bold="True" Width="472px" Font-Size="10pt"
										Font-Names="Gill Sans MT" runat="server"></asp:label></TD>
							</TR>
						</TABLE>
						<TABLE id="Table12" style="WIDTH: 640px; HEIGHT: 22px" cellSpacing="0" cellPadding="0"
							width="640" border="0">
							<TR>
								<TD style="WIDTH: 189px" align="right">
									<asp:TextBox id="txtctipgar" runat="server" Width="16px" Visible="False"></asp:TextBox>
									<asp:label id="Label5" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server">Descripción</asp:label></TD>
								<TD style="WIDTH: 328px"><asp:textbox id="txtDescri" Width="304px" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server"
										BorderWidth="1px" Enabled="False" BackColor="White"></asp:textbox></TD>
								<TD style="WIDTH: 87px"><asp:label id="Label3" Font-Size="10pt" Font-Names="Gill Sans MT" runat="server">Gravamen</asp:label></TD>
								<TD><asp:textbox id="txtGravamen" Width="79px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT" runat="server"
										BorderWidth="1px" onkeypress="return SoloNumeros(event)"></asp:textbox></TD>
							</TR>
						</TABLE>
						<P align="center"><INPUT id="Button1" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 54px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 50px; BACKGROUND-COLOR: transparent"
								type="button" runat="server"></P>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
<P>&nbsp;</P>
