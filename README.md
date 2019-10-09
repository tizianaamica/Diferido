# Diferido
Primer Parcial Programacion II 20191 Diferido

Problema 1: Fracciones Mixtas
Usted es parte de un equipo de desarrollo de software que ayuda a estudiante a aprender matemática básica.  
Usted  debe  escribir  una  parte  de  un  programa,  el  cual  debe  mostrar  posibles  fracciones impropias como fracciones mixtas. 
Una fracción apropiada es laque el numerador es menor que el denominador;  una  fracción  mixta  es  un  número  entero  seguido  de  una  fracción  apropiada.  
Por ejemplo, la fracción impropia 27/12 es equivalente a la fracción mixta, 2 3/12. Usted no debe reducir la fracción (no cambie 3/12 a1/4). 
Entrada(fracciones.in)La entrada tiene un caso de prueba por línea. Cada caso de prueba contiene dos enteros en el rango [1,231−1]. 

El primer número es el numerador y el segundo es el denominador. 
Una línea que se lea 0 0 indica fin de los casos de prueba.
SalidaPara cada caso de prueba mostrar la fracción mixta.

Ejemplo de entrada
27 12
2460000 98400
3 4000
0 0

Ejemplo de Salida
2 3 / 12
25 0 / 98400
0 3 / 4000

Problema 3:Intersección

Debes escribir un programa que indique si una línea se intersecta con un rectángulo o no.
Un ejemplo:
Punto de inicio de la línea (4,9)
Punto fin de la línea      (11,2)
Punto izquierda arriba del rectángulo (1,5)
Punto derecho abajo del rectángulo (7,1)

Se dice que la línea se intersecta con el rectángulo si al menos tienen un punto en común. 
El rectángulo consta de cuatro líneas rectas y un área entre ellas. 
Aunque los números de las entradas son enteros, no necesariamente son positivos.
Entrada(inter.in)
La entrada consta de n casos. La primera línea del archive contiene el número n. cada una de las líneas siguientes consta de un caso de entrada de la siguiente forma:xinicio yinicio xfin yfin xizquierdo yarriba xderecho yabajoLos ocho números están separados por un espacio en blanco. 
.Los términos arriba, izquierda y abajo, derecha no implican algún orden de las coordenadas. 

Salida(Pantalla)Para cada caso de entrada debe existir una línea con una letra “T” si existe intersección o una letra “F” en caso que no exista. 

Ejemplo de Entrada
1
4 9 11 2 1 5 7 1
Ejemplo de Salida
F

