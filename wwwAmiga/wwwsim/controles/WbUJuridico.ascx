<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbUJuridico.ascx.vb" Inherits="WbUJuridico"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<style type="text/css">
    .style1
    {
        height: 210px;
    }
    .style2
    {
        height: 20px;
    }
    .style3
    {
        width: 100%;
    }
</style>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<style type="text/css">
    .style6
    {
        height: 22px;
        width: 222px;
    }
    .style11
    {
        height: 22px;
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
    .style27
    {
        width: 92%;
    }
    #Table3
    {
        width: 84%;
        height: 100px;
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
	<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 803px; HEIGHT: 205px; BACKGROUND-COLOR: #FFFFFF"
		cellSpacing="0" cellPadding="0" border="0">
		<TR>
			<TD>
				<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #006699; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
					align="center">DATOS GENERALES PARA PERSONA JURIDICA</P>
			</TD>
		</TR>
		<TR>
			<TD align="center" class="style1">
				<TABLE id="Table2" style="WIDTH: 762px; HEIGHT: 112px" cellSpacing="0" 
                    cellPadding="0" border="0" class="CSSTableGenerator">
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 114px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                            Codigo:</TD>
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
                                Font-Size="10pt" Text="Razon Social:" Width="124px"></asp:Label>
                        </TD>
						<TD class="style23"><asp:textbox id="TxtNomcli" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Enabled="False" runat="server"
								Width="200px" tabIndex="3"></asp:textbox></TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
                            <asp:Label ID="Label44" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="RFC:" Width="124px"></asp:Label>
						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            <asp:textbox id="TxtIdTribu" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="168px" MaxLength="12" tabIndex="12"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
                            <asp:Label ID="Label46" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Estado:" Width="124px"></asp:Label>
                        </TD>
						<TD class="style23">         <asp:DropDownList runat="server" AutoPostBack="True" Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" TabIndex="20" Width="202px" ID="DropDownDeptos" onchange="CargaMuni();"></asp:DropDownList>

                        </TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
                            <asp:Label ID="Label45" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Municipio:" Width="124px"></asp:Label>
						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            <asp:DropDownList runat="server" AutoPostBack="True" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="21" Width="202px" ID="DropDownMuni" onchange="CargaComu();"></asp:DropDownList>

                        </TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
                            Colonia:</TD>
						<TD class="style23">
                            <asp:DropDownList runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="22" Width="202px" ID="DropDownComu"></asp:DropDownList>

                        </TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
                            <asp:Label runat="server" Text="Localidad Demografica:" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="17px" Width="149px" 
                                ID="Label22" Visible="False"></asp:Label>

						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            <asp:DropDownList runat="server" Enabled="False" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="18px" TabIndex="23" Width="203px" ID="cmblocalidad" 
                                Visible="False"></asp:DropDownList>

                        </TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
                            <asp:Label runat="server" Text="Direcci&#242;n:" Font-Names="Gill Sans MT" Font-Size="10pt" Height="17px" Width="96px" ID="Label19"></asp:Label>

                        </TD>
						<TD class="style23">
                            <asp:TextBox runat="server" TextMode="MultiLine" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" Height="37px" TabIndex="28" Width="208px" ID="TxtDirDom"></asp:TextBox>
                        </TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
							&nbsp;</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            &nbsp;</TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
                            <asp:Label runat="server" Text="PBX:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="17px" Width="96px" ID="Label21"></asp:Label>

                        </TD>
						<TD class="style23">
                            <asp:TextBox runat="server" MaxLength="8" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="24" Width="120px" ID="TxtTelDom"></asp:TextBox>
                        </TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
                            <asp:Label runat="server" Text="Otro Telefono:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Height="17px" Width="96px" ID="Label20"></asp:Label>

						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            <asp:TextBox runat="server" MaxLength="8" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="27" Width="120px" ID="txtcelular"></asp:TextBox>
                        </TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
                            <asp:Label ID="Label4" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                ForeColor="#000066" Text="Contacto Principal:"></asp:Label>
                        </TD>
						<TD class="style23">
                            <asp:textbox id="Txtadicionales" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="208px" Height="23px" tabIndex="34"></asp:textbox>
                        </TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
                            <asp:Label runat="server" Text="Telefono Contacto:" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Width="124px" ID="Label16"></asp:Label>

						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                            <asp:TextBox runat="server" MaxLength="8" Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="25" Width="120px" ID="txtotrtel"></asp:TextBox>
                        </TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
                            <asp:Label ID="Label17" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Correo Electronico:" Width="124px"></asp:Label>
                        </TD>
						<TD class="style23">
                            <asp:textbox id="txtgrado" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Enabled="False" runat="server"
								Width="200px" tabIndex="36"></asp:textbox>
                        </TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
                            <asp:Label ID="Label41" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Pagina WEB:" Width="124px"></asp:Label>
						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                                                <asp:TextBox ID="txtotracondicion" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Height="23px" TabIndex="28" 
                                                    Width="208px"></asp:TextBox>
                                            </TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
							<asp:Label ID="Label25" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Fec.de Constitucion:" Width="124px"></asp:Label>
                        </TD>
						<TD class="style23">
                            
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
                            <asp:ImageButton ID="Image_btn1" runat="server" 
                                ImageUrl="~/web/gifs/Calendar_scheduleHS.png" />
                            <cc1:MaskedEditValidator ID="Mask_Edit1" runat="server" 
                                ControlExtender="Mask_EditExt1" ControlToValidate="TxtDfecnaci" 
                                Display="Dynamic" EmptyValueMessage="La fecha es requerida" 
                                Font-Names="Gill Sans MT" Font-Size="10pt" InvalidValueMessage="Fecha Invalida" 
                                IsValidEmpty="False" TooltipMessage="Por favor Digite una Fecha"></cc1:MaskedEditValidator>
                                    </TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
							<asp:Label ID="Label42" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Fec.de Inicio Operaciones:" Width="150px"></asp:Label>
						</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                                                <asp:TextBox ID="TxtNacCony" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" MaxLength="10" onChange="Getfecha1()" tabIndex="41" 
                                                    Width="120px"></asp:TextBox>
                                                <cc1:MaskedEditExtender ID="TxtNacCony_MaskedEdit" runat="server" 
                                                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                                                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                                    CultureThousandsPlaceholder="" 
                                CultureTimePlaceholder="" Enabled="True" 
                                                    Mask="99/99/9999" MaskType="Date" 
                                TargetControlID="TxtNacCony">
                                                </cc1:MaskedEditExtender>
                            
                                                <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" 
                                                    ControlExtender="TxtNacCony_MaskedEdit" ControlToValidate="TxtNacCony" 
                                                    Display="Dynamic" EmptyValueMessage="La fecha es requerida" 
                                                    ErrorMessage="Mask_Edit2" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                                    InvalidValueMessage="Fecha Invalida" 
                                                    TooltipMessage="Por favor Digite una Fecha">
                                                </cc1:MaskedEditValidator>
                                                </TD>
					</TR>
					<TR>
						<TD style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; " 
                            class="style19">
							<asp:Label ID="Label43" runat="server" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Representante Legal:" Width="124px"></asp:Label>
                        </TD>
						<TD class="style23">
                                                <asp:TextBox ID="txtdueño" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" 
                                Height="23px" TabIndex="28" 
                                                    Width="208px"></asp:TextBox>
                                            </TD>
						<TD style="FONT-SIZE: 10pt; " class="style24">
							&nbsp;</TD>
						<TD style="font-family: Gill Sans MT; font-size: 12px;" class="style22">
                            
                                                &nbsp;</TD>
					</TR>
					</TABLE>
			</TD>
		</TR>
		<TR>
			<TD align="center" class="style2">
				<table cellpadding="0" cellspacing="0" class="style27">
                    <tr>
                        <td align="center">
                            <asp:Button ID="btnuevo" 
                        runat="server" Font-Names="Gill Sans MT" Font-Size="12pt" Text="Nuevo" 
                        Width="85px" />
                        </td>
                        <td align="center">
                            <asp:Button ID="btgrabar" runat="server" Font-Names="Gill Sans MT" 
                        Font-Size="12pt" Text="Grabar" Width="85px" tabIndex="44" />
                        </td>
                        <td align="center">
                            <asp:Button ID="bteditar" runat="server" 
                        Font-Names="Gill Sans MT" Font-Size="12pt" Text="Editar" Width="85px" />
                        </td>
                        <td align="center">
                            <asp:Button ID="btCancela" runat="server" 
                        Font-Names="Gill Sans MT" Font-Size="12pt" Text="Inicializar" Width="85px" />
                        </td>
                        <td align="center">
                    <asp:Button ID="btreferencia" runat="server" Font-Names="Gill Sans MT" 
                        Font-Size="12pt" Text="Referencias" Width="85px" Visible="False" />
                        </td>
                    </tr>
                </table>
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
<table cellpadding="0" cellspacing="0" class="style3">
    <tr>
        <td>
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
                                                <asp:DropDownList ID="cmbCondicion" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" TabIndex="26" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 79px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 24px">
                                                <asp:Label ID="Label27" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Height="16px" Text="Otro:" Width="90px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 24px">
                                                &nbsp;</td>
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
                                                &nbsp;</td>
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
                                                <asp:TextBox ID="TxtEdadCony" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="1" Width="60px"></asp:TextBox>
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
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                <asp:Label ID="Label7" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Segundo Nombre:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:TextBox ID="Txtsegnom" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="4" Width="200px"></asp:TextBox>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                <asp:Label ID="Label10" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Primer Apellido:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 22px">
                                                <asp:TextBox ID="Txtpriape" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="6" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                <asp:Label ID="Label11" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Segundo Apellido:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:TextBox ID="Txtsegape" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="7" Width="200px"></asp:TextBox>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                <asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Tercer Nombre:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 22px">
                                                <asp:TextBox ID="Txtternom" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="5" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                <asp:Label ID="Label12" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Apellido de Casada:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:TextBox ID="Txtapecasada" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="8" Width="200px"></asp:TextBox>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                &nbsp;</td>
                                            <td style="HEIGHT: 22px">
                                                <asp:TextBox ID="TxtEdad" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Width="64px"></asp:TextBox>
                                                <asp:Label ID="Label6" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#666666"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                <asp:Label ID="Label26" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Tipo de Doc.:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbTipDoc" runat="server" AutoPostBack="True" 
                                                    Enabled="False" Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="9" 
                                                    Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                Nº de Doc.:</td>
                                            <td style="HEIGHT: 22px">
                                                <table cellpadding="0" cellspacing="0" class="style27">
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="Txtorden" runat="server" Enabled="False" 
                                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="21px" MaxLength="14" 
                                                                tabIndex="5" Visible="False" Width="39px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TxtIdCivil" runat="server" Enabled="False" 
                                                                Font-Names="Gill Sans MT" Font-Size="10pt" Height="19px" MaxLength="16" 
                                                                tabIndex="10" Width="161px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                Departamento Extendido Doc:</td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:DropDownList ID="DropDownDeptos0" runat="server" AutoPostBack="True" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" Height="16px" 
                                                    onchange="CargaMuni0();" tabIndex="13" Width="207px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                Municipio Extendido Doc:</td>
                                            <td style="HEIGHT: 22px">
                                                <asp:DropDownList ID="DropDownMuni0" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" tabIndex="14" Width="202px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                Sexo:</td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbGenCli" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="15" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                <p align="left" 
                                                    style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'">
                                                    Profesión</p>
                                            </td>
                                            <td style="HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbProfCli" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="18" Width="184px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                <asp:Label ID="Label1" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Text="Etnia:"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbEtnia" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="29" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                <asp:Label ID="Label23" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Grupo Etnico:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbgruetnico" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="35" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                <asp:Label ID="Label24" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Idiomas que domina:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbidiomas" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="30" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                <asp:Label ID="Label15" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Height="17px" Text="Sabe firmar:" Width="96px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbfirmar" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="37" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                <asp:Label ID="Label3" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" ForeColor="#000066" Text="Escolaridad:"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbNivel" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="31" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                <asp:Label ID="Label14" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Sabe escribir:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbescribir" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="33" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="FONT-WEIGHT: normal; FONT-SIZE: 10pt; WIDTH: 100px; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; HEIGHT: 22px">
                                                <asp:Label ID="Label13" runat="server" Font-Names="Gill Sans MT" 
                                                    Font-Size="10pt" Text="Sabe leer:" Width="124px"></asp:Label>
                                            </td>
                                            <td style="WIDTH: 230px; HEIGHT: 22px">
                                                <asp:DropDownList ID="cmbleer" runat="server" Enabled="False" 
                                                    Font-Names="Gill Sans MT" Font-Size="10pt" tabIndex="32" Width="208px">
                                                </asp:DropDownList>
                                            </td>
                                            <td style="WIDTH: 79px; HEIGHT: 22px">
                                                &nbsp;</td>
                                            <td style="HEIGHT: 22px">
                                                &nbsp;</td>
                                        </tr>
                                    </TABLE>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
			</td>
    </tr>
</table>

