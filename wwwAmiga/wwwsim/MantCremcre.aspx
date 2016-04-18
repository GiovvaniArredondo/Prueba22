<%@ Reference Control="~/controles/barraNavegacion.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Inherits="MantCremcre" CodeFile="MantCremcre.aspx.vb" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<%@ Register TagPrefix="uc1" TagName="barraNavegacion" Src="controles/barraNavegacion.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Mantenimiento de Cremcre</title>
		<META http-equiv="Content-Type" content="text/html; charset=windows-1252">
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<BODY>
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="TableLista" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD></TD>
						<TD>
							<uc1:barraNavegacion id="BarraNavegacion1" runat="server"></uc1:barraNavegacion></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD align="center"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server" Font-Bold="True" ForeColor="Blue"
								Font-Size="Medium">Catálogo de Cremcre</asp:Label></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD><IMG style="WIDTH: 17px; HEIGHT: 12px" height="12" src="../Imagenes/spacer.gif" width="17"></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD align="center">
							<asp:DataGrid id="dgLista" runat="server" BorderColor="White" BorderStyle="Ridge" CellSpacing="1"
								BorderWidth="2px" BackColor="White" CellPadding="3" GridLines="None" AutoGenerateColumns="False"
								AllowSorting="True">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
								<ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
								<FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
								<Columns>
									<asp:HyperLinkColumn Target="_self" DataNavigateUrlField="ccodcta" DataNavigateUrlFormatString="DetaMantCremcre.aspx?id={0}"
										DataTextField="ccodcta" SortExpression="cCodofi" HeaderText="Codigo"></asp:HyperLinkColumn>
									<asp:BoundColumn DataField="ccodprd" SortExpression="ccodprd" HeaderText="ccodprd"></asp:BoundColumn>
									<asp:TemplateColumn>
										<ItemTemplate>
											<asp:LinkButton id=LinkButton1 runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ccodcta") %>'>
												<img src='Imagenes/Eliminar.gif' alt='Eliminar el Registro' border='0' width="32" height="32" /></asp:LinkButton>
										</ItemTemplate>
									</asp:TemplateColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6"></PagerStyle>
							</asp:DataGrid></TD>
						<TD></TD>
					</TR>
				</TBODY>
			</TABLE>
		</FORM>
	</BODY>
</HTML>
