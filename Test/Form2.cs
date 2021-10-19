using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
	public partial class Form2 : Form
	{
		private int _ProgressValue;

		public int ProgressValue
		{
			get { return _ProgressValue; }
			set { 
				
				_ProgressValue = value;
				progressBar1.Invoke((Action)(() => { progressBar1.Value = _ProgressValue; }));
			}
		}

		public Form2()
		{
			InitializeComponent();
		}
	}
}
