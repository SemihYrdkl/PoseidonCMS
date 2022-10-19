using FluentNHibernate.Mapping;
using Poseidon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Data.Mapping
{
    public class ProfileMapping : ClassMap<Profile>
    {
        public ProfileMapping()
        {
            Table("Profile");
            Id(p => p.Id).GeneratedBy.Identity();
            Map(p => p.CompanyName).Not.Nullable();
            Map(p => p.CompanyInfo).Not.Nullable();
            Map(p => p.Email).Not.Nullable();
            Map(p => p.PhoneNumber).Not.Nullable();
            Map(p => p.Picture).Not.Nullable();
        }
    }
}
