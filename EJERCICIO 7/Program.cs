using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumeroEnteroParInpar
{
    class program
    {
        static void Main(string[] args)
        {  

            Console.Write("Introducir numero: ");
            int numero = int.Parse(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.Write("El numero " + numero + " es Par.");
            }
            else
            {
                Console.Write("El numero " + numero + " es Impar.");
            }
            Console.ReadKey();
        }
    }
}