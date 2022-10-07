using Poseidon.Application.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Application.Dtos
{
    public class SliderDto : BaseDto
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
