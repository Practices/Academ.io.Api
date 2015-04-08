using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Academ.io.Api.Models;
using Academ.io.Api.Security.Models;
using Academ.io.Api.Security.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Academ.io.Api.Controllers
{
    [RoutePrefix("api/account")]
    public class AccountController: ApiController
    {
        private IUserRepository userRepository;

        public AccountController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [AllowAnonymous]
        [Route("register")]
        public async Task<IHttpActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await userRepository.RegisterUser(model);

            IHttpActionResult errorResult = GetErrorResult(result);

            if(errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if(result == null)
            {
                return InternalServerError();
            }

            if(!result.Succeeded)
            {
                if(result.Errors != null)
                {
                    foreach(string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if(ModelState.IsValid)
                {
                    return BadRequest();
                }

                return BadRequest();
            }
            return null;
        }
    }
}