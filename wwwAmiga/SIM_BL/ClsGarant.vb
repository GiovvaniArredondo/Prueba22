Public Class ClsGarant
#Region " Variables "
    Private ccodcli As String
    Private ccodgar As String
    Private ccoduni As String
    Private ctipdes As String
    Private ctipgar As String
    Private cmoneda As String
    Private nmongar As Double
    Private nmongra As Double
    Private nmontas As Double
    Private llBandera As Boolean
    Private destado As Date
    Private cCodusu As String
    Private cDescri As String

    Private dpresent As Date
    Private dinscrip As Date
    Private cnumins As String
    Private cnumpres As String
    Private cobser As String

    Private cnotario As String
    Private nnumeropr As String
    Private dfechaes As Date
    Private clugares As String

    Private cpropietario As String

    Private cprofinca As String

    Private cprofolio As String

    Private cprolibro As String

    Private cprode As String

    Private dprofecha As DateTime

    Private cmunfinca As String

    Private cmunfolio As String

    Private cmunlibro As String

    Private cmunde As String

    Private dmunfecha As DateTime

    Private cdireccion As String

    Private ctopo As String

    Private cespdir As String

    Private cuso As String

    Private cespuso As String

    Private clocalidad As String

    Private nniveles As Int32

    Private cacceso As String

    Private cservicios As String

    Private cespser As String

    Private cambientes As String

    Private cespamb As String

    Private ctecho As String

    Private cesptecho As String

    Private cpiso As String

    Private cesppiso As String

    Private cparedes As String

    Private cesppared As String

    Private nnmedida As Decimal

    Private nncolin As String

    Private nsmedida As Decimal

    Private nscolin As String

    Private nemedida As Decimal

    Private necolin As String

    Private nomedida As Decimal

    Private nocolin As String

    Private nlongitud As Decimal

    Private nlatitud As Decimal

    Private cubica As String
#End Region

