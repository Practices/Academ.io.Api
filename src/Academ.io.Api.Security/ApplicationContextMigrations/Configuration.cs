using System.Collections.Generic;
using Academ.io.Api.Security.Contexts;
using Academ.io.Api.Security.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Academ.io.Api.Security.ApplicationContextMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Academ.io.Api.Security.Contexts.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"ApplicationContextMigrations";
        }

        protected override void Seed(Academ.io.Api.Security.Contexts.ApplicationContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var users = new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    UserName = "Abys",
                    Email = "Todd87@mail.ru",
                    EmailConfirmed = true,
                    Firstname = "Юрий",
                    Lastname = "Андреевич"
                },
                new ApplicationUser()
                {
                    UserName = "Test",
                    Email = "TakaJimm@mail.ru",
                    EmailConfirmed = false,
                    Firstname = "Тест",
                    Lastname = "Тестович"
                }
            };

            userManager.Create(users[0], "George87");
            userManager.Create(users[1], "George87");
        }
    }
}
