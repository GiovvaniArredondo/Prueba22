<%@ Control Language="vb" AutoEventWireup="false" Codefile="WbEncuestap.ascx.vb" Inherits="WbEncuestap" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<script runat="server">

</script>

<script language="javascript" type="text/javascript">
// <!CDATA[



// ]]>
</script>





<style type="text/css">

    .style8
    {
        width: 70%;
    }
    .style9
    {
        width: 619px;
    }
    .style10
    {
        width: 100%;
        height: 22px;
    }
    .style11
    {
        width: 146px;
    }
    </style>



<table cellpadding="0" cellspacing="0" class="style8" 
    
    
    style="border: thin solid highlight; WIDTH: 642px; HEIGHT: 391px; BACKGROUND-COLOR: #ffffff">
    <tr>
        <td align="center" class="style9" 
            style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'">
                        ENCUESTA PPI</td>
    </tr>
    <tr>
        <td align="center" class="style9" 
            style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; COLOR: #16387c; FONT-STYLE: normal; FONT-FAMILY: 'Verdana'">
                        <table align="center" cellpadding="0" cellspacing="0" class="style10">
                            <tr>
                                <td align="right" class="style11">
				<asp:label id="lblMostrar" Font-Size="X-Small" Width="98px" 
                Font-Names="Verdana" runat="server"
					ForeColor="#16387C" Height="16px">Codigo:</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtcodcli" runat="server" Enabled="False" Font-Names="Verdana" 
                                        ForeColor="#16387C" Width="103px"></asp:TextBox>
                                </td>
                                <td align="right">
				<asp:label id="lblMostrar0" Font-Size="X-Small" Width="98px" 
                Font-Names="Verdana" runat="server"
					ForeColor="#16387C" Height="16px">Nombre:</asp:label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtcnomcli" runat="server" Enabled="False" 
                                        Font-Names="Verdana" ForeColor="#16387C" Width="317px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
        </td>
    </tr>
    <tr>
        <td class="style9" align="center">
			<asp:datagrid id="Datagrid1" AllowSorting="True" 
                AutoGenerateColumns="False" CellPadding="3"
								BorderWidth="1px" BorderStyle="None" BorderColor="#006699" BackColor="White" 
                Height="16px" Width="618px"
								runat="server">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
								<AlternatingItemStyle BackColor="#FFFF66" />
								<ItemStyle ForeColor="#000066"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
								<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
								<Columns>
									<asp:BoundColumn DataField="ccodpreg" 
                                        SortExpression="ccodpreg">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
								    <asp:BoundColumn DataField="cpregunta" HeaderText="Indicador" 
                                        SortExpression="cpregunta">
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Top" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="calibri" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:BoundColumn>
								    <asp:TemplateColumn HeaderText="Respuestas Posibles">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="DropDownList1" runat="server" Font-Names="Verdana" 
                                                Font-Size="8pt" Height="44px" Width="208px">
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Size="X-Small" Font-Strikeout="False" 
                                            Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Names="Calibri" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                                            HorizontalAlign="Center" VerticalAlign="Top" />
                                    </asp:TemplateColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
							</asp:datagrid>
                                </td>
    </tr>
    <tr>
        <td class="style9" align="center">
			<asp:Button ID="btngrabar" runat="server" Font-Names="Verdana" Text="Grabar" 
                Width="102px" style="height: 26px" />
                                <cc1:ConfirmButtonExtender ID="btngrabar_ConfirmButtonExtender" runat="server" 
                ConfirmText="Seguro de Respuestas?" Enabled="True" TargetControlID="btngrabar">
            </cc1:ConfirmButtonExtender>
                                </td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
    </tr>
</table>

<P>&nbsp;</P>
