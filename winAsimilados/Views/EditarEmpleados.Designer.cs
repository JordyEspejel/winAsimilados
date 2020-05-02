namespace winAsimilados.Views
{
    partial class EditarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEmpleados));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.GridControlEmpl = new DevExpress.XtraGrid.GridControl();
            this.GridViewEmpl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAsimilados.Views.WaitForm1), true, true, true);
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.AutoScroll = true;
            this.sidePanel1.Controls.Add(this.GridControlEmpl);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(800, 450);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // GridControlEmpl
            // 
            this.GridControlEmpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlEmpl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.GridControlEmpl_EmbeddedNavigator_ButtonClick);
            this.GridControlEmpl.Location = new System.Drawing.Point(0, 0);
            this.GridControlEmpl.MainView = this.GridViewEmpl;
            this.GridControlEmpl.Name = "GridControlEmpl";
            this.GridControlEmpl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.GridControlEmpl.ShowOnlyPredefinedDetails = true;
            this.GridControlEmpl.Size = new System.Drawing.Size(800, 450);
            this.GridControlEmpl.TabIndex = 0;
            this.GridControlEmpl.UseEmbeddedNavigator = true;
            this.GridControlEmpl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewEmpl});
            // 
            // GridViewEmpl
            // 
            this.GridViewEmpl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.GridViewEmpl.GridControl = this.GridControlEmpl;
            this.GridViewEmpl.Name = "GridViewEmpl";
            this.GridViewEmpl.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.GridViewEmpl.OptionsFilter.ColumnFilterPopupRowCount = 10;
            this.GridViewEmpl.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.GridViewEmpl.OptionsFilter.UseNewCustomFilterDialog = true;
            this.GridViewEmpl.OptionsView.RowAutoHeight = true;
            this.GridViewEmpl.OptionsView.ShowAutoFilterRow = true;
            this.GridViewEmpl.OptionsView.ShowFooter = true;
            this.GridViewEmpl.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GridViewEmpl_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "idempleado";
            this.gridColumn1.FieldName = "idempleado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "# Empleado";
            this.gridColumn2.FieldName = "NUM_EMPLEADO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "NOMBRE";
            this.gridColumn3.FieldName = "NOMBRE";
            this.gridColumn3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "RFC";
            this.gridColumn4.FieldName = "RFC";
            this.gridColumn4.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "CURP";
            this.gridColumn5.FieldName = "CURP";
            this.gridColumn5.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "PERIODICIDAD";
            this.gridColumn6.FieldName = "PERIODICIDAD_PAGO";
            this.gridColumn6.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn6.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // EditarEmpleados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarEmpleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarEmpleados_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarEmpleados_FormClosed);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl GridControlEmpl;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewEmpl;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}