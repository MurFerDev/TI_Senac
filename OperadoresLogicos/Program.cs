

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Lógi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            bool autorizacao;
            double propina = 100.00, carteira = 0;

            Console.WriteLine("Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Possui CNH? (0 - NÃO  ||  1 - SIM)");
            autorizacao = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

            if(idade < 18 && autorizacao)
            {
                autorizacao = false;
            }

            if (idade >= 18 && autorizacao)
            {
                //Executa o código se as duas condições forem verdadeiras
                Console.WriteLine("Está liberado!");
            }

            else
            {
                if (idade < 18 && !autorizacao)
                {
                    Console.WriteLine("Informe o telefone de seus pais ou responsáveis!");
                }
                else if (idade > 18 && !autorizacao)
                {
                    Console.WriteLine($"Pague um cafézinho... \n Insira um valor:");
                    carteira = Convert.ToDouble(Console.ReadLine());

                    if (carteira < propina)
                    {
                        Console.WriteLine("Não é suficiente. Desça do veículo!");
                    }
                    else
                    {
                        Console.WriteLine("Boa viagem!");
                    }
                }
                else
                {
                    Console.WriteLine("Desça do veículo!");
                }
            }
            Console.ReadKey(); 
        }
    }
}
