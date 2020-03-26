namespace winAsimilados.Views
{
    partial class EditarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEmpleados));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.GridControlEmpl = new DevExpress.XtraGrid.GridControl();
            this.GridViewEmpl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.AutoScroll = true;
            this.sidePanel1.Controls.Add(this.GridControlEmpl);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(800, 450);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // GridControlEmpl
            // 
            this.GridControlEmpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlEmpl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.GridControlEmpl_EmbeddedNavigator_ButtonClick);
            this.GridControlEmpl.Location = new System.Drawing.Point(0, 0);
            this.GridControlEmpl.MainView = this.GridViewEmpl;
            this.GridControlEmpl.Name = "GridControlEmpl";
            this.GridControlEmpl.Size = new System.Drawing.Size(800, 450);
            this.GridControlEmpl.TabIndex = 0;
            this.GridControlEmpl.UseEmbeddedNavigator = true;
            this.GridControlEmpl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewEmpl});
            // 
            // GridViewEmpl
            // 
            this.GridViewEmpl.GridControl = this.GridControlEmpl;
            this.GridViewEmpl.Name = "GridViewEmpl";
            this.GridViewEmpl.OptionsView.RowAutoHeight = true;
            this.GridViewEmpl.OptionsView.ShowAutoFilterRow = true;
            this.GridViewEmpl.OptionsView.ShowFooter = true;
            // 
            // EditarEmpleados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarEmpleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarEmpleados_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarEmpleados_FormClosed);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl GridControlEmpl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewEmpl;
    }
}