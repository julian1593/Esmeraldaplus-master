function validar(){
var fecha1, cantidad1, cantidad2, fecha2, expresiones;

var fecha1 = document.getElementById('fechaproducto').value;
var cantidad1 = document.getElementById('cantidadproducto').value;
var cantidad2 = document.getElementById('cantidadinsumos').value;
var fecha2 = document.getElementById('fechainsumo').value;

if (fecha1==0) {
	alert("Debe agregar una fecha de ingreso de producto");
	return false;
}
if (cantidad1==0) {
	alert("Debe ingresar la cantidad de productos que desea agregar");
	return false;
}
if (cantidad2==0) {
	alert("Debe ingresar la cantidad de insumos que desea agregar");
	return false;
}
if (fecha2==0) {
	alert("Debe agregar una fecha de ingreso de insumo");
	return false;
}


}