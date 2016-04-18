<%@ control language="vb" autoeventwireup="false" inherits="Login, App_Web_mb_xwoah" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style4
    {
        width: 65%;
        height: 321px;
       
    }
    .style5
    {
        width: 136px;
       
        /*Las 3 líneas siguientes, sirven para el borde redondeado
        * pero para diferentes navegadores*/
        -webkit-border-radius:5px;
        -moz-border-radius:10px;
         border-radius:10px;
    }
    .style6
    {
     width: 101%;
     height: 265px;
     
    /*Las 3 líneas siguientes, sirven para el borde redondeado
     * pero para diferentes navegadores*/
    -webkit-border-radius:5px;
    -moz-border-radius:10px;
    border-radius:10px;
    
    }
    .style7
    {
        width: 900px;
         
    }
    .style9
    {
        width: 100%;
        height: 4px;
    }
    .style2
    {
        width: 27%;
        height: 82px;
    }
    .style3
    {
        width: 94%;
        height: 3px;
    }
    .style10
    {
        width: 65%;
        height: 25px;
    }
    .style12
    {
        width: 65%;
        height: 27px;
    }
    .style13
    {
        height: 27px;
    }
    .style14
    {
        width: 131px;
    }
    .style15
    {
        width: 485px;
        height: 4px;
    }
    .style16
    {
        height: 25px;
    }
    .ToUpper
    {
    text-transform: uppercase;
    }	
    .style17
    {
        width: 210px;
       
    }
    .style18
    {
        height: 24px;
        width: 175px;
    }
    .style19
    {
        height: 15px;
        width: 175px;
    }
    .style20
    {
        height: 24px;
        width: 151px;
    }
    .style21
    {
        height: 15px;
        width: 151px;
    }
    .style22
    {
        width: 210px;
        height: 488px;
    }
    
    
  .txtbox
        {
        	text-transform: uppercase;
            border-top-left-radius: 10px;
            border-top-right-radius: 10px;
            border-bottom-left-radius: 10px;
            border-bottom-right-radius: 10px;
            
        }
  
    
