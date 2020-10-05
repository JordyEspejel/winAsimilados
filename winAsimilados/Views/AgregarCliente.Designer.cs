namespace winAsimilados.Views
{
    partial class AgregarCliente
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Group group1 = new DevExpress.DataAccess.Sql.Group();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Group group2 = new DevExpress.DataAccess.Sql.Group();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery5 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery6 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtComisionista = new DevExpress.XtraEditors.TextEdit();
            this.spinEditPerISN = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditPerServ = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditRetIVA = new DevExpress.XtraEditors.SpinEdit();
            this.lookUpFacIva = new DevExpress.XtraEditors.LookUpEdit();
            this.opcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lookUpRetIva = new DevExpress.XtraEditors.LookUpEdit();
            this.opcionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEjecutivo = new DevExpress.XtraEditors.LookUpEdit();
            this.usuariosSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.lookUpPeriodo = new DevExpress.XtraEditors.LookUpEdit();
            this.periodicidadPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEmpCFDI = new DevExpress.XtraEditors.LookUpEdit();
            this.empresaCatalogoCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEmprFact = new DevExpress.XtraEditors.LookUpEdit();
            this.empresaPagaAsimiladosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chBoxEmpFactura = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpEmprFact2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEmprFact3 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEmprFact4 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpMetodoPago = new DevExpress.XtraEditors.LookUpEdit();
            this.metodoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpFormaPago = new DevExpress.XtraEditors.LookUpEdit();
            this.formaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtObservaciones = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDClte = new DevExpress.XtraEditors.TextEdit();
            this.chComi = new DevExpress.XtraEditors.CheckEdit();
            this.spinEditComi = new DevExpress.XtraEditors.SpinEdit();
            this.txtComi2 = new DevExpress.XtraEditors.TextEdit();
            this.spinEditComi2 = new DevExpress.XtraEditors.SpinEdit();
            this.txtComi3 = new DevExpress.XtraEditors.TextEdit();
            this.spinEditComi3 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditEmpFact = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditEmpFact2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditEmpFact3 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditEmpFact4 = new DevExpress.XtraEditors.SpinEdit();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlComi2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlSpinComi2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlComi3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlSpinComi3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemRetIVA = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComisionista.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPerISN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPerServ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditRetIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFacIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRetIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEjecutivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosSistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicidadPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmpCFDI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaCatalogoCFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmprFact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaPagaAsimiladosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBoxEmpFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmprFact2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmprFact3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmprFact4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMetodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDClte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chComi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditComi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditComi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComi3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditComi3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEmpFact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEmpFact2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEmpFact3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEmpFact4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlComi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSpinComi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlComi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSpinComi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRetIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtNombre);
            this.layoutControl1.Controls.Add(this.txtComisionista);
            this.layoutControl1.Controls.Add(this.spinEditPerISN);
            this.layoutControl1.Controls.Add(this.spinEditPerServ);
            this.layoutControl1.Controls.Add(this.spinEditRetIVA);
            this.layoutControl1.Controls.Add(this.lookUpFacIva);
            this.layoutControl1.Controls.Add(this.lookUpRetIva);
            this.layoutControl1.Controls.Add(this.lookUpEjecutivo);
            this.layoutControl1.Controls.Add(this.txtProveedor);
            this.layoutControl1.Controls.Add(this.lookUpPeriodo);
            this.layoutControl1.Controls.Add(this.lookUpEmpCFDI);
            this.layoutControl1.Controls.Add(this.lookUpEmprFact);
            this.layoutControl1.Controls.Add(this.chBoxEmpFactura);
            this.layoutControl1.Controls.Add(this.lookUpEmprFact2);
            this.layoutControl1.Controls.Add(this.lookUpEmprFact3);
            this.layoutControl1.Controls.Add(this.lookUpEmprFact4);
            this.layoutControl1.Controls.Add(this.lookUpMetodoPago);
            this.layoutControl1.Controls.Add(this.lookUpFormaPago);
            this.layoutControl1.Controls.Add(this.txtObservaciones);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.txtIDClte);
            this.layoutControl1.Controls.Add(this.chComi);
            this.layoutControl1.Controls.Add(this.spinEditComi);
            this.layoutControl1.Controls.Add(this.txtComi2);
            this.layoutControl1.Controls.Add(this.spinEditComi2);
            this.layoutControl1.Controls.Add(this.txtComi3);
            this.layoutControl1.Controls.Add(this.spinEditComi3);
            this.layoutControl1.Controls.Add(this.spinEditEmpFact);
            this.layoutControl1.Controls.Add(this.spinEditEmpFact2);
            this.layoutControl1.Controls.Add(this.spinEditEmpFact3);
            this.layoutControl1.Controls.Add(this.spinEditEmpFact4);
            this.layoutControl1.Controls.Add(this.txtCorreo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(811, 542);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Size = new System.Drawing.Size(680, 20);
            this.txtNombre.StyleController = this.layoutControl1;
            this.txtNombre.TabIndex = 5;
            // 
            // txtComisionista
            // 
            this.txtComisionista.Location = new System.Drawing.Point(100, 120);
            this.txtComisionista.Name = "txtComisionista";
            this.txtComisionista.Size = new System.Drawing.Size(217, 20);
            this.txtComisionista.StyleController = this.layoutControl1;
            this.txtComisionista.TabIndex = 6;
            // 
            // spinEditPerISN
            // 
            this.spinEditPerISN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditPerISN.Location = new System.Drawing.Point(72, 306);
            this.spinEditPerISN.Name = "spinEditPerISN";
            this.spinEditPerISN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPerISN.Properties.Mask.EditMask = "P";
            this.spinEditPerISN.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditPerISN.Size = new System.Drawing.Size(204, 20);
            this.spinEditPerISN.StyleController = this.layoutControl1;
            this.spinEditPerISN.TabIndex = 7;
            // 
            // spinEditPerServ
            // 
            this.spinEditPerServ.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditPerServ.Location = new System.Drawing.Point(381, 306);
            this.spinEditPerServ.Name = "spinEditPerServ";
            this.spinEditPerServ.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPerServ.Properties.Mask.EditMask = "P";
            this.spinEditPerServ.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditPerServ.Size = new System.Drawing.Size(92, 20);
            this.spinEditPerServ.StyleController = this.layoutControl1;
            this.spinEditPerServ.TabIndex = 8;
            // 
            // spinEditRetIVA
            // 
            this.spinEditRetIVA.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditRetIVA.Location = new System.Drawing.Point(564, 306);
            this.spinEditRetIVA.Name = "spinEditRetIVA";
            this.spinEditRetIVA.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.spinEditRetIVA.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.spinEditRetIVA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditRetIVA.Properties.Mask.EditMask = "P";
            this.spinEditRetIVA.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditRetIVA.Size = new System.Drawing.Size(194, 20);
            this.spinEditRetIVA.StyleController = this.layoutControl1;
            this.spinEditRetIVA.TabIndex = 9;
            // 
            // lookUpFacIva
            // 
            this.lookUpFacIva.Location = new System.Drawing.Point(139, 282);
            this.lookUpFacIva.Name = "lookUpFacIva";
            this.lookUpFacIva.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpFacIva.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Opción", "Opción", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpFacIva.Properties.DataSource = this.opcionesBindingSource;
            this.lookUpFacIva.Properties.DisplayMember = "Opción";
            this.lookUpFacIva.Properties.NullText = "Seleccione";
            this.lookUpFacIva.Properties.ValueMember = "Value";
            this.lookUpFacIva.Size = new System.Drawing.Size(255, 20);
            this.lookUpFacIva.StyleController = this.layoutControl1;
            this.lookUpFacIva.TabIndex = 10;
            // 
            // opcionesBindingSource
            // 
            this.opcionesBindingSource.DataMember = "Opciones";
            this.opcionesBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_BSNOMINAS_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "usuarioNombre";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"210\" />";
            table1.Name = "UsuariosSistema";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            selectQuery1.Columns.Add(column1);
            selectQuery1.FilterString = "StartsWith([UsuariosSistema.usuarioTipo], \'O\')";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "UsuariosSistema";
            selectQuery1.Tables.Add(table1);
            customSqlQuery1.Name = "Opciones";
            customSqlQuery1.Sql = "SELECT \'S\' AS [Value], \'Sí\' AS [Opción]\r\nUNION SELECT \'N\' AS [Value], \'No\' AS [Op" +
    "ción]";
            columnExpression2.ColumnName = "Descripcion";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"115\" />";
            table2.Name = "PeriodicidadPago";
            columnExpression2.Table = table2;
            column2.Expression = columnExpression2;
            selectQuery2.Columns.Add(column2);
            selectQuery2.Name = "PeriodicidadPago";
            selectQuery2.Tables.Add(table2);
            columnExpression3.ColumnName = "NumEmpresa";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"115\" />";
            table3.Name = "EmpresaCatalogoCFDI";
            columnExpression3.Table = table3;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Descripcion";
            columnExpression4.Table = table3;
            column4.Expression = columnExpression4;
            selectQuery3.Columns.Add(column3);
            selectQuery3.Columns.Add(column4);
            selectQuery3.Name = "EmpresaCatalogoCFDI";
            selectQuery3.Tables.Add(table3);
            columnExpression5.ColumnName = "IDEmpresa";
            table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"210\" />";
            table4.Name = "EmpresaPagaAsimilados";
            columnExpression5.Table = table4;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "RazonSocial";
            columnExpression6.Table = table4;
            column6.Expression = columnExpression6;
            selectQuery4.Columns.Add(column5);
            selectQuery4.Columns.Add(column6);
            columnExpression7.ColumnName = "IDEmpresa";
            columnExpression7.Table = table4;
            group1.Expression = columnExpression7;
            columnExpression8.ColumnName = "RazonSocial";
            columnExpression8.Table = table4;
            group2.Expression = columnExpression8;
            selectQuery4.Groups.Add(group1);
            selectQuery4.Groups.Add(group2);
            selectQuery4.Name = "EmpresaPagaAsimilados";
            selectQuery4.Tables.Add(table4);
            columnExpression9.ColumnName = "c_MetodoPago";
            table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"115\" />";
            table5.Name = "MetodoPago";
            columnExpression9.Table = table5;
            column7.Expression = columnExpression9;
            columnExpression10.ColumnName = "Descripción";
            columnExpression10.Table = table5;
            column8.Expression = columnExpression10;
            selectQuery5.Columns.Add(column7);
            selectQuery5.Columns.Add(column8);
            selectQuery5.Name = "MetodoPago";
            selectQuery5.Tables.Add(table5);
            columnExpression11.ColumnName = "c_FormaPago";
            table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"115\" />";
            table6.Name = "FormaPago";
            columnExpression11.Table = table6;
            column9.Expression = columnExpression11;
            columnExpression12.ColumnName = "Descripción";
            columnExpression12.Table = table6;
            column10.Expression = columnExpression12;
            selectQuery6.Columns.Add(column9);
            selectQuery6.Columns.Add(column10);
            selectQuery6.Name = "FormaPago";
            selectQuery6.Tables.Add(table6);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            customSqlQuery1,
            selectQuery2,
            selectQuery3,
            selectQuery4,
            selectQuery5,
            selectQuery6});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // lookUpRetIva
            // 
            this.lookUpRetIva.Location = new System.Drawing.Point(471, 282);
            this.lookUpRetIva.Name = "lookUpRetIva";
            this.lookUpRetIva.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRetIva.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Opción", "Opción", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpRetIva.Properties.DataSource = this.opcionesBindingSource1;
            this.lookUpRetIva.Properties.DisplayMember = "Opción";
            this.lookUpRetIva.Properties.NullText = "Seleccione";
            this.lookUpRetIva.Properties.ValueMember = "Value";
            this.lookUpRetIva.Size = new System.Drawing.Size(287, 20);
            this.lookUpRetIva.StyleController = this.layoutControl1;
            this.lookUpRetIva.TabIndex = 11;
            this.lookUpRetIva.EditValueChanged += new System.EventHandler(this.lookUpRetIva_EditValueChanged);
            // 
            // opcionesBindingSource1
            // 
            this.opcionesBindingSource1.DataMember = "Opciones";
            this.opcionesBindingSource1.DataSource = this.sqlDataSource1;
            // 
            // lookUpEjecutivo
            // 
            this.lookUpEjecutivo.Location = new System.Drawing.Point(532, 120);
            this.lookUpEjecutivo.Name = "lookUpEjecutivo";
            this.lookUpEjecutivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEjecutivo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuarioNombre", "Nombre Ejecutivo", 98, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEjecutivo.Properties.DataSource = this.usuariosSistemaBindingSource;
            this.lookUpEjecutivo.Properties.DisplayMember = "usuarioNombre";
            this.lookUpEjecutivo.Properties.NullText = "Seleccione";
            this.lookUpEjecutivo.Properties.ValueMember = "usuarioNombre";
            this.lookUpEjecutivo.Size = new System.Drawing.Size(226, 20);
            this.lookUpEjecutivo.StyleController = this.layoutControl1;
            this.lookUpEjecutivo.TabIndex = 12;
            // 
            // usuariosSistemaBindingSource
            // 
            this.usuariosSistemaBindingSource.DataMember = "UsuariosSistema";
            this.usuariosSistemaBindingSource.DataSource = this.sqlDataSource1;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(91, 168);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(281, 20);
            this.txtProveedor.StyleController = this.layoutControl1;
            this.txtProveedor.TabIndex = 14;
            // 
            // lookUpPeriodo
            // 
            this.lookUpPeriodo.Location = new System.Drawing.Point(459, 168);
            this.lookUpPeriodo.Name = "lookUpPeriodo";
            this.lookUpPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPeriodo.Properties.DataSource = this.periodicidadPagoBindingSource;
            this.lookUpPeriodo.Properties.DisplayMember = "Descripcion";
            this.lookUpPeriodo.Properties.NullText = "Seleccione";
            this.lookUpPeriodo.Properties.ValueMember = "Descripcion";
            this.lookUpPeriodo.Size = new System.Drawing.Size(299, 20);
            this.lookUpPeriodo.StyleController = this.layoutControl1;
            this.lookUpPeriodo.TabIndex = 13;
            // 
            // periodicidadPagoBindingSource
            // 
            this.periodicidadPagoBindingSource.DataMember = "PeriodicidadPago";
            this.periodicidadPagoBindingSource.DataSource = this.sqlDataSource1;
            // 
            // lookUpEmpCFDI
            // 
            this.lookUpEmpCFDI.Location = new System.Drawing.Point(138, 330);
            this.lookUpEmpCFDI.Name = "lookUpEmpCFDI";
            this.lookUpEmpCFDI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEmpCFDI.Properties.DataSource = this.empresaCatalogoCFDIBindingSource;
            this.lookUpEmpCFDI.Properties.DisplayMember = "Descripcion";
            this.lookUpEmpCFDI.Properties.NullText = "Seleccione";
            this.lookUpEmpCFDI.Properties.ValueMember = "NumEmpresa";
            this.lookUpEmpCFDI.Size = new System.Drawing.Size(620, 20);
            this.lookUpEmpCFDI.StyleController = this.layoutControl1;
            this.lookUpEmpCFDI.TabIndex = 15;
            // 
            // empresaCatalogoCFDIBindingSource
            // 
            this.empresaCatalogoCFDIBindingSource.DataMember = "EmpresaCatalogoCFDI";
            this.empresaCatalogoCFDIBindingSource.DataSource = this.sqlDataSource1;
            // 
            // lookUpEmprFact
            // 
            this.lookUpEmprFact.Location = new System.Drawing.Point(141, 354);
            this.lookUpEmprFact.Name = "lookUpEmprFact";
            this.lookUpEmprFact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEmprFact.Properties.DataSource = this.empresaPagaAsimiladosBindingSource;
            this.lookUpEmprFact.Properties.DisplayMember = "RazonSocial";
            this.lookUpEmprFact.Properties.NullText = "Seleccione";
            this.lookUpEmprFact.Properties.ValueMember = "IDEmpresa";
            this.lookUpEmprFact.Size = new System.Drawing.Size(508, 20);
            this.lookUpEmprFact.StyleController = this.layoutControl1;
            this.lookUpEmprFact.TabIndex = 16;
            // 
            // empresaPagaAsimiladosBindingSource
            // 
            this.empresaPagaAsimiladosBindingSource.DataMember = "EmpresaPagaAsimilados";
            this.empresaPagaAsimiladosBindingSource.DataSource = this.sqlDataSource1;
            // 
            // chBoxEmpFactura
            // 
            this.chBoxEmpFactura.Location = new System.Drawing.Point(475, 42);
            this.chBoxEmpFactura.Name = "chBoxEmpFactura";
            this.chBoxEmpFactura.Properties.Caption = "Cliente Factura  Con más De Una Empresa";
            this.chBoxEmpFactura.Size = new System.Drawing.Size(295, 19);
            this.chBoxEmpFactura.StyleController = this.layoutControl1;
            this.chBoxEmpFactura.TabIndex = 17;
            this.chBoxEmpFactura.CheckedChanged += new System.EventHandler(this.chBoxEmpFactura_CheckedChanged);
            // 
            // lookUpEmprFact2
            // 
            this.lookUpEmprFact2.Location = new System.Drawing.Point(150, 378);
            this.lookUpEmprFact2.Name = "lookUpEmprFact2";
            this.lookUpEmprFact2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEmprFact2.Properties.DataSource = this.empresaPagaAsimiladosBindingSource;
            this.lookUpEmprFact2.Properties.DisplayMember = "RazonSocial";
            this.lookUpEmprFact2.Properties.NullText = "Seleccione";
            this.lookUpEmprFact2.Properties.ValueMember = "IDEmpresa";
            this.lookUpEmprFact2.Size = new System.Drawing.Size(499, 20);
            this.lookUpEmprFact2.StyleController = this.layoutControl1;
            this.lookUpEmprFact2.TabIndex = 18;
            // 
            // lookUpEmprFact3
            // 
            this.lookUpEmprFact3.Location = new System.Drawing.Point(150, 402);
            this.lookUpEmprFact3.Name = "lookUpEmprFact3";
            this.lookUpEmprFact3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEmprFact3.Properties.DataSource = this.empresaCatalogoCFDIBindingSource;
            this.lookUpEmprFact3.Properties.DisplayMember = "RazonSocial";
            this.lookUpEmprFact3.Properties.NullText = "Seleccione";
            this.lookUpEmprFact3.Properties.ValueMember = "IDEmpresa";
            this.lookUpEmprFact3.Size = new System.Drawing.Size(499, 20);
            this.lookUpEmprFact3.StyleController = this.layoutControl1;
            this.lookUpEmprFact3.TabIndex = 20;
            // 
            // lookUpEmprFact4
            // 
            this.lookUpEmprFact4.Location = new System.Drawing.Point(150, 426);
            this.lookUpEmprFact4.Name = "lookUpEmprFact4";
            this.lookUpEmprFact4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEmprFact4.Properties.DataSource = this.empresaPagaAsimiladosBindingSource;
            this.lookUpEmprFact4.Properties.DisplayMember = "RazonSocial";
            this.lookUpEmprFact4.Properties.NullText = "Seleccione";
            this.lookUpEmprFact4.Properties.ValueMember = "IDEmpresa";
            this.lookUpEmprFact4.Size = new System.Drawing.Size(499, 20);
            this.lookUpEmprFact4.StyleController = this.layoutControl1;
            this.lookUpEmprFact4.TabIndex = 19;
            // 
            // lookUpMetodoPago
            // 
            this.lookUpMetodoPago.Location = new System.Drawing.Point(119, 450);
            this.lookUpMetodoPago.Name = "lookUpMetodoPago";
            this.lookUpMetodoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMetodoPago.Properties.DataSource = this.metodoPagoBindingSource;
            this.lookUpMetodoPago.Properties.DisplayMember = "Descripción";
            this.lookUpMetodoPago.Properties.NullText = "Seleccione";
            this.lookUpMetodoPago.Properties.ValueMember = "c_MetodoPago";
            this.lookUpMetodoPago.Size = new System.Drawing.Size(201, 20);
            this.lookUpMetodoPago.StyleController = this.layoutControl1;
            this.lookUpMetodoPago.TabIndex = 21;
            // 
            // metodoPagoBindingSource
            // 
            this.metodoPagoBindingSource.DataMember = "MetodoPago";
            this.metodoPagoBindingSource.DataSource = this.sqlDataSource1;
            // 
            // lookUpFormaPago
            // 
            this.lookUpFormaPago.Location = new System.Drawing.Point(401, 450);
            this.lookUpFormaPago.Name = "lookUpFormaPago";
            this.lookUpFormaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpFormaPago.Properties.DataSource = this.formaPagoBindingSource;
            this.lookUpFormaPago.Properties.DisplayMember = "Descripción";
            this.lookUpFormaPago.Properties.NullText = "Seleccione";
            this.lookUpFormaPago.Properties.ValueMember = "c_FormaPago";
            this.lookUpFormaPago.Size = new System.Drawing.Size(357, 20);
            this.lookUpFormaPago.StyleController = this.layoutControl1;
            this.lookUpFormaPago.TabIndex = 22;
            // 
            // formaPagoBindingSource
            // 
            this.formaPagoBindingSource.DataMember = "FormaPago";
            this.formaPagoBindingSource.DataSource = this.sqlDataSource1;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(112, 192);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(646, 20);
            this.txtObservaciones.StyleController = this.layoutControl1;
            this.txtObservaciones.TabIndex = 23;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(638, 486);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 38);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIDClte
            // 
            this.txtIDClte.Enabled = false;
            this.txtIDClte.Location = new System.Drawing.Point(40, 42);
            this.txtIDClte.Name = "txtIDClte";
            this.txtIDClte.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIDClte.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtIDClte.Size = new System.Drawing.Size(75, 20);
            this.txtIDClte.StyleController = this.layoutControl1;
            this.txtIDClte.TabIndex = 25;
            // 
            // chComi
            // 
            this.chComi.Location = new System.Drawing.Point(274, 42);
            this.chComi.Name = "chComi";
            this.chComi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.chComi.Properties.Caption = "Cliente tiene más de un comisionista";
            this.chComi.Size = new System.Drawing.Size(197, 19);
            this.chComi.StyleController = this.layoutControl1;
            this.chComi.TabIndex = 26;
            this.chComi.CheckedChanged += new System.EventHandler(this.chComi_CheckedChanged);
            // 
            // spinEditComi
            // 
            this.spinEditComi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditComi.Location = new System.Drawing.Point(337, 120);
            this.spinEditComi.Name = "spinEditComi";
            this.spinEditComi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditComi.Properties.Mask.EditMask = "P";
            this.spinEditComi.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditComi.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditComi.Size = new System.Drawing.Size(78, 20);
            this.spinEditComi.StyleController = this.layoutControl1;
            this.spinEditComi.TabIndex = 27;
            // 
            // txtComi2
            // 
            this.txtComi2.Location = new System.Drawing.Point(107, 144);
            this.txtComi2.Name = "txtComi2";
            this.txtComi2.Size = new System.Drawing.Size(210, 20);
            this.txtComi2.StyleController = this.layoutControl1;
            this.txtComi2.TabIndex = 28;
            // 
            // spinEditComi2
            // 
            this.spinEditComi2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditComi2.Location = new System.Drawing.Point(337, 144);
            this.spinEditComi2.Name = "spinEditComi2";
            this.spinEditComi2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditComi2.Properties.Mask.EditMask = "P";
            this.spinEditComi2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditComi2.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditComi2.Size = new System.Drawing.Size(78, 20);
            this.spinEditComi2.StyleController = this.layoutControl1;
            this.spinEditComi2.TabIndex = 29;
            // 
            // txtComi3
            // 
            this.txtComi3.Location = new System.Drawing.Point(490, 144);
            this.txtComi3.Name = "txtComi3";
            this.txtComi3.Size = new System.Drawing.Size(189, 20);
            this.txtComi3.StyleController = this.layoutControl1;
            this.txtComi3.TabIndex = 30;
            // 
            // spinEditComi3
            // 
            this.spinEditComi3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditComi3.Location = new System.Drawing.Point(699, 144);
            this.spinEditComi3.Name = "spinEditComi3";
            this.spinEditComi3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditComi3.Properties.Mask.EditMask = "P";
            this.spinEditComi3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditComi3.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditComi3.Size = new System.Drawing.Size(59, 20);
            this.spinEditComi3.StyleController = this.layoutControl1;
            this.spinEditComi3.TabIndex = 31;
            // 
            // spinEditEmpFact
            // 
            this.spinEditEmpFact.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditEmpFact.Location = new System.Drawing.Point(669, 354);
            this.spinEditEmpFact.Name = "spinEditEmpFact";
            this.spinEditEmpFact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditEmpFact.Properties.Mask.EditMask = "P";
            this.spinEditEmpFact.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditEmpFact.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditEmpFact.Size = new System.Drawing.Size(89, 20);
            this.spinEditEmpFact.StyleController = this.layoutControl1;
            this.spinEditEmpFact.TabIndex = 32;
            // 
            // spinEditEmpFact2
            // 
            this.spinEditEmpFact2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditEmpFact2.Location = new System.Drawing.Point(669, 378);
            this.spinEditEmpFact2.Name = "spinEditEmpFact2";
            this.spinEditEmpFact2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditEmpFact2.Properties.Mask.EditMask = "P";
            this.spinEditEmpFact2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditEmpFact2.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditEmpFact2.Size = new System.Drawing.Size(89, 20);
            this.spinEditEmpFact2.StyleController = this.layoutControl1;
            this.spinEditEmpFact2.TabIndex = 33;
            // 
            // spinEditEmpFact3
            // 
            this.spinEditEmpFact3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditEmpFact3.Location = new System.Drawing.Point(669, 402);
            this.spinEditEmpFact3.Name = "spinEditEmpFact3";
            this.spinEditEmpFact3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditEmpFact3.Properties.Mask.EditMask = "P";
            this.spinEditEmpFact3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditEmpFact3.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditEmpFact3.Size = new System.Drawing.Size(89, 20);
            this.spinEditEmpFact3.StyleController = this.layoutControl1;
            this.spinEditEmpFact3.TabIndex = 34;
            // 
            // spinEditEmpFact4
            // 
            this.spinEditEmpFact4.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditEmpFact4.Location = new System.Drawing.Point(669, 426);
            this.spinEditEmpFact4.Name = "spinEditEmpFact4";
            this.spinEditEmpFact4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditEmpFact4.Properties.Mask.EditMask = "P";
            this.spinEditEmpFact4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditEmpFact4.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditEmpFact4.Size = new System.Drawing.Size(89, 20);
            this.spinEditEmpFact4.StyleController = this.layoutControl1;
            this.spinEditEmpFact4.TabIndex = 35;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(129, 216);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(629, 20);
            this.txtCorreo.StyleController = this.layoutControl1;
            this.txtCorreo.TabIndex = 36;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 548);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup3,
            this.layoutControlItem13,
            this.layoutControlItem21,
            this.layoutControlGroup4,
            this.emptySpaceItem4,
            this.layoutControlItem22,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(774, 528);
            this.layoutControlGroup2.Text = "Ingrese Información del Cliente ";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(95, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(155, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Datos Generales";
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem17,
            this.layoutControlItem20,
            this.layoutControlItem23,
            this.layoutControlComi2,
            this.layoutControlSpinComi2,
            this.layoutControlComi3,
            this.layoutControlSpinComi3,
            this.layoutControlItem28});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(750, 186);
            this.layoutControlGroup3.Text = "Datos Generales";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lookUpEjecutivo;
            this.layoutControlItem6.Location = new System.Drawing.Point(383, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(343, 24);
            this.layoutControlItem6.Text = "Ejecutivo Responsable";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(108, 13);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtComisionista;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(285, 24);
            this.layoutControlItem3.Text = "Comisionista";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(59, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.lookUpPeriodo;
            this.layoutControlItem9.Location = new System.Drawing.Point(340, 72);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(386, 24);
            this.layoutControlItem9.Text = "Periodo de Pago";
            this.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(78, 13);
            this.layoutControlItem9.TextToControlDistance = 5;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtProveedor;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem10.Text = "Proveedor";
            this.layoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem10.TextToControlDistance = 5;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.txtNombre;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(726, 24);
            this.layoutControlItem17.Text = "Nombre";
            this.layoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem17.TextSize = new System.Drawing.Size(37, 13);
            this.layoutControlItem17.TextToControlDistance = 5;
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.txtObservaciones;
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(726, 24);
            this.layoutControlItem20.Text = "Observaciones";
            this.layoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem20.TextSize = new System.Drawing.Size(71, 13);
            this.layoutControlItem20.TextToControlDistance = 5;
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.spinEditComi;
            this.layoutControlItem23.Location = new System.Drawing.Point(285, 24);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(98, 24);
            this.layoutControlItem23.Text = "%";
            this.layoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem23.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlItem23.TextToControlDistance = 5;
            // 
            // layoutControlComi2
            // 
            this.layoutControlComi2.Control = this.txtComi2;
            this.layoutControlComi2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlComi2.Name = "layoutControlComi2";
            this.layoutControlComi2.Size = new System.Drawing.Size(285, 24);
            this.layoutControlComi2.Text = "Comisionista 2";
            this.layoutControlComi2.TextSize = new System.Drawing.Size(68, 13);
            this.layoutControlComi2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlSpinComi2
            // 
            this.layoutControlSpinComi2.Control = this.spinEditComi2;
            this.layoutControlSpinComi2.Location = new System.Drawing.Point(285, 48);
            this.layoutControlSpinComi2.Name = "layoutControlSpinComi2";
            this.layoutControlSpinComi2.Size = new System.Drawing.Size(98, 24);
            this.layoutControlSpinComi2.Text = "%";
            this.layoutControlSpinComi2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlSpinComi2.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlSpinComi2.TextToControlDistance = 5;
            this.layoutControlSpinComi2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlComi3
            // 
            this.layoutControlComi3.Control = this.txtComi3;
            this.layoutControlComi3.Location = new System.Drawing.Point(383, 48);
            this.layoutControlComi3.Name = "layoutControlComi3";
            this.layoutControlComi3.Size = new System.Drawing.Size(264, 24);
            this.layoutControlComi3.Text = "Comicionista 3";
            this.layoutControlComi3.TextSize = new System.Drawing.Size(68, 13);
            this.layoutControlComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlSpinComi3
            // 
            this.layoutControlSpinComi3.Control = this.spinEditComi3;
            this.layoutControlSpinComi3.Location = new System.Drawing.Point(647, 48);
            this.layoutControlSpinComi3.Name = "layoutControlSpinComi3";
            this.layoutControlSpinComi3.Size = new System.Drawing.Size(79, 24);
            this.layoutControlSpinComi3.Text = "%";
            this.layoutControlSpinComi3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlSpinComi3.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlSpinComi3.TextToControlDistance = 5;
            this.layoutControlSpinComi3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.txtCorreo;
            this.layoutControlItem28.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(726, 24);
            this.layoutControlItem28.Text = "Correo Electronico";
            this.layoutControlItem28.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem28.TextSize = new System.Drawing.Size(88, 13);
            this.layoutControlItem28.TextToControlDistance = 5;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.chBoxEmpFactura;
            this.layoutControlItem13.Location = new System.Drawing.Point(451, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(299, 24);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.btnAgregar;
            this.layoutControlItem21.Location = new System.Drawing.Point(614, 444);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(136, 42);
            this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem21.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Datos Facturación";
            this.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItemRetIVA,
            this.layoutControlItem14,
            this.layoutControlItem11,
            this.layoutControlItem18,
            this.layoutControlItem19,
            this.layoutControlItem7,
            this.layoutControlItem12,
            this.layoutControlItem8,
            this.layoutControlItem24,
            this.layoutControlItem16,
            this.layoutControlItem15,
            this.layoutControlItem25,
            this.layoutControlItem26,
            this.layoutControlItem27});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 210);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(750, 234);
            this.layoutControlGroup4.Text = "Datos Facturación";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.spinEditPerISN;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(244, 24);
            this.layoutControlItem4.Text = "% ISN";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(31, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.spinEditPerServ;
            this.layoutControlItem5.Location = new System.Drawing.Point(244, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(197, 24);
            this.layoutControlItem5.Text = "% Comisión Servicio";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(96, 13);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItemRetIVA
            // 
            this.layoutControlItemRetIVA.Control = this.spinEditRetIVA;
            this.layoutControlItemRetIVA.Location = new System.Drawing.Point(441, 24);
            this.layoutControlItemRetIVA.Name = "layoutControlItemRetIVA";
            this.layoutControlItemRetIVA.Size = new System.Drawing.Size(285, 24);
            this.layoutControlItemRetIVA.Text = "% Retención IVA";
            this.layoutControlItemRetIVA.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItemRetIVA.TextSize = new System.Drawing.Size(82, 13);
            this.layoutControlItemRetIVA.TextToControlDistance = 5;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.lookUpEmprFact2;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem14.Text = "Empresa que factura 2";
            this.layoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem14.TextSize = new System.Drawing.Size(109, 13);
            this.layoutControlItem14.TextToControlDistance = 5;
            this.layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.lookUpEmpCFDI;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(726, 24);
            this.layoutControlItem11.Text = "Empresa Emite CFDI";
            this.layoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(97, 13);
            this.layoutControlItem11.TextToControlDistance = 5;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.lookUpMetodoPago;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(288, 24);
            this.layoutControlItem18.Text = "Metodo de Pago";
            this.layoutControlItem18.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem18.TextSize = new System.Drawing.Size(78, 13);
            this.layoutControlItem18.TextToControlDistance = 5;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.lookUpFormaPago;
            this.layoutControlItem19.Location = new System.Drawing.Point(288, 168);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(438, 24);
            this.layoutControlItem19.Text = "Forma de Pago";
            this.layoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem19.TextSize = new System.Drawing.Size(72, 13);
            this.layoutControlItem19.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lookUpFacIva;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItem7.Text = "Facturación Con IVA";
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(98, 13);
            this.layoutControlItem7.TextToControlDistance = 5;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.lookUpEmprFact;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem12.Text = "Empresa que factura";
            this.layoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(100, 13);
            this.layoutControlItem12.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lookUpRetIva;
            this.layoutControlItem8.CustomizationFormText = "Retención IVA";
            this.layoutControlItem8.Location = new System.Drawing.Point(362, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(364, 24);
            this.layoutControlItem8.Text = "Retención IVA";
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(68, 13);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.spinEditEmpFact;
            this.layoutControlItem24.Location = new System.Drawing.Point(617, 72);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(109, 24);
            this.layoutControlItem24.Text = "%";
            this.layoutControlItem24.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem24.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlItem24.TextToControlDistance = 5;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.lookUpEmprFact3;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem16.Text = "Empresa que factura 3";
            this.layoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem16.TextSize = new System.Drawing.Size(109, 13);
            this.layoutControlItem16.TextToControlDistance = 5;
            this.layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.lookUpEmprFact4;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem15.Text = "Empresa que factura 4";
            this.layoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem15.TextSize = new System.Drawing.Size(109, 13);
            this.layoutControlItem15.TextToControlDistance = 5;
            this.layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.spinEditEmpFact2;
            this.layoutControlItem25.Location = new System.Drawing.Point(617, 96);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(109, 24);
            this.layoutControlItem25.Text = "%";
            this.layoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem25.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlItem25.TextToControlDistance = 5;
            this.layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.spinEditEmpFact3;
            this.layoutControlItem26.Location = new System.Drawing.Point(617, 120);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(109, 24);
            this.layoutControlItem26.Text = "%";
            this.layoutControlItem26.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem26.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlItem26.TextToControlDistance = 5;
            this.layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.spinEditEmpFact4;
            this.layoutControlItem27.Location = new System.Drawing.Point(617, 144);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(109, 24);
            this.layoutControlItem27.Text = "%";
            this.layoutControlItem27.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem27.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlItem27.TextToControlDistance = 5;
            this.layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 444);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(614, 42);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.txtIDClte;
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(95, 24);
            this.layoutControlItem22.Text = "ID";
            this.layoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem22.TextSize = new System.Drawing.Size(11, 13);
            this.layoutControlItem22.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chComi;
            this.layoutControlItem1.Location = new System.Drawing.Point(250, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem1.Text = "Cliente tiene más de un comisionista";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNombre;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(732, 24);
            this.layoutControlItem2.Text = "Nombre";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(37, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 542);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComisionista.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPerISN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPerServ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditRetIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFacIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRetIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEjecutivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosSistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicidadPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmpCFDI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaCatalogoCFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmprFact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaPagaAsimiladosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBoxEmpFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmprFact2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmprFact3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmprFact4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMetodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDClte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chComi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditComi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditComi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComi3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditComi3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEmpFact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEmpFact2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEmpFact3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEmpFact4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlComi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSpinComi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlComi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSpinComi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRetIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtComisionista;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SpinEdit spinEditPerISN;
        private DevExpress.XtraEditors.SpinEdit spinEditPerServ;
        private DevExpress.XtraEditors.SpinEdit spinEditRetIVA;
        private DevExpress.XtraEditors.LookUpEdit lookUpFacIva;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRetIVA;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.LookUpEdit lookUpRetIva;
        private DevExpress.XtraEditors.LookUpEdit lookUpEjecutivo;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.LookUpEdit lookUpPeriodo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.LookUpEdit lookUpEmpCFDI;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.LookUpEdit lookUpEmprFact;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.CheckEdit chBoxEmpFactura;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraEditors.LookUpEdit lookUpEmprFact2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEmprFact3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEmprFact4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit lookUpMetodoPago;
        private DevExpress.XtraEditors.LookUpEdit lookUpFormaPago;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraEditors.TextEdit txtObservaciones;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraEditors.TextEdit txtIDClte;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private System.Windows.Forms.BindingSource usuariosSistemaBindingSource;
        private System.Windows.Forms.BindingSource empresaCatalogoCFDIBindingSource;
        private System.Windows.Forms.BindingSource empresaPagaAsimiladosBindingSource;
        private System.Windows.Forms.BindingSource opcionesBindingSource;
        private System.Windows.Forms.BindingSource formaPagoBindingSource;
        private System.Windows.Forms.BindingSource metodoPagoBindingSource;
        private System.Windows.Forms.BindingSource periodicidadPagoBindingSource;
        private System.Windows.Forms.BindingSource opcionesBindingSource1;
        private DevExpress.XtraEditors.CheckEdit chComi;
        private DevExpress.XtraEditors.SpinEdit spinEditComi;
        private DevExpress.XtraEditors.TextEdit txtComi2;
        private DevExpress.XtraEditors.SpinEdit spinEditComi2;
        private DevExpress.XtraEditors.TextEdit txtComi3;
        private DevExpress.XtraEditors.SpinEdit spinEditComi3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlComi2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlSpinComi2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlComi3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlSpinComi3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SpinEdit spinEditEmpFact;
        private DevExpress.XtraEditors.SpinEdit spinEditEmpFact2;
        private DevExpress.XtraEditors.SpinEdit spinEditEmpFact3;
        private DevExpress.XtraEditors.SpinEdit spinEditEmpFact4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
    }
}