using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PrimeiraClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Construtor que cria um objeto do tipo Mensagem
            Mensagem msg1 = new Mensagem();
            msg1.textoMensagem = "Primeira Classe!";
            msg1.ExibirMensagem();

            Mensagem msg2 = new Mensagem();
            msg2.textoMensagem = "Segunda mensagem...";
            msg2.ExibirMensagem();

            Console.ReadKey();
        }
    }
}
