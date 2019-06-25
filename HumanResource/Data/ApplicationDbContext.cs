using HumanResource.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace HumanResource.Data
{
    class ApplicationDbContext : DbContext
    {
        public static string cntString = ConfigurationManager.ConnectionStrings["HumanResourceconnectionString"].ConnectionString;
        public ApplicationDbContext() : base(cntString)
        {

        }
        public DbSet<RecruitmentRequirement> RecruitmentRequirements { get; set; }       
    }
}
