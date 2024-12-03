using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Reptil : Animal
    {
        private bool Venenoso; // Atributo específico do reptiliano

        public Reptil(string nome, int idade, string alimento, bool venenoso)
            : base(nome, idade, alimento)
        {
            Venenoso = venenoso;
        }

        // Sobrescreve o método da classe pai
        public override string Descrever()
        {
            return base.Descrever() + $"É venenoso: {(Venenoso ? "Sim" : "Não")}.";
        }
    }
}
