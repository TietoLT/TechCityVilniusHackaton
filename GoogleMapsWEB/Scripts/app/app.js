function appJS() {

    var image = '~../../Images/football.png';
    var marker = addMarker(new google.maps.LatLng(54.691443, 25.2919347), "fule", image);

    google.maps.event.addListener(marker, 'click', function () {
        infowindow.open(map, marker);
    });












    

}

