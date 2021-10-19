
namespace BMS
{
	partial class frmMotorPartDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotorPartDetails));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnEditPart = new System.Windows.Forms.ToolStripButton();
			this.dtgvMotorDetails = new DevExpress.XtraGrid.GridControl();
			this.gvMotorDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPositionCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPartID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPositionID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMotorDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMotorDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditPart});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(1084, 7);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(122, 51);
			this.toolStrip1.TabIndex = 28;
			this.toolStrip1.Text = "toolStrip2";
			// 
			// btnEditPart
			// 
			this.btnEditPart.BackColor = System.Drawing.SystemColors.Control;
			this.btnEditPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			// dtgvMotorDetails
			// 
			this.dtgvMotorDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgvMotorDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvMotorDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgvMotorDetails.Location = new System.Drawing.Point(4, 3);
			this.dtgvMotorDetails.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
			this.dtgvMotorDetails.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
			this.dtgvMotorDetails.LookAndFeel.UseDefaultLookAndFeel = false;
			this.dtgvMotorDetails.MainView = this.gvMotorDetails;
			this.dtgvMotorDetails.Margin = new System.Windows.Forms.Padding(4);
			this.dtgvMotorDetails.Name = "dtgvMotorDetails";
			this.dtgvMotorDetails.Size = new System.Drawing.Size(1198, 467);
			this.dtgvMotorDetails.TabIndex = 35;
			this.dtgvMotorDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMotorDetails});
			// 
			// gvMotorDetails
			// 
			this.gvMotorDetails.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.gvMotorDetails.ColumnPanelRowHeight = 40;
			this.gvMotorDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPartCode,
            this.colPositionCode,
            this.colQuantity,
            this.colSTT,
            this.colPartID,
            this.colPositionID});
			this.gvMotorDetails.GridControl = this.dtgvMotorDetails;
			this.gvMotorDetails.Name = "gvMotorDetails";
			this.gvMotorDetails.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMotorDetails.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gvMotorDetails.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
			this.gvMotorDetails.OptionsBehavior.AllowIncrementalSearch = true;
			this.gvMotorDetails.OptionsBehavior.Editable = false;
			this.gvMotorDetails.OptionsCustomization.AllowColumnMoving = false;
			this.gvMotorDetails.OptionsCustomization.AllowQuickHideColumns = false;
			this.gvMotorDetails.OptionsFind.AlwaysVisible = true;
			this.gvMotorDetails.OptionsFind.ShowCloseButton = false;
			this.gvMotorDetails.OptionsView.ShowGroupPanel = false;
			this.gvMotorDetails.PaintStyleName = "Web";
			this.gvMotorDetails.RowHeight = 25;
			this.gvMotorDetails.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
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
			this.colPartCode.Width = 456;
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
			this.colPositionCode.Caption = "Mã vị trí";
			this.colPositionCode.FieldName = "PositionCode";
			this.colPositionCode.Name = "colPositionCode";
			this.colPositionCode.OptionsColumn.AllowEdit = false;
			this.colPositionCode.Visible = true;
			this.colPositionCode.VisibleIndex = 2;
			this.colPositionCode.Width = 345;
			// 
			// colQuantity
			// 
			this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11F);
			this.colQuantity.AppearanceCell.Options.UseFont = true;
			this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
			this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colQuantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colQuantity.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colQuantity.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.colQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.White;
			this.colQuantity.AppearanceHeader.Options.UseBackColor = true;
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
			this.colQuantity.Width = 252;
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
			this.colSTT.Width = 130;
			// 
			// colPartID
			// 
			this.colPartID.Caption = "gridColumn1";
			this.colPartID.FieldName = "PartID";
			this.colPartID.Name = "colPartID";
			// 
			// colPositionID
			// 
			this.colPositionID.Caption = "gridColumn1";
			this.colPositionID.FieldName = "PositionID";
			this.colPositionID.Name = "colPositionID";
			// 
			// frmMotorPartDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1204, 472);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dtgvMotorDetails);
			this.Name = "frmMotorPartDetails";
			this.Text = "CHI TIẾT SỐ LƯỢNG LINH KIỆN";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMotorPartDetails_FormClosing);
			this.Load += new System.EventHandler(this.frmMotorPartDetails_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvMotorDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvMotorDetails)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnEditPart;
		private DevExpress.XtraGrid.GridControl dtgvMotorDetails;
		private DevExpress.XtraGrid.Views.Grid.GridView gvMotorDetails;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colPartCode;
		private DevExpress.XtraGrid.Columns.GridColumn colPositionCode;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
		private DevExpress.XtraGrid.Columns.GridColumn colPartID;
		private DevExpress.XtraGrid.Columns.GridColumn colPositionID;
	}
}