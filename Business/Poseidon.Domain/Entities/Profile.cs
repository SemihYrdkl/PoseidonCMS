using Poseidon.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Domain.Entities
{
    public class Profile : BaseEntity
    {
        public virtual string CompanyName { get; set; }
        public virtual string CompanyInfo { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Picture { get; set; }

    }
}
