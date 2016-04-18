<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ucbenefi.ascx.vb" Inherits="wwwSIM.ucbenefi" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="576" border="0" style="BORDER-RIGHT: highlight thin solid; BORDER-TOP: highlight thin solid; BORDER-LEFT: highlight thin solid; WIDTH: 576px; BORDER-BOTTOM: highlight thin solid; HEIGHT: 456px; BACKGROUND-COLOR: #ffffff">
	<TR>
		<TD align="center" style="HEIGHT: 16px">
			<asp:label id="Label1" runat="server" Width="315px" Font-Bold="True" Font-Names="Verdana" Font-Size="Medium"
				ForeColor="#16387C" Height="15px">ADICION DE BENEFICIARIOS</asp:label></TD>
	</TR>
	<TR>
		<TD align="center" style="HEIGHT: 62px">
			<P align="center"><asp:label id="Label3" runat="server" Font-Names="Verdana" Font-Size="8pt">Certificado</asp:label><asp:textbox id="txtccodcrt" Width="106px" runat="server" BorderStyle="Groove" Font-Names="Verdana"
					Font-Size="8pt"></asp:textbox><asp:textbox id="txtnomcli" Width="260px" runat="server" BorderStyle="Groove" Font-Names="Verdana"
					Font-Size="8pt"></asp:textbox><INPUT id="btnaplicar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_aplicar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
					type="button" name="Button1" runat="server">
				<asp:Label id="Label2" runat="server" Width="196px" BackColor="Transparent" BorderWidth="0px"
					Font-Names="Verdana" Font-Size="8pt" ForeColor="DarkBlue">BENEFICIARIOS</asp:Label></P>
		</TD>
	</TR>
	<TR>
		<TD align="center"><asp:datagrid id="dgClientes" Width="563px" runat="server" BorderStyle="None" BackColor="White"
				DataKeyField="ccodcrt" AutoGenerateColumns="False" BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="3">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
				<ItemStyle ForeColor="#000066"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
				<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
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
					<asp:BoundColumn DataField="dfecnac" SortExpression="dfecnac" HeaderText="Nacimiento">
						<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="nporcen" SortExpression="nporcen" HeaderText="Porcentaje">
						<HeaderStyle Font-Size="8pt" Font-Names="Arial" Font-Bold="True" HorizontalAlign="Center" VerticalAlign="Top"></HeaderStyle>
						<ItemStyle Font-Size="XX-Small" Font-Names="Century Gothic" HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
			</asp:datagrid></TD>
	</TR>
	<TR>
		<TD align="center" style="HEIGHT: 17px">
			<asp:Label id="Label4" runat="server" Width="196px" BackColor="Transparent" BorderWidth="0px"
				Font-Names="Verdana" Font-Size="8pt" ForeColor="DarkBlue">ADICION DE BENEFICIARIOS</asp:Label></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
	<TR>
		<TD style="HEIGHT: 94px">
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="568" border="0" style="WIDTH: 568px; HEIGHT: 79px"
				align="center">
				<TR>
					<TD style="WIDTH: 86px; HEIGHT: 17px" align="right"><asp:label id="Label5" runat="server" Font-Names="Verdana" Font-Size="8pt">Nombre:</asp:label></TD>
					<TD style="WIDTH: 185px; HEIGHT: 17px"><asp:textbox id="txtbeneficiario" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:textbox></TD>
					<TD style="WIDTH: 78px; HEIGHT: 17px"><asp:label id="Label6" runat="server" Font-Names="Verdana" Font-Size="8pt">Parentesco:</asp:label></TD>
					<TD style="HEIGHT: 17px"><asp:dropdownlist id="ddlparentesco" Width="168px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:dropdownlist></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 86px; HEIGHT: 19px" align="right"><asp:label id="Label7" runat="server" Font-Names="Verdana" Font-Size="8pt">Nacimiento:</asp:label></TD>
					<TD style="WIDTH: 185px; HEIGHT: 19px"><asp:textbox id="txtfecnac" Width="80px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:textbox>
						<asp:RangeValidator id="RangeValidator5" Font-Size="8pt" Font-Names="Verdana" Width="88px" runat="server"
							ControlToValidate="txtfecnac" ErrorMessage="RangeValidator" Type="Date" MinimumValue="01/01/2000"
							MaximumValue="01/01/3000">Fecha Inválida-</asp:RangeValidator></TD>
					<TD style="WIDTH: 78px; HEIGHT: 19px"><asp:label id="Label8" runat="server" Font-Names="Verdana" Font-Size="8pt">Dirección:</asp:label></TD>
					<TD style="HEIGHT: 19px"><asp:textbox id="txtdirben" Width="232px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:textbox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 86px; HEIGHT: 24px" align="right"><asp:label id="Label9" runat="server" Font-Names="Verdana" Font-Size="8pt">Porcentaje:</asp:label></TD>
					<TD style="WIDTH: 185px; HEIGHT: 24px"><asp:textbox id="txtporcen" Width="55px" runat="server" Font-Names="Verdana" Font-Size="8pt"></asp:textbox><asp:label id="Label10" runat="server" Font-Size="8pt" Font-Names="Verdana">%</asp:label>
						<asp:RangeValidator id="RangeValidator6" Height="12px" Font-Size="8pt" Font-Names="Verdana" Width="86px"
							runat="server" ControlToValidate="txtporcen" ErrorMessage="RangeValidator" Type="Double" MinimumValue="0"
							MaximumValue="100">Valor Inválido-</asp:RangeValidator></TD>
					<TD style="WIDTH: 78px; HEIGHT: 24px"><asp:label id="Label11" runat="server" Font-Names="Verdana" Font-Size="8pt">Correlativo:</asp:label></TD>
					<TD style="HEIGHT: 24px"><asp:textbox id="txtcorrela" Width="55px" runat="server" Enabled="False" Font-Names="Verdana"
							Font-Size="8pt"></asp:textbox></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
	<TR>
		<TD align="center" style="HEIGHT: 27px"><INPUT id="btnadicionar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_insertar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
			&nbsp;&nbsp;<INPUT id="btncancela" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_rechazar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server">&nbsp;&nbsp;&nbsp; 
			&nbsp;&nbsp;&nbsp;<INPUT id="btncancelar" style="BACKGROUND-POSITION: center center; BACKGROUND-IMAGE: url(Web/jpgs/btn_iniciar_b.jpg); WIDTH: 64px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 56px; BACKGROUND-COLOR: transparent"
				type="button" name="Button1" runat="server"></TD>
	</TR>
	<TR>
		<TD></TD>
	</TR>
</TABLE>
