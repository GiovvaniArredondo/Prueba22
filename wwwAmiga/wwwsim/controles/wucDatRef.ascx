<%@ Control Language="vb" AutoEventWireup="false" Inherits="wucDatRef" CodeFile="wucDatRef.ascx.vb" %>
<%@ Register assembly="SIM_WINUC" namespace="SIM_WINUC" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc11" %>
<link rel="stylesheet" href="css/style.css" type="text/css" />
<style type="text/css">
    .style1
    {
        width: 70%;
    }
    .style2
    {
        height: 19px;
        text-align: left;
    }
    .style4
    {
        width: 298px;
        height: 19px;
    }
    .style5
    {
        width: 245px;
        height: 19px;
    }
    .style7
    {
        width: 290px;
    }
    .style8
    {
        width: 298px;
    }
    .style9
    {
        width: 230px;
        height: 33px;
    }
    .style10
    {
        width: 73px;
        height: 33px;
    }
    .style11
    {
        width: 245px;
        height: 33px;
    }
    .style12
    {
        height: 33px;
    }
    .style13
    {
        width: 290px;
        height: 19px;
    }
    .style14
    {
        width: 290px;
        height: 28px;
    }
    .style15
    {
        width: 298px;
        height: 28px;
    }
    .style16
    {
        width: 245px;
        height: 28px;
    }
    .style17
    {
        height: 28px;
    }
    .style18
    {
        width: 135px;
        text-align: left;
    }
    .style19
    {
        height: 28px;
        width: 135px;
    }
    .style20
    {
        height: 19px;
        width: 135px;
    }
    .style21
    {
        width: 146px;
    }
    .style22
    {
        height: 28px;
        width: 146px;
    }
    .style23
    {
        height: 19px;
        width: 146px;
    }
