<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbUConyuge.ascx.vb" Inherits="WbUConyuge"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<style type="text/css">
    .style4
    {
        width: 100%;
        height: 86px;
        margin-right: 0px;
    }
    .style5
    {
        width: 122px;
    }
    .style6
    {
        height: 22px;
        width: 222px;
    }
    .style8
    {
        height: 23px;
        width: 222px;
    }
    .style9
    {
        height: 2px;
        width: 222px;
    }
    .style11
    {
        height: 22px;
        width: 11px;
    }
    .style13
    {
        height: 23px;
        width: 11px;
    }
    .style14
    {
        height: 2px;
        width: 11px;
    }
    .style19
    {
        width: 114px;
        height: 4px;
    }
    .style22
    {
        height: 4px;
    }
    .style23
    {
        height: 4px;
        width: 222px;
    }
    .style24
    {
        height: 4px;
        width: 11px;
    }
    .style25
    {
        width: 172px;
    }
    .style27
    {
        width: 100%;
    }
    .style28
    {
        width: 122px;
        height: 29px;
    }
    .style29
    {
        width: 172px;
        height: 29px;
    }
    .style31
    {
        height: 29px;
    }
    .style33
    {
        width: 114px;
        height: 32px;
    }
    .style34
    {
        height: 32px;
        width: 222px;
    }
    .style35
    {
        height: 32px;
        width: 11px;
    }
    .style36
    {
        height: 32px;
    }
    .style37
    {
        width: 133px;
    }
    .style38
    {
        width: 133px;
        height: 29px;
    }
    .style1
    {
        height: 21px;
        width: 81px;
    }
    .style2
    {
        height: 26px;
        width: 81px;
    }
    #Table3
    {
        width: 84%;
        height: 100px;
    }
    .style43
    {
        width: 27px;
        height: 16px;
    }
    .style44
    {
        height: 16px;
    }
    .style45
    {
        height: 16px;
        width: 81px;
    }
    .style46
    {
        width: 27px;
        height: 4px;
    }
    .style47
    {
        height: 4px;
        width: 81px;
    }
    </style>
<head id="Head1" runat="server" />

    <script src="js/jquery.js" type="text/javascript"></script>    
    <script type="text/javascript" src="js/lib.js"></script>
    <script type="text/javascript">
        function HabilitaCampos() {
            //2 y 6 se habilitan los campos si son diferentes de deshabilitan

            var EstadoCivil = document.getElementById("<%=cmbEstCli.ClientID %>").options[document.getElementById("<%=cmbEstCli.ClientID %>").selectedIndex].value
            if (EstadoCivil == 2 || EstadoCivil == 6) {
                document.getElementById("<%=TxtNomC.ClientID %>").disabled = false;
                document.getElementById("<%=TxtIdCony.ClientID %>").disabled = false;
                document.getElementById("<%=cmbProfCony.ClientID %>").disabled = false;
                document.getElementById("<%=TxtNacCony.ClientID %>").disabled = false;
                document.getElementById("<%=cmbGenCony.ClientID %>").disabled = false;
                document.getElementById("<%=Sleer.ClientID %>").disabled = false;
                //alert("lo habilite")
            }
            else {
                document.getElementById("<%=TxtNomC.ClientID %>").disabled = true;
                document.getElementById("<%=TxtIdCony.ClientID %>").disabled = true;
                document.getElementById("<%=cmbProfCony.ClientID %>").disabled = true;
                document.getElementById("<%=TxtNacCony.ClientID %>").disabled = true;
                document.getElementById("<%=cmbGenCony.ClientID %>").disabled = true;
                document.getElementById("<%=Sleer.ClientID %>").disabled = true;
            }

        }

        function CargaMuni0() {
            $.ajax({
                type: "POST",
                url: "ajax/Municipios0.ashx",
                data: "Departamento0=" + document.getElementById("<%=DropDownDeptos0.ClientID %>").options[document.getElementById("<%=DropDownDeptos0.ClientID %>").selectedIndex].value,
                success: function(html) {
                $("#<%=DropDownMuni0.ClientID %>").html(html);
                CargaComu0();
                 }
            });
        }

                    
        function CargaMuni() {    
    	$.ajax({
  			type: "POST",
  			url: "ajax/Municipios.ashx",
  			data: "Departamento=" + document.getElementById("<%=DropDownDeptos.ClientID %>").options[document.getElementById("<%=DropDownDeptos.ClientID %>").selectedIndex].value,
  			success: function(html){
  			$("#<%=DropDownMuni.ClientID %>").html(html);
  			 CargaComu();
  			}
  		});  		
		}
		function CargaComu() {    
    	$.ajax({
  			type: "POST",
  			url: "ajax/Comunidades.ashx",
  			data: "Municipio=" + document.getElementById("<%=DropDownMuni.ClientID %>").options[document.getElementById("<%=DropDownMuni.ClientID %>").selectedIndex].value,
  			success: function(html){
  			$("#<%=DropDownComu.ClientID %>").html(html);  			  
  			}
  		});  		
		}

		function CargaComu0() {
		    $.ajax({
		        type: "POST",
		        url: "ajax/Comunidades0.ashx",
		        data: "Municipio0=" + document.getElementById("<%=DropDownMuni0.ClientID %>").options[document.getElementById("<%=DropDownMuni0.ClientID %>").selectedIndex].value,
		        success: function(html) {
		            $("#<%=DropDownComu0.ClientID %>").html(html);
		        }
		    });
		}	

       function Getfecha(){
           document.getElementById('<%=TxtEdad.ClientID %>').value = calcular_edad(document.getElementById('<%=TxtDfecnaci.ClientID %>').value);	         
	    }

       function Getfecha1(){
           document.getElementById('<%=TxtEdadCony.ClientID %>').value = calcular_edad(document.getElementById('<%=TxtNacCony.ClientID %>').value);	         
	    }
	    
    </script>

