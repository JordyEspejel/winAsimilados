namespace winAsimilados.Views
{
    partial class Bitacora
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lookUpEditUser = new DevExpress.XtraEditors.LookUpEdit();
            this.segUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceSopradeUsers = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lookUpEditYear = new DevExpress.XtraEditors.LookUpEdit();
            this.queryBindingSourceYear = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceAnio = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lookUpEditMonth = new DevExpress.XtraEditors.LookUpEdit();
            this.queryBindingSourceMonth = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSourceMes = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAsimilados.Views.WaitForm1), true, true, true);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSourceYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSourceMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.lookUpEditUser);
            this.layoutControl1.Controls.Add(this.lookUpEditYear);
            this.layoutControl1.Controls.Add(this.lookUpEditMonth);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(948, 504);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 78);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(924, 414);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // lookUpEditUser
            // 
            this.lookUpEditUser.Location = new System.Drawing.Point(562, 42);
            this.lookUpEditUser.Name = "lookUpEditUser";
            this.lookUpEditUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditUser.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuarioID", "usuario ID", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuarioNombre", "usuario Nombre", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditUser.Properties.DataSource = this.segUsuariosBindingSource;
            this.lookUpEditUser.Properties.DisplayMember = "usuarioNombre";
            this.lookUpEditUser.Properties.ValueMember = "usuarioID";
            this.lookUpEditUser.Size = new System.Drawing.Size(362, 20);
            this.lookUpEditUser.StyleController = this.layoutControl1;
            this.lookUpEditUser.TabIndex = 6;
            this.lookUpEditUser.EditValueChanged += new System.EventHandler(this.lookUpEditUser_EditValueChanged);
            // 
            // segUsuariosBindingSource
            // 
            this.segUsuariosBindingSource.DataMember = "segUsuarios";
            this.segUsuariosBindingSource.DataSource = this.sqlDataSourceSopradeUsers;
            // 
            // sqlDataSourceSopradeUsers
            // 
            this.sqlDataSourceSopradeUsers.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSourceSopradeUsers.Name = "sqlDataSourceSopradeUsers";
            columnExpression1.ColumnName = "usuarioID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"210\" />";
            table1.Name = "UsuariosSistema";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "usuarioNombre";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "segUsuarios";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSourceSopradeUsers.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSourceSopradeUsers.ResultSchemaSerializable = resources.GetString("sqlDataSourceSopradeUsers.ResultSchemaSerializable");
            // 
            // lookUpEditYear
            // 
            this.lookUpEditYear.Location = new System.Drawing.Point(63, 42);
            this.lookUpEditYear.Name = "lookUpEditYear";
            this.lookUpEditYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditYear.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Anio", "Año", 44, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditYear.Properties.DataSource = this.queryBindingSourceYear;
            this.lookUpEditYear.Properties.DisplayMember = "Anio";
            this.lookUpEditYear.Properties.ValueMember = "Anio";
            this.lookUpEditYear.Size = new System.Drawing.Size(161, 20);
            this.lookUpEditYear.StyleController = this.layoutControl1;
            this.lookUpEditYear.TabIndex = 5;
            this.lookUpEditYear.EditValueChanged += new System.EventHandler(this.lookUpEditYear_EditValueChanged);
            // 
            // queryBindingSourceYear
            // 
            this.queryBindingSourceYear.DataMember = "Query";
            this.queryBindingSourceYear.DataSource = this.sqlDataSourceAnio;
            // 
            // sqlDataSourceAnio
            // 
            this.sqlDataSourceAnio.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSourceAnio.Name = "sqlDataSourceAnio";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select 2020 as Anio\r\nunion select 2022 as anio\r\nunion select 2023 as anio\r\nunion " +
    "select 2024 as anio\r\nunion select 2025 as anio\r\nunion select 2026 as anio\r\nunion" +
    " select 2027 as anio\r\n";
            this.sqlDataSourceAnio.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSourceAnio.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZUFuaW8iPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgT" +
    "mFtZT0iQW5pbyIgVHlwZT0iSW50MzIiIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // lookUpEditMonth
            // 
            this.lookUpEditMonth.Location = new System.Drawing.Point(267, 42);
            this.lookUpEditMonth.Name = "lookUpEditMonth";
            this.lookUpEditMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMonth.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mes", "Mes", 29, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditMonth.Properties.DataSource = this.queryBindingSourceMonth;
            this.lookUpEditMonth.Properties.DisplayMember = "Mes";
            this.lookUpEditMonth.Properties.ValueMember = "ID";
            this.lookUpEditMonth.Size = new System.Drawing.Size(252, 20);
            this.lookUpEditMonth.StyleController = this.layoutControl1;
            this.lookUpEditMonth.TabIndex = 4;
            this.lookUpEditMonth.EditValueChanged += new System.EventHandler(this.lookUpEditMonth_EditValueChanged);
            // 
            // queryBindingSourceMonth
            // 
            this.queryBindingSourceMonth.DataMember = "Query";
            this.queryBindingSourceMonth.DataSource = this.sqlDataSourceMes;
            // 
            // sqlDataSourceMes
            // 
            this.sqlDataSourceMes.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSourceMes.Name = "sqlDataSourceMes";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSourceMes.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSourceMes.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZU1lcyI+PFZpZXcgTmFtZT0iUXVlcnkiPjxGaWVsZCBOY" +
    "W1lPSJJRCIgVHlwZT0iSW50MzIiIC8+PEZpZWxkIE5hbWU9Ik1lcyIgVHlwZT0iU3RyaW5nIiAvPjwvV" +
    "mlldz48L0RhdGFTZXQ+";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(948, 504);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(928, 66);
            this.layoutControlGroup2.Text = "Seleccione Rango de Busqueda";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpEditYear;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(204, 24);
            this.layoutControlItem2.Text = "Año";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(36, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpEditMonth;
            this.layoutControlItem1.Location = new System.Drawing.Point(204, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(295, 24);
            this.layoutControlItem1.Text = "Mes";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(36, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookUpEditUser;
            this.layoutControlItem3.Location = new System.Drawing.Point(499, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(405, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Usuario";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(36, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(928, 418);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 504);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Bitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSourceYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSourceMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMonth;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceMes;
        private System.Windows.Forms.BindingSource queryBindingSourceMonth;
        private System.Windows.Forms.BindingSource queryBindingSourceYear;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceAnio;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditYear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditUser;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceSopradeUsers;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.BindingSource segUsuariosBindingSource;
    }
}