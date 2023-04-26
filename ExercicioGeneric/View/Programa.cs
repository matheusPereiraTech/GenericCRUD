using ExercicioGeneric.Domain.Entidade;
using ExercicioGeneric.Interface.Repositorio;
using ExercicioGeneric.Interface.Servico;
using ExercicioGeneric.Repositorio;
using ExercicioGeneric.Services;
using ExercicioGeneric.Servico;
using Microsoft.Extensions.DependencyInjection;

namespace ExercicioGeneric.View
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            var provider = BuildServiceProvider();
            var pessoaService = provider.GetService<IPessoaService>();



            while (true)
            {

                switch (Menu())
                {
                    case 1:
                        AdicionarPessoa(pessoaService);
                        break;

                    case 2:
                        MostrarPessoas(pessoaService);
                        break;

                    case 3:
                        RemoverPessoa(pessoaService);
                        break;
                    case 4:
                        AtualizarPessoa(pessoaService);
                        break;

                    case 5:
                        Console.WriteLine("Programa Finalizado!!!");
                        return;
                    default:
                        break;
                }

            }
        }

        private static IServiceProvider BuildServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            return services.BuildServiceProvider();
        }

        private static int Menu()
        {
            Console.WriteLine("---------------MENU-----------------");
            Console.WriteLine("Cadastrar Pessoa - 1");
            Console.WriteLine("Mostra Todas as  Pessoas - 2");
            Console.WriteLine("Remover Pessoa - 3");
            Console.WriteLine("Atualizar Pessoa - 4");
            Console.WriteLine("Finalizar Programa - 5");
            Console.WriteLine("------------------------------------");

            int.TryParse(Console.ReadLine(), out int opcao);

            Console.WriteLine("\n");

            return opcao;
        }

        private static void AdicionarPessoa(IPessoaService pessoaService)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Informe o nome da pessoa:");
            string nomePessoa = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Informe a idade da pessoa:");
            string idadePessoa = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nomePessoa, idadePessoa);

            pessoaService.Adicionar(pessoa);
        }

        private static void RemoverPessoa(IPessoaService pessoaService)
        {
            Console.WriteLine("Informe a pessoa para remover:");
            int.TryParse(Console.ReadLine(), out int id);

            var pessoaBuscada = pessoaService.Buscar(id);

            if (pessoaService.ValidarPessoaEncontrada(pessoaBuscada))
            {
                return;
            }

            Console.WriteLine("\n");

            pessoaService.Remover(id);
        }

        private static void MostrarPessoas(IPessoaService pessoaService)
        {
            List<Pessoa> listaPessoas = pessoaService.mostrarTodos();

            pessoaService.ValidarListaVazia(listaPessoas);

            foreach (var item in listaPessoas)
            {
                Console.WriteLine(item);

            }
        }

        private static void AtualizarPessoa(IPessoaService pessoaService)
        {
            Console.WriteLine("Informe a pessoa para atualizar:");
            int.TryParse(Console.ReadLine(), out int id);

            var pessoaBuscada = pessoaService.Buscar(id);

            if (pessoaService.ValidarPessoaEncontrada(pessoaBuscada))
            {
                return;
            }

            Console.WriteLine("\n");
            Console.WriteLine("Informe o nome da pessoa:");
            string nomePessoaAtualizada = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Informe a idade da pessoa:");
            string idadePessoaAtualizada = Console.ReadLine();

            Console.WriteLine("\n");

            pessoaBuscada.Nome = nomePessoaAtualizada;

            pessoaBuscada.Idade = idadePessoaAtualizada;

            pessoaService.Atualizar(pessoaBuscada, id);

        }
    }
}
