
namespace BMS
{
    partial class frmSonPlan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSonPlan));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCreatePlan = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEditPlan = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelPlan = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.btnImportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this.dtgvSonPlan = new DevExpress.XtraGrid.GridControl();
			this.gvSonPlan = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDateExported = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLotSize = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQtyPlan = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProdDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSaleCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipTo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipVia = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colConfirmCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWorkerCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrintedDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
			this.txbSearch = new System.Windows.Forms.TextBox();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvSonPlan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvSonPlan)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreatePlan,
            this.toolStripSeparator1,
            this.btnEditPlan,
            this.toolStripSeparator7,
            this.btnDelPlan,
            this.toolStripSeparator8,
            this.btnExportExcel,
            this.toolStripSeparator11,
            this.btnImportExcel,
            this.toolStripSeparator12});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1275, 59);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 27;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// btnCreatePlan
			// 
			this.btnCreatePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreatePlan.Image = ((System.Drawing.Image)(resources.GetObject("btnCreatePlan.Image")));
			this.btnCreatePlan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCreatePlan.Name = "btnCreatePlan";
			this.btnCreatePlan.Size = new System.Drawing.Size(142, 48);
			this.btnCreatePlan.Tag = "frmProduct_AddProductH";
			this.btnCreatePlan.Text = "Tạo kế hoạch";
			this.btnCreatePlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCreatePlan.Click += new System.EventHandler(this.btnCreatePlan_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEditPlan
			// 
			this.btnEditPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPlan.Image")));
			this.btnEditPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditPlan.Name = "btnEditPlan";
			this.btnEditPlan.Size = new System.Drawing.Size(142, 48);
			this.btnEditPlan.Tag = "frmProduct_EditProductH";
			this.btnEditPlan.Text = "Sửa kế hoạch";
			this.btnEditPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEditPlan.Click += new System.EventHandler(this.btnEditPlan_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDelPlan
			// 
			this.btnDelPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnDelPlan.Image")));
			this.btnDelPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelPlan.Name = "btnDelPlan";
			this.btnDelPlan.Size = new System.Drawing.Size(144, 48);
			this.btnDelPlan.Tag = "frmProduct_DeleteProductH";
			this.btnDelPlan.Text = "Xóa kế hoạch";
			this.btnDelPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelPlan.Click += new System.EventHandler(this.btnDelPlan_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.AutoSize = false;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 40);
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
			this.btnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(116, 48);
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
			// btnImportExcel
			// 
			this.btnImportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnImportExcel.Image")));
			this.btnImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImportExcel.Name = "btnImportExcel";
			this.btnImportExcel.Size = new System.Drawing.Size(123, 48);
			this.btnImportExcel.Tag = "";
			this.btnImportExcel.Text = "Nhập Excel";
			this.btnImportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.AutoSize = false;
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new System.Drawing.Size(6, 40);
			// 
			// dtgvSonPlan
			// 
			this.dtgvSonPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvSonPlan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
			this.dtgvSonPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvSonPlan.Location = new System.Drawing.Point(0, 98);
			this.dtgvSonPlan.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
			this.dtgvSonPlan.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
			this.dtgvSonPlan.LookAndFeel.UseDefaultLookAndFeel = false;
			this.dtgvSonPlan.MainView = this.gvSonPlan;
			this.dtgvSonPlan.Margin = new System.Windows.Forms.Padding(5);
			this.dtgvSonPlan.Name = "dtgvSonPlan";
			this.dtgvSonPlan.Size = new System.Drawing.Size(1275, 456);
			this.dtgvSonPlan.TabIndex = 29;
			this.dtgvSonPlan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSonPlan});
			// 
			// gvSonPlan
			// 
			this.gvSonPlan.ColumnPanelRowHeight = 60;
			this.gvSonPlan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colStt,
            this.colDateExported,
            this.colPartCode,
            this.colLotSize,
            this.colQtyPlan,
            this.colProdDate,
            this.colOK,
            this.colNG,
            this.colOrderCode,
            this.colSaleCode,
            this.colOP,
            this.colShipTo,
            this.colShipVia,
            this.colConfirmCode,
            this.colNote,
            this.colWorkerCode,
            this.colPrintedDate});
			this.gvSonPlan.GridControl = this.dtgvSonPlan;
			this.gvSonPlan.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
			this.gvSonPlan.Name = "gvSonPlan";
			this.gvSonPlan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvSonPlan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvSonPlan.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvSonPlan.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvSonPlan.OptionsBehavior.Editable = false;
			this.gvSonPlan.OptionsView.ColumnAutoWidth = false;
			this.gvSonPlan.OptionsView.ShowGroupPanel = false;
			this.gvSonPlan.PaintStyleName = "Flat";
			this.gvSonPlan.RowHeight = 25;
			this.gvSonPlan.DoubleClick += new System.EventHandler(this.gvSonPlan_DoubleClick);
			// 
			// colID
			// 
			this.colID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colID.AppearanceCell.Options.UseFont = true;
			this.colID.AppearanceCell.Options.UseTextOptions = true;
			this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colID.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colID.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colID.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colID.AppearanceHeader.Options.UseBackColor = true;
			this.colID.AppearanceHeader.Options.UseBorderColor = true;
			this.colID.AppearanceHeader.Options.UseFont = true;
			this.colID.AppearanceHeader.Options.UseForeColor = true;
			this.colID.AppearanceHeader.Options.UseTextOptions = true;
			this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.MinWidth = 25;
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			// 
			// colStt
			// 
			this.colStt.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colStt.AppearanceCell.Options.UseFont = true;
			this.colStt.AppearanceCell.Options.UseTextOptions = true;
			this.colStt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStt.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colStt.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colStt.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colStt.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colStt.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colStt.AppearanceHeader.Options.UseBackColor = true;
			this.colStt.AppearanceHeader.Options.UseBorderColor = true;
			this.colStt.AppearanceHeader.Options.UseFont = true;
			this.colStt.AppearanceHeader.Options.UseForeColor = true;
			this.colStt.AppearanceHeader.Options.UseTextOptions = true;
			this.colStt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colStt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colStt.Caption = "STT";
			this.colStt.FieldName = "STT";
			this.colStt.MinWidth = 25;
			this.colStt.Name = "colStt";
			this.colStt.Visible = true;
			this.colStt.VisibleIndex = 0;
			this.colStt.Width = 59;
			// 
			// colDateExported
			// 
			this.colDateExported.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colDateExported.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colDateExported.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDateExported.AppearanceCell.Options.UseBackColor = true;
			this.colDateExported.AppearanceCell.Options.UseFont = true;
			this.colDateExported.AppearanceCell.Options.UseTextOptions = true;
			this.colDateExported.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDateExported.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDateExported.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDateExported.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colDateExported.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colDateExported.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colDateExported.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colDateExported.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colDateExported.AppearanceHeader.Options.UseBackColor = true;
			this.colDateExported.AppearanceHeader.Options.UseBorderColor = true;
			this.colDateExported.AppearanceHeader.Options.UseFont = true;
			this.colDateExported.AppearanceHeader.Options.UseForeColor = true;
			this.colDateExported.AppearanceHeader.Options.UseTextOptions = true;
			this.colDateExported.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colDateExported.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDateExported.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDateExported.Caption = "Ngày xuất kho";
			this.colDateExported.FieldName = "DateExported";
			this.colDateExported.MinWidth = 25;
			this.colDateExported.Name = "colDateExported";
			this.colDateExported.OptionsColumn.AllowEdit = false;
			this.colDateExported.Visible = true;
			this.colDateExported.VisibleIndex = 1;
			this.colDateExported.Width = 200;
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
			this.colPartCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
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
			this.colPartCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPartCode.Caption = "Mã linh kiện";
			this.colPartCode.FieldName = "PartCode";
			this.colPartCode.MinWidth = 25;
			this.colPartCode.Name = "colPartCode";
			this.colPartCode.OptionsColumn.AllowEdit = false;
			this.colPartCode.Visible = true;
			this.colPartCode.VisibleIndex = 2;
			this.colPartCode.Width = 236;
			// 
			// colLotSize
			// 
			this.colLotSize.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colLotSize.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colLotSize.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colLotSize.AppearanceCell.Options.UseBackColor = true;
			this.colLotSize.AppearanceCell.Options.UseFont = true;
			this.colLotSize.AppearanceCell.Options.UseTextOptions = true;
			this.colLotSize.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLotSize.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colLotSize.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colLotSize.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colLotSize.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colLotSize.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colLotSize.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colLotSize.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colLotSize.AppearanceHeader.Options.UseBackColor = true;
			this.colLotSize.AppearanceHeader.Options.UseBorderColor = true;
			this.colLotSize.AppearanceHeader.Options.UseFont = true;
			this.colLotSize.AppearanceHeader.Options.UseForeColor = true;
			this.colLotSize.AppearanceHeader.Options.UseTextOptions = true;
			this.colLotSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLotSize.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colLotSize.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colLotSize.Caption = "Lot Size";
			this.colLotSize.FieldName = "LotSize";
			this.colLotSize.MinWidth = 25;
			this.colLotSize.Name = "colLotSize";
			this.colLotSize.OptionsColumn.AllowEdit = false;
			this.colLotSize.Visible = true;
			this.colLotSize.VisibleIndex = 3;
			this.colLotSize.Width = 109;
			// 
			// colQtyPlan
			// 
			this.colQtyPlan.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colQtyPlan.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colQtyPlan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colQtyPlan.AppearanceCell.Options.UseBackColor = true;
			this.colQtyPlan.AppearanceCell.Options.UseFont = true;
			this.colQtyPlan.AppearanceCell.Options.UseTextOptions = true;
			this.colQtyPlan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQtyPlan.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQtyPlan.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQtyPlan.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colQtyPlan.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colQtyPlan.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colQtyPlan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colQtyPlan.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colQtyPlan.AppearanceHeader.Options.UseBackColor = true;
			this.colQtyPlan.AppearanceHeader.Options.UseBorderColor = true;
			this.colQtyPlan.AppearanceHeader.Options.UseFont = true;
			this.colQtyPlan.AppearanceHeader.Options.UseForeColor = true;
			this.colQtyPlan.AppearanceHeader.Options.UseTextOptions = true;
			this.colQtyPlan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQtyPlan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQtyPlan.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQtyPlan.Caption = "Kế hoạch";
			this.colQtyPlan.FieldName = "QtyPlan";
			this.colQtyPlan.MinWidth = 25;
			this.colQtyPlan.Name = "colQtyPlan";
			this.colQtyPlan.OptionsColumn.AllowEdit = false;
			this.colQtyPlan.Visible = true;
			this.colQtyPlan.VisibleIndex = 4;
			this.colQtyPlan.Width = 113;
			// 
			// colProdDate
			// 
			this.colProdDate.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colProdDate.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colProdDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colProdDate.AppearanceCell.Options.UseBackColor = true;
			this.colProdDate.AppearanceCell.Options.UseFont = true;
			this.colProdDate.AppearanceCell.Options.UseTextOptions = true;
			this.colProdDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProdDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProdDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProdDate.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colProdDate.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colProdDate.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colProdDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colProdDate.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colProdDate.AppearanceHeader.Options.UseBackColor = true;
			this.colProdDate.AppearanceHeader.Options.UseBorderColor = true;
			this.colProdDate.AppearanceHeader.Options.UseFont = true;
			this.colProdDate.AppearanceHeader.Options.UseForeColor = true;
			this.colProdDate.AppearanceHeader.Options.UseTextOptions = true;
			this.colProdDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProdDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProdDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProdDate.Caption = "Ngày sản xuất thực tế";
			this.colProdDate.FieldName = "ProdDate";
			this.colProdDate.MinWidth = 25;
			this.colProdDate.Name = "colProdDate";
			this.colProdDate.OptionsColumn.AllowEdit = false;
			this.colProdDate.Visible = true;
			this.colProdDate.VisibleIndex = 5;
			this.colProdDate.Width = 122;
			// 
			// colOK
			// 
			this.colOK.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colOK.AppearanceCell.Options.UseFont = true;
			this.colOK.AppearanceCell.Options.UseTextOptions = true;
			this.colOK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOK.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOK.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colOK.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colOK.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colOK.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colOK.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colOK.AppearanceHeader.Options.UseBackColor = true;
			this.colOK.AppearanceHeader.Options.UseBorderColor = true;
			this.colOK.AppearanceHeader.Options.UseFont = true;
			this.colOK.AppearanceHeader.Options.UseForeColor = true;
			this.colOK.AppearanceHeader.Options.UseTextOptions = true;
			this.colOK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colOK.Caption = "OK";
			this.colOK.FieldName = "RealProdQty";
			this.colOK.MinWidth = 25;
			this.colOK.Name = "colOK";
			this.colOK.Visible = true;
			this.colOK.VisibleIndex = 6;
			// 
			// colNG
			// 
			this.colNG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colNG.AppearanceCell.Options.UseFont = true;
			this.colNG.AppearanceCell.Options.UseTextOptions = true;
			this.colNG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNG.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colNG.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colNG.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colNG.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colNG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colNG.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colNG.AppearanceHeader.Options.UseBackColor = true;
			this.colNG.AppearanceHeader.Options.UseBorderColor = true;
			this.colNG.AppearanceHeader.Options.UseFont = true;
			this.colNG.AppearanceHeader.Options.UseForeColor = true;
			this.colNG.AppearanceHeader.Options.UseTextOptions = true;
			this.colNG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colNG.Caption = "NG";
			this.colNG.FieldName = "NG";
			this.colNG.MinWidth = 25;
			this.colNG.Name = "colNG";
			this.colNG.Visible = true;
			this.colNG.VisibleIndex = 7;
			this.colNG.Width = 55;
			// 
			// colOrderCode
			// 
			this.colOrderCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
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
			this.colOrderCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOrderCode.Caption = "MÃ ORDER";
			this.colOrderCode.FieldName = "OrderCode";
			this.colOrderCode.MinWidth = 25;
			this.colOrderCode.Name = "colOrderCode";
			this.colOrderCode.Visible = true;
			this.colOrderCode.VisibleIndex = 8;
			this.colOrderCode.Width = 173;
			// 
			// colSaleCode
			// 
			this.colSaleCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colSaleCode.AppearanceCell.Options.UseFont = true;
			this.colSaleCode.AppearanceCell.Options.UseTextOptions = true;
			this.colSaleCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSaleCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSaleCode.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colSaleCode.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colSaleCode.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colSaleCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colSaleCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colSaleCode.AppearanceHeader.Options.UseBackColor = true;
			this.colSaleCode.AppearanceHeader.Options.UseBorderColor = true;
			this.colSaleCode.AppearanceHeader.Options.UseFont = true;
			this.colSaleCode.AppearanceHeader.Options.UseForeColor = true;
			this.colSaleCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colSaleCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSaleCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSaleCode.Caption = "SALE ORDER";
			this.colSaleCode.FieldName = "SaleCode";
			this.colSaleCode.MinWidth = 25;
			this.colSaleCode.Name = "colSaleCode";
			this.colSaleCode.Visible = true;
			this.colSaleCode.VisibleIndex = 9;
			this.colSaleCode.Width = 161;
			// 
			// colOP
			// 
			this.colOP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colOP.AppearanceCell.Options.UseFont = true;
			this.colOP.AppearanceCell.Options.UseTextOptions = true;
			this.colOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOP.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colOP.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colOP.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colOP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colOP.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colOP.AppearanceHeader.Options.UseBackColor = true;
			this.colOP.AppearanceHeader.Options.UseBorderColor = true;
			this.colOP.AppearanceHeader.Options.UseFont = true;
			this.colOP.AppearanceHeader.Options.UseForeColor = true;
			this.colOP.AppearanceHeader.Options.UseTextOptions = true;
			this.colOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colOP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colOP.Caption = "OP";
			this.colOP.FieldName = "OP";
			this.colOP.MinWidth = 25;
			this.colOP.Name = "colOP";
			this.colOP.Visible = true;
			this.colOP.VisibleIndex = 10;
			// 
			// colShipTo
			// 
			this.colShipTo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colShipTo.AppearanceCell.Options.UseFont = true;
			this.colShipTo.AppearanceCell.Options.UseTextOptions = true;
			this.colShipTo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colShipTo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colShipTo.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colShipTo.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colShipTo.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colShipTo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colShipTo.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colShipTo.AppearanceHeader.Options.UseBackColor = true;
			this.colShipTo.AppearanceHeader.Options.UseBorderColor = true;
			this.colShipTo.AppearanceHeader.Options.UseFont = true;
			this.colShipTo.AppearanceHeader.Options.UseForeColor = true;
			this.colShipTo.AppearanceHeader.Options.UseTextOptions = true;
			this.colShipTo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colShipTo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colShipTo.Caption = "SHIP TO";
			this.colShipTo.FieldName = "ShipTo";
			this.colShipTo.MinWidth = 25;
			this.colShipTo.Name = "colShipTo";
			this.colShipTo.Visible = true;
			this.colShipTo.VisibleIndex = 11;
			this.colShipTo.Width = 118;
			// 
			// colShipVia
			// 
			this.colShipVia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colShipVia.AppearanceCell.Options.UseFont = true;
			this.colShipVia.AppearanceCell.Options.UseTextOptions = true;
			this.colShipVia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colShipVia.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colShipVia.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colShipVia.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colShipVia.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colShipVia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colShipVia.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colShipVia.AppearanceHeader.Options.UseBackColor = true;
			this.colShipVia.AppearanceHeader.Options.UseBorderColor = true;
			this.colShipVia.AppearanceHeader.Options.UseFont = true;
			this.colShipVia.AppearanceHeader.Options.UseForeColor = true;
			this.colShipVia.AppearanceHeader.Options.UseTextOptions = true;
			this.colShipVia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colShipVia.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colShipVia.Caption = "SHIP VIA";
			this.colShipVia.FieldName = "ShipVia";
			this.colShipVia.MinWidth = 25;
			this.colShipVia.Name = "colShipVia";
			this.colShipVia.Visible = true;
			this.colShipVia.VisibleIndex = 12;
			this.colShipVia.Width = 114;
			// 
			// colConfirmCode
			// 
			this.colConfirmCode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colConfirmCode.AppearanceCell.Options.UseFont = true;
			this.colConfirmCode.AppearanceCell.Options.UseTextOptions = true;
			this.colConfirmCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colConfirmCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colConfirmCode.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colConfirmCode.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colConfirmCode.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colConfirmCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colConfirmCode.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colConfirmCode.AppearanceHeader.Options.UseBackColor = true;
			this.colConfirmCode.AppearanceHeader.Options.UseBorderColor = true;
			this.colConfirmCode.AppearanceHeader.Options.UseFont = true;
			this.colConfirmCode.AppearanceHeader.Options.UseForeColor = true;
			this.colConfirmCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colConfirmCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colConfirmCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colConfirmCode.Caption = "CONFIRM";
			this.colConfirmCode.FieldName = "ConfirmCode";
			this.colConfirmCode.MinWidth = 25;
			this.colConfirmCode.Name = "colConfirmCode";
			this.colConfirmCode.Visible = true;
			this.colConfirmCode.VisibleIndex = 13;
			this.colConfirmCode.Width = 117;
			// 
			// colNote
			// 
			this.colNote.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colNote.AppearanceCell.Options.UseFont = true;
			this.colNote.AppearanceCell.Options.UseTextOptions = true;
			this.colNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNote.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colNote.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colNote.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colNote.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colNote.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colNote.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colNote.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colNote.AppearanceHeader.Options.UseBackColor = true;
			this.colNote.AppearanceHeader.Options.UseBorderColor = true;
			this.colNote.AppearanceHeader.Options.UseFont = true;
			this.colNote.AppearanceHeader.Options.UseForeColor = true;
			this.colNote.AppearanceHeader.Options.UseTextOptions = true;
			this.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNote.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colNote.Caption = "Chú ý";
			this.colNote.FieldName = "Note";
			this.colNote.MinWidth = 25;
			this.colNote.Name = "colNote";
			this.colNote.Visible = true;
			this.colNote.VisibleIndex = 14;
			this.colNote.Width = 194;
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
			this.colWorkerCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colWorkerCode.Caption = "Người in";
			this.colWorkerCode.FieldName = "WorkerCode";
			this.colWorkerCode.MinWidth = 25;
			this.colWorkerCode.Name = "colWorkerCode";
			this.colWorkerCode.Visible = true;
			this.colWorkerCode.VisibleIndex = 15;
			this.colWorkerCode.Width = 107;
			// 
			// colPrintedDate
			// 
			this.colPrintedDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colPrintedDate.AppearanceCell.Options.UseFont = true;
			this.colPrintedDate.AppearanceCell.Options.UseTextOptions = true;
			this.colPrintedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPrintedDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPrintedDate.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colPrintedDate.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colPrintedDate.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colPrintedDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colPrintedDate.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colPrintedDate.AppearanceHeader.Options.UseBackColor = true;
			this.colPrintedDate.AppearanceHeader.Options.UseBorderColor = true;
			this.colPrintedDate.AppearanceHeader.Options.UseFont = true;
			this.colPrintedDate.AppearanceHeader.Options.UseForeColor = true;
			this.colPrintedDate.AppearanceHeader.Options.UseTextOptions = true;
			this.colPrintedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPrintedDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPrintedDate.Caption = "Ngày in";
			this.colPrintedDate.FieldName = "PrintedDate";
			this.colPrintedDate.MinWidth = 25;
			this.colPrintedDate.Name = "colPrintedDate";
			this.colPrintedDate.Visible = true;
			this.colPrintedDate.VisibleIndex = 16;
			this.colPrintedDate.Width = 111;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.btnSearch);
			this.panel2.Controls.Add(this.txbSearch);
			this.panel2.Controls.Add(this.dtpFrom);
			this.panel2.Controls.Add(this.dtpTo);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(0, 53);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(840, 42);
			this.panel2.TabIndex = 30;
			// 
			// btnSearch
			// 
			this.btnSearch.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Appearance.Options.UseFont = true;
			this.btnSearch.Location = new System.Drawing.Point(729, 6);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 28);
			this.btnSearch.TabIndex = 25;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txbSearch
			// 
			this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbSearch.Location = new System.Drawing.Point(525, 7);
			this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txbSearch.Name = "txbSearch";
			this.txbSearch.Size = new System.Drawing.Size(195, 28);
			this.txbSearch.TabIndex = 24;
			// 
			// dtpFrom
			// 
			this.dtpFrom.CustomFormat = "dd/MM/yyyy";
			this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFrom.Location = new System.Drawing.Point(103, 7);
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
			this.dtpTo.Location = new System.Drawing.Point(365, 7);
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
			this.label1.Location = new System.Drawing.Point(273, 10);
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
			this.label3.Location = new System.Drawing.Point(16, 10);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 24);
			this.label3.TabIndex = 33;
			this.label3.Text = "Từ ngày: ";
			// 
			// frmSonPlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1275, 554);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dtgvSonPlan);
			this.Controls.Add(this.toolStrip1);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmSonPlan";
			this.Text = "KẾ HOẠCH LINH KIỆN";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSonPlan_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvSonPlan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvSonPlan)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCreatePlan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditPlan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnDelPlan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton btnImportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private DevExpress.XtraGrid.GridControl dtgvSonPlan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSonPlan;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDateExported;
        private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLotSize;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyPlan;
        private DevExpress.XtraGrid.Columns.GridColumn colProdDate;
		private DevExpress.XtraGrid.Columns.GridColumn colStt;
		private DevExpress.XtraGrid.Columns.GridColumn colOK;
		private DevExpress.XtraGrid.Columns.GridColumn colNG;
		private DevExpress.XtraGrid.Columns.GridColumn colOrderCode;
		private DevExpress.XtraGrid.Columns.GridColumn colSaleCode;
		private DevExpress.XtraGrid.Columns.GridColumn colOP;
		private DevExpress.XtraGrid.Columns.GridColumn colShipTo;
		private DevExpress.XtraGrid.Columns.GridColumn colShipVia;
		private DevExpress.XtraGrid.Columns.GridColumn colConfirmCode;
		private DevExpress.XtraGrid.Columns.GridColumn colNote;
		private DevExpress.XtraGrid.Columns.GridColumn colWorkerCode;
		private DevExpress.XtraGrid.Columns.GridColumn colPrintedDate;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel2;
		private DevExpress.XtraEditors.SimpleButton btnSearch;
		private System.Windows.Forms.TextBox txbSearch;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}