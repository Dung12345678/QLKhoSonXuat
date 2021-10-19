using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.Business;
using BMS.Model;

namespace BMS
{
	public partial class frmProductListSON : _Forms
	{
		public frmProductListSON()
		{
			InitializeComponent();
			LoadListProducts();
			dtgvProducts.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
		}
		int prevRow;
		#region Method
		void LoadListProducts()
		{
			// Neu skipnumber = 0 thi store se tra ve toan bo danh sach sp
			DataTable dt = TextUtils.LoadDataFromSP("spLoadProductListPagination", "L", new string[] { "@skipnumber", "@passedRows" }, new object[] { 0, 1 });
			dtgvProducts.DataSource = dt;
		}
		#endregion



		#region Event
		private void btnExcel_Click(object sender, EventArgs e)
		{

		}

		private void dtgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void mnuMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		#endregion

		private void btnSearchProducts_Click(object sender, EventArgs e)
		{
			if (txbSearchProducts.Text != "")
			{
				string keyword = txbSearchProducts.Text;
				DataTable dataTable = TextUtils.LoadDataFromSP("spVietnameseSearch", "VS", new string[] { "@keyword" }, new object[] { keyword });
				dtgvProducts.DataSource = dataTable;

			}
			else
			{
				LoadListProducts();
			}
		}

		private void btnHistory_Click(object sender, EventArgs e)
		{
			frmPartImExHistory frm = new frmPartImExHistory();
			frm.ShowDialog();
		}

		private void btnCreatePart_Click(object sender, EventArgs e)
		{
			frmAddEditProduct form = new frmAddEditProduct(1);
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadListProducts();

				// Tu dong focus ve dong vua tao
				//gvPart.FocusedRowHandle = gvPart.RowCount - 1;
			}
		}

		// Sua thong tin san pham
		private void btnEditPart_Click(object sender, EventArgs e)
		{
			int id = TextUtils.ToInt(gvPart.GetFocusedRowCellValue(colID));

			//  Lay so dong da chon
			prevRow = gvPart.GetSelectedRows()[0];
			if (id == 0) return;
			PartSonModel model = (PartSonModel)PartSonBO.Instance.FindByPK(id);
			frmAddEditProduct form = new frmAddEditProduct(3); // Sua thong tin san pham
			form.partSonModel = model;
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadListProducts();
				//  Tu dong focus lai ve dong vua chon
				gvPart.FocusedRowHandle = prevRow;
			}
		}

		private void gvPart_DoubleClick(object sender, EventArgs e)
		{
			if (gvPart.RowCount > 0 && btnEditPart.Enabled == true)
			{
				btnEditPart_Click(null, null);
			}
		}

		private void btnImportPart_Click(object sender, EventArgs e)
		{
			frmImportPart form = new frmImportPart();
			if (form.ShowDialog() == DialogResult.OK)
			{
				LoadListProducts();
			}
		}

		/* private void btnExportPart_Click(object sender, EventArgs e)
		 {
			 int id = TextUtils.ToInt(gvPart.GetFocusedRowCellValue(colID));
			 if (id == 0) return;
			 PartSonModel model = (PartSonModel)PartSonBO.Instance.FindByPK(id);
			 frmAddEditProduct form = new frmAddEditProduct(4); // Sua thong tin san pham
			 form.partSonModel = model;
			 if (form.ShowDialog() == DialogResult.OK)
			 {
				 LoadListProducts();
			 }
		 }*/
		private void btnDelPart_Click(object sender, EventArgs e)
		{
			if (!gvPart.IsDataRow(gvPart.FocusedRowHandle))
				return;
			int strID = TextUtils.ToInt(gvPart.GetFocusedRowCellValue("ID"));
			string str = TextUtils.ToString(gvPart.GetFocusedRowCellValue("PartCode"));

			try
			{
				if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa linh kiện [{0}] không?", str), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					string query = string.Format("EXEC dbo.spDeletePart @partid = {0}", strID);
					int result = TextUtils.ToInt(TextUtils.ExcuteScalar(query));
					if (result != 0)
					{
						MessageBox.Show("Linh kiện này đã có lịch sử xuất/nhập nên không thể xóa được!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return;
					}
					else
					{
						LoadListProducts();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hệ thống!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			try
			{
				if (gvPart.RowCount > 0)
				{
					FolderBrowserDialog od = new FolderBrowserDialog();
					if (od.ShowDialog() == DialogResult.OK)
					{
						TextUtils.ExportExcel(gvPart, od.SelectedPath, string.Format("DanhSachSanPhamKhoSon_{0}", DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnImportEx_Click(object sender, EventArgs e)
		{
			frmImportExcelPart frm = new frmImportExcelPart();
			frm.ShowDialog();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				LoadListProducts();

			}
		}

		private void btnSonPlan_Click(object sender, EventArgs e)
		{
			frmSonPlan frm = new frmSonPlan();
			frm.ShowDialog();
		}

		private void frmProductListSON_Load(object sender, EventArgs e)
		{

		}
	}
}
