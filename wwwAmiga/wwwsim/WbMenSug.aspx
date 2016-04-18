<%@ Reference Control="~/controles/WUCGarantias.ascx" %>
<%@ Reference Control="~/controles/CUWSugInd.ascx" %>
<%@ Reference Control="~/controles/WUCFindCre.ascx" %>
<%@ Page Language="vb" AutoEventWireup="false" Inherits="WbMenSug2" CodeFile="WbMenSug.aspx.vb" %>
<%@ Register TagPrefix="uc1" TagName="WUCGetLin" Src="controles/WUCGetLin.ascx" %>
<%@ Register TagPrefix="uc1" TagName="WUCGarantias" Src="controles/WUCGarantias.ascx" %>
<%@ Register TagPrefix="uc1" TagName="CUWSugInd" Src="controles/CUWSugInd.ascx" %>
<%@ Register TagPrefix="uc1" TagName="WUCFindCre" Src="controles/WUCFindCre.ascx" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WbMenSug</title>
		<meta content="False" name="vs_snapToGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; WIDTH: 100%" cellSpacing="1" cellPadding="1" width="878"
				border="1">
				<TR>
					<TD style="WIDTH: 34px; HEIGHT: 14px"></TD>
					<TD style="HEIGHT: 14px" bgColor="#6699ff"><iewc:tabstrip id="TabStrip1" runat="server" AutoPostBack="True" TabDefaultStyle="background-color:#000000;font-family:verdana;font-weight:bold;font-size:8pt;color:#ffffff;width:79;height:21;text-align:center;"
							TabHoverStyle="background-color:#777777;" TabSelectedStyle="background-color:#ffffff;color:#000000;" Font-Names="Century Gothic" Font-Size="Larger">
							<iewc:Tab Text="Busqueda"></iewc:Tab>
							<iewc:Tab Text="Sugerencia"></iewc:Tab>
							<iewc:Tab Text="Garantias"></iewc:Tab>
						</iewc:tabstrip></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 34px"></TD>
					<TD bgColor="#0099ff"><uc1:wucgarantias id="WUCGarantias1" runat="server"></uc1:wucgarantias><uc1:cuwsugind id="CUWSugInd1" runat="server"></uc1:cuwsugind><uc1:wucfindcre id="WUCFindCre1" runat="server"></uc1:wucfindcre></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 34px"></TD>
					<TD></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
