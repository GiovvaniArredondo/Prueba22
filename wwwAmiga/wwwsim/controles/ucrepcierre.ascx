<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucrepcierre" CodeFile="ucrepcierre.ascx.vb" %>
<style type="text/css">
    .style1
    {
        height: 49px;
    }
    #Table2
    {
        height: 90px;
    }
</style>
<TABLE id="Table3" style="WIDTH: 568px; HEIGHT: 256px" cellSpacing="0" cellPadding="0"
	width="568" align="left" border="0">
	<TR>
		<TD align="center">
			<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 344px; HEIGHT: 205px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" align="center" border="0">
				<TR>
					<TD align="center">
						<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
							align="center">VALIDACION CARTERA Y CONTABILIDAD</P>
					</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 86px" align="center">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 126px" align="right">
									<asp:label id="Label4" Font-Size="10pt" Font-Names="Verdana" runat="server"></asp:label></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 126px" align="right">
									<asp:label id="Label2" Font-Size="10pt" Font-Names="Verdana" runat="server" Width="116px">Fecha 
                                    Proceso:</asp:label></TD>
								<TD>
									<asp:textbox id="txtfecant" Font-Names="Verdana" runat="server" Width="80px" BorderWidth="1px"
										Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 126px" align="right">
									&nbsp;</TD>
								<TD>
									<asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                                        BackColor="Yellow" BorderColor="Black" BorderWidth="1px" Font-Names="Calibri" 
                                        Text="Agencia Validada" />
                                </TD>
							</TR>
						</TABLE>
					    <asp:Button ID="Button1" runat="server" Font-Names="Calibri" 
                            Text="Imprimir Validación" Visible="False" />
					</TD>
				</TR>
				<TR>
					<TD align="center" class="style1">
					    <asp:Button ID="Button2" runat="server" Font-Names="Calibri" 
                            Text="Imprimir Reclasificación Cartera" />
					</TD>
				</TR>
				<TR>
					<TD align="center">
                        <asp:Button ID="Button3" runat="server" Font-Names="Gill Sans MT" 
                            Text="Provision de Intereses" Visible="False" />
                    </TD>
				</TR>
				<TR>
					<TD align="center">&nbsp;</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
