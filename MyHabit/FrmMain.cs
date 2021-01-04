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
            FrmKiemTraBanThan frmKiemTraBanThan = new FrmKiemTraBanThan();
            this.Hide();
            frmKiemTraBanThan.ShowDialog();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
