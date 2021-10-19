using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmMotorHistoryImEx : _Forms
	{
		public frmMotorHistoryImEx()
		{
			InitializeComponent();
		}

		void LoadData() {
			int type = 2;
			if (rbAll.Checked)
			{
				type = 2;
			}
			if (rbImport.Checked)
			{
				type = 0;
			}
			if (rbExport.Checked)
			{
				type = 1;
			}
			string keyword = txbSearchHistory.Text;
			DataTable dataTable = TextUtils.LoadDataFromSP("spGetMotorHistoryByDate", "VS", new string[] { "@dateFrom", "@dateTo", "@keyword", "@filter" }, new object[] { dtpFrom.Value.ToString("yyyy/MM/dd HH:mm:ss")
										, dtpTo.Value.ToString("yyyy/MM/dd HH:mm:ss")
										, keyword
										, type
						   });
			dtgvMotorHistory.DataSource = dataTable;
		}
		private void btnSearchHistory_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void frmMotorHistoryImEx_Load(object sender, EventArgs e)
		{

			LoadData();
		}

		private void rbAll_CheckedChanged(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dtpFrom_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnSearchHistory_Click(null, null);
			}
		}
	}
}
