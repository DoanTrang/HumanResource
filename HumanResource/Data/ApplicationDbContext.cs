using HumanResource.Models;
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
        public ApplicationDbContext() : base(@"Data Source=QUANGSMILE\QUANGHOANG;Initial Catalog=HumanResource;Persist Security Info=True;User ID=sa;Password=1")
        {

        }
        public DbSet<RecruitmentRequirement> RecruitmentRequirements { get; set; }       
    }
}