#Region " Propiedades "
    Public Property _cubica() As String
        Get
            Return cubica
        End Get
        Set(ByVal value As String)
            cubica = value
        End Set
    End Property
    Public Property _cnotario() As String
        Get
            Return cnotario
        End Get
        Set(ByVal value As String)
            cnotario = value
        End Set
    End Property
    Public Property _nnumeropr() As String
        Get
            Return nnumeropr
        End Get
        Set(ByVal value As String)
            nnumeropr = value
        End Set
    End Property
    Public Property _dfechaes() As Date
        Get
            Return dfechaes
        End Get
        Set(ByVal value As Date)
            dfechaes = value
        End Set
    End Property
    Public Property _clugares() As String
        Get
            Return clugares
        End Get
        Set(ByVal value As String)
            clugares = value
        End Set
    End Property

    Public Property _ccodcli() As String
        Get
            Return ccodcli
        End Get
        Set(ByVal Value As String)
            ccodcli = Value
        End Set
    End Property

    Public Property _ccodgar() As String
        Get
            Return ccodgar
        End Get
        Set(ByVal Value As String)
            ccodgar = Value
        End Set
    End Property
    Public Property _ccoduni() As String
        Get
            Return ccoduni
        End Get
        Set(ByVal Value As String)
            ccoduni = Value
        End Set
    End Property
    Public Property _ctipdes() As String
        Get
            Return ctipdes
        End Get
        Set(ByVal Value As String)
            ctipdes = Value
        End Set
    End Property
    Public Property _ctipgar() As String
        Get
            Return ctipgar
        End Get
        Set(ByVal Value As String)
            ctipgar = Value
        End Set
    End Property
    Public Property _cmoneda() As String
        Get
            Return cmoneda
        End Get
        Set(ByVal Value As String)
            cmoneda = Value
        End Set
    End Property
    Public Property _cdescri() As String
        Get
            Return cDescri
        End Get
        Set(ByVal Value As String)
            cDescri = Value
        End Set
    End Property
    Public Property _nmongar() As Double
        Get
            Return nmongar
        End Get
        Set(ByVal Value As Double)
            nmongar = Value
        End Set
    End Property

    Public Property _nmongra() As Double
        Get
            Return nmongra
        End Get
        Set(ByVal Value As Double)
            nmongra = Value
        End Set
    End Property

    Public Property _nmontas() As Double
        Get
            Return nmontas
        End Get
        Set(ByVal Value As Double)
            nmontas = Value
        End Set
    End Property
    Public Property _llBandera() As Boolean
        Get
            Return llBandera
        End Get
        Set(ByVal Value As Boolean)
            llBandera = Value
        End Set
    End Property
    Public Property _destado() As Date
        Get
            Return destado
        End Get
        Set(ByVal Value As Date)
            destado = Value
        End Set
    End Property
    Public Property _cCodusu() As String
        Get
            Return cCodusu
        End Get
        Set(ByVal Value As String)
            cCodusu = Value
        End Set
    End Property

    Public Property _dpresent() As Date
        Get
            Return dpresent
        End Get
        Set(ByVal Value As Date)
            dpresent = Value
        End Set
    End Property
    Public Property _dinscrip() As Date
        Get
            Return dinscrip
        End Get
        Set(ByVal Value As Date)
            dinscrip = Value
        End Set
    End Property
    Public Property _cnumins() As String
        Get
            Return cnumins
        End Get
        Set(ByVal Value As String)
            cnumins = Value
        End Set
    End Property
    Public Property _cnumpres() As String
        Get
            Return cnumpres
        End Get
        Set(ByVal Value As String)
            cnumpres = Value
        End Set
    End Property
    Public Property _cobser() As String
        Get
            Return cobser
        End Get
        Set(ByVal Value As String)
            cobser = Value
        End Set
    End Property

    Public Property _cpropietario() As String
        Get
            Return cpropietario
        End Get
        Set(ByVal Value As String)
            cpropietario = Value
        End Set
    End Property

    Public Property _cprofinca() As String
        Get
            Return cprofinca
        End Get
        Set(ByVal Value As String)
            cprofinca = Value
        End Set
    End Property

    Public Property _cprofolio() As String
        Get
            Return cprofolio
        End Get
        Set(ByVal Value As String)
            cprofolio = Value
        End Set
    End Property

    Public Property _cprolibro() As String
        Get
            Return cprolibro
        End Get
        Set(ByVal Value As String)
            cprolibro = Value
        End Set
    End Property

    Public Property _cprode() As String
        Get
            Return cprode
        End Get
        Set(ByVal Value As String)
            cprode = Value
        End Set
    End Property

    Public Property _dprofecha() As DateTime
        Get
            Return dprofecha
        End Get
        Set(ByVal Value As DateTime)
            dprofecha = Value
        End Set
    End Property

    Public Property _cmunfinca() As String
        Get
            Return cmunfinca
        End Get
        Set(ByVal Value As String)
            cmunfinca = Value
        End Set
    End Property

    Public Property _cmunfolio() As String
        Get
            Return cmunfolio
        End Get
        Set(ByVal Value As String)
            cmunfolio = Value
        End Set
    End Property

    Public Property _cmunlibro() As String
        Get
            Return cmunlibro
        End Get
        Set(ByVal Value As String)
            cmunlibro = Value
        End Set
    End Property

    Public Property _cmunde() As String
        Get
            Return cmunde
        End Get
        Set(ByVal Value As String)
            cmunde = Value
        End Set
    End Property

    Public Property _dmunfecha() As DateTime
        Get
            Return dmunfecha
        End Get
        Set(ByVal Value As DateTime)
            dmunfecha = Value
        End Set
    End Property

    Public Property _cdireccion() As String
        Get
            Return cdireccion
        End Get
        Set(ByVal Value As String)
            cdireccion = Value
        End Set
    End Property

    Public Property _ctopo() As String
        Get
            Return ctopo
        End Get
        Set(ByVal Value As String)
            ctopo = Value
        End Set
    End Property

    Public Property _cespdir() As String
        Get
            Return cespdir
        End Get
        Set(ByVal Value As String)
            cespdir = Value
        End Set
    End Property

    Public Property _cuso() As String
        Get
            Return cuso
        End Get
        Set(ByVal Value As String)
            cuso = Value
        End Set
    End Property

    Public Property _cespuso() As String
        Get
            Return cespuso
        End Get
        Set(ByVal Value As String)
            cespuso = Value
        End Set
    End Property

    Public Property _clocalidad() As String
        Get
            Return clocalidad
        End Get
        Set(ByVal Value As String)
            clocalidad = Value
        End Set
    End Property

    Public Property _nniveles() As Int32
        Get
            Return nniveles
        End Get
        Set(ByVal Value As Int32)
            nniveles = Value
        End Set
    End Property

    Public Property _cacceso() As String
        Get
            Return cacceso
        End Get
        Set(ByVal Value As String)
            cacceso = Value
        End Set
    End Property

    Public Property _cservicios() As String
        Get
            Return cservicios
        End Get
        Set(ByVal Value As String)
            cservicios = Value
        End Set
    End Property

    Public Property _cespser() As String
        Get
            Return cespser
        End Get
        Set(ByVal Value As String)
            cespser = Value
        End Set
    End Property

    Public Property _cambientes() As String
        Get
            Return cambientes
        End Get
        Set(ByVal Value As String)
            cambientes = Value
        End Set
    End Property

    Public Property _cespamb() As String
        Get
            Return cespamb
        End Get
        Set(ByVal Value As String)
            cespamb = Value
        End Set
    End Property

    Public Property _ctecho() As String
        Get
            Return ctecho
        End Get
        Set(ByVal Value As String)
            ctecho = Value
        End Set
    End Property

    Public Property _cesptecho() As String
        Get
            Return cesptecho
        End Get
        Set(ByVal Value As String)
            cesptecho = Value
        End Set
    End Property

    Public Property _cpiso() As String
        Get
            Return cpiso
        End Get
        Set(ByVal Value As String)
            cpiso = Value
        End Set
    End Property

    Public Property _cesppiso() As String
        Get
            Return cesppiso
        End Get
        Set(ByVal Value As String)
            cesppiso = Value
        End Set
    End Property

    Public Property _cparedes() As String
        Get
            Return cparedes
        End Get
        Set(ByVal Value As String)
            cparedes = Value
        End Set
    End Property

    Public Property _cesppared() As String
        Get
            Return cesppared
        End Get
        Set(ByVal Value As String)
            cesppared = Value
        End Set
    End Property

    Public Property _nnmedida() As Decimal
        Get
            Return nnmedida
        End Get
        Set(ByVal Value As Decimal)
            nnmedida = Value
        End Set
    End Property

    Public Property _nncolin() As String
        Get
            Return nncolin
        End Get
        Set(ByVal Value As String)
            nncolin = Value
        End Set
    End Property

    Public Property _nsmedida() As Decimal
        Get
            Return nsmedida
        End Get
        Set(ByVal Value As Decimal)
            nsmedida = Value
        End Set
    End Property

    Public Property _nscolin() As String
        Get
            Return nscolin
        End Get
        Set(ByVal Value As String)
            nscolin = Value
        End Set
    End Property

    Public Property _nemedida() As Decimal
        Get
            Return nemedida
        End Get
        Set(ByVal Value As Decimal)
            nemedida = Value
        End Set
    End Property

    Public Property _necolin() As String
        Get
            Return necolin
        End Get
        Set(ByVal Value As String)
            necolin = Value
        End Set
    End Property

    Public Property _nomedida() As Decimal
        Get
            Return nomedida
        End Get
        Set(ByVal Value As Decimal)
            nomedida = Value
        End Set
    End Property

    Public Property _nocolin() As String
        Get
            Return nocolin
        End Get
        Set(ByVal Value As String)
            nocolin = Value
        End Set
    End Property

    Public Property _nlongitud() As Decimal
        Get
            Return nlongitud
        End Get
        Set(ByVal Value As Decimal)
            nlongitud = Value
        End Set
    End Property

    Public Property _nlatitud() As Decimal
        Get
            Return nlatitud
        End Get
        Set(ByVal Value As Decimal)
            nlatitud = Value
        End Set
    End Property

    Private dfecval As Date
    Public Property _dfecval() As Date
        Get
            Return dfecval
        End Get
        Set(ByVal Value As Date)
            dfecval = Value
        End Set
    End Property

