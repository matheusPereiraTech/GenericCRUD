using ExercicioGeneric.Domain.Entidade;
using ExercicioGeneric.Interface.Repositorio;
using ExercicioGeneric.Interface.Servico;
using ExercicioGeneric.Repositorio;
using ExercicioGeneric.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGeneric.Servico
{
    internal sealed class PessoaService : BaseService<Pessoa>, IPessoaService
    {
        public PessoaService(IPessoaRepository pessoaRepository) : base(pessoaRepository)
        {  
        }
    }
}
