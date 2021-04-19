
namespace winAsimilados.Views
{
    partial class DetallesNomina
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
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesNomina));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.nominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnominanumEmpl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnominanombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnominaRFCEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnominaPeriodidicadPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.periodicidadPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colnominaIngresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnominaIngresosNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnominaISR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnominaEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnominaEstatusSAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnominaDescripciponError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.txtFecPeriFin = new DevExpress.XtraEditors.TextEdit();
            this.txtIngBruto = new DevExpress.XtraEditors.TextEdit();
            this.txtISR = new DevExpress.XtraEditors.TextEdit();
            this.txtIngNeto = new DevExpress.XtraEditors.TextEdit();
            this.txtEmpresaGral = new DevExpress.XtraEditors.TextEdit();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.txtFechaCreacion = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuaCreacion = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuaCierre = new DevExpress.XtraEditors.TextEdit();
            this.txtFechaPago = new DevExpress.XtraEditors.TextEdit();
            this.txtFechaCierre = new DevExpress.XtraEditors.TextEdit();
            this.txtEstatusGral = new DevExpress.XtraEditors.TextEdit();
            this.txtFecPeriIni = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalEmpleados = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup11 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup13 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem34 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem35 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem38 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem39 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem40 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem36 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem37 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem17 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoytFechaPago = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem32 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem43 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem16 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicidadPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecPeriFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngBruto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngNeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresaGral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaCreacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuaCreacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuaCierre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaCierre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstatusGral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecPeriIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEmpleados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoytFechaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtPeriodo);
            this.layoutControl1.Controls.Add(this.txtFecPeriFin);
            this.layoutControl1.Controls.Add(this.txtIngBruto);
            this.layoutControl1.Controls.Add(this.txtISR);
            this.layoutControl1.Controls.Add(this.txtIngNeto);
            this.layoutControl1.Controls.Add(this.txtEmpresaGral);
            this.layoutControl1.Controls.Add(this.txtRFC);
            this.layoutControl1.Controls.Add(this.txtFechaCreacion);
            this.layoutControl1.Controls.Add(this.txtUsuaCreacion);
            this.layoutControl1.Controls.Add(this.txtUsuaCierre);
            this.layoutControl1.Controls.Add(this.txtFechaPago);
            this.layoutControl1.Controls.Add(this.txtFechaCierre);
            this.layoutControl1.Controls.Add(this.txtEstatusGral);
            this.layoutControl1.Controls.Add(this.txtFecPeriIni);
            this.layoutControl1.Controls.Add(this.txtTotalEmpleados);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 60, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1045, 600);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nominaBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(36, 416);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(973, 148);
            this.gridControl1.TabIndex = 63;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nominaBindingSource
            // 
            this.nominaBindingSource.DataMember = "Nomina";
            this.nominaBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Asimilados";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "nominanumEmpl";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"514\" />";
            table1.Name = "Nomina";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "nominanombreEmpleado";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "nominaRFCEmpleado";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "nominaIngresosBruto";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "nominaISR";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "nominaEstatusSAT";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "nominaDescripciponError";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "nominaPeriodidicadPago";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "nominaIngresos";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.FilterString = "[Nomina.ResumenNominaID] = ?ResumenNominaID";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "Nomina";
            queryParameter1.Name = "ResumenNominaID";
            queryParameter1.Type = typeof(string);
            selectQuery1.Parameters.Add(queryParameter1);
            selectQuery1.Tables.Add(table1);
            columnExpression10.ColumnName = "c_PeriodicidadPago";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"115\" />";
            table2.Name = "PeriodicidadPago";
            columnExpression10.Table = table2;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "Descripcion";
            columnExpression11.Table = table2;
            column11.Expression = columnExpression11;
            selectQuery2.Columns.Add(column10);
            selectQuery2.Columns.Add(column11);
            selectQuery2.Name = "PeriodicidadPago";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnominanumEmpl,
            this.colnominanombreEmpleado,
            this.colnominaRFCEmpleado,
            this.colnominaPeriodidicadPago,
            this.colnominaIngresos,
            this.colnominaIngresosNeto,
            this.colnominaISR,
            this.colnominaEstatus,
            this.colnominaEstatusSAT,
            this.colnominaDescripciponError});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colnominanumEmpl
            // 
            this.colnominanumEmpl.Caption = "# Empleado";
            this.colnominanumEmpl.FieldName = "nominanumEmpl";
            this.colnominanumEmpl.Name = "colnominanumEmpl";
            this.colnominanumEmpl.OptionsColumn.ReadOnly = true;
            this.colnominanumEmpl.Visible = true;
            this.colnominanumEmpl.VisibleIndex = 0;
            this.colnominanumEmpl.Width = 69;
            // 
            // colnominanombreEmpleado
            // 
            this.colnominanombreEmpleado.Caption = "Nombre";
            this.colnominanombreEmpleado.FieldName = "nominanombreEmpleado";
            this.colnominanombreEmpleado.Name = "colnominanombreEmpleado";
            this.colnominanombreEmpleado.OptionsColumn.ReadOnly = true;
            this.colnominanombreEmpleado.Visible = true;
            this.colnominanombreEmpleado.VisibleIndex = 1;
            this.colnominanombreEmpleado.Width = 69;
            // 
            // colnominaRFCEmpleado
            // 
            this.colnominaRFCEmpleado.Caption = "RFC";
            this.colnominaRFCEmpleado.FieldName = "nominaRFCEmpleado";
            this.colnominaRFCEmpleado.Name = "colnominaRFCEmpleado";
            this.colnominaRFCEmpleado.OptionsColumn.ReadOnly = true;
            this.colnominaRFCEmpleado.Visible = true;
            this.colnominaRFCEmpleado.VisibleIndex = 2;
            this.colnominaRFCEmpleado.Width = 69;
            // 
            // colnominaPeriodidicadPago
            // 
            this.colnominaPeriodidicadPago.Caption = "Perodicidad Pago";
            this.colnominaPeriodidicadPago.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colnominaPeriodidicadPago.FieldName = "nominaPeriodidicadPago";
            this.colnominaPeriodidicadPago.Name = "colnominaPeriodidicadPago";
            this.colnominaPeriodidicadPago.OptionsColumn.ReadOnly = true;
            this.colnominaPeriodidicadPago.Visible = true;
            this.colnominaPeriodidicadPago.VisibleIndex = 3;
            this.colnominaPeriodidicadPago.Width = 95;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.periodicidadPagoBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Descripcion";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "c_PeriodicidadPago";
            // 
            // periodicidadPagoBindingSource
            // 
            this.periodicidadPagoBindingSource.DataMember = "PeriodicidadPago";
            this.periodicidadPagoBindingSource.DataSource = this.sqlDataSource1;
            // 
            // colnominaIngresos
            // 
            this.colnominaIngresos.Caption = "Ingresos (Brutos)";
            this.colnominaIngresos.DisplayFormat.FormatString = "c2";
            this.colnominaIngresos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnominaIngresos.FieldName = "nominaIngresosBruto";
            this.colnominaIngresos.Name = "colnominaIngresos";
            this.colnominaIngresos.OptionsColumn.ReadOnly = true;
            this.colnominaIngresos.Visible = true;
            this.colnominaIngresos.VisibleIndex = 4;
            this.colnominaIngresos.Width = 104;
            // 
            // colnominaIngresosNeto
            // 
            this.colnominaIngresosNeto.Caption = "Ingresos (Netos)";
            this.colnominaIngresosNeto.DisplayFormat.FormatString = "c2";
            this.colnominaIngresosNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnominaIngresosNeto.FieldName = "nominaIngresos";
            this.colnominaIngresosNeto.Name = "colnominaIngresosNeto";
            this.colnominaIngresosNeto.OptionsColumn.ReadOnly = true;
            this.colnominaIngresosNeto.Visible = true;
            this.colnominaIngresosNeto.VisibleIndex = 6;
            this.colnominaIngresosNeto.Width = 101;
            // 
            // colnominaISR
            // 
            this.colnominaISR.Caption = "ISR";
            this.colnominaISR.DisplayFormat.FormatString = "c2";
            this.colnominaISR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnominaISR.FieldName = "nominaISR";
            this.colnominaISR.Name = "colnominaISR";
            this.colnominaISR.OptionsColumn.ReadOnly = true;
            this.colnominaISR.Visible = true;
            this.colnominaISR.VisibleIndex = 5;
            this.colnominaISR.Width = 63;
            // 
            // colnominaEstatus
            // 
            this.colnominaEstatus.FieldName = "nominaEstatus";
            this.colnominaEstatus.Name = "colnominaEstatus";
            this.colnominaEstatus.OptionsColumn.ReadOnly = true;
            // 
            // colnominaEstatusSAT
            // 
            this.colnominaEstatusSAT.Caption = "Estatus SAT";
            this.colnominaEstatusSAT.FieldName = "nominaEstatusSAT";
            this.colnominaEstatusSAT.Name = "colnominaEstatusSAT";
            this.colnominaEstatusSAT.Visible = true;
            this.colnominaEstatusSAT.VisibleIndex = 7;
            this.colnominaEstatusSAT.Width = 78;
            // 
            // colnominaDescripciponError
            // 
            this.colnominaDescripciponError.Caption = "Error";
            this.colnominaDescripciponError.FieldName = "nominaDescripciponError";
            this.colnominaDescripciponError.Name = "colnominaDescripciponError";
            this.colnominaDescripciponError.Visible = true;
            this.colnominaDescripciponError.VisibleIndex = 8;
            this.colnominaDescripciponError.Width = 58;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(77, 234);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPeriodo.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtPeriodo.Properties.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(88, 20);
            this.txtPeriodo.StyleController = this.layoutControl1;
            this.txtPeriodo.TabIndex = 53;
            // 
            // txtFecPeriFin
            // 
            this.txtFecPeriFin.Location = new System.Drawing.Point(367, 234);
            this.txtFecPeriFin.Name = "txtFecPeriFin";
            this.txtFecPeriFin.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFecPeriFin.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtFecPeriFin.Properties.ReadOnly = true;
            this.txtFecPeriFin.Size = new System.Drawing.Size(153, 20);
            this.txtFecPeriFin.StyleController = this.layoutControl1;
            this.txtFecPeriFin.TabIndex = 54;
            // 
            // txtIngBruto
            // 
            this.txtIngBruto.EditValue = "0";
            this.txtIngBruto.Location = new System.Drawing.Point(137, 292);
            this.txtIngBruto.Name = "txtIngBruto";
            this.txtIngBruto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIngBruto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtIngBruto.Properties.Mask.EditMask = "c";
            this.txtIngBruto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIngBruto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIngBruto.Properties.ReadOnly = true;
            this.txtIngBruto.Size = new System.Drawing.Size(284, 20);
            this.txtIngBruto.StyleController = this.layoutControl1;
            this.txtIngBruto.TabIndex = 57;
            // 
            // txtISR
            // 
            this.txtISR.EditValue = "0";
            this.txtISR.Location = new System.Drawing.Point(137, 316);
            this.txtISR.Name = "txtISR";
            this.txtISR.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtISR.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtISR.Properties.Mask.EditMask = "c";
            this.txtISR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtISR.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtISR.Properties.ReadOnly = true;
            this.txtISR.Size = new System.Drawing.Size(284, 20);
            this.txtISR.StyleController = this.layoutControl1;
            this.txtISR.TabIndex = 58;
            // 
            // txtIngNeto
            // 
            this.txtIngNeto.EditValue = "0";
            this.txtIngNeto.Location = new System.Drawing.Point(137, 340);
            this.txtIngNeto.Name = "txtIngNeto";
            this.txtIngNeto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIngNeto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtIngNeto.Properties.Mask.EditMask = "c";
            this.txtIngNeto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIngNeto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIngNeto.Properties.ReadOnly = true;
            this.txtIngNeto.Size = new System.Drawing.Size(284, 20);
            this.txtIngNeto.StyleController = this.layoutControl1;
            this.txtIngNeto.TabIndex = 59;
            // 
            // txtEmpresaGral
            // 
            this.txtEmpresaGral.Location = new System.Drawing.Point(85, 210);
            this.txtEmpresaGral.Name = "txtEmpresaGral";
            this.txtEmpresaGral.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmpresaGral.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtEmpresaGral.Properties.ReadOnly = true;
            this.txtEmpresaGral.Size = new System.Drawing.Size(435, 20);
            this.txtEmpresaGral.StyleController = this.layoutControl1;
            this.txtEmpresaGral.TabIndex = 55;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(549, 210);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRFC.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtRFC.Properties.ReadOnly = true;
            this.txtRFC.Size = new System.Drawing.Size(460, 20);
            this.txtRFC.StyleController = this.layoutControl1;
            this.txtRFC.TabIndex = 56;
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(115, 96);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFechaCreacion.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtFechaCreacion.Properties.ReadOnly = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(269, 20);
            this.txtFechaCreacion.StyleController = this.layoutControl1;
            this.txtFechaCreacion.TabIndex = 47;
            // 
            // txtUsuaCreacion
            // 
            this.txtUsuaCreacion.Location = new System.Drawing.Point(440, 96);
            this.txtUsuaCreacion.Name = "txtUsuaCreacion";
            this.txtUsuaCreacion.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsuaCreacion.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtUsuaCreacion.Properties.ReadOnly = true;
            this.txtUsuaCreacion.Size = new System.Drawing.Size(168, 20);
            this.txtUsuaCreacion.StyleController = this.layoutControl1;
            this.txtUsuaCreacion.TabIndex = 48;
            // 
            // txtUsuaCierre
            // 
            this.txtUsuaCierre.Location = new System.Drawing.Point(440, 144);
            this.txtUsuaCierre.Name = "txtUsuaCierre";
            this.txtUsuaCierre.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsuaCierre.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtUsuaCierre.Properties.ReadOnly = true;
            this.txtUsuaCierre.Size = new System.Drawing.Size(168, 20);
            this.txtUsuaCierre.StyleController = this.layoutControl1;
            this.txtUsuaCierre.TabIndex = 52;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(100, 120);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFechaPago.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtFechaPago.Properties.ReadOnly = true;
            this.txtFechaPago.Size = new System.Drawing.Size(284, 20);
            this.txtFechaPago.StyleController = this.layoutControl1;
            this.txtFechaPago.TabIndex = 49;
            // 
            // txtFechaCierre
            // 
            this.txtFechaCierre.Location = new System.Drawing.Point(102, 144);
            this.txtFechaCierre.Name = "txtFechaCierre";
            this.txtFechaCierre.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFechaCierre.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtFechaCierre.Properties.ReadOnly = true;
            this.txtFechaCierre.Size = new System.Drawing.Size(282, 20);
            this.txtFechaCierre.StyleController = this.layoutControl1;
            this.txtFechaCierre.TabIndex = 51;
            // 
            // txtEstatusGral
            // 
            this.txtEstatusGral.Location = new System.Drawing.Point(65, 42);
            this.txtEstatusGral.Name = "txtEstatusGral";
            this.txtEstatusGral.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEstatusGral.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtEstatusGral.Properties.ReadOnly = true;
            this.txtEstatusGral.Size = new System.Drawing.Size(168, 20);
            this.txtEstatusGral.StyleController = this.layoutControl1;
            this.txtEstatusGral.TabIndex = 62;
            // 
            // txtFecPeriIni
            // 
            this.txtFecPeriIni.Location = new System.Drawing.Point(189, 234);
            this.txtFecPeriIni.Name = "txtFecPeriIni";
            this.txtFecPeriIni.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFecPeriIni.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtFecPeriIni.Properties.ReadOnly = true;
            this.txtFecPeriIni.Size = new System.Drawing.Size(160, 20);
            this.txtFecPeriIni.StyleController = this.layoutControl1;
            this.txtFecPeriIni.TabIndex = 54;
            // 
            // txtTotalEmpleados
            // 
            this.txtTotalEmpleados.EditValue = "";
            this.txtTotalEmpleados.Location = new System.Drawing.Point(137, 268);
            this.txtTotalEmpleados.Name = "txtTotalEmpleados";
            this.txtTotalEmpleados.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTotalEmpleados.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTotalEmpleados.Properties.Mask.EditMask = "n";
            this.txtTotalEmpleados.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalEmpleados.Properties.ReadOnly = true;
            this.txtTotalEmpleados.Size = new System.Drawing.Size(50, 20);
            this.txtTotalEmpleados.StyleController = this.layoutControl1;
            this.txtTotalEmpleados.TabIndex = 57;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup11});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1045, 600);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup11
            // 
            this.layoutControlGroup11.CustomizationFormText = "Detalles";
            this.layoutControlGroup11.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup11.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup13,
            this.layoutControlGroup12,
            this.layoutControlItem43,
            this.emptySpaceItem16,
            this.layoutControlGroup2});
            this.layoutControlGroup11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup11.Name = "layoutControlGroup11";
            this.layoutControlGroup11.Size = new System.Drawing.Size(1025, 580);
            this.layoutControlGroup11.Text = "Detalles";
            // 
            // layoutControlGroup13
            // 
            this.layoutControlGroup13.CustomizationFormText = "Información General";
            this.layoutControlGroup13.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup13.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem34,
            this.layoutControlItem35,
            this.layoutControlItem38,
            this.emptySpaceItem11,
            this.emptySpaceItem14,
            this.layoutControlItem39,
            this.layoutControlItem40,
            this.layoutControlItem36,
            this.layoutControlItem37,
            this.emptySpaceItem17,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2});
            this.layoutControlGroup13.Location = new System.Drawing.Point(0, 138);
            this.layoutControlGroup13.Name = "layoutControlGroup13";
            this.layoutControlGroup13.Size = new System.Drawing.Size(1001, 206);
            this.layoutControlGroup13.Text = "Información General";
            // 
            // layoutControlItem34
            // 
            this.layoutControlItem34.Control = this.txtPeriodo;
            this.layoutControlItem34.CustomizationFormText = "Nombre Caratula";
            this.layoutControlItem34.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem34.Name = "layoutControlItem34";
            this.layoutControlItem34.Size = new System.Drawing.Size(133, 24);
            this.layoutControlItem34.Text = "Periodo";
            this.layoutControlItem34.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem34.TextSize = new System.Drawing.Size(36, 13);
            this.layoutControlItem34.TextToControlDistance = 5;
            // 
            // layoutControlItem35
            // 
            this.layoutControlItem35.Control = this.txtFecPeriFin;
            this.layoutControlItem35.CustomizationFormText = "Nombre Layout";
            this.layoutControlItem35.Location = new System.Drawing.Point(317, 24);
            this.layoutControlItem35.Name = "layoutControlItem35";
            this.layoutControlItem35.Size = new System.Drawing.Size(171, 24);
            this.layoutControlItem35.Text = "Al";
            this.layoutControlItem35.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem35.TextSize = new System.Drawing.Size(9, 13);
            this.layoutControlItem35.TextToControlDistance = 5;
            // 
            // layoutControlItem38
            // 
            this.layoutControlItem38.Control = this.txtIngBruto;
            this.layoutControlItem38.CustomizationFormText = "Pago Asimilados";
            this.layoutControlItem38.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem38.Name = "layoutControlItem38";
            this.layoutControlItem38.Size = new System.Drawing.Size(389, 24);
            this.layoutControlItem38.Text = "Total Ingresos Bruto";
            this.layoutControlItem38.TextSize = new System.Drawing.Size(98, 13);
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.CustomizationFormText = "emptySpaceItem11";
            this.emptySpaceItem11.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(977, 10);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem14
            // 
            this.emptySpaceItem14.AllowHotTrack = false;
            this.emptySpaceItem14.CustomizationFormText = "emptySpaceItem14";
            this.emptySpaceItem14.Location = new System.Drawing.Point(389, 58);
            this.emptySpaceItem14.Name = "emptySpaceItem14";
            this.emptySpaceItem14.Size = new System.Drawing.Size(588, 96);
            this.emptySpaceItem14.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem39
            // 
            this.layoutControlItem39.Control = this.txtISR;
            this.layoutControlItem39.CustomizationFormText = "Comisión por Servicio";
            this.layoutControlItem39.Location = new System.Drawing.Point(0, 106);
            this.layoutControlItem39.Name = "layoutControlItem39";
            this.layoutControlItem39.Size = new System.Drawing.Size(389, 24);
            this.layoutControlItem39.Text = "Total ISR";
            this.layoutControlItem39.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem40
            // 
            this.layoutControlItem40.Control = this.txtIngNeto;
            this.layoutControlItem40.CustomizationFormText = "Impuesto Sobre Nómina";
            this.layoutControlItem40.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem40.Name = "layoutControlItem40";
            this.layoutControlItem40.Size = new System.Drawing.Size(389, 24);
            this.layoutControlItem40.Text = "Total Ingresos Neto";
            this.layoutControlItem40.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem36
            // 
            this.layoutControlItem36.Control = this.txtEmpresaGral;
            this.layoutControlItem36.CustomizationFormText = "Empresa ";
            this.layoutControlItem36.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem36.Name = "layoutControlItem36";
            this.layoutControlItem36.Size = new System.Drawing.Size(488, 24);
            this.layoutControlItem36.Text = "Empresa ";
            this.layoutControlItem36.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem36.TextSize = new System.Drawing.Size(44, 13);
            this.layoutControlItem36.TextToControlDistance = 5;
            // 
            // layoutControlItem37
            // 
            this.layoutControlItem37.Control = this.txtRFC;
            this.layoutControlItem37.CustomizationFormText = "Cliente";
            this.layoutControlItem37.Location = new System.Drawing.Point(488, 0);
            this.layoutControlItem37.Name = "layoutControlItem37";
            this.layoutControlItem37.Size = new System.Drawing.Size(489, 24);
            this.layoutControlItem37.Text = "RFC";
            this.layoutControlItem37.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem37.TextSize = new System.Drawing.Size(20, 13);
            this.layoutControlItem37.TextToControlDistance = 5;
            // 
            // emptySpaceItem17
            // 
            this.emptySpaceItem17.AllowHotTrack = false;
            this.emptySpaceItem17.CustomizationFormText = "emptySpaceItem17";
            this.emptySpaceItem17.Location = new System.Drawing.Point(0, 154);
            this.emptySpaceItem17.Name = "emptySpaceItem17";
            this.emptySpaceItem17.Size = new System.Drawing.Size(977, 10);
            this.emptySpaceItem17.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtFecPeriIni;
            this.layoutControlItem1.CustomizationFormText = "Nombre Layout";
            this.layoutControlItem1.Location = new System.Drawing.Point(133, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(184, 24);
            this.layoutControlItem1.Text = "Del";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(15, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(488, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(489, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTotalEmpleados;
            this.layoutControlItem2.CustomizationFormText = "Pago Asimilados";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(155, 24);
            this.layoutControlItem2.Text = "Total Empleados";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(98, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(155, 58);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(234, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup12
            // 
            this.layoutControlGroup12.CustomizationFormText = "Fechas";
            this.layoutControlGroup12.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup12.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem19,
            this.layoutControlItem29,
            this.LayoytFechaPago,
            this.emptySpaceItem8,
            this.emptySpaceItem9,
            this.layoutControlItem31,
            this.layoutControlItem32,
            this.emptySpaceItem3});
            this.layoutControlGroup12.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup12.Name = "layoutControlGroup12";
            this.layoutControlGroup12.Size = new System.Drawing.Size(1001, 114);
            this.layoutControlGroup12.Text = "Fechas";
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.txtFechaCreacion;
            this.layoutControlItem19.CustomizationFormText = "Fecha Creación";
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem19.Text = "Fecha Creación";
            this.layoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem19.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem19.TextSize = new System.Drawing.Size(74, 13);
            this.layoutControlItem19.TextToControlDistance = 5;
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.Control = this.txtUsuaCreacion;
            this.layoutControlItem29.CustomizationFormText = "Usuario";
            this.layoutControlItem29.Location = new System.Drawing.Point(363, 0);
            this.layoutControlItem29.Name = "layoutControlItem29";
            this.layoutControlItem29.Size = new System.Drawing.Size(213, 24);
            this.layoutControlItem29.Text = "Usuario";
            this.layoutControlItem29.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem29.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem29.TextSize = new System.Drawing.Size(36, 13);
            this.layoutControlItem29.TextToControlDistance = 5;
            // 
            // LayoytFechaPago
            // 
            this.LayoytFechaPago.Control = this.txtFechaPago;
            this.LayoytFechaPago.CustomizationFormText = "Fecha Validación Pago";
            this.LayoytFechaPago.Location = new System.Drawing.Point(0, 24);
            this.LayoytFechaPago.Name = "LayoytFechaPago";
            this.LayoytFechaPago.Size = new System.Drawing.Size(352, 24);
            this.LayoytFechaPago.Text = "Fecha  Pago";
            this.LayoytFechaPago.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.LayoytFechaPago.TextSize = new System.Drawing.Size(59, 13);
            this.LayoytFechaPago.TextToControlDistance = 5;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8";
            this.emptySpaceItem8.Location = new System.Drawing.Point(576, 0);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(401, 72);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.CustomizationFormText = "emptySpaceItem9";
            this.emptySpaceItem9.Location = new System.Drawing.Point(352, 0);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(11, 72);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.txtFechaCierre;
            this.layoutControlItem31.CustomizationFormText = "Fecha Cierre";
            this.layoutControlItem31.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem31.Name = "layoutControlItem31";
            this.layoutControlItem31.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem31.Text = "Fecha Cierre";
            this.layoutControlItem31.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem31.TextSize = new System.Drawing.Size(61, 13);
            this.layoutControlItem31.TextToControlDistance = 5;
            // 
            // layoutControlItem32
            // 
            this.layoutControlItem32.Control = this.txtUsuaCierre;
            this.layoutControlItem32.CustomizationFormText = "Usuario";
            this.layoutControlItem32.Location = new System.Drawing.Point(363, 48);
            this.layoutControlItem32.Name = "layoutControlItem32";
            this.layoutControlItem32.Size = new System.Drawing.Size(213, 24);
            this.layoutControlItem32.Text = "Usuario";
            this.layoutControlItem32.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem32.TextSize = new System.Drawing.Size(36, 13);
            this.layoutControlItem32.TextToControlDistance = 5;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(363, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(213, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem43
            // 
            this.layoutControlItem43.Control = this.txtEstatusGral;
            this.layoutControlItem43.CustomizationFormText = "layoutControlItem43";
            this.layoutControlItem43.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem43.Name = "layoutControlItem43";
            this.layoutControlItem43.Size = new System.Drawing.Size(213, 24);
            this.layoutControlItem43.Text = "Estatus";
            this.layoutControlItem43.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem43.TextSize = new System.Drawing.Size(36, 13);
            this.layoutControlItem43.TextToControlDistance = 5;
            // 
            // emptySpaceItem16
            // 
            this.emptySpaceItem16.AllowHotTrack = false;
            this.emptySpaceItem16.CustomizationFormText = "emptySpaceItem16";
            this.emptySpaceItem16.Location = new System.Drawing.Point(213, 0);
            this.emptySpaceItem16.Name = "emptySpaceItem16";
            this.emptySpaceItem16.Size = new System.Drawing.Size(788, 24);
            this.emptySpaceItem16.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 344);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1001, 194);
            this.layoutControlGroup2.Text = "Nómina";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(977, 152);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // DetallesNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 600);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DetallesNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Nómina";
            this.Load += new System.EventHandler(this.DetallesNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodicidadPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecPeriFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngBruto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngNeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresaGral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaCreacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuaCreacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuaCierre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaCierre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstatusGral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFecPeriIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEmpleados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoytFechaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.TextEdit txtFecPeriFin;
        private DevExpress.XtraEditors.TextEdit txtIngBruto;
        private DevExpress.XtraEditors.TextEdit txtISR;
        private DevExpress.XtraEditors.TextEdit txtIngNeto;
        private DevExpress.XtraEditors.TextEdit txtEmpresaGral;
        private DevExpress.XtraEditors.TextEdit txtRFC;
        private DevExpress.XtraEditors.TextEdit txtFechaCreacion;
        private DevExpress.XtraEditors.TextEdit txtUsuaCreacion;
        private DevExpress.XtraEditors.TextEdit txtUsuaCierre;
        private DevExpress.XtraEditors.TextEdit txtFechaPago;
        private DevExpress.XtraEditors.TextEdit txtFechaCierre;
        private DevExpress.XtraEditors.TextEdit txtEstatusGral;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup11;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem34;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem35;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem38;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem39;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem40;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem36;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem37;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem17;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem32;
        private DevExpress.XtraLayout.LayoutControlItem LayoytFechaPago;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem43;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem16;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.TextEdit txtFecPeriIni;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtTotalEmpleados;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource nominaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnominanumEmpl;
        private DevExpress.XtraGrid.Columns.GridColumn colnominanombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colnominaRFCEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colnominaPeriodidicadPago;
        private DevExpress.XtraGrid.Columns.GridColumn colnominaIngresos;
        private DevExpress.XtraGrid.Columns.GridColumn colnominaIngresosNeto;
        private DevExpress.XtraGrid.Columns.GridColumn colnominaISR;
        private DevExpress.XtraGrid.Columns.GridColumn colnominaEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colnominaEstatusSAT;
        private DevExpress.XtraGrid.Columns.GridColumn colnominaDescripciponError;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource periodicidadPagoBindingSource;
    }
}