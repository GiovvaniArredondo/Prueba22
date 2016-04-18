<%@ Reference Control="~/controles/Reportes.ascx" %>
<%@ Control Language="vb" AutoEventWireup="false" Inherits="wbajuste" CodeFile="wbajuste.ascx.vb" %>
<style type="text/css">
    .style1
    {
        height: 36px;
    }
    .style2
    {
        height: 23px;
    }
    .style3
    {
        width: 79%;
    }
    .style4
    {
        width: 226px;
    }
    .style5
    {
        width: 92%;
    }
    .style6
    {
        width: 80px;
    }
    .style7
    {
        width: 76px;
    }
    .style8
    {
        width: 78px;
    }
    .style9
    {
        width: 70px;
    }
    .style10
    {
        width: 94%;
        height: 117px;
    }
    .style11
    {
        width: 138px;
    }
    .style14
    {
        width: 81px;
    }
    .style15
    {
        width: 72%;
    }
    .style16
    {
        width: 182px;
    }
    .style17
    {
        width: 73%;
    }
    .style18
    {
        width: 244px;
    }
    .style19
    {
        height: 17px;
    }
    .style20
    {
        height: 127px;
    }
    .style21
    {
        height: 40px;
    }
    .style22
    {
        width: 100%;
    }
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 494px; HEIGHT: 423px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" width="494" border="0">
	<TR>
		<TD align="center">
			<P style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Gill Sans MT'; BACKGROUND-COLOR: #ffffff"
				align="center">AJUSTE DE CREDITOS</P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 77px" align="center">
			<TABLE id="Table2" style="WIDTH: 469px; HEIGHT: 25px" cellSpacing="0" cellPadding="0" width="469"
				border="0">
				<TR>
					<TD style="WIDTH: 52px" align="right"><asp:label id="Label4" runat="server" Width="56px" Height="15px" Font-Names="Gill Sans MT" Font-Size="10pt">Crédito:</asp:label></TD>
					<TD style="WIDTH: 102px"><asp:dropdownlist id="ddlcodins" runat="server" Width="103px" Height="16px" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 136px"><asp:dropdownlist id="ddlcodofi" runat="server" Width="169px" Font-Names="Gill Sans MT" Font-Size="10pt"></asp:dropdownlist></TD>
					<TD style="WIDTH: 109px"><asp:textbox id="txtcnrocta" tabIndex="5" runat="server" Width="152px" Font-Names="Gill Sans MT" Font-Size="10pt"
							Enabled="False"></asp:textbox></TD>
					<TD align="center"></TD>
				</TR>
			</TABLE>
			<TABLE id="Table3" style="WIDTH: 438px; HEIGHT: 56px" cellSpacing="0" cellPadding="0" width="438"
				border="0">
				<TR>
					<TD style="WIDTH: 139px" align="right"><asp:label id="Label9" runat="server" Width="67px" Height="15px" Font-Names="Gill Sans MT" Font-Size="10pt">Nombre:  </asp:label></TD>
					<TD style="WIDTH: 243px"><asp:textbox id="txtnomcli" runat="server" Width="232px" Font-Names="Gill Sans MT" Font-Size="10pt"
							Enabled="False"></asp:textbox></TD>
					<TD>
						<P align="center">
                            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Gill Sans MT" 
                                Font-Size="10pt" Text="Aplicar" />
                        </P>
					</TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 162px" align="center">
						<TABLE id="Table6" style="WIDTH: 439px; HEIGHT: 120px" cellSpacing="0" cellPadding="0"
							width="439" align="center" border="0">
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 8px"><asp:label id="Label12" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Cuota:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 8px"><asp:textbox id="txtmoncuo" runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 8px"><asp:label id="Label13" runat="server" Width="96px" Font-Names="Gill Sans MT" Font-Size="10pt">Deuda Capital:</asp:label></TD>
								<TD style="HEIGHT: 8px"><asp:textbox id="txtdeucap" runat="server" Width="102px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 8px"><asp:label id="Label3" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Saldo Capital:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 8px"><asp:textbox id="txtcapita" runat="server" Width="102px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 8px"><asp:label id="Label5" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Interés:</asp:label></TD>
								<TD style="HEIGHT: 8px"><asp:textbox id="txtinteres" runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 6px"><asp:label id="Label6" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Mora:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 6px"><asp:textbox id="txtmora" runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 6px"><asp:label id="Label10" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Ultimo Pago:</asp:label></TD>
								<TD style="HEIGHT: 6px"><asp:textbox id="txtdultpag" runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 109px; HEIGHT: 1px"><asp:label id="Label8" runat="server" Width="96px" Font-Names="Gill Sans MT" Font-Size="10pt" Font-Bold="True">Total a pagar:</asp:label></TD>
								<TD style="WIDTH: 117px; HEIGHT: 1px"><asp:textbox id="txttotal" runat="server" Width="104px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False"></asp:textbox></TD>
								<TD style="WIDTH: 197px; HEIGHT: 1px"><asp:label id="Label1" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Dias Atraso:</asp:label></TD>
								<TD style="HEIGHT: 1px"><asp:textbox id="txtdias" runat="server" Width="72px" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"></asp:textbox></TD>
							</TR>
							</TABLE>
						</TD>
	</TR>
	<TR>
		<TD align="center" class="style19">
            <table cellpadding="0" cellspacing="0" class="style17">
                <tr>
                    <td align="right" class="style18">
                        <asp:label id="Label2" runat="server" Width="146px" Font-Names="Gill Sans MT" Font-Size="10pt" Font-Bold="True">Fecha a Procesar:</asp:label>
                    </td>
                    <td>
                        <asp:textbox id="txtfecval2" tabIndex="5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="104px"
				runat="server" BorderWidth="1px"></asp:textbox>
                    </td>
                    <td>
                        <asp:rangevalidator id="RangeValidator5" Font-Size="10pt" Font-Names="Gill Sans MT" Width="88px" runat="server"
				ControlToValidate="txtfecval2" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000" MaximumValue="01/01/3000" DESIGNTIMEDRAGDROP="1491">Fecha Inválida-</asp:rangevalidator>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style1">
            <table cellpadding="0" cellspacing="0" class="style3" bgcolor="#FFFF66" 
                border="1" style="border-color: #000000">
                <tr>
                    <td align="center" class="style4">
                        <asp:RadioButton ID="RadioButton1" runat="server" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" GroupName="Tipo" 
                            Text="Nota de Débito" />
                    </td>
                    <td align="center">
                        <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" GroupName="Tipo" Text="Nota de Crédito" Checked="True" />
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style2">
            <table cellpadding="0" cellspacing="0" class="style5">
                <tr>
                    <td align="left" class="style6">
                        <asp:label id="Label14" runat="server" Width="50px" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="16px">Capital:</asp:label>
                    </td>
                    <td class="style7">
                        <asp:TextBox ID="TextBox1" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Height="20px" Width="70px"></asp:TextBox>
                    </td>
                    <td align="left" class="style8">
                        <asp:label id="Label15" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Interés:</asp:label>
                    </td>
                    <td class="style7">
                        <asp:TextBox ID="TextBox2" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Height="20px" Width="70px"></asp:TextBox>
                    </td>
                    <td align="left" class="style9">
                        <asp:label id="Label16" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt">Mora:</asp:label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Height="20px" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="style6">
                        &nbsp;</td>
                    <td class="style7">
                                        <asp:rangevalidator id="RangeValidator1" runat="server" 
                            Width="90px" Font-Names="Gill Sans MT" Font-Size="10pt"
								ErrorMessage="RangeValidator" ControlToValidate="TextBox1" MaximumValue="1000000" MinimumValue="0"
								Type="Double">Monto Inválido</asp:rangevalidator>
                    </td>
                    <td align="left" class="style8">
                        &nbsp;</td>
                    <td class="style7">
                                        <asp:rangevalidator id="RangeValidator6" runat="server" 
                            Width="90px" Font-Names="Gill Sans MT" Font-Size="10pt"
								ErrorMessage="RangeValidator" ControlToValidate="TextBox2" MaximumValue="1000000" MinimumValue="0"
								Type="Double">Monto Inválido</asp:rangevalidator>
                    </td>
                    <td align="left" class="style9">
                        &nbsp;</td>
                    <td>
                                        <asp:rangevalidator id="RangeValidator7" runat="server" 
                            Width="90px" Font-Names="Gill Sans MT" Font-Size="10pt"
								ErrorMessage="RangeValidator" ControlToValidate="TextBox3" MaximumValue="1000000" MinimumValue="0"
								Type="Double">Monto Inválido</asp:rangevalidator>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style20">
            <table cellpadding="0" cellspacing="0" class="style10">
                <tr>
                    <td align="right" class="style11">
                        <asp:label id="Label17" runat="server" Width="168px" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="16px">Nota de Débito o Crédito Nº:</asp:label>
                    </td>
                    <td class="style14">
                        <asp:TextBox ID="TextBox4" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Height="22px" Width="101px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:label id="Label18" runat="server" Width="112px" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="17px" Visible="False">Cuenta Contable:</asp:label>
                    </td>
                    <td class="style14">
                        <asp:TextBox ID="TextBox6" runat="server" AutoPostBack="True" 
                            Font-Names="Gill Sans MT" Font-Size="10pt" Height="22px" Width="101px" 
                            Visible="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        &nbsp;</td>
                    <td class="style14">
							<asp:label id="Label20" ForeColor="Red" Font-Size="10pt" 
                            Font-Names="Gill Sans MT" runat="server"
								Width="138px" Height="16px" Visible="False"></asp:label>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:label id="Label19" runat="server" Width="107px" Font-Names="Gill Sans MT" 
                            Font-Size="10pt" Height="16px" style="margin-right: 0px">Concepto:</asp:label>
                    </td>
                    <td class="style14">
                        <asp:TextBox ID="TextBox5" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                            Height="56px" TextMode="MultiLine" Width="276px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style21">
            <table cellpadding="0" cellspacing="0" class="style15" bgcolor="#CCFF66" 
                border="1" style="border-color: #000000">
                <tr>
                    <td align="center" class="style16">
                        <asp:Button ID="Button2" runat="server" Font-Names="Gill Sans MT" Text="Guardar" />
                    </td>
                    <td align="center">
                        <asp:Button ID="Button3" runat="server" Font-Names="Gill Sans MT" Text="Imprimir" 
                            Enabled="False" />
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	<TR>
		<TD align="center" class="style2">&nbsp;</TD>
	</TR>
	<TR>
		<TD align="center" class="style2"><asp:textbox id="txtmon60" runat="server" 
                Width="46px" Font-Names="Gill Sans MT" Font-Size="10pt"
										Enabled="False" Height="18px" Visible="False"></asp:textbox><asp:textbox id="txt60" runat="server" Width="64px" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"
							Visible="False"></asp:textbox><asp:textbox id="txt30" runat="server" Width="73px" Font-Names="Gill Sans MT" Font-Size="10pt" Enabled="False"
							Visible="False"></asp:textbox>
						<asp:textbox id="txtccodcli" runat="server" Width="75px" Font-Names="Gill Sans MT" Font-Size="10pt"
							Enabled="False" Visible="False"></asp:textbox>
						<asp:textbox id="txtncappag" runat="server" Width="75px" 
                Font-Names="Gill Sans MT" Font-Size="10pt"
							Enabled="False" Visible="False"></asp:textbox>
						<asp:textbox id="txtcletras" runat="server" Width="75px" 
                Font-Names="Gill Sans MT" Font-Size="10pt"
							Enabled="False" Visible="False"></asp:textbox></TD>
	</TR>
	<TR>
		<TD>
			<table cellpadding="0" cellspacing="0" class="style22">
                <tr>
                    <td>
                        <asp:HiddenField ID="HiddenField1" runat="server" />
                    </td>
                    <td>
                        <asp:HiddenField ID="HiddenField2" runat="server" />
                    </td>
                    <td>
                        <asp:HiddenField ID="HiddenField3" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HiddenField ID="HiddenField4" runat="server" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </TD>
	</TR>
</TABLE>
