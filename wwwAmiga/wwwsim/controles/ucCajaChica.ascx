<%@ Control Language="vb" AutoEventWireup="false" Codefile="ucCajaChica.ascx.vb" Inherits="ucCajaChica"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<head runat="server">
    <title>Poliza contable</title>
    <style type="text/css">
        .style23
        {
            width: 75%;
            margin-bottom: 8px;
            height: 135px;
        }
        .style24
        {
            width: 215px;
        }
        .style25
        {
            height: 39px;
        }
        .style26
        {
            width: 100%;
        }
        </style>
</head>
        
<script src="js/jquery.js" type="text/javascript"></script>    
<script type="text/javascript" src="js/lib.js"></script>
<script type="text/javascript">
function Cajachica() {
    Cajachica_calculo();
}

</script>
<table border="2" cellpadding="0" cellspacing="0" class="style23" 
    style="border-color: #3366CC">
    <tr>
        <td>
            <table align="center" class="style23">
                <tr>
                    <td>
                        <table cellpadding="0" cellspacing="0" class="style23">
                            <tr>
                                <td align="center">
                                            <asp:Label ID="Label20" runat="server" Font-Names="Gill Sans MT" 
                                        Text="AUXILIAR DE CAJA CHICA" Font-Bold="True" Font-Size="16pt" 
                                        ForeColor="#666666" Font-Italic="True"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <table cellpadding="0" cellspacing="0" class="style23" align="center">
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label1" runat="server" Font-Names="Gill Sans MT" Text="Agencia:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td class="style24">
                                            <asp:dropdownlist id="cmbOficina" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                                runat="server"
							Width="206px"></asp:dropdownlist>
                                            </td>
                                            <td>
                                                <asp:CheckBox ID="CheckBox1" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Todos" Visible="False" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label2" runat="server" Font-Names="Gill Sans MT" 
                                                Text="Fondo:" Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td class="style24">
						<asp:dropdownlist id="cmbfondo" runat="server" Width="206px" Height="16px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist>
                                 
                                  
                                            </td>
                                            <td>
                                                <asp:CheckBox ID="CheckBox2" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Todos" Visible="False" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label6" runat="server" Font-Names="Gill Sans MT" 
                                                Text="Encargado de Caja Chica:" Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td class="style24">
						<asp:dropdownlist id="cmbencargado" runat="server" Width="206px" Height="16px" 
                                        Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist>
                                 
                                  
                                            </td>
                                            <td>
                                                <asp:CheckBox ID="CheckBox3" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Todos" Visible="False" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" 
                                                Text="Del:" Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td class="style24">
                                            <asp:textbox id="txtdfecini" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                                runat="server"
							Width="112px"></asp:textbox>
						                        <asp:CalendarExtender ID="txtdfecini_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdfecini">
                                                </asp:CalendarExtender>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label4" runat="server" Font-Names="Gill Sans MT" Text="Al:"></asp:Label>
                                            </td>
                                            <td class="style24">
                                            <asp:textbox id="txtdfecfin" Font-Size="10pt" Font-Names="Gill Sans MT" 
                                                runat="server"
							Width="112px"></asp:textbox>
						                        <asp:CalendarExtender ID="txtdfecfin_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdfecfin">
                                                </asp:CalendarExtender>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" class="style25">
                    <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" 
                        Text="Consultar Movimientos" Height="29px" Width="134px" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                    <asp:GridView ID="cuentas_GridView" runat="server" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                        Font-Names="Gill Sans MT" Font-Size="10pt" 
                        AutoGenerateColumns="False" Width="518px" AllowPaging="True" 
                        AllowSorting="True" Height="100px" 
                        PageSize="8" AutoGenerateSelectButton="True">
                        <RowStyle ForeColor="#000066" />                        					    
					    <HeaderStyle Font-Bold="True" ForeColor="LightCyan" BackColor="#006699"></HeaderStyle>
					    <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					
                    <Columns>
                        <asp:TemplateField HeaderText="No.">
                        <HeaderStyle Font-Size="8pt" ForeColor="White"  Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("idcchica") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("idcchica") %>'></asp:Label>                                
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="cnit" HeaderText="NIT" >
                        <HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						<HeaderStyle ForeColor="White" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cdespro" HeaderText="Proveedor" >
                        <HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						<HeaderStyle ForeColor="White" />
                        </asp:BoundField>
                        <asp:BoundField DataField="dfecha" HeaderText="Fecha" 
                            DataFormatString="{0:dd-MM-yyyy}">
                        <HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>

                        <HeaderStyle ForeColor="White" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cfactura" HeaderText="Factura" 
                            InsertVisible="False" >
                        <HeaderStyle ForeColor="White" />
                        <HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="cdescri" HeaderText="Descripción" >
                        <HeaderStyle ForeColor="White" />
                        <HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="nDebe" HeaderText="Monto" >
                        <HeaderStyle ForeColor="White" />
                        <HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="destipope" HeaderText="Tip. Ope" >
                        <HeaderStyle ForeColor="White" />
                        <HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="ctipo" HeaderText="Cuenta" >
                        <HeaderStyle ForeColor="White" />
                        <HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                        </asp:BoundField>
                    </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <PagerStyle ForeColor="#000066" HorizontalAlign="Left" BackColor="White" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <table cellpadding="0" cellspacing="0" class="style23">
                                        <tr>
                                            <td align="right">
                                                &nbsp;</td>
                                            <td align="right">
                                                &nbsp;</td>
                                            <td align="left">
                                            <asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                                                    Text="Saldo" Font-Size="15pt" ForeColor="#FF3300"></asp:Label>
                                            </td>
                                            <td>
                                            <asp:Label ID="lblSaldo" runat="server" Font-Names="Gill Sans MT" Font-Size="15pt" 
                                                    Font-Bold="True" ForeColor="#009933"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label19" runat="server" Font-Names="Gill Sans MT" 
                                                    Text="Tipo de Operación:" Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <table cellpadding="0" cellspacing="0" class="style23">
                                                    <tr>
                                                        <td>
                                                            <asp:RadioButton ID="RadioButton1" runat="server" Font-Names="Gill Sans MT" 
                                                                Font-Size="10pt" GroupName="opcion" Text="Apertura/Reintegro" 
                                                                AutoPostBack="True" />
                                                            <asp:RadioButton ID="RadioButton2" runat="server" Checked="True" 
                                                                Font-Names="Gill Sans MT" Font-Size="10pt" GroupName="opcion" Text="Gasto" 
                                                                AutoPostBack="True" />
                                                        </td>
                                                        <td>
                                                            <asp:HiddenField ID="HiddenFieldCorrelativo" runat="server" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td align="right">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label23" runat="server" Font-Names="Gill Sans MT" Text="Buscar" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtBuscarNit" runat="server"></asp:TextBox>
                                                <asp:Button ID="btnBNit" runat="server" Height="21px" Text="Buscar Nit" 
                                                    Width="83px" />
                                            </td>
                                            <td align="right">
                                            <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" Text="Buscar" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtBuscarCuenta" runat="server"></asp:TextBox>
                                                <asp:Button ID="btnBCuenta" runat="server" Height="21px" Text="Buscar cuenta" 
                                                    Width="96px" Font-Names="Gill Sans MT" />
                                                </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label7" runat="server" Font-Names="Gill Sans MT" Text="NIT:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtcnit" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    Enabled="False" ForeColor="Black"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="txtcnit_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="txtcnit" 
                                                    WatermarkText="digitar numero de identificacion tributaria">
                                                </asp:TextBoxWatermarkExtender>
                                            </td>
                                            <td align="right">
                                            <asp:Label ID="Label13" runat="server" Font-Names="Gill Sans MT" Text="Cuenta:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:dropdownlist id="cmbtipo" runat="server" Width="267px" 
                            Font-Names="Gill Sans MT" Font-Size="8pt" Height="16px"></asp:dropdownlist>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label8" runat="server" Font-Names="Gill Sans MT" Text="Proveedor:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <table cellpadding="0" cellspacing="0" class="style26">
                                                    <tr>
                                                        <td>
                                                            <asp:dropdownlist id="cmbprovee" runat="server" Width="267px" 
                            Font-Names="Gill Sans MT" Font-Size="8pt" Height="16px" AutoPostBack="True"></asp:dropdownlist>
                                                        </td>
                                                        <td>
                        <asp:Button ID="Button3" runat="server" Font-Names="Gill Sans MT" Text="Proveedores" 
                            Width="90px" />
                                                        </td>
                                                        <td>
                        <asp:Button ID="Button4" runat="server" Font-Names="Gill Sans MT" Height="27px" 
                            Text="Actualizar" Width="71px" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td align="right">
                                            <asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" Text="Total:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtntotal" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" TabIndex="4"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="txtntotal_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="txtntotal" 
                                                    WatermarkText="Cantidad total de la factura">
                                                </asp:TextBoxWatermarkExtender>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" Text="Descripción:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtcdescripcion" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" TabIndex="1" Height="63px" TextMode="MultiLine" 
                                                    Width="251px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="txtcdescripcion_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="txtcdescripcion" 
                                                    WatermarkText="descripcion del gasto">
                                                </asp:TextBoxWatermarkExtender>
                                            </td>
                                            <td align="right">
                                            <asp:Label ID="Label21" runat="server" Font-Names="Gill Sans MT" Text="Observaciones:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtObservac" runat="server" Height="63px" 
                                                    TextMode="MultiLine" Width="215px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" Text="Fecha:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtdfecha" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" TabIndex="2"></asp:TextBox>
                                                <asp:CalendarExtender ID="txtdfecha_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdfecha">
                                                </asp:CalendarExtender>
                                                <asp:TextBoxWatermarkExtender ID="txtdfecha_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="txtdfecha" 
                                                    WatermarkText="Fecha de Factura">
                                                </asp:TextBoxWatermarkExtender>
                                            </td>
                                            <td align="right">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" Text="Factura:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtcfactura" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" TabIndex="3"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="txtcfactura_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="txtcfactura" 
                                                    WatermarkText="Numero de Factura">
                                                </asp:TextBoxWatermarkExtender>
                                            </td>
                                            <td align="right">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                            <asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" Text="Responsable:" 
                                                    Font-Size="10pt"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:dropdownlist id="cmbresponsable" runat="server" Width="267px" 
                            Font-Names="Gill Sans MT" Font-Size="8pt" Height="16px"></asp:dropdownlist>
                                            </td>
                                            <td align="right">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <table cellpadding="0" cellspacing="0" class="style23">
                                        <tr>
                                            <td align="center">
                                                <asp:Button ID="Button2" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    Text="Agregar" Width="100px" Height="25px" />
                                            </td>
                                            <td align="center">
                                                <asp:Button ID="btnmodificar" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Modificar" Width="100px" Enabled="False" 
                                                    Height="25px" />
                                            </td>
                                            <td align="center">
                                                <asp:Button ID="btnimprimir" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Imprimir" Width="87px" Height="25px" />&nbsp&nbsp&nbsp
                                                <asp:Button ID="ButtonConsolidadoXAgencia" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    Height="25px" Text="Imprimir Consolidado" Width="127px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="3">
                                                <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" Height="116px" 
                                                    Width="641px">
                                                    <table class="style26">
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label22" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                                    Text="Referencia:"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="txtRef" runat="server"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="Label18" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                                    Text="Bancos:"></asp:Label>
                                                            </td>
                                                            <td>
                                                                <asp:DropDownList ID="cmbbancos" runat="server" Font-Names="Gill Sans MT" 
                                                                    Font-Size="8pt" Height="16px" Width="267px">
                                                                </asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:RadioButtonList ID="RadioButtonListOpciones" runat="server" 
                                                                    Font-Names="Gill Sans MT" Font-Size="10pt">
                                                                    <asp:ListItem Selected="True" Value="1">Liquidado</asp:ListItem>
                                                                    <asp:ListItem Value="0">No liquidado</asp:ListItem>
                                                                </asp:RadioButtonList>
                                                            </td>
                                                            <td>
                                                                <asp:Button ID="ButtonImpConsolidado" runat="server" Font-Names="Gill Sans MT" 
                                                                    Font-Size="10pt" Height="25px" Text="Imprimir liquidacion" Width="142px" />
                                                                <asp:Button ID="ButtonGenerarArchivoBanca" runat="server" Font-Names="Gill Sans MT" 
                                                                    Font-Size="10pt" Height="25px" Text="Archivo banca" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:Button ID="btnliquidar" runat="server" BackColor="#99CCFF" 
                                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="25px" Text="Liquidar agencias" 
                                                                    Width="120px" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                        </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

<p>
    &nbsp;</p>
<p>
    &nbsp;</p>


