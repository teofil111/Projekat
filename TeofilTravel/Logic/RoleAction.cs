using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeofilTravel.Models;

namespace TeofilTravel.Logic
{
    public class RoleAction
    {
        internal void AddUserAndRole()
        {


            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            var roleStore = new RoleStore<IdentityRole>(context);

            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }

            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser

            {
                UserName = "teofil@gmail.com",
                Email = "teofil@gmail.com"
            };

            IdUserResult = userMgr.Create(appUser, "Teofil1!");
            if (!userMgr.IsInRole(userMgr.FindByEmail("teofil@gmail.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("teofil@gmail.com").Id, "canEdit");
            }
        }
    }
}