</style>

  <script type="text/javascript">       


	    function SoloLetras(evt) {
	        var charCode = (evt.which) ? evt.which : event.keyCode

	        if (charCode == 08 || charCode == 32 || charCode == 241 || charCode == 209)
	            return true;
	        else if (charCode >= 65 && charCode <= 90)
	            return true;
	        else if (charCode >= 97 && charCode <= 122)
	            return true;

	        return false;
	    }
	    
	    function SoloLetras_Numeros(evt) {
	        var charCode = (evt.which) ? evt.which : event.keyCode
	        if (charCode == 08 || charCode == 32 || charCode == 45)
	            return true;
	        else if (charCode >= 48 && charCode <= 57)
	            return true;	            
	        else if (charCode >= 65 && charCode <= 90)
	            return true;
	        else if (charCode >= 97 && charCode <= 122)
	            return true;

	        return false;
	    }


	    
    </script>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 956px; HEIGHT: 279px"
	cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0">
	<TR>
		<TD align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #006699; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'"
				align="center">REFERENCIAS PERSONALES</P>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<table cellpadding="0" cellspacing="0" class="style1">
                <tr>
                    <td>
                        <asp:label id="Label16" Font-Bold="True" ForeColor="Navy" Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="48px" runat="server">Cod.Cliente</asp:label>
                    </td>
                    <td>
                        <asp:textbox id="TxtCodigo" Font-Size="10pt" Font-Names="Gill Sans MT" 
                            runat="server" Enabled="False" BorderColor="#2E6A99" BorderWidth="1px" 
                            Height="28px"></asp:textbox>
                    </td>
                    <td>
						<asp:label id="Label17" runat="server" Width="48px" Font-Names="Gill Sans MT" Font-Size="10pt" ForeColor="Navy"
							Font-Bold="True">Nombre:</asp:label>
                    </td>
                    <td>
						<asp:textbox id="TxtNomcli" tabIndex="3" runat="server" Width="300px" 
                            Font-Names="Gill Sans MT" Font-Size="10pt"
							Enabled="False" BorderColor="#2E6A99" BorderWidth="1px" Height="28px"></asp:textbox>
                    </td>
                </tr>
            </table>
		</TD>
	</TR>
	<TR>
		<TD align="center" style="text-align: right">
                                            <asp:Label ID="Label54" runat="server" Font-Names="Gill Sans MT" 
                                                Font-Size="10pt" ForeColor="Red" onkeypress="return SoloLetras(event)" 
                                                Text="Campos Requeridos {*}" Width="130px"></asp:Label>
                                        </TD>
	</TR>
	<TR>
		<TD align="center">
			<TABLE id="Table2" style="WIDTH: 933px; HEIGHT: 133px" cellSpacing="0" 
                cellPadding="0" border="0">
				<TR>
					<TD align="center" class="style7"><asp:label id="Label1" Font-Bold="True" ForeColor="Navy" Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="48px" runat="server">NOMBRE</asp:label></TD>
					<TD align="center" class="style8"><asp:label id="Label2" Font-Bold="True" ForeColor="Navy" Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="48px" runat="server">DIRECCION</asp:label></TD>
					<TD style="WIDTH: 245px" align="center">
                        <asp:label id="Label4" Font-Bold="True" 
                            ForeColor="Navy" Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="100px" runat="server" style="text-align: left">TEL. FIJO</asp:label></TD>
					<TD align="center" class="style21">
                        <asp:label id="Label31" Font-Bold="True" ForeColor="Navy" 
                            Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="100px" runat="server" style="text-align: left">TEL. CELULAR</asp:label></TD>
					<TD align="center" class="style18"><asp:label id="Label32" Font-Bold="True" ForeColor="Navy" 
                            Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="48px" runat="server">PARENTESCO</asp:label></TD>
					<TD align="center" style="text-align: left"><asp:label id="Label29" Font-Bold="True" ForeColor="Navy" 
                            Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="48px" runat="server">REFERENCIA</asp:label></TD>
				</TR>
				<TR>
					<TD class="style14">
                        <asp:textbox id="txtcref1" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="209px" runat="server"
							MaxLength="40" BorderWidth="1px" onkeypress="return SoloLetras(event)" BorderColor="#2E6A99" 
                            Height="28px" CssClass="ToUpper"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqv1" runat="server" 
                            ControlToValidate="txtcref1" ErrorMessage="Falta Nombre Referencia No 1">*</asp:RequiredFieldValidator>
                        <cc11:ValidatorCalloutExtender ID="rqv1_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqv1">
                        </cc11:ValidatorCalloutExtender>
                    </TD>
					<TD class="style15">
                        <asp:textbox id="txtcdomicilio1" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="216px" runat="server"
							MaxLength="90" BorderWidth="1px" BorderColor="#2E6A99" Height="28px" CssClass="ToUpper"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqv2" runat="server" 
                            ControlToValidate="txtcdomicilio1" 
                            ErrorMessage="Falta Docimilio Referencia No 1">*</asp:RequiredFieldValidator>
                        <cc11:ValidatorCalloutExtender ID="rqv2_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqv2">
                        </cc11:ValidatorCalloutExtender>
                    </TD>
					<TD class="style16"><asp:textbox id="txtctel1" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="85px" runat="server"
							MaxLength="10" BorderWidth="1px" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99" 
                            Height="28px"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqv3" runat="server" 
                            ControlToValidate="txtctel1" ErrorMessage="Falta No Telefono Referencia No 1">*</asp:RequiredFieldValidator>
                        <cc11:ValidatorCalloutExtender ID="rqv3_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqv3">
                        </cc11:ValidatorCalloutExtender>
                    </TD>
					<TD class="style22"><asp:textbox id="txtcelular1" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="85px" runat="server"
							MaxLength="10" BorderWidth="1px" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99" 
                            Height="28px"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqv4" runat="server" 
                            ControlToValidate="txtcelular1" ErrorMessage="Falta No Celular Referencia No 1">*</asp:RequiredFieldValidator>
                        <cc11:ValidatorCalloutExtender ID="rqv4_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqv4">
                        </cc11:ValidatorCalloutExtender>
                    </TD>
					<TD class="style19">
                        <cc1:CbxParentesco ID="CbxParentesco1" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="17px" Width="100px">
                        </cc1:CbxParentesco>
                    </TD>
					<TD class="style17"><asp:dropdownlist id="cmbTipref1" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" runat="server"
								Width="100px" tabIndex="2"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD class="style13">
                        <asp:textbox id="txtcref2" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="209px" runat="server"
							MaxLength="40" BorderWidth="1px" onkeypress="return SoloLetras(event)" BorderColor="#2E6A99" 
                            Height="28px" CssClass="ToUpper"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqv5" runat="server" 
                            ControlToValidate="txtcref2" ErrorMessage="Falta Nombre Referencia No 2">*</asp:RequiredFieldValidator>
                        <cc11:ValidatorCalloutExtender ID="rqv5_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqv5">
                        </cc11:ValidatorCalloutExtender>
                    </TD>
					<TD class="style4">
                        <asp:textbox id="txtcdomicilio2" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="216px" runat="server"
							MaxLength="90" BorderWidth="1px" BorderColor="#2E6A99" Height="28px" CssClass="ToUpper"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqv6" runat="server" 
                            ControlToValidate="txtcdomicilio2" 
                            ErrorMessage="Falta Docimilio Referencia No 2">*</asp:RequiredFieldValidator>
                        <cc11:ValidatorCalloutExtender ID="rqv6_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqv6">
                        </cc11:ValidatorCalloutExtender>
                    </TD>
					<TD class="style5"><asp:textbox id="txtctel2" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="85px" runat="server"
							MaxLength="10" BorderWidth="1px" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99" 
                            Height="28px"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqv7" runat="server" 
                            ControlToValidate="txtctel2" ErrorMessage="Falta No Telefono Referencia No 2">*</asp:RequiredFieldValidator>
                        <cc11:ValidatorCalloutExtender ID="rqv7_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqv7">
                        </cc11:ValidatorCalloutExtender>
                    </TD>
					<TD class="style23"><asp:textbox id="txtcelular2" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="85px" runat="server"
							MaxLength="10" BorderWidth="1px" onkeypress="return SoloNumeros(event)" BorderColor="#2E6A99" 
                            Height="28px"></asp:textbox>
                        <asp:RequiredFieldValidator ID="rqv8" runat="server" 
                            ControlToValidate="txtcelular2" ErrorMessage="Falta No Celular Referencia No 2">*</asp:RequiredFieldValidator>
                        <cc11:ValidatorCalloutExtender ID="rqv8_ValidatorCalloutExtender" 
                            runat="server" Enabled="True" TargetControlID="rqv8">
                        </cc11:ValidatorCalloutExtender>
                    </TD>
					<TD class="style20">
                        <cc1:CbxParentesco ID="CbxParentesco2" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Width="100px">
                        </cc1:CbxParentesco>
                    </TD>
					<TD class="style2"><asp:dropdownlist id="cmbTipref2" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" runat="server"
								Width="100px" tabIndex="2"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD class="style7"><asp:textbox id="txtcref3" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="209px" runat="server"
							MaxLength="40" BorderWidth="1px" onkeypress="return SoloLetras(event)" Visible="False"></asp:textbox></TD>
					<TD class="style8"><asp:textbox id="txtcdomicilio3" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="216px" runat="server"
							MaxLength="90" BorderWidth="1px" BorderColor="#2E6A99" Visible="False"></asp:textbox></TD>
					<TD style="WIDTH: 245px">
                        <asp:textbox id="txtctel3" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="85px" runat="server"
							MaxLength="10" BorderWidth="1px" onkeypress="return SoloNumeros(event)" Visible="False"></asp:textbox></TD>
					<TD class="style21">&nbsp;</TD>
					<TD class="style18">&nbsp;</TD>
					<TD><asp:dropdownlist id="cmbTipref3" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" runat="server"
								Width="100px" tabIndex="2" Visible="False"></asp:dropdownlist></TD>
				</TR>
				</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center" class="style2">
			<INPUT id="btnGrabar" style="BACKGROUND-IMAGE: url('Web/jpgs/btn_guardar2_b.gif'); WIDTH: 57px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 50px; BACKGROUND-COLOR: transparent"
							type="button" name="Button1" runat="server"><asp:Button 
                ID="Button1" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Text="Cerrar" Visible="False" />
                    &nbsp;</TD>
	</TR>
	<TR>
		<TD align="center">
			&nbsp;</TD>
	</TR>
