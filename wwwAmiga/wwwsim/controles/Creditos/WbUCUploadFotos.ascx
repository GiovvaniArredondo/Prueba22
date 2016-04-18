<%@ Control Language="VB" AutoEventWireup="false" CodeFile="WbUCUploadFotos.ascx.vb" Inherits="controles_Creditos_WbUCUploadFotos" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc2" %>

<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>

<style type="text/css">
    .style1
    {
        width: 43%;
        height: 180px;
    }
    .style25
    {
        height: 1px;
        width: 483px;
    }
    .style28
    {
        height: 33px;
    }
    .CSSTableGenerator
    {
        margin-bottom: 0px;
    }
    .style4
    {
        width: 100%;
        height: 86px;
        margin-right: 0px;
    }
    .style29
    {
        width: 100%;
        height: 43px;
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
        <td style="text-align: center">
            <fieldset id="Catalogo">
                    <legend>
                           <asp:Label ID="Label1" runat="server" Text="Carga Fotografias" 
                            Font-Bold="True" Font-Names="Calibri" Font-Size="10pt"></asp:Label></legend>



                        <table cellpadding="0" cellspacing="0" class="style25">
                            <tr>
                                <td>
                                    <asp:Image ID="ImageFoto" runat="server" Height="58px" Visible="False" 
                                        Width="83px" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table cellpadding="0" cellspacing="0" class="style25">
                                        <tr>
                                            <td class="style28" style="text-align: center">
                                                                    <asp:Label ID="lblUsuario34" Runat="server" Font-Names="calibri" 
                                                                        Font-Size="9pt" style="text-align: left" Width="120px">Codigo Prestamo:</asp:Label>
                                                                </td>
                                            <td class="style28">
                                                                                                                                                    <asp:TextBox ID="TxtcCodcta" runat="server" 
                                                    BorderColor="#2E6A99" 
                                                                                                                                                        
                                                    BorderWidth="1px" Font-Names="Verdana" 
                                                    Font-Size="8pt" 
                                                                                                                                                        
                                                    Height="29px" TabIndex="4" Width="200px" 
                                                                                                                                                        
                                                    onkeypress="return SoloLetras_Numeros(event)" Enabled="False"></asp:TextBox>
                                                                                                                                                    
                                                                                                                                                </td>
                                        </tr>
                                        <tr>
                                            <td class="style28" style="text-align: center">
                                                                    <asp:Label ID="lblUsuario35" Runat="server" Font-Names="calibri" 
                                                                        Font-Size="9pt" style="text-align: left" Width="120px">Nombre del Cliente:</asp:Label>
                                                                </td>
                                            <td class="style28">
                                                                                                                                                    <asp:TextBox ID="TxtcNomcli" runat="server" 
                                                    BorderColor="#2E6A99" 
                                                                                                                                                        
                                                    BorderWidth="1px" Font-Names="Verdana" 
                                                    Font-Size="8pt" 
                                                                                                                                                        
                                                    Height="29px" TabIndex="4" Width="350px" 
                                                                                                                                                        
                                                    onkeypress="return SoloLetras_Numeros(event)" Enabled="False"></asp:TextBox>
                                                                                                                                                </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:FileUpload ID="fileUpEx" runat="server" Font-Names="Gill Sans MT" 
                                        TabIndex="60" Width="248px" />
                                    <asp:Button ID="btnSubir" runat="server" Font-Names="Gill Sans MT" 
                                        Height="21px" TabIndex="60" Text="Vista Preliminar" Width="98px" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: center">                                    
                                            <table cellpadding="0" cellspacing="0" class="style29">
                                                <tr>
                                                    <td>
                                                        <table cellpadding="0" cellspacing="0" class="style29">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label ID="lblUsuario33" Runat="server" Font-Names="calibri" 
                                                                        Font-Size="9pt" style="text-align: left" Width="120px">Tipo de Fotografia</asp:Label>
                                                                </td>
                                                                <td>
                                                                    <asp:DropDownList ID="cbxTipFoto" runat="server" Font-Names="Calibri" 
                                                                        Font-Size="10pt" Height="21px" Width="300px">
                                                                        <asp:ListItem Value="A">DOMICILIO</asp:ListItem>
                                                                        <asp:ListItem Value="B">NEGOCIO</asp:ListItem>
                                                                        <asp:ListItem Value="C">GARANTIAS</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Button ID="Btnsave" runat="server" CssClass="TestStyle" Enabled="False" 
                                                            Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" Height="27px" 
                                                            TabIndex="8" Text="Subir Foto" Width="120px" />
                                                        <cc2:ConfirmButtonExtender ID="Confirm_BtnExt1" runat="server" 
                                                            ConfirmText="Realmente Desea Guardar los cambios" Enabled="True" 
                                                            TargetControlID="Btnsave">
                                                        </cc2:ConfirmButtonExtender>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                    <asp:Label ID="lblStatus" runat="server" CssClass="style4" Font-Names="Calibri" 
                                        Font-Size="12pt" Height="16px"></asp:Label>
                                                    </td>
                                                </tr>
                                            </table>                                        
                                </td>
                            </tr>
                        </table>



                </fieldset>            
        </td>
    </tr>
</table>
            <asp:HiddenField ID="hfExtension" runat="server" />
            <asp:HiddenField ID="hfPathArchivo" runat="server" />
            
            
            <asp:HiddenField ID="hfIdEmpleado" runat="server" />
        

            

