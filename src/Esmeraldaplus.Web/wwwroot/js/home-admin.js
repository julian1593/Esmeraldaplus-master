function validarInsumo(elemento){
	if (elemento.value !== '') {
		let data = elemento.value;
		let expresion = /^[A-Z]{1}[0-9]{3}$/
		if (!expresion.test(data)) {
			elemento.className='error';
			document.getElementById('errorCodigoProducto').style.display="block";
		}else{
		elemento.className='input';
			document.getElementById('errorCodigoProducto').style.display="none";
		}
	}
}
function agregarInsumo(){
	document.getElementById('dark-body2').style.display="block";
}

function agregar(){
	document.getElementById('dark_body').style.display="block";
}

function cerrarFormInsumo(){
	document.getElementById('dark-body2').style.display="none";
}

function cerrar(){
	document.getElementById('dark_body').style.display="none";
}