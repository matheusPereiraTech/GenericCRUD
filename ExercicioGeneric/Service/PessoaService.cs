using ExercicioGeneric.Domain.Entidade;
using ExercicioGeneric.Interface.Repositorio;
using ExercicioGeneric.Interface.Servico;
using ExercicioGeneric.Repositorio;
using ExercicioGeneric.Services;


namespace ExercicioGeneric.Servico
{
    internal sealed class PessoaService : BaseService<Pessoa>, IPessoaService
    {
        public PessoaService(IPessoaRepository pessoaRepository) : base(pessoaRepository)
        {
        }


        public void ValidarListaVazia(List<Pessoa> pessoas)
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Lista vazia");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\n");
            }
        }

        public bool ValidarPessoaEncontrada(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Usuário não encontrado");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\n");

                return true;
            }

            return false;
        }
    }
}
