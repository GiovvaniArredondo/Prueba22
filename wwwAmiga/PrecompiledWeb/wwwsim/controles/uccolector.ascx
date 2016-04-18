<%@ control language="vb" autoeventwireup="false" inherits="uccolector, App_Web_yl8dokps" %>
<HEAD>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</HEAD>
<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <TABLE id="Table1" cellSpacing="0" cellPadding="0" width="400" border="0" 
    style="WIDTH: 400px; HEIGHT: 248px">
                        <TR>
                            <TD>
                                <TABLE id="Table8" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 433px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 256px; BACKGROUND-COLOR: #ffffff"
				cellSpacing="0" cellPadding="0" width="433" border="0" DESIGNTIMEDRAGDROP="9">
                                    <TR>
                                        <TD style="HEIGHT: 33px" align="center">
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:label id="Label1" runat="server" Width="278px" Font-Bold="True" 
                            Font-Size="Medium" Height="15px"
							Font-Names="Gill Sans MT" ForeColor="#16387C">EMISION DE CARNET</asp:label>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD align="center">
                                            <TABLE id="Table2" style="WIDTH: 392px; HEIGHT: 76px" cellSpacing="0" 
                            cellPadding="0" width="392"
							border="0">
                                                <TR>
                                                    <TD style="WIDTH: 256px; HEIGHT: 19px" align="right">
                                                        <asp:label id="Label2" runat="server" Width="128px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT">CREDITO Nº:</asp:label>
                                                    </TD>
                                                    <TD style="HEIGHT: 19px">
                                                        <asp:textbox id="txtcredito" runat="server" Width="192px" Font-Size="10pt" Font-Names="Gill Sans MT"
										ReadOnly="True" Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                                    </TD>
                                                </TR>
                                                <TR>
                                                    <TD style="WIDTH: 256px" align="right">
                                                        <asp:label id="Label3" runat="server" Width="125px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT">NOMBRE:</asp:label>
                                                    </TD>
                                                    <TD>
                                                        <asp:textbox id="txtnombre" runat="server" Width="256px" Font-Size="10pt" Font-Names="Gill Sans MT"
										ReadOnly="True" Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                                    </TD>
                                                </TR>
                                                <TR>
                                                    <TD style="WIDTH: 256px" align="right">
                                                        <asp:label id="Label4" runat="server" Width="131px" Font-Size="10pt" 
                                        Font-Names="Gill Sans MT">CUOTA:</asp:label>
                                                    </TD>
                                                    <TD>
                                                        <asp:textbox id="txtcuota" runat="server" Width="96px" Font-Size="10pt" Font-Names="Gill Sans MT"
										ReadOnly="True" Enabled="False" BorderColor="#2E6A99" BorderWidth="1px"></asp:textbox>
                                                    </TD>
                                                </TR>
                                            </TABLE>
                                            <asp:textbox id="txtdfecvig" Font-Names="Gill Sans MT" Font-Size="X-Small" 
                            Width="62px" runat="server"
							Visible="False"></asp:textbox>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD style="HEIGHT: 19px">
                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:label id="label_mensaje" runat="server" Width="392px" Font-Size="8pt" 
                            Height="15px" Font-Names="Gill Sans MT"
							ForeColor="Red"></asp:label>
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD align="center">
                                            <asp:Button ID="btnImprime" runat="server" Enabled="False" 
                            Font-Bold="True" 
                                                                                                        
                            Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                            TabIndex="22" 
                                                                                                        
                            Text="Generar" Width="145px" />
                                        </TD>
                                    </TR>
                                    <TR>
                                        <TD>
                                            <asp:HiddenField ID="HiddenField2" runat="server" />
                                            <asp:HiddenField ID="HiddenField1" runat="server" />
                                        </TD>
                                    </TR>
                                </TABLE>
                            </TD>
                        </TR>
                    </TABLE>
                </ContentTemplate>
                <Triggers>                    
                    <asp:PostBackTrigger ControlID="btnImprime" />
                </Triggers>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>
<SCRIPT language="JavaScript">
 function aplicar()
 {
 if(confirm("¿Esta seguro de continuar?"))
   alert("ok");
  else
   alert("proceso no completado");
 }
</SCRIPT>
