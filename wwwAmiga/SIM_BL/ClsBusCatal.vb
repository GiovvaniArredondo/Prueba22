Public Class ClsBusCatal


#Region " Variables "
    Private llBandera As Boolean
    Private cValor As String
    Private ds As New DataSet
#End Region

#Region " Propiedades"
    Public Property _llBandera() As Boolean
        Get
            Return llBandera
        End Get
        Set(ByVal Value As Boolean)
            llBandera = Value
        End Set
    End Property


    Public Property _cValor() As String
        Get
            Return cValor
        End Get
        Set(ByVal Value As String)
            cValor = Value
        End Set
    End Property


#End Region

#Region " Metodos "

    Public Function BuscaCatalogo() As DataSet

        Dim entidadCtbmcta As New SIM.EL.ctbmcta
        Dim eCtbmcta As New SIM.BL.cCtbmcta

        If Me.llBandera Then
            ds = eCtbmcta.ObtenerDataSetEsp(Me.cValor)  'Descripcion 
        Else
            ds = eCtbmcta.ObtenerDataSetEsp1(Me.cValor) 'Cuenta
        End If

        Return ds

    End Function

    Public Function Catalogo(ByVal cCodigo As String) As DataSet

        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerDataSetEsp2(cCodigo)

        Return ds

    End Function

    'Public Function BuscaPartidaNo(ByVal ccodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String, ByVal cpoliza As String) As DataSet

    '    Dim eCtbmcta As New SIM.BL.cCtbmcta

    '    ds = eCtbmcta.ObtenerDataSetEsp3(ccodigo, cfondo, ccadena, ccodofi, cpoliza)

    '    Return ds

    'End Function
    Public Function BuscaPartidaNo(ByVal ccodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String) As DataSet

        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerDataSetEsp3(ccodigo, cfondo, ccadena, ccodofi)

        Return ds

    End Function
    'Public Function BuscaPartidaDes(ByVal ccodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String, ByVal cpoliza As String) As DataSet

    '    Dim eCtbmcta As New SIM.BL.cCtbmcta

    '    ds = eCtbmcta.ObtenerDataSetEsp4(ccodigo, cfondo, ccadena, ccodofi, cpoliza)

    '    Return ds

    'End Function
    Public Function BuscaPartidaDes(ByVal ccodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String) As DataSet

        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerDataSetEsp4(ccodigo, cfondo, ccadena, ccodofi)

        Return ds

    End Function
    'Public Function BuscaPartidaFechas(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String, ByVal cpoliza As String) As DataSet

    '    Dim eCtbmcta As New SIM.BL.cCtbmcta

    '    ds = eCtbmcta.ObtenerDataSetEsp4a(dfecini, dfecfin, cfondo, ccadena, ccodofi, cpoliza)

    '    Return ds

    'End Function
    Public Function BuscaPartidaFechas(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String) As DataSet

        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerDataSetEsp4a(dfecini, dfecfin, cfondo, ccadena, ccodofi)

        Return ds

    End Function
    Public Function ObtenerBusquedaCheque(ByVal cfondo As String, ByVal ccadena As String, ByVal cbanco As String, ByVal cnrochq As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal opcion As Integer, ByVal ccodigo As String) As DataSet
        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerBusquedaCheque(cfondo, ccadena, cbanco, cnrochq, dfecini, dfecfin, opcion, ccodigo)

        Return ds
    End Function

    Public Function ObtenerBusquedaPartidaBancaria(ByVal cfondo As String, ByVal ccadena As String, ByVal cbanco As String, ByVal cnrochq As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal opcion As Integer, ByVal ccodigo As String) As DataSet
        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerBusquedaPartidaBancaria(cfondo, ccadena, cbanco, cnrochq, dfecini, dfecfin, opcion, ccodigo)

        Return ds
    End Function

#End Region

End Class
