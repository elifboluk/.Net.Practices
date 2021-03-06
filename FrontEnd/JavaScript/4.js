console.log("4.js dosyası çalıştı.");

//GeoLocation

var initMap = () => {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    } else {
        console.log("Geolocation is not supported by this browser.");
    }
}

var showPosition = (position) => {
    //console.log(position);
    var pos = {
        lat: position.coords.latitude,
        lng: position.coords.longitude
    };
    console.log(pos);
    var mapDiv = document.getElementById('map');
    var map = new google.maps.Map(mapDiv, {
        center: pos,
        zoom: 18,
        mapTypeId: "terrain",
    });

    var marker = new google.maps.Marker({
        position: pos,
        map: map
    });


    map.addListener('click', (e) => {
        console.log(e),
        console.log(e.latLng.lat())
        var posClick = {
            lat: e.latLng.lat(),
            lng: e.latLng.lng()
        };

        //markerları temizle
        marker.setMap(null);
        //Tıklanan konuma göre marker ekle
        marker = new google.maps.Marker({
            position: posClick,
            map: map,
            title: 'Clicked Location',
            animation: google.maps.Animation.DROP
        });
    });

}
// latitude: 41.044008982786345
// longitude: 29.007230753851537

//https://www.google.com/maps/@41.04400551057116,29.007235110826237,20z

//latitude: 41.04400551057116
//longitude: 29.007235110826237