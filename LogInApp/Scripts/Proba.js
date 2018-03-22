var dzisiaj = new Date();
var godzina = dzisiaj.getHours();
var minuta = dzisiaj.getMinutes();
var sekunda = dzisiaj.getSeconds();

function czas()
{
    document.getElementById(".timer").innerHTML = godzina + ":" + minuta + ":" + sekunda;
    setTimeout("czas()", 1000);

}
