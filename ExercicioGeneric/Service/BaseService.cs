using ExercicioGeneric.Domain.Entidade;
using ExercicioGeneric.Interface.Repositorio;
using ExercicioGeneric.Interface.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGeneric.Services
{
    internal abstract class BaseService<T> : IBaseService<T> where T : EntityBase
    {
        private readonly IBaseRepository<T> _baseRepository;


        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Adicionar(T entidade)
        {
           _baseRepository.Adicionar(entidade);
        }

        public void Atualizar(T entidade, int index)
        {

            _baseRepository.Atualizar(index, entidade);
        }

        public T Buscar(int index) => _baseRepository.Buscar(index);


        public List<T> mostrarTodos() => _baseRepository.MostrarTodos();

        public void Remover(int index)
        {
            _baseRepository.Remover(index);
        }
    }
}
