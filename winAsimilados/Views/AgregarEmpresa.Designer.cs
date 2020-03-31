namespace winAsimilados.Views
{
    partial class AgregarEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpresa));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblNomEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.TxtNomEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtRFCEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.BtnAgregarEmpresa = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAsimilados.Views.WaitForm1), true, true, true);
            this.sidePanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNomEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRFCEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.groupBox1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(800, 450);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa la información de la Empresa Nueva:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LblNomEmpresa);
            this.flowLayoutPanel1.Controls.Add(this.TxtNomEmpresa);
            this.flowLayoutPanel1.Controls.Add(this.labelControl1);
            this.flowLayoutPanel1.Controls.Add(this.TxtRFCEmpresa);
            this.flowLayoutPanel1.Controls.Add(this.separatorControl1);
            this.flowLayoutPanel1.Controls.Add(this.BtnAgregarEmpresa);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 431);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LblNomEmpresa
            // 
            this.LblNomEmpresa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.LblNomEmpresa.Appearance.Options.UseFont = true;
            this.LblNomEmpresa.Location = new System.Drawing.Point(3, 3);
            this.LblNomEmpresa.Name = "LblNomEmpresa";
            this.LblNomEmpresa.Size = new System.Drawing.Size(99, 13);
            this.LblNomEmpresa.TabIndex = 2;
            this.LblNomEmpresa.Text = "Nombre Empresa:";
            // 
            // TxtNomEmpresa
            // 
            this.TxtNomEmpresa.Location = new System.Drawing.Point(3, 22);
            this.TxtNomEmpresa.Name = "TxtNomEmpresa";
            this.TxtNomEmpresa.Size = new System.Drawing.Size(254, 20);
            this.TxtNomEmpresa.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "RFC:";
            // 
            // TxtRFCEmpresa
            // 
            this.TxtRFCEmpresa.Location = new System.Drawing.Point(3, 67);
            this.TxtRFCEmpresa.Name = "TxtRFCEmpresa";
            this.TxtRFCEmpresa.Size = new System.Drawing.Size(254, 20);
            this.TxtRFCEmpresa.TabIndex = 5;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl1.Location = new System.Drawing.Point(3, 93);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(254, 20);
            this.separatorControl1.TabIndex = 0;
            // 
            // BtnAgregarEmpresa
            // 
            this.BtnAgregarEmpresa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarEmpresa.ImageOptions.Image")));
            this.BtnAgregarEmpresa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnAgregarEmpresa.Location = new System.Drawing.Point(3, 119);
            this.BtnAgregarEmpresa.Name = "BtnAgregarEmpresa";
            this.BtnAgregarEmpresa.Size = new System.Drawing.Size(254, 63);
            this.BtnAgregarEmpresa.TabIndex = 1;
            this.BtnAgregarEmpresa.Text = "Agregar Empresa";
            this.BtnAgregarEmpresa.Click += new System.EventHandler(this.BtnAgregarEmpresa_Click);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // AgregarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidePanel1);
            this.Name = "AgregarEmpresa";
            this.Text = "AgregarEmpresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarEmpresa_FormClosed);
            this.sidePanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNomEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRFCEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton BtnAgregarEmpresa;
        private DevExpress.XtraEditors.LabelControl LblNomEmpresa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtRFCEmpresa;
        public DevExpress.XtraEditors.TextEdit TxtNomEmpresa;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}