<%@ control language="vb" autoeventwireup="false" inherits="ucchequeo, App_Web_5wr0lfuo" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 88%;
        height: 56px;
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
						<asp:label id="Label3" runat="server" Width="555px" Font-Bold="True" 
                            Font-Size="12pt" Height="15px"
							Font-Names="Gill Sans MT" ForeColor="#16387C" BackColor="Yellow" BorderWidth="2px">CHEQUEO 
                        DE CONTROL DE EXPEDIENTES DE PRESTAMO</asp:label>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
						<table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td>
                                    <asp:label id="Label1" Font-Names="Gill Sans MT" runat="server" Width="56px" Font-Size="10pt" Height="15px">Nombre:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtnomcli" tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                        Width="336px" Font-Size="10pt" Enabled="False" Height="22px"></asp:textbox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:label id="Label5" Font-Names="Gill Sans MT" runat="server" Width="56px" 
                                        Font-Size="10pt" Height="15px">Crédito:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtccodcta" tabIndex="5" Font-Names="Gill Sans MT" runat="server" 
                                        Width="225px" Font-Size="10pt" Enabled="False" Height="25px"></asp:textbox>
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
                <asp:GridView ID="datagrid1" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" CssClass="CSSTableGenerator" Font-Names="Verdana" 
                    Font-Size="10pt" Height="148px" Width="579px">
                    <Columns>
                        <asp:BoundField DataField="ccodchk" HeaderText="Codigo Chequeo">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cnomchk" HeaderText="Datos a Verificar">
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Chequeo">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("cnudoci") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox2" runat="server" 
                                    Checked='<%# DataBinder.Eval(Container, "DataItem.lopcion") %>' />
                            </ItemTemplate>
                            <ControlStyle Font-Names="Calibri" Font-Size="10pt" />
                            <HeaderStyle Font-Names="Gill Sans MT" Font-Size="10pt" />
                            <ItemStyle Font-Names="Gill Sans MT" Font-Size="10pt" 
                                HorizontalAlign="Center" />
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
                    <td align="center" class="style17">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" class="style17">
						<table cellpadding="0" cellspacing="0" class="style2">
                            <tr>
                                <td class="style3">
                                    <asp:Label ID="Label4" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Visible="False"></asp:Label>
                                </td>
                                <td class="style4">
                                    <asp:CheckBox ID="CheckBox1" runat="server" Visible="False" />
                                </td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Font-Names="Gill Sans MT" Font-Size="10pt" 
                                        Text="Aplicar" Visible="False" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
                                    <asp:ImageButton ID="ImageButton1" runat="server" 
                                        ImageUrl="~/web/jpgs/btn_guardar2_b.gif" />
                                    <cc1:ConfirmButtonExtender ID="ImageButton1_ConfirmButtonExtender" 
                                        runat="server" ConfirmText="Desea Guardar Chequeo?" Enabled="True" 
                                        TargetControlID="ImageButton1">
                                    </cc1:ConfirmButtonExtender>
                                </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="16px" Visible="False" 
                            Width="34px"></asp:TextBox>
                        <asp:TextBox ID="txtccomodin" runat="server" Height="16px" Visible="False" 
                            Width="34px"></asp:TextBox>
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
