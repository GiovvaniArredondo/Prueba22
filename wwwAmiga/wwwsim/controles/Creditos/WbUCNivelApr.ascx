<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbUCNivelApr.ascx.vb" Inherits="controles_creditos_WbUCNivelApr" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>

<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>

<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style25
    {
        height: 38px;
        width: 728px;
    }
    .style27
    {
        height: 30px;
    }
    .style28
    {
        height: 33px;
    }
    .CSSTableGenerator
    {
        margin-bottom: 0px;
    }
    .style29
    {
        height: 27px;
    }
    .style30
    {
        height: 38px;
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
                           <asp:Label ID="Label1" runat="server" Text="Mantenimiento Niveles de Aprobación" 
                            Font-Bold="True" Font-Names="Calibri" Font-Size="10pt"></asp:Label></legend>



                        <table cellpadding="0" cellspacing="0" class="style25">
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridNiveles" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" CssClass="grid" Width="730px">
                                        <Columns>
                                            <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                                <ControlStyle Font-Names="Gill Sans MT" Font-Size="9pt" />
                                                <HeaderStyle BackColor="#99CCFF" />
                                            </asp:CommandField>
                                            <asp:BoundField DataField="CODIGO_NIVEL_APROBACION" HeaderText="ID">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="70px" />
                                                <ItemStyle Font-Names="Gill Sans MT" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripción" 
                                                ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="250px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="LIMITE_INFERIOR" HeaderText="Desde">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="right"/>
                                            </asp:BoundField>
                                            <asp:BoundField DataField="LIMITE_SUPERIOR" HeaderText="Hasta">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="right"/>
                                            </asp:BoundField>                                           
                                             <asp:BoundField DataField="OBSERVACIONES" HeaderText="Observaciones">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="350px" />
                                                <ItemStyle Font-Names="Gill Sans MT" />
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
                                    <table cellpadding="0" cellspacing="0" class="style25">
                                        <tr>
                                            <td class="style27" style="text-align: center">
                                                <asp:Label ID="lblUsuario32" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Id : </asp:Label>
                                            </td>
                                            <td class="style27">
                                                <asp:TextBox ID="TxtId" runat="server" AutoPostBack="True" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="20px" 
                                                    style="text-align: left" TabIndex="1" Width="150px">0</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style30" style="text-align: center">
                                                <asp:Label ID="lblUsuario46" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Descripción :</asp:Label>
                                            </td>
                                            <td class="style30">
                                                <asp:TextBox ID="Txtcdescri" runat="server" AutoPostBack="True" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="20px" TabIndex="2" Width="350px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style28" style="text-align: center">
                                                <asp:Label ID="lblUsuario33" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Limite Inferior :</asp:Label>
                                            </td>
                                            <td class="style28">
                                                <asp:TextBox ID="TxtnDesde" runat="server" AutoPostBack="True" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="20px" style="text-align: left" TabIndex="3" 
                                                    Width="150px" onkeypress="return NumCheck(event, this)">0</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: center" class="style29">
                                                <asp:Label ID="lblUsuario43" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Limite Superior :</asp:Label>
                                            </td>
                                            <td class="style29">
                                                <asp:TextBox ID="TxtnHasta" runat="server" BorderColor="#2E6A99" 
                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="20px" style="text-align: left" TabIndex="4" Width="150px" 
                                                    onkeypress="return NumCheck(event, this)">0</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style27" style="text-align: center">
                                                <asp:Label ID="lblUsuario47" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Observaciones :</asp:Label>
                                            </td>
                                            <td class="style27">
                                                <asp:TextBox ID="TxtcObserva" runat="server" AutoPostBack="True" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="40px" MaxLength="250" TabIndex="5" TextMode="MultiLine" 
                                                    Width="350px"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style25">
                                        <tr>
                                            <td style="text-align: center">
                                                <asp:Button ID="btnnew" runat="server" CssClass="TestStyle" Font-Bold="True" 
                                                    Font-Names="Calibri" Font-Size="9pt" Height="27px" Text="Nuevo" Width="120px" />
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button ID="btnCancel" runat="server" CssClass="TestStyle" Enabled="False" 
                                                    Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                                                    Text="Cancelar" Width="120px" />
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button ID="btnEdit" runat="server" CssClass="TestStyle" Enabled="False" 
                                                    Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                                                    Text="Editar" Width="120px" />
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button ID="Btnsave" runat="server" CssClass="TestStyle" Enabled="False" 
                                                    Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                                                    TabIndex="8" Text="Actualizar" Width="120px" />
                                                <cc2:ConfirmButtonExtender ID="Confirm_BtnExt1" runat="server" 
                                                    ConfirmText="Realmente Desea Guardar los cambios" Enabled="True" 
                                                    TargetControlID="Btnsave">
                                                </cc2:ConfirmButtonExtender>
                                            </td>
                                            <td style="text-align: center">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>



                </fieldset>    
                </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnsave" EventName="Click" />
                        <asp:AsyncPostBackTrigger ControlID="btnnew" EventName="Click" />                                                
                        <asp:AsyncPostBackTrigger ControlID="btnCancel" EventName="Click" />                                                                      
                        
                    </Triggers>
                </asp:UpdatePanel>
        </td>
    </tr>
</table>
