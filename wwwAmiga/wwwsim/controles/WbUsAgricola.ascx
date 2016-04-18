<%@ Control Language="vb" AutoEventWireup="false" Inherits="WbUsAgricola" CodeFile="WbUsAgricola.ascx.vb" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<script type="text/javascript">
    function SoloNumeros(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode == 08 || charCode == 32 || charCode == 45 || charCode == 46)
            return true;
        else if (charCode >= 48 && charCode <= 57)
            return true;

        return false;
    }



    function rendimiento() {
        var ingreso, costo;
        ingreso = parseFloat(document.getElementById('<%=txtingreso.ClientID %>').value);
        costo = parseFloat(document.getElementById('<%=txtcosto.ClientID %>').value);
        if (costo == 0) {
            document.getElementById('<%=txtRendimiento.ClientID %>').value = 0
        }
        else {
            document.getElementById('<%=txtRendimiento.ClientID %>').value = Math.round( ingreso - costo,2);
        }
        
            }
</script>
<style type="text/css">
    .style11
    {
        height: 35px;
        width: 450px;
    }
    #Table4
    {
        width: 103%;
    }
    .style14
    {
        height: 25px;
        width: 144px;
    }
    .style15
    {
        height: 24px;
        width: 144px;
    }
    .style16
    {
        height: 23px;
        width: 144px;
    }
    .style23
    {
        width: 92%;
    }
    .style24
    {
        width: 135px;
    }
    .style25
    {
        width: 85px;
    }
    #Table3
    {
        width: 52%;
        height: 52px;
    }
    .style28
    {
        width: 100px;
        height: 20px;
    }
    .style29
    {
        width: 90px;
        height: 20px;
    }
    .style30
    {
        width: 99px;
        height: 20px;
    }
    .style31
    {
        height: 20px;
    }
    .style32
    {
        width: 153%;
    }
    .style33
    {
        height: 29px;
    }
    .style34
    {
        height: 15px;
    }
    .CSSTableGenerator
    {
        width: 448px;
        height: 81px;
    }
    .style36
    {
        width: 167px;
    }
    .style37
    {
        width: 84%;
    }
    .style38
    {
        width: 241px;
    }
    .style39
    {
        width: 89px;
    }
    .style40
    {
        width: 95px;
    }
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 664px; HEIGHT: 21px; "
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff; height: 33px;"
				align="center">Resumen de Ingresos y Costos del(los) Cultivos y/o Crianza</P>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff" 
                        class="style28">Fecha de Datos:</TD>
					<TD style="BACKGROUND-COLOR: #ffffff" align="left" class="style29">
                        <asp:textbox id="TxtdFecha" Font-Names="Gill Sans MT" runat="server" 
                            Width="88px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox></TD>
					<TD style="BACKGROUND-COLOR: #ffffff" class="style30"><asp:textbox id="txtfuente" 
                            Font-Names="Gill Sans MT" runat="server" Width="93px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" BorderColor="#2E6A99"></asp:textbox></TD>
					<TD style="BACKGROUND-COLOR: #ffffff" class="style31">
                        <asp:textbox id="txtcodcli" 
                            Font-Names="Gill Sans MT" runat="server" Width="175px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" Height="20px" BorderColor="#2E6A99"></asp:textbox></TD>
				</TR>
				</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; " class="style33">
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" border="0">
				<TR>
					<TD style="WIDTH: 300px; HEIGHT: 18px" align="center">
                        <table cellpadding="0" cellspacing="0" class="style32">
                            <tr>
                                <td align="right">
                                    <asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Cliente:"></asp:Label>
                                </td>
                                <td align="left">
                                    <asp:textbox id="txtnomcli" Font-Names="Gill Sans MT" runat="server" 
                                        Width="424px" Font-Size="10pt"
							Enabled="False" BorderWidth="1px" Height="21px" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD style="WIDTH: 300px; HEIGHT: 22px" align="right">
                        <table cellpadding="0" cellspacing="0" class="style23">
                            <tr>
                                <td class="style25">
                                    &nbsp; &nbsp;
                                    <asp:Label ID="Label8" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Fecha:"></asp:Label>
                                </td>
                                <td class="style24">
						<asp:dropdownlist id="ddlbalance" Font-Names="Gill Sans MT" runat="server" Width="93px" 
                                        Font-Size="10pt" Height="42px"></asp:dropdownlist>
                                </td>
                                <td>
                                    <asp:Button ID="btbusca" runat="server" 
                    Font-Names="Gill Sans MT" Text="Buscar" Width="85px" />
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px" 
            align="center">
			<table cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                <tr>
                    <td align="right" class="style36">
                        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" 
                            Checked="True" Font-Names="Gill Sans MT" GroupName="grupo" Text="Cultivo" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" 
                            Font-Names="Gill Sans MT" GroupName="grupo" Text="Crianza" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style36">
                                    <asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                                        Text="Elegir:"></asp:Label>
                                </td>
                    <td>
						<asp:dropdownlist id="cmbelegir" Font-Names="Gill Sans MT" runat="server" Width="191px" 
                                        Font-Size="10pt" Height="41px"></asp:dropdownlist>
                                </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style36">
                                    <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                                        Text="Ingreso:"></asp:Label>
                                </td>
                    <td>
                        <asp:textbox id="txtingreso" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt" Enabled="False"
							BorderWidth="1px" TabIndex="1" onChange = "rendimiento()"  
                            onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                    <td>
                                    <asp:rangevalidator id="RangeValidator3" Font-Names="Gill Sans MT" 
                            runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" 
                            ErrorMessage="RangeValidator" ControlToValidate="txtingreso">Valor Inválido</asp:rangevalidator>
                                </td>
                </tr>
                <tr>
                    <td align="right" class="style36">
                                    <asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                                        Text="Costo:"></asp:Label>
                                </td>
                    <td>
                        <asp:textbox id="txtcosto" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt" Enabled="False"
							BorderWidth="1px" TabIndex="2" onChange = "rendimiento()" 
                            onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                    <td>
                                    <asp:rangevalidator id="RangeValidator2" Font-Names="Gill Sans MT" 
                            runat="server" Width="85px" Font-Size="10pt"
							Height="8px" MaximumValue="1000000000" MinimumValue="0" Type="Double" 
                            ErrorMessage="RangeValidator" ControlToValidate="txtcosto">Valor Inválido</asp:rangevalidator>
                                </td>
                </tr>
                <tr>
                    <td align="right" class="style36">
                                    <asp:Label ID="Label13" runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" 
                                        Text="Excedente:"></asp:Label>
                                </td>
                    <td>
                        <asp:textbox id="txtRendimiento" 
                            Font-Names="Gill Sans MT" runat="server" Width="80px" Font-Size="10pt" Enabled="False"
							BorderWidth="1px" TabIndex="1" BorderColor="#2E6A99"></asp:textbox>
                                </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="style36">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnagregar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Grabar" Width="85px" Height="30px" 
                            Font-Size="12pt" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px" 
            align="center">
			<asp:GridView ID="Datagrid1" runat="server" AutoGenerateColumns="False" 
                CssClass="CSSTableGenerator" Font-Names="Gill Sans MT" Font-Size="10pt" 
                Height="148px" Visible="False" Width="697px">
                <Columns>
                    <asp:CommandField ButtonType="Button" CancelText="" DeleteText="" EditText="" 
                        InsertText="" InsertVisible="False" NewText="" SelectText="Quitar" 
                        ShowCancelButton="False" ShowSelectButton="True" UpdateText="">
                        <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                    </asp:CommandField>
