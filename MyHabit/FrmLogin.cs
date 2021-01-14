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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // this.TopMost = true;
            // this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void btGetIn_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCreateAcc_Click(object sender, EventArgs e)
        {
            FrmCreateAccount  createAccount= new FrmCreateAccount();
            this.Hide();
            createAccount.Show();
        }

        private void btChagePass_Click(object sender, EventArgs e)
        {
            FrmChagePassWord frmChagePassWord = new FrmChagePassWord();
            frmChagePassWord.ShowDialog();
        }
    }
}
