Public Class ClsCliente

#Region " Variables "
    Private ccodigo As String
    Private cnomcli As String
    Private dfecnac As Date
    Private cnudoci As String
    Private cnudotr As String
    Private cGen As String
    Private cEstciv As String
    Private cProf As String
    Private cCodDom As String
    Private cDirDom As String
    Private cTelDom As String
    Private cNomCony As String
    Private dfNacCony As Date
    Private idCivCony As String
    Private cGenCony As String
    Private cProfCony As String
    Private nsabeesc As Integer
    Private cTipcli As String
    Private cCodOfi As String
    Private id_codigo_postal As String
    Private lsegvida As Boolean
    Private nfirma As Boolean
    Private ife As String
    Private cetnia As String
    Private cnivel As String
    Private cadicional As String
    Private cconviv As String
    Private npercar As Integer

    Private clugexp As String
    Private ctidoci As String

    Private cprinom As String
    Private csegnom As String
    Private cternom As String
    Private cpriape As String
    Private csegape As String
    Private capecasada As String
    Private cleer As String
    Private cescribir As String
    Private cfirmar As String
    Private cotrtel As String
    Private cgrado As String
    Private nhijos As Integer
    Private clocalidad As String
    Private cgruetnico As String
    Private cidiomas As String

    Private ctipocondic As String
    Private cparedes As String
    Private cparedcondic As String
    Private cpiso As String
    Private cpisocondic As String
    Private ctecho As String
    Private ctechocondic As String
    Private cservicios As String
    Private csercondic As String
    Private cnomdño As String
    Private nvalor As Decimal
    Private nanodom As Integer

    Private cgrusan As String
    Private ccodcon As String
    Private ccodusu As String
    Private _foto() As Byte

    Private cCalle As String
    Private cNoExt As String
    Private cNoInt As String
    Private ccorreo As String
    Private usuface As String

    Private _Latitud As String
    Private _Longitud As String
#End Region


