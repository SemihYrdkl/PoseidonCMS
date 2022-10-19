using Poseidon.Domain.Entities.Base.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Domain.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        public virtual int Id { get; set; }
    }
}
