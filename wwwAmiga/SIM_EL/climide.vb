Public Class climide
    Inherits entidadBase


#Region " Privadas "
    Private _ccodcli As String
 
    Private _ccodofi As String
 
    Private _cnomcli As String
 
    Private _cnomcor As String
 
    Private _ccodsol As String
 
    Private _dnacimi As DateTime
 
    Private _cclaper As String
 
    Private _csexo As String
 
    Private _ctipper As String
 
    Private _cindnac As String
 
    Private _clugnac As String
 
    Private _ctidoci As String
 
    Private _cnudoci As String
 
    Private _ctidotr As String
 
    Private _cnudotr As String
 
    Private _cestciv As String
 
    Private _cnivins As String
 
    Private _ccodcon As String
 
    Private _npercar As Decimal
 
    Private _cgrusan As String
 
    Private _ccodpro As String
 
    Private _cestsoc As String
 
    Private _ccoddom As String
 
    Private _cdirdom As String
 
    Private _ccondom As String
 
    Private _cteldom As String
 
    Private _nanodom As String
 
    Private _ccodsbs As String
 
    Private _caccins As String
 
    Private _crelins As String
 
    Private _dregist As DateTime
 
    Private _ndismen As Decimal
 
    Private _ccalint As String
 
    Private _ccalext As String
 
    Private _ccalpro As String
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
    Private _cbenef1 As String
 
    Private _cbenef2 As String
 
    Private _dfechai As DateTime
 
    Private _nacciones As Decimal
 
    Private _ccargo As String
 
    Private _cfirma As Decimal
 
    Private _cctacte As String
 
    Private _cnombco As String
 
    Private _lactivo As Boolean
 
    Private _cdevol As String
 
    Private _cubifue As String
 
    Private _cdirfue As String
 
    Private _nHijos As Decimal
 
    Private _nOtros As Decimal
 
    Private _cTipcli As String
 
    Private _cEscolar As String
 
    Private _cLugExp As String
 
    Private _dfchExp As DateTime
 
    Private _cTipcli1 As String
 
    Private _cTipviv As String
 
    Private _cDomAnt As String
 
    Private _cTiemRes As String
 
    Private _cRefe As String
 
    Private _cSabeEsc As String
 
    Private _cNomDño As String
 
    Private _cTelDño As String
 
    Private _cNomcon As String
 
    Private _cTipCony As String
 
    Private _cDuiCony As String
 
    Private _cSexcon As String
 
    Private _cProfCon As String

    Private _nsabeesc As Integer

    Private _cLtrab As String
 
    Private _cDirCon As String
 
    Private _cTelcon As String
 
    Private _cSactCon As Decimal
 
    Private _cTiempCon As String
 
    Private _mDatAdi As String
 
    Private _cNomInv As String
 
    Private _cPrefe1 As String
 
    Private _cDomInv As String
 
    Private _cTelInv As String
 
    Private _cLugInv As String
 
    Private _cTelLugInv As String
 
    Private _cNomFam As String
 
    Private _cPrefe2 As String
 
    Private _cDomFam As String
 
    Private _cTelFam As String
 
    Private _cLugFam As String
 
    Private _cTelLugFam As String
 
    Private _cNomVec As String
 
    Private _cPrefe3 As String
 
    Private _cDomVec As String
 
    Private _cTelVec As String
 
    Private _clugVec As String
 
    Private _cTelLugVec As String
 
    Private _cAnoDom As String

    Private _dfCony As DateTime

    Private _lsegvida As Boolean

    Private _cnrohij As String
    Private _cnomhij As String
    Private _dfecnac As DateTime
    Private _cCodgra As String
    Private _lcarnet As Boolean


    Private _cetnia As String
    Private _cnivel As String
    Private _cadicional As String
    Private _cconviv As String

    Private _cnombres As String
    Private _capellidos As String
    Private _cnomnit As String
    Private _ccodnac As String
    Private _ccodprodui As String

    Private _cnomcasa As String
    Private _nyearcasa As Integer
    Private _ccorreo As String

    Private _clugartray As String
    Private _ccodtray As String
    Private _cdomtray As String
    Private _cteltray As String
    Private _nsuetray As Decimal

    Private _czonlab As String
    Private _cdomtra As String
    Private _cteltralab As String
    Private _cjefe As String
    Private _ctiempo As String

    Private _foto() As Byte
    Private _firma As String

    Private _cpagadu As String

    Private _lactivado As Integer

    Private _csegnom As String
    Private _cternom As String
    Private _cpriape As String
    Private _csegape As String
    Private _capecasada As String
    Private _cleer As String
    Private _cescribir As String
    Private _cfirmar As String
    Private _cotrtel As String
    Private _cgrado As String
    'Private _nhijos As Integer
    Private _clocalidad As String
    Private _cgruetnico As String
    Private _cidiomas As String

    Private _cprinom As String

    Private _cnomrefcom1 As String
    Private _cnomrefcom2 As String
    Private _cnomrefcom3 As String

    Private _ctelrefcom1 As String
    Private _ctelrefcom2 As String
    Private _ctelrefcom3 As String

    Private _cdirrefcom1 As String
    Private _cdirrefcom2 As String
    Private _cdirrefcom3 As String

    Private _ctiprefper1 As String
    Private _ctiprefper2 As String
    Private _ctiprefper3 As String
    Private _ctiprefcom1 As String
    Private _ctiprefcom2 As String
    Private _ctiprefcom3 As String

    Private _ctipocondic As String
    Private _cparedes As String
    Private _cparedcondic As String
    Private _cpiso As String
    Private _cpisocondic As String
    Private _ctecho As String
    Private _ctechocondic As String
    Private _cservicios As String
    Private _csercondic As String
    Private _nvalor As Decimal
    Private _id_codigo_postal As String
        
    Private _id_ife As String

    Private _cCodPostal As String
    Private _cCalle As String
    Private _cNoExt As String
    Private _cNoInt As String

    Private _cparentesco As String

    Private _ctelcelular As String

    Private _cparentesco1 As String

    Private _ctelcelular1 As String

    Private _usuface As String


    Private _longitud As String
    Private _latitud As String

    Public Property ctipocondic() As String
        Get
            Return _ctipocondic
        End Get
        Set(ByVal Value As String)
            _ctipocondic = Value
        End Set
    End Property
    Public Property cparedes() As String
        Get
            Return _cparedes
        End Get
        Set(ByVal Value As String)
            _cparedes = Value
        End Set
    End Property
    Public Property cparedcondic() As String
        Get
            Return _cparedcondic
        End Get
        Set(ByVal Value As String)
            _cparedcondic = Value
        End Set
    End Property
    Public Property cpiso() As String
        Get
            Return _cpiso
        End Get
        Set(ByVal Value As String)
            _cpiso = Value
        End Set
    End Property
    Public Property cpisocondic() As String
        Get
            Return _cpisocondic
        End Get
        Set(ByVal Value As String)
            _cpisocondic = Value
        End Set
    End Property
    Public Property ctecho() As String
        Get
            Return _ctecho
        End Get
        Set(ByVal Value As String)
            _ctecho = Value
        End Set
    End Property
    Public Property ctechocondic() As String
        Get
            Return _ctechocondic
        End Get
        Set(ByVal Value As String)
            _ctechocondic = Value
        End Set
    End Property
    Public Property cservicios() As String
        Get
            Return _cservicios
        End Get
        Set(ByVal Value As String)
            _cservicios = Value
        End Set
    End Property
    Public Property csercondic() As String
        Get
            Return _csercondic
        End Get
        Set(ByVal Value As String)
            _csercondic = Value
        End Set
    End Property

    Public Property nvalor() As Decimal
        Get
            Return _nvalor
        End Get
        Set(ByVal Value As Decimal)
            _nvalor = Value
        End Set
    End Property

    '-----
    Public Property ctiprefper1() As String
        Get
            Return _ctiprefper1
        End Get
        Set(ByVal Value As String)
            _ctiprefper1 = Value
        End Set
    End Property
    Public Property ctiprefper2() As String
        Get
            Return _ctiprefper2
        End Get
        Set(ByVal Value As String)
            _ctiprefper2 = Value
        End Set
    End Property
    Public Property ctiprefper3() As String
        Get
            Return _ctiprefper3
        End Get
        Set(ByVal Value As String)
            _ctiprefper3 = Value
        End Set
    End Property
    Public Property ctiprefcom1() As String
        Get
            Return _ctiprefcom1
        End Get
        Set(ByVal Value As String)
            _ctiprefcom1 = Value
        End Set
    End Property
    Public Property ctiprefcom2() As String
        Get
            Return _ctiprefcom2
        End Get
        Set(ByVal Value As String)
            _ctiprefcom2 = Value
        End Set
    End Property
    Public Property ctiprefcom3() As String
        Get
            Return _ctiprefcom3
        End Get
        Set(ByVal Value As String)
            _ctiprefcom3 = Value
        End Set
    End Property

    Public Property cparentesco() As String
        Get
            Return _cparentesco
        End Get
        Set(ByVal Value As String)
            _cparentesco = Value
        End Set
    End Property

    Public Property ctelcelular() As String
        Get
            Return _ctelcelular
        End Get
        Set(ByVal Value As String)
            _ctelcelular = Value
        End Set
    End Property


    Public Property cparentesco1() As String
        Get
            Return _cparentesco1
        End Get
        Set(ByVal Value As String)
            _cparentesco1 = Value
        End Set
    End Property

    Public Property ctelcelular1() As String
        Get
            Return _ctelcelular1
        End Get
        Set(ByVal Value As String)
            _ctelcelular1 = Value
        End Set
    End Property


