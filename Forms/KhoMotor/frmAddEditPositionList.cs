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
	public partial class frmAddEditPositionList : _Forms
	{
		public MotorPositionListModel positionListModel = new MotorPositionListModel();
		/// <summary>
		/// Thêm = 1, Sửa = 2
		/// </summary>
		private int type;
		
		/// <summary>
		/// Thêm = 1, Sửa = 2
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

		public frmAddEditPositionList(int type)
		{
			InitializeComponent();
			Type = type;
			if (Type == 1)
			{
				this.Text = "THÊM VỊ TRÍ";
			}
			if (Type == 2)
			{
				this.Text = "SỬA VỊ TRÍ";
			}
			
		}

		void LoadDataToForm()
		{
			txbPositionCode.Text = positionListModel.PositionCode;
			txbDescription.Text = positionListModel.Description;
		}


		private bool ValidateForm()
		{
			if (string.IsNullOrEmpty(txbPositionCode.Text.Trim()))
			{
				MessageBox.Show("Xin hãy nhập mã vị trí.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}
			
			return true;
		}

		bool SaveData()
		{
			if (!ValidateForm())
			{
				return false;
			}

			positionListModel.PositionCode= txbPositionCode.Text.Trim();
			positionListModel.Description = txbDescription.Text;
			try
			{
				if (positionListModel.ID > 0)
				{
					TextUtils.ExcuteProcedure("spMotorUpdatePosition",
							new string[] { "@id", "@positionCode", "@description" },
							new object[] { positionListModel.ID, positionListModel.PositionCode, positionListModel.Description });
				}
				else
				{
					/*string sql = string.Format("INSERT dbo.MotorPartList ( PartCode, Quantity, Description, CreatedDate ) VALUES  ( '{0}', {1}, '{2}', '{3}' )", motorPart.PartCode, motorPart.Quantity, motorPart.Description, motorPart.CreatedDate);
					TextUtils.ExcuteSQL(sql);*/

					decimal exec = MotorPositionListBO.Instance.Insert(positionListModel);
				}
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
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
				positionListModel = new MotorPositionListModel();
				LoadDataToForm();
			}
		}

		private void frmAddEditPositionList_Load(object sender, EventArgs e)
		{
			LoadDataToForm();
		}

		private void frmAddEditPositionList_FormClosing(object sender, FormClosingEventArgs e)
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
