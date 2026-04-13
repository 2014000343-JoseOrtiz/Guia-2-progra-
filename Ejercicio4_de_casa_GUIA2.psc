Algoritmo Ejercicio4_de_casa_GUIA2
	Definir opc1, opc2 Como Entero
	Definir cant, metros Como Real
	Escribir "********************************"
	Escribir "CONVERSOR DE MEDIDAS DE LONGITUD"
	Escribir "********************************"
	Escribir "1- Metros"
	Escribir "2- Pies"
	Escribir "3- Centimetros"
	Escribir "4- Pulgadas"
	Escribir Sin Saltar"Digite la Unidad de Origen: "
	Leer opc1
	Escribir Sin Saltar"Ingresa el valor de tu medida: "
	Leer cant
	Escribir Sin Saltar"Digita la Unidad Final: "
	Leer opc2
	//Convertir a metros
	Segun opc1 Hacer
		1:
			metros = cant
		2:
			metros = cant/3.281
		3:
			metros = cant/100
		4: 
			metros = cant/39.37
		De Otro Modo:
			Escribir "Opcion invalida"
	Fin Segun
	Segun opc2 Hacer
		1:
			Escribir "Conversión a Metros: ",metros
		2:
			Escribir "Conversión a Pies: ",metros*3.281
		3:
			Escribir "Conversión a centimetros: ",metros*100
		4:
			Escribir "Conversión a pulgadas: ",metros*39.3701
		De Otro Modo:
			Escribir "Opcion invalida"
	Fin Segun
FinAlgoritmo