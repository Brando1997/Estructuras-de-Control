using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumeroMultiplo
{
    class program
    {
        static void Main(string[] args)
        {  

            for(int i = 8;i <= 500; i++)
                if(i % 8 == 0)
                    Console.WriteLine("Los multiplos de 8 hasta 500 son ==> " + i + "");
                
                    Console.ReadKey();

        }
    }
}