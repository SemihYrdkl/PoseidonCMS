using Poseidon.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Domain.Services.Interface
{
    public interface IProfileService
    {
        void ProfileAdded(ProfileDto profileModel);
        //IList<ProfileDto> ProfileList();
    }
}
