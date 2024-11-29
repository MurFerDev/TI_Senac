using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PrimeiraClasse
{
    internal class Mensagem
    {
        public string textoMensagem;

        public void ExibirMensagem()
        {
            Console.WriteLine(this.textoMensagem);
        }
    }
}
