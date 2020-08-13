namespace winAsimilados.Views
{
    partial class SucursalesBancarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SucursalesBancarias));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlSucursales = new DevExpress.XtraGrid.GridControl();
            this.gridViewSucursales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRazon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCVE = new DevExpress.XtraEditors.TextEdit();
            this.txtDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtRazon = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlBtnAgregar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlBtnEditar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnEliminar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnGuardar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlbtnCancelar = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCVE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBtnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlSucursales);
            this.layoutControl1.Controls.Add(this.txtCVE);
            this.layoutControl1.Controls.Add(this.txtDesc);
            this.layoutControl1.Controls.Add(this.txtRazon);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.btnEditar);
            this.layoutControl1.Controls.Add(this.btnEliminar);
            this.layoutControl1.Controls.Add(this.btnGuardar);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlSucursales
            // 
            this.gridControlSucursales.Location = new System.Drawing.Point(36, 162);
            this.gridControlSucursales.MainView = this.gridViewSucursales;
            this.gridControlSucursales.Name = "gridControlSucursales";
            this.gridControlSucursales.Size = new System.Drawing.Size(728, 252);
            this.gridControlSucursales.TabIndex = 7;
            this.gridControlSucursales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSucursales});
            // 
            // gridViewSucursales
            // 
            this.gridViewSucursales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCVE,
            this.gridColumnDescripcion,
            this.gridColumnRazon});
            this.gridViewSucursales.GridControl = this.gridControlSucursales;
            this.gridViewSucursales.Name = "gridViewSucursales";
            this.gridViewSucursales.OptionsBehavior.Editable = false;
            this.gridViewSucursales.OptionsView.ColumnAutoWidth = false;
            this.gridViewSucursales.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnCVE
            // 
            this.gridColumnCVE.Caption = "CVE Banco";
            this.gridColumnCVE.FieldName = "c_Banco";
            this.gridColumnCVE.Name = "gridColumnCVE";
            this.gridColumnCVE.Visible = true;
            this.gridColumnCVE.VisibleIndex = 0;
            // 
            // gridColumnDescripcion
            // 
            this.gridColumnDescripcion.Caption = "Descripcion";
            this.gridColumnDescripcion.FieldName = "Descripcion";
            this.gridColumnDescripcion.Name = "gridColumnDescripcion";
            this.gridColumnDescripcion.Visible = true;
            this.gridColumnDescripcion.VisibleIndex = 1;
            this.gridColumnDescripcion.Width = 145;
            // 
            // gridColumnRazon
            // 
            this.gridColumnRazon.Caption = "Nombre o razón social";
            this.gridColumnRazon.FieldName = "Nombre o razón social";
            this.gridColumnRazon.Name = "gridColumnRazon";
            this.gridColumnRazon.Visible = true;
            this.gridColumnRazon.VisibleIndex = 2;
            this.gridColumnRazon.Width = 486;
            // 
            // txtCVE
            // 
            this.txtCVE.Location = new System.Drawing.Point(80, 42);
            this.txtCVE.Name = "txtCVE";
            this.txtCVE.Size = new System.Drawing.Size(50, 20);
            this.txtCVE.StyleController = this.layoutControl1;
            this.txtCVE.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(193, 42);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(583, 20);
            this.txtDesc.StyleController = this.layoutControl1;
            this.txtDesc.TabIndex = 5;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(88, 66);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(688, 20);
            this.txtRazon.StyleController = this.layoutControl1;
            this.txtRazon.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(533, 90);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 38);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(620, 90);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 38);
            this.btnEditar.StyleController = this.layoutControl1;
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(696, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 38);
            this.btnEliminar.StyleController = this.layoutControl1;
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(24, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 38);
            this.btnGuardar.StyleController = this.layoutControl1;
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(154, 90);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 38);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Ingrese información de sucursal";
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlGroup3,
            this.emptySpaceItem1,
            this.layoutControlBtnAgregar,
            this.layoutControlBtnEditar,
            this.layoutControlItem3,
            this.layoutControlbtnEliminar,
            this.layoutControlbtnGuardar,
            this.layoutControlbtnCancelar});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(780, 430);
            this.layoutControlGroup2.Text = "Ingrese información de sucursal";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCVE;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(110, 24);
            this.layoutControlItem1.Text = "Cve Banco";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(51, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDesc;
            this.layoutControlItem2.Location = new System.Drawing.Point(110, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(646, 24);
            this.layoutControlItem2.Text = "Descripción";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(54, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 90);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(756, 298);
            this.layoutControlGroup3.Text = "Bancos registrados";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControlSucursales;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(732, 256);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(220, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(289, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlBtnAgregar
            // 
            this.layoutControlBtnAgregar.Control = this.btnAgregar;
            this.layoutControlBtnAgregar.Location = new System.Drawing.Point(509, 48);
            this.layoutControlBtnAgregar.Name = "layoutControlBtnAgregar";
            this.layoutControlBtnAgregar.Size = new System.Drawing.Size(87, 42);
            this.layoutControlBtnAgregar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlBtnAgregar.TextVisible = false;
            // 
            // layoutControlBtnEditar
            // 
            this.layoutControlBtnEditar.Control = this.btnEditar;
            this.layoutControlBtnEditar.Location = new System.Drawing.Point(596, 48);
            this.layoutControlBtnEditar.Name = "layoutControlBtnEditar";
            this.layoutControlBtnEditar.Size = new System.Drawing.Size(76, 42);
            this.layoutControlBtnEditar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlBtnEditar.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtRazon;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(756, 24);
            this.layoutControlItem3.Text = "Razón social";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(59, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlbtnEliminar
            // 
            this.layoutControlbtnEliminar.Control = this.btnEliminar;
            this.layoutControlbtnEliminar.Location = new System.Drawing.Point(672, 48);
            this.layoutControlbtnEliminar.Name = "layoutControlbtnEliminar";
            this.layoutControlbtnEliminar.Size = new System.Drawing.Size(84, 42);
            this.layoutControlbtnEliminar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnEliminar.TextVisible = false;
            // 
            // layoutControlbtnGuardar
            // 
            this.layoutControlbtnGuardar.Control = this.btnGuardar;
            this.layoutControlbtnGuardar.Location = new System.Drawing.Point(0, 48);
            this.layoutControlbtnGuardar.Name = "layoutControlbtnGuardar";
            this.layoutControlbtnGuardar.Size = new System.Drawing.Size(130, 42);
            this.layoutControlbtnGuardar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnGuardar.TextVisible = false;
            this.layoutControlbtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlbtnCancelar
            // 
            this.layoutControlbtnCancelar.Control = this.btnCancelar;
            this.layoutControlbtnCancelar.Location = new System.Drawing.Point(130, 48);
            this.layoutControlbtnCancelar.Name = "layoutControlbtnCancelar";
            this.layoutControlbtnCancelar.Size = new System.Drawing.Size(90, 42);
            this.layoutControlbtnCancelar.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlbtnCancelar.TextVisible = false;
            this.layoutControlbtnCancelar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // SucursalesBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SucursalesBancarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sucursales Bancarias";
            this.Load += new System.EventHandler(this.SucursalesBancarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCVE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBtnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlbtnCancelar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControlSucursales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSucursales;
        private DevExpress.XtraEditors.TextEdit txtCVE;
        private DevExpress.XtraEditors.TextEdit txtDesc;
        private DevExpress.XtraEditors.TextEdit txtRazon;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlBtnAgregar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCVE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRazon;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlBtnEditar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlbtnCancelar;
    }
}