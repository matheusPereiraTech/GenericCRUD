
namespace ExercicioGeneric.Domain.Entidade
{
    internal class Pessoa : EntityBase
    {

        public string Nome { get; set; }
        public string Idade { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string idade)
        {

            Nome = nome;
            Idade = idade;
        }
        public override string ToString()
        {
            {
                return $" ID:{Id}\n Nome:{Nome}\n Idade:{Idade}";
            }
        }
    }
}