#End Region

#Region " Propiedades "
    Public Property cdirrefcom1() As String
        Get
            Return _cdirrefcom1
        End Get
        Set(ByVal Value As String)
            _cdirrefcom1 = Value
        End Set
    End Property
    Public Property cdirrefcom2() As String
        Get
            Return _cdirrefcom2
        End Get
        Set(ByVal Value As String)
            _cdirrefcom2 = Value
        End Set
    End Property
    Public Property cdirrefcom3() As String
        Get
            Return _cdirrefcom3
        End Get
        Set(ByVal Value As String)
            _cdirrefcom3 = Value
        End Set
    End Property
    Public Property ctelrefcom1() As String
        Get
            Return _ctelrefcom1
        End Get
        Set(ByVal Value As String)
            _ctelrefcom1 = Value
        End Set
    End Property
    Public Property ctelrefcom2() As String
        Get
            Return _ctelrefcom2
        End Get
        Set(ByVal Value As String)
            _ctelrefcom2 = Value
        End Set
    End Property
    Public Property ctelrefcom3() As String
        Get
            Return _ctelrefcom3
        End Get
        Set(ByVal Value As String)
            _ctelrefcom3 = Value
        End Set
    End Property

    Public Property cnomrefcom1() As String
        Get
            Return _cnomrefcom1
        End Get
        Set(ByVal Value As String)
            _cnomrefcom1 = Value
        End Set
    End Property
    Public Property cnomrefcom2() As String
        Get
            Return _cnomrefcom2
        End Get
        Set(ByVal Value As String)
            _cnomrefcom2 = Value
        End Set
    End Property
    Public Property cnomrefcom3() As String
        Get
            Return _cnomrefcom3
        End Get
        Set(ByVal Value As String)
            _cnomrefcom3 = Value
        End Set
    End Property

    Public Property cprinom() As String
        Get
            Return _cprinom
        End Get
        Set(ByVal Value As String)
            _cprinom = Value
        End Set
    End Property
    Public Property csegnom() As String
        Get
            Return _csegnom
        End Get
        Set(ByVal Value As String)
            _csegnom = Value
        End Set
    End Property
    Public Property cternom() As String
        Get
            Return _cternom
        End Get
        Set(ByVal Value As String)
            _cternom = Value
        End Set
    End Property
    Public Property cpriape() As String
        Get
            Return _cpriape
        End Get
        Set(ByVal Value As String)
            _cpriape = Value
        End Set
    End Property
    Public Property csegape() As String
        Get
            Return _csegape
        End Get
        Set(ByVal Value As String)
            _csegape = Value
        End Set
    End Property
    Public Property capecasada() As String
        Get
            Return _capecasada
        End Get
        Set(ByVal Value As String)
            _capecasada = Value
        End Set
    End Property
    Public Property cleer() As String
        Get
            Return _cleer
        End Get
        Set(ByVal Value As String)
            _cleer = Value
        End Set
    End Property
    Public Property cescribir() As String
        Get
            Return _cescribir
        End Get
        Set(ByVal Value As String)
            _cescribir = Value
        End Set
    End Property
    Public Property cfirmar() As String
        Get
            Return _cfirmar
        End Get
        Set(ByVal Value As String)
            _cfirmar = Value
        End Set
    End Property
    Public Property cotrtel() As String
        Get
            Return _cotrtel
        End Get
        Set(ByVal Value As String)
            _cotrtel = Value
        End Set
    End Property
    Public Property cgrado() As String
        Get
            Return _cgrado
        End Get
        Set(ByVal Value As String)
            _cgrado = Value
        End Set
    End Property
    'Public Property nhijos() As String
    '    Get
    '        Return _nhijos
    '    End Get
    '    Set(ByVal Value As String)
    '        _nHijos = Value
    '    End Set
    'End Property
    Public Property clocalidad() As String
        Get
            Return _clocalidad
        End Get
        Set(ByVal Value As String)
            _clocalidad = Value
        End Set
    End Property
    Public Property cgruetnico() As String
        Get
            Return _cgruetnico
        End Get
        Set(ByVal Value As String)
            _cgruetnico = Value
        End Set
    End Property
    Public Property cidiomas() As String
        Get
            Return _cidiomas
        End Get
        Set(ByVal Value As String)
            _cidiomas = Value
        End Set
    End Property


    Public Property cetnia() As String
        Get
            Return _cetnia
        End Get
        Set(ByVal Value As String)
            _cetnia = Value
        End Set
    End Property
    Public Property cnivel() As String
        Get
            Return _cnivel
        End Get
        Set(ByVal Value As String)
            _cnivel = Value
        End Set
    End Property
    Public Property cadicional() As String
        Get
            Return _cadicional
        End Get
        Set(ByVal Value As String)
            _cadicional = Value
        End Set
    End Property
    Public Property cconviv() As String
        Get
            Return _cconviv
        End Get
        Set(ByVal Value As String)
            _cconviv = Value
        End Set
    End Property

    Public Property ccodcli() As String
        Get
            Return _ccodcli
        End Get
        Set(ByVal Value As String)
            _ccodcli = Value
        End Set
    End Property

    Public Property ccodofi() As String
        Get
            Return _ccodofi
        End Get
        Set(ByVal Value As String)
            _ccodofi = Value
        End Set
    End Property

    Public Property cnomcli() As String
        Get
            Return _cnomcli
        End Get
        Set(ByVal Value As String)
            _cnomcli = Value
        End Set
    End Property

    Public Property cnomcor() As String
        Get
            Return _cnomcor
        End Get
        Set(ByVal Value As String)
            _cnomcor = Value
        End Set
    End Property

    Public Property ccodsol() As String
        Get
            Return _ccodsol
        End Get
        Set(ByVal Value As String)
            _ccodsol = Value
        End Set
    End Property

    Public Property dnacimi() As DateTime
        Get
            Return _dnacimi
        End Get
        Set(ByVal Value As DateTime)
            _dnacimi = Value
        End Set
    End Property

    Public Property cclaper() As String
        Get
            Return _cclaper
        End Get
        Set(ByVal Value As String)
            _cclaper = Value
        End Set
    End Property

    Public Property csexo() As String
        Get
            Return _csexo
        End Get
        Set(ByVal Value As String)
            _csexo = Value
        End Set
    End Property

    Public Property ctipper() As String
        Get
            Return _ctipper
        End Get
        Set(ByVal Value As String)
            _ctipper = Value
        End Set
    End Property

    Public Property cindnac() As String
        Get
            Return _cindnac
        End Get
        Set(ByVal Value As String)
            _cindnac = Value
        End Set
    End Property

    Public Property clugnac() As String
        Get
            Return _clugnac
        End Get
        Set(ByVal Value As String)
            _clugnac = Value
        End Set
    End Property

    Public Property ctidoci() As String
        Get
            Return _ctidoci
        End Get
        Set(ByVal Value As String)
            _ctidoci = Value
        End Set
    End Property

    Public Property cnudoci() As String
        Get
            Return _cnudoci
        End Get
        Set(ByVal Value As String)
            _cnudoci = Value
        End Set
    End Property

    Public Property ctidotr() As String
        Get
            Return _ctidotr
        End Get
        Set(ByVal Value As String)
            _ctidotr = Value
        End Set
    End Property

    Public Property cnudotr() As String
        Get
            Return _cnudotr
        End Get
        Set(ByVal Value As String)
            _cnudotr = Value
        End Set
    End Property

    Public Property cestciv() As String
        Get
            Return _cestciv
        End Get
        Set(ByVal Value As String)
            _cestciv = Value
        End Set
    End Property

    Public Property cnivins() As String
        Get
            Return _cnivins
        End Get
        Set(ByVal Value As String)
            _cnivins = Value
        End Set
    End Property

    Public Property ccodcon() As String
        Get
            Return _ccodcon
        End Get
        Set(ByVal Value As String)
            _ccodcon = Value
        End Set
    End Property

    Public Property npercar() As Decimal
        Get
            Return _npercar
        End Get
        Set(ByVal Value As Decimal)
            _npercar = Value
        End Set
    End Property

    Public Property cgrusan() As String
        Get
            Return _cgrusan
        End Get
        Set(ByVal Value As String)
            _cgrusan = Value
        End Set
    End Property

    Public Property ccodpro() As String
        Get
            Return _ccodpro
        End Get
        Set(ByVal Value As String)
            _ccodpro = Value
        End Set
    End Property

    Public Property cestsoc() As String
        Get
            Return _cestsoc
        End Get
        Set(ByVal Value As String)
            _cestsoc = Value
        End Set
    End Property

    Public Property ccoddom() As String
        Get
            Return _ccoddom
        End Get
        Set(ByVal Value As String)
            _ccoddom = Value
        End Set
    End Property

    Public Property cdirdom() As String
        Get
            Return _cdirdom
        End Get
        Set(ByVal Value As String)
            _cdirdom = Value
        End Set
    End Property

    Public Property ccondom() As String
        Get
            Return _ccondom
        End Get
        Set(ByVal Value As String)
            _ccondom = Value
        End Set
    End Property

    Public Property cteldom() As String
        Get
            Return _cteldom
        End Get
        Set(ByVal Value As String)
            _cteldom = Value
        End Set
    End Property

    Public Property nanodom() As String
        Get
            Return _nanodom
        End Get
        Set(ByVal Value As String)
            _nanodom = Value
        End Set
    End Property

    Public Property ccodsbs() As String
        Get
            Return _ccodsbs
        End Get
        Set(ByVal Value As String)
            _ccodsbs = Value
        End Set
    End Property

    Public Property caccins() As String
        Get
            Return _caccins
        End Get
        Set(ByVal Value As String)
            _caccins = Value
        End Set
    End Property

    Public Property crelins() As String
        Get
            Return _crelins
        End Get
        Set(ByVal Value As String)
            _crelins = Value
        End Set
    End Property

    Public Property dregist() As DateTime
        Get
            Return _dregist
        End Get
        Set(ByVal Value As DateTime)
            _dregist = Value
        End Set
    End Property

    Public Property ndismen() As Decimal
        Get
            Return _ndismen
        End Get
        Set(ByVal Value As Decimal)
            _ndismen = Value
        End Set
    End Property

    Public Property ccalint() As String
        Get
            Return _ccalint
        End Get
        Set(ByVal Value As String)
            _ccalint = Value
        End Set
    End Property

    Public Property ccalext() As String
        Get
            Return _ccalext
        End Get
        Set(ByVal Value As String)
            _ccalext = Value
        End Set
    End Property

    Public Property ccalpro() As String
        Get
            Return _ccalpro
        End Get
        Set(ByVal Value As String)
            _ccalpro = Value
        End Set
    End Property

    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal Value As String)
            _ccodusu = Value
        End Set
    End Property

    Public Property dfecmod() As DateTime
        Get
            Return _dfecmod
        End Get
        Set(ByVal Value As DateTime)
            _dfecmod = Value
        End Set
    End Property

    Public Property cflag() As String
        Get
            Return _cflag
        End Get
        Set(ByVal Value As String)
            _cflag = Value
        End Set
    End Property

    Public Property cbenef1() As String
        Get
            Return _cbenef1
        End Get
        Set(ByVal Value As String)
            _cbenef1 = Value
        End Set
    End Property

    Public Property cbenef2() As String
        Get
            Return _cbenef2
        End Get
        Set(ByVal Value As String)
            _cbenef2 = Value
        End Set
    End Property

    Public Property dfechai() As DateTime
        Get
            Return _dfechai
        End Get
        Set(ByVal Value As DateTime)
            _dfechai = Value
        End Set
    End Property

    Public Property nacciones() As Decimal
        Get
            Return _nacciones
        End Get
        Set(ByVal Value As Decimal)
            _nacciones = Value
        End Set
    End Property

    Public Property ccargo() As String
        Get
            Return _ccargo
        End Get
        Set(ByVal Value As String)
            _ccargo = Value
        End Set
    End Property

    Public Property cfirma() As Decimal
        Get
            Return _cfirma
        End Get
        Set(ByVal Value As Decimal)
            _cfirma = Value
        End Set
    End Property

    Public Property cctacte() As String
        Get
            Return _cctacte
        End Get
        Set(ByVal Value As String)
            _cctacte = Value
        End Set
    End Property

    Public Property cnombco() As String
        Get
            Return _cnombco
        End Get
        Set(ByVal Value As String)
            _cnombco = Value
        End Set
    End Property

    Public Property lactivo() As Boolean
        Get
            Return _lactivo
        End Get
        Set(ByVal Value As Boolean)
            _lactivo = Value
        End Set
    End Property

    Public Property cdevol() As String
        Get
            Return _cdevol
        End Get
        Set(ByVal Value As String)
            _cdevol = Value
        End Set
    End Property

    Public Property cubifue() As String
        Get
            Return _cubifue
        End Get
        Set(ByVal Value As String)
            _cubifue = Value
        End Set
    End Property

    Public Property cdirfue() As String
        Get
            Return _cdirfue
        End Get
        Set(ByVal Value As String)
            _cdirfue = Value
        End Set
    End Property

    Public Property nHijos() As Decimal
        Get
            Return _nHijos
        End Get
        Set(ByVal Value As Decimal)
            _nHijos = Value
        End Set
    End Property

    Public Property nOtros() As Decimal
        Get
            Return _nOtros
        End Get
        Set(ByVal Value As Decimal)
            _nOtros = Value
        End Set
    End Property

    Public Property cTipcli() As String
        Get
            Return _cTipcli
        End Get
        Set(ByVal Value As String)
            _cTipcli = Value
        End Set
    End Property

    Public Property cEscolar() As String
        Get
            Return _cEscolar
        End Get
        Set(ByVal Value As String)
            _cEscolar = Value
        End Set
    End Property

    Public Property cLugExp() As String
        Get
            Return _cLugExp
        End Get
        Set(ByVal Value As String)
            _cLugExp = Value
        End Set
    End Property

    Public Property dfchExp() As DateTime
        Get
            Return _dfchExp
        End Get
        Set(ByVal Value As DateTime)
            _dfchExp = Value
        End Set
    End Property

    Public Property cTipcli1() As String
        Get
            Return _cTipcli1
        End Get
        Set(ByVal Value As String)
            _cTipcli1 = Value
        End Set
    End Property

    Public Property cTipviv() As String
        Get
            Return _cTipviv
        End Get
        Set(ByVal Value As String)
            _cTipviv = Value
        End Set
    End Property

    Public Property cDomAnt() As String
        Get
            Return _cDomAnt
        End Get
        Set(ByVal Value As String)
            _cDomAnt = Value
        End Set
    End Property

    Public Property cTiemRes() As String
        Get
            Return _cTiemRes
        End Get
        Set(ByVal Value As String)
            _cTiemRes = Value
        End Set
    End Property

    Public Property cRefe() As String
        Get
            Return _cRefe
        End Get
        Set(ByVal Value As String)
            _cRefe = Value
        End Set
    End Property

    Public Property cSabeEsc() As String
        Get
            Return _cSabeEsc
        End Get
        Set(ByVal Value As String)
            _cSabeEsc = Value
        End Set
    End Property

    Public Property cNomDño() As String
        Get
            Return _cNomDño
        End Get
        Set(ByVal Value As String)
            _cNomDño = Value
        End Set
    End Property

    Public Property cTelDño() As String
        Get
            Return _cTelDño
        End Get
        Set(ByVal Value As String)
            _cTelDño = Value
        End Set
    End Property

    Public Property cNomcon() As String
        Get
            Return _cNomcon
        End Get
        Set(ByVal Value As String)
            _cNomcon = Value
        End Set
    End Property

    Public Property cTipCony() As String
        Get
            Return _cTipCony
        End Get
        Set(ByVal Value As String)
            _cTipCony = Value
        End Set
    End Property

    Public Property cDuiCony() As String
        Get
            Return _cDuiCony
        End Get
        Set(ByVal Value As String)
            _cDuiCony = Value
        End Set
    End Property

    Public Property cSexcon() As String
        Get
            Return _cSexcon
        End Get
        Set(ByVal Value As String)
            _cSexcon = Value
        End Set
    End Property
    Public Property nsabeesc() As Integer
        Get
            Return _nsabeesc
        End Get
        Set(ByVal value As Integer)
            _nsabeesc = value
        End Set
    End Property

    Public Property cProfCon() As String
        Get
            Return _cProfCon
        End Get
        Set(ByVal Value As String)
            _cProfCon = Value
        End Set
    End Property

    Public Property cLtrab() As String
        Get
            Return _cLtrab
        End Get
        Set(ByVal Value As String)
            _cLtrab = Value
        End Set
    End Property

    Public Property cDirCon() As String
        Get
            Return _cDirCon
        End Get
        Set(ByVal Value As String)
            _cDirCon = Value
        End Set
    End Property

    Public Property cTelcon() As String
        Get
            Return _cTelcon
        End Get
        Set(ByVal Value As String)
            _cTelcon = Value
        End Set
    End Property

    Public Property cSactCon() As Decimal
        Get
            Return _cSactCon
        End Get
        Set(ByVal Value As Decimal)
            _cSactCon = Value
        End Set
    End Property

    Public Property cTiempCon() As String
        Get
            Return _cTiempCon
        End Get
        Set(ByVal Value As String)
            _cTiempCon = Value
        End Set
    End Property

    Public Property mDatAdi() As String
        Get
            Return _mDatAdi
        End Get
        Set(ByVal Value As String)
            _mDatAdi = Value
        End Set
    End Property

    Public Property cNomInv() As String
        Get
            Return _cNomInv
        End Get
        Set(ByVal Value As String)
            _cNomInv = Value
        End Set
    End Property

    Public Property cPrefe1() As String
        Get
            Return _cPrefe1
        End Get
        Set(ByVal Value As String)
            _cPrefe1 = Value
        End Set
    End Property

    Public Property cDomInv() As String
        Get
            Return _cDomInv
        End Get
        Set(ByVal Value As String)
            _cDomInv = Value
        End Set
    End Property

    Public Property cTelInv() As String
        Get
            Return _cTelInv
        End Get
        Set(ByVal Value As String)
            _cTelInv = Value
        End Set
    End Property

    Public Property cLugInv() As String
        Get
            Return _cLugInv
        End Get
        Set(ByVal Value As String)
            _cLugInv = Value
        End Set
    End Property

    Public Property cTelLugInv() As String
        Get
            Return _cTelLugInv
        End Get
        Set(ByVal Value As String)
            _cTelLugInv = Value
        End Set
    End Property

    Public Property cNomFam() As String
        Get
            Return _cNomFam
        End Get
        Set(ByVal Value As String)
            _cNomFam = Value
        End Set
    End Property

    Public Property cPrefe2() As String
        Get
            Return _cPrefe2
        End Get
        Set(ByVal Value As String)
            _cPrefe2 = Value
        End Set
    End Property

    Public Property cDomFam() As String
        Get
            Return _cDomFam
        End Get
        Set(ByVal Value As String)
            _cDomFam = Value
        End Set
    End Property

    Public Property cTelFam() As String
        Get
            Return _cTelFam
        End Get
        Set(ByVal Value As String)
            _cTelFam = Value
        End Set
    End Property

    Public Property cLugFam() As String
        Get
            Return _cLugFam
        End Get
        Set(ByVal Value As String)
            _cLugFam = Value
        End Set
    End Property

    Public Property cTelLugFam() As String
        Get
            Return _cTelLugFam
        End Get
        Set(ByVal Value As String)
            _cTelLugFam = Value
        End Set
    End Property

    Public Property cNomVec() As String
        Get
            Return _cNomVec
        End Get
        Set(ByVal Value As String)
            _cNomVec = Value
        End Set
    End Property

    Public Property cPrefe3() As String
        Get
            Return _cPrefe3
        End Get
        Set(ByVal Value As String)
            _cPrefe3 = Value
        End Set
    End Property

    Public Property cDomVec() As String
        Get
            Return _cDomVec
        End Get
        Set(ByVal Value As String)
            _cDomVec = Value
        End Set
    End Property

    Public Property cTelVec() As String
        Get
            Return _cTelVec
        End Get
        Set(ByVal Value As String)
            _cTelVec = Value
        End Set
    End Property

    Public Property clugVec() As String
        Get
            Return _clugVec
        End Get
        Set(ByVal Value As String)
            _clugVec = Value
        End Set
    End Property

    Public Property cTelLugVec() As String
        Get
            Return _cTelLugVec
        End Get
        Set(ByVal Value As String)
            _cTelLugVec = Value
        End Set
    End Property

    Public Property cAnoDom() As String
        Get
            Return _cAnoDom
        End Get
        Set(ByVal Value As String)
            _cAnoDom = Value
        End Set
    End Property
    Public Property dfCony() As DateTime
        Get
            Return _dfCony
        End Get
        Set(ByVal Value As DateTime)
            _dfCony = Value
        End Set
    End Property

    Public Property lsegvida() As Boolean
        Get
            Return _lsegvida
        End Get
        Set(ByVal Value As Boolean)
            _lsegvida = Value
        End Set
    End Property

    Public Property cnomhij() As String
        Get
            Return _cnomhij
        End Get
        Set(ByVal Value As String)
            _cnomhij = Value
        End Set
    End Property

    Public Property dfecnac() As DateTime
        Get
            Return _dfecnac
        End Get
        Set(ByVal Value As DateTime)
            _dfecnac = Value
        End Set
    End Property
    Public Property ccodgra() As String
        Get
            Return _cCodgra
        End Get
        Set(ByVal Value As String)
            _cCodgra = Value
        End Set
    End Property

    Public Property cnrohij() As String
        Get
            Return _cnrohij
        End Get
        Set(ByVal Value As String)
            _cnrohij = Value
        End Set
    End Property

    Public Property lcarnet() As Boolean
        Get
            Return _lcarnet
        End Get
        Set(ByVal Value As Boolean)
            _lcarnet = Value
        End Set
    End Property

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private _cdejaesc As String
    Public Property cdejaesc() As String
        Get
            Return _cdejaesc
        End Get
        Set(ByVal Value As String)
            _cdejaesc = Value
        End Set
    End Property

    Private _nprestamo As Integer
    Public Property nprestamo() As Integer
        Get
            Return _nprestamo
        End Get
        Set(ByVal Value As Integer)
            _nprestamo = Value
        End Set
    End Property

    Private _ninvertir1 As Integer
    Public Property ninvertir1() As Integer
        Get
            Return _ninvertir1
        End Get
        Set(ByVal Value As Integer)
            _ninvertir1 = Value
        End Set
    End Property

    Private _ninvertir2 As Integer
    Public Property ninvertir2() As Integer
        Get
            Return _ninvertir2
        End Get
        Set(ByVal Value As Integer)
            _ninvertir2 = Value
        End Set
    End Property

    Private _ninvertir3 As Integer
    Public Property ninvertir3() As Integer
        Get
            Return _ninvertir3
        End Get
        Set(ByVal Value As Integer)
            _ninvertir3 = Value
        End Set
    End Property

    Private _ninvertir4 As Integer
    Public Property ninvertir4() As Integer
        Get
            Return _ninvertir4
        End Get
        Set(ByVal Value As Integer)
            _ninvertir4 = Value
        End Set
    End Property

    Private _ninvertir5 As Integer
    Public Property ninvertir5() As Integer
        Get
            Return _ninvertir5
        End Get
        Set(ByVal Value As Integer)
            _ninvertir5 = Value
        End Set
    End Property

    Private _ninvertir6 As Integer
    Public Property ninvertir6() As Integer
        Get
            Return _ninvertir6
        End Get
        Set(ByVal Value As Integer)
            _ninvertir6 = Value
        End Set
    End Property

    Private _cinvertir As String
    Public Property cinvertir() As String
        Get
            Return _cinvertir
        End Get
        Set(ByVal Value As String)
            _cinvertir = Value
        End Set
    End Property

    Private _nuso1 As Integer
    Public Property nuso1() As Integer
        Get
            Return _nuso1
        End Get
        Set(ByVal Value As Integer)
            _nuso1 = Value
        End Set
    End Property

    Private _nuso2 As Integer
    Public Property nuso2() As Integer
        Get
            Return _nuso2
        End Get
        Set(ByVal Value As Integer)
            _nuso2 = Value
        End Set
    End Property

    Private _nuso3 As Integer
    Public Property nuso3() As Integer
        Get
            Return _nuso3
        End Get
        Set(ByVal Value As Integer)
            _nuso3 = Value
        End Set
    End Property

    Private _nuso4 As Integer
    Public Property nuso4() As Integer
        Get
            Return _nuso4
        End Get
        Set(ByVal Value As Integer)
            _nuso4 = Value
        End Set
    End Property

    Private _nuso5 As Integer
    Public Property nuso5() As Integer
        Get
            Return _nuso5
        End Get
        Set(ByVal Value As Integer)
            _nuso5 = Value
        End Set
    End Property

    Private _nhogar1 As Integer
    Public Property nhogar1() As Integer
        Get
            Return _nhogar1
        End Get
        Set(ByVal Value As Integer)
            _nhogar1 = Value
        End Set
    End Property

    Private _nhogar2 As Integer
    Public Property nhogar2() As Integer
        Get
            Return _nhogar2
        End Get
        Set(ByVal Value As Integer)
            _nhogar2 = Value
        End Set
    End Property

    Private _nhogar3 As Integer
    Public Property nhogar3() As Integer
        Get
            Return _nhogar3
        End Get
        Set(ByVal Value As Integer)
            _nhogar3 = Value
        End Set
    End Property

    Private _nhogar4 As Integer
    Public Property nhogar4() As Integer
        Get
            Return _nhogar4
        End Get
        Set(ByVal Value As Integer)
            _nhogar4 = Value
        End Set
    End Property

    Private _nhogar5 As Integer
    Public Property nhogar5() As Integer
        Get
            Return _nhogar5
        End Get
        Set(ByVal Value As Integer)
            _nhogar5 = Value
        End Set
    End Property

    Private _nhogar6 As Integer
    Public Property nhogar6() As Integer
        Get
            Return _nhogar6
        End Get
        Set(ByVal Value As Integer)
            _nhogar6 = Value
        End Set
    End Property

    Private _nhogarxq1 As Integer
    Public Property nhogarxq1() As Integer
        Get
            Return _nhogarxq1
        End Get
        Set(ByVal Value As Integer)
            _nhogarxq1 = Value
        End Set
    End Property

    Private _nhogarxq2 As Integer
    Public Property nhogarxq2() As Integer
        Get
            Return _nhogarxq2
        End Get
        Set(ByVal Value As Integer)
            _nhogarxq2 = Value
        End Set
    End Property

    Private _nhogarxq3 As Integer
    Public Property nhogarxq3() As Integer
        Get
            Return _nhogarxq3
        End Get
        Set(ByVal Value As Integer)
            _nhogarxq3 = Value
        End Set
    End Property

    Private _nhogarxq4 As Integer
    Public Property nhogarxq4() As Integer
        Get
            Return _nhogarxq4
        End Get
        Set(ByVal Value As Integer)
            _nhogarxq4 = Value
        End Set
    End Property

    Private _nhogarxq5 As Integer
    Public Property nhogarxq5() As Integer
        Get
            Return _nhogarxq5
        End Get
        Set(ByVal Value As Integer)
            _nhogarxq5 = Value
        End Set
    End Property

    Private _chogarxq As String
    Public Property chogarxq() As String
        Get
            Return _chogarxq
        End Get
        Set(ByVal Value As String)
            _chogarxq = Value
        End Set
    End Property

    Private _nsiaumento1 As Integer
    Public Property nsiaumento1() As Integer
        Get
            Return _nsiaumento1
        End Get
        Set(ByVal Value As Integer)
            _nsiaumento1 = Value
        End Set
    End Property

    Private _nsiaumento2 As Integer
    Public Property nsiaumento2() As Integer
        Get
            Return _nsiaumento2
        End Get
        Set(ByVal Value As Integer)
            _nsiaumento2 = Value
        End Set
    End Property

    Private _nsiaumento3 As Integer
    Public Property nsiaumento3() As Integer
        Get
            Return _nsiaumento3
        End Get
        Set(ByVal Value As Integer)
            _nsiaumento3 = Value
        End Set
    End Property

    Private _nsiaumento4 As Integer
    Public Property nsiaumento4() As Integer
        Get
            Return _nsiaumento4
        End Get
        Set(ByVal Value As Integer)
            _nsiaumento4 = Value
        End Set
    End Property

    Private _nsiaumento5 As Integer
    Public Property nsiaumento5() As Integer
        Get
            Return _nsiaumento5
        End Get
        Set(ByVal Value As Integer)
            _nsiaumento5 = Value
        End Set
    End Property

    Private _nenseres As Integer
    Public Property nenseres() As Integer
        Get
            Return _nenseres
        End Get
        Set(ByVal Value As Integer)
            _nenseres = Value
        End Set
    End Property

    Private _nsicual1 As Integer
    Public Property nsicual1() As Integer
        Get
            Return _nsicual1
        End Get
        Set(ByVal Value As Integer)
            _nsicual1 = Value
        End Set
    End Property

    Private _nsicual2 As Integer
    Public Property nsicual2() As Integer
        Get
            Return _nsicual2
        End Get
        Set(ByVal Value As Integer)
            _nsicual2 = Value
        End Set
    End Property
    Private _nsicual3 As Integer
    Public Property nsicual3() As Integer
        Get
            Return _nsicual3
        End Get
        Set(ByVal Value As Integer)
            _nsicual3 = Value
        End Set
    End Property
    Private _nsicual4 As Integer
    Public Property nsicual4() As Integer
        Get
            Return _nsicual4
        End Get
        Set(ByVal Value As Integer)
            _nsicual4 = Value
        End Set
    End Property
    Private _nsicual5 As Integer
    Public Property nsicual5() As Integer
        Get
            Return _nsicual5
        End Get
        Set(ByVal Value As Integer)
            _nsicual5 = Value
        End Set
    End Property
    Private _nsicual6 As Integer
    Public Property nsicual6() As Integer
        Get
            Return _nsicual6
        End Get
        Set(ByVal Value As Integer)
            _nsicual6 = Value
        End Set
    End Property
    Private _nsicual7 As Integer
    Public Property nsicual7() As Integer
        Get
            Return _nsicual7
        End Get
        Set(ByVal Value As Integer)
            _nsicual7 = Value
        End Set
    End Property
    Private _csicual As String
    Public Property csicual() As String
        Get
            Return _csicual
        End Get
        Set(ByVal Value As String)
            _csicual = Value
        End Set
    End Property

    Private _npropia As Integer
    Public Property npropia() As Integer
        Get
            Return _npropia
        End Get
        Set(ByVal Value As Integer)
            _npropia = Value
        End Set
    End Property
    Private _nmejoras As Integer
    Public Property nmejoras() As Integer
        Get
            Return _nmejoras
        End Get
        Set(ByVal Value As Integer)
            _nmejoras = Value
        End Set
    End Property

    Private _nsimejoras1 As Integer
    Public Property nsimejoras1() As Integer
        Get
            Return _nsimejoras1
        End Get
        Set(ByVal Value As Integer)
            _nsimejoras1 = Value
        End Set
    End Property

    Private _nsimejoras2 As Integer
    Public Property nsimejoras2() As Integer
        Get
            Return _nsimejoras2
        End Get
        Set(ByVal Value As Integer)
            _nsimejoras2 = Value
        End Set
    End Property

    Private _nsimejoras3 As Integer
    Public Property nsimejoras3() As Integer
        Get
            Return _nsimejoras3
        End Get
        Set(ByVal Value As Integer)
            _nsimejoras3 = Value
        End Set
    End Property
    Private _nsimejoras4 As Integer
    Public Property nsimejoras4() As Integer
        Get
            Return _nsimejoras4
        End Get
        Set(ByVal Value As Integer)
            _nsimejoras4 = Value
        End Set
    End Property
    Private _nsimejoras5 As Integer
    Public Property nsimejoras5() As Integer
        Get
            Return _nsimejoras5
        End Get
        Set(ByVal Value As Integer)
            _nsimejoras5 = Value
        End Set
    End Property
    Private _nsimejoras6 As Integer
    Public Property nsimejoras6() As Integer
        Get
            Return _nsimejoras6
        End Get
        Set(ByVal Value As Integer)
            _nsimejoras6 = Value
        End Set
    End Property
    Private _nsimejoras7 As Integer
    Public Property nsimejoras7() As Integer
        Get
            Return _nsimejoras7
        End Get
        Set(ByVal Value As Integer)
            _nsimejoras7 = Value
        End Set
    End Property
    Private _nsimejoras8 As Integer
    Public Property nsimejoras8() As Integer
        Get
            Return _nsimejoras8
        End Get
        Set(ByVal Value As Integer)
            _nsimejoras8 = Value
        End Set
    End Property
    Private _csimejoras As String
    Public Property csimejoras() As String
        Get
            Return _csimejoras
        End Get
        Set(ByVal Value As String)
            _csimejoras = Value
        End Set
    End Property

    Public Property cnombres() As String
        Get
            Return _cnombres
        End Get
        Set(ByVal value As String)
            _cnombres = value
        End Set
    End Property
    Public Property capellidos() As String
        Get
            Return _capellidos
        End Get
        Set(ByVal value As String)
            _capellidos = value
        End Set
    End Property
    Public Property cnomnit() As String
        Get
            Return _cnomnit
        End Get
        Set(ByVal value As String)
            _cnomnit = value
        End Set
    End Property
    Public Property ccodnac() As String
        Get
            Return _ccodnac
        End Get
        Set(ByVal value As String)
            _ccodnac = value
        End Set
    End Property
    Public Property ccodprodui() As String
        Get
            Return _ccodprodui
        End Get
        Set(ByVal value As String)
            _ccodprodui = value
        End Set
    End Property

    Public Property cnomcasa() As String
        Get
            Return _cnomcasa
        End Get
        Set(ByVal value As String)
            _cnomcasa = value
        End Set
    End Property
    Public Property nyearcasa() As Integer
        Get
            Return _nyearcasa
        End Get
        Set(ByVal value As Integer)
            _nyearcasa = value
        End Set
    End Property
    Public Property ccorreo() As String
        Get
            Return _ccorreo
        End Get
        Set(ByVal value As String)
            _ccorreo = value
        End Set
    End Property

    Public Property usuface() As String
        Get
            Return _usuface
        End Get
        Set(ByVal value As String)
            _usuface = value
        End Set
    End Property

    Public Property clugartray() As String
        Get
            Return _clugartray
        End Get
        Set(ByVal value As String)
            _clugartray = value
        End Set
    End Property

    Public Property ccodtray() As String
        Get
            Return _ccodtray
        End Get
        Set(ByVal value As String)
            _ccodtray = value
        End Set
    End Property

    Public Property cdomtray() As String
        Get
            Return _cdomtray
        End Get
        Set(ByVal value As String)
            _cdomtray = value
        End Set
    End Property

    Public Property cteltray() As String
        Get
            Return _cteltray
        End Get
        Set(ByVal value As String)
            _cteltray = value
        End Set
    End Property

    Public Property nsuetray() As Decimal
        Get
            Return _nsuetray
        End Get
        Set(ByVal value As Decimal)
            _nsuetray = value
        End Set
    End Property

    Public Property czonlab() As String
        Get
            Return _czonlab
        End Get
        Set(ByVal value As String)
            _czonlab = value
        End Set
    End Property

    Public Property cdomtra() As String
        Get
            Return _cdomtra
        End Get
        Set(ByVal value As String)
            _cdomtra = value
        End Set
    End Property

    Public Property cteltralab() As String
        Get
            Return _cteltralab
        End Get
        Set(ByVal value As String)
            _cteltralab = value
        End Set
    End Property

    Public Property cjefe() As String
        Get
            Return _cjefe
        End Get
        Set(ByVal value As String)
            _cjefe = value
        End Set
    End Property

    Public Property ctiempo() As String
        Get
            Return _ctiempo
        End Get
        Set(ByVal value As String)
            _ctiempo = value
        End Set
    End Property

    Public Property foto() As Array
        Get
            Return _foto
        End Get
        Set(ByVal Value As Array)
            _foto = Value
        End Set
    End Property

    Public Property firma() As String
        Get
            Return _firma
        End Get
        Set(ByVal value As String)
            _firma = value
        End Set
    End Property

    Public Property cpagadu() As String
        Get
            Return _cpagadu
        End Get
        Set(ByVal value As String)
            _cpagadu = value
        End Set
    End Property

    Public Property id_codigo_postal() As String
        Get
            Return _id_codigo_postal
        End Get
        Set(ByVal Value As String)
            _id_codigo_postal = Value
        End Set
    End Property


    Public Property id_ife() As String
        Get
            Return _id_ife
        End Get
        Set(ByVal Value As String)
            _id_ife = Value
        End Set
    End Property

    Public Property cCodPostal() As String
        Get
            Return _cCodPostal
        End Get
        Set(ByVal Value As String)
            _cCodPostal = Value
        End Set
    End Property

    Public Property cCalle() As String
        Get
            Return _cCalle
        End Get
        Set(ByVal Value As String)
            _cCalle = Value
        End Set
    End Property

    Public Property cNoExt() As String
        Get
            Return _cNoExt
        End Get
        Set(ByVal Value As String)
            _cNoExt = Value
        End Set
    End Property

    Public Property cNoInt() As String
        Get
            Return _cNoInt
        End Get
        Set(ByVal Value As String)
            _cNoInt = Value
        End Set
    End Property

    Public Property latitud() As String
        Get
            Return _latitud
        End Get
        Set(ByVal Value As String)
            _latitud = Value
        End Set
    End Property

    Public Property longitud() As String
        Get
            Return _longitud
        End Get
        Set(ByVal Value As String)
            _longitud = Value
        End Set
    End Property

#End Region

End Class
