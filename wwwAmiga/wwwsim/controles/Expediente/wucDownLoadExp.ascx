<%@ Control Language="VB" AutoEventWireup="false" CodeFile="wucDownLoadExp.ascx.vb" Inherits="controles_wucDownLoadExp" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <TABLE id="Table1" style="WIDTH: 504px; HEIGHT: 303px" cellSpacing="0" cellPadding="0"
	width="504" border="0">
            <TR>
                <TD align="center">
                    &nbsp;</TD>
            </TR>
            <tr>
                <td align="center">
                </td>
            </tr>
            <TR>
                <TD align="center">
                    <TABLE id="Table8" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 466px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 246px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="466" border="0">
                        <TR>
                            <TD style="HEIGHT: 33px" align="center">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:label id="Label3" runat="server" Width="251px" Font-Bold="True" 
                            Font-Size="Medium" Height="15px"
							Font-Names="Verdana" ForeColor="#16387C">Descargar Expediente</asp:label>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 22px" align="center">
                                <TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
                                    <TR>
                                        <TD style="WIDTH: 143px" align="right">
                                            &nbsp;</TD>
                                        <TD>
                                            &nbsp;</TD>
                                    </TR>
                                </TABLE>
                                <asp:textbox id="txtccodcli" runat="server" Width="21px" Visible="False"></asp:textbox>
                                <asp:textbox id="txtcnomcli" 
                            runat="server" Width="338px" Font-Names="Garamond" ForeColor="Maroon"
							BorderWidth="2px" ReadOnly="True"></asp:textbox>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 15px" align="center">
                                <br />
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 20px" align="center">
                                <asp:Label ID="lblStatus" runat="server" Text="Label" Font-Names="Calibri" 
                                    Font-Size="9pt"></asp:Label>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 41px" align="center">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                            ID="btnGen" runat="server" Font-Bold="True" 
                            Font-Names="Calibri" Font-Size="11pt" Text="Descargar" Width="100px" />
                                &nbsp;&nbsp;</TD>
                        </TR>
                        <TR>
                            <TD align="center">
                                &nbsp;</TD>
                        </TR>
                    </TABLE>
                    &nbsp;&nbsp;&nbsp;</TD>
            </TR>
            <TR>
                <TD>
                </TD>
            </TR>
        </TABLE>
    </ContentTemplate>
    <Triggers>
                            <asp:PostBackTrigger  ControlID="btnGen"  />
     </Triggers>
</asp:UpdatePanel>