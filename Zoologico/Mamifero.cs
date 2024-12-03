using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class Mamifero : Animal
    {
        public Mamifero(string nome, int idade, string alimento)
            : base(nome, idade, alimento)
        { }
            public override string Descrever()
        {
            return base.Descrever() + "Tipo: Mamífero.";
        }
     
    }
}
