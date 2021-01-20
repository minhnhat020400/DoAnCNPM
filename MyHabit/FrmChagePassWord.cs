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
    public partial class FrmChagePassWord : Form
    {
        public FrmChagePassWord()
        {
            InitializeComponent();
        }
        bool timTK(string ten)
        {
            return true;
        }
        bool checkThongTin()
        {
            
            if (timTK(tbName.Text) == false)
            {
                // không tìm thấy tên thì hiệm thông báo

                MessageBox.Show("không tìm thấy tài khoản của bạn trong hệ thống", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
           else if (tbPass.Text != tbRePass.Text)
            {
                // 2 password ko khớp sẽ không cho đk và trả về false
                MessageBox.Show("mật khẩu không khớp nhau", "kiểm tra lại mật khẩu", MessageBoxButtons.OK);
                return false;
            }
            //thoả đk sẽ gọi hàm đăng ký
            else return true;
        }
        void doiMK(string name, string pass, string repass)
        {
            MessageBox.Show("ok");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //nếu ko có lỗi thì chổi mật khẩu
            if (checkThongTin() == true)
            {
                doiMK(tbName.Text, tbPass.Text, tbRePass.Text);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }
    }
}
