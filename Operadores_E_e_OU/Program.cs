using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_E_e_OU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool convite = false;
            bool permissao = false;

            if (convite || permissao)
            {
                Console.WriteLine("Seja bem-vindo!");
            }
            else {
                Console.WriteLine("Você não pode entrar");
            }

            Console.ReadKey();
        }
    }
}
