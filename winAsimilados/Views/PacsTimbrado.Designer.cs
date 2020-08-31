namespace winAsimilados.Views
{
    partial class PacsTimbrado
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacsTimbrado));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.chEditSolucion = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpPAC = new DevExpress.XtraEditors.LookUpEdit();
            this.chNtLink = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlPacsTimbrado = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem65 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lookUpAmbiente = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem66 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtPACActivo = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEditSolucion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPAC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chNtLink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPacsTimbrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpAmbiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPACActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chEditSolucion);
            this.layoutControl1.Controls.Add(this.lookUpPAC);
            this.layoutControl1.Controls.Add(this.chNtLink);
            this.layoutControl1.Controls.Add(this.txtPACActivo);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 188, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlPacsTimbrado,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // chEditSolucion
            // 
            this.chEditSolucion.Location = new System.Drawing.Point(24, 42);
            this.chEditSolucion.Name = "chEditSolucion";
            this.chEditSolucion.Properties.Caption = "Solución Factible";
            this.chEditSolucion.Size = new System.Drawing.Size(374, 19);
            this.chEditSolucion.StyleController = this.layoutControl1;
            this.chEditSolucion.TabIndex = 10;
            this.chEditSolucion.CheckedChanged += new System.EventHandler(this.chEditSolucion_CheckedChanged);
            // 
            // lookUpPAC
            // 
            this.lookUpPAC.Location = new System.Drawing.Point(74, 65);
            this.lookUpPAC.Name = "lookUpPAC";
            this.lookUpPAC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPAC.Properties.DataSource = this.queryBindingSource;
            this.lookUpPAC.Properties.DisplayMember = "Descripcion";
            this.lookUpPAC.Properties.NullText = "Seleccione";
            this.lookUpPAC.Properties.ValueMember = "value";
            this.lookUpPAC.Size = new System.Drawing.Size(702, 20);
            this.lookUpPAC.StyleController = this.layoutControl1;
            this.lookUpPAC.TabIndex = 12;
            this.lookUpPAC.EditValueChanged += new System.EventHandler(this.lookUpPAC_EditValueChanged);
            // 
            // chNtLink
            // 
            this.chNtLink.Location = new System.Drawing.Point(402, 42);
            this.chNtLink.Name = "chNtLink";
            this.chNtLink.Properties.Caption = "NT-Link";
            this.chNtLink.Size = new System.Drawing.Size(374, 19);
            this.chNtLink.StyleController = this.layoutControl1;
            this.chNtLink.TabIndex = 11;
            this.chNtLink.CheckedChanged += new System.EventHandler(this.chNtLink_CheckedChanged);
            // 
            // layoutControlPacsTimbrado
            // 
            this.layoutControlPacsTimbrado.CustomizationFormText = "Pac de timbrado";
            this.layoutControlPacsTimbrado.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlPacsTimbrado.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem65,
            this.lookUpAmbiente,
            this.layoutControlItem66,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2});
            this.layoutControlPacsTimbrado.Location = new System.Drawing.Point(0, 0);
            this.layoutControlPacsTimbrado.Name = "layoutControlPacsTimbrado";
            this.layoutControlPacsTimbrado.Size = new System.Drawing.Size(780, 155);
            this.layoutControlPacsTimbrado.Text = "Pac de timbrado";
            // 
            // layoutControlItem65
            // 
            this.layoutControlItem65.Control = this.chEditSolucion;
            this.layoutControlItem65.CustomizationFormText = "layoutControlItem65";
            this.layoutControlItem65.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem65.Name = "layoutControlItem65";
            this.layoutControlItem65.Size = new System.Drawing.Size(378, 23);
            this.layoutControlItem65.Text = "layoutControlItem65";
            this.layoutControlItem65.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem65.TextVisible = false;
            // 
            // lookUpAmbiente
            // 
            this.lookUpAmbiente.Control = this.lookUpPAC;
            this.lookUpAmbiente.CustomizationFormText = "Ambiente";
            this.lookUpAmbiente.Location = new System.Drawing.Point(0, 23);
            this.lookUpAmbiente.Name = "lookUpAmbiente";
            this.lookUpAmbiente.Size = new System.Drawing.Size(756, 24);
            this.lookUpAmbiente.Text = "Ambiente";
            this.lookUpAmbiente.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lookUpAmbiente.TextSize = new System.Drawing.Size(45, 13);
            this.lookUpAmbiente.TextToControlDistance = 5;
            // 
            // layoutControlItem66
            // 
            this.layoutControlItem66.Control = this.chNtLink;
            this.layoutControlItem66.CustomizationFormText = "layoutControlItem66";
            this.layoutControlItem66.Location = new System.Drawing.Point(378, 0);
            this.layoutControlItem66.Name = "layoutControlItem66";
            this.layoutControlItem66.Size = new System.Drawing.Size(378, 23);
            this.layoutControlItem66.Text = "layoutControlItem66";
            this.layoutControlItem66.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem66.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 155);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 275);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtPACActivo
            // 
            this.txtPACActivo.Location = new System.Drawing.Point(144, 89);
            this.txtPACActivo.Name = "txtPACActivo";
            this.txtPACActivo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPACActivo.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPACActivo.Properties.ReadOnly = true;
            this.txtPACActivo.Size = new System.Drawing.Size(632, 20);
            this.txtPACActivo.StyleController = this.layoutControl1;
            this.txtPACActivo.TabIndex = 13;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtPACActivo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(756, 24);
            this.layoutControlItem1.Text = "PAC de Timbrado Activo";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(115, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "\r\nselect \'Produccion\' as [value], \'Ambiente De Produccuión\' as [Descripcion]\r\nuni" +
    "on select \'Pruebas\' as [Value], \'Ambiente de Pruebas\' as [Descripción]";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0idmFsdWUiIFR5cGU9IlN0cmluZyIgLz48RmllbGQgTmFtZT0iRGVzY3JpcGNpb24iIFR5cGU9IlN0c" +
    "mluZyIgLz48L1ZpZXc+PC9EYXRhU2V0Pg==";
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(693, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 38);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnGuardar;
            this.layoutControlItem2.Location = new System.Drawing.Point(669, 71);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(87, 42);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 71);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(669, 42);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PacsTimbrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PacsTimbrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PACS Timbrado";
            this.Load += new System.EventHandler(this.PacsTimbrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEditSolucion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPAC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chNtLink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPacsTimbrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpAmbiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPACActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckEdit chEditSolucion;
        private DevExpress.XtraEditors.LookUpEdit lookUpPAC;
        private DevExpress.XtraEditors.CheckEdit chNtLink;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlPacsTimbrado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem65;
        private DevExpress.XtraLayout.LayoutControlItem lookUpAmbiente;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem66;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtPACActivo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}