using ExercicioGeneric.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGeneric.Interface.Repositorio
{
    internal interface IBaseRepository<T> where T : EntityBase
    {

        public void Adicionar(T entidade);

        public void Remover(int index);

        public T Buscar(int id);

        public void Atualizar(int id, T entidade);

        public List<T> MostrarTodos();
    }
}
