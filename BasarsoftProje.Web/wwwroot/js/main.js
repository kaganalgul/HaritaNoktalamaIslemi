var _Map, _Draw, _Source, _Layer;
var modal = document.getElementById("myModal");
var table = document.getElementById("myTable");
var span = document.getElementsByClassName("close")[0];
var spanBtn = document.getElementById("closeBtn");
const features = [];

InitializeMap = () => {
    _Source = new ol.source.Vector({ wrapX: false });

    _Layer = new ol.layer.Vector({
        source: _Source,
    });

    _Map = new ol.Map({
        target: 'map',
        layers: [
            new ol.layer.Tile({
                source: new ol.source.OSM()
            }),
            _Layer

        ],
        view: new ol.View({
            center: [3875337.272593909, 4673762.797695817],
            zoom: 6.85
        })
    });
}

AddInteraction = () => {

    _Draw = new ol.interaction.Draw({
        source: _Source,
        type: "Point"
    });

    _Map.addInteraction(_Draw);

    _Draw.setActive(false);

    _Draw.on(
        "drawend",
        (_event) => {
            console.log(_event.feature.getGeometry().getCoordinates());
            modal.style.display = "block";
            $("#pointXaxis").val(_event.feature.getGeometry().getCoordinates()[0]);
            $("#pointYaxis").val(_event.feature.getGeometry().getCoordinates()[1]);
            _Draw.setActive(false);
        }
    );
}

$(document).ready(function() {
    $.ajax({
        type: "GET",
        url: "Home/GetPoints",
        success: function (data) {
            data.points.forEach((item) => {
                features.push(new ol.Feature({
                    geometry: new ol.geom.Point(ol.proj.fromLonLat([
                        Number(item.xaxis), Number(item.yaxis)
                    ]))
                }));
            });
        }
    });
});

OpenTable = () => {
    table.style.display = "block";
}

AddPoint = () => {
    _Draw.setActive(true);
}


span.onclick = function () {
    modal.style.display = "none";
}


spanBtn.onclick = function () {
    table.style.display = "none";
}
