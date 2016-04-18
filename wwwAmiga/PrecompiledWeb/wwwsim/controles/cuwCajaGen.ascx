<%@ control language="vb" autoeventwireup="false" inherits="cuwCajaGen, App_Web_mb_xwoah" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<script type="text/javascript">
  


   </script>

<style type="text/css">
    .style1
    {
        width: 84%;
        height: 40px;
    }
    .style3
    {
        height: 58px;
    }
</style>
<head id="Head1" runat="server" />
<TABLE id="Table8" style="border: thin solid highlight; WIDTH: 534px; HEIGHT: 138px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" border="0" DESIGNTIMEDRAGDROP="9">
	<TR>
		<TD style="HEIGHT: 33px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:label id="Label1" runat="server" Width="278px" Font-Bold="True" Font-Size="Medium" Height="15px"
				Font-Names="Verdana" ForeColor="#16387C">CUADRE DEL CAJERO</asp:label></TD>
	</TR>
	<TR>
		<TD align="center" class="style3">&nbsp;
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td align="right">
                        <asp:label id="Label28" Font-Size="10pt" Font-Names="Gill Sans MT" Height="15px" Width="88px" runat="server">Fecha:</asp:label>
                    </td>
                    <td>
            <asp:textbox id="txtfecha" tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="104px"
				runat="server" BorderWidth="2px" BackColor="Yellow" BorderColor="#003366" 
                            Height="27px"></asp:textbox>
                        <cc1:MaskedEditExtender ID="txtfecha_MaskedEditExtender" runat="server" 
                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecha">
                        </cc1:MaskedEditExtender>
                        <cc1:CalendarExtender ID="txtfecha_CalendarExtender" runat="server" 
                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtfecha">
                        </cc1:CalendarExtender>
                    </td>
                    <td>
                        <asp:Button ID="btncuadre" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Text="Cuadre" Width="94px" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        &nbsp;</td>
                    <td>
                        <asp:rangevalidator id="RangeValidator5" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" Width="88px" runat="server"
				ControlToValidate="txtfecha" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000" 
                            MaximumValue="01/01/3000" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 28px" align="center">
            &nbsp;</TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
