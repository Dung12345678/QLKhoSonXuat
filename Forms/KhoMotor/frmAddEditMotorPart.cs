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
	public partial class frmAddEditMotorPart : _Forms
	{
		public MotorPartListModel motorPart = new MotorPartListModel();
		private int type;

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


		public frmAddEditMotorPart(int type)
		{
			InitializeComponent();
			Type = type;
			if (Type == 1) {
				this.Text = "THÊM DANH MỤC LINH KIỆN";
			}
			if (Type == 2)
			{
				this.Text = "SỬA DANH MỤC LINH KIỆN";
				txbQuantity.Enabled = false;
			}
			if (Type == 3)
			{
				this.Text = "XUẤT LINH KIỆN";
				txbPartCode.Enabled = false;
				txbPartCode.ReadOnly = true;
			}
			if (Type == 4)
			{
				this.Text = "NHẬP LINH KIỆN";
				txbPartCode.Enabled = false;
				txbPartCode.ReadOnly = true;
			}
		}

		void LoadDataToForm() {
			txbPartCode.Text = motorPart.PartCode;
			txbDescription.Text = motorPart.Description;
			txbQuantity.Value = motorPart.Quantity;
		}

		private bool ValidateForm()
		{
			if (string.IsNullOrEmpty(txbPartCode.Text.Trim()))
			{
				MessageBox.Show("Xin hãy nhập mã linh kiện.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			else
			{
				if (Type == 1) {
					if (MotorPartListBO.Instance.CheckExist("PartCode", txbPartCode.Text.Trim())) { 
						MessageBox.Show("Mã linh kiện đã tồn tại!", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return false;
					}
				}
			}
			return true;
		}

		bool SaveData() {
			if (!ValidateForm()) {
				return false;
			}
			
			motorPart.PartCode = txbPartCode.Text.Trim();
			motorPart.Description = txbDescription.Text;
			motorPart.Quantity = TextUtils.ToInt(txbQuantity.Value);
			if (Type == 1)
				motorPart.CreatedDate = DateTime.Now;
			if (Type == 2)
				motorPart.ModifiedDate = DateTime.Now;

			try
			{
					if (motorPart.ID > 0)
					{
						TextUtils.ExcuteProcedure("spMotorUpdatePart",
								new string[] { "@id", "@partCode", "@description", "@quantity", "@modifiedDate" },
								new object[] { motorPart.ID, motorPart.PartCode, motorPart.Description, motorPart.Quantity, motorPart.ModifiedDate});
					}
					else {
						/*string sql = string.Format("INSERT dbo.MotorPartList ( PartCode, Quantity, Description, CreatedDate ) VALUES  ( '{0}', {1}, '{2}', '{3}' )", motorPart.PartCode, motorPart.Quantity, motorPart.Description, motorPart.CreatedDate);
						TextUtils.ExcuteSQL(sql);*/

						decimal exec = MotorPartListBO.Instance.Insert(motorPart);
					}
			}
			catch (Exception e) {
				return false;
			}
			return true;
		}

		private void frmAddEditMotorPart_Load(object sender, EventArgs e)
		{
			if (Type == 2)
				LoadDataToForm();
		}

		private void frmAddEditMotorPart_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;

		}

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			if (SaveData())
				this.DialogResult = DialogResult.OK;
		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				motorPart = new MotorPartListModel();
				LoadDataToForm();
			}
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
