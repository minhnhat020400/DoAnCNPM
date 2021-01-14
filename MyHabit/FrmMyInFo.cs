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
    public partial class FrmMyInFo : Form
    {
        public FrmMyInFo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }
        private bool check_number()
        {
            float a;
            float b;
            // tạo biến trya , đúng nếu có thể ép kiểu chiều cao qua số và đổ dữ liệu số vào biến a
            bool trya = float.TryParse(tbChieuCao.Text, out a);
            // tạo biến tryb , đúng nếu có thể ép kiểu cân nặng qua số và đổ dữ liệu số vào biến b
            bool tryb = float.TryParse(tbCanNang.Text, out b);
            if (!trya || !tryb)

            {
                if (tbChieuCao.Text == "" || tbChieuCao.Text == "" || tbSoDienThoai.Text =="" || cbGioiTinh.Text== "")
                {
                    MessageBox.Show("Hay Nhận Đủ thông tin", "sai định dạnh", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    MessageBox.Show("Chỉ Cho Phép Nhập Số  Vào Chiều Cao Và Cân Nặng", "Sai định dạng", MessageBoxButtons.OK);
                    tbChieuCao.Text = "";
                    tbCanNang.Text = "";
                    return false;
                }
            }
            else
            {
                tbChieuCao.Text = a.ToString();
                tbCanNang.Text = b.ToString();
                return true;
            }
        }
        private void addCBox()
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (check_number())
            {
                luuthongtin(tbCanNang.Text, tbChieuCao.Text, dateTimePicker1.Value,cbGioiTinh.Text, tbSoDienThoai.Text, tbDiaChi.Text);
            }

        }

        private void FrmMyInFo_Load(object sender, EventArgs e)
        {
            addCBox();
        }
        private void checkSDT()
        {
            float a;
            bool trya = float.TryParse(tbSoDienThoai.Text, out a);
            if (!trya)
            {
                MessageBox.Show("số điện thoại không được có chữ", "Sai định dạng");
                tbSoDienThoai.Text = "";
            }
            else{
                tbSoDienThoai.Text = a.ToString();
            }

        }
        private void tbSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void luuthongtin(string CanNang, string chieuCao, DateTime  ngaySinh, string gt, string sdt, string diachi)
        {
            MessageBox.Show(" cc", "Sai định dạng");
        }
    }
}
