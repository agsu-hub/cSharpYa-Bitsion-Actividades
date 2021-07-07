using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionesCompuestas
{
    class Program
    {
        static void Main(string[] args)
        {


            //string aux;
            //int dia, mes, anio;
            //Console.WriteLine("Ingrese el dia");
            //aux = Console.ReadLine();
            //dia = int.Parse(aux);
            //Console.WriteLine("Ingrese el mes");
            //aux = Console.ReadLine();
            //mes = int.Parse(aux);
            //Console.WriteLine("Ingrese el año");
            //aux = Console.ReadLine();
            //anio = int.Parse(aux);
            //if(mes==1 || mes==2 || mes==3)
            //{
            //    Console.Write("La fecha ingresada corresponde al primer trimestre del año");
            //}
            //else
            //{
            //    if(mes>3 && mes<7)
            //    {
            //        Console.Write("La fecha ingresada corresponde al segundo trimestre del año");
            //    }
            //    else
            //    {
            //        Console.Write("no interesa");
            //    }
            //}
            //Console.ReadKey();


            //1)Realizar un programa que pida cargar una fecha cualquiera,
            //luego verificar si dicha fecha corresponde a Navidad.
            //
            //string aux;
            //int dia, mes, anio;
            //Console.WriteLine("Ingrese el dia");
            //aux = Console.ReadLine();
            //dia = int.Parse(aux);
            //Console.WriteLine("Ingrese el mes");
            //aux = Console.ReadLine();
            //mes = int.Parse(aux);
            //Console.WriteLine("Ingrese el año");
            //aux = Console.ReadLine();
            //anio = int.Parse(aux);
            //if (mes == 12 && dia==25)
            //{
            //    Console.Write("La fecha ingresada corresponde navidad");
            //}
            //Console.ReadKey();



            //2)Se ingresan tres valores por teclado,
            //si todos son iguales se imprime la suma del primero con el segundo y
            //a este resultado se lo multiplica por el tercero. 


            //string aux;
            //int num1, num2, num3,suma,producto;
            //Console.WriteLine("Ingrese el primer numero: ");
            //aux = Console.ReadLine();
            //num1 = int.Parse(aux);
            //Console.WriteLine("Ingrese el segundo numero: ");
            //aux = Console.ReadLine();
            //num2 = int.Parse(aux);
            //Console.WriteLine("Ingrese el tercer numero: ");
            //aux = Console.ReadLine();
            //num3 = int.Parse(aux);

            //if(num1==num2 && num2==num3)
            //{
            //    suma = num1 + num2;
            //    producto = suma * num3;
            //    Console.Write("Suma de los dos primeros: " + suma + " producto de la suma por el tercer numero: " + producto);
            //}
            //else
            //{
            //    Console.Write("Error ingrese de nuevo los numeros");
            //}
            //Console.ReadKey();

            //3)Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10,
            //imprimir en pantalla la leyenda "Todos los números son menores a diez". 


            //string aux;
            //int num1, num2, num3;
            //Console.WriteLine("Ingrese el primer numero: ");
            //aux = Console.ReadLine();
            //num1 = int.Parse(aux);
            //Console.WriteLine("Ingrese el segundo numero: ");
            //aux = Console.ReadLine();
            //num2 = int.Parse(aux);
            //Console.WriteLine("Ingrese el tercer numero: ");
            //aux = Console.ReadLine();
            //num3 = int.Parse(aux);

            //if (num1<10 && num2<10 && num3<10)
            //{

            //    Console.Write("Todos los numeros ingresados son menores a diez ");
            //}

            //Console.ReadKey();


            //4)Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10,
            //imprimir en pantalla la leyenda "Alguno de los números es menor a diez". 


            //string aux;
            //int num1, num2, num3;
            //Console.WriteLine("Ingrese el primer numero: ");
            //aux = Console.ReadLine();
            //num1 = int.Parse(aux);
            //Console.WriteLine("Ingrese el segundo numero: ");
            //aux = Console.ReadLine();
            //num2 = int.Parse(aux);
            //Console.WriteLine("Ingrese el tercer numero: ");
            //aux = Console.ReadLine();
            //num3 = int.Parse(aux);

            //if (num1 < 10 || num2 < 10 || num3 < 10)
            //{

            //    Console.Write("Alguno de los numeros ingresados es menor a diez ");
            //}

            //Console.ReadKey();



            //5)Escribir un programa que pida ingresar la coordenada de un punto en el plano,
            //es decir dos valores enteros x e y (distintos a cero).
            // Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto.
            // (1º Cuadrante si x > 0 Y y > 0, 2º Cuadrante: x < 0 Y y > 0, etc.)



            // string aux;
            // int x, y;
            // Console.WriteLine("Ingrese coordenada x: ");
            // aux = Console.ReadLine();
            // x = int.Parse(aux);
            // Console.WriteLine("Ingrese coordenada y: ");
            // aux = Console.ReadLine();
            // y = int.Parse(aux);
            //if(x>0 && y >0)
            // {
            //     Console.Write("las coordenadas ingresadas pertenecen al primer cuadrante");
            // }
            //else
            // {
            //     if(x<0 && y>0)
            //     {
            //         Console.Write("las coordenadas ingresadas pertenecen al segundo cuadrante");
            //     }
            //     else
            //         if(x<0 && y<0)
            //     {
            //         Console.Write("las coordenadas ingresadas pertenecen al tercer cuadrante");
            //     }
            //     else
            //     {
            //         Console.Write("las coordenadas ingresadas pertenecen al cuarto cuadrante");
            //     }
            // }

            // Console.ReadKey();


            //6)De un operario se conoce su sueldo y los años de antigüedad.
            //Se pide confeccionar un programa que lea los datos de entrada e informe:
            //a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años,
            //    otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
            //b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
            //c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.


            // string aux;
            // double sueldo, antiguedad;
            // Console.WriteLine("Ingrese el sueldo del operario: ");
            // aux = Console.ReadLine();
            //sueldo= int.Parse(aux);
            // Console.WriteLine("Ingrese la antiguedad del operario: ");
            // aux = Console.ReadLine();
            // antiguedad = int.Parse(aux);

            // if(sueldo<500 && antiguedad>=10)
            // {
            //     sueldo = sueldo * 1.2;
            //     Console.Write("el sueldo a pagar es de : "+sueldo);
            // }

            // else
            // {
            //     if(sueldo<500 && antiguedad<10)
            //     {
            //         sueldo = sueldo * 1.05;
            //         Console.Write("el sueldo a pagar es de : " + sueldo);
            //     }
            //     else
            //     {
            //         Console.Write("el sueldo a pagar es de : " + sueldo);
            //     }
            // }

            // Console.ReadKey();




            //7)Escribir un programa en el cual: dada una lista de tres valores numéricos distintos se
            //calcule e informe su rango de variación
            //(debe mostrar el mayor y el menor de ellos) 

            //int num1, num2, num3;
            //string linea;
            //Console.Write("Ingrese primer valor:");
            //linea = Console.ReadLine();
            //num1 = int.Parse(linea);
            //Console.Write("Ingrese segundo valor:");
            //linea = Console.ReadLine();
            //num2 = int.Parse(linea);
            //Console.Write("Ingrese tercer valor:");
            //linea = Console.ReadLine();
            //num3 = int.Parse(linea);
            //Console.Write("Rango de valores:");
            //if (num1 < num2 && num1 < num3)
            //{
            //    Console.Write(num1);
            //}
            //else
            //{
            //    if (num2 < num3)
            //    {
            //        Console.Write(num2);
            //    }
            //    else
            //    {
            //        Console.Write(num3);
            //    }
            //}
            //Console.Write("-");
            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.Write(num1);
            //}
            //else
            //{
            //    if (num2 > num3)
            //    {
            //        Console.Write(num2);
            //    }
            //    else
            //    {
            //        Console.Write(num3);
            //    }
            //}
            //Console.ReadKey();





        }
    }
}
