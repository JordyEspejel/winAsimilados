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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEmpleados));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataTipoPeri = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAsimilados.Views.WaitForm1), true, true, true);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GridControlEmpl = new DevExpress.XtraGrid.GridControl();
            this.GridViewEmpl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUM_EMPLEADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPERIODICIDAD_PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.queryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceEmpl = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataTipoPeri;
            // 
            // sqlDataTipoPeri
            // 
            this.sqlDataTipoPeri.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataTipoPeri.Name = "sqlDataTipoPeri";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select \"PeriodicidadPago\".\"c_PeriodicidadPago\",\r\n       \"PeriodicidadPago\".\"Descr" +
    "ipcion\"\r\n  from \"dbo\".\"PeriodicidadPago\" \"PeriodicidadPago\" ";
            this.sqlDataTipoPeri.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataTipoPeri.ResultSchemaSerializable = resources.GetString("sqlDataTipoPeri.ResultSchemaSerializable");
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GridControlEmpl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 189, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GridControlEmpl
            // 
            this.GridControlEmpl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.GridControlEmpl_EmbeddedNavigator_ButtonClick);
            this.GridControlEmpl.Location = new System.Drawing.Point(12, 12);
            this.GridControlEmpl.MainView = this.GridViewEmpl;
            this.GridControlEmpl.Name = "GridControlEmpl";
            this.GridControlEmpl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.GridControlEmpl.Size = new System.Drawing.Size(776, 426);
            this.GridControlEmpl.TabIndex = 4;
            this.GridControlEmpl.UseEmbeddedNavigator = true;
            this.GridControlEmpl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewEmpl});
            // 
            // GridViewEmpl
            // 
            this.GridViewEmpl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidempleado,
            this.colNUM_EMPLEADO,
            this.colNOMBRE,
            this.colRFC,
            this.colCURP,
            this.colPERIODICIDAD_PAGO});
            this.GridViewEmpl.GridControl = this.GridControlEmpl;
            this.GridViewEmpl.Name = "GridViewEmpl";
            this.GridViewEmpl.OptionsView.ShowAutoFilterRow = true;
            this.GridViewEmpl.OptionsView.ShowGroupPanel = false;
            // 
            // colidempleado
            // 
            this.colidempleado.FieldName = "idempleado";
            this.colidempleado.Name = "colidempleado";
            // 
            // colNUM_EMPLEADO
            // 
            this.colNUM_EMPLEADO.Caption = "# Empleado";
            this.colNUM_EMPLEADO.FieldName = "NUM_EMPLEADO";
            this.colNUM_EMPLEADO.Name = "colNUM_EMPLEADO";
            this.colNUM_EMPLEADO.Visible = true;
            this.colNUM_EMPLEADO.VisibleIndex = 0;
            // 
            // colNOMBRE
            // 
            this.colNOMBRE.Caption = "Nombre";
            this.colNOMBRE.FieldName = "NOMBRE";
            this.colNOMBRE.Name = "colNOMBRE";
            this.colNOMBRE.Visible = true;
            this.colNOMBRE.VisibleIndex = 1;
            // 
            // colRFC
            // 
            this.colRFC.Caption = "RFC";
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 2;
            // 
            // colCURP
            // 
            this.colCURP.Caption = "CURP";
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 3;
            // 
            // colPERIODICIDAD_PAGO
            // 
            this.colPERIODICIDAD_PAGO.Caption = "Periodicidad Pago";
            this.colPERIODICIDAD_PAGO.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colPERIODICIDAD_PAGO.FieldName = "PERIODICIDAD_PAGO";
            this.colPERIODICIDAD_PAGO.Name = "colPERIODICIDAD_PAGO";
            this.colPERIODICIDAD_PAGO.Visible = true;
            this.colPERIODICIDAD_PAGO.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.queryBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descripcion";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "c_PeriodicidadPago";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridControlEmpl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 430);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // queryBindingSource1
            // 
            this.queryBindingSource1.DataMember = "Query";
            this.queryBindingSource1.DataSource = this.sqlDataSourceEmpl;
            // 
            // sqlDataSourceEmpl
            // 
            this.sqlDataSourceEmpl.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSourceEmpl.Name = "sqlDataSourceEmpl";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSourceEmpl.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSourceEmpl.ResultSchemaSerializable = resources.GetString("sqlDataSourceEmpl.ResultSchemaSerializable");
            // 
            // EditarEmpleados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EditarEmpleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarEmpleados_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarEmpleados_FormClosed);
            this.Load += new System.EventHandler(this.EditarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataTipoPeri;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl GridControlEmpl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewEmpl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource queryBindingSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceEmpl;
        private DevExpress.XtraGrid.Columns.GridColumn colidempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNUM_EMPLEADO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colPERIODICIDAD_PAGO;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}