<%@ control language="VB" autoeventwireup="false" inherits="controles_Ahorros_WbUControl_Libreta_Agencia, App_Web_kxy_ccyk" %>
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
</style>

<script type="text/javascript">

 function SoloNumeros(evt) {
	    var charCode = (evt.which) ? evt.which : event.keyCode
	    if (charCode == 08 || charCode == 32 || charCode == 45)
            	return true;
	    else if (charCode >= 48 && charCode <= 57)
		    return true; return false;
    }


</script>

<table cellpadding="0" cellspacing="0" class="style1">
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <fieldset id="Catalogo">
                    <legend>
                           <asp:Label ID="Label1" runat="server" Text="Mantenimiento Libretas de Ahorros" 
                            Font-Bold="True" Font-Names="Calibri" Font-Size="10pt"></asp:Label></legend>



                        <table cellpadding="0" cellspacing="0" class="style25">
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style1">
                                        <tr>
                                            <td style="text-align: center">
                                                <asp:Label ID="lblUsuario42" Runat="server" Font-Bold="True" 
                                                    Font-Names="Calibri" Font-Size="10pt" style="text-align: center" Width="120px">FILTRO AGENCIA:</asp:Label>
                                            </td>
                                            <td>
                                                <cc1:CbxOficinas ID="CbxOficinas1" runat="server" Font-Names="Calibri" 
                                                    Font-Size="10pt" Width="300px" AppendDataBoundItems="True" 
                                                    AutoPostBack="True" Enabled="False">
                                                    <asp:ListItem Value="00">Seleccione una Oficina</asp:ListItem>
                                                </cc1:CbxOficinas>
                                            </td>
                                            <td>
                                                <asp:CheckBox ID="lloficinas" runat="server" Font-Names="Calibri" 
                                                    Font-Size="10pt" Text="Todas las Oficinas" AutoPostBack="True" 
                                                    Checked="True" />
                                            </td>
                                            <td>
                                                <asp:Button ID="Btnfiltro" runat="server" CssClass="TestStyle" 
                                                    Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                                                    TabIndex="6" Text="Filtrar" Width="120px" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridOfi" runat="server" AllowPaging="True" 
                                        AutoGenerateColumns="False" CssClass="grid" Width="730px">
                                        <Columns>
                                            <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                                <ControlStyle Font-Names="Gill Sans MT" Font-Size="9pt" />
                                                <HeaderStyle BackColor="#99CCFF" />
                                            </asp:CommandField>
                                            <asp:BoundField DataField="ccodofi" HeaderText="Codigo">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                <ItemStyle Font-Names="Gill Sans MT" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="cnomofi" HeaderText="Descripción" 
                                                ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Left" Width="350px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="ndesde" HeaderText="Desde">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                <ItemStyle Font-Names="Gill Sans MT" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="nhasta" HeaderText="Hasta">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                <ItemStyle Font-Names="Gill Sans MT" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="nlibreta" HeaderText="No Libreta">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                <ItemStyle Font-Names="Gill Sans MT" />
                                            </asp:BoundField>
                                             <asp:BoundField DataField="cestado1" HeaderText="Estado">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" Width="100px" />
                                                <ItemStyle Font-Names="Gill Sans MT" />
                                            </asp:BoundField>
                                             <asp:BoundField DataField="dfecasi" DataFormatString="{0:d}" HeaderText="Asignación" 
                                                ItemStyle-HorizontalAlign="Left" ItemStyle-Width="350px">
                                                <HeaderStyle BackColor="#99CCFF" Font-Names="Gill Sans MT" />
                                                <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="center" Width="350px" />
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
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Oficina : </asp:Label>
                                            </td>
                                            <td class="style27">
                                                <cc1:CbxOficinas ID="CbxOficinas2" runat="server" Font-Names="Calibri" 
                                                    Font-Size="10pt" Width="250px" Enabled="False" TabIndex="1">
                                                </cc1:CbxOficinas>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style28" style="text-align: center">
                                                <asp:Label ID="lblUsuario33" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Desde :</asp:Label>
                                            </td>
                                            <td class="style28">
                                                <asp:TextBox ID="TxtnDesde" runat="server" AutoPostBack="True" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="20px" style="text-align: left" TabIndex="2" 
                                                    Width="150px" onkeypress="return SoloNumeros(event)">0</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: center">
                                                <asp:Label ID="lblUsuario43" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Hasta :</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TxtnHasta" runat="server" BorderColor="#2E6A99" 
                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="20px" style="text-align: left" TabIndex="3" Width="150px" 
                                                    onkeypress="return SoloNumeros(event)">0</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style27" style="text-align: center">
                                                <asp:Label ID="lblUsuario44" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">No Actual :</asp:Label>
                                            </td>
                                            <td class="style27">
                                                <asp:TextBox ID="Txtnactual" runat="server" BorderColor="#2E6A99" 
                                                    BorderWidth="1px" Enabled="False" Font-Names="Verdana" Font-Size="8pt" 
                                                    Height="20px" onkeypress="return SoloNumeros(event)" style="text-align: left" 
                                                    TabIndex="4" Width="150px">0</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style27" style="text-align: center">
                                                <asp:Label ID="lblUsuario45" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Asignación :</asp:Label>
                                            </td>
                                            <td class="style27">
                                                <asp:TextBox ID="Txtdfecasi" runat="server" AutoPostBack="True" 
                                                    BorderColor="#2E6A99" BorderWidth="1px" Enabled="False" Font-Names="Verdana" 
                                                    Font-Size="8pt" Height="20px" TabIndex="5" Width="105px"></asp:TextBox>
                                                <cc2:MaskedEditExtender ID="Txtdfecasi_MaskedEditExtender" runat="server" 
                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="Txtdfecasi">
                                                </cc2:MaskedEditExtender>
                                                <cc2:CalendarExtender ID="Txtdfecasi_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="dd/MM/yyyy" PopupButtonID="Image_btn4" 
                                                    TargetControlID="Txtdfecasi">
                                                </cc2:CalendarExtender>
                                                <asp:ImageButton ID="Image_btn4" runat="server" 
                                                    ImageUrl="~/web/gifs/Calendar_scheduleHS.png" TabIndex="6" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: center">
                                                <asp:Label ID="lblUsuario41" Runat="server" Font-Names="calibri" 
                                                    Font-Size="9pt" style="text-align: left" Width="120px">Estado :</asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="cbxestado" runat="server" Font-Names="Calibri" 
                                                    Font-Size="10pt" Height="21px" Width="250px" TabIndex="7">
                                                    <asp:ListItem Value="00">Seleccionar una Estado</asp:ListItem>
                                                    <asp:ListItem Value="01">ACTIVO</asp:ListItem>
                                                    <asp:ListItem Value="02">INACTIVO</asp:ListItem>
                                                </asp:DropDownList>
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
                                                <asp:Button ID="Btnprint" runat="server" CssClass="TestStyle" Font-Bold="True" 
                                                    Font-Names="Calibri" Font-Size="9pt" Height="27px" TabIndex="6" Text="Imprimir" 
                                                    Width="120px" Visible="False" />
                                            </td>
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
