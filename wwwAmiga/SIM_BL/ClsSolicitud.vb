Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings

Public Class ClsSolicitud

#Region " Variables "
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private pcNrolin As String
    Private Transacc As String
    Private ds As New DataSet
    Private clase As New SIM.bl.class1
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private pctipgar As String
    Private cFuente As String
    Private cDestino As String
    Private cSector As String
    Private cPrograma As String
    Private nMonto As String
    Private cAnalista As String
    Private cdFecAsig As String
    Private cOficina As String
    Private cInstitu As String
    Private cCodigo As String
    Private cTipo As String
    Private pcCodAct As String
    Private cCuenta As String

    Private cpnCiclo As String
    Private cpnTipcre As String
    Private cpnTipgar As String
    Private myconnection As New SqlConnection
    Private mycommand As SqlDataAdapter
    Private _cnnStr As New String(AppSettings("cnnString"))
    Private sql As String
    Private sql1 As String
    Private cmd As SqlCommand
    Private myTrans As SqlTransaction

    Private _cCodtmp As String

    '   >>>>> Grupos <<<<<

    Private cnomgru As String

    Private ccodsol As String

    Private cdirdom As String

    Private cdiareu As String

    Private chora As String

    Private ccodofi As String

    Private ccodins As String

    Private cfrecreu As String

    Private lactivo As Boolean

    Private ctipomet As String

    Private ccodzon As String

    Private ccodcen As String

    Private ccargo As String
    '>>>>>>>>>>>>>>>>>>>>>
    Private gcCodUsu As String

    Private lsegvid As Boolean

    Private cprocre As String
    Private pccodsol As String

    Private pccodcli As String
#End Region


