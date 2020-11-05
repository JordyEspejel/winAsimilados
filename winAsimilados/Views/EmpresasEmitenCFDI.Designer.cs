namespace winAsimilados.Views
{
    partial class EmpresasEmitenCFDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpresasEmitenCFDI));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEditarInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaja = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAltaEmpr = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlEmpr = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmpr = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtRazon = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnBaja = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnAlta = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnCancelar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnEditar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnGuardar = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.empresaCatalogoCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaCatalogoCFDIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEditarInfo);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnBaja);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.btnAltaEmpr);
            this.layoutControl1.Controls.Add(this.gridControlEmpr);
            this.layoutControl1.Controls.Add(this.txtID);
            this.layoutControl1.Controls.Add(this.txtRazon);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(343, 83, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnEditarInfo
            // 
            this.btnEditarInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarInfo.ImageOptions.Image")));
            this.btnEditarInfo.Location = new System.Drawing.Point(692, 138);
            this.btnEditarInfo.Name = "btnEditarInfo";
            this.btnEditarInfo.Size = new System.Drawing.Size(72, 38);
            this.btnEditarInfo.StyleController = this.layoutControl1;
            this.btnEditarInfo.TabIndex = 14;
            this.btnEditarInfo.Text = "Editar";
            this.btnEditarInfo.Click += new System.EventHandler(this.btnEditarInfo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(36, 138);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 38);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaja.ImageOptions.Image")));
            this.btnBaja.Location = new System.Drawing.Point(234, 138);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(109, 38);
            this.btnBaja.StyleController = this.layoutControl1;
            this.btnBaja.TabIndex = 16;
            this.btnBaja.Text = "Baja Empresa";
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(347, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 38);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAltaEmpr
            // 
            this.btnAltaEmpr.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaEmpr.ImageOptions.Image")));
            this.btnAltaEmpr.Location = new System.Drawing.Point(123, 138);
            this.btnAltaEmpr.Name = "btnAltaEmpr";
            this.btnAltaEmpr.Size = new System.Drawing.Size(107, 38);
            this.btnAltaEmpr.StyleController = this.layoutControl1;
            this.btnAltaEmpr.TabIndex = 18;
            this.btnAltaEmpr.Text = "Alta Empresa";
            this.btnAltaEmpr.Click += new System.EventHandler(this.btnAltaEmpr_Click);
            // 
            // gridControlEmpr
            // 
            this.gridControlEmpr.Location = new System.Drawing.Point(36, 180);
            this.gridControlEmpr.MainView = this.gridViewEmpr;
            this.gridControlEmpr.Name = "gridControlEmpr";
            this.gridControlEmpr.Size = new System.Drawing.Size(728, 234);
            this.gridControlEmpr.TabIndex = 7;
            this.gridControlEmpr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpr});
            // 
            // gridViewEmpr
            // 
            this.gridViewEmpr.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumEmpresa,
            this.colDescripcion,
            this.colEstatus});
            this.gridViewEmpr.GridControl = this.gridControlEmpr;
            this.gridViewEmpr.Name = "gridViewEmpr";
            this.gridViewEmpr.OptionsView.ShowGroupPanel = false;
            // 
            // colNumEmpresa
            // 
            this.colNumEmpresa.Caption = "ID Empresa";
            this.colNumEmpresa.FieldName = "NumEmpresa";
            this.colNumEmpresa.Name = "colNumEmpresa";
            this.colNumEmpresa.OptionsColumn.AllowEdit = false;
            this.colNumEmpresa.Visible = true;
            this.colNumEmpresa.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Razón Social";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colEstatus
            // 
            this.colEstatus.Caption = "Estatus";
            this.colEstatus.FieldName = "Estatus";
            this.colEstatus.Name = "colEstatus";
            this.colEstatus.OptionsColumn.AllowEdit = false;
            this.colEstatus.Visible = true;
            this.colEstatus.VisibleIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(40, 60);
            this.txtID.Name = "txtID";
            this.txtID.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtID.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(69, 20);
            this.txtID.StyleController = this.layoutControl1;
            this.txtID.TabIndex = 4;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(89, 84);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(687, 20);
            this.txtRazon.StyleController = this.layoutControl1;
            this.txtRazon.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(693, 42);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 38);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlGroup3,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(780, 430);
            this.layoutControlGroup2.Text = "Ingrese Información de Empresa";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtRazon;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(756, 24);
            this.layoutControlItem2.Text = "Razón Social";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtID;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 18);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(89, 24);
            this.layoutControlItem1.Text = "ID";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(89, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(580, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAgregar;
            this.layoutControlItem3.Location = new System.Drawing.Point(669, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(87, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlbtnBaja,
            this.layoutControlbtnAlta,
            this.layoutControlbtnCancelar,
            this.layoutControlbtnEditar,
            this.layoutControlbtnGuardar,
            this.emptySpaceItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 66);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(756, 322);
            this.layoutControlGroup3.Text = "Empresas Registradas";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControlEmpr;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(732, 238);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlbtnBaja
            // 
            this.layoutControlbtnBaja.Control = this.btnBaja;
            this.layoutControlbtnBaja.Location = new System.Drawing.Point(198, 0);
            this.layoutControlbtnBaja.Name = "layoutControlbtnBaja";
            this.layoutControlbtnBaja.Size = new System.Drawing.Size(113, 42);
            this.layoutControlbtnBaja.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnBaja.TextVisible = false;
            this.layoutControlbtnBaja.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlbtnAlta
            // 
            this.layoutControlbtnAlta.Control = this.btnAltaEmpr;
            this.layoutControlbtnAlta.Location = new System.Drawing.Point(87, 0);
            this.layoutControlbtnAlta.Name = "layoutControlbtnAlta";
            this.layoutControlbtnAlta.Size = new System.Drawing.Size(111, 42);
            this.layoutControlbtnAlta.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnAlta.TextVisible = false;
            this.layoutControlbtnAlta.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlbtnCancelar
            // 
            this.layoutControlbtnCancelar.Control = this.btnCancelar;
            this.layoutControlbtnCancelar.Location = new System.Drawing.Point(311, 0);
            this.layoutControlbtnCancelar.Name = "layoutControlbtnCancelar";
            this.layoutControlbtnCancelar.Size = new System.Drawing.Size(90, 42);
            this.layoutControlbtnCancelar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnCancelar.TextVisible = false;
            this.layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlbtnEditar
            // 
            this.layoutControlbtnEditar.Control = this.btnEditarInfo;
            this.layoutControlbtnEditar.Location = new System.Drawing.Point(656, 0);
            this.layoutControlbtnEditar.Name = "layoutControlbtnEditar";
            this.layoutControlbtnEditar.Size = new System.Drawing.Size(76, 42);
            this.layoutControlbtnEditar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnEditar.TextVisible = false;
            // 
            // layoutControlbtnGuardar
            // 
            this.layoutControlbtnGuardar.Control = this.btnGuardar;
            this.layoutControlbtnGuardar.Location = new System.Drawing.Point(0, 0);
            this.layoutControlbtnGuardar.Name = "layoutControlbtnGuardar";
            this.layoutControlbtnGuardar.Size = new System.Drawing.Size(87, 42);
            this.layoutControlbtnGuardar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnGuardar.TextVisible = false;
            this.layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(401, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(255, 42);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(89, 18);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // empresaCatalogoCFDIBindingSource
            // 
            this.empresaCatalogoCFDIBindingSource.DataMember = "EmpresaCatalogoCFDI";
            this.empresaCatalogoCFDIBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression3.ColumnName = "NumEmpresa";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"96\" />";
            table2.Name = "EmpresaCatalogoCFDI";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Descripcion";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            selectQuery2.Columns.Add(column3);
            selectQuery2.Columns.Add(column4);
            selectQuery2.Name = "EmpresaCatalogoCFDI";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(692, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 38);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            // 
            // EmpresasEmitenCFDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmpresasEmitenCFDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Empresas que Emiten CFDI";
            this.Load += new System.EventHandler(this.EmpresasEmitenCFDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaCatalogoCFDIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtRazon;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gridControlEmpr;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpr;
        private DevExpress.XtraGrid.Columns.GridColumn colNumEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource empresaCatalogoCFDIBindingSource;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnEditarInfo;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnBaja;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAltaEmpr;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnBaja;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnAlta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnCancelar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnEditar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatus;
    }
}