var map;
$(document).ready(function () {
    SetMap();
})
function SetMap() {
    map = L.map('myMap', {
        center: [32, 118],
        zoom: 6
    });

    var wmsLayer = L.tileLayer.wms('http://localhost:6080/arcgis/services/%E6%B5%8B%E8%AF%95%E6%95%B0%E6%8D%AE/%E6%B5%8B%E8%AF%95%E6%95%B0%E6%8D%AE/MapServer/WMSServer?', {
        layers: '0,1,2,3,4'
    }).addTo(map);
}

function AddFeature() {
    L.geoJSON(myLines).addTo(map);
}



var myLines = [{
    "type": "LineString",
    "coordinates": [[-100, 40], [-105, 45], [-110, 55]]
}, {
    "type": "LineString",
    "coordinates": [[-105, 40], [-110, 45], [-115, 55]]
}];
























































//var isChange = false;
//function ChangeBakgroudColor() {
//    if (isChange) {
//        $("#myMap").css('background-color',"red")

//    } else {
//        $("#myMap").css("background-color","#00FA9A");
//    }
//    isChange = !isChange;
//}
////有参数调用  
//function callWithPar(name, address) {
//    alert("Name is " + name + "; address is " + address);
//}

////返回字符串  
//function returnString() {
//    return ("This is a test.");
//}

////返回对象  
//function returnScriptObject() {
//    var people = { name: "test", age: 17 }
//    return people;
//}

//function MyObject() {
//    this.Data = "Data for my private object.";
//}

//function SSS() {
//    window.external.HHH();
////window.external.CallShow();
//////传参数  
////window.external.ShowSomething("Hello");
//////返回值  
////var msg = window.external.returnSomething("Hello");
////alert(msg);
//}