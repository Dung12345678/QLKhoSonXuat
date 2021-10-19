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
    public partial class frmAddEditHistory : _Forms
    {
        public SONHistoryImExModel model = new SONHistoryImExModel();
       

        #region Method
        void LoadDataToForm() {
            txtPartCode.Text = model.PartCode;
            if (model.IsAssembled == 1) { 
                txtAsQuantity.Value = model.Quantity;
            }
            else
                txtExQuantity.Value = model.Quantity;
        }

        bool SaveData() {
            model.PartCode = txtPartCode.Text.Trim();
            if (model.IsAssembled == 1)
                model.Quantity = TextUtils.ToInt(txtAsQuantity.Value);
            else
                model.Quantity = TextUtils.ToInt(txtExQuantity.Value);
            try
            {
                SONHistoryImExBO.Instance.Update(model);
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
            if (model.IsAssembled == 1)
            {
                txtExQuantity.Enabled = false;
            }
            else {
                txtAsQuantity.Enabled = false;
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

        
    }
}
