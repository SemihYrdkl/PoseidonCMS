using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using Poseidon.Common.Dtos;
using Poseidon.Domain.Entities;
using Poseidon.Domain.Services.Interface;
using Poseidon.Infrastructure.Data;
using ISession = NHibernate.ISession;

namespace Poseidon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpPost]
        public ActionResult Create(ProfileDto profileDto)
        {
            _profileService.ProfileAdded(profileDto);

            /* Insert */
            //var profile = new Profile
            //{
            //    CompanyName = profileDto.CompanyName,
            //    CompanyInfo = profileDto.CompanyInfo,
            //    Email = profileDto.Email,
            //    PhoneNumber = profileDto.PhoneNumber,
            //    Picture = profileDto.Picture
            //};

            //ISession session = NHibernateHelper.GetCurrentSession();
            //try
            //{
            //    using (ITransaction tx = session.BeginTransaction())
            //    {
            //        try
            //        {
            //            session.Save(profile);
            //            tx.Commit();
            //        }
            //        catch(Exception ex)
            //        {
            //            tx.Rollback();
            //        }
            //    }
            //}
            //finally
            //{
            //    NHibernateHelper.CloseSession();
            //}

            /* Get */

            //ISession session = NHibernateHelper.GetCurrentSession();
            //try
            //{
            //    using (ITransaction tx = session.BeginTransaction())
            //    {
            //        var customers = from customer in session.Query<Test>()
            //                        select customer;

            //        foreach (var f in customers)
            //        {
            //            Console.WriteLine("{0} {1} {2}", f.Id, f.Name, f.Email);
            //        }
            //        tx.Commit();
            //    }
            //}
            //finally
            //{
            //    NHibernateHelper.CloseSession();
            //}
            return Ok();
        }
        
        //[HttpGet(template: "getall")]
        //public IActionResult GetList()
        //{
        //    var result = _profileService.ProfileList();

        //    return Ok(result);
        //}

    }
}
