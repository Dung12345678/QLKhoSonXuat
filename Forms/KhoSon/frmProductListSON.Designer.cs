
namespace BMS
{
    partial class frmProductListSON
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductListSON));
			this.miniToolStrip = new System.Windows.Forms.ToolStrip();
			this.btnAddProduct = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEditProducts = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDeleteProduct = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSungLuc = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnImportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnUpdateStepCode = new System.Windows.Forms.ToolStripButton();
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSonPlan = new System.Windows.Forms.ToolStripButton();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txbSearchProducts = new System.Windows.Forms.TextBox();
			this.btnSearchProducts = new DevExpress.XtraEditors.SimpleButton();
			this.gvPart = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantityExporting = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantityAssembling = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dtgvProducts = new DevExpress.XtraGrid.GridControl();
			this.mnuMenu.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvPart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// miniToolStrip
			// 
			this.miniToolStrip.AccessibleName = "New item selection";
			this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
			this.miniToolStrip.AutoSize = false;
			this.miniToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.miniToolStrip.CanOverflow = false;
			this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.miniToolStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.miniToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.miniToolStrip.Location = new System.Drawing.Point(655, 0);
			this.miniToolStrip.Name = "miniToolStrip";
			this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.miniToolStrip.Size = new System.Drawing.Size(825, 42);
			this.miniToolStrip.TabIndex = 26;
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
			this.btnAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(90, 37);
			this.btnAddProduct.Tag = "frmProduct_AddProductH";
			this.btnAddProduct.Text = "Tạo sản phẩm";
			this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEditProducts
			// 
			this.btnEditProducts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProducts.Image")));
			this.btnEditProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEditProducts.Name = "btnEditProducts";
			this.btnEditProducts.Size = new System.Drawing.Size(91, 37);
			this.btnEditProducts.Tag = "frmProduct_EditProductH";
			this.btnEditProducts.Text = "Sửa sản phẩm";
			this.btnEditProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDeleteProduct
			// 
			this.btnDeleteProduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
			this.btnDeleteProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDeleteProduct.Name = "btnDeleteProduct";
			this.btnDeleteProduct.Size = new System.Drawing.Size(90, 37);
			this.btnDeleteProduct.Tag = "frmProduct_DeleteProductH";
			this.btnDeleteProduct.Text = "Xóa sản phẩm";
			this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.AutoSize = false;
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSungLuc
			// 
			this.btnSungLuc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSungLuc.Image = ((System.Drawing.Image)(resources.GetObject("btnSungLuc.Image")));
			this.btnSungLuc.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSungLuc.Name = "btnSungLuc";
			this.btnSungLuc.Size = new System.Drawing.Size(70, 37);
			this.btnSungLuc.Tag = "frmProduct_GunH";
			this.btnSungLuc.Text = "Nhập hàng";
			this.btnSungLuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
			// 
			// btnExcel
			// 
			this.btnExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(69, 37);
			this.btnExcel.Tag = "";
			this.btnExcel.Text = "Xuất Excel";
			this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
			// 
			// btnImportExcel
			// 
			this.btnImportExcel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnImportExcel.Image")));
			this.btnImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImportExcel.Name = "btnImportExcel";
			this.btnImportExcel.Size = new System.Drawing.Size(71, 37);
			this.btnImportExcel.Tag = "frmProduct_ImportExcelProductH";
			this.btnImportExcel.Text = "Nhập Excel";
			this.btnImportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
			// 
			// btnUpdateStepCode
			// 
			this.btnUpdateStepCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateStepCode.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStepCode.Image")));
			this.btnUpdateStepCode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUpdateStepCode.Name = "btnUpdateStepCode";
			this.btnUpdateStepCode.Size = new System.Drawing.Size(138, 37);
			this.btnUpdateStepCode.Tag = "frmProduct_UpdateCDH";
			this.btnUpdateStepCode.Text = "Xem lịch sử nhập/xuất";
			this.btnUpdateStepCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// mnuMenu
			// 
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProduct,
            this.toolStripSeparator6,
            this.btnEditProducts,
            this.toolStripSeparator4,
            this.btnDeleteProduct,
            this.toolStripSeparator10,
            this.btnSungLuc,
            this.toolStripSeparator5,
            this.btnExcel,
            this.toolStripSeparator3,
            this.btnImportExcel,
            this.toolStripSeparator2,
            this.btnUpdateStepCode});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(825, 42);
			this.mnuMenu.TabIndex = 26;
			this.mnuMenu.Text = "toolStrip2";
			this.mnuMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMenu_ItemClicked);
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
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
            this.toolStripSeparator13,
            this.btnExportExcel,
            this.toolStripSeparator11,
            this.btnImportEx,
            this.toolStripSeparator12,
            this.btnHistory,
            this.toolStripSeparator9,
            this.btnSonPlan});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1202, 52);
			this.toolStrip1.TabIndex = 26;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// btnCreatePart
			// 
			this.btnCreatePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnImportEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
			this.btnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new System.Drawing.Size(171, 41);
			this.btnHistory.Tag = "frmProduct_UpdateCDH";
			this.btnHistory.Text = "Xem lịch sử nhập/xuất";
			this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.AutoSize = false;
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 40);
			// 
			// btnSonPlan
			// 
			this.btnSonPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSonPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnSonPlan.Image")));
			this.btnSonPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSonPlan.Name = "btnSonPlan";
			this.btnSonPlan.Size = new System.Drawing.Size(114, 41);
			this.btnSonPlan.Tag = "frmProduct_UpdateCDH";
			this.btnSonPlan.Text = "Xem kế hoạch";
			this.btnSonPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSonPlan.Click += new System.EventHandler(this.btnSonPlan_Click);
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.txbSearchProducts);
			this.panel6.Controls.Add(this.btnSearchProducts);
			this.panel6.Location = new System.Drawing.Point(0, 55);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(662, 44);
			this.panel6.TabIndex = 27;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 27;
			this.label1.Text = "Từ khóa";
			// 
			// txbSearchProducts
			// 
			this.txbSearchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbSearchProducts.Location = new System.Drawing.Point(76, 10);
			this.txbSearchProducts.Margin = new System.Windows.Forms.Padding(4);
			this.txbSearchProducts.Name = "txbSearchProducts";
			this.txbSearchProducts.Size = new System.Drawing.Size(416, 24);
			this.txbSearchProducts.TabIndex = 26;
			// 
			// btnSearchProducts
			// 
			this.btnSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSearchProducts.Location = new System.Drawing.Point(500, 10);
			this.btnSearchProducts.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearchProducts.Name = "btnSearchProducts";
			this.btnSearchProducts.Size = new System.Drawing.Size(112, 25);
			this.btnSearchProducts.TabIndex = 25;
			this.btnSearchProducts.Text = "Tìm kiếm";
			this.btnSearchProducts.Click += new System.EventHandler(this.btnSearchProducts_Click);
			// 
			// gvPart
			// 
			this.gvPart.ColumnPanelRowHeight = 40;
			this.gvPart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPartCode,
            this.colPartName,
            this.colDescription,
            this.colQuantityExporting,
            this.colQuantityAssembling});
			this.gvPart.GridControl = this.dtgvProducts;
			this.gvPart.Name = "gvPart";
			this.gvPart.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvPart.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvPart.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvPart.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvPart.OptionsBehavior.Editable = false;
			this.gvPart.OptionsNavigation.AutoFocusNewRow = true;
			this.gvPart.OptionsView.ShowGroupPanel = false;
			this.gvPart.PaintStyleName = "Flat";
			this.gvPart.RowHeight = 25;
			this.gvPart.DoubleClick += new System.EventHandler(this.gvPart_DoubleClick);
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
			this.colPartCode.Name = "colPartCode";
			this.colPartCode.OptionsColumn.AllowEdit = false;
			this.colPartCode.Visible = true;
			this.colPartCode.VisibleIndex = 0;
			this.colPartCode.Width = 232;
			// 
			// colPartName
			// 
			this.colPartName.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colPartName.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colPartName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colPartName.AppearanceCell.Options.UseBackColor = true;
			this.colPartName.AppearanceCell.Options.UseFont = true;
			this.colPartName.AppearanceCell.Options.UseTextOptions = true;
			this.colPartName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPartName.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colPartName.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colPartName.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colPartName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colPartName.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colPartName.AppearanceHeader.Options.UseBackColor = true;
			this.colPartName.AppearanceHeader.Options.UseBorderColor = true;
			this.colPartName.AppearanceHeader.Options.UseFont = true;
			this.colPartName.AppearanceHeader.Options.UseForeColor = true;
			this.colPartName.AppearanceHeader.Options.UseTextOptions = true;
			this.colPartName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPartName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colPartName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colPartName.Caption = "Tên linh kiện";
			this.colPartName.FieldName = "PartName";
			this.colPartName.Name = "colPartName";
			this.colPartName.OptionsColumn.AllowEdit = false;
			this.colPartName.Width = 290;
			// 
			// colDescription
			// 
			this.colDescription.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colDescription.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colDescription.AppearanceCell.Options.UseBackColor = true;
			this.colDescription.AppearanceCell.Options.UseFont = true;
			this.colDescription.AppearanceCell.Options.UseTextOptions = true;
			this.colDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colDescription.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colDescription.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colDescription.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colDescription.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colDescription.AppearanceHeader.Options.UseBackColor = true;
			this.colDescription.AppearanceHeader.Options.UseBorderColor = true;
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
			this.colDescription.VisibleIndex = 1;
			this.colDescription.Width = 199;
			// 
			// colQuantityExporting
			// 
			this.colQuantityExporting.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colQuantityExporting.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colQuantityExporting.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colQuantityExporting.AppearanceCell.Options.UseBackColor = true;
			this.colQuantityExporting.AppearanceCell.Options.UseFont = true;
			this.colQuantityExporting.AppearanceCell.Options.UseTextOptions = true;
			this.colQuantityExporting.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantityExporting.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantityExporting.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantityExporting.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colQuantityExporting.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colQuantityExporting.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colQuantityExporting.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colQuantityExporting.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colQuantityExporting.AppearanceHeader.Options.UseBackColor = true;
			this.colQuantityExporting.AppearanceHeader.Options.UseBorderColor = true;
			this.colQuantityExporting.AppearanceHeader.Options.UseFont = true;
			this.colQuantityExporting.AppearanceHeader.Options.UseForeColor = true;
			this.colQuantityExporting.AppearanceHeader.Options.UseTextOptions = true;
			this.colQuantityExporting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantityExporting.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantityExporting.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantityExporting.Caption = "Số lượng xuất khẩu";
			this.colQuantityExporting.FieldName = "QuantityExporting";
			this.colQuantityExporting.Name = "colQuantityExporting";
			this.colQuantityExporting.OptionsColumn.AllowEdit = false;
			this.colQuantityExporting.Visible = true;
			this.colQuantityExporting.VisibleIndex = 2;
			this.colQuantityExporting.Width = 126;
			// 
			// colQuantityAssembling
			// 
			this.colQuantityAssembling.AppearanceCell.BackColor = System.Drawing.Color.White;
			this.colQuantityAssembling.AppearanceCell.BackColor2 = System.Drawing.Color.White;
			this.colQuantityAssembling.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colQuantityAssembling.AppearanceCell.Options.UseBackColor = true;
			this.colQuantityAssembling.AppearanceCell.Options.UseFont = true;
			this.colQuantityAssembling.AppearanceCell.Options.UseTextOptions = true;
			this.colQuantityAssembling.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantityAssembling.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantityAssembling.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantityAssembling.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colQuantityAssembling.AppearanceHeader.BackColor2 = System.Drawing.Color.DodgerBlue;
			this.colQuantityAssembling.AppearanceHeader.BorderColor = System.Drawing.Color.DodgerBlue;
			this.colQuantityAssembling.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colQuantityAssembling.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colQuantityAssembling.AppearanceHeader.Options.UseBackColor = true;
			this.colQuantityAssembling.AppearanceHeader.Options.UseBorderColor = true;
			this.colQuantityAssembling.AppearanceHeader.Options.UseFont = true;
			this.colQuantityAssembling.AppearanceHeader.Options.UseForeColor = true;
			this.colQuantityAssembling.AppearanceHeader.Options.UseTextOptions = true;
			this.colQuantityAssembling.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantityAssembling.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantityAssembling.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantityAssembling.Caption = "Số lượng lắp ráp";
			this.colQuantityAssembling.FieldName = "QuantityAssembling";
			this.colQuantityAssembling.Name = "colQuantityAssembling";
			this.colQuantityAssembling.OptionsColumn.AllowEdit = false;
			this.colQuantityAssembling.Visible = true;
			this.colQuantityAssembling.VisibleIndex = 3;
			this.colQuantityAssembling.Width = 140;
			// 
			// dtgvProducts
			// 
			this.dtgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvProducts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvProducts.Location = new System.Drawing.Point(0, 107);
			this.dtgvProducts.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
			this.dtgvProducts.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
			this.dtgvProducts.LookAndFeel.UseDefaultLookAndFeel = false;
			this.dtgvProducts.MainView = this.gvPart;
			this.dtgvProducts.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvProducts.Name = "dtgvProducts";
			this.dtgvProducts.Size = new System.Drawing.Size(1202, 569);
			this.dtgvProducts.TabIndex = 28;
			this.dtgvProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPart});
			// 
			// frmProductListSON
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1202, 690);
			this.Controls.Add(this.dtgvProducts);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(1192, 729);
			this.Name = "frmProductListSON";
			this.Text = "DANH SÁCH LINH KIỆN";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmProductListSON_Load);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvPart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton btnAddProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnEditProducts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDeleteProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnSungLuc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnImportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnUpdateStepCode;
        private System.Windows.Forms.ToolStrip mnuMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCreatePart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditPart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnDelPart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnImportPart;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton btnImportEx;
        private System.Windows.Forms.ToolStripButton btnHistory;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.SimpleButton btnSearchProducts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
		private System.Windows.Forms.TextBox txbSearchProducts;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraGrid.Views.Grid.GridView gvPart;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
		private DevExpress.XtraGrid.Columns.GridColumn colPartName;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantityExporting;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantityAssembling;
		private DevExpress.XtraGrid.GridControl dtgvProducts;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripButton btnSonPlan;
	}
}