#End Region

#Region " Metodos "
    Public Function GrabaGarantia() As Integer
        Dim lnRetorno As Integer

        Try
            Dim entidadclimgar As New SIM.EL.climgar
            Dim eClimgar As New SIM.BL.cClimgar

            entidadclimgar.ccodcli = Me.ccodcli
            entidadclimgar.ccodgar = Me.ccodgar
            entidadclimgar.ccoduni = Me.ccoduni
            entidadclimgar.ctipdes = Me.ctipdes
            entidadclimgar.ctipgar = Me.ctipgar
            entidadclimgar.cmoneda = Me.cmoneda
            entidadclimgar.nmongar = Me.nmongar
            entidadclimgar.nmontas = Me.nmontas
            entidadclimgar.destado = Me.destado
            entidadclimgar.dfecmod = Today()
            entidadclimgar.ccodusu = Me.cCodusu
            entidadclimgar.cdescri = Me.cDescri
            entidadclimgar.cestado = ""
            entidadclimgar.ccodzon = ""

            entidadclimgar.csitgar = ""
            entidadclimgar.dfecrev = Today()
            entidadclimgar.ccoddep = ""
            entidadclimgar.cflag = ""
            entidadclimgar.cdirec = ""
            entidadclimgar.dpresent = #1/1/1900#
            entidadclimgar.dinscrip = #1/1/1900#
            entidadclimgar.cnumins = ""
            entidadclimgar.cnumpres = ""
            entidadclimgar.cobser = ""
            entidadclimgar.dfecval = Today()
            entidadclimgar.cubica = Me.cubica

            entidadclimgar.cnotario = Me.cnotario
            entidadclimgar.nnumeropr = Me.nnumeropr
            entidadclimgar.dfechaes = Me.dfechaes
            entidadclimgar.clugares = Me.clugares

            entidadclimgar.nmongra = Me.nmongra

            entidadclimgar.cpropietario = Me.cpropietario
            entidadclimgar.cprofinca = cprofinca
            entidadclimgar.cprofolio = cprofolio
            entidadclimgar.cprolibro = cprolibro
            entidadclimgar.cprode = cprode
            entidadclimgar.dprofecha = dprofecha
            entidadclimgar.cmunfinca = cmunfinca
            entidadclimgar.cmunfolio = cmunfolio
            entidadclimgar.cmunlibro = cmunlibro
            entidadclimgar.cmunde = cmunde
            entidadclimgar.dmunfecha = dmunfecha
            entidadclimgar.cdireccion = cdireccion
            entidadclimgar.cubica = cubica
            entidadclimgar.ctopo = ctopo
            entidadclimgar.cespdir = cespdir
            entidadclimgar.cuso = cuso
            entidadclimgar.cespuso = cespuso
            entidadclimgar.clocalidad = clocalidad
            entidadclimgar.nniveles = nniveles
            entidadclimgar.cacceso = cacceso
            entidadclimgar.cservicios = cservicios
            entidadclimgar.cambientes = cambientes
            entidadclimgar.ctecho = ctecho
            entidadclimgar.cpiso = cpiso
            entidadclimgar.cparedes = cparedes
            '-------------------------------------------------------------------
            entidadclimgar.cespser = cespser
            entidadclimgar.cespamb = cespamb
            entidadclimgar.cesptecho = cesptecho
            entidadclimgar.cesppiso = cesppiso
            entidadclimgar.cesppared = cesppared
            entidadclimgar.nnmedida = nnmedida
            entidadclimgar.nncolin = nncolin
            entidadclimgar.nsmedida = nsmedida
            entidadclimgar.nscolin = nscolin
            entidadclimgar.nemedida = nemedida
            entidadclimgar.necolin = necolin
            entidadclimgar.nomedida = nomedida
            entidadclimgar.nocolin = nocolin
            entidadclimgar.nlongitud = nlongitud
            entidadclimgar.nlatitud = nlatitud
            entidadclimgar.dfecval = dfecval

            If Me.llBandera Then 'Nuevo

                eClimgar.Agregar(entidadclimgar)
            Else 'Modificacion
                eClimgar.ActualizarClimgar(entidadclimgar)
            End If


            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function

    Public Function Elimina() As Integer
        Dim lnRetorno As Integer

        Try

            Dim entidadClimgar As New SIM.EL.climgar
            Dim eClimgar As New SIM.BL.cClimgar


            entidadClimgar.ccodcli = Me.ccodcli
            entidadClimgar.ccodgar = Me.ccodgar

            eClimgar.EliminarClimgar(Me.ccodcli, Me.ccodgar)


            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try
    End Function
    Public Function GrabaGarantiaGravamen() As Integer
        Dim lnRetorno As Integer

        Try
            Dim entidadclimgar As New SIM.El.climgar
            Dim eClimgar As New SIM.BL.cClimgar

            entidadclimgar.ccodcli = Me.ccodcli
            entidadclimgar.ccodgar = Me.ccodgar
            entidadclimgar.nmongra = Me.nmongra
            eClimgar.Actualizar1(entidadclimgar)

            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try


    End Function
    Public Function GrabaGarantiaHipo() As Integer
        Dim lnRetorno As Integer

        Try
            Dim entidadclimgar As New SIM.El.climgar
            Dim eClimgar As New SIM.BL.cClimgar

            entidadclimgar.ccodcli = Me.ccodcli
            entidadclimgar.ccodgar = Me.ccodgar
            entidadclimgar.dpresent = Me.dpresent
            entidadclimgar.dinscrip = Me.dinscrip
            entidadclimgar.cnumins = Me.cnumins
            entidadclimgar.cnumpres = Me.cnumpres
            entidadclimgar.cobser = Me.cobser

            eClimgar.ActualizarHipo(entidadclimgar)

            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function

#End Region

End Class
