<%@ Control Language="vb" AutoEventWireup="false" Inherits="cuwLoteAna" CodeFile="cuwLoteAna.ascx.vb" %>
<style type="text/css">
    .style1
    {
        width: 361px;
    }
    .style2
    {
        width: 223px;
    }
    .style3
    {
        height: 38px;
    }
</style>
<TABLE id="Table1" style="border: thin solid highlight; WIDTH: 752px; HEIGHT: 144px; BACKGROUND-COLOR: #ffffff"
	cellSpacing="0" cellPadding="0" align="left" border="0">
	<TR>
		<TD style="HEIGHT: 20px">
			&nbsp;</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 20px" align="center">
										<asp:Label id="Label6" Font-Size="15pt" 
                Width="475px" Font-Names="Gill Sans MT" runat="server" ForeColor="Navy" 
                Font-Bold="True">CAMBIO DE ANALISTA POR  LOTES</asp:Label>
		</TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <TABLE id="Table2" 
    style="WIDTH: 736px; HEIGHT: 336px" borderColor="inactivecaption" cellSpacing="0"
								cellPadding="0" border="0">
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label id="Label4" Font-Size="12pt" Width="99px" Font-Names="Gill Sans MT" 
                                            runat="server" ForeColor="Navy">Analistas</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="cmbanaact" runat="server" 
                                            Font-Names="Gill Sans MT" Height="25px" Width="307px">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                <asp:CheckBox ID="CheckBox1" runat="server" 
                                            Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Navy" 
                                    Text="Todos" Checked="True" />
                            </TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label id="Label14" Font-Size="12pt" Width="99px" Font-Names="Gill Sans MT" 
                                            runat="server" ForeColor="Navy">Metodología:</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="ddlgarantia" runat="server" 
                                            Font-Names="Gill Sans MT" Height="25px" Width="307px">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                <asp:CheckBox ID="CheckBox2" runat="server" Checked="True" 
                                    Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Navy" Text="Todos" />
                            </TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label id="Label7" Font-Size="12pt" Width="99px" Font-Names="Gill Sans MT" 
                                            runat="server" ForeColor="Navy">Programa:</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="ddlcartera" runat="server" 
                                            Font-Names="Gill Sans MT" Height="25px" Width="307px" 
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                <asp:CheckBox ID="CheckBox3" runat="server" Checked="True" 
                                    Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Navy" Text="Todos" />
                            </TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label id="Label8" Font-Size="12pt" Width="99px" Font-Names="Gill Sans MT" 
                                            runat="server" ForeColor="Navy">Producto:</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="ddlprogramas" runat="server" 
                                            Font-Names="Gill Sans MT" Height="25px" Width="307px">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                <asp:CheckBox ID="CheckBox4" runat="server" Checked="True" 
                                    Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Navy" Text="Todos" />
                            </TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label id="Label9" Font-Size="12pt" Width="99px" Font-Names="Gill Sans MT" 
                                            runat="server" ForeColor="Navy">Fondo:</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="ddlfondos" runat="server" 
                                            Font-Names="Gill Sans MT" Height="25px" Width="307px">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                <asp:CheckBox ID="CheckBox5" runat="server" Checked="True" 
                                    Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Navy" Text="Todos" />
                            </TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label id="Label10" Font-Size="12pt" Width="99px" Font-Names="Gill Sans MT" 
                                            runat="server" ForeColor="Navy">Departamento:</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="DropDownDeptos" runat="server" 
                                            Font-Names="Gill Sans MT" Height="25px" Width="307px" 
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                <asp:CheckBox ID="CheckBox6" runat="server" Checked="True" 
                                    Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Navy" Text="Todos" />
                            </TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label id="Label11" Font-Size="12pt" Width="99px" Font-Names="Gill Sans MT" 
                                            runat="server" ForeColor="Navy">Municipios:</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="DropDownMuni" runat="server" 
                                            Font-Names="Gill Sans MT" Height="25px" Width="307px" 
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                <asp:CheckBox ID="CheckBox7" runat="server" Checked="True" 
                                    Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Navy" Text="Todos" />
                            </TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label id="Label12" Font-Size="12pt" Width="99px" Font-Names="Gill Sans MT" 
                                            runat="server" ForeColor="Navy">Comunidad/Colonia/Cantón:</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="DropDownComu" runat="server" 
                                            Font-Names="Gill Sans MT" Height="25px" Width="307px">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                <asp:CheckBox ID="CheckBox8" runat="server" Checked="True" 
                                    Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Navy" Text="Todos" />
                            </TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label ID="Label15" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="12pt" ForeColor="Navy" Width="99px">Tipo Cartera:</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="ddltipo" runat="server" Font-Names="Gill Sans MT" 
                                    Height="25px" Width="307px">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                <asp:CheckBox ID="CheckBox9" runat="server" Checked="True" 
                                    Font-Names="Gill Sans MT" Font-Size="12pt" ForeColor="Navy" Text="Todos" />
                            </TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                &nbsp;</TD>
                            <TD class="style1">
                                &nbsp;</TD>
                            <TD>
                                &nbsp;</TD>
                        </TR>
                        <TR>
                            <TD align="right" class="style2">
                                <asp:Label ID="Label5" runat="server" Font-Names="Gill Sans MT" 
                                    Font-Size="12pt" ForeColor="Navy" Width="142px">Analista a Asignar:</asp:Label>
                            </TD>
                            <TD class="style1">
                                <asp:DropDownList ID="cmbananue" runat="server" 
                                            Font-Names="Gill Sans MT" Height="25px" Width="307px">
                                </asp:DropDownList>
                            </TD>
                            <TD>
                                &nbsp;</TD>
                        </TR>
                    </TABLE>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="DropDownDeptos" />
                    <asp:AsyncPostBackTrigger ControlID="DropDownMuni" />
                    <asp:AsyncPostBackTrigger ControlID="ddlcartera" />
                </Triggers>
            </asp:UpdatePanel>
		</TD>
	</TR>
	<TR>
		<TD align="center" class="style3">
			<asp:Button ID="btntrasladar" runat="server" Font-Names="Gill Sans MT" 
                Font-Size="12pt" Text="Trasladar" Width="102px" />
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 20px" align="center">
			&nbsp;</TD>
	</TR>
</TABLE>