#Region " Propiedades "
    Public Property _pccodsol() As String
        Get
            Return pccodsol
        End Get
        Set(ByVal Value As String)
            pccodsol = Value
        End Set
    End Property

    Public Property _pccodcli() As String
        Get
            Return pccodcli
        End Get
        Set(ByVal Value As String)
            pccodcli = Value
        End Set
    End Property
    Public Property _cprocre() As String
        Get
            Return cprocre
        End Get
        Set(ByVal Value As String)
            cprocre = Value
        End Set
    End Property
    Public Property _gcCodusu() As String
        Get
            Return gcCodUsu
        End Get
        Set(ByVal Value As String)
            gcCodUsu = Value
        End Set
    End Property

    Protected Overridable Property cnnStr() As String
        Get
            Return Me._cnnStr
        End Get
        Set(ByVal Value As String)
            Me._cnnStr = Value
        End Set
    End Property

    Public Property Fuente() As String
        Get
            Return cFuente
        End Get
        Set(ByVal Value As String)
            cFuente = Value
        End Set
    End Property

    Public Property Destino() As String
        Get
            Return cDestino
        End Get
        Set(ByVal Value As String)
            cDestino = Value
        End Set
    End Property
    Public Property Sector() As String
        Get
            Return cSector
        End Get
        Set(ByVal Value As String)
            cSector = Value
        End Set
    End Property

    Public Property Programa() As String
        Get
            Return cPrograma
        End Get
        Set(ByVal Value As String)
            cPrograma = Value
        End Set
    End Property

    Public Property Monto() As String
        Get
            Return nMonto
        End Get
        Set(ByVal Value As String)
            nMonto = Value
        End Set
    End Property

    Public Property Analista() As String
        Get
            Return cAnalista
        End Get
        Set(ByVal Value As String)
            cAnalista = Value
        End Set
    End Property

    Public Property dFecAsig() As String
        Get
            Return cdFecAsig
        End Get
        Set(ByVal Value As String)
            cdFecAsig = Value
        End Set
    End Property

    Public Property Oficina() As String
        Get
            Return cOficina
        End Get
        Set(ByVal Value As String)
            cOficina = Value
        End Set
    End Property

    Public Property Institucion() As String
        Get
            Return cInstitu
        End Get
        Set(ByVal Value As String)
            cInstitu = Value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return cCodigo
        End Get
        Set(ByVal Value As String)
            cCodigo = Value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return cTipo
        End Get
        Set(ByVal Value As String)
            cTipo = Value
        End Set
    End Property

    Public Property Cuenta() As String
        Get
            Return cCuenta
        End Get
        Set(ByVal Value As String)
            cCuenta = Value
        End Set
    End Property
    Public Property pnTipcre() As String
        Get
            Return cpnTipcre
        End Get
        Set(ByVal Value As String)
            cpnTipcre = Value
        End Set
    End Property
    Public Property pnTipgar() As String
        Get
            Return cpnTipgar
        End Get
        Set(ByVal Value As String)
            cpnTipgar = Value
        End Set
    End Property
    Public Property pnCiclo() As String
        Get
            Return cpnCiclo
        End Get
        Set(ByVal Value As String)
            cpnCiclo = Value
        End Set
    End Property

    Public Property cCodAct() As String
        Get
            Return pcCodAct
        End Get
        Set(ByVal Value As String)
            pcCodAct = Value
        End Set
    End Property

    Public Property ctipgar() As String
        Get
            Return pctipgar
        End Get
        Set(ByVal Value As String)
            pctipgar = Value
        End Set
    End Property

    Public Property cCodtmp() As String
        Get
            Return _cCodtmp
        End Get
        Set(ByVal Value As String)
            _cCodtmp = Value
        End Set
    End Property

    Public Property _cnomgru() As String
        Get
            Return cnomgru
        End Get
        Set(ByVal Value As String)
            cnomgru = Value
        End Set
    End Property

    Public Property _ccodsol() As String
        Get
            Return ccodsol
        End Get
        Set(ByVal Value As String)
            ccodsol = Value
        End Set
    End Property

    Public Property _cdirdom() As String
        Get
            Return cdirdom
        End Get
        Set(ByVal Value As String)
            cdirdom = Value
        End Set
    End Property

    Public Property _cdiareu() As String
        Get
            Return cdiareu
        End Get
        Set(ByVal Value As String)
            cdiareu = Value
        End Set
    End Property

    Public Property _chora() As String
        Get
            Return chora
        End Get
        Set(ByVal Value As String)
            chora = Value
        End Set
    End Property

    Public Property _ccodofi() As String
        Get
            Return ccodofi
        End Get
        Set(ByVal Value As String)
            ccodofi = Value
        End Set
    End Property

    Public Property _ccodins() As String
        Get
            Return ccodins
        End Get
        Set(ByVal Value As String)
            ccodins = Value
        End Set
    End Property

    Public Property _cfrecreu() As String
        Get
            Return cfrecreu
        End Get
        Set(ByVal Value As String)
            cfrecreu = Value
        End Set
    End Property

    Public Property _lactivo() As Boolean
        Get
            Return lactivo
        End Get
        Set(ByVal Value As Boolean)
            lactivo = Value
        End Set
    End Property


    Public Property _ctipomet() As String
        Get
            Return ctipomet
        End Get
        Set(ByVal Value As String)
            ctipomet = Value
        End Set
    End Property

    Public Property _ccodzon() As String
        Get
            Return ccodzon
        End Get
        Set(ByVal Value As String)
            ccodzon = Value
        End Set
    End Property

    Public Property _ccodcen() As String
        Get
            Return ccodcen
        End Get
        Set(ByVal Value As String)
            ccodcen = Value
        End Set
    End Property

    Public Property _ccargo() As String
        Get
            Return ccargo
        End Get
        Set(ByVal Value As String)
            ccargo = Value
        End Set
    End Property

    Public Property _lsegvid() As Boolean
        Get
            Return lsegvid
        End Get
        Set(ByVal Value As Boolean)
            lsegvid = Value
        End Set
    End Property

