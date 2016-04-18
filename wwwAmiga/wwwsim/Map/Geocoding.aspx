<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Geocoding.aspx.vb" Inherits="Map_Geocoding" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 30px;
        }
        #Button2
        {
            height: 25px;
            width: 189px;
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 214px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
        <script language="javascript" type="text/javascript">

            var map;
            var geocoder;
            function InitializeMap() {

                var latlng = new google.maps.LatLng(-34.397, 150.644);
                var myOptions =
                {
                    zoom: 8,
                    center: latlng,
                    mapTypeId: google.maps.MapTypeId.ROADMAP                   
                    
                };
                map = new google.maps.Map(document.getElementById("map"), myOptions);
            }

            function FindLocaiton() {
                geocoder = new google.maps.Geocoder();
                InitializeMap();

                var address = document.getElementById("addressinput").value;
                geocoder.geocode({ 'address': address }, function (results, status) {
                    if (status == google.maps.GeocoderStatus.OK) {
                        map.setCenter(results[0].geometry.location);
                        
                        //actualizo el formulario
                        updatePosition(results[0].geometry.location);
                        
                        //Se coloca la Marca
                        var marker = new google.maps.Marker({
                            map: map,
                            position: results[0].geometry.location //,
                            //draggable: true
                        });

                    }
                    else {                        
                        alert("No podemos encontrar la dirección, error: " + status);
                    }
                });

            }


                        
            function FindCoordenadas() {
                var latlng = new google.maps.LatLng(document.getElementById("Lat").value, document.getElementById("Lng").value);
                var myOptions =
                {
                    zoom: 8,
                    center: latlng,
                    mapTypeId: google.maps.MapTypeId.ROADMAP
                    
                };

                map = new google.maps.Map(document.getElementById("map"), myOptions);

                var marker = new google.maps.Marker({
                    map: map,                    
                    position: new google.maps.LatLng(document.getElementById("Lat").value, document.getElementById("Lng").value) //,
                    //draggable: true
                });
                
            }


            function Button1_onclick() {
                FindLocaiton();
            }


            function Button2_onclick() {
                FindCoordenadas();
            }

            //funcion que actualiza los campos del formulario
            function updatePosition(latLng) {
                            
                document.getElementById("Lat").value = latLng.lat();
                document.getElementById("Lng").value = latLng.lng();

            }
    
            
            window.onload = InitializeMap;


        </script>

        <h2>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            Geolocalización: </h2>
        <table>
        <tr>
        <td>
            <input id="addressinput" type="text" style="width: 447px" />   
        </td>
        <td class="style3">
            <input id="Button1" type="button" value="Obtener Coordenadas" onclick="return Button1_onclick()" /></td>
        </tr>
        <tr>
        <td colspan ="2">
        <div id ="map" style="height: 418px; width: 722px;" >
        </div>
        </td>
        </tr>
        <tr>
        <td colspan ="2">
            <table cellpadding="0" cellspacing="0" class="style2">
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label1" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Text="Latitud"></asp:Label>
                    </td>
                    <td class="style1">
            <input id="Lat" type="text" style="width: 200px" /><input id="Button2" type="button" value="Buscar Coordenadas" 
                onclick="return Button2_onclick()" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="12pt" Text="Longitud"></asp:Label>
                    </td>
                    <td>
            <input id="Lng" type="text" style="width: 200px" /></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td style="text-align: right">
                        <asp:Button ID="btnsalir" runat="server" Font-Names="Gill Sans MT" 
                            Font-Size="11pt" style="text-align: right" Text="Retornar" />
                    </td>
                </tr>
            </table>
            </td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
