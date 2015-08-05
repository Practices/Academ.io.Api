using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Academ.io.Api.Models;
using Academ.io.Data.Contexts;
using Academ.io.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Academ.io.Data.Repositories
{
    public class UserRepository: IUserRepository
    {
        private ApplicationContext context;
        private UserManager<ApplicationUser> userManager;

        public UserRepository(ApplicationContext context)
        {
            this.context = context;
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
        }

        public async Task<IdentityResult> RegisterUser(RegisterModel model)
        {
            ApplicationUser user = new ApplicationUser
            {
                UserName = model.UserName
            };
            var result = await userManager.CreateAsync(user, model.Password);

            return result;
        }

        public async Task<ApplicationUser> FindUser(string userName, string password)
        {
            ApplicationUser user = await userManager.FindAsync(userName, password);

            return user;
        }

        public async Task<List<ApplicationUser>> GetUsers()
        {
            return await this.userManager.Users.ToListAsync();
        }

        public ApplicationUser GetUser(string username)
        {
            return userManager.FindByName(username);
        }

        public void Dispose()
        {
            context.Dispose();
            userManager.Dispose();
        }
    }
}