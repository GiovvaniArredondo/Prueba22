<%@ Control Language="vb" AutoEventWireup="false" Inherits="WUsGarant" CodeFile="WUsGarant.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<script type="text/javascript">
    function SoloNumeros(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode == 08 || charCode == 32 || charCode == 45 || charCode == 46)
            return true;
        else if (charCode >= 48 && charCode <= 57)
            return true;

        return false;
    }

</script>

<style type="text/css">
    .style5
    {
        width: 100%;
    }
    .style2
    {
        height: 229px;
    }
    .style4
    {
        height: 26px;
    }
    .style3
    {
        height: 2px;
    }
    .style6
    {
        width: 304px;
    }
    </style>
<head id="Head1"/>
<table cellpadding="0" cellspacing="0" class="style5">
    <tr>
        <td>            
                    <TABLE id="Table4" style="border: thin solid highlight; WIDTH: 899px; HEIGHT: 506px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" border="0">
                        <TR>
                            <TD>
                                <P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
					align="center">
                                    ADICIÓN DE GARANTÍAS</P>
                            </TD>
                        </TR>
                        <TR>
                            <TD align="center">
                                <TABLE id="Table2" style="WIDTH: 423px; HEIGHT: 8px" cellSpacing="0" 
                    cellPadding="0" width="423"
					align="center" border="0">
                                    <TR>
                                        <TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 187px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 23px"
							align="right">
                                            Codigo</TD>
                                        <TD style="WIDTH: 107px; HEIGHT: 23px">
                                            <asp:textbox id="TxtCodigo" runat="server" Width="89px" Enabled="False" 
                                Font-Size="10pt" Font-Names="Gill Sans MT"
								BorderWidth="1px"></asp:textbox>
                                        </TD>
                                        <TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 53px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 23px">
                                            Cliente</TD>
                                        <TD style="HEIGHT: 23px">
                                            <asp:textbox id="txtNomcli" 
                                runat="server" Width="248px" Enabled="False" Font-Size="10pt" Font-Names="Gill Sans MT"
								BorderWidth="1px"></asp:textbox>
                                        </TD>
                                    </TR>
                                </TABLE>
                            </TD>
                        </TR>
                        <TR>
                            <TD style="HEIGHT: 16px" align="center">
                                <cc1:TabContainer ID="Garantias" runat="server" ActiveTabIndex="0" 
                    Width="727px" Font-Names="Gill Sans MT" Font-Size="10pt" Height="314px" 
                    CssClass="NewsTab">
                                    <cc1:TabPanel runat="server" HeaderText="Informacion" ID="TabPanel1">                                        

                        <HeaderTemplate>

                        Informacion</HeaderTemplate>
                                        

                        <ContentTemplate><table cellpadding="0" cellspacing="0" class="style2"><tr><td align="right"><asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="122px">Tipo de Garantía:</asp:Label></td><td><asp:DropDownList ID="cmbTipGar" runat="server" AutoPostBack="True" 
                                            Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" 
                                            Width="200px"></asp:DropDownList></td><td></td></tr><tr><td align="right"><asp:Label ID="Label4" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="122px">Tipo Descriptor:</asp:Label></td><td><asp:DropDownList ID="cmbTipDes" runat="server" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Width="200px"></asp:DropDownList></td><td></td></tr><tr><td align="right"><asp:Label ID="Label5" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Descripción de la Garantía:</asp:Label></td><td><asp:TextBox ID="TxtDescri" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="30px" MaxLength="256" 
                                            TextMode="MultiLine" Width="288px" BorderColor="#2E6A99"></asp:TextBox></td><td></td></tr><tr><td align="right"><asp:Label ID="Label6" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Codigo Unico:</asp:Label></td><td><asp:TextBox ID="TxtId" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" MaxLength="12" 
                                            BorderColor="#2E6A99"></asp:TextBox></td><td></td></tr><tr><td align="right"><asp:Label ID="Label7" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Valor de Garantía:</asp:Label></td><td><asp:TextBox ID="TxtMongas" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" 
                                            onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:TextBox></td><td><asp:RangeValidator ID="RangeValidator2" runat="server" 
                                            ControlToValidate="TxtMongas" ErrorMessage="RangeValidator" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="8px" 
                                            MaximumValue="1000000000" MinimumValue="0" Type="Double" Width="112px">Valor Inválido</asp:RangeValidator></td></tr><tr><td align="right"><asp:Label ID="Label8" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Total Avaluo:</asp:Label></td><td><asp:TextBox ID="TxtMontas" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" 
                                            onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:TextBox></td><td><asp:RangeValidator ID="RangeValidator1" runat="server" 
                                            ControlToValidate="TxtMontas" ErrorMessage="RangeValidator" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="8px" 
                                            MaximumValue="1000000000" MinimumValue="0" Type="Double" Width="109px">Valor Inválido</asp:RangeValidator></td></tr><tr><td align="right"><asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Monto Gravamen:</asp:Label></td><td><asp:TextBox ID="Txtmongrav" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" BorderColor="#2E6A99"></asp:TextBox></td><td><asp:RangeValidator ID="RangeValidator3" runat="server" 
                                            ControlToValidate="Txtmongrav" ErrorMessage="RangeValidator" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" 
                                            MaximumValue="1000000000" MinimumValue="0" Type="Double" Width="119px">Valor Inválido</asp:RangeValidator></td></tr><tr><td align="right"><asp:Label ID="Label71" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px" 
                                            Visible="False">Fecha de Avaluo:</asp:Label></td><td><asp:TextBox ID="txtfecavaluo" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px" 
                                            BorderColor="#2E6A99" Visible="False"></asp:TextBox><cc1:MaskedEditExtender ID="txtfecavaluo_MaskedEditExtender" runat="server" 
                                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtfecavaluo"></cc1:MaskedEditExtender><cc1:CalendarExtender ID="txtfecavaluo_CalendarExtender" runat="server" 
                                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtfecavaluo"></cc1:CalendarExtender></td><td></td></tr><tr><td align="right"><asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Visible="False" 
                                            Width="170px">Moneda:</asp:Label></td><td><asp:DropDownList ID="cmbmoneda" runat="server" AutoPostBack="True" 
                                            Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Visible="False" 
                                            Width="120px"></asp:DropDownList></td><td><asp:TextBox ID="TxtComodin" runat="server" BorderWidth="1px" 
                                            Font-Names="Gill Sans MT" Visible="False" Width="64px"></asp:TextBox></td></tr><tr><td 
                                    align="right"><asp:Label ID="Label73" runat="server" ForeColor="#0000C0" 
                                    Text="Banco"></asp:Label></td><td><asp:DropDownList ID="DplBancos" 
                                        runat="server">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    &#160;</td></tr>
                            <tr>
                                <td align="right">
                                    <asp:Button ID="TxtLimpiar" runat="server" Height="21px" Text="Limpiar Datos" 
                                        Width="126px" />
                                </td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TxtCogar" runat="server" Enabled="False" Visible="False"></asp:TextBox>
                                </td>
                            </tr>
                            </table>
                            

                            
 
                            


                            

                            
 
                            

 
                            

 
                            


 
                            


                            

                            
 
                            


                            

                                    </ContentTemplate>
                                        

                                        

                                        


                                        

                                        
 
                                        

 
                                        

 
                                        


 
                                        


                                        

                                        

                                        


                                        

                    </cc1:TabPanel>
                                    <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Escritura">
                                        

                                        

                                        


                                        

                                        
 
                                        

 
                                        

 
                                        


 
                                        


                                        

                                        

                                        


                                        

                        <HeaderTemplate>Escritrura







                                    </HeaderTemplate>
                                        

                                        

                                        


                                        

                                        
 
                                        

 
                                        

 
                                        


 
                                        


                                        

                                        

                                        


                                        

                        <ContentTemplate><table cellpadding="0" cellspacing="0" style="height: 272px"><tr><td align="right"></td><td class="style10"></td><td></td></tr><tr><td align="right"><asp:Label ID="Label15" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Nombre del Propietario:</asp:Label></td><td class="style10"><asp:TextBox ID="txtpropietario" runat="server" BorderWidth="1px" 
                                            Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" 
                                            Width="200px"></asp:TextBox></td><td></td></tr><tr><td align="right"><asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Notario:</asp:Label></td><td class="style10"><asp:TextBox ID="txtnotario" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td><td></td></tr><tr><td align="right"><asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Número de Escritura:</asp:Label></td><td class="style10"><asp:TextBox ID="txtnumeropr" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"></asp:TextBox></td><td></td></tr><tr><td align="right"><asp:Label ID="Label13" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Fecha de Escritura:</asp:Label></td><td class="style10"><asp:TextBox ID="txtfechaes" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"></asp:TextBox><cc1:MaskedEditExtender ID="txtfechaes_MaskedEditExtender" runat="server" 
                                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtfechaes"></cc1:MaskedEditExtender><cc1:CalendarExtender ID="txtfechaes_CalendarExtender" runat="server" 
                                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtfechaes"></cc1:CalendarExtender></td><td></td></tr><tr><td align="right"><asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Lugar de Escritura:</asp:Label></td><td class="style10"><asp:TextBox ID="txtlugares" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt"></asp:TextBox></td><td></td></tr><tr><td align="right"></td><td class="style10"><asp:Label ID="Label16" runat="server" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#0000C0" Height="16px" 
                                            Width="170px">Registro de la Propiedad</asp:Label></td><td><asp:Label ID="Label23" runat="server" Font-Bold="True" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#0000C0" Height="16px" 
                                            Width="170px">Registro Municipal</asp:Label></td></tr><tr><td align="right"><asp:Label ID="Label18" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Finca:</asp:Label></td><td class="style10"><asp:TextBox ID="txtprofinca" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td><td><asp:TextBox ID="txtmunfinca" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label19" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Folio:</asp:Label></td><td class="style10"><asp:TextBox ID="txtprofolio" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td><td><asp:TextBox ID="txtmunfolio" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label20" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Libro:</asp:Label></td><td class="style10"><asp:TextBox ID="txtprolibro" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td><td><asp:TextBox ID="txtmunlibro" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label21" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">De:</asp:Label></td><td class="style10"><asp:TextBox ID="txtprode" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td><td><asp:TextBox ID="txtmunde" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label22" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="170px">Fecha:</asp:Label></td><td class="style10"><asp:TextBox ID="txtprofecha" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox><cc1:MaskedEditExtender ID="txtprofecha_MaskedEditExtender" runat="server" 
                                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtprofecha"></cc1:MaskedEditExtender><cc1:CalendarExtender ID="txtprofecha_CalendarExtender" runat="server" 
                                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtprofecha"></cc1:CalendarExtender></td><td><asp:TextBox ID="txtmunfecha" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox><cc1:MaskedEditExtender ID="txtmunfecha_MaskedEditExtender" runat="server" 
                                            CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                            CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                            CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                            Mask="99/99/9999" MaskType="Date" TargetControlID="txtmunfecha"></cc1:MaskedEditExtender><cc1:CalendarExtender ID="txtmunfecha_CalendarExtender" runat="server" 
                                            Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtmunfecha"></cc1:CalendarExtender></td></tr></table>
                            

                            
 
                            


                            

                            
 
                            

 
                            

 
                            


 
                            


                            

                            
 
                            


                            

                                    </ContentTemplate>
                                        

                                        

                                        


                                        

                                        
 
                                        

 
                                        

 
                                        


 
                                        


                                        

                                        

                                        


                                        

                    </cc1:TabPanel>
                                    <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Datos Generales">
                                        

                                        

                                        


                                        

                                        
 
                                        

 
                                        

 
                                        


 
                                        


                                        

                                        

                                        


                                        

                        <ContentTemplate><table cellpadding="0" cellspacing="0" style="height: 250px"><tr><td align="right"></td><td></td></tr><tr><td align="right"><asp:Label ID="Label30" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Direccion:</asp:Label></td><td><asp:TextBox ID="txtdireccion" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" TextMode="MultiLine" 
                                            Width="200px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label31" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Estado:</asp:Label></td><td><asp:DropDownList ID="cmbDep" runat="server" AutoPostBack="True" 
                                            Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" 
                                             Width="200px"></asp:DropDownList></td></tr><tr><td align="right"><asp:Label ID="Label32" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Municipio:</asp:Label></td><td><asp:DropDownList ID="cmbMun" runat="server" AutoPostBack="True" 
                                            Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" 
                                             Width="200px"></asp:DropDownList></td></tr><tr><td align="right"><asp:Label ID="Label33" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Colonia:</asp:Label></td><td><asp:DropDownList ID="cmbcant" runat="server" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="200px"></asp:DropDownList></td></tr><tr><td align="right"><asp:Label ID="Label34" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Topografia:</asp:Label></td><td><asp:DropDownList ID="cmbTopo" runat="server" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="19px" Width="200px"></asp:DropDownList></td></tr><tr><td align="right"><asp:Label ID="Label37" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Especifique:</asp:Label></td><td><asp:TextBox ID="txtespdir" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label35" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Uso del Inmueble:</asp:Label></td><td><asp:DropDownList ID="cmbuso" runat="server" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="19px" Width="200px"></asp:DropDownList></td></tr><tr><td align="right"><asp:Label ID="Label36" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Especifique:</asp:Label></td><td><asp:TextBox ID="txtespuso" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label38" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="145px">Localidad Demografica:</asp:Label></td><td><asp:DropDownList ID="cmblocalidad" runat="server" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="19px" Width="200px"></asp:DropDownList></td></tr></table>
                            

                            
 
                            


                            

                            
 
                            

 
                            

 
                            


 
                            


                            

                            
 
                            


                            

                                    </ContentTemplate>
                                        

                                        

                                        


                                        

                                        
 
                                        

 
                                        

 
                                        


 
                                        


                                        

                                        

                                        


                                        

                    </cc1:TabPanel>
                                    <cc1:TabPanel ID="TabPanel4" runat="server" 
                        HeaderText="Caracteristica del Inmueble">
                                        

                                        

                                        


                                        

                                        
 
                                        

 
                                        

 
                                        


 
                                        


                                        

                                        

                                        


                                        

                        <ContentTemplate><table cellpadding="0" cellspacing="0" class="style8"><tr><td align="right"><asp:Label ID="Label40" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Niveles:</asp:Label></td><td><asp:TextBox ID="txtniveles" runat="server" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" 
                                            style="vertical-align:top" TabIndex="19" Width="89px"></asp:TextBox><cc1:NumericUpDownExtender ID="txtniveles_NumericUpDownExtender" runat="server" 
                                            Enabled="True" Maximum="100" Minimum="1" RefValues="" ServiceDownMethod="" 
                                            ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                            TargetButtonUpID="" TargetControlID="txtniveles" Width="60"></cc1:NumericUpDownExtender></td><td></td><td></td></tr><tr><td align="right"><asp:Label ID="Label41" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Acceso:</asp:Label></td><td><asp:DropDownList ID="cmbacceso" runat="server" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="19px" Width="200px"></asp:DropDownList></td><td></td><td></td></tr><tr><td align="right"><asp:Label ID="Label42" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Servicios:</asp:Label></td><td><asp:ListBox ID="cmbservicios" runat="server" Font-Names="Gill Sans MT" 
                                            SelectionMode="Multiple" Width="148px"><asp:ListItem Value="1">Agua</asp:ListItem><asp:ListItem Value="2">Energia Electrica</asp:ListItem><asp:ListItem Value="3">Drenaje</asp:ListItem><asp:ListItem Value="4">Fosa Septica</asp:ListItem><asp:ListItem Value="5">Otros</asp:ListItem></asp:ListBox></td><td align="right"><asp:Label ID="Label48" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Piso:</asp:Label></td><td align="left"><asp:ListBox ID="cmbpiso" runat="server" Font-Names="Gill Sans MT" 
                                            Height="60px" SelectionMode="Multiple" Width="148px"><asp:ListItem Value="1">Tierra</asp:ListItem><asp:ListItem Value="2">Cemento</asp:ListItem><asp:ListItem Value="3">Granito</asp:ListItem><asp:ListItem Value="4">Ceramico</asp:ListItem><asp:ListItem Value="5">Otro</asp:ListItem></asp:ListBox></td></tr><tr><td align="right"><asp:Label ID="Label43" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Especifique:</asp:Label></td><td><asp:TextBox ID="txtespser" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td><td align="right"><asp:Label ID="Label49" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Especifique:</asp:Label></td><td><asp:TextBox ID="txtesppiso" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label44" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Ambientes:</asp:Label></td><td><asp:ListBox ID="cmbambientes" runat="server" Font-Names="Gill Sans MT" 
                                            SelectionMode="Multiple" Width="148px"><asp:ListItem Value="1">Dormitorios</asp:ListItem><asp:ListItem Value="2">Cocina</asp:ListItem><asp:ListItem Value="3">Comedor</asp:ListItem><asp:ListItem Value="4">Baños</asp:ListItem><asp:ListItem Value="5">Corredor</asp:ListItem><asp:ListItem Value="6">Patios</asp:ListItem><asp:ListItem Value="7">Garage</asp:ListItem><asp:ListItem Value="8">Otros</asp:ListItem></asp:ListBox></td><td align="right"><asp:Label ID="Label50" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Paredes:</asp:Label></td><td><asp:ListBox ID="cmbparedes" runat="server" Font-Names="Gill Sans MT" 
                                            Height="60px" SelectionMode="Multiple" Width="148px"><asp:ListItem Value="1">Adobe</asp:ListItem><asp:ListItem Value="2">Block</asp:ListItem><asp:ListItem Value="3">Ladrillo</asp:ListItem><asp:ListItem Value="4">Madera</asp:ListItem><asp:ListItem Value="5">Otro</asp:ListItem></asp:ListBox></td></tr><tr><td align="right"><asp:Label ID="Label45" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Especifique:</asp:Label></td><td><asp:TextBox ID="txtespamb" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td><td align="right"><asp:Label ID="Label51" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Especifique:</asp:Label></td><td><asp:TextBox ID="txtesppared" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label46" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Techo:</asp:Label></td><td><asp:ListBox ID="cmbtecho" runat="server" Font-Names="Gill Sans MT" 
                                            Height="60px" SelectionMode="Multiple" Width="148px"><asp:ListItem Value="1">Lamina</asp:ListItem><asp:ListItem Value="2">Terraza</asp:ListItem><asp:ListItem Value="3">Otro</asp:ListItem></asp:ListBox></td><td align="right"></td><td></td></tr><tr><td align="right"><asp:Label ID="Label47" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Especifique:</asp:Label></td><td><asp:TextBox ID="txtesptecho" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="200px"></asp:TextBox></td><td align="right"></td><td></td></tr></table>
                            

                            
 
                            


                            

                            
 
                            

 
                            

 
                            


 
                            


                            

                            
 
                            


                            

                                    </ContentTemplate>
                                        

                                        

                                        


                                        

                                        
 
                                        

 
                                        

 
                                        


 
                                        


                                        

                                        

                                        


                                        

                    </cc1:TabPanel>
                                    <cc1:TabPanel ID="TabPanel5" runat="server" 
                        HeaderText="Medidas, Colindancias y Coordenadas">
                                        

                                        

                                        


                                        

                                        
 
                                        

 
                                        

 
                                        


 
                                        


                                        

                                        

                                        


                                        

                        <ContentTemplate><table cellpadding="0" cellspacing="0" class="style9"><tr><td align="right"></td><td><asp:Label ID="Label53" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Norte</asp:Label></td><td></td><td><asp:Label ID="Label68" runat="server" Font-Bold="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#0000C0" Height="16px" 
                                            Width="147px">Coordenadas GPS</asp:Label></td></tr><tr><td align="right"><asp:Label ID="Label54" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Medida:</asp:Label></td><td><asp:TextBox ID="txtNmedida" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td><td align="right"><asp:Label ID="Label69" runat="server" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#0000C0" Height="16px" 
                                            Width="102px">Latitud:</asp:Label></td><td><asp:TextBox ID="txtlatitud" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td></tr><tr><td align="right"><asp:Label ID="Label55" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Colindancia:</asp:Label></td><td><asp:TextBox ID="txtNcolin" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td><td align="right"><asp:Label ID="Label70" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Longitud:</asp:Label></td><td><asp:TextBox ID="txtlongitud" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td></tr><tr><td align="right"></td><td><asp:Label ID="Label56" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Sur</asp:Label></td><td></td><td><asp:Button ID="Button9" runat="server" Font-Names="Gill Sans MT" Height="29px" 
                                            Text="Mapa" Width="76px" /></td></tr><tr><td align="right"><asp:Label ID="Label60" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Medida:</asp:Label></td><td><asp:TextBox ID="txtSmedida" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td><td></td><td></td></tr><tr><td align="right"><asp:Label ID="Label64" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Colindancia:</asp:Label></td><td><asp:TextBox ID="txtScolin" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td><td></td><td></td></tr><tr><td align="right"></td><td><asp:Label ID="Label57" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Oriente</asp:Label></td><td></td><td></td></tr><tr><td align="right"><asp:Label ID="Label61" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Medida:</asp:Label></td><td><asp:TextBox ID="txtEmedida" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td><td></td><td></td></tr><tr><td align="right"><asp:Label ID="Label65" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Colindancia:</asp:Label></td><td><asp:TextBox ID="txtEcolin" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td><td></td><td></td></tr><tr><td align="right"></td><td><asp:Label ID="Label58" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Poniente</asp:Label></td><td></td><td></td></tr><tr><td align="right"><asp:Label ID="Label62" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Medida:</asp:Label></td><td><asp:TextBox ID="txtOmedida" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td><td></td><td></td></tr><tr><td align="right"><asp:Label ID="Label66" runat="server" Font-Names="Gill Sans MT" 
                                            Font-Size="10pt" ForeColor="#0000C0" Height="16px" Width="102px">Colindancia:</asp:Label></td><td><asp:TextBox ID="txtOcolin" runat="server" BorderWidth="1px" Enabled="False" 
                                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" Width="100px"></asp:TextBox></td><td></td><td></td></tr></table>                            

                         
                            

                            

                                    </ContentTemplate>
                   

                                        
 


                   

                    </cc1:TabPanel>
                                </cc1:TabContainer>
                            </TD>
                        </TR>
                        <tr>
                        <td>
                          <center><table cellpadding="0" cellspacing="0" class="style1">
                                            <tr>
                                                <td style="text-align: center">
                                                    <fieldset ID="Catalogo">
                                                        <legend>
                                                            <asp:Label ID="Label72" runat="server" Font-Bold="True" Font-Names="Calibri" 
                                                                Font-Size="10pt" Text="Carga Ticket"></asp:Label>
                                                        </legend>
                                                        <table cellpadding="0" cellspacing="0" class="style25">
                                                            <tr>
                                                                <td class="style6">
                                                                    <asp:Image ID="ImageFoto" runat="server" Height="58px" Visible="False" 
                                                                        Width="154px" />
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class="style6">
                                                                    <table cellpadding="0" cellspacing="0" class="style25">
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="text-align: center" class="style6">
                                                                    <asp:FileUpload ID="fileUpEx" runat="server" Font-Names="Gill Sans MT" 
                                                                        TabIndex="60" Width="248px" />
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="text-align: center" class="style6">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="text-align: center" class="style6">
                                                                    <table cellpadding="0" cellspacing="0" class="style29">
                                                                        <tr>
                                                                            
                                                                            <td style="text-align: center">
                                                                                &nbsp;</td>
                                                                            
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
                                    
                                        
                                    </td>
                                    <td> 
                                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    
                                </tr>
                                    
                                    <tr>
                                    <td align="right">
                                
                                        &nbsp;</td>
                                    
                                </tr>
                                    
                                    </tr></table> </center>
                        
                        </td>
                        
                        
                        
                        
                        </tr>
                        
                        <TR>
                            <TD align="center" class="style4">
                                <asp:label id="Label1" runat="server" Width="416px" Font-Size="10pt" Font-Names="Gill Sans MT"
						Height="2px" Visible="False" ForeColor="#0000C0">Label</asp:label>
                            </TD>
                        </TR>
                        <TR>
                            <TD align="center" class="style3">
                                <asp:label id="Label2" runat="server" Width="391px" Font-Size="10pt" Font-Names="Gill Sans MT"
						Height="2px" Visible="False" ForeColor="#0000C0">Label</asp:label>
                            </TD>
                        </TR>
                        <TR>
                            <TD align="center">
                                <INPUT id="btnNew" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" name="btnNew" runat="server">
                                    
                                    <INPUT id="btngraba" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" name="Button2" runat="server">
                                         
                                        <INPUT id="btnElimina" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" name="Button4" runat="server">
                                            
                                            <INPUT id="btnCancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server" visible="False">
                                                
                                                <INPUT id="btnprint" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/gifs/imprimir.gif); WIDTH: 67px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 60px; BACKGROUND-COLOR: transparent"
					type="button" name="Button3" runat="server">
                            </TD>
                        </TR>
                        <TR>
                            <TD align="center">
                             <asp:GridView ID="Grid_Garantia" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="657px">
                                    <Columns>
                                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                                            <ControlStyle Font-Names="Gill Sans MT" />
                                            <ItemStyle Font-Names="Gill Sans MT" />
                                        </asp:CommandField>
                                        <asp:BoundField DataField="Nro" HeaderText="Nro">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Tipo" HeaderText="Tipo">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                            HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" 
                            DataFormatString="{0:dd-MM-yyyy}">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Garantia" HeaderText="Garantia" 
                            DataFormatString="{0:###,##0.00}">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                            HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Tasacion" HeaderText="Tasacion" 
                                            DataFormatString="{0:###,##0.00}">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                            HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="cestado" HeaderText="Estado">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                            HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        
                                         <asp:BoundField DataField="Link" HeaderText="Garantia">
                                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                            HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        
                                        
                                        <asp:TemplateField HeaderText="Garantias">
                                                <ItemTemplate>
                                                    <asp:Button ID="Button1" 
                                                    runat="server" Text="Visualizar Garantia"
                                                    CommandName="Ver" 
                                                    CommandArgument='<%#Container.DataItem("Link")%>'/>
                                                  </ItemTemplate>
                                                    
                                        </asp:TemplateField>
                                        
                                        
                                    </Columns>
                                    <FooterStyle Font-Names="Gill Sans MT" />
                                    <PagerStyle Font-Names="Gill Sans MT" />
                                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                                    <AlternatingRowStyle BackColor="#CCFF66" />
                                </asp:GridView>
                            </TD>
                        </TR>
                    </TABLE>
           
        </td>
    </tr>
</table>

