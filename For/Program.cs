using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cores = { "Vermelho", "Verde", "Azul", "Amarelo" };

            for (int i = 0; i < cores.Length; i++)
            {
                Console.WriteLine("Cor: " + (i+1) + " " + cores[i]);
            }
        }
    }
}
