using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Ave : Animal
    {
        private bool PodeVoar;

        public Ave(string nome, int idade, string alimento, bool podeVoar)
            : base(nome,idade,alimento) // Chama o construtor da classe base
        {
            PodeVoar = podeVoar; // Inicaliza o atributo específico
        }

        // Sobrescrever o método Descrever para adicionar informações específicas
        public override string Descrever()
        {
            return base.Descrever() + $"Pode voar: {(PodeVoar ? "Sim" : "Não")},";
        }
        
    }

}

