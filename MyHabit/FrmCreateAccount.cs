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
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount()
        {
            InitializeComponent();
        }
        bool timTK()// trả lại kết quả là đúng nếu bị trùng tên
        {
            return false;
        }
        bool checkThongTin()
        {
            //
            if (timTK() == true)
            {
                //nếu trùng tên thì xuất ra thông báo và trả về false 

                MessageBox.Show("tên tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK);
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
        private void dangky()
        {
            MessageBox.Show("dk ok");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkThongTin() == true)
            {
                dangky();
            }

        }

        private void btBack_Click(object sender, EventArgs e)
        {

             this.Hide();

        }
    }
}
