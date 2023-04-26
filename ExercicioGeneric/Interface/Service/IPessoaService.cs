using ExercicioGeneric.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGeneric.Interface.Servico
{
    internal interface IPessoaService : IBaseService<Pessoa>
    {
        public bool ValidarPessoaEncontrada(Pessoa pessoa);

        public void ValidarListaVazia(List<Pessoa> pessoas);
        
    }
}
