using Poseidon.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Application.Services.Interface
{
    public interface IProfileService
    {
        void ProfileAdded(ProfileDto profileModel);
        IList<ProfileDto> ProfileList();
    }
}
