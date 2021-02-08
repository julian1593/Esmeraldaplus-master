function revisar(elemento) {
	if (elemento.value =='') {
		elemento.className='error';
	}else{
		elemento.className='input';
	}
}
function validarNombre(elemento){
	if (elemento.value !== '') {
		let data = elemento.value;
		let expresion = /^[A-Za-z\s]{2,20}$/
		if (!expresion.test(data)) {
			elemento.className='error';
			document.getElementById('errorNombre').style.display="block";
		}else{
		elemento.className='input';
		document.getElementById('errorNombre').style.display="none";
		}
	}
}
function validarApellido(elemento){
	if (elemento.value !== '') {
		let data = elemento.value;
		let expresion = /^[A-Za-z\s]{2,20}$/
		if (!expresion.test(data)) {
			elemento.className='error';
			document.getElementById('errorApellido').style.display="block";
		}else{
		elemento.className='input';
		document.getElementById('errorApellido').style.display="none";
		}
	}
}
function validarEmail(elemento){
	if (elemento.value !== '') {
		let data = elemento.value;
		let expresion = /^[A-Za-z0-9_.+-]+@[A-Za-z]+\.[A-Za-z-]+\.?[A-Za-z]*$/
		if (!expresion.test(data)) {
			elemento.className='error';
			document.getElementById('errorEmail').style.display="block";
		}else{
		elemento.className='input';
		document.getElementById('errorEmail').style.display="none";
		}
	}
}


