<%@ Page Language="vb" AutoEventWireup="false" Inherits="wfLogin2" CodeFile="wfLogin2.aspx.vb" %>
<%@ Register TagPrefix="uc1" TagName="CUWHeader" Src="controles/CUWHeader.ascx" %>
<%@ Register TagPrefix="uc1" TagName="cuwIntro1" Src="controles/cuwIntro1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Reclave" Src="controles/Reclave.ascx" %>
<%@ Register TagPrefix="uc1" TagName="entrada" Src="controles/entrada.ascx" %>
<%@ Register src="controles/Login2.ascx" tagname="Login2" tagprefix="uc2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>wfLogin</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	    <style type="text/css">
            .style7
            {
                width: 730px;
            }
            </style>
	</HEAD>
	<body bgColor="#ffffff" background="imagenes/fondo.jpg">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="border: thin solid highlight; Z-INDEX: 102; LEFT: 104px; WIDTH: 774px; POSITION: absolute; TOP: 24px; HEIGHT: 38px"
				cellSpacing="0" cellPadding="0" border="0">
				<TR>
					<TD style="BACKGROUND-COLOR: #ffff99" align="left" class="style7">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 153px; BACKGROUND-COLOR: #ffffff">
									<uc1:cuwIntro1 id="CuwIntro11" runat="server"></uc1:cuwIntro1></TD>
								<TD style="BACKGROUND-COLOR: #ffffff">
									<uc1:CUWHeader id="CUWHeader1" runat="server"></uc1:CUWHeader></TD>
							</TR>
						</TABLE>
						</TD>
				</TR>
				<TR>
					<TD style="BACKGROUND-COLOR: infobackground" align="center" class="style7">
                        <uc2:Login2 ID="Login21" runat="server" />
                    </TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
