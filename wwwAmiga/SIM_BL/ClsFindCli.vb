Public Class ClsFindCli

    Public Function BuscaCliente(ByVal cCodigo As String, ByVal nNivel As Integer, ByVal cOficina As String) As DataSet
        Dim ds As New DataSet
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide
        'Dim ccodcli As String = ""

        'Valida si el filtrado fue sin parametro de entrada
        'If cCodigo = "" Then

        ds = eClimide.ObtenerDataSetNivel(cCodigo, nNivel, cOficina)
        'Else 'Si tiene dato de entrada entonces hace :
        '    'Nueva validacion busqueda de credito ** Fernando Abreg **
        '    ccodcli = eClimide.Busca_codigo_Clie(cCodigo)
        '    'ds = eClimide.ObtenerDataSetEsp(cCodigo)
        '    ds = eClimide.ObtenerDataSetNivel(ccodcli, nNivel, cOficina)

        'End If

        Return ds

    End Function

    Public Function BuscaCreditoActivo(ByVal ccodigo As String, ByVal nnivel As Integer, ByVal coficina As String) As DataSet
        Dim ds As New DataSet
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        ds = eClimide.ObtenerDataSetEsp1(ccodigo, nnivel, coficina)

        Return ds
    End Function

    Public Function BuscaClienteGru(ByVal cCodigo As String, ByVal ccodcen As String, ByVal ctipmet As String, ByVal cCodofi As String) As DataSet
        Dim ds As New DataSet
        Dim entidadCremsol As New SIM.EL.cremsol
        Dim eCremsol As New SIM.BL.cCremsol

        ds = eCremsol.ObtenerDataSetNivelGru(cCodigo, ccodcen, ctipmet, cCodofi)
        Return ds

    End Function
    Public Function BuscaCentros(ByVal cCodigo As String) As DataSet
        Dim ds As New DataSet
        Dim entidadCentros As New SIM.EL.centros
        Dim eCentros As New SIM.BL.ccentros

        ds = eCentros.ObtenerDataSetNivel(cCodigo)
        Return ds

    End Function


    Public Function BuscaClienteTodos(ByVal cCodigo As String, ByVal cCodofi As String) As DataSet
        Dim ds As New DataSet
        Dim entidadCremsol As New SIM.EL.cremsol
        Dim eCremsol As New SIM.BL.cCremsol

        ds = eCremsol.ObtenerDataSetNivelTodos(cCodigo, cCodofi)
        Return ds

    End Function

End Class
