namespace winAsimilados.Views
{
    partial class CancelarCFDI
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarCFDI));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRutXML = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFecPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFecIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSelloCFD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.FecFinal = new System.Windows.Forms.DateTimePicker();
            this.FecIni = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAsimilados.Views.WaitForm1), true, true, true);
            this.ColTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.FecFinal);
            this.layoutControl1.Controls.Add(this.FecIni);
            this.layoutControl1.Controls.Add(this.BtnBuscar);
            this.layoutControl1.Controls.Add(this.simpleButton1);
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
            this.gridControl1.Location = new System.Drawing.Point(12, 96);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(924, 354);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColFolio,
            this.ColUUID,
            this.ColRutXML,
            this.ColEmpleado,
            this.ColRFC,
            this.ColImporte,
            this.ColStat,
            this.ColFecPago,
            this.ColFecIni,
            this.colFecFin,
            this.ColSelloCFD,
            this.ColTotal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ColFolio
            // 
            this.ColFolio.Caption = "Folio";
            this.ColFolio.FieldName = "Folio";
            this.ColFolio.Name = "ColFolio";
            this.ColFolio.OptionsColumn.AllowEdit = false;
            this.ColFolio.Visible = true;
            this.ColFolio.VisibleIndex = 1;
            // 
            // ColUUID
            // 
            this.ColUUID.Caption = "UUID";
            this.ColUUID.FieldName = "UUID";
            this.ColUUID.Name = "ColUUID";
            this.ColUUID.OptionsColumn.AllowEdit = false;
            this.ColUUID.Visible = true;
            this.ColUUID.VisibleIndex = 2;
            // 
            // ColRutXML
            // 
            this.ColRutXML.Caption = "Ruta XML";
            this.ColRutXML.FieldName = "Ruta XML";
            this.ColRutXML.Name = "ColRutXML";
            this.ColRutXML.OptionsColumn.AllowEdit = false;
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.Caption = "Empleado";
            this.ColEmpleado.FieldName = "Empleado";
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.OptionsColumn.AllowEdit = false;
            this.ColEmpleado.Visible = true;
            this.ColEmpleado.VisibleIndex = 4;
            // 
            // ColRFC
            // 
            this.ColRFC.Caption = "RFC";
            this.ColRFC.FieldName = "RFC";
            this.ColRFC.Name = "ColRFC";
            this.ColRFC.OptionsColumn.AllowEdit = false;
            this.ColRFC.Visible = true;
            this.ColRFC.VisibleIndex = 5;
            // 
            // ColImporte
            // 
            this.ColImporte.Caption = "Importe";
            this.ColImporte.FieldName = "Importe";
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.OptionsColumn.AllowEdit = false;
            this.ColImporte.Visible = true;
            this.ColImporte.VisibleIndex = 6;
            // 
            // ColStat
            // 
            this.ColStat.Caption = "Status SAT";
            this.ColStat.FieldName = "Status SAT";
            this.ColStat.Name = "ColStat";
            this.ColStat.OptionsColumn.AllowEdit = false;
            this.ColStat.Visible = true;
            this.ColStat.VisibleIndex = 8;
            // 
            // ColFecPago
            // 
            this.ColFecPago.Caption = "Fecha Pago";
            this.ColFecPago.FieldName = "Fecha Pago";
            this.ColFecPago.Name = "ColFecPago";
            this.ColFecPago.OptionsColumn.AllowEdit = false;
            this.ColFecPago.Visible = true;
            this.ColFecPago.VisibleIndex = 9;
            // 
            // ColFecIni
            // 
            this.ColFecIni.Caption = "Fecha Inicio";
            this.ColFecIni.FieldName = "Fecha Inicio";
            this.ColFecIni.Name = "ColFecIni";
            this.ColFecIni.OptionsColumn.AllowEdit = false;
            this.ColFecIni.Visible = true;
            this.ColFecIni.VisibleIndex = 10;
            // 
            // colFecFin
            // 
            this.colFecFin.Caption = "Fecha Final";
            this.colFecFin.FieldName = "Fecha Final";
            this.colFecFin.Name = "colFecFin";
            this.colFecFin.OptionsColumn.AllowEdit = false;
            this.colFecFin.Visible = true;
            this.colFecFin.VisibleIndex = 11;
            // 
            // ColSelloCFD
            // 
            this.ColSelloCFD.Caption = "SelloCFD";
            this.ColSelloCFD.FieldName = "SelloCFD";
            this.ColSelloCFD.Name = "ColSelloCFD";
            this.ColSelloCFD.Visible = true;
            this.ColSelloCFD.VisibleIndex = 3;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.repositoryItemButtonEdit1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "Cancelar CFDI", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemButtonEdit1.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.ContextImageOptions.Image")));
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemButtonEdit1.UseReadOnlyAppearance = false;
            // 
            // FecFinal
            // 
            this.FecFinal.Location = new System.Drawing.Point(514, 42);
            this.FecFinal.Name = "FecFinal";
            this.FecFinal.Size = new System.Drawing.Size(357, 20);
            this.FecFinal.TabIndex = 5;
            // 
            // FecIni
            // 
            this.FecIni.Location = new System.Drawing.Point(84, 42);
            this.FecIni.Name = "FecIni";
            this.FecIni.Size = new System.Drawing.Size(366, 20);
            this.FecIni.TabIndex = 4;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.ImageOptions.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(875, 42);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(49, 38);
            this.BtnBuscar.StyleController = this.layoutControl1;
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(747, 454);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(189, 38);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Cancelar CFDI";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(948, 504);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(928, 84);
            this.layoutControlGroup2.Text = "Seleccione Rango De Fechas";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.FecIni;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(430, 42);
            this.layoutControlItem1.Text = "Fecha Inicio";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.FecFinal;
            this.layoutControlItem2.Location = new System.Drawing.Point(430, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(421, 42);
            this.layoutControlItem2.Text = "Fecha Fin";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BtnBuscar;
            this.layoutControlItem3.Location = new System.Drawing.Point(851, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(53, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(928, 358);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.Location = new System.Drawing.Point(735, 442);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(193, 42);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 442);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(735, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // ColTotal
            // 
            this.ColTotal.Caption = "Total";
            this.ColTotal.FieldName = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.Visible = true;
            this.ColTotal.VisibleIndex = 7;
            // 
            // CancelarCFDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 504);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CancelarCFDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cancelar CFDI";
            this.Load += new System.EventHandler(this.CancelarCFDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DateTimePicker FecFinal;
        private System.Windows.Forms.DateTimePicker FecIni;
        private DevExpress.XtraEditors.SimpleButton BtnBuscar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn ColFolio;
        private DevExpress.XtraGrid.Columns.GridColumn ColUUID;
        private DevExpress.XtraGrid.Columns.GridColumn ColRutXML;
        private DevExpress.XtraGrid.Columns.GridColumn ColEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn ColRFC;
        private DevExpress.XtraGrid.Columns.GridColumn ColImporte;
        private DevExpress.XtraGrid.Columns.GridColumn ColStat;
        private DevExpress.XtraGrid.Columns.GridColumn ColFecPago;
        private DevExpress.XtraGrid.Columns.GridColumn ColFecIni;
        private DevExpress.XtraGrid.Columns.GridColumn colFecFin;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.Columns.GridColumn ColSelloCFD;
        private DevExpress.XtraGrid.Columns.GridColumn ColTotal;
    }
}