Imports System
Imports System.Web.UI
Imports Subgurim.Controles

Partial Class WbGoogleMaps
    Inherits System.Web.UI.Page



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Latitud As Double
        Dim Longitud As Double

        Latitud = 41.40338
        Longitud = 2.17403

        Dim ubicacion As New GLatLng(latitud, longitud)
        GMap1.setCenter(ubicacion, 15)

        'Establece alto y ancho en px
        GMap1.Height = 300
        GMap1.Width = 400

        'Adiciona el control de la parte izquierda superior (mover, ampliar y reducir)
        'GMap1.AddControl(New GControl(GControl.preBuilt.LargeMapControl))
        GMap1.Add(New GControl(GControl.preBuilt.LargeMapControl))

        'Permitir hacer zoon con la rueda del mause
        GMap1.enableHookMouseWheelToZoom = True

        'Tipo de Mapa a Mostrar
        GMap1.mapType = GMapType.GTypes.Normal

    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnOpciones.SelectedIndexChanged
        Dim val As Integer

        val = rbtnOpciones.SelectedIndex()

        If val = 0 Then   'Coordenadas
            Me.TxtLatitud.Enabled = True
            Me.TxtLongitud.Enabled = True
            Me.TxtLocalidad.Enabled = False
            Me.BtnIr.Enabled = True
            Btnciudad.Enabled = False
        Else              'Latitud, Longitud  
            Me.TxtLatitud.Enabled = False
            Me.TxtLongitud.Enabled = False
            Me.TxtLocalidad.Enabled = True
            Me.BtnIr.Enabled = False
            Btnciudad.Enabled = True
        End If
    End Sub

    Protected Sub BtnIr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIr.Click
        Dim Latitud As Double
        Dim Longitud As Double
        Latitud = Me.TxtLatitud.Text.Trim
        Longitud = Me.TxtLongitud.Text.Trim

        Dim ubicacion As New GLatLng(Latitud, Longitud)
        GMap1.setCenter(ubicacion, 15)

    End Sub

    Protected Sub Btnciudad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnciudad.Click
        Try
            Dim GeoCode As Subgurim.Controles.GeoCode
            Dim eMapKey As String = System.Configuration.ConfigurationManager.AppSettings("481196834884-e3d0jq9cmlccg7ln9sko0gu88583f4iq.apps.googleusercontent.com")

            GeoCode = GMap.geoCodeRequest(Me.TxtLocalidad.Text.Trim, eMapKey)

            If GeoCode.valid Then
                Me.LblLatitud.Text = GeoCode.Placemark.coordinates.lat
                Me.LblLongitud.Text = GeoCode.Placemark.coordinates.lng

                Dim gLatLng As New Subgurim.Controles.GLatLng(GeoCode.Placemark.coordinates.lat, GeoCode.Placemark.coordinates.lng)

                GMap1.setCenter(gLatLng, 16, Subgurim.Controles.GMapType.GTypes.Normal)
            Else
                Response.Write("<script language='javascript'>alert('No se puede Encontrar la Ubicación, Advertencia SIM.NET')</script>")
            End If

        Catch ex As Exception
            'Response.Write("Error: " & ex.Message.ToString)
            Response.Write("<script language='javascript'>alert('Ocurrio un Error, Advertencia SIM.NET')</script>")
        End Try
    End Sub

    Protected Sub BtnVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnVer.Click

        Dim val As Integer

        'Reajusta las coordenadas
        val = rbtnOpciones.SelectedIndex()

        If val = 0 Then   'Coordenadas
            BtnIr_Click(sender, e)
        Else              'Latitud, Longitud  
            Btnciudad_Click(sender, e)
        End If

        Select Case Me.ListaTipoMapa.SelectedValue.Trim
            Case "A"  'Normal
                GMap1.mapType = GMapType.GTypes.Normal
            Case "B"  'Satelite  
                GMap1.mapType = GMapType.GTypes.Satellite
            Case "C"  'Hibrido 
                GMap1.mapType = GMapType.GTypes.Hybrid
            Case "D"  'Fisico  
                GMap1.mapType = GMapType.GTypes.Physical
        End Select



    End Sub
End Class
