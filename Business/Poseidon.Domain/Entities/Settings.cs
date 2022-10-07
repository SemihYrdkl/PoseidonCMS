using Poseidon.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Domain.Entities
{
    public class Settings : BaseEntity
    {
        public string Logo { get; set; }
        public string SocialMediaLinks { get; set; }
    }
}
