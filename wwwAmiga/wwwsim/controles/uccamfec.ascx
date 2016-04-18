<%@ Control Language="vb" AutoEventWireup="false" Inherits="uccamfec" CodeFile="uccamfec.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        height: 27px;
    }
</style>
<TABLE id="Table3" style="WIDTH: 568px; HEIGHT: 256px" cellSpacing="0" cellPadding="0"
	width="568" align="left" border="0">
	<TR>
		<TD align="center">
			<asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <TABLE id="Table1" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 248px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 176px; BACKGROUND-COLOR: #ffffff; border-color: #003366;"
				cellSpacing="0" cellPadding="0" width="248" align="center" border="0">
                        <TR>
                            <TD align="center">
                                <P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
							align="center">
                                    CIERRE DIARIO</P>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 86px">
                                <TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
                                    <TR>
                                        <TD style="WIDTH: 126px" align="right">
                                            <asp:label id="Label4" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                        runat="server"></asp:label>
                                        </TD>
                                        <TD>
                                            &nbsp;</TD>
                                    </TR>
                                    <TR>
                                        <TD style="WIDTH: 126px" align="right">
                                            <asp:label id="Label2" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                        runat="server" Width="116px">Fecha Anterior:</asp:label>
                                        </TD>
                                        <TD>
                                            <asp:textbox id="txtfecant" Font-Names="Gill Sans MT" runat="server" 
                                        Width="80px" BorderWidth="1px"
										Enabled="False"></asp:textbox>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD style="WIDTH: 126px" align="right">
                                            <asp:label id="Label3" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                        runat="server">Nueva Fecha:</asp:label>
                                        </TD>
                                        <TD style="border-color: #009900">
                                            <asp:textbox id="txtfecvig" Font-Names="Gill Sans MT" runat="server" 
                                        Width="80px" BorderWidth="1px"
										Enabled="False"></asp:textbox>
                                        </TD>
                                    </TR>
                                </TABLE>
                            </TD>
                        </TR>
                        <TR>
                            <TD align="center">
                                <asp:ImageButton ID="ImageButton1" runat="server" 
                            ImageUrl="~/web/jpgs/btn_guardar2_b.gif" />
                                <cc1:ConfirmButtonExtender ID="ImageButton1_ConfirmButtonExtender" 
                            runat="server" ConfirmText="Seguro de Cierre?" Enabled="True" 
                            TargetControlID="ImageButton1">
                                </cc1:ConfirmButtonExtender>
                            </TD>
                        </TR>
                        <TR>
                            <TD align="center" class="style1">
                                <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" 
                            Text="Actualizar Tipo Gar." Visible="False" />
                            </TD>
                        </TR>
                    </TABLE>
                </ContentTemplate>
                <Triggers>
                    <asp:PostBackTrigger ControlID="ImageButton1" />
                </Triggers>
            </asp:UpdatePanel>
		</TD>
	</TR>
</TABLE>
