Imports System.Text
Imports System.Data.SqlClient

'Public Class ccreditos
'#Region " Privadas "
'    Private mDb As New dbCreditos
'    Private mEntidad As creditos
'#End Region

'    Public Function ObtenerLista() As listacreditos
'        Return mDb.ObtenerListaPorID()
'    End Function

'    Public Function Obtenercreditos(ByRef mEntidad As creditos) As Integer
'        Return mDb.Recuperar(mEntidad)
'    End Function

'    Public Function Eliminarcreditos(ByVal ccodcta As String) As Integer
'        Dim mEntidad As New creditos
'        mEntidad.ccodcta = ccodcta
'        Return mDb.Eliminar(mEntidad)
'    End Function

'    Public Function Actualizarcreditos(ByVal aEntidad As creditos) As Integer
'        Return mDb.Actualizar(aEntidad)
'    End Function

'    Public Function ObtenerListaPorCliente(ByVal codcli As String) As listacreditos
'        Return mDb.ObtenerListaPorCliente(codcli)
'    End Function

'    Public Function ObtenerDataSetPorCliente(ByVal codcli As String) As DataSet
'        Return mDb.ObtenerDataSetPorCliente(codcli)
'    End Function

'    Public Function ObtenerDataSetPorID() As DataSet
'        Return mDb.ObtenerDataSetPorID()
'    End Function

'    'funcion que retorna los creditos acompa;ados con el nombre y el estado
'    Public Function Obtenerbusquedacredito(ByVal nombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String) As DataSet
'        Return mDb.Obtenerbusquedacredito(nombre, cestado, ctipo, cbusq)
'    End Function

'End Class

Public Class ccreditos

#Region " Privadas "
    Private mDb As New dbCreditos
    Private mEntidad As creditos
#End Region

#Region " Propiedades "
    Private _pnporseg As Double
    Public Property pnporseg() As Double
        Get
            pnporseg = _pnporseg
        End Get
        Set(ByVal Value As Double)
            _pnporseg = Value
        End Set
    End Property

    Private _pnpordan As Double
    Public Property pnpordan() As Double
        Get
            pnpordan = _pnpordan
        End Get
        Set(ByVal Value As Double)
            _pnpordan = Value
        End Set
    End Property

    Private _pnporres As Double
    Public Property pnporres() As Double
        Get
            pnporres = _pnporres
        End Get
        Set(ByVal Value As Double)
            _pnporres = Value
        End Set
    End Property

    Private _pnportal As Double
    Public Property pnportal() As Double
        Get
            pnportal = _pnportal
        End Get
        Set(ByVal Value As Double)
            _pnportal = Value
        End Set
    End Property


    Private _pncosind As Double
    Public Property pncosind() As Double
        Get
            pncosind = _pncosind
        End Get
        Set(ByVal Value As Double)
            _pncosind = Value
        End Set
    End Property

    Private _gnpergra As Integer
    Public Property gnpergra() As Integer
        Get
            gnpergra = _gnpergra
        End Get
        Set(ByVal value As Integer)
            _gnpergra = value
        End Set
    End Property

    'Chequeo internos de cliente
    Private _chequeo1 As String
    Private _chequeo2 As String
    Private _chequeo3 As String
    Private _chequeo4 As String
    'Chequeo internos del cliente
    Public Property chequeo1() As String
        Get
            Return _chequeo1
        End Get
        Set(ByVal Value As String)
            _chequeo1 = Value
        End Set
    End Property

    Public Property chequeo2() As String
        Get
            Return _chequeo2
        End Get
        Set(ByVal Value As String)
            _chequeo2 = Value
        End Set
    End Property

    Public Property chequeo3() As String
        Get
            Return _chequeo3
        End Get
        Set(ByVal Value As String)
            _chequeo3 = Value
        End Set
    End Property

    Public Property chequeo4() As String
        Get
            Return _chequeo4
        End Get
        Set(ByVal Value As String)
            _chequeo4 = Value
        End Set
    End Property
    Private _cartera As String
    Public Property cartera() As String
        Get
            Return _cartera
        End Get
        Set(ByVal Value As String)
            _cartera = Value
        End Set
    End Property

    Private _tipo As String
    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal Value As String)
            _tipo = Value
        End Set
    End Property

    Private _pncomtra As Double
    Public Property pncomtra() As Double
        Get
            pncomtra = _pncomtra
        End Get
        Set(ByVal Value As Double)
            _pncomtra = Value
        End Set
    End Property
    Private _pnperbas As Double
    Public Property pnperbas() As Double
        Get
            pnperbas = _pnperbas
        End Get
        Set(ByVal Value As Double)
            _pnperbas = Value
        End Set
    End Property
    Private _pnsegvm As Double
    Public Property pnsegvm() As Double
        Get
            pnsegvm = _pnsegvm
        End Get
        Set(ByVal Value As Double)
            _pnsegvm = Value
        End Set
    End Property
    Private _pnsegvm1 As Double
    Public Property pnsegvm1() As Double
        Get
            pnsegvm1 = _pnsegvm1
        End Get
        Set(ByVal Value As Double)
            _pnsegvm1 = Value
        End Set
    End Property

    Private _pnopcion As Integer
    Public Property pnopcion() As Integer
        Get
            pnopcion = _pnopcion
        End Get
        Set(ByVal Value As Integer)
            _pnopcion = Value
        End Set
    End Property


    Private _pcproducto As String
    Public Property pcproducto() As String
        Get
            pcproducto = _pcproducto
        End Get
        Set(ByVal Value As String)
            _pcproducto = Value
        End Set
    End Property

    Private _pltoda As Boolean
    Public Property pltoda() As Boolean
        Get
            pltoda = _pltoda
        End Get
        Set(ByVal Value As Boolean)
            _pltoda = Value
        End Set
    End Property
    Private _plven As Boolean
    Public Property plven() As Boolean
        Get
            plven = _plven
        End Get
        Set(ByVal Value As Boolean)
            _plven = Value
        End Set
    End Property

    Private _pnRango1 As Integer
    Public Property pnRango1() As Integer
        Get
            pnRango1 = _pnRango1
        End Get
        Set(ByVal Value As Integer)
            _pnRango1 = Value
        End Set
    End Property
    Private _pnRango2 As Integer
    Public Property pnRango2() As Integer
        Get
            pnRango2 = _pnRango2
        End Get
        Set(ByVal Value As Integer)
            _pnRango2 = Value
        End Set
    End Property
    Private _pnRango3 As Integer
    Public Property pnRango3() As Integer
        Get
            pnRango3 = _pnRango3
        End Get
        Set(ByVal Value As Integer)
            _pnRango3 = Value
        End Set
    End Property
    Private _pnRango4 As Integer
    Public Property pnRango4() As Integer
        Get
            pnRango4 = _pnRango4
        End Get
        Set(ByVal Value As Integer)
            _pnRango4 = Value
        End Set
    End Property
    Private _pnRango5 As Integer
    Public Property pnRango5() As Integer
        Get
            pnRango5 = _pnRango5
        End Get
        Set(ByVal Value As Integer)
            _pnRango5 = Value
        End Set
    End Property

    Private _pdfecha As Date
    Public Property pdfecha() As Date
        Get
            pdfecha = _pdfecha
        End Get
        Set(ByVal Value As Date)
            _pdfecha = Value
        End Set
    End Property

#End Region

    Public Function ObtenerLista() As DataSet 'listacreditos
        Return mDb.Obtenerdatasetcreditos()
        '        Return mDb.ObtenerListaPorID()
    End Function

    Public Function Obtenercreditos(ByRef mEntidad As creditos) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function


    Public Function recupera_ds(ByVal ccodcta As String) As DataSet
        Return mDb.recupera_ds(ccodcta)
    End Function


    Public Function Eliminarcreditos(ByVal ccodcta As String) As Integer
        Dim mEntidad As New creditos
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function Actualizarcreditos(ByVal aEntidad As creditos) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerListaPorCliente(ByVal codcli As String) As listacreditos
        Return mDb.ObtenerListaPorCliente(codcli)
    End Function

    Public Function ObtenerDataSetPorCliente(ByVal codcli As String) As DataSet
        Return mDb.ObtenerDataSetPorCliente(codcli)
    End Function

    'obtiene dataset por credito para habitat,
    Public Function ObtenerDataSetPorcredito1(ByVal ccodcta As String, ByVal ldfecha As Date) As DataSet
        Return mDb.ObtenerDataSetPorcredito1(ccodcta, ldfecha)
    End Function


    Public Function ObtenerDataSetPorcredito11(ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerDataSetPorcredito11(ccodcta)
    End Function

    Public Function ObtenerDataSetvigente() As DataSet
        Return mDb.ObtenerDataSetvigente()
    End Function

    'cartera total actualizada con pagos
    Public Function CARTERA_ACTUALIZADA(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lczona As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo
        Return mDb.CARTERA_ACTUALIZADA(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona)
    End Function

    Public Function CARTERA_ACTUALIZADA_POR_CUENTA(ByVal ccodcta As String, ByVal ldfecha As Date) As DataSet
        Return mDb.CARTERA_ACTUALIZADA_POR_CUENTA(ccodcta, ldfecha)
    End Function

    'Fran	
    Public Function Detalle_Kardex(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lccodcta As String) As DataSet
        Return mDb.Detalle_Kardex(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, lccodcta)
    End Function


    '    Public Function CARTERA_ACTUALIZADA_ANALISTAS(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean) As DataSet
    '  Return mDb.CARTERA_ACTUALIZADA_ANALISTAS(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora)
    '   End Function

    'detalle de cartera

    Public Function DETALLE_CARTERA_Y_PAGOS(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String, ByVal ctippag As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo

        Return mDb.DETALLE_CARTERA_Y_PAGOS(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona, ctippag)
    End Function
    Public Function CAPITAL_VIGENTE_ASESOR(ByVal ds As DataSet, ByVal ldfecha2 As Date) As DataSet
        Return mDb.CAPITAL_VIGENTE_ASESOR(ds, ldfecha2)
    End Function
   

    Public Function COMISIONES_ASESOR(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal bandera As String) As DataSet
        Return mDb.COMISIONES_ASESOR(ldfecha1, ldfecha2, lcoficina, lcanalista, bandera)
    End Function
    'realizadada por fernando Abrego Rdz 03-06-2015
    Public Function Rpt_ComisionMensuales82(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal bandera As String) As DataSet
        Return mDb.Rpt_ComisionMensuales82(ldfecha1, ldfecha2, lcoficina, lcanalista, bandera)

    End Function

    Public Function Rpt_DPGrupales88(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal bandera As String) As DataSet
        Return mDb.Rpt_DPGrupales88(ldfecha1, ldfecha2, lcoficina, lcanalista, bandera)
    End Function
    Public Function MONTO_COMISION(ByVal ds As DataSet) As DataSet
        Return mDb.MONTO_COMISION(ds)
    End Function
   

    Public Function PORCENTAJE_MORA(ByVal ds As DataSet) As DataSet
        Return mDb.PORCENTAJE_MORA(ds)
    End Function
    Public Function CAPITAL_RECUPERADO(ByVal ds As DataSet, ByVal ldfecha1 As Date, ByVal ldfecha2 As Date) As DataSet
        Return mDb.CAPITAL_RECUPERADO(ds, ldfecha1, ldfecha2)
    End Function
    Public Function COMISION_RECUPERADO(ByVal ds As DataSet) As DataSet
        Return mDb.COMISION_RECUPERADO(ds)
    End Function


    Public Function DETALLE_CARTERA_Y_PAGOS_POR_CUENTA(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lccodcta As String) As DataSet
        Return mDb.DETALLE_CARTERA_Y_PAGOS_POR_CUENTA(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, lccodcta)
    End Function


    'detalle de pagos por fondo
    Public Function DETALLE_CARTERA_Y_PAGOS_FONDO(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal cbandera As String, ByVal ccajeros As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo
        Return mDb.DETALLE_CARTERA_Y_PAGOS_FONDO(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, cbandera, ccajeros)
    End Function


    'contiene lo mismo del dataset pero son listaas
    Public Function ObtenerListadetallada(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date) As listacreditos
        Return mDb.ObtenerListadetallada(ldfecha1, ldfecha2)
    End Function


    Public Function ObtenerDataSetPorID() As DataSet
        Return mDb.ObtenerDataSetPorID()
    End Function


    Public Function obtenercartera(ByVal ldfecha As Date, ByVal pccodcta1 As String) As DataSet
        Return mDb.obtenercartera(ldfecha, pccodcta1)
    End Function

    'funcion que retorna los creditos acompa;ados con el nombre y el estado
    Public Function Obtenerbusquedacredito(ByVal nombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, ByVal ccodOfi As String) As DataSet
        Return mDb.Obtenerbusquedacredito(nombre, cestado, ctipo, cbusq, cmetodologia, cflag, ccodOfi)

    End Function
    Public Function Historial_cre1(ByVal ccodcli As String) As DataSet
        Return mDb.Historial_cre1(ccodcli)
    End Function
    Public Function Historial_cre2(ByVal ccodcta As String) As DataSet
        Return mDb.Historial_cre2(ccodcta)
    End Function
    Public Function Resumen(ByVal ccodcta As String) As DataSet
        Return mDb.Resumen(ccodcta)
    End Function
    Public Function IgualaCerosNmonsug(ByVal ccodsol As String) As String
        Return mDb.IgualaCerosNmonsug(ccodsol)
    End Function
    Public Function actualizaCnrolin(ByVal cnrolin As String, ByVal ccodsol As String) As String
        Return mDb.actualizaCnrolin(cnrolin, ccodsol)
    End Function
    '************ temporalmente cartera en mora
    'OBTIENE LA CARTERA CON SUS PAGOS ACTUALIZADOS

    Public Function CARTERA_ACTUALIZADA_MORA(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim DSCARTERA As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        Dim cancela As String
        cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona)
        lnsalintmor = 0


        For Each drcartera In DSCARTERA.Tables(0).Rows
            lnseguros = 0
            If drcartera("ndiaatr") > 0 Then
                If lcestrato <> "*" Then
                    'calculo de mora  dias de atraso menores que cero
                    If (drcartera("ndiaatr") <= 0 And lcestrato = "A") Or (drcartera("ndiaatr") > 0 And drcartera("ndiaatr") <= 30 And lcestrato = "B") Or (drcartera("ndiaatr") >= 31 And drcartera("ndiaatr") <= 60 And lcestrato = "C") Or (drcartera("ndiaatr") >= 61 And drcartera("ndiaatr") <= 180 And lcestrato = "D") Or (drcartera("ndiaatr") >= 181 And lcestrato = "E") Then
                        drmora = lcMORA.NewRow()
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("cdirdom") = drcartera("cdirdom")
                        drmora("dultpag") = drcartera("dultpag")

                        If IsDBNull(drcartera("ncapita")) Then
                            drcartera("ncapita") = 0
                        End If
                        If IsDBNull(drcartera("ncappag")) Then
                            drcartera("ncappag") = 0
                        End If

                        drmora("ncapmora") = drcartera("ncapita") - drcartera("ncappag")
                        drmora("nsalcap") = drcartera("ncapdes") - drcartera("ncappag")

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If
                        If IsDBNull(drcartera("nintteo")) Then
                            drcartera("nintteo") = 0
                        End If
                        If IsDBNull(drcartera("nintpag")) Then
                            drcartera("nintpag") = 0
                        End If
                        If IsDBNull(drcartera("ndifer")) Then
                            drcartera("ndifer") = 0
                        End If

                        If IsDBNull(drcartera("nahoprg")) Then
                            drcartera("nahoprg") = 0
                        End If

                        If IsDBNull(drcartera("tasa")) Then
                            drcartera("tasa") = 0
                        End If
                        drmora("nsalint") = drcartera("nsalint")
                        drmora("ndiaatr") = drcartera("ndiaatr")
                        lnsalintmor = drcartera("nsalintmor")
                        drmora("nsalintmor") = drcartera("nsalintmor")

                        'calculos de los seguros
                        If IsDBNull(drcartera("cflat")) Then
                            drcartera("cflat") = ""
                        End If


                        If IsDBNull(drcartera("ncapdes")) Then
                            drcartera("ncapdes") = 0
                        End If

                        If IsDBNull(drcartera("ncappag")) Then
                            drcartera("ncappag") = 0
                        End If

                        If drcartera("lsegdeu") = "1" Then
                            lnseguros = lnseguros + segdeu1(drcartera("cflat"), dfecha2, drcartera("dultpag"), drcartera("pnsegdeuind"), drcartera("pnsegdeuplatot"), drcartera("pnsegdeukar"), drcartera("ncapdes"), drcartera("ncappag"))
                            drmora("nseguros") = lnseguros

                        End If

                        If drcartera("lsegdan") = "1" Then
                            lnseguros = lnseguros + segdan1(drcartera("cflat"), dfecha2, drcartera("dultpag"), drcartera("pnsegdanind"), drcartera("pnsegdanplatot"), drcartera("pnsegdankar"), drcartera("ncapdes"), drcartera("ncappag"), drcartera("ncosdir"), drcartera("nprima"))
                            drmora("nseguros") = lnseguros

                        End If



                        'finaliza calculo de los seguros


                        lcMORA.Rows.Add(drmora)

                    End If


                Else

                    'no filtra dias de atraso
                    lnsalintmor = 0

                    drmora = lcMORA.NewRow()
                    lnsalintmor = drcartera("nsalintmor")
                    drmora("nsalintmor") = lnsalintmor
                    drmora("ccodcta") = drcartera("ccodcta")
                    drmora("cnomcli") = drcartera("cnomcli")
                    drmora("ncapdes") = drcartera("ncapdes")
                    drmora("dfecvig") = drcartera("dfecvig")
                    drmora("dfecven") = drcartera("dfecven")
                    drmora("cdirdom") = drcartera("cdirdom")
                    drmora("dultpag") = drcartera("dultpag")

                    If IsDBNull(drcartera("ncapita")) Then
                        drcartera("ncapita") = 0
                    End If
                    If IsDBNull(drcartera("ncappag")) Then
                        drcartera("ncappag") = 0
                    End If

                    drmora("ncapmora") = drcartera("ncapita") - drcartera("ncappag")
                    drmora("nsalcap") = drcartera("ncapdes") - drcartera("ncappag")
                    If IsDBNull(drmora("ncapmora")) Then
                        drmora("ncapmora") = 0
                    End If

                    If drmora("ncapmora") < 0 Then
                        drmora("ncapmora") = 0
                    End If

                    If IsDBNull(drcartera("nintteo")) Then
                        drcartera("nintteo") = 0
                    End If
                    If IsDBNull(drcartera("nintpag")) Then
                        drcartera("nintpag") = 0
                    End If
                    If IsDBNull(drcartera("ndifer")) Then
                        drcartera("ndifer") = 0
                    End If

                    If IsDBNull(drcartera("nahoprg")) Then
                        drcartera("nahoprg") = 0
                    End If

                    If IsDBNull(drcartera("tasa")) Then
                        drcartera("tasa") = 0
                    End If

                    If IsDBNull(drcartera("pnadmkar")) Then
                        drcartera("pnadmkar") = 0
                    End If

                    drmora("nsalint") = drcartera("nsalint")

                    drmora("ndiaatr") = drcartera("ndiaatr")

                    'calculos de los seguros
                    If IsDBNull(drcartera("cflat")) Then
                        drcartera("cflat") = ""
                    End If


                    If IsDBNull(drcartera("ncapdes")) Then
                        drcartera("ncapdes") = 0
                    End If

                    If IsDBNull(drcartera("ncappag")) Then
                        drcartera("ncappag") = 0
                    End If
                    If IsDBNull(drcartera("numcuoteo")) Then
                        drcartera("numcuoteo") = 0
                    End If
                    If IsDBNull(drcartera("ncuoapr")) Then
                        drcartera("ncuoapr") = 0
                    End If

                    If drcartera("lsegdeu") = "1" Then
                        lnseguros = lnseguros + segdeu1(drcartera("cflat"), dfecha2, drcartera("dultpag"), 0, 0, 0, drcartera("ncapdes"), drcartera("ncappag"))
                        drmora("nseguros") = lnseguros

                    End If



                    'finaliza calculo de los seguros


                    lcMORA.Rows.Add(drmora)
                End If
            End If
        Next

        dsmora.Tables.Add(lcMORA)
        Return dsmora

    End Function

    'calcula seguro de deuda
    Public Function segdeu1(ByVal pcflat As String, ByVal pdfecval As Date, ByVal pdultpag As Date, ByVal pnsegdeuind As Double, ByVal pnsegdeuplatot As Double, ByVal pnsegdeukar As Double, ByVal pncapdes As Double, ByVal pncappag As Double)
        Dim lndias As Double
        Dim lnsegdeu As Double
        Dim lnporsegdeu As Double

        Dim numero As Double
        Dim lnsegdeu1 As Double
        Dim mpay As New payment

        If pcflat = "F" Then
            numero = mpay.meses_desde_ultimo_pago(pdfecval, pdultpag)
            lnsegdeu1 = pnsegdeuind * numero

            If pnsegdeuplatot - pnsegdeukar >= lnsegdeu1 Then
                lnsegdeu = lnsegdeu1
            Else
                lnsegdeu = pnsegdeuplatot - pnsegdeukar
            End If
            If lnsegdeu < 0 Then
                lnsegdeu = 0
            End If

        Else
            lndias = pdfecval.ToOADate - pdultpag.ToOADate 'Me.pdultpag.ToOADate
            lnporsegdeu = Me.pnporseg

            lnsegdeu = utilNumeros.Redondear((pncapdes - pncappag) * lnporsegdeu * (lndias / 365), 2)
        End If
        Return lnsegdeu
    End Function

    Public Function segdan1(ByVal pcflat As String, ByVal pdfecval As Date, ByVal pdultpag As Date, ByVal pnsegdanind As Double, ByVal pnsegdanplatot As Double, ByVal pnsegdankar As Double, ByVal pncapdes As Double, ByVal pncappag As Double, ByVal pncosdir As Double, ByVal pnprima As Double)
        Dim lnsegdan As Double
        Dim lndias As Double
        Dim lnporsegdan As Double

        Dim numero As Double
        Dim lnsegdan1 As Double
        Dim mpay As New payment

        If pcflat = "F" Then
            numero = mpay.meses_desde_ultimo_pago(pdfecval, pdultpag)
            lnsegdan1 = pnsegdanind * numero

            If pnsegdanplatot - pnsegdankar >= lnsegdan1 Then
                lnsegdan = lnsegdan1
            Else
                lnsegdan = pnsegdanplatot - pnsegdankar
            End If
            If lnsegdan < 0 Then
                lnsegdan = 0
            End If
        Else

            lndias = pdfecval.ToOADate - pdultpag.ToOADate 'Me.pdultpag.ToOADate
            lnporsegdan = Me.pnpordan

            '            lnsegdan = utilNumeros.Redondear((pncosdir - pnprima) * lnporsegdan * (30 / 365), 2)
            lnsegdan = utilNumeros.Redondear((pncapdes) * lnporsegdan * (30 / 365), 2)

        End If

        Return lnsegdan

    End Function


    Public Function reserva1(ByVal pcflat As String, ByVal pdfecval As Date, ByVal pdultpag As Date, ByVal pnreservaind As Double, ByVal pnreservaplatot As Double, ByVal pnreservakar As Double, ByVal pncapdes As Double, ByVal pncappag As Double)
        Dim lnreserva As Double
        Dim lndias As Double
        Dim lnporres As Double

        Dim numero As Double
        Dim lnreserva1 As Double
        Dim mpay As New payment

        If pcflat = "F" Then
            numero = mpay.meses_desde_ultimo_pago(pdfecval, pdultpag)
            lnreserva1 = pnreservaind * numero

            If pnreservaplatot - pnreservakar >= lnreserva1 Then
                lnreserva = lnreserva1
            Else
                lnreserva = pnreservaplatot - pnreservakar
            End If
            If lnreserva < 0 Then
                lnreserva = 0
            End If
        Else

            lndias = pdfecval.ToOADate - pdultpag.ToOADate 'Me.pdultpag.ToOADate
            lnporres = Me.pnporres
            lnreserva = utilNumeros.Redondear((pncapdes - pncappag) * lnporres * (lndias / 365), 2)
        End If
        Return lnreserva

    End Function

    Public Function talonario1()
        Dim lntalona As Double
        Dim lnportalona As Double
        lnportalona = Me.pnportal
        lntalona = utilNumeros.Redondear(lnportalona, 2)
        Return lntalona
    End Function


    Public Function cosadm1(ByVal pngasadm As Double, ByVal pncapdes As Double, ByVal lnpagogas As Double)
        Dim filacuotas As DataRow
        Dim lngasadm As Double
        Dim lngastot As Double
        Dim lnnewgas As Double
        lngasadm = 0
        lnnewgas = 0

        lngasadm = pngasadm  ' se calcula  arriba
        lngastot = pncapdes * Me.pncosind

        lnnewgas = lngasadm - lnpagogas
        If lnnewgas <= 0 Then
            If lngastot >= lnpagogas Then
                lnnewgas = 0
            Else
                If lngastot >= lngasadm Then
                    lnnewgas = lngasadm
                Else
                    lnnewgas = lngastot - lngasadm
                End If
            End If
        End If
        Return lnnewgas
    End Function

    Public Function Multicolector(ByVal pccodana, ByVal pdfecini, ByVal pdfecfin) As DataSet
        Return mDb.Multicolector(pccodana, pdfecini, pdfecfin)
    End Function
    Public Function CreTraslado(ByVal pccodcta As String) As DataSet
        Return mDb.CreTraslado(pccodcta)
    End Function
    Public Function Trasladar(ByVal aEntidad As creditos) As Integer
        Return mDb.Trasladar(aEntidad)
    End Function
    Public Sub ReclasificacionCartera()
        mDb.ReclasificacionCartera()
    End Sub
    Public Function CalculoMora(ByVal dfecha As Date)
        mDb.CalculoMora(dfecha)
    End Function
    Public Function Chequeointerno(ByVal ccodcli As String, ByVal ccodcta As String)
        mDb.ChequeoInterno(ccodcli, ccodcta)
        Me.chequeo1 = mDb.chequeo1a
        Me.chequeo2 = mDb.chequeo2b
        Me.chequeo3 = mDb.chequeo3c
        Me.chequeo4 = mDb.chequeo4d
    End Function
    Public Function Ultimopago(ByVal ccodcta, ByVal dfecha) As Date
        Return mDb.Ultimopago(ccodcta, dfecha)
    End Function
    Public Function ciclo(ByVal ccodcli As String, ByVal ccodcta As String) As Integer
        Return mDb.Ciclo(ccodcli, ccodcta)
    End Function
    Public Function Califica(ByVal ndiaatr As Integer) As String
        Dim lccalifica As String = "A"
        If ndiaatr <= 0 Then
            lccalifica = "A"
        ElseIf ndiaatr > 0 And ndiaatr <= 30 Then
            lccalifica = "B"
        ElseIf ndiaatr > 30 And ndiaatr <= 60 Then
            lccalifica = "C"
        ElseIf ndiaatr > 60 And ndiaatr <= 90 Then
            lccalifica = "D"
        ElseIf ndiaatr > 90 And ndiaatr <= 120 Then
            lccalifica = "E"
        ElseIf ndiaatr > 120 And ndiaatr <= 180 Then
            lccalifica = "F"
        ElseIf ndiaatr > 180 And ndiaatr <= 360 Then
            lccalifica = "G"
        Else
            lccalifica = "H"
        End If
        Return lccalifica
    End Function
    Public Function CalificaDes(ByVal ndiaatr As Integer) As String
        Dim lccalifica As String = "A"
        If ndiaatr <= 0 Then
            lccalifica = "CARTERA SIN ATRASO EN PAGOS"
        ElseIf ndiaatr > 0 And ndiaatr <= 30 Then
            lccalifica = "CARTERA CON MORA 1-30 DÍAS"
        ElseIf ndiaatr > 30 And ndiaatr <= 60 Then
            lccalifica = "CARTERA CON MORA 31-60 DÍAS"
        ElseIf ndiaatr > 60 And ndiaatr <= 90 Then
            lccalifica = "CARTERA CON MORA 61-90 DÍAS"
        ElseIf ndiaatr > 90 And ndiaatr <= 120 Then
            lccalifica = "CARTERA CON MORA 91-120 DÍAS"
        ElseIf ndiaatr > 120 And ndiaatr <= 180 Then
            lccalifica = "CARTERA CON MORA 121-180 DÍAS"
        ElseIf ndiaatr > 180 And ndiaatr <= 360 Then
            lccalifica = "CARTERA CON MORA 181-360 DÍAS"
        Else
            lccalifica = "CARTERA CON MORA MAS DE 360 DÍAS"
        End If
        Return lccalifica
    End Function
    Public Function MORA_POR_ASESOR(ByVal ds As DataSet, ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataSet
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow

            Dim totalMora As Double
            Dim lccodusu, cnrolin As String
            Dim total_mes_actual As Double
            Dim fechaActual As Date
            Dim lcoficina, lcanalista As String
            Dim lcestrato, lclineas, lczona, lcproducto As String
            Dim lmora As Boolean



            cnrolin = "*"
            lcoficina = "*"
            lczona = "*"
            lcproducto = "*"
            lclineas = "*"
            lcestrato = "*"
            lmora = True
            Dim ele As Integer
            For Each fila In ds.Tables(0).Rows
                lcanalista = ds.Tables(0).Rows(ele)("ccodusu")
                totalMora = Me.MORA_ASESOR(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto, cnrolin)
                ds.Tables(0).Rows(ele)("mora") = totalMora
                ele += 1


            Next
        End If
        Return ds
    End Function

    Public Function MORA_POR_PRODUCTO(ByVal ds As DataSet, ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataSet
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow

            Dim totalMora As Double
            Dim lccodusu, cnrolin As String
            Dim total_mes_actual As Double
            Dim fechaActual As Date
            Dim lcoficina, lcanalista As String
            Dim lcestrato, lclineas, lczona, lcproducto As String
            Dim lmora As Boolean

            lczona = "*"
            lclineas = "*"
            lcestrato = "*"
            lmora = True
            Dim ele As Integer
            For Each fila In ds.Tables(0).Rows
                lcoficina = ds.Tables(0).Rows(ele)("Id_Sucursal")
                lcanalista = ds.Tables(0).Rows(ele)("id_Asesor")
                lcproducto = "*"
                cnrolin = ds.Tables(0).Rows(ele)("idproducto")
                Dim i = 0
                If i = 0 Then
                    totalMora = Me.MORA_ASESOR(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto, cnrolin)
                Else
                    totalMora = Me.MORA_ASESOR(ldfecha1, ldfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lczona, lcproducto, cnrolin)
                End If
                ds.Tables(0).Rows(ele)("mora") = totalMora
                ele += 1


            Next
        End If
        Return ds
    End Function


    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<
    Public Function MORA_ASESOR(ByVal dfecha1 As DateTime, ByVal dfecha2 As DateTime, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal lcproducto As String, ByVal cnrolin As String) As Double


        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String

        Dim lnsaldo As Double = 0
        Dim lnsalteo30 As Double = 0
        Dim lnsalteo60 As Double = 0

        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        Dim lnpagar30 As Double = 0
        Dim lnpagar60 As Double = 0

        Dim ldfec30 As Date
        Dim ldfec60 As Date

        Dim nCapitalEnRiesgo As Double

        ldfec30 = dfecha2.AddDays(-30)
        ldfec60 = dfecha2.AddDays(-60)

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  120 "
        ElseIf lcestrato = "E" Then
            categoria = " drcartera('ndiaatr')> 120 AND drcartera('ndiaatr') <=  180 "
        ElseIf lcestrato = "F" Then
            categoria = " drcartera('ndiaatr')> 180 AND drcartera('ndiaatr') <=  360 "
        Else
            categoria = " drcartera('ndiaatr')> 360 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes , dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador,cteldom, npagar30, npagar60, ccodsol, cnomgru, ccodcen, cnomcen, ccodana, dultpag2,ccodofi, cnomofi, ffondos, cdescri,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,S,D,D,S,S,S,S,S,F,S,S,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        Dim cancela As String
        cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo


        dscartera = clscartera.CarteraCalculadaFiltrada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto, cnrolin)
        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "D" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)



                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr

                    If lndiaatr > 0 Then
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        'Para Calcular Cuota
                        Dim lncuota As Double = 0
                        lccalifica = Me.Califica(lndiaatr)
                        lcestrdes = Me.CalificaDes(lndiaatr)
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        clsppal.gnperbas = Me.pnperbas
                        clsppal.pnComtra = Me.pncomtra
                        If drcartera("dfecvig") >= #7/11/2008# Then
                            clsppal.pnSegVm = Me.pnsegvm1
                        Else
                            clsppal.pnSegVm = Me.pnsegvm
                        End If

                        lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                        Dim lctelefono As String
                        If IsDBNull(drcartera("cteldom")) Then
                        Else
                            lctelefono = drcartera("cteldom")
                            drcartera("cteldom") = lctelefono.Trim
                        End If
                        'lncuota = clsaplica.pnmoncuo
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        If lcestrato <> "*" Then
                            'calculo de mora  dias de atraso menores que cero
                            If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr >= 1 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr >= 31 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr >= 61 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr >= 91 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                                If pltoda = True Or (pltoda = False And clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2) Then
                                    drmora = lcMORA.NewRow()
                                    drmora("ccodcta") = drcartera("ccodcta")
                                    drmora("cnomcli") = drcartera("cnomcli")
                                    drmora("ncapdes") = drcartera("ncapdes")
                                    drmora("dfecvig") = drcartera("dfecvig")
                                    drmora("ccodsol") = drcartera("ccodsol")
                                    drmora("cnomgru") = drcartera("cnomgru")
                                    drmora("ccodana") = drcartera("ccodana")

                                    drmora("ccodcen") = drcartera("ccodcen")
                                    drmora("cnomcen") = drcartera("cnomcen")

                                    drmora("dfecven") = drcartera("dfecven")
                                    drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                                    drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                                    drmora("dultpag") = clsaplica.pdultpag
                                    drmora("dultpag2") = clsaplica.pdultpag2
                                    drmora("ncuota") = clsaplica.pnmoncuo
                                    drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)

                                    'calcula a saldos teorico a 30 y 60 dias --------------------------------------
                                    lnsalteo30 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec30)
                                    If lnsalteo30 = 0 Then
                                        drmora("npagar30") = 0
                                    Else
                                        drmora("npagar30") = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))
                                    End If

                                    lnsalteo60 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec60)
                                    If lnsalteo60 = 0 Then
                                        drmora("npagar60") = 0
                                    Else
                                        drmora("npagar60") = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))
                                    End If
                                    '-------------------------------------------------------------------------------

                                    drmora("ncuota") = lncuota
                                    drmora("ccalifica") = lccalifica
                                    drmora("ccalificades") = lcestrdes
                                    drmora("cfiador") = lcdatosfia

                                    If IsDBNull(drmora("ncapmora")) Then
                                        drmora("ncapmora") = 0
                                    End If

                                    If drmora("ncapmora") < 0 Then
                                        drmora("ncapmora") = 0
                                    End If

                                    drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                    drmora("ndiaatr") = clsaplica.pndiaatr
                                    drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                                    'calculos de los seguros
                                    ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                    entidadcretlin.cnrolin = clsaplica.cnrolin
                                    ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                    pccodlin = entidadcretlin.ccodlin
                                    lsegdeu = entidadcretlin.lsegdeu

                                    lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)

                                    lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                                    lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                                    lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                                    lngasadm = lnmanejo + lniva


                                    drmora("ncomision") = lngasadm
                                    drmora("nsegdeu") = lnsegdeu
                                    drmora("nseguros") = 0

                                    drmora("ccodofi") = drcartera("coficina")
                                    drmora("cnomofi") = drcartera("cnomofi")

                                    drmora("ffondos") = drcartera("ffondos")
                                    drmora("cdescri") = drcartera("cdescri")
                                    'finaliza calculo de los seguros
                                    lcMORA.Rows.Add(drmora)
                                    nCapitalEnRiesgo += drmora("ncapmora")
                                End If
                            End If


                        Else
                            'no filtra dias de atraso
                            If pltoda = True Or (pltoda = False And clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2) Then
                                lnsalintmor = 0
                                drmora = lcMORA.NewRow()
                                drmora("nsalintmor") = clsaplica.pnsalmor
                                drmora("ccodcta") = drcartera("ccodcta")
                                drmora("cnomcli") = drcartera("cnomcli")
                                drmora("ncapdes") = drcartera("ncapdes")
                                drmora("dfecvig") = drcartera("dfecvig")
                                drmora("ccodsol") = drcartera("ccodsol")
                                drmora("cnomgru") = drcartera("cnomgru")
                                drmora("ccodcen") = drcartera("ccodcen")
                                drmora("cnomcen") = drcartera("cnomcen")
                                drmora("dfecven") = drcartera("dfecven")
                                drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                                drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                                drmora("dultpag") = clsaplica.pdultpag
                                drmora("dultpag2") = clsaplica.pdultpag2
                                drmora("ncuota") = lncuota
                                drmora("ccalifica") = lccalifica
                                drmora("ccalificades") = lcestrdes
                                drmora("cfiador") = lcdatosfia
                                drmora("ccodana") = drcartera("ccodana")

                                drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)


                                lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)


                                'calcula a saldos teorico a 30 y 60 dias --------------------------------------
                                lnsalteo30 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec30)
                                If lnsalteo30 = 0 Then
                                    drmora("npagar30") = 0
                                Else
                                    drmora("npagar30") = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))
                                End If

                                lnsalteo60 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec60)
                                If lnsalteo60 = 0 Then
                                    drmora("npagar60") = 0
                                Else
                                    drmora("npagar60") = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))
                                End If
                                '-------------------------------------------------------------------------------



                                If IsDBNull(drmora("ncapmora")) Then
                                    drmora("ncapmora") = 0
                                End If

                                If drmora("ncapmora") < 0 Then
                                    drmora("ncapmora") = 0
                                End If



                                drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                drmora("ndiaatr") = clsaplica.pndiaatr

                                'calculos de los seguros

                                ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                entidadcretlin.cnrolin = clsaplica.cnrolin
                                ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                pccodlin = entidadcretlin.ccodlin
                                lsegdeu = entidadcretlin.lsegdeu

                                lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)

                                lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                                lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                                lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                                lngasadm = lnmanejo + lniva


                                drmora("ncomision") = lngasadm
                                drmora("nsegdeu") = lnsegdeu
                                drmora("nseguros") = 0

                                drmora("ccodofi") = drcartera("coficina")
                                drmora("cnomofi") = drcartera("cnomofi")

                                drmora("ffondos") = drcartera("ffondos")
                                drmora("cdescri") = drcartera("cdescri")


                                'finaliza calculo de los seguros

                                nCapitalEnRiesgo += drmora("ncapmora")
                                lcMORA.Rows.Add(drmora)
                            End If
                        End If
                    End If
                End If
            End If
            'Capital en mora consolidado

        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return nCapitalEnRiesgo

    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<
    Public Function CarteraCalculadaMora(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String

        Dim lnsaldo As Double = 0
        Dim lnsalteo30 As Double = 0
        Dim lnsalteo60 As Double = 0

        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        Dim lnpagar30 As Double = 0
        Dim lnpagar60 As Double = 0

        Dim ldfec30 As Date
        Dim ldfec60 As Date

        ldfec30 = dfecha2.AddDays(-30)
        ldfec60 = dfecha2.AddDays(-60)

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  120 "
        ElseIf lcestrato = "E" Then
            categoria = " drcartera('ndiaatr')> 120 AND drcartera('ndiaatr') <=  180 "
        ElseIf lcestrato = "F" Then
            categoria = " drcartera('ndiaatr')> 180 AND drcartera('ndiaatr') <=  360 "
        Else
            categoria = " drcartera('ndiaatr')> 360 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador,cteldom, npagar30, npagar60, ccodsol, cnomgru, ccodcen, cnomcen, ccodana, dultpag2,ccodofi, cnomofi, ffondos, cdescri,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,S,D,D,S,S,S,S,S,F,S,S,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        Dim cancela As String
        cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)
        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)
        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "D" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)



                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr

                    If lndiaatr > 0 Then
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        'Para Calcular Cuota
                        Dim lncuota As Double = 0
                        lccalifica = Me.Califica(lndiaatr)
                        lcestrdes = Me.CalificaDes(lndiaatr)
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        clsppal.gnperbas = Me.pnperbas
                        clsppal.pnComtra = Me.pncomtra
                        If drcartera("dfecvig") >= #7/11/2008# Then
                            clsppal.pnSegVm = Me.pnsegvm1
                        Else
                            clsppal.pnSegVm = Me.pnsegvm
                        End If

                        lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                        Dim lctelefono As String
                        If IsDBNull(drcartera("cteldom")) Then
                        Else
                            lctelefono = drcartera("cteldom")
                            drcartera("cteldom") = lctelefono.Trim
                        End If
                        'lncuota = clsaplica.pnmoncuo
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        If lcestrato <> "*" Then
                            'calculo de mora  dias de atraso menores que cero
                            If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr >= 1 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr >= 31 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr >= 61 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr >= 91 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                                If pltoda = True Or (pltoda = False And clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2) Then
                                    drmora = lcMORA.NewRow()
                                    drmora("ccodcta") = drcartera("ccodcta")
                                    drmora("cnomcli") = drcartera("cnomcli")
                                    drmora("ncapdes") = drcartera("ncapdes")
                                    drmora("dfecvig") = drcartera("dfecvig")
                                    drmora("ccodsol") = drcartera("ccodsol")
                                    drmora("cnomgru") = drcartera("cnomgru")
                                    drmora("ccodana") = drcartera("ccodana")

                                    drmora("ccodcen") = drcartera("ccodcen")
                                    drmora("cnomcen") = drcartera("cnomcen")

                                    drmora("dfecven") = drcartera("dfecven")
                                    drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                                    drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                                    drmora("dultpag") = clsaplica.pdultpag
                                    drmora("dultpag2") = clsaplica.pdultpag2
                                    drmora("ncuota") = clsaplica.pnmoncuo
                                    drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)

                                    'calcula a saldos teorico a 30 y 60 dias --------------------------------------
                                    lnsalteo30 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec30)
                                    If lnsalteo30 = 0 Then
                                        drmora("npagar30") = 0
                                    Else
                                        drmora("npagar30") = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))
                                    End If

                                    lnsalteo60 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec60)
                                    If lnsalteo60 = 0 Then
                                        drmora("npagar60") = 0
                                    Else
                                        drmora("npagar60") = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))
                                    End If
                                    '-------------------------------------------------------------------------------

                                    drmora("ncuota") = lncuota
                                    drmora("ccalifica") = lccalifica
                                    drmora("ccalificades") = lcestrdes
                                    drmora("cfiador") = lcdatosfia

                                    If IsDBNull(drmora("ncapmora")) Then
                                        drmora("ncapmora") = 0
                                    End If

                                    If drmora("ncapmora") < 0 Then
                                        drmora("ncapmora") = 0
                                    End If

                                    drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                    drmora("ndiaatr") = clsaplica.pndiaatr
                                    drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                                    'calculos de los seguros
                                    ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                    entidadcretlin.cnrolin = clsaplica.cnrolin
                                    ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                    pccodlin = entidadcretlin.ccodlin
                                    lsegdeu = entidadcretlin.lsegdeu

                                    lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)

                                    lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                                    lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                                    lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                                    lngasadm = lnmanejo + lniva


                                    drmora("ncomision") = lngasadm
                                    drmora("nsegdeu") = lnsegdeu
                                    drmora("nseguros") = 0

                                    drmora("ccodofi") = drcartera("coficina")
                                    drmora("cnomofi") = drcartera("cnomofi")

                                    drmora("ffondos") = drcartera("ffondos")
                                    drmora("cdescri") = drcartera("cdescri")
                                    'finaliza calculo de los seguros
                                    lcMORA.Rows.Add(drmora)
                                End If
                            End If


                        Else
                            'no filtra dias de atraso
                            If pltoda = True Or (pltoda = False And clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2) Then
                                lnsalintmor = 0
                                drmora = lcMORA.NewRow()
                                drmora("nsalintmor") = clsaplica.pnsalmor
                                drmora("ccodcta") = drcartera("ccodcta")
                                drmora("cnomcli") = drcartera("cnomcli")
                                drmora("ncapdes") = drcartera("ncapdes")
                                drmora("dfecvig") = drcartera("dfecvig")
                                drmora("ccodsol") = drcartera("ccodsol")
                                drmora("cnomgru") = drcartera("cnomgru")
                                drmora("ccodcen") = drcartera("ccodcen")
                                drmora("cnomcen") = drcartera("cnomcen")
                                drmora("dfecven") = drcartera("dfecven")
                                drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                                drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                                drmora("dultpag") = clsaplica.pdultpag
                                drmora("dultpag2") = clsaplica.pdultpag2
                                drmora("ncuota") = lncuota
                                drmora("ccalifica") = lccalifica
                                drmora("ccalificades") = lcestrdes
                                drmora("cfiador") = lcdatosfia
                                drmora("ccodana") = drcartera("ccodana")

                                drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                                lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)


                                'calcula a saldos teorico a 30 y 60 dias --------------------------------------
                                lnsalteo30 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec30)
                                If lnsalteo30 = 0 Then
                                    drmora("npagar30") = 0
                                Else
                                    drmora("npagar30") = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))
                                End If

                                lnsalteo60 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec60)
                                If lnsalteo60 = 0 Then
                                    drmora("npagar60") = 0
                                Else
                                    drmora("npagar60") = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))
                                End If
                                '-------------------------------------------------------------------------------



                                If IsDBNull(drmora("ncapmora")) Then
                                    drmora("ncapmora") = 0
                                End If

                                If drmora("ncapmora") < 0 Then
                                    drmora("ncapmora") = 0
                                End If

                                drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                drmora("ndiaatr") = clsaplica.pndiaatr

                                'calculos de los seguros

                                ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                entidadcretlin.cnrolin = clsaplica.cnrolin
                                ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                pccodlin = entidadcretlin.ccodlin
                                lsegdeu = entidadcretlin.lsegdeu

                                lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)

                                lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                                lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                                lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                                lngasadm = lnmanejo + lniva


                                drmora("ncomision") = lngasadm
                                drmora("nsegdeu") = lnsegdeu
                                drmora("nseguros") = 0

                                drmora("ccodofi") = drcartera("coficina")
                                drmora("cnomofi") = drcartera("cnomofi")

                                drmora("ffondos") = drcartera("ffondos")
                                drmora("cdescri") = drcartera("cdescri")


                                'finaliza calculo de los seguros


                                lcMORA.Rows.Add(drmora)
                            End If
                        End If
                    End If
                End If
            End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function

    Public Function CarteraCalculada(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, _
                                     ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, _
                                     ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, _
                                     ByVal lcproducto As String) As DataSet


        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, ctipgar, cteldom, cNudoci, cNudotr, ccodcli, dnacimi, ncuoapr, ncuomor, ccodact, ccodsol, cnomgru, ccodcen, cnomcen, ncuotakp, cdias, cdesdias, dultpag2, ccodana, cnomana, ccodofi, cnomofi,ffondos,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,S,S,S,S,F,D,D,S,S,S,S,S,D,S,S,F,S,S,S,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)

        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, _
                                                Me.cartera, lczona, lcproducto)

        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        Dim lniva As Double = 0
        nn = dscartera.Tables(0).Rows.Count

        Dim k As Integer = 0
        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0

            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra

                clsaplica.pcestado = drcartera("cestado")

                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                    Dim lncuotakp As Double = 0
                    lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                    'lncuota = clsaplica.pnmoncuo
                    Dim lncuotasmor As Integer = 0
                    'Cuotas Atrasadas
                    If lndiaatr > 0 And lncuotakp > 0 Then
                        lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                    Else
                        lncuotasmor = 0
                    End If

                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                            drmora = lcMORA.NewRow()
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfecvig")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("ccodsol") = drcartera("ccodsol")
                            drmora("cnomgru") = drcartera("cnomgru")
                            drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                            drmora("cteldom") = drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("dultpag2") = clsaplica.pdultpag2
                            drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncuota") = lncuota
                            drmora("ncuotakp") = lncuotakp
                            drmora("ncuomor") = lncuotasmor
                            drmora("ccalifica") = lccalifica
                            drmora("ccalificades") = lcestrdes
                            drmora("cfiador") = lcdatosfia
                            drmora("ctipgar") = drcartera("ctipgar")
                            drmora("cnudoci") = drcartera("cnudoci")
                            drmora("cnudotr") = drcartera("cnudotr")
                            drmora("ccodcli") = drcartera("ccodcli")
                            drmora("dnacimi") = drcartera("dnacimi")
                            drmora("ncuoapr") = drcartera("ncuoapr")
                            drmora("ccodact") = drcartera("ccodact")

                            drmora("ccodcen") = (drcartera("cCodcta")).substring(6, 2) 'drcartera("ccodcen")
                            drmora("cnomcen") = IIf((drcartera("cCodcta")).substring(6, 2) = "01", "PRESTAMOS INDIVIDUALES", IIf((drcartera("cCodcta")).substring(6, 2) = "02", "BANCOS COMUNALES", "GRUPOS SOLIDARIOS"))

                            drmora("ccodana") = drcartera("ccodana")
                            drmora("cnomana") = drcartera("cnomana")

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            If clsaplica.pndiaatr > 30 Then
                                drmora("cdias") = "A"
                                drmora("cdesdias") = "Créditos > 30 días"
                            Else
                                drmora("cdias") = "B"
                                drmora("cdesdias") = "Créditos <= 30 días"
                            End If
                            drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If
                            lnsegdeu = 0 'Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = 0 'Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, clsaplica.pdfecvig), 2)
                            lniva = 0 'Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva


                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0

                            drmora("ccodofi") = drcartera("coficina")
                            drmora("cnomofi") = drcartera("cnomofi")
                            drmora("ffondos") = drcartera("ffondos")
                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("ccodsol") = drcartera("ccodsol")
                        drmora("cnomgru") = drcartera("cnomgru")
                        drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                        drmora("cteldom") = drcartera("cteldom")
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("dultpag2") = clsaplica.pdultpag2
                        drmora("ncuota") = lncuota
                        drmora("ncuotakp") = lncuotakp
                        drmora("ncuomor") = lncuotasmor
                        drmora("ccalifica") = lccalifica
                        drmora("ccalificades") = lcestrdes
                        drmora("cfiador") = lcdatosfia
                        drmora("ctipgar") = drcartera("ctipgar")
                        drmora("cnudoci") = drcartera("cnudoci")
                        drmora("cnudotr") = drcartera("cnudotr")
                        drmora("ccodcli") = drcartera("ccodcli")
                        drmora("dnacimi") = drcartera("dnacimi")
                        drmora("ncuoapr") = drcartera("ncuoapr")
                        drmora("ccodact") = drcartera("ccodact")

                        drmora("ccodana") = drcartera("ccodana")
                        drmora("cnomana") = drcartera("cnomana")


                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        drmora("ccodcen") = (drcartera("cCodcta")).substring(6, 2) 'drcartera("ccodcen")
                        drmora("cnomcen") = IIf((drcartera("cCodcta")).substring(6, 2) = "01", "PRESTAMOS INDIVIDUALES", IIf((drcartera("cCodcta")).substring(6, 2) = "02", "BANCOS COMUNALES", "GRUPOS SOLIDARIOS"))

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr

                        If clsaplica.pndiaatr > 30 Then
                            drmora("cdias") = "A"
                            drmora("cdesdias") = "Créditos > 30 días"
                        Else
                            drmora("cdias") = "B"
                            drmora("cdesdias") = "Créditos <= 30 días"
                        End If

                        'calculos de los seguros

                        ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        entidadcretlin.cnrolin = clsaplica.cnrolin
                        ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = entidadcretlin.ccodlin
                        lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        'If pccodlin.Substring(8, 2) = "06" Then
                        '    lngasadm = 0
                        'Else
                        '    If clsaplica.pdfecvig > #11/1/2005# Then
                        '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                        '    Else
                        '        lngasadm = 0
                        '    End If
                        'End If
                        'If lsegdeu = True Then
                        '    If clsaplica.pdfecvig >= #7/11/2008# Then
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                        '    Else
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                        '    End If

                        'Else
                        '    lnsegdeu = 0
                        'End If
                        lnsegdeu = 0 'Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = 0 'Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, clsaplica.pdfecvig), 2)
                        lniva = 0 'Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva


                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0
                        drmora("ccodofi") = drcartera("coficina")
                        drmora("cnomofi") = drcartera("cnomofi")
                        drmora("ffondos") = drcartera("ffondos")

                        'finaliza calculo de los seguros


                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function

    Public Function Agenda(ByVal dfecha As Date, ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lnnivel As Integer, ByVal limite1 As Double, ByVal limite2 As Double) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim clsppal As New class1
        Dim ncuota As Double
        Dim pnciclo As Integer
        Dim cfrecuencia As String
        Dim pcgarantia As String
        Dim dstipo As New DataSet
        Dim nelemgar As Integer
        Dim lndias As Integer = 0

        dscartera = clscartera.AgendaComite(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera, lnnivel, limite1, limite2)
        If dscartera.Tables(0).Rows.Count = 0 Then
        Else
            Dim nelem As Integer
            Dim fila As DataRow
            Dim pccodcta As String
            Dim pccodcli As String
            Dim pctipper As String
            Dim pndia As Integer

            clsppal.gnperbas = Me.pnperbas
            clsppal.pnComtra = Me.pncomtra
            clsppal.pnSegVm = Me.pnsegvm
            Dim ldfecsol As Date
            For Each fila In dscartera.Tables(0).Rows
                pccodcta = dscartera.Tables(0).Rows(nelem)("ccodcta")
                pccodcli = dscartera.Tables(0).Rows(nelem)("ccodcli")
                pctipper = dscartera.Tables(0).Rows(nelem)("ctipper")
                ldfecsol = dscartera.Tables(0).Rows(nelem)("dfecasi")
                If dscartera.Tables(0).Rows(nelem)("dfecvig") >= #7/11/2008# Then
                    clsppal.pnSegVm = Me.pnsegvm1
                Else
                    clsppal.pnSegVm = Me.pnsegvm
                End If
                pndia = dscartera.Tables(0).Rows(nelem)("ndiasug")
                ncuota = dscartera.Tables(0).Rows(nelem)("nmoncuo") 'clsppal.ValorCuotaCredtpl(pccodcta)
                pnciclo = Me.ciclo(pccodcli, pccodcta)
                cfrecuencia = clsppal.frecuencia(pctipper, pndia)

                dstipo = clsppal.Garantizados(pccodcli)
                nelemgar = dstipo.Tables(0).Rows.Count
                If nelemgar = 0 Then
                    pcgarantia = ""
                ElseIf (nelemgar = 1) Then
                    pcgarantia = dstipo.Tables(0).Rows(0)("cdescri")
                Else
                    pcgarantia = "MIXTA"
                End If

                lndias = DateDiff(DateInterval.Day, ldfecsol, dfecha)
                dscartera.Tables(0).Rows(nelem)("nmoncuo") = ncuota
                dscartera.Tables(0).Rows(nelem)("cperiodo") = cfrecuencia
                dscartera.Tables(0).Rows(nelem)("cgarantia") = pcgarantia
                dscartera.Tables(0).Rows(nelem)("nciclo") = pnciclo
                dscartera.Tables(0).Rows(nelem)("ndias") = lndias
                nelem += 1
            Next


        End If
        Return dscartera
    End Function
    Public Function ResumenMunicipios(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        dscartera = clscartera.RMunicipios(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim lnmuni As Integer
        lnmuni = dscartera.Tables(0).Rows.Count

        Dim elem As Integer
        Dim clcreditos As New dbCreditos
        Dim fila1 As DataRow
        Dim lccodzon As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        For Each fila1 In dscartera.Tables(0).Rows
            lccodzon = dscartera.Tables(0).Rows(elem)("cCodZon")
            lccodzon = lccodzon.Trim
            lncreditos = clcreditos.TotalCreditos(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                lnmonto = clcreditos.MontoTotal(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
                lnsaldo = clcreditos.SaldoTotal(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
                lncarafecta = clcreditos.Saldoafectado(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
                lncasosafec = clcreditos.casosafectado(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function

    Public Function ResumenMontos(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos
        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        dscartera = clcreditos.RMontos(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer

        Dim fila1 As DataRow

        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer

        Dim lndesde As Double
        Dim lnhasta As Double
        For Each fila1 In dscartera.Tables(0).Rows
            lndesde = dscartera.Tables(0).Rows(elem)("ndesde")
            lnhasta = dscartera.Tables(0).Rows(elem)("nhasta")
            lncreditos = clcreditos.TotalCreditos2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
            If lncreditos = 0 Then
                'dscartera.Tables(0).Rows(elem).Delete()
                'dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                lnmonto = clcreditos.MontoTotal2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
                lnsaldo = clcreditos.SaldoTotal2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
                lncarafecta = clcreditos.Saldoafectado2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
                lncasosafec = clcreditos.casosafectado2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)

                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        'dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function ResumenPlazos(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        dscartera = clscartera.RPlazos(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer
        Dim clcreditos As New dbCreditos
        Dim fila1 As DataRow

        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer

        Dim lndesde As Double
        Dim lnhasta As Double

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        For Each fila1 In dscartera.Tables(0).Rows
            lndesde = dscartera.Tables(0).Rows(elem)("ndesde")
            lnhasta = dscartera.Tables(0).Rows(elem)("nhasta")
            lncreditos = clcreditos.TotalCreditos3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
            If lncreditos = 0 Then
            Else

                lnmonto = clcreditos.MontoTotal3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
                lnsaldo = clcreditos.SaldoTotal3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
                lncarafecta = clcreditos.Saldoafectado3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
                lncasosafec = clcreditos.casosafectado3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)

                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        'dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function ResumenReserva(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        dscartera = clscartera.RReserva(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer
        Dim clcreditos As New dbCreditos
        Dim fila1 As DataRow

        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        Dim lccalif As String
        Dim lnpromedio As Double

        Dim lndesde As Double
        Dim lnhasta As Double
        For Each fila1 In dscartera.Tables(0).Rows
            lccalif = dscartera.Tables(0).Rows(elem)("ccodigo")
            lccalif = lccalif.Trim
            If lccalif = "A" Then
                lndesde = -999999999999
                lnhasta = 0
            ElseIf lccalif = "B" Then
                lndesde = 1
                lnhasta = 31
            ElseIf lccalif = "C" Then
                lndesde = 32
                lnhasta = 61
            ElseIf lccalif = "D" Then
                lndesde = 62
                lnhasta = 91
            ElseIf lccalif = "E" Then
                lndesde = 92
                lnhasta = 181
            ElseIf lccalif = "F" Then
                lndesde = 182
                lnhasta = 9999999999
            End If

            clcreditos.dbcartera = Me.cartera
            clcreditos.dbtipo = Me.tipo

            lncreditos = clcreditos.TotalCreditos4(dfecha1, dfecha2, fila1("ccodofi"), lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)

            If lncreditos = 0 Then

            Else

                lnmonto = clcreditos.MontoTotal4(dfecha1, dfecha2, fila1("ccodofi"), lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
                lnsaldo = clcreditos.SaldoTotal4(dfecha1, dfecha2, fila1("ccodofi"), lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
                lncarafecta = clcreditos.Saldoafectado4(dfecha1, dfecha2, fila1("ccodofi"), lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
                lncasosafec = clcreditos.casosafectado4(dfecha1, dfecha2, fila1("ccodofi"), lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)

                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
                If lncreditos = 0 Then
                    lnpromedio = 0
                Else
                    lnpromedio = Math.Round(lnmonto / lncreditos, 2)
                End If
                dscartera.Tables(0).Rows(elem)("npromedio") = lnpromedio


            End If

            elem += 1
        Next
        'dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function ResumenCarteraFondo(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        dscartera = clscartera.RporFondos(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer
        Dim clcreditos As New dbCreditos
        Dim fila1 As DataRow

        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        Dim lccodigo As String
        Dim lnpromedio As Double


        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("ccodigo")
            lccodigo = lccodigo.Trim

            clcreditos.dbcartera = Me.cartera
            clcreditos.dbtipo = Me.tipo

            lncreditos = clcreditos.TotalCreditos6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

            If lncreditos = 0 Then

            Else

                lnmonto = clcreditos.MontoTotal6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lnsaldo = clcreditos.SaldoTotal6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncarafecta = clcreditos.Saldoafectado6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncasosafec = clcreditos.casosafectado6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
                If lncreditos = 0 Then
                    lnpromedio = 0
                Else
                    lnpromedio = Math.Round(lnmonto / lncreditos, 2)
                End If
                dscartera.Tables(0).Rows(elem)("npromedio") = lnpromedio


            End If

            elem += 1
        Next
        'dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Public Function ActualizaCalificacion(ByVal aEntidad As creditos) As Integer
        Return mDb.ActualizaCalificacion(aEntidad)
    End Function
    Public Function CarteraCancelada(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim clscartera As New dbCreditos
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo
        Return mDb.CarteraCancelada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
    End Function
    Public Function DeudaProyectada(ByVal pccodcta As String, ByVal pdfecha As Date) As Double
        Return mDb.DeudaProyectada(pccodcta, pdfecha)
    End Function
    Public Function mensaje() As String
        Return mDb.mensaje
    End Function
    Public Function autor() As String
        Return mDb.Autor
    End Function
    Public Function CarteraEstadistica(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcsol As String, ByVal lctippre As String) As Integer
        Return mDb.CarteraEstadistica(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lcsol, lctippre)
    End Function
    Public Function CarteraEstadistica2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcsol As String, ByVal lctippre As String) As Double
        Return mDb.CarteraEstadistica2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lcsol, lctippre)
    End Function
    Public Function CarteraEstadisticaN(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcsol As String, ByVal lctippre As String) As Integer
        Return mDb.CarteraEstadisticaN(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lcsol, lctippre)
    End Function
    Public Function CarteraEstadisticaC(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcsol As String, ByVal lctippre As String) As Double
        Return mDb.CarteraEstadisticaC(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lcsol, lctippre)
    End Function
    Public Function CarteraCalculada2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo
        Return mDb.CarteraCalculada2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
    End Function
    Public Function diasAtraso(ByVal pccodcta As String, ByVal pncappag As Double, ByVal pdfecsis As Date) As Integer
        Return mDb.diasAtraso(pccodcta, pncappag, pdfecsis)
    End Function
    Public Function fxCiclo(ByVal ccodcli As String, ByVal ccodcta As String) As Integer
        Return mDb.Ciclo(ccodcli, ccodcta)
    End Function
    Public Function diashis(ByVal ccodcta As String) As Integer
        Return mDb.diashis(ccodcta)
    End Function
    Public Function ResumenActividades(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo


        dscartera = clcreditos.RActividades(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer

        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer

        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            lncreditos = clcreditos.TotalCreditos7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                lnmonto = clcreditos.MontoTotal7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lnsaldo = clcreditos.SaldoTotal7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncarafecta = clcreditos.Saldoafectado7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncasosafec = clcreditos.casosafectado7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    Public Function ResumenDestino(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        dscartera = clcreditos.RDestino(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer

        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            lncreditos = clcreditos.TotalCreditos8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "D")
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                lnmonto = clcreditos.MontoTotal8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "D")
                lnsaldo = clcreditos.SaldoTotal8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "D")
                lncarafecta = clcreditos.Saldoafectado8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "D")
                lncasosafec = clcreditos.casosafectado8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "D")
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    Public Function ResumenAnalistas(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        dscartera = clscartera.RAnalistas(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer
        Dim clcreditos As New dbCreditos
        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodusu")
            lccodigo = lccodigo.Trim
            lncreditos = clcreditos.TotalCreditos9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                lnmonto = clcreditos.MontoTotal9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lnsaldo = clcreditos.SaldoTotal9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncarafecta = clcreditos.Saldoafectado9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncasosafec = clcreditos.casosafectado9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function

    '>>>>>>>>>>>><
    Public Function ResumenGenero(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        dscartera = clscartera.RGenero(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer
        Dim clcreditos As New dbCreditos
        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            lncreditos = clcreditos.TotalCreditos10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                lnmonto = clcreditos.MontoTotal10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lnsaldo = clcreditos.SaldoTotal10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncarafecta = clcreditos.Saldoafectado10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncasosafec = clcreditos.casosafectado10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function ResumenOficina(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        dscartera = clscartera.ROficina(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer
        Dim clcreditos As New dbCreditos
        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            lncreditos = clcreditos.TotalCreditos11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                lnmonto = clcreditos.MontoTotal11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lnsaldo = clcreditos.SaldoTotal11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncarafecta = clcreditos.Saldoafectado11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                lncasosafec = clcreditos.casosafectado11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    Public Function CarteraCalculada1(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccodcli, nmeses, nciclo, ntasint,ctipcuo,cflat,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,I,I,D,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)
        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)
        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        Dim lnciclo As Integer
        Dim ldfecvig As Date
        Dim ldfecven As Date
        Dim lnmeses As Integer
        nn = dscartera.Tables(0).Rows.Count

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                lnciclo = clscartera.Ciclo(drcartera("ccodcli"), drcartera("ccodcta"))
                ldfecvig = drcartera("dfecvig")
                ldfecven = drcartera("dfecven")
                lnmeses = DateDiff(DateInterval.Month, ldfecvig, ldfecven)
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                If lcestrato <> "*" Then
                    'calculo de mora  dias de atraso menores que cero
                    If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                        drmora = lcMORA.NewRow()
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("nsalcap") = Math.Round(drcartera("ncapdes") - drcartera("ncappag"), 2)
                        drmora("nciclo") = lnciclo
                        drmora("nmeses") = lnmeses
                        drmora("ccodcli") = drcartera("ccodcli")
                        drmora("ctipcuo") = drcartera("ctipcuo")
                        drmora("cflat") = drcartera("cflat")

                        lcMORA.Rows.Add(drmora)
                    End If
                Else
                    'no filtra dias de atraso
                    lnsalintmor = 0
                    drmora = lcMORA.NewRow()
                    drmora("nsalintmor") = clsaplica.pnsalmor
                    drmora("ccodcta") = drcartera("ccodcta")
                    drmora("cnomcli") = drcartera("cnomcli")
                    drmora("ncapdes") = drcartera("ncapdes")
                    drmora("dfecvig") = drcartera("dfecvig")
                    drmora("dfecven") = drcartera("dfecven")
                    drmora("ntasint") = drcartera("ntasint")
                    drmora("nsalcap") = Math.Round(drcartera("ncapdes") - drcartera("ncappag"), 2)
                    drmora("nciclo") = lnciclo
                    drmora("nmeses") = lnmeses
                    drmora("ccodcli") = drcartera("ccodcli")
                    drmora("ctipcuo") = drcartera("ctipcuo")
                    drmora("cflat") = drcartera("cflat")

                    lcMORA.Rows.Add(drmora)
                End If
            End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>

        Return dsmora

    End Function
    Public Function CarteraCalculada50(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0


        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, ccodsol, cnomgru,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)
        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)
        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        nn = dscartera.Tables(0).Rows.Count

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                    'lncuota = clsaplica.pnmoncuo

                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                            If Math.Round((clsaplica.pncapdes - clsaplica.pncappag), 2) <= Math.Round((clsaplica.pncapdes / 2), 2) Then

                                drmora = lcMORA.NewRow()
                                drmora("ccodcta") = drcartera("ccodcta")
                                drmora("cnomcli") = drcartera("cnomcli")
                                drmora("ncapdes") = drcartera("ncapdes")
                                drmora("dfecvig") = drcartera("dfecvig")
                                drmora("ccodsol") = drcartera("ccodsol")
                                drmora("cnomgru") = drcartera("cnomgru")
                                drmora("dfecven") = drcartera("dfecven")
                                drmora("ntasint") = drcartera("ntasint")
                                drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                                drmora("dultpag") = clsaplica.pdultpag
                                drmora("ncuota") = clsaplica.pnmoncuo
                                drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                drmora("ncuota") = lncuota
                                drmora("ccalifica") = lccalifica
                                drmora("ccalificades") = lcestrdes
                                drmora("cfiador") = lcdatosfia

                                If IsDBNull(drmora("ncapmora")) Then
                                    drmora("ncapmora") = 0
                                End If

                                If drmora("ncapmora") < 0 Then
                                    drmora("ncapmora") = 0
                                End If

                                drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                drmora("ndiaatr") = clsaplica.pndiaatr
                                drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                                'calculos de los seguros
                                ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                entidadcretlin.cnrolin = clsaplica.cnrolin
                                ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                pccodlin = entidadcretlin.ccodlin
                                lsegdeu = entidadcretlin.lsegdeu

                                lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                                'If pccodlin.Substring(8, 2) = "06" Then
                                '    lngasadm = 0
                                'Else
                                '    If clsaplica.pdfecvig > #11/1/2005# Then
                                '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                                '    Else
                                '        lngasadm = 0
                                '    End If
                                'End If
                                'If lsegdeu = True Then
                                '    If clsaplica.pdfecvig >= #7/11/2008# Then
                                '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                                '    Else
                                '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                                '    End If

                                'Else
                                '    lnsegdeu = 0
                                'End If
                                lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                                lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                                lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                                lngasadm = lnmanejo + lniva


                                drmora("ncomision") = lngasadm
                                drmora("nsegdeu") = lnsegdeu
                                drmora("nseguros") = 0
                                'finaliza calculo de los seguros
                                lcMORA.Rows.Add(drmora)
                            End If
                        End If


                    Else
                        'no filtra dias de atraso
                        If Math.Round((clsaplica.pncapdes - clsaplica.pncappag), 2) <= Math.Round((clsaplica.pncapdes / 2), 2) Then
                            lnsalintmor = 0
                            drmora = lcMORA.NewRow()
                            drmora("nsalintmor") = clsaplica.pnsalmor
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfecvig")
                            drmora("ccodsol") = drcartera("ccodsol")
                            drmora("cnomgru") = drcartera("cnomgru")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("ncuota") = lncuota
                            drmora("ccalifica") = lccalifica
                            drmora("ccalificades") = lcestrdes
                            drmora("cfiador") = lcdatosfia

                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr

                            'calculos de los seguros

                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If
                            lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                            lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva


                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0


                            'finaliza calculo de los seguros


                            lcMORA.Rows.Add(drmora)
                        End If
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function
    Public Function Decersion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim clscartera As New dbCreditos
        Dim ds As New DataSet
        clscartera.dbtipo = Me.tipo
        ds = mDb.Decersion(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
        Return ds
    End Function
    Public Function ResumenSector(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        clcreditos.dbmonto = 0
        clcreditos.dbsaldo = 0
        clcreditos.dbafectada = 0
        clcreditos.dbcasos = 0

        dscartera = clcreditos.RSector(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer

        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        Dim lnhombres As Integer = 0
        Dim lnmujeres As Integer = 0
        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            lncreditos = clcreditos.TotalCreditos8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "S")
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else
                clcreditos.Carteraxsector(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "S")
                lnmonto = clcreditos.dbmonto
                lnsaldo = clcreditos.dbsaldo
                lncarafecta = clcreditos.dbafectada
                lncasosafec = clcreditos.dbcasos
                lnhombres = clcreditos.dbhombres
                lnmujeres = clcreditos.dbmujeres
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
                dscartera.Tables(0).Rows(elem)("nhombres") = lnhombres
                dscartera.Tables(0).Rows(elem)("nmujeres") = lnmujeres
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function

    Public Function Estado(ByVal dfecha2 As Date, ByVal ccodcta As String) As String
        Return mDb.Estado(dfecha2, ccodcta)
    End Function

    Public Function ResumenGarantia(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        clcreditos.dbmonto = 0
        clcreditos.dbsaldo = 0
        clcreditos.dbafectada = 0
        clcreditos.dbcasos = 0

        dscartera = clcreditos.RGarantia(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer

        Dim fila1 As DataRow


        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer

        Dim dsg1 As New DataSet
        Dim dsg2 As New DataSet

        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            'lncreditos = clcreditos.TotalCreditos12(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "G")
            dsg1 = clcreditos.TotalCreditos12(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "G")
            dsg2 = Me.depura(dsg1, lccodigo)
            lncreditos = dsg2.Tables(0).Rows.Count

            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else
                'dsg3 = clcreditos.Carteraxgarantia(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "G")
                'dsg4 = Me.depura(dsg3, lccodigo)
                '----------------------
                Dim lnmontot As Double = 0
                Dim lnmonto4 As Double = 0
                Dim lncapdes As Double = 0
                Dim lncappag As Double = 0
                Dim lnpagteo As Double = 0
                Dim lnsalteo As Double = 0
                Dim lncasos As Integer = 0
                Dim pccodcta As String
                Dim pndias As Integer
                Dim lnsaldot As Double = 0
                Dim lncapdest As Double = 0

                If dsg2.Tables(0).Rows.Count = 0 Then
                    lnmontot = 0
                Else
                    Dim fila4 As DataRow
                    Dim elem4 As Integer = 0
                    For Each fila4 In dsg2.Tables(0).Rows
                        lncapdes = dsg2.Tables(0).Rows(elem4)("ncapdes")
                        lncappag = dsg2.Tables(0).Rows(elem4)("ncappag")
                        lnpagteo = dsg2.Tables(0).Rows(elem4)("npagteo")
                        lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                        lnmonto4 = lncapdes - lncappag
                        pccodcta = dsg2.Tables(0).Rows(elem4)("ccodcta")
                        pndias = clcreditos.diasAtraso(pccodcta, lncappag, dfecha2)

                        lncapdest = lncapdest + lncapdes
                        lnsaldot = lnsaldot + lnmonto4
                        If lnmonto4 > lnsalteo And pndias > 30 Then
                            lncasos += 1
                            lnmontot = lnmontot + lnmonto4
                        End If
                        elem4 += 1
                    Next
                End If

                '----------------------
                lnmonto = lncapdest
                lnsaldo = lnsaldot
                lncarafecta = lnmontot
                lncasosafec = lncasos

                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            dsg1.Clear()
            dsg2.Clear()
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    Public Function tipogarantia(ByVal ccodcli As String) As String
        Dim dstipo As New DataSet
        Dim mcrepgar As New cCrepgar
        Dim nelemgar As Integer
        Dim clase As New SIM.bl.class1
        Dim lctipo As String
        dstipo = clase.Garantizados(ccodcli)

        nelemgar = dstipo.Tables(0).Rows.Count
        If nelemgar = 0 Then
            lctipo = "00"
        ElseIf (nelemgar = 1) Then
            lctipo = dstipo.Tables(0).Rows(0)("ctipgar")
        Else
            If dstipo.Tables(0).Rows(0)("ctipgar") = "05" Then
                lctipo = "05"
            Else
                lctipo = "04"
            End If
        End If
        Return lctipo
    End Function
    Public Function depura(ByVal ds As DataSet, ByVal ccodigo As String) As DataSet
        Dim fila2 As DataRow
        Dim elem2 As Integer
        Dim lctipo As String
        Dim lccodcli As String
        Dim lccodcta As String
        Dim clsppal As New class1
        For Each fila2 In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(elem2)("ccodcta")
            lctipo = clsppal.ObtenerCodigoGarantia(lccodcta)

            'lctipo = Me.tipogarantia(lccodcli)
            If ccodigo = lctipo Then
            Else
                ds.Tables(0).Rows(elem2).Delete()
                ds.Tables(0).GetChanges(DataRowState.Deleted)
            End If
            elem2 += 1
        Next
        ds.Tables(0).AcceptChanges()
        Return ds
    End Function

    Public Function ResumenEdad(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim dt As New DataTable
        Dim dredad As DataRow
        Dim clsppal As New class1
        Dim dsedad As New DataSet

        lcampos1 = "cCodigo, Edad, nmonto, nsaldo, ncreditos, ncarafecta, ncasosafec, "
        ltipos1 = "S,S,D,D,I,D,I,"
        dt = clsppal.creadatasetdesconec(lcampos1, ltipos1, "edad")


        dredad = dt.NewRow
        dredad("cCodigo") = "A"
        dredad("Edad") = "Hasta 21 años"
        dredad("nmonto") = 0
        dredad("nsaldo") = 0
        dredad("ncreditos") = 0
        dredad("ncarafecta") = 0
        dredad("ncasosafec") = 0
        dt.Rows.Add(dredad)

        dredad = dt.NewRow
        dredad("cCodigo") = "B"
        dredad("Edad") = "Mayores de 21 hasta 30"
        dredad("nmonto") = 0
        dredad("nsaldo") = 0
        dredad("ncreditos") = 0
        dredad("ncarafecta") = 0
        dredad("ncasosafec") = 0
        dt.Rows.Add(dredad)

        dredad = dt.NewRow
        dredad("cCodigo") = "C"
        dredad("Edad") = "Mayores de 30 hasta 40"
        dredad("nmonto") = 0
        dredad("nsaldo") = 0
        dredad("ncreditos") = 0
        dredad("ncarafecta") = 0
        dredad("ncasosafec") = 0
        dt.Rows.Add(dredad)

        dredad = dt.NewRow
        dredad("cCodigo") = "D"
        dredad("Edad") = "Mayores de 40 hasta 50"
        dredad("nmonto") = 0
        dredad("nsaldo") = 0
        dredad("ncreditos") = 0
        dredad("ncarafecta") = 0
        dredad("ncasosafec") = 0
        dt.Rows.Add(dredad)

        dredad = dt.NewRow
        dredad("cCodigo") = "E"
        dredad("Edad") = "Mayores de 50 hasta 60"
        dredad("nmonto") = 0
        dredad("nsaldo") = 0
        dredad("ncreditos") = 0
        dredad("ncarafecta") = 0
        dredad("ncasosafec") = 0
        dt.Rows.Add(dredad)

        dredad = dt.NewRow
        dredad("cCodigo") = "F"
        dredad("Edad") = "Mayores de 60 años"
        dredad("nmonto") = 0
        dredad("nsaldo") = 0
        dredad("ncreditos") = 0
        dredad("ncarafecta") = 0
        dredad("ncasosafec") = 0
        dt.Rows.Add(dredad)

        dsedad.Tables.Add(dt)
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim dscartera As New DataSet
        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        clcreditos.dbmonto = 0
        clcreditos.dbsaldo = 0
        clcreditos.dbafectada = 0
        clcreditos.dbcasos = 0

        dscartera = dsedad 'clcreditos.RSector(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer

        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            lncreditos = clcreditos.TotalCreditos13(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "S")
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else
                clcreditos.Carteraxedad(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "S")
                lnmonto = clcreditos.dbmonto
                lnsaldo = clcreditos.dbsaldo
                lncarafecta = clcreditos.dbafectada
                lncasosafec = clcreditos.dbcasos
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function

    Public Function Resumensecuencia(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim dt As New DataTable

        Dim dt2 As New DataTable
        Dim drsecuencia As DataRow
        Dim drsecuencia1 As DataRow
        Dim drsecuencia2 As DataRow
        Dim clsppal As New class1
        Dim dssecuencia As New DataSet

        Dim dsdisparador As New DataSet
        Dim maximo, i As Integer
        maximo = Me.maxCiclo()

        lcampos1 = "cCodigo, Secuencia, nmonto, nsaldo, ncreditos, ncarafecta, ncasosafec, "
        ltipos1 = "S,S,D,D,I,D,I,"
        dt = clsppal.creadatasetdesconec(lcampos1, ltipos1, "secuencia")
        dt2 = clsppal.creadatasetdesconec(lcampos1, ltipos1, "secuencia1")

        lcampos1 = "cCodcta, cCodcli, nCapdes, ncappag, npagteo,"
        ltipos1 = "S,S,D,D,D,"

        For i = 1 To maximo
            drsecuencia = dt.NewRow
            drsecuencia("cCodigo") = i.ToString
            drsecuencia("secuencia") = i.ToString
            drsecuencia("nmonto") = 0
            drsecuencia("nsaldo") = 0
            drsecuencia("ncreditos") = 0
            drsecuencia("ncarafecta") = 0
            drsecuencia("ncasosafec") = 0
            dt.Rows.Add(drsecuencia)
        Next
        Dim dscartera As New DataSet
        dscartera.Tables.Add(dt)
        'dsdisparador.Tables.Add(dt1)

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        clcreditos.dbmonto = 0
        clcreditos.dbsaldo = 0
        clcreditos.dbafectada = 0
        clcreditos.dbcasos = 0

        '  dscartera = dssecuencia 'clcreditos.RSector(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer = 0

        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer

        Dim dstmp As New DataSet
        '        Dim dsselect As New DataSet

        Dim lnciclo As Integer

        dstmp = clcreditos.TotalCreditos14(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "S")
        Dim itmp As Integer
        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            Dim dsselect As New DataSet
            dsselect.Clear()
            dsselect.Tables.Clear()
            Dim dt1 As New DataTable
            dt1 = clsppal.creadatasetdesconec(lcampos1, ltipos1, "secuencia1")
            itmp = dstmp.Tables(0).Rows.Count

            ' dsselect = dstmp
            'Ciclea data set
            If dstmp.Tables(0).Rows.Count > 0 Then
                Dim fila As DataRow
                Dim ele As Integer = 0
                Dim lnciclo1 As Integer
                Dim lccodcta As String
                Dim lccodcli As String

                lnciclo = Integer.Parse(lccodigo)
                For Each fila In dstmp.Tables(0).Rows
                    lccodcli = dstmp.Tables(0).Rows(ele)("ccodcli")
                    lccodcta = dstmp.Tables(0).Rows(ele)("ccodcta")
                    lnciclo1 = clcreditos.Ciclo(lccodcli, lccodcta)

                    If lnciclo1 = lnciclo Then
                        drsecuencia1 = dt1.NewRow
                        drsecuencia1("ncapdes") = dstmp.Tables(0).Rows(ele)("ncapdes")
                        drsecuencia1("ncappag") = dstmp.Tables(0).Rows(ele)("ncappag")
                        drsecuencia1("npagteo") = dstmp.Tables(0).Rows(ele)("npagteo")
                        drsecuencia1("ccodcta") = dstmp.Tables(0).Rows(ele)("ccodcta")
                        drsecuencia1("ccodcli") = dstmp.Tables(0).Rows(ele)("ccodcli")
                        dt1.Rows.Add(drsecuencia1)
                    Else
                        'dsselect.Tables(0).Rows(ele).Delete()
                        'dsselect.Tables(0).GetChanges(DataRowState.Deleted)
                    End If
                    ele += 1
                Next
                dsselect.Tables.Add(dt1)
                'dt1.Clear()
                'dt1.Reset()
                'dsselect.Tables(0).AcceptChanges()
            End If

            '>>>>>>>>>>>>>>>>>>>>>>>><
            lncreditos = dsselect.Tables(0).Rows.Count 'clcreditos.TotalCreditos14(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "S")

            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem)("nmonto") = 0
                dscartera.Tables(0).Rows(elem)("nsaldo") = 0
                dscartera.Tables(0).Rows(elem)("ncreditos") = 0
                dscartera.Tables(0).Rows(elem)("ncarafecta") = 0
                dscartera.Tables(0).Rows(elem)("ncasosafec") = 0
                '       dscartera.Tables(0).Rows(elem).Delete()
                '      dscartera.Tables(0).GetChanges(DataRowState.Deleted)

            Else
                clcreditos.Carteraxsecuencia(dsselect, dfecha2)
                lnmonto = clcreditos.dbmonto
                lnsaldo = clcreditos.dbsaldo
                lncarafecta = clcreditos.dbafectada
                lncasosafec = clcreditos.dbcasos
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        'dscartera.Tables(0).AcceptChanges()
        elem = 0

        Dim fila2 As DataRow
        Dim lncre As Integer = 0

        For Each fila2 In dscartera.Tables(0).Rows
            lncre = dscartera.Tables(0).Rows(elem)("ncreditos")
            If lncre = 0 Then
            Else
                drsecuencia2 = dt2.NewRow
                drsecuencia2("cCodigo") = dscartera.Tables(0).Rows(elem)("cCodigo")
                drsecuencia2("secuencia") = dscartera.Tables(0).Rows(elem)("secuencia")
                drsecuencia2("nmonto") = dscartera.Tables(0).Rows(elem)("nmonto")
                drsecuencia2("nsaldo") = dscartera.Tables(0).Rows(elem)("nsaldo")
                drsecuencia2("ncreditos") = dscartera.Tables(0).Rows(elem)("ncreditos")
                drsecuencia2("ncarafecta") = dscartera.Tables(0).Rows(elem)("ncarafecta")
                drsecuencia2("ncasosafec") = dscartera.Tables(0).Rows(elem)("ncasosafec")
                dt2.Rows.Add(drsecuencia2)
            End If
            elem += 1
        Next
        dsdisparador.Tables.Add(dt2)

        Return dsdisparador
    End Function
    Public Function maxCiclo() As Integer
        Return mDb.maxCiclo()
    End Function
    Public Function ResumenTipo(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim dt As New DataTable

        Dim dt2 As New DataTable
        Dim drsecuencia As DataRow
        Dim drsecuencia1 As DataRow
        Dim drsecuencia2 As DataRow
        Dim clsppal As New class1
        Dim dssecuencia As New DataSet

        Dim dsdisparador As New DataSet
        Dim maximo, i As Integer
        ' maximo = Me.maxCiclo()

        lcampos1 = "cCodigo, Secuencia, nmonto, nsaldo, ncreditos, ncarafecta, ncasosafec, "
        ltipos1 = "S,S,D,D,I,D,I,"
        dt = clsppal.creadatasetdesconec(lcampos1, ltipos1, "secuencia")
        dt2 = clsppal.creadatasetdesconec(lcampos1, ltipos1, "secuencia1")

        lcampos1 = "cCodcta, cCodcli, nCapdes, ncappag, npagteo,"
        ltipos1 = "S,S,D,D,D,"

        'For i = 1 To maximo
        drsecuencia = dt.NewRow
        drsecuencia("cCodigo") = "A"
        drsecuencia("secuencia") = "NUEVO"
        drsecuencia("nmonto") = 0
        drsecuencia("nsaldo") = 0
        drsecuencia("ncreditos") = 0
        drsecuencia("ncarafecta") = 0
        drsecuencia("ncasosafec") = 0
        dt.Rows.Add(drsecuencia)

        drsecuencia = dt.NewRow
        drsecuencia("cCodigo") = "B"
        drsecuencia("secuencia") = "RECURRENTE"
        drsecuencia("nmonto") = 0
        drsecuencia("nsaldo") = 0
        drsecuencia("ncreditos") = 0
        drsecuencia("ncarafecta") = 0
        drsecuencia("ncasosafec") = 0
        dt.Rows.Add(drsecuencia)

        'Next
        Dim dscartera As New DataSet
        dscartera.Tables.Add(dt)
        'dsdisparador.Tables.Add(dt1)

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        clcreditos.dbmonto = 0
        clcreditos.dbsaldo = 0
        clcreditos.dbafectada = 0
        clcreditos.dbcasos = 0

        '  dscartera = dssecuencia 'clcreditos.RSector(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer = 0

        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer

        Dim dstmp As New DataSet
        '        Dim dsselect As New DataSet

        Dim lnciclo As Integer

        dstmp = clcreditos.TotalCreditos14(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "S")
        Dim itmp As Integer
        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            Dim dsselect As New DataSet
            dsselect.Clear()
            dsselect.Tables.Clear()
            Dim dt1 As New DataTable
            dt1 = clsppal.creadatasetdesconec(lcampos1, ltipos1, "secuencia1")
            itmp = dstmp.Tables(0).Rows.Count

            ' dsselect = dstmp
            'Ciclea data set
            If dstmp.Tables(0).Rows.Count > 0 Then
                Dim fila As DataRow
                Dim ele As Integer = 0
                Dim lnciclo1 As Integer
                Dim lccodcta As String
                Dim lccodcli As String

                'lnciclo = Integer.Parse(lccodigo)
                For Each fila In dstmp.Tables(0).Rows
                    lccodcli = dstmp.Tables(0).Rows(ele)("ccodcli")
                    lccodcta = dstmp.Tables(0).Rows(ele)("ccodcta")
                    lnciclo1 = clcreditos.Ciclo(lccodcli, lccodcta)
                    If lccodigo = "A" Then
                        If lnciclo1 <= 1 Then
                            drsecuencia1 = dt1.NewRow
                            drsecuencia1("ncapdes") = dstmp.Tables(0).Rows(ele)("ncapdes")
                            drsecuencia1("ncappag") = dstmp.Tables(0).Rows(ele)("ncappag")
                            drsecuencia1("npagteo") = dstmp.Tables(0).Rows(ele)("npagteo")
                            drsecuencia1("ccodcta") = dstmp.Tables(0).Rows(ele)("ccodcta")
                            drsecuencia1("ccodcli") = dstmp.Tables(0).Rows(ele)("ccodcli")
                            dt1.Rows.Add(drsecuencia1)
                        End If
                    Else
                        If lnciclo1 > 1 Then
                            drsecuencia1 = dt1.NewRow
                            drsecuencia1("ncapdes") = dstmp.Tables(0).Rows(ele)("ncapdes")
                            drsecuencia1("ncappag") = dstmp.Tables(0).Rows(ele)("ncappag")
                            drsecuencia1("npagteo") = dstmp.Tables(0).Rows(ele)("npagteo")
                            drsecuencia1("ccodcta") = dstmp.Tables(0).Rows(ele)("ccodcta")
                            drsecuencia1("ccodcli") = dstmp.Tables(0).Rows(ele)("ccodcli")
                            dt1.Rows.Add(drsecuencia1)
                        End If
                    End If
                    ele += 1
                Next
                dsselect.Tables.Add(dt1)
            End If

            '>>>>>>>>>>>>>>>>>>>>>>>><
            lncreditos = dsselect.Tables(0).Rows.Count 'clcreditos.TotalCreditos14(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "S")

            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem)("nmonto") = 0
                dscartera.Tables(0).Rows(elem)("nsaldo") = 0
                dscartera.Tables(0).Rows(elem)("ncreditos") = 0
                dscartera.Tables(0).Rows(elem)("ncarafecta") = 0
                dscartera.Tables(0).Rows(elem)("ncasosafec") = 0
                '       dscartera.Tables(0).Rows(elem).Delete()
                '      dscartera.Tables(0).GetChanges(DataRowState.Deleted)

            Else
                clcreditos.Carteraxsecuencia(dsselect, dfecha2)
                lnmonto = clcreditos.dbmonto
                lnsaldo = clcreditos.dbsaldo
                lncarafecta = clcreditos.dbafectada
                lncasosafec = clcreditos.dbcasos
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        'dscartera.Tables(0).AcceptChanges()
        elem = 0

        Dim fila2 As DataRow
        Dim lncre As Integer = 0

        For Each fila2 In dscartera.Tables(0).Rows
            lncre = dscartera.Tables(0).Rows(elem)("ncreditos")
            If lncre = 0 Then
            Else
                drsecuencia2 = dt2.NewRow
                drsecuencia2("cCodigo") = dscartera.Tables(0).Rows(elem)("cCodigo")
                drsecuencia2("secuencia") = dscartera.Tables(0).Rows(elem)("secuencia")
                drsecuencia2("nmonto") = dscartera.Tables(0).Rows(elem)("nmonto")
                drsecuencia2("nsaldo") = dscartera.Tables(0).Rows(elem)("nsaldo")
                drsecuencia2("ncreditos") = dscartera.Tables(0).Rows(elem)("ncreditos")
                drsecuencia2("ncarafecta") = dscartera.Tables(0).Rows(elem)("ncarafecta")
                drsecuencia2("ncasosafec") = dscartera.Tables(0).Rows(elem)("ncasosafec")
                dt2.Rows.Add(drsecuencia2)
            End If
            elem += 1
        Next
        dsdisparador.Tables.Add(dt2)

        Return dsdisparador
    End Function

    Public Function Proyeccion_Cuotas(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsppal As New class1
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        dscartera = clcreditos.CarteraCalculada15(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
        Return dscartera
    End Function

    Public Function DETALLE_CARTERA_Y_PAGOS_Extorno(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo

        Return mDb.DETALLE_CARTERA_Y_PAGOS_Extorno(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona)
    End Function
    Public Function Resumen_Mensual_Recuperaciones(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo
        Return mDb.Resumen_Mensual_Recuperaciones(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona)
    End Function

    Public Function Resumen_Anual_Recuperaciones(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo

        Return mDb.Resumen_Anual_Recuperaciones(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona)
    End Function

    Public Function Resumen_Mensual_Colocacion(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo
        Return mDb.Resumen_Mensual_Colocacion(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona)
    End Function

    Public Function Resumen_Anual_Colocacion(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo
        Return mDb.Resumen_Anual_Colocacion(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona)
    End Function

    Public Function Proyeccion_Cuotas_porCredito(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsppal As New class1
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        dscartera = clcreditos.CarteraCalculada16(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
        Dim fila As DataRow
        'Dim lnsegdeu As Double = 0
        Dim lnmonto As Double = 0
        Dim lniva As Double = 0
        Dim lnintere As Double = 0
        Dim lncomision As Double = 0
        Dim clsaplica As New payment
        Dim ok As Integer = 0
        'Esta parte la cancele por que saca interes por cuenta y
        ' lo estamos realizadon por grupos y asi no aplica
        '----------------------------------------------------
        'For Each fila In dscartera.Tables(0).Rows
        '    clsaplica.pccodcta = fila("cCodcta")
        '    clsaplica.pdfecval = fila("dfecven")
        '    clsaplica.gdfecsis = fila("dfecven")
        '    clsaplica.gnperbas = Me.pnperbas
        '    clsaplica.gdultpag = #2/1/1970#
        '    If fila("dfecven") >= #7/11/2008# Then
        '        clsaplica.porsegdeu = Me.pnsegvm1
        '    Else
        '        clsaplica.porsegdeu = Me.pnsegvm
        '    End If

        '    clsaplica.porcomision = Me.pncomtra
        '    clsaplica.pcestado = "F"
        '    clsaplica.gnpergra = Me.gnpergra
        '    ok = clsaplica.omcalcinterest("R", dfecha2)



        '    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        '    If ok = 9 Then
        '    Else
        '        fila("nintere") = clsaplica.pnsalint
        '    End If

        '    fila("ncomision") = 0
        '    fila("nseguro") = 0
        'Next
        Return dscartera
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    '/****** Object:  Reporte Modificado Agreado
    '[rbtnprorec1551.Checked] Script Date: 06/29/2015 17:17:30 modificacion solo por cuentas ******/
    Public Function Proyeccion_Cuotas_porCredito551(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsppal As New class1
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        dscartera = clcreditos.CarteraCalculada16_551(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
        Dim fila As DataRow
        'Dim lnsegdeu As Double = 0
        Dim lnmonto As Double = 0
        Dim lniva As Double = 0
        Dim lnintere As Double = 0
        Dim lncomision As Double = 0
        Dim clsaplica As New payment
        Dim ok As Integer = 0
        Dim NcapMoraXCLi As Double
        'Obtiene el capital moratorio por cuentas 

        'For Each rowDs As DataRow In dscartera.Tables(0).Rows

        '    NcapMoraXCLi = clcreditos.ObtieneCpMoratorixCliente(rowDs("ccodcta"), dfecha2)
        'Next




        ''/****** Object:  Reporte Modificado Agreado
        ''[rbtnprorec1551.Checked] Script Date: 06/29/2015 17:17:30 revisar en caso de que no cuadre algo ******/
        'For Each fila In dscartera.Tables(0).Rows
        '    clsaplica.pccodcta = fila("cCodcta")
        '    clsaplica.pdfecval = fila("dfecven")
        '    clsaplica.gdfecsis = fila("dfecven")
        '    clsaplica.gnperbas = Me.pnperbas
        '    clsaplica.gdultpag = #2/1/1970#
        '    If fila("dfecven") >= #7/11/2008# Then
        '        clsaplica.porsegdeu = Me.pnsegvm1
        '    Else
        '        clsaplica.porsegdeu = Me.pnsegvm
        '    End If

        '    clsaplica.porcomision = Me.pncomtra
        '    clsaplica.pcestado = "F"
        '    clsaplica.gnpergra = Me.gnpergra
        '    ok = clsaplica.omcalcinterest("R", dfecha2)
        '    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        '    If ok = 9 Then
        '    Else
        '        fila("nintere") = clsaplica.pnsalint
        '    End If

        '    fila("ncomision") = 0
        '    fila("nseguro") = 0
        'Next
        ''retorno de set
        Return dscartera
    End Function
    Public Function ObtieneCpMoratorixCliente(ByVal ccodcta As String, ByVal fecha2 As Date) As Double

        Return mDb.ObtieneCpMoratorixCliente(ccodcta, fecha2)
    End Function
    'Funcion para reporte 55.1
    Public Function Proyeccion_Cuotas_porCredito55_1(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsppal As New class1
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        dscartera = clcreditos.CarteraCalculada1655_1(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
        Dim fila As DataRow
        'Dim lnsegdeu As Double = 0
        Dim lnmonto As Double = 0
        Dim lniva As Double = 0
        Dim lnintere As Double = 0
        Dim lncomision As Double = 0
        Dim clsaplica As New payment
        Dim ok As Integer = 0

        Return dscartera
    End Function



    Public Function CarteraCalculada17(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal cflag As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "cSecEco, ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, cDescri,"
        ltipos1 = "S,S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)
        dscartera = clscartera.CarteraCalculada17(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, cflag)
        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        nn = dscartera.Tables(0).Rows.Count

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                    'lncuota = clsaplica.pnmoncuo

                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                            drmora = lcMORA.NewRow()
                            drmora("cSecEco") = drcartera("cSecECo")
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfecvig")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("cDescri") = drcartera("cDescri")
                            drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncuota") = lncuota
                            drmora("ccalifica") = drcartera("csececo") 'lccalifica
                            drmora("ccalificades") = drcartera("cDescri") 'lcestrdes
                            drmora("cfiador") = lcdatosfia

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If

                            lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                            lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva


                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0
                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("cSecEco") = drcartera("cSecECo")
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("cDescri") = drcartera("cDescri")
                        drmora("ncuota") = lncuota
                        drmora("ccalifica") = drcartera("csececo") 'lccalifica
                        drmora("ccalificades") = drcartera("cDescri") 'lcestrdes
                        drmora("cfiador") = lcdatosfia

                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr

                        'calculos de los seguros

                        ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        entidadcretlin.cnrolin = clsaplica.cnrolin
                        ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = entidadcretlin.ccodlin
                        lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        'If pccodlin.Substring(8, 2) = "06" Then
                        '    lngasadm = 0
                        'Else
                        '    If clsaplica.pdfecvig > #11/1/2005# Then
                        '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                        '    Else
                        '        lngasadm = 0
                        '    End If
                        'End If
                        'If lsegdeu = True Then
                        '    If clsaplica.pdfecvig >= #7/11/2008# Then
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                        '    Else
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                        '    End If

                        'Else
                        '    lnsegdeu = 0
                        'End If

                        lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                        lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva


                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0


                        'finaliza calculo de los seguros


                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function

    Public Function CarteraCalculada18(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal cflag As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "cSecEco, ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, cDescri,"
        ltipos1 = "S,S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,D,S,S,D,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")
        Dim lncapdes As Double
        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)
        dscartera = clscartera.CarteraCalculada18(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, cflag)
        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        nn = dscartera.Tables(0).Rows.Count

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                    'lncuota = clsaplica.pnmoncuo

                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                            drmora = lcMORA.NewRow()
                            drmora("cSecEco") = drcartera("cSecECo")
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfecvig")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("cDescri") = drcartera("cDescri")
                            drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncuota") = lncuota


                            drmora("ccalifica") = clscartera.RangoMontoD(drcartera("ncapdes"))
                            drmora("ccalificades") = clscartera.RangoMonto(drcartera("ncapdes"))
                            drmora("cfiador") = lcdatosfia

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If
                            lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                            lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva


                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0
                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("cSecEco") = drcartera("cSecECo")
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("cDescri") = drcartera("cDescri")
                        drmora("ncuota") = lncuota

                        drmora("ccalifica") = clscartera.RangoMontoD(drcartera("ncapdes"))
                        drmora("ccalificades") = clscartera.RangoMonto(drcartera("ncapdes"))

                        drmora("cfiador") = lcdatosfia

                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr

                        'calculos de los seguros

                        ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        entidadcretlin.cnrolin = clsaplica.cnrolin
                        ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = entidadcretlin.ccodlin
                        lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        'If pccodlin.Substring(8, 2) = "06" Then
                        '    lngasadm = 0
                        'Else
                        '    If clsaplica.pdfecvig > #11/1/2005# Then
                        '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                        '    Else
                        '        lngasadm = 0
                        '    End If
                        'End If
                        'If lsegdeu = True Then
                        '    If clsaplica.pdfecvig >= #7/11/2008# Then
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                        '    Else
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                        '    End If

                        'Else
                        '    lnsegdeu = 0
                        'End If
                        lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                        lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva


                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0


                        'finaliza calculo de los seguros


                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function

    Public Function CarteraCalculada19(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal cflag As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "cSecEco, ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, cDescri,"
        ltipos1 = "S,S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)
        dscartera = clscartera.CarteraCalculada18(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, cflag)
        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0
        Dim nn As Integer
        Dim lctipgar As String
        Dim etabttab As New cTabttab
        nn = dscartera.Tables(0).Rows.Count

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                    'lncuota = clsaplica.pnmoncuo

                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                            drmora = lcMORA.NewRow()
                            drmora("cSecEco") = drcartera("cSecECo")
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfecvig")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("cDescri") = drcartera("cDescri")
                            drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncuota") = lncuota


                            lctipgar = drcartera("ctipgar") 'clsppal.ObtenerCodigoGarantia(drcartera("ccodcta"))
                            drmora("ccalifica") = lctipgar
                            drmora("ccalificades") = etabttab.Describe(lctipgar, "074")

                            drmora("cfiador") = lcdatosfia

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If

                            lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                            lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva


                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0
                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("cSecEco") = drcartera("cSecECo")
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("cDescri") = drcartera("cDescri")
                        drmora("ncuota") = lncuota

                        lctipgar = clsppal.ObtenerCodigoGarantia(drcartera("ccodcta"))
                        drmora("ccalifica") = lctipgar
                        drmora("ccalificades") = etabttab.Describe(lctipgar, "074")

                        drmora("cfiador") = lcdatosfia

                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr

                        'calculos de los seguros

                        ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        entidadcretlin.cnrolin = clsaplica.cnrolin
                        ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = entidadcretlin.ccodlin
                        lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        'If pccodlin.Substring(8, 2) = "06" Then
                        '    lngasadm = 0
                        'Else
                        '    If clsaplica.pdfecvig > #11/1/2005# Then
                        '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                        '    Else
                        '        lngasadm = 0
                        '    End If
                        'End If
                        'If lsegdeu = True Then
                        '    If clsaplica.pdfecvig >= #7/11/2008# Then
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                        '    Else
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                        '    End If

                        'Else
                        '    lnsegdeu = 0
                        'End If

                        lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                        lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva


                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0


                        'finaliza calculo de los seguros


                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function



    Public Function CarteraCalculadaINFORED(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, ctipgar, cteldom, cNudoci, cNudotr, ccodcli, dnacimi, ncuoapr, ncuomor, ccodact, ccodsol, cnomgru, ccodcen, cnomcen, ncuotakp,csececo,genero, "
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,S,S,S,S,F,D,D,S,S,S,S,S,D,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo


        dscartera = clscartera.CarteraCalculadaINFORED(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona)


        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        nn = dscartera.Tables(0).Rows.Count

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra

                clsaplica.pcestado = drcartera("cestado")

                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterestINFORED
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                    Dim lncuotakp As Double = 0
                    lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                    'lncuota = clsaplica.pnmoncuo
                    Dim lncuotasmor As Integer = 0
                    'Cuotas Atrasadas
                    If lndiaatr > 0 And lncuotakp > 0 Then
                        lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                    Else
                        lncuotasmor = 0
                    End If

                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                            drmora = lcMORA.NewRow()
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfecvig")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("ccodsol") = drcartera("ccodsol")
                            drmora("cnomgru") = drcartera("cnomgru")
                            drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                            drmora("cteldom") = drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncuota") = lncuota
                            drmora("ncuotakp") = lncuotakp
                            drmora("ncuomor") = lncuotasmor
                            drmora("ccalifica") = lccalifica
                            drmora("ccalificades") = lcestrdes
                            drmora("cfiador") = lcdatosfia
                            drmora("ctipgar") = drcartera("ctipgar")
                            drmora("cnudoci") = drcartera("cnudoci")
                            drmora("cnudotr") = drcartera("cnudotr")
                            drmora("ccodcli") = drcartera("ccodcli")
                            drmora("dnacimi") = drcartera("dnacimi")
                            drmora("ncuoapr") = drcartera("ncuoapr")
                            drmora("ccodact") = drcartera("ccodact")
                            drmora("ccodcen") = drcartera("ccodcen")
                            drmora("cnomcen") = drcartera("cnomcen")
                            drmora("csececo") = drcartera("csececo")
                            drmora("genero") = drcartera("genero")

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If
                            lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                            lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva


                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0
                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("ccodsol") = drcartera("ccodsol")
                        drmora("cnomgru") = drcartera("cnomgru")
                        drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                        drmora("cteldom") = drcartera("cteldom")
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("ncuota") = lncuota
                        drmora("ncuotakp") = lncuotakp
                        drmora("ncuomor") = lncuotasmor
                        drmora("ccalifica") = lccalifica
                        drmora("ccalificades") = lcestrdes
                        drmora("cfiador") = lcdatosfia
                        drmora("ctipgar") = drcartera("ctipgar")
                        drmora("cnudoci") = drcartera("cnudoci")
                        drmora("cnudotr") = drcartera("cnudotr")
                        drmora("ccodcli") = drcartera("ccodcli")
                        drmora("dnacimi") = drcartera("dnacimi")
                        drmora("ncuoapr") = drcartera("ncuoapr")
                        drmora("ccodact") = drcartera("ccodact")
                        drmora("csececo") = drcartera("csececo")
                        drmora("genero") = drcartera("genero")

                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        drmora("ccodcen") = drcartera("ccodcen")
                        drmora("cnomcen") = drcartera("cnomcen")

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr

                        'calculos de los seguros

                        ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        entidadcretlin.cnrolin = clsaplica.cnrolin
                        ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = entidadcretlin.ccodlin
                        lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        'If pccodlin.Substring(8, 2) = "06" Then
                        '    lngasadm = 0
                        'Else
                        '    If clsaplica.pdfecvig > #11/1/2005# Then
                        '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                        '    Else
                        '        lngasadm = 0
                        '    End If
                        'End If
                        'If lsegdeu = True Then
                        '    If clsaplica.pdfecvig >= #7/11/2008# Then
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                        '    Else
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                        '    End If

                        'Else
                        '    lnsegdeu = 0
                        'End If
                        lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                        lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva


                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0


                        'finaliza calculo de los seguros


                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function
    Public Function SaldoxCuenta(ByVal ccodcta As String, ByVal dfecha As Date) As DataSet
        Return mDb.SaldoxCuenta(ccodcta, dfecha)
    End Function

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function CarteraCalculadaxCentro(ByVal dfecha2 As Date, ByVal cCodcen As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        categoria = " "


        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, ctipgar, cteldom, cNudoci, cNudotr, ccodcli, dnacimi, ncuoapr, ncuomor, ccodact, ccodsol, cnomgru, ccodcen, cnomcen, ncuotakp, cnrocuo, nsalteo, "
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,S,S,S,S,F,D,D,S,S,S,S,S,D,S,D,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)

        dscartera = clscartera.CarteraCalculadaxCentro(dfecha2, cCodcen)

        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        Dim lnsalteo As Double = 0
        nn = dscartera.Tables(0).Rows.Count
        Dim lcnrocuo As String = ""
        Dim ecredppg As New cCredppg
        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0

            'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
            lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
            lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
            clsaplica.pccodcta = drcartera("cCodcta")
            clsaplica.pdfecval = dfecha2
            clsaplica.gdfecsis = dfecha2
            clsaplica.gnperbas = Me.pnperbas
            clsaplica.gdultpag = #2/1/1970#
            If drcartera("dfecvig") >= #7/11/2008# Then
                clsaplica.porsegdeu = Me.pnsegvm1
            Else
                clsaplica.porsegdeu = Me.pnsegvm
            End If

            clsaplica.porcomision = Me.pncomtra

            clsaplica.pcestado = drcartera("cestado")

            clsaplica.gnpergra = Me.gnpergra
            ok = clsaplica.omcalcinterest("R", dfecha2)
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            If ok = 9 Then
                ok = 9
            Else
                If Me.pnopcion = 1 Then
                    lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                Else
                    lcdatosfia = ""
                End If
                lndiaatr = clsaplica.pndiaatr
                '                    If lndiaatr > 0 Then
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                'Para Calcular Cuota
                Dim lncuota As Double = 0
                lccalifica = Me.Califica(lndiaatr)
                lcestrdes = Me.CalificaDes(lndiaatr)
                '---------------------------------
                clsppal.gnperbas = Me.pnperbas
                clsppal.pnComtra = Me.pncomtra
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsppal.pnSegVm = Me.pnsegvm1
                Else
                    clsppal.pnSegVm = Me.pnsegvm
                End If

                lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                lnsalteo = ecredppg.ObtenerSaldoTeorico(drcartera("cCodcta"), dfecha2, drcartera("ncapdes"))


                Dim lncuotakp As Double = 0

                lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                'lncuota = clsaplica.pnmoncuo
                Dim lncuotasmor As Integer = 0
                'Cuotas Atrasadas
                If lndiaatr > 0 And lncuotakp > 0 Then
                    lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                Else
                    lncuotasmor = 0
                End If
                lcnrocuo = ecredppg.CuotasTeoricas(drcartera("ccodcta"), dfecha2)


                drmora = lcMORA.NewRow()
                drmora("ccodcta") = drcartera("ccodcta")
                drmora("cnomcli") = drcartera("cnomcli")
                drmora("ncapdes") = drcartera("ncapdes")
                drmora("dfecvig") = drcartera("dfecvig")
                drmora("dfecven") = drcartera("dfecven")
                drmora("ntasint") = drcartera("ntasint")
                drmora("ccodsol") = drcartera("ccodsol")
                drmora("cnomgru") = drcartera("cnomgru")
                drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                drmora("cteldom") = drcartera("cteldom")
                drmora("dultpag") = clsaplica.pdultpag
                drmora("ncuota") = clsaplica.pnmoncuo
                drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                drmora("ncuota") = lncuota
                drmora("ncuotakp") = lncuotakp
                drmora("ncuomor") = lncuotasmor
                drmora("ccalifica") = lccalifica
                drmora("ccalificades") = lcestrdes
                drmora("cfiador") = lcdatosfia
                drmora("ctipgar") = drcartera("ctipgar")
                drmora("cnudoci") = drcartera("cnudoci")
                drmora("cnudotr") = drcartera("cnudotr")
                drmora("ccodcli") = drcartera("ccodcli")
                drmora("dnacimi") = drcartera("dnacimi")
                drmora("ncuoapr") = drcartera("ncuoapr")
                drmora("ccodact") = drcartera("ccodact")
                drmora("ccodcen") = drcartera("ccodcen")
                drmora("cnomcen") = drcartera("cnomcen")
                drmora("cnrocuo") = lcnrocuo
                drmora("nsalteo") = lnsalteo


                If IsDBNull(drmora("ncapmora")) Then
                    drmora("ncapmora") = 0
                End If

                If drmora("ncapmora") < 0 Then
                    drmora("ncapmora") = 0
                End If

                drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                drmora("ndiaatr") = clsaplica.pndiaatr
                drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                'calculos de los seguros
                ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                entidadcretlin.cnrolin = clsaplica.cnrolin
                ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                pccodlin = entidadcretlin.ccodlin
                lsegdeu = entidadcretlin.lsegdeu

                lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                'If pccodlin.Substring(8, 2) = "06" Then
                '    lngasadm = 0
                'Else
                '    If clsaplica.pdfecvig > #11/1/2005# Then
                '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                '    Else
                '        lngasadm = 0
                '    End If
                'End If
                'If lsegdeu = True Then
                '    If clsaplica.pdfecvig >= #7/11/2008# Then
                '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                '    Else
                '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                '    End If

                'Else
                '    lnsegdeu = 0
                'End If
                lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                lngasadm = lnmanejo + lniva


                drmora("ncomision") = lngasadm
                drmora("nsegdeu") = lnsegdeu
                drmora("nseguros") = 0
                'finaliza calculo de los seguros
                lcMORA.Rows.Add(drmora)

            End If

        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function

    Public Function CAJA(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcanalista As String, ByVal lcoficina As String, ByVal lclineas As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        Dim lcampos1 As String

        Dim ltipos1 As String
        Dim lcCaja As DataTable
        Dim clsprin As New class1
        Dim dsbancos As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsCaja As New DataSet
        Dim drbanco As DataRow
        Dim drCaja As DataRow
        Dim lnseguros As Double
        Dim dsresumen As New DataSet


        lcampos1 = "cCodbco,cnombco,ncapita,nintere,nmora,notros,nexcedente,ctipo,ncomision,nseguro,niva,"
        ltipos1 = "S,S,D,D,D,D,D,S,D,D,D,"
        lcCaja = clsprin.creadatasetdesconec(lcampos1, ltipos1, "CAJA")

        Dim etabtbco As New cTabtbco
        etabtbco.ObtenerDatasetporid(dsbancos, "001")

        dsresumen = clscartera.ResumenCaja(dfecha1, dfecha2, lcanalista, lcoficina, lclineas, lccajeros, lczona, "E", "")
        If dsresumen.Tables(0).Rows.Count = 0 Then
        Else
            drCaja = lcCaja.NewRow()
            drCaja("ccodbco") = ""
            drCaja("cnombco") = "EFECTIVO"
            drCaja("cTipo") = "EFECTIVO"

            drCaja("nCapita") = dsresumen.Tables(0).Rows(0)("ncapita")
            drCaja("nintere") = dsresumen.Tables(0).Rows(0)("nintere")
            drCaja("nmora") = dsresumen.Tables(0).Rows(0)("nmora")
            drCaja("notros") = dsresumen.Tables(0).Rows(0)("notros")
            drCaja("nexcedente") = dsresumen.Tables(0).Rows(0)("NEXCED")

            drCaja("nseguro") = dsresumen.Tables(0).Rows(0)("NSEGDEU")
            drCaja("ncomision") = dsresumen.Tables(0).Rows(0)("NGASADM")
            drCaja("niva") = dsresumen.Tables(0).Rows(0)("niva")
            lcCaja.Rows.Add(drCaja)
        End If




        Dim lccodbco As String

        For Each drbanco In dsbancos.Tables(0).Rows
            dsresumen = clscartera.ResumenCaja(dfecha1, dfecha2, lcanalista, lcoficina, lclineas, lccajeros, lczona, "C", drbanco("ccodbco"))
            If dsresumen.Tables(0).Rows.Count = 0 Then
            Else

                drCaja = lcCaja.NewRow()
                drCaja("ccodbco") = drbanco("ccodbco")
                lccodbco = drCaja("cCodbco")
                drCaja("cnombco") = drbanco("cnombco")

                'If lccodbco.Trim = "77" Or lccodbco.Trim = "88" Or lccodbco.Trim = "99" Then
                '    drCaja("cTipo") = "OTROS"
                'Else
                drCaja("cTipo") = "BANCOS"
                'End If

                drCaja("nCapita") = dsresumen.Tables(0).Rows(0)("ncapita")
                drCaja("nintere") = dsresumen.Tables(0).Rows(0)("nintere")
                drCaja("nmora") = dsresumen.Tables(0).Rows(0)("nmora")
                drCaja("notros") = dsresumen.Tables(0).Rows(0)("notros")
                drCaja("nexcedente") = dsresumen.Tables(0).Rows(0)("NEXCED")

                drCaja("nseguro") = dsresumen.Tables(0).Rows(0)("NSEGDEU")
                drCaja("ncomision") = dsresumen.Tables(0).Rows(0)("NGASADM")
                drCaja("niva") = dsresumen.Tables(0).Rows(0)("niva")
                lcCaja.Rows.Add(drCaja)
            End If




        Next

        dsresumen = clscartera.ResumenCaja(dfecha1, dfecha2, lcanalista, lcoficina, lclineas, lccajeros, lczona, "I", "")
        If dsresumen.Tables(0).Rows.Count = 0 Then
        Else
            drCaja = lcCaja.NewRow()
            drCaja("ccodbco") = ""
            drCaja("cnombco") = "CONDONACION"
            drCaja("cTipo") = "CONDONACIONES"

            drCaja("nCapita") = dsresumen.Tables(0).Rows(0)("ncapita")
            drCaja("nintere") = dsresumen.Tables(0).Rows(0)("nintere")
            drCaja("nmora") = dsresumen.Tables(0).Rows(0)("nmora")
            drCaja("notros") = dsresumen.Tables(0).Rows(0)("notros")
            drCaja("nexcedente") = dsresumen.Tables(0).Rows(0)("NEXCED")

            drCaja("nseguro") = dsresumen.Tables(0).Rows(0)("NSEGDEU")
            drCaja("ncomision") = dsresumen.Tables(0).Rows(0)("NGASADM")
            drCaja("niva") = dsresumen.Tables(0).Rows(0)("niva")

            lcCaja.Rows.Add(drCaja)
        End If

        dsresumen.Tables.Clear()
        dsresumen = clscartera.ResumenCaja(dfecha1, dfecha2, lcanalista, lcoficina, lclineas, lccajeros, lczona, "P", "")
        If dsresumen.Tables(0).Rows.Count = 0 Then
        Else
            drCaja = lcCaja.NewRow()
            drCaja("ccodbco") = ""
            drCaja("cnombco") = "AJUSTES"
            drCaja("cTipo") = "AJUSTES"

            drCaja("nCapita") = dsresumen.Tables(0).Rows(0)("ncapita")
            drCaja("nintere") = dsresumen.Tables(0).Rows(0)("nintere")
            drCaja("nmora") = dsresumen.Tables(0).Rows(0)("nmora")
            drCaja("notros") = dsresumen.Tables(0).Rows(0)("notros")
            drCaja("nexcedente") = dsresumen.Tables(0).Rows(0)("NEXCED")

            drCaja("nseguro") = dsresumen.Tables(0).Rows(0)("NSEGDEU")
            drCaja("ncomision") = dsresumen.Tables(0).Rows(0)("NGASADM")
            drCaja("niva") = dsresumen.Tables(0).Rows(0)("niva")
            lcCaja.Rows.Add(drCaja)
        End If


        dsCaja.Tables.Add(lcCaja)
        Return dsCaja

    End Function

    Public Function DETALLE_CARTERA_Y_PAGOS_OTROS(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo

        Return mDb.DETALLE_CARTERA_Y_PAGOS_OTROS(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona)
    End Function
    Public Function DETALLE_CARTERA_Y_PAGOS_EXCEDENTES(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo
        Return mDb.DETALLE_CARTERA_Y_PAGOS_EXCEDENTES(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona)
    End Function
    Public Function StatusCredito(ByVal ccodcta As String) As String
        Return mDb.StatusCredito(ccodcta)
    End Function
    Public Function ObtenerbusquedaGrupal(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String) As DataSet
        Return mDb.ObtenerbusquedaGrupal(cnombre, cestado, ctipo, cbusq, cmetodologia, cflag)
    End Function
    Public Function ObtenerbusquedacreditoGrupales(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, ByVal cCodofi As String) As DataSet
        Return mDb.ObtenerbusquedacreditoGrupales(cnombre, cestado, ctipo, cbusq, cmetodologia, cflag, cCodofi)
    End Function
    Public Function ListadoCreditosxGrupoPreAprobar(ByVal cCodsol As String) As DataSet
        Return mDb.ListadoCreditosxGrupoPreAprobar(cCodsol)
    End Function
    'Validacion de montos mas comision 09072015 ***Fer Abrego Rdz
    'Pendiente ......
    Public Function ValidadorMontosMasComison(ByVal cbxLineas As String, ByVal ccodsol As String) As DataSet

        Return mDb.ValidadorMontosMasComison(cbxLineas, ccodsol)
    End Function
    Public Function ListadoCreditosxGrupoSugerencia(ByVal cCodsol As String) As DataSet
        Return mDb.ListadoCreditosxGrupoSugerencia(cCodsol)
    End Function
    'Validaacion por estatus Fenrnado Abrego 07072015***
    Public Function Estatus_grupal(ByVal cCodsol As String) As DataSet
        Return mDb.Estatus_grupal(cCodsol)
    End Function
    ''**************************************
    Public Function buscaCodigosClientes(ByVal ccodsol As String) As DataSet
        Return mDb.buscaCodigosClientes(ccodsol)
    End Function
    Public Function buscarCreditos(ByVal ccodcli As String) As Integer
        Return mDb.buscarCreditos(ccodcli)
    End Function
    Public Function ListadoCreditosxGrupoAprobar(ByVal cCodsol As String) As DataSet
        Return mDb.ListadoCreditosxGrupoAprobar(cCodsol)
    End Function

    Public Function ListadoCreditosxGrupoDesembolso(ByVal cCodsol As String) As DataSet
        Return mDb.ListadoCreditosxGrupoDesembolso(cCodsol)
    End Function

    Public Function Extrae_Resolucion_Usuario(ByVal cCodsol As String) As DataSet
        Return mDb.Extrae_Resolucion_Usuario(cCodsol)
    End Function

    Public Function ObtenerbusquedacreditoAmbos(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, ByVal cCodofi As String) As DataSet
        Return mDb.ObtenerbusquedacreditoAmbos(cnombre, cestado, ctipo, cbusq, cmetodologia, cflag, cCodofi)
    End Function

    Public Function ObtenerbusquedacreditoAmbos_(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, ByVal cCodofi As String) As DataSet
        Return mDb.ObtenerbusquedacreditoAmbos_(cnombre, cestado, ctipo, cbusq, cmetodologia, cflag, cCodofi)
    End Function

    Public Function CargaFechas(ByVal cCodsol As String) As DataSet
        Return mDb.CargaFechas(cCodsol)
    End Function
    Public Function HistoricoGrupal(ByVal cCodsol As String, ByVal dfecvig As Date) As DataSet
        Return mDb.HistoricoGrupal(cCodsol, dfecvig)
    End Function
    'Public Function ValidadorPlusCierre(ByVal dfecha As Date, ByVal coficina As String) As DataSet
    '    Return mDb.ValidadorPlusCierre(dfecha, coficina)
    'End Function

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
    Public Function EstratificacionCartera(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String

        Dim lnsaldo As Double = 0
        Dim lnsalteo30 As Double = 0
        Dim lnsalteo60 As Double = 0

        Dim lnpagar30 As Double = 0
        Dim lnpagar60 As Double = 0

        Dim ldfec30 As Date
        Dim ldfec60 As Date

        ldfec30 = dfecha2.AddDays(-30)
        ldfec60 = dfecha2.AddDays(-60)

        If lcestrato = "A" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "E" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  120 "
        ElseIf lcestrato = "F" Then
            categoria = " drcartera('ndiaatr')> 120 AND drcartera('ndiaatr') <=  180 "
        ElseIf lcestrato = "G" Then
            categoria = " drcartera('ndiaatr')> 180 AND drcartera('ndiaatr') <=  360 "
        Else
            categoria = " drcartera('ndiaatr')> 360 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador,cteldom, npagar30, npagar60, ccodsol, cnomgru, ccodcen, cnomcen, npar30num, npar30sal, npar30mor,cflag, ccodana, cnomana, coficina, cnomofi,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,S,D,D,S,S,S,S,D,D,D,S,S,S,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        Dim cancela As String
        cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo


        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)


        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""

        For Each drcartera In dscartera.Tables(0).Rows

            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "D" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                'lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                'lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)



                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                Else
                    'If Me.pnopcion = 1 Then
                    '    lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    'Else
                    '    lcdatosfia = ""
                    'End If
                    lndiaatr = clsaplica.pndiaatr

                    '                   If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    'If drcartera("dfecvig") >= #7/11/2008# Then
                    clsppal.pnSegVm = Me.pnsegvm1
                    'Else
                    '    clsppal.pnSegVm = Me.pnsegvm
                    'End If

                    'lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                    'Dim lctelefono As String
                    'If IsDBNull(drcartera("cteldom")) Then
                    'Else
                    '    lctelefono = drcartera("cteldom")
                    '    drcartera("cteldom") = lctelefono.Trim
                    'End If
                    'lncuota = clsaplica.pnmoncuo
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A") Or (lndiaatr >= 1 And lndiaatr <= 30 And lcestrato = "B") Or (lndiaatr >= 31 And lndiaatr <= 60 And lcestrato = "C") Or (lndiaatr >= 61 And lndiaatr <= 90 And lcestrato = "D") Or (lndiaatr >= 91 And lndiaatr <= 120 And lcestrato = "E") Or (lndiaatr >= 121 And lndiaatr <= 180 And lcestrato = "F") Or (lndiaatr >= 181 And lndiaatr <= 360 And lcestrato = "G") Or (lndiaatr > 360 And lcestrato = "H") Then
                            drmora = lcMORA.NewRow()
                            drmora("ccodcta") = drcartera("ccodcta")
                            'drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            'drmora("dfecvig") = drcartera("dfecvig")
                            'drmora("ccodsol") = drcartera("ccodsol")
                            'drmora("cnomgru") = drcartera("cnomgru")

                            'drmora("ccodcen") = drcartera("ccodcen")
                            'drmora("cnomcen") = drcartera("cnomcen")

                            'drmora("dfecven") = drcartera("dfecven")
                            'drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                            'drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                            'drmora("dultpag") = clsaplica.pdultpag
                            'drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(drcartera("nCapdes") - drcartera("ncappag"), 2) 'utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)

                            If lndiaatr > 30 Then
                                drmora("npar30num") = 1
                                drmora("npar30sal") = lnsaldo
                                drmora("npar30mor") = drmora("ncapmora")
                            Else
                                drmora("npar30num") = 0
                                drmora("npar30sal") = 0
                                drmora("npar30mor") = 0
                            End If

                            If lndiaatr <= 0 Then
                                drmora("cflag") = "A"
                            Else
                                drmora("cflag") = "B"
                            End If
                            'calcula a saldos teorico a 30 y 60 dias --------------------------------------
                            'lnsalteo30 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec30)
                            'If lnsalteo30 = 0 Then
                            '    drmora("npagar30") = 0
                            'Else
                            '    drmora("npagar30") = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))
                            'End If

                            'lnsalteo60 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec60)
                            'If lnsalteo60 = 0 Then
                            '    drmora("npagar60") = 0
                            'Else
                            '    drmora("npagar60") = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))
                            'End If
                            '-------------------------------------------------------------------------------

                            'drmora("ncuota") = lncuota
                            drmora("ccalifica") = lccalifica
                            drmora("ccalificades") = lcestrdes
                            'drmora("cfiador") = lcdatosfia

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            'drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            'drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            'ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            'entidadcretlin.cnrolin = clsaplica.cnrolin
                            'ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            'pccodlin = entidadcretlin.ccodlin
                            'lsegdeu = entidadcretlin.lsegdeu

                            'lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If

                            'drmora("ncomision") = lngasadm
                            'drmora("nsegdeu") = lnsegdeu
                            'drmora("nseguros") = 0
                            drmora("ccodana") = drcartera("ccodana")
                            drmora("cnomana") = drcartera("cnomana")

                            drmora("coficina") = drcartera("coficina")
                            drmora("cnomofi") = drcartera("cnomofi")

                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)
                        Else
                            Dim lflag As Boolean
                            lflag = True

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        'drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("ccodcta") = drcartera("ccodcta")
                        'drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        'drmora("dfecvig") = drcartera("dfecvig")
                        'drmora("ccodsol") = drcartera("ccodsol")
                        'drmora("cnomgru") = drcartera("cnomgru")
                        'drmora("ccodcen") = drcartera("ccodcen")
                        'drmora("cnomcen") = drcartera("cnomcen")
                        'drmora("dfecven") = drcartera("dfecven")
                        'drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                        'drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                        'drmora("dultpag") = clsaplica.pdultpag
                        'drmora("ncuota") = lncuota
                        drmora("ccalifica") = lccalifica
                        drmora("ccalificades") = lcestrdes
                        'drmora("cfiador") = lcdatosfia

                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(drcartera("nCapdes") - drcartera("ncappag"), 2) 'utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        lnsaldo = Math.Round(drcartera("nCapdes") - drcartera("ncappag"), 2)

                        If lndiaatr > 30 Then
                            drmora("npar30num") = 1
                            drmora("npar30sal") = lnsaldo
                            drmora("npar30mor") = drmora("ncapmora")
                        Else
                            drmora("npar30num") = 0
                            drmora("npar30sal") = 0
                            drmora("npar30mor") = 0
                        End If

                        If lndiaatr <= 0 Then
                            drmora("cflag") = "A"
                        Else
                            drmora("cflag") = "B"
                        End If


                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr

                        'calculos de los seguros

                        'ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        'entidadcretlin.cnrolin = clsaplica.cnrolin
                        'ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        'pccodlin = entidadcretlin.ccodlin
                        'lsegdeu = entidadcretlin.lsegdeu

                        'lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        'If pccodlin.Substring(8, 2) = "06" Then
                        '    lngasadm = 0
                        'Else
                        '    If clsaplica.pdfecvig > #11/1/2005# Then
                        '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                        '    Else
                        '        lngasadm = 0
                        '    End If
                        'End If
                        'If lsegdeu = True Then
                        '    If clsaplica.pdfecvig >= #7/11/2008# Then
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                        '    Else
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                        '    End If

                        'Else
                        '    lnsegdeu = 0
                        'End If

                        'drmora("ncomision") = lngasadm
                        'drmora("nsegdeu") = lnsegdeu
                        'drmora("nseguros") = 0


                        'finaliza calculo de los seguros
                        drmora("coficina") = drcartera("coficina")
                        drmora("cnomofi") = drcartera("cnomofi")

                        drmora("ccodana") = drcartera("ccodana")
                        drmora("cnomana") = drcartera("cnomana")

                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If

        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function
    Public Function ValidadorPlusCierre(ByVal dfecha As Date, ByVal coficina As String) As DataSet
        Return mDb.ValidadorPlusCierre(dfecha, coficina)
    End Function
    Public Function SaldoTotalxAgencia(ByVal lcoficina As String, ByVal dfecha2 As Date) As Double
        Return mDb.SaldoTotalxAgencia(lcoficina, dfecha2)
    End Function
    Public Function SaldoTotalxAgenciaConta(ByVal lcoficina As String, ByVal dfecha2 As Date) As Double
        Return mDb.SaldoTotalxAgenciaConta(lcoficina, dfecha2)
    End Function

    Public Function CarteraCalculadaaProvisionar(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal accion As String, ByVal dfecant As Date) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "ccodcta,cestado, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, ctipgar, cteldom, cNudoci, cNudotr, ccodcli, dnacimi, ncuoapr, ncuomor, ccodact, ccondic, cFlgMod, ccodlin, ccodpres, ccodofi,ntasmor," & "No,Region,Agencia,Credito,Cliente,Nombre,Cedula,Direccion,Actividad,Monto,Saldo,Cuota,Capital_Mora,Intereses_Corrientes,Intereses_Moratorios,Cuotas_Mora,Garantia,Tasa_Interes,Fecha_Otorgado,Fecha_Vence,Ciclo,Dias_Atraso,Menosde1,Menosde2,Menosde3,Menosde4,Menosde6,Mayor180,Sexo,Metodologia,Programa,Producto,Sector,Estado,Tipo_Cartera,Destino,Municipio,Fecha_Nac,Departamento,Fondos,Asesor_Otorgo,Asesor_Administra,Pago_Capital,Pago_Interes,Pago_Mora,TipoInteres,nsalintAnt,nsalMorAnt,ndiaatrAnt,nCapmoraAnt,ncuotakp,"
        ltipos1 = "S,S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,S,S,S,S,F,D,D,S,S,S,S,S,S,D," & "S,S,S,S,S,S,S,S,S,D,D,D,D,D,D,D,S,D,F,F,I,I,D,D,D,D,D,D,S,S,S,S,S,S,S,S,S,F,S,S,S,S,D,D,D,S,D,D,I,D,D,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")


        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        Dim ldfecpri As Date
        ldfecpri = clsppal.PrimerDiaMes(dfecha2)


        Dim dskardex As New DataSet
        'colcamos el datatable generado para le mine
        dskardex = clscartera.ObtenerPagosdelPeriodo(ldfecpri, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, "*")
        'dscartera = clscartera.CarteraCalculadaUseEstado(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona)
        dscartera = clscartera.CarteraCalculadaMINE(ldfecpri, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, "*")
        lnsalintmor = 0

        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre
        Dim lcestrdes As String = ""
        Dim lccalifica As String = ""
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim lccondic As String = ""
        Dim nn As Integer
        nn = dscartera.Tables(0).Rows.Count
        Dim lccalif As String = ""

        Dim contador As Integer = 1
        Dim etabtofi As New cTabtofi
        Dim ccodreg As String
        Dim etabttab As New cTabttab
        Dim etabtciu As New cTabtciu

        Dim dstrabajo As New DataSet
        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = 0
                ok = clsaplica.omcalcinterest("R", dfecant)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then ' 9 = cancelados
                    ok = 9
                    'Graba Cancelados Para mine---------------------
                    If accion = "R" Then
                        ldultfecha = drcartera("dfecult")
                        drmora = lcMORA.NewRow()
                        drmora("cestado") = drcartera("cestado")
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("ccodpres") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("ntasmor") = drcartera("ntasmor")
                        drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                        drmora("cteldom") = drcartera("cteldom")
                        drmora("dultpag") = ldultfecha
                        drmora("ncuota") = clsaplica.pnmoncuo
                        drmora("ncapmora") = 0
                        drmora("nsalcap") = 0
                        drmora("ncuota") = clsaplica.pnmoncuo
                        drmora("ccalifica") = ""
                        drmora("ccalificades") = ""
                        drmora("cfiador") = ""
                        drmora("ctipgar") = IIf(IsDBNull(drcartera("ctipgar")), "01", drcartera("ctipgar"))
                        drmora("cnudoci") = drcartera("cnudoci")
                        drmora("cnudotr") = drcartera("cnudotr")
                        drmora("ccodcli") = drcartera("ccodcli")
                        drmora("dnacimi") = drcartera("dnacimi")
                        drmora("ncuoapr") = drcartera("ncuoapr")
                        drmora("ccodact") = drcartera("ccodact")
                        drmora("ccodofi") = drcartera("coficina")

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = 0
                        drmora("ndiaatr") = 0
                        drmora("nsalintmor") = 0

                        'calculos de los seguros

                        drmora("cCodlin") = drcartera("ccodlin")
                        drmora("ncomision") = 0
                        drmora("nsegdeu") = 0
                        drmora("nseguros") = 0
                        drmora("cCondic") = ""

                        'Aqui se agregaran campos del MiNE

                        drmora("No") = contador

                        ccodreg = etabtofi.ObtenerRegiondeOficina(drcartera("coficina"))
                        drmora("Region") = etabttab.Describe(ccodreg, "054")
                        drmora("Agencia") = drcartera("cnomofi")
                        drmora("Credito") = "'" & drcartera("ccodcta") '
                        drmora("Cliente") = "'" & drcartera("ccodcli")
                        drmora("Nombre") = drcartera("cnomcli")
                        drmora("Cedula") = drcartera("cnudoci")
                        drmora("Direccion") = drcartera("cdirdom")
                        drmora("Actividad") = etabtciu.CIIU(drcartera("ccodact"))
                        drmora("Monto") = Math.Round(drcartera("ncapdes"), 2)
                        drmora("Saldo") = 0
                        drmora("Cuota") = drcartera("nmoncuo")
                        drmora("Capital_Mora") = 0
                        drmora("Intereses_Corrientes") = 0
                        drmora("Intereses_Moratorios") = 0
                        drmora("Cuotas_Mora") = 0
                        drmora("Garantia") = "" 'clsppal.TipodeGarantia(drcartera("ccodcta"))
                        drmora("Tasa_Interes") = drcartera("ntasint")
                        drmora("Fecha_otorgado") = drcartera("dfecvig")
                        drmora("Fecha_vence") = drcartera("dfecven")
                        drmora("Ciclo") = drcartera("nciclo")
                        drmora("Dias_Atraso") = 0
                        drmora("Menosde1") = 0
                        drmora("Menosde2") = 0
                        drmora("Menosde3") = 0
                        drmora("Menosde4") = 0
                        drmora("Menosde6") = 0
                        drmora("Mayor180") = 0

                        drmora("Sexo") = drcartera("csexo")
                        drmora("Metodologia") = etabttab.Describe(drcartera("ccodlin").Substring(4, 2), "125")
                        drmora("Programa") = etabttab.Describe(drcartera("ccodlin").substring(6, 2), "034")
                        drmora("Producto") = etabttab.Describe(drcartera("ccodlin").substring(8, 2), "075")
                        drmora("Sector") = etabttab.Describe(IIf(IsDBNull(drcartera("csececo")), "", drcartera("csececo")), "021")
                        drmora("Estado") = ecremcre.StatusCredito(drcartera("ccondic"))
                        If IsDBNull(drcartera("ccontra")) Then
                            drcartera("ccontra") = "N"
                        End If

                        drmora("Tipo_Cartera") = IIf(drcartera("ccontra") = "N", "Normal", "Reestructurado")
                        drmora("Destino") = etabttab.Describe(drcartera("cdescre"), "005")
                        drmora("Municipio") = etabtzon.Zona(Left(drcartera("cCoddom"), 4)).Trim
                        drmora("Fecha_Nac") = drcartera("dnacimi")
                        drmora("Departamento") = etabtzon.Zona(Left(drcartera("cCoddom"), 2)).Trim
                        drmora("Fondos") = etabttab.Describe(drcartera("ffondos"), "033")
                        drmora("Asesor_Otorgo") = drcartera("cnomoto")
                        drmora("Asesor_Administra") = drcartera("cnomana")

                        drmora("Pago_Capital") = 0
                        drmora("Pago_Interes") = 0
                        drmora("Pago_Mora") = 0

                        dstrabajo = clscartera.Filtrado(dskardex, drcartera("ccodcta"))
                        For Each filak As DataRow In dstrabajo.Tables(0).Rows
                            drmora("Pago_Capital") = filak("ncappag")
                            drmora("Pago_Interes") = filak("nintpag")
                            drmora("Pago_Mora") = filak("nmorpag")
                        Next
                        dstrabajo.Tables.Clear()
                        drmora("tipoInteres") = IIf(Trim(drcartera("cflat")) = "F", "FLAT", "Sobre Saldo")

                        drmora("nsalintant") = 0
                        drmora("nsalmorant") = 0
                        drmora("ndiaatrAnt") = 0
                        drmora("nCapmoraAnt") = 0
                        drmora("ncuotakp") = 0
                        contador += 1



                        'Fin de campos MINE---------------------------------------------

                        'finaliza calculo de los seguros
                        lcMORA.Rows.Add(drmora)


                    End If
                    '--------------------------
                Else
                    'Graba datos en la cremcre



                    entidadcremcre.ccodcta = clsaplica.pccodcta
                    ecremcre.ObtenerCremcre(entidadcremcre)


                    lccalif = clsppal.Califica(clsaplica.pndiaatr, entidadcremcre.cfrecint)

                    entidadcremcre.ncapdes = clsaplica.pncapdes
                    entidadcremcre.ncappag = clsaplica.pncappag
                    entidadcremcre.ndiaatr = clsaplica.pndiaatr
                    entidadcremcre.nintcal = clsaplica.pnintcal
                    entidadcremcre.nintpag = clsaplica.pnintpag
                    entidadcremcre.nintpen = clsaplica.pnintpen
                    entidadcremcre.npagcta = clsaplica.pnpagcta
                    entidadcremcre.nmorpag = clsaplica.pnmorpag
                    entidadcremcre.nintmor = clsaplica.pnintmor
                    entidadcremcre.dultpag = clsaplica.pdultpag
                    entidadcremcre.ncapcal = clsaplica.pncapcal
                    entidadcremcre.nmorak = clsaplica.pndeucap
                    entidadcremcre.ccalif = lccalif
                    entidadcremcre.nsalcap = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                    entidadcremcre.nsalint = clsaplica.pnsalint
                    entidadcremcre.nsalmor = clsaplica.pnsalmor

                    lccondic = entidadcremcre.ccondic

                    Try
                        ecremcre.ActualizarCierreCremcre(entidadcremcre)
                    Catch ex As Exception

                    End Try


                    'entidadcremcre.ccodcta = clsaplica.pccodcta
                    'ecremcre.ObtenerCremcre(entidadcremcre)
                    'entidadcremcre.ccalif = ecredkar.fxCalifica(clsaplica.pccodcta)
                    'Try
                    '    ecremcre.ActualizarCalificacionCremcre(entidadcremcre)
                    'Catch ex As Exception

                    'End Try


                    '<<<<<<<<<<<<>>>>>>>>>>>>>>
                    If accion = "P" Then 'Para usar en provision
                        If lccondic <> "S" Then 'clsaplica.pndiaatr <= 30 Then
                            lndiaatr = clsaplica.pndiaatr
                            'Para Calcular Cuota
                            Dim lncuota As Double = 0
                            clsppal.gnperbas = Me.pnperbas
                            clsppal.pnComtra = Me.pncomtra
                            If drcartera("dfecvig") >= #7/11/2008# Then
                                clsppal.pnSegVm = Me.pnsegvm1
                            Else
                                clsppal.pnSegVm = Me.pnsegvm
                            End If
                            Dim lncuotakp As Double = 0
                            lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))

                            drmora = lcMORA.NewRow()
                            drmora("ncuotakp") = lncuotakp
                            drmora("cestado") = drcartera("cestado")
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("ccodpres") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfecvig")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("ntasmor") = drcartera("ntasmor")
                            drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                            drmora("cteldom") = drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncuota") = lncuota
                            drmora("ccalifica") = lccalifica
                            drmora("ccalificades") = lcestrdes
                            drmora("cfiador") = lcdatosfia
                            drmora("ctipgar") = IIf(IsDBNull(drcartera("ctipgar")), "01", drcartera("ctipgar"))
                            drmora("cnudoci") = drcartera("cnudoci")
                            drmora("cnudotr") = drcartera("cnudotr")
                            drmora("ccodcli") = drcartera("ccodcli")
                            drmora("dnacimi") = drcartera("dnacimi")
                            drmora("ncuoapr") = drcartera("ncuoapr")
                            drmora("ccodact") = drcartera("ccodact")
                            drmora("ccodofi") = drcartera("coficina")

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            'entidadcretlin.cnrolin = clsaplica.cnrolin
                            'ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = drcartera("ccodlin") 'entidadcretlin.ccodlin
                            'lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            lngasadm = 0

                            lnsegdeu = 0
                            lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                            lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva


                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0
                            drmora("cCondic") = lccondic
                            drmora("cCodlin") = pccodlin

                            drmora("nsalintant") = clsaplica.pnsalintAnt
                            drmora("nsalmorant") = clsaplica.pnsalmorAnt
                            drmora("ndiaatrAnt") = clsaplica.pndiaatrAnt
                            drmora("nCapmoraAnt") = clsaplica.pndeucapAnt
                            drmora("ncuotakp") = 0
                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)

                        End If

                    Else ' Para usar en reclasificacion
                        'If clsaplica.pndiaatr <= 30 Then
                        lndiaatr = clsaplica.pndiaatr

                        'Para Calcular Cuota
                        Dim lncuota As Double = 0
                        clsppal.gnperbas = Me.pnperbas
                        clsppal.pnComtra = Me.pncomtra
                        If drcartera("dfecvig") >= #7/11/2008# Then
                            clsppal.pnSegVm = Me.pnsegvm1
                        Else
                            clsppal.pnSegVm = Me.pnsegvm
                        End If
                        Dim lncuotakp As Double = 0
                        lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))

                        Dim lncuotasmor As Integer = 0
                        'Cuotas Atrasadas
                        If lndiaatr > 0 And lncuotakp > 0 Then
                            lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                        Else
                            lncuotasmor = 0
                        End If


                        drmora = lcMORA.NewRow()
                        drmora("ncuotakp") = lncuotakp
                        drmora("cestado") = drcartera("cestado")
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("ccodpres") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("ntasmor") = drcartera("ntasmor")
                        drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                        drmora("cteldom") = drcartera("cteldom")
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("ncuota") = clsaplica.pnmoncuo
                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                        drmora("ncuota") = lncuota
                        drmora("ccalifica") = lccalifica
                        drmora("ccalificades") = lcestrdes
                        drmora("cfiador") = lcdatosfia
                        drmora("ctipgar") = IIf(IsDBNull(drcartera("ctipgar")), "01", drcartera("ctipgar"))
                        drmora("cnudoci") = drcartera("cnudoci")
                        drmora("cnudotr") = drcartera("cnudotr")
                        drmora("ccodcli") = drcartera("ccodcli")
                        drmora("dnacimi") = drcartera("dnacimi")
                        drmora("ncuoapr") = drcartera("ncuoapr")
                        drmora("ccodact") = drcartera("ccodact")
                        drmora("ccodofi") = drcartera("coficina")

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr
                        drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                        'calculos de los seguros
                        ldultfecha = drcartera("dfecult")

                        'entidadcretlin.cnrolin = clsaplica.cnrolin
                        'ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = drcartera("ccodlin") 'entidadcretlin.ccodlin
                        'lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        lngasadm = 0
                        lnsegdeu = 0
                        lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                        lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva

                        drmora("cCodlin") = pccodlin
                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0
                        drmora("cCondic") = lccondic

                        'Aqui se agregaran campos del MiNE

                        drmora("No") = contador

                        ccodreg = etabtofi.ObtenerRegiondeOficina(drcartera("coficina"))
                        drmora("Region") = etabttab.Describe(ccodreg, "054")
                        drmora("Agencia") = drcartera("cnomofi")
                        drmora("Credito") = "'" & drcartera("ccodcta") '
                        drmora("Cliente") = "'" & drcartera("ccodcli")
                        drmora("Nombre") = drcartera("cnomcli")
                        drmora("Cedula") = drcartera("cnudoci")
                        drmora("Direccion") = drcartera("cdirdom")
                        drmora("Actividad") = etabtciu.CIIU(drcartera("ccodact"))
                        drmora("Monto") = Math.Round(clsaplica.pncapdes, 2)
                        drmora("Saldo") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                        drmora("Cuota") = drcartera("nmoncuo")
                        drmora("Capital_Mora") = Math.Round(clsaplica.pndeucap, 2)
                        drmora("Intereses_Corrientes") = Math.Round(clsaplica.pnsalint, 2)
                        drmora("Intereses_Moratorios") = Math.Round(clsaplica.pnsalmor, 2)
                        drmora("Cuotas_Mora") = lncuotasmor
                        drmora("Garantia") = "" 'clsppal.TipodeGarantia(drcartera("ccodcta"))
                        drmora("Tasa_Interes") = drcartera("ntasint")
                        drmora("Fecha_otorgado") = drcartera("dfecvig")
                        drmora("Fecha_vence") = drcartera("dfecven")
                        drmora("Ciclo") = drcartera("nciclo")
                        drmora("Dias_Atraso") = clsaplica.pndiaatr
                        drmora("Menosde1") = 0
                        drmora("Menosde2") = 0
                        drmora("Menosde3") = 0
                        drmora("Menosde4") = 0
                        drmora("Menosde6") = 0
                        drmora("Mayor180") = 0

                        If clsaplica.pndiaatr <= 30 Then
                            drmora("Menosde1") = Math.Round(clsaplica.pndeucap, 2)
                        ElseIf clsaplica.pndiaatr > 30 And clsaplica.pndiaatr <= 60 Then
                            drmora("Menosde2") = Math.Round(clsaplica.pndeucap, 2)
                        ElseIf clsaplica.pndiaatr > 60 And clsaplica.pndiaatr <= 90 Then
                            drmora("Menosde3") = Math.Round(clsaplica.pndeucap, 2)
                        ElseIf clsaplica.pndiaatr > 90 And clsaplica.pndiaatr <= 120 Then
                            drmora("Menosde4") = Math.Round(clsaplica.pndeucap, 2)
                        ElseIf clsaplica.pndiaatr > 120 And clsaplica.pndiaatr <= 180 Then
                            drmora("Menosde6") = Math.Round(clsaplica.pndeucap, 2)
                        Else
                            drmora("Mayor180") = Math.Round(clsaplica.pndeucap, 2)
                        End If
                        drmora("Sexo") = drcartera("csexo")
                        drmora("Metodologia") = etabttab.Describe(drcartera("ccodlin").Substring(4, 2), "125")
                        drmora("Programa") = etabttab.Describe(drcartera("ccodlin").substring(6, 2), "034")
                        drmora("Producto") = etabttab.Describe(drcartera("ccodlin").substring(8, 2), "075")
                        drmora("Sector") = etabttab.Describe(IIf(IsDBNull(drcartera("csececo")), "", drcartera("csececo")), "021")
                        drmora("Estado") = ecremcre.StatusCredito(drcartera("ccondic"))
                        If IsDBNull(drcartera("ccontra")) Then
                            drcartera("ccontra") = "N"
                        End If

                        drmora("Tipo_Cartera") = IIf(drcartera("ccontra") = "N", "Normal", "Reestructurado")
                        drmora("Destino") = etabttab.Describe(drcartera("cdescre"), "005")
                        drmora("Municipio") = etabtzon.Zona(Left(drcartera("cCoddom"), 4)).Trim
                        drmora("Fecha_Nac") = drcartera("dnacimi")
                        drmora("Departamento") = etabtzon.Zona(Left(drcartera("cCoddom"), 2)).Trim
                        drmora("Fondos") = etabttab.Describe(drcartera("ffondos"), "033")
                        drmora("Asesor_Otorgo") = drcartera("cnomoto")
                        drmora("Asesor_Administra") = drcartera("cnomana")

                        drmora("Pago_Capital") = 0
                        drmora("Pago_Interes") = 0
                        drmora("Pago_Mora") = 0

                        dstrabajo = clscartera.Filtrado(dskardex, drcartera("ccodcta"))
                        For Each filak As DataRow In dstrabajo.Tables(0).Rows
                            drmora("Pago_Capital") = filak("ncappag")
                            drmora("Pago_Interes") = filak("nintpag")
                            drmora("Pago_Mora") = filak("nmorpag")
                        Next
                        dstrabajo.Tables.Clear()
                        drmora("tipoInteres") = IIf(Trim(drcartera("cflat")) = "F", "FLAT", "Sobre Saldo")

                        drmora("nsalintant") = clsaplica.pnsalintAnt
                        drmora("nsalmorant") = clsaplica.pnsalmorAnt
                        drmora("ndiaatrAnt") = clsaplica.pndiaatrAnt
                        drmora("nCapmoraAnt") = clsaplica.pndeucapAnt
                        contador += 1



                        'Fin de campos MINE---------------------------------------------

                        'finaliza calculo de los seguros
                        lcMORA.Rows.Add(drmora)

                        ' End If

                    End If
                End If
            End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function
    Public Function Cadenabk(ByVal dfecha As Date) As DataSet
        Return mDb.Cadenabk(dfecha)
    End Function
    Public Function CadenaActual() As String
        Return mDb.CadenaActual
    End Function

    '-------------------------------------------------------------------------------------
    Public Function CarteraCalculadaResumen(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim mcremcre As New cCremcre
        Dim mtabtofi As New cTabtofi
        Dim mtabttab As New cTabttab
        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, ctipgar, cteldom, cNudoci, cNudotr, ccodcli, dnacimi, ncuoapr, ncuomor, ccodact, ccodsol, cnomgru, ccodcen, cnomcen, ncuotakp, ccondic, ffondos, coficina, ctipmet, cStatus, cNomOfi, cNomfon, Producto, "
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,S,S,S,S,F,D,D,S,S,S,S,S,D,S,S,S,S,S,S,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)

        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)

        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        nn = dscartera.Tables(0).Rows.Count
        Dim lccodcta As String = ""

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            lccodcta = drcartera("cCodcta")

            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                'lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                'lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra

                clsaplica.pcestado = drcartera("cestado")

                clsaplica.gnpergra = 0 'Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                    Dim lncuotakp As Double = 0
                    lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                    'lncuota = clsaplica.pnmoncuo
                    Dim lncuotasmor As Integer = 0
                    'Cuotas Atrasadas
                    If lndiaatr > 0 And lncuotakp > 0 Then
                        lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                    Else
                        lncuotasmor = 0
                    End If

                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                            drmora = lcMORA.NewRow()
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfecvig")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("ccodsol") = drcartera("ccodsol")
                            drmora("cnomgru") = drcartera("cnomgru")
                            drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                            drmora("cteldom") = drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncuota") = lncuota
                            drmora("ncuotakp") = lncuotakp
                            drmora("ncuomor") = lncuotasmor
                            drmora("ccalifica") = lccalifica
                            drmora("ccalificades") = lcestrdes
                            drmora("cfiador") = lcdatosfia
                            drmora("ctipgar") = drcartera("ctipgar")
                            drmora("cnudoci") = drcartera("cnudoci")
                            drmora("cnudotr") = drcartera("cnudotr")
                            drmora("ccodcli") = drcartera("ccodcli")
                            drmora("dnacimi") = drcartera("dnacimi")
                            drmora("ncuoapr") = drcartera("ncuoapr")
                            drmora("ccodact") = drcartera("ccodact")
                            drmora("ccodcen") = drcartera("ccodcen")
                            drmora("cnomcen") = drcartera("cnomcen")

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = drcartera("cnrolin") 'clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If
                            lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                            lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva


                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0

                            lccodcta = drcartera("cCodcta")
                            drmora("cCondic") = drcartera("cCondic")
                            drmora("cStatus") = mcremcre.StatusCredito(drcartera("cCondic"))

                            drmora("coficina") = drcartera("coficina")
                            drmora("cnomofi") = mtabtofi.NombreAgencia(drcartera("coficina"))

                            drmora("ffondos") = pccodlin.Substring(2, 2)
                            drmora("cNomfon") = mtabttab.Describe(pccodlin.Substring(2, 2), "033")

                            drmora("ctipmet") = lccodcta.Substring(6, 2)
                            drmora("Producto") = mtabttab.Describe(lccodcta.Substring(6, 2), "125")

                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("ccodsol") = drcartera("ccodsol")
                        drmora("cnomgru") = drcartera("cnomgru")
                        drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                        drmora("cteldom") = drcartera("cteldom")
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("ncuota") = lncuota
                        drmora("ncuotakp") = lncuotakp
                        drmora("ncuomor") = lncuotasmor
                        drmora("ccalifica") = lccalifica
                        drmora("ccalificades") = lcestrdes
                        drmora("cfiador") = lcdatosfia
                        drmora("ctipgar") = drcartera("ctipgar")
                        drmora("cnudoci") = drcartera("cnudoci")
                        drmora("cnudotr") = drcartera("cnudotr")
                        drmora("ccodcli") = drcartera("ccodcli")
                        drmora("dnacimi") = drcartera("dnacimi")
                        drmora("ncuoapr") = drcartera("ncuoapr")
                        drmora("ccodact") = drcartera("ccodact")


                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        drmora("ccodcen") = drcartera("ccodcen")
                        drmora("cnomcen") = drcartera("cnomcen")

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr

                        'calculos de los seguros

                        ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        entidadcretlin.cnrolin = drcartera("cnrolin") 'clsaplica.cnrolin
                        ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = entidadcretlin.ccodlin
                        lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        'If pccodlin.Substring(8, 2) = "06" Then
                        '    lngasadm = 0
                        'Else
                        '    If clsaplica.pdfecvig > #11/1/2005# Then
                        '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                        '    Else
                        '        lngasadm = 0
                        '    End If
                        'End If
                        'If lsegdeu = True Then
                        '    If clsaplica.pdfecvig >= #7/11/2008# Then
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                        '    Else
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                        '    End If

                        'Else
                        '    lnsegdeu = 0
                        'End If
                        lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                        lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva


                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0

                        drmora("cCondic") = drcartera("cCondic")
                        drmora("cStatus") = mcremcre.StatusCredito(drcartera("cCondic"))

                        drmora("coficina") = drcartera("coficina")
                        drmora("cnomofi") = mtabtofi.NombreAgencia(drcartera("coficina"))

                        drmora("ffondos") = pccodlin.Substring(2, 2)
                        drmora("cNomfon") = mtabttab.Describe(pccodlin.Substring(2, 2), "033")

                        drmora("ctipmet") = lccodcta.Substring(6, 2)
                        drmora("Producto") = mtabttab.Describe(lccodcta.Substring(6, 2), "125")
                        'finaliza calculo de los seguros


                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function

    Public Function DETALLE_CARTERA_Y_PAGOS_AJUSTES(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo

        Return mDb.DETALLE_CARTERA_Y_PAGOS_AJUSTES(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona)
    End Function

    Public Function CarteraCalculadaTras(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, ctipgar, cteldom, cNudoci, cNudotr, ccodcli, dnacimi, ncuoapr, ncuomor, ccodact, ccodsol, cnomgru, ccodcen, cnomcen, ncuotakp, "
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,S,S,S,S,F,D,D,S,S,S,S,S,D,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)

        dscartera = clscartera.CarteraCalculadaCondicionTras(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)

        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        nn = dscartera.Tables(0).Rows.Count

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0


            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra

                clsaplica.pcestado = drcartera("cestado")

                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                    Dim lncuotakp As Double = 0
                    lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                    'lncuota = clsaplica.pnmoncuo
                    Dim lncuotasmor As Integer = 0
                    'Cuotas Atrasadas
                    If lndiaatr > 0 And lncuotakp > 0 Then
                        lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                    Else
                        lncuotasmor = 0
                    End If

                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                            drmora = lcMORA.NewRow()
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfecvig")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("ccodsol") = drcartera("ccodsol")
                            drmora("cnomgru") = drcartera("cnomgru")
                            drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                            drmora("cteldom") = drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncuota") = lncuota
                            drmora("ncuotakp") = lncuotakp
                            drmora("ncuomor") = lncuotasmor
                            drmora("ccalifica") = lccalifica
                            drmora("ccalificades") = lcestrdes
                            drmora("cfiador") = lcdatosfia
                            drmora("ctipgar") = drcartera("ctipgar")
                            drmora("cnudoci") = drcartera("cnudoci")
                            drmora("cnudotr") = drcartera("cnudotr")
                            drmora("ccodcli") = drcartera("ccodcli")
                            drmora("dnacimi") = drcartera("dnacimi")
                            drmora("ncuoapr") = drcartera("ncuoapr")
                            drmora("ccodact") = drcartera("ccodact")
                            drmora("ccodcen") = drcartera("ccodcen")
                            drmora("cnomcen") = drcartera("cnomcen")


                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If

                            lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                            lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva

                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0
                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("ccodsol") = drcartera("ccodsol")
                        drmora("cnomgru") = drcartera("cnomgru")
                        drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                        drmora("cteldom") = drcartera("cteldom")
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("ncuota") = lncuota
                        drmora("ncuotakp") = lncuotakp
                        drmora("ncuomor") = lncuotasmor
                        drmora("ccalifica") = lccalifica
                        drmora("ccalificades") = lcestrdes
                        drmora("cfiador") = lcdatosfia
                        drmora("ctipgar") = drcartera("ctipgar")
                        drmora("cnudoci") = drcartera("cnudoci")
                        drmora("cnudotr") = drcartera("cnudotr")
                        drmora("ccodcli") = drcartera("ccodcli")
                        drmora("dnacimi") = drcartera("dnacimi")
                        drmora("ncuoapr") = drcartera("ncuoapr")
                        drmora("ccodact") = drcartera("ccodact")


                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        drmora("ccodcen") = drcartera("ccodcen")
                        drmora("cnomcen") = drcartera("cnomcen")

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr

                        'calculos de los seguros

                        ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        entidadcretlin.cnrolin = clsaplica.cnrolin
                        ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = entidadcretlin.ccodlin
                        lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        'If pccodlin.Substring(8, 2) = "06" Then
                        '    lngasadm = 0
                        'Else
                        '    If clsaplica.pdfecvig > #11/1/2005# Then
                        '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                        '    Else
                        '        lngasadm = 0
                        '    End If
                        'End If
                        'If lsegdeu = True Then
                        '    If clsaplica.pdfecvig >= #7/11/2008# Then
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                        '    Else
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                        '    End If

                        'Else
                        '    lnsegdeu = 0
                        'End If
                        lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                        lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva


                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0


                        'finaliza calculo de los seguros


                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function

    'Public Function CarteraCalculadaTransunion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal lcproducto As String) As DataSet
    '    Dim lcampos1 As String
    '    Dim ltipos1 As String
    '    Dim lcMORA As DataTable
    '    Dim clsprin As New class1
    '    Dim dscartera As New DataSet
    '    Dim clscartera As New dbCreditos
    '    Dim dsmora As New DataSet
    '    Dim drcartera As DataRow
    '    Dim drmora As DataRow
    '    Dim categoria As String
    '    Dim lnsalintmor As Double
    '    Dim lngasadm As Double
    '    Dim lnseguros As Double
    '    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    '    Dim clsaplica As New payment
    '    Dim ok As Integer
    '    Dim ecretlin As New cCretlin
    '    Dim ecredkar As New cCredkar
    '    Dim ldultfecha As Date
    '    Dim pccodlin As String
    '    Dim lsegdeu As Boolean
    '    Dim lndias As Integer
    '    Dim entidadcretlin As New cretlin
    '    Dim lnsegdeu As Double
    '    Dim clsppal As New class1
    '    Dim eclimgar As New cClimgar
    '    Dim etabtzon As New cTabtzon
    '    Dim eclidfin As New cClidfin
    '    Dim lcdeszon As String
    '    Dim lcdirneg As String
    '    Dim lnmanejo As Double = 0
    '    Dim lniva As Double = 0

    '    If lcestrato = "A1" Then
    '        categoria = "  drcartera('ndiaatr') <=  0"
    '    ElseIf lcestrato = "A" Then
    '        categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
    '    ElseIf lcestrato = "B" Then
    '        categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
    '    ElseIf lcestrato = "C" Then
    '        categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
    '    ElseIf lcestrato = "D" Then
    '        categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
    '    Else
    '        categoria = " drcartera('ndiaatr')> 180 "
    '    End If

    '    lcampos1 = "id,apellido1,apellido2,nombre1,nombre2,apellido3,norden,registro,municipioced,fechanacimiento,nit,emisor,numcredito,relacion,tipocredito,tipomoneda,fechaapertura,plazo,fechaultimopago,saldo,limitecredito,saldov,pagosvencidos,estado,diasmora,"
    '    ltipos1 = "S,S,S,S,S,S,S,S,S,F,S,S,S,S,S,S,F,I,F,D,D,D,I,S,I,"
    '    lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

    '    'Dim cancela As String
    '    'cancela = "0"
    '    clscartera.dbcartera = Me.cartera
    '    clscartera.dbtipo = Me.tipo

    '    '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)

    '    dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)

    '    lnsalintmor = 0

    '    Dim lcestrdes As String
    '    Dim lccalifica As String
    '    Dim lndiaatr As Integer
    '    Dim lcdatosfia As String = ""
    '    Dim nn As Integer
    '    Dim lcnomcli As String = ""
    '    Dim nombre1, nombre2, apellido1, apellido2, apellido3 As String
    '    nombre1 = ""
    '    nombre2 = ""
    '    apellido1 = ""
    '    apellido2 = ""
    '    apellido3 = ""

    '    Dim posicion As Integer = 0
    '    Dim posTemp As Integer = 0
    '    nn = dscartera.Tables(0).Rows.Count
    '    Dim longitud As Integer = 0
    '    Dim lccadena As String = ""
    '    Dim lvalida As Boolean
    '    Dim lcdocumento As String = ""
    '    Dim documento As String = ""
    '    Dim lcorden As String = ""
    '    Dim lonli As Integer
    '    Dim i As Integer = 0
    '    Dim lccaracter As String = ""
    '    Dim lcregistro As String = ""
    '    Dim lccoddom As String = ""
    '    Dim entidadtabtzon As New tabtzon
    '    Dim lcmunic As String = ""
    '    Dim cproducto As String = ""

    '    For Each drcartera In dscartera.Tables(0).Rows
    '        lnseguros = 0
    '        posTemp = 0

    '        lcnomcli = drcartera("cnomcli")
    '        lccadena = lcnomcli.Trim
    '        longitud = lcnomcli.Length

    '        posicion = InStr(1, lccadena, " ")
    '        nombre1 = lccadena.Substring(0, posicion - 1)
    '        posTemp = posicion
    '        If (longitud - posTemp) > 0 Then
    '            lccadena = lcnomcli.Substring(posTemp, (longitud - posTemp))
    '            posicion = InStr(1, lccadena, " ")
    '            If posicion = 0 Then
    '                apellido1 = lccadena
    '            Else
    '                nombre2 = lccadena.Substring(0, posicion - 1)
    '                posTemp = posTemp + posicion
    '                If (longitud - posTemp) > 0 Then
    '                    lccadena = lcnomcli.Substring(posTemp, (longitud - posTemp))
    '                    posicion = InStr(1, lccadena, " ")
    '                    If posicion = 0 Then
    '                        apellido1 = lccadena
    '                    Else
    '                        apellido1 = lccadena.Substring(0, posicion - 1)
    '                        posTemp = posTemp + posicion

    '                        If (longitud - posTemp) > 0 Then
    '                            lccadena = lcnomcli.Substring(posTemp, (longitud - posTemp))
    '                            posicion = InStr(1, lccadena, " ")
    '                            If posicion = 0 Then
    '                                apellido2 = lccadena
    '                            Else
    '                                apellido2 = lccadena.Substring(0, posicion - 1)
    '                                posTemp = posTemp + posicion
    '                                If (longitud - posTemp) > 0 Then
    '                                    lccadena = lcnomcli.Substring(posTemp, (longitud - posTemp))
    '                                    posicion = InStr(1, lccadena, " ")
    '                                    If posicion = 0 Then
    '                                        apellido3 = lccadena
    '                                    Else
    '                                        apellido3 = lccadena.Substring(0, posicion - 1)
    '                                    End If
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                Else

    '                End If

    '            End If

    '        End If

    '        If apellido1.Trim = "" Then
    '            apellido1 = nombre2
    '            nombre2 = ""
    '        End If

    '        lccoddom = drcartera("ccoddom")

    '        entidadtabtzon.ccodzon = Left(lccoddom, 4)
    '        entidadtabtzon.ctipzon = "2"
    '        etabtzon.ObtenerTabtzon(entidadtabtzon)
    '        lcmunic = entidadtabtzon.cdeszon.Trim
    '        lcmunic = lcmunic.ToUpper

    '        If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
    '        Else
    '            'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
    '            lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
    '            lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
    '            clsaplica.pccodcta = drcartera("cCodcta")
    '            clsaplica.pdfecval = dfecha2
    '            clsaplica.gdfecsis = dfecha2
    '            clsaplica.gnperbas = Me.pnperbas
    '            clsaplica.gdultpag = #2/1/1970#
    '            If drcartera("dfecvig") >= #7/11/2008# Then
    '                clsaplica.porsegdeu = Me.pnsegvm1
    '            Else
    '                clsaplica.porsegdeu = Me.pnsegvm
    '            End If

    '            clsaplica.porcomision = Me.pncomtra

    '            clsaplica.pcestado = drcartera("cestado")

    '            clsaplica.gnpergra = Me.gnpergra
    '            ok = clsaplica.omcalcinterest("R")
    '            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    '            If ok = 9 Then
    '                ok = 9
    '            Else
    '                If utilNumeros.Redondear(clsaplica.pndeucap, 2) > 15 Then
    '                    If Me.pnopcion = 1 Then
    '                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
    '                    Else
    '                        lcdatosfia = ""
    '                    End If
    '                    lndiaatr = clsaplica.pndiaatr
    '                    '                    If lndiaatr > 0 Then
    '                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    '                    'Para Calcular Cuota
    '                    Dim lncuota As Double = 0
    '                    lccalifica = Me.Califica(lndiaatr)
    '                    lcestrdes = Me.CalificaDes(lndiaatr)
    '                    '---------------------------------
    '                    clsppal.gnperbas = Me.pnperbas
    '                    clsppal.pnComtra = Me.pncomtra
    '                    If drcartera("dfecvig") >= #7/11/2008# Then
    '                        clsppal.pnSegVm = Me.pnsegvm1
    '                    Else
    '                        clsppal.pnSegVm = Me.pnsegvm
    '                    End If

    '                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

    '                    Dim lncuotakp As Double = 0
    '                    lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
    '                    'lncuota = clsaplica.pnmoncuo
    '                    Dim lncuotasmor As Integer = 0
    '                    'Cuotas Atrasadas
    '                    If lndiaatr > 0 And lncuotakp > 0 Then
    '                        lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
    '                    Else
    '                        lncuotasmor = 0
    '                    End If

    '                    If lcestrato <> "*" Then
    '                        'calculo de mora  dias de atraso menores que cero
    '                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
    '                            If clsaplica.pndiaatr > 30 And clsaplica.pndeucap > 0 Then
    '                                drmora = lcMORA.NewRow()
    '                                drmora("id") = "'" & drcartera("ccodcli")
    '                                drmora("nombre1") = nombre1
    '                                drmora("nombre2") = nombre2
    '                                drmora("apellido1") = apellido1
    '                                drmora("apellido2") = apellido2
    '                                drmora("apellido3") = apellido3

    '                                lcregistro = ""
    '                                documento = drcartera("cnudoci")
    '                                lvalida = clsppal.ValidaCaracter(Left(documento.Trim, 1))
    '                                If lvalida = True Then 'Cedula
    '                                    lcdocumento = documento.Replace("-", "").Replace(",", "").Trim
    '                                    lcorden = lcdocumento.Substring(0, 3)
    '                                    lonli = lcdocumento.Trim.Length
    '                                    'Extrae registro
    '                                    For i = lonli To 1 Step -1
    '                                        lccaracter = lcdocumento.Substring(i - 1, 1)
    '                                        If lccaracter = " " Then
    '                                            Exit For
    '                                        Else
    '                                            lcregistro = lccaracter + lcregistro
    '                                        End If
    '                                    Next
    '                                    drmora("registro") = lcregistro

    '                                Else
    '                                    lcorden = ""
    '                                    drmora("registro") = drcartera("cnudoci")
    '                                End If
    '                                drmora("norden") = lcorden
    '                                drmora("municipioced") = lcmunic
    '                                drmora("fechanacimiento") = drcartera("dnacimi")
    '                                drmora("nit") = drcartera("cnudotr")
    '                                drmora("emisor") = "FONDESOL"
    '                                drmora("numcredito") = "'" & drcartera("ccodcta")
    '                                drmora("relacion") = "DEUDOR"

    '                                drmora("tipomoneda") = "QUETZALES"
    '                                drmora("fechaapertura") = drcartera("dfecvig")
    '                                'drmora("cnomcli") = drcartera("cnomcli")
    '                                'drmora("ncapdes") = drcartera("ncapdes")
    '                                'drmora("dfecvig") = drcartera("dfecvig")
    '                                'drmora("dfecven") = drcartera("dfecven")
    '                                'drmora("ntasint") = drcartera("ntasint")
    '                                'drmora("ccodsol") = drcartera("ccodsol")
    '                                'drmora("cnomgru") = drcartera("cnomgru")
    '                                'drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
    '                                'drmora("cteldom") = drcartera("cteldom")
    '                                drmora("fechaultimopago") = clsaplica.pdultpag
    '                                'drmora("ncuota") = clsaplica.pnmoncuo
    '                                drmora("saldov") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
    '                                drmora("saldo") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
    '                                'drmora("ncuota") = lncuota
    '                                'drmora("ncuotakp") = lncuotakp
    '                                drmora("pagosvencidos") = lncuotasmor
    '                                'drmora("ccalifica") = lccalifica
    '                                'drmora("ccalificades") = lcestrdes
    '                                'drmora("cfiador") = lcdatosfia
    '                                'drmora("ctipgar") = drcartera("ctipgar")
    '                                'drmora("cnudoci") = drcartera("cnudoci")
    '                                'drmora("cnudotr") = drcartera("cnudotr")
    '                                'drmora("ccodcli") = drcartera("ccodcli")
    '                                'drmora("dnacimi") = drcartera("dnacimi")
    '                                'drmora("ncuoapr") = drcartera("ncuoapr")
    '                                'drmora("ccodact") = drcartera("ccodact")
    '                                'drmora("ccodcen") = drcartera("ccodcen")
    '                                'drmora("cnomcen") = drcartera("cnomcen")

    '                                drmora("plazo") = drcartera("ncuoapr")
    '                                'If IsDBNull(drmora("ncapmora")) Then
    '                                '    drmora("ncapmora") = 0
    '                                'End If

    '                                'If drmora("ncapmora") < 0 Then
    '                                '    drmora("ncapmora") = 0
    '                                'End If

    '                                'drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
    '                                drmora("diasmora") = IIf(utilNumeros.Redondear(clsaplica.pndeucap, 2) <= 0, 0, clsaplica.pndiaatr)
    '                                'drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

    '                                'calculos de los seguros
    '                                ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

    '                                entidadcretlin.cnrolin = clsaplica.cnrolin
    '                                ecretlin.ObtenerCretlinPorllave(entidadcretlin)
    '                                pccodlin = entidadcretlin.ccodlin
    '                                lsegdeu = entidadcretlin.lsegdeu

    '                                cproducto = pccodlin.Substring(4, 2)
    '                                If cproducto = "01" Then
    '                                    drmora("limitecredito") = 50000
    '                                ElseIf lcproducto = "02" Then
    '                                    drmora("limitecredito") = 7500
    '                                Else
    '                                    drmora("limitecredito") = 10000
    '                                End If



    '                                lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
    '                                'If pccodlin.Substring(8, 2) = "06" Then
    '                                '    lngasadm = 0
    '                                'Else
    '                                '    If clsaplica.pdfecvig > #11/1/2005# Then
    '                                '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
    '                                '    Else
    '                                '        lngasadm = 0
    '                                '    End If
    '                                'End If
    '                                'If lsegdeu = True Then
    '                                '    If clsaplica.pdfecvig >= #7/11/2008# Then
    '                                '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
    '                                '    Else
    '                                '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
    '                                '    End 


    '                                'Else
    '                                '    lnsegdeu = 0
    '                                'End If
    '                                lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
    '                                lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
    '                                lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

    '                                lngasadm = lnmanejo + lniva


    '                                drmora("estado") = "1"
    '                                drmora("tipocredito") = cproducto

    '                                'drmora("ncomision") = lngasadm
    '                                'drmora("nsegdeu") = lnsegdeu
    '                                'drmora("nseguros") = 0
    '                                'finaliza calculo de los seguros
    '                                lcMORA.Rows.Add(drmora)

    '                            End If
    '                        End If

    '                    Else
    '                        'no filtra dias de atraso
    '                        If clsaplica.pndiaatr > 30 And clsaplica.pndeucap > 0 Then
    '                            lnsalintmor = 0
    '                            drmora = lcMORA.NewRow()
    '                            'drmora("nsalintmor") = clsaplica.pnsalmor
    '                            drmora("id") = "'" & drcartera("ccodcli")
    '                            drmora("nombre1") = nombre1
    '                            drmora("nombre2") = nombre2
    '                            drmora("apellido1") = apellido1
    '                            drmora("apellido2") = apellido2
    '                            drmora("apellido3") = apellido3

    '                            lcregistro = ""
    '                            documento = drcartera("cnudoci")
    '                            lvalida = clsppal.ValidaCaracter(Left(documento.Trim, 1))
    '                            If lvalida = True Then 'Cedula
    '                                lcdocumento = documento.Replace("-", "").Replace(",", "").Trim
    '                                lcorden = lcdocumento.Substring(0, 3)
    '                                lonli = lcdocumento.Trim.Length
    '                                'Extrae registro
    '                                For i = lonli To 1 Step -1
    '                                    lccaracter = lcdocumento.Substring(i - 1, 1)
    '                                    If lccaracter = " " Then
    '                                        Exit For
    '                                    Else
    '                                        lcregistro = lccaracter + lcregistro
    '                                    End If
    '                                Next
    '                                drmora("registro") = lcregistro

    '                            Else
    '                                lcorden = ""
    '                                drmora("registro") = drcartera("cnudoci")
    '                            End If
    '                            drmora("norden") = lcorden
    '                            drmora("municipioced") = lcmunic
    '                            drmora("fechanacimiento") = drcartera("dnacimi")
    '                            drmora("nit") = drcartera("cnudotr")
    '                            drmora("emisor") = "FONDESOL"
    '                            drmora("numcredito") = "'" & drcartera("ccodcta")
    '                            drmora("relacion") = "DEUDOR"
    '                            drmora("tipomoneda") = "QUETZALES"
    '                            drmora("fechaapertura") = drcartera("dfecvig")

    '                            'drmora("cnomcli") = drcartera("cnomcli")
    '                            'drmora("ncapdes") = drcartera("ncapdes")
    '                            'drmora("dfecvig") = drcartera("dfecvig")
    '                            'drmora("dfecven") = drcartera("dfecven")
    '                            'drmora("ntasint") = drcartera("ntasint")
    '                            'drmora("ccodsol") = drcartera("ccodsol")
    '                            'drmora("cnomgru") = drcartera("cnomgru")
    '                            'drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
    '                            'drmora("cteldom") = drcartera("cteldom")
    '                            drmora("fechaultimopago") = clsaplica.pdultpag
    '                            'drmora("ncuota") = lncuota
    '                            'drmora("ncuotakp") = lncuotakp
    '                            drmora("pagosvencidos") = lncuotasmor
    '                            'drmora("ccalifica") = lccalifica
    '                            'drmora("ccalificades") = lcestrdes
    '                            'drmora("cfiador") = lcdatosfia
    '                            'drmora("ctipgar") = drcartera("ctipgar")
    '                            'drmora("cnudoci") = drcartera("cnudoci")
    '                            'drmora("cnudotr") = drcartera("cnudotr")
    '                            'drmora("ccodcli") = drcartera("ccodcli")
    '                            'drmora("dnacimi") = drcartera("dnacimi")
    '                            'drmora("ncuoapr") = drcartera("ncuoapr")
    '                            'drmora("ccodact") = drcartera("ccodact")


    '                            drmora("saldov") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
    '                            drmora("saldo") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

    '                            'drmora("ccodcen") = drcartera("ccodcen")
    '                            'drmora("cnomcen") = drcartera("cnomcen")
    '                            drmora("plazo") = drcartera("ncuoapr")

    '                            'If IsDBNull(drmora("ncapmora")) Then
    '                            '    drmora("ncapmora") = 0
    '                            'End If

    '                            'If drmora("ncapmora") < 0 Then
    '                            '    drmora("ncapmora") = 0
    '                            'End If

    '                            'drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
    '                            drmora("diasmora") = IIf(utilNumeros.Redondear(clsaplica.pndeucap, 2) <= 0, 0, clsaplica.pndiaatr)

    '                            'calculos de los seguros

    '                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

    '                            entidadcretlin.cnrolin = clsaplica.cnrolin
    '                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
    '                            pccodlin = entidadcretlin.ccodlin
    '                            lsegdeu = entidadcretlin.lsegdeu


    '                            cproducto = pccodlin.Substring(4, 2)
    '                            If cproducto = "01" Then
    '                                drmora("limitecredito") = 50000
    '                            ElseIf cproducto = "02" Then
    '                                drmora("limitecredito") = 7500
    '                            Else
    '                                drmora("limitecredito") = 10000
    '                            End If


    '                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
    '                            'If pccodlin.Substring(8, 2) = "06" Then
    '                            '    lngasadm = 0
    '                            'Else
    '                            '    If clsaplica.pdfecvig > #11/1/2005# Then
    '                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
    '                            '    Else
    '                            '        lngasadm = 0
    '                            '    End If
    '                            'End If
    '                            'If lsegdeu = True Then
    '                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
    '                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
    '                            '    Else
    '                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
    '                            '    End If

    '                            'Else
    '                            '    lnsegdeu = 0
    '                            'End If
    '                            lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
    '                            lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
    '                            lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

    '                            lngasadm = lnmanejo + lniva


    '                            'drmora("ncomision") = lngasadm
    '                            'drmora("nsegdeu") = lnsegdeu
    '                            'drmora("nseguros") = 0

    '                            drmora("estado") = "1"
    '                            drmora("tipocredito") = cproducto
    '                            'finaliza calculo de los seguros


    '                            lcMORA.Rows.Add(drmora)
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End If
    '        'End If
    '    Next

    '    dsmora.Tables.Add(lcMORA)
    '    '>>>>>>>
    '    'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
    '    '<<<<<<<<<<<<<

    '    Return dsmora

    'End Function
    Public Function CarteraCalculadaTransunion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "id,apellido1,apellido2,nombre1,nombre2,apellido3,norden,registro,municipioced,fechanacimiento,nit,emisor,numcredito,relacion,tipocredito,tipomoneda,fechaapertura,plazo,fechaultimopago,saldo,limitecredito,saldov,pagosvencidos,estado,diasmora,"
        ltipos1 = "S,S,S,S,S,S,S,S,S,F,S,S,S,S,S,S,F,I,F,D,D,D,I,S,I,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)

        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)
        dscartera = FiltraCreditosNoVencidos(dscartera.Tables(0), " coficina<>'016' ")

        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        Dim lcnomcli As String = ""
        Dim nombre1, nombre2, apellido1, apellido2, apellido3 As String
        nombre1 = ""
        nombre2 = ""
        apellido1 = ""
        apellido2 = ""
        apellido3 = ""

        Dim posicion As Integer = 0
        Dim posTemp As Integer = 0
        nn = dscartera.Tables(0).Rows.Count
        Dim longitud As Integer = 0
        Dim lccadena As String = ""
        Dim lvalida As Boolean
        Dim lcdocumento As String = ""
        Dim documento As String = ""
        Dim lcorden As String = ""
        Dim lonli As Integer
        Dim i As Integer = 0
        Dim lccaracter As String = ""
        Dim lcregistro As String = ""
        Dim lccoddom As String = ""
        Dim entidadtabtzon As New tabtzon
        Dim lcmunic As String = ""
        Dim cproducto As String = ""

        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            posTemp = 0

            lcnomcli = drcartera("cnomcli")
            lccadena = lcnomcli.Trim
            longitud = lcnomcli.Length

            posicion = InStr(1, lccadena, " ")
            nombre1 = lccadena.Substring(0, posicion - 1)
            posTemp = posicion
            If (longitud - posTemp) > 0 Then
                lccadena = lcnomcli.Substring(posTemp, (longitud - posTemp))
                posicion = InStr(1, lccadena, " ")
                If posicion = 0 Then
                    apellido1 = lccadena
                Else
                    nombre2 = lccadena.Substring(0, posicion - 1)
                    posTemp = posTemp + posicion
                    If (longitud - posTemp) > 0 Then
                        lccadena = lcnomcli.Substring(posTemp, (longitud - posTemp))
                        posicion = InStr(1, lccadena, " ")
                        If posicion = 0 Then
                            apellido1 = lccadena
                        Else
                            apellido1 = lccadena.Substring(0, posicion - 1)
                            posTemp = posTemp + posicion

                            If (longitud - posTemp) > 0 Then
                                lccadena = lcnomcli.Substring(posTemp, (longitud - posTemp))
                                posicion = InStr(1, lccadena, " ")
                                If posicion = 0 Then
                                    apellido2 = lccadena
                                Else
                                    apellido2 = lccadena.Substring(0, posicion - 1)
                                    posTemp = posTemp + posicion
                                    If (longitud - posTemp) > 0 Then
                                        lccadena = lcnomcli.Substring(posTemp, (longitud - posTemp))
                                        posicion = InStr(1, lccadena, " ")
                                        If posicion = 0 Then
                                            apellido3 = lccadena
                                        Else
                                            apellido3 = lccadena.Substring(0, posicion - 1)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Else

                    End If

                End If

            End If

            If apellido1.Trim = "" Then
                apellido1 = nombre2
                nombre2 = ""
            End If

            lccoddom = drcartera("ccoddom")

            entidadtabtzon.ccodzon = Left(lccoddom, 4)
            entidadtabtzon.ctipzon = "2"
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lcmunic = entidadtabtzon.cdeszon.Trim
            lcmunic = lcmunic.ToUpper

            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra

                clsaplica.pcestado = drcartera("cestado")

                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else

                    ' PARA BANCOS COMUNALES SEGUN REQ. CARTERA MORA CAPITAL > Q15 YA NO FILTRA MORA > 30 DIAS
                    If drcartera("ccodcta").ToString.Substring(6, 2) = 2 Then
                        If utilNumeros.Redondear(clsaplica.pndeucap, 2) >= 15 Then
                            If Me.pnopcion = 1 Then
                                lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                            Else
                                lcdatosfia = ""
                            End If
                            lndiaatr = clsaplica.pndiaatr
                            '                    If lndiaatr > 0 Then
                            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                            'Para Calcular Cuota
                            Dim lncuota As Double = 0
                            lccalifica = Me.Califica(lndiaatr)
                            lcestrdes = Me.CalificaDes(lndiaatr)
                            '---------------------------------
                            clsppal.gnperbas = Me.pnperbas
                            clsppal.pnComtra = Me.pncomtra
                            If drcartera("dfecvig") >= #7/11/2008# Then
                                clsppal.pnSegVm = Me.pnsegvm1
                            Else
                                clsppal.pnSegVm = Me.pnsegvm
                            End If

                            lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                            Dim lncuotakp As Double = 0
                            lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                            'lncuota = clsaplica.pnmoncuo
                            Dim lncuotasmor As Integer = 0
                            'Cuotas Atrasadas
                            If lndiaatr > 0 And lncuotakp > 0 Then
                                lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                            Else
                                lncuotasmor = 0
                            End If

                            If lcestrato <> "*" Then
                                'calculo de mora  dias de atraso menores que cero
                                If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                                    'If clsaplica.pndiaatr > 30 And clsaplica.pndeucap > 0 Then
                                    drmora = lcMORA.NewRow()
                                    drmora("id") = "'" & drcartera("ccodcli")
                                    drmora("nombre1") = nombre1
                                    drmora("nombre2") = nombre2
                                    drmora("apellido1") = apellido1
                                    drmora("apellido2") = apellido2
                                    drmora("apellido3") = apellido3

                                    lcregistro = ""
                                    documento = drcartera("cnudoci")
                                    lvalida = clsppal.ValidaCaracter(Left(documento.Trim, 1))
                                    If lvalida = True Then 'Cedula
                                        lcdocumento = documento.Replace("-", "").Replace(",", "").Trim
                                        lcorden = lcdocumento.Substring(0, 3)
                                        lonli = lcdocumento.Trim.Length
                                        'Extrae registro
                                        For i = lonli To 1 Step -1
                                            lccaracter = lcdocumento.Substring(i - 1, 1)
                                            If lccaracter = " " Then
                                                Exit For
                                            Else
                                                lcregistro = lccaracter + lcregistro
                                            End If
                                        Next
                                        drmora("registro") = lcregistro

                                    Else
                                        lcorden = ""
                                        drmora("registro") = drcartera("cnudoci")
                                    End If
                                    drmora("norden") = lcorden
                                    drmora("municipioced") = lcmunic
                                    drmora("fechanacimiento") = drcartera("dnacimi")
                                    drmora("nit") = drcartera("cnudotr")
                                    drmora("emisor") = "FUNDEA"
                                    drmora("numcredito") = "'" & drcartera("ccodcta")
                                    drmora("relacion") = "DEUDOR"

                                    drmora("tipomoneda") = "QUETZALES"
                                    drmora("fechaapertura") = drcartera("dfecvig")
                                    'drmora("cnomcli") = drcartera("cnomcli")
                                    'drmora("ncapdes") = drcartera("ncapdes")
                                    'drmora("dfecvig") = drcartera("dfecvig")
                                    'drmora("dfecven") = drcartera("dfecven")
                                    'drmora("ntasint") = drcartera("ntasint")
                                    'drmora("ccodsol") = drcartera("ccodsol")
                                    'drmora("cnomgru") = drcartera("cnomgru")
                                    'drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                                    'drmora("cteldom") = drcartera("cteldom")
                                    drmora("fechaultimopago") = clsaplica.pdultpag
                                    'drmora("ncuota") = clsaplica.pnmoncuo
                                    drmora("saldov") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    drmora("saldo") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    'drmora("ncuota") = lncuota
                                    'drmora("ncuotakp") = lncuotakp
                                    drmora("pagosvencidos") = lncuotasmor
                                    'drmora("ccalifica") = lccalifica
                                    'drmora("ccalificades") = lcestrdes
                                    'drmora("cfiador") = lcdatosfia
                                    'drmora("ctipgar") = drcartera("ctipgar")
                                    'drmora("cnudoci") = drcartera("cnudoci")
                                    'drmora("cnudotr") = drcartera("cnudotr")
                                    'drmora("ccodcli") = drcartera("ccodcli")
                                    'drmora("dnacimi") = drcartera("dnacimi")
                                    'drmora("ncuoapr") = drcartera("ncuoapr")
                                    'drmora("ccodact") = drcartera("ccodact")
                                    'drmora("ccodcen") = drcartera("ccodcen")
                                    'drmora("cnomcen") = drcartera("cnomcen")

                                    drmora("plazo") = drcartera("ncuoapr")
                                    'If IsDBNull(drmora("ncapmora")) Then
                                    '    drmora("ncapmora") = 0
                                    'End If

                                    'If drmora("ncapmora") < 0 Then
                                    '    drmora("ncapmora") = 0
                                    'End If

                                    'drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                    drmora("diasmora") = IIf(utilNumeros.Redondear(clsaplica.pndeucap, 2) <= 0, 0, clsaplica.pndiaatr)
                                    'drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                                    'calculos de los seguros
                                    ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                    entidadcretlin.cnrolin = clsaplica.cnrolin
                                    ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                    pccodlin = entidadcretlin.ccodlin
                                    lsegdeu = entidadcretlin.lsegdeu

                                    cproducto = pccodlin.Substring(4, 2)
                                    If cproducto = "01" Then
                                        drmora("limitecredito") = 50000
                                    ElseIf lcproducto = "02" Then
                                        drmora("limitecredito") = 7500
                                    Else
                                        drmora("limitecredito") = 10000
                                    End If



                                    lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                                    If pccodlin.Substring(8, 2) = "06" Then
                                        lngasadm = 0
                                    Else
                                        If clsaplica.pdfecvig > #11/1/2005# Then
                                            lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                                        Else
                                            lngasadm = 0
                                        End If
                                    End If
                                    If lsegdeu = True Then
                                        If clsaplica.pdfecvig >= #7/11/2008# Then
                                            lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                                        Else
                                            lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                                        End If

                                    Else
                                        lnsegdeu = 0
                                    End If

                                    drmora("estado") = "1"
                                    drmora("tipocredito") = cproducto

                                    'drmora("ncomision") = lngasadm
                                    'drmora("nsegdeu") = lnsegdeu
                                    'drmora("nseguros") = 0
                                    'finaliza calculo de los seguros
                                    lcMORA.Rows.Add(drmora)

                                    'End If
                                End If

                            Else
                                'no filtra dias de atraso
                                'If clsaplica.pndiaatr > 30 And clsaplica.pndeucap > 0 Then
                                lnsalintmor = 0
                                drmora = lcMORA.NewRow()
                                'drmora("nsalintmor") = clsaplica.pnsalmor
                                drmora("id") = "'" & drcartera("ccodcli")
                                drmora("nombre1") = nombre1
                                drmora("nombre2") = nombre2
                                drmora("apellido1") = apellido1
                                drmora("apellido2") = apellido2
                                drmora("apellido3") = apellido3

                                lcregistro = ""
                                documento = drcartera("cnudoci")
                                lvalida = clsppal.ValidaCaracter(Left(documento.Trim, 1))
                                If lvalida = True Then 'Cedula
                                    lcdocumento = documento.Replace("-", "").Replace(",", "").Trim
                                    lcorden = lcdocumento.Substring(0, 3)
                                    lonli = lcdocumento.Trim.Length
                                    'Extrae registro
                                    For i = lonli To 1 Step -1
                                        lccaracter = lcdocumento.Substring(i - 1, 1)
                                        If lccaracter = " " Then
                                            Exit For
                                        Else
                                            lcregistro = lccaracter + lcregistro
                                        End If
                                    Next
                                    drmora("registro") = lcregistro

                                Else
                                    lcorden = ""
                                    drmora("registro") = drcartera("cnudoci")
                                End If
                                drmora("norden") = lcorden
                                drmora("municipioced") = lcmunic
                                drmora("fechanacimiento") = drcartera("dnacimi")
                                drmora("nit") = drcartera("cnudotr")
                                drmora("emisor") = "FUNDEA"
                                drmora("numcredito") = "'" & drcartera("ccodcta")
                                drmora("relacion") = "DEUDOR"
                                drmora("tipomoneda") = "QUETZALES"
                                drmora("fechaapertura") = drcartera("dfecvig")

                                'drmora("cnomcli") = drcartera("cnomcli")
                                'drmora("ncapdes") = drcartera("ncapdes")
                                'drmora("dfecvig") = drcartera("dfecvig")
                                'drmora("dfecven") = drcartera("dfecven")
                                'drmora("ntasint") = drcartera("ntasint")
                                'drmora("ccodsol") = drcartera("ccodsol")
                                'drmora("cnomgru") = drcartera("cnomgru")
                                'drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                                'drmora("cteldom") = drcartera("cteldom")
                                drmora("fechaultimopago") = clsaplica.pdultpag
                                'drmora("ncuota") = lncuota
                                'drmora("ncuotakp") = lncuotakp
                                drmora("pagosvencidos") = lncuotasmor
                                'drmora("ccalifica") = lccalifica
                                'drmora("ccalificades") = lcestrdes
                                'drmora("cfiador") = lcdatosfia
                                'drmora("ctipgar") = drcartera("ctipgar")
                                'drmora("cnudoci") = drcartera("cnudoci")
                                'drmora("cnudotr") = drcartera("cnudotr")
                                'drmora("ccodcli") = drcartera("ccodcli")
                                'drmora("dnacimi") = drcartera("dnacimi")
                                'drmora("ncuoapr") = drcartera("ncuoapr")
                                'drmora("ccodact") = drcartera("ccodact")


                                drmora("saldov") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                drmora("saldo") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                                'drmora("ccodcen") = drcartera("ccodcen")
                                'drmora("cnomcen") = drcartera("cnomcen")
                                drmora("plazo") = drcartera("ncuoapr")

                                'If IsDBNull(drmora("ncapmora")) Then
                                '    drmora("ncapmora") = 0
                                'End If

                                'If drmora("ncapmora") < 0 Then
                                '    drmora("ncapmora") = 0
                                'End If

                                'drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                drmora("diasmora") = IIf(utilNumeros.Redondear(clsaplica.pndeucap, 2) <= 0, 0, clsaplica.pndiaatr)

                                'calculos de los seguros

                                ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                entidadcretlin.cnrolin = clsaplica.cnrolin
                                ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                pccodlin = entidadcretlin.ccodlin
                                lsegdeu = entidadcretlin.lsegdeu


                                cproducto = pccodlin.Substring(4, 2)
                                If cproducto = "01" Then
                                    drmora("limitecredito") = 50000
                                ElseIf cproducto = "02" Then
                                    drmora("limitecredito") = 7500
                                Else
                                    drmora("limitecredito") = 10000
                                End If


                                lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                                If pccodlin.Substring(8, 2) = "06" Then
                                    lngasadm = 0
                                Else
                                    If clsaplica.pdfecvig > #11/1/2005# Then
                                        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                                    Else
                                        lngasadm = 0
                                    End If
                                End If
                                If lsegdeu = True Then
                                    If clsaplica.pdfecvig >= #7/11/2008# Then
                                        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                                    Else
                                        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                                    End If

                                Else
                                    lnsegdeu = 0
                                End If

                                'drmora("ncomision") = lngasadm
                                'drmora("nsegdeu") = lnsegdeu
                                'drmora("nseguros") = 0

                                drmora("estado") = "1"
                                drmora("tipocredito") = cproducto
                                'finaliza calculo de los seguros


                                lcMORA.Rows.Add(drmora)
                                'End If
                            End If
                        End If
                    Else
                        '' PARA INDIVIDUALES Y GRUPOS SOLIDARIOS: TODOS LOS CREDITOS AL DIA Y EN MORA
                        '************************************************************************************************************'

                        If Me.pnopcion = 1 Then
                            lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                        Else
                            lcdatosfia = ""
                        End If
                        lndiaatr = clsaplica.pndiaatr
                        '                    If lndiaatr > 0 Then
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        'Para Calcular Cuota
                        Dim lncuota As Double = 0
                        lccalifica = Me.Califica(lndiaatr)
                        lcestrdes = Me.CalificaDes(lndiaatr)
                        '---------------------------------
                        clsppal.gnperbas = Me.pnperbas
                        clsppal.pnComtra = Me.pncomtra
                        If drcartera("dfecvig") >= #7/11/2008# Then
                            clsppal.pnSegVm = Me.pnsegvm1
                        Else
                            clsppal.pnSegVm = Me.pnsegvm
                        End If

                        lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                        Dim lncuotakp As Double = 0
                        lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                        'lncuota = clsaplica.pnmoncuo
                        Dim lncuotasmor As Integer = 0
                        'Cuotas Atrasadas
                        If lndiaatr > 0 And lncuotakp > 0 Then
                            lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                        Else
                            lncuotasmor = 0
                        End If

                        If lcestrato <> "*" Then
                            'calculo de mora  dias de atraso menores que cero
                            If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30) Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then

                                drmora = lcMORA.NewRow()
                                drmora("id") = "'" & drcartera("ccodcli")
                                drmora("nombre1") = nombre1
                                drmora("nombre2") = nombre2
                                drmora("apellido1") = apellido1
                                drmora("apellido2") = apellido2
                                drmora("apellido3") = apellido3

                                lcregistro = ""
                                documento = drcartera("cnudoci")
                                lvalida = clsppal.ValidaCaracter(Left(documento.Trim, 1))
                                If lvalida = True Then 'Cedula
                                    lcdocumento = documento.Replace("-", "").Replace(",", "").Trim
                                    lcorden = lcdocumento.Substring(0, 3)
                                    lonli = lcdocumento.Trim.Length
                                    'Extrae registro
                                    For i = lonli To 1 Step -1
                                        lccaracter = lcdocumento.Substring(i - 1, 1)
                                        If lccaracter = " " Then
                                            Exit For
                                        Else
                                            lcregistro = lccaracter + lcregistro
                                        End If
                                    Next
                                    drmora("registro") = lcregistro

                                Else
                                    lcorden = ""
                                    drmora("registro") = drcartera("cnudoci")
                                End If
                                drmora("norden") = lcorden
                                drmora("municipioced") = lcmunic
                                drmora("fechanacimiento") = drcartera("dnacimi")
                                drmora("nit") = drcartera("cnudotr")
                                drmora("emisor") = "FUNDEA"
                                drmora("numcredito") = "'" & drcartera("ccodcta")
                                drmora("relacion") = "DEUDOR"

                                drmora("tipomoneda") = "QUETZALES"
                                drmora("fechaapertura") = drcartera("dfecvig")
                                'drmora("cnomcli") = drcartera("cnomcli")
                                'drmora("ncapdes") = drcartera("ncapdes")
                                'drmora("dfecvig") = drcartera("dfecvig")
                                'drmora("dfecven") = drcartera("dfecven")
                                'drmora("ntasint") = drcartera("ntasint")
                                'drmora("ccodsol") = drcartera("ccodsol")
                                'drmora("cnomgru") = drcartera("cnomgru")
                                'drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                                'drmora("cteldom") = drcartera("cteldom")
                                drmora("fechaultimopago") = clsaplica.pdultpag
                                'drmora("ncuota") = clsaplica.pnmoncuo
                                drmora("saldov") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                drmora("saldo") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                'drmora("ncuota") = lncuota
                                'drmora("ncuotakp") = lncuotakp
                                drmora("pagosvencidos") = lncuotasmor
                                'drmora("ccalifica") = lccalifica
                                'drmora("ccalificades") = lcestrdes
                                'drmora("cfiador") = lcdatosfia
                                'drmora("ctipgar") = drcartera("ctipgar")
                                'drmora("cnudoci") = drcartera("cnudoci")
                                'drmora("cnudotr") = drcartera("cnudotr")
                                'drmora("ccodcli") = drcartera("ccodcli")
                                'drmora("dnacimi") = drcartera("dnacimi")
                                'drmora("ncuoapr") = drcartera("ncuoapr")
                                'drmora("ccodact") = drcartera("ccodact")
                                'drmora("ccodcen") = drcartera("ccodcen")
                                'drmora("cnomcen") = drcartera("cnomcen")

                                drmora("plazo") = drcartera("ncuoapr")
                                'If IsDBNull(drmora("ncapmora")) Then
                                '    drmora("ncapmora") = 0
                                'End If

                                'If drmora("ncapmora") < 0 Then
                                '    drmora("ncapmora") = 0
                                'End If

                                'drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                drmora("diasmora") = IIf(utilNumeros.Redondear(clsaplica.pndeucap, 2) <= 0, 0, clsaplica.pndiaatr)
                                'drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                                'calculos de los seguros
                                ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                entidadcretlin.cnrolin = clsaplica.cnrolin
                                ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                pccodlin = entidadcretlin.ccodlin
                                lsegdeu = entidadcretlin.lsegdeu

                                cproducto = pccodlin.Substring(4, 2)
                                If cproducto = "01" Then
                                    drmora("limitecredito") = 50000
                                ElseIf lcproducto = "02" Then
                                    drmora("limitecredito") = 7500
                                Else
                                    drmora("limitecredito") = 10000
                                End If



                                lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                                If pccodlin.Substring(8, 2) = "06" Then
                                    lngasadm = 0
                                Else
                                    If clsaplica.pdfecvig > #11/1/2005# Then
                                        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                                    Else
                                        lngasadm = 0
                                    End If
                                End If
                                If lsegdeu = True Then
                                    If clsaplica.pdfecvig >= #7/11/2008# Then
                                        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                                    Else
                                        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                                    End If

                                Else
                                    lnsegdeu = 0
                                End If

                                drmora("estado") = "1"
                                drmora("tipocredito") = cproducto

                                'drmora("ncomision") = lngasadm
                                'drmora("nsegdeu") = lnsegdeu
                                'drmora("nseguros") = 0
                                'finaliza calculo de los seguros
                                lcMORA.Rows.Add(drmora)

                            End If
                        Else
                            'no filtra dias de atraso

                            lnsalintmor = 0
                            drmora = lcMORA.NewRow()
                            'drmora("nsalintmor") = clsaplica.pnsalmor
                            drmora("id") = "'" & drcartera("ccodcli")
                            drmora("nombre1") = nombre1
                            drmora("nombre2") = nombre2
                            drmora("apellido1") = apellido1
                            drmora("apellido2") = apellido2
                            drmora("apellido3") = apellido3

                            lcregistro = ""
                            documento = drcartera("cnudoci")
                            lvalida = clsppal.ValidaCaracter(Left(documento.Trim, 1))
                            If lvalida = True And lcdocumento.Trim <> "" Then 'Cedula
                                lcdocumento = documento.Replace("-", "").Replace(",", "").Trim
                                lcorden = lcdocumento.Substring(0, 3)
                                lonli = lcdocumento.Trim.Length
                                'Extrae registro
                                For i = lonli To 1 Step -1
                                    lccaracter = lcdocumento.Substring(i - 1, 1)
                                    If lccaracter = " " Then
                                        Exit For
                                    Else
                                        lcregistro = lccaracter + lcregistro
                                    End If
                                Next
                                drmora("registro") = lcregistro

                            Else
                                lcorden = ""
                                drmora("registro") = drcartera("cnudoci")
                            End If
                            drmora("norden") = lcorden
                            drmora("municipioced") = lcmunic
                            drmora("fechanacimiento") = drcartera("dnacimi")
                            drmora("nit") = drcartera("cnudotr")
                            drmora("emisor") = "FUNDEA"
                            drmora("numcredito") = "'" & drcartera("ccodcta")
                            drmora("relacion") = "DEUDOR"
                            drmora("tipomoneda") = "QUETZALES"
                            drmora("fechaapertura") = drcartera("dfecvig")

                            'drmora("cnomcli") = drcartera("cnomcli")
                            'drmora("ncapdes") = drcartera("ncapdes")
                            'drmora("dfecvig") = drcartera("dfecvig")
                            'drmora("dfecven") = drcartera("dfecven")
                            'drmora("ntasint") = drcartera("ntasint")
                            'drmora("ccodsol") = drcartera("ccodsol")
                            'drmora("cnomgru") = drcartera("cnomgru")
                            'drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                            'drmora("cteldom") = drcartera("cteldom")
                            drmora("fechaultimopago") = clsaplica.pdultpag
                            'drmora("ncuota") = lncuota
                            'drmora("ncuotakp") = lncuotakp
                            drmora("pagosvencidos") = lncuotasmor
                            'drmora("ccalifica") = lccalifica
                            'drmora("ccalificades") = lcestrdes
                            'drmora("cfiador") = lcdatosfia
                            'drmora("ctipgar") = drcartera("ctipgar")
                            'drmora("cnudoci") = drcartera("cnudoci")
                            'drmora("cnudotr") = drcartera("cnudotr")
                            'drmora("ccodcli") = drcartera("ccodcli")
                            'drmora("dnacimi") = drcartera("dnacimi")
                            'drmora("ncuoapr") = drcartera("ncuoapr")
                            'drmora("ccodact") = drcartera("ccodact")


                            drmora("saldov") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("saldo") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                            'drmora("ccodcen") = drcartera("ccodcen")
                            'drmora("cnomcen") = drcartera("cnomcen")
                            drmora("plazo") = drcartera("ncuoapr")

                            'If IsDBNull(drmora("ncapmora")) Then
                            '    drmora("ncapmora") = 0
                            'End If

                            'If drmora("ncapmora") < 0 Then
                            '    drmora("ncapmora") = 0
                            'End If

                            'drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("diasmora") = IIf(utilNumeros.Redondear(clsaplica.pndeucap, 2) <= 0, 0, clsaplica.pndiaatr)

                            'calculos de los seguros

                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu


                            cproducto = pccodlin.Substring(4, 2)
                            If cproducto = "01" Then
                                drmora("limitecredito") = 50000
                            ElseIf cproducto = "02" Then
                                drmora("limitecredito") = 7500
                            Else
                                drmora("limitecredito") = 10000
                            End If


                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            If pccodlin.Substring(8, 2) = "06" Then
                                lngasadm = 0
                            Else
                                If clsaplica.pdfecvig > #11/1/2005# Then
                                    lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                                Else
                                    lngasadm = 0
                                End If
                            End If
                            If lsegdeu = True Then
                                If clsaplica.pdfecvig >= #7/11/2008# Then
                                    lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                                Else
                                    lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                                End If

                            Else
                                lnsegdeu = 0
                            End If

                            'drmora("ncomision") = lngasadm
                            'drmora("nsegdeu") = lnsegdeu
                            'drmora("nseguros") = 0

                            drmora("estado") = "1"
                            drmora("tipocredito") = cproducto
                            'finaliza calculo de los seguros


                            lcMORA.Rows.Add(drmora)

                        End If

                        '************************************************************************************************************'
                    End If

                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function

    Public Function FiltraCreditosNoVencidos(ByVal dt As DataTable, ByVal filtro As String) As DataSet
        Dim tabla As DataTable
        tabla = mDb.FiltraTablaInteresesVencidos(dt, filtro)

        Dim ds2 As New DataSet
        ds2.Tables.Add(tabla)

        Return ds2
    End Function

    Public Function CarteraCalculadaCuotasaVencer(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim ecredppg As New cCredppg
        Dim lcflag As String = ""

        Dim lnsaldo As Double = 0
        Dim lnsalteo30 As Double = 0
        Dim lnsalteo60 As Double = 0

        Dim lnpagar30 As Double = 0
        Dim lnpagar60 As Double = 0

        Dim ldfec30 As Date
        Dim ldfec60 As Date

        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0


        ldfec30 = dfecha2.AddDays(-30)
        ldfec60 = dfecha2.AddDays(-60)

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  120 "
        ElseIf lcestrato = "E" Then
            categoria = " drcartera('ndiaatr')> 120 AND drcartera('ndiaatr') <=  180 "
        ElseIf lcestrato = "F" Then
            categoria = " drcartera('ndiaatr')> 180 AND drcartera('ndiaatr') <=  360 "
        Else
            categoria = " drcartera('ndiaatr')> 360 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador,cteldom, npagar30, npagar60, ccodsol, cnomgru, ccodcen, cnomcen,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,S,D,D,S,S,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        Dim cancela As String
        cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)
        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)
        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "D" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)



                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                Else
                    'If Me.pnopcion = 1 Then
                    '    lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    'Else
                    lcdatosfia = ""
                    'End If
                    lndiaatr = clsaplica.pndiaatr
                    lcflag = ecredppg.CuotaseVence(drcartera("cCodcta"), dfecha1, dfecha2)
                    'lndiaatr > 0 Then
                    If lcflag.Trim <> "" Then
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        'Para Calcular Cuota
                        Dim lncuota As Double = 0
                        lccalifica = Me.Califica(lndiaatr)
                        lcestrdes = Me.CalificaDes(lndiaatr)
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        clsppal.gnperbas = Me.pnperbas
                        clsppal.pnComtra = Me.pncomtra
                        If drcartera("dfecvig") >= #7/11/2008# Then
                            clsppal.pnSegVm = Me.pnsegvm1
                        Else
                            clsppal.pnSegVm = Me.pnsegvm
                        End If

                        lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                        Dim lctelefono As String
                        If IsDBNull(drcartera("cteldom")) Then
                        Else
                            lctelefono = drcartera("cteldom")
                            drcartera("cteldom") = lctelefono.Trim
                        End If
                        'lncuota = clsaplica.pnmoncuo
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        'If lcestrato <> "*" Then
                        '    'calculo de mora  dias de atraso menores que cero
                        '    If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr >= 1 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr >= 31 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr >= 61 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr >= 91 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                        drmora = lcMORA.NewRow()
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfecvig")
                        drmora("ccodsol") = drcartera("ccodsol")
                        drmora("cnomgru") = drcartera("cnomgru")

                        drmora("ccodcen") = drcartera("ccodcen")
                        drmora("cnomcen") = drcartera("cnomcen")

                        drmora("dfecven") = Date.Parse(lcflag) 'drcartera("dfecven")
                        drmora("cdirdom") = drcartera("cdirdom") + " " + drcartera("cteldom") ' + lcdeszon + " Neg." + lcdirneg + " " +
                        drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("ncuota") = clsaplica.pnmoncuo
                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap2, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                        lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        'calcula a saldos teorico a 30 y 60 dias --------------------------------------
                        'lnsalteo30 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec30)
                        'If lnsalteo30 = 0 Then
                        '    drmora("npagar30") = 0
                        'Else
                        '    drmora("npagar30") = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))
                        'End If

                        'lnsalteo60 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec60)
                        'If lnsalteo60 = 0 Then
                        '    drmora("npagar60") = 0
                        'Else
                        '    drmora("npagar60") = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))
                        'End If
                        '-------------------------------------------------------------------------------

                        drmora("ncuota") = lncuota
                        drmora("ccalifica") = lccalifica
                        drmora("ccalificades") = lcestrdes
                        drmora("cfiador") = lcdatosfia

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr
                        drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                        'calculos de los seguros
                        ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        entidadcretlin.cnrolin = clsaplica.cnrolin
                        ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = entidadcretlin.ccodlin
                        lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)

                        lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                        lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva



                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0

                        'finaliza calculo de los seguros
                        lcMORA.Rows.Add(drmora)

                    End If


                End If
            End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function
    Public Function ListadoCreditosxGrupoVigencia(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Return mDb.ListadoCreditosxGrupoVigencia(cCodsol, dfecha)
    End Function
    Public Function CreditosxGrupoVigencia(ByVal cCodsol As String) As String
        Return mDb.CreditosxGrupoVigencia(cCodsol)
    End Function
    Public Function ConsolidadoCreditosOtorgados(ByVal Fondo As String, ByVal Agencia As String, ByVal FechaInicio As String, ByVal FechaFin As String, ByRef TotalCreditosOtorgados As Decimal, ByRef MontoOtorgado As Decimal, ByRef Promedio As Decimal, ByVal canalista As String) As DataTable
        Return mDb.ConsolidadoCreditosOtorgados(Fondo, Agencia, FechaInicio, FechaFin, TotalCreditosOtorgados, MontoOtorgado, Promedio, canalista)
    End Function
    Public Function ConsultaFDL(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As String, ByVal lczona As String, ByVal cancela As String, ByVal lcproducto As String) As DataSet
        Return mDb.ConsultaFDL(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)
    End Function
    Public Function CreditosPorPlazo(ByVal Fondo As String, ByVal Agencia As String, ByVal TipoCartera As String, ByVal FechaFin As String) As DataTable
        Return mDb.CreditosPorPlazo(Fondo, Agencia, TipoCartera, FechaFin)
    End Function
    Public Function ResumenCarteraPorProducto(ByVal Fondo As String, ByVal Agencia As String, ByVal TipoCartera As String, ByVal FechaFin As String) As DataTable
        Return mDb.ResumenCarteraPorProducto(Fondo, Agencia, TipoCartera, FechaFin)
    End Function
    Public Function PeriodicidadCobro(ByVal Fondo As String, ByVal Agencia As String, ByVal TipoCartera As String, ByVal FechaFin As String) As DataTable
        Return mDb.PeriodicidadCobro(Fondo, Agencia, TipoCartera, FechaFin)
    End Function
    Public Function ResumenDesembolso(ByVal Fondo As String, ByVal Agencia As String, ByVal Producto As String, ByVal Analista As String, ByVal FechaInicio As String, ByVal FechaFin As String) As DataTable
        Return mDb.ResumenDesembolso(Fondo, Agencia, Producto, Analista, FechaInicio, FechaFin)
    End Function
    Public Function ConsolidadoCarteraDivididaPorAgencia(ByVal Fondo As String, ByVal TipoCartera As String, ByVal FechaFin As String) As DataTable
        Return mDb.ConsolidadoCarteraDivididaPorAgencia(Fondo, TipoCartera, FechaFin)
    End Function
    Public Function ResumenIngresos(ByVal Fondo As String, ByVal Agencia As String, ByVal Producto As String, ByVal Analista As String, ByVal FechaInicio As String, ByVal FechaFin As String) As DataTable
        Return mDb.ResumenIngresos(Fondo, Agencia, Producto, Analista, FechaInicio, FechaFin)
    End Function
    Public Function CarteraConInteresesSuspendidos(ByVal Fondo As String, ByVal Agencia As String, ByVal Producto As String, ByVal FechaFin As String) As DataTable
        Return mDb.CarteraConInteresesSuspendidos(Fondo, Agencia, Producto, FechaFin)
    End Function
    Public Function DatosparaEstimacion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As DataSet
        mDb.dbtipo = Me.tipo
        Return mDb.DatosparaEstimacion(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
    End Function
    Public Function InsertarEstimacion(ByVal ccodofi As String, ByVal ffondos As String, ByVal nsaldo As Double, ByVal dfecha As Date, ByVal cmes As String, ByVal cyear As String, ByVal ccodusu As String, ByVal ccalifica As String, ByVal nestimacion As Double, ByVal cstatus As String) As Integer
        Return mDb.InsertarEstimacion(ccodofi, ffondos, nsaldo, dfecha, cmes, cyear, ccodusu, ccalifica, nestimacion, cstatus)
    End Function
    Public Function IngresosCondonados(ByVal Fondo As String, ByVal Agencia As String, ByVal Producto As String, ByVal Analista As String, ByVal FechaInicio As String, ByVal FechaFin As String) As DataTable
        Return mDb.IngresosCondonados(Fondo, Agencia, Producto, Analista, FechaInicio, FechaFin)
    End Function

    Public Function ResumenDeCartera3(ByVal Fondo As String, ByVal Agencia As String, ByVal Analista As String, ByVal TipoCartera As String, ByVal Municipio As String, ByVal FechaFin As String) As DataTable
        Return mDb.ResumenDeCartera3(Fondo, Agencia, Analista, TipoCartera, Municipio, FechaFin)
    End Function
    Public Function OtrosIngresos(ByVal Agencia As String, ByVal FechaInicio As String, ByVal FechaFin As String) As DataTable
        Return mDb.OtrosIngresos(Agencia, FechaInicio, FechaFin)
    End Function
    Public Function EstimacionCartera(ByVal dfecha As Date) As DataSet
        Return mDb.EstimacionCartera(dfecha)
    End Function
    Public Function ObtienePorcentajeEstimacion(ByVal ccalifica As String, ByVal ffondos As String) As Decimal
        Return mDb.ObtienePorcentajeEstimacion(ccalifica, ffondos)
    End Function
    Public Function ObtieneEstimacion(ByVal ffondos As String, ByVal ccodofi As String, ByVal cmes As String, ByVal cyear As String, ByVal status As String) As Decimal
        Return mDb.ObtieneEstimacion(ffondos, ccodofi, cmes, cyear, status)
    End Function
    Public Function Estimacionpor(ByVal cmes As String, ByVal cyear As String, ByVal ccodofi As String, ByVal ffondos As String, ByVal ccalifica As String) As Decimal
        Return mDb.Estimacionpor(cmes, cyear, ccodofi, ffondos, ccalifica)
    End Function
    Public Function ListadoCreditosxGrupoSolicitud(ByVal ccodsol As String) As DataSet
        Return mDb.ListadoCreditosxGrupoSolicitud(ccodsol)
    End Function
    Public Function ListadoCreditosxGrupoSolicitud2(ByVal ccodsol As String) As DataSet
        Return mDb.ListadoCreditosxGrupoSolicitud2(ccodsol)
    End Function
    Public Function ObtieneCiclo(ByVal ccodcli As String) As Integer
        Return mDb.ObtieneCiclo(ccodcli)
    End Function
    Public Function ClientexGrupoSolicitud(ByVal ccodsol As String, ByVal ccodcli As String) As String
        Return mDb.ClientexGrupoSolicitud(ccodsol, ccodcli)
    End Function
    Public Function Solicitudes(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String, ByVal dfecha As Date) As DataSet
        Return mDb.Solicitudes(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lccartera, dfecha)
    End Function

    Public Function Solicitudes_Pendientes(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, _
                                           ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, _
                                           ByVal lmora As Boolean, ByVal lccartera As String, ByVal dfecha As Date) As DataSet
        Return mDb.Solicitudes_Pendientes(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, lccartera, dfecha)
    End Function


    Public Function ResumenAldeas(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        dscartera = clscartera.RAldeas(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera, lczona)
        Dim lnmuni As Integer
        lnmuni = dscartera.Tables(0).Rows.Count

        Dim elem As Integer
        Dim clcreditos As New dbCreditos
        Dim fila1 As DataRow
        Dim lccodzon As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        For Each fila1 In dscartera.Tables(0).Rows
            lccodzon = dscartera.Tables(0).Rows(elem)("cCodZon")
            lccodzon = lccodzon.Trim
            lncreditos = clcreditos.TotalCreditos(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                lnmonto = clcreditos.MontoTotal(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
                lnsaldo = clcreditos.SaldoTotal(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
                lncarafecta = clcreditos.Saldoafectado(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
                lncasosafec = clcreditos.casosafectado(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    Public Function Comisiones(ByVal nmonto As Double, ByVal csector As String, ByVal lsegvid As Boolean) As DataTable
        Return mDb.Comisiones(nmonto, csector, lsegvid)
    End Function
    Public Function EstructuraComisiones() As DataSet
        Return mDb.EstructuraComisiones()
    End Function
    Public Function ComisionesGrupal(ByVal dsgrupo As DataSet) As DataTable
        Return mDb.ComisionesGrupal(dsgrupo)
    End Function
    Public Function HistorialCreditos(ByVal ccodcli As String) As DataSet
        Return mDb.HistorialCreditos(ccodcli)
    End Function
    Public Function SaldoxCuenta2(ByVal ccodcta As String, ByVal dfecha As Date) As DataSet
        Return mDb.SaldoxCuenta2(ccodcta, dfecha)
    End Function

    Public Function GeneradordeReportes(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, _
                                        ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, _
                                        ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, _
                                        ByVal lcproducto As String, ByVal ccampos As String, ByVal ctipos As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = ccampos '"ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, ctipgar, cteldom, cNudoci, cNudotr, ccodcli, dnacimi, ncuoapr, ncuomor, ccodact, ccodsol, cnomgru, ccodcen, cnomcen, ncuotakp, cdias, cdesdias, dultpag2, ccodana, cnomana, ccodofi, cnomofi,"
        ltipos1 = ctipos '"S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,S,S,S,S,F,D,D,S,S,S,S,S,D,S,S,F,S,S,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"

        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)

        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, _
                                                Me.cartera, lczona, lcproducto)

        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        Dim lniva As Double = 0
        Dim lnciclo As Integer = 0
        nn = dscartera.Tables(0).Rows.Count

        Dim etabtciu As New cTabtciu
        Dim etabttab As New cTabttab

        Dim k As Integer = 0
        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0

            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra

                clsaplica.pcestado = drcartera("cestado")

                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                    Dim lncuotakp As Double = 0
                    lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                    'lncuota = clsaplica.pnmoncuo
                    Dim lncuotasmor As Integer = 0
                    'Cuotas Atrasadas
                    If lndiaatr > 0 And lncuotakp > 0 Then
                        lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                    Else
                        lncuotasmor = 0
                    End If

                    If plven = True Then
                        If pdfecha >= drcartera("dfecven") Then ' Adiciona datos-------------
                            If lmora = True Then 'No adicionara a creditos al dia data
                                If lndiaatr > 0 Then
                                    'calculo de mora  dias de atraso menores que cero

                                    drmora = lcMORA.NewRow() '--------------------------------------------------
                                    If clsppal.IncluirCampo(ccampos, "ntasmor") Then
                                        drmora("ntasmor") = drcartera("ntasmor") '
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "coficina") Then
                                        drmora("coficina") = "'" & drcartera("cnomofi") '
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "ccodcta") Then
                                        drmora("ccodcta") = "'" & drcartera("ccodcta") '
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "cnomcli") Then
                                        drmora("cnomcli") = drcartera("cnomcli")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "ccodcli") Then
                                        drmora("ccodcli") = "'" & drcartera("ccodcli")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nnumhom") Then
                                        If drcartera("csexo") = "M" Then
                                            drmora("nnumhom") = 1
                                        Else
                                            drmora("nnumhom") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nnummuj") Then
                                        If drcartera("csexo") = "F" Then
                                            drmora("nnummuj") = 1
                                        Else
                                            drmora("nnummuj") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nnumhomp") Then
                                        lnciclo = ciclo(drcartera("ccodcli"), drcartera("ccodcta"))
                                        If lnciclo = 1 And drcartera("csexo") = "M" Then
                                            drmora("nnumhomp") = 1
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nnummujp") Then
                                        lnciclo = ciclo(drcartera("ccodcli"), drcartera("ccodcta"))
                                        If lnciclo = 1 And drcartera("csexo") = "F" Then
                                            drmora("nnummujp") = 1
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "dfecvig") Then
                                        drmora("dfecvig") = drcartera("dfecvig")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmontotot") Then
                                        drmora("nmontotot") = drcartera("ncapdes")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmontohom") Then
                                        If drcartera("csexo") = "M" Then
                                            drmora("nmontohom") = drcartera("ncapdes")
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmontomuj") Then
                                        If drcartera("csexo") = "F" Then
                                            drmora("nmontomuj") = drcartera("ncapdes")
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalcap") Then
                                        drmora("nsalcap") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    End If
                                    If pltoda = False Then
                                        If clsppal.IncluirCampo(ccampos, "nsalafe1") Then
                                            If clsaplica.pndiaatr >= 1 And clsaplica.pndiaatr <= 30 Then
                                                drmora("nsalafe1") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe1") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nsalafe2") Then
                                            If clsaplica.pndiaatr >= 31 And clsaplica.pndiaatr <= 60 Then
                                                drmora("nsalafe2") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe2") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nsalafe3") Then
                                            If clsaplica.pndiaatr >= 61 And clsaplica.pndiaatr <= 90 Then
                                                drmora("nsalafe3") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe3") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nsalafe4") Then
                                            If clsaplica.pndiaatr >= 91 And clsaplica.pndiaatr <= 180 Then
                                                drmora("nsalafe4") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe4") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nsalafe5") Then
                                            If clsaplica.pndiaatr >= 181 Then
                                                drmora("nsalafe5") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe5") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap1") Then
                                            If clsaplica.pndiaatr >= 1 And clsaplica.pndiaatr <= 30 Then
                                                drmora("nmorcap1") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap1") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap2") Then
                                            If clsaplica.pndiaatr >= 31 And clsaplica.pndiaatr <= 60 Then
                                                drmora("nmorcap2") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap2") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap3") Then
                                            If clsaplica.pndiaatr >= 61 And clsaplica.pndiaatr <= 90 Then
                                                drmora("nmorcap3") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap3") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap4") Then
                                            If clsaplica.pndiaatr >= 91 And clsaplica.pndiaatr <= 180 Then
                                                drmora("nmorcap4") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap4") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap5") Then
                                            If clsaplica.pndiaatr >= 181 Then
                                                drmora("nmorcap5") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap5") = 0
                                            End If
                                        End If

                                        If clsppal.IncluirCampo(ccampos, "cnomgru") Then
                                            drmora("cnomgru") = drcartera("cnomgru")
                                        End If

                                    Else 'Rangos personalizados
                                        If clsppal.IncluirCampo(ccampos, "nsalafe1") Then
                                            If clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2 Then
                                                drmora("nsalafe1") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe1") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nsalafe2") Then
                                            If clsaplica.pndiaatr > pnRango2 And clsaplica.pndiaatr <= pnRango3 Then
                                                drmora("nsalafe2") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe2") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nsalafe3") Then
                                            If clsaplica.pndiaatr > pnRango3 And clsaplica.pndiaatr <= pnRango4 Then
                                                drmora("nsalafe3") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe3") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nsalafe4") Then
                                            If clsaplica.pndiaatr > pnRango4 And clsaplica.pndiaatr <= pnRango5 Then
                                                drmora("nsalafe4") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe4") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nsalafe5") Then
                                            If clsaplica.pndiaatr > pnRango5 Then
                                                drmora("nsalafe5") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                            Else
                                                drmora("nsalafe5") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap1") Then
                                            If clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2 Then
                                                drmora("nmorcap1") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap1") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap2") Then
                                            If clsaplica.pndiaatr > pnRango2 And clsaplica.pndiaatr <= pnRango3 Then
                                                drmora("nmorcap2") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap2") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap3") Then
                                            If clsaplica.pndiaatr > pnRango3 And clsaplica.pndiaatr <= pnRango4 Then
                                                drmora("nmorcap3") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap3") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap4") Then
                                            If clsaplica.pndiaatr > pnRango4 And clsaplica.pndiaatr <= pnRango5 Then
                                                drmora("nmorcap4") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap4") = 0
                                            End If
                                        End If
                                        If clsppal.IncluirCampo(ccampos, "nmorcap5") Then
                                            If clsaplica.pndiaatr > pnRango5 Then
                                                drmora("nmorcap5") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                            Else
                                                drmora("nmorcap5") = 0
                                            End If
                                        End If

                                    End If
                                    If clsppal.IncluirCampo(ccampos, "ncuota") Then
                                        drmora("ncuota") = drcartera("nmoncuo")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "ndiaatr") Then
                                        drmora("ndiaatr") = clsaplica.pndiaatr
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "dfecven") Then
                                        drmora("dfecven") = drcartera("dfecven")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "cnomana") Then
                                        drmora("cnomana") = drcartera("cnomana")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "ccodana") Then
                                        drmora("ccodana") = drcartera("ccodana")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "ncapmora") Then
                                        drmora("ncapmora") = Math.Round(clsaplica.pndeucap, 2)
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafecta") Then
                                        If Math.Round(clsaplica.pndeucap, 2) > 0 Then
                                            drmora("nsalafecta") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafecta") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "cdirdom") Then
                                        drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "ctelefono") Then
                                        drmora("ctelefono") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "dultpag") Then
                                        drmora("dultpag") = clsaplica.pdultpag
                                    End If
                                    '------------------
                                    If clsppal.IncluirCampo(ccampos, "cfondo") Then
                                        drmora("cfondo") = etabttab.Describe(drcartera("ffondos"), "033")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "ctipgar") Then
                                        drmora("ctipgar") = clsppal.TipodeGarantia(drcartera("ccodcta"))
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "cdestino") Then
                                        drmora("cdestino") = etabttab.Describe(drcartera("cdescre"), "005")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "ntasint") Then
                                        drmora("ntasint") = drcartera("ntasint")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "cacteco") Then
                                        drmora("cacteco") = etabtciu.CIIU(drcartera("ccodact"))
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "cproducto") Then
                                        drmora("cproducto") = etabttab.Describe(drcartera("ccodlin").substring(8, 2), "075")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalint") Then
                                        drmora("nsalint") = Math.Round(clsaplica.pnsalint, 2)
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalmor") Then
                                        drmora("nsalmor") = Math.Round(clsaplica.pnsalmor, 2)
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "cprograma") Then
                                        drmora("cprograma") = etabttab.Describe(drcartera("ccodlin").substring(6, 2), "034")
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "tipoInteres") Then
                                        drmora("tipoInteres") = IIf(Trim(drcartera("cflat")) = "F", "FLAT", "Sobre Saldo")
                                    End If

                                    If clsppal.IncluirCampo(ccampos, "cnomgru") Then
                                        drmora("cnomgru") = drcartera("cnomgru")
                                    End If
                                    '------------------


                                    lcMORA.Rows.Add(drmora)

                                End If
                            Else
                                'calculo de mora  dias de atraso menores que cero

                                drmora = lcMORA.NewRow() '--------------------------------------------------
                                If clsppal.IncluirCampo(ccampos, "ntasmor") Then
                                    drmora("ntasmor") = drcartera("ntasmor") '
                                End If
                                If clsppal.IncluirCampo(ccampos, "coficina") Then
                                    drmora("coficina") = "'" & drcartera("cnomofi") '"'" &
                                End If
                                If clsppal.IncluirCampo(ccampos, "ccodcta") Then
                                    drmora("ccodcta") = "'" & drcartera("ccodcta") '"'" &
                                End If
                                If clsppal.IncluirCampo(ccampos, "cnomcli") Then
                                    drmora("cnomcli") = drcartera("cnomcli")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ccodcli") Then
                                    drmora("ccodcli") = "'" & drcartera("ccodcli")
                                End If
                                If clsppal.IncluirCampo(ccampos, "nnumhom") Then
                                    If drcartera("csexo") = "M" Then
                                        drmora("nnumhom") = 1
                                    Else
                                        drmora("nnumhom") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nnummuj") Then
                                    If drcartera("csexo") = "F" Then
                                        drmora("nnummuj") = 1
                                    Else
                                        drmora("nnummuj") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nnumhomp") Then
                                    lnciclo = ciclo(drcartera("ccodcli"), drcartera("ccodcta"))
                                    If lnciclo = 1 And drcartera("csexo") = "M" Then
                                        drmora("nnumhomp") = 1
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nnummujp") Then
                                    lnciclo = ciclo(drcartera("ccodcli"), drcartera("ccodcta"))
                                    If lnciclo = 1 And drcartera("csexo") = "F" Then
                                        drmora("nnummujp") = 1
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "dfecvig") Then
                                    drmora("dfecvig") = drcartera("dfecvig")
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmontotot") Then
                                    drmora("nmontotot") = drcartera("ncapdes")
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmontohom") Then
                                    If drcartera("csexo") = "M" Then
                                        drmora("nmontohom") = drcartera("ncapdes")
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmontomuj") Then
                                    If drcartera("csexo") = "F" Then
                                        drmora("nmontomuj") = drcartera("ncapdes")
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalcap") Then
                                    drmora("nsalcap") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                End If
                                If pltoda = False Then
                                    If clsppal.IncluirCampo(ccampos, "nsalafe1") Then
                                        If clsaplica.pndiaatr >= 1 And clsaplica.pndiaatr <= 30 Then
                                            drmora("nsalafe1") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe1") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe2") Then
                                        If clsaplica.pndiaatr >= 31 And clsaplica.pndiaatr <= 60 Then
                                            drmora("nsalafe2") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe2") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe3") Then
                                        If clsaplica.pndiaatr >= 61 And clsaplica.pndiaatr <= 90 Then
                                            drmora("nsalafe3") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe3") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe4") Then
                                        If clsaplica.pndiaatr >= 91 And clsaplica.pndiaatr <= 180 Then
                                            drmora("nsalafe4") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe4") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe5") Then
                                        If clsaplica.pndiaatr >= 181 Then
                                            drmora("nsalafe5") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe5") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap1") Then
                                        If clsaplica.pndiaatr >= 1 And clsaplica.pndiaatr <= 30 Then
                                            drmora("nmorcap1") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap1") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap2") Then
                                        If clsaplica.pndiaatr >= 31 And clsaplica.pndiaatr <= 60 Then
                                            drmora("nmorcap2") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap2") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap3") Then
                                        If clsaplica.pndiaatr >= 61 And clsaplica.pndiaatr <= 90 Then
                                            drmora("nmorcap3") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap3") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap4") Then
                                        If clsaplica.pndiaatr >= 91 And clsaplica.pndiaatr <= 180 Then
                                            drmora("nmorcap4") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap4") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap5") Then
                                        If clsaplica.pndiaatr >= 181 Then
                                            drmora("nmorcap5") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap5") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "cnomgru") Then
                                        drmora("cnomgru") = drcartera("cnomgru")
                                    End If

                                Else 'Rangos personalizados
                                    If clsppal.IncluirCampo(ccampos, "nsalafe1") Then
                                        If clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2 Then
                                            drmora("nsalafe1") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe1") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe2") Then
                                        If clsaplica.pndiaatr > pnRango2 And clsaplica.pndiaatr <= pnRango3 Then
                                            drmora("nsalafe2") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe2") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe3") Then
                                        If clsaplica.pndiaatr > pnRango3 And clsaplica.pndiaatr <= pnRango4 Then
                                            drmora("nsalafe3") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe3") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe4") Then
                                        If clsaplica.pndiaatr > pnRango4 And clsaplica.pndiaatr <= pnRango5 Then
                                            drmora("nsalafe4") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe4") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe5") Then
                                        If clsaplica.pndiaatr > pnRango5 Then
                                            drmora("nsalafe5") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe5") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap1") Then
                                        If clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2 Then
                                            drmora("nmorcap1") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap1") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap2") Then
                                        If clsaplica.pndiaatr > pnRango2 And clsaplica.pndiaatr <= pnRango3 Then
                                            drmora("nmorcap2") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap2") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap3") Then
                                        If clsaplica.pndiaatr > pnRango3 And clsaplica.pndiaatr <= pnRango4 Then
                                            drmora("nmorcap3") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap3") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap4") Then
                                        If clsaplica.pndiaatr > pnRango4 And clsaplica.pndiaatr <= pnRango5 Then
                                            drmora("nmorcap4") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap4") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap5") Then
                                        If clsaplica.pndiaatr > pnRango5 Then
                                            drmora("nmorcap5") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap5") = 0
                                        End If
                                    End If

                                End If
                                If clsppal.IncluirCampo(ccampos, "ncuota") Then
                                    drmora("ncuota") = drcartera("nmoncuo")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ndiaatr") Then
                                    drmora("ndiaatr") = clsaplica.pndiaatr
                                End If
                                If clsppal.IncluirCampo(ccampos, "dfecven") Then
                                    drmora("dfecven") = drcartera("dfecven")
                                End If
                                If clsppal.IncluirCampo(ccampos, "cnomana") Then
                                    drmora("cnomana") = drcartera("cnomana")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ccodana") Then
                                    drmora("ccodana") = drcartera("ccodana")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ncapmora") Then
                                    drmora("ncapmora") = Math.Round(clsaplica.pndeucap, 2)
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafecta") Then
                                    If Math.Round(clsaplica.pndeucap, 2) > 0 Then
                                        drmora("nsalafecta") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafecta") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "cdirdom") Then
                                    drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ctelefono") Then
                                    drmora("ctelefono") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                                End If
                                If clsppal.IncluirCampo(ccampos, "dultpag") Then
                                    drmora("dultpag") = clsaplica.pdultpag
                                End If
                                '------------------
                                If clsppal.IncluirCampo(ccampos, "cfondo") Then
                                    drmora("cfondo") = etabttab.Describe(drcartera("ffondos"), "033")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ctipgar") Then
                                    drmora("ctipgar") = clsppal.TipodeGarantia(drcartera("ccodcta"))
                                End If
                                If clsppal.IncluirCampo(ccampos, "cdestino") Then
                                    drmora("cdestino") = etabttab.Describe(drcartera("cdescre"), "005")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ntasint") Then
                                    drmora("ntasint") = drcartera("ntasint")
                                End If
                                If clsppal.IncluirCampo(ccampos, "cacteco") Then
                                    drmora("cacteco") = etabtciu.CIIU(drcartera("ccodact"))
                                End If
                                If clsppal.IncluirCampo(ccampos, "cproducto") Then
                                    drmora("cproducto") = etabttab.Describe(drcartera("ccodlin").substring(8, 2), "075")
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalint") Then
                                    drmora("nsalint") = Math.Round(clsaplica.pnsalint, 2)
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalmor") Then
                                    drmora("nsalmor") = Math.Round(clsaplica.pnsalmor, 2)
                                End If
                                If clsppal.IncluirCampo(ccampos, "cprograma") Then
                                    drmora("cprograma") = etabttab.Describe(drcartera("ccodlin").substring(6, 2), "034")
                                End If
                                If clsppal.IncluirCampo(ccampos, "tipoInteres") Then
                                    drmora("tipoInteres") = IIf(Trim(drcartera("cflat")) = "F", "FLAT", "Sobre Saldo")
                                End If

                                If clsppal.IncluirCampo(ccampos, "cnomgru") Then
                                    drmora("cnomgru") = drcartera("cnomgru")
                                End If


                                '------------------
                                lcMORA.Rows.Add(drmora)


                            End If

                        End If
                    Else 'Adiciona datos------------------------------------------------------
                        If lmora = True Then 'No adicionara a creditos al dia data
                            If lndiaatr > 0 Then
                                'calculo de mora  dias de atraso menores que cero

                                drmora = lcMORA.NewRow() '--------------------------------------------------
                                If clsppal.IncluirCampo(ccampos, "ntasmor") Then
                                    drmora("ntasmor") = drcartera("ntasmor") '
                                End If
                                If clsppal.IncluirCampo(ccampos, "coficina") Then
                                    drmora("coficina") = "'" & drcartera("cnomofi") '"'" &
                                End If
                                If clsppal.IncluirCampo(ccampos, "ccodcta") Then
                                    drmora("ccodcta") = "'" & drcartera("ccodcta") '"'" &
                                End If
                                If clsppal.IncluirCampo(ccampos, "cnomcli") Then
                                    drmora("cnomcli") = drcartera("cnomcli")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ccodcli") Then
                                    drmora("ccodcli") = "'" & drcartera("ccodcli")
                                End If
                                If clsppal.IncluirCampo(ccampos, "nnumhom") Then
                                    If drcartera("csexo") = "M" Then
                                        drmora("nnumhom") = 1
                                    Else
                                        drmora("nnumhom") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nnummuj") Then
                                    If drcartera("csexo") = "F" Then
                                        drmora("nnummuj") = 1
                                    Else
                                        drmora("nnummuj") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nnumhomp") Then
                                    lnciclo = ciclo(drcartera("ccodcli"), drcartera("ccodcta"))
                                    If lnciclo = 1 And drcartera("csexo") = "M" Then
                                        drmora("nnumhomp") = 1
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nnummujp") Then
                                    lnciclo = ciclo(drcartera("ccodcli"), drcartera("ccodcta"))
                                    If lnciclo = 1 And drcartera("csexo") = "F" Then
                                        drmora("nnummujp") = 1
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "dfecvig") Then
                                    drmora("dfecvig") = drcartera("dfecvig")
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmontotot") Then
                                    drmora("nmontotot") = drcartera("ncapdes")
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmontohom") Then
                                    If drcartera("csexo") = "M" Then
                                        drmora("nmontohom") = drcartera("ncapdes")
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmontomuj") Then
                                    If drcartera("csexo") = "F" Then
                                        drmora("nmontomuj") = drcartera("ncapdes")
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalcap") Then
                                    drmora("nsalcap") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                End If
                                If pltoda = False Then
                                    If clsppal.IncluirCampo(ccampos, "nsalafe1") Then
                                        If clsaplica.pndiaatr >= 1 And clsaplica.pndiaatr <= 30 Then
                                            drmora("nsalafe1") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe1") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe2") Then
                                        If clsaplica.pndiaatr >= 31 And clsaplica.pndiaatr <= 60 Then
                                            drmora("nsalafe2") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe2") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe3") Then
                                        If clsaplica.pndiaatr >= 61 And clsaplica.pndiaatr <= 90 Then
                                            drmora("nsalafe3") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe3") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe4") Then
                                        If clsaplica.pndiaatr >= 91 And clsaplica.pndiaatr <= 180 Then
                                            drmora("nsalafe4") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe4") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe5") Then
                                        If clsaplica.pndiaatr >= 181 Then
                                            drmora("nsalafe5") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe5") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap1") Then
                                        If clsaplica.pndiaatr >= 1 And clsaplica.pndiaatr <= 30 Then
                                            drmora("nmorcap1") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap1") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap2") Then
                                        If clsaplica.pndiaatr >= 31 And clsaplica.pndiaatr <= 60 Then
                                            drmora("nmorcap2") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap2") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap3") Then
                                        If clsaplica.pndiaatr >= 61 And clsaplica.pndiaatr <= 90 Then
                                            drmora("nmorcap3") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap3") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap4") Then
                                        If clsaplica.pndiaatr >= 91 And clsaplica.pndiaatr <= 180 Then
                                            drmora("nmorcap4") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap4") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap5") Then
                                        If clsaplica.pndiaatr >= 181 Then
                                            drmora("nmorcap5") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap5") = 0
                                        End If
                                    End If

                                    If clsppal.IncluirCampo(ccampos, "cnomgru") Then
                                        drmora("cnomgru") = drcartera("cnomgru")
                                    End If

                                Else 'Rangos personalizados
                                    If clsppal.IncluirCampo(ccampos, "nsalafe1") Then
                                        If clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2 Then
                                            drmora("nsalafe1") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe1") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe2") Then
                                        If clsaplica.pndiaatr > pnRango2 And clsaplica.pndiaatr <= pnRango3 Then
                                            drmora("nsalafe2") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe2") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe3") Then
                                        If clsaplica.pndiaatr > pnRango3 And clsaplica.pndiaatr <= pnRango4 Then
                                            drmora("nsalafe3") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe3") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe4") Then
                                        If clsaplica.pndiaatr > pnRango4 And clsaplica.pndiaatr <= pnRango5 Then
                                            drmora("nsalafe4") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe4") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nsalafe5") Then
                                        If clsaplica.pndiaatr > pnRango5 Then
                                            drmora("nsalafe5") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                        Else
                                            drmora("nsalafe5") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap1") Then
                                        If clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2 Then
                                            drmora("nmorcap1") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap1") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap2") Then
                                        If clsaplica.pndiaatr > pnRango2 And clsaplica.pndiaatr <= pnRango3 Then
                                            drmora("nmorcap2") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap2") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap3") Then
                                        If clsaplica.pndiaatr > pnRango3 And clsaplica.pndiaatr <= pnRango4 Then
                                            drmora("nmorcap3") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap3") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap4") Then
                                        If clsaplica.pndiaatr > pnRango4 And clsaplica.pndiaatr <= pnRango5 Then
                                            drmora("nmorcap4") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap4") = 0
                                        End If
                                    End If
                                    If clsppal.IncluirCampo(ccampos, "nmorcap5") Then
                                        If clsaplica.pndiaatr > pnRango5 Then
                                            drmora("nmorcap5") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                        Else
                                            drmora("nmorcap5") = 0
                                        End If
                                    End If

                                End If
                                If clsppal.IncluirCampo(ccampos, "ncuota") Then
                                    drmora("ncuota") = drcartera("nmoncuo")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ndiaatr") Then
                                    drmora("ndiaatr") = clsaplica.pndiaatr
                                End If
                                If clsppal.IncluirCampo(ccampos, "dfecven") Then
                                    drmora("dfecven") = drcartera("dfecven")
                                End If
                                If clsppal.IncluirCampo(ccampos, "cnomana") Then
                                    drmora("cnomana") = drcartera("cnomana")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ccodana") Then
                                    drmora("ccodana") = drcartera("ccodana")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ncapmora") Then
                                    drmora("ncapmora") = Math.Round(clsaplica.pndeucap, 2)
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafecta") Then
                                    If Math.Round(clsaplica.pndeucap, 2) > 0 Then
                                        drmora("nsalafecta") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafecta") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "cdirdom") Then
                                    drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ctelefono") Then
                                    drmora("ctelefono") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                                End If
                                If clsppal.IncluirCampo(ccampos, "dultpag") Then
                                    drmora("dultpag") = clsaplica.pdultpag
                                End If
                                '------------------
                                If clsppal.IncluirCampo(ccampos, "cfondo") Then
                                    drmora("cfondo") = etabttab.Describe(drcartera("ffondos"), "033")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ctipgar") Then
                                    drmora("ctipgar") = clsppal.TipodeGarantia(drcartera("ccodcta"))
                                End If
                                If clsppal.IncluirCampo(ccampos, "cdestino") Then
                                    drmora("cdestino") = etabttab.Describe(drcartera("cdescre"), "005")
                                End If
                                If clsppal.IncluirCampo(ccampos, "ntasint") Then
                                    drmora("ntasint") = drcartera("ntasint")
                                End If
                                If clsppal.IncluirCampo(ccampos, "cacteco") Then
                                    drmora("cacteco") = etabtciu.CIIU(drcartera("ccodact"))
                                End If
                                If clsppal.IncluirCampo(ccampos, "cproducto") Then
                                    drmora("cproducto") = etabttab.Describe(drcartera("ccodlin").substring(8, 2), "075")
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalint") Then
                                    drmora("nsalint") = Math.Round(clsaplica.pnsalint, 2)
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalmor") Then
                                    drmora("nsalmor") = Math.Round(clsaplica.pnsalmor, 2)
                                End If
                                If clsppal.IncluirCampo(ccampos, "cprograma") Then
                                    drmora("cprograma") = etabttab.Describe(drcartera("ccodlin").substring(6, 2), "034")
                                End If
                                If clsppal.IncluirCampo(ccampos, "tipoInteres") Then
                                    drmora("tipoInteres") = IIf(Trim(drcartera("cflat")) = "F", "FLAT", "Sobre Saldo")
                                End If

                                If clsppal.IncluirCampo(ccampos, "cnomgru") Then
                                    drmora("cnomgru") = drcartera("cnomgru")
                                End If

                                '------------------
                                lcMORA.Rows.Add(drmora)

                            End If
                        Else
                            'calculo de mora  dias de atraso menores que cero

                            drmora = lcMORA.NewRow() '--------------------------------------------------
                            If clsppal.IncluirCampo(ccampos, "ntasmor") Then
                                drmora("ntasmor") = drcartera("ntasmor") '
                            End If
                            If clsppal.IncluirCampo(ccampos, "coficina") Then
                                drmora("coficina") = "'" & drcartera("cnomofi") '"'" &
                            End If
                            If clsppal.IncluirCampo(ccampos, "ccodcta") Then
                                drmora("ccodcta") = "'" & drcartera("ccodcta") '"'" &
                            End If
                            If clsppal.IncluirCampo(ccampos, "cnomcli") Then
                                drmora("cnomcli") = drcartera("cnomcli")
                            End If
                            If clsppal.IncluirCampo(ccampos, "ccodcli") Then
                                drmora("ccodcli") = "'" & drcartera("ccodcli")
                            End If
                            If clsppal.IncluirCampo(ccampos, "nnumhom") Then
                                If drcartera("csexo") = "M" Then
                                    drmora("nnumhom") = 1
                                Else
                                    drmora("nnumhom") = 0
                                End If
                            End If
                            If clsppal.IncluirCampo(ccampos, "nnummuj") Then
                                If drcartera("csexo") = "F" Then
                                    drmora("nnummuj") = 1
                                Else
                                    drmora("nnummuj") = 0
                                End If
                            End If
                            If clsppal.IncluirCampo(ccampos, "nnumhomp") Then
                                lnciclo = ciclo(drcartera("ccodcli"), drcartera("ccodcta"))
                                If lnciclo = 1 And drcartera("csexo") = "M" Then
                                    drmora("nnumhomp") = 1
                                End If
                            End If
                            If clsppal.IncluirCampo(ccampos, "nnummujp") Then
                                lnciclo = ciclo(drcartera("ccodcli"), drcartera("ccodcta"))
                                If lnciclo = 1 And drcartera("csexo") = "F" Then
                                    drmora("nnummujp") = 1
                                End If
                            End If
                            If clsppal.IncluirCampo(ccampos, "dfecvig") Then
                                drmora("dfecvig") = drcartera("dfecvig")
                            End If
                            If clsppal.IncluirCampo(ccampos, "nmontotot") Then
                                drmora("nmontotot") = drcartera("ncapdes")
                            End If
                            If clsppal.IncluirCampo(ccampos, "nmontohom") Then
                                If drcartera("csexo") = "M" Then
                                    drmora("nmontohom") = drcartera("ncapdes")
                                End If
                            End If
                            If clsppal.IncluirCampo(ccampos, "nmontomuj") Then
                                If drcartera("csexo") = "F" Then
                                    drmora("nmontomuj") = drcartera("ncapdes")
                                End If
                            End If
                            If clsppal.IncluirCampo(ccampos, "nsalcap") Then
                                drmora("nsalcap") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            End If
                            If pltoda = False Then
                                If clsppal.IncluirCampo(ccampos, "nsalafe1") Then
                                    If clsaplica.pndiaatr >= 1 And clsaplica.pndiaatr <= 30 Then
                                        drmora("nsalafe1") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe1") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafe2") Then
                                    If clsaplica.pndiaatr >= 31 And clsaplica.pndiaatr <= 60 Then
                                        drmora("nsalafe2") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe2") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafe3") Then
                                    If clsaplica.pndiaatr >= 61 And clsaplica.pndiaatr <= 90 Then
                                        drmora("nsalafe3") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe3") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafe4") Then
                                    If clsaplica.pndiaatr >= 91 And clsaplica.pndiaatr <= 180 Then
                                        drmora("nsalafe4") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe4") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafe5") Then
                                    If clsaplica.pndiaatr >= 181 Then
                                        drmora("nsalafe5") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe5") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap1") Then
                                    If clsaplica.pndiaatr >= 1 And clsaplica.pndiaatr <= 30 Then
                                        drmora("nmorcap1") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap1") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap2") Then
                                    If clsaplica.pndiaatr >= 31 And clsaplica.pndiaatr <= 60 Then
                                        drmora("nmorcap2") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap2") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap3") Then
                                    If clsaplica.pndiaatr >= 61 And clsaplica.pndiaatr <= 90 Then
                                        drmora("nmorcap3") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap3") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap4") Then
                                    If clsaplica.pndiaatr >= 91 And clsaplica.pndiaatr <= 180 Then
                                        drmora("nmorcap4") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap4") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap5") Then
                                    If clsaplica.pndiaatr >= 181 Then
                                        drmora("nmorcap5") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap5") = 0
                                    End If
                                End If

                                If clsppal.IncluirCampo(ccampos, "cnomgru") Then
                                    drmora("cnomgru") = drcartera("cnomgru")
                                End If

                            Else 'Rangos personalizados
                                If clsppal.IncluirCampo(ccampos, "nsalafe1") Then
                                    If clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2 Then
                                        drmora("nsalafe1") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe1") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafe2") Then
                                    If clsaplica.pndiaatr > pnRango2 And clsaplica.pndiaatr <= pnRango3 Then
                                        drmora("nsalafe2") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe2") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafe3") Then
                                    If clsaplica.pndiaatr > pnRango3 And clsaplica.pndiaatr <= pnRango4 Then
                                        drmora("nsalafe3") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe3") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafe4") Then
                                    If clsaplica.pndiaatr > pnRango4 And clsaplica.pndiaatr <= pnRango5 Then
                                        drmora("nsalafe4") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe4") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nsalafe5") Then
                                    If clsaplica.pndiaatr > pnRango5 Then
                                        drmora("nsalafe5") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    Else
                                        drmora("nsalafe5") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap1") Then
                                    If clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2 Then
                                        drmora("nmorcap1") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap1") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap2") Then
                                    If clsaplica.pndiaatr > pnRango2 And clsaplica.pndiaatr <= pnRango3 Then
                                        drmora("nmorcap2") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap2") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap3") Then
                                    If clsaplica.pndiaatr > pnRango3 And clsaplica.pndiaatr <= pnRango4 Then
                                        drmora("nmorcap3") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap3") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap4") Then
                                    If clsaplica.pndiaatr > pnRango4 And clsaplica.pndiaatr <= pnRango5 Then
                                        drmora("nmorcap4") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap4") = 0
                                    End If
                                End If
                                If clsppal.IncluirCampo(ccampos, "nmorcap5") Then
                                    If clsaplica.pndiaatr > pnRango5 Then
                                        drmora("nmorcap5") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    Else
                                        drmora("nmorcap5") = 0
                                    End If
                                End If

                            End If
                            If clsppal.IncluirCampo(ccampos, "ncuota") Then
                                drmora("ncuota") = drcartera("nmoncuo")
                            End If
                            If clsppal.IncluirCampo(ccampos, "ndiaatr") Then
                                drmora("ndiaatr") = clsaplica.pndiaatr
                            End If
                            If clsppal.IncluirCampo(ccampos, "dfecven") Then
                                drmora("dfecven") = drcartera("dfecven")
                            End If
                            If clsppal.IncluirCampo(ccampos, "cnomana") Then
                                drmora("cnomana") = drcartera("cnomana")
                            End If
                            If clsppal.IncluirCampo(ccampos, "ccodana") Then
                                drmora("ccodana") = drcartera("ccodana")
                            End If
                            If clsppal.IncluirCampo(ccampos, "ncapmora") Then
                                drmora("ncapmora") = Math.Round(clsaplica.pndeucap, 2)
                            End If
                            If clsppal.IncluirCampo(ccampos, "nsalafecta") Then
                                If Math.Round(clsaplica.pndeucap, 2) > 0 Then
                                    drmora("nsalafecta") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                Else
                                    drmora("nsalafecta") = 0
                                End If
                            End If
                            If clsppal.IncluirCampo(ccampos, "cdirdom") Then
                                drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                            End If
                            If clsppal.IncluirCampo(ccampos, "ctelefono") Then
                                drmora("ctelefono") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                            End If
                            If clsppal.IncluirCampo(ccampos, "dultpag") Then
                                drmora("dultpag") = clsaplica.pdultpag
                            End If
                            '------------------
                            If clsppal.IncluirCampo(ccampos, "cfondo") Then
                                drmora("cfondo") = etabttab.Describe(drcartera("ffondos"), "033")
                            End If
                            If clsppal.IncluirCampo(ccampos, "ctipgar") Then
                                drmora("ctipgar") = clsppal.TipodeGarantia(drcartera("ccodcta"))
                            End If
                            If clsppal.IncluirCampo(ccampos, "cdestino") Then
                                drmora("cdestino") = etabttab.Describe(drcartera("cdescre"), "005")
                            End If
                            If clsppal.IncluirCampo(ccampos, "ntasint") Then
                                drmora("ntasint") = drcartera("ntasint")
                            End If
                            If clsppal.IncluirCampo(ccampos, "cacteco") Then
                                drmora("cacteco") = etabtciu.CIIU(drcartera("ccodact"))
                            End If
                            If clsppal.IncluirCampo(ccampos, "cproducto") Then
                                drmora("cproducto") = etabttab.Describe(drcartera("ccodlin").substring(8, 2), "075")
                            End If
                            If clsppal.IncluirCampo(ccampos, "nsalint") Then
                                drmora("nsalint") = Math.Round(clsaplica.pnsalint, 2)
                            End If
                            If clsppal.IncluirCampo(ccampos, "nsalmor") Then
                                drmora("nsalmor") = Math.Round(clsaplica.pnsalmor, 2)
                            End If
                            If clsppal.IncluirCampo(ccampos, "cprograma") Then
                                drmora("cprograma") = etabttab.Describe(drcartera("ccodlin").substring(6, 2), "034")
                            End If
                            If clsppal.IncluirCampo(ccampos, "tipoInteres") Then
                                drmora("tipoInteres") = IIf(Trim(drcartera("cflat")) = "F", "FLAT", "Sobre Saldo")
                            End If


                            If clsppal.IncluirCampo(ccampos, "cnomgru") Then
                                drmora("cnomgru") = drcartera("cnomgru")
                            End If

                            '------------------
                            lcMORA.Rows.Add(drmora)


                        End If

                    End If




                End If

            End If
        Next

        dsmora.Tables.Add(lcMORA)

        Return dsmora

    End Function
    Public Function ObtenerAbonosCreditos(ByVal ccodcli As String, ByVal dfecha As Date) As Decimal
        Return mDb.ObtenerAbonosCreditos(ccodcli, dfecha)
    End Function
    Public Function ResumenTipoCartera(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim dscartera As New DataSet

        Dim clcreditos As New dbCreditos

        clcreditos.dbcartera = Me.cartera
        clcreditos.dbtipo = Me.tipo

        clcreditos.dbmonto = 0
        clcreditos.dbsaldo = 0
        clcreditos.dbafectada = 0
        clcreditos.dbcasos = 0

        dscartera = clcreditos.RTipoCartera(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, Me.cartera)
        Dim elem As Integer

        Dim fila1 As DataRow
        Dim lccodigo As String
        Dim lnmonto As Double
        Dim lnsaldo As Double
        Dim lncreditos As Integer
        Dim lncarafecta As Double
        Dim lncasosafec As Integer
        Dim lnhombres As Integer = 0
        Dim lnmujeres As Integer = 0
        For Each fila1 In dscartera.Tables(0).Rows
            lccodigo = dscartera.Tables(0).Rows(elem)("cCodigo")
            lccodigo = lccodigo.Trim
            lncreditos = clcreditos.TotalCreditos8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "T")
            If lncreditos = 0 Then
                dscartera.Tables(0).Rows(elem).Delete()
                dscartera.Tables(0).GetChanges(DataRowState.Deleted)
            Else
                clcreditos.Carteraxsector(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, "T")
                lnmonto = clcreditos.dbmonto
                lnsaldo = clcreditos.dbsaldo
                lncarafecta = clcreditos.dbafectada
                lncasosafec = clcreditos.dbcasos
                lnhombres = clcreditos.dbhombres
                lnmujeres = clcreditos.dbmujeres
                dscartera.Tables(0).Rows(elem)("nmonto") = lnmonto
                dscartera.Tables(0).Rows(elem)("nsaldo") = lnsaldo
                dscartera.Tables(0).Rows(elem)("ncreditos") = lncreditos
                dscartera.Tables(0).Rows(elem)("ncarafecta") = lncarafecta
                dscartera.Tables(0).Rows(elem)("ncasosafec") = lncasosafec
                dscartera.Tables(0).Rows(elem)("nhombres") = lnhombres
                dscartera.Tables(0).Rows(elem)("nmujeres") = lnmujeres
            End If
            elem += 1
        Next
        dscartera.Tables(0).AcceptChanges()
        Return dscartera
    End Function
    Public Function CarteraIntermediacion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String

        Dim lnsaldo As Double = 0
        Dim lnsalteo30 As Double = 0
        Dim lnsalteo60 As Double = 0

        Dim lnmanejo As Double = 0
        Dim lniva As Double = 0

        Dim lnpagar30 As Double = 0
        Dim lnpagar60 As Double = 0

        Dim ldfec30 As Date
        Dim ldfec60 As Date

        ldfec30 = dfecha2.AddDays(-30)
        ldfec60 = dfecha2.AddDays(-60)

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  120 "
        ElseIf lcestrato = "E" Then
            categoria = " drcartera('ndiaatr')> 120 AND drcartera('ndiaatr') <=  180 "
        ElseIf lcestrato = "F" Then
            categoria = " drcartera('ndiaatr')> 180 AND drcartera('ndiaatr') <=  360 "
        Else
            categoria = " drcartera('ndiaatr')> 360 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador,cteldom, npagar30, npagar60, ccodsol, cnomgru, ccodcen, cnomcen, ccodana, dultpag2,ccodofi, cnomofi, ffondos, cdescri, nsalser, ncapita,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,S,D,D,S,S,S,S,S,F,S,S,S,S,D,D,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        Dim cancela As String
        cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)
        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, "001", lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)
        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim lccartera As String
        Dim lcflag As String = ""
        Dim ecredppg As New cCredppg
        Dim lnsalteo As Double = 0
        Dim lnmora As Double = 0
        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "D" Or drcartera("cestado") = "E" Then
            Else
                lccartera = drcartera("ccodlin")

                lcflag = ecredppg.CuotaseVence(drcartera("cCodcta"), dfecha1, dfecha2)

                If lccartera.ToString.Substring(6, 2) = "05" And Trim(drcartera("cclaper")) = "1" And drcartera("ccodofi") = lcoficina And lcflag <> "" Then


                    'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                    lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                    lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                    clsaplica.pccodcta = drcartera("cCodcta")
                    clsaplica.pdfecval = pdfecha
                    clsaplica.gdfecsis = pdfecha
                    clsaplica.gnperbas = Me.pnperbas
                    clsaplica.gdultpag = #2/1/1970#
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsaplica.porsegdeu = Me.pnsegvm1
                    Else
                        clsaplica.porsegdeu = Me.pnsegvm
                    End If

                    clsaplica.porcomision = Me.pncomtra
                    clsaplica.pcestado = drcartera("cestado")
                    clsaplica.gnpergra = Me.gnpergra
                    ok = clsaplica.omcalcinterest("R", pdfecha)

                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    If ok = 9 Then
                    Else
                        If Me.pnopcion = 1 Then
                            lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                        Else
                            lcdatosfia = ""
                        End If
                        lndiaatr = clsaplica.pndiaatr

                        'If lndiaatr > 0 Then
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        'Para Calcular Cuota
                        Dim lncuota As Double = 0
                        lccalifica = Me.Califica(lndiaatr)
                        lcestrdes = Me.CalificaDes(lndiaatr)
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        clsppal.gnperbas = Me.pnperbas
                        clsppal.pnComtra = Me.pncomtra
                        If drcartera("dfecvig") >= #7/11/2008# Then
                            clsppal.pnSegVm = Me.pnsegvm1
                        Else
                            clsppal.pnSegVm = Me.pnsegvm
                        End If

                        lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                        Dim lctelefono As String
                        If IsDBNull(drcartera("cteldom")) Then
                        Else
                            lctelefono = drcartera("cteldom")
                            drcartera("cteldom") = lctelefono.Trim
                        End If
                        'lncuota = clsaplica.pnmoncuo
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        If lcestrato <> "*" Then
                            'calculo de mora  dias de atraso menores que cero
                            If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr >= 1 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr >= 31 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr >= 61 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr >= 91 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                                If pltoda = True Or (pltoda = False And clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2) Then
                                    drmora = lcMORA.NewRow()
                                    drmora("ccodcta") = drcartera("ccodcta")
                                    drmora("cnomcli") = drcartera("cnomcli")
                                    drmora("ncapdes") = drcartera("ncapdes")
                                    drmora("dfecvig") = drcartera("dfecvig")
                                    drmora("ccodsol") = drcartera("ccodsol")
                                    drmora("cnomgru") = drcartera("cnomgru")
                                    drmora("ncapita") = ecredppg.CuotaTeoricaMontoporRango(drcartera("ccodcta"), dfecha1, dfecha2)
                                    drmora("ccodana") = drcartera("ccodana")

                                    drmora("ccodcen") = drcartera("ccodcen")
                                    drmora("cnomcen") = drcartera("cnomcen")

                                    drmora("dfecven") = drcartera("dfecven")

                                    drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                                    drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                                    drmora("dultpag") = clsaplica.pdultpag
                                    drmora("dultpag2") = clsaplica.pdultpag2
                                    drmora("ncuota") = clsaplica.pnmoncuo
                                    drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                    drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                                    lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)

                                    'calcula a saldos teorico a 30 y 60 dias --------------------------------------
                                    lnsalteo30 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec30)
                                    If lnsalteo30 = 0 Then
                                        drmora("npagar30") = 0
                                    Else
                                        drmora("npagar30") = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))
                                    End If

                                    lnsalteo60 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec60)
                                    If lnsalteo60 = 0 Then
                                        drmora("npagar60") = 0
                                    Else
                                        drmora("npagar60") = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))
                                    End If
                                    '------------------------------------------------------------------------------
                                    lnsalteo = Me.DeudaProyectadaIncluye(drcartera("ccodcta"), dfecha2)
                                    lnmora = Math.Round((clsaplica.pncapdes - clsaplica.pncappag) - lnsalteo, 2)
                                    If lnmora > 0 Then 'existe mora
                                        drmora("ncapita") = lnmora
                                    Else
                                        lnmora = 0
                                        drmora("ncapita") = 0
                                    End If

                                    '-------------------------------------------------------------------------------

                                    drmora("ncuota") = lncuota
                                    drmora("ccalifica") = lccalifica
                                    drmora("ccalificades") = lcestrdes
                                    drmora("cfiador") = lcdatosfia

                                    If IsDBNull(drmora("ncapmora")) Then
                                        drmora("ncapmora") = 0
                                    End If

                                    If drmora("ncapmora") < 0 Then
                                        drmora("ncapmora") = 0
                                    End If

                                    drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                    drmora("nsalser") = Math.Round(clsaplica.pnsalser, 2)
                                    drmora("ndiaatr") = clsaplica.pndiaatr
                                    drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                                    'calculos de los seguros
                                    ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                    entidadcretlin.cnrolin = clsaplica.cnrolin
                                    ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                    pccodlin = entidadcretlin.ccodlin
                                    lsegdeu = entidadcretlin.lsegdeu

                                    lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)

                                    lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                                    lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                                    lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                                    lngasadm = lnmanejo + lniva


                                    drmora("ncomision") = lngasadm
                                    drmora("nsegdeu") = lnsegdeu
                                    drmora("nseguros") = 0

                                    drmora("ccodofi") = drcartera("coficina")
                                    drmora("cnomofi") = drcartera("cnomofi")

                                    drmora("ffondos") = drcartera("ffondos")
                                    drmora("cdescri") = drcartera("cdescri")
                                    'finaliza calculo de los seguros
                                    lcMORA.Rows.Add(drmora)
                                End If
                            End If


                        Else
                            'no filtra dias de atraso
                            If pltoda = True Or (pltoda = False And clsaplica.pndiaatr >= pnRango1 And clsaplica.pndiaatr <= pnRango2) Then
                                lnsalintmor = 0
                                drmora = lcMORA.NewRow()
                                drmora("nsalintmor") = clsaplica.pnsalmor
                                drmora("ccodcta") = drcartera("ccodcta")
                                drmora("ncapita") = ecredppg.CuotaTeoricaMontoporRango(drcartera("ccodcta"), dfecha1, dfecha2)
                                drmora("cnomcli") = drcartera("cnomcli")
                                drmora("ncapdes") = drcartera("ncapdes")
                                drmora("dfecvig") = drcartera("dfecvig")
                                drmora("ccodsol") = drcartera("ccodsol")
                                drmora("cnomgru") = drcartera("cnomgru")
                                drmora("ccodcen") = drcartera("ccodcen")
                                drmora("cnomcen") = drcartera("cnomcen")
                                drmora("dfecven") = drcartera("dfecven")
                                drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                                drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                                drmora("dultpag") = clsaplica.pdultpag
                                drmora("dultpag2") = clsaplica.pdultpag2
                                drmora("ncuota") = lncuota
                                drmora("ccalifica") = lccalifica
                                drmora("ccalificades") = lcestrdes
                                drmora("cfiador") = lcdatosfia
                                drmora("ccodana") = drcartera("ccodana")

                                drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                                drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                                lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)


                                'calcula a saldos teorico a 30 y 60 dias --------------------------------------
                                lnsalteo30 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec30)
                                If lnsalteo30 = 0 Then
                                    drmora("npagar30") = 0
                                Else
                                    drmora("npagar30") = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))
                                End If

                                lnsalteo60 = Me.DeudaProyectada(drcartera("ccodcta"), ldfec60)
                                If lnsalteo60 = 0 Then
                                    drmora("npagar60") = 0
                                Else
                                    drmora("npagar60") = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))
                                End If
                                '-------------------------------------------------------------------------------
                                lnsalteo = Me.DeudaProyectadaIncluye(drcartera("ccodcta"), dfecha2)
                                lnmora = Math.Round((clsaplica.pncapdes - clsaplica.pncappag) - lnsalteo, 2)
                                If lnmora > 0 Then 'existe mora
                                    drmora("ncapita") = lnmora
                                Else
                                    lnmora = 0
                                    drmora("ncapita") = 0
                                End If
                                '--------------------------------------------------------------------------------


                                If IsDBNull(drmora("ncapmora")) Then
                                    drmora("ncapmora") = 0
                                End If

                                If drmora("ncapmora") < 0 Then
                                    drmora("ncapmora") = 0
                                End If
                                drmora("nsalser") = Math.Round(clsaplica.pnsalser, 2)
                                drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                                drmora("ndiaatr") = clsaplica.pndiaatr

                                'calculos de los seguros

                                ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                                entidadcretlin.cnrolin = clsaplica.cnrolin
                                ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                                pccodlin = entidadcretlin.ccodlin
                                lsegdeu = entidadcretlin.lsegdeu

                                lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)

                                lnsegdeu = Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                                lnmanejo = Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, False), 2)
                                lniva = Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                                lngasadm = lnmanejo + lniva


                                drmora("ncomision") = lngasadm
                                drmora("nsegdeu") = lnsegdeu
                                drmora("nseguros") = 0

                                drmora("ccodofi") = drcartera("coficina")
                                drmora("cnomofi") = drcartera("cnomofi")

                                drmora("ffondos") = drcartera("ffondos")
                                drmora("cdescri") = drcartera("cdescri")


                                'finaliza calculo de los seguros


                                lcMORA.Rows.Add(drmora)
                            End If
                        End If
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function
    Public Function DeudaProyectadaIncluye(ByVal pccodcta As String, ByVal pdfecha As Date) As Double
        Return mDb.DeudaProyectadaIncluye(pccodcta, pdfecha)
    End Function
    Public Function DETALLE_CARTERA_Y_PAGOS_en_BANCOS(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet
        Return mDb.DETALLE_CARTERA_Y_PAGOS_en_BANCOS(dfecha1, dfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona)
    End Function
    Public Function ReservaCartera(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String

        Dim lnsaldo As Double = 0
        Dim lnsalteo30 As Double = 0
        Dim lnsalteo60 As Double = 0

        Dim lnpagar30 As Double = 0
        Dim lnpagar60 As Double = 0

        Dim ldfec30 As Date
        Dim ldfec60 As Date

        ldfec30 = dfecha2.AddDays(-30)
        ldfec60 = dfecha2.AddDays(-60)

        If lcestrato = "A" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "E" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  120 "
        ElseIf lcestrato = "F" Then
            categoria = " drcartera('ndiaatr')> 120 AND drcartera('ndiaatr') <=  180 "
        ElseIf lcestrato = "G" Then
            categoria = " drcartera('ndiaatr')> 180 AND drcartera('ndiaatr') <=  360 "
        Else
            categoria = " drcartera('ndiaatr')> 360 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador,cteldom, npagar30, npagar60, ccodsol, cnomgru, ccodcen, cnomcen, npar30num, npar30sal, npar30mor,cflag, ccodana, cnomana, coficina, cnomofi,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,S,D,D,S,S,S,S,D,D,D,S,S,S,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        Dim cancela As String
        cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo


        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)


        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""

        For Each drcartera In dscartera.Tables(0).Rows

            lnseguros = 0
            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "D" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                'lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                'lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra
                clsaplica.pcestado = drcartera("cestado")
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)



                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                Else
                    'If Me.pnopcion = 1 Then
                    '    lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    'Else
                    '    lcdatosfia = ""
                    'End If
                    lndiaatr = clsaplica.pndiaatr

                    '                   If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.CalificaReserva(lndiaatr)
                    lcestrdes = Me.CalificaDesReserva(lndiaatr)
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    'If drcartera("dfecvig") >= #7/11/2008# Then
                    clsppal.pnSegVm = Me.pnsegvm1
                    'Else
                    '    clsppal.pnSegVm = Me.pnsegvm
                    'End If

                    'lncuota = clsppal.ValorCuota(drcartera("cCodcta"))
                    'Dim lctelefono As String
                    'If IsDBNull(drcartera("cteldom")) Then
                    'Else
                    '    lctelefono = drcartera("cteldom")
                    '    drcartera("cteldom") = lctelefono.Trim
                    'End If
                    'lncuota = clsaplica.pnmoncuo
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A") Or (lndiaatr >= 1 And lndiaatr <= 30 And lcestrato = "B") Or (lndiaatr >= 31 And lndiaatr <= 60 And lcestrato = "C") Or (lndiaatr >= 61 And lndiaatr <= 90 And lcestrato = "D") Or (lndiaatr >= 91 And lndiaatr <= 120 And lcestrato = "E") Or (lndiaatr >= 121 And lndiaatr <= 180 And lcestrato = "F") Or (lndiaatr >= 181 And lndiaatr <= 360 And lcestrato = "G") Or (lndiaatr > 360 And lcestrato = "H") Then
                            drmora = lcMORA.NewRow()
                            drmora("ccodcta") = drcartera("ccodcta")
                            'drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            'drmora("dfecvig") = drcartera("dfecvig")
                            'drmora("ccodsol") = drcartera("ccodsol")
                            'drmora("cnomgru") = drcartera("cnomgru")

                            'drmora("ccodcen") = drcartera("ccodcen")
                            'drmora("cnomcen") = drcartera("cnomcen")

                            'drmora("dfecven") = drcartera("dfecven")
                            'drmora("cdirdom") = drcartera("cdirdom") + " " + lcdeszon + " Neg." + lcdirneg + " " + drcartera("cteldom")
                            'drmora("cteldom") = IIf(IsDBNull(drcartera("cteldom")) Or drcartera("cteldom") = "", drcartera("ctelfam"), drcartera("cteldom"))
                            'drmora("dultpag") = clsaplica.pdultpag
                            'drmora("ncuota") = clsaplica.pnmoncuo

                            drmora("nsalcap") = utilNumeros.Redondear(drcartera("nCapdes") - drcartera("ncappag"), 2) 'utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncapmora") = Reservar(lnsaldo, lndiaatr)

                            If lndiaatr > 30 Then
                                drmora("npar30num") = 1
                                drmora("npar30sal") = lnsaldo
                                drmora("npar30mor") = drmora("ncapmora")
                            Else
                                drmora("npar30num") = 0
                                drmora("npar30sal") = 0
                                drmora("npar30mor") = 0
                            End If

                            If lndiaatr <= 0 Then
                                drmora("cflag") = "A"
                            Else
                                drmora("cflag") = "B"
                            End If

                            'drmora("ncuota") = lncuota
                            drmora("ccalifica") = lccalifica
                            drmora("ccalificades") = lcestrdes
                            'drmora("cfiador") = lcdatosfia

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            'drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr

                            drmora("ccodana") = drcartera("ccodana")
                            drmora("cnomana") = drcartera("cnomana")

                            drmora("coficina") = drcartera("coficina")
                            drmora("cnomofi") = drcartera("cnomofi")

                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)
                        Else
                            Dim lflag As Boolean
                            lflag = True

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        'drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("ccodcta") = drcartera("ccodcta")
                        'drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")

                        drmora("ccalifica") = lccalifica
                        drmora("ccalificades") = lcestrdes
                        'drmora("cfiador") = lcdatosfia


                        drmora("nsalcap") = utilNumeros.Redondear(drcartera("nCapdes") - drcartera("ncappag"), 2) 'utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        lnsaldo = Math.Round(drcartera("nCapdes") - drcartera("ncappag"), 2)
                        drmora("ncapmora") = Reservar(lnsaldo, lndiaatr)

                        If lndiaatr > 30 Then
                            drmora("npar30num") = 1
                            drmora("npar30sal") = lnsaldo
                            drmora("npar30mor") = drmora("ncapmora")
                        Else
                            drmora("npar30num") = 0
                            drmora("npar30sal") = 0
                            drmora("npar30mor") = 0
                        End If

                        If lndiaatr <= 0 Then
                            drmora("cflag") = "A"
                        Else
                            drmora("cflag") = "B"
                        End If


                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr



                        'finaliza calculo de los seguros
                        drmora("coficina") = drcartera("coficina")
                        drmora("cnomofi") = drcartera("cnomofi")

                        drmora("ccodana") = drcartera("ccodana")
                        drmora("cnomana") = drcartera("cnomana")

                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If

        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function
    Public Function CalificaReserva(ByVal ndiaatr As Integer) As String
        Dim lccalifica As String = "A"
        If ndiaatr <= 0 Then
            lccalifica = "A"
        ElseIf ndiaatr > 0 And ndiaatr <= 30 Then
            lccalifica = "B"
        ElseIf ndiaatr > 30 And ndiaatr <= 60 Then
            lccalifica = "C"
        ElseIf ndiaatr > 60 And ndiaatr <= 90 Then
            lccalifica = "D"
        ElseIf ndiaatr > 90 And ndiaatr <= 180 Then
            lccalifica = "E"
        ElseIf ndiaatr > 180 Then
            lccalifica = "F"
        End If
        Return lccalifica
    End Function
    Public Function CalificaDesReserva(ByVal ndiaatr As Integer) As String
        Dim lccalifica As String = "Cartera al día o Sana"
        If ndiaatr <= 0 Then
            lccalifica = "Cartera al día o Sana"
        ElseIf ndiaatr > 0 And ndiaatr <= 30 Then
            lccalifica = "Cartera con atraso mayor a 1 día"
        ElseIf ndiaatr > 30 And ndiaatr <= 60 Then
            lccalifica = "Cartera con atraso mayor a 31 días"
        ElseIf ndiaatr > 60 And ndiaatr <= 90 Then
            lccalifica = "Cartera con atraso mayor a 61 días"
        ElseIf ndiaatr > 90 And ndiaatr <= 180 Then
            lccalifica = "Cartera con atraso mayor a 91 días"
        ElseIf ndiaatr > 180 Then
            lccalifica = "Cartera con atraso mayor a 181 días"
        End If
        Return lccalifica
    End Function
    Public Function Reservar(ByVal nsaldo As Double, ByVal ndiaatr As Integer) As Double
        Dim lnreserva As Double = 0
        If ndiaatr <= 0 Then
            lnreserva = 0
        ElseIf ndiaatr > 0 And ndiaatr <= 30 Then
            lnreserva = Math.Round(nsaldo * 1 / 100, 2)
        ElseIf ndiaatr > 30 And ndiaatr <= 60 Then
            lnreserva = Math.Round(nsaldo * 7 / 100, 2)
        ElseIf ndiaatr > 60 And ndiaatr <= 90 Then
            lnreserva = Math.Round(nsaldo * 15 / 100, 2)
        ElseIf ndiaatr > 90 And ndiaatr <= 180 Then
            lnreserva = Math.Round(nsaldo * 50 / 100, 2)
        ElseIf ndiaatr > 180 Then
            lnreserva = Math.Round(nsaldo * 100 / 100, 2)
        End If
        Return lnreserva
    End Function
    Public Function ObtieneComision(ByVal nmonto As Double, ByVal csector As String, ByVal ctipgas As String) As Double
        Return mDb.ObtieneComision(nmonto, csector, ctipgas)
    End Function
    Public Function ClientesdeGrupoenProceso(ByVal cCodsol As String) As DataSet
        Return mDb.ClientesdeGrupoenProceso(cCodsol)
    End Function
    Public Function Carteratotal() As DataSet
        Return mDb.Carteratotal()
    End Function
    Public Function ActualizaTipoGarantia(ByVal ccodcta As String, ByVal ctipgar As String) As Integer
        Return mDb.ActualizaTipoGarantia(ccodcta, ctipgar)
    End Function
    Public Function ListadoCreditosxGrupoenProceso(ByVal cCodsol As String) As DataSet
        Return mDb.ListadoCreditosxGrupoenProceso(cCodsol)
    End Function

    Public Function DETALLE_CARTERA_Y_PAGOS_CAJA(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String, ByVal ctippag As String) As DataSet
        mDb.dbcartera = Me.cartera
        mDb.dbtipo = Me.tipo

        Return mDb.DETALLE_CARTERA_Y_PAGOS_CAJA(ldfecha1, ldfecha2, lcdescob, lcoficina, lcanalista, lcestrato, lclineas, bandera, lccajeros, lczona, ctippag)
    End Function
    '-----MINE
    Public Function GeneradordeReportesMINE(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "No,Region,Agencia,Credito,Cliente,Nombre,Cedula,Direccion,Actividad,Monto,Saldo,Cuota,Capital_Mora,Intereses_Corrientes,Intereses_Moratorios,Cuotas_Mora,Garantia,Tasa_Interes,Fecha_Otorgado,Fecha_Vence,Ciclo,Dias_Atraso,Menosde1,Menosde2,Menosde3,Menosde4,Menosde6,Mayor180,Sexo,Metodologia,Programa,Producto,Sector,Estado,Tipo_Cartera,Destino,Municipio,Fecha_Nac,Departamento,Fondos,Asesor_Otorgo,Asesor_Administra,Pago_Capital,Pago_Interes,Pago_Mora,TipoInteres,ntasmor,ctipgar,"
        ltipos1 = "S,S,S,S,S,S,S,S,S,D,D,D,D,D,D,D,S,D,F,F,I,I,D,D,D,D,D,D,S,S,S,S,S,S,S,S,S,F,S,S,S,S,D,D,D,S,D,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"

        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        'Obtenemos los pagos del mes por credito
        Dim dskardex As New DataSet

        dscartera = clscartera.CarteraCalculadaMINE(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)
        dskardex = clscartera.ObtenerPagosdelPeriodo(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)

        lnsalintmor = 0
        Dim dstrabajo As New DataSet
        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        Dim lniva As Double = 0
        Dim lnciclo As Integer = 0
        Dim ecremcre As New cCremcre
        nn = dscartera.Tables(0).Rows.Count

        Dim etabtciu As New cTabtciu
        Dim etabttab As New cTabttab

        Dim k As Integer = 0
        Dim contador As Integer = 1
        Dim etabtofi As New cTabtofi
        Dim ccodreg As String
        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0

            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra

                clsaplica.pcestado = drcartera("cestado")

                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then 'Cancelados
                    ok = 9
                    lndiaatr = 0
                    lcdatosfia = ""
                    'lndiaatr = clsaplica.pndiaatr
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)


                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                    Dim lncuotakp As Double = 0
                    lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                    'lncuota = clsaplica.pnmoncuo
                    Dim lncuotasmor As Integer = 0
                    'Cuotas Atrasadas
                    If lndiaatr > 0 And lncuotakp > 0 Then
                        lncuotasmor = 0 'Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                    Else
                        lncuotasmor = 0
                    End If


                    drmora = lcMORA.NewRow() '--------------------------------------------------
                    drmora("No") = contador

                    ccodreg = etabtofi.ObtenerRegiondeOficina(drcartera("coficina"))
                    drmora("Region") = etabttab.Describe(ccodreg, "054")
                    drmora("Agencia") = drcartera("cnomofi")
                    drmora("Credito") = "'" & drcartera("ccodcta") '
                    drmora("Cliente") = "'" & drcartera("ccodcli")
                    drmora("Nombre") = drcartera("cnomcli")
                    drmora("Cedula") = drcartera("cnudoci")
                    drmora("Direccion") = drcartera("cdirdom")
                    drmora("Actividad") = etabtciu.CIIU(drcartera("ccodact"))
                    drmora("Monto") = Math.Round(clsaplica.pncapdes, 2)
                    drmora("Saldo") = 0 'Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                    drmora("Cuota") = drcartera("nmoncuo")
                    drmora("Capital_Mora") = 0 'Math.Round(clsaplica.pndeucap, 2)
                    drmora("Intereses_Corrientes") = 0 'Math.Round(clsaplica.pnsalint, 2)
                    drmora("Intereses_Moratorios") = 0 'Math.Round(clsaplica.pnsalmor, 2)
                    drmora("Cuotas_Mora") = 0 'lncuotasmor
                    drmora("Garantia") = "" 'clsppal.TipodeGarantia(drcartera("ccodcta"))
                    drmora("Tasa_Interes") = drcartera("ntasint")
                    drmora("Fecha_otorgado") = drcartera("dfecvig")
                    drmora("Fecha_vence") = drcartera("dfecven")
                    drmora("Ciclo") = drcartera("nciclo")
                    drmora("Dias_Atraso") = 0 'clsaplica.pndiaatr
                    drmora("Menosde1") = 0
                    drmora("Menosde2") = 0
                    drmora("Menosde3") = 0
                    drmora("Menosde4") = 0
                    drmora("Menosde6") = 0
                    drmora("Mayor180") = 0

                    If clsaplica.pndiaatr <= 30 Then
                        drmora("Menosde1") = 0 'Math.Round(clsaplica.pndeucap, 2)
                    ElseIf clsaplica.pndiaatr > 30 And clsaplica.pndiaatr <= 60 Then
                        drmora("Menosde2") = 0 'Math.Round(clsaplica.pndeucap, 2)
                    ElseIf clsaplica.pndiaatr > 60 And clsaplica.pndiaatr <= 90 Then
                        drmora("Menosde3") = 0 'Math.Round(clsaplica.pndeucap, 2)
                    ElseIf clsaplica.pndiaatr > 90 And clsaplica.pndiaatr <= 120 Then
                        drmora("Menosde4") = 0 'Math.Round(clsaplica.pndeucap, 2)
                    ElseIf clsaplica.pndiaatr > 120 And clsaplica.pndiaatr <= 180 Then
                        drmora("Menosde6") = 0 'Math.Round(clsaplica.pndeucap, 2)
                    Else
                        drmora("Mayor180") = 0 'Math.Round(clsaplica.pndeucap, 2)
                    End If
                    drmora("Sexo") = drcartera("csexo")
                    drmora("Metodologia") = etabttab.Describe(drcartera("ccodlin").Substring(4, 2), "125")
                    drmora("Programa") = etabttab.Describe(drcartera("ccodlin").substring(6, 2), "034")
                    drmora("Producto") = etabttab.Describe(drcartera("ccodlin").substring(8, 2), "075")
                    drmora("Sector") = etabttab.Describe(IIf(IsDBNull(drcartera("csececo")), "", drcartera("csececo")), "021")
                    drmora("Estado") = ecremcre.StatusCredito(drcartera("ccondic"))
                    If IsDBNull(drcartera("ccontra")) Then
                        drcartera("ccontra") = "N"
                    End If

                    drmora("Tipo_Cartera") = IIf(drcartera("ccontra") = "N", "Normal", "Reestructurado")
                    drmora("Destino") = etabttab.Describe(drcartera("cdescre"), "005")
                    drmora("Municipio") = etabtzon.Zona(Left(drcartera("cCoddom"), 4)).Trim
                    drmora("Fecha_Nac") = drcartera("dnacimi")
                    drmora("Departamento") = etabtzon.Zona(Left(drcartera("cCoddom"), 2)).Trim
                    drmora("Fondos") = etabttab.Describe(drcartera("ffondos"), "033")
                    drmora("Asesor_Otorgo") = drcartera("cnomoto")
                    drmora("Asesor_Administra") = drcartera("cnomana")

                    drmora("Pago_Capital") = 0
                    drmora("Pago_Interes") = 0
                    drmora("Pago_Mora") = 0

                    dstrabajo = clscartera.Filtrado(dskardex, drcartera("ccodcta"))
                    For Each filak As DataRow In dstrabajo.Tables(0).Rows
                        drmora("Pago_Capital") = filak("ncappag")
                        drmora("Pago_Interes") = filak("nintpag")
                        drmora("Pago_Mora") = filak("nmorpag")
                    Next
                    dstrabajo.Tables.Clear()
                    drmora("tipoInteres") = IIf(Trim(drcartera("cflat")) = "F", "FLAT", "Sobre Saldo")
                    drmora("ntasmor") = drcartera("ntasmor")
                    drmora("ctipgar") = drcartera("ctipgar")
                    contador += 1
                    lcMORA.Rows.Add(drmora)

                    '-----------------------------------------------------------------------------
                Else
                    lcdatosfia = ""
                    lndiaatr = clsaplica.pndiaatr
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                    Dim lncuotakp As Double = 0
                    lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                    'lncuota = clsaplica.pnmoncuo
                    Dim lncuotasmor As Integer = 0
                    'Cuotas Atrasadas
                    If lndiaatr > 0 And lncuotakp > 0 Then
                        lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                    Else
                        lncuotasmor = 0
                    End If


                    drmora = lcMORA.NewRow() '--------------------------------------------------
                    drmora("No") = contador

                    ccodreg = etabtofi.ObtenerRegiondeOficina(drcartera("coficina"))
                    drmora("Region") = etabttab.Describe(ccodreg, "054")
                    drmora("Agencia") = drcartera("cnomofi")
                    drmora("Credito") = "'" & drcartera("ccodcta") '
                    drmora("Cliente") = "'" & drcartera("ccodcli")
                    drmora("Nombre") = drcartera("cnomcli")
                    drmora("Cedula") = drcartera("cnudoci")
                    drmora("Direccion") = drcartera("cdirdom")
                    drmora("Actividad") = etabtciu.CIIU(drcartera("ccodact"))
                    drmora("Monto") = Math.Round(clsaplica.pncapdes, 2)
                    drmora("Saldo") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                    drmora("Cuota") = drcartera("nmoncuo")
                    drmora("Capital_Mora") = Math.Round(clsaplica.pndeucap, 2)
                    drmora("Intereses_Corrientes") = Math.Round(clsaplica.pnsalint, 2)
                    drmora("Intereses_Moratorios") = Math.Round(clsaplica.pnsalmor, 2)
                    drmora("Cuotas_Mora") = lncuotasmor
                    drmora("Garantia") = "" 'clsppal.TipodeGarantia(drcartera("ccodcta"))
                    drmora("Tasa_Interes") = drcartera("ntasint")
                    drmora("Fecha_otorgado") = drcartera("dfecvig")
                    drmora("Fecha_vence") = drcartera("dfecven")
                    drmora("Ciclo") = drcartera("nciclo")
                    drmora("Dias_Atraso") = clsaplica.pndiaatr
                    drmora("Menosde1") = 0
                    drmora("Menosde2") = 0
                    drmora("Menosde3") = 0
                    drmora("Menosde4") = 0
                    drmora("Menosde6") = 0
                    drmora("Mayor180") = 0

                    If clsaplica.pndiaatr <= 30 Then
                        drmora("Menosde1") = Math.Round(clsaplica.pndeucap, 2)
                    ElseIf clsaplica.pndiaatr > 30 And clsaplica.pndiaatr <= 60 Then
                        drmora("Menosde2") = Math.Round(clsaplica.pndeucap, 2)
                    ElseIf clsaplica.pndiaatr > 60 And clsaplica.pndiaatr <= 90 Then
                        drmora("Menosde3") = Math.Round(clsaplica.pndeucap, 2)
                    ElseIf clsaplica.pndiaatr > 90 And clsaplica.pndiaatr <= 120 Then
                        drmora("Menosde4") = Math.Round(clsaplica.pndeucap, 2)
                    ElseIf clsaplica.pndiaatr > 120 And clsaplica.pndiaatr <= 180 Then
                        drmora("Menosde6") = Math.Round(clsaplica.pndeucap, 2)
                    Else
                        drmora("Mayor180") = Math.Round(clsaplica.pndeucap, 2)
                    End If
                    drmora("Sexo") = drcartera("csexo")
                    drmora("Metodologia") = etabttab.Describe(drcartera("ccodlin").Substring(4, 2), "125")
                    drmora("Programa") = etabttab.Describe(drcartera("ccodlin").substring(6, 2), "034")
                    drmora("Producto") = etabttab.Describe(drcartera("ccodlin").substring(8, 2), "075")
                    drmora("Sector") = etabttab.Describe(IIf(IsDBNull(drcartera("csececo")), "", drcartera("csececo")), "021")
                    drmora("Estado") = ecremcre.StatusCredito(drcartera("ccondic"))
                    If IsDBNull(drcartera("ccontra")) Then
                        drcartera("ccontra") = "N"
                    End If

                    drmora("Tipo_Cartera") = IIf(drcartera("ccontra") = "N", "Normal", "Reestructurado")
                    drmora("Destino") = etabttab.Describe(drcartera("cdescre"), "005")
                    drmora("Municipio") = etabtzon.Zona(Left(drcartera("cCoddom"), 4)).Trim
                    drmora("Fecha_Nac") = drcartera("dnacimi")
                    drmora("Departamento") = etabtzon.Zona(Left(drcartera("cCoddom"), 2)).Trim
                    drmora("Fondos") = etabttab.Describe(drcartera("ffondos"), "033")
                    drmora("Asesor_Otorgo") = drcartera("cnomoto")
                    drmora("Asesor_Administra") = drcartera("cnomana")

                    drmora("Pago_Capital") = 0
                    drmora("Pago_Interes") = 0
                    drmora("Pago_Mora") = 0

                    dstrabajo = clscartera.Filtrado(dskardex, drcartera("ccodcta"))
                    For Each filak As DataRow In dstrabajo.Tables(0).Rows
                        drmora("Pago_Capital") = filak("ncappag")
                        drmora("Pago_Interes") = filak("nintpag")
                        drmora("Pago_Mora") = filak("nmorpag")
                    Next
                    dstrabajo.Tables.Clear()
                    drmora("tipoInteres") = IIf(Trim(drcartera("cflat")) = "F", "FLAT", "Sobre Saldo")
                    drmora("ntasmor") = drcartera("ntasmor")
                    drmora("ctipgar") = drcartera("ctipgar")
                    contador += 1
                    lcMORA.Rows.Add(drmora)

                End If

            End If
        Next

        dsmora.Tables.Add(lcMORA)

        Return dsmora

    End Function

    '------------Dentro de ccreditos.vb

    Public Function Extraer_Cartera(ByVal pdfecsis As Date, ByVal pnTipo As Integer, ByVal lcanalista As String, _
                                     ByVal lcoficina As String, ByVal lclineas As String, ByVal lczona As String, _
                                     ByVal lcproducto As String, ByVal lccartera As String, ByVal lctipo As String) As DataSet
        Return mDb.Extraer_Cartera(pdfecsis, pnTipo, lcanalista, lcoficina, lclineas, lczona, _
                                    lcproducto, lccartera, lctipo)
    End Function
    Public Function Obtener_Saldo(ByVal ccodcta As String) As Decimal
        Return mDb.Obtener_Saldo(ccodcta)
    End Function
    Public Function Trasladar_Analista_Lote(ByVal ccodanaact As String, ByVal cmetodo As String, ByVal cprogra As String, ByVal cproducto As String, _
                                        ByVal cfondo As String, ByVal cdepa As String, ByVal cmuni As String, ByVal caldea As String, _
                                        ByVal ccodananue As String, ByVal ctipo As String) As Integer

        Return mDb.Trasladar_Analista_Lote(ccodanaact, cmetodo, cprogra, cproducto, cfondo, cdepa, cmuni, caldea, ccodananue, ctipo)
    End Function
    Public Function DETALLE_CARTERA_Y_PAGOS_AGENCIA(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String, ByVal ctippag As String) As DataSet
        Return mDb.DETALLE_CARTERA_Y_PAGOS_AGENCIA(dfecha1, dfecha2, lcdescob, lcoficina, lcoficina, lcestrato, lclineas, bandera, lccajeros, lczona, ctippag)
    End Function
    Public Function ComisionesIndividual(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String) As DataSet
        Return mDb.ComisionesIndividual(dfecha1, dfecha2, lcoficina, lcanalista)
    End Function
    Public Function CarteraTrasladada(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String, ByVal cancela As String, ByVal lcproducto As String) As DataSet
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcMORA As DataTable
        Dim clsprin As New class1
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsmora As New DataSet
        Dim drcartera As DataRow
        Dim drmora As DataRow
        Dim categoria As String
        Dim lnsalintmor As Double
        Dim lngasadm As Double
        Dim lnseguros As Double
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsaplica As New payment
        Dim ok As Integer
        Dim ecretlin As New cCretlin
        Dim ecredkar As New cCredkar
        Dim ldultfecha As Date
        Dim pccodlin As String
        Dim lsegdeu As Boolean
        Dim lndias As Integer
        Dim entidadcretlin As New cretlin
        Dim lnsegdeu As Double
        Dim clsppal As New class1
        Dim eclimgar As New cClimgar
        Dim etabtzon As New cTabtzon
        Dim eclidfin As New cClidfin
        Dim lcdeszon As String
        Dim lcdirneg As String
        Dim lnmanejo As Double = 0

        If lcestrato = "A1" Then
            categoria = "  drcartera('ndiaatr') <=  0"
        ElseIf lcestrato = "A" Then
            categoria = " drcartera('ndiaatr') > 0 AND drcartera('ndiaatr') <=  30"
        ElseIf lcestrato = "B" Then
            categoria = " drcartera('ndiaatr') > 30 AND drcartera('ndiaatr') <=  60"
        ElseIf lcestrato = "C" Then
            categoria = " drcartera('ndiaatr')> 60 AND drcartera('ndiaatr') <=  90 "
        ElseIf lcestrato = "D" Then
            categoria = " drcartera('ndiaatr')> 90 AND drcartera('ndiaatr') <=  180 "
        Else
            categoria = " drcartera('ndiaatr')> 180 "
        End If

        lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador, ntasint, ctipgar, cteldom, cNudoci, cNudotr, ccodcli, dnacimi, ncuoapr, ncuomor, ccodact, ccodsol, cnomgru, ccodcen, cnomcen, ncuotakp, cdias, cdesdias, dultpag2, ccodana, cnomana, ccodofi, cnomofi,ffondos,"
        ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,D,S,S,S,S,S,F,D,D,S,S,S,S,S,D,S,S,F,S,S,S,S,S,"
        lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")

        'Dim cancela As String
        'cancela = "0"
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        '        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera)

        dscartera = clscartera.CarteraTrasladada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, Me.cartera, lczona, lcproducto)

        lnsalintmor = 0

        Dim lcestrdes As String
        Dim lccalifica As String
        Dim lndiaatr As Integer
        Dim lcdatosfia As String = ""
        Dim nn As Integer
        Dim lniva As Double = 0
        nn = dscartera.Tables(0).Rows.Count

        Dim k As Integer = 0
        For Each drcartera In dscartera.Tables(0).Rows
            lnseguros = 0

            If drcartera("cestado") = "A" Or drcartera("cestado") = "C" Or drcartera("cestado") = "E" Then
            Else
                'Hace calculo actualizado >>>>>>>>>>>>>>>>>>>>>>>>
                lcdeszon = etabtzon.Zona(drcartera("cCoddom")).Trim
                lcdirneg = eclidfin.ObtenerDirNegocio(drcartera("ccodcli")).Trim
                clsaplica.pccodcta = drcartera("cCodcta")
                clsaplica.pdfecval = dfecha2
                clsaplica.gdfecsis = dfecha2
                clsaplica.gnperbas = Me.pnperbas
                clsaplica.gdultpag = #2/1/1970#
                If drcartera("dfecvig") >= #7/11/2008# Then
                    clsaplica.porsegdeu = Me.pnsegvm1
                Else
                    clsaplica.porsegdeu = Me.pnsegvm
                End If

                clsaplica.porcomision = Me.pncomtra

                clsaplica.pcestado = drcartera("cestado")

                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("R", dfecha2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ok = 9 Then
                    ok = 9
                Else
                    If Me.pnopcion = 1 Then
                        lcdatosfia = eclimgar.DatosFiador(drcartera("cCodcta"))
                    Else
                        lcdatosfia = ""
                    End If
                    lndiaatr = clsaplica.pndiaatr
                    '                    If lndiaatr > 0 Then
                    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    'Para Calcular Cuota
                    Dim lncuota As Double = 0
                    lccalifica = Me.Califica(lndiaatr)
                    lcestrdes = Me.CalificaDes(lndiaatr)
                    '---------------------------------
                    clsppal.gnperbas = Me.pnperbas
                    clsppal.pnComtra = Me.pncomtra
                    If drcartera("dfecvig") >= #7/11/2008# Then
                        clsppal.pnSegVm = Me.pnsegvm1
                    Else
                        clsppal.pnSegVm = Me.pnsegvm
                    End If

                    lncuota = clsppal.ValorCuota(drcartera("cCodcta"))

                    Dim lncuotakp As Double = 0
                    lncuotakp = clsppal.ValorCuotaCapital(drcartera("ccodcta"))
                    'lncuota = clsaplica.pnmoncuo
                    Dim lncuotasmor As Integer = 0
                    'Cuotas Atrasadas
                    If lndiaatr > 0 And lncuotakp > 0 Then
                        lncuotasmor = Math.Ceiling(Math.Round(clsaplica.pndeucap, 2) / lncuotakp)
                    Else
                        lncuotasmor = 0
                    End If

                    If lcestrato <> "*" Then
                        'calculo de mora  dias de atraso menores que cero
                        If (lndiaatr <= 0 And lcestrato = "A1") Or (lndiaatr > 0 And lndiaatr <= 30 And lcestrato = "A") Or (lndiaatr > 30 And lndiaatr <= 60 And lcestrato = "B") Or (lndiaatr > 60 And lndiaatr <= 90 And lcestrato = "C") Or (lndiaatr > 90 And lndiaatr <= 180 And lcestrato = "D") Or (lndiaatr > 180 And lcestrato = "E") Then
                            drmora = lcMORA.NewRow()
                            drmora("ccodcta") = drcartera("ccodcta")
                            drmora("cnomcli") = drcartera("cnomcli")
                            drmora("ncapdes") = drcartera("ncapdes")
                            drmora("dfecvig") = drcartera("dfectra")
                            drmora("dfecven") = drcartera("dfecven")
                            drmora("ntasint") = drcartera("ntasint")
                            drmora("ccodsol") = drcartera("ccodsol")
                            drmora("cnomgru") = drcartera("cnomgru")
                            drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                            drmora("cteldom") = drcartera("cteldom")
                            drmora("dultpag") = clsaplica.pdultpag
                            drmora("dultpag2") = clsaplica.pdultpag2
                            drmora("ncuota") = clsaplica.pnmoncuo
                            drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                            drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drmora("ncuota") = lncuota
                            drmora("ncuotakp") = lncuotakp
                            drmora("ncuomor") = lncuotasmor
                            drmora("ccalifica") = lccalifica
                            drmora("ccalificades") = lcestrdes
                            drmora("cfiador") = lcdatosfia
                            drmora("ctipgar") = drcartera("ctipgar")
                            drmora("cnudoci") = drcartera("cnudoci")
                            drmora("cnudotr") = drcartera("cnudotr")
                            drmora("ccodcli") = drcartera("ccodcli")
                            drmora("dnacimi") = drcartera("dnacimi")
                            drmora("ncuoapr") = drcartera("ncuoapr")
                            drmora("ccodact") = drcartera("ccodact")

                            drmora("ccodcen") = (drcartera("cCodcta")).substring(6, 2) 'drcartera("ccodcen")
                            drmora("cnomcen") = IIf((drcartera("cCodcta")).substring(6, 2) = "01", "PRESTAMOS INDIVIDUALES", IIf((drcartera("cCodcta")).substring(6, 2) = "02", "BANCOS COMUNALES", "GRUPOS SOLIDARIOS"))

                            drmora("ccodana") = drcartera("ccodana")
                            drmora("cnomana") = drcartera("cnomana")

                            If IsDBNull(drmora("ncapmora")) Then
                                drmora("ncapmora") = 0
                            End If

                            If drmora("ncapmora") < 0 Then
                                drmora("ncapmora") = 0
                            End If

                            drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                            drmora("ndiaatr") = clsaplica.pndiaatr
                            If clsaplica.pndiaatr > 30 Then
                                drmora("cdias") = "A"
                                drmora("cdesdias") = "Créditos > 30 días"
                            Else
                                drmora("cdias") = "B"
                                drmora("cdesdias") = "Créditos <= 30 días"
                            End If
                            drmora("nsalintmor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                            'calculos de los seguros
                            ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                            entidadcretlin.cnrolin = clsaplica.cnrolin
                            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                            pccodlin = entidadcretlin.ccodlin
                            lsegdeu = entidadcretlin.lsegdeu

                            lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                            'If pccodlin.Substring(8, 2) = "06" Then
                            '    lngasadm = 0
                            'Else
                            '    If clsaplica.pdfecvig > #11/1/2005# Then
                            '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                            '    Else
                            '        lngasadm = 0
                            '    End If
                            'End If
                            'If lsegdeu = True Then
                            '    If clsaplica.pdfecvig >= #7/11/2008# Then
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                            '    Else
                            '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                            '    End If

                            'Else
                            '    lnsegdeu = 0
                            'End If
                            lnsegdeu = 0 'Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                            lnmanejo = 0 'Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, clsaplica.pdfecvig), 2)
                            lniva = 0 'Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                            lngasadm = lnmanejo + lniva


                            drmora("ncomision") = lngasadm
                            drmora("nsegdeu") = lnsegdeu
                            drmora("nseguros") = 0

                            drmora("ccodofi") = drcartera("coficina")
                            drmora("cnomofi") = drcartera("cnomofi")
                            drmora("ffondos") = drcartera("ffondos")
                            'finaliza calculo de los seguros
                            lcMORA.Rows.Add(drmora)

                        End If


                    Else
                        'no filtra dias de atraso
                        lnsalintmor = 0
                        drmora = lcMORA.NewRow()
                        drmora("nsalintmor") = clsaplica.pnsalmor
                        drmora("ccodcta") = drcartera("ccodcta")
                        drmora("cnomcli") = drcartera("cnomcli")
                        drmora("ncapdes") = drcartera("ncapdes")
                        drmora("dfecvig") = drcartera("dfectra")
                        drmora("dfecven") = drcartera("dfecven")
                        drmora("ntasint") = drcartera("ntasint")
                        drmora("ccodsol") = drcartera("ccodsol")
                        drmora("cnomgru") = drcartera("cnomgru")
                        drmora("cdirdom") = RTrim(LTrim(drcartera("cdirdom"))) + " " + RTrim(LTrim(lcdeszon)) + " Neg." + RTrim(LTrim(lcdirneg)) + " " + drcartera("cteldom")
                        drmora("cteldom") = drcartera("cteldom")
                        drmora("dultpag") = clsaplica.pdultpag
                        drmora("dultpag2") = clsaplica.pdultpag2
                        drmora("ncuota") = lncuota
                        drmora("ncuotakp") = lncuotakp
                        drmora("ncuomor") = lncuotasmor
                        drmora("ccalifica") = lccalifica
                        drmora("ccalificades") = lcestrdes
                        drmora("cfiador") = lcdatosfia
                        drmora("ctipgar") = drcartera("ctipgar")
                        drmora("cnudoci") = drcartera("cnudoci")
                        drmora("cnudotr") = drcartera("cnudotr")
                        drmora("ccodcli") = drcartera("ccodcli")
                        drmora("dnacimi") = drcartera("dnacimi")
                        drmora("ncuoapr") = drcartera("ncuoapr")
                        drmora("ccodact") = drcartera("ccodact")

                        drmora("ccodana") = drcartera("ccodana")
                        drmora("cnomana") = drcartera("cnomana")


                        drmora("ncapmora") = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                        drmora("nsalcap") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)

                        drmora("ccodcen") = (drcartera("cCodcta")).substring(6, 2) 'drcartera("ccodcen")
                        drmora("cnomcen") = IIf((drcartera("cCodcta")).substring(6, 2) = "01", "PRESTAMOS INDIVIDUALES", IIf((drcartera("cCodcta")).substring(6, 2) = "02", "BANCOS COMUNALES", "GRUPOS SOLIDARIOS"))

                        If IsDBNull(drmora("ncapmora")) Then
                            drmora("ncapmora") = 0
                        End If

                        If drmora("ncapmora") < 0 Then
                            drmora("ncapmora") = 0
                        End If

                        drmora("nsalint") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                        drmora("ndiaatr") = clsaplica.pndiaatr

                        If clsaplica.pndiaatr > 30 Then
                            drmora("cdias") = "A"
                            drmora("cdesdias") = "Créditos > 30 días"
                        Else
                            drmora("cdias") = "B"
                            drmora("cdesdias") = "Créditos <= 30 días"
                        End If

                        'calculos de los seguros

                        ldultfecha = ecredkar.UltimafechaProceso(drcartera("cCodcta"), dfecha2)

                        entidadcretlin.cnrolin = clsaplica.cnrolin
                        ecretlin.ObtenerCretlinPorllave(entidadcretlin)
                        pccodlin = entidadcretlin.ccodlin
                        lsegdeu = entidadcretlin.lsegdeu

                        lndias = DateDiff(DateInterval.Day, ldultfecha, dfecha2)
                        'If pccodlin.Substring(8, 2) = "06" Then
                        '    lngasadm = 0
                        'Else
                        '    If clsaplica.pdfecvig > #11/1/2005# Then
                        '        lngasadm = utilNumeros.Redondear((clsaplica.pncapdes * (Me.pncomtra / 100) * lndias) / Me.pnperbas, 2)
                        '    Else
                        '        lngasadm = 0
                        '    End If
                        'End If
                        'If lsegdeu = True Then
                        '    If clsaplica.pdfecvig >= #7/11/2008# Then
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm1 / 31) * lndias, 2)
                        '    Else
                        '        lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Me.pnsegvm / 31) * lndias, 2)
                        '    End If

                        'Else
                        '    lnsegdeu = 0
                        'End If
                        lnsegdeu = 0 'Math.Round(clsppal.CalcularSeguroDeuda(drcartera("ccodcta"), dfecha2, utilNumeros.Redondear(clsaplica.pncapdes, 2), clsaplica.pdfecvig), 2)
                        lnmanejo = 0 'Math.Round(clsppal.CalcularManejo(drcartera("ccodcta"), dfecha2, clsaplica.pncapdes, clsaplica.pdfecvig), 2)
                        lniva = 0 'Math.Round(clsppal.CalcularIVAManejo(12, (lnmanejo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))), 2)

                        lngasadm = lnmanejo + lniva


                        drmora("ncomision") = lngasadm
                        drmora("nsegdeu") = lnsegdeu
                        drmora("nseguros") = 0
                        drmora("ccodofi") = drcartera("coficina")
                        drmora("cnomofi") = drcartera("cnomofi")
                        drmora("ffondos") = drcartera("ffondos")

                        'finaliza calculo de los seguros


                        lcMORA.Rows.Add(drmora)
                    End If
                End If
            End If
            'End If
        Next

        dsmora.Tables.Add(lcMORA)
        '>>>>>>>
        'dsmora.Tables(0).DefaultView.Sort = "ndiaatr ASC"
        '<<<<<<<<<<<<<

        Return dsmora

    End Function
    Public Function ListadoCreditosParaContrato(ByVal cCodsol As String, ByVal cestado As String, ByVal ccodcta As String) As DataSet
        Return mDb.ListadoCreditosParaContrato(cCodsol, cestado, ccodcta)
    End Function
    Public Function SelectIncentivos(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Return mDb.SelectIncentivos(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona)
    End Function
    Public Function ObtieneDatos(ByVal ds As DataSet, ByVal condicion As String, ByVal opcion As Integer) As Decimal
        Dim lnvalor As Decimal = 0
        Dim lncappag As Decimal = 0, lncapdes As Decimal = 0
        Dim clsppal As New class1
        Dim dscartera As New DataSet
        Dim sumObject1 As Object
        Dim sumObject2 As Object

        dscartera = clsppal.Filtrar(ds.Tables(0), condicion)

        If opcion = 1 Then
            lnvalor = dscartera.Tables(0).Rows.Count
        ElseIf opcion = 2 Then
            'For Each fila As DataRow In dscartera.Tables(0).Rows
            '    lnvalor = lnvalor + Math.Round(fila("ncapdes") - fila("ncappag"), 2)
            'Next


            sumObject1 = dscartera.Tables(0).Compute("Sum(ncapdes)", "")
            sumObject2 = dscartera.Tables(0).Compute("Sum(ncappag)", "")

            If IsDBNull(sumObject1) Then
                lncapdes = 0
            Else
                lncapdes = Decimal.Parse(sumObject1)
            End If
            If IsDBNull(sumObject2) Then
                lncappag = 0
            Else
                lncappag = Decimal.Parse(sumObject2)
            End If

            lnvalor = lncapdes - lncappag
        ElseIf opcion = 3 Then

            sumObject1 = dscartera.Tables(0).Compute("Sum(ncappag)", "")
            If IsDBNull(sumObject1) Then
                lnvalor = 0
            Else
                lnvalor = Decimal.Parse(sumObject1)
            End If
        ElseIf opcion = 4 Then
            sumObject1 = dscartera.Tables(0).Compute("Sum(nsalcon)", "")
            If IsDBNull(sumObject1) Then
                lnvalor = 0
            Else
                lnvalor = Decimal.Parse(sumObject1)
            End If
        End If

        Return lnvalor
    End Function

    Public Function CarteraCalculadaSaldosCapital(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim dscartera As New DataSet
        Dim clscartera As New dbCreditos
        clscartera.dbcartera = Me.cartera
        clscartera.dbtipo = Me.tipo

        dscartera = clscartera.CarteraCalculada(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lcproducto)
        Dim lncappag As Decimal = 0, lnpagteo As Decimal = 0, lnsaldo As Decimal = 0, lnsalteo As Decimal = 0
        Dim lncapmora As Decimal = 0, lnsalcon As Decimal = 0, lncapdes As Decimal = 0
        For Each fila As DataRow In dscartera.Tables(0).Rows
            'If fila("ccodcta") = "001001011000000014" Then
            '    fila("ccodcta") = "001001011000000014"
            'End If
            lncapdes = fila("ncapdes")
            lncappag = fila("nCappag")
            lnpagteo = fila("npagteo")
            fila("ncapmora") = 0
            fila("nsalcon") = 0
            lnsaldo = Math.Round(lncapdes - lncappag, 2)
            lnsalteo = Math.Round(IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo)), 2)
            If lnsaldo > lnsalteo Then 'saldo afectado y capital en mora
                fila("ncapmora") = Math.Round(lnsaldo - lnsalteo, 2)
                fila("nsalcon") = lnsaldo
            End If
        Next

        Return dscartera
    End Function
    Public Function SelectIncentivosRecuperacion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Return mDb.SelectIncentivosRecuperacion(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona)
    End Function
    Public Function ObtenerCicloCancelado(ByVal ccodcli As String) As Integer
        Return mDb.ObtenerCicloCancelado(ccodcli)
    End Function

    Public Function ObtenerGastos(ByVal ccodcta As String, ByVal cnrodoc As String) As DataSet
        Return mDb.ObtenerGastos(ccodcta, cnrodoc)
    End Function

    Public Function ObtenerLiquidacion(ByVal ccodcta As String, ByVal cnrodoc As String, ByVal GNIVA As Double) As DataSet
        Return mDb.ObtenerLiquidacion(ccodcta, cnrodoc, GNIVA)
    End Function

    Public Function ObtenerLiquidacion_Deudor(ByVal ccodcta As String, ByVal cnrodoc As String) As DataSet
        Return mDb.ObtenerLiquidacion_Deudor(ccodcta, cnrodoc)
    End Function

    Public Function Obtenerbusquedacreditos(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, ByVal cCodofi As String) As DataSet
        Return mDb.Obtenerbusquedacreditos(cnombre, cestado, ctipo, cbusq, cmetodologia, cflag, cCodofi)
    End Function

    Public Function Extrae_Datos_Grupo(ByVal ccodigo As String) As DataSet
        Return mDb.Extrae_Datos_Grupo(ccodigo)
    End Function

    Public Function Extrae_Datos_Grupo_Vigente(ByVal ccodigo As String) As DataSet
        Return mDb.Extrae_Datos_Grupo_Vigente(ccodigo)
    End Function

    Public Function Extrae_Datos_Grupo_Sugerido_Aprobado(ByVal ccodigo As String) As DataSet
        Return mDb.Extrae_Datos_Grupo_Sugerido_Aprobado(ccodigo)
    End Function

    Public Function CalculaCartera(ByVal dfecha As Date, ByVal ndesde As Integer, ByVal nhasta As Integer, ByVal ccodana As String) As DataSet
        Dim ds As New DataSet
        Dim clscartera As New dbCreditos
        Dim claseaditivos As New cClsAditivos
        ds = clscartera.Creditosrangodias(ndesde, nhasta, ccodana)

        Dim clsaplica As New payment
        Dim fila As DataRow
        Dim ok As Integer = 0

        For Each fila In ds.Tables(0).Rows
            clsaplica.pccodcta = fila("cCodcta")
            clsaplica.pdfecval = dfecha
            clsaplica.gdfecsis = dfecha
            clsaplica.gnperbas = Me.pnperbas
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.porsegdeu = 0
            clsaplica.porcomision = 0
            clsaplica.pcestado = fila("cestado")
            clsaplica.gnpergra = Me.gnpergra
            clsaplica.gnperbas = Me.pnperbas

            claseaditivos.pccodcta = fila("cCodcta")
            claseaditivos.pdfecval = dfecha

            claseaditivos.pdfeclim = dfecha 'Me.pdfeclim
            claseaditivos.pnsegmax = 0 'Me.pnsegmax
            claseaditivos.pdfecseg1 = dfecha ' Me.pdfecseg1
            claseaditivos.pdfecseg2 = dfecha 'Me.pdfecseg2
            claseaditivos.pdfecsis = dfecha
            claseaditivos.pnmancta = 0 'Me.pnmancta
            claseaditivos.pdfecefec6 = dfecha 'Me.pdfecefec6
            claseaditivos.pnmancta6 = 0 'Me.pnmancta6
            claseaditivos.pnmancta5 = 0 'Me.pnmancta5
            claseaditivos.pcCostas = "" 'Me.pcCostas
            claseaditivos.pcAnotacion = "" 'Me.pcAnotacion
            claseaditivos.pcDeudores = "" 'Me.pcDeudores
            claseaditivos.pcPorCob = "" 'Me.pcPorCob
            claseaditivos.pnsegvid = 0 'Me.pnsegvid


            ok = clsaplica.omcalcinterest("T", dfecha)

            If ok = 9 Then
            Else
                fila("ndiaatr") = clsaplica.pndiaatr

                If clsaplica.pndiaatr >= ndesde And clsaplica.pndiaatr <= nhasta Then
                    fila("nsalint") = Math.Round(clsaplica.pnsalint, 2)
                    fila("nsalmor") = Math.Round(clsaplica.pnsalmor, 2)
                    fila("nmorcap") = Math.Round(clsaplica.pndeucap, 2)
                    claseaditivos.pnsalcap = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                    fila("nsalcap") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)

                    fila("nsegdeu") = claseaditivos.SeguroDeuda()
                    fila("nmanejo") = claseaditivos.ManejoCuenta()
                    fila("naporta") = claseaditivos.Aportaciones()
                    fila("ncostas") = claseaditivos.CostasProcesales()
                    fila("nanotacion") = claseaditivos.AnotacionPreventiva()
                    fila("ndeudores") = claseaditivos.Deudores()
                    fila("ndepurada") = claseaditivos.Depurada()
                    fila("nsegvid") = claseaditivos.SeguroProtege()
                Else
                    fila.Delete()
                    ds.Tables(0).GetChanges(DataRowState.Deleted)

                End If
            End If
        Next

        ds.Tables(0).AcceptChanges()

        Return ds

    End Function


    Public Function CalculaCartera_Individual(ByVal dfecha As Date, ByVal ndesde As Integer, _
                                           ByVal nhasta As Integer, ByVal ccodcta As String) As DataSet


        Dim ds As New DataSet
        Dim clscartera As New dbCreditos
        Dim claseaditivos As New cClsAditivos

        ds = clscartera.Creditosrangodias_Individual(ndesde, nhasta, ccodcta)

        Dim clsaplica As New payment
        Dim fila As DataRow
        Dim ok As Integer = 0

        For Each fila In ds.Tables(0).Rows
            clsaplica.pccodcta = fila("cCodcta")
            clsaplica.pdfecval = dfecha
            clsaplica.gdfecsis = dfecha
            clsaplica.gnperbas = Me.pnperbas
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.porsegdeu = 0
            clsaplica.porcomision = 0
            clsaplica.pcestado = fila("cestado")
            clsaplica.gnpergra = Me.gnpergra
            clsaplica.gnperbas = Me.pnperbas

            claseaditivos.pccodcta = fila("cCodcta")
            claseaditivos.pdfecval = dfecha

            claseaditivos.pdfeclim = dfecha 'Me.pdfeclim
            claseaditivos.pnsegmax = 0 'Me.pnsegmax
            claseaditivos.pdfecseg1 = dfecha 'Me.pdfecseg1
            claseaditivos.pdfecseg2 = dfecha 'Me.pdfecseg2
            claseaditivos.pdfecsis = dfecha
            claseaditivos.pnmancta = 0 'Me.pnmancta
            claseaditivos.pdfecefec6 = dfecha 'Me.pdfecefec6
            claseaditivos.pnmancta6 = 0 'Me.pnmancta6
            claseaditivos.pnmancta5 = 0 'Me.pnmancta5
            claseaditivos.pcCostas = "" 'Me.pcCostas
            claseaditivos.pcAnotacion = "" 'Me.pcAnotacion
            claseaditivos.pcDeudores = "" 'Me.pcDeudores
            claseaditivos.pcPorCob = "" 'Me.pcPorCob
            claseaditivos.pnsegvid = 0 'Me.pnsegvid



            ok = clsaplica.omcalcinterest("T", dfecha)

            If ok = 9 Then
            Else

                fila("ndiaatr") = clsaplica.pndiaatr

                If clsaplica.pndiaatr >= ndesde And clsaplica.pndiaatr <= nhasta Then
                    fila("nsalint") = Math.Round(clsaplica.pnsalint, 2)
                    fila("nsalmor") = Math.Round(clsaplica.pnsalmor, 2)
                    fila("nmorcap") = Math.Round(clsaplica.pndeucap, 2)
                    claseaditivos.pnsalcap = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                    fila("nsalcap") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)

                    fila("nsegdeu") = claseaditivos.SeguroDeuda()
                    fila("nmanejo") = claseaditivos.ManejoCuenta()
                    fila("naporta") = claseaditivos.Aportaciones()
                    fila("ncostas") = claseaditivos.CostasProcesales()
                    fila("nanotacion") = claseaditivos.AnotacionPreventiva()
                    fila("ndeudores") = claseaditivos.Deudores()
                    fila("ndepurada") = claseaditivos.Depurada()
                    fila("nsegvid") = claseaditivos.SeguroProtege()
                Else
                    fila.Delete()
                    ds.Tables(0).GetChanges(DataRowState.Deleted)

                End If



            End If

        Next

        ds.Tables(0).AcceptChanges()

        Return ds

    End Function

    Public Function ListaCarteraxAnalista(ByVal cCodana As String) As DataSet

        Return mDb.ListaCarteraxAnalista(cCodana)
    End Function

    Public Function Verifica_Solicitudes_Pendientes(ByVal cCodsol As String) As Boolean
        Return mDb.Verifica_Solicitudes_Pendientes(cCodsol)
    End Function

    Public Function CadenaDatos(ByVal dfecha As Date) As String
        Return mDb.CadenaDatos(dfecha)
    End Function

    Public Function Buscar_Oficinas(ByVal lcoficina As String) As DataSet

        Return mDb.Buscar_Oficinas(lcoficina)
    End Function
    Public Function Consulta_analistaSuc(ByVal dsbaseSucu As DataSet, ByVal dataset_productos As DataSet, ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime, ByVal lcanalista As String) As DataSet
        Return mDb.Consulta_analistaSuc(dsbaseSucu, dataset_productos, ldfecha1, ldfecha2, lcanalista)
    End Function


    Public Function Productos_Search()
        Return mDb.Productos_Search
    End Function


    Public Function Buscar_clientes(ByVal lfecha1 As DateTime, ByVal lfecha2 As DateTime) As DataSet
        Return mDb.Buscar_clientes(lfecha1, lfecha2)
        ', ByVal lfecha2 As DateTime
    End Function

    'Public Function Rpt_DL(ByVal ldfecha2 As DateTime) As DataSet

    '    Return mDb.Rpt_DL(ldfecha2)
    'End Function
    Public Function cargarAnexoC() As DataTable
        Return mDb.cargarAnexoC()
    End Function

    Public Function Rpt_Desembolsos(ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataTable
        Return mDb.Rpt_Desembolso(ldfecha1, ldfecha2)
    End Function

    Public Function Rpt_Dolares_Desembolso_inusuales(ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataTable
        Return mDb.Rpt_Dolares_Desembolso_inusuales(ldfecha1, ldfecha2)
    End Function

    Public Function Rpt_Pago_Cuotas_inusuales(ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataTable
        Return mDb.Rpt_Pago_Cuotas_inusuales(ldfecha1, ldfecha2)
    End Function

    Public Function RdbOperaciones_Insuales(ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataTable
        Return mDb.RdbOperaciones_Insuales(ldfecha1, ldfecha2)
    End Function
    Public Function Rpt_CuentaMaestra(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date) As DataSet
        Return mDb.Rpt_CuentaMaestra(ldfecha1, ldfecha2)

    End Function
    Public Function Rpt_GestoresMora(ByVal ldfecha2 As Date, ByVal oficina As String, ByVal asesor As String) As DataSet
        Return mDb.Rpt_GestoresMora(ldfecha2, oficina, asesor)
    End Function
    Public Function ExecReporteAsigAnalistas(ByVal ldfecha2 As Date, ByVal oficina As String, ByVal asesor As String) As DataSet
        Return mDb.ExecReporteAsigAnalistas(ldfecha2, oficina, asesor)
    End Function
    Public Function consultaCodigoAnalistasGestores(ByVal lcoficina As String) As DataSet
        Return mDb.consultaCodigoAnalistasGestores(lcoficina)
    End Function
    Public Function consultaGarantiasPrendarias() As DataSet
        Return mDb.consultaGarantiasPrendarias()
    End Function
    Public Function ConsultaDetalleGarantias(ByVal fecha1 As Date, ByVal fecha2 As Date) As DataSet
        Return mDb.ConsultaDetalleGarantias(fecha1, fecha2)
    End Function
    Public Function Credito_Vigente_por_Cliente(ByVal cCodcli As String) As DataSet
        Return mDb.Credito_Vigente_por_Cliente(cCodcli)
    End Function

    Public Function Valida_Archivo_Txt(ByVal cnomarch As String) As Integer
        Return mDb.Valida_Archivo_Txt(cnomarch)
    End Function

    Public Function Actualiza_Datos_Archivo_Txt(ByVal cnomarch As String, ByVal fecha_archivo As Date, _
                                                ByVal ccodusu As String) As Integer
        Return mDb.Actualiza_Datos_Archivo_Txt(cnomarch, fecha_archivo, ccodusu)
    End Function

    Public Function Extraer_Cartera_SP(ByVal pdfecsis As Date, ByVal pnTipo As Integer, ByVal lcanalista As String, _
                                       ByVal lcoficina As String, ByVal lclineas As String, ByVal lczona As String, _
                                       ByVal lcproducto As String, ByVal lccartera As String, ByVal lctipo As String, _
                                       ByVal lnmora As Integer) As DataSet
        Return mDb.Extraer_Cartera_SP(pdfecsis, pnTipo, lcanalista, lcoficina, lclineas, lczona, _
                                    lcproducto, lccartera, lctipo, lnmora)
    End Function

    Public Function Extraer_Cartera_SP_MoraGpo(ByVal pdfecsis As Date, ByVal pnTipo As Integer, ByVal lcanalista As String, _
                                       ByVal lcoficina As String, ByVal lclineas As String, ByVal lczona As String, _
                                       ByVal lcproducto As String, ByVal lccartera As String, ByVal lctipo As String, _
                                       ByVal lnmora As Integer) As DataSet
        Return mDb.Extraer_Cartera_SP_MoraGpo(pdfecsis, pnTipo, lcanalista, lcoficina, lclineas, lczona, _
                                    lcproducto, lccartera, lctipo, lnmora)
    End Function


End Class

