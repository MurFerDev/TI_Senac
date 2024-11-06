using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meuNome, meuCurso;
            int anoAtual = DateTime.Now.Year;
            int anoNascimento, idade;
            double altura;
            //bool residenteSalto = true;

            Console.WriteLine("----- Ficha do Estudante Senac -----");

            Console.WriteLine("Digite seu nome para cadastro no Senac");
            meuNome = Console.ReadLine();
            Console.WriteLine($"Seja bem-vindo {meuNome}");
            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sua idade é: {idade}");
            Console.WriteLine("Digite sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Sua altura é: {altura}");
            Console.WriteLine("Qual curso deseja se inscrever:");
            meuCurso = (Console.ReadLine());
            Console.WriteLine("Em que ano você nasceu? ");
            anoNascimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Você tem: {anoAtual - anoNascimento} anos de idade");

            Console.ReadKey();
        }
    }
}
