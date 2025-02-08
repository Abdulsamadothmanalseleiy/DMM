
namespace DMM.Pages
{
    partial class ReportPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPage));
            this.btn_supplierreport = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_customerreoprt = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_supplierreport
            // 
            this.btn_supplierreport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_supplierreport.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplierreport.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplierreport.Appearance.Options.UseBackColor = true;
            this.btn_supplierreport.Appearance.Options.UseFont = true;
            this.btn_supplierreport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_supplierreport.ImageOptions.Image")));
            this.btn_supplierreport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_supplierreport.Location = new System.Drawing.Point(330, 32);
            this.btn_supplierreport.Name = "btn_supplierreport";
            this.btn_supplierreport.Size = new System.Drawing.Size(238, 103);
            this.btn_supplierreport.TabIndex = 5;
            this.btn_supplierreport.Text = "تقرير ديون الموردين";
            this.btn_supplierreport.Click += new System.EventHandler(this.btn_supplierreport_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btn_customerreoprt);
            this.panel1.Controls.Add(this.btn_supplierreport);
            this.panel1.Location = new System.Drawing.Point(225, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 185);
            this.panel1.TabIndex = 6;
            // 
            // btn_customerreoprt
            // 
            this.btn_customerreoprt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_customerreoprt.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_customerreoprt.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerreoprt.Appearance.Options.UseBackColor = true;
            this.btn_customerreoprt.Appearance.Options.UseFont = true;
            this.btn_customerreoprt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_customerreoprt.ImageOptions.Image")));
            this.btn_customerreoprt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_customerreoprt.Location = new System.Drawing.Point(20, 32);
            this.btn_customerreoprt.Name = "btn_customerreoprt";
            this.btn_customerreoprt.Size = new System.Drawing.Size(253, 103);
            this.btn_customerreoprt.TabIndex = 5;
            this.btn_customerreoprt.Text = "تقرير ديون العملاء";
            this.btn_customerreoprt.Click += new System.EventHandler(this.btn_customerreoprt_Click);
            // 
            // ReportPage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ReportPage";
            this.Size = new System.Drawing.Size(1048, 618);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_supplierreport;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_customerreoprt;
    }
}
