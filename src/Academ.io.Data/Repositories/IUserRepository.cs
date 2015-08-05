using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Academ.io.Api.Models;
using Academ.io.Models;
using Microsoft.AspNet.Identity;

namespace Academ.io.Data.Repositories
{
    public interface IUserRepository: IDisposable
    {
        Task<IdentityResult> RegisterUser(RegisterModel model);
        Task<ApplicationUser> FindUser(string userName, string password);
        Task<List<ApplicationUser>> GetUsers();
        ApplicationUser GetUser(string username);
    }
}