Imports System
Imports System.EnterpriseServices

Public Class cactualizamora
    Public Function calculo(ByVal ldfecha As Date, ByVal gnperbas As Double, ByVal gnmora As Double, ByVal gdfecmor As Date) As DataSet
        'actualiza la mora de los creditos
        Dim creditos As New DataSet
        Dim mcreditos As New ccreditos
        Dim dr As DataRow
        Dim clsaplica As New payment

        Dim ecremcre As New cremcre
        Dim mcremcre As New cCremcre
        Dim lccodcta As String

        Dim contador As Integer
        contador = 0

        creditos = mcreditos.ObtenerDataSetvigente()
        For Each dr In creditos.Tables(0).Rows
            'obtiene datos de la prima y otrosp
            lccodcta = dr("ccodcta")
            clsaplica.pnprima = dr("nprima")
            clsaplica.pncosdir = dr("ncosdir")
            clsaplica.pncosind = dr("ncosind")
            clsaplica.pnsubcidio = dr("nahoprg")

            clsaplica.pccodcta = lccodcta
            clsaplica.pdfecval = ldfecha
            clsaplica.gdfecsis = ldfecha
            clsaplica.gnperbas = gnperbas
            clsaplica.cosind = dr("ncosind")
            clsaplica.gnmora = gnmora
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.gdfecmor = gdfecmor
            clsaplica.gnpergra = 7
            clsaplica.omcalcinterest("T", ldfecha)

            dr("ncappag") = clsaplica.pncappag
            dr("nintcal") = clsaplica.pnintcal
            dr("nintpen") = clsaplica.pnintpen
            dr("nmorpag") = clsaplica.pnmorpag
            dr("nintmor") = clsaplica.pnintmor

            'creditos.Tables(0).Rows(contador)("ncappag") = clsaplica.pncappag
            'creditos.Tables(0).Rows(contador)("nintcal") = clsaplica.pnintcal
            'creditos.Tables(0).Rows(contador)("nintpen") = clsaplica.pnintpen
            'creditos.Tables(0).Rows(contador)("nmorpag") = clsaplica.pnmorpag
            'creditos.Tables(0).Rows(contador)("nintmor") = clsaplica.pnintmor
            'contador = contador + 1

        Next
        Return creditos

    End Function

End Class
