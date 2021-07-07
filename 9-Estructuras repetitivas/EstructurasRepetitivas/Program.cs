using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasRepetitivas
{
    class Program
    {
        static void Main(string[] args)
        {


            // int num = 1;
            //while (num<=100)
            // {
            //     Console.Write(num+"-");

            //     num = num + 1;

            // }
            // Console.ReadKey();

            //variaciones: 1 - Imprimir los números del 1 al 500.

            //int num = 1;
            //while (num <= 500)
            //{
            //    Console.Write(num + "-");

            //    num = num + 1;

            //}
            //Console.ReadKey();

            // 2- Imprimir los números del 50 al 100.


            //int num = 50;
            //while (num <= 100)
            //{
            //    Console.Write(num + "-");

            //    num = num + 1;

            //}
            //Console.ReadKey();


            // 3 - Imprimir los números del - 50 al 0.

            //int num = -50;
            //while (num <= 0)
            //{
            //    Console.Write("("+num +")-");

            //    num = num + 1;

            //}
            //Console.ReadKey();


            //// 4 - Imprimir los números del 2 al 100 pero de 2 en 2(2, 4, 6, 8....100).

            //int num = 2;
            //while (num <= 100)
            //{
            //    Console.Write("(" + num + ")-");

            //    num = num + 2;

            //}
            //Console.ReadKey();

            //)Problema 2 : Escribir un programa que solicite la carga de un valor positivo y nos muestre desde 1 hasta el valor ingresado de uno en uno.
            // Ejemplo: Si ingresamos 30 se debe mostrar en pantalla los números del 1 al 30.

            //string aux;
            //int numero;
            //int x = 1;
            //Console.WriteLine("Ingrese un numero entero positivo");
            //aux = Console.ReadLine();
            //numero = int.Parse(aux);
            //while (x <= numero)
            //{
            //    Console.Write("(" + x + ")-");
            //    x ++;


            //}
            //Console.ReadKey();


            //string aux;
            //int x = 1;
            //int num = 0;
            //int suma = 0;
            //double promedio = 0;
            //while(x<=10)
            //{
            //    Console.WriteLine("Ingrese un numero cualquiera: ");
            //    aux = Console.ReadLine();
            //    num = int.Parse(aux);
            //    suma =suma+num;
            //    x++;

            //}
            //promedio = suma / 10;

            //Console.Write("La suma es: " + suma+ " y el promedio es: " + promedio);

            //Console.ReadKey();


            //4) Una planta que fabrica perfiles de hierro posee un lote de n piezas.
            // Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar y
            // luego ingrese la longitud de cada perfil; sabiendo que la pieza cuya longitud esté
            //  comprendida en el rango de 1,20 y 1,30 son aptas. Imprimir por pantalla la cantidad de piezas aptas que hay en el lote.
            //int x = 1;
            //string aux;
            //int cantPiezas;
            //int cont = 0;
            //double longPerfil;
            //Console.WriteLine("Ingrese la cantidad de piezas a procesar :");
            //aux = Console.ReadLine();
            //cantPiezas = int.Parse(aux);
            //while(x<=cantPiezas)
            //{
            //    Console.WriteLine("ingrese la longitud del perfil");
            //    aux = Console.ReadLine();
            //    longPerfil = double.Parse(aux);
            //    if(longPerfil >= 1.20 && longPerfil<=1.30)
            //    {

            //        cont ++;

            //    }
            //    x = x + 1;

            //}
            //Console.Write("La  cantidad de piezas aptas es: "+cont);
            //Console.ReadKey();


            //Problemas propuestos:
            //1) Escribir un programa que solicite ingresar 10 notas de alumnos y
            //nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores. 



            //int x = 1;
            //string aux;
            //int nota=0;
            //int cont1 = 0;
            //int cont2 = 0;

            //while (x <= 10)
            //{
            //    Console.WriteLine("ingrese la nota del alumno");
            //    aux = Console.ReadLine();
            //    nota = int.Parse(aux);
            //    if (nota >=7)
            //    {

            //        cont1++;

            //    }
            //    else
            //    {
            //        cont2++;
            //    }
            //    x = x + 1;

            //}
            //Console.WriteLine("La  cantidad de alumnos con nota de 7 o mas es: " + cont1);
            //Console.WriteLine("La  cantidad de alumnos con nota menor a 7  es: " + cont2);
            //Console.ReadKey();

            //2) Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas. 

            //int x = 1;
            //string aux;
            //int cantPersonas = 0;
            //double promPersonas = 0;
            //double alturaPersonas = 0;
            //double acum= 0;

            //Console.WriteLine("ingrese la cantidad de personas");
            //aux = Console.ReadLine();
            //cantPersonas = int.Parse(aux);
            //while (x <= cantPersonas)
            //{
            //    Console.WriteLine("ingrese la altura de la persona");
            //    aux = Console.ReadLine();
            //    alturaPersonas = int.Parse(aux);
            //    acum = alturaPersonas + acum;
            //      x = x + 1;



            //}
            //promPersonas = acum / cantPersonas;
            //Console.WriteLine("La altura promedio es: " + promPersonas);

            //Console.ReadKey();


            //3)En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
            //realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y
            //cuántos cobran más de $300.
            //Además el programa deberá informar el importe que gasta la empresa en sueldos al personal. 

            //string aux;
            //  int  x = 1;
            //    int cantSueldos = 0;
            //int totalSueldos = 0;
            //int sueldo = 0;
            //int cont1 = 0;
            //int cont2 = 0;
            //Console.WriteLine("Ingresa la cantidad de sueldos");
            //aux = Console.ReadLine();
            //cantSueldos = int.Parse(aux);
            //while (x <= cantSueldos)
            // {
            //    Console.WriteLine("Ingresa el monto del sueldo");
            //    aux = Console.ReadLine();
            //    sueldo = int.Parse(aux);

            //    if(sueldo <=300 )
            //    {
            //        cont1++;
            //    }
            //    else
            //    {
            //        cont2++;
            //    }
            //    x = x + 1;
            //    totalSueldos = totalSueldos + sueldo;




            //}
            //Console.Write("La cantidad de empleados que cobra entre $100 y $300 es: " + cont1);
            //Console.Write("La cantidad de empleados que cobra mas de $300 es: " + cont2);
            //Console.Write("La cantidad de total que la empresa gasta en sueldos es: " + totalSueldos);
            //Console.ReadKey();

            //4) Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado) 

            //int x = 1;
            //int termino = 11;
            //while(x<=25)
            //{

            //    Console.WriteLine(termino + "-");
            //    termino = termino + 11;
            //    x = x + 1;
            //}
            //Console.ReadKey();

            //5) Mostrar los múltiplos de 8 hasta el valor 500. Debe aparecer en pantalla 8 - 16 - 24, etc. 


            //int multiplo = 8;
            //while (multiplo <= 500)
            //{

            //    Console.WriteLine(multiplo + "-");
            //    multiplo = multiplo + 8;

            //}
            //Console.ReadKey();

            //6)Realizar un programa que permita cargar dos listas de 15 valores cada una.
            //Informar con un mensaje cual de las dos listas tiene un valor acumulado mayor
            //(mensajes "Lista 1 mayor", "Lista 2 mayor", "Listas iguales")
            // Tener en cuenta que puede haber dos o más estructuras repetitivas en un algoritmo. 
            //string aux;
            //int valorLista1;
            //int valorLista2;
            //int x = 1;
            //int acum1=0;
            //int acum2=0;

            //Console.WriteLine("Lista 1");

            //while(x<=15)
            //{
            //    Console.WriteLine("Ingrese los valores de la lista 1");
            //    aux = Console.ReadLine();
            //    valorLista1 = int.Parse(aux);
            //    acum1 = acum1 + valorLista1;


            //    x = x+1;
            //}


            //Console.WriteLine("Lista 2");
            //x = 1;
            //while(x<=15)
            //{
            //    Console.WriteLine("Ingrese los valores de la lista 2");
            //    aux = Console.ReadLine();
            //    valorLista2 = int.Parse(aux);
            //    acum2 = acum2 + valorLista2;

            //    x = x + 1;
            //}

            //if(acum1>acum2)
            //{
            //    Console.Write("Lista 1 mayor");
            //}
            //else
            //{
            //    if(acum2>acum1)
            //    {
            //        Console.Write("Lista 2 mayor");
            //    }
            //    else
            //    {
            //        Console.Write("Lista 1 y 2 iguales");
            //    }
            //}
            //Console.ReadKey();


            ///7)Desarrollar un programa que permita cargar n números enteros y luego nos informe cuántos valores fueron pares y 
            ///cuántos impares.
            // Emplear el operador “%” en la condición de la estructura condicional:

            // if (valor % 2 == 0)         //Si el if da verdadero luego es par.
            //int x = 1;
            //string aux;
            //int cantNum ;
            //int contPar=0;
            //int contImpar=0;
            //int num;

            //Console.WriteLine("Ingrese la cantidad de numeros a cargar");
            //aux = Console.ReadLine();
            //cantNum = int.Parse(aux);
            //while(x<= cantNum)
            //{
            //    Console.WriteLine("Ingrese un numero entero");
            //    aux = Console.ReadLine();
            //    num = int.Parse(aux);

            //    if(num % 2==0)
            //    {
            //        contPar++;
            //    }
            //    else
            //    {
            //        contImpar++;
            //    }
            //    x = x + 1;
            //}
            //Console.WriteLine("La cantidad de numeros pares es: " + contPar+" y la cantidad de numeros impares es: "+contImpar);
            //Console.ReadKey();








        }
    }
}
