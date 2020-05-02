namespace winAsimilados.Views
{
    partial class ListaEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEmpresas));
            this.GridEmpresas = new DevExpress.XtraGrid.GridControl();
            this.GridViewEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnIniciar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpresas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridEmpresas
            // 
            this.GridEmpresas.Location = new System.Drawing.Point(27, 19);
            this.GridEmpresas.MainView = this.GridViewEmpresas;
            this.GridEmpresas.Name = "GridEmpresas";
            this.GridEmpresas.Size = new System.Drawing.Size(735, 358);
            this.GridEmpresas.TabIndex = 0;
            this.GridEmpresas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewEmpresas});
            this.GridEmpresas.Click += new System.EventHandler(this.GridEmpresas_Click);
            this.GridEmpresas.DoubleClick += new System.EventHandler(this.GridEmpresas_DoubleClick);
            // 
            // GridViewEmpresas
            // 
            this.GridViewEmpresas.ActiveFilterEnabled = false;
            this.GridViewEmpresas.GridControl = this.GridEmpresas;
            this.GridViewEmpresas.Name = "GridViewEmpresas";
            this.GridViewEmpresas.OptionsBehavior.Editable = false;
            this.GridViewEmpresas.OptionsCustomization.AllowFilter = false;
            this.GridViewEmpresas.OptionsCustomization.AllowGroup = false;
            this.GridViewEmpresas.OptionsView.ShowDetailButtons = false;
            this.GridViewEmpresas.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.BtnIniciar);
            this.groupBox1.Controls.Add(this.GridEmpresas);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 425);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una empresa para continuar:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::winAsimilados.Properties.Resources.hospital;
            this.simpleButton1.Location = new System.Drawing.Point(27, 384);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 35);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Agregar Empresa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnIniciar.ImageOptions.Image")));
            this.BtnIniciar.Location = new System.Drawing.Point(665, 384);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(119, 35);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Seleccionar";
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // ListaEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListaEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaEmpresas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaEmpresas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpresas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridEmpresas;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewEmpresas;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton BtnIniciar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}