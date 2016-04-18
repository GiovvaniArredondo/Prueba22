<%@ control language="vb" autoeventwireup="false" inherits="WbSolcredbc, App_Web_yl8dokps" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<script language="javascript" type="text/javascript">
// <!CDATA[



// ]]>
</script>





<style type="text/css">

    .style8
    {
        width: 70%;
    }
    .style9
    {
        width: 619px;
    }
    .style10
    {
        width: 93%;
    }
    .style11
    {
        width: 107px;
    }
    .style12
    {
        width: 207px;
    }
    .style13
    {
        width: 74%;
        height: 47px;
    }
    .style16
    {
        width: 154px;
    }
    .style15
    {
        width: 123px;
    }
    .style14
    {
        width: 165px;
    }
    .style17
    {
        width: 140px;
    }
    .style18
    {
        width: 92%;
        height: 68px;
    }
    .style19
    {
        width: 193px;
    }
</style>



<table cellpadding="0" cellspacing="0" class="style8" 
    style="border: thin solid highlight; WIDTH: 525px; HEIGHT: 440px; BACKGROUND-COLOR: #ffffff">
    <tr>
        <td align="center" class="style9" 
            style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'">
                        SOLICITUD DE CREDITOS BANCO COMUNAL</td>
    </tr>
    <tr>
        <td class="style9">
            <table align="center" cellpadding="0" cellspacing="0" class="style10">
                <tr>
                    <td align="center" class="style11">
								<asp:RadioButton id="RadioButton1" runat="server" Font-Names="Verdana" 
                                    Font-Size="8pt" Font-Bold="True"
									GroupName="tipo" Text="Individual" AutoPostBack="True" Visible="False"></asp:RadioButton>
                    </td>
                    <td class="style12">
                        <asp:textbox id="txtcnomcli" Font-Size="8pt" Width="299px" Font-Names="Verdana" runat="server"
									Font-Bold="True" Enabled="False" BorderWidth="1px" Visible="False"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style11">
								<asp:RadioButton id="RadioButton2" runat="server" Font-Names="Verdana" 
                                    Width="139px" Font-Size="8pt"
									Font-Bold="True" GroupName="tipo" Text="Banco Comunal:" AutoPostBack="True" Checked="True" 
                            style="margin-left: 11px; margin-bottom: 3px"></asp:RadioButton>
                    </td>
                    <td class="style12">
                        <asp:DropDownList ID="cbxgrupos" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="240px" 
                            Enabled="False">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style11">
                        <asp:label id="Label7" Font-Size="8pt" Width="148px" Font-Names="Verdana" 
                            runat="server" Height="16px">Cargo:</asp:label>
                    </td>
                    <td class="style12">
                        <select id="cbxCargo" style="FONT-SIZE: 12px; WIDTH: 240px; FONT-FAMILY: 'Century Gothic'; height: 5px;"
									name="cbxanacre0" runat="server">
									<OPTION selected></OPTION>
								</select></td>
                </tr>
                <tr>
                    <td align="right" class="style11">
                        &nbsp;</td>
                    <td class="style12">
                        <asp:DropDownList ID="cbxcentros" runat="server" AutoPostBack="True" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="32px" 
                            Visible="False">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <table cellpadding="0" cellspacing="0" class="style13">
                <tr>
                    <td align="right" class="style16">
                        <asp:label id="Label8" Font-Size="8pt" Width="89px" Font-Names="Verdana" 
                            runat="server" Height="16px">Solicitud:</asp:label>
                    </td>
                    <td class="style15">
                        <select id="cbxCodins" 
                            style="FONT-SIZE: 12px; WIDTH: 129px; FONT-FAMILY: 'Verdana'" name="cbxCodins"
								runat="server">
								<OPTION selected></OPTION>
							</select></td>
                    <td class="style14">
                        <select id="CbxCodOFi" 
                            style="FONT-SIZE: 12px; WIDTH: 140px; FONT-FAMILY: 'Verdana'" name="CbxCodOFi"
								runat="server">
								<OPTION selected></OPTION>
							</select></td>
                    <td>
                        <INPUT id="txtNroCta" style="FONT-SIZE: 12px; WIDTH: 138px; FONT-FAMILY: 'Verdana'; HEIGHT: 22px"
								disabled type="text" size="17" name="txtNroCta" runat="server"></td>
                </tr>
                <tr>
                    <td align="right" class="style16">
                        <asp:label id="Label9" Font-Size="8pt" Width="120px" Font-Names="Verdana" 
                            runat="server">Codigo del Cliente:</asp:label>
                    </td>
                    <td class="style15">
                        <INPUT id="txtcodcli" style="FONT-SIZE: 12px; WIDTH: 130px; FONT-FAMILY: 'Verdana'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtcodcli" runat="server"></td>
                    <td class="style14">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style9">
				<asp:label id="lblMostrar" Font-Size="X-Small" Width="214px" 
                Font-Names="Verdana" runat="server"
					ForeColor="#16387C" Height="16px"></asp:label>
            <asp:textbox id="TxtTipcre" Font-Names="Verdana" runat="server" 
                BorderWidth="1px" Visible="False" Height="17px" Width="98px"></asp:textbox>
            <asp:textbox id="TxtTipgar" Width="90px" Font-Names="Verdana" runat="server" BorderWidth="1px"
								Visible="False" Height="17px"></asp:textbox>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:label id="Label10" Font-Size="8pt" Width="529px" Font-Names="Verdana" 
                runat="server" BackColor="#FFFF66" BorderWidth="2px" Font-Bold="True" 
                ForeColor="#000099" Height="17px">DATOS SOLICITADOS:</asp:label>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <table align="center" cellpadding="0" cellspacing="0" class="style13">
                <tr>
                    <td class="style17">
                        <asp:label id="Label11" Font-Size="8pt" Width="124px" Font-Names="Verdana" 
                            runat="server" Height="17px">Fuente de Ingreso:</asp:label>
                    </td>
                    <td>
							<select id="cbxfueing" style="FONT-SIZE: 12px; WIDTH: 192px; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'"
								disabled name="cbxfueing" runat="server">
								<OPTION selected></OPTION>
							</select></td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label12" Font-Size="8pt" Width="124px" Font-Names="Verdana" 
                            runat="server" Height="17px">Destino de Crédito:</asp:label>
                    </td>
                    <td>
                        <asp:DropDownList ID="cbxdescre" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="192px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label13" Font-Size="8pt" Width="124px" Font-Names="Verdana" 
                            runat="server" Height="17px">Sector Económico:</asp:label>
                    </td>
                    <td align="left">
							<select id="cbxsececo" 
                            style="FONT-SIZE: 12px; WIDTH: 192px; FONT-FAMILY: 'Verdana'" disabled
								name="cbxsececo" runat="server">
								<OPTION selected></OPTION>
							</select></td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label14" Font-Size="8pt" Width="124px" Font-Names="Verdana" 
                            runat="server" Height="17px">Fuente de Fondos:</asp:label>
                    </td>
                    <td>
                        <asp:DropDownList ID="cbxprograma" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="16px" Width="192px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label15" Font-Size="8pt" Width="124px" Font-Names="Verdana" 
                            runat="server" Height="17px">Monto Solicitado:</asp:label>
                    </td>
                    <td>
                        <INPUT id="txtmonsol" style="FONT-SIZE: 12px; WIDTH: 130px; DIRECTION: rtl; FONT-FAMILY: 'Verdana'; HEIGHT: 22px"
									disabled type="text" size="16" name="txtmonsol" runat="server"><asp:rangevalidator 
                            id="RangeValidator1" Font-Size="8pt" Width="152px" Font-Names="Verdana" runat="server"
									ErrorMessage="RangeValidator" ControlToValidate="txtmonsol" MinimumValue="58" MaximumValue="1000000"
									Type="Double">Monto Solicitado Invalido</asp:rangevalidator>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label16" Font-Size="8pt" Width="124px" Font-Names="Verdana" 
                            runat="server" Height="17px">Analista:</asp:label>
                    </td>
                    <td>
                        <select id="cbxanacre" 
                            style="FONT-SIZE: 12px; WIDTH: 276px; FONT-FAMILY: calibri" disabled
								name="cbxanacre" runat="server">
								<OPTION selected></OPTION>
							</select></td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label17" Font-Size="8pt" Width="124px" Font-Names="Verdana" 
                            runat="server" Height="17px">Fecha de Asignación:</asp:label>
                    </td>
                    <td>
                        <INPUT id="txtfecasi" style="FONT-SIZE: 12px; WIDTH: 130px; FONT-FAMILY: 'Verdana'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtfecasi" runat="server"><asp:TextBox 
                            id="txtccodtmp" runat="server" Font-Names="Verdana" Width="77px" Font-Size="8pt"
								MaxLength="18" Enabled="False" Visible="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label18" Font-Size="8pt" Width="124px" Font-Names="Verdana" 
                            runat="server" Height="17px">Actividad:</asp:label>
                    </td>
                    <td>
                        <asp:dropdownlist id="cmbactividad" Font-Size="8pt" Width="276px" 
                            Font-Names="Verdana" runat="server"
								Enabled="False" Height="16px"></asp:dropdownlist>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <table cellpadding="0" cellspacing="0" class="style18">
                <tr>
                    <td align="center" class="style19">
                        <INPUT id="btnAplica" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 63px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						disabled tabIndex="9" type="button" name="Button4" runat="server"></td>
                    <td align="center">
                        <INPUT id="btnGuardar" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 63px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						disabled tabIndex="9" type="button" name="Button5" runat="server"></td>
                    <td align="center">
                        <INPUT id="btncancela" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 65px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Verdana'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						tabIndex="10" type="button" name="Button3" runat="server" visible="False"></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
    </tr>
</table>

<P>&nbsp;</P>