<P style="FONT-SIZE: 11pt; FONT-FAMILY: 'Gill Sans MT'">
	<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 720px; HEIGHT: 906px; BACKGROUND-COLOR: #FFFFFF"
		cellSpacing="0" cellPadding="0" border="0">
		<TR>
			<TD>
				<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #006699; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
					align="center">DATOS GENERALES DEL CONYUGE/FAMILIAR<asp:Image ID="ImageFoto" runat="server" Height="58px" Visible="False" 
                        Width="83px" />
                </P>
			</TD>
		</TR>
		<tr>
			<TD style="HEIGHT: 16px; BACKGROUND-COLOR: silver">
				<P style="FONT-WEIGHT: normal; FONT-SIZE: 11pt; COLOR: White; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #006699"
					align="center">Identificación</P>
			</TD>
		</tr>
		<TR>
			<TD align="center">
				<TABLE id="Table2" style="WIDTH: 652px; HEIGHT: 112px" cellSpacing="0" 
                    cellPadding="0" border="0">
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">Conyuge/Familiar:</TD>
						<TD class="style6"><asp:textbox id="TxtCodigo" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False" runat="server"></asp:textbox></TD>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style11">Oficina</TD>
						<TD style="HEIGHT: 22px"><asp:dropdownlist id="cmbOficina" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False" runat="server"
								Width="184px" tabIndex="1"></asp:dropdownlist></TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
                            <asp:Label ID="Label8" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Primer Nombre:" Width="124px"></asp:Label>
                        </TD>
						<TD class="style23"><asp:textbox id="TxtNomcli" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="200px" tabIndex="3"></asp:textbox></TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
							<asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Primer Apellido:" Width="124px"></asp:Label>
						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            <asp:textbox id="Txtpriape" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="200px" tabIndex="6"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
                            <asp:Label ID="Label7" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Segundo Nombre:" Width="124px"></asp:Label>
                        </TD>
						<TD class="style23">
                            <asp:textbox id="Txtsegnom" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="200px" tabIndex="4"></asp:textbox></TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
							<asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Segundo Apellido:" Width="124px"></asp:Label>
						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            <asp:textbox id="Txtsegape" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="200px" tabIndex="7"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
                            <asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Tercer Nombre:" Width="124px"></asp:Label>
                        </TD>
						<TD class="style23">
                            <asp:textbox id="Txtternom" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="200px" tabIndex="5"></asp:textbox></TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
							<asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Apellido de Casada:" Width="124px"></asp:Label>
						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            <asp:textbox id="Txtapecasada" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="200px" tabIndex="8"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
							<asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Tipo de Doc.:" Width="124px"></asp:Label>
						</TD>
						<TD class="style23">
                            <asp:dropdownlist id="cmbTipDoc" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="208px" tabIndex="9" AutoPostBack="True"></asp:dropdownlist></TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
							<asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Fec.Nacimiento:" Width="124px"></asp:Label>
						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            <table cellpadding="0" cellspacing="0" class="style27">
                                <tr>
                                    <td>
                            
                            <asp:TextBox ID="TxtDfecnaci" runat="server" onChange = "Getfecha()" BackColor="White" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Width="116px" tabIndex="11"></asp:TextBox>
                            <cc1:MaskedEditExtender ID="Mask_EditExt1" runat="server" 
                                CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                Mask="99/99/9999" MaskType="Date" TargetControlID="TxtDfecnaci">
                            </cc1:MaskedEditExtender>
                            <cc1:CalendarExtender ID="TxtDfecnaci_CalendarExtender" runat="server" 
                                Format="dd/MM/yyyy" PopupButtonID="Image_btn1" TargetControlID="TxtDfecnaci">
                            </cc1:CalendarExtender>
                                    </td>
                                    <td>
                            <asp:ImageButton ID="Image_btn1" runat="server" 
                                ImageUrl="~/web/gifs/Calendar_scheduleHS.png" />
                                    </td>
                                    <td>
                                    <asp:TextBox ID="TxtEdad" runat="server" Enabled="False" Font-Names="Gill Sans MT" 
                                        Font-Size="10pt" Width="64px"></asp:TextBox>
                            
                                    </td>
                                </tr>
                            </table>
                            
                        </TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">Nº de Doc.:</TD>
						<TD class="style23">
                            <table cellpadding="0" cellspacing="0" class="style27">
                                <tr>
                                    <td>
                                        <asp:textbox id="Txtorden" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="39px" MaxLength="14" tabIndex="5" Height="21px" Visible="False"></asp:textbox>
                                    </td>
                                    <td>
                                        <asp:textbox id="TxtIdCivil" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="161px" MaxLength="16" tabIndex="10" Height="19px"></asp:textbox>
                                    </td>
                                </tr>
                            </table>
                        </TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
							&nbsp;</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px; color: #999999;" 
                            class="style22">Formato (dd/mm/yyyy)<cc1:MaskedEditValidator ID="Mask_Edit1" runat="server" 
                                ControlExtender="Mask_EditExt1" ControlToValidate="TxtDfecnaci" 
                                Display="Dynamic" EmptyValueMessage="La fecha es requerida" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" InvalidValueMessage="Fecha Invalida" 
                                IsValidEmpty="False" TooltipMessage="Por favor Digite una Fecha"></cc1:MaskedEditValidator></TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style33">
                            &nbsp;</TD>
						<TD class="style34">
                            <asp:Label ID="Label6" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#666666"></asp:Label>
                        </TD>
						<TD style="FONT-SIZE: 10pt; " class="style35">
							<P style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
								align="left">NIT</P>
						</TD>
						<TD class="style36"><asp:textbox id="TxtIdTribu" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False" runat="server"
								Width="168px" MaxLength="18" tabIndex="12"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 23px">
                            Departamento Extendido Doc:</TD>
						<TD class="style8">
                            <asp:DropDownList ID="DropDownDeptos0" runat="server"  onchange="CargaMuni0();" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" Width="207px"  tabIndex="13"
                                AutoPostBack="True">
                            </asp:DropDownList>
                        </TD>
						<TD style="FONT-SIZE: 10pt; font-weight: normal; width: 114px; color: #16387c; font-style: normal; font-family: Gill Sans MT; height: 23px;" 
                            class="style13">
							Municipio Extendido Doc:</TD>
						<TD style="HEIGHT: 23px">
                            <asp:DropDownList ID="DropDownMuni0" runat="server"  Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Width="202px" tabIndex="14">
                            </asp:DropDownList>
                        </TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 2px">
                            Sexo:</TD>
						<TD class="style9"><asp:dropdownlist id="cmbGenCli" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False" runat="server"
								Width="208px" tabIndex="15"></asp:dropdownlist></TD>
						<TD style="FONT-SIZE: 10pt; " class="style14">
							<P style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
								align="left">Profesión</P>
						</TD>
						<TD style="HEIGHT: 2px"><asp:dropdownlist id="cmbProfCli" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False" runat="server"
								Width="184px" tabIndex="18"></asp:dropdownlist></TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 2px">
                            &nbsp;</TD>
						<TD class="style9">
            
            <asp:FileUpload ID="fileUpEx" runat="server" Width="248px" Font-Names="Gill Sans MT" 
                                TabIndex="20" />
                        </TD>
						<TD style="FONT-SIZE: 10pt; " class="style14">
            <asp:Button ID="btnSubir" runat="server" Height="21px" Text="Subir Foto" 
                Width="98px" Font-Names="Gill Sans MT" />
						</TD>
						<TD style="HEIGHT: 2px">
            <asp:Label ID="lblStatus" runat="server" CssClass="style4" Height="16px"></asp:Label>
                        </TD>
					</TR>
					</TABLE>
			</TD>
		</TR>
		<TR>
			<TD align="center">
				<P style="FONT-WEIGHT: normal; FONT-SIZE: 11pt; COLOR: White; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #006699"
					align="center">Domicilio</P>
			</TD>
		</TR>
		<TR>
			<TD align="center">
                            <table id="Table3" border="0" cellpadding="0" cellspacing="0">
					<tr>
						<td 
                                style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 99px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 21px">Departamento</td>
						<td style="WIDTH: 225px; HEIGHT: 21px">
                            <asp:DropDownList runat="server" AutoPostBack="True" Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" TabIndex="20" Width="202px" ID="DropDownDeptos" onchange="CargaMuni();"></asp:DropDownList>

                        </td>
						<td class="style1" 
                                style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; ">Municipio</td>
						<td style="HEIGHT: 21px">
                            <asp:DropDownList runat="server" AutoPostBack="True" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="21" Width="202px" ID="DropDownMuni" onchange="CargaComu();"></asp:DropDownList>

                        </td>
					</tr>
					<tr>
						<td 
                                style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 99px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 26px">
                            Comunidad/Colonia/Cantòn:</td>
						<td style="WIDTH: 225px; HEIGHT: 26px">
                            <asp:DropDownList runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="22" Width="202px" ID="DropDownComu"></asp:DropDownList>

                        </td>
						<td class="style2" 
                                style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                            <asp:Label runat="server" Text="Localidad Demografica:" Font-Names="Gill Sans MT" Font-Size="10pt" Height="17px" Width="149px" ID="Label22"></asp:Label>

                        </td>
						<td style="HEIGHT: 26px">
                            <asp:DropDownList runat="server" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="18px" TabIndex="23" Width="203px" ID="cmblocalidad"></asp:DropDownList>

                        </td>
					</tr>
					<tr>
						<td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style43">
                            <asp:Label runat="server" Text="Tel. Casa:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="17px" Width="96px" ID="Label21"></asp:Label>

                        </td>
						<td class="style44"><asp:TextBox runat="server" MaxLength="8" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="24" Width="120px" ID="TxtTelDom"></asp:TextBox>
