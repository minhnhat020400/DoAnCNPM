using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHabit
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

       
        #region NÚT ĐIỀU KHIỂN
        private void button1_Click(object sender, EventArgs e)
        {
            FormThongKetuan formThongKetuan = new FormThongKetuan();
            this.Hide();
            formThongKetuan.ShowDialog();
        }
        private void thoátTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            FrmToMo frm = new FrmToMo();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnMy_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            FrmKiemTraBanThan frmKiemTraBanThan = new FrmKiemTraBanThan();
            this.Hide();
            frmKiemTraBanThan.ShowDialog();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
=======
            FrmCheck frm = new FrmCheck();
            this.Hide();
            frm.ShowDialog();
        }
>>>>>>> 6378511340614ed5f45e4220f5f354d60ddd44de

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBMI frm = new FrmBMI();
            this.Hide();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormThongKetuan frm = new FormThongKetuan();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
