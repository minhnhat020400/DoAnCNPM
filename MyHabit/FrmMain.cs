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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMyInFo frm = new FrmMyInFo();
            this.Hide();
            frm.ShowDialog();
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
            FrmCheck frm = new FrmCheck();
            this.Hide();
            frm.ShowDialog();
        }

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
