using Poseidon.Common.Enums;
using Poseidon.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Domain.Entities
{
    public class Content : BaseEntity
    {
        public string Name { get; set; }
        public string ContentText { get; set; }
        public string ImagePath { get; set; }
        public ContentTypeEnum ContentType { get; set; }
    }
}
