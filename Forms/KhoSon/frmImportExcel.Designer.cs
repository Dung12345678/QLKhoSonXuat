
namespace BMS
{
    partial class frmImportExcel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportExcel));
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.chkAutoCheck = new System.Windows.Forms.CheckBox();
			this.cboSheet = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnBrowse = new DevExpress.XtraEditors.ButtonEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.chbAdvImport = new System.Windows.Forms.CheckBox();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.mnuMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnBrowse.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuMenu
			// 
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(1291, 57);
			this.mnuMenu.TabIndex = 171;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = false;
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(55, 40);
			this.btnSave.Text = "Cất";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupControl1
			// 
			this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupControl1.Controls.Add(this.chkAutoCheck);
			this.groupControl1.Controls.Add(this.cboSheet);
			this.groupControl1.Controls.Add(this.label5);
			this.groupControl1.Controls.Add(this.btnBrowse);
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Location = new System.Drawing.Point(0, 60);
			this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(1291, 87);
			this.groupControl1.TabIndex = 172;
			this.groupControl1.Text = "Thông tin";
			// 
			// chkAutoCheck
			// 
			this.chkAutoCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkAutoCheck.AutoSize = true;
			this.chkAutoCheck.Checked = true;
			this.chkAutoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAutoCheck.Location = new System.Drawing.Point(1174, 43);
			this.chkAutoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkAutoCheck.Name = "chkAutoCheck";
			this.chkAutoCheck.Size = new System.Drawing.Size(101, 21);
			this.chkAutoCheck.TabIndex = 177;
			this.chkAutoCheck.Text = "New ImPort";
			this.chkAutoCheck.UseVisualStyleBackColor = true;
			// 
			// cboSheet
			// 
			this.cboSheet.FormattingEnabled = true;
			this.cboSheet.Location = new System.Drawing.Point(880, 41);
			this.cboSheet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboSheet.Name = "cboSheet";
			this.cboSheet.Size = new System.Drawing.Size(208, 24);
			this.cboSheet.TabIndex = 1;
			this.cboSheet.SelectionChangeCommitted += new System.EventHandler(this.cboSheet_SelectionChangeCommitted);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(796, 46);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 17);
			this.label5.TabIndex = 147;
			this.label5.Text = "Tên Sheet:";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(93, 42);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.btnBrowse.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.btnBrowse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.btnBrowse.Size = new System.Drawing.Size(681, 22);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnBrowse_ButtonClick);
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(12, 46);
			this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(63, 16);
			this.labelControl5.TabIndex = 4;
			this.labelControl5.Text = "Đường dẫn";
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grdData.Location = new System.Drawing.Point(0, 150);
			this.grdData.MainView = this.grvData;
			this.grdData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grdData.Name = "grdData";
			this.grdData.Size = new System.Drawing.Size(1291, 492);
			this.grdData.TabIndex = 173;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.grvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.grvData.GridControl = this.grdData;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.AutoExpandAllGroups = true;
			this.grvData.OptionsBehavior.Editable = false;
			this.grvData.OptionsBehavior.ReadOnly = true;
			this.grvData.OptionsFilter.AllowFilterEditor = false;
			this.grvData.OptionsView.ColumnAutoWidth = false;
			this.grvData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.grvData.OptionsView.ShowGroupPanel = false;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// chbAdvImport
			// 
			this.chbAdvImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chbAdvImport.AutoSize = true;
			this.chbAdvImport.Location = new System.Drawing.Point(625, 17);
			this.chbAdvImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chbAdvImport.Name = "chbAdvImport";
			this.chbAdvImport.Size = new System.Drawing.Size(133, 21);
			this.chbAdvImport.TabIndex = 177;
			this.chbAdvImport.Text = "Nhập dữ liệu lớn";
			this.chbAdvImport.UseVisualStyleBackColor = true;
			// 
			// txtRate
			// 
			this.txtRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRate.Location = new System.Drawing.Point(765, 15);
			this.txtRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtRate.Name = "txtRate";
			this.txtRate.ReadOnly = true;
			this.txtRate.Size = new System.Drawing.Size(132, 22);
			this.txtRate.TabIndex = 176;
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(904, 14);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(372, 28);
			this.progressBar1.TabIndex = 175;
			// 
			// frmImportExcel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1291, 645);
			this.Controls.Add(this.chbAdvImport);
			this.Controls.Add(this.txtRate);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.grdData);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.mnuMenu);
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "frmImportExcel";
			this.Text = "NHẬP EXCEL";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImportExcel_FormClosing);
			this.Load += new System.EventHandler(this.frmImportExcel_Load);
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnBrowse.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnuMenu;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckBox chkAutoCheck;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ButtonEdit btnBrowse;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chbAdvImport;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}