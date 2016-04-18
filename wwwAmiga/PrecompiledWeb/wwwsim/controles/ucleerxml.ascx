<%@ control language="vb" autoeventwireup="false" inherits="ucleerxml, App_Web_yjxjq67i" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<HEAD>

    <style type="text/css">
          .BackColorTab
        {
            font-family:Verdana, Arial, Courier New;
            font-size: 12px;
            color:Black;
            background-color:White; 
        }
        .style12
        {
            height: 396px;
        }
        .style13
        {
            width: 100%;
            height: 154px;
        }
        #msgServerSide
        {
            height: 39px;
        }
        .style14
        {
            height: 43px;
        }
        #Table1
        {
            height: 692px;
            width: 101%;
        }
    </style>
</HEAD>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0">
	<TR>
		<TD class="style12">
                        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                        </cc1:ToolkitScriptManager>

<!--CssClass="BackColorTab"-->
            <cc1:TabContainer ID="TabContainer1"   runat="server" ActiveTabIndex="0" 
                Height="408px" Width="850px" style="margin-top: 1px">
                <cc1:TabPanel  runat="server" HeaderText="Conciliación" ID="TabPanel1">
                    <ContentTemplate>
                        <table cellpadding="0" cellspacing="0" class="style13">
                            <tr>
                                <td align="center" class="style14">
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Verdana" 
                                        Font-Size="Medium" ForeColor="#16387C" Height="15px" Width="251px">Conciliacion Bancaria</asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Label ID="Label38" runat="server" Font-Names="Verdana" Font-Size="X-Small" 
                                        Height="15px" Width="166px">Nombre de Archivo:</asp:Label>
                                    <asp:TextBox ID="txtnombar" runat="server" BorderWidth="1px" 
                                        Font-Names="Verdana" Font-Size="X-Small" TabIndex="5" Width="113px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <table align="center" cellpadding="0" cellspacing="0" class="style8">
                                        <tr>
                                            <td class="style9">
                                                <asp:Label ID="Label40" runat="server" Font-Names="Verdana" Font-Size="X-Small" 
                                                    Height="16px" Width="66px">Desde:</asp:Label>
                                            </td>
                                            <td class="style10">
                                                <asp:TextBox ID="txtdesde" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                    Height="22px" Width="87px"></asp:TextBox>
                                                <cc1:CalendarExtender ID="txtdesde_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="dd/MM/yyyy" TargetControlID="txtdesde">
                                                </cc1:CalendarExtender>
                                            </td>
                                            <td class="style11">
                                                <asp:Label ID="Label41" runat="server" Font-Names="Verdana" Font-Size="X-Small" 
                                                    Height="16px" Width="66px">Hasta:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txthasta" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                                    Height="22px" Width="87px"></asp:TextBox>
                                                <cc1:CalendarExtender ID="txthasta_CalendarExtender" runat="server" 
                                                    Enabled="True" Format="dd/MM/yyyy" TargetControlID="txthasta">
                                                </cc1:CalendarExtender>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                        Text="Importar Archivo" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <table cellpadding="0" cellspacing="0" class="style4">
                                        <tr>
                                            <td class="style5">
                                                <asp:Label ID="Label39" runat="server" Font-Names="Verdana" Font-Size="X-Small" 
                                                    Height="16px" style="margin-right: 0px" Width="60px">Banco:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="cmbbanco" runat="server" Font-Names="Calibri" 
                                                    Font-Size="10pt" Height="24px" Width="305px">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <table align="center" cellpadding="0" cellspacing="0" class="style6">
                                        <tr>
                                            <td class="style7">
                                                <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" 
                                                    Font-Names="Calibri" Font-Size="10pt" GroupName="opcion" 
                                                    Text="Movimientos Registrados en SIM y no en BANCO" Width="294px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style7">
                                                <asp:RadioButton ID="RadioButton2" runat="server" Font-Names="Calibri" 
                                                    Font-Size="10pt" GroupName="opcion" 
                                                    Text="Movimientos Registrados en BANCO y no en SIM" Width="294px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style7">
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Button ID="Button2" runat="server" Font-Names="Calibri" Text="Procesar" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Label ID="label_mensaje" runat="server" Font-Names="Verdana" 
                                        Font-Size="8pt" ForeColor="Red" Height="15px" Width="184px"></asp:Label>
                                    <asp:RangeValidator ID="RangeValidator5" runat="server" 
                                        ControlToValidate="txtfecbar" DESIGNTIMEDRAGDROP="1491" 
                                        ErrorMessage="RangeValidator" Font-Names="Verdana" Font-Size="8pt" 
                                        MaximumValue="01/01/3000" MinimumValue="01/01/2000" Type="Date" Width="88px">Fecha Inválida-</asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                        AllowSorting="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" 
                                        BorderWidth="1px" CellPadding="4" Font-Names="Calibri" ForeColor="Black" 
                                        GridLines="Vertical">
                                        <RowStyle BackColor="#F7F7DE" />
                                        <AlternatingRowStyle BackColor="#FFFF66" />
                                        <FooterStyle BackColor="#CCCC99" />
                                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:TextBox ID="txtfecbar" runat="server" BorderWidth="1px" 
                                        Font-Names="Verdana" Font-Size="X-Small" TabIndex="5" Visible="False" 
                                        Width="83px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Subir Archivo">
                    <HeaderTemplate>
                        Subir Archivo
                    </HeaderTemplate>
                    <ContentTemplate>
                        <table cellpadding="0" cellspacing="0" class="style13">
                            <tr>
                                <td align="center">
                                    
                                     <div id="Throbber" runat="server"
                                       style="display: none;"> 
                                       <img align="middle" alt="" src="indicator.gif" />
                                        </div>
                                         <div id="msgServerSide" runat="server" align="center">   
                                             <asp:FileUpload ID="FileUpload1" runat="server" />
                                    </div>
                                     <div align="center">
                                         <asp:Label ID="lblStatus" runat="server"></asp:Label>
                                     </div> 
                                     <div id="msgClientSide" runat="server" style="display: none">   </div>
                                     <asp:Button ID="Button3" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                                         Text="Enviar" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </cc1:TabPanel>
            </cc1:TabContainer>
        </TD>
	</TR>
	</TABLE>
<SCRIPT language="JavaScript">
 function aplicar()
 {
 if(confirm("¿Esta seguro de continuar?"))
   alert("ok");
  else
   alert("proceso no completado");
 }
</SCRIPT>
