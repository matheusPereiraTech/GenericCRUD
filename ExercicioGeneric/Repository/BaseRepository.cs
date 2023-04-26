using ExercicioGeneric.Domain.Entidade;
using ExercicioGeneric.Interface.Repositorio;

namespace ExercicioGeneric.Repositorio
{
    internal abstract class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        private static List<T> _list = new List<T>();

       public void Adicionar(T entidade)
        {
            _list.Add(entidade);
        }

        public void Remover(int index)
        {
            var entidadeBuscada = Buscar(index);
            _list.Remove(entidadeBuscada);
        }

        public T Buscar(int id) => _list.Find(x => x.Id == id);
        

        public void Atualizar(int id, T entidade)
        {
            var entidadeBuscada = Buscar(id);

            entidadeBuscada = entidade;

        }

        public List<T> MostrarTodos() => _list;
        
    }
}
