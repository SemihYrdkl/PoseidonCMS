using Poseidon.Application.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Application.Dtos
{
    public class ContentDto : BaseDto
    {
        public string ContentText { get; set; }
        public string ImagePath { get; set; }
        public string ContentType { get; set; }
    }
}
