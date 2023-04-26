

namespace ExercicioGeneric.Interface.Servico
{
    internal interface IBaseService<T>
    {

        public void Adicionar(T entidade);

        public void Remover(int index);

        public T Buscar(int index);

        public void Atualizar(T entidade, int index);

        public List<T> mostrarTodos();

    }
}
