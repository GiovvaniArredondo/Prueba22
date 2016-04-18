<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucColectorMulti" CodeFile="ucColectorMulti.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<TABLE id="Table8" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 440px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 200px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="440" border="0" DESIGNTIMEDRAGDROP="9">
	<TR>
		<TD style="HEIGHT: 33px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:label id="Label1" runat="server" Width="278px" Font-Bold="True" Font-Size="Medium" Height="15px"
				Font-Names="Gill Sans MT" ForeColor="#16387C">EMISION DE CARNETS MULTIPLES</asp:label>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </TD>
	</TR>
	<TR>
		<TD align="center" style="HEIGHT: 28px">
			<DIV id="DIV8" style="DISPLAY: inline; FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 91px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 11px"
				runat="server">
									<asp:label id="Label2" runat="server" Width="99px" 
                    Font-Size="X-Small" Font-Names="Gill Sans MT" Height="16px">ANALISTA:</asp:label>
			</DIV>
			<SELECT id="cbxanacre" style="FONT-SIZE: 12px; WIDTH: 309px; FONT-FAMILY: 'Gill Sans MT'" name="cbxanacre"
				runat="server">
				<OPTION selected></OPTION>
			</SELECT>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 19px" align="center">&nbsp;&nbsp;&nbsp;&nbsp;
			<TABLE id="Table1" style="WIDTH: 371px; HEIGHT: 33px" cellSpacing="1" cellPadding="1" width="371"
				border="0">
				<TR>
					<TD style="WIDTH: 98px" align="right">
						<DIV id="Div1" style="DISPLAY: inline; FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 56px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 20px"
							runat="server">
							<P>
									<asp:label id="Label3" runat="server" Width="61px" Font-Size="12pt" 
                                    Font-Names="Gill Sans MT" Height="16px">Desde:</asp:label></P>
						</DIV>
					</TD>
					<TD style="WIDTH: 77px">
						<asp:textbox id="txtFecini" runat="server" Width="94px" Font-Size="10pt" Font-Names="Gill Sans MT"
							BorderWidth="1px"></asp:textbox>
                        <cc1:MaskedEditExtender ID="txtFecini_MaskedEditExtender" runat="server" 
                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtFecini">
                        </cc1:MaskedEditExtender>
                    </TD>
					<TD style="WIDTH: 66px" align="right">
						<DIV id="Div2" style="DISPLAY: inline; FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 48px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 19px"
							runat="server">
							<P>
									<asp:label id="Label4" runat="server" Width="38px" Font-Size="12pt" 
                                    Font-Names="Gill Sans MT" Height="16px">Hasta:</asp:label></P>
						</DIV>
					</TD>
					<TD>
						<asp:textbox id="txtfecfin" runat="server" Width="94px" Font-Size="10pt" Font-Names="Gill Sans MT"
							BorderWidth="1px"></asp:textbox>
                        <cc1:MaskedEditExtender ID="txtfecfin_MaskedEditExtender" runat="server" 
                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecfin">
                        </cc1:MaskedEditExtender>
                    </TD>
				</TR>
			</TABLE>
			<asp:rangevalidator id="Rangevalidator6" DESIGNTIMEDRAGDROP="1491" runat="server" Font-Size="8pt" Font-Names="Gill Sans MT"
				Type="Date" MaximumValue="01/01/3000" MinimumValue="01/01/2000" ControlToValidate="txtfecini" ErrorMessage="RangeValidator">Fecha Desde Inválida-</asp:rangevalidator>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:rangevalidator id="Rangevalidator1" DESIGNTIMEDRAGDROP="1491" runat="server" Font-Size="8pt" Font-Names="Gill Sans MT"
				Type="Date" MaximumValue="01/01/3000" MinimumValue="01/01/2000" ControlToValidate="txtfecfin" ErrorMessage="RangeValidator">Fecha Hasta Inválida-</asp:rangevalidator>
		</TD>
	</TR>
	<TR>
		<TD align="center"><INPUT id="btnAplicar" style="BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
				type="button" name="btnAplicar" runat="server"></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