#End Region

    Public Function Graba_Solicitud() As String

        Dim x As String


        Dim pcNorRef As String
        Dim lnmonto As Double
        Dim pcCodCta As String



        Dim ecremcre As New cremcre
        Dim mcremcre As New cCremcre

        '        Dim eclipcta As New clipcta
        '       Dim mclipcta As New cclipcta

        Try
            '-------------------------------
            ' Carga Lineas de Credito      '
            '-------------------------------
            lnparametro1_R = "cNrolin , cCodlin, cDeslin, "
            lnparametro2_R = "S,S,S, "
            lnparametro3_R = " "
            lnparametro4_R = "CRETLIN"
            lnparametro5_R = "S"
            lnparametro6_R = " "
            Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
            lnparametro4_R, lnparametro5_R, lnparametro6_R)
            Transacc = "Select cNrolin , cCodlin, cDeslin from CRETLIN where lactiva = 1  and substring(ccodlin,5,2) = " & "'" & Me.ctipomet & "'   order by cnrolin desc "
            ds = cls1.ResulSelect(Transacc)

            If ds.Tables("Resultado").Rows.Count <= 0 Then
                x = "9"
                Return x
            Else
                pcNrolin = ds.Tables("Resultado").Rows(0)("cNrolin")
            End If
            ds.Tables("Resultado").Rows.Clear()
            ds.Tables("Resultado").Columns.Clear()


            'If Me.Destino = "9" Then
            '    pcNorRef = "R"
            'Else
            pcNorRef = "N"
            'End If


            lnmonto = Double.Parse(Me.Monto.Trim)

            Dim lccuentas As String


            'Me.lNuevo
            If Me.Tipo.Trim = "NUEVO" Then
                pcCodCta = clase.fxSteCuenta(Me.ctipomet, "1", Trim(Me.Institucion), Trim(Me.Oficina))

                x = pcCodCta


                ecremcre.ccodcli = Me.Codigo.Trim
                ecremcre.ccodcta = pcCodCta
                ecremcre.cestado = "A"
                ecremcre.ccodfue = Me.Programa.Trim
                ecremcre.ctipcre = Me.pnTipcre.Trim
                ecremcre.cdescre = Me.Destino.Trim
                ecremcre.cnorref = pcNorRef
                ecremcre.dfecasi = Me.dFecAsig.Trim
                ecremcre.dfecmod = Me.dFecAsig.Trim
                ecremcre.dfecsol = Me.dFecAsig.Trim
                ecremcre.dfecter = Me.dFecAsig.Trim
                ecremcre.dfectra = Me.dFecAsig.Trim
                ecremcre.dfecven = Me.dFecAsig.Trim
                ecremcre.dfecvig = Me.dFecAsig.Trim
                ecremcre.dultpag = Me.dFecAsig.Trim
                ecremcre.lctaret = "0"
                ecremcre.nmonsol = Double.Parse(Me.Monto.Trim)
                ecremcre.cnrolin = pcNrolin
                ecremcre.ccondic = "N"
                ecremcre.ccodana = Me.Analista.Trim
                ecremcre.cmoneda = "1"
                ecremcre.ccodprd = "01"
                ecremcre.cclacre = Me.Programa.Trim
                ecremcre.ccodusu = gcCodUsu
                ecremcre.dfecmod = Today()
                ecremcre.csececo = Me.Sector.Trim
                ecremcre.nciclo = Double.Parse(Me.pnCiclo.Trim)
                ecremcre.ctipgar = Me.pnTipgar.Trim
                ecremcre.ntipperc = 0
                ecremcre.cctapre = " "
                ecremcre.cCodofi = Me.Oficina.Trim
                ecremcre.ccodact = Me.cCodAct.Trim
                ecremcre.coficina = Me.Oficina.Trim
                ecremcre.ccatego = "A"
                ecremcre.ctipcuo = "1"
                ecremcre.ctipper = "1"
                ecremcre.cctapre = "1"
                ecremcre.ctipcon = "A"
                ecremcre.ccodapo = "001"
                ecremcre.cmarjud = "1"
                ecremcre.lctaret = "1"
                ecremcre.ccalif = "A"
                ecremcre.ccodsol = Me._ccodsol.Trim
                ecremcre.ccontra = "N"
                ecremcre.cflag = " "
                ecremcre.cflat = "S"
                ecremcre.clineac = " "
                ecremcre.cliquid = "N"
                ecremcre.dfecadm = Me.dFecAsig.Trim
                ecremcre.cregist = "1"
                ecremcre.dfecapr = Me.dFecAsig.Trim
                ecremcre.ccodrub = " "
                ecremcre.cnumexp = " "
                ecremcre.ccodrec = " "
                ecremcre.ccargo = Me.ccargo
                ecremcre.lsegvid = Me.lsegvid

                ecremcre.cprograma = Me._cprocre
                ecremcre.cfueing = Me.Fuente

                mcremcre.Agregar(ecremcre)
                lccuentas = pcCodCta

            Else
                'Modificación
                pcCodCta = Me.Institucion.Trim & Me.Oficina.Trim & Me.Cuenta.Trim
                x = pcCodCta
                ecremcre.ccodcli = Me.Codigo.Trim
                ecremcre.ccodcta = pcCodCta
                ecremcre.cestado = "A"
                ecremcre.ccodfue = Me.Programa.Trim
                ecremcre.ctipcre = Me.pnTipcre.Trim
                ecremcre.cdescre = Me.Destino.Trim
                ecremcre.cnorref = pcNorRef
                ecremcre.dfecasi = Me.dFecAsig.Trim
                ecremcre.dfecmod = Me.dFecAsig.Trim
                ecremcre.dfecsol = Me.dFecAsig.Trim
                ecremcre.dfecter = Me.dFecAsig.Trim
                ecremcre.dfectra = Me.dFecAsig.Trim
                ecremcre.dfecven = Me.dFecAsig.Trim
                ecremcre.dfecvig = Me.dFecAsig.Trim
                ecremcre.dultpag = Me.dFecAsig.Trim
                ecremcre.lctaret = "0"
                ecremcre.nmonsol = Double.Parse(Me.Monto.Trim)
                ecremcre.cnrolin = pcNrolin
                ecremcre.ccondic = "N"
                ecremcre.ccodana = Me.Analista.Trim
                ecremcre.cmoneda = "1"
                ecremcre.ccodprd = "01"
                ecremcre.cclacre = Me.Programa.Trim
                ecremcre.ccodusu = gcCodUsu
                ecremcre.dfecmod = Today()
                ecremcre.csececo = Me.Sector.Trim
                ecremcre.nciclo = Double.Parse(Me.pnCiclo.Trim)
                ecremcre.ctipgar = Me.pnTipgar.Trim
                ecremcre.ntipperc = 0
                ecremcre.cctapre = " "
                ecremcre.cCodofi = Me.cOficina.Trim
                ecremcre.ccodact = Me.cCodAct.Trim
                ecremcre.coficina = Me.cOficina.Trim
                ecremcre.ccatego = "A"
                ecremcre.ctipcuo = "1"
                ecremcre.ctipper = "1"
                ecremcre.cctapre = "1"
                ecremcre.ctipcon = "A"
                ecremcre.ccodapo = "001"
                ecremcre.cmarjud = "1"
                ecremcre.lctaret = "1"
                ecremcre.ccalif = "A"
                ecremcre.ccodsol = Me._ccodsol
                ecremcre.ccontra = "N"
                ecremcre.cflag = " "
                ecremcre.cflat = "S"
                ecremcre.clineac = " "
                ecremcre.cliquid = "N"
                ecremcre.dfecadm = Me.dFecAsig.Trim
                ecremcre.cregist = "1"
                ecremcre.dfecapr = Me.dFecAsig.Trim
                ecremcre.ccodrub = " "
                ecremcre.cnumexp = " "
                ecremcre.ccodrec = " "
                ecremcre.ccargo = Me.ccargo
                ecremcre.lsegvid = Me.lsegvid
                ecremcre.cprograma = Me._cprocre
                ecremcre.cfueing = Me.Fuente
                mcremcre.Actualizar(ecremcre)
            End If

            Return x
        Catch ex As Exception
            x = "0"
            Return x
        End Try


    End Function
    Public Function Resetea_Miembros(ByVal cCodsol As String) As String
        'Resetea miembros del banco 
        Dim mcremsol As New cCremsol
        Dim i As Integer
        i = mcremsol.ReseteaBancoComunal(cCodsol)
    End Function
    Public Function Graba_Miembros(ByVal cCodsol As String, ByVal ccodcli As String) As String
        'Resetea miembros del banco 
        Dim mcremsol As New cCremsol
        Dim i As Integer
        i = mcremsol.ActualizaMiembro(ccodcli, cCodsol)
    End Function


    Public Function Graba_Grupo(ByVal ctipmet As String) As String
        Dim x As String
        'Dim pccodsol As String
        Dim ecremsol As New cremsol
        Dim mcremsol As New cCremsol

        Try
            If Me.Tipo.Trim = "NUEVO" Then
                pccodsol = clase.fxSteCuentaGru(Trim(Me.Institucion), Trim(Me.Oficina), ctipmet.Trim)
                ecremsol.cCodsol = pccodsol
                ecremsol.cnomgru = Me.cnomgru
                ecremsol.cdirdom = Me.cdirdom
                ecremsol.cdiareu = Me.cdiareu
                ecremsol.chora = Me.chora
                ecremsol.ccodofi = Me.ccodofi
                ecremsol.ccodins = Me.ccodins
                ecremsol.cfrecreu = Me.cfrecreu
                ecremsol.dfecmod = Today()
                ecremsol.lactivo = Me.lactivo
                ecremsol.cCodzon = Me.ccodzon
                ecremsol.cCodcen = Me.ccodcen
                ecremsol.cCodcli = Me.pccodcli
                mcremsol.Agregar(ecremsol)

                x = pccodsol
            Else
                'pccodsol = Me.Institucion.Trim & Me.Oficina.Trim & Me.Cuenta.Trim
                ecremsol.cCodsol = pccodsol
                ecremsol.cnomgru = Me.cnomgru
                ecremsol.cdirdom = Me.cdirdom
                ecremsol.cdiareu = Me.cdiareu
                ecremsol.chora = Me.chora
                ecremsol.ccodofi = Me.ccodofi
                ecremsol.ccodins = Me.ccodins
                ecremsol.cfrecreu = Me.cfrecreu
                ecremsol.dfecmod = Today()
                ecremsol.lactivo = Me.lactivo
                ecremsol.cCodzon = Me.ccodzon
                ecremsol.cCodcen = Me.ccodcen
                ecremsol.cCodcli = Me.pccodcli
                mcremsol.Actualizar(ecremsol)

                x = pccodsol

            End If
            Me.ccodsol = pccodsol

            Return x
        Catch ex As Exception
            x = "0"
            Return x
        End Try

    End Function

    Public Function Graba_Centro() As String
        Dim x As String
        Dim pccodsol As String
        Dim ecentros As New centros
        Dim mcentros As New ccentros

        Try
            If Me.Tipo.Trim = "NUEVO" Then
                pccodsol = clase.fxSteCuentaCen(Trim(Me.Institucion), Trim(Me.Oficina))

                ecentros.cCodsol = pccodsol
                ecentros.cnomgru = Me.cnomgru
                ecentros.cdirdom = Me.cdirdom
                ecentros.cdiareu = Me.cdiareu
                ecentros.chora = Me.chora
                ecentros.ccodofi = Me.ccodofi
                ecentros.ccodins = Me.ccodins
                ecentros.cfrecreu = Me.cfrecreu
                ecentros.dfecmod = Today()
                ecentros.lactivo = Me.lactivo
                ecentros.cCodzon = Me.ccodzon
                mcentros.Agregar(ecentros)

                x = pccodsol
            Else
                pccodsol = Me.Institucion.Trim & Me.Oficina.Trim & Me.Cuenta.Trim
                ecentros.cCodsol = pccodsol
                ecentros.cnomgru = Me.cnomgru
                ecentros.cdirdom = Me.cdirdom
                ecentros.cdiareu = Me.cdiareu
                ecentros.chora = Me.chora
                ecentros.ccodofi = Me.ccodofi
                ecentros.ccodins = Me.ccodins
                ecentros.cfrecreu = Me.cfrecreu
                ecentros.dfecmod = Today()
                ecentros.lactivo = Me.lactivo
                ecentros.cCodzon = Me.ccodzon
                mcentros.Actualizar(ecentros)
            End If
            Return x
        Catch ex As Exception
            x = "0"
            Return x
        End Try

    End Function

End Class