</TABLE>
			<TABLE id="Table4" style="WIDTH: 736px; HEIGHT: 125px" cellSpacing="0" 
                cellPadding="0" border="0">
				<TR>
					<TD style="WIDTH: 230px" align="center">
                        <asp:label id="Label20" Font-Bold="True" 
                            ForeColor="Navy" Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="48px" runat="server" Visible="False">NOMBRE</asp:label></TD>
					<TD style="WIDTH: 73px" align="center"></TD>
					<TD style="WIDTH: 245px" align="center">
                        <asp:label id="Label21" Font-Bold="True" 
                            ForeColor="Navy" Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="48px" runat="server" Visible="False">UBICACIÓN</asp:label></TD>
					<TD align="center">
                        <asp:label id="Label22" Font-Bold="True" ForeColor="Navy" 
                            Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="48px" runat="server" Visible="False">TELEFONO</asp:label></TD>
					<TD align="center">
                        <asp:label id="Label30" Font-Bold="True" ForeColor="Navy" 
                            Font-Size="10pt" Font-Names="Gill Sans MT"
							Width="48px" runat="server" Visible="False">REFERENCIA</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 230px">
                        <asp:textbox id="txtcref4" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="209px" runat="server"
							MaxLength="40" BorderWidth="1px" onkeypress="return SoloLetras(event)" Visible="False"></asp:textbox></TD>
					<TD style="WIDTH: 73px">
                        <asp:label id="Label24" ForeColor="Navy" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" Width="56px"
							runat="server" Visible="False">Domicilio:</asp:label></TD>
					<TD style="WIDTH: 245px">
                        <asp:textbox id="txtcdomicilio4" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="216px" runat="server"
							MaxLength="90" BorderWidth="1px" Visible="False"></asp:textbox></TD>
					<TD><asp:textbox id="txtctel4" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="85px" runat="server"
							MaxLength="10" BorderWidth="1px" onkeypress="return SoloNumeros(event)" Visible="False"></asp:textbox></TD>
					<TD><asp:dropdownlist id="cmbTipref4" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" runat="server"
								Width="100px" tabIndex="2" Visible="False"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD class="style9">
                        <asp:textbox id="txtcref5" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="209px" runat="server"
							MaxLength="40" BorderWidth="1px" onkeypress="return SoloLetras(event)" Visible="False"></asp:textbox></TD>
					<TD class="style10">
                        <asp:label id="Label26" ForeColor="Navy" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" Width="56px"
							runat="server" Visible="False">Domicilio:</asp:label></TD>
					<TD class="style11">
                        <asp:textbox id="txtcdomicilio5" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="216px" runat="server"
							MaxLength="90" BorderWidth="1px" Visible="False"></asp:textbox></TD>
					<TD class="style12"><asp:textbox id="txtctel5" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="85px" runat="server"
							MaxLength="10" BorderWidth="1px" onkeypress="return SoloNumeros(event)" Visible="False"></asp:textbox></TD>
					<TD class="style12"><asp:dropdownlist id="cmbTipref5" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" runat="server"
								Width="100px" tabIndex="2" Visible="False"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 230px">
                        <asp:textbox id="txtcref6" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="209px" runat="server"
							MaxLength="10" BorderWidth="1px" onkeypress="return SoloLetras(event)" Visible="False"></asp:textbox></TD>
					<TD style="WIDTH: 73px">
                        <asp:label id="Label28" ForeColor="Navy" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" Width="56px"
							runat="server" Visible="False">Domicilio:</asp:label></TD>
					<TD style="WIDTH: 245px">
                        <asp:textbox id="txtcdomicilio6" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="216px" runat="server"
							MaxLength="90" BorderWidth="1px" Visible="False"></asp:textbox></TD>
					<TD><asp:textbox id="txtctel6" Font-Size="10pt" 
                            Font-Names="Century Gothic" Width="85px" runat="server"
							MaxLength="10" BorderWidth="1px" onkeypress="return SoloNumeros(event)" Visible="False"></asp:textbox></TD>
					<TD><asp:dropdownlist id="cmbTipref6" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" runat="server"
								Width="100px" tabIndex="2" Visible="False"></asp:dropdownlist></TD>
				</TR>
				</TABLE>
		
<p>
    &nbsp;</p>

		
