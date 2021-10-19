using BMS.Business;
using BMS.Model;
using BMS.Utils;
using DevExpress.XtraCharts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.IO;

namespace BMS
{
	public partial class frmImportPart : _Forms
	{
		SonPlanModel _sonPlanModel = new SonPlanModel();
		string _pathFileConfigUpdate = Path.Combine(Application.StartupPath, "ConfigUpdate.txt");
		string _pathFolderUpdate = "";
		string _pathUpdateServer = "";
		string _pathFileVersion = "";
		string _pathError = Path.Combine(Application.StartupPath, "Errors");
		int check;
		DataSet dataSet;

		public frmImportPart()
		{
			InitializeComponent();
			txbWorkerCode.Focus();

		}

		private void frmImportPart_Load(object sender, EventArgs e)
		{
			//tableLayoutPanel4.SetColumnSpan(cboType, 3);
			//LoadCD();
			LoadDataToChart();
			timer1.Enabled = true;

			DocUtils.InitFTPQLSX();
			//Check update version
			//updateVersion();
			txbWorkerCode.Focus();
		}
		//void LoadCD()
		//{
		//	DataTable dt = TextUtils.Select("SELECT * FROM [ShiStock].[dbo].[SonStep]");
		//	cboCD.DataSource = dt;
		//	cboCD.DisplayMember = "SonStepCode";
		//	cboCD.ValueMember = "ID";
		//}
		void updateVersion()
		{
			if (!File.Exists(_pathFileConfigUpdate)) return;
			try
			{
				string[] lines = File.ReadAllLines(_pathFileConfigUpdate);
				if (lines == null) return;
				if (lines.Length < 2) return;

				string[] stringSeparators = new string[] { "||" };
				string[] arr = lines[1].Split(stringSeparators, 4, StringSplitOptions.RemoveEmptyEntries);

				if (arr == null) return;
				if (arr.Length < 4) return;

				_pathFolderUpdate = Path.Combine(Application.StartupPath, arr[1].Trim());
				_pathUpdateServer = arr[2].Trim();
				_pathFileVersion = Path.Combine(Application.StartupPath, arr[3].Trim());

				if (!Directory.Exists(_pathError))
				{
					Directory.CreateDirectory(_pathError);
				}
				if (!Directory.Exists(_pathFolderUpdate))
				{
					Directory.CreateDirectory(_pathFolderUpdate);
				}
				if (!File.Exists(_pathFileVersion))
				{
					File.Create(_pathFileVersion);
					File.WriteAllText(_pathFileVersion, "1");
				}
				int currentVerion = TextUtils.ToInt(File.ReadAllText(_pathFileVersion).Trim());
				string[] listFileSv = DocUtils.GetFilesList(_pathUpdateServer);
				if (listFileSv == null) return;
				if (listFileSv.Length == 0) return;

				List<string> lst = listFileSv.ToList();
				lst = lst.Where(o => o.Contains(".zip")).ToList();
				int newVersion = lst.Max(o => TextUtils.ToInt(Path.GetFileNameWithoutExtension(o)));

				if (newVersion != currentVerion)
				{
					Process.Start(Path.Combine(Application.StartupPath, "UpdateVersion.exe"));
				}
			}
			catch
			{
				MessageBox.Show("Can't connect to server!");
				return;
			}
		}
		System.Timers.Timer _timer;
		#region Method
		bool SaveData()
		{
			if (cboType.Text == "")
			{
				MessageBox.Show("Bạn chưa chọn loại hàng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (MessageBox.Show(String.Format("Bạn có chắc muốn lưu không?"), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (txbQuantity.Value > 0)
				{
					if (PartSonBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim()))
					{

					}
					else
					{
						MessageBox.Show("Mã linh kiện không tồn tại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return false;

						////Mã linh kiện không tồn tại thì insert vào bảng PartSonBO
						//PartSonModel partSonModel = new PartSonModel();
						//partSonModel.PartCode = txbPartCode.Text.Trim();
						//partSonModel.QuantityAssembling = 0;
						//partSonModel.QuantityExporting = 0;
						//partSonModel.Description = "Insert trên kho sơn";
						//int IDPartSon = TextUtils.ToInt(PartSonBO.Instance.Insert(partSonModel));
					}
					int type;
					//if (cboType.Text == "Xuất khẩu")
					//	type = 1;
					//else type = 0; // lap rap
					type = cboType.SelectedIndex;
					SONHistoryImExModel sONHistoryImExModel = new SONHistoryImExModel();
					Expression exp1 = new Expression("OrderCode", txbOrderCode.Text.Trim());
					Expression exp2 = new Expression("PartCode", txbPartCode.Text.Trim());
					Expression exp3 = new Expression("IsExported", 1);//Xuất linh kiện
					ArrayList arr = SONHistoryImExBO.Instance.FindByExpression(exp1.And(exp2).And(exp3));
					if (arr.Count > 0)
					{
						//Update vào bảng History khi nhập sai số lượng sơn nhập lại sẽ update vào dòng cũ
						sONHistoryImExModel = (SONHistoryImExModel)arr[0];
						sONHistoryImExModel.Quantity = TextUtils.ToInt(txbQuantity.Value);
						ArrayList arrPartSon = PartSonBO.Instance.FindByExpression(exp2);
						if (arrPartSon.Count > 0)
						{
							PartSonModel partSonModel = new PartSonModel();
							partSonModel = (PartSonModel)arrPartSon[0];
							//Hàng xuất khẩu
							if (sONHistoryImExModel.IsAssembled == 0)
							{
								partSonModel.QuantityExporting = partSonModel.QuantityExporting + TextUtils.ToInt(txbCurrentQuantity.Text.Trim()) - TextUtils.ToInt(txbQuantity.Text.Trim());
							}
							else//Hàng lắp ráp
							{
								partSonModel.QuantityAssembling = partSonModel.QuantityAssembling + TextUtils.ToInt(txbCurrentQuantity.Text.Trim()) - TextUtils.ToInt(txbQuantity.Text.Trim());
							}
							PartSonBO.Instance.Update(partSonModel);
						}
						SONHistoryImExBO.Instance.Update(sONHistoryImExModel);
					}
					else
					{
						//Insert vào bảng History
						TextUtils.ExcuteProcedure("spExportPartXuatKho",
									new string[] { "@partCode", "@orderCode", "@quantity", "@workerCode", "@partType" },
									new object[] { txbPartCode.Text.Trim(), txbOrderCode.Text.Trim(), (int)txbQuantity.Value, txbWorkerCode.Text, type });
					}
					//Check trong Kế hoạch sơn nếu có thì update số lượng vào 
					//ArrayList orderCode = SonPlanBO.Instance.FindByAttribute("OrderCode", txbOrderCode.Text.Trim());
					//if (orderCode.Count > 0)
					//{
					//	_sonPlanModel = (SonPlanModel)SonPlanBO.Instance.FindByAttribute("OrderCode", txbOrderCode.Text.Trim())[0];
					//	if (_sonPlanModel.ID > 0)
					//	{
					//		_sonPlanModel.ProdDate = DateTime.Now;
					//		_sonPlanModel.RealProdQty = TextUtils.ToInt(txbQuantity.Value);
					//		if (_sonPlanModel.QtyPlan <= _sonPlanModel.RealProdQty)
					//		{
					//			_sonPlanModel.Status = 1;
					//		}
					//		else
					//		{
					//			_sonPlanModel.Status = 0;
					//		}
					//		SonPlanBO.Instance.Update(_sonPlanModel);
					//	}
					//}
					return true;
				}
				else
				{
					MessageBox.Show("Vui lòng nhập số lượng!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
					return false;
				}

			}
			else return false;
		}
		void LoadDataToChart()
		{
			try
			{
				//string sql = "SELECT * FROM dbo.SONHistoryImEx WHERE DateImEx <= DATEADD(DD, 1, CAST(CURRENT_TIMESTAMP AS DATE)) AND DateImEx > DATEADD(DD, -30, CAST(CURRENT_TIMESTAMP AS DATE))";
				int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
				DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 1);
				DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, days, 23, 59, 59);

				DataTable dt = TextUtils.LoadDataFromSP("spGetSonPartExportDataByDate", "A", new string[] { "@StartDate", "@EndDate" }, new object[] { startDate, endDate });
				DataTable table = new DataTable();
				DataRow row = null;
				table.Columns.Add("Day", typeof(string));
				table.Columns.Add("Quantity", typeof(int));

				for (int i = 1; i <= days; i++)
				{
					row = table.NewRow();
					int qty = 0;
					DataRow[] arr = dt.Select("CDay = " + i);
					if (arr.Length > 0)
					{
						qty = TextUtils.ToInt(arr[0]["Quantity"]);
					}

					row["Day"] = i + "/" + DateTime.Now.Month;
					row["Quantity"] = qty;
					table.Rows.Add(row);
				}


				//  Chong' timer khi refresh se chay tren 1 luong rieng biet nen se gay loi Index of out bound
				chartControl2.Invoke((MethodInvoker)delegate
				{
					chartControl2.Series[0].DataSource = table;
					chartControl2.Series[0].ArgumentScaleType = ScaleType.Auto;
					chartControl2.Series[0].ArgumentDataMember = "Day";
					chartControl2.Series[0].ValueScaleType = ScaleType.Numerical;
					chartControl2.Series[0].ValueDataMembers.AddRange(new string[] { "Quantity" });
				});
			}
			catch (Exception)
			{

			}


		}
		#endregion


