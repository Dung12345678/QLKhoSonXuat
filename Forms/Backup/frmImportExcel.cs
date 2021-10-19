using BMS.Business;
using BMS.Model;
using BMS.Utils;
using DevExpress.Utils;
using ExcelDataReader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmImportExcel : _Forms
	{
		public frmImportExcel()
		{
			InitializeComponent();
		}
		private DataSet ds;
		DateTime start;


        #region Method
        private static IList<string> GetTablenames(DataTableCollection tables)
		{
			var tableList = new List<string>();
			foreach (var table in tables)
			{
				tableList.Add(table.ToString());
			}

			return tableList;
		}

		private DataSet ReadData() {
			var stream = new FileStream(btnBrowse.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

			var sw = new Stopwatch();
			sw.Start();

			IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

			var openTiming = sw.ElapsedMilliseconds;

			ds = reader.AsDataSet(new ExcelDataSetConfiguration()
			{
				UseColumnDataType = false,
				ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
				{
					UseHeaderRow = false
				}
			});	// ton nhieu thoi gian
			//toolStripStatusLabel1.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";

			
			return ds;
		}

		void enableControl(bool enable) {
			btnSave.Enabled = enable;
			grdData.Enabled = enable;
			cboSheet.Enabled = enable;
			btnBrowse.Enabled = enable;
		}
        #endregion



		private async void btnBrowse_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
			grvData.Columns.Clear();
			txtRate.Text = "";
			cboSheet.DataSource = null;
			OpenFileDialog ofd = new OpenFileDialog();
			if (chkAutoCheck.Checked)
			{
				OpenFileDialog openFileDialog1 = new OpenFileDialog();
				var result = openFileDialog1.ShowDialog();
				if (result == DialogResult.OK)
				{
					btnBrowse.Text = openFileDialog1.FileName;
				}
				else if (result == DialogResult.Cancel)
				{
					return;
				}

				try
				{
					using (WaitDialogForm wait = new WaitDialogForm("","")) { 
						Task<DataSet> tasks = new Task<DataSet>(ReadData);	// Load method vao Task
						tasks.Start();										// Cho Task chay
						//frmSonLoading.ShowSplashScreen();
						txtRate.Text = "Dang xu ly...";
						DataSet ds = await tasks;							// Lay data tra ve tu task
						var tablenames = GetTablenames(ds.Tables);

						cboSheet.DataSource = tablenames;
						//frmSonLoading.CloseForm();
						//this.Focus(); this.Show();
						if (tablenames.Count > 0)
							cboSheet.SelectedIndex = 0;
						txtRate.Text = "Da xong!";
						btnSave.Enabled = true;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			else
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					btnBrowse.Text = ofd.FileName;
					cboSheet.DataSource = null;
					cboSheet.DataSource = TextUtils.ListSheetInExcel(ofd.FileName);
					btnSave.Enabled = true;
				}
			}

		}

		private void cboSheet_SelectionChangeCommitted(object sender, EventArgs e)
		{
			grvData.Columns.Clear();
			if (chkAutoCheck.Checked) {
				try
				{
					DataTable dtt = ds.Tables[cboSheet.SelectedIndex];

					for (int i = 0; i < dtt.Columns.Count; i++) {
						dtt.Columns[i].ColumnName = "F" + i.ToString();
					}
					
					grdData.DataSource = dtt;
					grvData.PopulateColumns();  // Tao cot cho cac truong trong datatable
					//grvData.BestFitColumns();   // Tu dong dieu chinh kich thuoc cot  -- Ton nhieu tg
					grvData.Focus();
					for (int i = 0; i < dtt.Columns.Count; i++)
					{
						grvData.Columns[i].Caption = "F" + i.ToString();
						//dtt.Columns[i].ColumnName = "F" + i.ToString();
					}
					var test = grvData.Columns;
				}
				catch (Exception er) {
					TextUtils.ShowError(er);
					grdData.DataSource = null;
				}
			}
			else
            {
				try {
					DataTable dt = TextUtils.ExcelToDatatableNoHeader(btnBrowse.Text, cboSheet.SelectedValue.ToString());
					grdData.DataSource = dt;
					grvData.PopulateColumns();  // Tao cot cho cac truong trong datatable
					//grvData.BestFitColumns();   // Tu dong dieu chinh kich thuoc cot  -- Ton nhieu tg
					grvData.Focus();
				}
				catch (Exception er)
				{
					TextUtils.ShowError(er);
					grdData.DataSource = null;
				}
			}
		}



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
			txtRate.Text = "";
			int rowCount = grvData.RowCount;
			// Bat dau duyet theo tung dong Excel
			for (int i = 0; i < rowCount; i++) {
				try
				{
					if (i < 6) continue;
					progressBar1.Invoke((Action)(() => { progressBar1.Value = i - 2; }));
					txtRate.Invoke((Action)(() => { txtRate.Text = string.Format("{0}/{1}", i - 2, rowCount - 6); }));
					string _partCode = TextUtils.ToString(grvData.GetRowCellValue(i, "F2"));
					string _orderCode = TextUtils.ToString(grvData.GetRowCellValue(i, "F8"));

					// Kiem tra xem dong do' co du? thong tin hop le hay khong
					if (string.IsNullOrEmpty(_partCode) || string.IsNullOrEmpty(_orderCode)) {
						continue;
					}

					SonPlanModel sonPlanModel = new SonPlanModel();

					#region Set value
					sonPlanModel.DateExported = TextUtils.ToDate(grvData.GetRowCellValue(i, "F0").ToString());
					sonPlanModel.PartCode = _partCode;
					sonPlanModel.LotSize = TextUtils.ToInt(grvData.GetRowCellValue(i, "F3"));
					sonPlanModel.QtyPlan = TextUtils.ToInt(grvData.GetRowCellValue(i, "F4"));
					sonPlanModel.ProdDate = TextUtils.ToDate3(grvData.GetRowCellValue(i, "F5"));
					sonPlanModel.RealProdQty = TextUtils.ToInt(grvData.GetRowCellValue(i, "F6"));
					sonPlanModel.NG = TextUtils.ToInt(grvData.GetRowCellValue(i, "F7"));
					sonPlanModel.OrderCode = _orderCode;
					sonPlanModel.SaleCode = TextUtils.ToString(grvData.GetRowCellValue(i, "F9"));
					sonPlanModel.OP = TextUtils.ToInt(grvData.GetRowCellValue(i, "F10"));
					sonPlanModel.ShipTo = TextUtils.ToString(grvData.GetRowCellValue(i, "F11"));
					sonPlanModel.ShipVia = TextUtils.ToString(grvData.GetRowCellValue(i, "F12"));
					sonPlanModel.ConfirmCode = TextUtils.ToString(grvData.GetRowCellValue(i, "F13"));
					sonPlanModel.Note = TextUtils.ToString(grvData.GetRowCellValue(i, "F14"));
					sonPlanModel.WorkerCode = TextUtils.ToString(grvData.GetRowCellValue(i, "F15"));
					sonPlanModel.PrintedDate = TextUtils.ToDate3(grvData.GetRowCellValue(i, "F16"));
					#endregion

					// Kiem tra xem ma san pham/ma order da ton tai chua
					Expression exp1 = new Expression("PartCode", _partCode);
					Expression exp2 = new Expression("OrderCode", _orderCode);
					ArrayList arr = SonPlanBO.Instance.FindByExpression(exp1.And(exp2));
					if (arr.Count > 0)
					{
						for (int j = 0; j < arr.Count; j++)
						{
							sonPlanModel.ID = (arr[j] as SonPlanModel).ID;
							SonPlanBO.Instance.Update(sonPlanModel);
						}
					}
					else {
						sonPlanModel.ID = (int)SonPlanBO.Instance.Insert(sonPlanModel);
					}
				}
				catch (Exception er) {
					MessageBox.Show("Lỗi lưu dữ liệu tại dòng " + i + Environment.NewLine + er.ToString());
				}
			} 
		}
        private void frmImportExcel_Load(object sender, EventArgs e)
        {
			btnSave.Enabled = false;
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (backgroundWorker1.IsBusy)
			{
				backgroundWorker1.CancelAsync();
			}
			else
			{
				progressBar1.Minimum = 1;
				progressBar1.Maximum = grvData.RowCount - 6;
				txtRate.Text = "";
				start = DateTime.Now;
				enableControl(false);
				backgroundWorker1.RunWorkerAsync();
			}
		}

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			MessageBox.Show(start.ToString() + " - " + DateTime.Now.ToString());
			enableControl(true);
		}
    }
}
