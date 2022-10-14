using Poseidon.Common.Dtos;
using Poseidon.Domain.Entities;
using Poseidon.Domain.Repositories;
using Poseidon.Domain.Services.Interface;
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
        private readonly IBaseRepository<Profile> _baseRepository;
        public ProfileService(IBaseRepository<Profile> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        //private readonly RepositoryBase<ProfileDto> _repository = new RepositoryBase<ProfileDto>();
        public void ProfileAdded(ProfileDto profileModel)
        {
            Profile profile = new Profile() { 
            Id = profileModel.Id,
            CompanyName = profileModel.CompanyName,
            CompanyInfo = profileModel.CompanyInfo,
            Email = profileModel.Email,
            PhoneNumber = profileModel.PhoneNumber,
            Picture = profileModel.Picture
            };
            _baseRepository.Insert(profile);
        }

        //public IList<ProfileDto> ProfileList()
        //{
        //    return _repository.GetList();  
        //}
    }
}