<asp:BoundField DataField="ccodigo" HeaderText="Codigo">
    <HeaderStyle Font-Names="Gill Sans MT" />
    <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
</asp:BoundField>
                    <asp:BoundField DataField="descripcion" HeaderText="Cultivo/Crianza">
                    </asp:BoundField>
                    <asp:BoundField DataField="ningreso" HeaderText="Ingreso" 
                        DataFormatString="{0:###,##0.00}">
                        <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ncosto" HeaderText="Costo" 
                        DataFormatString="{0:###,##0.00}">
                        <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                    </asp:BoundField>
                    <asp:BoundField DataField="nrendimiento" HeaderText="Excedente" 
                        DataFormatString="{0:###,##0.00}">
                        <HeaderStyle Font-Names="Gill Sans MT" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>
        </TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px" 
            align="center">
			<table align="right" class="style37">
                <tr>
                    <td align="right" class="style38">
                                    <asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Total Cultivo:"></asp:Label>
                                </td>
                    <td class="style39">
                        <asp:TextBox ID="txtotaling1" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="24px" Width="97px" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td class="style40">
                        <asp:TextBox ID="txtotalcos1" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="24px" Width="97px" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtotalren1" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="24px" Width="97px" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style38">
                                    <asp:Label ID="Label15" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Total Crianza:"></asp:Label>
                                </td>
                    <td class="style39">
                        <asp:TextBox ID="txtotaling2" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="24px" Width="97px" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td class="style40">
                        <asp:TextBox ID="txtotalcos2" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="24px" Width="97px" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtotalren2" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="24px" Width="97px" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px">
            <table 
                    cellpadding="0" cellspacing="0" class="style11" align="center">
                <tr>
                    <td class="style15">
                        <asp:Button ID="btnuevo" runat="server" 
                    Font-Names="Gill Sans MT" Text="Nuevo" Width="85px" Height="25px" />
                    </td>
                    <td class="style14">
                        <asp:Button ID="btini" runat="server" 
                    Font-Names="Gill Sans MT" Text="Inicializar" Width="85px" style="margin-left: 0px" />
                    </td>
                    <td>
                        <asp:Button ID="btimprimir" runat="server" 
                    Font-Names="Gill Sans MT" Text="Imprimir" Width="85px" Height="25px" 
                            Visible="False" />
                    </td>
                </tr>
                </table>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; " class="style34">
			<asp:TextBox ID="Txtcomodin" runat="server" Height="16px" Visible="False" 
                Width="56px"></asp:TextBox>
                        <asp:Button ID="btgrabar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Grabar" Width="85px" Visible="False" />
		</TD>
	</TR>
	</TABLE>
