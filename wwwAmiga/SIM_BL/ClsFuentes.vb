Public Class ClsFuentes

#Region " Variables "
    Private ccodcli As String
    Private dEvalua As Date
    Private nIngCony As Double
    Private nIngFami As Double
    Private nIngSSPC As Double
    Private nIngReme As Double
    Private nGasCasa As Double
    Private nGasAlim As Double
    Private nGasAlte As Double
    Private ngasTran As Double
    Private nGasEduc As Double
    Private nGasSalu As Double
    Private nGasRopa As Double
    Private nGasPres As Double
    Private cCodusu As String
    Private dFecMod As Date
    Private llBandera As Boolean
    Private ccoduni As String
    Private cTiprel As String
    Private cCodfue As String
    Private cNomFue As String
    Private cTiDofu As String
    Private cNuDoFu As String
    Private dIniFue As Date
    Private nEmplea As Double
    Private cUbiFue As String
    Private cDirFue As String
    Private cTelFue As String
    Private cConFue As String
    Private cSecEco As String
    Private cCodAct As String
    Private cAnoUbi As Date
    Private nSueldo As Double
    Private cTipNeg As String

    Private dBalanc As Date
    Private nActDis As Double
    Private nCtaCob As Double
    Private nInvent As Double
    Private nActFij As Double
    Private nProvee As Double
    Private nOtrPre As Double
    Private nCreIns As Double
    Private nVentas As Double
    Private nRecupe As Double
    Private nMercad As Double
    Private nOtrEgr As Double
    Private nPagPres As Double
    Private nOtrIng As Double
    Private nImpues As Double
    Private nImprev As Double
    Private nOtrAct As Double
    Private nmarseg As Double

    Private cmanfon As String
    Private cpuesto As String
    Private cjefe As String
    Private cpuestojefe As String

    Private dfechaA As Date
    Private cconcpa As String
    Private cconvta As String
    Private nfahope As Integer
    Private nfahote As Integer
    Private nnfhope As Integer
    Private nnfhote As Integer

    Private cpara As String
    Private nmetros As Decimal
    Private nvaras As Decimal
    Private cmedida As String
    Private ncantidad As Decimal
    Private nfamupe As Integer
    Private nfamute As Integer
    Private nnfmupe As Integer
    Private nnfmute As Integer
    Private cdirterreno As String
    Private cgiro As String
    Private _Latitud As String
    Private _Longitud As String
#End Region

