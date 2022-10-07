using Poseidon.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
