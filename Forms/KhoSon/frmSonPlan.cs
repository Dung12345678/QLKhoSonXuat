using BMS.Business;
using BMS.Model;
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
    public partial class frmSonPlan : _Forms
    {
        public frmSonPlan()
        {
            InitializeComponent();
            LoadDataWithDate();
            dtgvSonPlan.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
        }
        int prevRow;

        #region Method
        void LoadDataToForm() {
            string sql = "select ROW_NUMBER() OVER (ORDER BY ID) AS STT, * from SonPlan ORDER BY DateExported";
            DataTable dt = TextUtils.Select(sql);
            dtgvSonPlan.DataSource = dt;
        }

        SonPlanModel DataRowToSonPlanModel(DataRow row) {
            if (row != null)
            {
                SonPlanModel model = new SonPlanModel();
                model.ID = TextUtils.ToInt(row.ItemArray[1]);
                model.DateExported = TextUtils.ToDate2(row.ItemArray[2]);
                model.PartCode = TextUtils.ToString(row.ItemArray[3]);
                model.LotSize = TextUtils.ToInt(row.ItemArray[4]);
                model.QtyPlan = TextUtils.ToInt(row.ItemArray[5]);
                model.ProdDate = TextUtils.ToDate2(row.ItemArray[6]);
                model.RealProdQty = TextUtils.ToInt(row.ItemArray[7]);
                model.NG = TextUtils.ToInt(row.ItemArray[8]);
                model.OrderCode = TextUtils.ToString(row.ItemArray[9]);
                model.SaleCode = TextUtils.ToString(row.ItemArray[10]);
                model.OP = TextUtils.ToInt(row.ItemArray[11]);
                model.ShipTo = TextUtils.ToString(row.ItemArray[12]);
                model.ShipVia = TextUtils.ToString(row.ItemArray[13]);
                model.ConfirmCode = TextUtils.ToString(row.ItemArray[14]);
                model.Note = TextUtils.ToString(row.ItemArray[15]);
                model.WorkerCode = TextUtils.ToString(row.ItemArray[16]);
                model.PrintedDate = TextUtils.ToDate2(row.ItemArray[17]);
                return model;
            }
            else {
                return null;
            }
        }

        void LoadDataWithDate()
        {
            string keyword = txbSearch.Text;
            DataTable dataTable = TextUtils.LoadDataFromSP("spGetSonPlanByDate", "VS", new string[] { "@dateFrom", "@dateTo", "@keyword" }, new object[] { dtpFrom.Value.ToString("yyyy/MM/dd HH:mm:ss")
                                        , dtpTo.Value.ToString("yyyy/MM/dd HH:mm:ss")
                                        , keyword
                           });
            dtgvSonPlan.DataSource = dataTable;
        }
        #endregion


        #region Event
        /// <summary>
        /// All form events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportExcel_Click(object sender, EventArgs e)
		{
            frmImportExcel frm = new frmImportExcel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataWithDate();
            }
        }

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
            try
            {
                if (gvSonPlan.RowCount > 0)
                {
                    FolderBrowserDialog od = new FolderBrowserDialog();
                    if (od.ShowDialog() == DialogResult.OK)
                    {
                        TextUtils.ExportExcel(gvSonPlan, od.SelectedPath, string.Format("DanhSachKeHoachKhoSon_{0}", DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
		private void frmSonPlan_Load(object sender, EventArgs e)
		{

		}
		private void btnCreatePlan_Click(object sender, EventArgs e)
		{
            frmAddEditPlan frm = new frmAddEditPlan(1);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataWithDate();
                // Tu dong focus ve dong vua tao
                //gvSonPlan.FocusedRowHandle = gvSonPlan.RowCount - 1;
            }
        }

		private void btnEditPlan_Click(object sender, EventArgs e)
		{
            if (gvSonPlan.GetSelectedRows().Length != 0)
                prevRow = gvSonPlan.GetSelectedRows()[0];
            DataRow row = gvSonPlan.GetFocusedDataRow();
            if (row != null) {
                int strID = TextUtils.ToInt(gvSonPlan.GetFocusedRowCellValue("ID"));
                SonPlanModel model = (SonPlanModel)SonPlanBO.Instance.FindByPK(strID);
                frmAddEditPlan frm = new frmAddEditPlan(2);
                frm.sonPlanModel = model;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataWithDate();
                    //  Tu dong focus lai ve dong vua chon
                    if (gvSonPlan.GetSelectedRows().Length != 0)
                        gvSonPlan.FocusedRowHandle = prevRow;
                }
            }
        }

        private void btnDelPlan_Click(object sender, EventArgs e)
		{
            if (!gvSonPlan.IsDataRow(gvSonPlan.FocusedRowHandle))
                return;
            int strID = TextUtils.ToInt(gvSonPlan.GetFocusedRowCellValue("ID"));
            string str = TextUtils.ToString(gvSonPlan.GetFocusedRowCellValue("PartCode"));

            try
            {
                if (MessageBox.Show(String.Format("Bạn có chắc muốn xóa kế hoạch [{0}] không?", str), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SonPlanBO.Instance.Delete(strID);
                    LoadDataWithDate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

		private void gvSonPlan_DoubleClick(object sender, EventArgs e)
		{
            if (gvSonPlan.RowCount > 0 && btnEditPlan.Enabled == true) {
                btnEditPlan_Click(null, null);
            }
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
            // spGetSonPlanByDate
            LoadDataWithDate();
        }
		#endregion

		private void dtpFrom_KeyPress(object sender, KeyPressEventArgs e)
		{
            if (e.KeyChar == (char)13)
            {
                btnSearch_Click(null, null);
            }
        }

		private void dtpTo_KeyPress(object sender, KeyPressEventArgs e)
		{
            if (e.KeyChar == (char)13)
            {
                btnSearch_Click(null, null);
            }
        }
	}
}
