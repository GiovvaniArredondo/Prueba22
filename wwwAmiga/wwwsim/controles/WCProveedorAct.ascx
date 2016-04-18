<%@ Control Language="vb" AutoEventWireup="false" Inherits="WCProveedorAct" CodeFile="WCProveedorAct.ascx.vb" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<style type="text/css">
    .style1
    {
        width: 90%;
    }
    .style2
    {
        width: 91%;
        height: 61px;
        margin-bottom: 0px;
    }
    .style3
    {
        width: 230px;
    }
    .style4
    {
        height: 120px;
    }
    .style6
    {
        width: 58%;
        height: 49px;
    }
    .style7
    {
        width: 139px;
    }
    .style8
    {
        width: 66%;
    }
    .style9
    {
        height: 40px;
    }
    .style16
    {
        width: 132px;
    }
    .style17
    {
        width: 74px;
    }
    .style18
    {
        width: 309px;
    }
    .style19
    {
        width: 230px;
        height: 19px;
    }
    .style20
    {
        width: 309px;
        height: 19px;
    }
    .style21
    {
        height: 19px;
    }
    .style22
    {
        width: 230px;
        height: 33px;
    }
    .style23
    {
        width: 309px;
        height: 33px;
    }
    .style24
    {
        height: 33px;
    }
    </style>
<head id="Head1" runat="server" />
<table border="1" cellpadding="0" cellspacing="0" class="style8" 
    style="border-color: #000066; height: 341px; background-color: #FFFFFF;">
    <tr>
        <td>
<table cellpadding="0" cellspacing="0" class="style1" align="center">
    <tr>
        <td align="center">
                        <asp:label id="Label1" Font-Size="Small" Width="189px" 
                runat="server" Font-Names="Verdana"
				Font-Bold="True" ForeColor="Maroon" Height="21px">PROVEEDORES ACTIVOS</asp:label>
			        <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </td>
    </tr>
    <tr>
        <td class="style4">
            <table cellpadding="0" cellspacing="0" class="style2" align="center">
                <tr>
                    <td align="right" class="style19">
                                                <asp:label id="Label62" Font-Size="10pt" runat="server" 
                            Font-Names="Georgia">N.I.T.</asp:label>
                                            </td>
                    <td class="style20">
                        <asp:TextBox ID="TextBox6" runat="server" Font-Names="Georgia" Font-Size="10pt" 
                            Width="150px"></asp:TextBox>
                    </td>
                    <td class="style21">
                        </td>
                </tr>
                <tr>
                    <td align="right" class="style22">
                                                <asp:label id="Label57" Font-Size="10pt" runat="server" Font-Names="Georgia">Nombre 
                                                Proveedor:</asp:label>
                                            </td>
                    <td class="style23">
                        <asp:TextBox ID="TextBox1" runat="server" Font-Names="Georgia" Font-Size="10pt" 
                            Width="300px"></asp:TextBox>
                    </td>
                    <td class="style24">
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style3">
                                                <asp:label id="Label65" Font-Size="10pt" runat="server" 
                            Font-Names="Georgia" Visible="False">Servicio:</asp:label>
                                                <asp:label id="Label63" Font-Size="10pt" runat="server" 
                            Font-Names="Georgia" Visible="False">I.V.A.</asp:label>
                                                <asp:label id="Label64" Font-Size="10pt" runat="server" 
                            Font-Names="Georgia" Visible="False">I.S.R.</asp:label>
                                            </td>
                    <td class="style18">
                        <asp:TextBox ID="TextBox8" runat="server" Font-Names="Georgia" Font-Size="10pt" 
                            Width="29px" Visible="False"></asp:TextBox>
                        <asp:TextBox ID="TextBox7" runat="server" Font-Names="Georgia" Font-Size="10pt" 
                            Width="31px" Visible="False"></asp:TextBox>
                        <asp:TextBox ID="TextBox9" runat="server" Font-Names="Georgia" Font-Size="10pt" 
                            Width="28px" Visible="False"></asp:TextBox>
                                        <asp:rangevalidator id="RangeValidator4" runat="server" 
                            Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
								ControlToValidate="TextBox9" MaximumValue="100" MinimumValue="0" Type="Integer">Valor Invalido</asp:rangevalidator>
                                        <asp:rangevalidator id="RangeValidator2" runat="server" 
                            Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
								ControlToValidate="TextBox7" MaximumValue="100" MinimumValue="0" Type="Integer">Valor Invalido</asp:rangevalidator>
                    </td>
                    <td>
                                        <asp:rangevalidator id="RangeValidator3" runat="server" 
                            Font-Names="Verdana" Font-Size="8pt" ErrorMessage="RangeValidator"
								ControlToValidate="TextBox8" MaximumValue="100" MinimumValue="0" Type="Integer">Valor Invalido</asp:rangevalidator>
                    </td>
                </tr>
                </table>
        </td>
    </tr>
    <tr>
        <td align="center" class="style9">
            <asp:DataGrid ID="Datagrid1" runat="server" AllowSorting="True" 
                AutoGenerateColumns="False" BackColor="White" BorderColor="#006699" 
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="16px" 
                Width="618px" AllowPaging="True">
                <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <AlternatingItemStyle BackColor="#FFFF66" />
                <ItemStyle ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <Columns>
                    <asp:ButtonColumn CommandName="Select" Text="Seleccionar"></asp:ButtonColumn>
                    <asp:TemplateColumn HeaderText="Codigo">
                        <EditItemTemplate>
                            <asp:TextBox runat="server" 
                                Text='<%# DataBinder.Eval(Container, "DataItem.cCodEmp") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" 
                                NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.ccodemp", URLCodigo) %>' 
                                Target="_self" Text='<%# DataBinder.Eval(Container, "DataItem.ccodemp") %>'>
								</asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="cdescri" HeaderText="Razón Social" 
                        SortExpression="cdescri">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                            HorizontalAlign="Center" VerticalAlign="Top" Font-Size="Small" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="nPorIVA" HeaderText="I.V.A." 
                        SortExpression="nPorIVA">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                            HorizontalAlign="Center" VerticalAlign="Top" Font-Size="Small" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="nPorISRS" HeaderText="I.S.R." 
                        SortExpression="nPorISRS">
                        <HeaderStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                            HorizontalAlign="Center" VerticalAlign="Top" Font-Size="Small" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="dfecReg" HeaderText="Fecha" 
                        SortExpression="dfecReg" DataFormatString="{0:dd-MM-yyyy}">
                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                            Font-Overline="False" Font-Size="Small" Font-Strikeout="False" 
                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                    </asp:BoundColumn>
                </Columns>
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" 
                    Mode="NumericPages" />
            </asp:DataGrid>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Height="16px" Visible="False" 
                Width="78px"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" Height="16px" Visible="False" 
                Width="78px"></asp:TextBox>
            <asp:TextBox ID="flag" runat="server" Visible="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style6">
                <tr>
                    <td align="center" class="style7">
                        <asp:Button ID="Button1" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Nuevo" Width="80px" />
                    </td>
                    <td align="center" class="style16">
                        <asp:Button ID="Button2" runat="server" Font-Names="Calibri" Font-Size="12pt" 
                            Text="Grabar" Width="80px" />
                        <cc1:ConfirmButtonExtender ID="Button2_ConfirmButtonExtender" runat="server" 
                            ConfirmText="Seguro de Grabar?" Enabled="True" TargetControlID="Button2">
                        </cc1:ConfirmButtonExtender>
                    </td>
                    <td align="center" class="style17">
                        &nbsp;</td>
                    <td align="center">
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
</table>
        </td>
    </tr>
</table>

