<%@ control language="vb" autoeventwireup="false" inherits="CuwPlanGB, App_Web_pi2jwlis" %>
<script language="javascript" type="text/javascript">
// <!CDATA[



// ]]>
</script>

<style type="text/css">
    .style1
    {
        width: 71%;
    }
    .style2
    {
        width: 228px;
    }
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 649px; HEIGHT: 259px"
	cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0">
	<TR>
		<TD style="HEIGHT: 18px" align="center"><asp:label id="Label9" Height="15px" 
                Font-Bold="True" ForeColor="#16387C" runat="server" Font-Names="Verdana"
				Width="388px" Font-Size="Medium">CALENDARIO DE PAGOS GRUPAL</asp:label></TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" 
                style="width: 96%">
				<TR>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD align="center">
                <asp:GridView ID="Grid_Plan" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="625px">
                    <Columns>                        
                        <asp:BoundField DataField="fecha" HeaderText="Fecha" 
                            DataFormatString="{0:dd-MM-yyyy}">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="operacion" HeaderText="Tipo Op.">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="N_cuota" HeaderText="Nº Cuota">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nMcuota" HeaderText="Cuota" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="capital" HeaderText="Capital" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="interes" HeaderText="Interes">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Gastos" HeaderText="Iva" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nsegdeu" HeaderText="Seguro Deuda" 
                            DataFormatString="{0:###,##0.00}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="saldo" HeaderText="Saldo" 
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
                        <asp:textbox id="txtcCodCta" runat="server" Font-Names="Verdana" Width="357px" Visible="False"></asp:textbox>
                        <asp:TextBox ID="txtcCodsol" runat="server" Font-Names="Verdana" Height="16px" 
                            Visible="False" Width="162px"></asp:TextBox>
                    </TD>
				</TR>
			</TABLE>
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td align="center" class="style2">
			<INPUT id="btnImprimir" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 51px; BACKGROUND-COLOR: transparent"
				type="button" runat="server" visible="False"></td>
                    <td align="center">
			            <asp:Button ID="Button1" runat="server" Font-Names="Verdana" Height="28px" 
                            Text="Planes Individuales" Width="136px" Visible="False" />
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
			<INPUT id="btnplan" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/printer1.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 51px; BACKGROUND-COLOR: transparent"
				type="button" runat="server"></TD>
	</TR>
</TABLE>
