namespace winAsimilados.Views
{
    partial class AltaClavesSAT
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Sorting sorting2 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaClavesSAT));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlClave = new DevExpress.XtraGrid.GridControl();
            this.gridViewClave = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIDClte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnClaveServProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEmpr = new DevExpress.XtraEditors.LookUpEdit();
            this.clientesAsimiladosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuitar = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpClave = new DevExpress.XtraEditors.LookUpEdit();
            this.claveProdServBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlLookUpClave = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnAgregar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnQuitar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmpr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesAsimiladosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claveProdServBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLookUpClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnQuitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlClave);
            this.layoutControl1.Controls.Add(this.lookUpEmpr);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.btnQuitar);
            this.layoutControl1.Controls.Add(this.lookUpClave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 188, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlClave
            // 
            this.gridControlClave.Location = new System.Drawing.Point(36, 190);
            this.gridControlClave.MainView = this.gridViewClave;
            this.gridControlClave.Name = "gridControlClave";
            this.gridControlClave.Size = new System.Drawing.Size(728, 224);
            this.gridControlClave.TabIndex = 5;
            this.gridControlClave.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClave});
            // 
            // gridViewClave
            // 
            this.gridViewClave.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnIDClte,
            this.gridColumnCliente,
            this.gridColumnClaveServProd,
            this.gridColumnConcepto});
            this.gridViewClave.GridControl = this.gridControlClave;
            this.gridViewClave.Name = "gridViewClave";
            this.gridViewClave.OptionsBehavior.Editable = false;
            this.gridViewClave.OptionsView.ColumnAutoWidth = false;
            this.gridViewClave.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.Name = "gridColumnID";
            // 
            // gridColumnIDClte
            // 
            this.gridColumnIDClte.Caption = "ID Cliente";
            this.gridColumnIDClte.FieldName = "IDClte";
            this.gridColumnIDClte.Name = "gridColumnIDClte";
            // 
            // gridColumnCliente
            // 
            this.gridColumnCliente.Caption = "Cliente";
            this.gridColumnCliente.FieldName = "Cliente";
            this.gridColumnCliente.Name = "gridColumnCliente";
            // 
            // gridColumnClaveServProd
            // 
            this.gridColumnClaveServProd.Caption = "Clave";
            this.gridColumnClaveServProd.FieldName = "ClaveServProd";
            this.gridColumnClaveServProd.Name = "gridColumnClaveServProd";
            this.gridColumnClaveServProd.Visible = true;
            this.gridColumnClaveServProd.VisibleIndex = 0;
            // 
            // gridColumnConcepto
            // 
            this.gridColumnConcepto.Caption = "Descripción";
            this.gridColumnConcepto.FieldName = "Concepto";
            this.gridColumnConcepto.Name = "gridColumnConcepto";
            this.gridColumnConcepto.Visible = true;
            this.gridColumnConcepto.VisibleIndex = 1;
            this.gridColumnConcepto.Width = 630;
            // 
            // lookUpEmpr
            // 
            this.lookUpEmpr.Location = new System.Drawing.Point(58, 42);
            this.lookUpEmpr.Name = "lookUpEmpr";
            this.lookUpEmpr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEmpr.Properties.DataSource = this.clientesAsimiladosBindingSource;
            this.lookUpEmpr.Properties.DisplayMember = "CLIENTE";
            this.lookUpEmpr.Properties.NullText = "Seleccione";
            this.lookUpEmpr.Properties.ValueMember = "ID";
            this.lookUpEmpr.Size = new System.Drawing.Size(718, 20);
            this.lookUpEmpr.StyleController = this.layoutControl1;
            this.lookUpEmpr.TabIndex = 4;
            this.lookUpEmpr.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // clientesAsimiladosBindingSource
            // 
            this.clientesAsimiladosBindingSource.DataMember = "ClientesAsimilados";
            this.clientesAsimiladosBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression6.ColumnName = "ID";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"666\" />";
            table3.Name = "ClientesAsimilados";
            columnExpression6.Table = table3;
            column5.Expression = columnExpression6;
            columnExpression7.ColumnName = "CLIENTE";
            columnExpression7.Table = table3;
            column6.Expression = columnExpression7;
            selectQuery3.Columns.Add(column5);
            selectQuery3.Columns.Add(column6);
            selectQuery3.FilterString = "[ClientesAsimilados.ID] <> \'E00000\'";
            selectQuery3.GroupFilterString = "";
            selectQuery3.Name = "ClientesAsimilados";
            columnExpression8.ColumnName = "ID";
            columnExpression8.Table = table3;
            sorting2.Expression = columnExpression8;
            selectQuery3.Sorting.Add(sorting2);
            selectQuery3.Tables.Add(table3);
            columnExpression9.ColumnName = "c_ClaveProdServ";
            table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"115\" />";
            table4.Name = "ClaveProdServ";
            columnExpression9.Table = table4;
            column7.Expression = columnExpression9;
            columnExpression10.ColumnName = "Descripcion";
            columnExpression10.Table = table4;
            column8.Expression = columnExpression10;
            selectQuery4.Columns.Add(column7);
            selectQuery4.Columns.Add(column8);
            selectQuery4.Name = "ClaveProdServ";
            selectQuery4.Tables.Add(table4);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3,
            selectQuery4});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(603, 96);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 38);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.ImageOptions.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(690, 96);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(74, 38);
            this.btnQuitar.StyleController = this.layoutControl1;
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lookUpClave
            // 
            this.lookUpClave.Location = new System.Drawing.Point(68, 96);
            this.lookUpClave.Name = "lookUpClave";
            this.lookUpClave.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpClave.Properties.DataSource = this.claveProdServBindingSource;
            this.lookUpClave.Properties.DisplayMember = "Descripcion";
            this.lookUpClave.Properties.NullText = "Seleccione";
            this.lookUpClave.Properties.ValueMember = "c_ClaveProdServ";
            this.lookUpClave.Size = new System.Drawing.Size(531, 20);
            this.lookUpClave.StyleController = this.layoutControl1;
            this.lookUpClave.TabIndex = 8;
            // 
            // claveProdServBindingSource
            // 
            this.claveProdServBindingSource.DataMember = "ClaveProdServ";
            this.claveProdServBindingSource.DataSource = this.sqlDataSource1;
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
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(780, 430);
            this.layoutControlGroup2.Text = "Seleccione Cliente  Para Dar De Allta Claves de Factiración";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpEmpr;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(756, 24);
            this.layoutControlItem1.Text = "Clente";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(31, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 108);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(756, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlLookUpClave,
            this.layoutControlbtnAgregar,
            this.layoutControlbtnQuitar});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(756, 84);
            this.layoutControlGroup3.Text = "Seleccione Clave";
            this.layoutControlGroup3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlLookUpClave
            // 
            this.layoutControlLookUpClave.Control = this.lookUpClave;
            this.layoutControlLookUpClave.Location = new System.Drawing.Point(0, 0);
            this.layoutControlLookUpClave.Name = "layoutControlLookUpClave";
            this.layoutControlLookUpClave.Size = new System.Drawing.Size(567, 42);
            this.layoutControlLookUpClave.Text = "Clave";
            this.layoutControlLookUpClave.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlLookUpClave.TextSize = new System.Drawing.Size(27, 13);
            this.layoutControlLookUpClave.TextToControlDistance = 5;
            this.layoutControlLookUpClave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlbtnAgregar
            // 
            this.layoutControlbtnAgregar.Control = this.btnAgregar;
            this.layoutControlbtnAgregar.Location = new System.Drawing.Point(567, 0);
            this.layoutControlbtnAgregar.Name = "layoutControlbtnAgregar";
            this.layoutControlbtnAgregar.Size = new System.Drawing.Size(87, 42);
            this.layoutControlbtnAgregar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnAgregar.TextVisible = false;
            this.layoutControlbtnAgregar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlbtnQuitar
            // 
            this.layoutControlbtnQuitar.Control = this.btnQuitar;
            this.layoutControlbtnQuitar.Location = new System.Drawing.Point(654, 0);
            this.layoutControlbtnQuitar.Name = "layoutControlbtnQuitar";
            this.layoutControlbtnQuitar.Size = new System.Drawing.Size(78, 42);
            this.layoutControlbtnQuitar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnQuitar.TextVisible = false;
            this.layoutControlbtnQuitar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 118);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(756, 270);
            this.layoutControlGroup4.Text = "Lista Claves Activadas";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlClave;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(732, 228);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // AltaClavesSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AltaClavesSAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alta Claves SAT";
            this.Load += new System.EventHandler(this.AltaClavesSAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmpr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesAsimiladosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claveProdServBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLookUpClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnQuitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEmpr;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControlClave;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource clientesAsimiladosBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnQuitar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnQuitar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnAgregar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLookUpClave;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraEditors.LookUpEdit lookUpClave;
        private System.Windows.Forms.BindingSource claveProdServBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIDClte;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCliente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnClaveServProd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnConcepto;
    }
}