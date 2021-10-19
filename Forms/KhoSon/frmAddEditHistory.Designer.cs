
namespace BMS

{
    partial class frmAddEditHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditHistory));
            this.mnuMenu = new System.Windows.Forms.ToolStrip();
            this.btnSaveClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAsQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtExQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartCode = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.mnuMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.AutoSize = false;
            this.mnuMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveClose,
            this.toolStripSeparator2});
            this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuMenu.Size = new System.Drawing.Size(461, 42);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "toolStrip2";
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClose.Image")));
            this.btnSaveClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(75, 33);
            this.btnSaveClose.Tag = "frmProduct_AddProductH";
            this.btnSaveClose.Text = "Cất && Đóng";
            this.btnSaveClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 135);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAsQuantity);
            this.tabPage1.Controls.Add(this.txtExQuantity);
            this.tabPage1.Controls.Add(this.labelControl7);
            this.tabPage1.Controls.Add(this.labelControl6);
            this.tabPage1.Controls.Add(this.txtPartCode);
            this.tabPage1.Controls.Add(this.labelControl9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 109);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAsQuantity
            // 
            this.txtAsQuantity.Location = new System.Drawing.Point(169, 69);
            this.txtAsQuantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtAsQuantity.Name = "txtAsQuantity";
            this.txtAsQuantity.Size = new System.Drawing.Size(203, 20);
            this.txtAsQuantity.TabIndex = 179;
            // 
            // txtExQuantity
            // 
            this.txtExQuantity.Location = new System.Drawing.Point(169, 42);
            this.txtExQuantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtExQuantity.Name = "txtExQuantity";
            this.txtExQuantity.Size = new System.Drawing.Size(203, 20);
            this.txtExQuantity.TabIndex = 178;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(41, 44);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(120, 13);
            this.labelControl7.TabIndex = 177;
            this.labelControl7.Text = "Số lượng hàng xuất khẩu";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(56, 71);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(105, 13);
            this.labelControl6.TabIndex = 176;
            this.labelControl6.Text = "Số lượng hàng lắp ráp";
            // 
            // txtPartCode
            // 
            this.txtPartCode.Location = new System.Drawing.Point(169, 17);
            this.txtPartCode.Name = "txtPartCode";
            this.txtPartCode.ReadOnly = true;
            this.txtPartCode.Size = new System.Drawing.Size(203, 20);
            this.txtPartCode.TabIndex = 2;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(98, 21);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 13);
            this.labelControl9.TabIndex = 89;
            this.labelControl9.Text = "Mã sản phẩm";
            // 
            // frmAddEditHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 192);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnuMenu);
            this.MaximumSize = new System.Drawing.Size(477, 231);
            this.MinimumSize = new System.Drawing.Size(477, 231);
            this.Name = "frmAddEditHistory";
            this.Text = "Sửa lịch sử xuất nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditProduct_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnuMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripButton btnSaveClose;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown txtAsQuantity;
        private System.Windows.Forms.NumericUpDown txtExQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtPartCode;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}