<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbRechazarI.ascx.vb" Inherits="WbRechazarI" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<script language="javascript" type="text/javascript">
// <!CDATA[



// ]]>
</script>





<style type="text/css">

    .style8
    {
        width: 70%;
    }
    .style9
    {
        width: 619px;
    }
    .style10
    {
        width: 90%;
        height: 177px;
    }
    .style11
    {
        width: 146px;
    }
    .style12
    {
        width: 146px;
        height: 18px;
    }
    .style13
    {
        height: 18px;
    }
    .style14
    {
        width: 619px;
        height: 184px;
    }
</style>



<table cellpadding="0" cellspacing="0" class="style8" 
    
    style="border: thin solid highlight; WIDTH: 525px; HEIGHT: 287px; BACKGROUND-COLOR: #ffffff">
    <tr>
        <td align="center" class="style9" 
            style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'">
                                                RECHAZO DE CLIENTES</td>
    </tr>
    <tr>
        <td class="style14">
            <table cellpadding="0" cellspacing="0" class="style10">
                <tr>
                    <td class="style12">
                        <asp:label id="Label9" Font-Size="8pt" Width="120px" Font-Names="Verdana" 
                            runat="server">Codigo del Cliente:</asp:label>
                    </td>
                    <td class="style13">
                        <INPUT id="txtcodcli" style="FONT-SIZE: 12px; WIDTH: 130px; FONT-FAMILY: 'Verdana'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtcodcli" runat="server"></td>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:label id="Label10" Font-Size="8pt" Width="120px" Font-Names="Verdana" 
                            runat="server">Nombre del Cliente:</asp:label>
                    </td>
                    <td>
                        <asp:textbox id="txtcnomcli" Font-Size="8pt" Width="299px" Font-Names="Verdana" runat="server"
									Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:label id="Label12" Font-Size="8pt" Width="134px" Font-Names="Verdana" 
                            runat="server">Causa de Rechazo:</asp:label>
                    </td>
                    <td>
                                        <asp:DropDownList ID="ddlcausa" runat="server" BackColor="#A8C5FF" 
                                            Font-Names="Verdana" Font-Size="8pt" ForeColor="#000066" 
                            Height="97px" Width="373px">
                                        </asp:DropDownList>
                                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style9" align="center">
            <asp:Button ID="Button1" runat="server" Font-Names="Verdana" Height="30px" 
                Text="Grabar" Width="94px" />
            <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
                ConfirmText="Esta Seguro de Rechazar?" Enabled="True" TargetControlID="Button1">
            </cc1:ConfirmButtonExtender>
        </td>
    </tr>
    </table>

<P>&nbsp;</P>
