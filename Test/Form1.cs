using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int count = 0;
		private BackgroundWorker backgroundWorker = null;
		Form2 form2 = null;
		private void DoWork(object sender, DoWorkEventArgs e)
		{
			
			do
			{
				/*form2 = new Form2();
				form2.Show();*/
				//frmSonLoading.ShowSplashScreen();
				backgroundWorker.ReportProgress(count);
				form2.ProgressValue = count;
				count += 1;
				Thread.Sleep(100);
			} while (count<=100);
		}

		public void ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.progressBar1.Value = e.ProgressPercentage;
		}
		public void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Cursor = Cursors.Default;
			button1.Enabled = true;
			form2.Close();
		}

		// Nếu gọi lệnh mở form ở đây thì form loading sẽ được mở trên cùng 1 tiến trình với BackgroundWorker
		// do đó khi chúng ta gọi lệnh form close thì lệnh mới được phép chạy do lệnh khởi tạo/mở và đóng cùng trên
		// một tiến trình	(do BGW DoWork với BGW RunWorkerComplete chạy trên 2 thread khác nhau)

		// Proof: https://stackoverflow.com/questions/46209741/how-does-backgroundworker-decide-on-which-thread-to-run-the-runworkercompleted-h

		// Còn nếu chúng ta ném vào DoWork thì dù có dùng delegate, chương trình cũng không biết được thread nào chứa lệnh khởi tạo
		// để hủy (do có 2 thread đang chạy là DoWork và thread Application chính), do đó chương trình sẽ gây lỗi
		private void button1_Click(object sender, EventArgs e)
		{
			form2 = new Form2();
			form2.Show();
			count = 0;
			this.Cursor = Cursors.WaitCursor;
			button1.Enabled = false;
			backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += DoWork;
			backgroundWorker.ProgressChanged += ProgressChanged;
			backgroundWorker.RunWorkerCompleted += RunWorkerCompleted;
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.RunWorkerAsync();
		}
	}
}
