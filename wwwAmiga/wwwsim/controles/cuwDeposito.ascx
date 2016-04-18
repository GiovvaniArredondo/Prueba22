<%@ Control Language="vb" AutoEventWireup="false" Inherits="cuwDeposito" CodeFile="cuwDeposito.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
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

<style type="text/css">
    .style1
    {
        width: 92%;
        height: 107px;
    }
    .style2
    {
        width: 166px;
    }
</style>
<head id="Head1" runat="server" />
<TABLE id="Table8" style="border: thin solid highlight; WIDTH: 549px; HEIGHT: 275px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" border="0" DESIGNTIMEDRAGDROP="9">
	<TR>
		<TD style="HEIGHT: 33px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:label id="Label1" runat="server" Width="278px" Font-Bold="True" Font-Size="Medium" Height="15px"
				Font-Names="Verdana" ForeColor="#16387C">DEPOSITOS DEL DIA</asp:label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="right">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table 
                cellpadding="0" cellspacing="0" class="style1" align="center">
                <tr>
                    <td class="style2" align="right">
                        <asp:Label ID="Label2" runat="server" Font-Names="Gill Sans MT" Text="Fecha:"></asp:Label>
                    </td>
                    <td>
                        <asp:textbox id="Txtdfecha" runat="server" Font-Names="Gill Sans MT" Width="116px" 
                            BackColor="White" Enabled="False"></asp:textbox>
                                                                <cc1:MaskedEditExtender ID="Txtdfecha_MaskedEditExtender" runat="server" 
                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="Txtdfecha">
                        </cc1:MaskedEditExtender>
                                                                <cc1:CalendarExtender ID="Txtdfecha_CalendarExtender" runat="server" 
                                                                    Format="dd/MM/yyyy" 
                            TargetControlID="Txtdfecha">
                                                                </cc1:CalendarExtender>
                                                            </td>
                </tr>
                <tr>
                    <td class="style2" align="right">
                        <asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" 
                            Text="Monto a Depositar:" Width="140px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtnsalini" runat="server" Font-Names="Gill Sans MT" onkeypress="return SoloNumeros(event)"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2" align="right">
                        <asp:Label ID="Label5" runat="server" Font-Names="Gill Sans MT" 
                            Text="Banco:" Width="140px"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="cmbBancos" runat="server" BackColor="#FFFF66" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="26px" Width="300px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style2" align="right">
                        <asp:Label ID="Label6" runat="server" Font-Names="Gill Sans MT" 
                            Text="Nº Boleta:" Width="140px"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBoleta" runat="server" 
                            Font-Names="Gill Sans MT" Width="104px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2" align="right">
                        <asp:Label ID="Label4" runat="server" Font-Names="Gill Sans MT" Text="Cajero:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtccajero" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Width="334px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center">
            &nbsp;</TD>
	</TR>
	<TR>
		<TD align="center">
            <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" Text="Depositar" 
                Width="104px" />
        </TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
