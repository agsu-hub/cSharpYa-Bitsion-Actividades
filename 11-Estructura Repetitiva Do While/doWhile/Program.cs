using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {


            //Problema 1 : Escribir un programa que solicite la carga de un número entre 0 y 999,
            //y nos muestre un mensaje de cuántos dígitos tiene el mismo.
            //Finalizar el programa cuando se cargue el valor 0.


            //int valor;
            //string aux;

            //do
            //{
            //    Console.WriteLine("Ingrese un valor: ");
            //    aux = Console.ReadLine();
            //    valor = int.Parse(aux);

            //    if(valor < 10)
            //    {
            //        Console.WriteLine("El valor ingresado es de 1 digito");
            //    }
            //    else
            //    {
            //        if(valor>=10 && valor <= 99 )
            //        {
            //            Console.WriteLine("El valor ingresado es de 2 digitos");
            //        }
            //        else
            //        {
            //            Console.WriteLine("El valro ingresado es de 3 digitos o mas");
            //        }
            //    }


            //} while (valor != 0);
            //Console.ReadKey();

            //Problema 2 : Escribir un programa que solicite la carga de números por teclado, obtener su promedio.
            //Finalizar la carga de valores cuando se cargue el valor 0.




            //int valor;
            //int cont=0;
            //int acum=0;
            //string aux;
            //double prom=0;

            //do
            //{
            //    Console.WriteLine("Ingrese un valor: ");
            //    aux = Console.ReadLine();
            //    valor = int.Parse(aux);

            //    if (valor != 0)
            //    {
            //        cont++;
            //        acum = acum + valor;
            //        prom = acum / cont;
            //    }




            //} while (valor != 0);
            //Console.WriteLine("El promedio es: " + prom);
            //Console.ReadKey();


            //Problema 3 : Realizar un programa que permita ingresar el peso (en kilogramos) de piezas.
            //El proceso termina cuando ingresamos el valor 0. Se debe informar:
            // a) Cuántas piezas tienen un peso entre 9.8 Kg.y 10.2 Kg.?, cuántas con más de 10.2 Kg.? y cuántas con menos de 9.8 Kg.?
            /// b) La cantidad total de piezas procesadas. 

            //int peso;

            //int contPiezas = 0,cont1=0,cont2=0,cont3=0;

            //string aux;


            //do
            //{
            //    Console.WriteLine("Ingrese el peso de las piezas: ");
            //    aux = Console.ReadLine();
            //    peso = int.Parse(aux);

            //    if (peso != 0)
            //    {
            //        contPiezas++;

            //    }
            //    if(peso<=10.2 && peso>= 9.8)
            //    {
            //        cont1++;

            //    }
            //     if(peso > 10.2)
            //        {
            //            cont2++;
            //        }
            //    if (peso <9.8)
            //    {
            //        cont3++;
            //    }





            //} while (peso != 0);
            //Console.WriteLine("la cantidad de piezas con un peso entre 9.8kg y 10.2 es de: " + cont1);
            //Console.WriteLine("la cantidad de piezas con un peso de mas de 10.2kg es de: " + cont2);
            //Console.WriteLine("la cantidad de piezas con un peso de menos de 9.8kg es de: " + (cont3-1));

            //Console.WriteLine("la cantidad de piezas totales es de: " + contPiezas);

            //Console.ReadKey();

            //Problema propuestos
            //1)Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999
            //(no sumar dicho valor, indica que ha finalizado la carga).
            //Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero


            //int valor;
            //int cont = 0;
            //int acum = 0;
            //string aux;
            //double prom = 0;

            //do
            //{
            //    Console.WriteLine("Ingrese un valor: ");
            //    aux = Console.ReadLine();
            //    valor = int.Parse(aux);

            //    if (valor != 9999)
            //    {

            //        acum = acum + valor;

            //    }

            //} while (valor != 9999);
            //if (acum < 0) { 
            //    Console.WriteLine($"El valor acumulado es {acum} que es menor a cero");

            //}
            //else
            //{
            //    if(acum == 0)
            //    {
            //        Console.WriteLine($"El valor acumulado es {acum} que es igual a cero");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El valor acumulado es {acum} que es mayor a cero");
            //    }
            //}

            //Console.ReadKey();


            //2)En un banco se procesan datos de las cuentas corrientes de sus clientes.
            //De cada cuenta corriente se conoce: número de cuenta y saldo actual.
            //El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.
            //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
            // a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:

            // Estado de la cuenta 'Acreedor' si el saldo es > 0.

            //'Deudor' si el saldo es<0.

            //'Nulo' si el saldo es = 0.

            //// b) La suma total de los saldos acreedores.


            //int cuenta;
            //int saldo = 0;
            //int acum = 0;
            //string aux;
            //double prom = 0;

            //do
            //{

            //    Console.Write("Ingrese número de cuenta:");
            //    aux = Console.ReadLine();
            //    cuenta = int.Parse(aux);
            //    if (cuenta >= 0)
            //    {
            //        Console.WriteLine("Ingrese el saldo de la cuenta: ");
            //        aux = Console.ReadLine();
            //        saldo = int.Parse(aux);

            //        if (saldo > 0)
            //        {
            //            Console.WriteLine("El saldo es acreedor ");
            //            acum = acum + saldo;

            //        }
            //        else
            //        {
            //            if (saldo < 0)
            //            {
            //                Console.WriteLine("El saldo de la cuenta es deudor");
            //            }
            //            else
            //            {
            //                Console.WriteLine("El saldo de la cuenta es igual a cero");
            //            }
            //        }
            //    }
            //} while (cuenta >0);
           
            //Console.WriteLine($"El valor acumulado de las cuentas acreedoras es {acum}");
            // Console.ReadKey();




        }
    }
}
