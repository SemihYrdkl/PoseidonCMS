using NHibernate;
using Poseidon.Common.Dtos;
using Poseidon.Domain.Entities;
using Poseidon.Domain.Repositories;
using Poseidon.Domain.Services.Interface;
using Poseidon.Infrastructure.Data;
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
        //private readonly IBaseRepository<Profile> _baseRepository;
        public ProfileService(/*IBaseRepository<Profile> baseRepository*/)
        {
            //_baseRepository = baseRepository;
        }

        public void ProfileAdded(ProfileDto profileDto)
        {
            var profile = new Profile
            {
                CompanyName = profileDto.CompanyName,
                CompanyInfo = profileDto.CompanyInfo,
                Email = profileDto.Email,
                PhoneNumber = profileDto.PhoneNumber,
                Picture = profileDto.Picture
            };

            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(profile);
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                    }
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
        }

        //public IList<ProfileDto> ProfileList()
        //{
        //    return _repository.GetList();  
        //}
    }
}
