<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbSolidario.ascx.vb" Inherits="Wbsolidario"  %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>
<style type="text/css">
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
    .style15
    {
        width: 60%;
    }
    .style16
    {
        width: 74%;
        height: 24px;
    }
    .style18
    {
        width: 101%;
    }
    .style20
    {
        width: 146px;
    }
    .style21
    {
        width: 68px;
    }
    .style22
    {
        width: 110px;
    }
    .style23
    {
        width: 77%;
    }
    .style24
    {
        width: 130px;
    }
    .style25
    {
        height: 176px;
    }
    .style26
    {
        height: 156px;
    }
    .style27
    {
        width: 90px;
    }
    .style28
    {
        height: 19px;
    }
    .style29
    {
        width: 181px;
    }
</style>
<table cellpadding="0" cellspacing="0" class="style15" 
    style="border: thin solid highlight; WIDTH: 657px; HEIGHT: 481px; BACKGROUND-COLOR: #ffffff">
    <tr>
        <td align="center" 
            style="font-family: Gill Sans MT; font-size: large; color: #003366; font-weight: bold;">
            ABC GRUPOS SOLIDARIOS</tr>
    <tr>
        <td>
            <table cellpadding="0" cellspacing="0" class="style16">
                <tr>
                    <td class="style27">
                        <asp:label id="Label6" Font-Size="10pt" Width="151px" 
                        Font-Names="Gill Sans MT" runat="server" Height="16px" Font-Bold="True" 
                            ForeColor="#003366">Grupo Solidario:</asp:label>
                    </td>
                    <td align="left">
                        <asp:textbox id="txtcnomcli" Font-Size="8pt" Width="321px" Font-Names="Gill Sans MT" runat="server"
						Font-Bold="True" Enabled="False" BorderWidth="1px"></asp:textbox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table align="left" cellpadding="0" cellspacing="0" class="style18">
                <tr>
                    <td class="style29">
                        <asp:label id="Label11" Font-Size="10pt" Width="71px" 
                        Font-Names="Gill Sans MT" runat="server" Height="16px" Font-Bold="True" 
                            ForeColor="#003366">Sucursal:</asp:label>
                    </td>
                    <td class="style20">
                        <SELECT id="cbxCodins" 
                            style="FONT-SIZE: 12px; WIDTH: 140px; FONT-FAMILY: 'Gill Sans MT'" name="cbxCodins"
								runat="server">
								<OPTION selected></OPTION>
							</SELECT></td>
                    <td class="style21">
                        <SELECT id="CbxCodOFi" style="FONT-SIZE: 12px; WIDTH: 176px; FONT-FAMILY: 'Gill Sans MT'" name="CbxCodOFi"
								runat="server">
								<OPTION selected></OPTION>
							</SELECT></td>
                    <td class="style22">
                        <INPUT id="txtNroCta" style="FONT-SIZE: 12px; WIDTH: 128px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtNroCta" runat="server"></td>
                    <td>
				<asp:textbox id="txtccodtmp" Font-Size="8pt" Width="54px" Font-Names="Gill Sans MT" runat="server"
					Enabled="False" Visible="False" MaxLength="18" Height="16px" style="margin-left: 0px"></asp:textbox>
                            </td>
                </tr>
                <tr>
                    <td class="style29">
                        <asp:label id="Label12" Font-Size="10pt" Width="128px" 
                        Font-Names="Gill Sans MT" runat="server" Height="16px" Font-Bold="True" 
                            ForeColor="#003366">Codigo Grupo:</asp:label>
                    </td>
                    <td class="style20">
                        <INPUT id="txtcodcli" style="FONT-SIZE: 12px; WIDTH: 128px; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px"
								disabled type="text" size="16" name="txtcodcli" runat="server"></td>
                    <td class="style21">
                        <asp:textbox id="TxtTipcre" Width="128px" Font-Names="Gill Sans MT" runat="server" BorderWidth="1px"
								Visible="False"></asp:textbox>
                    </td>
                    <td class="style22">
                        <asp:textbox id="TxtTipgar" Width="136px" Font-Names="Gill Sans MT" runat="server" BorderWidth="1px"
								Visible="False"></asp:textbox>
                    </td>
                    <td align="center">
                        <asp:TextBox 
                        ID="txtflag" runat="server" Height="16px" Width="40px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
				<asp:label id="lblMostrar" Font-Size="X-Small" Width="112px" Font-Names="Gill Sans MT" runat="server"
					ForeColor="#16387C" Height="16px"></asp:label>
        </td>
    </tr>
    <tr>
        <td class="style28">
                            <asp:textbox id="Textbox2" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black" Visible="False"></asp:textbox>
                            <asp:textbox id="Textbox5" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black" TabIndex="14" Visible="False"></asp:textbox>
            </td>
    </tr>
    <tr>
        <td class="style26">
                <table border="1" cellpadding="0" cellspacing="0" class="CSSTableGenerator" 
                    
                style="border-color: #000099; background-color: #FF9DCE; height: 142px;" 
                align="center">
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
            <asp:label id="Label13" Font-Size="12pt" Width="199px" 
                        Font-Names="Gill Sans MT" runat="server" Height="16px" 
                BackColor="#FFFF66" BorderWidth="1px" Font-Bold="False" ForeColor="#003366">Datos 
  del Grupo Solidario</asp:label>
                        </td>
                        <td class="style8">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label1" Font-Size="8pt" Width="154px" 
                                Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="16px">Nombre del Grupo Solidario:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="Textbox1" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black" Height="24px" TabIndex="10" CssClass="ToUpper"></asp:textbox>
                        </td>
                        <td class="style8">
                            <asp:label id="Label8" Font-Size="8pt" Width="99px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Estado:</asp:label>
                        </td>
                        <td>
                            <asp:dropdownlist id="cmbDep" Font-Names="CALIBRI" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="165px" AutoPostBack="True" tabIndex="15"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label2" Font-Size="8pt" Width="88px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Dia de Reunión:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:DropDownList ID="CMBDIAS" runat="server" Enabled="False" 
                                Font-Names="Calibri" Font-Size="10pt" Height="24px" TabIndex="11" Width="200px">
                                <asp:ListItem Value="1">LUNES</asp:ListItem>
                                <asp:ListItem Value="2">MARTES</asp:ListItem>
                                <asp:ListItem Value="3">MIERCOLES</asp:ListItem>
                                <asp:ListItem Value="4">JUEVES</asp:ListItem>
                                <asp:ListItem Value="5">VIERNES</asp:ListItem>
                                <asp:ListItem Value="6">SABADO</asp:ListItem>
                                <asp:ListItem Value="7">DOMINGO</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="style8">
                            <asp:label id="Label9" Font-Size="8pt" Width="86px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Municipio:</asp:label>
                        </td>
                        <td>
                            <asp:dropdownlist id="cmbMun" Font-Names="CALIBRI" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="165px" AutoPostBack="True" tabIndex="16"></asp:dropdownlist>
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
								BorderWidth="1px" ForeColor="Black" TabIndex="12"></asp:textbox>
                        </td>
                        <td class="style8">
                            <asp:label id="Label10" Font-Size="8pt" Width="80px" 
                                Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Colonia:</asp:label>
                        </td>
                        <td>
                            <asp:dropdownlist id="cmbCant" Font-Names="CALIBRI" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="165px" tabIndex="17"></asp:dropdownlist>
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
								BorderWidth="1px" ForeColor="Black" TabIndex="13"></asp:textbox>
                        </td>
                        <td class="style8">
                            &nbsp;</td>
                        <td>
                            <asp:dropdownlist id="cmbCentro" Font-Names="CALIBRI" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="163px" AutoPostBack="True" tabIndex="18" Height="24px" Visible="False"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label5" Font-Size="8pt" Width="64px" Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Frecuencia:</asp:label>
                        </td>
                        <td class="style7">
                            <cc1:CbxFormaPag ID="CbxFormaPag1" runat="server" Font-Names="Calibri" 
                                Font-Size="10pt" Height="24px" Width="200px" Enabled="False" TabIndex="14">
                            </cc1:CbxFormaPag>
                        </td>
                        <td class="style8">
							<asp:label id="Label7" runat="server" Font-Names="Century Gothic" Width="87px" Font-Size="8pt"
								Height="16px" ForeColor="#000040">Activo?</asp:label>
                        </td>
                        <td>
							<asp:CheckBox id="CheckBox1" runat="server" Font-Names="8" TabIndex="19"></asp:CheckBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:label id="Label14" Font-Size="8pt" Width="120px" 
                                Font-Names="Century Gothic" runat="server"
								ForeColor="#000040" Height="15px">Codigo Presidente:</asp:label>
                        </td>
                        <td class="style7">
                            <asp:textbox id="TxtCodPresidente" Font-Size="9pt" Width="200px" 
                                Font-Names="Century Gothic" runat="server"
								BorderWidth="1px" ForeColor="Black" TabIndex="14" Enabled="False"></asp:textbox>
                        </td>
                        <td class="style8">
							&nbsp;</td>
                        <td>
							&nbsp;</td>
                    </tr>
                </table>
            </td>
    </tr>
    <tr>
        <td class="style25" align="center">
                <asp:GridView ID="Grid_Grupo" runat="server" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="651px">
                    <Columns>                        
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                            <ControlStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:CommandField>
                        <asp:BoundField DataField="ccodcli" HeaderText="Codigo de Cliente">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnomcli" HeaderText="Nombre del Cliente">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnudoci" HeaderText="Identificacion" >
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" />
                        </asp:BoundField>                        
                        <asp:BoundField DataField="dfecnac" HeaderText="Fecha de Nacimiento" DataFormatString="{0:dd-MM-yyyy}">
                            <HeaderStyle Font-Names="Gill Sans MT" />
                            <ItemStyle Font-Names="Gill Sans MT" HorizontalAlign="Right"  />
                        </asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton ID="ibt" runat="server" 
                                      CommandArgument='<%# Bind("ccodcli") %>' ImageUrl="~/imagenes/delete.png" 
                                      onclick="ibt_Click"                                             
                                       onclientclick="return confirm('¿Confirma que desea eliminar el registro indicado?');" />
                                 </ItemTemplate>
                        </asp:TemplateField> 
                    </Columns>
                    <FooterStyle Font-Names="Gill Sans MT" />
                    <PagerStyle Font-Names="Gill Sans MT" />
                    <HeaderStyle BackColor="#99CC00" ForeColor="#003366" />
                    <AlternatingRowStyle BackColor="#CCFF66" />
                </asp:GridView>
		    </td>
    </tr>
    <tr>
        <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style23">
                <tr>
                    <td align="center" class="style24">
                        <INPUT id="btnAplica" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 63px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						tabIndex="0" type="button" name="Button4" runat="server"></td>
                    <td align="center" class="style8">
                        <INPUT id="btnGraba" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_guardar2_b.gif); WIDTH: 66px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						disabled tabIndex="20" type="button" name="Button2" runat="server"></td>
                    <td align="center">
                        <INPUT id="btncancela" style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 65px; COLOR: buttontext; BACKGROUND-REPEAT: no-repeat; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 55px; BACKGROUND-COLOR: transparent"
						tabIndex="21" type="button" name="Button3" runat="server"></td>
                    <td align="center">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="52px" 
                            ImageUrl="~/web/jpgs/printer.jpg" Width="60px" TabIndex="26" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
</table>

