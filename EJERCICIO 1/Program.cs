using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerimetroCuadrado
{
    class program
    {
        static void Main(string[] args)
        {   
            

            Console.Write("Ingrese la medida de lado del cuadrado");
            double lado = int.Parse(Console.ReadLine());
            double perimetro = lado * 4;
            Console.Write("El perimetro del cuadrado es: " + perimetro + "");
            Console.ReadKey();
        }
    }
}

