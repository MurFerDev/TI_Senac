using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class ContaBancaria
    {
        // Propriedades da conta
        public string Titutlar { get; private set; }

        private decimal _saldo;

        // Construtor da conta
        public ContaBancaria(string titutlar, decimal saldoinicial)
        {
            Titutlar = titutlar;
            _saldo = saldoinicial;
        }

        // Métodos da conta
        public void ExibirSaldo()
        {
            Console.WriteLine($"\nSaldo atual: R$ {_saldo:F2}");
        }

        public void Depositar(decimal valor)
        {
            _saldo += valor;
            Console.WriteLine($"\nR$ {valor:F2} depositado com sucesso!");
            ExibirSaldo();
        }

        public void Sacar(decimal retirada)
        {
            if (retirada > _saldo)
            {
                Console.WriteLine($"\nSaldo insuficiente!\nValor solicitado é maior que o saldo disponível.");
            }
            else if (retirada == 0)
            {
                Console.WriteLine("\nNenhum valor foi digitado. Operação cancelada.");
            }
            else
            {
                _saldo -= retirada;
                Console.WriteLine($"\nSaque efetuado com sucesso! Você sacou R$ {retirada:F2}.");
                ExibirSaldo();
            }
        }
    }
}
