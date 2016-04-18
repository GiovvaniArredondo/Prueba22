<%@ Control Language="vb" AutoEventWireup="false" CodeFile="WbDeprecia.ascx.vb" Inherits="WbDeprecia"   %>



<style type="text/css">
    .style1
    {
        height: 18px;
        width: 147px;
    }
    .style2
    {
        width: 147px;
    }
    .style3
    {
        width: 168px;
    }
    .style4
    {
        width: 110px;
    }
    .style5
    {
        font-size: xx-small;
    }
</style>



<P></P>
<P></P>
<P></P>
<P>
	<TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 536px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 272px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" width="536" align="left" border="0">
		<TR>
			<TD style="HEIGHT: 20px">
				<P class="PageTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; height: 24px;"
					align="center"><sub>DEPRECIACIÓN&nbsp;DE ACTIVOS</sub></P>
                <P class="PageTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
					align="center"><sup><span class="style5">(Metodo Linea Recta)</span></sup>
					<TABLE id="Table2" style="BORDER-RIGHT: royalblue thin solid; BORDER-TOP: royalblue thin solid; BORDER-LEFT: royalblue thin solid; WIDTH: 453px; BORDER-BOTTOM: royalblue thin solid; HEIGHT: 121px"
						borderColor="#003399" cellSpacing="0" cellPadding="0" width="453" bgColor="#ffff99"
						border="2">
						<TR>
							<TD style="WIDTH: 168px; HEIGHT: 18px" align="right"><asp:label id="Label9" 
                                    runat="server" Font-Names="Century Gothic" Width="65px" Font-Size="8pt"
									ForeColor="#0000C0" Font-Bold="True" Visible="False">Exportar a:</asp:label></TD>
							<TD class="style1">
                                <asp:dropdownlist id="ddlexportar" 
                                    runat="server" Font-Names="Century Gothic" Width="130px" Font-Size="8pt" 
                                    Visible="False" Height="16px"></asp:dropdownlist></TD>
							<TD style="WIDTH: 110px; HEIGHT: 18px" align="right">
                                <asp:checkbox id="chqtipo" runat="server" Font-Names="Century Gothic" 
                                    Font-Size="8pt" Text="Todos"
									Checked="True" Visible="False"></asp:checkbox>
                                </TD>
						</TR>
						<TR>
							<TD style="WIDTH: 168px; HEIGHT: 18px" align="right"><asp:label id="Label1" 
                                    runat="server" Font-Names="Century Gothic" Width="184px" Font-Size="8pt"
									Height="16px" ForeColor="#0000C0" Font-Bold="True">Fecha Contable a 
                                depreciar:</asp:label></TD>
							<TD class="style1"><asp:textbox id="TxtDate2" runat="server" 
                                    Font-Names="Century Gothic" Font-Size="8pt" 
                                    
                                    style="text-align: left; top: 210px; left: 254px; float: none; width: 135px;"></asp:textbox></TD>
							<TD style="WIDTH: 110px; HEIGHT: 18px" align="right">
                                <asp:rangevalidator id="RangeValidator5" runat="server" Font-Names="Verdana" 
                                    Font-Size="8pt" ErrorMessage="RangeValidator"
									ControlToValidate="TxtDate2" MinimumValue="01/01/2000" MaximumValue="01/01/3000" Type="Date" 
                                    Visible="False">Fecha Inválida-</asp:rangevalidator></TD>
						</TR>
						<TR>
							<TD align="right" class="style3">
                                <asp:label id="Label16" 
                                    runat="server" Font-Names="Century Gothic" Width="59px" Font-Size="8pt"
									Height="16px" ForeColor="#0000C0" Font-Bold="True" Visible="False">A:</asp:label>
                                <asp:label id="Label15" 
                                    runat="server" Font-Names="Century Gothic" Width="32px" Font-Size="8pt"
									Height="8px" ForeColor="#0000C0" Font-Bold="True" Visible="False">Fondo:</asp:label>
                                <asp:label id="Label14" runat="server" Font-Names="Century Gothic" Width="16px" Font-Size="8pt"
									Height="16px" ForeColor="#0000C0" Font-Bold="True" Visible="False">O:</asp:label>
                                <asp:label id="Label8" runat="server" Font-Names="Century Gothic" Width="42px" Font-Size="8pt"
									ForeColor="#0000C0" Font-Bold="True" Visible="False" Height="16px"> T:</asp:label></TD>
							<TD class="style2"><asp:dropdownlist id="ddloficinas" 
                                    runat="server" Font-Names="Century Gothic" Width="16px" Font-Size="8pt" 
                                    Height="16px" Visible="False"></asp:dropdownlist><asp:dropdownlist id="ddlfondos" 
                                    runat="server" Font-Names="Century Gothic" Width="16px" Font-Size="8pt" 
                                    Height="16px" Visible="False"></asp:dropdownlist>
                                <asp:checkbox id="chqfondos" 
                                    runat="server" Font-Names="Century Gothic" Width="17px" Font-Size="8pt"
									Text="Todos" Checked="True" Visible="False"></asp:checkbox>
                                <asp:dropdownlist id="ddltipo" runat="server" Font-Names="Century Gothic" 
                                    Width="16px" Font-Size="8pt" Height="16px" Visible="False"></asp:dropdownlist>
                                <asp:checkbox id="chqdepre" runat="server" 
                                    Font-Names="Century Gothic" Font-Size="8pt"
									Checked="True" Visible="False"></asp:checkbox></TD>
							<TD align="center" class="style4">
                                <asp:checkbox id="chqoficinas" runat="server" Font-Names="Century Gothic" 
                                    Width="31px" Font-Size="8pt"
									Text="Todos" Checked="True" Visible="False"></asp:checkbox>
                                </TD>
						</TR>
						</TABLE>
					<TABLE id="Table3" style="WIDTH: 453px; HEIGHT: 89px" cellSpacing="0" cellPadding="0" width="453"
						align="center" border="0">
						<TR>
							<TD style="WIDTH: 165px" align="center">
								<TABLE id="Table4" style="WIDTH: 455px; HEIGHT: 68px" cellSpacing="0" cellPadding="0" width="455"
									border="0">
									<TR>
										<TD align="center">
                                            <INPUT id="btnprint" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: none; WIDTH: 86px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 50px; BACKGROUND-COLOR: transparent; font-size: xx-small; font-weight: 700; font-family: 'gill Sans MT';"
												type="button" name="btnprint" runat="server" value="DEPRECIAR" ></TD>
									</TR>
								</TABLE>
							</TD>
						</TR>
					</TABLE>
				</P>
			</TD>
		</TR>
	</TABLE>
</P>
<P>&nbsp;</P>
