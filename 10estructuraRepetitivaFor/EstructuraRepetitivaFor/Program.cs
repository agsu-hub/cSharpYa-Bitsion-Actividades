using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Problema 1:
            //for (int i = 1; i <= 100; i++)
            //{

            //    Console.Write("-"+i);


            //}
            //Console.ReadKey();



            //Problema 2
            //int i2 = 1;
            //string  aux;
            //int suma = 0;
            //int valor = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine("Ingrese el valor numero "+i2+++":");
            //    aux = Console.ReadLine();
            //    valor = int.Parse(aux);
            //    suma = suma + 1;

            //}
            //Console.Write("la suma de los valores es: " + suma);
            //Console.ReadKey();

            //Problema 3
            //string aux;
            //int nota = 0;
            //int apro = 0;
            //int repro = 0;
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("Ingrese las notas de los alumnos");
            //    aux = Console.ReadLine();
            //    nota = int.Parse(aux);
            //    if (nota >= 7)
            //    {
            //        apro++;
            //    }
            //    else
            //    {
            //        repro++;
            //    }


            //}
            //Console.WriteLine("La cantidad de alumnos aprobados es de: " + apro);
            //Console.WriteLine("La cantidad de alumnos reprobados: " + repro);
            //Console.ReadKey();

            ////Problema 4
            //string aux;
            //int num = 0;
            //int m3 = 0;
            //int m5 = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Ingrese un valor ");
            //    aux = Console.ReadLine();
            //    num = int.Parse(aux);
            //    if (num %5==0)
            //    {
            //        m5++;
            //    }

            //    if (num %3==0)
            //    {
            //         m3++;
            //    }




            //}
            //Console.WriteLine("La cantidad de numeros ingresados divisibles por 5 es de: " + m5);
            //Console.WriteLine("La cantidad de numeros ingresados divisibles por 3 es de: " + m3);
            //Console.ReadKey();





            //Problema 5

            //string aux;
            //int valor,num;
            //int cont = 0;
            //Console.WriteLine("Ingrese un valor ");
            //aux = Console.ReadLine();
            //valor = int.Parse(aux);
            //for (int i = 1; i <= valor; i++)
            //{
            //    Console.WriteLine("Ingrese un numero ");
            //    aux = Console.ReadLine();
            //    num = int.Parse(aux);
            //    if (num >= 1000)
            //    {
            //        cont++;
            //    }


            //}
            //Console.WriteLine("La cantidad de valores mayores o iguales a 1000 es: " + cont);
            //Console.ReadKey();


            //Problemas propuestos
            //1) Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la medida de
            //la base y la altura de un triángulo. El programa deberá informar:
            //  a) De cada triángulo la medida de su base, su altura y su superficie.
            // b) La cantidad de triángulos cuya superficie es mayor a 12.

            //string aux;
            //int cant, baseTriang, altura;
            //double superficie;
            //Console.WriteLine("Ingrese la cantidad de triangulos a analizar: ");
            //aux = Console.ReadLine();
            //cant = int.Parse(aux);
            //int supMayorA12 = 0;
            //for (int i = 1; i <= cant; i++)
            //{
            //    Console.WriteLine("Ingrese la base ");
            //    aux = Console.ReadLine();
            //    baseTriang = int.Parse(aux);
            //    Console.WriteLine("Ingrese la altura ");
            //    aux = Console.ReadLine();
            //    altura = int.Parse(aux);

            //    superficie = baseTriang * altura/2;

            //    if (superficie > 12)
            //    {
            //        supMayorA12++;
            //    }



            //}
            //Console.WriteLine("La cantidad de triangulos con superficie mayor a 12 es: " + supMayorA12);
            //Console.ReadKey();

            //2) Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados. 


            //string aux;
            //int cont, num;
            //int acum = 0;
            //Console.WriteLine("Ingrese 10 numeros");
            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine(" ingrese un numero: ");
            //    aux = Console.ReadLine();
            //    num = int.Parse(aux);

            //    if(i>=6)
            //    {
            //        acum = acum + num;
            //    }


            //}

            //Console.WriteLine("El valor de la suma de los ultimos 5 numeros ingresados es: " + acum);
            //Console.ReadKey();



            //3) Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50) 





            //for (int i = 5; i <= 50;i= i+5)
            //{

            //    Console.WriteLine(" - "+i);




            //}


            //Console.ReadKey();

            //4) Confeccionar un programa que permita ingresar un valor del 1 al 10 y
            //nos muestre la tabla de multiplicar del mismo (los primeros 13 términos)
            // Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.


            //string aux;
            //int valor;
            //Console.WriteLine("Ingrese un valor del 1 al 10");
            //aux=Console.ReadLine();
            //valor = int.Parse(aux);

            //for (int i = valor; i <=valor*13;i= i+valor)
            //{

            //    Console.WriteLine(" - " + i);




            //}


            //Console.ReadKey();


            //5)  Realizar un programa que lea los lados de n triángulos, e informar:
            // a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados iguales),
            // isósceles(dos lados iguales), o escaleno(ningún lado igual)
            //     b) Cantidad de triángulos de cada tipo.
            //c) Tipo de triángulo que posee menor cantidad.



            //string aux;
            //int cant, contEqui=0,contIso=0,contEsca=0,lado1,lado2,lado3,contMenor=0;

            //Console.WriteLine("Ingrese la cantidad de triangulos a analizar: ");
            //aux = Console.ReadLine();
            //cant = int.Parse(aux);

            //for (int i = 1; i <= cant; i++)
            //{
            //    Console.WriteLine("Ingrese el valor del lado1: ");
            //    aux = Console.ReadLine();
            //    lado1 = int.Parse(aux);
            //    Console.WriteLine("Ingrese el valor del lado2: ");
            //    aux = Console.ReadLine();
            //    lado2 = int.Parse(aux);
            //    Console.WriteLine("Ingrese el valor del lado3: ");
            //    aux = Console.ReadLine();
            //    lado3 = int.Parse(aux);

            //    if(lado1==lado2 && lado1==lado3)
            //    {
            //        contEqui++;
            //    }
            //    else
            //    {
            //        if(lado1==lado2 || lado1==lado3 || lado2==lado3)
            //        {
            //            contIso++;
            //        }
            //        else
            //        {
            //            contEsca++;
            //        }
            //    }





            //}
            //Console.WriteLine("La cantidad de triangulos equilateros es: " + contEqui);
            //Console.WriteLine("La cantidad de triangulos isosceles es: " + contIso);
            //Console.WriteLine("La cantidad de triangulos Escalenos es: " + contEsca);
            //if (contEqui < contEsca && contEqui < contIso)
            //{
            //    Console.WriteLine("Hay menor cantidad de triangulos escalenos");
            //}
            //else
            //{
            //    if(contIso<contEsca && contIso<contEqui)
            //    {
            //        Console.WriteLine("Hay menor cantidad de triangulos isosceles");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hay menor cantidad de triangulos escalenos");
            //    }
            //}
            //Console.ReadKey();

            //6) Escribir un programa que pida ingresar coordenadas (x,y) que representan puntos en el plano.
            // Informar cuántos puntos se han ingresado en el primer, segundo, tercer y cuarto cuadrante. 
            //    Al comenzar el programa se pide que se ingrese la cantidad de puntos a procesar.





            //string aux;
            //int cant, cont1 = 0, cont2 = 0, cont3 = 0, cont4=0, x, y;

            //Console.WriteLine("Ingrese la cantidad de puntos a procesar: ");
            //aux = Console.ReadLine();
            //cant = int.Parse(aux);

            //for (int i = 1; i <= cant; i++)
            //{
            //    Console.WriteLine("Ingrese el valor del punto x: ");
            //    aux = Console.ReadLine();
            //    x = int.Parse(aux);
            //    Console.WriteLine("Ingrese el valor del punto y: ");
            //    aux = Console.ReadLine();
            //    y = int.Parse(aux);

            //    if (x>0 && y>0)
            //    {
            //        cont1++;
            //    }
            //    else
            //    {
            //        if (x<0 && y>0)
            //        {
            //            cont2++;
            //        }
            //        else
            //        {
            //            if(x<0 && y>0)
            //            {
            //                cont3++;
            //            }
            //            else
            //            {
            //                cont4++;
            //            }
            //        }
            //    }





            //}

            //Console.WriteLine("la cantidad de puntos ingresados en el 1 cuadrante es : "+cont1);
            //Console.WriteLine("la cantidad de puntos ingresados en el 2 cuadrante es : " + cont2);
            //Console.WriteLine("la cantidad de puntos ingresados en el 3 cuadrante es : " + cont3);
            //Console.WriteLine("la cantidad de puntos ingresados en el 4 cuadrante es : " + cont4);
            //Console.ReadKey();

            //6) Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            //  a) La cantidad de valores ingresados negativos.
            //b) La cantidad de valores ingresados positivos.
            //c) La cantidad de múltiplos de 15.
            //d) El valor acumulado de los números ingresados que son pares. 


            //string aux;
            //int num;
            //int contNeg = 0, contPos = 0, contM15 = 0, acumX2 = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Ingrese un valor");
            //    aux = Console.ReadLine();
            //    num = int.Parse(aux);

            //    if(num <=-1)
            //    {
            //        contNeg++;
            //    }
            //    else
            //    {
            //        contPos++;
            //    }
            //    if(num %15==0)
            //    {
            //        contM15++;
            //    }
            //    if(num %2==0)
            //    {
            //        acumX2 = acumX2 + num;
            //    }

            //}

            //Console.WriteLine("La cantidad de numeros negativos es: " + contNeg);
            //Console.WriteLine("La cantidad de numeros positivos es: " + contPos);
            //Console.WriteLine("La cantidad de numeros multiplos de 15 es: " + contM15);
            //Console.WriteLine("el acumulado de los numeros pares es: " + acumX2);
            //Console.ReadKey();

            //8)

            //string aux;
            //int contTM = 0, contTT = 0, contTN = 0, acumTM = 0, acuTT = 0, acuTN = 0;
            //double prom1=0,prom2=0,prom3=0;
            //int edad;
            //Console.WriteLine("Alumnos turno mañana");
            //for (int i = 0; i < 50; i++)
            //{

            //    Console.WriteLine("Ingrese la edad del alumno");
            //    aux = Console.ReadLine();
            //   edad = int.Parse(aux);
            //    acumTM = acumTM + edad;
            //    contTM ++;
            //}
            //prom1 = acumTM / contTM;
            //Console.WriteLine("Alumnos turno tarde");
            //for (int i = 0; i < 60; i++)
            //{

            //    Console.WriteLine("Ingrese la edad del alumno");
            //    aux = Console.ReadLine();
            //    edad = int.Parse(aux);
            //    acuTT = acuTT + edad;
            //    contTT++;
            //}
            //prom2 = acuTT / contTT;
            //Console.WriteLine("Alumnos turno noche");
            //for (int i = 0; i < 110; i++)
            //{

            //    Console.WriteLine("Ingrese la edad del alumno");
            //    aux = Console.ReadLine();
            //    edad = int.Parse(aux);
            //    acuTN = acuTN + edad;
            //    contTN++;
            //}
            //prom3 = acuTN / contTN;

            //Console.WriteLine("El promedio de edad del tuno mañana es  de: " + prom1);
            //Console.WriteLine("El promedio de edad del tuno tarde es  de: " + prom2);
            //Console.WriteLine("El promedio de edad del tuno noche es  de: " + prom3);

            //if(prom1 < prom2 && prom1<prom3)
            //{
            //    Console.WriteLine("El turno mañana tiene un promedio de edades menor.");
            //}
            //else
            //{
            //    if(prom2<prom1 && prom2<prom3)
            //    {
            //        Console.WriteLine("El turno tarde tiene un promedio de edades menor.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El turno noche tiene un promedio de edades menor.");
            //    }
            //}


            //Console.ReadKey();
        }
    }
}
