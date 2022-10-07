using Poseidon.Application.Dtos.Base.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Application.Dtos.Base
{
    public class BaseDto : IBaseDto
    {
        public int Id { get; set; }
    }
}
