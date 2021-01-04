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
    public partial class FrmBMI : Form
    {
        double _CanNang, _ChieuCao, _BMI;
        public FrmBMI()
        {
            InitializeComponent();
          //Event();
        }
     /* private void Event();
        {
            txtBMI.ReadOnly = txtDanhGia.ReadOnly = true;
            btnTinhBMI.Click += btnTinhBMI_Click;
            btnTaoLai.Click += btnTaoLai_Click;
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            txtChieuCao.Text = txtCanNang.Text = txtBMI.Text = txtDanhGia.Text = null;
            txtChieuCao.Focus();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void FrmBMI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtChieuCao.Text))
            {
                MessageBox.Show("Vui lòng nhập chiều cao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChieuCao.Focus();
            }
            if(string.IsNullOrEmpty(txtCanNang.Text))
            {
                MessageBox.Show("Vui lòng nhập cân nặng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCanNang.Focus();
            }
            if(!double.TryParse(txtChieuCao.Text,out _ChieuCao))
            {
                MessageBox.Show("Vui lòng nhập chiều cao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChieuCao.Focus();
            }
            if (!double.TryParse(txtCanNang.Text,out _CanNang))
            {
                MessageBox.Show("Vui lòng nhập cân nặng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCanNang.Focus();
            }
            _ChieuCao = double.Parse(txtChieuCao.Text);
            _CanNang = double.Parse(txtCanNang.Text);
            if(_ChieuCao <= 0)
            {
                MessageBox.Show("Vui lòng nhập chiều cao là số nguyên dương lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChieuCao.Focus();
            }
            else if (_CanNang <= 0)
            {
                MessageBox.Show("Vui lòng nhập cân nặng là số nguyên dương lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCanNang.Focus();
            }
            else
            {
                _ChieuCao = _ChieuCao / 100.0;
                _BMI = _CanNang / (Math.Pow(_ChieuCao, 2));
                txtBMI.Text = _BMI.ToString();
                if (_BMI < 18.5)
                {
                    txtDanhGia.Text = "Gầy";
                }
                else if (_BMI >= 18.5 && _BMI <= 24.9)
                {
                    txtDanhGia.Text = "Bình Thường";
                }
                else if (_BMI == 25)
                {
                    txtDanhGia.Text = "Thừa cân";
                }
                else if (_BMI > 25 && _BMI <= 29.9)
                {
                    txtDanhGia.Text = "Tiền béo phì";
                }
                else if (_BMI >= 30 && _BMI <= 34.9)
                {
                    txtDanhGia.Text = "Béo phì loại I";
                }
                else if (_BMI >= 35 && _BMI <= 39.9)
                {
                    txtDanhGia.Text = "Béo phì loại II";
                }
                else
                {
                    txtDanhGia.Text = "Béo phì loại III";
                }
            }
        }
    }
}
