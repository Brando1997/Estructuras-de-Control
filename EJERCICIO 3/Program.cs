using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumeroEntero
{
    class program
    {
        static void Main(string[] args)
        {  
            int valor;
            string linea;
            do{
                Console.Write("Ingrese un valor de 1, 2 o 3 digitos (4 error):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                 if (valor>=1000)
                    {
                        Console.WriteLine("Error.");
                    }
                else
                {
                if(valor>=100)
                {
                    Console.WriteLine("Tiene 3 digitos.");
                }
                else
                {
                    if (valor>=10)
                    {
                        Console.WriteLine("Tiene 2 digitos.");
                    }
                    else
                    {
                        Console.WriteLine("Tiene 1 digito.");
                    }
                }
                }
        } while (valor!=0);
        }
    }
}