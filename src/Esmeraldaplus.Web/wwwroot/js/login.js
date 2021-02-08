function revisarCampo(elemento){
	if (elemento.value == '') {
		elemento.className='error';
	}else{
		elemento.className='input';
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