Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Data.Common
Imports System.Data.DataRow
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System.IO
Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Linq.Queryable
Imports System.Collections.Generic
Imports System.Globalization

Public Class clsActivo
    Private moDataset As DataSet
    Private moDataAdapter As SqlDataAdapter
    Private Const msTabla As String = "ActTemp"
#Region "Propiedades"
    Private _cCodinv As String
    Public Property cCodinv() As String
        Get
            Return _cCodinv
        End Get
        Set(ByVal Value As String)
            _cCodinv = Value
        End Set
    End Property

    Private _ccodofi As String
    Public Property ccodofi() As String
        Get
            Return _ccodofi
        End Get
        Set(ByVal Value As String)
            _ccodofi = Value
        End Set
    End Property

    Private _ffondos As String
    Public Property ffondos() As String
        Get
            Return _ffondos
        End Get
        Set(ByVal value As String)
            _ffondos = value
        End Set
    End Property

    Private _cnrochq As String
    Public Property cnrochq() As String
        Get
            Return _cnrochq
        End Get
        Set(ByVal value As String)
            _cnrochq = value
        End Set
    End Property

    Private _cnumcom As String
    Public Property cnumcom() As String
        Get
            Return _cnumcom
        End Get
        Set(ByVal value As String)
            _cnumcom = value
        End Set
    End Property

    Private _ccodpro As String
    Public Property ccodpro() As String
        Get
            Return _ccodpro
        End Get
        Set(ByVal value As String)
            _ccodpro = value
        End Set
    End Property

    Private _cnumdoc As String
    Public Property cnumdoc() As String
        Get
            Return _cnumdoc
        End Get
        Set(ByVal value As String)
            _cnumdoc = value
        End Set
    End Property

    Private _dfecadq As Date
    Public Property dfecadq() As Date
        Get
            Return _dfecadq
        End Get
        Set(ByVal Value As Date)
            _dfecadq = Value
        End Set
    End Property

    Private _dfecbja As Date
    Public Property dfecbja() As Date
        Get
            Return _dfecbja
        End Get
        Set(ByVal value As Date)
            _dfecbja = value
        End Set
    End Property

    Private _ccodemp As String
    Public Property ccodemp() As String
        Get
            Return _ccodemp
        End Get
        Set(ByVal value As String)
            _ccodemp = value
        End Set
    End Property

    Private _ccodusu As String
    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal value As String)
            _ccodusu = value
        End Set
    End Property

    Private _nactdep As Integer
    Public Property nactdep() As Integer
        Get
            Return _nactdep
        End Get
        Set(ByVal value As Integer)
            _nactdep = value
        End Set
    End Property

    Private _ccodact As String
    Public Property ccodact() As String
        Get
            Return _ccodact
        End Get
        Set(ByVal Value As String)
            _ccodact = Value
        End Set
    End Property

    Private _ctipact As String
    Public Property ctipact() As String
        Get
            Return _ctipact
        End Get
        Set(ByVal Value As String)
            _ctipact = Value
        End Set
    End Property

    Private _cdesbien As String
    Public Property cdesbien() As String
        Get
            Return _cdesbien
        End Get
        Set(ByVal Value As String)
            _cdesbien = Value
        End Set
    End Property

    Private _nviduti As Integer
    Public Property nviduti() As Integer
        Get
            Return _nviduti
        End Get
        Set(ByVal Value As Integer)
            _nviduti = Value
        End Set
    End Property

    Private _nvalcpa As Double
    Public Property nvalcpa() As Double 
        Get
            Return _nvalcpa
        End Get
        Set(ByVal Value As Double)
            _nvalcpa = Value
        End Set
    End Property

    Private _nvalres As Decimal
    Public Property nvalres() As Double
        Get
            Return _nvalres
        End Get
        Set(ByVal Value As Double)
            _nvalres = Value
        End Set
    End Property

    Private _nvalno As Double
    Public Property nvalno() As Double
        Get
            Return _nvalno
        End Get
        Set(ByVal Value As Double)
            _nvalno = Value
        End Set
    End Property

    Private _ccodadq As String
    Public Property ccodadq() As String
        Get
            Return _ccodadq
        End Get
        Set(ByVal Value As String)
            _ccodadq = Value
        End Set
    End Property

    Private _cestbien As String
    Public Property cestbien() As String
        Get
            Return _cestbien
        End Get
        Set(ByVal Value As String)
            _cestbien = Value
        End Set
    End Property

    Private _ccodsec As String
    Public Property ccodsec() As String
        Get
            Return _ccodsec
        End Get
        Set(ByVal value As String)
            _ccodsec = value
        End Set
    End Property

    Private _ccodubi As String
    Public Property ccodubi() As String
        Get
            Return _ccodubi
        End Get
        Set(ByVal Value As String)
            _ccodubi = Value
        End Set
    End Property

    Private _cnumser As String
    Public Property cnumser() As String
        Get
            Return _cnumser
        End Get
        Set(ByVal Value As String)
            _cnumser = Value
        End Set
    End Property

    Private _cunidad As String
    Public Property cunidad() As String
        Get
            Return _cunidad
        End Get
        Set(ByVal Value As String)
            _cunidad = Value
        End Set
    End Property

    Private _dfecdep As Date
    Public Property dfecdep() As DateTime
        Get
            Return _dfecdep
        End Get
        Set(ByVal value As DateTime)
            _dfecdep = value
        End Set
    End Property
