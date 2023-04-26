using ExercicioGeneric.Domain.Entidade;
using ExercicioGeneric.Interface.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGeneric.Repositorio
{
    internal sealed class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {

    }
}
