function revisarcampo(elemento) {
	if (elemento.value =='') {
		elemento.className='error';
	}else{
		elemento.className='input';
	}
}

function revisarNombre(elemento){
	if (elemento.value !=='') {
		let data = elemento.value;
		let expresion =/^[a-zA-Z\s]{10,50}$/

		if (!expresion.test(data)) {
		elemento.className='error';
		document.getElementById('mensaje1').style.display="block";
		}else{
		elemento.className='input';
		document.getElementById('mensaje1').style.display="none";
		}
	}
}
function revisarCorreo(elemento){
	if (elemento.value !== '') {
		let data = elemento.value;
		let expresion = /^[A-Za-z0-9_.+-]+@[A-Za-z]+\.[A-Za-z-]+\.?[A-Za-z]*$/
		if (!expresion.test(data)) {
			elemento.className='error';
			document.getElementById('mensaje2').style.display="block";
		}else{
			elemento.className='input';
			document.getElementById('mensaje2').style.display="none";
		}
	}
}

function revisarTelefono(elemento){
	if (elemento.value !== '') {
		let data = elemento.value;
		let expresion = /^[0-9]{7,10}$/
		if (!expresion.test(data)) {
			elemento.className='error';
			document.getElementById('mensaje3').style.display="block";
		}else{
			elemento.className='input';
			document.getElementById('mensaje3').style.display="none";
		}
	}
}