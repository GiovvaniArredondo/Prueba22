<%@ control language="VB" autoeventwireup="false" inherits="controles_Creditos_WUCPromocion, App_Web_6e0px9a3" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>

<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>

<style type="text/css">
    .style1
    {
        width: 76%;
    }
    .style25
    {
        height: 446px;
        width: 728px;
    }
    .CSSTableGenerator
    {
        margin-bottom: 0px;
    }
    </style>

<script type="text/javascript">

 function SoloNumeros(evt) {
	    var charCode = (evt.which) ? evt.which : event.keyCode
	    if (charCode == 08 || charCode == 32 || charCode == 45)
            	return true;
	    else if (charCode >= 48 && charCode <= 57)
		    return true; return false;
    }

    //Esta función solo permite numeros y el punto, se invoca desde el evento onkeypress Ejemplo onkeypress="return NumCheck(event, this)"
    function NumCheck(e, field) {
        key = e.keyCode ? e.keyCode : e.which
        if (key == 8 || key == 9 || key == 127)
            return true;
        else if (key > 47 && key < 58) {
            var cad = field.value;
            if (cad.indexOf(".") != -1) {
                regexp = /.[0-9]{2}$/
                return !(regexp.test(field.value))
            }
            return true
        }
        else if (key == 46) {
            if (field.value == "") return false
            regexp = /^[0-9]+$/
            return regexp.test(field.value)
        }
        return false
    }
    
</script>

<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <fieldset id="Catalogo">
                    <legend>
                           <asp:Label ID="Label1" runat="server" Text="Promoción de Creditos" 
                            Font-Bold="True" Font-Names="Calibri" Font-Size="10pt"></asp:Label></legend>



                        <table cellpadding="0" cellspacing="0" class="style25">
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style1">
                                        <tr>
                                            <td style="text-align: right">
                                                <asp:Label ID="lblUsuario82" Runat="server" Font-Names="calibri" 
                                                    Font-Size="11pt" style="text-align: left" Width="100px">Sucursal:</asp:Label>
                                            </td>
                                            <td>
                                                <cc1:CbxOficinas ID="CbxOficinas1" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Width="300px">
                                                </cc1:CbxOficinas>
                                            </td>
                                            <td>
                                                <asp:Button ID="btnCargar" runat="server" CssClass="TestStyle" 
                                                    Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                                                    Text="Filtrar" Width="120px" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridPromocion" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" CssClass="grid" Width="956px">
                                        <Columns>                                           
                                            <asp:BoundField DataField="ccodcli" HeaderText="CODIGO">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="70px" />
                                                <ItemStyle Font-Names="Gill Sans MT" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="CNOMCLI" HeaderText="NOMBRE DEL CLIENTE" 
                                                ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="200px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="CNUDOCI" HeaderText="No CURP">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="center"/>
                                            </asp:BoundField>
                                            <asp:BoundField DataField="cteldom" HeaderText="TELEFONO">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="90px" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="center"/>
                                            </asp:BoundField>                                                                                                           
                                            <asp:BoundField DataField="ctelfam" HeaderText="CELULAR">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="90px" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="center"/>
                                            </asp:BoundField>                                                                                                           
                                            <asp:BoundField DataField="cdirdom" HeaderText="DIRECCION">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="250px" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="left"/>
                                            </asp:BoundField>                                                                                                           
                                        </Columns>
                                        <PagerTemplate>
                                            Página
                                            <asp:DropDownList ID="paginasDropDownList" runat="server" AutoPostBack="true" 
                                                Font-Size="12px">
                                            </asp:DropDownList>
                                            de
                                            <asp:Label ID="lblTotalNumberOfPages" runat="server" />
                                            <asp:Button ID="Button4" runat="server" CommandArgument="First" 
                                                CommandName="Page" CssClass="pagfirst" ToolTip="Prim. Pag" />
                                            <asp:Button ID="Button5" runat="server" CommandArgument="Prev" 
                                                CommandName="Page" CssClass="pagprev" ToolTip="Pág. anterior" />
                                            <asp:Button ID="Button2" runat="server" CommandArgument="Next" 
                                                CommandName="Page" CssClass="pagnext" ToolTip="Sig. página" />
                                            <asp:Button ID="Button3" runat="server" CommandArgument="Last" 
                                                CommandName="Page" CssClass="paglast" ToolTip="Últ. Pag" />
                                        </PagerTemplate>
                                        <PagerStyle CssClass="pagerstyle" />
                                        <AlternatingRowStyle BackColor="#99CCFF" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Button ID="btnPrint" runat="server" CssClass="TestStyle" Enabled="False" 
                                        Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                                        Text="Imprimir" Width="120px" Visible="False" />
                                </td>
                            </tr>
                        </table>



                </fieldset>    
                </ContentTemplate>
                    <Triggers>                        
                        <asp:PostBackTrigger ControlID="btnPrint" />
                    </Triggers>
                </asp:UpdatePanel>
        </td>
    </tr>
</table>
