using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMS
{
	public partial class WarningForm : _Forms
	{
		public string LB;
		public string LBTieuDe;
		public WarningForm()
		{
			InitializeComponent();
		}

		private void WarningForm_Load(object sender, EventArgs e)
		{
			label1.Text = LB;
			LBLTIEUDE.Text = LBTieuDe;
			if (LBLTIEUDE.Text == "")
			{
				LBLTIEUDE.Visible = false;
				label1.Size = new Size(869, 302);
				label1.Location = new System.Drawing.Point(4, 6);
				label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				
			}


			textBox1.Focus();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnClose_Click(null, null);
			}
		}
	}
}
