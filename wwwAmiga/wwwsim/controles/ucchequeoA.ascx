<%@ Control Language="vb" AutoEventWireup="false" Codefile="ucchequeoA.ascx.vb" Inherits="ucchequeoA"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 88%;
        height: 28px;
    }
    .style2
    {
        width: 89%;
    }
    .style3
    {
        width: 343px;
    }
    .style4
    {
        width: 130px;
    }
    .style5
    {
        width: 120px;
    }
</style>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="1" 
    style="OVERFLOW: visible; WIDTH: 580px; HEIGHT: 375px">
	<TR>
		<TD align="center" 
            style="border: thin solid highlight; BACKGROUND-COLOR: #ffffff" 
            class="style16">
            &nbsp;&nbsp;
            <table cellpadding="0" cellspacing="0" class="style14" align="center">
                <tr>
                    <td align="center" class="style17">
						<asp:label id="Label3" runat="server" Width="549px" Font-Bold="True" 
                            Font-Size="14pt" Height="15px"
							Font-Names="Calibri" ForeColor="#16387C" BackColor="Yellow" BorderWidth="2px">CHEQUEO 
                        DE AGENCIAS VALIDADAS</asp:label>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
						<table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td class="style5">
                                    <asp:label id="Label1" Font-Names="Verdana" runat="server" Width="56px" 
                                        Font-Size="8pt" Height="15px" Enabled="False" Visible="False" 
                                        ForeColor="#FF3300">Grupo:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtnomgru" tabIndex="5" Font-Names="Verdana" runat="server" 
                                        Width="311px" Font-Size="8pt" Enabled="False" Height="24px" Visible="False"></asp:textbox>
                                </td>
                            </tr>
                            </table>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" class="style17">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                            Font-Names="Gill Sans MT" Width="468px">
                            <Columns>
                                <asp:BoundField DataField="ccodofi" HeaderText="Codigo" />
                                <asp:BoundField DataField="cnomofi" HeaderText="Agencia" />
                                <asp:TemplateField HeaderText="Estatus">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" 
                                            Text='<%# DataBinder.Eval(Container,"DataItem.estado") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
						<table cellpadding="0" cellspacing="0" class="style2">
                            <tr>
                                <td class="style3">
                                    <asp:Label ID="Label4" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                        Visible="False"></asp:Label>
                                </td>
                                <td class="style4">
                                    <asp:CheckBox ID="CheckBox1" runat="server" Visible="False" />
                                </td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="10pt" 
                                        Text="Aplicar" Visible="False" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    &nbsp;</td>
                                <td class="style4">
                                    <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" 
                                        Font-Names="Calibri" Text="Aplicar a Todos" Visible="False" />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
                                    <asp:ImageButton ID="ImageButton1" runat="server" 
                                        ImageUrl="~/web/jpgs/btn_aplicar_b.jpg" />
                                
                                </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="16px" Visible="False" 
                            Width="34px"></asp:TextBox>
                        <asp:TextBox ID="txtccomodin" runat="server" Height="16px" Visible="False" 
                            Width="34px"></asp:TextBox>
                                    <asp:textbox id="txtccodcta" tabIndex="5" Font-Names="Verdana" runat="server" 
                                        Width="18px" Font-Size="8pt" Enabled="False" Height="25px" 
                                        Visible="False"></asp:textbox>
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                    </td>
                </tr>
                </table>
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