</style>
<table class="style4" border=0>
    <tr>
        <td class="style5" bgcolor="#DBB5FD">
            <table class="style6" bgcolor="#DBB5FD">
                <tr>
                    <td align="center" bgcolor="#DBB5FD" class="style22">
                        <br />
			<TABLE style="WIDTH: 100px; HEIGHT: 100px; margin-top: 0px; margin-bottom: 0px;" 
                            borderColor="#DBB5FD" bgColor="#DBB5FD" 
                            borderColorLight="#DBB5FD" >
				<TR>
					<TD style="FONT-SIZE: 0.8em; " align="right" 
                        bgColor="#DBB5FD" class="style20">
                        <asp:label id="lblUsuario" Runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt">Usuario:</asp:label></TD>
					<TD align="left" bgColor="#DBB5FD" class="style18">
                        <br />
                        <asp:textbox id="txtUsuario" Width="148px" Runat="server" 
                            Font-Names="Gill Sans MT" BorderColor="#99CCFF"
							Font-Size="12pt" MaxLength="10" ForeColor="#9966FF" cssclass="txtbox"></asp:textbox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 0.8em; " align="right" 
                        bgColor="#DBB5FD" class="style21">
                        <asp:label id="lblClave" Runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt">Clave:</asp:label>&nbsp;&nbsp;&nbsp; </TD>
					<TD align="left" bgColor="#DBB5FD" class="style19">
                        <asp:textbox id="txtClave" 
                            Width="149px" Runat="server" Font-Names="Gill Sans MT" BorderColor="#99CCFF"
							Font-Size="12pt" TextMode="Password" ForeColor="#9966FF" cssclass="txtbox"></asp:textbox>
                        <br />
                    </TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 0.8em; " align="right" 
                        bgColor="#DBB5FD" class="style21">
                        <br />
                        <asp:label id="lblClave0" Runat="server" Font-Names="Gill Sans MT">Empresa:</asp:label></TD>
					<TD align="left" bgColor="#DBB5FD" class="style19">
                        <br />
                        <asp:DropDownList ID="cbxfondos" runat="server" AutoPostBack="True" 
                            Font-Names="Century Gothic" Font-Size="8.5pt" Height="16px" Width="146px" 
                            BackColor="White" Font-Bold="True" Font-Overline="False" Font-Underline="False" 
                            ForeColor="#9966FF" EnableTheming="True">
                        </asp:DropDownList>
                    </TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 0.8em; " align="right" 
                        bgColor="#DBB5FD" class="style21">
                        <asp:label id="lblClave1" Runat="server" Font-Names="Gill Sans MT" 
                            Visible="False">Año:</asp:label></TD>
					<TD align="left" bgColor="#DBB5FD" class="style19">
                        <asp:DropDownList ID="cbxanos" runat="server" 
                            Font-Names="Century Gothic" Font-Size="8pt" Height="17px" Width="99px" 
                            Enabled="False" Visible="False">
                        </asp:DropDownList>
                    </TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 27px" borderColor="#CC99FF" align="center" bgColor="#DBB5FD" 
                        colSpan="2">
                        <br />
                        <asp:button id="btnIn" runat="server" Font-Names="Gill Sans MT" 
                            Text="Ingresar" Width="143px" BorderColor="#CC99FF" BorderStyle="Solid" 
                            ForeColor="#9966FF" BackColor="White" Height="33px" Font-Bold="True"></asp:button>
                        <br />
                    </TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 0.8em; COLOR: red" align="center" bgColor="#DBB5FD" 
                        colSpan="2"><asp:literal id="FailureText" Runat="server" EnableViewState="False" ></asp:literal></TD>
				</TR>
			</TABLE>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
						</td>
                </tr>
                <tr>
                    <td align="center" bgcolor="#DBB5FD" class="style17" id="#CC99FF">
						<asp:hyperlink id="HyperLink1" runat="server" Height="16px" 
                            ForeColor="#9900CC" NavigateUrl="http://www.mfamiga"
							Font-Names="Gill Sans MT" Font-Size="12pt" BackColor="#DBB5FD" Width="224px">http://www.mfamiga.com/</asp:hyperlink>
					</td>
                </tr>
                </table>
        </td>
        <td align="justify" class="style7" style="background: url(imagenes/fondo_.png">
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        
                        <table cellpadding="0" cellspacing="0" class="style2" 
                align="center" bgcolor="White">
                            <tr>
                                <td align="center" bgcolor="White">
                                    <asp:Label ID="Label1" runat="server" BackColor="#CCCC00" Font-Names="Gill Sans MT" 
                                        ForeColor="White" Text="Cambiar la contraseña" Visible="False" 
                                        Enabled="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table align="center" cellpadding="0" cellspacing="0" class="style3">
                                        <tr>
                                            <td align="right" class="style15">
                                                <asp:Label ID="Label7" runat="server" Font-Names="Gill Sans MT" 
                                                    Text="Contraseña Actual:" Font-Size="9pt"></asp:Label>
                                            </td>
                                            <td class="style9">
                                                <asp:textbox id="txtClave2" 
                            Width="100px" Runat="server" Font-Names="Gill Sans MT" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password" Height="21px"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style10" bgcolor="White">
                                                <asp:Label ID="Label8" runat="server" Font-Names="Gill Sans MT" 
                                                    Text="Nueva Contraseña:" Font-Size="9pt"></asp:Label>
                                            </td>
                                            <td class="style16">
                                                <asp:textbox id="txtClave0" 
                            Width="100px" Runat="server" Font-Names="Gill Sans MT" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password" Height="21px"></asp:textbox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" class="style12">
                                                <asp:Label ID="Label9" runat="server" Font-Names="Gill Sans MT" 
                                                    Text="Confirmar Nueva Contraseña:" Font-Size="9pt"></asp:Label>
                                            </td>
                                            <td class="style13">
                                                <asp:textbox id="txtClave1" 
                            Width="100px" Runat="server" Font-Names="Gill Sans MT" BorderColor="Black"
							Font-Size="0.8em" TextMode="Password" Height="21px"></asp:textbox>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Label ID="Label5" runat="server" Font-Names="Gill Sans MT" ForeColor="Red" 
                                        
                                        Text="Confirmar la nueva contraseña debe coincidir con la entrada Nueva contraseña." 
                                        Font-Size="9pt"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table align="center" cellpadding="0" cellspacing="0" class="style5">
                                        <tr>
                                            <td align="center" class="style14">
                                                <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" 
                                                    Text="Confirmar" BorderColor="Black" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        <br />
        </td>
    </tr>
</table>

<p style="margin-left: 400px">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label10" runat="server" Font-Names="Arial" Font-Size="8pt" 
        Text="Copyright@ 2015 Amiga"></asp:Label>
</p>



