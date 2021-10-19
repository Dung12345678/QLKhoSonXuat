
namespace BMS
{
	partial class frmMotorPartList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotorPartList));
			this.tlStorageCode2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.btnCreatePart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEditPart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelPart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.btnImportPart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.btnImportEx = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this.btnHistory = new System.Windows.Forms.ToolStripButton();
			this.btnSonPlan = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExportPart = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.gvMotor = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dtgvMotorList = new DevExpress.XtraGrid.GridControl();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeData = new DevExpress.XtraTreeList.TreeList();
			this.colIDTree = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colDescriptionTree = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.colPositionCodeTree = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnAddPos = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEditPos = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelPos = new System.Windows.Forms.ToolStripButton();
			this.cbShowAll = new System.Windows.Forms.CheckBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnCancelSearch = new DevExpress.XtraEditors.SimpleButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvMotor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMotorList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
			this.toolStrip2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlStorageCode2
			// 
			this.tlStorageCode2.AppearanceHeader.BackColor = System.Drawing.Color.MediumPurple;
			this.tlStorageCode2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.tlStorageCode2.AppearanceHeader.Options.UseBackColor = true;
			this.tlStorageCode2.AppearanceHeader.Options.UseFont = true;
			this.tlStorageCode2.AppearanceHeader.Options.UseTextOptions = true;
			this.tlStorageCode2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.tlStorageCode2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.tlStorageCode2.Caption = "Mã kho";
			this.tlStorageCode2.FieldName = "StorageCode";
			this.tlStorageCode2.Name = "tlStorageCode2";
			this.tlStorageCode2.Visible = true;
			this.tlStorageCode2.VisibleIndex = 1;
			this.tlStorageCode2.Width = 366;
			// 
			// btnCreatePart
			// 
			this.btnCreatePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreatePart.ForeColor = System.Drawing.Color.Black;
			this.btnCreatePart.Image = ((System.Drawing.Image)(resources.GetObject("btnCreatePart.Image")));
			this.btnCreatePart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreatePart.Name = "btnCreatePart";
			this.btnCreatePart.Size = new System.Drawing.Size(106, 41);
			this.btnCreatePart.Tag = "frmProduct_AddProductH";
			this.btnCreatePart.Text = "Tạo linh kiện";
			this.btnCreatePart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCreatePart.Click += new System.EventHandler(this.btnCreatePart_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEditPart
			// 
			this.btnEditPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditPart.ForeColor = System.Drawing.Color.Black;
			this.btnEditPart.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPart.Image")));
			this.btnEditPart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditPart.Name = "btnEditPart";
			this.btnEditPart.Size = new System.Drawing.Size(106, 41);
			this.btnEditPart.Tag = "frmProduct_EditProductH";
			this.btnEditPart.Text = "Sửa linh kiện";
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
			this.btnDelPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelPart.ForeColor = System.Drawing.Color.Black;
			this.btnDelPart.Image = ((System.Drawing.Image)(resources.GetObject("btnDelPart.Image")));
			this.btnDelPart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelPart.Name = "btnDelPart";
			this.btnDelPart.Size = new System.Drawing.Size(106, 41);
			this.btnDelPart.Tag = "frmProduct_DeleteProductH";
			this.btnDelPart.Text = "Xóa linh kiện";
			this.btnDelPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelPart.Click += new System.EventHandler(this.btnDelPart_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.AutoSize = false;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 40);
			// 
			// btnImportPart
			// 
			this.btnImportPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportPart.ForeColor = System.Drawing.Color.Black;
			this.btnImportPart.Image = ((System.Drawing.Image)(resources.GetObject("btnImportPart.Image")));
			this.btnImportPart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImportPart.Name = "btnImportPart";
			this.btnImportPart.Size = new System.Drawing.Size(81, 41);
			this.btnImportPart.Tag = "frmProduct_GunH";
			this.btnImportPart.Text = "Nhập kho";
			this.btnImportPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnImportPart.Click += new System.EventHandler(this.btnImportPart_Click);
			// 
			// toolStripSeparator13
			// 
			this.toolStripSeparator13.AutoSize = false;
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new System.Drawing.Size(6, 40);
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
			this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
			this.btnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(88, 41);
			this.btnExportExcel.Tag = "";
			this.btnExportExcel.Text = "Xuất Excel";
			this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// toolStripSeparator11
			// 
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new System.Drawing.Size(6, 23);
			// 
			// btnImportEx
			// 
			this.btnImportEx.Enabled = false;
			this.btnImportEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportEx.ForeColor = System.Drawing.Color.Black;
			this.btnImportEx.Image = ((System.Drawing.Image)(resources.GetObject("btnImportEx.Image")));
			this.btnImportEx.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImportEx.Name = "btnImportEx";
			this.btnImportEx.Size = new System.Drawing.Size(93, 41);
			this.btnImportEx.Tag = "";
			this.btnImportEx.Text = "Nhập Excel";
			this.btnImportEx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnImportEx.Click += new System.EventHandler(this.btnImportEx_Click);
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.AutoSize = false;
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new System.Drawing.Size(6, 40);
			// 
			// btnHistory
			// 
			this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHistory.ForeColor = System.Drawing.Color.Black;
			this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
			this.btnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new System.Drawing.Size(95, 41);
			this.btnHistory.Tag = "frmProduct_UpdateCDH";
			this.btnHistory.Text = "Xem lịch sử";
			this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
			// 
			// btnSonPlan
			// 
			this.btnSonPlan.Enabled = false;
			this.btnSonPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSonPlan.ForeColor = System.Drawing.Color.Black;
			this.btnSonPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnSonPlan.Image")));
			this.btnSonPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSonPlan.Name = "btnSonPlan";
			this.btnSonPlan.Size = new System.Drawing.Size(114, 41);
			this.btnSonPlan.Tag = "frmProduct_UpdateCDH";
			this.btnSonPlan.Text = "Xem kế hoạch";
			this.btnSonPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSonPlan.Click += new System.EventHandler(this.btnSonPlan_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreatePart,
            this.toolStripSeparator1,
            this.btnEditPart,
            this.toolStripSeparator7,
            this.btnDelPart,
            this.toolStripSeparator8,
            this.btnImportPart,
            this.toolStripSeparator5,
            this.btnExportPart,
            this.toolStripSeparator13,
            this.btnExportExcel,
            this.toolStripSeparator11,
            this.btnImportEx,
            this.toolStripSeparator12,
            this.btnHistory,
            this.toolStripSeparator6,
            this.btnSonPlan,
            this.toolStripSeparator2,
            this.btnRefresh});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(970, 42);
			this.toolStrip1.TabIndex = 27;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
			// 
			// btnExportPart
			// 
			this.btnExportPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportPart.ForeColor = System.Drawing.Color.Black;
			this.btnExportPart.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPart.Image")));
			this.btnExportPart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExportPart.Name = "btnExportPart";
			this.btnExportPart.Size = new System.Drawing.Size(76, 41);
			this.btnExportPart.Tag = "frmProduct_GunH";
			this.btnExportPart.Text = "Xuất kho";
			this.btnExportPart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnExportPart.Click += new System.EventHandler(this.btnExportPart_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// btnRefresh
			// 
			this.btnRefresh.AutoSize = false;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(91, 44);
			this.btnRefresh.Tag = "";
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// gvMotor
			// 
			this.gvMotor.ColumnPanelRowHeight = 40;
			this.gvMotor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPartCode,
            this.colDescription,
            this.colQuantity,
            this.colSTT});
			this.gvMotor.GridControl = this.dtgvMotorList;
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
			this.gvMotor.RowHeight = 25;
			this.gvMotor.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			this.gvMotor.DoubleClick += new System.EventHandler(this.gvMotor_DoubleClick);
			// 
			// colID
			// 
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colPartCode
			// 
			this.colPartCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colPartCode.AppearanceCell.Options.UseFont = true;
			this.colPartCode.AppearanceCell.Options.UseTextOptions = true;
			this.colPartCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPartCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colPartCode.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
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
			this.colPartCode.Width = 366;
			// 
			// colDescription
			// 
			this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDescription.AppearanceCell.Options.UseFont = true;
			this.colDescription.AppearanceCell.Options.UseTextOptions = true;
			this.colDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colDescription.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colDescription.AppearanceHeader.Options.UseFont = true;
			this.colDescription.AppearanceHeader.Options.UseForeColor = true;
			this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
			this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDescription.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDescription.Caption = "Mô tả";
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.OptionsColumn.AllowEdit = false;
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 2;
			this.colDescription.Width = 338;
			// 
			// colQuantity
			// 
			this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colQuantity.AppearanceCell.Options.UseFont = true;
			this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
			this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantity.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colQuantity.AppearanceHeader.Options.UseFont = true;
			this.colQuantity.AppearanceHeader.Options.UseForeColor = true;
			this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
			this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantity.Caption = "Số lượng";
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.OptionsColumn.AllowEdit = false;
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 3;
			this.colQuantity.Width = 140;
			// 
			// colSTT
			// 
			this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colSTT.AppearanceCell.Options.UseFont = true;
			this.colSTT.AppearanceCell.Options.UseTextOptions = true;
			this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colSTT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
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
			this.colSTT.Width = 105;
			// 
			// dtgvMotorList
			// 
			this.dtgvMotorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvMotorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvMotorList.Location = new System.Drawing.Point(3, 45);
			this.dtgvMotorList.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
			this.dtgvMotorList.MainView = this.gvMotor;
			this.dtgvMotorList.Name = "dtgvMotorList";
			this.dtgvMotorList.Size = new System.Drawing.Size(735, 502);
			this.dtgvMotorList.TabIndex = 34;
			this.dtgvMotorList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMotor});
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Location = new System.Drawing.Point(0, 45);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.splitContainer1.Panel1.Controls.Add(this.treeData);
			this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
			this.splitContainer1.Panel1MinSize = 15;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.cbShowAll);
			this.splitContainer1.Panel2.Controls.Add(this.panel6);
			this.splitContainer1.Panel2.Controls.Add(this.dtgvMotorList);
			this.splitContainer1.Size = new System.Drawing.Size(970, 556);
			this.splitContainer1.SplitterDistance = 226;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 35;
			// 
			// treeData
			// 
			this.treeData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.FocusedRow.Options.UseBackColor = true;
			this.treeData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.treeData.Appearance.HideSelectionRow.Options.UseBackColor = true;
			this.treeData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
			this.treeData.ColumnPanelRowHeight = 30;
			this.treeData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIDTree,
            this.colDescriptionTree,
            this.colPositionCodeTree});
			this.treeData.Location = new System.Drawing.Point(3, 45);
			this.treeData.LookAndFeel.UseDefaultLookAndFeel = false;
			this.treeData.Name = "treeData";
			this.treeData.OptionsBehavior.AllowExpandOnDblClick = false;
			this.treeData.OptionsBehavior.Editable = false;
			this.treeData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit2});
			this.treeData.Size = new System.Drawing.Size(218, 502);
			this.treeData.TabIndex = 18;
			this.treeData.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeData_FocusedNodeChanged);
			this.treeData.DoubleClick += new System.EventHandler(this.treeData_DoubleClick);
			// 
			// colIDTree
			// 
			this.colIDTree.Caption = "Mã nhóm";
			this.colIDTree.FieldName = "ID";
			this.colIDTree.Name = "colIDTree";
			// 
			// colDescriptionTree
			// 
			this.colDescriptionTree.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDescriptionTree.AppearanceCell.Options.UseFont = true;
			this.colDescriptionTree.AppearanceCell.Options.UseTextOptions = true;
			this.colDescriptionTree.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDescriptionTree.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescriptionTree.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDescriptionTree.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colDescriptionTree.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colDescriptionTree.AppearanceHeader.Options.UseFont = true;
			this.colDescriptionTree.AppearanceHeader.Options.UseForeColor = true;
			this.colDescriptionTree.AppearanceHeader.Options.UseTextOptions = true;
			this.colDescriptionTree.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDescriptionTree.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescriptionTree.Caption = "Mô tả";
			this.colDescriptionTree.ColumnEdit = this.repositoryItemMemoEdit2;
			this.colDescriptionTree.FieldName = "Description";
			this.colDescriptionTree.Name = "colDescriptionTree";
			this.colDescriptionTree.OptionsColumn.AllowEdit = false;
			this.colDescriptionTree.OptionsColumn.AllowFocus = false;
			this.colDescriptionTree.Visible = true;
			this.colDescriptionTree.VisibleIndex = 1;
			this.colDescriptionTree.Width = 207;
			// 
			// repositoryItemMemoEdit2
			// 
			this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
			// 
			// colPositionCodeTree
			// 
			this.colPositionCodeTree.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colPositionCodeTree.AppearanceCell.Options.UseFont = true;
			this.colPositionCodeTree.AppearanceCell.Options.UseTextOptions = true;
			this.colPositionCodeTree.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPositionCodeTree.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPositionCodeTree.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colPositionCodeTree.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colPositionCodeTree.AppearanceHeader.Options.UseFont = true;
			this.colPositionCodeTree.AppearanceHeader.Options.UseForeColor = true;
			this.colPositionCodeTree.AppearanceHeader.Options.UseTextOptions = true;
			this.colPositionCodeTree.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPositionCodeTree.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPositionCodeTree.Caption = "Mã vị trí";
			this.colPositionCodeTree.FieldName = "PositionCode";
			this.colPositionCodeTree.Name = "colPositionCodeTree";
			this.colPositionCodeTree.OptionsColumn.AllowEdit = false;
			this.colPositionCodeTree.OptionsColumn.AllowFocus = false;
			this.colPositionCodeTree.Visible = true;
			this.colPositionCodeTree.VisibleIndex = 0;
			this.colPositionCodeTree.Width = 117;
			// 
			// toolStrip2
			// 
			this.toolStrip2.AutoSize = false;
			this.toolStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.toolStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPos,
            this.toolStripSeparator3,
            this.btnEditPos,
            this.toolStripSeparator4,
            this.btnDelPos});
			this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip2.Size = new System.Drawing.Size(224, 41);
			this.toolStrip2.TabIndex = 28;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btnAddPos
			// 
			this.btnAddPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddPos.ForeColor = System.Drawing.Color.Black;
			this.btnAddPos.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPos.Image")));
			this.btnAddPos.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAddPos.Name = "btnAddPos";
			this.btnAddPos.Size = new System.Drawing.Size(77, 41);
			this.btnAddPos.Tag = "frmProduct_AddProductH";
			this.btnAddPos.Text = "Tạo vị trí";
			this.btnAddPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnAddPos.Click += new System.EventHandler(this.btnAddPos_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEditPos
			// 
			this.btnEditPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditPos.ForeColor = System.Drawing.Color.Black;
			this.btnEditPos.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPos.Image")));
			this.btnEditPos.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditPos.Name = "btnEditPos";
			this.btnEditPos.Size = new System.Drawing.Size(77, 41);
			this.btnEditPos.Tag = "frmProduct_EditProductH";
			this.btnEditPos.Text = "Sửa vị trí";
			this.btnEditPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEditPos.Click += new System.EventHandler(this.btnEditPos_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDelPos
			// 
			this.btnDelPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelPos.ForeColor = System.Drawing.Color.Black;
			this.btnDelPos.Image = ((System.Drawing.Image)(resources.GetObject("btnDelPos.Image")));
			this.btnDelPos.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelPos.Name = "btnDelPos";
			this.btnDelPos.Size = new System.Drawing.Size(77, 41);
			this.btnDelPos.Tag = "frmProduct_DeleteProductH";
			this.btnDelPos.Text = "Xóa vị trí";
			this.btnDelPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelPos.Click += new System.EventHandler(this.btnDelPos_Click);
			// 
			// cbShowAll
			// 
			this.cbShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbShowAll.AutoSize = true;
			this.cbShowAll.Checked = true;
			this.cbShowAll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbShowAll.Location = new System.Drawing.Point(631, 14);
			this.cbShowAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbShowAll.Name = "cbShowAll";
			this.cbShowAll.Size = new System.Drawing.Size(100, 19);
			this.cbShowAll.TabIndex = 36;
			this.cbShowAll.Text = "Hiển thị tất cả";
			this.cbShowAll.UseVisualStyleBackColor = true;
			this.cbShowAll.CheckedChanged += new System.EventHandler(this.cbShowAll_CheckedChanged);
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.Controls.Add(this.btnCancelSearch);
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.txbSearch);
			this.panel6.Controls.Add(this.btnSearch);
			this.panel6.Location = new System.Drawing.Point(3, 6);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(619, 36);
			this.panel6.TabIndex = 35;
			// 
			// btnCancelSearch
			// 
			this.btnCancelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancelSearch.Location = new System.Drawing.Point(453, 6);
			this.btnCancelSearch.Name = "btnCancelSearch";
			this.btnCancelSearch.Size = new System.Drawing.Size(63, 20);
			this.btnCancelSearch.TabIndex = 28;
			this.btnCancelSearch.Text = "Hủy";
			this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 27;
			this.label1.Text = "Từ khóa";
			// 
			// txbSearch
			// 
			this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbSearch.Location = new System.Drawing.Point(73, 5);
			this.txbSearch.Name = "txbSearch";
			this.txbSearch.Size = new System.Drawing.Size(306, 24);
			this.txbSearch.TabIndex = 26;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSearch.Location = new System.Drawing.Point(384, 6);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(63, 20);
			this.btnSearch.TabIndex = 25;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
			// 
			// frmMotorPartList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(970, 602);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmMotorPartList";
			this.Text = "DANH SÁCH LINH KIỆN MOTOR";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMotorPartList_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvMotor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMotorList)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.treeData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraTreeList.Columns.TreeListColumn tlStorageCode2;
		private System.Windows.Forms.ToolStripButton btnCreatePart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnEditPart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton btnDelPart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton btnImportPart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
		private System.Windows.Forms.ToolStripButton btnExportExcel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
		private System.Windows.Forms.ToolStripButton btnImportEx;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		private System.Windows.Forms.ToolStripButton btnHistory;
		private System.Windows.Forms.ToolStripButton btnSonPlan;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private DevExpress.XtraGrid.Views.Grid.GridView gvMotor;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
		private DevExpress.XtraGrid.GridControl dtgvMotorList;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private DevExpress.XtraTreeList.TreeList treeData;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colIDTree;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colDescriptionTree;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colPositionCodeTree;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnAddPos;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnEditPos;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton btnDelPos;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbSearch;
		private DevExpress.XtraEditors.SimpleButton btnSearch;
		private DevExpress.XtraEditors.SimpleButton btnCancelSearch;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton btnExportPart;
		private System.Windows.Forms.CheckBox cbShowAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
	}
}