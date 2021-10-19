using System;
using System.Collections;
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
	public partial class frmMotorImExPart : _Forms
	{
		public MotorPartListModel motorPart = new MotorPartListModel();
	
		private int type;
		
		/// <summary>
		/// Xuất khẩu = 1, Nhập khẩu = 2
		/// </summary>
		public int Type
		{
			get
			{
				return type;
			}

			set
			{
				type = value;
			}
		}

		public frmMotorImExPart(int type)
		{
			InitializeComponent();
			Type = type;
			if (Type == 1)
			{
				this.Text = "XUẤT LINH KIỆN";
				cbPosition.Enabled = false;
			}
			if (Type == 2)
			{
				this.Text = "NHẬP LINH KIỆN";
			}
		}

		void LoadPosition() {
			DataTable dt = TextUtils.Select("Select * from MotorPositionList");
			cbPosition.Properties.DataSource = dt;
			cbPosition.Properties.DisplayMember = "PositionCode";
			cbPosition.Properties.ValueMember = "ID";
		}
		void LoadDataToForm()
		{
			txbPartCode.Text = motorPart.PartCode;
			txbQuantity.Value = motorPart.Quantity;
		}

		bool ValidateForm() {
			if (cbPosition.EditValue == null && type == 2)
			{
				MessageBox.Show("Vui lòng chọn vị trí!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			if (txbQuantity.Value <= 0 )
			{
				MessageBox.Show("Vui lòng nhập số lượng!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (type == 1 && txbQuantity.Value > motorPart.Quantity) {
				MessageBox.Show("Số lượng còn lại trong kho không đáp ứng được nhu cầu!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (MessageBox.Show(String.Format("Bạn có chắc muốn lưu không?"), TextUtils.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{ 
				return true;
			}
			else
			{
				return false;
			}
		}

		bool SaveData() {
			if (ValidateForm()) {
				try
				{
					if (type == 2)
					{
						motorPart.PartCode = txbPartCode.Text.Trim();
						TextUtils.ExcuteProcedure("spMotorImportPart",
									new string[] { "@partID", "@positionID", "@quantity", "@workerCode" },
									new object[] { motorPart.ID, TextUtils.ToInt(cbPosition.EditValue), txbQuantity.Value, txbWorkerCode.Text });
						return true;
					}
					if (type == 1) {
						TextUtils.ExcuteProcedure("spMotorExportPart",
									new string[] { "@partID", "@quantity", "@workerCode" },
									new object[] { motorPart.ID, txbQuantity.Value, txbWorkerCode.Text });
						return true;
					}
				}
				catch (Exception ex) {
					MessageBox.Show("Lưu thất bại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
					return false;
				}
			}
			return false;
		}

		private void frmMotorImExPart_Load(object sender, EventArgs e)
		{
			LoadPosition();
			LoadDataToForm();
		}

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			
			if (motorPart.ID != 0 && type == 2)
			{
				if (SaveData())
				{
					this.DialogResult = DialogResult.OK;
				}
			}
			else {
				if (MotorPartListBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim()))
				{
					ArrayList arrProduct = MotorPartListBO.Instance.FindByAttribute("PartCode", txbPartCode.Text.Trim());
					MotorPartListModel model = arrProduct[0] as MotorPartListModel;
					motorPart.ID = model.ID;
					motorPart.Quantity = model.Quantity;
					if (SaveData())
					{
						this.DialogResult = DialogResult.OK;
					}
				}
				else
				{
					MessageBox.Show("Mã linh kiện không tồn tại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
		}

	

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (motorPart.ID != 0 && type == 2)
			{
				if (SaveData())
				{
					motorPart = new MotorPartListModel();
					LoadDataToForm();
				}
			}
			else
			{
				if (MotorPartListBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim()))
				{
					ArrayList arrProduct = MotorPartListBO.Instance.FindByAttribute("PartCode", txbPartCode.Text.Trim());
					MotorPartListModel model = arrProduct[0] as MotorPartListModel;
					motorPart.ID = model.ID;
					motorPart.Quantity = model.Quantity;
					if (SaveData())
					{
						motorPart = new MotorPartListModel();
						LoadDataToForm();
					}
				}
				else
				{
					MessageBox.Show("Mã linh kiện không tồn tại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
		}

		private void frmMotorImExPart_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveClose_Click(null, null);
		}

		private void catVaThemOiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}
	}
}
