using System;

namespace POO_JogoDePersonagens
{
    public class Personagem
    {
        // propriedades que definem Estado/Característica do objeto

        public string Nome { get; set; } // Por ser público permite o acesso e edição através do get/set

        private int _vida; // Queremos ter mais controle, por isso é privado. Usaremos um setter personalizado
        // Encapsulamento da propriedade vida para controle do seu valor
        public int vida
        {
            get { return _vida; }
            set
            {
                if (value < 0)
                {
                    _vida = 0;
                }
                else
                {
                    _vida = (int)value;
                }
            }
        }

        //Construtor que é chamado automaticamente quando criamos uma instância da classe
        public Personagem(string nome, int vida)
        {
            Nome = nome;
            _vida = vida;
        }

        // Método Atacar: é uma ação que o objeto pode fazer
        public virtual void Atacar()
        {
            Console.WriteLine($"{Nome} atacou com força bruta");
        }// O método é virtual, ou seja, pode ser modificado nas classes que herdam de Personagem

        public void MostrarVida()
        {
            Console.WriteLine($"{Nome} tem {_vida} de vida");
        }

    }
}
