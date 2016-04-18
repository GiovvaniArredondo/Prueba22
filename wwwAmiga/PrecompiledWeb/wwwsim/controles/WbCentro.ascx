<%@ control language="vb" autoeventwireup="false" inherits="Wbcentro, App_Web_pi2jwlis" %>
<style type="text/css">
    .style5
    {
        width: 97%;
    }
    .style6
    {
        width: 101px;
    }
    .style7
    {
        width: 410px;
    }
    .style8
    {
        width: 141px;
    }
</style>
<P>
	<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 636px; HEIGHT: 424px; BACKGROUND-COLOR: #ffffff"
		cellSpacing="0" cellPadding="0" align="left" border="0">
		<TR>
			<TD style="HEIGHT: 20px">
				<P class="PageTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
					align="center">CENTRO</P>
				<P class="PageTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
					align="center"><asp:label id="Label6" Font-Size="8pt" Width="63px" Font-Names="Verdana" runat="server">Centro:</asp:label><asp:textbox id="txtcnomcli" Font-Size="8pt" Width="321px" Font-Names="Verdana" runat="server"
						Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox></P>
			</TD>
		</TR>
		<TR>
			<TD>
				<TABLE id="Table2" style="WIDTH: 528px; HEIGHT: 48px" cellSpacing="0" cellPadding="0" width="528"
					border="0">
					<TR>
						<TD>
							<DIV id="DIV1" style="DISPLAY: inline; FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 80px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 16px"
								runat="server" ms_positioning="FlowLayout">
								<P>Sucursal:</P>
							</DIV>
						</TD>
						<TD style="WIDTH: 102px"><SELECT id="cbxCodins" style="FONT-SIZE: 12px; WIDTH: 120px; FONT-FAMILY: 'Verdana'" name="cbxCodins"
								runat="server">
								<OPTION selected></OPTION>
							</SELECT></TD>
						<TD style="WIDTH: 147px"><SELECT id="CbxCodOFi" style="FONT-SIZE: 12px; WIDTH: 176px; FONT-FAMILY: 'Verdana'" name="CbxCodOFi"
								runat="server">
								<OPTION selected></OPTION>
							</SELECT></TD>
						<TD><INPUT id="txtNroCta" style="FONT-SIZE: 12px; WIDTH: 128px; FONT-FAMILY: 'Verdana'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtNroCta" runat="server"></TD>
						<TD>
							<P align="right">&nbsp;</P>
							<script language="javascript">
							function ejecutarBusqueda(){
								var clienteSeleccionado;
								clienteSeleccionado = window.open("WebForm3.aspx","busquedaCliente","resizable:no;dialogHeight:600px;dialogWidth:600px;scroll:no;");
								//alert(clienteSeleccionado);	
								return false;							
							}
							</script>
						</TD>
					</TR>
					<TR>
						<TD>
							<DIV id="DIV2" style="DISPLAY: inline; FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 112px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 16px"
								runat="server" ms_positioning="FlowLayout">
								<P>Código Centro:</P>
							</DIV>
						</TD>
						<TD style="WIDTH: 102px"><INPUT id="txtcodcli" style="FONT-SIZE: 12px; WIDTH: 128px; FONT-FAMILY: 'Verdana'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtcodcli" runat="server"></TD>
						<TD style="WIDTH: 147px"><asp:textbox id="TxtTipcre" Width="128px" Font-Names="Verdana" runat="server" BorderWidth="1px"
								Visible="False"></asp:textbox></TD>
						<TD><asp:textbox id="TxtTipgar" Width="136px" Font-Names="Verdana" runat="server" BorderWidth="1px"
								Visible="False"></asp:textbox></TD>
						<TD></TD>
					</TR>
				</TABLE>
				<asp:label id="lblMostrar" Font-Size="X-Small" Width="112px" Font-Names="Verdana" runat="server"
					ForeColor="#16387C" Height="16px"></asp:label></TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 17px" bgColor="#FFFFCC">
				<DIV style="DISPLAY: inline; FONT-SIZE: 10pt; WIDTH: 499px; COLOR: #000099; FONT-STYLE: normal; FONT-FAMILY: 'Century Gothic'; HEIGHT: 18px;"
					ms_positioning="FlowLayout">
					<P style="border-color: #000000; height: 17px; width: 639px; background-color: #FFFF00; font-family: 'Century Gothic'; font-size: x-small; font-style: normal;">
                        Datos del Centro</P>
				</DIV>
			</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 174px" align="center">
				<asp:textbox id="txtccodtmp" Font-Size="8pt" Width="131px" Font-Names="Verdana" runat="server"
					Enabled="False" Visible="False" MaxLength="18"></asp:textbox>
                <table border="1" cellpadding="0" cellspacing="0" class="style5" 
                    style="border-color: #000000; background-color: #99CCFF; height: 142px;">
                    <tr>
                        <td class="style6">
                            <asp:label id="Label1" Font-Size="8pt" Width="111px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Nombre del Centro:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox1" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black" Height="24px"></asp:textbox>
                        </td>
                        <td class="style8">
                            <asp:label id="Label8" Font-Size="8pt" Width="99px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Departamento:</asp:label>
                        </td>
                        <td>
                            <asp:dropdownlist id="cmbDep" Font-Names="Verdana" Font-Size="8pt" 
                                Enabled="False" runat="server"
								Width="165px" AutoPostBack="True" tabIndex="10"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label2" Font-Size="8pt" Width="88px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Dia de Reunión:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox2" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black"></asp:textbox>
                        </td>
                        <td class="style8">
                            <asp:label id="Label9" Font-Size="8pt" Width="86px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Municipio:</asp:label>
                        </td>
                        <td>
                            <asp:dropdownlist id="cmbMun" Font-Names="Verdana" Font-Size="8pt" 
                                Enabled="False" runat="server"
								Width="165px" AutoPostBack="True" tabIndex="11"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label3" Font-Size="8pt" Width="96px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Hora de Reunión:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox3" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black"></asp:textbox>
                        </td>
                        <td class="style8">
                            <asp:label id="Label10" Font-Size="8pt" Width="80px" 
                                Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Cantón:</asp:label>
                        </td>
                        <td>
                            <asp:dropdownlist id="cmbCant" Font-Names="Verdana" Font-Size="8pt" 
                                Enabled="False" runat="server"
								Width="165px" AutoPostBack="True" tabIndex="12"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label4" Font-Size="8pt" Width="104px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Lugar de Reunión:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox4" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black"></asp:textbox>
                        </td>
                        <td class="style8">
							<asp:label id="Label7" runat="server" Font-Names="Century Gothic" Width="87px" Font-Size="8pt"
								Height="16px" ForeColor="#000040">Activo?</asp:label>
                        </td>
                        <td>
							<asp:CheckBox id="CheckBox1" runat="server" Font-Names="8"></asp:CheckBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label5" Font-Size="8pt" Width="64px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Frecuencia:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox5" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black"></asp:textbox>
                        </td>
                        <td class="style8">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </TD>
		</TR>
		<TR>
			<TD>
				<P align="center"><INPUT id="btnAplica" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 63px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						tabIndex="9" type="button" name="Button2" runat="server">&nbsp;&nbsp;<INPUT id="btnGraba" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 66px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						disabled tabIndex="9" type="button" name="Button2" runat="server">&nbsp; 
					&nbsp;<INPUT id="btncancela" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 65px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						tabIndex="10" type="button" name="Button3" runat="server"></P>
			</TD>
		</TR>
	</TABLE>
</P>
<P>&nbsp;</P>
