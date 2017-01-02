function initialize() {
    var secheltLoc = new google.maps.LatLng(46.387741, 3.430176),
         markers,
            myMapOptions = {
             zoom: 8,
            center: secheltLoc,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
			scrollwheel: false,
		   styles: [
    {
        "featureType": "landscape",
        "stylers": [
            {
                "hue": "#FFA800"
            },
            {
                "saturation": 0
            },
            {
                "lightness": 0
            },
            {
                "gamma": 1
            }
        ]
    },
    {
        "featureType": "road.highway",
        "stylers": [
            {
                "hue": "#53FF00"
            },
            {
                "saturation": -73
            },
            {
                "lightness": 40
            },
            {
                "gamma": 1
            }
        ]
    },
    {
        "featureType": "road.arterial",
        "stylers": [
            {
                "hue": "#FBFF00"
            },
            {
                "saturation": 0
            },
            {
                "lightness": 0
            },
            {
                "gamma": 1
            }
        ]
    },
    {
        "featureType": "road.local",
        "stylers": [
            {
                "hue": "#00FFFD"
            },
            {
                "saturation": 0
            },
            {
                "lightness": 30
            },
            {
                "gamma": 1
            }
        ]
    },
    {
        "featureType": "water",
        "stylers": [
            {
                "hue": "#00BFFF"
            },
            {
                "saturation": 6
            },
            {
                "lightness": 8
            },
            {
                "gamma": 1
            }
        ]
    },
    {
        "featureType": "poi",
        "stylers": [
            {
                "hue": "#679714"
            },
            {
                "saturation": 33.4
            },
            {
                "lightness": -25.4
            },
            {
                "gamma": 1
            }
        ]
    }
]
        },
        map = new google.maps.Map(document.getElementById("map"), myMapOptions);

    function initMarkers(map, markerData) {
        var newMarkers = [],
            marker;
		var image ='../../Areas/Beneficiary/Images/bano-salons-coiffure-markeur1.png'; 
        for(var i=0; i<markerData.length; i++) {
            marker = new google.maps.Marker({
                map: map,
				icon: image,
                draggable: false,
                position: markerData[i].latLng,
				animation: google.maps.Animation.DROP,
                visible: true
            }),
            boxText = document.createElement("div");
			
            //these are the options for all infoboxes
             infoboxOptions = {
                 content: boxText,
                disableAutoPan: false
			,maxWidth: 0
			,pixelOffset: new google.maps.Size(-65, -115)
			,zIndex: -999999
			,boxStyle: {  
			  background: "#9FB814"
			  ,opacity: 1
			  ,width: "60px"
			  ,height: "60px"
			  ,textAlign:"center"
			  ,color: "#fff"
			  ,padding: "1px"
			  ,borderRadius: "100%"
			  ,border:"5px solid #9FB814"
			  ,fontSize: "11px"
                }
            };

            newMarkers.push(marker);
            //define the text and style for all infoboxes
      
            boxText.innerHTML = markerData[i].address + "<br>" + markerData[i].state;
            //Define the infobox
            newMarkers[i].infobox = new InfoBox(infoboxOptions);
            //Open box when page is loaded
            newMarkers[i].infobox.open(map, marker);
            //Add event listen, so infobox for marker is opened when user clicks on it.  Notice the return inside the anonymous function - this creates
            //a closure, thereby saving the state of the loop variable i for the new marker.  If we did not return the value from the inner function, 
            //the variable i in the anonymous function would always refer to the last i used, i.e., the last infobox. This pattern (or something that
            //serves the same purpose) is often needed when setting function callbacks inside a for-loop.
            google.maps.event.addListener(marker, 'click', (function(marker, i) {
                return function() {
                    newMarkers[i].infobox.open(map, this);
                    map.panTo(markerData[i].latLng);
					if (screen.width <= 970) {
					    $('.header-map').hide();
					    $('.body-content').hide();
					    $('.info-salon').show();
					}
					else {
					    $('#infoSurSalon').show();
                	}
                }
				
            })(marker, i));
        }

        return newMarkers;
    }
		
    //here the call to initMarkers() is made with the necessary data for each marker.  All markers are then returned as an array into the markers variable
    markers = initMarkers(map, [
        { latLng: new google.maps.LatLng(46.187741, 3.430176), address: "<center> 30 € <br><img src= '../../Areas/Beneficiary/Images/hour-glass.png' /><br> 0 min</center>", state: "" }
    ]);
}