<%@ Page Language="vb" AutoEventWireup="false" Inherits="wfLogin" CodeFile="wfLogin.aspx.vb" %>
<%@ Register TagPrefix="uc1" TagName="CUWHeader" Src="controles/CUWHeader.ascx" %>
<%@ Register TagPrefix="uc1" TagName="cuwIntro1" Src="controles/cuwIntro1.ascx" %>
<%@ Register TagPrefix="uc1" TagName="Login" Src="controles/Login.ascx" %>
<%@ Register TagPrefix="uc1" TagName="entrada" Src="controles/entrada.ascx" %>
<%@ Register src="controles/Login2.ascx" tagname="Login2" tagprefix="uc2" %>
<%@ Register src="controles/cuwClave.ascx" tagname="cuwClave" tagprefix="uc3" %>
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
            .style24
            {
                width: 154%;
               
            }
            .style25
            {
                width: 100%;
            }
            .ToUpper
            {
            text-transform: uppercase;
            }
    .style3
    {
        width: 94%;
        height: 3px;
    }
    .style15
    {
        width: 485px;
        height: 4px;
    }
    .style9
    {
        width: 100%;
        height: 4px;
    }
    .style10
    {
        width: 65%;
        height: 25px;
    }
    .style16
    {
        height: 25px;
    }
    .style12
    {
        width: 65%;
        height: 27px;
    }
    .style13
    {
        height: 27px;
    }
    .style21
    {
        width: 89%;
        height: 95px;
    }
    .style22
    {
        width: 258px;
    }
    
        </style>
	</HEAD>
	<body bgColor="#ffffff">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="border: thin solid highlight; Z-INDEX: 102; LEFT: 104px; WIDTH: 749px; POSITION: absolute; TOP: 24px; HEIGHT: 38px"
				cellSpacing="5" cellPadding="5" border="0">
				<TR>
					<TD style="BACKGROUND-COLOR: White" align="left" class="style7">
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0" >
							<TR>
								
								<TD style="BACKGROUND-COLOR: #ffffff">
									<uc1:CUWHeader id="CUWHeader1" runat="server"></uc1:CUWHeader></TD>
							</TR>
							
						</TABLE >
                        <asp:TextBox ID="TextBox1" runat="server" BackColor="White" BorderColor="White" 
                            BorderStyle="None" Enabled="False" ForeColor="White" Height="9px" Width="692px"></asp:TextBox>
						
						<table cellpadding="0" cellspacing="0" class="style24" >
                            <tr>
                                <td class="style25">
                <uc1:Login id="Login1" runat="server"></uc1:Login>
                                </td>
                            </tr>
                            <tr>
                                <td class="style25">
                                    <uc3:cuwClave ID="cuwClave1" runat="server" />
                                </td>
                            </tr>
                        </table>
                    </TD>
				</TR>
				<TR>
					<TD style="BACKGROUND-COLOR: infobackground" align="center" class="style7"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
