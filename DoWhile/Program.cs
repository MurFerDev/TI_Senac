using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frasesInicioDia =
                {
                "Hoje é o seu dia! Faça valer a pena!",
                "Comoce o dia o um sorriso e tudo será diferente!",
                "Parece um bom dia para recomeçar",
                "É um novo dia, beba água e seja gentil!",
                "Bom dia, flor do dia!!"
            };

            string[] frasesTreino =
               {
                "Tá pago! Se não postar, não cresce...",
                "No pain, no gain!",
                "Treine enquanto eles trabalham",
                "Ela não será esquecida sem treino",
                "As pessoas veêm músculo e não coração",
                "O que cresce natural é planta"
            };

            string[] frasesTrabalho =
            {
                "Boletos não se pagam sozinhos...",
                "Acredite em seu potencial e faça o melhor!",
                "O décimo terceiro vem aí...",
                "Sextou! Só mais hoje...",
                "Tome um café, respire e vamos lá!"
            };

            Random random = new Random();

            int opcao = 0;

            do
            {
                Console.WriteLine("Escolha o tipo de mensagem motivacional");
                Console.WriteLine("1 - Iniciar o dia\n2 - Treinar\n3 - Trabalhar\n4 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        int indiceInicioDia = random.Next(frasesInicioDia.Length);
                        Console.WriteLine("\nMensagem: " + frasesInicioDia[indiceInicioDia]);
                        break;
                    case 2:
                        int indiceTreino = random.Next(frasesTreino.Length);
                        Console.WriteLine("\nMensagem: " + frasesTreino[indiceTreino]);
                        break;
                    case 3:
                        int indiceTrabalho = random.Next(frasesTrabalho.Length);
                        Console.WriteLine("\nMensagem: " + frasesTrabalho[indiceTrabalho]);
                        break;
                    case 4:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 4);
        }
    }
}