using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresRelacionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1 > 0 " + (1 > 0));      // > Maior
            Console.WriteLine(" 2 < 3 " + (2 < 3));      // < Menor
            Console.WriteLine(" 4 == 4 " + (4 == 4));    // == Igual
            Console.WriteLine(" 5 <= 6 " + (5 <= 6));    // <= Maior ou Igual
            Console.WriteLine(" 7 >= 8 " + (7 >= 8));    // >= Menor ou Igual
            Console.WriteLine(" 9 != 10 " + (9 != 10));  // != Diferente

             Console.ReadKey();
        }
    }
}
