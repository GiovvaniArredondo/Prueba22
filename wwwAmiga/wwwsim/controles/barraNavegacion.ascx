<%@ Control Language="vb" AutoEventWireup="false" Inherits="barraNavegacion" CodeFile="barraNavegacion.ascx.vb" %>
<TABLE id="Table1" cellSpacing="0" cellPadding="0" border="0" width="100%" bgColor="#90bed7">
	<TR>
		<TD style="WIDTH: 274px">
			<asp:ImageButton id="ibtnInicio" runat="server" ImageUrl="../Imagenes/Inicio.gif" ToolTip="Ir al Primer Registro"
				Width="18px" Height="18px"></asp:ImageButton>
			<asp:ImageButton id="ibtnAnterior" runat="server" ImageUrl="../Imagenes/Anterior.gif" ToolTip="Registro Anterior"
				Width="18px" Height="18px"></asp:ImageButton>
			<asp:ImageButton id="ibtnSiguiente" runat="server" ImageUrl="../Imagenes/Siguiente.gif" ToolTip="Siguiente Registro"
				Width="18px" Height="18px"></asp:ImageButton>
			<asp:ImageButton id="ibtnFin" runat="server" ImageUrl="../Imagenes/Fin.gif" ToolTip="Ir al Ultimo Registro"
				Width="18px" Height="18px"></asp:ImageButton>
			<asp:ImageButton id="ibtnAgregar" runat="server" ImageUrl="../Imagenes/Nuevo.gif" ToolTip="Agregar un Registro"
				Width="18px" Height="18px"></asp:ImageButton>
			<asp:ImageButton id="ibtnEditarCancelar" runat="server" ImageUrl="../Imagenes/Editar.gif" ToolTip="Editar/Cancelar el Registro"
				Width="18px" Height="18px" CausesValidation="False"></asp:ImageButton>&nbsp;
			<asp:ImageButton id="ibtnGuardar" runat="server" ImageUrl="../Imagenes/Almacenar.gif" ToolTip="Guardar el Registro"
				Width="18px" Height="18px"></asp:ImageButton>
		</TD>
		<TD align="right" style="WIDTH: 320px"><asp:Label id="lblRegistroActual" runat="server"></asp:Label>&nbsp;
			<asp:Label id="lblDe" runat="server">de</asp:Label>
			<asp:Label id="lblTotalRegistros" runat="server"></asp:Label>&nbsp;
			<asp:Label id="lblRegistros" runat="server">Registros.</asp:Label></TD>
		<TD align="right"></TD>
	</TR>
</TABLE>
