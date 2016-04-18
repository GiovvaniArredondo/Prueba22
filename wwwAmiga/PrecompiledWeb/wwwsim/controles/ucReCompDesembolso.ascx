<%@ control language="vb" autoeventwireup="false" inherits="ucReCompDesembolso, App_Web_pi2jwlis" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 126px;
        height: 35px;
    }
    .style2
    {
        height: 35px;
    }
    .style3
    {
        height: 33px;
    }
    #Table2
    {
        height: 39px;
    }
    .style4
    {
        width: 72%;
    }
    .style5
    {
        width: 110px;
    }
    .style6
    {
        width: 79px;
    }
    .style7
    {
        width: 115px;
    }
    .style8
    {
        width: 56%;
    }
    .style9
    {
        width: 117px;
    }
    .style10
    {
        background-color: #FFFFFF;
    }
</style>

			<TABLE id="Table1" style="border: thin solid #003366; WIDTH: 462px; HEIGHT: 241px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" align="center" border="0">
				<TR>
					<TD align="center">
						<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; BACKGROUND-COLOR: #ffffff"
							align="center"><span lang="es-gt">Re-<span class="style10">i</span></span>mpresión
                            <span lang="es-gt">comprobante desembolso</span></P>
					</TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 86px" align="center">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD align="right" class="style1">
									<asp:label id="Label2" Font-Size="9pt" Font-Names="CALIBRI" runat="server" 
                                        Width="116px">Cliente/Banco</asp:label></TD>
								<TD class="style2">
                                    <asp:TextBox ID="TextBoxCcodcta" runat="server" Visible="False" Width="26px" 
                                        BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                    <asp:TextBox ID="TextBoxNombre" runat="server" Enabled="False" Width="299px" 
                                        BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                </TD>
							</TR>
							<TR>
								<TD align="right" class="style1">
									<asp:label id="Label8" Font-Size="9pt" Font-Names="CALIBRI" runat="server" 
                                        Width="116px">No. Doc:</asp:label></TD>
								<TD class="style2">
                                    <asp:TextBox ID="TextBoxCheque" runat="server" Width="101px" 
                                        BorderColor="#2E6A99" BorderWidth="1px" Enabled="False"></asp:TextBox>
                                </TD>
							</TR>
							<TR>
								<TD align="right" class="style1">
									<asp:label id="Label9" Font-Size="9pt" Font-Names="CALIBRI" runat="server" 
                                        Width="116px">fecha desemb:</asp:label></TD>
								<TD class="style2">
                                    <asp:TextBox ID="TextBoxFecha" runat="server" Enabled="False" Width="101px" 
                                        BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                                </TD>
							</TR>
							</TABLE>
					</TD>
				</TR>
				<TR>
					<TD align="center" class="style3">
                                    <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Text="Imprimir" Width="100px" />
                                    <asp:TextBox ID="TextBoxBandera" runat="server" Visible="False" Width="52px"></asp:TextBox>
                                </TD>
				</TR>		
			</TABLE>

