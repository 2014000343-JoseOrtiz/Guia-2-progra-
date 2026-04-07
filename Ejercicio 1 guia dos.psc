Algoritmo Calculadora
	Definir opc Como Entero
	Definir num1, num2 Como Entero
	
	Escribir "*****************"
	Escribir "  MENU DE OPCIONES"
	Escribir "******************"
	Escribir "1-Suma"
	Escribir "2-RESTA"
	Escribir "3-Multriplicacion"
	Escribir "4-Division"
	Escribir Sin Saltar "Digite la opcion [] : "
	Leer opc
	Escribir "Digite dos Valores numericos"
	leer num1 
	Leer num2 
	Segun opc Hacer
		1:
			Escribir "La suma es: " ,(num1+num2)
		2:
			Escribir "La resta es: " ,(num1-num2)
		3:
			Escribir "La multriplicacion es: " ,(num1*num2)
		3:
			Escribir "La Division es: " ,(num1/num2)
		De Otro Modo:
			Escribir 'Error al calcular'
	Fin Segun
FinAlgoritmo
