/*______________________________________*/	
		/* Tipos de variable */
/*______________________________________*/

// let, var, const;

/*______________________________________*/	
		/* Pedir dato a usuario */
/*______________________________________*/

// prompt();

/*______________________________________*/	
		/* Concardenar texto */
/*______________________________________*/

// nombre = prompt("dime tu nombre");
// frase = `soy ${nombre} y estoy cansado`;
// alert(frase);

/*______________________________________*/	
	  /* Operadores de comparación */
/*______________________________________*/

// igualdad "==";
// no iguales "!=";
// igualdad estrictamente "===";
// no iguales estrictamente "!==";
// mayor que ">";
// menor que "<";
// mayor o igual ">=";
// menor o igual "<=";

/*______________________________________*/	
	  /* Ejercicio de practica #1 */
/*______________________________________*/


// opcion = prompt(`Seleccione el producto que desea llevar
// 1. Coca Cola $2000
// 2. Café $1600
// 3. Yogurt $1700`);

// pagoCliente = prompt("Cuanto pago el cliente")

// if (opcion == 1 ) {
// 	alert("Disfruta tu Coca Cola");
// 	alert(`Su cambio es $${pagoCliente-2000}`);
// }

// else if (opcion == 2 ) {
// 	alert("Disfruta tu Café");
// 	alert(`Su cambio es $${pagoCliente-1600}`);
// }

// else if (opcion == 3 ) {
// 	alert("Disfruta tu Yogurt");
// 	alert(`Su cambio es $${pagoCliente-1700}`);
// }

// else{
// 	alert("Opcion no valida recargue la pagina e intente nuevamemte");
// }

/*______________________________________*/	
	  	   /* Arreglos común */
/*______________________________________*/

// let frutas = ["banana", "manzana", "pera"];

// document.write(frutas[0]);

/*______________________________________*/	
	     /* Arreglos asociativo */
/*______________________________________*/

// let pc = {
// 	nombre: "Ikahde777",
// 	procesador: "Intel Core i5",
// 	ram: "4GB",
// 	espacio: "256GB SSD"
// };

// alert(pc["ram"]);

/*______________________________________*/	
	     /* Ciclo while */
/*______________________________________*/

// let numero = 0;

// while (numero <=6) {
// 	numero++;
// 	document.write(numero);
// }

/*______________________________________*/	
	     /* Ciclo do while */
/*______________________________________*/

// let numero = 0;

// do {
// 	numero++;
// 	document.write(numero);
// }
// while (numero <=6) 

/*______________________________________*/	
	     	  /* Ciclo for */
/*______________________________________*/

// for (let i = 0; i < 6; i++) {
// 	document.write(i + "<br>")
// }

/*______________________________________*/	
	     	/* Ciclo for in */
	     	/* Ciclo for of */
/*______________________________________*/

// let animales = ["gato", "perro", "conejo"];

// for (animal in animales) {
// 	document.write(animal + "<br>");
// }

// for (animal of animales) {
// 	document.write(animal + "<br>");
// }

/*______________________________________*/	
	     	  /* Funciones */
/*______________________________________*/

// function saludar(){
// 	nombre = prompt("¿Cual es tu nombre?");
// 	respuesta = prompt(`¿Hola ${nombre} como estas?`);
// 	if (respuesta == "bien") {
// 		alert("Que bueno me alegra");
// 	} else {
// 		alert("Es una pena");
// 	}
// }

// saludar();

/*______________________________________*/	
	   /* Parametros en funciones */
/*______________________________________*/

// function suma(num1,num2) {
// 	let result = num1 + num2;
// 	return result;
// }

// let resultado = suma(10,34);
// document.write(resultado);

/*______________________________________*/	
	   /* Funciones flecha */
/*______________________________________*/

// const suma = (num1,num2) => {
// 	let result = num1 + num2;
// 	return result;
// }

// let resultado = suma(10,10);
// document.write(resultado);

/*______________________________________*/	
	  /* Ejercicio de practica #2 */
/*______________________________________*/

// let free = false;

// const validarCliente = (time) => {
// 	let edad = prompt("¿Cual es tu edad?");
// 	if (edad >= 18) {
// 		if (time >= 2 && time < 7 && free == false) {
// 			alert("Puedes pasar gratis");
// 			free = true;
// 		} else {
// 			alert("Puedes pasar pero tienes que pagar la entrada");
// 		}
// 	} else {
// 		alert("No puedes pasar ¡¡¡PENDEJO!!!")
// 	}
// }

// validarCliente(2);
// validarCliente(3);
// validarCliente(4);
// validarCliente(6);
// validarCliente(12);



// function validar(){
// 	var nombre, apellido, correo, contraseña, expresiones;

// 	expresiones = {
// 	nombre: /^[A-Za-z\s]{1,20}$/
// 	apellido: /^[A-Za-z\s]{1,20}$/
// 	correo: /^[A-Za-z0-9_.+-]+@[A-Za-z]+\.[A-Za-z-]+\.?[A-Za-z]*$/
// 	contraseña = /^[A-Z]{1}[A-Za-z]+/
// 	}

