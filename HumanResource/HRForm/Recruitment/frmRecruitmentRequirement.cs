using DevExpress.XtraEditors;
using HumanResource.Data;
using HumanResource.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource.HRForm.Recruitment
{
    public partial class frmRecruitmentRequirement : XtraForm
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();
        public frmRecruitmentRequirement()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var lstObj = _dbContext.RecruitmentRequirements.ToList();
            grRR.DataSource = lstObj;
        }
    }
}
