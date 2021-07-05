using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
         int horasTrabajadas ;
            float costoHoras ;
            float sueldo;
            string texto;
            Console.Write("Ingrese las horas trabajadas por el empleado: ");
            texto = Console.ReadLine();
            horasTrabajadas = Convert.ToInt32( texto);
            Console.Write("Ingrese el pago por hora:  ");
            texto = Console.ReadLine();
            costoHoras = float.Parse(texto);
            sueldo = horasTrabajadas * costoHoras;
            Console.Write("El sueldo total del empleado es: " + sueldo);
            Console.ReadKey();
            



            


        }
    }
}
