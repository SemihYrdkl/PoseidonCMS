using Poseidon.Common.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Common.Dtos
{
    public class ContentBoxDto : BaseDto
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
    }
}
