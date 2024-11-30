using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando uma conta bancária
            ContaBancaria conta = new ContaBancaria("Jefferson José Jeremeias", 1000.00m);

            // Exibindo informações inciais
            Console.WriteLine($"Bem vindo(a), {conta.Titutlar}");

            conta.ExibirSaldo();

            int escolha;

            do
            {
                ExibirMenu();
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.Write("Digite o valor de depósito: ");
                        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());
                        conta.Depositar(valorDeposito);
                        break;
                    case 2:
                        Console.Write("Digite o valor do saque: ");
                        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());
                        conta.Sacar(valorSaque);
                        break;
                    case 3:
                        conta.ExibirSaldo();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"Bem vindo(a), {conta.Titutlar}");
                        break;
                    case 5:
                        Console.WriteLine($"Obrifgado por usar osistema do POOBank");
                        break;
                    default:
                        Console.WriteLine("opção inválida!");
                        break;
                }
            }
            while (escolha != 5);
            
            Console.ReadKey();
        }

        public static void ExibirMenu()
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Exibir Saldo");
            Console.WriteLine("4 - Reiniciar");
            Console.WriteLine("5 - Sair");
         }
    }
}
