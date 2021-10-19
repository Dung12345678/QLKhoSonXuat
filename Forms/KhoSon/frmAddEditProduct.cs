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
    public partial class frmAddEditProduct : _Forms
    {
        // Them san pham type = 1, Nhap them so luong type = 2, Sua thong tin san pham type = 3
        public PartSonModel partSonModel = new PartSonModel();
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

        public frmAddEditProduct(int typeEvent)
        {
            InitializeComponent();
            Type = typeEvent;
            switch (typeEvent) {
                case 1:
                    txtPartCode.ReadOnly = false;
                    txtPartDescription.ReadOnly = false;
                    txtPartName.ReadOnly = false;
                    txtExQuantity.Enabled = false;
                    txtAsQuantity.Enabled = false;
                    this.Text = "Thêm danh mục linh kiện";

                    break;
                case 2:
                    txtPartCode.ReadOnly = true;
                    txtPartDescription.ReadOnly = true;
                    txtPartName.ReadOnly = true;
                    this.Text = "Nhập kho";

                    break;
                case 3:
                    this.Text = "Chỉnh sửa thông tin linh kiện";
                    break;
                case 4:
                    txtPartCode.ReadOnly = true;
                    txtPartDescription.ReadOnly = true;
                    txtPartName.ReadOnly = true;
                    this.Text = "Xuất kho";
                    break;
            }

        }

        #region Method
        void LoadDataToForm() {
            txtPartCode.Text = partSonModel.PartCode;
            txtPartName.Text = partSonModel.PartName;
            txtPartDescription.Text = partSonModel.Description;
            txtExQuantity.Value = partSonModel.QuantityExporting;
            txtAsQuantity.Value = partSonModel.QuantityAssembling;
        }

        void ClearForm() {
            txtPartCode.Text = "";
            txtPartName.Text = "";
            txtPartDescription.Text = "";
            txtExQuantity.Value = 0;
            txtAsQuantity.Value = 0;
        }

        private bool ValidateForm() {
            if (txtPartCode.Text.Trim() == "")
            {
                MessageBox.Show("Xin hãy nhập mã linh kiện.", TextUtils.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;

        }

        bool SaveData() {
            if (!ValidateForm()) {
                return false;
            }
            partSonModel.PartCode = txtPartCode.Text.Trim();
            partSonModel.PartName = txtPartName.Text.Trim();
            partSonModel.Description = txtPartDescription.Text.Trim();
            partSonModel.QuantityExporting = TextUtils.ToInt(txtExQuantity.Value);
            partSonModel.QuantityAssembling = TextUtils.ToInt(txtAsQuantity.Value);

            try
            {
                
                switch (Type)
                {
                    case 1:
                        if (!PartSonBO.Instance.CheckExist("PartCode", partSonModel.PartCode))
                        {
                            int test = (int)PartSonBO.Instance.Insert(partSonModel);
                        }
                        else {
                            MessageBox.Show("Mã linh kiện đã tồn tại !!");
                            return false;
                        }
                        break;
                    case 2:
                        TextUtils.ExcuteProcedure("spImportPart",
                            new string[] { "@id", "@partCode", "@partName", "@description", "@quantityExporting", "@quantityAssembling" },
                            new object[] { partSonModel.ID, partSonModel.PartCode, partSonModel.PartName, partSonModel.Description, partSonModel.QuantityExporting, partSonModel.QuantityAssembling });
                        break;
                    case 3:
                        TextUtils.ExcuteProcedure("spUpdatePart",
                            new string[] { "@id", "@partCode", "@partName", "@description", "@quantityExporting", "@quantityAssembling" },
                            new object[] { partSonModel.ID, partSonModel.PartCode, partSonModel.PartName, partSonModel.Description, partSonModel.QuantityExporting, partSonModel.QuantityAssembling });
                        break;
                    case 4:
                        TextUtils.ExcuteProcedure("spExportPart",
                            new string[] { "@id", "@partCode", "@partName", "@description", "@quantityExporting", "@quantityAssembling" },
                            new object[] { partSonModel.ID, partSonModel.PartCode, partSonModel.PartName, partSonModel.Description, partSonModel.QuantityExporting, partSonModel.QuantityAssembling });
                        break;
                }
            }
            catch (Exception e) {
                return false;
            }
            
            return true;
        }
        #endregion



        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            if (Type == 2 || Type == 4) {
                txtExQuantity.Value = 0;
                txtAsQuantity.Value = 0;
            }
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (SaveData()) {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void frmAddEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                 PartSonModel partSonModel = new PartSonModel();
               /* LoadDataToForm();*/
                ClearForm();
                txtPartCode.ReadOnly = false;
                txtPartDescription.ReadOnly = false;
                txtPartName.ReadOnly = false;
                txtExQuantity.ReadOnly = false;
                txtAsQuantity.ReadOnly = false;
                this.Text = "Thêm danh mục linh kiện";
                Type = 1;
            }
        }

		private void catVaThemOiToolStripMenuItem_Click(object sender, EventArgs e)
		{
            btnSaveNew_Click(null, null);

        }

		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
            btnSaveClose_Click(null, null);

        }
	}
}
