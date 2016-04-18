<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbSolind.ascx.vb" Inherits="WbSolind" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc2" %>
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
    </script>
&nbsp;<!CDATA[



// ]]></script><style type="text/css">

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
        width: 98%;
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
    .style20
    {
        width: 140px;
        height: 22px;
    }
    .style21
    {
        height: 22px;
    }
                   .style22
                   {
                       width: 154px;
                       height: 32px;
                   }
                   .style23
                   {
                       width: 123px;
                       height: 32px;
                   }
                   .style24
                   {
                       width: 165px;
                       height: 32px;
                   }
                   .style25
                   {
                       height: 32px;
                   }
               </style><table cellpadding="0" cellspacing="0" class="style8" 
    
    style="border: thin solid highlight; WIDTH: 575px; HEIGHT: 440px; BACKGROUND-COLOR: #ffffff">
    <tr>
        <td align="center" class="style9" 
            style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">
                                                SOLICITUD DE CREDITO INDIVIDUAL</td>
    </tr>
    <tr>
        <td class="style9">
            <table align="center" cellpadding="0" cellspacing="0" class="style10">
                <tr>
                    <td align="center" class="style11">
								<asp:RadioButton id="RadioButton1" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="10pt" Font-Bold="True"
									GroupName="tipo" Text="Individual" AutoPostBack="True" Checked="True"></asp:RadioButton>
                    </td>
                    <td class="style12">
                        <asp:textbox id="txtcnomcli" Font-Size="10pt" Width="299px" Font-Names="Gill Sans MT" runat="server"
									Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="style11">
								<asp:RadioButton id="RadioButton2" runat="server" Font-Names="Gill Sans MT" 
                                    Width="80px" Font-Size="10pt"
									Font-Bold="True" GroupName="tipo" Text="Grupal" AutoPostBack="True" 
                            style="margin-left: 11px; margin-bottom: 3px" Visible="False"></asp:RadioButton>
                    </td>
                    <td class="style12">
                        <asp:DropDownList ID="cbxcentros" runat="server" AutoPostBack="True" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="240px" 
                            Visible="False">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style11">
								&nbsp;</td>
                    <td class="style12">
                        <asp:DropDownList ID="cbxgrupos" runat="server" AutoPostBack="True" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="240px" 
                            Visible="False">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style11">
                        <asp:label id="Label7" Font-Size="10pt" Width="63px" Font-Names="Gill Sans MT" 
                            runat="server" Visible="False">Cargo:</asp:label>
                    </td>
                    <td class="style12">
                        <select id="cbxCargo" style="FONT-SIZE: 12px; WIDTH: 302px; FONT-FAMILY: 'Gill Sans MT'"
									name="cbxanacre0" runat="server" visible="False">
									<OPTION selected></OPTION>
								</select></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table cellpadding="0" cellspacing="0" class="style13">
                        <tr>
                            <td align="right" class="style22">
                                <asp:label id="Label8" Font-Size="10pt" Width="89px" Font-Names="Gill Sans MT" 
                            runat="server" Height="16px">Solicitud:</asp:label>
                            </td>
                            <td class="style23">
                                <asp:DropDownList ID="cbxcodins" runat="server" AutoPostBack="True" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="24px" Width="128px">
                                </asp:DropDownList>
                            </td>
                            <td class="style24">
                                <select id="CbxCodOFi" 
                            style="FONT-SIZE: 10px; WIDTH: 140px; FONT-FAMILY: 'Gill Sans MT'" name="CbxCodOFi"
								runat="server">
                                    <OPTION selected></OPTION>
                                </select></td>
                            <td class="style25">
                                <INPUT id="txtNroCta" style="FONT-SIZE: 12px; WIDTH: 138px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
								disabled type="text" size="17" name="txtNroCta" runat="server">
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style16">
                                <asp:label id="Label9" Font-Size="10pt" Width="120px" Font-Names="Gill Sans MT" 
                            runat="server">Codigo del Cliente:</asp:label>
                            </td>
                            <td class="style15">
                                <INPUT id="txtcodcli" style="FONT-SIZE: 12px; WIDTH: 130px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtcodcli" runat="server">
                            </td>
                            <td class="style14">
                                &nbsp;</td>
                            <td>
                                <asp:CheckBox ID="Chkseguro" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Microseguro?" Visible="False" />
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="cbxcodins" />
                </Triggers>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td class="style9">
				&nbsp;</td>
    </tr>
    <tr>
        <td class="style9" align="center">
				<asp:GridView ID="dgGastos" runat="server" AutoGenerateColumns="False" 
                    Font-Names="Gill Sans MT" Font-Size="10pt" 
                    Height="148px" Width="512px" CssClass="CSSTableGenerator">
                    <Columns>
                        <asp:BoundField DataField="ccodigo" HeaderText="Codigo">
                        <ControlStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#009933" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cdescri" HeaderText="Descripción">
                        <ControlStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#009933" />
                        <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Aplicar">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("llogtab") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox2" runat="server" 
                                    Checked='<%# DataBinder.Eval(Container, "DataItem.llogtab") %>' />
                            </ItemTemplate>
                            <ControlStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="#009933" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="style9">
				<asp:label id="lblMostrar" Font-Size="12pt" Width="214px" 
                Font-Names="Gill Sans MT" runat="server"
					ForeColor="#16387C" Height="16px"></asp:label>
            <asp:textbox id="TxtTipcre" Font-Names="Gill Sans MT" runat="server" 
                BorderWidth="1px" Visible="False" Height="17px" Width="98px"></asp:textbox>
            <asp:textbox id="TxtTipgar" Width="90px" Font-Names="Gill Sans MT" runat="server" BorderWidth="1px"
								Visible="False" Height="17px"></asp:textbox>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <table align="center" cellpadding="0" cellspacing="0" class="CSSTableGenerator">
                <tr>
                    <td class="style17">
                        &nbsp;</td>
                    <td>
            <asp:label id="Label10" Font-Size="10pt" Width="196px" Font-Names="Gill Sans MT" 
                runat="server" BorderWidth="0px" Font-Bold="True" 
                ForeColor="#000099" Height="16px">DATOS SOLICITADOS:</asp:label>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label11" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Fuente de Ingreso:</asp:label>
                    </td>
                    <td>
							<select id="cbxfueing" style="FONT-SIZE: 12px; WIDTH: 192px; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
								disabled name="cbxfueing" runat="server">
								<OPTION selected></OPTION>
							</select></td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label12" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Destino de Crédito:</asp:label>
                    </td>
                    <td>
                        <asp:DropDownList ID="cbxdescre" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="192px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label13" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Sector Económico:</asp:label>
                    </td>
                    <td align="left">
							<select id="cbxsececo" 
                            style="FONT-SIZE: 12px; WIDTH: 192px; FONT-FAMILY: 'Gill Sans MT'" disabled
								name="cbxsececo" runat="server">
								<OPTION selected></OPTION>
							</select></td>
                </tr>
                <tr>
                    <td class="style20">
                        <asp:label id="Label14" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px" Visible="False">Fuente de Fondos:</asp:label>
                    </td>
                    <td class="style21">
                        <asp:DropDownList ID="cbxprograma" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="192px" 
                            Visible="False">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label15" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Monto Solicitado:</asp:label>
                    </td>
                    <td>
                        <INPUT id="txtmonsol" style="FONT-SIZE: 14px; WIDTH: 130px; DIRECTION: rtl; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
									disabled type="text" size="16" name="txtmonsol" runat="server" onkeypress="return SoloNumeros(event)"><asp:rangevalidator 
                            id="RangeValidator1" Font-Size="10pt" Width="152px" 
                            Font-Names="Gill Sans MT" runat="server"
									ErrorMessage="RangeValidator" ControlToValidate="txtmonsol" MinimumValue="58" MaximumValue="2000000"
									Type="Double">Monto Solicitado Invalido</asp:rangevalidator></td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label16" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Promotor:</asp:label>
                    </td>
                    <td>
                        <select id="cbxanacre" 
                            style="FONT-SIZE: 12px; WIDTH: 278px; FONT-FAMILY: 'Gill Sans MT'" disabled
								name="cbxanacre" runat="server">
								<OPTION selected></OPTION>
							</select></td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label17" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Fecha de Asignación:</asp:label>
                    </td>
                    <td>
                        <INPUT id="txtfecasi" style="FONT-SIZE: 12px; WIDTH: 130px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtfecasi" runat="server"><asp:TextBox 
                            id="txtccodtmp" runat="server" Font-Names="Gill Sans MT" Width="77px" Font-Size="10pt"
								MaxLength="18" Enabled="False" Visible="False"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label18" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Actividad:</asp:label>
                    </td>
                    <td>
                        <asp:dropdownlist id="cmbactividad" Font-Size="10pt" Width="276px" 
                            Font-Names="Gill Sans MT" runat="server"
								Enabled="False" Height="16px"></asp:dropdownlist>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label19" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Programa:</asp:label>
                    </td>
                    <td>
                        <asp:dropdownlist id="cmbprograma" Font-Size="10pt" Width="276px" 
                            Font-Names="Gill Sans MT" runat="server"
								Enabled="False" Height="16px"></asp:dropdownlist>
                    </td>
                </tr>
                <tr>
                    <td class="style17">
                        <asp:label id="Label20" Font-Size="10pt" Width="124px" Font-Names="Gill Sans MT" 
                            runat="server" Height="17px">Tipo de Crédito:</asp:label>
                    </td>
                    <td>
                        <cc2:CbxClasifCred ID="CbxClasifCred1" runat="server" Enabled="False" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Width="276px">
                        </cc2:CbxClasifCred>
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
                        <INPUT id="btnAplica" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 63px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						disabled tabIndex="9" type="button" name="Button4" runat="server" visible="False"></td>
                    <td align="center">
                        <INPUT id="btnGuardar" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar_b.jpg); WIDTH: 63px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						disabled tabIndex="9" type="button" name="Button5" runat="server"></td>
                    <td align="center">
                        <INPUT id="btncancela" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 65px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						tabIndex="10" type="button" name="Button3" runat="server" visible="False"></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:HiddenField ID="HiddenField1" runat="server" />
        </td>
    </tr>
</table>

<P>&nbsp;</P>
