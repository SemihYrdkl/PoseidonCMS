using Poseidon.Application.Dtos;
using Poseidon.Application.Services.Interface;
using Poseidon.Domain.Entities;
using Poseidon.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Application.Services.Concrete
{
    public class ProfileService : IProfileService
    {
        private readonly RepositoryBase<ProfileDto> _repository = new RepositoryBase<ProfileDto>();
        public void ProfileAdded(ProfileDto profileModel)
        {
            _repository.Add(profileModel);
        }

        public IList<ProfileDto> ProfileList()
        {
            return _repository.GetList();  
        }
    }
}