</td>
						<td class="style45" 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                            <asp:Label runat="server" Text="Celular:" Font-Names="Gill Sans MT" Font-Size="10pt" Height="17px" Width="96px" ID="Label20"></asp:Label>

                        </td>
						<td class="style44"><asp:TextBox runat="server" MaxLength="8" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="27" Width="120px" ID="txtcelular"></asp:TextBox>
</td>
					</tr>
					<tr>
						<td 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none" 
                            class="style46">
                            <asp:Label runat="server" Text="Otro telefono:" Font-Names="Gill Sans MT" Font-Size="10pt" Width="124px" ID="Label16"></asp:Label>

                        </td>
						<td class="style22">
                            <asp:TextBox runat="server" MaxLength="8" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="25" Width="120px" ID="txtotrtel"></asp:TextBox>
</td>
						<td class="style47" 
                                
                            style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; TEXT-DECORATION: none">
                            <asp:Label runat="server" Text="Direcci&#242;n:" Font-Names="Gill Sans MT" Font-Size="10pt" Height="17px" Width="96px" ID="Label19"></asp:Label>

                        </td>
						<td class="style22">
                            <asp:TextBox runat="server" TextMode="MultiLine" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="37px" TabIndex="28" Width="208px" ID="TxtDirDom"></asp:TextBox>