#Region " Propiedades"
    Public Property foto() As Array
        Get
            Return _foto
        End Get
        Set(ByVal Value As Array)
            _foto = Value
        End Set
    End Property

    Public Property _ccodcon() As String
        Get
            Return ccodcon
        End Get
        Set(ByVal Value As String)
            ccodcon = Value
        End Set
    End Property
    Public Property _cgrusan() As String
        Get
            Return cgrusan
        End Get
        Set(ByVal Value As String)
            cgrusan = Value
        End Set
    End Property
    Public Property _ctipocondic() As String
        Get
            Return ctipocondic
        End Get
        Set(ByVal Value As String)
            ctipocondic = Value
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
    Public Property _cparedcondic() As String
        Get
            Return cparedcondic
        End Get
        Set(ByVal Value As String)
            cparedcondic = Value
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
    Public Property _cpisocondic() As String
        Get
            Return cpisocondic
        End Get
        Set(ByVal Value As String)
            cpisocondic = Value
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
    Public Property _ctechocondic() As String
        Get
            Return ctechocondic
        End Get
        Set(ByVal Value As String)
            ctechocondic = Value
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
    Public Property _csercondic() As String
        Get
            Return csercondic
        End Get
        Set(ByVal Value As String)
            csercondic = Value
        End Set
    End Property
    Public Property _cnomdño() As String
        Get
            Return cnomdño
        End Get
        Set(ByVal Value As String)
            cnomdño = Value
        End Set
    End Property
    Public Property _nvalor() As Decimal
        Get
            Return nvalor
        End Get
        Set(ByVal Value As Decimal)
            nvalor = Value
        End Set
    End Property
    Public Property _nanodom() As Integer
        Get
            Return nanodom
        End Get
        Set(ByVal Value As Integer)
            nanodom = Value
        End Set
    End Property


    Public Property _cprinom() As String
        Get
            Return cprinom
        End Get
        Set(ByVal Value As String)
            cprinom = Value
        End Set
    End Property
    Public Property _csegnom() As String
        Get
            Return csegnom
        End Get
        Set(ByVal Value As String)
            csegnom = Value
        End Set
    End Property
    Public Property _cternom() As String
        Get
            Return cternom
        End Get
        Set(ByVal Value As String)
            cternom = Value
        End Set
    End Property
    Public Property _cpriape() As String
        Get
            Return cpriape
        End Get
        Set(ByVal Value As String)
            cpriape = Value
        End Set
    End Property
    Public Property _csegape() As String
        Get
            Return csegape
        End Get
        Set(ByVal Value As String)
            csegape = Value
        End Set
    End Property
    Public Property _capecasada() As String
        Get
            Return capecasada
        End Get
        Set(ByVal Value As String)
            capecasada = Value
        End Set
    End Property
    Public Property _cleer() As String
        Get
            Return cleer
        End Get
        Set(ByVal Value As String)
            cleer = Value
        End Set
    End Property
    Public Property _cescribir() As String
        Get
            Return cescribir
        End Get
        Set(ByVal Value As String)
            cescribir = Value
        End Set
    End Property
    Public Property _cfirmar() As String
        Get
            Return cfirmar
        End Get
        Set(ByVal Value As String)
            cfirmar = Value
        End Set
    End Property
    Public Property _cotrtel() As String
        Get
            Return cotrtel
        End Get
        Set(ByVal Value As String)
            cotrtel = Value
        End Set
    End Property
    Public Property _cgrado() As String
        Get
            Return cgrado
        End Get
        Set(ByVal Value As String)
            cgrado = Value
        End Set
    End Property
    Public Property _nhijos() As String
        Get
            Return nhijos
        End Get
        Set(ByVal Value As String)
            nhijos = Value
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

    Public Property _id_codigo_postal() As String
        Get
            Return id_codigo_postal
        End Get
        Set(ByVal Value As String)
            id_codigo_postal = Value
        End Set
    End Property
    Public Property _cgruetnico() As String
        Get
            Return cgruetnico
        End Get
        Set(ByVal Value As String)
            cgruetnico = Value
        End Set
    End Property
    Public Property _cidiomas() As String
        Get
            Return cidiomas
        End Get
        Set(ByVal Value As String)
            cidiomas = Value
        End Set
    End Property
    Public Property _clugexp() As String
        Get
            Return clugexp
        End Get
        Set(ByVal Value As String)
            clugexp = Value
        End Set
    End Property
    Public Property _ctidoci() As String
        Get
            Return ctidoci
        End Get
        Set(ByVal Value As String)
            ctidoci = Value
        End Set
    End Property

    Public Property _cetnia() As String
        Get
            Return cetnia
        End Get
        Set(ByVal Value As String)
            cetnia = Value
        End Set
    End Property
    Public Property _cnivel() As String
        Get
            Return cnivel
        End Get
        Set(ByVal Value As String)
            cnivel = Value
        End Set
    End Property
    Public Property _cadicional() As String
        Get
            Return cadicional
        End Get
        Set(ByVal Value As String)
            cadicional = Value
        End Set
    End Property
    Public Property _cconviv() As String
        Get
            Return cconviv
        End Get
        Set(ByVal Value As String)
            cconviv = Value
        End Set
    End Property

    Public Property _npercar() As Integer
        Get
            Return npercar
        End Get
        Set(ByVal value As Integer)
            npercar = value
        End Set
    End Property




    Private ivacli As String

    Public Property _ivacli() As String
        Get
            Return ivacli
        End Get
        Set(ByVal Value As String)
            ivacli = Value
        End Set
    End Property


    Private celular As String

    Public Property _celular() As String
        Get
            Return celular
        End Get
        Set(ByVal Value As String)
            celular = Value
        End Set
    End Property


    Public Property _ccodigo() As String
        Get
            Return ccodigo
        End Get
        Set(ByVal Value As String)
            ccodigo = Value
        End Set
    End Property
    Public Property _cNomcli() As String
        Get
            Return cnomcli
        End Get
        Set(ByVal Value As String)
            cnomcli = Value
        End Set
    End Property

    Public Property _dFecnac() As Date
        Get
            Return dfecnac
        End Get
        Set(ByVal Value As Date)
            dfecnac = Value
        End Set
    End Property

    Public Property _dfNacCony() As Date
        Get
            Return dfNacCony
        End Get
        Set(ByVal Value As Date)
            dfNacCony = Value
        End Set
    End Property
    Public Property _cnudoci() As String
        Get
            Return cnudoci
        End Get
        Set(ByVal Value As String)
            cnudoci = Value
        End Set
    End Property
    Public Property _cnudotr() As String
        Get
            Return cnudotr
        End Get
        Set(ByVal Value As String)
            cnudotr = Value
        End Set
    End Property
    Public Property _cGen() As String
        Get
            Return cGen
        End Get
        Set(ByVal Value As String)
            cGen = Value
        End Set
    End Property
    Public Property _cEstciv() As String
        Get
            Return cEstciv
        End Get
        Set(ByVal Value As String)
            cEstciv = Value
        End Set
    End Property

    Public Property _cProf() As String
        Get
            Return cProf
        End Get
        Set(ByVal Value As String)
            cProf = Value
        End Set
    End Property
    Public Property _cCodDom() As String
        Get
            Return cCodDom
        End Get
        Set(ByVal Value As String)
            cCodDom = Value
        End Set
    End Property
    Public Property _cDirDom() As String
        Get
            Return cDirDom
        End Get
        Set(ByVal Value As String)
            cDirDom = Value
        End Set
    End Property
    Public Property _cTelDom() As String
        Get
            Return cTelDom
        End Get
        Set(ByVal Value As String)
            cTelDom = Value
        End Set
    End Property

    Public Property _cNomCony() As String
        Get
            Return cNomCony
        End Get
        Set(ByVal Value As String)
            cNomCony = Value
        End Set
    End Property
    Public Property _IdCivCony() As String
        Get
            Return idCivCony
        End Get
        Set(ByVal Value As String)
            idCivCony = Value
        End Set
    End Property
    Public Property _cGenCony() As String
        Get
            Return cGenCony
        End Get
        Set(ByVal Value As String)
            cGenCony = Value
        End Set
    End Property
    Public Property _cProfCony() As String
        Get
            Return cProfCony
        End Get
        Set(ByVal Value As String)
            cProfCony = Value
        End Set
    End Property
    Public Property _nsabeesc() As Integer
        Get
            Return nsabeesc
        End Get
        Set(ByVal value As Integer)
            nsabeesc = value
        End Set
    End Property

    Public Property _cTipcli() As String
        Get
            Return cTipcli
        End Get
        Set(ByVal Value As String)
            cTipcli = Value
        End Set
    End Property

    Public Property _cCodOfi() As String
        Get
            Return cCodOfi
        End Get
        Set(ByVal Value As String)
            cCodOfi = Value
        End Set
    End Property


    Public Property _lsegvida() As Boolean
        Get
            Return lsegvida
        End Get
        Set(ByVal Value As Boolean)
            lsegvida = Value
        End Set
    End Property

    Public Property _nfirma() As Boolean
        Get
            Return nfirma
        End Get
        Set(ByVal Value As Boolean)
            nfirma = Value
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


    Public Property _ife() As String
        Get
            Return ife
        End Get
        Set(ByVal Value As String)
            ife = Value
        End Set
    End Property


    Public Property _cCalle() As String
        Get
            Return cCalle
        End Get
        Set(ByVal Value As String)
            cCalle = Value
        End Set
    End Property

    Public Property _cNoExt() As String
        Get
            Return cNoExt
        End Get
        Set(ByVal Value As String)
            cNoExt = Value
        End Set
    End Property

    Public Property _cNoInt() As String
        Get
            Return cNoInt
        End Get
        Set(ByVal Value As String)
            cNoInt = Value
        End Set
    End Property

    Public Property _ccorreo() As String
        Get
            Return ccorreo
        End Get
        Set(ByVal value As String)
            ccorreo = value
        End Set
    End Property

    Public Property _usuface() As String
        Get
            Return usuface
        End Get
        Set(ByVal value As String)
            usuface = value
        End Set
    End Property


    Public Property Latitud() As String
        Get
            Return _Latitud
        End Get
        Set(ByVal value As String)
            _Latitud = value
        End Set
    End Property

    Public Property Longitud() As String
        Get
            Return _Longitud
        End Get
        Set(ByVal value As String)
            _Longitud = value
        End Set
    End Property

