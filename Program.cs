using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_nuevo_proyecto_commit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumar dos numeros");
            int a, b, x;
            Console.WriteLine("ingrese el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());
            x = a + b;
            Console.Write($"la suma de los dos numeros es: {x}");
            
            
        }
    }
}
