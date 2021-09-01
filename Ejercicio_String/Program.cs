using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre, Ciudad;
            Console.WriteLine("Escribre tu nombre:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribre tu ciudad");
            Ciudad = Console.ReadLine();
            Console.WriteLine("Hola "+ Nombre +"Bienvenido a " +Ciudad);
            Console.WriteLine("Preciona cualquier tecla");
            Console.ReadKey();  

        }
    }
}
