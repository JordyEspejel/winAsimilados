namespace winAsimilados.Views
{
    partial class EmpresasPagoAsimilados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpresasPagoAsimilados));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlEmpr = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmpr = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIDEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.queryStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.txtRazon = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgre = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaja = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAltaEmpr = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnEditar = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlbtnGuardar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnBaja = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnCancelar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnAlta = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnAgregar = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlEmpr);
            this.layoutControl1.Controls.Add(this.txtRazon);
            this.layoutControl1.Controls.Add(this.txtID);
            this.layoutControl1.Controls.Add(this.txtRFC);
            this.layoutControl1.Controls.Add(this.btnEditar);
            this.layoutControl1.Controls.Add(this.btnAgre);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnBaja);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.btnAltaEmpr);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 481);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlEmpr
            // 
            this.gridControlEmpr.Location = new System.Drawing.Point(36, 180);
            this.gridControlEmpr.MainView = this.gridViewEmpr;
            this.gridControlEmpr.Name = "gridControlEmpr";
            this.gridControlEmpr.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlEmpr.Size = new System.Drawing.Size(728, 265);
            this.gridControlEmpr.TabIndex = 7;
            this.gridControlEmpr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpr});
            // 
            // gridViewEmpr
            // 
            this.gridViewEmpr.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnIDEmpresa,
            this.gridColumnRFC,
            this.gridColumnRazonSocial,
            this.gridColumnEstatus});
            this.gridViewEmpr.GridControl = this.gridControlEmpr;
            this.gridViewEmpr.Name = "gridViewEmpr";
            this.gridViewEmpr.OptionsView.ColumnAutoWidth = false;
            this.gridViewEmpr.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.OptionsColumn.AllowEdit = false;
            this.gridColumnID.Width = 53;
            // 
            // gridColumnIDEmpresa
            // 
            this.gridColumnIDEmpresa.Caption = "ID Empresa";
            this.gridColumnIDEmpresa.FieldName = "IDEmpresa";
            this.gridColumnIDEmpresa.Name = "gridColumnIDEmpresa";
            this.gridColumnIDEmpresa.OptionsColumn.AllowEdit = false;
            this.gridColumnIDEmpresa.Visible = true;
            this.gridColumnIDEmpresa.VisibleIndex = 0;
            // 
            // gridColumnRFC
            // 
            this.gridColumnRFC.Caption = "RFC";
            this.gridColumnRFC.FieldName = "RFC";
            this.gridColumnRFC.Name = "gridColumnRFC";
            this.gridColumnRFC.OptionsColumn.AllowEdit = false;
            this.gridColumnRFC.Visible = true;
            this.gridColumnRFC.VisibleIndex = 1;
            this.gridColumnRFC.Width = 147;
            // 
            // gridColumnRazonSocial
            // 
            this.gridColumnRazonSocial.Caption = "Razon Social";
            this.gridColumnRazonSocial.FieldName = "RazonSocial";
            this.gridColumnRazonSocial.Name = "gridColumnRazonSocial";
            this.gridColumnRazonSocial.OptionsColumn.AllowEdit = false;
            this.gridColumnRazonSocial.Visible = true;
            this.gridColumnRazonSocial.VisibleIndex = 2;
            this.gridColumnRazonSocial.Width = 394;
            // 
            // gridColumnEstatus
            // 
            this.gridColumnEstatus.Caption = "Estatus";
            this.gridColumnEstatus.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumnEstatus.FieldName = "Estatus";
            this.gridColumnEstatus.Name = "gridColumnEstatus";
            this.gridColumnEstatus.OptionsColumn.AllowEdit = false;
            this.gridColumnEstatus.Visible = true;
            this.gridColumnEstatus.VisibleIndex = 3;
            this.gridColumnEstatus.Width = 92;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.queryStatusBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descripcion";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "c_Status";
            // 
            // queryStatusBindingSource
            // 
            this.queryStatusBindingSource.DataMember = "QueryStatus";
            this.queryStatusBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery2.Name = "QueryStatus";
            customSqlQuery2.Sql = "SELECT \'A\' AS [c_Status], \'Activa\' AS [Descripcion]\r\nUNION SELECT \'I\' AS [c_Statu" +
    "s], \'Inactiva\' AS [Descripcion]";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(89, 84);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazon.Size = new System.Drawing.Size(469, 20);
            this.txtRazon.StyleController = this.layoutControl1;
            this.txtRazon.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(40, 60);
            this.txtID.Name = "txtID";
            this.txtID.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtID.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(74, 20);
            this.txtID.StyleController = this.layoutControl1;
            this.txtID.TabIndex = 5;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(587, 84);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Size = new System.Drawing.Size(189, 20);
            this.txtRFC.StyleController = this.layoutControl1;
            this.txtRFC.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(692, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 38);
            this.btnEditar.StyleController = this.layoutControl1;
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgre
            // 
            this.btnAgre.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgre.ImageOptions.Image")));
            this.btnAgre.Location = new System.Drawing.Point(693, 42);
            this.btnAgre.Name = "btnAgre";
            this.btnAgre.Size = new System.Drawing.Size(83, 38);
            this.btnAgre.StyleController = this.layoutControl1;
            this.btnAgre.TabIndex = 9;
            this.btnAgre.Text = "Agregar";
            this.btnAgre.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(36, 138);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 38);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 10;
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
            this.btnBaja.TabIndex = 11;
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
            this.btnCancelar.TabIndex = 12;
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
            this.btnAltaEmpr.TabIndex = 13;
            this.btnAltaEmpr.Text = "Alta Empresa";
            this.btnAltaEmpr.Click += new System.EventHandler(this.btnAltaEmpr_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 481);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlGroup3,
            this.btnAgregar,
            this.emptySpaceItem1,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(780, 461);
            this.layoutControlGroup2.Text = "Ingrese datos de Empresa";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtRazon;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(538, 24);
            this.layoutControlItem1.Text = "Razon Social";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtID;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 18);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(94, 24);
            this.layoutControlItem2.Text = "ID";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtRFC;
            this.layoutControlItem3.Location = new System.Drawing.Point(538, 42);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(218, 24);
            this.layoutControlItem3.Text = "RFC";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(20, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlbtnEditar,
            this.emptySpaceItem2,
            this.layoutControlbtnGuardar,
            this.layoutControlbtnBaja,
            this.layoutControlbtnCancelar,
            this.layoutControlbtnAlta});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 66);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(756, 353);
            this.layoutControlGroup3.Text = "Empresas Registradas";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControlEmpr;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(732, 269);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlbtnEditar
            // 
            this.layoutControlbtnEditar.Control = this.btnEditar;
            this.layoutControlbtnEditar.Location = new System.Drawing.Point(656, 0);
            this.layoutControlbtnEditar.Name = "layoutControlbtnEditar";
            this.layoutControlbtnEditar.Size = new System.Drawing.Size(76, 42);
            this.layoutControlbtnEditar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnEditar.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(401, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(255, 42);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
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
            // btnAgregar
            // 
            this.btnAgregar.Control = this.btnAgre;
            this.btnAgregar.Location = new System.Drawing.Point(669, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 42);
            this.btnAgregar.TextSize = new System.Drawing.Size(0, 0);
            this.btnAgregar.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(94, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(575, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(94, 18);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // EmpresasPagoAsimilados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmpresasPagoAsimilados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Empresas Paga Asimilados";
            this.Load += new System.EventHandler(this.EmpresasPagoAsimilados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControlEmpr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpr;
        private DevExpress.XtraEditors.TextEdit txtRazon;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtRFC;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIDEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRFC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEstatus;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnEditar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource queryStatusBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton btnAgre;
        private DevExpress.XtraLayout.LayoutControlItem btnAgregar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnBaja;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnBaja;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAltaEmpr;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnAlta;
    }
}