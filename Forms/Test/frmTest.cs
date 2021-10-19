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

namespace BMS
{
	public partial class frmTest : _Forms
	{
		public frmTest()
		{
			InitializeComponent();
		}

		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TextUtils.OpenChildForm(new frmProductListSON(), this);
		
		}

		private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frmMotorPartList frm = new frmMotorPartList();
			TextUtils.OpenChildForm(frm, this);
		
		}

		private void frmTest_Load(object sender, EventArgs e)
		{
			ribbonControl1.SelectedPage = ribbonPageHyp;
		}

		private void btnProductHyp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}
	}
}
