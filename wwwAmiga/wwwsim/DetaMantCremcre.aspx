<%@ Reference Control="~/controles/VistaDetalleCremcre.ascx" %>
<%@ Reference Control="~/controles/barraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="barraNavegacion" Src="controles/barraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="VistaDetalleCremcre" Src="controles/VistaDetalleCremcre.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Inherits="DetaMantCremcre" CodeFile="DetaMantCremcre.aspx.vb" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Detalle de Mantenimiento de Cremcre</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<BODY>
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="TableDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD></TD>
						<TD>
							<uc1:barraNavegacion id="BarraNavegacion1" runat="server"></uc1:barraNavegacion></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD align="center"><asp:label id="lblTitulo" runat="server" Font-Size="Medium" ForeColor="Blue" Font-Bold="True">Detalle de Registro</asp:label>
						</TD>
						<TD></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD><IMG style="WIDTH: 17px; HEIGHT: 12px" height="12" src="../Imagenes/spacer.gif" width="17"></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD></TD>
						<TD>
							<uc1:VistaDetalleCremcre id="VistaDetalleCremcre1" runat="server"></uc1:VistaDetalleCremcre>
						</TD>
						<TD></TD>
					</TR>
				</TBODY>
			</TABLE>
		</FORM>
	</BODY>
</HTML>
