using HumanResource.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Data
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationDbContext>());
        }
        public DbSet<RecruitmentRequirement> RecruitmentRequirements { get; set; }

    }
}
