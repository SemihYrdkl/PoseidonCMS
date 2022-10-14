using Poseidon.Common.Dtos.Base;
using Poseidon.Common.Dtos.Base.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Common.Dtos
{
    public class ProfileDto : BaseDto
    {
        public virtual string CompanyName { get; set; }
        public virtual string CompanyInfo { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Picture { get; set; }
    }
}
