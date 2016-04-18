Public Class ClsRepGraf
#Region "Variables"
    Private dataS_Cont As New DataSet
    Private dataS_Aux As New DataSet
#End Region


    Public Function Antiguedad() As DataSet
        Try
            Dim entidadCategoria As New SIM.EL.Categoria
            Dim eCategoria As New SIM.BL.cCategoria
            dataS_Cont = eCategoria.ObtenerDataSet()
            Dim Fila As DataRow
            Dim x As Integer = 0

            Dim lcCatego As String
            Dim lnlimite As Integer
            Dim lnlimite2 As Integer

            Dim lnNumCre As Integer
            Dim lnSalCre As Double
            For Each Fila In dataS_Cont.Tables(0).Rows
                lnlimite = dataS_Cont.Tables(0).Rows(x)("limite")
                lnlimite2 = dataS_Cont.Tables(0).Rows(x)("limite2")
                dataS_Aux.Tables.Clear()
                dataS_Aux = Datos(lnlimite, lnlimite2)
                If dataS_Aux.Tables(0).Rows.Count <> 0 Then
                    lnNumCre = dataS_Aux.Tables(0).Rows(0)("nNumCre")
                    lnSalCre = dataS_Aux.Tables(0).Rows(0)("nSalCre")
                Else
                    lnNumCre = 0
                    lnSalCre = 0
                End If
                dataS_Cont.Tables(0).Rows(x)("nNumCre") = lnNumCre
                dataS_Cont.Tables(0).Rows(x)("nSalCre") = lnSalCre
                x += 1
            Next

            Return dataS_Cont
        Catch ex As Exception

        End Try
    End Function

    Public Function Datos(ByVal nLimite As Integer, ByVal nlimite2 As Integer) As DataSet
        Try
            Dim entidadREpGraf As New SIM.EL.RepGraf
            Dim eRepGraf As New SIM.BL.cRepGraf
            Dim dsReturn As New DataSet
            dsReturn = eRepGraf.ObtenerDataSetEstadistico(nLimite, nlimite2)
            Return dsReturn
        Catch ex As Exception

        End Try
    End Function
    Public Function Datos2(ByVal cGenero As String) As DataSet
        Try


        Catch ex As Exception

        End Try
    End Function
    Public Function PorGenero() As DataSet
        Try
            Dim entidadREpGraf As New SIM.EL.RepGraf
            Dim eRepGraf As New SIM.BL.cRepGraf
            dataS_Cont.Tables.Clear()
            dataS_Cont = eRepGraf.ObtenerDataSetPorIDTab("003", "1")

            Dim Fila As DataRow
            Dim x As Integer = 0
            Dim lcGenero As String
            Dim lnNumCli As Integer = 0
            Dim lnSalCre As Double = 0

            For Each Fila In dataS_Cont.Tables(0).Rows
                lcGenero = dataS_Cont.Tables(0).Rows(x)("Codigo")
                dataS_Aux = eRepGraf.ObtenerDataSetPorGenero(lcGenero.Trim)
                If dataS_Aux.Tables(0).Rows.Count = 0 Then
                    lnNumCli = 0
                    lnSalCre = 0
                Else
                    lnNumCli = dataS_Aux.Tables(0).Rows(0)("nNumCli")
                    lnSalCre = dataS_Aux.Tables(0).Rows(0)("nSalCre")
                End If
                dataS_Cont.Tables(0).Rows(x)("nNumCli") = lnNumCli
                dataS_Cont.Tables(0).Rows(x)("nSalCre") = lnSalCre
                x += 1
            Next
            Return dataS_Cont
        Catch ex As Exception
        End Try
    End Function
    Public Function PorOficina() As DataSet
        Try
            Dim entidadREpGraf As New SIM.EL.RepGraf
            Dim eRepGraf As New SIM.BL.cRepGraf
            dataS_Cont.Tables.Clear()
            dataS_Cont = eRepGraf.ObtenerDataSetOficina()

            Dim Fila As DataRow
            Dim x As Integer = 0
            Dim lcRegion As String
            Dim lcOficina As String
            Dim lnNumCli As Integer = 0
            Dim lnSalCre As Double = 0

            For Each Fila In dataS_Cont.Tables(0).Rows
                lcRegion = dataS_Cont.Tables(0).Rows(x)("Region")
                lcOficina = dataS_Cont.Tables(0).Rows(x)("Codigo")

                dataS_Aux = eRepGraf.ObtenerDataSetPorOficina(lcRegion.Trim, lcOficina.Trim)
                If dataS_Aux.Tables(0).Rows.Count = 0 Then
                    lnNumCli = 0
                    lnSalCre = 0
                Else
                    lnNumCli = dataS_Aux.Tables(0).Rows(0)("nNumCli")
                    lnSalCre = dataS_Aux.Tables(0).Rows(0)("nSalCre")
                End If
                dataS_Cont.Tables(0).Rows(x)("nNumCli") = lnNumCli
                dataS_Cont.Tables(0).Rows(x)("nSalCre") = lnSalCre
                x += 1
            Next
            Return dataS_Cont

        Catch ex As Exception

        End Try
    End Function
    Public Function PorDestino() As DataSet
        Try
            Dim entidadREpGraf As New SIM.EL.RepGraf
            Dim eRepGraf As New SIM.BL.cRepGraf
            dataS_Cont.Tables.Clear()
            dataS_Cont = eRepGraf.ObtenerDataSetDestino("005", "1")

            Dim Fila As DataRow
            Dim x As Integer = 0
            Dim lcCodigo As String
            Dim lnNumCli As Integer = 0
            Dim lnSalCre As Double = 0

            For Each Fila In dataS_Cont.Tables(0).Rows
                lcCodigo = dataS_Cont.Tables(0).Rows(x)("Codigo")
                dataS_Aux = eRepGraf.ObtenerDataSetPorDestino(lcCodigo)
                If dataS_Aux.Tables(0).Rows.Count = 0 Then
                    lnNumCli = 0
                    lnSalCre = 0
                Else
                    lnNumCli = dataS_Aux.Tables(0).Rows(0)("nNumCli")
                    lnSalCre = dataS_Aux.Tables(0).Rows(0)("nSalCre")
                End If
                dataS_Cont.Tables(0).Rows(x)("nNumCli") = lnNumCli
                dataS_Cont.Tables(0).Rows(x)("nSalCre") = lnSalCre
                x += 1
            Next
            Return dataS_Cont

        Catch ex As Exception

        End Try
    End Function
End Class
