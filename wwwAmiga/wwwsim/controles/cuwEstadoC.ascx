<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="cuwEstadoC" CodeFile="cuwEstadoC.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<HEAD runat =server >


    <style type="text/css">
        .style1
        {
            width: 77%;
            height: 83px;
        }
        .style2
        {
            width: 231px;
        }
        .style4
        {
            height: 19px;
            width: 442px;
            margin-left: 40px;
        }
        #Table1
        {
            height: 409px;
            width: 86%;
        }
        .style14
        {
            width: 82%;
            height: 213px;
        }
        .style15
        {
            width: 82%;
            height: 68px;
        }
        .style17
        {
            height: 38px;
        }
        .style18
        {
            width: 236px;
        }
        .style22
        {
            width: 33%;
        }
        .style24
        {
            width: 66%;
        }
        .style25
        {
            height: 291px;
        }
        </style>
</HEAD>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<SCRIPT language="JavaScript">
 function aplicar()
 {
 if(confirm("¿Esta seguro de continuar?"))
   alert("ok");
  else
   alert("proceso no completado");
 }
</SCRIPT>
<table border="1" cellpadding="0" cellspacing="0" class="style24" 
    style="border-width: 2px; border-color: #000099; OVERFLOW: visible; WIDTH: 431px; HEIGHT: 293px">
    <tr>
        <td class="style25">
            <table cellpadding="0" cellspacing="0" class="style14" align="center">
                <tr>
                    <td align="center" class="style17">
						<asp:label id="Label3" runat="server" Width="368px" Font-Bold="True" 
                            Font-Size="Medium" Height="15px"
							Font-Names="Century Gothic" ForeColor="#16387C" BackColor="Yellow" BorderWidth="2px">Estado 
                        del Centro</asp:label>
                        </td>
                </tr>
                <tr>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td align="right" class="style2">
                        <asp:label id="Label7" Font-Size="10pt" Width="63px" Font-Names="Century Gothic" 
                            runat="server">Centro:</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtcentro" runat="server" Enabled="False" 
                                        Font-Names="Century Gothic" Font-Size="8pt" Height="20px" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style2">
						<asp:label id="Label39" runat="server" Width="195px" Font-Size="X-Small" Height="15px" 
                                        Font-Names="Century Gothic">Fecha:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtfecbar" tabIndex="5" runat="server" Width="83px" 
                                        Font-Size="X-Small" Font-Names="Century Gothic"
							BorderWidth="1px"></asp:textbox>
                                    <cc1:CalendarExtender ID="txtfecbar_CalendarExtender" runat="server" 
                                        TargetControlID="txtfecbar" Format="dd/MM/yyyy">
                                    </cc1:CalendarExtender>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="style2">
                                    <asp:label id="label_mensaje" runat="server" Width="184px" Font-Size="8pt" Height="15px" Font-Names="Verdana"
							ForeColor="Red"></asp:label>
                                </td>
                                <td>
                                    <asp:rangevalidator id="RangeValidator5" runat="server" Width="88px" Font-Size="8pt" Font-Names="Verdana"
							DESIGNTIMEDRAGDROP="1491" MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" ErrorMessage="RangeValidator" ControlToValidate="txtfecbar">Fecha 
                                    Inválida-</asp:rangevalidator>
                                 
                                  
                                </td>
                            </tr>
                            </table>
                    </td>
                </tr>
                <tr>
					<TD align="center" class="style4">
                        &nbsp;</TD>
				</tr>
                <tr>
                    <td>
                        <table align="center" cellpadding="0" cellspacing="0" class="style15">
                            <tr>
                                <td align="right" class="style18">
                                    <table cellpadding="0" cellspacing="0" class="style22">
                                        <tr>
                                            <td>
                                     <INPUT id="btnRecibo" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/fileprint.gif); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: #ffffff"
				           type="button" name="Button3" runat="server"></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtcCodsol" runat="server" Visible="False" Height="16px" 
                            Width="61px"></asp:TextBox>
                        <asp:TextBox ID="txtccomodin" runat="server" Height="19px" Visible="False" 
                            Width="53px"></asp:TextBox>
                        <asp:TextBox ID="txtflag" runat="server" Height="19px" Visible="False" 
                            Width="53px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

