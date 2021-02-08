function comprar() {
	document.getElementById('dark_screen').style.display="block";
}
function cerrar() {
	document.getElementById('dark_screen').style.display="none";
}
function validar(elemento) {
	if (elemento.value =='') {
		elemento.className="error";
		document.getElementById('error_campo').style.display="block";
	}else{
		elemento.className="input";
		document.getElementById('error_campo').style.display="none";
	}
}
function validarIdCompra(elemento){
	if (elemento.value !== '') {
		let data = elemento.value;
		let expresion = /^[0-9]{4}$/
		if (!expresion.test(data)) {
			elemento.className='error';
			document.getElementById('error_alerta').style.display="block";
		}else{
		elemento.className='input';
		document.getElementById('error_alerta').style.display="none";
		}
	}
}