</td>
					</tr>
					</table>
			</TD>
		</TR>
		<TR>
			<TD align="center">
				<P style="FONT-WEIGHT: normal; FONT-SIZE: 11pt; COLOR: White; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #006699"
					align="center">Otros</P>
			</TD>
		</TR>
		<TR>
			<TD align="center">
				<table cellpadding="0" cellspacing="0" class="style4" align="center" 
                    bgcolor="White">
                    <tr>
                        <td align="right" class="style5">
                            <asp:Label ID="Label1" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Text="Etnia:"></asp:Label>
                        </td>
                        <td align="center" class="style25">
                            <asp:dropdownlist id="cmbEtnia" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="29"></asp:dropdownlist>
                        </td>
                        <td align="right" class="style37">
                            <asp:Label ID="Label23" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Grupo Etnico:" Width="124px"></asp:Label>
                        </td>
                        <td align="left">
                            <asp:dropdownlist id="cmbgruetnico" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="35"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style5">
                            <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Idiomas que domina:" Width="124px"></asp:Label>
                        </td>
                        <td align="left" class="style25">
                            <asp:ListBox runat="server" SelectionMode="Multiple" Font-Names="Gill Sans MT" 
                                Width="148px" ID="cmbidiomas">
                            </asp:ListBox>
                        </td>
                        <td align="right" class="style37">
                            <asp:Label ID="Label39" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Forma de Empleo:" Width="124px"></asp:Label>
                        </td>
                        <td align="left">
                                                <asp:DropDownList ID="cmbCondicion" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" 
                                TabIndex="26" Width="208px">
                                                </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style28">
                            <asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Text="Escolaridad:"></asp:Label>
                        </td>
                        <td align="center" class="style29">
                            <asp:dropdownlist id="cmbNivel" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="31"></asp:dropdownlist>
                        </td>
                        <td align="right" class="style38">
                            <asp:Label ID="Label17" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Grado:" Width="124px"></asp:Label>
                        </td>
                        <td align="left" class="style31">
                            <asp:textbox id="txtgrado" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="200px" tabIndex="36"></asp:textbox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style5">
                            <asp:Label ID="Label13" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Sabe leer:" Width="124px"></asp:Label>
                        </td>
                        <td align="center" class="style25">
                            <asp:dropdownlist id="cmbleer" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="32"></asp:dropdownlist>
                        </td>
                        <td align="right" class="style37">
                            <asp:Label ID="Label15" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="17px" Text="Sabe firmar:" Width="96px"></asp:Label>
                        </td>
                        <td align="left">
                            <asp:dropdownlist id="cmbfirmar" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="37"></asp:dropdownlist>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style28">
                            <asp:Label ID="Label4" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Text="Otro:"></asp:Label>
                        </td>
                        <td align="center" class="style29">
                            <asp:textbox id="Txtadicionales" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" Height="23px" tabIndex="34"></asp:textbox>
                        </td>
                        <td align="right" class="style38">
                            <asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Sabe escribir:" Width="124px"></asp:Label>
                        </td>
                        <td align="left" class="style31">
                            <asp:dropdownlist id="cmbescribir" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" tabIndex="33"></asp:dropdownlist>
                                            </td>
                    </tr>
                    </table>
			</TD>
		</TR>
		<TR align="center" 
            style="font-family: Gill Sans MT; font-size: 12px; color: #FFFFFF;">
			<TD>
				&nbsp;<TD style="FONT-SIZE: 11pt; HEIGHT: 20px; ">
				&nbsp;</TD>
		</TR>
		<TR align="center" 
            style="font-family: Gill Sans MT; font-size: 12px; color: #FFFFFF;">
			<TD>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnuevo" 
                        runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" Text="Nuevo" 
                        Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btgrabar" runat="server" Font-Names="Gill Sans MT" 
                        Font-Size="12pt" Text="Grabar" Width="85px" tabIndex="44" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="bteditar" runat="server" 
                        Font-Names="Gill Sans MT" Font-Size="12pt" Text="Editar" Width="85px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btCancela" runat="server" 
                        Font-Names="Gill Sans MT" Font-Size="12pt" Text="Inicializar" Width="85px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btreferencia" runat="server" Font-Names="Gill Sans MT" 
                        Font-Size="12pt" Text="Referencias" Width="85px" Visible="False" />
                <TD style="FONT-SIZE: 11pt; HEIGHT: 20px; ">
				    &nbsp;</TD>
		</TR>
		<TR>
			<TD style="HEIGHT: 53px">
				<asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table cellpadding="0" cellspacing="0" class="style27">
                            <tr>
                                <td align="center">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <TABLE ID="Table4" border="0" cellPadding="0" cellSpacing="0" width="100%">
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                Tipo de Conyuge</td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:DropDownList ID="cmbTipcli" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="2" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                Estado Civil</td>
                                            <td style="HEIGHT: 24px">
                                                <asp:DropDownList ID="cmbEstCli" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" onchange="HabilitaCampos()" 
                                                    tabIndex="16" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label18" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Text="Nº Hijos:" Width="107px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:TextBox ID="txthijos" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" MaxLength="8" 
                                                    style="vertical-align:top" tabIndex="17" Width="89px"></asp:TextBox>
                                                <cc1:NumericUpDownExtender ID="txthijos_NumericUpDownExtender" runat="server" 
                                                    Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                                    ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                    TargetButtonUpID="" TargetControlID="txthijos" Width="60">
                                                </cc1:NumericUpDownExtender>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label5" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Text="Nº Dependientes:" Width="107px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 24px">
                                                <asp:TextBox ID="txtiva" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" MaxLength="8" 
                                                    tabIndex="14" Visible="False" Width="62px"></asp:TextBox>
                                                <asp:TextBox ID="txtdepen" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" MaxLength="8" 
                                                    style="vertical-align:top" tabIndex="19" Width="89px"></asp:TextBox>
                                                <cc1:NumericUpDownExtender ID="txtdepen_NumericUpDownExtender" runat="server" 
                                                    Enabled="True" Maximum="100" Minimum="0" RefValues="" ServiceDownMethod="" 
                                                    ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                    TargetButtonUpID="" TargetControlID="txtdepen" Width="60">
                                                </cc1:NumericUpDownExtender>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label2" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Text="Condición de la Vivienda:" 
                                                    Width="152px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                &nbsp;</td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label27" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Otro:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 24px">
                                                <asp:TextBox ID="txtotracondicion" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="23px" TabIndex="28" 
                                                    Width="208px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label28" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Paredes:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:ListBox ID="cmbparedes" runat="server" Font-Names="Gill Sans MT" 
                                                    Height="16px" SelectionMode="Multiple" Width="148px">
                                                    <asp:ListItem Value="1">Adobe</asp:ListItem>
                                                    <asp:ListItem Value="2">Block</asp:ListItem>
                                                    <asp:ListItem Value="3">Ladrillo</asp:ListItem>
                                                    <asp:ListItem Value="4">Madera</asp:ListItem>
                                                    <asp:ListItem Value="5">Otro</asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label30" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Piso:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 24px">
                                                <asp:ListBox ID="cmbpiso" runat="server" Font-Names="Gill Sans MT" 
                                                    Height="21px" SelectionMode="Multiple" Width="148px">
                                                    <asp:ListItem Value="1">Tierra</asp:ListItem>
                                                    <asp:ListItem Value="2">Cemento</asp:ListItem>
                                                    <asp:ListItem Value="3">Granito</asp:ListItem>
                                                    <asp:ListItem Value="4">Ceramico</asp:ListItem>
                                                    <asp:ListItem Value="5">Otro</asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label29" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Otro:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:TextBox ID="txtotracondicion0" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="23px" TabIndex="28" 
                                                    Width="208px"></asp:TextBox>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label31" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Otro:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 24px">
                                                <asp:TextBox ID="txtotracondicion1" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="23px" TabIndex="28" 
                                                    Width="208px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label32" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Techo:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:ListBox ID="cmbtecho" runat="server" Font-Names="Gill Sans MT" 
                                                    Height="16px" SelectionMode="Multiple" Width="148px">
                                                    <asp:ListItem Value="1">Lamina</asp:ListItem>
                                                    <asp:ListItem Value="2">Terraza</asp:ListItem>
                                                    <asp:ListItem Value="3">Otro</asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label34" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Servicios:" 
                                                    Width="90px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 24px">
                                                <asp:ListBox ID="cmbservicios" runat="server" Font-Names="Gill Sans MT" 
                                                    Height="19px" SelectionMode="Multiple" Width="148px">
                                                    <asp:ListItem Value="1">Agua</asp:ListItem>
                                                    <asp:ListItem Value="2">Energia Electrica</asp:ListItem>
                                                    <asp:ListItem Value="3">Drenaje</asp:ListItem>
                                                    <asp:ListItem Value="4">Fosa Septica</asp:ListItem>
                                                    <asp:ListItem Value="5">Otros</asp:ListItem>
                                                </asp:ListBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label33" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Otro:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:TextBox ID="txtotracondicion2" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="23px" TabIndex="28" 
                                                    Width="208px"></asp:TextBox>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label35" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Otro:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 24px">
                                                <asp:TextBox ID="txtotracondicion3" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="23px" TabIndex="28" 
                                                    Width="208px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label36" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Dueño:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:TextBox ID="txtdueño" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="23px" TabIndex="28" 
                                                    Width="208px"></asp:TextBox>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label37" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Valor Aproximado:" 
                                                    Width="126px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 24px">
                                                <asp:TextBox ID="txtvalor" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="25" Width="120px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label38" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Año desde que Recide:" 
                                                    Width="134px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:TextBox ID="txtrecidir" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="28px" 
                                                    style="vertical-align:top" tabIndex="17" Width="89px"></asp:TextBox>
                                                <cc1:NumericUpDownExtender ID="txtrecidir_NumericUpDownExtender" runat="server" 
                                                    Enabled="True" Maximum="2030" Minimum="1901" RefValues="" ServiceDownMethod="" 
                                                    ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" 
                                                    TargetButtonUpID="" TargetControlID="txtrecidir" Width="60">
                                                </cc1:NumericUpDownExtender>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                &nbsp;</td>
                                            <td style="HEIGHT: 24px">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                Nombre</td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:TextBox ID="TxtNomC" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" tabIndex="38" Width="200px"></asp:TextBox>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                Nacimiento</td>
                                            <td style="HEIGHT: 24px">
                                                <asp:TextBox ID="TxtNacCony" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" MaxLength="10" onChange="Getfecha1()" tabIndex="41" 
                                                    Width="120px"></asp:TextBox>
                                                <cc1:MaskedEditExtender ID="TxtNacCony_MaskedEdit" runat="server" 
                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                                                    Mask="99/99/9999" MaskType="Date" TargetControlID="TxtNacCony">
                                                </cc1:MaskedEditExtender>
                                                <asp:TextBox ID="TxtEdadCony" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="1" Width="60px"></asp:TextBox>
                                                <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                    ControlExtender="TxtNacCony_MaskedEdit" ControlToValidate="TxtNacCony" 
                                                    Display="Dynamic" EmptyValueMessage="La fecha es requerida" 
                                                    ErrorMessage="Mask_Edit2" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    InvalidValueMessage="Fecha Invalida" 
                                                    TooltipMessage="Por favor Digite una Fecha">
                                                </cc1:MaskedEditValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                Cedula/DPI:<br />
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 24px">
                                                <asp:TextBox ID="TxtIdCony" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" MaxLength="16" tabIndex="39" Width="120px"></asp:TextBox>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                Sexo:</td>
                                            <td style="HEIGHT: 24px">
                                                <asp:DropDownList ID="cmbGenCony" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" tabIndex="42" Width="192px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                Profesión</td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbProfCony" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" tabIndex="40" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                            </td>
                                            <td style="HEIGHT: 22px">
                                                <asp:CheckBox ID="Sleer" runat="server" Checked="True" Font-Bold="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="43" 
                                                    Text="Sabe Leer y Escribir" />
                                            </td>
                                        </tr>
                                    </TABLE>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
			</TD>
		</TR>
		<TR>
			<TD>
                            <asp:CheckBox ID="SeguroV" runat="server" Font-Bold="True" 
                                Font-Names="Century Gothic" Font-Size="10pt" 
                    Text="Sujeto a Retención" Visible="False" />
                            <asp:CheckBox ID="Sfirmar" runat="server" Font-Bold="True" 
                                Font-Names="Century Gothic" Font-Size="10pt" Text="Sabe Leer y Escribir" 
                                Checked="True" Visible="False" />
                            <asp:DropDownList ID="DropDownComu0" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Width="110px" Visible="False" Enabled="False" 
                                Height="16px">
                            </asp:DropDownList>
                                    </TD>
		</TR>
	</TABLE>
</P>
            <asp:HiddenField ID="hfExtension" runat="server" />
            <asp:HiddenField ID="hfPathArchivo" runat="server" />
            
<asp:HiddenField ID="HiddenField1" runat="server" />

            
            <asp:HiddenField ID="hfIdEmpleado" runat="server" />
        
