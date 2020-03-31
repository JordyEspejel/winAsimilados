namespace winAsimilados.Views
{
    partial class AgregarEmpleado
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleado));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNombreEmpl = new DevExpress.XtraEditors.LabelControl();
            this.TxtNombreEmpl = new DevExpress.XtraEditors.TextEdit();
            this.lblCURP = new DevExpress.XtraEditors.LabelControl();
            this.TxtCURP = new DevExpress.XtraEditors.TextEdit();
            this.lblRFC = new DevExpress.XtraEditors.LabelControl();
            this.TxtRFC = new DevExpress.XtraEditors.TextEdit();
            this.lblPeri = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.BtnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.sidePanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreEmpl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCURP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
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
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa la información del empleado nuevo:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.lblNombreEmpl);
            this.flowLayoutPanel1.Controls.Add(this.TxtNombreEmpl);
            this.flowLayoutPanel1.Controls.Add(this.lblCURP);
            this.flowLayoutPanel1.Controls.Add(this.TxtCURP);
            this.flowLayoutPanel1.Controls.Add(this.lblRFC);
            this.flowLayoutPanel1.Controls.Add(this.TxtRFC);
            this.flowLayoutPanel1.Controls.Add(this.lblPeri);
            this.flowLayoutPanel1.Controls.Add(this.lookUpEdit2);
            this.flowLayoutPanel1.Controls.Add(this.separatorControl1);
            this.flowLayoutPanel1.Controls.Add(this.BtnAgregar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(260, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(257, 429);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblNombreEmpl
            // 
            this.lblNombreEmpl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpl.Appearance.Options.UseFont = true;
            this.lblNombreEmpl.Location = new System.Drawing.Point(3, 3);
            this.lblNombreEmpl.Name = "lblNombreEmpl";
            this.lblNombreEmpl.Size = new System.Drawing.Size(105, 13);
            this.lblNombreEmpl.TabIndex = 0;
            this.lblNombreEmpl.Text = "Nombre Empleado:";
            // 
            // TxtNombreEmpl
            // 
            this.TxtNombreEmpl.Location = new System.Drawing.Point(3, 22);
            this.TxtNombreEmpl.Name = "TxtNombreEmpl";
            this.TxtNombreEmpl.Size = new System.Drawing.Size(250, 20);
            this.TxtNombreEmpl.TabIndex = 1;
            // 
            // lblCURP
            // 
            this.lblCURP.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCURP.Appearance.Options.UseFont = true;
            this.lblCURP.Location = new System.Drawing.Point(3, 48);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(33, 13);
            this.lblCURP.TabIndex = 2;
            this.lblCURP.Text = "CURP:";
            // 
            // TxtCURP
            // 
            this.TxtCURP.Location = new System.Drawing.Point(3, 67);
            this.TxtCURP.Name = "TxtCURP";
            this.TxtCURP.Size = new System.Drawing.Size(250, 20);
            this.TxtCURP.TabIndex = 3;
            // 
            // lblRFC
            // 
            this.lblRFC.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.Appearance.Options.UseFont = true;
            this.lblRFC.Location = new System.Drawing.Point(3, 93);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(24, 13);
            this.lblRFC.TabIndex = 4;
            this.lblRFC.Text = "RFC:";
            // 
            // TxtRFC
            // 
            this.TxtRFC.Location = new System.Drawing.Point(3, 112);
            this.TxtRFC.Name = "TxtRFC";
            this.TxtRFC.Size = new System.Drawing.Size(250, 20);
            this.TxtRFC.TabIndex = 5;
            // 
            // lblPeri
            // 
            this.lblPeri.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeri.Appearance.Options.UseFont = true;
            this.lblPeri.Location = new System.Drawing.Point(3, 138);
            this.lblPeri.Name = "lblPeri";
            this.lblPeri.Size = new System.Drawing.Size(103, 13);
            this.lblPeri.TabIndex = 6;
            this.lblPeri.Text = "Periodicidad Pago:";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(3, 157);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DataSource = this.queryBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "Descripcion";
            this.lookUpEdit2.Properties.DropDownRows = 11;
            this.lookUpEdit2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit2.Properties.ValueMember = "Codigo";
            this.lookUpEdit2.Size = new System.Drawing.Size(250, 20);
            this.lookUpEdit2.TabIndex = 15;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_BSNOMINAS_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = "  SELECT c_PeriodicidadPago as [Codigo], Descripcion  from PeriodicidadPago";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iQ29kaWdvIiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IkRlc2NyaXBjaW9uIiBUeXBlPSJTd" +
    "HJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl1.Location = new System.Drawing.Point(3, 183);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(250, 20);
            this.separatorControl1.TabIndex = 8;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.ImageOptions.Image")));
            this.BtnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnAgregar.Location = new System.Drawing.Point(3, 209);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(250, 55);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "Agregar Empleado";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidePanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEmpleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarEmpleado_FormClosed);
            this.sidePanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreEmpl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCURP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblNombreEmpl;
        private DevExpress.XtraEditors.TextEdit TxtNombreEmpl;
        private DevExpress.XtraEditors.LabelControl lblCURP;
        private DevExpress.XtraEditors.LabelControl lblRFC;
        private DevExpress.XtraEditors.TextEdit TxtRFC;
        private DevExpress.XtraEditors.LabelControl lblPeri;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton BtnAgregar;
        private System.Windows.Forms.BindingSource queryBindingSource;
        public DevExpress.XtraEditors.TextEdit TxtCURP;
        public DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
    }
}