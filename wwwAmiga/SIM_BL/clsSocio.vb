Public Class clsSocio
    Private ccodcli As String
    Private cnrohij As String


    Private cnomhij As String
    Private dfecnac As DateTime
    Private cCodgra As String
    Private lcarnet As Boolean

    Private ccodusu As String

    Private cdejaesc As String
    Public Property _cdejaesc() As String
        Get
            Return cdejaesc
        End Get
        Set(ByVal Value As String)
            cdejaesc = Value
        End Set
    End Property

    Private nprestamo As Integer
    Public Property _nprestamo() As Integer
        Get
            Return nprestamo
        End Get
        Set(ByVal Value As Integer)
            nprestamo = Value
        End Set
    End Property

    Private ninvertir1 As Integer
    Public Property _ninvertir1() As Integer
        Get
            Return ninvertir1
        End Get
        Set(ByVal Value As Integer)
            ninvertir1 = Value
        End Set
    End Property
    Private ninvertir2 As Integer
    Public Property _ninvertir2() As Integer
        Get
            Return ninvertir2
        End Get
        Set(ByVal Value As Integer)
            ninvertir2 = Value
        End Set
    End Property

    Private ninvertir3 As Integer
    Public Property _ninvertir3() As Integer
        Get
            Return ninvertir3
        End Get
        Set(ByVal Value As Integer)
            ninvertir3 = Value
        End Set
    End Property

    Private ninvertir4 As Integer
    Public Property _ninvertir4() As Integer
        Get
            Return ninvertir4
        End Get
        Set(ByVal Value As Integer)
            ninvertir4 = Value
        End Set
    End Property

    Private ninvertir5 As Integer
    Public Property _ninvertir5() As Integer
        Get
            Return ninvertir5
        End Get
        Set(ByVal Value As Integer)
            ninvertir5 = Value
        End Set
    End Property

    Private ninvertir6 As Integer
    Public Property _ninvertir6() As Integer
        Get
            Return ninvertir6
        End Get
        Set(ByVal Value As Integer)
            ninvertir6 = Value
        End Set
    End Property

    Private cinvertir As String
    Public Property _cinvertir() As String
        Get
            Return cinvertir
        End Get
        Set(ByVal Value As String)
            cinvertir = Value
        End Set
    End Property

    Private nuso1 As Integer
    Public Property _nuso1() As Integer
        Get
            Return nuso1
        End Get
        Set(ByVal Value As Integer)
            nuso1 = Value
        End Set
    End Property

    Private nuso2 As Integer
    Public Property _nuso2() As Integer
        Get
            Return nuso2
        End Get
        Set(ByVal Value As Integer)
            nuso2 = Value
        End Set
    End Property

    Private nuso3 As Integer
    Public Property _nuso3() As Integer
        Get
            Return nuso3
        End Get
        Set(ByVal Value As Integer)
            nuso3 = Value
        End Set
    End Property

    Private nuso4 As Integer
    Public Property _nuso4() As Integer
        Get
            Return nuso4
        End Get
        Set(ByVal Value As Integer)
            nuso4 = Value
        End Set
    End Property

    Private nuso5 As Integer
    Public Property _nuso5() As Integer
        Get
            Return nuso5
        End Get
        Set(ByVal Value As Integer)
            nuso5 = Value
        End Set
    End Property

    Private nhogar1 As Integer
    Public Property _nhogar1() As Integer
        Get
            Return nhogar1
        End Get
        Set(ByVal Value As Integer)
            nhogar1 = Value
        End Set
    End Property

    Private nhogar2 As Integer
    Public Property _nhogar2() As Integer
        Get
            Return nhogar2
        End Get
        Set(ByVal Value As Integer)
            nhogar2 = Value
        End Set
    End Property

    Private nhogar3 As Integer
    Public Property _nhogar3() As Integer
        Get
            Return nhogar3
        End Get
        Set(ByVal Value As Integer)
            nhogar3 = Value
        End Set
    End Property

    Private nhogar4 As Integer
    Public Property _nhogar4() As Integer
        Get
            Return nhogar4
        End Get
        Set(ByVal Value As Integer)
            nhogar4 = Value
        End Set
    End Property

    Private nhogar5 As Integer
    Public Property _nhogar5() As Integer
        Get
            Return nhogar5
        End Get
        Set(ByVal Value As Integer)
            nhogar5 = Value
        End Set
    End Property

    Private nhogar6 As Integer
    Public Property _nhogar6() As Integer
        Get
            Return nhogar6
        End Get
        Set(ByVal Value As Integer)
            nhogar6 = Value
        End Set
    End Property

    Private nhogarxq1 As Integer
    Public Property _nhogarxq1() As Integer
        Get
            Return nhogarxq1
        End Get
        Set(ByVal Value As Integer)
            nhogarxq1 = Value
        End Set
    End Property

    Private nhogarxq2 As Integer
    Public Property _nhogarxq2() As Integer
        Get
            Return nhogarxq2
        End Get
        Set(ByVal Value As Integer)
            nhogarxq2 = Value
        End Set
    End Property

    Private nhogarxq3 As Integer
    Public Property _nhogarxq3() As Integer
        Get
            Return nhogarxq3
        End Get
        Set(ByVal Value As Integer)
            nhogarxq3 = Value
        End Set
    End Property

    Private nhogarxq4 As Integer
    Public Property _nhogarxq4() As Integer
        Get
            Return nhogarxq4
        End Get
        Set(ByVal Value As Integer)
            nhogarxq4 = Value
        End Set
    End Property

    Private nhogarxq5 As Integer
    Public Property _nhogarxq5() As Integer
        Get
            Return nhogarxq5
        End Get
        Set(ByVal Value As Integer)
            nhogarxq5 = Value
        End Set
    End Property

    Private chogarxq As String
    Public Property _chogarxq() As String
        Get
            Return chogarxq
        End Get
        Set(ByVal Value As String)
            chogarxq = Value
        End Set
    End Property

    Private nsiaumento1 As Integer
    Public Property _nsiaumento1() As Integer
        Get
            Return nsiaumento1
        End Get
        Set(ByVal Value As Integer)
            nsiaumento1 = Value
        End Set
    End Property

    Private nsiaumento2 As Integer
    Public Property _nsiaumento2() As Integer
        Get
            Return nsiaumento2
        End Get
        Set(ByVal Value As Integer)
            nsiaumento2 = Value
        End Set
    End Property

    Private nsiaumento3 As Integer
    Public Property _nsiaumento3() As Integer
        Get
            Return nsiaumento3
        End Get
        Set(ByVal Value As Integer)
            nsiaumento3 = Value
        End Set
    End Property

    Private nsiaumento4 As Integer
    Public Property _nsiaumento4() As Integer
        Get
            Return nsiaumento4
        End Get
        Set(ByVal Value As Integer)
            nsiaumento4 = Value
        End Set
    End Property

    Private nsiaumento5 As Integer
    Public Property _nsiaumento5() As Integer
        Get
            Return nsiaumento5
        End Get
        Set(ByVal Value As Integer)
            nsiaumento5 = Value
        End Set
    End Property

    Private nenseres As Integer
    Public Property _nenseres() As Integer
        Get
            Return nenseres
        End Get
        Set(ByVal Value As Integer)
            nenseres = Value
        End Set
    End Property

    Private nsicual1 As Integer
    Public Property _nsicual1() As Integer
        Get
            Return nsicual1
        End Get
        Set(ByVal Value As Integer)
            nsicual1 = Value
        End Set
    End Property

    Private nsicual2 As Integer
    Public Property _nsicual2() As Integer
        Get
            Return nsicual2
        End Get
        Set(ByVal Value As Integer)
            nsicual2 = Value
        End Set
    End Property
    Private nsicual3 As Integer
    Public Property _nsicual3() As Integer
        Get
            Return nsicual3
        End Get
        Set(ByVal Value As Integer)
            nsicual3 = Value
        End Set
    End Property
    Private nsicual4 As Integer
    Public Property _nsicual4() As Integer
        Get
            Return nsicual4
        End Get
        Set(ByVal Value As Integer)
            nsicual4 = Value
        End Set
    End Property
    Private nsicual5 As Integer
    Public Property _nsicual5() As Integer
        Get
            Return nsicual5
        End Get
        Set(ByVal Value As Integer)
            nsicual5 = Value
        End Set
    End Property
    Private nsicual6 As Integer
    Public Property _nsicual6() As Integer
        Get
            Return nsicual6
        End Get
        Set(ByVal Value As Integer)
            nsicual6 = Value
        End Set
    End Property
    Private nsicual7 As Integer
    Public Property _nsicual7() As Integer
        Get
            Return nsicual7
        End Get
        Set(ByVal Value As Integer)
            nsicual7 = Value
        End Set
    End Property
    Private csicual As String
    Public Property _csicual() As String
        Get
            Return csicual
        End Get
        Set(ByVal Value As String)
            csicual = Value
        End Set
    End Property

    Private npropia As Integer
    Public Property _npropia() As Integer
        Get
            Return npropia
        End Get
        Set(ByVal Value As Integer)
            npropia = Value
        End Set
    End Property
    Private nmejoras As Integer
    Public Property _nmejoras() As Integer
        Get
            Return nmejoras
        End Get
        Set(ByVal Value As Integer)
            nmejoras = Value
        End Set
    End Property

    Private nsimejoras1 As Integer
    Public Property _nsimejoras1() As Integer
        Get
            Return nsimejoras1
        End Get
        Set(ByVal Value As Integer)
            nsimejoras1 = Value
        End Set
    End Property

    Private nsimejoras2 As Integer
    Public Property _nsimejoras2() As Integer
        Get
            Return nsimejoras2
        End Get
        Set(ByVal Value As Integer)
            nsimejoras2 = Value
        End Set
    End Property

    Private nsimejoras3 As Integer
    Public Property _nsimejoras3() As Integer
        Get
            Return nsimejoras3
        End Get
        Set(ByVal Value As Integer)
            nsimejoras3 = Value
        End Set
    End Property
    Private nsimejoras4 As Integer
    Public Property _nsimejoras4() As Integer
        Get
            Return nsimejoras4
        End Get
        Set(ByVal Value As Integer)
            nsimejoras4 = Value
        End Set
    End Property
    Private nsimejoras5 As Integer
    Public Property _nsimejoras5() As Integer
        Get
            Return nsimejoras5
        End Get
        Set(ByVal Value As Integer)
            nsimejoras5 = Value
        End Set
    End Property
    Private nsimejoras6 As Integer
    Public Property _nsimejoras6() As Integer
        Get
            Return nsimejoras6
        End Get
        Set(ByVal Value As Integer)
            nsimejoras6 = Value
        End Set
    End Property
    Private nsimejoras7 As Integer
    Public Property _nsimejoras7() As Integer
        Get
            Return nsimejoras7
        End Get
        Set(ByVal Value As Integer)
            nsimejoras7 = Value
        End Set
    End Property
    Private nsimejoras8 As Integer
    Public Property _nsimejoras8() As Integer
        Get
            Return nsimejoras8
        End Get
        Set(ByVal Value As Integer)
            nsimejoras8 = Value
        End Set
    End Property
    Private csimejoras As String
    Public Property _csimejoras() As String
        Get
            Return csimejoras
        End Get
        Set(ByVal Value As String)
            csimejoras = Value
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

    Public Property _cnrohij() As String
        Get
            Return cnrohij
        End Get
        Set(ByVal Value As String)
            cnrohij = Value
        End Set
    End Property

    Private llBandera As Boolean
    Public Property _llBandera() As Boolean
        Get
            Return llBandera
        End Get
        Set(ByVal Value As Boolean)
            llBandera = Value
        End Set
    End Property

    Public Property _cnomhij() As String
        Get
            Return cnomhij
        End Get
        Set(ByVal Value As String)
            cnomhij = Value
        End Set
    End Property

    Public Property _dfecnac() As DateTime
        Get
            Return dfecnac
        End Get
        Set(ByVal Value As DateTime)
            dfecnac = Value
        End Set
    End Property
    Public Property _ccodgra() As String
        Get
            Return cCodgra
        End Get
        Set(ByVal Value As String)
            cCodgra = Value
        End Set
    End Property

   

    Public Property _lcarnet() As Boolean
        Get
            Return lcarnet
        End Get
        Set(ByVal Value As Boolean)
            lcarnet = Value
        End Set
    End Property

    Public Property _ccodusu() As String
        Get
            Return ccodusu
        End Get
        Set(ByVal Value As String)
            ccodusu = Value
        End Set
    End Property

    Public Function GrabaHijos() As Integer
        Dim lnRetorno As Integer
        Dim entidadclimide As New SIM.El.climide
        Dim eClimide As New SIM.BL.cClimide

        Try
            entidadclimide.ccodcli = Me.ccodcli
            entidadclimide.cnrohij = Me.cnrohij
            entidadclimide.cnomhij = Me.cnomhij
            entidadclimide.dfecnac = Me.dfecnac
            entidadclimide.lcarnet = Me.lcarnet
            entidadclimide.ccodgra = Me.cCodgra
            entidadclimide.ccodusu = Me.ccodusu

            If Me.llBandera Then 'Nuevo
                eClimide.AgregarHijos(entidadclimide)
            Else 'Modificacion
                eClimide.ActualizarHijos(entidadclimide)
            End If


            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno

        End Try
    End Function

    Public Function GrabaSocioEconomico() As Integer
        Dim lnRetorno As Integer
        Dim entidadclimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        Try
            entidadclimide.ccodcli = Me.ccodcli
            entidadclimide.cdejaesc = Me.cdejaesc
            entidadclimide.nprestamo = Me.nprestamo
            entidadclimide.ninvertir1 = Me.ninvertir1
            entidadclimide.ninvertir2 = Me.ninvertir2
            entidadclimide.ninvertir3 = Me.ninvertir3
            entidadclimide.ninvertir4 = Me.ninvertir4
            entidadclimide.ninvertir5 = Me.ninvertir5
            entidadclimide.ninvertir6 = Me.ninvertir6

            entidadclimide.cinvertir = Me.cinvertir

            entidadclimide.nuso1 = Me.nuso1
            entidadclimide.nuso2 = Me.nuso2
            entidadclimide.nuso3 = Me.nuso3
            entidadclimide.nuso4 = Me.nuso4
            entidadclimide.nuso5 = Me.nuso5

            entidadclimide.nhogar1 = Me.nhogar1
            entidadclimide.nhogar2 = Me.nhogar2
            entidadclimide.nhogar3 = Me.nhogar3
            entidadclimide.nhogar4 = Me.nhogar4
            entidadclimide.nhogar5 = Me.nhogar5
            entidadclimide.nhogar6 = Me.nhogar6

            entidadclimide.nhogarxq1 = Me.nhogarxq1
            entidadclimide.nhogarxq2 = Me.nhogarxq2
            entidadclimide.nhogarxq3 = Me.nhogarxq3
            entidadclimide.nhogarxq4 = Me.nhogarxq4
            entidadclimide.nhogarxq5 = Me.nhogarxq5

            entidadclimide.chogarxq = Me.chogarxq

            entidadclimide.nsiaumento1 = Me.nsiaumento1
            entidadclimide.nsiaumento2 = Me.nsiaumento2
            entidadclimide.nsiaumento3 = Me.nsiaumento3
            entidadclimide.nsiaumento4 = Me.nsiaumento4
            entidadclimide.nsiaumento5 = Me.nsiaumento5

            entidadclimide.nenseres = Me.nenseres

            entidadclimide.nsicual1 = Me.nsicual1
            entidadclimide.nsicual2 = Me.nsicual2
            entidadclimide.nsicual3 = Me.nsicual3
            entidadclimide.nsicual4 = Me.nsicual4
            entidadclimide.nsicual5 = Me.nsicual5
            entidadclimide.nsicual6 = Me.nsicual6
            entidadclimide.nsicual7 = Me.nsicual7

            entidadclimide.csicual = Me.csicual
            entidadclimide.npropia = Me.npropia
            entidadclimide.nmejoras = Me.nmejoras

            entidadclimide.nsimejoras1 = Me.nsimejoras1
            entidadclimide.nsimejoras2 = Me.nsimejoras2
            entidadclimide.nsimejoras3 = Me.nsimejoras3
            entidadclimide.nsimejoras4 = Me.nsimejoras4
            entidadclimide.nsimejoras5 = Me.nsimejoras5
            entidadclimide.nsimejoras6 = Me.nsimejoras6
            entidadclimide.nsimejoras7 = Me.nsimejoras7
            entidadclimide.nsimejoras8 = Me.nsimejoras8

            entidadclimide.csimejoras = Me.csimejoras

            entidadclimide.ccodusu = Me.ccodusu

            If Me.llBandera Then 'Nuevo
                eClimide.AgregarEstudioSocio(entidadclimide)
            Else 'Modificacion
                eClimide.ActualizarEstudioSocio(entidadclimide)
            End If

            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try
    End Function


End Class
