using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Aventura_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fase, xp=120, casaco, armadura;
            string userName, codigo = "UNLOCK";

            Console.Write("Escolha um nome: ");
            userName = Console.ReadLine();

            if(userName == codigo)
            {
                Console.WriteLine($"Olá {userName}, seja bem-vindo!");
                Console.WriteLine($"Código secreto aceito!");
                Console.WriteLine("Você chegou à Fortaleza do Boss.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Olá {userName}, seja bem-vindo!");
                Console.Write("Pressione qualquer botão para começar.");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"{userName}, escolha uma fase:\n(1) Floresta Encantada\t(2) Montanha Congelada\t(3) Fortaleza do Boss");
                fase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if(fase == 1)
                {
                    Console.WriteLine("Bem-vindo(a) à Floresta Encantada!");
                    Console.ReadKey();
                }
                else if
                    (fase == 2)
                {
                    Console.WriteLine("Você chegou à Montanha Congelada.");
                    Console.WriteLine($"Para entrar na Montanha Congelada você precisa equipar o 'casaco'.");
                    Console.WriteLine("Você possui o 'casaco'? \n(1)Sim - Equipar 'casaco' \t (0) Não - Sair da Montanha Congelada");
                    casaco = Convert.ToInt32(Console.ReadLine());

                    if (casaco == 1)
                    {
                        Console.WriteLine("Você equipou 'casaco'!");
                        Console.WriteLine("Siga em frente aventureiro.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Volte quando possuir o 'casaco'!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    if (xp > 100)
                    {
                        Console.WriteLine("Você chegou à Fortaleza do Boss!");
                        Console.WriteLine($"Para entrar na Fortaleza do Boss você precisa equipar uma 'armadura'.\n");
                        Console.WriteLine("Você possui uma 'armadura'? \n(1)Sim - Equipar 'armadura' \t (2) Não - Sair da Fortaleza do Boss");
                        armadura = Convert.ToInt32(Console.ReadLine());
                        if (armadura == 1)
                        {
                            Console.WriteLine("Você está pronto para enfrentar o BOSS. Boa sorte!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Saindo da Fortaleza do Boss.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você não possui experiência para acessar a Fortaleza do Boss!");
                        Console.WriteLine("Fique mais forte para tentar novamente!");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