#Region " Propiedades "
    Public Property _cdirterreno() As String
        Get
            Return cdirterreno
        End Get
        Set(ByVal Value As String)
            cdirterreno = Value
        End Set
    End Property
    Public Property _cpara() As String
        Get
            Return cpara
        End Get
        Set(ByVal Value As String)
            cpara = Value
        End Set
    End Property
    Public Property _nmetros() As Decimal
        Get
            Return nmetros
        End Get
        Set(ByVal Value As Decimal)
            nmetros = Value
        End Set
    End Property
    Public Property _nvaras() As Decimal
        Get
            Return nvaras
        End Get
        Set(ByVal Value As Decimal)
            nvaras = Value
        End Set
    End Property
    Public Property _cmedida() As String
        Get
            Return cmedida
        End Get
        Set(ByVal Value As String)
            cmedida = Value
        End Set
    End Property
    Public Property _ncantidad() As Decimal
        Get
            Return ncantidad
        End Get
        Set(ByVal Value As Decimal)
            ncantidad = Value
        End Set
    End Property
    Public Property _nfamupe() As Integer
        Get
            Return nfamupe
        End Get
        Set(ByVal Value As Integer)
            nfamupe = Value
        End Set
    End Property
    Public Property _nfamute() As Integer
        Get
            Return nfamute
        End Get
        Set(ByVal Value As Integer)
            nfamute = Value
        End Set
    End Property
    Public Property _nnfmupe() As Integer
        Get
            Return nnfmupe
        End Get
        Set(ByVal Value As Integer)
            nnfmupe = Value
        End Set
    End Property
    Public Property _nnfmute() As Integer
        Get
            Return nnfmute
        End Get
        Set(ByVal Value As Integer)
            nnfmute = Value
        End Set
    End Property
    Public Property _dfechaA() As Date
        Get
            Return dfechaA
        End Get
        Set(ByVal Value As Date)
            dfechaA = Value
        End Set
    End Property
    Public Property _cconcpa() As String
        Get
            Return cconcpa
        End Get
        Set(ByVal Value As String)
            cconcpa = Value
        End Set
    End Property
    Public Property _cconvta() As String
        Get
            Return cconvta
        End Get
        Set(ByVal Value As String)
            cconvta = Value
        End Set
    End Property
    Public Property _nfahope() As Integer
        Get
            Return nfahope
        End Get
        Set(ByVal Value As Integer)
            nfahope = Value
        End Set
    End Property
    Public Property _nfahote() As Integer
        Get
            Return nfahote
        End Get
        Set(ByVal Value As Integer)
            nfahote = Value
        End Set
    End Property
    Public Property _nnfhope() As Integer
        Get
            Return nnfhope
        End Get
        Set(ByVal Value As Integer)
            nnfhope = Value
        End Set
    End Property
    Public Property _nnfhote() As Integer
        Get
            Return nnfhote
        End Get
        Set(ByVal Value As Integer)
            nnfhote = Value
        End Set
    End Property

    Public Property _cmanfon() As String
        Get
            Return cmanfon
        End Get
        Set(ByVal Value As String)
            cmanfon = Value
        End Set
    End Property
    Public Property _cpuesto() As String
        Get
            Return cpuesto
        End Get
        Set(ByVal Value As String)
            cpuesto = Value
        End Set
    End Property
    Public Property _cjefe() As String
        Get
            Return cjefe
        End Get
        Set(ByVal Value As String)
            cjefe = Value
        End Set
    End Property
    Public Property _cpuestojefe() As String
        Get
            Return cpuestojefe
        End Get
        Set(ByVal Value As String)
            cpuestojefe = Value
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
    Public Property _cTipNeg() As String
        Get
            Return cTipNeg
        End Get
        Set(ByVal Value As String)
            cTipNeg = Value
        End Set
    End Property
    Public Property _dEvalua() As Date
        Get
            Return dEvalua
        End Get
        Set(ByVal Value As Date)
            dEvalua = Value
        End Set
    End Property

    Public Property _nIngCony() As Double
        Get
            Return nIngCony
        End Get
        Set(ByVal Value As Double)
            nIngCony = Value
        End Set
    End Property

    Public Property _nIngFami() As Double
        Get
            Return nIngFami
        End Get
        Set(ByVal Value As Double)
            nIngFami = Value
        End Set
    End Property

    Public Property _nIngSSPC() As Double
        Get
            Return nIngSSPC
        End Get
        Set(ByVal Value As Double)
            nIngSSPC = Value
        End Set
    End Property
    Public Property _nIngReme() As Double
        Get
            Return nIngReme
        End Get
        Set(ByVal Value As Double)
            nIngReme = Value
        End Set
    End Property
    Public Property _nGasCasa() As Double
        Get
            Return nGasCasa
        End Get
        Set(ByVal Value As Double)
            nGasCasa = Value
        End Set
    End Property
    Public Property _nGasAlim() As Double
        Get
            Return nGasAlim
        End Get
        Set(ByVal Value As Double)
            nGasAlim = Value
        End Set
    End Property
    Public Property _nGasAlte() As Double
        Get
            Return nGasAlte
        End Get
        Set(ByVal Value As Double)
            nGasAlte = Value
        End Set
    End Property
    Public Property _nGasEduc() As Double
        Get
            Return nGasEduc
        End Get
        Set(ByVal Value As Double)
            nGasEduc = Value
        End Set
    End Property
    Public Property _ngasTran() As Double
        Get
            Return ngasTran
        End Get
        Set(ByVal Value As Double)
            ngasTran = Value
        End Set
    End Property
    Public Property _nGasSalu() As Double
        Get
            Return nGasSalu
        End Get
        Set(ByVal Value As Double)
            nGasSalu = Value
        End Set
    End Property
    Public Property _nGasRopa() As Double
        Get
            Return nGasRopa
        End Get
        Set(ByVal Value As Double)
            nGasRopa = Value
        End Set
    End Property
    Public Property _nGasPres() As Double
        Get
            Return nGasPres
        End Get
        Set(ByVal Value As Double)
            nGasPres = Value
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
    Public Property _dfecmod() As Date
        Get
            Return dFecMod
        End Get
        Set(ByVal Value As Date)
            dFecMod = Value
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

    Public Property _ccoduni() As String
        Get
            Return ccoduni
        End Get
        Set(ByVal Value As String)
            ccoduni = Value
        End Set
    End Property
    Public Property _cTiprel() As String
        Get
            Return cTiprel
        End Get
        Set(ByVal Value As String)
            cTiprel = Value
        End Set
    End Property
    Public Property _cNomfue() As String
        Get
            Return cNomFue
        End Get
        Set(ByVal Value As String)
            cNomFue = Value
        End Set
    End Property
    Public Property _cTidofu() As String
        Get
            Return cTiDofu
        End Get
        Set(ByVal Value As String)
            cTiDofu = Value
        End Set
    End Property
    Public Property _cNudofu() As String
        Get
            Return cNuDoFu
        End Get
        Set(ByVal Value As String)
            cNuDoFu = Value
        End Set
    End Property
    Public Property _dIniFue() As Date
        Get
            Return dIniFue
        End Get
        Set(ByVal Value As Date)
            dIniFue = Value
        End Set
    End Property
    Public Property _cCodfue() As String
        Get
            Return cCodfue
        End Get
        Set(ByVal Value As String)
            cCodfue = Value
        End Set
    End Property
    Public Property _nEmplea() As Double
        Get
            Return nEmplea
        End Get
        Set(ByVal Value As Double)
            nEmplea = Value
        End Set
    End Property
    Public Property _cUbiFue() As String
        Get
            Return cUbiFue
        End Get
        Set(ByVal Value As String)
            cUbiFue = Value
        End Set
    End Property
    Public Property _cDirFue() As String
        Get
            Return cDirFue
        End Get
        Set(ByVal Value As String)
            cDirFue = Value
        End Set
    End Property
    Public Property _cTelFue() As String
        Get
            Return cTelFue
        End Get
        Set(ByVal Value As String)
            cTelFue = Value
        End Set
    End Property
    Public Property _cConFue() As String
        Get
            Return cConFue
        End Get
        Set(ByVal Value As String)
            cConFue = Value
        End Set
    End Property
    Public Property _cSecEco() As String
        Get
            Return cSecEco
        End Get
        Set(ByVal Value As String)
            cSecEco = Value
        End Set
    End Property
    Public Property _cCodAct() As String
        Get
            Return cCodAct
        End Get
        Set(ByVal Value As String)
            cCodAct = Value
        End Set
    End Property
    Public Property _cAnoUbi() As Date
        Get
            Return cAnoUbi
        End Get
        Set(ByVal Value As Date)
            cAnoUbi = Value
        End Set
    End Property
    Public Property _nSueldo() As Double
        Get
            Return nSueldo
        End Get
        Set(ByVal Value As Double)
            nSueldo = Value
        End Set
    End Property

    Public Property _dBalanc() As Date
        Get
            Return dBalanc
        End Get
        Set(ByVal Value As Date)
            dBalanc = Value
        End Set
    End Property
    Public Property _nActDis() As Double
        Get
            Return nActDis
        End Get
        Set(ByVal Value As Double)
            nActDis = Value
        End Set
    End Property
    Public Property _nCtaCob() As Double
        Get
            Return nSueldo
        End Get
        Set(ByVal Value As Double)
            nCtaCob = Value
        End Set
    End Property
    Public Property _nInvent() As Double
        Get
            Return nInvent
        End Get
        Set(ByVal Value As Double)
            nInvent = Value
        End Set
    End Property
    Public Property _nActFij() As Double
        Get
            Return nActFij
        End Get
        Set(ByVal Value As Double)
            nActFij = Value
        End Set
    End Property
    Public Property _nProvee() As Double
        Get
            Return nProvee
        End Get
        Set(ByVal Value As Double)
            nProvee = Value
        End Set
    End Property
    Public Property _nOtrPre() As Double
        Get
            Return nOtrPre
        End Get
        Set(ByVal Value As Double)
            nOtrPre = Value
        End Set
    End Property
    Public Property _nCreIns() As Double
        Get
            Return nCreIns
        End Get
        Set(ByVal Value As Double)
            nCreIns = Value
        End Set
    End Property
    Public Property _nVentas() As Double
        Get
            Return nVentas
        End Get
        Set(ByVal Value As Double)
            nVentas = Value
        End Set
    End Property
    Public Property _nRecupe() As Double
        Get
            Return nRecupe
        End Get
        Set(ByVal Value As Double)
            nRecupe = Value
        End Set
    End Property
    Public Property _nMercad() As Double
        Get
            Return nMercad
        End Get
        Set(ByVal Value As Double)
            nMercad = Value
        End Set
    End Property
    Public Property _nOtrEgr() As Double
        Get
            Return nOtrEgr
        End Get
        Set(ByVal Value As Double)
            nOtrEgr = Value
        End Set
    End Property
    Public Property _nPagPres() As Double
        Get
            Return nPagPres
        End Get
        Set(ByVal Value As Double)
            nPagPres = Value
        End Set
    End Property
    Public Property _nOtrIng() As Double
        Get
            Return nOtrIng
        End Get
        Set(ByVal Value As Double)
            nOtrIng = Value
        End Set
    End Property
    Public Property _nImpues() As Double
        Get
            Return nImpues
        End Get
        Set(ByVal Value As Double)
            nImpues = Value
        End Set
    End Property
    Public Property _nImprev() As Double
        Get
            Return nImprev
        End Get
        Set(ByVal Value As Double)
            nImprev = Value
        End Set
    End Property
    Public Property _nOtrAct() As Double
        Get
            Return nOtrAct
        End Get
        Set(ByVal Value As Double)
            nOtrAct = Value
        End Set
    End Property

    Public Property _nmarseg() As Double
        Get
            Return nmarseg
        End Get
        Set(ByVal Value As Double)
            nmarseg = Value
        End Set
    End Property
    Private ndinefe As Double
    Public Property _ndinefe() As Double
        Get
            Return ndinefe
        End Get
        Set(ByVal Value As Double)
            ndinefe = Value
        End Set
    End Property
    Private ndinban As Double
    Public Property _ndinban() As Double
        Get
            Return ndinban
        End Get
        Set(ByVal Value As Double)
            ndinban = Value
        End Set
    End Property
    Private nbienesinm As Double
    Public Property _nbienesinm() As Double
        Get
            Return nbienesinm
        End Get
        Set(ByVal Value As Double)
            nbienesinm = Value
        End Set
    End Property
    Private nbienesens As Double
    Public Property _nbienesens() As Double
        Get
            Return nbienesens
        End Get
        Set(ByVal Value As Double)
            nbienesens = Value
        End Set
    End Property
    Private nvehiculos As Double
    Public Property _nvehiculos() As Double
        Get
            Return nvehiculos
        End Get
        Set(ByVal Value As Double)
            nvehiculos = Value
        End Set
    End Property
    Private nganado As Double
    Public Property _nganado() As Double
        Get
            Return nganado
        End Get
        Set(ByVal Value As Double)
            nganado = Value
        End Set
    End Property
    Private notrosbienes As Double
    Public Property _notrosbienes() As Double
        Get
            Return notrosbienes
        End Get
        Set(ByVal Value As Double)
            notrosbienes = Value
        End Set
    End Property
    Private noblbancos As Double
    Public Property _noblbancos() As Double
        Get
            Return noblbancos
        End Get
        Set(ByVal Value As Double)
            noblbancos = Value
        End Set
    End Property
    Private noblbens As Double
    Public Property _noblens() As Double
        Get
            Return noblbens
        End Get
        Set(ByVal Value As Double)
            noblbens = Value
        End Set
    End Property
    Private ntienyalm As Double
    Public Property _ntienyalm() As Double
        Get
            Return ntienyalm
        End Get
        Set(ByVal Value As Double)
            ntienyalm = Value
        End Set
    End Property
    Private noblgasfam As Double
    Public Property _noblgasfam() As Double
        Get
            Return noblgasfam
        End Get
        Set(ByVal Value As Double)
            noblgasfam = Value
        End Set
    End Property
    Private notrosObl As Double
    Public Property _notrosObl() As Double
        Get
            Return notrosObl
        End Get
        Set(ByVal Value As Double)
            notrosObl = Value
        End Set
    End Property

    Public Property _cgiro() As String
        Get
            Return cgiro
        End Get
        Set(ByVal Value As String)
            cgiro = Value
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

    Public Function ActualizaClidFami() As Integer

        Dim lnRetorno As Integer

        Try
            Dim entidadclidfami As New SIM.El.CLIDFAMI
            Dim eClidfami As New SIM.BL.cCLIDFAMI


            entidadclidfami.ccodcli = Me.ccodcli
            entidadclidfami.cCodusu = Me.cCodusu
            entidadclidfami.dEvalua = Me.dEvalua
            entidadclidfami.dFecMod = Me.dFecMod
            entidadclidfami.nGasAlim = Me.nGasAlim
            entidadclidfami.nGasAlte = Me.nGasAlte
            entidadclidfami.nGasCasa = Me.nGasCasa
            entidadclidfami.nGasEduc = Me.nGasEduc
            entidadclidfami.nGasPres = Me.nGasPres
            entidadclidfami.nGasRopa = Me.nGasRopa
            entidadclidfami.nGasSalu = Me.nGasSalu
            entidadclidfami.ngasTran = Me.ngasTran
            entidadclidfami.nIngCony = Me.nIngCony
            entidadclidfami.nIngFami = Me.nIngFami
            entidadclidfami.nIngReme = Me.nIngReme
            entidadclidfami.nIngSSPC = Me.nIngSSPC
            entidadclidfami.cCodUni = Me.ccoduni

            If Me.llBandera Then   'Nuevo
                eClidfami.AgregrarCLIDFAMI(entidadclidfami)
            Else                'Modificacion
                eClidfami.ActualizarCLIDFAMI(entidadclidfami)
            End If

            lnRetorno = 1

            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0

            Return lnRetorno
        End Try

    End Function


    Public Function ElminaClidFami() As Integer
        Dim lnRetorno As Integer

        Try

            Dim entidadclidfami As New SIM.El.CLIDFAMI
            Dim eClidfami As New SIM.BL.cCLIDFAMI

            eClidfami.EliminarCLIDFAMI(Me.ccodcli, Me.ccoduni)

            lnRetorno = 1

            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0

            Return lnRetorno
        End Try

    End Function


    Public Function ActualizaClidifaDep() As Integer

        Dim lcResult As Integer


        Try


            Dim entidadclidfin As New SIM.El.clidfin
            Dim eClidfin As New SIM.BL.cClidfin


            entidadclidfin.ccodcli = Me.ccodcli
            entidadclidfin.ctiprel = Me.cTiprel
            entidadclidfin.ccodfue = Me.cCodfue

            entidadclidfin.cnomfue = Me.cNomFue
            entidadclidfin.ctidofu = Me.cTiDofu
            entidadclidfin.cnudofu = Me.cNuDoFu
            entidadclidfin.dinifue = Me.dIniFue
            entidadclidfin.nemplea = Me.nEmplea
            entidadclidfin.cubifue = Me.cUbiFue
            entidadclidfin.cdirfue = Me.cDirFue
            entidadclidfin.cconfue = Me.cConFue
            entidadclidfin.csececo = Me.cSecEco
            entidadclidfin.ccodact = Me.cCodAct
            entidadclidfin.canoubi = Me.cAnoUbi
            entidadclidfin.ccodusu = Me.cCodusu
            entidadclidfin.dfecmod = Today()
            entidadclidfin.nsueldo = Me.nSueldo
            entidadclidfin.ctelfue = Me.cTelFue

            entidadclidfin.cmanfon = Me.cmanfon
            entidadclidfin.cpuesto = Me.cpuesto
            entidadclidfin.cjefe = Me.cjefe
            entidadclidfin.cpuestojefe = Me.cpuestojefe
            entidadclidfin.ctipneg = Me.cTipNeg
            entidadclidfin.dfechaA = Me.dfechaA
            entidadclidfin.latitud = Me.Latitud
            entidadclidfin.longitud = Me.Longitud

            If Me.llBandera = True Then  'Nuevo
                eClidfin.Agregar(entidadclidfin)
            Else        'Modifica
                eClidfin.ActualizarClidfin(entidadclidfin)
            End If

            lcResult = 1

            Return lcResult

        Catch ex As Exception
            lcResult = 0
            Return lcResult
        End Try


    End Function

    Public Function EliminaClidfinDep() As Integer
        Dim lcResult As Integer

        Try
            Dim entidadclidfin As New SIM.El.clidfin
            Dim eClidfin As New SIM.BL.cClidfin


            entidadclidfin.ccodcli = Me.ccodcli
            entidadclidfin.ctiprel = Me.cTiprel
            entidadclidfin.ccodfue = Me.cCodfue

            eClidfin.EliminarClidfin(Me.ccodcli, Me.cTiprel, Me.cCodfue)

            lcResult = 1
            Return lcResult

        Catch ex As Exception
            lcResult = 0
            Return lcResult
        End Try
    End Function

    Public Function ActualizaClidfinInDep() As Integer
        Dim lcResult As Integer = 1

        Try
            Dim entidadclidfin As New SIM.El.clidfin
            Dim eClidfin As New SIM.BL.cClidfin


            entidadclidfin.ccodcli = Me.ccodcli
            entidadclidfin.ctiprel = Me.cTiprel
            entidadclidfin.ccodfue = Me.cCodfue


            entidadclidfin.cnomfue = Me.cNomFue
            entidadclidfin.ctidofu = Me.cTiDofu
            entidadclidfin.cnudofu = Me.cNuDoFu
            entidadclidfin.dinifue = Me.dIniFue
            entidadclidfin.nemplea = Me.nEmplea
            entidadclidfin.cubifue = Me.cUbiFue
            entidadclidfin.cdirfue = Me.cDirFue
            entidadclidfin.cdirterreno = Me.cdirterreno
            entidadclidfin.cconfue = Me.cConFue
            entidadclidfin.csececo = Me.cSecEco
            entidadclidfin.ccodact = Me.cCodAct
            entidadclidfin.canoubi = Me.cAnoUbi
            entidadclidfin.ccodusu = Me.cCodusu
            entidadclidfin.dfecmod = Today()
            entidadclidfin.nsueldo = 0
            entidadclidfin.ctelfue = Me.cTelFue
            entidadclidfin.ctipneg = Me.cTipNeg

            entidadclidfin.dfechaA = Me.dfechaA
            entidadclidfin.cconcpa = Me.cconcpa
            entidadclidfin.cconvta = Me.cconvta
            entidadclidfin.nfahope = Me.nfahope
            entidadclidfin.nfahote = Me.nfahote
            entidadclidfin.nnfhope = Me.nnfhope
            entidadclidfin.nnfhote = Me.nnfhote

            entidadclidfin.cpara = Me.cpara
            entidadclidfin.nmetros = Me.nmetros
            entidadclidfin.nvaras = Me.nvaras
            entidadclidfin.cmedida = Me.cmedida
            entidadclidfin.ncantidad = Me.ncantidad
            entidadclidfin.nfamupe = Me.nfamupe
            entidadclidfin.nfamute = Me.nfamute
            entidadclidfin.nnfmupe = Me.nnfmupe
            entidadclidfin.nnfmute = Me.nnfmute
            entidadclidfin.cgiro = Me.cgiro
            entidadclidfin.latitud = Me.Latitud
            entidadclidfin.longitud = Me.Longitud


            If Me.llBandera = True Then  'Nuevo
                eClidfin.Agregar(entidadclidfin)
            Else        'Modifica
                eClidfin.ActualizarClidfin(entidadclidfin)
            End If


            Return lcResult

        Catch ex As Exception
            lcResult = 0

            Return lcResult
        End Try

    End Function



    Public Function ActualizaClidBal() As Integer
        Dim lnRetorno As Integer = 1

        Try

            Dim entidadclidbal As New SIM.El.clidbal
            Dim eClidbal As New SIM.BL.cClidbal

            entidadclidbal.ccodcli = Me.ccodcli
            entidadclidbal.ccodfue = Me.cCodfue
            entidadclidbal.devalua = Me.dEvalua
            entidadclidbal.dbalanc = Me.dEvalua
            entidadclidbal.nactdis = Me.nActDis
            entidadclidbal.nctacob = Me.nCtaCob
            entidadclidbal.ninvent = Me.nInvent
            entidadclidbal.nactfij = Me.nActFij
            entidadclidbal.nprovee = Me.nProvee
            entidadclidbal.notrpre = Me.nOtrPre
            entidadclidbal.ncreins = Me.nCreIns
            entidadclidbal.nventas = Me.nVentas
            entidadclidbal.nrecupe = Me.nRecupe
            entidadclidbal.nmercad = Me.nMercad
            entidadclidbal.notregr = Me.nOtrEgr
            entidadclidbal.npagpres = Me.nPagPres
            entidadclidbal.ccodusu = Me.cCodusu
            entidadclidbal.dfecmod = Today()
            entidadclidbal.notring = Me.nOtrIng
            entidadclidbal.nimpues = Me.nImpues
            entidadclidbal.nimprev = Me.nImprev
            entidadclidbal.notract = Me.nOtrAct
            entidadclidbal.cflag = ""

            eClidbal.Agrega(entidadclidbal)

            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function

    Public Function modificaClidBal() As Integer
        Dim lnRetorno As Integer = 1

        Try

            Dim entidadclidbal As New SIM.El.clidbal
            Dim eClidbal As New SIM.BL.cClidbal

            entidadclidbal.ccodcli = Me.ccodcli
            entidadclidbal.ccodfue = Me.cCodfue
            entidadclidbal.devalua = Me.dEvalua
            entidadclidbal.dbalanc = Me.dEvalua
            entidadclidbal.nactdis = Me.nActDis
            entidadclidbal.nctacob = Me.nCtaCob
            entidadclidbal.ninvent = Me.nInvent
            entidadclidbal.nactfij = Me.nActFij
            entidadclidbal.nprovee = Me.nProvee
            entidadclidbal.notrpre = Me.nOtrPre
            entidadclidbal.ncreins = Me.nCreIns
            entidadclidbal.nventas = Me.nVentas
            entidadclidbal.nrecupe = Me.nRecupe
            entidadclidbal.nmercad = Me.nMercad
            entidadclidbal.notregr = Me.nOtrEgr
            entidadclidbal.npagpres = Me.nPagPres
            entidadclidbal.ccodusu = Me.cCodusu
            entidadclidbal.dfecmod = Today()
            entidadclidbal.notring = Me.nOtrIng
            entidadclidbal.nimpues = Me.nImpues
            entidadclidbal.nimprev = Me.nImprev
            entidadclidbal.notract = Me.nOtrAct
            entidadclidbal.nmarseg = Me.nmarseg

            eClidbal.ActualizarClidbal(entidadclidbal)

            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function

#End Region

End Class
