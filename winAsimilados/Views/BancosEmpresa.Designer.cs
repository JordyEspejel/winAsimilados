namespace winAsimilados.Views
{
    partial class BancosEmpresa
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BancosEmpresa));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlBancos = new DevExpress.XtraGrid.GridControl();
            this.gridViewBancos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIDEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCLABE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEmpresa = new DevExpress.XtraEditors.LookUpEdit();
            this.empresaPagaAsimiladosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtCuenta = new DevExpress.XtraEditors.TextEdit();
            this.txtCLABE = new DevExpress.XtraEditors.TextEdit();
            this.lookUpBanco = new DevExpress.XtraEditors.LookUpEdit();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnEditar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlBtnGuardar = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaPagaAsimiladosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCLABE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlBancos);
            this.layoutControl1.Controls.Add(this.lookUpEmpresa);
            this.layoutControl1.Controls.Add(this.txtCuenta);
            this.layoutControl1.Controls.Add(this.txtCLABE);
            this.layoutControl1.Controls.Add(this.lookUpBanco);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnEditar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(835, 575);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlBancos
            // 
            this.gridControlBancos.Location = new System.Drawing.Point(36, 262);
            this.gridControlBancos.MainView = this.gridViewBancos;
            this.gridControlBancos.Name = "gridControlBancos";
            this.gridControlBancos.Size = new System.Drawing.Size(763, 277);
            this.gridControlBancos.TabIndex = 8;
            this.gridControlBancos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBancos});
            // 
            // gridViewBancos
            // 
            this.gridViewBancos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnIDEmpresa,
            this.gridColumnRazonSocial,
            this.gridColumnBanco,
            this.gridColumnCuenta,
            this.gridColumnCLABE});
            this.gridViewBancos.GridControl = this.gridControlBancos;
            this.gridViewBancos.Name = "gridViewBancos";
            this.gridViewBancos.OptionsView.ColumnAutoWidth = false;
            this.gridViewBancos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.Name = "gridColumnID";
            // 
            // gridColumnIDEmpresa
            // 
            this.gridColumnIDEmpresa.Caption = "ID Empresa";
            this.gridColumnIDEmpresa.FieldName = "IDEmpresa";
            this.gridColumnIDEmpresa.Name = "gridColumnIDEmpresa";
            // 
            // gridColumnRazonSocial
            // 
            this.gridColumnRazonSocial.Caption = "Razon Social";
            this.gridColumnRazonSocial.FieldName = "RazonSocial";
            this.gridColumnRazonSocial.Name = "gridColumnRazonSocial";
            // 
            // gridColumnBanco
            // 
            this.gridColumnBanco.Caption = "Banco";
            this.gridColumnBanco.FieldName = "Banco";
            this.gridColumnBanco.Name = "gridColumnBanco";
            this.gridColumnBanco.OptionsColumn.AllowEdit = false;
            this.gridColumnBanco.Visible = true;
            this.gridColumnBanco.VisibleIndex = 0;
            this.gridColumnBanco.Width = 252;
            // 
            // gridColumnCuenta
            // 
            this.gridColumnCuenta.Caption = "Cuenta";
            this.gridColumnCuenta.FieldName = "Cuenta";
            this.gridColumnCuenta.Name = "gridColumnCuenta";
            this.gridColumnCuenta.OptionsColumn.AllowEdit = false;
            this.gridColumnCuenta.Visible = true;
            this.gridColumnCuenta.VisibleIndex = 1;
            this.gridColumnCuenta.Width = 212;
            // 
            // gridColumnCLABE
            // 
            this.gridColumnCLABE.Caption = "CLABE";
            this.gridColumnCLABE.FieldName = "CLABE";
            this.gridColumnCLABE.Name = "gridColumnCLABE";
            this.gridColumnCLABE.OptionsColumn.AllowEdit = false;
            this.gridColumnCLABE.Visible = true;
            this.gridColumnCLABE.VisibleIndex = 2;
            this.gridColumnCLABE.Width = 279;
            // 
            // lookUpEmpresa
            // 
            this.lookUpEmpresa.Location = new System.Drawing.Point(70, 42);
            this.lookUpEmpresa.Name = "lookUpEmpresa";
            this.lookUpEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEmpresa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDEmpresa", "ID Empresa", 78, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazonSocial", "Razon Social", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEmpresa.Properties.DataSource = this.empresaPagaAsimiladosBindingSource;
            this.lookUpEmpresa.Properties.DisplayMember = "RazonSocial";
            this.lookUpEmpresa.Properties.NullText = "Seleccione";
            this.lookUpEmpresa.Properties.ValueMember = "IDEmpresa";
            this.lookUpEmpresa.Size = new System.Drawing.Size(741, 20);
            this.lookUpEmpresa.StyleController = this.layoutControl1;
            this.lookUpEmpresa.TabIndex = 4;
            this.lookUpEmpresa.EditValueChanged += new System.EventHandler(this.lookUpEmpresa_EditValueChanged);
            // 
            // empresaPagaAsimiladosBindingSource
            // 
            this.empresaPagaAsimiladosBindingSource.DataMember = "EmpresaPagaAsimilados";
            this.empresaPagaAsimiladosBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "IDEmpresa";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"134\" />";
            table1.Name = "EmpresaPagaAsimilados";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "RazonSocial";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Name = "EmpresaPagaAsimilados";
            selectQuery1.Tables.Add(table1);
            columnExpression3.ColumnName = "c_Banco";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"134\" />";
            table2.Name = "Bancos";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Descripcion";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            selectQuery2.Columns.Add(column3);
            selectQuery2.Columns.Add(column4);
            selectQuery2.Name = "Bancos";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(90, 138);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(288, 20);
            this.txtCuenta.StyleController = this.layoutControl1;
            this.txtCuenta.TabIndex = 6;
            // 
            // txtCLABE
            // 
            this.txtCLABE.Location = new System.Drawing.Point(418, 138);
            this.txtCLABE.Name = "txtCLABE";
            this.txtCLABE.Size = new System.Drawing.Size(381, 20);
            this.txtCLABE.StyleController = this.layoutControl1;
            this.txtCLABE.TabIndex = 7;
            // 
            // lookUpBanco
            // 
            this.lookUpBanco.Location = new System.Drawing.Point(70, 96);
            this.lookUpBanco.Name = "lookUpBanco";
            this.lookUpBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBanco.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("c_Banco", "c_Banco", 63, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpBanco.Properties.DataSource = this.bancosBindingSource;
            this.lookUpBanco.Properties.DisplayMember = "Descripcion";
            this.lookUpBanco.Properties.NullText = "Seleccione";
            this.lookUpBanco.Properties.ValueMember = "Descripcion";
            this.lookUpBanco.Size = new System.Drawing.Size(558, 20);
            this.lookUpBanco.StyleController = this.layoutControl1;
            this.lookUpBanco.TabIndex = 5;
            // 
            // bancosBindingSource
            // 
            this.bancosBindingSource.DataMember = "Bancos";
            this.bancosBindingSource.DataSource = this.sqlDataSource1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(632, 96);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 38);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(719, 96);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 38);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(36, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 38);
            this.btnEditar.StyleController = this.layoutControl1;
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(116, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 38);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(835, 575);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup3,
            this.emptySpaceItem1,
            this.layoutControlGroup4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(815, 555);
            this.layoutControlGroup2.Text = "Seleccione Empresa para configurar bancos";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpEmpresa;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(791, 24);
            this.layoutControlItem1.Text = "Empresa";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(791, 108);
            this.layoutControlGroup3.Text = "Seleccione Banco";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpBanco;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(596, 42);
            this.layoutControlItem2.Text = "Banco";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(29, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCuenta;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(346, 24);
            this.layoutControlItem3.Text = " # Cuenta";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(49, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtCLABE;
            this.layoutControlItem4.Location = new System.Drawing.Point(346, 42);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(421, 24);
            this.layoutControlItem4.Text = "CLABE";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(31, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnEliminar;
            this.layoutControlItem7.Location = new System.Drawing.Point(683, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(84, 42);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnAgregar;
            this.layoutControlItem6.Location = new System.Drawing.Point(596, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(87, 42);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 132);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(791, 16);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlbtnEditar,
            this.layoutControlBtnGuardar,
            this.emptySpaceItem2});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 148);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(791, 365);
            this.layoutControlGroup4.Text = "Lista de bancos Activos";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControlBancos;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(767, 281);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlbtnEditar
            // 
            this.layoutControlbtnEditar.Control = this.btnEditar;
            this.layoutControlbtnEditar.Location = new System.Drawing.Point(0, 0);
            this.layoutControlbtnEditar.Name = "layoutControlbtnEditar";
            this.layoutControlbtnEditar.Size = new System.Drawing.Size(80, 42);
            this.layoutControlbtnEditar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnEditar.TextVisible = false;
            this.layoutControlbtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlBtnGuardar
            // 
            this.layoutControlBtnGuardar.Control = this.btnGuardar;
            this.layoutControlBtnGuardar.Location = new System.Drawing.Point(80, 0);
            this.layoutControlBtnGuardar.Name = "layoutControlBtnGuardar";
            this.layoutControlBtnGuardar.Size = new System.Drawing.Size(87, 42);
            this.layoutControlBtnGuardar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlBtnGuardar.TextVisible = false;
            this.layoutControlBtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(167, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(600, 42);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            this.emptySpaceItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // BancosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 575);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BancosEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bancos Empresa";
            this.Load += new System.EventHandler(this.BancosEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaPagaAsimiladosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCLABE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEmpresa;
        private DevExpress.XtraEditors.TextEdit txtCuenta;
        private DevExpress.XtraEditors.TextEdit txtCLABE;
        private DevExpress.XtraEditors.LookUpEdit lookUpBanco;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl gridControlBancos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBancos;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource empresaPagaAsimiladosBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnEditar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIDEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBanco;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCLABE;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlBtnGuardar;
    }
}