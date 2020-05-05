namespace winAsimilados.Views
{
    partial class EditarEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEmpresa));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery71 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column141 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression141 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table71 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column142 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression142 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery72 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column143 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression143 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table72 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column144 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression144 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery73 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column145 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression145 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table73 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column146 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression146 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery74 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column147 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression147 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table74 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column148 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression148 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery75 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column149 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression149 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table75 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column150 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression150 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TxtCP = new DevExpress.XtraEditors.TextEdit();
            this.TxtNumExt = new DevExpress.XtraEditors.TextEdit();
            this.TxtNumInt = new DevExpress.XtraEditors.TextEdit();
            this.ChAsimilados = new DevExpress.XtraEditors.CheckEdit();
            this.TxtEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.TxtCalle = new DevExpress.XtraEditors.TextEdit();
            this.TxtAsunto = new DevExpress.XtraEditors.TextEdit();
            this.BtnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.TxtRFC = new DevExpress.XtraEditors.TextEdit();
            this.TxtRegPat = new DevExpress.XtraEditors.TextEdit();
            this.LookUpPuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.riesgoPuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.LookUpRecu = new DevExpress.XtraEditors.LookUpEdit();
            this.origenRecursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LookUpNomi = new DevExpress.XtraEditors.LookUpEdit();
            this.tipoNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtPassKey = new DevExpress.XtraEditors.TextEdit();
            this.TxtSerie = new DevExpress.XtraEditors.TextEdit();
            this.TxtFecIniVig = new DevExpress.XtraEditors.TextEdit();
            this.TxtFevFinVig = new DevExpress.XtraEditors.TextEdit();
            this.BtnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.ChMostrar = new DevExpress.XtraEditors.CheckEdit();
            this.LookUpRegFis = new DevExpress.XtraEditors.LookUpEdit();
            this.regimenFiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LookUpEst = new DevExpress.XtraEditors.LookUpEdit();
            this.estados_RepublicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LookUpMuni = new DevExpress.XtraEditors.LookUpEdit();
            this.LookUpCol = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtCer = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtKey = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.TxtNomEmpr = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.xtraOpenFileDialog2 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumExt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumInt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChAsimilados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAsunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRegPat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpPuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riesgoPuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpRecu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenRecursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpNomi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecIniVig.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFevFinVig.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChMostrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpRegFis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regimenFiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estados_RepublicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpMuni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNomEmpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtCP);
            this.layoutControl1.Controls.Add(this.TxtNumExt);
            this.layoutControl1.Controls.Add(this.TxtNumInt);
            this.layoutControl1.Controls.Add(this.ChAsimilados);
            this.layoutControl1.Controls.Add(this.TxtEmpresa);
            this.layoutControl1.Controls.Add(this.TxtCalle);
            this.layoutControl1.Controls.Add(this.TxtAsunto);
            this.layoutControl1.Controls.Add(this.BtnActualizar);
            this.layoutControl1.Controls.Add(this.TxtRFC);
            this.layoutControl1.Controls.Add(this.TxtRegPat);
            this.layoutControl1.Controls.Add(this.LookUpPuesto);
            this.layoutControl1.Controls.Add(this.LookUpRecu);
            this.layoutControl1.Controls.Add(this.LookUpNomi);
            this.layoutControl1.Controls.Add(this.TxtPassKey);
            this.layoutControl1.Controls.Add(this.TxtSerie);
            this.layoutControl1.Controls.Add(this.TxtFecIniVig);
            this.layoutControl1.Controls.Add(this.TxtFevFinVig);
            this.layoutControl1.Controls.Add(this.BtnEditar);
            this.layoutControl1.Controls.Add(this.BtnCancelar);
            this.layoutControl1.Controls.Add(this.ChMostrar);
            this.layoutControl1.Controls.Add(this.LookUpRegFis);
            this.layoutControl1.Controls.Add(this.LookUpEst);
            this.layoutControl1.Controls.Add(this.LookUpMuni);
            this.layoutControl1.Controls.Add(this.LookUpCol);
            this.layoutControl1.Controls.Add(this.TxtCer);
            this.layoutControl1.Controls.Add(this.TxtKey);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(316, 174, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(922, 610);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TxtCP
            // 
            this.TxtCP.Location = new System.Drawing.Point(251, 308);
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtCP.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtCP.Size = new System.Drawing.Size(199, 20);
            this.TxtCP.StyleController = this.layoutControl1;
            this.TxtCP.TabIndex = 16;
            this.TxtCP.EditValueChanged += new System.EventHandler(this.TxtCP_EditValueChanged);
            // 
            // TxtNumExt
            // 
            this.TxtNumExt.Location = new System.Drawing.Point(669, 260);
            this.TxtNumExt.Name = "TxtNumExt";
            this.TxtNumExt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtNumExt.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtNumExt.Properties.ReadOnly = true;
            this.TxtNumExt.Size = new System.Drawing.Size(200, 20);
            this.TxtNumExt.StyleController = this.layoutControl1;
            this.TxtNumExt.TabIndex = 13;
            // 
            // TxtNumInt
            // 
            this.TxtNumInt.Location = new System.Drawing.Point(251, 260);
            this.TxtNumInt.Name = "TxtNumInt";
            this.TxtNumInt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtNumInt.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtNumInt.Properties.ReadOnly = true;
            this.TxtNumInt.Size = new System.Drawing.Size(199, 20);
            this.TxtNumInt.StyleController = this.layoutControl1;
            this.TxtNumInt.TabIndex = 12;
            // 
            // ChAsimilados
            // 
            this.ChAsimilados.Enabled = false;
            this.ChAsimilados.Location = new System.Drawing.Point(269, 26);
            this.ChAsimilados.Name = "ChAsimilados";
            this.ChAsimilados.Properties.Caption = "Asimilados";
            this.ChAsimilados.Size = new System.Drawing.Size(512, 19);
            this.ChAsimilados.StyleController = this.layoutControl1;
            this.ChAsimilados.TabIndex = 4;
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Location = new System.Drawing.Point(251, 98);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtEmpresa.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtEmpresa.Properties.ReadOnly = true;
            this.TxtEmpresa.Size = new System.Drawing.Size(618, 20);
            this.TxtEmpresa.StyleController = this.layoutControl1;
            this.TxtEmpresa.TabIndex = 5;
            this.TxtEmpresa.EditValueChanged += new System.EventHandler(this.TxtEmpresa_EditValueChanged);
            // 
            // TxtCalle
            // 
            this.TxtCalle.Location = new System.Drawing.Point(251, 236);
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtCalle.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtCalle.Properties.ReadOnly = true;
            this.TxtCalle.Size = new System.Drawing.Size(618, 20);
            this.TxtCalle.StyleController = this.layoutControl1;
            this.TxtCalle.TabIndex = 6;
            this.TxtCalle.EditValueChanged += new System.EventHandler(this.TxtCalle_EditValueChanged);
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.Location = new System.Drawing.Point(681, 404);
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtAsunto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtAsunto.Properties.ReadOnly = true;
            this.TxtAsunto.Size = new System.Drawing.Size(176, 20);
            this.TxtAsunto.StyleController = this.layoutControl1;
            this.TxtAsunto.TabIndex = 8;
            this.TxtAsunto.EditValueChanged += new System.EventHandler(this.TxtAsunto_EditValueChanged);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.ImageOptions.Image")));
            this.BtnActualizar.Location = new System.Drawing.Point(778, 536);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(91, 38);
            this.BtnActualizar.StyleController = this.layoutControl1;
            this.BtnActualizar.TabIndex = 9;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtRFC
            // 
            this.TxtRFC.Location = new System.Drawing.Point(251, 122);
            this.TxtRFC.Name = "TxtRFC";
            this.TxtRFC.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtRFC.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtRFC.Properties.ReadOnly = true;
            this.TxtRFC.Size = new System.Drawing.Size(199, 20);
            this.TxtRFC.StyleController = this.layoutControl1;
            this.TxtRFC.TabIndex = 10;
            this.TxtRFC.EditValueChanged += new System.EventHandler(this.TxtRFC_EditValueChanged);
            // 
            // TxtRegPat
            // 
            this.TxtRegPat.Location = new System.Drawing.Point(669, 122);
            this.TxtRegPat.Name = "TxtRegPat";
            this.TxtRegPat.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtRegPat.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtRegPat.Properties.ReadOnly = true;
            this.TxtRegPat.Size = new System.Drawing.Size(200, 20);
            this.TxtRegPat.StyleController = this.layoutControl1;
            this.TxtRegPat.TabIndex = 5;
            this.TxtRegPat.EditValueChanged += new System.EventHandler(this.TxtRegPat_EditValueChanged);
            // 
            // LookUpPuesto
            // 
            this.LookUpPuesto.Location = new System.Drawing.Point(251, 170);
            this.LookUpPuesto.Name = "LookUpPuesto";
            this.LookUpPuesto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.LookUpPuesto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.LookUpPuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpPuesto.Properties.DataSource = this.riesgoPuestoBindingSource;
            this.LookUpPuesto.Properties.DisplayMember = "Descripcion";
            this.LookUpPuesto.Properties.NullText = "";
            this.LookUpPuesto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpPuesto.Properties.ValueMember = "c_RiesgoPuesto";
            this.LookUpPuesto.Size = new System.Drawing.Size(199, 20);
            this.LookUpPuesto.StyleController = this.layoutControl1;
            this.LookUpPuesto.TabIndex = 5;
            this.LookUpPuesto.EditValueChanged += new System.EventHandler(this.LookUpPuesto_EditValueChanged);
            // 
            // riesgoPuestoBindingSource
            // 
            this.riesgoPuestoBindingSource.DataMember = "RiesgoPuesto";
            this.riesgoPuestoBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression141.ColumnName = "c_RegimenFiscal";
            table71.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"153\" />";
            table71.Name = "RegimenFiscal";
            columnExpression141.Table = table71;
            column141.Expression = columnExpression141;
            columnExpression142.ColumnName = "Descripcion";
            columnExpression142.Table = table71;
            column142.Expression = columnExpression142;
            selectQuery71.Columns.Add(column141);
            selectQuery71.Columns.Add(column142);
            selectQuery71.Name = "RegimenFiscal";
            selectQuery71.Tables.Add(table71);
            columnExpression143.ColumnName = "c_OrigenRecurso";
            table72.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"115\" />";
            table72.Name = "OrigenRecurso";
            columnExpression143.Table = table72;
            column143.Expression = columnExpression143;
            columnExpression144.ColumnName = "Descripcion";
            columnExpression144.Table = table72;
            column144.Expression = columnExpression144;
            selectQuery72.Columns.Add(column143);
            selectQuery72.Columns.Add(column144);
            selectQuery72.Name = "OrigenRecurso";
            selectQuery72.Tables.Add(table72);
            columnExpression145.ColumnName = "c_RiesgoPuesto";
            table73.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"115\" />";
            table73.Name = "RiesgoPuesto";
            columnExpression145.Table = table73;
            column145.Expression = columnExpression145;
            columnExpression146.ColumnName = "Descripcion";
            columnExpression146.Table = table73;
            column146.Expression = columnExpression146;
            selectQuery73.Columns.Add(column145);
            selectQuery73.Columns.Add(column146);
            selectQuery73.Name = "RiesgoPuesto";
            selectQuery73.Tables.Add(table73);
            columnExpression147.ColumnName = "c_TipoNomina";
            table74.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"115\" />";
            table74.Name = "TipoNomina";
            columnExpression147.Table = table74;
            column147.Expression = columnExpression147;
            columnExpression148.ColumnName = "Descripcion";
            columnExpression148.Table = table74;
            column148.Expression = columnExpression148;
            selectQuery74.Columns.Add(column147);
            selectQuery74.Columns.Add(column148);
            selectQuery74.Name = "TipoNomina";
            selectQuery74.Tables.Add(table74);
            columnExpression149.ColumnName = "c_Estado";
            table75.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"134\" />";
            table75.Name = "Estados_Republica";
            columnExpression149.Table = table75;
            column149.Expression = columnExpression149;
            columnExpression150.ColumnName = "Nombre del estado";
            columnExpression150.Table = table75;
            column150.Expression = columnExpression150;
            selectQuery75.Columns.Add(column149);
            selectQuery75.Columns.Add(column150);
            selectQuery75.Name = "Estados_Republica";
            selectQuery75.Tables.Add(table75);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery71,
            selectQuery72,
            selectQuery73,
            selectQuery74,
            selectQuery75});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // LookUpRecu
            // 
            this.LookUpRecu.Location = new System.Drawing.Point(669, 146);
            this.LookUpRecu.Name = "LookUpRecu";
            this.LookUpRecu.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.LookUpRecu.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.LookUpRecu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpRecu.Properties.DataSource = this.origenRecursoBindingSource;
            this.LookUpRecu.Properties.DisplayMember = "Descripcion";
            this.LookUpRecu.Properties.NullText = "";
            this.LookUpRecu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpRecu.Properties.ValueMember = "c_OrigenRecurso";
            this.LookUpRecu.Size = new System.Drawing.Size(200, 20);
            this.LookUpRecu.StyleController = this.layoutControl1;
            this.LookUpRecu.TabIndex = 5;
            this.LookUpRecu.EditValueChanged += new System.EventHandler(this.LookUpRecu_EditValueChanged);
            // 
            // origenRecursoBindingSource
            // 
            this.origenRecursoBindingSource.DataMember = "OrigenRecurso";
            this.origenRecursoBindingSource.DataSource = this.sqlDataSource1;
            // 
            // LookUpNomi
            // 
            this.LookUpNomi.Location = new System.Drawing.Point(669, 170);
            this.LookUpNomi.Name = "LookUpNomi";
            this.LookUpNomi.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.LookUpNomi.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.LookUpNomi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpNomi.Properties.DataSource = this.tipoNominaBindingSource;
            this.LookUpNomi.Properties.DisplayMember = "Descripcion";
            this.LookUpNomi.Properties.NullText = "";
            this.LookUpNomi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpNomi.Properties.ValueMember = "c_TipoNomina";
            this.LookUpNomi.Size = new System.Drawing.Size(200, 20);
            this.LookUpNomi.StyleController = this.layoutControl1;
            this.LookUpNomi.TabIndex = 5;
            this.LookUpNomi.EditValueChanged += new System.EventHandler(this.LookUpNomi_EditValueChanged);
            // 
            // tipoNominaBindingSource
            // 
            this.tipoNominaBindingSource.DataMember = "TipoNomina";
            this.tipoNominaBindingSource.DataSource = this.sqlDataSource1;
            // 
            // TxtPassKey
            // 
            this.TxtPassKey.Location = new System.Drawing.Point(263, 452);
            this.TxtPassKey.Name = "TxtPassKey";
            this.TxtPassKey.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtPassKey.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtPassKey.Properties.ReadOnly = true;
            this.TxtPassKey.Properties.UseSystemPasswordChar = true;
            this.TxtPassKey.Size = new System.Drawing.Size(175, 20);
            this.TxtPassKey.StyleController = this.layoutControl1;
            this.TxtPassKey.TabIndex = 19;
            this.TxtPassKey.EditValueChanged += new System.EventHandler(this.TxtPassKey_EditValueChanged);
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(681, 428);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtSerie.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtSerie.Properties.ReadOnly = true;
            this.TxtSerie.Size = new System.Drawing.Size(176, 20);
            this.TxtSerie.StyleController = this.layoutControl1;
            this.TxtSerie.TabIndex = 20;
            this.TxtSerie.EditValueChanged += new System.EventHandler(this.TxtSerie_EditValueChanged);
            // 
            // TxtFecIniVig
            // 
            this.TxtFecIniVig.Location = new System.Drawing.Point(681, 452);
            this.TxtFecIniVig.Name = "TxtFecIniVig";
            this.TxtFecIniVig.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtFecIniVig.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtFecIniVig.Properties.ReadOnly = true;
            this.TxtFecIniVig.Size = new System.Drawing.Size(176, 20);
            this.TxtFecIniVig.StyleController = this.layoutControl1;
            this.TxtFecIniVig.TabIndex = 21;
            this.TxtFecIniVig.EditValueChanged += new System.EventHandler(this.TxtFecIniVig_EditValueChanged);
            // 
            // TxtFevFinVig
            // 
            this.TxtFevFinVig.Location = new System.Drawing.Point(681, 476);
            this.TxtFevFinVig.Name = "TxtFevFinVig";
            this.TxtFevFinVig.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtFevFinVig.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtFevFinVig.Properties.ReadOnly = true;
            this.TxtFevFinVig.Size = new System.Drawing.Size(176, 20);
            this.TxtFevFinVig.StyleController = this.layoutControl1;
            this.TxtFevFinVig.TabIndex = 22;
            this.TxtFevFinVig.EditValueChanged += new System.EventHandler(this.TxtFevFinVig_EditValueChanged);
            // 
            // BtnEditar
            // 
            this.BtnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.ImageOptions.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(785, 26);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(96, 38);
            this.BtnEditar.StyleController = this.layoutControl1;
            this.BtnEditar.TabIndex = 23;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Visible = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.ImageOptions.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(688, 536);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(86, 38);
            this.BtnCancelar.StyleController = this.layoutControl1;
            this.BtnCancelar.TabIndex = 24;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ChMostrar
            // 
            this.ChMostrar.Enabled = false;
            this.ChMostrar.Location = new System.Drawing.Point(48, 476);
            this.ChMostrar.Name = "ChMostrar";
            this.ChMostrar.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.ChMostrar.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.ChMostrar.Properties.Caption = "Mostrar";
            this.ChMostrar.Size = new System.Drawing.Size(390, 19);
            this.ChMostrar.StyleController = this.layoutControl1;
            this.ChMostrar.TabIndex = 25;
            this.ChMostrar.CheckedChanged += new System.EventHandler(this.ChMostrar_CheckedChanged);
            // 
            // LookUpRegFis
            // 
            this.LookUpRegFis.Location = new System.Drawing.Point(251, 146);
            this.LookUpRegFis.Name = "LookUpRegFis";
            this.LookUpRegFis.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.LookUpRegFis.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.LookUpRegFis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpRegFis.Properties.DataSource = this.regimenFiscalBindingSource;
            this.LookUpRegFis.Properties.DisplayMember = "Descripcion";
            this.LookUpRegFis.Properties.NullText = "";
            this.LookUpRegFis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpRegFis.Properties.ValueMember = "c_RegimenFiscal";
            this.LookUpRegFis.Size = new System.Drawing.Size(199, 20);
            this.LookUpRegFis.StyleController = this.layoutControl1;
            this.LookUpRegFis.TabIndex = 5;
            this.LookUpRegFis.EditValueChanged += new System.EventHandler(this.LookUpRegFis_EditValueChanged);
            // 
            // regimenFiscalBindingSource
            // 
            this.regimenFiscalBindingSource.DataMember = "RegimenFiscal";
            this.regimenFiscalBindingSource.DataSource = this.sqlDataSource1;
            // 
            // LookUpEst
            // 
            this.LookUpEst.Location = new System.Drawing.Point(251, 284);
            this.LookUpEst.Name = "LookUpEst";
            this.LookUpEst.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.LookUpEst.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.LookUpEst.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEst.Properties.DataSource = this.estados_RepublicaBindingSource;
            this.LookUpEst.Properties.DisplayMember = "Nombre del estado";
            this.LookUpEst.Properties.NullText = "";
            this.LookUpEst.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpEst.Properties.ValueMember = "Nombre del estado";
            this.LookUpEst.Size = new System.Drawing.Size(199, 20);
            this.LookUpEst.StyleController = this.layoutControl1;
            this.LookUpEst.TabIndex = 14;
            this.LookUpEst.EditValueChanged += new System.EventHandler(this.LookUpEst_EditValueChanged);
            // 
            // estados_RepublicaBindingSource
            // 
            this.estados_RepublicaBindingSource.DataMember = "Estados_Republica";
            this.estados_RepublicaBindingSource.DataSource = this.sqlDataSource1;
            // 
            // LookUpMuni
            // 
            this.LookUpMuni.Location = new System.Drawing.Point(669, 284);
            this.LookUpMuni.Name = "LookUpMuni";
            this.LookUpMuni.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.LookUpMuni.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.LookUpMuni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpMuni.Properties.NullText = "";
            this.LookUpMuni.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpMuni.Size = new System.Drawing.Size(200, 20);
            this.LookUpMuni.StyleController = this.layoutControl1;
            this.LookUpMuni.TabIndex = 15;
            this.LookUpMuni.EditValueChanged += new System.EventHandler(this.LookUpMuni_EditValueChanged);
            // 
            // LookUpCol
            // 
            this.LookUpCol.Location = new System.Drawing.Point(669, 308);
            this.LookUpCol.Name = "LookUpCol";
            this.LookUpCol.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.LookUpCol.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.LookUpCol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpCol.Properties.NullText = "";
            this.LookUpCol.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpCol.Size = new System.Drawing.Size(200, 20);
            this.LookUpCol.StyleController = this.layoutControl1;
            this.LookUpCol.TabIndex = 17;
            this.LookUpCol.EditValueChanged += new System.EventHandler(this.LookUpCol_EditValueChanged);
            // 
            // TxtCer
            // 
            this.TxtCer.Location = new System.Drawing.Point(263, 404);
            this.TxtCer.Name = "TxtCer";
            this.TxtCer.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtCer.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtCer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.TxtCer.Properties.ReadOnly = true;
            this.TxtCer.Size = new System.Drawing.Size(175, 20);
            this.TxtCer.StyleController = this.layoutControl1;
            this.TxtCer.TabIndex = 7;
            this.TxtCer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtCer_ButtonClick);
            this.TxtCer.EditValueChanged += new System.EventHandler(this.TxtCer_EditValueChanged);
            // 
            // TxtKey
            // 
            this.TxtKey.Location = new System.Drawing.Point(263, 428);
            this.TxtKey.Name = "TxtKey";
            this.TxtKey.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtKey.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.TxtKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.TxtKey.Properties.ReadOnly = true;
            this.TxtKey.Size = new System.Drawing.Size(175, 20);
            this.TxtKey.StyleController = this.layoutControl1;
            this.TxtKey.TabIndex = 18;
            this.TxtKey.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtKey_ButtonClick);
            this.TxtKey.EditValueChanged += new System.EventHandler(this.TxtKey_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(905, 630);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(885, 610);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.simpleLabelItem1,
            this.layoutControlGroup4,
            this.emptySpaceItem1,
            this.layoutControlGroup5,
            this.layoutControlGroup3,
            this.layoutControlGroup8,
            this.layoutControlItem24});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(861, 564);
            this.layoutControlGroup2.Text = "Configuración Empresa";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ChAsimilados;
            this.layoutControlItem1.Location = new System.Drawing.Point(245, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(516, 42);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleLabelItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(245, 42);
            this.simpleLabelItem1.Text = "Campos en color azul son obligatorios";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem18,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem17,
            this.layoutControlItem19,
            this.layoutControlItem16});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 180);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(861, 138);
            this.layoutControlGroup4.Text = "Dirección Fiscal";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.TxtCalle;
            this.layoutControlItem3.CustomizationFormText = "Calle";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(837, 24);
            this.layoutControlItem3.Text = "Calle";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem18.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem18.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem18.Control = this.TxtCP;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(418, 24);
            this.layoutControlItem18.Text = "Codigo Postal";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.TxtNumInt;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(418, 24);
            this.layoutControlItem14.Text = "# Interior";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.TxtNumExt;
            this.layoutControlItem15.Location = new System.Drawing.Point(418, 24);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem15.Text = "# Exterior";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem17.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem17.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem17.Control = this.LookUpMuni;
            this.layoutControlItem17.Location = new System.Drawing.Point(418, 48);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem17.Text = "Municipio";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem19.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem19.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem19.Control = this.LookUpCol;
            this.layoutControlItem19.Location = new System.Drawing.Point(418, 72);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem19.Text = "Colonia";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem16.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem16.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem16.Control = this.LookUpEst;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(418, 24);
            this.layoutControlItem16.Text = "Estado";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(212, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 498);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(652, 66);
            this.emptySpaceItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup7,
            this.layoutControlGroup6});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 318);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(861, 180);
            this.layoutControlGroup5.Text = "Datos CSD";
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem21,
            this.layoutControlItem22,
            this.layoutControlItem23});
            this.layoutControlGroup7.Location = new System.Drawing.Point(418, 0);
            this.layoutControlGroup7.Name = "layoutControlGroup7";
            this.layoutControlGroup7.Size = new System.Drawing.Size(419, 138);
            this.layoutControlGroup7.Text = "Información CER";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.TxtAsunto;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(395, 24);
            this.layoutControlItem5.Text = "Asunto";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.TxtSerie;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(395, 24);
            this.layoutControlItem21.Text = "Serie";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.TxtFecIniVig;
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(395, 24);
            this.layoutControlItem22.Text = "Valido Desde";
            this.layoutControlItem22.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.TxtFevFinVig;
            this.layoutControlItem23.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(395, 24);
            this.layoutControlItem23.Text = "Valido Hasta";
            this.layoutControlItem23.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem13,
            this.layoutControlItem20,
            this.layoutControlItem26});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(418, 138);
            this.layoutControlGroup6.Text = "Configuración CSD";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.TxtCer;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem4.Text = "Archivo .cer";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem13.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem13.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem13.Control = this.TxtKey;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem13.Text = "Archivo .key";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem20.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem20.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem20.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem20.Control = this.TxtPassKey;
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem20.Text = "Contraseña";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.ChMostrar;
            this.layoutControlItem26.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem26.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem26.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.TxtNomEmpr,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 42);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(861, 138);
            this.layoutControlGroup3.Text = "Configuración Patronal";
            // 
            // TxtNomEmpr
            // 
            this.TxtNomEmpr.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtNomEmpr.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.TxtNomEmpr.AppearanceItemCaption.Options.UseFont = true;
            this.TxtNomEmpr.AppearanceItemCaption.Options.UseForeColor = true;
            this.TxtNomEmpr.Control = this.TxtEmpresa;
            this.TxtNomEmpr.Location = new System.Drawing.Point(0, 0);
            this.TxtNomEmpr.Name = "layoutControlItem2";
            this.TxtNomEmpr.Size = new System.Drawing.Size(837, 24);
            this.TxtNomEmpr.Text = "Nombre Empresa";
            this.TxtNomEmpr.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.TxtRFC;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(418, 24);
            this.layoutControlItem7.Text = "RFC";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.LookUpRegFis;
            this.layoutControlItem8.CustomizationFormText = "Regimen Físcal";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(418, 24);
            this.layoutControlItem8.Text = "Regimen Físcal";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem9.Control = this.LookUpNomi;
            this.layoutControlItem9.CustomizationFormText = "Tipo Nomina";
            this.layoutControlItem9.Location = new System.Drawing.Point(418, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem9.Text = "Tipo Nomina";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem10.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem10.Control = this.LookUpPuesto;
            this.layoutControlItem10.CustomizationFormText = "Riesgo Puesto";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(418, 24);
            this.layoutControlItem10.Text = "Riesgo Puesto";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem11.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem11.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem11.Control = this.LookUpRecu;
            this.layoutControlItem11.CustomizationFormText = "Origen Recursos";
            this.layoutControlItem11.Location = new System.Drawing.Point(418, 48);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem11.Text = "Origen Recursos";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem12.AppearanceItemCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem12.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem12.Control = this.TxtRegPat;
            this.layoutControlItem12.CustomizationFormText = "Registro Patronal";
            this.layoutControlItem12.Location = new System.Drawing.Point(418, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem12.Text = "Registro Patronal";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(212, 13);
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem25,
            this.layoutControlItem6});
            this.layoutControlGroup8.Location = new System.Drawing.Point(652, 498);
            this.layoutControlGroup8.Name = "layoutControlGroup8";
            this.layoutControlGroup8.Size = new System.Drawing.Size(209, 66);
            this.layoutControlGroup8.TextVisible = false;
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.BtnCancelar;
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(90, 42);
            this.layoutControlItem25.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem25.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.BtnActualizar;
            this.layoutControlItem6.Location = new System.Drawing.Point(90, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(95, 42);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.BtnEditar;
            this.layoutControlItem24.Location = new System.Drawing.Point(761, 0);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(100, 42);
            this.layoutControlItem24.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem24.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtEmpresa;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(854, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(212, 13);
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // xtraOpenFileDialog2
            // 
            this.xtraOpenFileDialog2.FileName = "xtraOpenFileDialog2";
            // 
            // EditarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 610);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditarEmpresa";
            this.Text = "EditarEmpresa";
            this.Load += new System.EventHandler(this.EditarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumExt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumInt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChAsimilados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAsunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRegPat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpPuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riesgoPuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpRecu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenRecursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpNomi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecIniVig.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFevFinVig.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChMostrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpRegFis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regimenFiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estados_RepublicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpMuni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpCol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNomEmpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.CheckEdit ChAsimilados;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraEditors.TextEdit TxtEmpresa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.TextEdit TxtCalle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraEditors.TextEdit TxtAsunto;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton BtnActualizar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit TxtRFC;
        private DevExpress.XtraEditors.TextEdit TxtRegPat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.TextEdit TxtCP;
        private DevExpress.XtraEditors.TextEdit TxtNumExt;
        private DevExpress.XtraEditors.TextEdit TxtNumInt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem TxtNomEmpr;
        private DevExpress.XtraEditors.LookUpEdit LookUpPuesto;
        private DevExpress.XtraEditors.LookUpEdit LookUpRecu;
        private DevExpress.XtraEditors.LookUpEdit LookUpNomi;
        private DevExpress.XtraEditors.TextEdit TxtPassKey;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraEditors.TextEdit TxtSerie;
        private DevExpress.XtraEditors.TextEdit TxtFecIniVig;
        private DevExpress.XtraEditors.TextEdit TxtFevFinVig;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraEditors.SimpleButton BtnEditar;
        private DevExpress.XtraEditors.SimpleButton BtnCancelar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraEditors.CheckEdit ChMostrar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraEditors.LookUpEdit LookUpRegFis;
        private System.Windows.Forms.BindingSource regimenFiscalBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource origenRecursoBindingSource;
        private System.Windows.Forms.BindingSource riesgoPuestoBindingSource;
        private System.Windows.Forms.BindingSource tipoNominaBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
        private DevExpress.XtraEditors.LookUpEdit LookUpEst;
        private System.Windows.Forms.BindingSource estados_RepublicaBindingSource;
        private DevExpress.XtraEditors.LookUpEdit LookUpMuni;
        private DevExpress.XtraEditors.LookUpEdit LookUpCol;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraEditors.ButtonEdit TxtCer;
        private DevExpress.XtraEditors.ButtonEdit TxtKey;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog2;
    }
}