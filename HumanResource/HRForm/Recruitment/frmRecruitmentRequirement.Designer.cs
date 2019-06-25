namespace HumanResource.HRForm.Recruitment
{
    partial class frmRecruitmentRequirement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grRR = new DevExpress.XtraGrid.GridControl();
            this.grvRR = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CRUDDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CRUDBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRR)).BeginInit();
            this.SuspendLayout();
            // 
            // grRR
            // 
            this.grRR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grRR.Location = new System.Drawing.Point(8, 338);
            this.grRR.MainView = this.grvRR;
            this.grRR.Name = "grRR";
            this.grRR.Size = new System.Drawing.Size(1366, 599);
            this.grRR.TabIndex = 0;
            this.grRR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvRR});
            // 
            // grvRR
            // 
            this.grvRR.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.CRUDDate,
            this.CRUDBy,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.grvRR.GridControl = this.grRR;
            this.grvRR.Name = "grvRR";
            this.grvRR.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Ma";
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 25;
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 94;
            // 
            // CRUDDate
            // 
            this.CRUDDate.Caption = "gridColumn2";
            this.CRUDDate.FieldName = "CRUDDate";
            this.CRUDDate.MinWidth = 25;
            this.CRUDDate.Name = "CRUDDate";
            this.CRUDDate.Visible = true;
            this.CRUDDate.VisibleIndex = 1;
            this.CRUDDate.Width = 94;
            // 
            // CRUDBy
            // 
            this.CRUDBy.Caption = "Người tạo";
            this.CRUDBy.FieldName = "CRUDBy";
            this.CRUDBy.MinWidth = 25;
            this.CRUDBy.Name = "CRUDBy";
            this.CRUDBy.Visible = true;
            this.CRUDBy.VisibleIndex = 2;
            this.CRUDBy.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "gridColumn7";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 94;
            // 
            // frmRecruitmentRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 949);
            this.Controls.Add(this.grRR);
            this.Name = "frmRecruitmentRequirement";
            this.Text = "Yêu cầu tuyển dụng";
            ((System.ComponentModel.ISupportInitialize)(this.grRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grRR;
        private DevExpress.XtraGrid.Views.Grid.GridView grvRR;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn CRUDDate;
        private DevExpress.XtraGrid.Columns.GridColumn CRUDBy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}