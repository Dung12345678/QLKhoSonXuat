
namespace BMS
{
	partial class frmMotorHistoryImEx
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbExport = new System.Windows.Forms.RadioButton();
			this.rbImport = new System.Windows.Forms.RadioButton();
			this.rbAll = new System.Windows.Forms.RadioButton();
			this.btnSearchHistory = new DevExpress.XtraEditors.SimpleButton();
			this.txbSearchHistory = new System.Windows.Forms.TextBox();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtgvMotorHistory = new DevExpress.XtraGrid.GridControl();
			this.gvMotor = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDateImEx = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWorkerCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPositionCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPositionID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMotorHistory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMotor)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rbExport);
			this.panel2.Controls.Add(this.rbImport);
			this.panel2.Controls.Add(this.rbAll);
			this.panel2.Controls.Add(this.btnSearchHistory);
			this.panel2.Controls.Add(this.txbSearchHistory);
			this.panel2.Controls.Add(this.dtpFrom);
			this.panel2.Controls.Add(this.dtpTo);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(1, 3);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1323, 52);
			this.panel2.TabIndex = 5;
			// 
			// rbExport
			// 
			this.rbExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbExport.AutoSize = true;
			this.rbExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
			this.rbExport.Location = new System.Drawing.Point(1192, 12);
			this.rbExport.Name = "rbExport";
			this.rbExport.Size = new System.Drawing.Size(70, 28);
			this.rbExport.TabIndex = 40;
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
			this.rbImport.TabIndex = 39;
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
			this.rbAll.TabIndex = 38;
			this.rbAll.TabStop = true;
			this.rbAll.Text = "Toàn bộ";
			this.rbAll.UseVisualStyleBackColor = true;
			this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
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
			// dtpTo
			// 
			this.dtpTo.CustomFormat = "dd/MM/yyyy";
			this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTo.Location = new System.Drawing.Point(365, 12);
			this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(131, 28);
			this.dtpTo.TabIndex = 37;
			this.dtpTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFrom_KeyPress);
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
			// dtgvMotorHistory
			// 
			this.dtgvMotorHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvMotorHistory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvMotorHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvMotorHistory.Location = new System.Drawing.Point(1, 55);
			this.dtgvMotorHistory.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
			this.dtgvMotorHistory.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
			this.dtgvMotorHistory.LookAndFeel.UseDefaultLookAndFeel = false;
			this.dtgvMotorHistory.MainView = this.gvMotor;
			this.dtgvMotorHistory.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvMotorHistory.Name = "dtgvMotorHistory";
			this.dtgvMotorHistory.Size = new System.Drawing.Size(1323, 639);
			this.dtgvMotorHistory.TabIndex = 30;
			this.dtgvMotorHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMotor});
			// 
			// gvMotor
			// 
			this.gvMotor.ColumnPanelRowHeight = 40;
			this.gvMotor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSTT,
            this.colPartID,
            this.colPartCode,
            this.colDateImEx,
            this.colWorkerCode,
            this.colStatus,
            this.colQuantity,
            this.colPositionCode,
            this.colPositionID});
			this.gvMotor.GridControl = this.dtgvMotorHistory;
			this.gvMotor.Name = "gvMotor";
			this.gvMotor.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMotor.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMotor.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvMotor.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvMotor.OptionsBehavior.Editable = false;
			this.gvMotor.OptionsCustomization.AllowColumnMoving = false;
			this.gvMotor.OptionsCustomization.AllowQuickHideColumns = false;
			this.gvMotor.OptionsFind.AlwaysVisible = true;
			this.gvMotor.OptionsFind.ShowCloseButton = false;
			this.gvMotor.OptionsView.ShowGroupPanel = false;
			this.gvMotor.PaintStyleName = "Web";
			this.gvMotor.RowHeight = 25;
			this.gvMotor.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colSTT
			// 
			this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colSTT.AppearanceCell.Options.UseFont = true;
			this.colSTT.AppearanceCell.Options.UseTextOptions = true;
			this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colSTT.AppearanceHeader.Options.UseBackColor = true;
			this.colSTT.AppearanceHeader.Options.UseFont = true;
			this.colSTT.AppearanceHeader.Options.UseForeColor = true;
			this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
			this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.Caption = "STT";
			this.colSTT.FieldName = "STT";
			this.colSTT.Name = "colSTT";
			this.colSTT.Visible = true;
			this.colSTT.VisibleIndex = 0;
			this.colSTT.Width = 67;
			// 
			// colPartID
			// 
			this.colPartID.Caption = "gridColumn1";
			this.colPartID.FieldName = "PartID";
			this.colPartID.Name = "colPartID";
			// 
			// colPartCode
			// 
			this.colPartCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colPartCode.AppearanceCell.Options.UseFont = true;
			this.colPartCode.AppearanceCell.Options.UseTextOptions = true;
			this.colPartCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPartCode.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colPartCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colPartCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colPartCode.AppearanceHeader.Options.UseBackColor = true;
			this.colPartCode.AppearanceHeader.Options.UseFont = true;
			this.colPartCode.AppearanceHeader.Options.UseForeColor = true;
			this.colPartCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colPartCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPartCode.Caption = "Mã linh kiện";
			this.colPartCode.FieldName = "PartCode";
			this.colPartCode.Name = "colPartCode";
			this.colPartCode.OptionsColumn.AllowEdit = false;
			this.colPartCode.Visible = true;
			this.colPartCode.VisibleIndex = 1;
			this.colPartCode.Width = 138;
			// 
			// colDateImEx
			// 
			this.colDateImEx.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDateImEx.AppearanceCell.Options.UseFont = true;
			this.colDateImEx.AppearanceCell.Options.UseTextOptions = true;
			this.colDateImEx.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDateImEx.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDateImEx.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colDateImEx.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colDateImEx.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colDateImEx.AppearanceHeader.Options.UseBackColor = true;
			this.colDateImEx.AppearanceHeader.Options.UseFont = true;
			this.colDateImEx.AppearanceHeader.Options.UseForeColor = true;
			this.colDateImEx.AppearanceHeader.Options.UseTextOptions = true;
			this.colDateImEx.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDateImEx.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDateImEx.Caption = "Thời gian";
			this.colDateImEx.FieldName = "DateImEx";
			this.colDateImEx.Name = "colDateImEx";
			this.colDateImEx.OptionsColumn.AllowEdit = false;
			this.colDateImEx.Visible = true;
			this.colDateImEx.VisibleIndex = 2;
			this.colDateImEx.Width = 133;
			// 
			// colWorkerCode
			// 
			this.colWorkerCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colWorkerCode.AppearanceCell.Options.UseFont = true;
			this.colWorkerCode.AppearanceCell.Options.UseTextOptions = true;
			this.colWorkerCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWorkerCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colWorkerCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colWorkerCode.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colWorkerCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colWorkerCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colWorkerCode.AppearanceHeader.Options.UseBackColor = true;
			this.colWorkerCode.AppearanceHeader.Options.UseFont = true;
			this.colWorkerCode.AppearanceHeader.Options.UseForeColor = true;
			this.colWorkerCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colWorkerCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWorkerCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colWorkerCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colWorkerCode.Caption = "Nhân viên";
			this.colWorkerCode.FieldName = "WorkerCode";
			this.colWorkerCode.Name = "colWorkerCode";
			this.colWorkerCode.OptionsColumn.AllowEdit = false;
			this.colWorkerCode.Visible = true;
			this.colWorkerCode.VisibleIndex = 6;
			this.colWorkerCode.Width = 78;
			// 
			// colStatus
			// 
			this.colStatus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colStatus.AppearanceCell.Options.UseFont = true;
			this.colStatus.AppearanceCell.Options.UseTextOptions = true;
			this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colStatus.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colStatus.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colStatus.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colStatus.AppearanceHeader.Options.UseBackColor = true;
			this.colStatus.AppearanceHeader.Options.UseFont = true;
			this.colStatus.AppearanceHeader.Options.UseForeColor = true;
			this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
			this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colStatus.Caption = "Trạng thái";
			this.colStatus.FieldName = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.OptionsColumn.AllowEdit = false;
			this.colStatus.Visible = true;
			this.colStatus.VisibleIndex = 5;
			this.colStatus.Width = 83;
			// 
			// colPositionCode
			// 
			this.colPositionCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colPositionCode.AppearanceCell.Options.UseFont = true;
			this.colPositionCode.AppearanceCell.Options.UseTextOptions = true;
			this.colPositionCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPositionCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPositionCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPositionCode.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colPositionCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colPositionCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colPositionCode.AppearanceHeader.Options.UseBackColor = true;
			this.colPositionCode.AppearanceHeader.Options.UseFont = true;
			this.colPositionCode.AppearanceHeader.Options.UseForeColor = true;
			this.colPositionCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colPositionCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPositionCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPositionCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPositionCode.Caption = "Vị trí";
			this.colPositionCode.FieldName = "PositionCode";
			this.colPositionCode.Name = "colPositionCode";
			this.colPositionCode.Visible = true;
			this.colPositionCode.VisibleIndex = 3;
			this.colPositionCode.Width = 137;
			// 
			// colPositionID
			// 
			this.colPositionID.Caption = "gridColumn1";
			this.colPositionID.FieldName = "PositionID";
			this.colPositionID.Name = "colPositionID";
			// 
			// colQuantity
			// 
			this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colQuantity.AppearanceCell.Options.UseFont = true;
			this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
			this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantity.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colQuantity.AppearanceHeader.Options.UseBackColor = true;
			this.colQuantity.AppearanceHeader.Options.UseFont = true;
			this.colQuantity.AppearanceHeader.Options.UseForeColor = true;
			this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
			this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantity.Caption = "Số lượng";
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 4;
			this.colQuantity.Width = 63;
			// 
			// frmMotorHistoryImEx
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1325, 703);
			this.Controls.Add(this.dtgvMotorHistory);
			this.Controls.Add(this.panel2);
			this.Name = "frmMotorHistoryImEx";
			this.Text = "LỊCH SỬ NHẬP XUẤT";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMotorHistoryImEx_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMotorHistory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMotor)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbExport;
		private System.Windows.Forms.RadioButton rbImport;
		private System.Windows.Forms.RadioButton rbAll;
		private DevExpress.XtraEditors.SimpleButton btnSearchHistory;
		private System.Windows.Forms.TextBox txbSearchHistory;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraGrid.GridControl dtgvMotorHistory;
		private DevExpress.XtraGrid.Views.Grid.GridView gvMotor;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colPartID;
		private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
		private DevExpress.XtraGrid.Columns.GridColumn colDateImEx;
		private DevExpress.XtraGrid.Columns.GridColumn colWorkerCode;
		private DevExpress.XtraGrid.Columns.GridColumn colStatus;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
		private DevExpress.XtraGrid.Columns.GridColumn colPositionCode;
		private DevExpress.XtraGrid.Columns.GridColumn colPositionID;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
	}
}