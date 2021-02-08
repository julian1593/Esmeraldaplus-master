function validar(){
var nombre, valor, fecha, hora, cantidad, expresion;

var nombre = document.getElementById('nombre-producto').value;
var valor = document.getElementById('valor-uni').value;
var fecha = document.getElementById('fecha').value;
var hora = document.getElementById('hora').value;
var cantidad = document.getElementById('cantidad').value;

if(nombre==0){
	alert("No se ha agregado un nombre de producto");
	return false;
}
if(valor==0){
	alert("No se ha agregado un valor unitario");
	return false;
}
if(fecha==0){
	alert("No se ha agregado una fecha");
	return false;
}
if(hora==0){
	alert("No se ha agregado una hora");
	return false;
}
if(cantidad==0){
	alert("No se ha agregado la cantidad del producto");
	return false;
}



}