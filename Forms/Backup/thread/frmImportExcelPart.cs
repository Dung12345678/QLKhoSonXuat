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
    public partial class frmImportExcelPart : _Forms
	{
        public frmImportExcelPart()
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

		private DataSet ReadData()
		{
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
			}); // ton nhieu thoi gian
				//toolStripStatusLabel1.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";


			return ds;
		}

		void enableControl(bool enable)
		{
			btnSave.Enabled = enable;
			grdData.Enabled = enable;
			cboSheet.Enabled = enable;
			btnBrowse.Enabled = enable;
		}
		public static IEnumerable<int> DistributeInteger(int total, int divider)
		{
			if (divider == 0)
			{
				yield return 0;
			}
			else
			{
				int rest = total % divider;
				double result = total / (double)divider;

				for (int i = 0; i < divider; i++)
				{
					if (rest-- > 0)
						yield return (int)Math.Ceiling(result);
					else
						yield return (int)Math.Floor(result);
				}
			}
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
					using (WaitDialogForm wait = new WaitDialogForm("", ""))
					{
						Task<DataSet> tasks = new Task<DataSet>(ReadData);  // Load method vao Task
						tasks.Start();                                      // Cho Task chay
																			//frmSonLoading.ShowSplashScreen();
						txtRate.Text = "Dang xu ly...";
						DataSet ds = await tasks;                           // Lay data tra ve tu task
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
			if (chkAutoCheck.Checked)
			{
				try
				{
					DataTable dtt = ds.Tables[cboSheet.SelectedIndex];

					for (int i = 0; i < dtt.Columns.Count; i++)
					{
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
				catch (Exception er)
				{
					TextUtils.ShowError(er);
					grdData.DataSource = null;
				}
			}
			else
			{
				try
				{
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
		long time;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
			txtRate.Text = "";
			int rowCount = grvData.RowCount;
			Stopwatch stopwatch = new Stopwatch();
			int markResult = 0;
			List<int> parts = DistributeInteger(rowCount, 3).ToList();
			List<int> marks = new List<int>();
            marks.Add(markResult);

			foreach (int j in parts) {
				markResult = markResult + j;
                marks.Add(markResult);
			}

			stopwatch.Start();

			Parallel.For(0, marks.Count-1, x => { 
				for (int i = marks[x]; i < marks[x+1]; i++)
				{
					try
					{
						if (i < 1) continue;	// Form du lieu bat dau tu dong 1
						progressBar1.Invoke((Action)(() => { progressBar1.Value = i; }));
						txtRate.Invoke((Action)(() => { txtRate.Text = string.Format("{0}/{1}", i, rowCount - 1); }));
						string _partCode = TextUtils.ToString(grvData.GetRowCellValue(i, "F0"));
						//string _orderCode = TextUtils.ToString(grvData.GetRowCellValue(i, "F8"));

						// Kiem tra xem dong do' co du? thong tin hop le hay khong
						if (string.IsNullOrEmpty(_partCode))
						{
							continue;
						}

						PartSonModel partSonModel = new PartSonModel();

						#region Set value
							if (grvData.Columns.Count < 3)
							{
								partSonModel.PartCode = _partCode;
								partSonModel.QuantityExporting = 0;
								partSonModel.QuantityAssembling = 0;
							}
							else {
								partSonModel.PartCode = _partCode;
								partSonModel.QuantityExporting = TextUtils.ToInt(grvData.GetRowCellValue(i, "F1"));
								partSonModel.QuantityAssembling = TextUtils.ToInt(grvData.GetRowCellValue(i, "F2"));
							}
						#endregion

						// Kiem tra xem ma san pham/ma order da ton tai chua
						Expression exp1 = new Expression("PartCode", _partCode);
						ArrayList arr = PartSonBO.Instance.FindByExpression(exp1);
						if (arr.Count > 0)
						{
							if (grvData.Columns.Count < 3)
								continue;
							else {
								for (int j = 0; j < arr.Count; j++)
								{
									partSonModel.ID = (arr[j] as PartSonModel).ID;
									PartSonBO.Instance.Update(partSonModel);
								}
							}
						}
						else
						{
							partSonModel.ID = (int)PartSonBO.Instance.Insert(partSonModel);
						}
					}
					catch (Exception er)
					{
						MessageBox.Show("Lỗi lưu dữ liệu tại dòng " + i + Environment.NewLine + er.ToString());
					}
				}
			});
			stopwatch.Stop();
			time = stopwatch.ElapsedMilliseconds;
			// Bat dau duyet theo tung dong Excel
		}

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			//MessageBox.Show(start.ToString() + " - " + DateTime.Now.ToString());
			MessageBox.Show(time.ToString());
			enableControl(true);
		}

        private void frmImportExcelPart_Load(object sender, EventArgs e)
        {
			btnSave.Enabled = false;
		}

        private void btnSave_Click_1(object sender, EventArgs e)
        {
			if (backgroundWorker1.IsBusy)
			{
				backgroundWorker1.CancelAsync();
			}
			else
			{
				progressBar1.Minimum = 1;
				progressBar1.Maximum = grvData.RowCount - 1;
				txtRate.Text = "";
				start = DateTime.Now;
				enableControl(false);
				backgroundWorker1.RunWorkerAsync();
			}
		}
    }
}
