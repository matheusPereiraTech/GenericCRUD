using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGeneric.Domain.Entidade
{
    internal class EntityBase
    {

        private static int IdContador = 0;
        
        public int Id { get; set; }

        public EntityBase() 
        {
            IdContador++;
            Id = IdContador;
        }
    }
}