#End Region

    Public Function GrabarActivo() As Integer
        Dim i As Integer
        Dim cactivof As New SIM.EL.ActivoF
        Dim eactivof As New SIM.BL.cActivoF
        Try
            cactivof.ccodinv = Me.cCodinv
            cactivof.ccodofi = Me.ccodofi
            cactivof.ffondos = Me.ffondos
            cactivof.cnrochq = Me.cnrochq
            cactivof.cnumcom = Me.cnumcom
            cactivof.ccodpro = Me.ccodpro
            cactivof.cnumdoc = Me.cnumdoc
            cactivof.dfecadq = Me.dfecadq
            cactivof.dfecbja = Me.dfecbja
            cactivof.ccodemp = Me.ccodemp
            cactivof.ccodusu = Me.ccodusu
            cactivof.nactdep = Me.nactdep
            cactivof.ccodact = Me.ccodact
            cactivof.ctipact = Me.ctipact
            cactivof.cdesbien = Me.cdesbien
            cactivof.nviduti = Me.nviduti
            cactivof.nvalcpa = Me.nvalcpa
            cactivof.nvalres = Me.nvalres
            cactivof.nvalno = Me.nvalno
            cactivof.ccodadq = Me.ccodadq
            cactivof.cestbien = Me.cestbien
            cactivof.ccodsec = Me.ccodsec
            cactivof.ccodubi = Me.ccodubi
            cactivof.cnumser = Me.cnumser
            cactivof.cunidad = Me.cunidad
            cactivof.dfecdep = Me.dfecdep
            i = eactivof.Agregar(cactivof)
            Return i
        Catch ex As Exception
            i = 0
            Return i
        End Try
    End Function
    Public Function UpdateActivo() As Integer
        Dim i As Integer
        Dim cactivof As New SIM.EL.ActivoF
        Dim eactivof As New SIM.BL.cActivoF
        Try
            cactivof.ccodinv = Me.cCodinv
            cactivof.ccodofi = Me.ccodofi
            cactivof.ffondos = Me.ffondos
            cactivof.cnrochq = Me.cnrochq
            cactivof.cnumcom = Me.cnumcom
            cactivof.ccodpro = Me.ccodpro
            cactivof.cnumdoc = Me.cnumdoc
            cactivof.dfecadq = Me.dfecadq
            cactivof.dfecbja = Me.dfecbja
            cactivof.ccodemp = Me.ccodemp
            cactivof.ccodusu = Me.ccodusu
            cactivof.nactdep = Me.nactdep
            cactivof.ccodact = Me.ccodact
            cactivof.ctipact = Me.ctipact
            cactivof.cdesbien = Me.cdesbien
            cactivof.nviduti = Me.nviduti
            cactivof.nvalcpa = Me.nvalcpa
            cactivof.nvalres = Me.nvalres
            cactivof.nvalno = Me.nvalno
            cactivof.ccodadq = Me.ccodadq
            cactivof.cestbien = Me.cestbien
            cactivof.ccodsec = Me.ccodsec
            cactivof.ccodubi = Me.ccodubi
            cactivof.cnumser = Me.cnumser
            cactivof.cunidad = Me.cunidad
            'cactivof.dfecdep = Me.dfecdep

            i = eactivof.ActualizarActivoF(cactivof)
            Return i
        Catch ex As Exception
            i = 0
            Return i
        End Try
    End Function
    Public Function DataActivo(ByVal ldfecha As Date, ByVal ccodofi As String, ByVal ffondos As String, ByVal ndepre As Integer, ByVal ccodadq As String, ByVal ccodact As String) As DataSet
        Dim ds As New DataSet
        Dim eactivof As New cActivoF
        ds = eactivof.DatasetActivoFijo(ccodofi, ffondos, ndepre, ccodadq, ccodact, ldfecha)
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim ccodigo As String
        Dim pre As String
        Dim etabttab As New cTabttab
        Dim ccodinv As String
        Dim ndepanual As Double
        Dim ndepmensual As Double
        Dim nvalcpa As Double
        Dim nviduti As Integer
        Dim nvalno As Double
        Dim ndepmensualno As Double
        Dim ndepmensualde As Double
        Dim ldfecadq As Date
        Dim ldfecbja As Date
        Dim ldfecdep As Date
        Dim cactdep As Integer
        Dim lnmeses As Integer
        Dim ndepacum As Double
        Dim nmestotdep As Double
        Dim ndiferencia As Double
        Dim lccodact As String
        Dim lccodinv As String
        Dim lccodofi As String
        Dim lntotalmeses As String
        For Each fila In ds.Tables(0).Rows
            ccodigo = Left(ds.Tables(0).Rows(i)("ccodinv"), 2)
            nvalcpa = ds.Tables(0).Rows(i)("nvalcpa")
            nviduti = ds.Tables(0).Rows(i)("nviduti")
            lccodact = ds.Tables(0).Rows(i)("cCodact")
            nmestotdep = ds.Tables(0).Rows(i)("nmestotdep")
            lntotalmeses = nviduti * 12
            lccodofi = ds.Tables(0).Rows(i)("cCodofi")
            If lccodact.Trim = "40" Then
                ds.Tables(0).Rows(i)("ctipo") = "2"
            Else
                ds.Tables(0).Rows(i)("ctipo") = "1"
            End If

            'ldfecadq = ds.Tables(0).Rows(i)("dfecadq")
            If IsDBNull(ds.Tables(0).Rows(i)("dfecdep")) Then
                ds.Tables(0).Rows(i)("dfecdep") = #1/1/1980#
            End If
            ldfecdep = ds.Tables(0).Rows(i)("dfecdep")


            'Meses depreciados
            If ldfecadq.Day > 15 Then
                'lnmeses = DateDiff(DateInterval.Month, ldfecadq, ldfecha)
                lnmeses = DateDiff(DateInterval.Month, ldfecdep, ldfecha)
            Else
                'lnmeses = DateDiff(DateInterval.Month, ldfecadq, ldfecha)
                lnmeses = DateDiff(DateInterval.Month, ldfecdep, ldfecha)
                lnmeses += 1
            End If

            If lnmeses > lntotalmeses Then
                lnmeses = lntotalmeses
            End If

            nvalno = ds.Tables(0).Rows(i)("nvalno")
            ndepanual = utilNumeros.Redondear((nvalcpa) / nviduti, 2)
            ndepmensual = utilNumeros.Redondear((ndepanual) / 12, 2)
            ndepmensualno = utilNumeros.Redondear((nvalno / nviduti) / 12, 2)
            ndepmensualde = utilNumeros.Redondear((nvalcpa - nvalno) / nviduti / 12, 2)
            lccodinv = ds.Tables(0).Rows(i)("ccodinv")
            ccodinv = Right(lccodinv.Trim, 11)
            'ndepacum = utilNumeros.Redondear(lnmeses * ndepmensual, 2)
            ndepacum = IIf((nmestotdep + 1) >= (nviduti * 12), nvalcpa, ndepmensual * (nmestotdep + 1))
            ndiferencia = IIf(nvalcpa - ndepacum < 0, System.Math.Abs(nvalcpa - ndepacum), 0)
            ds.Tables(0).Rows(i)("ccodinv") = ccodinv.Trim
            ds.Tables(0).Rows(i)("depanual") = ndepanual
            ds.Tables(0).Rows(i)("depmen") = ndepmensual
            ds.Tables(0).Rows(i)("depmenno") = ndepmensualno
            ds.Tables(0).Rows(i)("depacum") = ndepacum
            ds.Tables(0).Rows(i)("depmende") = ndepmensualde
            ds.Tables(0).Rows(i)("ccodofi") = lccodofi
            i += 1
        Next
        Return ds
    End Function
    Public Function DataActivoPartidas(ByVal ldfecha As Date, ByVal ndepre As Integer, ByVal ccodadq As String, ByVal ccodact As String) As DataSet
        Dim ds As New DataSet
        'Dim ds1 As New DataSet
        Dim eactivof As New cActivoF
        ds = eactivof.DatasetActivoFijo(ccodofi, ffondos, ndepre, ccodadq, ccodact, ldfecha)
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim ccodigo As String
        Dim pre As String
        Dim etabttab As New cTabttab
        Dim ccodinv As String
        Dim ndepanual As Double
        Dim ndepmensual As Double
        Dim nvalcpa As Double
        Dim nviduti As Integer
        Dim nvalno As Double
        Dim ndepmensualno As Double
        Dim ndepmensualde As Double
        Dim ldfecadq As Date
        Dim ldfecbja As Date
        Dim ldfecdep As Date
        Dim cactdep As Integer
        Dim lnmeses As Integer
        Dim ndepacum As Double
        Dim lccodact As String
        Dim lccodinv As String
        Dim lccodofi As String
        Dim lntotalmeses As String
        For Each fila In ds.Tables(0).Rows
            ccodigo = Left(ds.Tables(0).Rows(i)("ccodinv"), 2)
            nvalcpa = ds.Tables(0).Rows(i)("nvalcpa")
            nviduti = ds.Tables(0).Rows(i)("nviduti")
            lccodact = ds.Tables(0).Rows(i)("cCodact")
            lntotalmeses = nviduti * 12
            lccodofi = ds.Tables(0).Rows(i)("cCodofi")
            If lccodact.Trim = "40" Then
                ds.Tables(0).Rows(i)("ctipo") = "2"
            Else
                ds.Tables(0).Rows(i)("ctipo") = "1"
            End If

            'ldfecadq = ds.Tables(0).Rows(i)("dfecadq")
            ldfecdep = ds.Tables(0).Rows(i)("dfecdep")

            'Meses depreciados
            If ldfecadq.Day > 15 Then
                'lnmeses = DateDiff(DateInterval.Month, ldfecadq, ldfecha)
                lnmeses = DateDiff(DateInterval.Month, ldfecdep, ldfecha)
            Else
                'lnmeses = DateDiff(DateInterval.Month, ldfecadq, ldfecha)
                lnmeses = DateDiff(DateInterval.Month, ldfecdep, ldfecha)
                lnmeses += 1
            End If

            If lnmeses > lntotalmeses Then
                lnmeses = lntotalmeses
            End If

            nvalno = ds.Tables(0).Rows(i)("nvalno")
            ndepanual = utilNumeros.Redondear((nvalcpa) / nviduti, 2)
            ndepmensual = utilNumeros.Redondear((ndepanual) / 12, 2)
            ndepmensualno = utilNumeros.Redondear((nvalno / nviduti) / 12, 2)
            ndepmensualde = utilNumeros.Redondear((nvalcpa - nvalno) / nviduti / 12, 2)

            pre = etabttab.DescribeAux(ccodigo.Trim, "118").Trim
            lccodinv = ds.Tables(0).Rows(i)("ccodinv")
            ccodinv = pre & Right(lccodinv.Trim, 11)
            ndepacum = utilNumeros.Redondear(lnmeses * ndepmensual, 2)

            ds.Tables(0).Rows(i)("ccodinv") = ccodinv.Trim
            ds.Tables(0).Rows(i)("depanual") = ndepanual
            ds.Tables(0).Rows(i)("depmen") = ndepmensual
            ds.Tables(0).Rows(i)("depmenno") = ndepmensualno
            ds.Tables(0).Rows(i)("depacum") = ndepacum
            ds.Tables(0).Rows(i)("depmende") = ndepmensualde
            ds.Tables(0).Rows(i)("ccodofi") = lccodofi
            i += 1
        Next
        Return ds
    End Function

    'Public Function DataActivoDepreciados(ByVal ds As DataSet, ByVal ldfecha As Date) As DataSet
    '    ' Fill the DataSet.
    '    Dim ds1 As DataSet
    '    Dim cactivof As New SIM.BL.cActivoF
    '    ds1 = ds
    '    ds1.Locale = CultureInfo.InvariantCulture
    '    'Dim DepreActF As DataTable = ds.Tables("Table")

    '    Dim query = From m In ds1.Tables("table").AsEnumerable _
    '                Where m.Field(Of Int32)("nactdep") = 1 _
    '                 Order By m.Field(Of String)("ccodofi") Ascending _
    '                    Group m By ccodofi = m.Field(Of String)("ccodofi"), _
    '                        ffondos = m.Field(Of String)("ffondos"), _
    '                            ccodact = m.Field(Of String)("ccodact"), _
    '                             depmen = m.Field(Of Double)("depmen") _
    '                                Into Group _
    '                            Select New With {ccodofi, ffondos, ccodact, .cant = Group.count}

    '    ' Declaramos una variable para obtener el resultado
    '    Dim Ds2 As DataSet
    '    Dim fila As DataRow
    '    Dim i As Integer = 0
    '    Dim lccodofi1 As String = ""
    '    Dim lffondos1 As String = ""
    '    Dim lccodact1 As String = ""
    '    Dim conteo As String = ""
    '    Dim final As String = ""

    '    'Console.WriteLine("Product Names:")
    '    For Each m In query
    '        lccodofi1 = m.ccodofi
    '        lffondos1 = m.ffondos
    '        lccodact1 = m.ccodact
    '        conteo = m.cant
    '        ds1.Tables(0).Rows(i)("ccodofi") = lccodofi1
    '        ds1.Tables(0).Rows(i)("ffondos") = lffondos1
    '        ds1.Tables(0).Rows(i)("ccodact") = lccodact1
    '        ds1.Tables(0).Rows(i)("depmen") = conteo
    '        i += 1
    '    Next

    '    ' Mostramos el resultado final
    '    'final = lccodofi1 + lffondos1 + lccodact1 + conteo
    '    Return Ds2
    'End Function

    Public Function DataActivoTarjeta(ByVal ldfecha As DateTime, ByVal ccodusu As String) As DataSet
        Dim ds As New DataSet
        Dim eactivoM As New cActivoM
        ds = eactivoM.BuscaActivosEmpleado(ccodusu)
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim ccodigo As String
        Dim pre As String
        Dim etabttab As New cTabttab
        Dim ccodinv As String
        Dim ndepanual As Double
        Dim ndepmensual As Double
        Dim nvalcpa As Double
        Dim nviduti As Integer
        Dim nvalno As Double
        Dim ndepmensualno As Double
        Dim ndepmensualde As Double
        Dim ldfecadq As Date
        Dim ldfecbja As Date
        Dim ldfecdep As Date
        Dim cactdep As Integer
        Dim lnmeses As Integer
        Dim ndepacum As Double
        Dim lccodact As String
        Dim lccodinv As String
        Dim lccodofi As String
        Dim lntotalmeses As String

        For Each fila In ds.Tables(0).Rows
            ccodigo = Left(ds.Tables(0).Rows(i)("ccodinv"), 2)
            nvalcpa = ds.Tables(0).Rows(i)("nvalcpa")
            nviduti = ds.Tables(0).Rows(i)("nviduti")
            lccodact = ds.Tables(0).Rows(i)("cCodact")
            lntotalmeses = nviduti * 12
            lccodofi = ds.Tables(0).Rows(i)("cCodofi")
            If lccodact.Trim = "40" Then
                ds.Tables(0).Rows(i)("ctipo") = "2"
            Else
                ds.Tables(0).Rows(i)("ctipo") = "1"
            End If

            'ldfecadq = ds.Tables(0).Rows(i)("dfecadq")
            ldfecdep = ds.Tables(0).Rows(i)("dfecdep")

            'Meses depreciados
            If ldfecadq.Day > 15 Then
                'lnmeses = DateDiff(DateInterval.Month, ldfecadq, ldfecha)
                lnmeses = DateDiff(DateInterval.Month, ldfecdep, ldfecha)
            Else
                'lnmeses = DateDiff(DateInterval.Month, ldfecadq, ldfecha)
                lnmeses = DateDiff(DateInterval.Month, ldfecdep, ldfecha)
                lnmeses += 1
            End If

            If lnmeses > lntotalmeses Then
                lnmeses = lntotalmeses
            End If

            nvalno = ds.Tables(0).Rows(i)("nvalno")
            ndepanual = utilNumeros.Redondear((nvalcpa) / nviduti, 2)
            ndepmensual = utilNumeros.Redondear((ndepanual) / 12, 2)
            ndepmensualno = utilNumeros.Redondear((nvalno / nviduti) / 12, 2)
            ndepmensualde = utilNumeros.Redondear((nvalcpa - nvalno) / nviduti / 12, 2)
            lccodinv = ds.Tables(0).Rows(i)("ccodinv")
            ccodinv = Right(lccodinv.Trim, 11)
            ndepacum = utilNumeros.Redondear(lnmeses * ndepmensual, 2)
            ds.Tables(0).Rows(i)("ccodinv") = ccodinv.Trim
            ds.Tables(0).Rows(i)("depanual") = ndepanual
            ds.Tables(0).Rows(i)("depmen") = ndepmensual
            ds.Tables(0).Rows(i)("depmenno") = ndepmensualno
            ds.Tables(0).Rows(i)("depacum") = ndepacum
            ds.Tables(0).Rows(i)("depmende") = ndepmensualde
            ds.Tables(0).Rows(i)("ccodofi") = lccodofi
            i += 1
        Next
        Return ds
    End Function
End Class
