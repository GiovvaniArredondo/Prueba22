<%@ control language="VB" autoeventwireup="false" inherits="CuwRepRechazo, App_Web_yl8dokps" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style6
    {
        width: 38%;
        height: 279px;
    }
    .style7
    {
        width: 69%;
    }
    .style8
    {
        width: 47%;
    }
</style>
<head id="Head1" runat="server" />
<table border="1" cellpadding="0" cellspacing="0" class="style8" 
    style="border-color: #003366; height: 326px;">
    <tr>
        <td>
<table align="center" cellpadding="0" cellspacing="0" class="style6" border="0">
    <tr>
        <td>
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                    </td>
    </tr>
    <tr>
        <td align="center" 
            style="font-family: Georgia; font-size: 16px; font-weight: bold; color: #000066;">
                        REPORTE DE CLIENTES&nbsp; Y CREDITOS RECHAZADOS</td>
    </tr>
    <tr>
        <td>
                        &nbsp;</td>
    </tr>
    <tr>
        <td>
													<TABLE id="Table11" 
                            style="WIDTH: 317px; HEIGHT: 106px" cellSpacing="0" cellPadding="0"
														width="317" border="0" align="center">
														<TR>
															<TD style="WIDTH: 32px" align="right"><asp:label id="Label2" runat="server" Font-Names="Century Gothic" Width="17px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Desde:</asp:label></TD>
															<TD style="WIDTH: 231px"><asp:textbox id="TxtDate1" runat="server" Font-Names="Verdana" Width="116px" BackColor="White"></asp:textbox>
                                                                <cc1:CalendarExtender ID="TxtDate1_CalendarExtender" runat="server" 
                                                                    Format="dd/MM/yyyy" TargetControlID="TxtDate1">
                                                                </cc1:CalendarExtender>
                                                            </TD>
															<TD style="WIDTH: 36px">
																<P style="FONT-WEIGHT: bold; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"><asp:rangevalidator id="RangeValidator1" runat="server" Font-Names="Century Gothic" Width="112px" Font-Size="8pt"
																		Font-Bold="True" BackColor="AliceBlue" MinimumValue="01/01/1900" MaximumValue="01/01/2999" Type="Date" ControlToValidate="TxtDate1" ErrorMessage="RangeValidator">Fecha Invalida</asp:rangevalidator></P>
															</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 32px" align="left"><asp:label id="Label3" runat="server" Font-Names="Century Gothic" Width="36px" Font-Size="8pt"
																	ForeColor="#0000C0" Font-Bold="True">Hasta:</asp:label></TD>
															<TD style="WIDTH: 231px"><asp:textbox id="TxtDate2" runat="server" Font-Names="Verdana" Width="115px" BackColor="White"></asp:textbox></TD>
															<TD style="WIDTH: 36px"><asp:rangevalidator id="RangeValidator2" runat="server" Font-Names="Century Gothic" Width="111px" Font-Size="8pt"
																	Font-Bold="True" BackColor="AliceBlue" MinimumValue="01/01/1900" MaximumValue="01/01/2999" Type="Date" ControlToValidate="TxtDate2"
																	ErrorMessage="RangeValidator">Fecha Invalida</asp:rangevalidator></TD>
														</TR>
														</TABLE>
                    </td>
    </tr>
    <tr>
        <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style7">
                <tr>
                    <td align="center">
                        <asp:Button ID="Button2" runat="server" Font-Names="Calibri" Text="Clientes" 
                            Height="24px" Width="100px" />
                    </td>
                    <td align="center">
                        <asp:Button ID="Button3" runat="server" Font-Names="Calibri" Text="Solicitudes" 
                            Height="24px" Width="100px" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
</table>

        </td>
    </tr>
</table>


