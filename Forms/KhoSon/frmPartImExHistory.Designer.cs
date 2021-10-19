
namespace BMS
{
    partial class frmPartImExHistory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartImExHistory));
			this.dtgvHistory = new DevExpress.XtraGrid.GridControl();
			this.gvHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDateImEx = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWorkerCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHour = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMonth = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnSearchHistory = new DevExpress.XtraEditors.SimpleButton();
			this.txbSearchHistory = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbExport = new System.Windows.Forms.RadioButton();
			this.rbImport = new System.Windows.Forms.RadioButton();
			this.rbAll = new System.Windows.Forms.RadioButton();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnEditPart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelPart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvHistory)).BeginInit();
			this.panel2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtgvHistory
			// 
			this.dtgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvHistory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvHistory.Location = new System.Drawing.Point(0, 55);
			this.dtgvHistory.MainView = this.gvHistory;
			this.dtgvHistory.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvHistory.Name = "dtgvHistory";
			this.dtgvHistory.Size = new System.Drawing.Size(1323, 648);
			this.dtgvHistory.TabIndex = 29;
			this.dtgvHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHistory});
			// 
			// gvHistory
			// 
			this.gvHistory.ColumnPanelRowHeight = 40;
			this.gvHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPartID,
            this.colType,
            this.colStatus,
            this.colPartCode,
            this.colProductCode,
            this.colQuantity,
            this.colDateImEx,
            this.colOrderCode,
            this.colWorkerCode,
            this.colHour,
            this.colMonth});
			this.gvHistory.GridControl = this.dtgvHistory;
			this.gvHistory.Name = "gvHistory";
			this.gvHistory.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvHistory.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvHistory.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvHistory.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvHistory.OptionsBehavior.Editable = false;
			this.gvHistory.OptionsView.ShowGroupPanel = false;
			this.gvHistory.PaintStyleName = "Flat";
			this.gvHistory.RowHeight = 25;
			// 
			// colID
			// 
			this.colID.AppearanceCell.Options.UseTextOptions = true;
			this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colPartID
			// 
			this.colPartID.AppearanceCell.Options.UseTextOptions = true;
			this.colPartID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartID.FieldName = "PartID";
			this.colPartID.Name = "colPartID";
			// 
			// colType
			// 
			this.colType.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colType.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colType.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colType.AppearanceCell.Options.UseBackColor = true;
			this.colType.AppearanceCell.Options.UseFont = true;
			this.colType.AppearanceCell.Options.UseTextOptions = true;
			this.colType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colType.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colType.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colType.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colType.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colType.AppearanceHeader.Options.UseBackColor = true;
			this.colType.AppearanceHeader.Options.UseBorderColor = true;
			this.colType.AppearanceHeader.Options.UseFont = true;
			this.colType.AppearanceHeader.Options.UseForeColor = true;
			this.colType.AppearanceHeader.Options.UseTextOptions = true;
			this.colType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colType.Caption = "Mục đích";
			this.colType.FieldName = "Type";
			this.colType.Name = "colType";
			this.colType.OptionsColumn.AllowEdit = false;
			this.colType.Visible = true;
			this.colType.VisibleIndex = 2;
			// 
			// colStatus
			// 
			this.colStatus.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colStatus.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colStatus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colStatus.AppearanceCell.Options.UseBackColor = true;
			this.colStatus.AppearanceCell.Options.UseFont = true;
			this.colStatus.AppearanceCell.Options.UseTextOptions = true;
			this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStatus.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colStatus.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colStatus.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colStatus.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colStatus.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colStatus.AppearanceHeader.Options.UseBackColor = true;
			this.colStatus.AppearanceHeader.Options.UseBorderColor = true;
			this.colStatus.AppearanceHeader.Options.UseFont = true;
			this.colStatus.AppearanceHeader.Options.UseForeColor = true;
			this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
			this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStatus.Caption = "Nhập/Xuất";
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.OptionsColumn.AllowEdit = false;
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 3;
			// 
			// colPartCode
			// 
			this.colPartCode.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colPartCode.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colPartCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colPartCode.AppearanceCell.Options.UseBackColor = true;
			this.colPartCode.AppearanceCell.Options.UseFont = true;
			this.colPartCode.AppearanceCell.Options.UseTextOptions = true;
			this.colPartCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartCode.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colPartCode.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colPartCode.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colPartCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colPartCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colPartCode.AppearanceHeader.Options.UseBackColor = true;
			this.colPartCode.AppearanceHeader.Options.UseBorderColor = true;
			this.colPartCode.AppearanceHeader.Options.UseFont = true;
			this.colPartCode.AppearanceHeader.Options.UseForeColor = true;
			this.colPartCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colPartCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartCode.Caption = "Mã linh kiện";
			this.colPartCode.FieldName = "PartCode";
			this.colPartCode.Name = "colPartCode";
			this.colPartCode.OptionsColumn.AllowEdit = false;
			this.colPartCode.Visible = true;
			this.colPartCode.VisibleIndex = 0;
			// 
			// colProductCode
			// 
			this.colProductCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colProductCode.AppearanceCell.Options.UseFont = true;
			this.colProductCode.AppearanceCell.Options.UseTextOptions = true;
			this.colProductCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductCode.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colProductCode.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colProductCode.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colProductCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colProductCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colProductCode.AppearanceHeader.Options.UseBackColor = true;
			this.colProductCode.AppearanceHeader.Options.UseBorderColor = true;
			this.colProductCode.AppearanceHeader.Options.UseFont = true;
			this.colProductCode.AppearanceHeader.Options.UseForeColor = true;
			this.colProductCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colProductCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductCode.Caption = "PID";
			this.colProductCode.FieldName = "ProductCode";
			this.colProductCode.Name = "colProductCode";
			this.colProductCode.OptionsColumn.AllowEdit = false;
			this.colProductCode.Visible = true;
			this.colProductCode.VisibleIndex = 5;
			// 
			// colQuantity
			// 
			this.colQuantity.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colQuantity.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colQuantity.AppearanceCell.Options.UseBackColor = true;
			this.colQuantity.AppearanceCell.Options.UseFont = true;
			this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
			this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantity.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colQuantity.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colQuantity.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colQuantity.AppearanceHeader.Options.UseBackColor = true;
			this.colQuantity.AppearanceHeader.Options.UseBorderColor = true;
			this.colQuantity.AppearanceHeader.Options.UseFont = true;
			this.colQuantity.AppearanceHeader.Options.UseForeColor = true;
			this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
			this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.Caption = "Số lượng";
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.OptionsColumn.AllowEdit = false;
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 1;
			// 
			// colDateImEx
			// 
			this.colDateImEx.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDateImEx.AppearanceCell.Options.UseFont = true;
			this.colDateImEx.AppearanceCell.Options.UseTextOptions = true;
			this.colDateImEx.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDateImEx.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDateImEx.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colDateImEx.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colDateImEx.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colDateImEx.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colDateImEx.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colDateImEx.AppearanceHeader.Options.UseBackColor = true;
			this.colDateImEx.AppearanceHeader.Options.UseBorderColor = true;
			this.colDateImEx.AppearanceHeader.Options.UseFont = true;
			this.colDateImEx.AppearanceHeader.Options.UseForeColor = true;
			this.colDateImEx.AppearanceHeader.Options.UseTextOptions = true;
			this.colDateImEx.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDateImEx.Caption = "Thời gian";
			this.colDateImEx.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm";
			this.colDateImEx.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colDateImEx.FieldName = "DateImEx";
			this.colDateImEx.GroupFormat.FormatString = "d";
			this.colDateImEx.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colDateImEx.Name = "colDateImEx";
			this.colDateImEx.OptionsColumn.AllowEdit = false;
			this.colDateImEx.Visible = true;
			this.colDateImEx.VisibleIndex = 6;
			// 
			// colOrderCode
			// 
			this.colOrderCode.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colOrderCode.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colOrderCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colOrderCode.AppearanceCell.Options.UseBackColor = true;
			this.colOrderCode.AppearanceCell.Options.UseFont = true;
			this.colOrderCode.AppearanceCell.Options.UseTextOptions = true;
			this.colOrderCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOrderCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOrderCode.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colOrderCode.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colOrderCode.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colOrderCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colOrderCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colOrderCode.AppearanceHeader.Options.UseBackColor = true;
			this.colOrderCode.AppearanceHeader.Options.UseBorderColor = true;
			this.colOrderCode.AppearanceHeader.Options.UseFont = true;
			this.colOrderCode.AppearanceHeader.Options.UseForeColor = true;
			this.colOrderCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colOrderCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOrderCode.Caption = "Order";
			this.colOrderCode.FieldName = "OrderCode";
			this.colOrderCode.Name = "colOrderCode";
			this.colOrderCode.OptionsColumn.AllowEdit = false;
			this.colOrderCode.Visible = true;
			this.colOrderCode.VisibleIndex = 4;
			// 
			// colWorkerCode
			// 
			this.colWorkerCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colWorkerCode.AppearanceCell.Options.UseFont = true;
			this.colWorkerCode.AppearanceCell.Options.UseTextOptions = true;
			this.colWorkerCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWorkerCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colWorkerCode.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colWorkerCode.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colWorkerCode.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colWorkerCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colWorkerCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colWorkerCode.AppearanceHeader.Options.UseBackColor = true;
			this.colWorkerCode.AppearanceHeader.Options.UseBorderColor = true;
			this.colWorkerCode.AppearanceHeader.Options.UseFont = true;
			this.colWorkerCode.AppearanceHeader.Options.UseForeColor = true;
			this.colWorkerCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colWorkerCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWorkerCode.Caption = "Nhân viên";
			this.colWorkerCode.FieldName = "WorkerCode";
			this.colWorkerCode.Name = "colWorkerCode";
			this.colWorkerCode.Visible = true;
			this.colWorkerCode.VisibleIndex = 7;
			// 
			// colHour
			// 
			this.colHour.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colHour.AppearanceCell.Options.UseFont = true;
			this.colHour.AppearanceCell.Options.UseTextOptions = true;
			this.colHour.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colHour.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colHour.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colHour.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colHour.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colHour.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colHour.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colHour.AppearanceHeader.Options.UseBackColor = true;
			this.colHour.AppearanceHeader.Options.UseBorderColor = true;
			this.colHour.AppearanceHeader.Options.UseFont = true;
			this.colHour.AppearanceHeader.Options.UseForeColor = true;
			this.colHour.AppearanceHeader.Options.UseTextOptions = true;
			this.colHour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colHour.Caption = "Khung giờ";
			this.colHour.FieldName = "Hour";
			this.colHour.Name = "colHour";
			// 
			// colMonth
			// 
			this.colMonth.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colMonth.AppearanceCell.Options.UseFont = true;
			this.colMonth.AppearanceCell.Options.UseTextOptions = true;
			this.colMonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMonth.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colMonth.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colMonth.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colMonth.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colMonth.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colMonth.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colMonth.AppearanceHeader.Options.UseBackColor = true;
			this.colMonth.AppearanceHeader.Options.UseBorderColor = true;
			this.colMonth.AppearanceHeader.Options.UseFont = true;
			this.colMonth.AppearanceHeader.Options.UseForeColor = true;
			this.colMonth.AppearanceHeader.Options.UseTextOptions = true;
			this.colMonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMonth.Caption = "Tháng";
			this.colMonth.FieldName = "Month";
			this.colMonth.Name = "colMonth";
			// 
			// btnSearchHistory
			// 
			this.btnSearchHistory.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchHistory.Appearance.Options.UseFont = true;
			this.btnSearchHistory.Location = new System.Drawing.Point(729, 12);
			this.btnSearchHistory.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearchHistory.Name = "btnSearchHistory";
			this.btnSearchHistory.Size = new System.Drawing.Size(100, 28);
			this.btnSearchHistory.TabIndex = 25;
			this.btnSearchHistory.Text = "Tìm kiếm";
			this.btnSearchHistory.Click += new System.EventHandler(this.btnSearchHistory_Click);
			// 
			// txbSearchHistory
			// 
			this.txbSearchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbSearchHistory.Location = new System.Drawing.Point(525, 12);
			this.txbSearchHistory.Margin = new System.Windows.Forms.Padding(4);
			this.txbSearchHistory.Name = "txbSearchHistory";
			this.txbSearchHistory.Size = new System.Drawing.Size(195, 28);
			this.txbSearchHistory.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 14);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 24);
			this.label3.TabIndex = 33;
			this.label3.Text = "Từ ngày: ";
			// 
			// dtpFrom
			// 
			this.dtpFrom.CustomFormat = "dd/MM/yyyy";
			this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFrom.Location = new System.Drawing.Point(99, 12);
			this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(140, 28);
			this.dtpFrom.TabIndex = 36;
			this.dtpFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFrom_KeyPress);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.rbExport);
			this.panel2.Controls.Add(this.rbImport);
			this.panel2.Controls.Add(this.rbAll);
			this.panel2.Controls.Add(this.btnSearchHistory);
			this.panel2.Controls.Add(this.txbSearchHistory);
			this.panel2.Controls.Add(this.dtpFrom);
			this.panel2.Controls.Add(this.dtpTo);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(0, 1);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1323, 52);
			this.panel2.TabIndex = 4;
			// 
			// rbExport
			// 
			this.rbExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbExport.AutoSize = true;
			this.rbExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
			this.rbExport.Location = new System.Drawing.Point(1192, 12);
			this.rbExport.Name = "rbExport";
			this.rbExport.Size = new System.Drawing.Size(70, 28);
			this.rbExport.TabIndex = 39;
			this.rbExport.Text = "Xuất";
			this.rbExport.UseVisualStyleBackColor = true;
			this.rbExport.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
			// 
			// rbImport
			// 
			this.rbImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbImport.AutoSize = true;
			this.rbImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
			this.rbImport.Location = new System.Drawing.Point(1045, 12);
			this.rbImport.Name = "rbImport";
			this.rbImport.Size = new System.Drawing.Size(82, 28);
			this.rbImport.TabIndex = 38;
			this.rbImport.Text = "Nhập ";
			this.rbImport.UseVisualStyleBackColor = true;
			this.rbImport.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
			// 
			// rbAll
			// 
			this.rbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbAll.AutoSize = true;
			this.rbAll.Checked = true;
			this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
			this.rbAll.Location = new System.Drawing.Point(892, 12);
			this.rbAll.Name = "rbAll";
			this.rbAll.Size = new System.Drawing.Size(102, 28);
			this.rbAll.TabIndex = 37;
			this.rbAll.TabStop = true;
			this.rbAll.Text = "Toàn bộ";
			this.rbAll.UseVisualStyleBackColor = true;
			this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
			// 
			// dtpTo
			// 
			this.dtpTo.CustomFormat = "dd/MM/yyyy";
			this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTo.Location = new System.Drawing.Point(365, 12);
			this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(131, 28);
			this.dtpTo.TabIndex = 35;
			this.dtpTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpTo_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(273, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 24);
			this.label1.TabIndex = 34;
			this.label1.Text = "Đến ngày: ";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditPart,
            this.toolStripSeparator7,
            this.btnDelPart,
            this.toolStripSeparator8});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 50);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1326, 48);
			this.toolStrip1.TabIndex = 30;
			this.toolStrip1.Text = "toolStrip2";
			this.toolStrip1.Visible = false;
			// 
			// btnEditPart
			// 
			this.btnEditPart.Enabled = false;
			this.btnEditPart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditPart.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPart.Image")));
			this.btnEditPart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditPart.Name = "btnEditPart";
			this.btnEditPart.Size = new System.Drawing.Size(86, 41);
			this.btnEditPart.Tag = "frmProduct_EditProductH";
			this.btnEditPart.Text = "Sửa lịch sử";
			this.btnEditPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEditPart.Click += new System.EventHandler(this.btnEditPart_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDelPart
			// 
			this.btnDelPart.Enabled = false;
			this.btnDelPart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelPart.Image = ((System.Drawing.Image)(resources.GetObject("btnDelPart.Image")));
			this.btnDelPart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelPart.Name = "btnDelPart";
			this.btnDelPart.Size = new System.Drawing.Size(86, 41);
			this.btnDelPart.Tag = "frmProduct_DeleteProductH";
			this.btnDelPart.Text = "Xóa lịch sử";
			this.btnDelPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.AutoSize = false;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 40);
			// 
			// frmPartImExHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1325, 703);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dtgvHistory);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmPartImExHistory";
			this.Text = "LỊCH SỬ NHẬP XUẤT";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmPartImExHistory_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvHistory)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dtgvHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHistory;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.SimpleButton btnSearchHistory;
        private System.Windows.Forms.TextBox txbSearchHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colPartID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDateImEx;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEditPart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnDelPart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colHour;
        private DevExpress.XtraGrid.Columns.GridColumn colMonth;
		private System.Windows.Forms.RadioButton rbExport;
		private System.Windows.Forms.RadioButton rbImport;
		private System.Windows.Forms.RadioButton rbAll;
	}
}