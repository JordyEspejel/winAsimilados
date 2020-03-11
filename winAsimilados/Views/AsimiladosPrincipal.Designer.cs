namespace winAsimilados.Views
{
    partial class AsimiladosPrincipal
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.lblRFC = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidePanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.AutoSize = true;
            this.simpleButton1.AutoWidthInLayoutControl = true;
            this.simpleButton1.Location = new System.Drawing.Point(12, 79);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 22);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Generar PDF/XML";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.lblRFC);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.lblEmpresa);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.menuStrip1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1350, 73);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblRFC.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblRFC.LineVisible = true;
            this.lblRFC.Location = new System.Drawing.Point(42, 52);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(63, 16);
            this.lblRFC.TabIndex = 6;
            this.lblRFC.Text = "labelControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "RFC:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblEmpresa.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.lblEmpresa.Location = new System.Drawing.Point(63, 27);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(63, 13);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "labelEmpresa";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(12, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Empresa:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.meniToolStripMenuItem.Text = "Menu";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarEmpresaToolStripMenuItem});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // cambiarEmpresaToolStripMenuItem
            // 
            this.cambiarEmpresaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cambiarEmpresaToolStripMenuItem.Name = "cambiarEmpresaToolStripMenuItem";
            this.cambiarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarEmpresaToolStripMenuItem.Text = "Cambiar Empresa";
            this.cambiarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.cambiarEmpresaToolStripMenuItem_Click);
            // 
            // AsimiladosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sidePanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AsimiladosPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsimiladosPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsimiladosPrincipal_FormClosing);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        public DevExpress.XtraEditors.LabelControl lblEmpresa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.LabelControl lblRFC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarEmpresaToolStripMenuItem;
    }
}