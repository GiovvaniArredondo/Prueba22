<%@ Control Language="vb" AutoEventWireup="false" Inherits="ucbenaho" CodeFile="ucbenaho.ascx.vb" %>
<style type="text/css">
    .style1
    {
        width: 72%;
    }
    .style2
    {
        width: 132px;
    }
    .style3
    {
        width: 132px;
        height: 31px;
    }
    .style4
    {
        height: 31px;
    }
    .style5
    {
        width: 132px;
        height: 28px;
    }
    .style6
    {
        height: 28px;
    }
</style>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="592" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 592px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 440px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD style="HEIGHT: 26px">
			<P align="center">
				<asp:label id="Label13" Width="529px" runat="server" Font-Bold="True" Font-Names="Verdana"
					Font-Size="Medium" ForeColor="#16387C" Height="15px">ADICION DE BENEFICIARIOS CUENTAS DE AHORRO</asp:label></P>
		</TD>
	</TR>
	<TR>
		<TD align="center" style="HEIGHT: 77px">
			<P>
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td align="right" class="style2">
                            <asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt">Cuenta de Ahorros:</asp:label>
                        </td>
                        <td>
                            <asp:textbox id="txtcodaho" runat="server" Width="125px" Font-Names="Verdana" Font-Size="8pt"
					BorderWidth="1px" Enabled="False" style="margin-left: 0px"></asp:textbox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style5">
                            <asp:label id="Label14" runat="server" Font-Names="Verdana" Font-Size="8pt">Codigo de Cliente:</asp:label>
                        </td>
                        <td class="style6">
                            <asp:textbox id="txtcodcli" runat="server" Width="120px" Enabled="False" Font-Names="Verdana"
					Font-Size="8pt" BorderWidth="1px"></asp:textbox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style3">
                            <asp:label id="Label15" runat="server" Font-Names="Verdana" Font-Size="8pt">Nombre:</asp:label>
                        </td>
                        <td class="style4">
                            <asp:textbox id="txtnomcli" runat="server" Width="209px" Font-Names="Verdana" Font-Size="8pt"
					BorderWidth="1px" Enabled="False"></asp:textbox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            <INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 49px; BACKGROUND-COLOR: transparent"
					type="button" name="Button2" runat="server"></td>
                    </tr>
                </table>
            </P>
		</TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 16px" align="center">
			<asp:Label id="Label2" ForeColor="DarkBlue" Font-Size="8pt" Font-Names="Verdana" runat="server"
				Width="289px" BorderWidth="0px" BackColor="Transparent">BENEFICIARIOS</asp:Label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 146px" align="center">
			<asp:datagrid id="dgClientes" Height="24px" runat="server" Width="530px" 
                BorderWidth="1px" BorderStyle="None"
				BackColor="#DEBA84" DataKeyField="ccodaho" AutoGenerateColumns="False" BorderColor="#DEBA84"
				CellPadding="3" CellSpacing="2" Font-Names="Verdana" Font-Size="10pt">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
				<ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
				<FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
				<Columns>
					<asp:ButtonColumn Text="Seleccionar" CommandName="Select">
						<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="X-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
					</asp:ButtonColumn>
					<asp:BoundColumn DataField="ncorrel" SortExpression="ncorrel" HeaderText="Correlativo">
						<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="cnomben" SortExpression="cnomben" HeaderText="Nombre">
						<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="cdirben" SortExpression="cdirben" HeaderText="Direcci&#243;n">
						<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="dfecnac" SortExpression="dfecnac" 
                        HeaderText="Nacimiento" DataFormatString="{0:dd-MM-yyyy}">
						<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="nporcen" SortExpression="nporcen" HeaderText="Porcentaje">
						<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
			</asp:datagrid></TD>
	</TR>
	<TR>
		<TD align="center">
			<asp:Label id="Label1" ForeColor="DarkBlue" Font-Size="8pt" Font-Names="Verdana" runat="server"
				Width="253px" BorderWidth="0px" BackColor="Transparent">ADICION BENEFICIARIOS</asp:Label></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 63px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TR>
					<TD style="WIDTH: 102px; HEIGHT: 24px" align="right">
						<asp:label id="Label5" Font-Size="8pt" Font-Names="Verdana" runat="server">Nombre:</asp:label></TD>
					<TD style="WIDTH: 172px; HEIGHT: 24px">
						<asp:textbox id="txtbeneficiario" Font-Size="8pt" Font-Names="Verdana" runat="server" Width="112px"
							BorderWidth="1px"></asp:textbox></TD>
					<TD style="WIDTH: 95px; HEIGHT: 24px"><asp:label id="Label6" runat="server" Font-Names="Verdana" Font-Size="8pt">Parentesco:</asp:label></TD>
					<TD style="HEIGHT: 24px"><asp:dropdownlist id="ddlparentesco" runat="server" Width="184px" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 102px; HEIGHT: 19px" align="right"><asp:label id="Label7" runat="server" Font-Names="Verdana" Font-Size="8pt">Nacimiento:</asp:label></TD>
					<TD style="WIDTH: 172px; HEIGHT: 19px"><asp:textbox id="txtfecnac" runat="server" Width="80px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px"></asp:textbox>
						<asp:RangeValidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" 
                            runat="server" Width="88px"
							MaximumValue="01/01/3000" MinimumValue="01/01/1901" Type="Date" ErrorMessage="RangeValidator" 
                            ControlToValidate="txtfecnac">Fecha Inválida-</asp:RangeValidator></TD>
					<TD style="WIDTH: 95px; HEIGHT: 19px"><asp:label id="Label8" runat="server" Font-Names="Verdana" Font-Size="8pt">Dirección:</asp:label></TD>
					<TD style="HEIGHT: 19px"><asp:textbox id="txtdirben" runat="server" Width="187px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 102px; HEIGHT: 24px" align="right"><asp:label id="Label9" runat="server" Font-Names="Verdana" Font-Size="8pt">Porcentaje:</asp:label></TD>
					<TD style="WIDTH: 172px; HEIGHT: 24px"><asp:textbox id="txtporcen" runat="server" Width="55px" Font-Names="Verdana" Font-Size="8pt"
							BorderWidth="1px"></asp:textbox><asp:label id="Label10" runat="server" Font-Size="8pt" Font-Names="Verdana">%</asp:label>
						<asp:RangeValidator id="RangeValidator6" Height="12px" Font-Size="8pt" Font-Names="Verdana" runat="server"
							Width="86px" MaximumValue="100" MinimumValue="0" Type="Double" ErrorMessage="RangeValidator" ControlToValidate="txtporcen">Valor Inválido-</asp:RangeValidator></TD>
					<TD style="WIDTH: 95px; HEIGHT: 24px"><asp:label id="Label11" runat="server" Font-Names="Verdana" Font-Size="8pt">Correlativo:</asp:label></TD>
					<TD style="HEIGHT: 24px"><asp:textbox id="txtcorrela" runat="server" Width="80px" Enabled="False" Font-Names="Verdana"
							Font-Size="8pt" BorderWidth="1px"></asp:textbox>
						<asp:RangeValidator id="RangeValidator1" Height="8px" Font-Size="8pt" 
                            Font-Names="Verdana" runat="server"
							Width="86px" MaximumValue="240" MinimumValue="0" Type="Integer" ErrorMessage="RangeValidator" 
                            ControlToValidate="txtcorrela">Valor Inválido-</asp:RangeValidator></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center"><INPUT id="btnadicionar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp; 
			&nbsp;&nbsp;<INPUT id="btncancelar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<INPUT id="btncancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 59px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 54px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server"></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
