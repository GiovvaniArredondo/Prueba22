
Public Class ClsAdRpt

#Region "Variables"
    Private dat_Detalle As New DataSet
    Private dat_DesFin As New DataSet
    Private lccodcta As String
    Private lcnomcli As String
    Private lntasint As Double
    Private lncapdes As Double
    Private ldfevig As DateTime
    Private ldfeven As DateTime
    Private lnComOtr As Double = 0
    Private lnComEscr As Double = 0
    Private lnSeguro As Double = 0
    Private lnOtros As Double = 0
    Private lnliquido As Double
    Private lcConcep As String
    Private lcNuming As String
    Private lnMonto As Double = 0
    Private lnRetorno As Integer = 0
    Private lnKapita As Double
    Private lnIntere As Double
    Private lnIntMor As Double
    Private lnGestion As Double
    Private lnHono As Double
    Private lnTota As Double



#End Region

#Region "Propiedades"

#End Region

    '-------------------------------------------------------'
    '               Ingresos Diarios
    '-------------------------------------------------------'
    Public Function Ingresos(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet

        Try

            'modificado por mlvg
            Dim entidadCtbdchq As New SIM.EL.ctbdchq
            Dim eCtbdChq As New SIM.BL.cCtbdchq
            Dim cls11 As New class1

            Dim lncapita As Double
            Dim lnintere As Double
            Dim lnmora As Double
            Dim lnotros As Double
            Dim ldfecha As Date
            Dim lcnuming As String
            Dim lccodcta As String
            Dim dspagos As New DataSet
            Dim clspag As New clspagos
            lncapita = 0
            lnintere = 0
            lnmora = 0
            lnotros = 0

            'obtiene filtro en bruto
            dat_Detalle = eCtbdChq.ObtenerDataSetEsp4(date1, date2)
            dspagos = clspag.conviertepagos(date1, date2, "C")

            Dim drdetalle As DataRow
            Dim drpagos As DataRow

            Dim lccodcli As String = 0
            Dim ldfecvig As Date
            Dim lnmeses As Double = 0
            Dim lnsalint, lnsalmor, lnmorak As Double
            lnsalint = 0
            lnsalmor = 0
            lnmorak = 0

            Dim lccodana, lccoddom, lczona, lccodlin, lccodact, lcnomact As String
            Dim lcsexo, lccondic, sexo, lcdesfon, lccartera, lcanalista As String
            Dim lncontador As Integer

            lncontador = 0


            If dspagos.Tables(0).Rows.Count > 0 Then
                For Each drpagos In dspagos.Tables(0).Rows
                    lccodcta = drpagos("ccodcta")
                    If dat_Detalle.Tables(0).Rows.Count > 0 Then
                        For Each drdetalle In dat_Detalle.Tables(0).Rows
                            If drdetalle("ccodcta") = lccodcta Then 'reemplaza datos
                                lccodcli = drdetalle("ccodcli")
                                ldfecvig = drdetalle("dfecvig")
                                lntasint = drdetalle("ntasint")
                                lnsalint = drdetalle("nsalint")
                                lnsalmor = drdetalle("nsalmor")
                                lnmorak = drdetalle("nmorak")
                                lccodana = drdetalle("ccodana")
                                lccoddom = drdetalle("ccoddom")
                                lczona = drdetalle("zona")
                                lccodlin = drdetalle("ccodlin")
                                lccodact = drdetalle("ccodact")
                                lcnomact = drdetalle("cnomact")
                                lcsexo = drdetalle("csexo")
                                lccondic = drdetalle("ccondic")
                                lcdesfon = drdetalle("cdesfon")
                                lccartera = drdetalle("cartera")
                                sexo = drdetalle("sexo")
                                lcanalista = drdetalle("analista")

                            End If
                        Next
                        dspagos.Tables(0).Rows(lncontador)("ccodcli") = lccodcli
                        dspagos.Tables(0).Rows(lncontador)("dfecvig") = ldfecvig
                        dspagos.Tables(0).Rows(lncontador)("ntasint") = lntasint
                        dspagos.Tables(0).Rows(lncontador)("nmeses") = lnmeses
                        dspagos.Tables(0).Rows(lncontador)("nsalint") = lnsalint
                        dspagos.Tables(0).Rows(lncontador)("nsalmor") = lnsalmor
                        dspagos.Tables(0).Rows(lncontador)("nmorak") = lnmorak
                        dspagos.Tables(0).Rows(lncontador)("ccodana") = lccodana
                        dspagos.Tables(0).Rows(lncontador)("ccoddom") = lccoddom
                        dspagos.Tables(0).Rows(lncontador)("zona") = lczona
                        dspagos.Tables(0).Rows(lncontador)("ccodlin") = lccodlin
                        dspagos.Tables(0).Rows(lncontador)("ccodact") = lccodact
                        dspagos.Tables(0).Rows(lncontador)("cnomact") = lcnomact
                        dspagos.Tables(0).Rows(lncontador)("csexo") = lcsexo
                        dspagos.Tables(0).Rows(lncontador)("ccondic") = lccondic
                        dspagos.Tables(0).Rows(lncontador)("cdesfon") = lcdesfon
                        dspagos.Tables(0).Rows(lncontador)("cartera") = lccartera
                        dspagos.Tables(0).Rows(lncontador)("sexo") = sexo
                        dspagos.Tables(0).Rows(lncontador)("analista") = lcanalista
                        dspagos.Tables(0).Rows(lncontador)("dfecvig") = dspagos.Tables(0).Rows(lncontador)("dfecsis")

                    End If
                    lccodcli = ""
                    ldfecvig = Date.Now
                    lntasint = 0.0
                    lnmeses = 0
                    lnsalint = 0.0
                    lnsalmor = 0.0
                    lnmorak = 0.0
                    lccodana = ""
                    lccoddom = ""
                    lczona = ""
                    lccodlin = ""
                    lccodact = ""
                    lcnomact = ""
                    lcsexo = ""
                    lccondic = ""
                    lcdesfon = ""
                    lccartera = ""
                    sexo = ""
                    lcanalista = ""
                    lncontador = lncontador + 1

                Next
            End If

            Return dspagos





            'antes Rafa


            '            If dat_Detalle.Tables(0).Rows.Count() = 0 Then
            '           Return dat_Detalle
            '          Exit Function
            '         End If


            '            Dim Fila As DataRow
            '            Dim x As Integer = 0

            '            For Each Fila In dat_Detalle.Tables(0).Rows
            '            lcnomcli = dat_Detalle.Tables(0).Rows(x)("cnomcli")
            '            lccodcta = dat_Detalle.Tables(0).Rows(x)("cCodcta")
            '            lcNuming = dat_Detalle.Tables(0).Rows(x)("cnuming")


            'Obtiene la credkar

            '           dat_DesFin = eCtbdChq.ObtenerDataSetEsp5(lccodcta, lcNuming.Trim)


            '            Dim Fila1 As DataRow
            '            Dim i As Integer = 0

            '           For Each Fila1 In dat_DesFin.Tables(0).Rows
            '           lcConcep = dat_DesFin.Tables(0).Rows(i)("cConcep")
            '           lnMonto = dat_DesFin.Tables(0).Rows(i)("nMonto")

            '            Select Case lcConcep ' Evaluate Number.
            '                Case "KP"   'Capita
            '            lnKapita = lnKapita + lnMonto
            '                Case "IN"   'Interes
            '            lnIntere = lnIntere + lnMonto
            '                Case "MO"   'Mora
            '            lnIntMor = lnIntMor + lnMonto
            '                Case "01"   'Comision por tramite
            '            lnComOtr = lnComOtr + lnMonto
            '                Case "02"   'Gestion
            '            lnGestion = lnGestion + lnMonto
            '                Case "03"   'Honorarios
            '            lnHono = lnHono + lnMonto
            '                Case "CJ"   'Total del Pago
            '            lnTota = lnTota + lnMonto
            '                Case Else   'Otros
            '            lnOtros = lnOtros + lnMonto
            '           End Select


            '          i += 1

            '            Next




            'Agrega las comisiones al Dataset pricipal

            '           dat_Detalle.Tables(0).Rows(x)("nKapita") = lnKapita
            '           dat_Detalle.Tables(0).Rows(x)("nIntere") = lnIntere
            '           dat_Detalle.Tables(0).Rows(x)("nIntMor") = lnIntMor
            '           dat_Detalle.Tables(0).Rows(x)("nComtra") = lnComOtr
            '           dat_Detalle.Tables(0).Rows(x)("nGestion") = lnGestion
            '           dat_Detalle.Tables(0).Rows(x)("nHono") = lnHono
            '           dat_Detalle.Tables(0).Rows(x)("nOtros") = lnOtros
            '           dat_Detalle.Tables(0).Rows(x)("nTotal") = lnTota

            '          x += 1
            '          Next


            '            Return dat_Detalle

        Catch ex As Exception

        End Try

    End Function


    'cartera total incluyendo ingresos y depositos
    Public Function cartera_Ingresos_depositos(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet

        Try

            'modificado por mlvg
            Dim entidadCtbdchq As New SIM.EL.ctbdchq
            Dim eCtbdChq As New SIM.BL.cCtbdchq
            Dim cls11 As New class1

            Dim lncapita As Double
            Dim lnintere As Double
            Dim lnmora As Double
            Dim lnotros As Double
            Dim lnpago As Double
            Dim dspagos As New DataSet
            Dim clspag As New clspagos
            lncapita = 0
            lnintere = 0
            lnmora = 0
            lnotros = 0
            lnpago = 0

            'obtiene filtro en bruto
            dat_Detalle = eCtbdChq.ObtenerDataSetEsp4(date1, date2)
            dspagos = clspag.conviertepagos(date1, date2, "C")

            Dim drdetalle As DataRow
            Dim drpagos As DataRow

            Dim lncontador As Integer

            lncontador = 0

            If dat_Detalle.Tables(0).Rows.Count > 0 Then
                For Each drdetalle In dat_Detalle.Tables(0).Rows
                    lccodcta = drdetalle("ccodcta")
                    If dspagos.Tables(0).Rows.Count > 0 Then
                        For Each drpagos In dspagos.Tables(0).Rows
                            If drpagos("ccodcta") = lccodcta Then 'reemplaza datos
                                lncapita = lncapita + drpagos("ncapita")
                                lnintere = lnintere + drpagos("nintere")
                                lnotros = lnotros + drpagos("notros")
                                lnpago = lnpago + drpagos("npago")
                            End If
                        Next
                        dat_Detalle.Tables(0).Rows(lncontador)("ncapita") = lncapita
                        dat_Detalle.Tables(0).Rows(lncontador)("nintere") = lnintere
                        dat_Detalle.Tables(0).Rows(lncontador)("notros") = lnotros
                        dat_Detalle.Tables(0).Rows(lncontador)("npago") = lnpago
                    End If
                    lncontador = lncontador + 1
                Next
            End If

            Return dat_Detalle


        Catch ex As Exception

        End Try


    End Function


    'cartera proyeccion de mora, no es necesario calculo de mora, evalua automaticamente cada fecha
    'obtiene todos los pagos y evalua la fecha
    Public Function Proyeccion_mora(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet

        Try

            'modificado por mlvg
            Dim entidadCtbdchq As New SIM.EL.ctbdchq
            Dim eCtbdChq As New SIM.BL.cCtbdchq
            Dim cls11 As New class1

            Dim lncapita As Double
            Dim lnintere As Double
            Dim lnmora As Double
            Dim lnotros As Double
            Dim lnpago As Double
            Dim dspagos As New DataSet
            Dim clspag As New clspagos
            Dim ldfecha As Date
            Dim lndias As Double
            Dim gnperbas As Double
            Dim lnintere1 As Double
            Dim ok As Integer

            gnperbas = 365
            lndias = 0
            lnintere1 = 0
            lncapita = 0
            lnintere = 0
            lnmora = 0
            lnotros = 0
            lnpago = 0

            'la fecha de los pagos debe ser AL, pero para que los tome todos a una fecha X,
            'pondremos una fecha desde bien atras
            ldfecha = #1/1/1900#

            dat_Detalle = eCtbdChq.ObtenerDataSetEsp4(ldfecha, date2) 'tomaremos los pagos AL date2
            dspagos = clspag.conviertepagos(date1, date2, "C")

            Dim drdetalle As DataRow
            Dim drpagos As DataRow

            Dim lncontador As Integer
            Dim lnsalcap As Double

            Dim clsaplica As New payment



            lncontador = 0
            lnsalcap = 0


            If dat_Detalle.Tables(0).Rows.Count > 0 Then
                For Each drdetalle In dat_Detalle.Tables(0).Rows
                    lccodcta = drdetalle("ccodcta")
                    If dspagos.Tables(0).Rows.Count > 0 Then
                        For Each drpagos In dspagos.Tables(0).Rows
                            If drpagos("ccodcta") = lccodcta Then 'reemplaza datos
                                lncapita = lncapita + drpagos("ncapita")
                                lnintere = lnintere + drpagos("nintere")
                                lnotros = lnotros + drpagos("notros")
                                lnpago = lnpago + drpagos("npago")
                            End If
                        Next
                        dat_Detalle.Tables(0).Rows(lncontador)("ncapita") = lncapita
                        dat_Detalle.Tables(0).Rows(lncontador)("nintere") = lnintere
                        dat_Detalle.Tables(0).Rows(lncontador)("notros") = lnotros
                        dat_Detalle.Tables(0).Rows(lncontador)("npago") = lnpago
                        'mora capital
                        lnsalcap = dat_Detalle.Tables(0).Rows(lncontador)("ncapdes") - lncapita
                        If dat_Detalle.Tables(0).Rows(lncontador)("ncapdes") - lncapita > 0 Then
                            lncapdes = dat_Detalle.Tables(0).Rows(lncontador)("ncapdes")
                            dat_Detalle.Tables(0).Rows(lncontador)("nmorak") = lncapdes - lncapita
                        Else
                            dat_Detalle.Tables(0).Rows(lncontador)("nmorak") = 0
                        End If
                        'calcula saldos de intereses

                        clsaplica.pccodcta = lccodcta
                        clsaplica.pdfecval = date2
                        clsaplica.gdfecsis = date2
                        clsaplica.gnperbas = 365
                        clsaplica.gdultpag = #2/1/1970#
                        clsaplica.gnpergra = 7
                        ok = clsaplica.omcalcinterest("T", date2)

                        If ok = 1 Then
                            lnintere = clsaplica.pnintcal - (clsaplica.pnintpen + clsaplica.pnintpag)
                            lnmora = clsaplica.pnintmor - (clsaplica.pnmorpag + clsaplica.pnpagcta)
                        End If
                        dat_Detalle.Tables(0).Rows(lncontador)("nsalint") = lnintere1
                        dat_Detalle.Tables(0).Rows(lncontador)("nmora") = lnmora


                    End If
                    lncontador = lncontador + 1
                Next
            End If

            Return dat_Detalle


        Catch ex As Exception

        End Try


    End Function






    '-------------------------------------------------------'
    '               Desembolsos
    '-------------------------------------------------------'
    Public Function Desembolsos(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet

        '   Try

        Dim entidadCtbdchq As New SIM.EL.ctbdchq
        Dim eCtbdChq As New SIM.BL.cCtbdchq


        dat_Detalle = eCtbdChq.ObtenerDataSetEsp1(date1, date2)


        '            If dat_Detalle.Tables(0).Rows.Count() = 0 Then
        '           Return dat_Detalle
        '          Exit Function
        '         End If
        Return dat_Detalle



        '            Dim Fila As DataRow
        '            Dim x As Integer = 0

        '           For Each Fila In dat_Detalle.Tables(0).Rows
        '          lcnomcli = dat_Detalle.Tables(0).Rows(x)("cnomcli")
        '         lccodcta = dat_Detalle.Tables(0).Rows(x)("cCodcta")
        '        lncapdes = dat_Detalle.Tables(0).Rows(x)("ncapdes")
        '       ldfeven = dat_Detalle.Tables(0).Rows(x)("dfecven")
        '      ldfevig = dat_Detalle.Tables(0).Rows(x)("dfecvig")
        '     lntasint = dat_Detalle.Tables(0).Rows(x)("nTasint")
        '    lnliquido = dat_Detalle.Tables(0).Rows(x)("nliquido")

        'Obtiene la credkar

        '            dat_DesFin = eCtbdChq.ObtenerDataSetEsp2(lccodcta)


        '           Dim Fila1 As DataRow
        '          Dim i As Integer = 0

        '         For Each Fila1 In dat_DesFin.Tables(0).Rows
        '        lcConcep = dat_DesFin.Tables(0).Rows(i)("cConcep")
        '       lnMonto = dat_DesFin.Tables(0).Rows(i)("nMonto")

        '      Select Case lcConcep ' Evaluate Number.
        '         Case "01"   'Comision por Otorgamiento
        '    lnComOtr = lnComOtr + lnMonto
        '       Case "04"   'Comision por Escrituracion
        '  lnComEscr = lnComEscr + lnMonto
        '      Case "05"   'Seguro de Deuda
        '  lnSeguro = lnSeguro + lnMonto
        '      Case Else   ' Other values
        '  lnOtros = lnOtros + lnMonto
        '  End Select


        ' i += 1

        'Next


        'Agrega las comisiones al Dataset pricipal

        'dat_Detalle.Tables(0).Rows(x)("nComOtr") = lnComOtr
        'dat_Detalle.Tables(0).Rows(x)("nComEscr") = lnComEscr
        'dat_Detalle.Tables(0).Rows(x)("nSeguro") = lnSeguro
        'dat_Detalle.Tables(0).Rows(x)("nOtros") = lnOtros

        ' x += 1
        ' Next


        '            Return dat_Detalle

        ' Catch ex As Exception

        '  End Try


    End Function

    '-------------------------------------------------------'
    '               Cartera Vigente
    '-------------------------------------------------------'
    Public Function CartVigente(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet

        '  Try

        Dim entidadCtbdchq As New SIM.EL.ctbdchq
        Dim eCtbdChq As New SIM.BL.cCtbdchq


        dat_Detalle = eCtbdChq.ObtenerDataSetcarteracreditos(date1, date2)

        If dat_Detalle.Tables(0).Rows.Count() = 0 Then
            Return dat_Detalle
            Exit Function
        End If


        Return dat_Detalle


    End Function



    Public Function Cartera_mora(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet

        '  Try

        Dim entidadCtbdchq As New SIM.EL.ctbdchq
        Dim eCtbdChq As New SIM.BL.cCtbdchq


        dat_Detalle = eCtbdChq.ObtenerDataSetcarteramora(date1, date2)

        If dat_Detalle.Tables(0).Rows.Count() = 0 Then
            Return dat_Detalle
            Exit Function
        End If


        Return dat_Detalle


    End Function




End Class