#End Region

#Region " Metodos "
    Public Function AdCliente(ByVal lnflag As Integer) As String
        Dim cClase As New SIM.BL.crefunc
        Dim lccodcli As String

        Try

            If Me.ccodigo = "" Or Me.ccodigo = " " Then  'Nuevo Cliente
                'Genera el Codigo del Cliente
                lccodcli = cClase.GeneraCodCliente(Me.cCodOfi)

                Dim entidadClimide As New SIM.EL.climide
                Dim eClimide As New SIM.BL.cClimide

                entidadClimide.ccodcli = Me.ccodigo

                eClimide.ObtenerClimide(entidadClimide)

                entidadClimide.ccodcli = lccodcli
                entidadClimide.cclaper = Me.cTipcli
                entidadClimide.cnomcli = Me.cnomcli
                entidadClimide.cnomcor = Me.cnomcli
                entidadClimide.dnacimi = Me.dfecnac
                entidadClimide.cnudoci = Me.cnudoci
                entidadClimide.cnudotr = Me.cnudotr
                entidadClimide.csexo = Me.cGen
                entidadClimide.cestciv = Me.cEstciv
                entidadClimide.ccodpro = Me.cProf
                entidadClimide.ccoddom = Me.cCodDom
                entidadClimide.cdirdom = Me.cDirDom
                entidadClimide.cteldom = Me.cTelDom
                entidadClimide.cNomcon = Me.cNomCony
                entidadClimide.dfCony = Me.dfNacCony
                entidadClimide.cDuiCony = Me.idCivCony
                entidadClimide.cSexcon = Me.cGenCony
                entidadClimide.cProfCon = Me.cProfCony
                entidadClimide.ccodofi = Me.cCodOfi
                entidadClimide.cTelFam = Me.celular
                entidadClimide.mDatAdi = Me.ivacli
                entidadClimide.lsegvida = Me.lsegvida
                entidadClimide.cfirma = Me.nfirma

                entidadClimide.cetnia = Me.cetnia
                entidadClimide.cnivel = Me.cnivel
                entidadClimide.cadicional = Me.cadicional
                entidadClimide.cconviv = Me.cconviv

                entidadClimide.ccodsol = ""
                entidadClimide.cLugExp = Me.clugexp
                entidadClimide.nsabeesc = Me.nsabeesc
                entidadClimide.npercar = Me.npercar

                entidadClimide.ctidoci = Me.ctidoci

                entidadClimide.cprinom = Me.cprinom
                entidadClimide.csegnom = Me.csegnom
                entidadClimide.cternom = Me.cternom
                entidadClimide.cpriape = Me.cpriape
                entidadClimide.csegape = Me.csegape
                entidadClimide.capecasada = Me.capecasada
                entidadClimide.cleer = Me.cleer
                entidadClimide.cescribir = Me.cescribir
                entidadClimide.cfirmar = Me.cfirmar
                entidadClimide.cotrtel = Me.cotrtel
                entidadClimide.cgrado = Me.cgrado
                entidadClimide.nHijos = Me.nhijos
                entidadClimide.clocalidad = Me.clocalidad
                entidadClimide.cgruetnico = Me.cgruetnico
                entidadClimide.cidiomas = Me.cidiomas

                entidadClimide.ctipocondic = Me.ctipocondic
                entidadClimide.cparedes = Me.cparedes
                entidadClimide.cparedcondic = Me.cparedcondic
                entidadClimide.cpiso = Me.cpiso
                entidadClimide.cpisocondic = Me.cpisocondic
                entidadClimide.ctecho = Me.ctecho
                entidadClimide.ctechocondic = Me.ctechocondic
                entidadClimide.cservicios = Me.cservicios
                entidadClimide.csercondic = Me.csercondic
                entidadClimide.cNomDño = Me.cnomdño
                entidadClimide.nvalor = Me.nvalor
                entidadClimide.nanodom = Me.nanodom
                entidadClimide.cgrusan = Me.cgrusan
                entidadClimide.ccodcon = Me.ccodcon
                entidadClimide.foto = Me.foto
                entidadClimide.ccodusu = Me.ccodusu
                entidadClimide.id_codigo_postal = Me.id_codigo_postal
                entidadClimide.id_ife = Me.ife

                entidadClimide.cCalle = Me.cCalle
                entidadClimide.cNoExt = Me.cNoExt
                entidadClimide.cNoInt = Me.cNoInt
                entidadClimide.ccorreo = Me.ccorreo
                entidadClimide.usuface = Me.usuface
                entidadClimide.latitud = Me.Latitud
                entidadClimide.longitud = Me.Longitud


                eClimide.AgregaClimide(entidadClimide)


            Else    'Modificacion de Cliente

                Dim entidadClimide As New SIM.EL.climide
                Dim eClimide As New SIM.BL.cClimide

                entidadClimide.ccodcli = Me.ccodigo
                lccodcli = Me.ccodigo

                eClimide.ObtenerClimide(entidadClimide)

                entidadClimide.ccodcli = Me.ccodigo
                entidadClimide.cclaper = Me.cTipcli
                entidadClimide.cnomcli = Me.cnomcli
                entidadClimide.cnomcor = Me.cnomcli
                entidadClimide.dnacimi = Me.dfecnac
                entidadClimide.cnudoci = Me.cnudoci
                entidadClimide.cnudotr = Me.cnudotr
                entidadClimide.csexo = Me.cGen
                entidadClimide.cestciv = Me.cEstciv
                entidadClimide.ccodpro = Me.cProf
                entidadClimide.ccoddom = Me.cCodDom
                entidadClimide.cdirdom = Me.cDirDom
                entidadClimide.cteldom = Me.cTelDom
                entidadClimide.cNomcon = Me.cNomCony
                entidadClimide.dfCony = Me.dfNacCony
                entidadClimide.cDuiCony = Me.idCivCony
                entidadClimide.cSexcon = Me.cGenCony
                entidadClimide.cProfCon = Me.cProfCony
                entidadClimide.ccodofi = Me.cCodOfi
                entidadClimide.cTelFam = Me.celular
                entidadClimide.mDatAdi = Me.ivacli
                entidadClimide.lsegvida = Me.lsegvida
                entidadClimide.cfirma = Me.nfirma
                entidadClimide.cetnia = Me.cetnia
                entidadClimide.cnivel = Me.cnivel
                entidadClimide.cadicional = Me.cadicional
                entidadClimide.cconviv = Me.cconviv
                entidadClimide.cLugExp = Me.clugexp
                entidadClimide.nsabeesc = Me.nsabeesc
                entidadClimide.npercar = Me.npercar
                entidadClimide.ctidoci = Me.ctidoci

                entidadClimide.cprinom = Me.cprinom
                entidadClimide.csegnom = Me.csegnom
                entidadClimide.cternom = Me.cternom
                entidadClimide.cpriape = Me.cpriape
                entidadClimide.csegape = Me.csegape
                entidadClimide.capecasada = Me.capecasada
                entidadClimide.cleer = Me.cleer
                entidadClimide.cescribir = Me.cescribir
                entidadClimide.cfirmar = Me.cfirmar
                entidadClimide.cotrtel = Me.cotrtel
                entidadClimide.cgrado = Me.cgrado
                entidadClimide.nHijos = Me.nhijos
                entidadClimide.clocalidad = Me.clocalidad
                entidadClimide.cgruetnico = Me.cgruetnico
                entidadClimide.cidiomas = Me.cidiomas

                entidadClimide.ctipocondic = Me.ctipocondic
                entidadClimide.cparedes = Me.cparedes
                entidadClimide.cparedcondic = Me.cparedcondic
                entidadClimide.cpiso = Me.cpiso
                entidadClimide.cpisocondic = Me.cpisocondic
                entidadClimide.ctecho = Me.ctecho
                entidadClimide.ctechocondic = Me.ctechocondic
                entidadClimide.cservicios = Me.cservicios
                entidadClimide.csercondic = Me.csercondic
                entidadClimide.cNomDño = Me.cnomdño
                entidadClimide.nvalor = Me.nvalor
                entidadClimide.nanodom = Me.nanodom
                entidadClimide.cgrusan = Me.cgrusan
                entidadClimide.ccodcon = Me.ccodcon
                entidadClimide.ccodusu = Me.ccodusu
                entidadClimide.id_codigo_postal = Me.id_codigo_postal
                entidadClimide.id_ife = Me.ife

                entidadClimide.cCalle = Me.cCalle
                entidadClimide.cNoExt = Me.cNoExt
                entidadClimide.cNoInt = Me.cNoInt
                entidadClimide.ccorreo = Me.ccorreo
                entidadClimide.usuface = Me.usuface
                entidadClimide.latitud = Me.Latitud
                entidadClimide.longitud = Me.Longitud

                Try
                    entidadClimide.foto = Me.foto
                Catch ex As Exception

                End Try

                eClimide.ActualizarClimide1(entidadClimide, lnflag)

            End If

            Return lccodcli

        Catch ex As Exception
            lccodcli = "0"
            Return lccodcli
        End Try


    End Function
#End Region

End Class
