Imports System.Data
Imports System.Data.SqlClient

Public Class crefunc
    Private lcoficina As String
    Public Property pcoficina() As String
        Get
            pcoficina = lcoficina
        End Get
        Set(ByVal Value As String)
            lcoficina = Value
        End Set
    End Property
    Private lccodusu As String
    Public Property pccodusu() As String
        Get
            pccodusu = lccodusu
        End Get
        Set(ByVal Value As String)
            lccodusu = Value
        End Set
    End Property
    Function fxcuentacontable(ByVal pcCodCta As String, ByVal pcCodlin As String, ByVal pcNorRef As String, _
                              ByVal pcConcep As String, ByVal pcDesCob As String, ByVal pcCondic As String, _
                              ByVal pcTipPag As String, ByVal pcbanco As String, ByVal pnmonto As Double, _
                              ByVal pnIntCap As Double, ByVal pnDifInt As Double) As String


        Dim lccodofi As String
        Dim lccodigo As String
        Dim lnparametro1_R As String
        Dim lnparametro2_R As String
        Dim lnparametro3_R As String
        Dim lnparametro4_R As String
        Dim lnparametro5_R As String
        Dim lnparametro6_R As String
        Dim transacc As String
        Dim etabtbco As New cTabtbco
        Dim lccodcta As String
        Dim lccuenta As String
        Dim cls1 As New SIM.BL.class1
        Dim dstmp As DataSet
        Dim busquedaplantilla As Integer
        busquedaplantilla = 0
        lccodcta = ""
        Dim cplanti As String
        '    lccodofi = Mid(pcCodCta, 5, 2)
        'Dim etabtofi As New cTabtofi
        lccodofi = Me.pcoficina 'etabtofi.OficinaCtb(Mid(pcCodCta, 4, 3))

        'If (pcConcep = "IN" Or pcConcep = "MO") And pcCondic = "S" Then
        '    lccodigo = fxBuildCodOpe(pcDesCob, pcConcep, "N", "S", pcTipPag, pcCodlin)
        'Else
        lccodigo = fxBuildCodOpe(pcDesCob, pcConcep, "N", pcCondic, pcTipPag, pcCodlin) 'pcNorRef
        'End If

        'Dim lccodlin As String = pcCodlin
        'pcCodlin = Left(lccodlin, 4) & pcCodCta.Substring(6, 2) & Right(lccodlin, 4)

        If pcConcep = "CJ" And (pcTipPag <> "E" And pcTipPag <> "I" And pcTipPag <> "R") Then 'And pcTipPag <> "D"
            'Cuando es banco buscamos directamente de la tabla de bancos
            'Busca banco
            'lccodigo = lccodigo + pcbanco.Trim
            lccodcta = etabtbco.CuentaContableBanco(pcbanco.Trim)
        Else
            If pcTipPag = "E" And pcConcep = "CJ" Then 'Obtiene cuenta del cajero
                Dim eusuarios As New cusuarios
                lccodcta = eusuarios.CuentaContableCajero(pccodusu)
            Else
                Dim entidadtabtmak As New SIM.EL.tabtmak
                Dim etabtmak As New SIM.BL.cTabtmak

                If lccodigo <> Nothing Then
                    entidadtabtmak.ccodigo = lccodigo
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lccodcta = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lccodcta = fxBuildCtaCtb(cplanti, pcCodlin, lccodofi, pcCondic, pcCodCta)
                    End If
                End If
            End If

        End If
        'pcCodlin = lccodlin

        Return lccodcta
    End Function

    Function fxcuentacontableahorros(ByVal pcdescob As String, ByVal pcconcep As String, ByVal pcNorRef As String, ByVal pccondic As String, ByVal pctippag As String, ByVal pccodofi As String) As String
        Dim lccodofi As String
        Dim lccodigo As String
        Dim lnparametro1_R As String
        Dim lnparametro2_R As String
        Dim lnparametro3_R As String
        Dim lnparametro4_R As String
        Dim lnparametro5_R As String
        Dim lnparametro6_R As String
        Dim transacc As String
        Dim lccodcta As String
        Dim lccuenta As String
        Dim cls1 As New SIM.bl.class1
        Dim dstmp As DataSet
        Dim busquedaplantilla As Integer
        busquedaplantilla = 0
        lccodcta = ""

        lccodofi = Mid(pccodofi, 2, 2)
        lccodigo = fxBuildCodOpe(pcdescob, pcconcep, pcNorRef, pccondic, pctippag, "")

        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak

        If lccodigo <> Nothing Then
            entidadtabtmak.ccodigo = lccodigo
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccodcta = "*"
            Else
                lccodcta = entidadtabtmak.cplanti.Trim
            End If
        End If

        Return lccodcta
    End Function
    Function fxBuildCtaCtb(ByVal p_cCuenta As String, ByVal p_cCodLin As String, _
                           ByVal p_cCodOfi As String, ByVal p_cCondic As String, ByVal pccodcta As String) As String
        Dim lcfondos As String
        Dim lcCuenta As String
        Dim clssdes As New clsDesembolsa
        Dim clsppal As New class1
        Dim lcaux As String = ""
        lcaux = clsppal.ObtenerCodigoGarantia(pccodcta)
        lcfondos = clssdes.ConvertidorFondos(p_cCodLin.Substring(2, 2))
        lcCuenta = p_cCuenta
        lcCuenta = lcCuenta.Replace("TP", p_cCodLin.Substring(4, 2))
        lcCuenta = lcCuenta.Replace("SE", IIf(p_cCodLin.Substring(6, 2) = "02", "1", "2"))
        lcCuenta = lcCuenta.Replace("FF", lcfondos)
        lcCuenta = lcCuenta.Replace("OFI", p_cCodOfi)
        lcCuenta = lcCuenta.Replace("CC", Me.CodigoCondicion(p_cCondic))
        lcCuenta = lcCuenta.Replace("GA", lcaux)

        lcCuenta = lcCuenta.Replace(".", "")
        Return lcCuenta
    End Function

    'obtiene plantilla ejemplo:  CINNN
    Function fxBuildCodOpe(ByVal pcDesCob, ByVal pcConcep, ByVal pcNorRef, ByVal pcCondic, ByVal pctippag, ByVal pccodlin) As String
        Dim lccodctb As String
        If pcConcep = "CJ" Or pcConcep = "OT" Then
            lccodctb = pcDesCob + pcConcep + pctippag
        Else
            'If pcConcep = "IN" Then
            'Else
            pcNorRef = "N"
            'End If

            If pcCondic = "J" Then 'Cuando sea judicial contablemente se ira a Vencido en cobro administrativo
                'pcCondic = "V"
            End If
            If pcConcep <> "KP" Then 'And pcConcep <> "IN" And pcConcep <> "MO" Then 'Para mantener una unica mascara para estos rubros
                If pcCondic <> "S" Then
                    pcCondic = "N"
                End If

            End If

            lccodctb = pcDesCob + pcConcep + pcNorRef + pcCondic
        End If
        Return lccodctb
    End Function

    'reemplaza datos en la cuenta EJ.1106CC01 reemplaza el CC 
    Function fxBuildCtaCtb(ByVal pccuenta, ByVal pccodlin) As String
        Dim lccuenta1 As String
        lccuenta1 = lccuenta1.Replace("CC", Mid(pccodlin, 9, 2))
        lccuenta1 = lccuenta1.Replace("DD", Mid(pccodlin, 5, 2))
        Return lccuenta1
    End Function
    'graba pago en temporal kardex
    Function fxcreaKardex() As DataTable
        Dim lcampos As String
        Dim ltipos As String
        Dim lnomtab As String
        Dim cls As New SIM.bl.class1
        Dim dttmp As DataTable
        lcampos = "ccodcta, dfecval, dfecsis, cnrocuo, nmonto, ccodofi, ctippag, cestado, ctermid, cnrodoc, ccodusu, dfecha, cmoneda, ccondic, ctipgas, cdescob, cbancos, cnuming, cctactb, cclipag, cnomcta, cnumcta, crotativa, ndiaatr, lRecProv,"
        ltipos = "S,F,F,S,D,S,S,S,S,S,S,F,S,S,S,S,S,S,S,S,S,S,S,N,B,"
        lnomtab = "Datos"
        dttmp = cls.creadatasetdesconec(lcampos, ltipos, lnomtab)
        Return dttmp
    End Function

    '-------------------------------------------------
    'Genera el correlativo de Partida
    '-------------------------------------------------
    Function fxStevo(ByVal fecha As Date) As String
        Dim lcNumpar As String
        Dim lnnum As String
        Dim gdfecsis As Date = Today.Date()  'Se suplantara por la variable global
        Dim lnTota As Integer
        Dim lcnumcom As String
        Dim Clase As New SIM.BL.class1

        Try
            lnnum = CStr(Month(fecha))

            If lnnum.Length = 1 Then
                lnnum = "0" & lnnum.Trim
            End If

            Dim entidad1 As New SIM.EL.cnumes
            Dim eCnumes As New SIM.BL.cCnumes

            entidad1.numes = lnnum.Trim

            eCnumes.ObtenerCnumes(entidad1)

            Dim lcmes As String
            lcmes = Left(entidad1.cnumcom, 2)
            lnTota = Double.Parse(Right(entidad1.cnumcom, 6)) + 1
            'Validacion
            Dim lnlong As Integer
            Dim lnlargo As Integer = 0
            lnlargo = Len(lnTota.ToString)

            Dim lnvalor As Integer = 0
            lnvalor = 6 + lnlargo

            lnlong = lnvalor - Len(lnTota.ToString)
            


            lcnumcom = lcmes + Clase.fxStrZero(lnTota, lnlong)


            'Actualizara en la cNumes            
            entidad1.numes = lnnum
            entidad1.cnumcom = lcnumcom

            eCnumes.ActualizarCnumes1(entidad1)

            Return lcnumcom

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    '------------------------------------------------------------------------
    '   Genera el correlativo de Cliente
    '------------------------------------------------------------------------
    Public Function GeneraCodCliente(ByVal Parametro As String) As String
        '
        Dim Valor As Integer
        Dim Longitud As Integer
        Dim Correlativo As String
        Dim x As Integer
        Dim ds As New DataSet


        Try

            Dim entidadClimide As New SIM.EL.climide
            Dim eClimide As New SIM.BL.cClimide

            Dim ccodreg As String
            Dim etabtofi As New cTabtofi

            ccodreg = etabtofi.ObtenerRegiondeOficina(Parametro)

            ds = eClimide.ObtenerDataSetporOficina(ccodreg, Parametro)

            'Validando en caso que sea el primer cliente
            If IsDBNull(ds.Tables(0).Rows(0)(0)) Then
                Valor = 1
            Else
                Valor = Integer.Parse(ds.Tables(0).Rows(0)(0)) + 1
            End If

            'Longitud = 6 - Valor.ToString.Length
            Longitud = 9 - Valor.ToString.Length

            For x = 1 To Longitud
                Correlativo = Correlativo & 0
            Next

            Correlativo = Correlativo & Valor.ToString

            'Correlativo = ccodreg & Parametro & Correlativo
            Correlativo = Parametro & Correlativo
            Return Correlativo

        Catch ex As Exception

        End Try

    End Function
    Public Function CodigoCondicion(ByVal cCondic As String) As String
        Dim lccodigo As String = "01"
        If cCondic = "N" Then 'vigentes al dia
            lccodigo = "01"
        ElseIf cCondic = "M" Then 'vigentes en mora
            lccodigo = "02"
        ElseIf cCondic = "V" Then 'VENCIDOS EN PROCESO DE PRORROGA
            lccodigo = "03"
        ElseIf cCondic = "J" Then 'VENCIDOS EN COBRO JUDICIAL
            lccodigo = "04"
        End If
        Return lccodigo
    End Function


    Function fxcuentaAhorros(ByVal con As SqlConnection, ByVal pcCodctaAho As String) As String


        Dim lcCodcta_Aho As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds As New DataSet

        command.Connection = con


        'Extrae Mascara de Ahorros
        command.CommandText = _
                                " Select ccta1 from Ahomtrs " & _
                                " Where ccodtrs = '" & pcCodctaAho.Substring(6, 2).Trim & "'"

        command.CommandType = CommandType.Text

        MyAdapter.SelectCommand = command

        MyAdapter.Fill(ds, "Mascaras")

        For Each fila As DataRow In ds.Tables("Mascaras").Rows
            lcCodcta_Aho = fila("cCta1")
        Next


        Return lcCodcta_Aho

    End Function
End Class
