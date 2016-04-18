<%@ Control Language="vb" AutoEventWireup="false" Codefile="ucchequeoG.ascx.vb" Inherits="ucchequeoG"  %>
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
                        DE CONTROL DE EXPEDIENTES DE PRESTAMO GRUPAL</asp:label>
                        </td>
                </tr>
                <tr>
                    <td align="center" class="style17">
						<table cellpadding="0" cellspacing="0" class="style1">
                            <tr>
                                <td class="style5">
                                    <asp:label id="Label1" Font-Names="Verdana" runat="server" Width="56px" Font-Size="8pt" Height="15px">Grupo:</asp:label>
                                </td>
                                <td>
                                    <asp:textbox id="txtnomgru" tabIndex="5" Font-Names="Verdana" runat="server" 
                                        Width="311px" Font-Size="8pt" Enabled="False" Height="24px"></asp:textbox>
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
                        <asp:datagrid id="datagrid1" runat="server" 
                            Width="536px" AllowSorting="True" AutoGenerateColumns="False"
					BorderColor="#000099" BorderWidth="2px" CellPadding="4" 
                            Height="121px" ForeColor="#333333">
					        <EditItemStyle BackColor="#2461BF" />
					<SelectedItemStyle Font-Bold="True" ForeColor="#333333" BackColor="#D1DDF1"></SelectedItemStyle>
					    <AlternatingItemStyle BackColor="White" />
					<ItemStyle BackColor="#EFF3FB"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#507CD1"></HeaderStyle>
					<FooterStyle ForeColor="White" BackColor="#507CD1" Font-Bold="True"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
						</asp:ButtonColumn>
						<asp:TemplateColumn HeaderText="Codigo de Chequeo">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
							<ItemTemplate>
								<asp:HyperLink id=HyperLink1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.cCodchk") %>' NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.cCodchk", URLCodigo) %>' Target="_self">
								</asp:HyperLink>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:TextBox id=TextBox1 runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.codigo") %>'>
								</asp:TextBox>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="cnomchk" SortExpression="cnomchk" 
                            HeaderText="Documento">
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn  DataField="lopcion" SortExpression="lopcion" HeaderText="Chk" >
							<HeaderStyle Font-Size="8pt" Font-Names="verdana" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
							<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
						</asp:BoundColumn>
					    <asp:BoundColumn DataField="ccodchk" HeaderText="Codigo" 
                            SortExpression="ccodchk"></asp:BoundColumn>
       					<asp:TemplateColumn HeaderText="Chequeo">
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox3" runat="server" 
                                    Checked='<%# DataBinder.Eval(Container, "DataItem.lopcion") %>' />
                            </ItemTemplate>
                        </asp:TemplateColumn>
       					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#2461BF" 
                            Wrap="False"></PagerStyle>
				</asp:datagrid>
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
