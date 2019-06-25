using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using HumanResource.HRForm.Recruitment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResource
{
    public partial class frmMain : RibbonForm
    {
        public frmMain()
        {
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.SetSkinStyle("Visual Studio 2013 Light");
            InitializeComponent();
        }

        private void btnYeuCauTuyenDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm f = new frmRecruitmentRequirement();
            CheckTabOpenDev(f);

        }

        // Sử dụng kiểm tra trước khi add mới XtraTabPage (Đã add control)
        // Nếu XtraTabPage đã được add thì không add trùng 
        //---------------- chưa được add thì add mới XtraTabPage
        public void CheckTabOpenDev(XtraForm _f)
        {
            if (xtraTabMain.TabPages.Count == 0)
            {
                AddControl(_f);
            }
            else
            {
                bool trunglap = false;
                for (int i = 0; i < xtraTabMain.TabPages.Count; i++)
                {
                    if (("Tab" + _f.Name) == xtraTabMain.TabPages[i].Name)
                    {
                        trunglap = true;
                        xtraTabMain.SelectedTabPage = xtraTabMain.TabPages[i];
                        break;
                    }
                }
                if (trunglap == false) AddControl(_f);
            }
        }

        // Sử dụng add Form vào trong XtraTabPage (Bộ công cụ DevExpress)
        // Tham số truyền vào (XtraForm)
        public void AddControl(XtraForm _f)
        {
            var _Tab = new XtraTabPage();
            xtraTabMain.TabPages.Add(_Tab);
            xtraTabMain.SelectedTabPage = _Tab;
            _Tab.Name = "Tab" + _f.Name;
            _Tab.Text = _f.Text;

            // Dinh dang form
            _f.TopLevel = false;
            _f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Add Form
            _Tab.Controls.Add(_f);

            // Fill form toan bo Tab 
            _f.Dock = DockStyle.Fill;

            //Hien thi
            _f.Show();
        }

        private void xtraTabMain_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            (arg.Page as XtraTabPage).PageVisible = false;
            XtraTabControl t = sender as XtraTabControl;
            t.TabPages.Remove(arg.Page as XtraTabPage);
        }
    }
}
