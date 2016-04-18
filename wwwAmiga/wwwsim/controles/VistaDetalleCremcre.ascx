<%@ Control Language="vb" AutoEventWireup="false" Inherits="VistaDetalleCremcre" CodeFile="VistaDetalleCremcre.ascx.vb" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodcta" runat="server">ccodcta:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccodcta" runat="server" BackColor="Linen" ReadOnly="True" Width="70px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcCodofi" runat="server">cCodofi:</asp:Label></TD>
		<TD></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodprd" runat="server">ccodprd:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccodprd" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcmoneda" runat="server">cmoneda:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcmoneda" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcestado" runat="server">cestado:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcestado" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodcli" runat="server">ccodcli:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccodcli" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccatego" runat="server">ccatego:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccatego" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodfue" runat="server">ccodfue:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccodfue" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodact" runat="server">ccodact:</asp:Label></TD>
		<TD></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblctipcre" runat="server">ctipcre:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtctipcre" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcdescre" runat="server">cdescre:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcdescre" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblctipcuo" runat="server">ctipcuo:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtctipcuo" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblctipper" runat="server">ctipper:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtctipper" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblntipperc" runat="server">ntipperc:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtntipperc" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcctapre" runat="server">cctapre:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcctapre" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcnorref" runat="server">cnorref:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcnorref" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodana" runat="server">ccodana:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccodana" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldfecasi" runat="server">dfecasi:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdfecasi" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldfecasiFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdfecasi" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dfecasi tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdfecasi" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldfecsol" runat="server">dfecsol:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdfecsol" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldfecsolFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdfecsol" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dfecsol tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdfecsol" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnmonsol" runat="server">nmonsol:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnmonsol" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnmonsug" runat="server">nmonsug:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnmonsug" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblncuosug" runat="server">ncuosug:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtncuosug" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblndessug" runat="server">ndessug:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtndessug" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblndiasug" runat="server">ndiasug:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtndiasug" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblndiagra" runat="server">ndiagra:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtndiagra" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldfecapr" runat="server">dfecapr:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdfecapr" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldfecaprFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdfecapr" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dfecapr tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdfecapr" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldfecven" runat="server">dfecven:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdfecven" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldfecvenFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdfecven" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dfecven tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdfecven" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnmonapr" runat="server">nmonapr:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnmonapr" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnmoncuo" runat="server">nmoncuo:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnmoncuo" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnintapr" runat="server">nintapr:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnintapr" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblncuoapr" runat="server">ncuoapr:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtncuoapr" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblndiaapr" runat="server">ndiaapr:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtndiaapr" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblndesapr" runat="server">ndesapr:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtndesapr" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcnrolin" runat="server">cnrolin:</asp:Label></TD>
		<TD></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblntasint" runat="server">ntasint:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtntasint" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblctipcon" runat="server">ctipcon:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtctipcon" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodapo" runat="server">ccodapo:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccodapo" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldfecvig" runat="server">dfecvig:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdfecvig" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldfecvigFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdfecvig" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dfecvig tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdfecvig" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblndeseje" runat="server">ndeseje:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtndeseje" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblngastos" runat="server">ngastos:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtngastos" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblncappag" runat="server">ncappag:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtncappag" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnintpen" runat="server">nintpen:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnintpen" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnintcal" runat="server">nintcal:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnintcal" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnintpag" runat="server">nintpag:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnintpag" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnintmor" runat="server">nintmor:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnintmor" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnmorpag" runat="server">nmorpag:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnmorpag" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnpagcta" runat="server">npagcta:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnpagcta" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblncapdes" runat="server">ncapdes:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtncapdes" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblncapcal" runat="server">ncapcal:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtncapcal" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblngaspag" runat="server">ngaspag:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtngaspag" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblndiaatr" runat="server">ndiaatr:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtndiaatr" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblndiaant" runat="server">ndiaant:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtndiaant" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnatracu" runat="server">natracu:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnatracu" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnatrmax" runat="server">natrmax:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnatrmax" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccondic" runat="server">ccondic:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccondic" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldultpag" runat="server">dultpag:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdultpag" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldultpagFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdultpag" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dultpag tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdultpag" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldfecter" runat="server">dfecter:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdfecter" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldfecterFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdfecter" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dfecter tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdfecter" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodrec" runat="server">ccodrec:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccodrec" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnnota1" runat="server">nnota1:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnnota1" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnnota2" runat="server">nnota2:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnnota2" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcmarjud" runat="server">cmarjud:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcmarjud" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblntipcam" runat="server">ntipcam:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtntipcam" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbllctaret" runat="server">lctaret:</asp:Label></TD>
		<TD>
			<asp:CheckBox id="cbxlctaret" runat="server"></asp:CheckBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcclacre" runat="server">cclacre:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcclacre" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccalif" runat="server">ccalif:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccalif" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnsegvid" runat="server">nsegvid:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnsegvid" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcnumexp" runat="server">cnumexp:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcnumexp" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodrub" runat="server">ccodrub:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccodrub" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcregist" runat="server">cregist:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcregist" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldfecadm" runat="server">dfecadm:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdfecadm" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldfecadmFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdfecadm" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dfecadm tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdfecadm" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnintadm" runat="server">nintadm:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnintadm" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnmeses" runat="server">nmeses:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnmeses" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcsececo" runat="server">csececo:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcsececo" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnciclo" runat="server">nciclo:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnciclo" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodsol" runat="server">ccodsol:</asp:Label></TD>
		<TD></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnmorak" runat="server">nmorak:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnmorak" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnahoprg" runat="server">nahoprg:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnahoprg" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcliquid" runat="server">cliquid:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcliquid" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblclineac" runat="server">clineac:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtclineac" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblncapoto" runat="server">ncapoto:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtncapoto" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccontra" runat="server">ccontra:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccontra" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldfectra" runat="server">dfectra:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdfectra" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldfectraFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdfectra" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dfectra tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdfectra" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblccodusu" runat="server">ccodusu:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtccodusu" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lbldfecmod" runat="server">dfecmod:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtdfecmod" runat="server" Width="100px"></asp:TextBox>
			<asp:Label id="lbldfecmodFormato" runat="server">(dd/mm/yyyy)</asp:Label>
			<asp:RegularExpressionValidator id="revdfecmod" runat="server" ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((1[6-9]|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((1[6-9]|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$"
				ErrorMessage="dfecmod tiene que ser ingresada en formato dd/mm/yyyy" ControlToValidate="txtdfecmod" Display="Dynamic"></asp:RegularExpressionValidator></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcflag" runat="server">cflag:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcflag" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblcflat" runat="server">cflat:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtcflat" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblnnumfal" runat="server">nnumfal:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtnnumfal" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label id="lblctipgar" runat="server">ctipgar:</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtctipgar" runat="server" Width="100px"></asp:TextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR>
		<TD width="10"></TD>
		<TD colspan="2" align="center">
			<asp:ValidationSummary id="ValidationSummary1" runat="server" Width="610px" Visible="False" ShowMessageBox="True"
				HeaderText="Favor verifique los datos para poder continuar."></asp:ValidationSummary></TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
