Imports System
Imports System.Collections
Imports System.Configuration
Imports System.Data
Imports System.Text
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports Artem.Web.UI.Controls
Imports Artem.Google.Net

Partial Class wucGeoReferencia
    Inherits ucWBase

    Private latitud As Decimal
    Private longitud As Decimal
    Private descripcion As String

#Region "Publicos"
    Public Event Seleccionado(ByVal lat As String, ByVal Lng As String)
#End Region

    Public Property _latitud() As Decimal
        Get
            Return latitud
        End Get
        Set(ByVal value As Decimal)
            latitud = value
        End Set
    End Property

    Public Property _longitud() As Decimal
        Get
            Return longitud
        End Get
        Set(ByVal value As Decimal)
            longitud = value
        End Set
    End Property

    Public Property _descripcion() As String
        Get
            Return descripcion

        End Get
        Set(ByVal value As String)
            descripcion = value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            CargarMapa()
            'CargarMapa_()
        End If

    End Sub


#Region "Metodos"

    Private Function GetResponse_Address(ByVal Address As String) As ArrayList
        'Dim pruebas As New 
        Dim array_coordenadas As New ArrayList
        Dim request As New GeoRequest(Address)
        Dim response As GeoResponse = request.GetResponse()

        Dim actual As GeoLocation = response.Results(0).Geometry.Location
        Dim location As GeoLocation = response.Results(0).Geometry.Location

        Dim latitude As Double = location.Latitude
        Dim longitude As Double = location.Longitude

        array_coordenadas.Add(location.Latitude)
        array_coordenadas.Add(location.Longitude)

        'Assert.AreEqual(expected, actual)

        Return array_coordenadas

    End Function


#End Region

    Private Sub CargarMapa()
        latitud = Session("latitud")
        longitud = Session("longitud")

        If Me.Txtczona.Text.Length = 0 Then
            Me.Txtczona.Text = Session("Zona")
        End If

        If String.IsNullOrEmpty(latitud) Then
            Exit Sub
        End If
        If String.IsNullOrEmpty(longitud) Then
            Exit Sub
        End If

        If latitud = 0 Then
            Exit Sub
        End If
        If longitud = 0 Then
            Exit Sub
        End If


        Me.TxtLat.Text = latitud
        Me.TxtLng.Text = longitud

        GoogleMap1.Key = "AIzaSyCRCzmF0oDHCrFB933q0LsdMwDQ-cqzITQ"
        GoogleMap1.EnableScrollWheelZoom = False

        GoogleMap1.Latitude = latitud
        GoogleMap1.Longitude = longitud
        GoogleMap1.Zoom = 8



        Dim marker As New GoogleMarker
        marker.Latitude = latitud
        marker.Longitude = longitud
        marker.Text = Session("Zona") + " " + latitud.ToString.Trim + "," + longitud.ToString.Trim
        marker.Show()
        GoogleMap1.Markers.Add(marker)

    End Sub

    Private Sub CargarMapa_()
        latitud = 13.6929403
        longitud = -89.218191100000013

        GoogleMap1.Key = "AIzaSyCRCzmF0oDHCrFB933q0LsdMwDQ-cqzITQ"
        GoogleMap1.EnableScrollWheelZoom = False
        GoogleMap1.EnableGoogleBar = False

        GoogleMap1.Latitude = 25.6740301
        GoogleMap1.Longitude = -100.3096334
        GoogleMap1.Zoom = 8

        Dim marker As New GoogleMarker
        marker.Latitude = 25.6740301
        marker.Longitude = -100.3096334
        'marker.Text = Session("Zona") + " " + latitud.ToString.Trim + "," + longitud.ToString.Trim
        marker.Show()
        GoogleMap1.Markers.Add(marker)

    End Sub


    Protected Sub Btnir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIr.Click
        Dim array_coordenadas As New ArrayList

        If String.IsNullOrEmpty(Me.Txtczona.Text.Trim) Then
            Exit Sub
        End If

        GoogleMap1.Enabled = True
        GoogleMap1.Key = "AIzaSyCRCzmF0oDHCrFB933q0LsdMwDQ-cqzITQ"
        GoogleMap1.EnableScrollWheelZoom = True
        GoogleMap1.EnableDoubleClickZoom = True

        'GoogleMap1.EnableReverseGeocoding = True

        GoogleMap1.Address = Me.Txtczona.Text.Trim
        GoogleMap1.Zoom = 8
        GoogleMap1.Markers.Clear() 'Limpia la marca anterior


        array_coordenadas = GetResponse_Address(Me.Txtczona.Text.Trim)


        Me.TxtLat.Text = array_coordenadas.Item(0)
        Me.TxtLng.Text = array_coordenadas.Item(1)

        Dim marker As New GoogleMarker
        marker.Address = Me.Txtczona.Text.Trim
        marker.Text = Me.Txtczona.Text.Trim + " " + Me.TxtLat.Text.Trim + "," + Me.TxtLng.Text.Trim 'Session("descripcion")
        marker.Show()
        GoogleMap1.Markers.Add(marker)





        'For Each myM As GoogleMarker In GoogleMap1.Markers
        '    Dim CallArgs As [Object]() = New [Object](2) {}
        '    Me.TxLat.Text = myM.Latitude.ToString()
        '    Me.TxtLng.Text = myM.Longitude.ToString()

        'Next





        'geocoder = new google.maps.Geocoder();
        '       InitializeMap();

        '       var address = document.getElementById("addressinput").value;
        '       geocoder.geocode({ 'address': address }, function (results, status) {
        '           if (status == google.maps.GeocoderStatus.OK) {
        '               map.setCenter(results[0].geometry.location);

        '               //actualizo el formulario
        '               updatePosition(results[0].geometry.location);

        '               //Se coloca la Marca
        '               var marker = new google.maps.Marker({
        '                   map: map,
        '                   position: results[0].geometry.location //,
        '                   //draggable: true
        '               });

        '           }
        '           else {                        
        '               alert("No podemos encontrar la dirección, error: " + status);
        '           }
        '       });



    End Sub

    Protected Sub Btnout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnout.Click
        RaiseEvent Seleccionado(Me.TxtLat.Text.Trim, Me.TxtLng.Text.Trim)
    End Sub
End Class


