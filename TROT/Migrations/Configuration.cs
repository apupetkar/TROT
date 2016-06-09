namespace TROT.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TROT.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Diagnostics;
    internal sealed class Configuration : DbMigrationsConfiguration<TROT.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TROT.Models.ApplicationDbContext context)
        {
            AddUserAndRole(context);

            context.Agents.AddOrUpdate(p => p.Name,
               new Agent
            {
                Name = "Demo Agent",
                Address = "Grasmeierstr. 25",
                City = "Munich",
                State = "BA",
                Zip = "80805",
                Email = "rohittidke@gmail.com",
                PhoneNumber = "+4917698252030"
            }

                );
        }

        void AddUserAndRole(ApplicationDbContext context)
        {
            IdentityResult superUserResult;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            superUserResult = rm.Create(new IdentityRole("superuser"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "admin@trotrealty.com",
            };
            superUserResult = um.Create(user, "admin-Cola1");
            if (superUserResult.Succeeded == false)
                Trace.TraceError("Error in creation of superuser");
            else
            {
                superUserResult = um.AddToRole(user.Id, "superuser");
                //return ir.Succeeded;
            }

            IdentityResult agentResult;

            agentResult = rm.Create(new IdentityRole("agent"));
            
            var agent = new ApplicationUser()
            {
                UserName = "demoagent@trotrealty.com",
            };

            agentResult = um.Create(user, "demo-Cola1");

            if (agentResult.Succeeded == false)
                Trace.TraceError("Error in creation of agent");
            else
            {
                agentResult = um.AddToRole(user.Id, "agent");
                //return ir.Succeeded;
            }
        }

  
    }
}