		#region Event

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("AAAA");
			if (SaveData())
			{
				LoadDataToChart();
				this.DialogResult = DialogResult.OK;
			}
		}
		private void frmImportPart_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Dispose();
		}
		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				txbPartCode.Text = "";
				txbOrderCode.Text = "";
				txbCurrentQuantity.Text = "";
				txtQtyPlan.Text = "";
				txbQuantity.Value = 0;
				LoadDataToChart();
				txbOrderCode.Focus();
			}
		}

		private void txbOrderCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				try
				{
					//cboType.Text = "";
					txbCurrentQuantity.Text = "";
					txbPartCode.Text = "";
					dataSet = TextUtils.GetListDataFromSP("spCheckSonPlan", "a", new string[] { "@OrderCode" }, new object[] { txbOrderCode.Text.Trim() });

					if (dataSet.Tables[0].Rows.Count > 0)
					{
						if (cboType.SelectedIndex == 1)
						{
							//Thông báo Order có trong kế hoạch loại hàng lắp ráp khi check note là lắp ráp
							WarningForm frm = new WarningForm();
							frm.LBTieuDe = $"ORDER CÓ TRONG KẾ HOẠCH";
							frm.LB = $"Chọn lại loại hàng Lắp ráp";
							frm.ShowDialog();
						}
						txbPartCode.Focus();
						txbPartCode.SelectAll();

					}
					else if (dataSet.Tables[1].Rows.Count > 0)
					{
						//check =1 lắp ráp , = 2 là xuất khẩu , =0 là lắp ráp
						if (cboType.SelectedIndex == 0)
						{
							//Thông báo Order có trong kế hoạch loại hàng xuất khẩu
							WarningForm frm = new WarningForm();
							frm.LBTieuDe = $"ORDER CÓ TRONG KẾ HOẠCH";
							frm.LB = $"Chọn lại loại hàng Xuất khẩu";
							frm.ShowDialog();
						}
						string str = txbOrderCode.Text.Trim();
						ArrayList arrProduct = SonPlanBO.Instance.FindByAttribute("OrderCode", str);
						SonPlanModel model = arrProduct[0] as SonPlanModel;
						txbPartCode.Text = model.PartCode;
						txtQtyPlan.Text = TextUtils.ToString(model.QtyPlan);
						txbPartCode_KeyPress(new object(), new KeyPressEventArgs((char)13));
					}
					else
					{
						if (cboType.SelectedIndex == 1)
						{
							//Thông báo Order không có trong kế hoạch loại hàng lắp ráp
							WarningForm frm = new WarningForm();
							frm.LBTieuDe = $"ORDER KHÔNG CÓ TRONG KẾ HOẠCH";
							frm.LB = $"Chọn lại loại hàng Lắp ráp";
							frm.ShowDialog();
						}
						txbPartCode.Focus();
						txbPartCode.SelectAll();
					}


				}
				catch (Exception ex)
				{
				}
			}
		}
		private void txbPartCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				try
				{
					int Quantity = TextUtils.ToInt(TextUtils.ExcuteScalar($"SELECT Quantity FROM[ShiStock].[dbo].[SONHistoryImEx] WHERE OrderCode =N'{txbOrderCode.Text.Trim()}' AND PartCode = N'{txbPartCode.Text.Trim()}' AND IsExported='1' "));
					txbCurrentQuantity.Text = TextUtils.ToString(Quantity);
					if (Quantity > 0)
					{
						//Hiển thị đã xuất thông báo Order Đã xuất Sửa or Hủy
						frmSaveOK frm = new frmSaveOK();
						if (frm.ShowDialog() == DialogResult.Cancel)
						{
							txbPartCode.Text = "";
							txbOrderCode.Text = "";
							txbCurrentQuantity.Text = "";
							txtQtyPlan.Text = "";
							txbQuantity.Value = 0;
							cboType.Text = "";
							txbOrderCode.Focus();
							txbOrderCode.SelectAll();
							return;
						}
					}
					//string query = string.Format("SELECT ISNULL((SELECT SUM(Quantity) FROM dbo.SONHistoryImEx WHERE PartCode = '{0}' AND DateImEx >= CAST(CURRENT_TIMESTAMP AS DATE) AND DateImEx < DATEADD(DD, 1, CAST(CURRENT_TIMESTAMP AS DATE))), -1)", txbPartCode.Text.Trim());
					string query = string.Format("SELECT ISNULL((SELECT SUM(Quantity) FROM dbo.SONHistoryImEx WHERE OrderCode = N'{0}'), -1)", txbOrderCode.Text.Trim());
					int quantity = (int)TextUtils.ExcuteScalar(query);
					if (quantity == -1)
					{
						txbQuantity.Focus();
						txbQuantity.Select(0, txbQuantity.Text.Length);
						txbCurrentQuantity.Text = "0";
					}
					else
					{
						txbQuantity.Focus();
						txbQuantity.Select(0, txbQuantity.Text.Length);
						//txbCurrentQuantity.Text = quantity.ToString();
					}

				}
				catch (Exception er)
				{

				}
			}
		}

		#endregion

		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			LoadDataToChart();
			//label1.Invoke((MethodInvoker)delegate {
			//     var rnd = new Random();
			//     label1.Text = rnd.Next().ToString();
			//     timer1.Enabled = true;
			// });

			timer1.Enabled = true;
		}

		private void txbWorkerCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
				cboType.Focus();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}
		private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnSave.Focus();
			}
		}

		private void cboType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (txbOrderCode.Text.Trim() == "") return;
			dataSet = TextUtils.GetListDataFromSP("spCheckSonPlan", "a", new string[] { "@OrderCode" }, new object[] { txbOrderCode.Text.Trim() });
			if (dataSet.Tables[0].Rows.Count > 0)
			{
				if (cboType.SelectedIndex == 1)
				{
					//Thông báo Order có trong kế hoạch loại hàng lắp ráp khi check note là lắp ráp
					WarningForm frm = new WarningForm();
					frm.LBTieuDe = $"ORDER CÓ TRONG KẾ HOẠCH";
					frm.LB = $"Chọn lại loại hàng Lắp ráp";
					frm.ShowDialog();
				}
				txbPartCode.Focus();
				txbPartCode.SelectAll();

			}
			else if (dataSet.Tables[1].Rows.Count > 0)
			{
				//check =1 lắp ráp , = 2 là xuất khẩu , =0 là lắp ráp
				if (cboType.SelectedIndex == 0)
				{
					//Thông báo Order có trong kế hoạch loại hàng xuất khẩu
					WarningForm frm = new WarningForm();
					frm.LBTieuDe = $"ORDER CÓ TRONG KẾ HOẠCH";
					frm.LB = $"Chọn lại loại hàng Xuất khẩu";
					frm.ShowDialog();
				}
				string str = txbOrderCode.Text.Trim();
				ArrayList arrProduct = SonPlanBO.Instance.FindByAttribute("OrderCode", str);
				SonPlanModel model = arrProduct[0] as SonPlanModel;
				txbPartCode.Text = model.PartCode;
				txtQtyPlan.Text = TextUtils.ToString(model.QtyPlan);
				txbPartCode_KeyPress(new object(), new KeyPressEventArgs((char)13));
			}
			else
			{
				if (cboType.SelectedIndex == 1)
				{
					//Thông báo Order không có trong kế hoạch loại hàng lắp ráp
					WarningForm frm = new WarningForm();
					frm.LBTieuDe = $"ORDER KHÔNG CÓ TRONG KẾ HOẠCH";
					frm.LB = $"Chọn lại loại hàng Lắp ráp";
					frm.ShowDialog();
				}
				txbPartCode.Focus();
				txbPartCode.SelectAll();
			}

		}

		private void txbWorkerCode_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txbWorkerCode.Text.Trim()))
			{
				txbWorkerCode.BackColor = Color.FromArgb(255, 192, 255);
			}
			else
			{
				txbWorkerCode.BackColor = Color.White;
			}
		}

		private void txbOrderCode_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txbOrderCode.Text.Trim()))
			{
				txbOrderCode.BackColor = Color.FromArgb(255, 192, 255);
			}
			else
			{
				txbOrderCode.BackColor = Color.White;
			}
		}

		private void txbPartCode_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txbPartCode.Text.Trim()))
			{
				txbPartCode.BackColor = Color.FromArgb(255, 192, 255);
			}
			else
			{
				txbPartCode.BackColor = Color.White;
			}
		}

		private void cboType_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txbPartCode.Text.Trim()))
			{
				txbPartCode.BackColor = Color.FromArgb(255, 192, 255);
			}
			else
			{
				txbPartCode.BackColor = Color.White;
			}
		}

		private void txtQtyPlan_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txbPartCode.Text.Trim()))
			{
				txbPartCode.BackColor = Color.FromArgb(255, 192, 255);
			}
			else
			{
				txbPartCode.BackColor = Color.White;
			}
		}

		private void txbCurrentQuantity_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txbPartCode.Text.Trim()))
			{
				txbPartCode.BackColor = Color.FromArgb(255, 192, 255);
			}
			else
			{
				txbPartCode.BackColor = Color.White;
			}
		}

		//private void cboCD_TextChanged(object sender, EventArgs e)
		//{
		//	if (string.IsNullOrWhiteSpace(cboCD.Text.Trim()))
		//	{
		//		cboCD.BackColor = Color.FromArgb(255, 192, 255);
		//	}
		//	else
		//	{
		//		cboCD.BackColor = Color.White;
		//	}
		//}

		//private void cboCD_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	// hiển thị biểu đồ lịch sử theo công đoạn
		//	LoadDataToChart();
		//}
	}
}
