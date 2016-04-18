<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbUCPagoRefG.ascx.vb" Inherits="controles_Creditos_WbUCPagoRefG" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>
<style type="text/css">
    .style8
    {
        width: 141px;
    }
    .style15
    {
        width: 60%;
    }
    .style16
    {
        width: 89%;
        height: 39px;
    }
    .style18
    {
        width: 93%;
    }
    .style19
    {
        width: 91px;
    }
    .style20
    {
        width: 146px;
    }
    .style21
    {
        width: 68px;
    }
    .style22
    {
        width: 110px;
    }
    .style23
    {
        width: 87%;
        height: 24px;
    }
    .style24
    {
        width: 130px;
    }
    .style25
    {
        height: 176px;
    }
    .style27
    {
        width: 90px;
    }
    .style28
    {
        height: 19px;
    }
    .style29
    {
        width: 90px;
        height: 28px;
    }
    .style30
    {
        height: 28px;
    }
</style>
<table cellpadding="0" cellspacing="0" class="style15" 
    
    style="border: thin solid highlight; WIDTH: 674px; HEIGHT: 345px; BACKGROUND-COLOR: #ffffff">
    <tr>
        <td align="center" 
            style="font-family: Gill Sans MT; font-size: large; color: #003366; font-weight: bold;">
            ABC GRUPOS SOLIDARIOS</tr>
    <tr>
        <td>
            <table cellpadding="0" cellspacing="0" class="style16">
                <tr>
                    <td class="style29">
                        <asp:label id="Label12" Font-Size="10pt" Width="143px" 
                        Font-Names="Gill Sans MT" runat="server" Height="16px" Font-Bold="True" 
                            ForeColor="#003366">Codigo Grupo:</asp:label>
                    </td>
                    <td align="left" class="style30">
                        <asp:textbox id="txtccodcli" Font-Size="8pt" Width="150px" 
                            Font-Names="Gill Sans MT" runat="server"
						Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td class="style27">
                        <asp:label id="Label6" Font-Size="10pt" Width="154px" 
                        Font-Names="Gill Sans MT" runat="server" Height="16px" Font-Bold="True" 
                            ForeColor="#003366">Grupo Solidario:</asp:label>
                    </td>
                    <td align="left">
                        <asp:textbox id="txtcnomcli" Font-Size="8pt" Width="321px" Font-Names="Gill Sans MT" runat="server"
						Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style28">
                            &nbsp;</td>
    </tr>
    <tr>
        <td class="style25" align="center">
                <asp:GridView ID="Grid_Grupo" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="651px">
                    <Columns>                                               
                        <asp:BoundField DataField="ccodcta" HeaderText="Codigo de Prestamo">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnomcli" HeaderText="Nombre del Cliente">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnudoci" HeaderText="No CURP" >
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>                        
                        <asp:BoundField DataField="id_ife" HeaderText="No IFE" >
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>                        
                        <asp:BoundField DataField="dfecvig" HeaderText="Apertura" DataFormatString="{0:dd-MM-yyyy}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right"  />
                        </asp:BoundField>                        
                        <asp:BoundField DataField="ncapdes" HeaderText="Monto">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right"  />
                        </asp:BoundField>                        
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
		    </td>
    </tr>
    <tr>
        <td style="text-align: center">
                                                                                                    <asp:Button ID="btnImprime" runat="server" Enabled="False" 
                            Font-Bold="True" 
                                                                                                        
                            Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                            TabIndex="22" 
                                                                                                        
                            Text="Re-Impre Orden-Referencia" Width="145px" />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
</table>

