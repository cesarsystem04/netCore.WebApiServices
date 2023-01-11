using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public abstract class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }
    }
    public abstract class Entity : IEntity
    {

    }
}
