<%@ Control Language="vb" AutoEventWireup="false" Inherits="WbUsVentas" CodeFile="WbUsVentas.ascx.vb" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<script type="text/javascript">
    function promedio() {
        var primersemestre;
        var segundosemestre;
        primersemestre    = parseFloat(document.getElementById('<%=txtene.ClientID %>').value) + parseFloat(document.getElementById('<%=txtfeb.ClientID %>').value) + parseFloat(document.getElementById('<%=txtmar.ClientID %>').value) + parseFloat(document.getElementById('<%=txtabr.ClientID %>').value) + parseFloat(document.getElementById('<%=txtmay.ClientID %>').value) + parseFloat(document.getElementById('<%=txtjun.ClientID %>').value);
        segundosemestre = parseFloat(document.getElementById('<%=txtjul.ClientID %>').value) + parseFloat(document.getElementById('<%=txtago.ClientID %>').value) + parseFloat(document.getElementById('<%=txtsep.ClientID %>').value) + parseFloat(document.getElementById('<%=txtoct.ClientID %>').value) + parseFloat(document.getElementById('<%=txtnov.ClientID %>').value) + parseFloat(document.getElementById('<%=txtdic.ClientID %>').value);
        document.getElementById('<%=txtpromedio.ClientID %>').value = Math.round( (primersemestre + segundosemestre)/12,2);
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
        height: 42px;
    }
    .style34
    {
        height: 15px;
    }
    .CSSTableGenerator
    {
        width: 482px;
    }
    .style35
    {
        width: 113px;
    }
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 497px; HEIGHT: 404px; "
	cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff; height: 33px;"
				align="center">ESTIMACION DE VENTAS</P>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff" 
                        class="style28">Fecha de Flujo:</TD>
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
							Enabled="False" BorderWidth="1px" Height="22px" BorderColor="#2E6A99"></asp:textbox></TD>
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
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; HEIGHT: 20px">
			<table class="CSSTableGenerator">
                <tr>
                    <td class="style35">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style35">
                                    <asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Enero"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtene" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="1" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td>
                                    <asp:Label ID="Label16" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Julio" ></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtjul" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="7" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style35">
                                    <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Febrero"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtfeb" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="2" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td>
                                    <asp:Label ID="Label17" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Agosto"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtago" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="8" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style35">
                                    <asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Marzo"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtmar" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="3" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td>
                                    <asp:Label ID="Label18" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Septiembre"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtsep" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="9" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style35">
                                    <asp:Label ID="Label13" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Abril"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtabr" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="4" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td>
                                    <asp:Label ID="Label19" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Octubre"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtoct" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="10" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style35">
                                    <asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Mayo"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtmay" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="5" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td>
                                    <asp:Label ID="Label20" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Noviembre"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtnov" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="11" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style35">
                                    <asp:Label ID="Label15" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Junio"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtjun" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="6"></asp:TextBox>
                    </td>
                    <td>
                                    <asp:Label ID="Label21" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Diciembre"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtdic" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Width="75px" onChange = "promedio()" TabIndex="12" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style35">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style35">
                                    <asp:Label ID="Label22" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Promedio Mensual:"></asp:Label>
                                </td>
                    <td>
                        <asp:TextBox ID="txtpromedio" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="12pt" Width="75px" 
                            BorderColor="#2E6A99" BorderWidth="1px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
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
                    <td class="style16">
                        <asp:Button ID="btgrabar" runat="server" 
                    Font-Names="Gill Sans MT" Text="Grabar" Width="85px" />
                    </td>
                    <td class="style14">
                        <asp:Button ID="btini" runat="server" 
                    Font-Names="Gill Sans MT" Text="Inicializar" Width="85px" style="margin-left: 0px" />
                    </td>
                    <td>
                        <asp:Button ID="btimprimir" runat="server" 
                    Font-Names="Gill Sans MT" Text="Imprimir" Width="85px" Height="25px" />
                    </td>
                </tr>
                </table>
		</TD>
	</TR>
	<TR>
		<TD style="COLOR: blue; FONT-FAMILY: 'Century Gothic'; " class="style34">
			<asp:TextBox ID="Txtcomodin" runat="server" Height="16px" Visible="False" 
                Width="56px"></asp:TextBox>
		</TD>
	</TR>
	</TABLE>
